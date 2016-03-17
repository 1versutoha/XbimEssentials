// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.TimeSeriesResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgServiceElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSoundValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSoundValue : IIfcPropertySetDefinition
	{
		IIfcTimeSeries @SoundLevelTimeSeries { get; }
		IfcFrequencyMeasure @Frequency { get; }
		IIfcDerivedMeasureValue @SoundLevelSingleValue { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IfcSoundValue", 266)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSoundValue : IfcPropertySetDefinition, IInstantiableEntity, IIfcSoundValue, IEquatable<@IfcSoundValue>
	{
		#region IIfcSoundValue explicit implementation
		IIfcTimeSeries IIfcSoundValue.SoundLevelTimeSeries { get { return @SoundLevelTimeSeries; } }	
		IfcFrequencyMeasure IIfcSoundValue.Frequency { get { return @Frequency; } }	
		IIfcDerivedMeasureValue IIfcSoundValue.SoundLevelSingleValue { get { return @SoundLevelSingleValue; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSoundValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTimeSeries _soundLevelTimeSeries;
		private IfcFrequencyMeasure _frequency;
		private IfcDerivedMeasureValue _soundLevelSingleValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public IfcTimeSeries @SoundLevelTimeSeries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _soundLevelTimeSeries;
				((IPersistEntity)this).Activate(false);
				return _soundLevelTimeSeries;
			} 
			set
			{
				SetValue( v =>  _soundLevelTimeSeries = v, _soundLevelTimeSeries, value,  "SoundLevelTimeSeries");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcFrequencyMeasure @Frequency 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _frequency;
				((IPersistEntity)this).Activate(false);
				return _frequency;
			} 
			set
			{
				SetValue( v =>  _frequency = v, _frequency, value,  "Frequency");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 10)]
		public IfcDerivedMeasureValue @SoundLevelSingleValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _soundLevelSingleValue;
				((IPersistEntity)this).Activate(false);
				return _soundLevelSingleValue;
			} 
			set
			{
				SetValue( v =>  _soundLevelSingleValue = v, _soundLevelSingleValue, value,  "SoundLevelSingleValue");
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
					_soundLevelTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 5: 
					_frequency = value.RealVal;
					return;
				case 6: 
					_soundLevelSingleValue = (IfcDerivedMeasureValue)(value.EntityVal);
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
        public bool Equals(@IfcSoundValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSoundValue
            var root = (@IfcSoundValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSoundValue left, @IfcSoundValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSoundValue left, @IfcSoundValue right)
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