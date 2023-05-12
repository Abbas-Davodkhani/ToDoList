namespace Domain.Exceptions
{
    public class NotFoundToDoException : Exception
    {
        public NotFoundToDoException(int toDoId)
            : base(message: $"Could't find todo with id : {toDoId}.")
        {

        }
    }
}
