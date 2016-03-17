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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConnectedFaceSet
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectedFaceSet : IIfcTopologicalRepresentationItem
	{
		IEnumerable<IIfcFace> @CfsFaces { get; }
	
	}
}

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IfcConnectedFaceSet", 160)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectedFaceSet : IfcTopologicalRepresentationItem, IInstantiableEntity, IIfcConnectedFaceSet, IEquatable<@IfcConnectedFaceSet>
	{
		#region IIfcConnectedFaceSet explicit implementation
		IEnumerable<IIfcFace> IIfcConnectedFaceSet.CfsFaces { get { return @CfsFaces; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectedFaceSet(IModel model) : base(model) 		{ 
			Model = model; 
			_cfsFaces = new ItemSet<IfcFace>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcFace> _cfsFaces;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 3)]
		public ItemSet<IfcFace> @CfsFaces 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _cfsFaces;
				((IPersistEntity)this).Activate(false);
				return _cfsFaces;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_cfsFaces == null) _cfsFaces = new ItemSet<IfcFace>( this );
					_cfsFaces.InternalAdd((IfcFace)value.EntityVal);
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
        public bool Equals(@IfcConnectedFaceSet other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConnectedFaceSet
            var root = (@IfcConnectedFaceSet)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConnectedFaceSet left, @IfcConnectedFaceSet right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConnectedFaceSet left, @IfcConnectedFaceSet right)
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