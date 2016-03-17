// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationOrganizationResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.RepresentationResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRepresentation
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRepresentation : IPersistEntity, IfcLayeredItem
	{
		IIfcRepresentationContext @ContextOfItems { get; }
		IfcLabel? @RepresentationIdentifier { get; }
		IfcLabel? @RepresentationType { get; }
		IEnumerable<IIfcRepresentationItem> @Items { get; }
		IEnumerable<IIfcRepresentationMap> @RepresentationMap {  get; }
		IEnumerable<IIfcPresentationLayerAssignment> @LayerAssignments {  get; }
		IEnumerable<IIfcProductRepresentation> @OfProductRepresentation {  get; }
	
	}
}

namespace Xbim.Ifc2x3.RepresentationResource
{
	[ExpressType("IfcRepresentation", 87)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRepresentation : INotifyPropertyChanged, IInstantiableEntity, IIfcRepresentation, IEquatable<@IfcRepresentation>
	{
		#region IIfcRepresentation explicit implementation
		IIfcRepresentationContext IIfcRepresentation.ContextOfItems { get { return @ContextOfItems; } }	
		IfcLabel? IIfcRepresentation.RepresentationIdentifier { get { return @RepresentationIdentifier; } }	
		IfcLabel? IIfcRepresentation.RepresentationType { get { return @RepresentationType; } }	
		IEnumerable<IIfcRepresentationItem> IIfcRepresentation.Items { get { return @Items; } }	
		 
		IEnumerable<IIfcRepresentationMap> IIfcRepresentation.RepresentationMap {  get { return @RepresentationMap; } }
		IEnumerable<IIfcPresentationLayerAssignment> IIfcRepresentation.LayerAssignments {  get { return @LayerAssignments; } }
		IEnumerable<IIfcProductRepresentation> IIfcRepresentation.OfProductRepresentation {  get { return @OfProductRepresentation; } }
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRepresentation(IModel model) 		{ 
			Model = model; 
			_items = new ItemSet<IfcRepresentationItem>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcRepresentationContext _contextOfItems;
		private IfcLabel? _representationIdentifier;
		private IfcLabel? _representationType;
		private ItemSet<IfcRepresentationItem> _items;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcRepresentationContext @ContextOfItems 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _contextOfItems;
				((IPersistEntity)this).Activate(false);
				return _contextOfItems;
			} 
			set
			{
				SetValue( v =>  _contextOfItems = v, _contextOfItems, value,  "ContextOfItems");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel? @RepresentationIdentifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _representationIdentifier;
				((IPersistEntity)this).Activate(false);
				return _representationIdentifier;
			} 
			set
			{
				SetValue( v =>  _representationIdentifier = v, _representationIdentifier, value,  "RepresentationIdentifier");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLabel? @RepresentationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _representationType;
				((IPersistEntity)this).Activate(false);
				return _representationType;
			} 
			set
			{
				SetValue( v =>  _representationType = v, _representationType, value,  "RepresentationType");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 4)]
		public ItemSet<IfcRepresentationItem> @Items 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _items;
				((IPersistEntity)this).Activate(false);
				return _items;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MappedRepresentation")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 5)]
		public IEnumerable<IfcRepresentationMap> @RepresentationMap 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRepresentationMap>(e => (e.MappedRepresentation as IfcRepresentation) == this, "MappedRepresentation", this);
			} 
		}
		[InverseProperty("AssignedItems")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 6)]
		public IEnumerable<IfcPresentationLayerAssignment> @LayerAssignments 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPresentationLayerAssignment>(e => e.AssignedItems != null &&  e.AssignedItems.Contains(this), "AssignedItems", this);
			} 
		}
		[InverseProperty("Representations")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 7)]
		public IEnumerable<IfcProductRepresentation> @OfProductRepresentation 
		{ 
			get 
			{
				return Model.Instances.Where<IfcProductRepresentation>(e => e.Representations != null &&  e.Representations.Contains(this), "Representations", this);
			} 
		}
		#endregion

		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_contextOfItems = (IfcRepresentationContext)(value.EntityVal);
					return;
				case 1: 
					_representationIdentifier = value.StringVal;
					return;
				case 2: 
					_representationType = value.StringVal;
					return;
				case 3: 
					if (_items == null) _items = new ItemSet<IfcRepresentationItem>( this );
					_items.InternalAdd((IfcRepresentationItem)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRepresentation other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRepresentation
            var root = (@IfcRepresentation)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRepresentation left, @IfcRepresentation right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRepresentation left, @IfcRepresentation right)
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