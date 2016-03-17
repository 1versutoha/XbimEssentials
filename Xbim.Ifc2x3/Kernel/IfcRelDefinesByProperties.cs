// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDefinesByProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDefinesByProperties : IIfcRelDefines
	{
		IIfcPropertySetDefinition @RelatingPropertyDefinition { get; }
	
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcRelDefinesByProperties", 247)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDefinesByProperties : IfcRelDefines, IInstantiableEntity, IIfcRelDefinesByProperties, IEquatable<@IfcRelDefinesByProperties>
	{
		#region IIfcRelDefinesByProperties explicit implementation
		IIfcPropertySetDefinition IIfcRelDefinesByProperties.RelatingPropertyDefinition { get { return @RelatingPropertyDefinition; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefinesByProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPropertySetDefinition _relatingPropertyDefinition;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcPropertySetDefinition @RelatingPropertyDefinition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingPropertyDefinition;
				((IPersistEntity)this).Activate(false);
				return _relatingPropertyDefinition;
			} 
			set
			{
				SetValue( v =>  _relatingPropertyDefinition = v, _relatingPropertyDefinition, value,  "RelatingPropertyDefinition");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_relatingPropertyDefinition = (IfcPropertySetDefinition)(value.EntityVal);
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
        public bool Equals(@IfcRelDefinesByProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelDefinesByProperties
            var root = (@IfcRelDefinesByProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelDefinesByProperties left, @IfcRelDefinesByProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelDefinesByProperties left, @IfcRelDefinesByProperties right)
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