﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Tue, Jun 16, 2015 00:04+0200 for FHIR v0.5.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A request for referral or transfer of care
    /// </summary>
    [FhirType("ReferralRequest", IsResource=true)]
    [DataContract]
    public partial class ReferralRequest : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ReferralRequest; } }
        [NotMapped]
        public override string TypeName { get { return "ReferralRequest"; } }
        
        /// <summary>
        /// The status of the referral
        /// </summary>
        [FhirEnumeration("ReferralStatus")]
        public enum ReferralStatus
        {
            /// <summary>
            /// A draft referral that has yet to be send
            /// </summary>
            [EnumLiteral("draft")]
            Draft,
            /// <summary>
            /// The referral has been transmitted, but not yet acknowledged by the recipient
            /// </summary>
            [EnumLiteral("requested")]
            Requested,
            /// <summary>
            /// The referral has been acknowledged by the recipient, and is in the process of being actioned
            /// </summary>
            [EnumLiteral("active")]
            Active,
            /// <summary>
            /// The referral has been cancelled without being completed. For example it is no longer needed
            /// </summary>
            [EnumLiteral("cancelled")]
            Cancelled,
            /// <summary>
            /// The recipient has agreed to deliver the care requested by the referral
            /// </summary>
            [EnumLiteral("accepted")]
            Accepted,
            /// <summary>
            /// The recipient has declined to accept the referral
            /// </summary>
            [EnumLiteral("rejected")]
            Rejected,
            /// <summary>
            /// The referral has been completely actioned
            /// </summary>
            [EnumLiteral("completed")]
            Completed,
        }
        
        /// <summary>
        /// draft | requested | active | cancelled | accepted | rejected | completed
        /// </summary>
        [FhirElement("status", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ReferralRequest.ReferralStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ReferralRequest.ReferralStatus> _StatusElement;
        
        /// <summary>
        /// draft | requested | active | cancelled | accepted | rejected | completed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ReferralRequest.ReferralStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ReferralRequest.ReferralStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Identifier of request
        /// </summary>
        [FhirElement("identifier", Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Referral/Transition of care request type
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// The clinical specialty (discipline) that the referral is requested for
        /// </summary>
        [FhirElement("specialty", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Specialty
        {
            get { return _Specialty; }
            set { _Specialty = value; OnPropertyChanged("Specialty"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Specialty;
        
        /// <summary>
        /// Urgency of referral / transfer of care request
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Priority
        {
            get { return _Priority; }
            set { _Priority = value; OnPropertyChanged("Priority"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Priority;
        
        /// <summary>
        /// Patient referred to care or transfer
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=140)]
        [References("Patient")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// Requester of referral / transfer of care
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=150)]
        [References("Practitioner","Organization","Patient")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Requester
        {
            get { return _Requester; }
            set { _Requester = value; OnPropertyChanged("Requester"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Requester;
        
        /// <summary>
        /// Receiver of referral / transfer of care request
        /// </summary>
        [FhirElement("recipient", InSummary=true, Order=160)]
        [References("Practitioner","Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Recipient
        {
            get { if(_Recipient==null) _Recipient = new List<Hl7.Fhir.Model.ResourceReference>(); return _Recipient; }
            set { _Recipient = value; OnPropertyChanged("Recipient"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Recipient;
        
        /// <summary>
        /// Encounter
        /// </summary>
        [FhirElement("encounter", Order=170)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Date referral/transfer of care request is sent
        /// </summary>
        [FhirElement("dateSent", InSummary=true, Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateSentElement
        {
            get { return _DateSentElement; }
            set { _DateSentElement = value; OnPropertyChanged("DateSentElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateSentElement;
        
        /// <summary>
        /// Date referral/transfer of care request is sent
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DateSent
        {
            get { return DateSentElement != null ? DateSentElement.Value : null; }
            set
            {
                if(value == null)
                  DateSentElement = null; 
                else
                  DateSentElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("DateSent");
            }
        }
        
        /// <summary>
        /// Reason for referral / Transfer of care request
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=190)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Reason
        {
            get { return _Reason; }
            set { _Reason = value; OnPropertyChanged("Reason"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Reason;
        
        /// <summary>
        /// A textual description of the referral
        /// </summary>
        [FhirElement("description", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// A textual description of the referral
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// Service(s) requested
        /// </summary>
        [FhirElement("serviceRequested", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ServiceRequested
        {
            get { if(_ServiceRequested==null) _ServiceRequested = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ServiceRequested; }
            set { _ServiceRequested = value; OnPropertyChanged("ServiceRequested"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _ServiceRequested;
        
        /// <summary>
        /// Additonal information to support referral or transfer of care request
        /// </summary>
        [FhirElement("supportingInformation", InSummary=true, Order=220)]
        [References()]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> SupportingInformation
        {
            get { if(_SupportingInformation==null) _SupportingInformation = new List<Hl7.Fhir.Model.ResourceReference>(); return _SupportingInformation; }
            set { _SupportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _SupportingInformation;
        
        /// <summary>
        /// Requested service(s) fulfillment time
        /// </summary>
        [FhirElement("fulfillmentTime", InSummary=true, Order=230)]
        [DataMember]
        public Hl7.Fhir.Model.Period FulfillmentTime
        {
            get { return _FulfillmentTime; }
            set { _FulfillmentTime = value; OnPropertyChanged("FulfillmentTime"); }
        }
        
        private Hl7.Fhir.Model.Period _FulfillmentTime;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ReferralRequest;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ReferralRequest.ReferralStatus>)StatusElement.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(Specialty != null) dest.Specialty = (Hl7.Fhir.Model.CodeableConcept)Specialty.DeepCopy();
                if(Priority != null) dest.Priority = (Hl7.Fhir.Model.CodeableConcept)Priority.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Requester != null) dest.Requester = (Hl7.Fhir.Model.ResourceReference)Requester.DeepCopy();
                if(Recipient != null) dest.Recipient = new List<Hl7.Fhir.Model.ResourceReference>(Recipient.DeepCopy());
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(DateSentElement != null) dest.DateSentElement = (Hl7.Fhir.Model.FhirDateTime)DateSentElement.DeepCopy();
                if(Reason != null) dest.Reason = (Hl7.Fhir.Model.CodeableConcept)Reason.DeepCopy();
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(ServiceRequested != null) dest.ServiceRequested = new List<Hl7.Fhir.Model.CodeableConcept>(ServiceRequested.DeepCopy());
                if(SupportingInformation != null) dest.SupportingInformation = new List<Hl7.Fhir.Model.ResourceReference>(SupportingInformation.DeepCopy());
                if(FulfillmentTime != null) dest.FulfillmentTime = (Hl7.Fhir.Model.Period)FulfillmentTime.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ReferralRequest());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ReferralRequest;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
            if( !DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(DateSentElement, otherT.DateSentElement)) return false;
            if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(ServiceRequested, otherT.ServiceRequested)) return false;
            if( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if( !DeepComparable.Matches(FulfillmentTime, otherT.FulfillmentTime)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ReferralRequest;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
            if( !DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if( !DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(DateSentElement, otherT.DateSentElement)) return false;
            if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(ServiceRequested, otherT.ServiceRequested)) return false;
            if( !DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if( !DeepComparable.IsExactly(FulfillmentTime, otherT.FulfillmentTime)) return false;
            
            return true;
        }
        
    }
    
}
