using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Persictance
{
    public partial class StorageBroker
    {
        public DbSet<ToDo> ToDos { get; set; }

        public async ValueTask<ToDo> InsertToDoAsync(ToDo toDo)
        {
            var broker =
                new StorageBroker(this.configuration);

            EntityEntry<ToDo> ToDoEntityEntry =
                await broker.ToDos.AddAsync(toDo);

            await broker.SaveChangesAsync();

            return ToDoEntityEntry.Entity;
        }

        public IQueryable<ToDo> SelectAllToDos()
        {
            var broker =
                new StorageBroker(this.configuration);

            return broker.ToDos;
        }

        public async ValueTask<ToDo> SelectToDoByIdAsync(int toDoId)
        {
            var broker =
                new StorageBroker(this.configuration);

            return await broker.ToDos.FindAsync(toDoId);
        }

        public async ValueTask<ToDo> UpdateToDoAsync(ToDo toDo)
        {
            var broker =
                new StorageBroker(this.configuration);

            EntityEntry<ToDo> ToDoEntityEntry =
                broker.ToDos.Update(toDo);

            await broker.SaveChangesAsync();

            return ToDoEntityEntry.Entity;
        }

        public async ValueTask<ToDo> DeleteToDoAsync(ToDo toDo)
        {
            var broker =
                new StorageBroker(this.configuration);

            EntityEntry<ToDo> ToDoEntityEntry =
                broker.ToDos.Remove(toDo);

            await broker.SaveChangesAsync();

            return ToDoEntityEntry.Entity;
        }
    }
}
