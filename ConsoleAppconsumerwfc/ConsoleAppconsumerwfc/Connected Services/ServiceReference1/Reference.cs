﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppconsumerwfc.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WcfService1allan")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClassNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
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
        public string ClassName {
            get {
                return this.ClassNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassNameField, value) != true)) {
                    this.ClassNameField = value;
                    this.RaisePropertyChanged("ClassName");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        void AddStudent(int StudentID, string Name, string ClassName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        System.Threading.Tasks.Task AddStudentAsync(int StudentID, string Name, string ClassName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveStudent", ReplyAction="http://tempuri.org/IService1/RemoveStudentResponse")]
        void RemoveStudent(int StudentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveStudent", ReplyAction="http://tempuri.org/IService1/RemoveStudentResponse")]
        System.Threading.Tasks.Task RemoveStudentAsync(int StudentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditStudent", ReplyAction="http://tempuri.org/IService1/EditStudentResponse")]
        void EditStudent(int StudentID, string Name, string ClassName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditStudent", ReplyAction="http://tempuri.org/IService1/EditStudentResponse")]
        System.Threading.Tasks.Task EditStudentAsync(int StudentID, string Name, string ClassName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudents", ReplyAction="http://tempuri.org/IService1/GetAllStudentsResponse")]
        ConsoleAppconsumerwfc.ServiceReference1.Student[] GetAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudents", ReplyAction="http://tempuri.org/IService1/GetAllStudentsResponse")]
        System.Threading.Tasks.Task<ConsoleAppconsumerwfc.ServiceReference1.Student[]> GetAllStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindStudent", ReplyAction="http://tempuri.org/IService1/FindStudentResponse")]
        ConsoleAppconsumerwfc.ServiceReference1.Student FindStudent(int StudentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindStudent", ReplyAction="http://tempuri.org/IService1/FindStudentResponse")]
        System.Threading.Tasks.Task<ConsoleAppconsumerwfc.ServiceReference1.Student> FindStudentAsync(int StudentID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleAppconsumerwfc.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleAppconsumerwfc.ServiceReference1.IService1>, ConsoleAppconsumerwfc.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddStudent(int StudentID, string Name, string ClassName) {
            base.Channel.AddStudent(StudentID, Name, ClassName);
        }
        
        public System.Threading.Tasks.Task AddStudentAsync(int StudentID, string Name, string ClassName) {
            return base.Channel.AddStudentAsync(StudentID, Name, ClassName);
        }
        
        public void RemoveStudent(int StudentID) {
            base.Channel.RemoveStudent(StudentID);
        }
        
        public System.Threading.Tasks.Task RemoveStudentAsync(int StudentID) {
            return base.Channel.RemoveStudentAsync(StudentID);
        }
        
        public void EditStudent(int StudentID, string Name, string ClassName) {
            base.Channel.EditStudent(StudentID, Name, ClassName);
        }
        
        public System.Threading.Tasks.Task EditStudentAsync(int StudentID, string Name, string ClassName) {
            return base.Channel.EditStudentAsync(StudentID, Name, ClassName);
        }
        
        public ConsoleAppconsumerwfc.ServiceReference1.Student[] GetAllStudents() {
            return base.Channel.GetAllStudents();
        }
        
        public System.Threading.Tasks.Task<ConsoleAppconsumerwfc.ServiceReference1.Student[]> GetAllStudentsAsync() {
            return base.Channel.GetAllStudentsAsync();
        }
        
        public ConsoleAppconsumerwfc.ServiceReference1.Student FindStudent(int StudentID) {
            return base.Channel.FindStudent(StudentID);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppconsumerwfc.ServiceReference1.Student> FindStudentAsync(int StudentID) {
            return base.Channel.FindStudentAsync(StudentID);
        }
    }
}
