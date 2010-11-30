﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.4927.
// 
namespace Tripi.TripiWCFService {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_TripiSilverlightWCFService", Namespace="http://tempuri.org/")]
    public partial class TripiSilverlightWCFService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public TripiSilverlightWCFService() {
            this.Url = "http://localhost:1094/TripiSilverlightWCFService.svc";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:TripiSilverlightWCFService/CreateNewTrip", RequestNamespace="", ResponseNamespace="", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateNewTrip([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, out int CreateNewTripResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool CreateNewTripResultSpecified) {
            object[] results = this.Invoke("CreateNewTrip", new object[] {
                        username});
            CreateNewTripResult = ((int)(results[0]));
            CreateNewTripResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCreateNewTrip(string username, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CreateNewTrip", new object[] {
                        username}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndCreateNewTrip(System.IAsyncResult asyncResult, out int CreateNewTripResult, out bool CreateNewTripResultSpecified) {
            object[] results = this.EndInvoke(asyncResult);
            CreateNewTripResult = ((int)(results[0]));
            CreateNewTripResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:TripiSilverlightWCFService/GetTripsForUser", RequestNamespace="", ResponseNamespace="", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/TripiWCF.Service")]
        public Trip[] GetTripsForUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username) {
            object[] results = this.Invoke("GetTripsForUser", new object[] {
                        username});
            return ((Trip[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetTripsForUser(string username, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetTripsForUser", new object[] {
                        username}, callback, asyncState);
        }
        
        /// <remarks/>
        public Trip[] EndGetTripsForUser(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Trip[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:TripiSilverlightWCFService/GetPositionNodesForTrip", RequestNamespace="", ResponseNamespace="", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/TripiWCF.Service")]
        public PositionNode[] GetPositionNodesForTrip(int tripID, [System.Xml.Serialization.XmlIgnoreAttribute()] bool tripIDSpecified) {
            object[] results = this.Invoke("GetPositionNodesForTrip", new object[] {
                        tripID,
                        tripIDSpecified});
            return ((PositionNode[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPositionNodesForTrip(int tripID, bool tripIDSpecified, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPositionNodesForTrip", new object[] {
                        tripID,
                        tripIDSpecified}, callback, asyncState);
        }
        
        /// <remarks/>
        public PositionNode[] EndGetPositionNodesForTrip(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((PositionNode[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:TripiSilverlightWCFService/AddPositionNode", RequestNamespace="", ResponseNamespace="", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddPositionNode([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] PositionNode node) {
            this.Invoke("AddPositionNode", new object[] {
                        node});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddPositionNode(PositionNode node, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddPositionNode", new object[] {
                        node}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndAddPositionNode(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/TripiWCF.Service")]
    public partial class Trip {
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string usernameField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IDSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/TripiWCF.Service")]
    public partial class PositionNode {
        
        private System.DateTime creationTimeField;
        
        private bool creationTimeFieldSpecified;
        
        private double latitudeField;
        
        private bool latitudeFieldSpecified;
        
        private double longitudeField;
        
        private bool longitudeFieldSpecified;
        
        private int tripIDField;
        
        private bool tripIDFieldSpecified;
        
        /// <remarks/>
        public System.DateTime CreationTime {
            get {
                return this.creationTimeField;
            }
            set {
                this.creationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationTimeSpecified {
            get {
                return this.creationTimeFieldSpecified;
            }
            set {
                this.creationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double Latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatitudeSpecified {
            get {
                return this.latitudeFieldSpecified;
            }
            set {
                this.latitudeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LongitudeSpecified {
            get {
                return this.longitudeFieldSpecified;
            }
            set {
                this.longitudeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int TripID {
            get {
                return this.tripIDField;
            }
            set {
                this.tripIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TripIDSpecified {
            get {
                return this.tripIDFieldSpecified;
            }
            set {
                this.tripIDFieldSpecified = value;
            }
        }
    }
}
