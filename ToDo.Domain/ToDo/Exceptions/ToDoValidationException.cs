namespace Domain.Exceptions
{
    public class ToDoValidationException : Exception
    {
        public ToDoValidationException(Exception innerException)
            : base(message: "ToDo validation errors occurred , please try again", innerException)
        {

        }
    }
}
