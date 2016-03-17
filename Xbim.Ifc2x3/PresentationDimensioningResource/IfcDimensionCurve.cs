// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDimensioningResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDimensionCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDimensionCurve : IIfcAnnotationCurveOccurrence
	{
		IEnumerable<IIfcTerminatorSymbol> @AnnotatedBySymbols {  get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IfcDimensionCurve", 742)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDimensionCurve : IfcAnnotationCurveOccurrence, IInstantiableEntity, IIfcDimensionCurve, IEquatable<@IfcDimensionCurve>
	{
		#region IIfcDimensionCurve explicit implementation
		 
		IEnumerable<IIfcTerminatorSymbol> IIfcDimensionCurve.AnnotatedBySymbols {  get { return @AnnotatedBySymbols; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDimensionCurve(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region Inverse attributes
		[InverseProperty("AnnotatedCurve")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 2, 6)]
		public IEnumerable<IfcTerminatorSymbol> @AnnotatedBySymbols 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTerminatorSymbol>(e => (e.AnnotatedCurve as IfcDimensionCurve) == this, "AnnotatedCurve", this);
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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR51:                   >= 1;*/
		/*WR52:                            'IFCTERMINATORSYMBOL.ANNOTATEDCURVE') | (Dct2.Role = IfcDimensionExtentUsage.TARGET))) <= 1);*/
		/*WR53:               = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDimensionCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDimensionCurve
            var root = (@IfcDimensionCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDimensionCurve left, @IfcDimensionCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDimensionCurve left, @IfcDimensionCurve right)
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