// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
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
    /// Readonly interface for IfcTypeProduct
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTypeProduct : IIfcTypeObject
	{
		IEnumerable<IIfcRepresentationMap> @RepresentationMaps { get; }
		IfcLabel? @Tag { get; }
	
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcTypeProduct", 43)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTypeProduct : IfcTypeObject, IInstantiableEntity, IIfcTypeProduct, IEquatable<@IfcTypeProduct>
	{
		#region IIfcTypeProduct explicit implementation
		IEnumerable<IIfcRepresentationMap> IIfcTypeProduct.RepresentationMaps { get { return @RepresentationMaps; } }	
		IfcLabel? IIfcTypeProduct.Tag { get { return @Tag; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeProduct(IModel model) : base(model) 		{ 
			Model = model; 
			_representationMaps = new OptionalItemSet<IfcRepresentationMap>( this, 0 );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcRepresentationMap> _representationMaps;
		private IfcLabel? _tag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 12)]
		public OptionalItemSet<IfcRepresentationMap> @RepresentationMaps 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _representationMaps;
				((IPersistEntity)this).Activate(false);
				return _representationMaps;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public IfcLabel? @Tag 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _tag;
				((IPersistEntity)this).Activate(false);
				return _tag;
			} 
			set
			{
				SetValue( v =>  _tag = v, _tag, value,  "Tag");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					if (_representationMaps == null) _representationMaps = new OptionalItemSet<IfcRepresentationMap>( this );
					_representationMaps.InternalAdd((IfcRepresentationMap)value.EntityVal);
					return;
				case 7: 
					_tag = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:             ) = 0);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTypeProduct other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTypeProduct
            var root = (@IfcTypeProduct)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTypeProduct left, @IfcTypeProduct right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTypeProduct left, @IfcTypeProduct right)
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