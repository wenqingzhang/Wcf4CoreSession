using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TodoWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TodoManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TodoManager.svc or TodoManager.svc.cs at the Solution Explorer and start debugging.
    public class TodoManager : ITodoManager
    {
        public IEnumerable<TodoItem> GetTodoItemsByName(string title)
        {
            using (var db = new TodoContext())
            {
                return db.Todos.Where(t => t.Title.StartsWith(title));
            }
        }

        public IEnumerable<TodoItem> GetTodoItemsByStatus(TodoStatus status)
        {
            using (var db = new TodoContext())
            {
                return db.Todos.Where(t => t.Status == status);
            }
        }

        public TodoItem CreateTodo(string title, TodoStatus status, DateTime? eol)
        {
            using (var db = new TodoContext())
            {
                var todo = db.Todos.Add(new TodoItem()
                {
                    Title = title,
                    Status = status,
                    EoL = eol
                });
                db.SaveChanges();
                return todo;
            }
        }

        public TodoItem UpdateTodo(int id, TodoItem todoItem)
        {
            using (var db = new TodoContext())
            {
                var innerTodo = db.Todos.Find(id);
                if (innerTodo == null)
                {
                    return null;
                }

                innerTodo.Title = todoItem.Title;
                innerTodo.Status = todoItem.Status;
                innerTodo.EoL = todoItem.EoL;

                db.SaveChanges();

                return innerTodo;
            }
        }

        public TodoItem DeleteTodoItem(int id)
        {
            using (var db = new TodoContext())
            {
                var innerTodo = db.Todos.Find(id);
                if (innerTodo == null)
                {
                    return null;
                }

                var removed = db.Todos.Remove(innerTodo);
                db.SaveChanges();

                return removed;
            }
        }
    }
}
