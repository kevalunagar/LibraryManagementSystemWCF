﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_management_system_client.BookServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/Library_Management.models")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EditionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int No_of_Total_CopyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int No_of_Available_CopyField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int Edition {
            get {
                return this.EditionField;
            }
            set {
                if ((this.EditionField.Equals(value) != true)) {
                    this.EditionField = value;
                    this.RaisePropertyChanged("Edition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int No_of_Total_Copy {
            get {
                return this.No_of_Total_CopyField;
            }
            set {
                if ((this.No_of_Total_CopyField.Equals(value) != true)) {
                    this.No_of_Total_CopyField = value;
                    this.RaisePropertyChanged("No_of_Total_Copy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int No_of_Available_Copy {
            get {
                return this.No_of_Available_CopyField;
            }
            set {
                if ((this.No_of_Available_CopyField.Equals(value) != true)) {
                    this.No_of_Available_CopyField = value;
                    this.RaisePropertyChanged("No_of_Available_Copy");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookServiceReference.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooks", ReplyAction="http://tempuri.org/IBookService/GetBooksResponse")]
        Library_management_system_client.BookServiceReference.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooks", ReplyAction="http://tempuri.org/IBookService/GetBooksResponse")]
        System.Threading.Tasks.Task<Library_management_system_client.BookServiceReference.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        Library_management_system_client.BookServiceReference.Book GetBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        System.Threading.Tasks.Task<Library_management_system_client.BookServiceReference.Book> GetBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        void AddBook(Library_management_system_client.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        System.Threading.Tasks.Task AddBookAsync(Library_management_system_client.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        void UpdateBook(Library_management_system_client.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        System.Threading.Tasks.Task UpdateBookAsync(Library_management_system_client.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBook", ReplyAction="http://tempuri.org/IBookService/DeleteBookResponse")]
        void DeleteBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBook", ReplyAction="http://tempuri.org/IBookService/DeleteBookResponse")]
        System.Threading.Tasks.Task DeleteBookAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : Library_management_system_client.BookServiceReference.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<Library_management_system_client.BookServiceReference.IBookService>, Library_management_system_client.BookServiceReference.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Library_management_system_client.BookServiceReference.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<Library_management_system_client.BookServiceReference.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public Library_management_system_client.BookServiceReference.Book GetBook(int id) {
            return base.Channel.GetBook(id);
        }
        
        public System.Threading.Tasks.Task<Library_management_system_client.BookServiceReference.Book> GetBookAsync(int id) {
            return base.Channel.GetBookAsync(id);
        }
        
        public void AddBook(Library_management_system_client.BookServiceReference.Book book) {
            base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task AddBookAsync(Library_management_system_client.BookServiceReference.Book book) {
            return base.Channel.AddBookAsync(book);
        }
        
        public void UpdateBook(Library_management_system_client.BookServiceReference.Book book) {
            base.Channel.UpdateBook(book);
        }
        
        public System.Threading.Tasks.Task UpdateBookAsync(Library_management_system_client.BookServiceReference.Book book) {
            return base.Channel.UpdateBookAsync(book);
        }
        
        public void DeleteBook(int id) {
            base.Channel.DeleteBook(id);
        }
        
        public System.Threading.Tasks.Task DeleteBookAsync(int id) {
            return base.Channel.DeleteBookAsync(id);
        }
    }
}
