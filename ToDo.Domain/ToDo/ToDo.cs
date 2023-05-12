namespace Domain
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ToDoState ToDoState { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public ToDo()
        {
            IsDeleted = false;
            ToDoState = ToDoState.Working;
        }
    }

}
