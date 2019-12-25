using System;
using TodoService;

namespace TodoServiceClient
{
    public class TodoRepo
    {
        private readonly ITodoManager _todoManager;

        public TodoRepo()
        {
            _todoManager = new TodoManagerClient();
        }


        public TodoItem CreateTodo(string title)
        {
            return _todoManager.CreateTodoAsync(title, TodoStatus.Created, null)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }
    }
}
