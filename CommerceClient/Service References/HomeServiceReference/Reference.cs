﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommerceClient.HomeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producttype", Namespace="http://schemas.datacontract.org/2004/07/NewCommerceService")]
    [System.SerializableAttribute()]
    public partial class Producttype : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CommerceClient.HomeServiceReference.Categorytype CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CategoryIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> QuantityAvailableField;
        
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
        public CommerceClient.HomeServiceReference.Categorytype Category {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CategoryID {
            get {
                return this.CategoryIDField;
            }
            set {
                if ((this.CategoryIDField.Equals(value) != true)) {
                    this.CategoryIDField = value;
                    this.RaisePropertyChanged("CategoryID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImagePath {
            get {
                return this.ImagePathField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagePathField, value) != true)) {
                    this.ImagePathField = value;
                    this.RaisePropertyChanged("ImagePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Price {
            get {
                return this.PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceField, value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductDescription {
            get {
                return this.ProductDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductDescriptionField, value) != true)) {
                    this.ProductDescriptionField = value;
                    this.RaisePropertyChanged("ProductDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> QuantityAvailable {
            get {
                return this.QuantityAvailableField;
            }
            set {
                if ((this.QuantityAvailableField.Equals(value) != true)) {
                    this.QuantityAvailableField = value;
                    this.RaisePropertyChanged("QuantityAvailable");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Categorytype", Namespace="http://schemas.datacontract.org/2004/07/NewCommerceService")]
    [System.SerializableAttribute()]
    public partial class Categorytype : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
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
        public int CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImdbEntityType", Namespace="http://schemas.datacontract.org/2004/07/NewCommerceService")]
    [System.SerializableAttribute()]
    public partial class ImdbEntityType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ActorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AwardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LanguageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MetascoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MovieIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReleasedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RuntimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WriterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string YearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imdbRatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imdbVotesField;
        
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
        public string Actors {
            get {
                return this.ActorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ActorsField, value) != true)) {
                    this.ActorsField = value;
                    this.RaisePropertyChanged("Actors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Awards {
            get {
                return this.AwardsField;
            }
            set {
                if ((object.ReferenceEquals(this.AwardsField, value) != true)) {
                    this.AwardsField = value;
                    this.RaisePropertyChanged("Awards");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Director {
            get {
                return this.DirectorField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectorField, value) != true)) {
                    this.DirectorField = value;
                    this.RaisePropertyChanged("Director");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageField, value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Metascore {
            get {
                return this.MetascoreField;
            }
            set {
                if ((object.ReferenceEquals(this.MetascoreField, value) != true)) {
                    this.MetascoreField = value;
                    this.RaisePropertyChanged("Metascore");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MovieID {
            get {
                return this.MovieIDField;
            }
            set {
                if ((this.MovieIDField.Equals(value) != true)) {
                    this.MovieIDField = value;
                    this.RaisePropertyChanged("MovieID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Plot {
            get {
                return this.PlotField;
            }
            set {
                if ((object.ReferenceEquals(this.PlotField, value) != true)) {
                    this.PlotField = value;
                    this.RaisePropertyChanged("Plot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Poster {
            get {
                return this.PosterField;
            }
            set {
                if ((object.ReferenceEquals(this.PosterField, value) != true)) {
                    this.PosterField = value;
                    this.RaisePropertyChanged("Poster");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rated {
            get {
                return this.RatedField;
            }
            set {
                if ((object.ReferenceEquals(this.RatedField, value) != true)) {
                    this.RatedField = value;
                    this.RaisePropertyChanged("Rated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Released {
            get {
                return this.ReleasedField;
            }
            set {
                if ((object.ReferenceEquals(this.ReleasedField, value) != true)) {
                    this.ReleasedField = value;
                    this.RaisePropertyChanged("Released");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Response {
            get {
                return this.ResponseField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseField, value) != true)) {
                    this.ResponseField = value;
                    this.RaisePropertyChanged("Response");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Runtime {
            get {
                return this.RuntimeField;
            }
            set {
                if ((object.ReferenceEquals(this.RuntimeField, value) != true)) {
                    this.RuntimeField = value;
                    this.RaisePropertyChanged("Runtime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Writer {
            get {
                return this.WriterField;
            }
            set {
                if ((object.ReferenceEquals(this.WriterField, value) != true)) {
                    this.WriterField = value;
                    this.RaisePropertyChanged("Writer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Year {
            get {
                return this.YearField;
            }
            set {
                if ((object.ReferenceEquals(this.YearField, value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imdbRating {
            get {
                return this.imdbRatingField;
            }
            set {
                if ((object.ReferenceEquals(this.imdbRatingField, value) != true)) {
                    this.imdbRatingField = value;
                    this.RaisePropertyChanged("imdbRating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imdbVotes {
            get {
                return this.imdbVotesField;
            }
            set {
                if ((object.ReferenceEquals(this.imdbVotesField, value) != true)) {
                    this.imdbVotesField = value;
                    this.RaisePropertyChanged("imdbVotes");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HomeServiceReference.IHomeService")]
    public interface IHomeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService/DisplayAllProducts", ReplyAction="http://tempuri.org/IHomeService/DisplayAllProductsResponse")]
        CommerceClient.HomeServiceReference.Producttype[] DisplayAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService/DisplayAllProducts", ReplyAction="http://tempuri.org/IHomeService/DisplayAllProductsResponse")]
        System.Threading.Tasks.Task<CommerceClient.HomeServiceReference.Producttype[]> DisplayAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService/DisplayProductsByCategory", ReplyAction="http://tempuri.org/IHomeService/DisplayProductsByCategoryResponse")]
        CommerceClient.HomeServiceReference.Producttype[] DisplayProductsByCategory(string CategoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService/DisplayProductsByCategory", ReplyAction="http://tempuri.org/IHomeService/DisplayProductsByCategoryResponse")]
        System.Threading.Tasks.Task<CommerceClient.HomeServiceReference.Producttype[]> DisplayProductsByCategoryAsync(string CategoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService/GetQuantity", ReplyAction="http://tempuri.org/IHomeService/GetQuantityResponse")]
        int GetQuantity(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService/GetQuantity", ReplyAction="http://tempuri.org/IHomeService/GetQuantityResponse")]
        System.Threading.Tasks.Task<int> GetQuantityAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService/GetMovie", ReplyAction="http://tempuri.org/IHomeService/GetMovieResponse")]
        CommerceClient.HomeServiceReference.ImdbEntityType GetMovie(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService/GetMovie", ReplyAction="http://tempuri.org/IHomeService/GetMovieResponse")]
        System.Threading.Tasks.Task<CommerceClient.HomeServiceReference.ImdbEntityType> GetMovieAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHomeServiceChannel : CommerceClient.HomeServiceReference.IHomeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HomeServiceClient : System.ServiceModel.ClientBase<CommerceClient.HomeServiceReference.IHomeService>, CommerceClient.HomeServiceReference.IHomeService {
        
        public HomeServiceClient() {
        }
        
        public HomeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HomeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HomeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HomeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CommerceClient.HomeServiceReference.Producttype[] DisplayAllProducts() {
            return base.Channel.DisplayAllProducts();
        }
        
        public System.Threading.Tasks.Task<CommerceClient.HomeServiceReference.Producttype[]> DisplayAllProductsAsync() {
            return base.Channel.DisplayAllProductsAsync();
        }
        
        public CommerceClient.HomeServiceReference.Producttype[] DisplayProductsByCategory(string CategoryName) {
            return base.Channel.DisplayProductsByCategory(CategoryName);
        }
        
        public System.Threading.Tasks.Task<CommerceClient.HomeServiceReference.Producttype[]> DisplayProductsByCategoryAsync(string CategoryName) {
            return base.Channel.DisplayProductsByCategoryAsync(CategoryName);
        }
        
        public int GetQuantity(string name) {
            return base.Channel.GetQuantity(name);
        }
        
        public System.Threading.Tasks.Task<int> GetQuantityAsync(string name) {
            return base.Channel.GetQuantityAsync(name);
        }
        
        public CommerceClient.HomeServiceReference.ImdbEntityType GetMovie(string name) {
            return base.Channel.GetMovie(name);
        }
        
        public System.Threading.Tasks.Task<CommerceClient.HomeServiceReference.ImdbEntityType> GetMovieAsync(string name) {
            return base.Channel.GetMovieAsync(name);
        }
    }
}
