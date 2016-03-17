// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRectangleProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRectangleProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @XDim { get; }
		IfcPositiveLengthMeasure @YDim { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IfcRectangleProfileDef", 103)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangleProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcRectangleProfileDef, IEquatable<@IfcRectangleProfileDef>
	{
		#region IIfcRectangleProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcRectangleProfileDef.XDim { get { return @XDim; } }	
		IfcPositiveLengthMeasure IIfcRectangleProfileDef.YDim { get { return @YDim; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangleProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _xDim;
		private IfcPositiveLengthMeasure _yDim;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure @XDim 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _xDim;
				((IPersistEntity)this).Activate(false);
				return _xDim;
			} 
			set
			{
				SetValue( v =>  _xDim = v, _xDim, value,  "XDim");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure @YDim 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _yDim;
				((IPersistEntity)this).Activate(false);
				return _yDim;
			} 
			set
			{
				SetValue( v =>  _yDim = v, _yDim, value,  "YDim");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_xDim = value.RealVal;
					return;
				case 4: 
					_yDim = value.RealVal;
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
        public bool Equals(@IfcRectangleProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRectangleProfileDef
            var root = (@IfcRectangleProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRectangleProfileDef left, @IfcRectangleProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRectangleProfileDef left, @IfcRectangleProfileDef right)
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