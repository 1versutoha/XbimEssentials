// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelConnectsPorts
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsPorts : IIfcRelConnects
	{
		IIfcPort @RelatingPort { get; }
		IIfcPort @RelatedPort { get; }
		IIfcElement @RealizingElement { get; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcRelConnectsPorts", 215)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsPorts : IfcRelConnects, IInstantiableEntity, IIfcRelConnectsPorts, IEquatable<@IfcRelConnectsPorts>
	{
		#region IIfcRelConnectsPorts explicit implementation
		IIfcPort IIfcRelConnectsPorts.RelatingPort { get { return @RelatingPort; } }	
		IIfcPort IIfcRelConnectsPorts.RelatedPort { get { return @RelatedPort; } }	
		IIfcElement IIfcRelConnectsPorts.RealizingElement { get { return @RealizingElement; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsPorts(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPort _relatingPort;
		private IfcPort _relatedPort;
		private IfcElement _realizingElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcPort @RelatingPort 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingPort;
				((IPersistEntity)this).Activate(false);
				return _relatingPort;
			} 
			set
			{
				SetValue( v =>  _relatingPort = v, _relatingPort, value,  "RelatingPort");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcPort @RelatedPort 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedPort;
				((IPersistEntity)this).Activate(false);
				return _relatedPort;
			} 
			set
			{
				SetValue( v =>  _relatedPort = v, _relatedPort, value,  "RelatedPort");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcElement @RealizingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _realizingElement;
				((IPersistEntity)this).Activate(false);
				return _realizingElement;
			} 
			set
			{
				SetValue( v =>  _realizingElement = v, _realizingElement, value,  "RealizingElement");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingPort = (IfcPort)(value.EntityVal);
					return;
				case 5: 
					_relatedPort = (IfcPort)(value.EntityVal);
					return;
				case 6: 
					_realizingElement = (IfcElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : RelatingPort :<>: RelatedPort;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsPorts other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelConnectsPorts
            var root = (@IfcRelConnectsPorts)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelConnectsPorts left, @IfcRelConnectsPorts right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelConnectsPorts left, @IfcRelConnectsPorts right)
        {
            return !(left == right);
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}