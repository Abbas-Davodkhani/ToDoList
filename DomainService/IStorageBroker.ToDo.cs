using Domain;

namespace DomainService
{
    public partial interface IStorageBroker
    {
        ValueTask<ToDo> InsertToDoAsync(ToDo toDo);
        IQueryable<ToDo> SelectAllToDos();
        ValueTask<ToDo> SelectToDoByIdAsync(int toDoId);
        ValueTask<ToDo> UpdateToDoAsync(ToDo toDo);
        ValueTask<ToDo> DeleteToDoAsync(ToDo toDo);
    }
}
