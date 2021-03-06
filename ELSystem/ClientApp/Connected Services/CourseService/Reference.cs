﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.CourseService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/ELSystem")]
    [System.SerializableAttribute()]
    public partial class Course : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CurNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberofTabField;
        
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
        public string CurName {
            get {
                return this.CurNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CurNameField, value) != true)) {
                    this.CurNameField = value;
                    this.RaisePropertyChanged("CurName");
                }
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
        public int NumberofTab {
            get {
                return this.NumberofTabField;
            }
            set {
                if ((this.NumberofTabField.Equals(value) != true)) {
                    this.NumberofTabField = value;
                    this.RaisePropertyChanged("NumberofTab");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CourseService.ICourseService")]
    public interface ICourseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Create", ReplyAction="http://tempuri.org/ICourseService/CreateResponse")]
        void Create(ClientApp.CourseService.Course elearnSystem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Create", ReplyAction="http://tempuri.org/ICourseService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(ClientApp.CourseService.Course elearnSystem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetAllCourse", ReplyAction="http://tempuri.org/ICourseService/GetAllCourseResponse")]
        System.Data.DataSet GetAllCourse();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetAllCourse", ReplyAction="http://tempuri.org/ICourseService/GetAllCourseResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllCourseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Update", ReplyAction="http://tempuri.org/ICourseService/UpdateResponse")]
        bool Update(ClientApp.CourseService.Course elearnSystem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Update", ReplyAction="http://tempuri.org/ICourseService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(ClientApp.CourseService.Course elearnSystem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Read", ReplyAction="http://tempuri.org/ICourseService/ReadResponse")]
        ClientApp.CourseService.Course Read(int CurId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Read", ReplyAction="http://tempuri.org/ICourseService/ReadResponse")]
        System.Threading.Tasks.Task<ClientApp.CourseService.Course> ReadAsync(int CurId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Delete", ReplyAction="http://tempuri.org/ICourseService/DeleteResponse")]
        bool Delete(int CurId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Delete", ReplyAction="http://tempuri.org/ICourseService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int CurId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetAllCourseName", ReplyAction="http://tempuri.org/ICourseService/GetAllCourseNameResponse")]
        string[] GetAllCourseName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetAllCourseName", ReplyAction="http://tempuri.org/ICourseService/GetAllCourseNameResponse")]
        System.Threading.Tasks.Task<string[]> GetAllCourseNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCourseId", ReplyAction="http://tempuri.org/ICourseService/GetCourseIdResponse")]
        int GetCourseId(string coursename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCourseId", ReplyAction="http://tempuri.org/ICourseService/GetCourseIdResponse")]
        System.Threading.Tasks.Task<int> GetCourseIdAsync(string coursename);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICourseServiceChannel : ClientApp.CourseService.ICourseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CourseServiceClient : System.ServiceModel.ClientBase<ClientApp.CourseService.ICourseService>, ClientApp.CourseService.ICourseService {
        
        public CourseServiceClient() {
        }
        
        public CourseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CourseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(ClientApp.CourseService.Course elearnSystem) {
            base.Channel.Create(elearnSystem);
        }
        
        public System.Threading.Tasks.Task CreateAsync(ClientApp.CourseService.Course elearnSystem) {
            return base.Channel.CreateAsync(elearnSystem);
        }
        
        public System.Data.DataSet GetAllCourse() {
            return base.Channel.GetAllCourse();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllCourseAsync() {
            return base.Channel.GetAllCourseAsync();
        }
        
        public bool Update(ClientApp.CourseService.Course elearnSystem) {
            return base.Channel.Update(elearnSystem);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(ClientApp.CourseService.Course elearnSystem) {
            return base.Channel.UpdateAsync(elearnSystem);
        }
        
        public ClientApp.CourseService.Course Read(int CurId) {
            return base.Channel.Read(CurId);
        }
        
        public System.Threading.Tasks.Task<ClientApp.CourseService.Course> ReadAsync(int CurId) {
            return base.Channel.ReadAsync(CurId);
        }
        
        public bool Delete(int CurId) {
            return base.Channel.Delete(CurId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int CurId) {
            return base.Channel.DeleteAsync(CurId);
        }
        
        public string[] GetAllCourseName() {
            return base.Channel.GetAllCourseName();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllCourseNameAsync() {
            return base.Channel.GetAllCourseNameAsync();
        }
        
        public int GetCourseId(string coursename) {
            return base.Channel.GetCourseId(coursename);
        }
        
        public System.Threading.Tasks.Task<int> GetCourseIdAsync(string coursename) {
            return base.Channel.GetCourseIdAsync(coursename);
        }
    }
}
