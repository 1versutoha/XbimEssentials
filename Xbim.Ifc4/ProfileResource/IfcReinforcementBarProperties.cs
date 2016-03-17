// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcementBarProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcementBarProperties : IIfcPreDefinedProperties
	{
		IfcAreaMeasure @TotalCrossSectionArea { get; }
		IfcLabel @SteelGrade { get; }
		IfcReinforcingBarSurfaceEnum? @BarSurface { get; }
		IfcLengthMeasure? @EffectiveDepth { get; }
		IfcPositiveLengthMeasure? @NominalBarDiameter { get; }
		IfcCountMeasure? @BarCount { get; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IfcReinforcementBarProperties", 684)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcementBarProperties : IfcPreDefinedProperties, IInstantiableEntity, IIfcReinforcementBarProperties, IEquatable<@IfcReinforcementBarProperties>
	{
		#region IIfcReinforcementBarProperties explicit implementation
		IfcAreaMeasure IIfcReinforcementBarProperties.TotalCrossSectionArea { get { return @TotalCrossSectionArea; } }	
		IfcLabel IIfcReinforcementBarProperties.SteelGrade { get { return @SteelGrade; } }	
		IfcReinforcingBarSurfaceEnum? IIfcReinforcementBarProperties.BarSurface { get { return @BarSurface; } }	
		IfcLengthMeasure? IIfcReinforcementBarProperties.EffectiveDepth { get { return @EffectiveDepth; } }	
		IfcPositiveLengthMeasure? IIfcReinforcementBarProperties.NominalBarDiameter { get { return @NominalBarDiameter; } }	
		IfcCountMeasure? IIfcReinforcementBarProperties.BarCount { get { return @BarCount; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcementBarProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAreaMeasure _totalCrossSectionArea;
		private IfcLabel _steelGrade;
		private IfcReinforcingBarSurfaceEnum? _barSurface;
		private IfcLengthMeasure? _effectiveDepth;
		private IfcPositiveLengthMeasure? _nominalBarDiameter;
		private IfcCountMeasure? _barCount;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcAreaMeasure @TotalCrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _totalCrossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _totalCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _totalCrossSectionArea = v, _totalCrossSectionArea, value,  "TotalCrossSectionArea");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLabel @SteelGrade 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _steelGrade;
				((IPersistEntity)this).Activate(false);
				return _steelGrade;
			} 
			set
			{
				SetValue( v =>  _steelGrade = v, _steelGrade, value,  "SteelGrade");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 4)]
		public IfcReinforcingBarSurfaceEnum? @BarSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barSurface;
				((IPersistEntity)this).Activate(false);
				return _barSurface;
			} 
			set
			{
				SetValue( v =>  _barSurface = v, _barSurface, value,  "BarSurface");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcLengthMeasure? @EffectiveDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _effectiveDepth;
				((IPersistEntity)this).Activate(false);
				return _effectiveDepth;
			} 
			set
			{
				SetValue( v =>  _effectiveDepth = v, _effectiveDepth, value,  "EffectiveDepth");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure? @NominalBarDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _nominalBarDiameter;
				((IPersistEntity)this).Activate(false);
				return _nominalBarDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalBarDiameter = v, _nominalBarDiameter, value,  "NominalBarDiameter");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcCountMeasure? @BarCount 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barCount;
				((IPersistEntity)this).Activate(false);
				return _barCount;
			} 
			set
			{
				SetValue( v =>  _barCount = v, _barCount, value,  "BarCount");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_totalCrossSectionArea = value.RealVal;
					return;
				case 1: 
					_steelGrade = value.StringVal;
					return;
				case 2: 
                    _barSurface = (IfcReinforcingBarSurfaceEnum) System.Enum.Parse(typeof (IfcReinforcingBarSurfaceEnum), value.EnumVal, true);
					return;
				case 3: 
					_effectiveDepth = value.RealVal;
					return;
				case 4: 
					_nominalBarDiameter = value.RealVal;
					return;
				case 5: 
					_barCount = value.NumberVal;
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
        public bool Equals(@IfcReinforcementBarProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcReinforcementBarProperties
            var root = (@IfcReinforcementBarProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcReinforcementBarProperties left, @IfcReinforcementBarProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcReinforcementBarProperties left, @IfcReinforcementBarProperties right)
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