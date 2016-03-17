// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialProfile
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialProfile : IIfcMaterialDefinition
	{
		IfcLabel? @Name { get; }
		IfcText? @Description { get; }
		IIfcMaterial @Material { get; }
		IIfcProfileDef @Profile { get; }
		IfcInteger? @Priority { get; }
		IfcLabel? @Category { get; }
		IIfcMaterialProfileSet @ToMaterialProfileSet {  get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialProfile", 1205)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfile : IfcMaterialDefinition, IInstantiableEntity, IIfcMaterialProfile, IEquatable<@IfcMaterialProfile>
	{
		#region IIfcMaterialProfile explicit implementation
		IfcLabel? IIfcMaterialProfile.Name { get { return @Name; } }	
		IfcText? IIfcMaterialProfile.Description { get { return @Description; } }	
		IIfcMaterial IIfcMaterialProfile.Material { get { return @Material; } }	
		IIfcProfileDef IIfcMaterialProfile.Profile { get { return @Profile; } }	
		IfcInteger? IIfcMaterialProfile.Priority { get { return @Priority; } }	
		IfcLabel? IIfcMaterialProfile.Category { get { return @Category; } }	
		 
		IIfcMaterialProfileSet IIfcMaterialProfile.ToMaterialProfileSet {  get { return @ToMaterialProfileSet; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfile(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcMaterial _material;
		private IfcProfileDef _profile;
		private IfcInteger? _priority;
		private IfcLabel? _category;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcMaterial @Material 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _material;
				((IPersistEntity)this).Activate(false);
				return _material;
			} 
			set
			{
				SetValue( v =>  _material = v, _material, value,  "Material");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcProfileDef @Profile 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _profile;
				((IPersistEntity)this).Activate(false);
				return _profile;
			} 
			set
			{
				SetValue( v =>  _profile = v, _profile, value,  "Profile");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcInteger? @Priority 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _priority;
				((IPersistEntity)this).Activate(false);
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _category;
				((IPersistEntity)this).Activate(false);
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MaterialProfiles")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 10)]
		public IfcMaterialProfileSet @ToMaterialProfileSet 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcMaterialProfileSet>(e => e.MaterialProfiles != null &&  e.MaterialProfiles.Contains(this), "MaterialProfiles", this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_material = (IfcMaterial)(value.EntityVal);
					return;
				case 3: 
					_profile = (IfcProfileDef)(value.EntityVal);
					return;
				case 4: 
					_priority = value.IntegerVal;
					return;
				case 5: 
					_category = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NormalizedPriority:	NormalizedPriority : NOT(EXISTS(Priority)) OR {0 <= Priority <= 100};*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialProfile other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialProfile
            var root = (@IfcMaterialProfile)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialProfile left, @IfcMaterialProfile right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialProfile left, @IfcMaterialProfile right)
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