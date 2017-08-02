using Akka.Actor;

namespace WinTail
{
    internal class ValidationActor : UntypedActor
    {
        private readonly IActorRef _consoleWriteActor;

        public ValidationActor(IActorRef consoleWriteActor)
        {
            _consoleWriteActor = consoleWriteActor;
        }
        
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case string msg when string.IsNullOrEmpty(msg):
                    _consoleWriteActor.Tell(new Messages.NullInputError("No input received."));
                    break;
                case string msg:
                    var valid = IsValid(msg);

                    _consoleWriteActor.Tell(
                        valid 
                            ? (object) new Messages.InputSuccess("Thank you! Message was valid.") 
                            : new Messages.ValidationError("Invalid: input had odd number of characters.")
                        );
                    break;                    
            }
            
            Sender.Tell(new Messages.ContinueProcessing());
        }
        
        /// <summary>
        /// Validates <see cref="message"/>.
        /// Currently says messages are valid if contain even number of characters.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static bool IsValid(string message)
        {
            var valid = message.Length % 2 == 0;
            return valid;
        }
    }
}