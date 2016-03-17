// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcHalfSpaceSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcHalfSpaceSolid : IIfcGeometricRepresentationItem, IfcBooleanOperand
	{
		IIfcSurface @BaseSurface { get; }
		IfcBoolean @AgreementFlag { get; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcHalfSpaceSolid", 338)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcHalfSpaceSolid : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcHalfSpaceSolid, IEquatable<@IfcHalfSpaceSolid>
	{
		#region IIfcHalfSpaceSolid explicit implementation
		IIfcSurface IIfcHalfSpaceSolid.BaseSurface { get { return @BaseSurface; } }	
		IfcBoolean IIfcHalfSpaceSolid.AgreementFlag { get { return @AgreementFlag; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcHalfSpaceSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurface _baseSurface;
		private IfcBoolean _agreementFlag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcSurface @BaseSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseSurface;
				((IPersistEntity)this).Activate(false);
				return _baseSurface;
			} 
			set
			{
				SetValue( v =>  _baseSurface = v, _baseSurface, value,  "BaseSurface");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcBoolean @AgreementFlag 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _agreementFlag;
				((IPersistEntity)this).Activate(false);
				return _agreementFlag;
			} 
			set
			{
				SetValue( v =>  _agreementFlag = v, _agreementFlag, value,  "AgreementFlag");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return 3;
			    //##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_baseSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_agreementFlag = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcHalfSpaceSolid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcHalfSpaceSolid
            var root = (@IfcHalfSpaceSolid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcHalfSpaceSolid left, @IfcHalfSpaceSolid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcHalfSpaceSolid left, @IfcHalfSpaceSolid right)
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