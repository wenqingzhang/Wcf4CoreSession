using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TodoWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITodoManager
    {
        [OperationContract]
        TodoItem CreateTodo(string title, TodoStatus status, DateTime? eol);

        [OperationContract]
        TodoItem UpdateTodo(int id, TodoItem todoItem);

        [OperationContract]
        IEnumerable<TodoItem> GetTodoItemsByName(string title);

        [OperationContract]
        IEnumerable<TodoItem> GetTodoItemsByStatus(TodoStatus status);

        [OperationContract]
        TodoItem DeleteTodoItem(int id);
    }

    public enum TodoStatus
    {
        Created = 0,
        Uncompleted = 1,
        Completed = 2
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class TodoItem
    {
        [DataMember] public int Id { get; set; }

        [DataMember] public string Title { get; set; }

        [DataMember] public TodoStatus Status { get; set; }

        [DataMember] public DateTime? EoL { get; set; }
    }
}