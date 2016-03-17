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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ExternalReferenceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcClassificationItem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcClassificationItem : IPersistEntity
	{
		IIfcClassificationNotationFacet @Notation { get; }
		IIfcClassification @ItemOf { get; }
		IfcLabel @Title { get; }
		IEnumerable<IIfcClassificationItemRelationship> @IsClassifiedItemIn {  get; }
		IEnumerable<IIfcClassificationItemRelationship> @IsClassifyingItemIn {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[ExpressType("IfcClassificationItem", 14)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationItem : INotifyPropertyChanged, IInstantiableEntity, IIfcClassificationItem, IEquatable<@IfcClassificationItem>
	{
		#region IIfcClassificationItem explicit implementation
		IIfcClassificationNotationFacet IIfcClassificationItem.Notation { get { return @Notation; } }	
		IIfcClassification IIfcClassificationItem.ItemOf { get { return @ItemOf; } }	
		IfcLabel IIfcClassificationItem.Title { get { return @Title; } }	
		 
		IEnumerable<IIfcClassificationItemRelationship> IIfcClassificationItem.IsClassifiedItemIn {  get { return @IsClassifiedItemIn; } }
		IEnumerable<IIfcClassificationItemRelationship> IIfcClassificationItem.IsClassifyingItemIn {  get { return @IsClassifyingItemIn; } }
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
		internal IfcClassificationItem(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcClassificationNotationFacet _notation;
		private IfcClassification _itemOf;
		private IfcLabel _title;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcClassificationNotationFacet @Notation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _notation;
				((IPersistEntity)this).Activate(false);
				return _notation;
			} 
			set
			{
				SetValue( v =>  _notation = v, _notation, value,  "Notation");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcClassification @ItemOf 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _itemOf;
				((IPersistEntity)this).Activate(false);
				return _itemOf;
			} 
			set
			{
				SetValue( v =>  _itemOf = v, _itemOf, value,  "ItemOf");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLabel @Title 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _title;
				((IPersistEntity)this).Activate(false);
				return _title;
			} 
			set
			{
				SetValue( v =>  _title = v, _title, value,  "Title");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedItems")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 4)]
		public IEnumerable<IfcClassificationItemRelationship> @IsClassifiedItemIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationItemRelationship>(e => e.RelatedItems != null &&  e.RelatedItems.Contains(this), "RelatedItems", this);
			} 
		}
		[InverseProperty("RelatingItem")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 5)]
		public IEnumerable<IfcClassificationItemRelationship> @IsClassifyingItemIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationItemRelationship>(e => (e.RelatingItem as IfcClassificationItem) == this, "RelatingItem", this);
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
					_notation = (IfcClassificationNotationFacet)(value.EntityVal);
					return;
				case 1: 
					_itemOf = (IfcClassification)(value.EntityVal);
					return;
				case 2: 
					_title = value.StringVal;
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
        public bool Equals(@IfcClassificationItem other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcClassificationItem
            var root = (@IfcClassificationItem)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcClassificationItem left, @IfcClassificationItem right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcClassificationItem left, @IfcClassificationItem right)
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