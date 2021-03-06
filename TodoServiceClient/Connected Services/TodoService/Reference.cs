﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TodoService
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TodoStatus", Namespace="http://schemas.datacontract.org/2004/07/TodoWcfService")]
    public enum TodoStatus : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Created = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Uncompleted = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Completed = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TodoItem", Namespace="http://schemas.datacontract.org/2004/07/TodoWcfService")]
    public partial class TodoItem : object
    {
        
        private System.Nullable<System.DateTime> EoLField;
        
        private int IdField;
        
        private TodoService.TodoStatus StatusField;
        
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EoL
        {
            get
            {
                return this.EoLField;
            }
            set
            {
                this.EoLField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TodoService.TodoStatus Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TodoService.ITodoManager")]
    public interface ITodoManager
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITodoManager/CreateTodo", ReplyAction="http://tempuri.org/ITodoManager/CreateTodoResponse")]
        System.Threading.Tasks.Task<TodoService.TodoItem> CreateTodoAsync(string title, TodoService.TodoStatus status, System.Nullable<System.DateTime> eol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITodoManager/UpdateTodo", ReplyAction="http://tempuri.org/ITodoManager/UpdateTodoResponse")]
        System.Threading.Tasks.Task<TodoService.TodoItem> UpdateTodoAsync(int id, TodoService.TodoItem todoItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITodoManager/GetTodoItemsByName", ReplyAction="http://tempuri.org/ITodoManager/GetTodoItemsByNameResponse")]
        System.Threading.Tasks.Task<TodoService.TodoItem[]> GetTodoItemsByNameAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITodoManager/GetTodoItemsByStatus", ReplyAction="http://tempuri.org/ITodoManager/GetTodoItemsByStatusResponse")]
        System.Threading.Tasks.Task<TodoService.TodoItem[]> GetTodoItemsByStatusAsync(TodoService.TodoStatus status);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ITodoManager/DeleteTodoItem", ReplyAction = "http://tempuri.org/ITodoManager/DeleteTodoItemStatusResponse")]
        System.Threading.Tasks.Task<TodoService.TodoItem> DeleteTodoItemAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ITodoManagerChannel : TodoService.ITodoManager, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class TodoManagerClient : System.ServiceModel.ClientBase<TodoService.ITodoManager>, TodoService.ITodoManager
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public TodoManagerClient() : 
                base(TodoManagerClient.GetDefaultBinding(), TodoManagerClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ITodoManager.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TodoManagerClient(EndpointConfiguration endpointConfiguration) : 
                base(TodoManagerClient.GetBindingForEndpoint(endpointConfiguration), TodoManagerClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TodoManagerClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(TodoManagerClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TodoManagerClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(TodoManagerClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TodoManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<TodoService.TodoItem> CreateTodoAsync(string title, TodoService.TodoStatus status, System.Nullable<System.DateTime> eol)
        {
            return base.Channel.CreateTodoAsync(title, status, eol);
        }
        
        public System.Threading.Tasks.Task<TodoService.TodoItem> UpdateTodoAsync(int id, TodoService.TodoItem todoItem)
        {
            return base.Channel.UpdateTodoAsync(id, todoItem);
        }
        
        public System.Threading.Tasks.Task<TodoService.TodoItem[]> GetTodoItemsByNameAsync(string title)
        {
            return base.Channel.GetTodoItemsByNameAsync(title);
        }
        
        public System.Threading.Tasks.Task<TodoService.TodoItem[]> GetTodoItemsByStatusAsync(TodoService.TodoStatus status)
        {
            return base.Channel.GetTodoItemsByStatusAsync(status);
        }

        public System.Threading.Tasks.Task<TodoService.TodoItem> DeleteTodoItemAsync(int id)
        {
            return base.Channel.DeleteTodoItemAsync(id);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ITodoManager))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ITodoManager))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:30373/TodoManager.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return TodoManagerClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ITodoManager);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return TodoManagerClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ITodoManager);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ITodoManager,
        }
    }
}
