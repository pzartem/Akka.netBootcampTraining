using System.IO;
using Akka.Actor;

namespace WinTail
{
    internal class FileValidatorActor : UntypedActor
    {
        private readonly IActorRef _consoleWriteActor;
        
        public FileValidatorActor(IActorRef consoleWriteActor)
        {
            _consoleWriteActor = consoleWriteActor;
        }
        
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case string msg when string.IsNullOrEmpty(msg):
                    _consoleWriteActor.Tell(new Messages.NullInputError("Input was blank." +
                                                                        "Please try again.\n"));
                    
                    Sender.Tell(new Messages.ContinueProcessing());

                    break;
                case string msg:
                    var valid = IsFileUri(msg);
                    
                    if (valid)
                    {
                        // signal successful input
                        _consoleWriteActor.Tell(new Messages.InputSuccess(
                            $"Starting processing for {msg}"));

                        Context.ActorSelection("akka://MyActorSystem/user/tailCoordinatorActor").Tell(
                            new TailCoordinatorActor.StartTail(msg, _consoleWriteActor));
                    }
                    else
                    {
                        // signal that input was bad
                        _consoleWriteActor.Tell(
                            new Messages.ValidationError(
                               $"{msg} is not an existing URI on disk.")
                            );

                        // tell sender to continue doing its thing (whatever that
                        // may be, this actor doesn't care)
                        Sender.Tell(new Messages.ContinueProcessing());
                    }
                    break;                    
            }
            
        }
        
        /// <summary>
        /// Checks if file exists at path provided by user.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static bool IsFileUri(string path)
        {
            return File.Exists(path);
        }
    }
}