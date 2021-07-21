// <auto-generated/>
// Contents of: hl7.fhir.r3.core version: 3.0.2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

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

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// Text node with attribution
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Annotation","http://hl7.org/fhir/StructureDefinition/Annotation")]
  public partial class Annotation : Hl7.Fhir.Model.DataType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Annotation"; } }

    /// <summary>
    /// Individual responsible for the annotation
    /// </summary>
    [FhirElement("author", InSummary=true, Order=30, Choice=ChoiceType.DatatypeChoice)]
    [CLSCompliant(false)]
    [References("Practitioner","Patient","RelatedPerson")]
    [AllowedTypes(typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.FhirString))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Author
    {
      get { return _Author; }
      set { _Author = value; OnPropertyChanged("Author"); }
    }

    private Hl7.Fhir.Model.DataType _Author;

    /// <summary>
    /// When the annotation was made
    /// </summary>
    [FhirElement("time", InSummary=true, Order=40)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime TimeElement
    {
      get { return _TimeElement; }
      set { _TimeElement = value; OnPropertyChanged("TimeElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _TimeElement;

    /// <summary>
    /// When the annotation was made
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Time
    {
      get { return TimeElement != null ? TimeElement.Value : null; }
      set
      {
        if (value == null)
          TimeElement = null;
        else
          TimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Time");
      }
    }

    /// <summary>
    /// The annotation  - text content
    /// </summary>
    [FhirElement("text", Order=50)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString TextElement
    {
      get { return _TextElement; }
      set { _TextElement = value; OnPropertyChanged("TextElement"); }
    }

    private Hl7.Fhir.Model.FhirString _TextElement;

    /// <summary>
    /// The annotation  - text content
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Text
    {
      get { return TextElement != null ? TextElement.Value : null; }
      set
      {
        if (value == null)
          TextElement = null;
        else
          TextElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Text");
      }
    }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Annotation;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Author != null) dest.Author = (Hl7.Fhir.Model.DataType)Author.DeepCopy();
      if(TimeElement != null) dest.TimeElement = (Hl7.Fhir.Model.FhirDateTime)TimeElement.DeepCopy();
      if(TextElement != null) dest.TextElement = (Hl7.Fhir.Model.FhirString)TextElement.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Annotation());
    }

    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Annotation;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Author, otherT.Author)) return false;
      if( !DeepComparable.Matches(TimeElement, otherT.TimeElement)) return false;
      if( !DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Annotation;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Author, otherT.Author)) return false;
      if( !DeepComparable.IsExactly(TimeElement, otherT.TimeElement)) return false;
      if( !DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (Author != null) yield return Author;
        if (TimeElement != null) yield return TimeElement;
        if (TextElement != null) yield return TextElement;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (Author != null) yield return new ElementValue("author", Author);
        if (TimeElement != null) yield return new ElementValue("time", TimeElement);
        if (TextElement != null) yield return new ElementValue("text", TextElement);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "author":
          value = Author;
          return Author is not null;
        case "time":
          value = TimeElement;
          return TimeElement is not null;
        case "text":
          value = TextElement;
          return TextElement is not null;
        default:
          return choiceMatches(out value);
      };

      bool choiceMatches(out object value)
      {
        if (key.StartsWith("author"))
        {
          value = Author;
          return Author is not null && ElementName.HasCorrectSuffix(key, "author", Author.TypeName);
        }
        return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Author is not null) yield return new KeyValuePair<string,object>(ElementName.AddSuffixToElementName("author", Author),Author);
      if (TimeElement is not null) yield return new KeyValuePair<string,object>("time",TimeElement);
      if (TextElement is not null) yield return new KeyValuePair<string,object>("text",TextElement);
    }

  }

}

// end of file
