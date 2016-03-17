// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedComponentElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcEdgeFeature
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcEdgeFeature : IIfcFeatureElementSubtraction
	{
		IfcPositiveLengthMeasure? @FeatureLength { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedComponentElements
{
	[ExpressType("IfcEdgeFeature", 764)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcEdgeFeature : IfcFeatureElementSubtraction, IIfcEdgeFeature, IEquatable<@IfcEdgeFeature>
	{
		#region IIfcEdgeFeature explicit implementation
		IfcPositiveLengthMeasure? IIfcEdgeFeature.FeatureLength { get { return @FeatureLength; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEdgeFeature(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _featureLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 28)]
		public IfcPositiveLengthMeasure? @FeatureLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _featureLength;
				((IPersistEntity)this).Activate(false);
				return _featureLength;
			} 
			set
			{
				SetValue( v =>  _featureLength = v, _featureLength, value,  "FeatureLength");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_featureLength = value.RealVal;
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
        public bool Equals(@IfcEdgeFeature other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcEdgeFeature
            var root = (@IfcEdgeFeature)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcEdgeFeature left, @IfcEdgeFeature right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEdgeFeature left, @IfcEdgeFeature right)
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