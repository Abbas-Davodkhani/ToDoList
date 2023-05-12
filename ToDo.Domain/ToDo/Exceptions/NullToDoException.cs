namespace Domain.Exceptions
{
    public class NullToDoException : Exception
    {
        public NullToDoException()
            :base(message : "ToDo is null")
        {
            
        }
    }
}
