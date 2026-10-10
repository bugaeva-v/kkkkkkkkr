using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000113 RID: 275
	public abstract class DictionaryAdapterBase : IDictionaryCreate, IDictionaryAdapter, IDictionaryEdit, IEditableObject, IRevertibleChangeTracking, IChangeTracking, IDictionaryNotify, INotifyPropertyChanging, INotifyPropertyChanged, IDictionaryValidate, IDataErrorInfo
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x00013C99 File Offset: 0x00011E99
		public T Coerce<T>() where T : class
		{
			return (T)((object)this.Coerce(typeof(T)));
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00013CB0 File Offset: 0x00011EB0
		public object Coerce(Type type)
		{
			if (type.IsAssignableFrom(this.Meta.Type))
			{
				return this;
			}
			if (this.This.CoerceStrategy != null)
			{
				object obj = this.This.CoerceStrategy.Coerce(this, type);
				if (obj != null)
				{
					return obj;
				}
			}
			return this.This.Factory.GetAdapter(type, this.This.Dictionary, this.This.Descriptor);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00013D1E File Offset: 0x00011F1E
		public void CopyTo(IDictionaryAdapter other)
		{
			this.CopyTo(other, null);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00013D28 File Offset: 0x00011F28
		public void CopyTo(IDictionaryAdapter other, Func<PropertyDescriptor, bool> selector)
		{
			DictionaryAdapterBase.<>c__DisplayClass3_0 CS$<>8__locals1 = new DictionaryAdapterBase.<>c__DisplayClass3_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.other = other;
			CS$<>8__locals1.selector = selector;
			if (this == CS$<>8__locals1.other)
			{
				return;
			}
			if (!CS$<>8__locals1.other.Meta.Type.IsAssignableFrom(this.Meta.Type))
			{
				throw new ArgumentException(string.Format("Unable to copy to {0}.  The type must be assignable from {1}.", CS$<>8__locals1.other.Meta.Type.FullName, this.Meta.Type.FullName));
			}
			if (this.This.CopyStrategies.Aggregate(false, (bool copied, IDictionaryCopyStrategy s) => copied | s.Copy(CS$<>8__locals1.<>4__this, CS$<>8__locals1.other, ref CS$<>8__locals1.selector)))
			{
				return;
			}
			DictionaryAdapterBase.<>c__DisplayClass3_0 CS$<>8__locals2 = CS$<>8__locals1;
			Func<PropertyDescriptor, bool> selector2;
			if ((selector2 = CS$<>8__locals1.selector) == null && (selector2 = DictionaryAdapterBase.<>c.<>9__3_1) == null)
			{
				selector2 = (DictionaryAdapterBase.<>c.<>9__3_1 = ((PropertyDescriptor property) => true));
			}
			CS$<>8__locals2.selector = selector2;
			IEnumerable<PropertyDescriptor> values = this.This.Properties.Values;
			Func<PropertyDescriptor, bool> predicate;
			if ((predicate = CS$<>8__locals1.<>9__2) == null)
			{
				predicate = (CS$<>8__locals1.<>9__2 = ((PropertyDescriptor property) => CS$<>8__locals1.selector(property)));
			}
			foreach (PropertyDescriptor propertyDescriptor in values.Where(predicate))
			{
				object property2 = this.GetProperty(propertyDescriptor.PropertyName, true);
				CS$<>8__locals1.other.SetProperty(propertyDescriptor.PropertyName, ref property2);
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00013E8C File Offset: 0x0001208C
		public T Create<T>()
		{
			return this.Create<T>(new HybridDictionary());
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00013E99 File Offset: 0x00012099
		public object Create(Type type)
		{
			return this.Create(type, new HybridDictionary());
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00013EA7 File Offset: 0x000120A7
		public T Create<T>(IDictionary dictionary)
		{
			return (T)((object)this.Create(typeof(T), dictionary ?? new HybridDictionary()));
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00013EC8 File Offset: 0x000120C8
		public object Create(Type type, IDictionary dictionary)
		{
			if (this.This.CreateStrategy != null)
			{
				object obj = this.This.CreateStrategy.Create(this, type, dictionary);
				if (obj != null)
				{
					return obj;
				}
			}
			dictionary = (dictionary ?? new HybridDictionary());
			return this.This.Factory.GetAdapter(type, dictionary, this.This.Descriptor);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00013F24 File Offset: 0x00012124
		public T Create<T>(Action<T> init)
		{
			return this.Create<T>(new HybridDictionary(), init);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00013F34 File Offset: 0x00012134
		public T Create<T>(IDictionary dictionary, Action<T> init)
		{
			T t = this.Create<T>(dictionary ?? new HybridDictionary());
			if (init != null)
			{
				init(t);
			}
			return t;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00013F60 File Offset: 0x00012160
		public DictionaryAdapterBase(DictionaryAdapterInstance instance)
		{
			this.This = instance;
			this.CanEdit = typeof(IEditableObject).IsAssignableFrom(this.Meta.Type);
			this.CanNotify = typeof(INotifyPropertyChanged).IsAssignableFrom(this.Meta.Type);
			this.CanValidate = typeof(IDataErrorInfo).IsAssignableFrom(this.Meta.Type);
			this.Initialize();
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600072B RID: 1835
		public abstract DictionaryAdapterMeta Meta { get; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00013FE0 File Offset: 0x000121E0
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00013FE8 File Offset: 0x000121E8
		public DictionaryAdapterInstance This { get; private set; }

		// Token: 0x0600072E RID: 1838 RVA: 0x00013FF4 File Offset: 0x000121F4
		public string GetKey(string propertyName)
		{
			PropertyDescriptor propertyDescriptor;
			if (this.This.Properties.TryGetValue(propertyName, out propertyDescriptor))
			{
				return propertyDescriptor.GetKey(this, propertyName, this.This.Descriptor);
			}
			return null;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001402C File Offset: 0x0001222C
		public virtual object GetProperty(string propertyName, bool ifExists)
		{
			PropertyDescriptor propertyDescriptor;
			if (this.This.Properties.TryGetValue(propertyName, out propertyDescriptor))
			{
				object propertyValue = propertyDescriptor.GetPropertyValue(this, propertyName, null, this.This.Descriptor, ifExists);
				if (propertyValue is IEditableObject)
				{
					this.AddEditDependency((IEditableObject)propertyValue);
				}
				return propertyValue;
			}
			return null;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001407C File Offset: 0x0001227C
		public T GetPropertyOfType<T>(string propertyName)
		{
			object property = this.GetProperty(propertyName, false);
			if (property == null)
			{
				return default(T);
			}
			return (T)((object)property);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000140A8 File Offset: 0x000122A8
		public object ReadProperty(string key)
		{
			object result = null;
			if (!this.GetEditedProperty(key, out result))
			{
				IDictionary dictionary = DictionaryAdapterBase.GetDictionary(this.This.Dictionary, ref key);
				if (dictionary != null)
				{
					result = dictionary[key];
				}
			}
			return result;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000140E4 File Offset: 0x000122E4
		public virtual bool SetProperty(string propertyName, ref object value)
		{
			bool flag = false;
			PropertyDescriptor propertyDescriptor;
			if (this.This.Properties.TryGetValue(propertyName, out propertyDescriptor))
			{
				if (!this.ShouldNotify)
				{
					flag = propertyDescriptor.SetPropertyValue(this, propertyName, ref value, this.This.Descriptor);
					this.Invalidate();
					return flag;
				}
				object property = this.GetProperty(propertyName, true);
				if (!this.NotifyPropertyChanging(propertyDescriptor, property, value))
				{
					return false;
				}
				DictionaryAdapterBase.TrackPropertyChangeScope trackPropertyChangeScope = this.TrackPropertyChange(propertyDescriptor, property, value);
				flag = propertyDescriptor.SetPropertyValue(this, propertyName, ref value, this.This.Descriptor);
				if (flag && trackPropertyChangeScope != null)
				{
					trackPropertyChangeScope.Notify();
				}
			}
			return flag;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00014174 File Offset: 0x00012374
		public void StoreProperty(PropertyDescriptor property, string key, object value)
		{
			if (property == null || !this.EditProperty(property, key, value))
			{
				IDictionary dictionary = DictionaryAdapterBase.GetDictionary(this.This.Dictionary, ref key);
				if (dictionary != null)
				{
					dictionary[key] = value;
				}
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000141B0 File Offset: 0x000123B0
		public void ClearProperty(PropertyDescriptor property, string key)
		{
			key = (key ?? this.GetKey(property.PropertyName));
			if (property == null || !this.ClearEditProperty(property, key))
			{
				IDictionary dictionary = DictionaryAdapterBase.GetDictionary(this.This.Dictionary, ref key);
				if (dictionary != null)
				{
					dictionary.Remove(key);
				}
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000141FC File Offset: 0x000123FC
		public bool ShouldClearProperty(PropertyDescriptor property, object value)
		{
			return property == null || (from remove in property.Setters.OfType<RemoveIfAttribute>()
			where remove.ShouldRemove(value)
			select remove).Any<RemoveIfAttribute>();
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001423C File Offset: 0x0001243C
		public override bool Equals(object obj)
		{
			IDictionaryAdapter dictionaryAdapter = obj as IDictionaryAdapter;
			if (dictionaryAdapter == null)
			{
				return false;
			}
			if (this == obj)
			{
				return true;
			}
			if (this.Meta.Type != dictionaryAdapter.Meta.Type)
			{
				return false;
			}
			if (this.This.EqualityHashCodeStrategy != null)
			{
				return this.This.EqualityHashCodeStrategy.Equals(this, dictionaryAdapter);
			}
			return base.Equals(obj);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000142A4 File Offset: 0x000124A4
		public override int GetHashCode()
		{
			if (this.This.OldHashCode != null)
			{
				return this.This.OldHashCode.Value;
			}
			int hashCode;
			if (this.This.EqualityHashCodeStrategy == null || !this.This.EqualityHashCodeStrategy.GetHashCode(this, out hashCode))
			{
				hashCode = base.GetHashCode();
			}
			this.This.OldHashCode = new int?(hashCode);
			return hashCode;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00014318 File Offset: 0x00012518
		protected void Initialize()
		{
			object[] behaviors = this.Meta.Behaviors;
			IDictionaryInitializer[] initializers = this.This.Initializers;
			for (int i = 0; i < initializers.Length; i++)
			{
				initializers[i].Initialize(this, behaviors);
			}
			foreach (PropertyDescriptor propertyDescriptor in this.This.Properties.Values)
			{
				if (propertyDescriptor.Fetch)
				{
					this.GetProperty(propertyDescriptor.PropertyName, false);
				}
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000143B4 File Offset: 0x000125B4
		private static IDictionary GetDictionary(IDictionary dictionary, ref string key)
		{
			if (!key.StartsWith("!"))
			{
				string[] array = key.Split(new char[]
				{
					','
				});
				for (int i = 0; i < array.Length - 1; i++)
				{
					dictionary = (dictionary[array[i]] as IDictionary);
					if (dictionary == null)
					{
						return null;
					}
				}
				key = array[array.Length - 1];
			}
			return dictionary;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00014411 File Offset: 0x00012611
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00014426 File Offset: 0x00012626
		public bool CanEdit
		{
			get
			{
				return this.suppressEditingCount == 0 && this.updates != null;
			}
			set
			{
				this.updates = (value ? new Stack<Dictionary<string, DictionaryAdapterBase.Edit>>() : null);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00014439 File Offset: 0x00012639
		public bool IsEditing
		{
			get
			{
				return this.CanEdit && this.updates != null && this.updates.Count > 0;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0001445B File Offset: 0x0001265B
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00014463 File Offset: 0x00012663
		public bool SupportsMultiLevelEdit { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x0001446C File Offset: 0x0001266C
		public bool IsChanged
		{
			get
			{
				if (this.IsEditing)
				{
					if (this.updates.Any((Dictionary<string, DictionaryAdapterBase.Edit> level) => level.Count > 0))
					{
						return true;
					}
				}
				return (from prop in this.This.Properties.Values
				where typeof(IChangeTracking).IsAssignableFrom(prop.PropertyType)
				select this.GetProperty(prop.PropertyName, true)).Cast<IChangeTracking>().Any((IChangeTracking track) => track != null && track.IsChanged);
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0001451D File Offset: 0x0001271D
		public void BeginEdit()
		{
			if (this.CanEdit && (!this.IsEditing || this.SupportsMultiLevelEdit))
			{
				this.updates.Push(new Dictionary<string, DictionaryAdapterBase.Edit>());
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00014548 File Offset: 0x00012748
		public void CancelEdit()
		{
			if (this.IsEditing)
			{
				if (this.editDependencies != null)
				{
					IEditableObject[] array = this.editDependencies.ToArray<IEditableObject>();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].CancelEdit();
					}
					this.editDependencies.Clear();
				}
				using (this.SuppressEditingBlock())
				{
					using (this.TrackReadonlyPropertyChanges())
					{
						Dictionary<string, DictionaryAdapterBase.Edit> dictionary = this.updates.Peek();
						if (dictionary.Count > 0)
						{
							foreach (DictionaryAdapterBase.Edit edit in dictionary.Values)
							{
								edit.PropertyValue = this.GetProperty(edit.Property.PropertyName, true);
							}
							this.updates.Pop();
							foreach (DictionaryAdapterBase.Edit edit2 in dictionary.Values.ToArray<DictionaryAdapterBase.Edit>())
							{
								object propertyValue = edit2.PropertyValue;
								object property = this.GetProperty(edit2.Property.PropertyName, true);
								if (!object.Equals(propertyValue, property))
								{
									this.NotifyPropertyChanging(edit2.Property, propertyValue, property);
									this.NotifyPropertyChanged(edit2.Property, propertyValue, property);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000146C8 File Offset: 0x000128C8
		public void EndEdit()
		{
			if (this.IsEditing)
			{
				using (this.SuppressEditingBlock())
				{
					Dictionary<string, DictionaryAdapterBase.Edit> dictionary = this.updates.Pop();
					if (dictionary.Count > 0)
					{
						foreach (KeyValuePair<string, DictionaryAdapterBase.Edit> keyValuePair in dictionary.ToArray<KeyValuePair<string, DictionaryAdapterBase.Edit>>())
						{
							this.StoreProperty(null, keyValuePair.Key, keyValuePair.Value.PropertyValue);
						}
					}
				}
				if (this.editDependencies != null)
				{
					IEditableObject[] array2 = this.editDependencies.ToArray<IEditableObject>();
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].EndEdit();
					}
					this.editDependencies.Clear();
				}
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00014788 File Offset: 0x00012988
		public void RejectChanges()
		{
			this.CancelEdit();
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00014790 File Offset: 0x00012990
		public void AcceptChanges()
		{
			this.EndEdit();
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00014798 File Offset: 0x00012998
		public IDisposable SuppressEditingBlock()
		{
			return new DictionaryAdapterBase.SuppressEditingScope(this);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000147A0 File Offset: 0x000129A0
		public void SuppressEditing()
		{
			this.suppressEditingCount++;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000147B0 File Offset: 0x000129B0
		public void ResumeEditing()
		{
			this.suppressEditingCount--;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000147C0 File Offset: 0x000129C0
		protected bool GetEditedProperty(string propertyName, out object propertyValue)
		{
			if (this.updates != null)
			{
				Dictionary<string, DictionaryAdapterBase.Edit>[] array = this.updates.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					DictionaryAdapterBase.Edit edit;
					if (array[i].TryGetValue(propertyName, out edit))
					{
						propertyValue = edit.PropertyValue;
						return true;
					}
				}
			}
			propertyValue = null;
			return false;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0001480A File Offset: 0x00012A0A
		protected bool EditProperty(PropertyDescriptor property, string key, object propertyValue)
		{
			if (this.IsEditing)
			{
				this.updates.Peek()[key] = new DictionaryAdapterBase.Edit(property, propertyValue);
				return true;
			}
			return false;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001482F File Offset: 0x00012A2F
		protected bool ClearEditProperty(PropertyDescriptor property, string key)
		{
			if (this.IsEditing)
			{
				this.updates.Peek().Remove(key);
				return true;
			}
			return false;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001484E File Offset: 0x00012A4E
		protected void AddEditDependency(IEditableObject editDependency)
		{
			if (this.IsEditing)
			{
				if (this.editDependencies == null)
				{
					this.editDependencies = new HashSet<IEditableObject>();
				}
				if (this.editDependencies.Add(editDependency))
				{
					editDependency.BeginEdit();
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600074C RID: 1868 RVA: 0x00014880 File Offset: 0x00012A80
		// (remove) Token: 0x0600074D RID: 1869 RVA: 0x000148B8 File Offset: 0x00012AB8
		public event PropertyChangingEventHandler PropertyChanging;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600074E RID: 1870 RVA: 0x000148F0 File Offset: 0x00012AF0
		// (remove) Token: 0x0600074F RID: 1871 RVA: 0x00014928 File Offset: 0x00012B28
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0001495D File Offset: 0x00012B5D
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00014965 File Offset: 0x00012B65
		public bool CanNotify { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0001496E File Offset: 0x00012B6E
		public bool ShouldNotify
		{
			get
			{
				return this.CanNotify && this.suppressNotificationCount == 0;
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00014983 File Offset: 0x00012B83
		public IDisposable SuppressNotificationsBlock()
		{
			return new DictionaryAdapterBase.NotificationSuppressionScope(this);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001498B File Offset: 0x00012B8B
		public void SuppressNotifications()
		{
			this.suppressNotificationCount++;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001499B File Offset: 0x00012B9B
		public void ResumeNotifications()
		{
			this.suppressNotificationCount--;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000149AC File Offset: 0x00012BAC
		protected bool NotifyPropertyChanging(PropertyDescriptor property, object oldValue, object newValue)
		{
			if (property.SuppressNotifications || !this.ShouldNotify)
			{
				return true;
			}
			PropertyChangingEventHandler propertyChanging = this.PropertyChanging;
			if (propertyChanging == null)
			{
				return true;
			}
			PropertyChangingEventArgsEx propertyChangingEventArgsEx = new PropertyChangingEventArgsEx(property.PropertyName, oldValue, newValue);
			propertyChanging(this, propertyChangingEventArgsEx);
			return !propertyChangingEventArgsEx.Cancel;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000149F8 File Offset: 0x00012BF8
		protected void NotifyPropertyChanged(PropertyDescriptor property, object oldValue, object newValue)
		{
			if (property.SuppressNotifications || !this.ShouldNotify)
			{
				return;
			}
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgsEx(property.PropertyName, oldValue, newValue));
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00014A38 File Offset: 0x00012C38
		protected void NotifyPropertyChanged(string propertyName)
		{
			if (!this.ShouldNotify)
			{
				return;
			}
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00014A66 File Offset: 0x00012C66
		protected DictionaryAdapterBase.TrackPropertyChangeScope TrackPropertyChange(PropertyDescriptor property, object oldValue, object newValue)
		{
			if (!this.ShouldNotify || property.SuppressNotifications)
			{
				return null;
			}
			return new DictionaryAdapterBase.TrackPropertyChangeScope(this, property, oldValue);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00014A82 File Offset: 0x00012C82
		protected DictionaryAdapterBase.TrackPropertyChangeScope TrackReadonlyPropertyChanges()
		{
			if (!this.ShouldNotify || DictionaryAdapterBase.readOnlyTrackingScope != null)
			{
				return null;
			}
			return DictionaryAdapterBase.readOnlyTrackingScope = new DictionaryAdapterBase.TrackPropertyChangeScope(this);
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00014AA1 File Offset: 0x00012CA1
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00014AA9 File Offset: 0x00012CA9
		public bool CanValidate { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00014AB2 File Offset: 0x00012CB2
		public bool IsValid
		{
			get
			{
				if (this.CanValidate && this.validators != null)
				{
					return !this.validators.Any((IDictionaryValidator v) => !v.IsValid(this));
				}
				return !this.CanValidate;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00014AE8 File Offset: 0x00012CE8
		public string Error
		{
			get
			{
				if (this.CanValidate && this.validators != null)
				{
					return string.Join(Environment.NewLine, (from v in this.validators
					select v.Validate(this) into e
					where !string.IsNullOrEmpty(e)
					select e).ToArray<string>());
				}
				return string.Empty;
			}
		}

		// Token: 0x17000124 RID: 292
		public string this[string columnName]
		{
			get
			{
				if (this.CanValidate && this.validators != null)
				{
					PropertyDescriptor property;
					if (this.This.Properties.TryGetValue(columnName, out property))
					{
						return string.Join(Environment.NewLine, (from v in this.validators
						select v.Validate(this, property) into e
						where !string.IsNullOrEmpty(e)
						select e).ToArray<string>());
					}
				}
				return string.Empty;
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00014BEB File Offset: 0x00012DEB
		public DictionaryValidateGroup ValidateGroups(params object[] groups)
		{
			return new DictionaryValidateGroup(groups, this);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00014BF4 File Offset: 0x00012DF4
		public IEnumerable<IDictionaryValidator> Validators
		{
			get
			{
				IEnumerable<IDictionaryValidator> enumerable = this.validators;
				return enumerable ?? Enumerable.Empty<IDictionaryValidator>();
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00014C12 File Offset: 0x00012E12
		public void AddValidator(IDictionaryValidator validator)
		{
			if (this.validators == null)
			{
				this.validators = new HashSet<IDictionaryValidator>();
			}
			this.validators.Add(validator);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00014C34 File Offset: 0x00012E34
		protected internal void Invalidate()
		{
			if (this.CanValidate)
			{
				if (this.validators != null)
				{
					foreach (IDictionaryValidator dictionaryValidator in this.validators)
					{
						dictionaryValidator.Invalidate(this);
					}
				}
				this.NotifyPropertyChanged("IsValid");
			}
		}

		// Token: 0x040001B1 RID: 433
		private int suppressEditingCount;

		// Token: 0x040001B2 RID: 434
		private Stack<Dictionary<string, DictionaryAdapterBase.Edit>> updates;

		// Token: 0x040001B3 RID: 435
		private HashSet<IEditableObject> editDependencies;

		// Token: 0x040001B5 RID: 437
		[ThreadStatic]
		private static DictionaryAdapterBase.TrackPropertyChangeScope readOnlyTrackingScope;

		// Token: 0x040001B6 RID: 438
		private int suppressNotificationCount;

		// Token: 0x040001BA RID: 442
		private ICollection<IDictionaryValidator> validators;

		// Token: 0x020001FC RID: 508
		private struct Edit
		{
			// Token: 0x06000EA0 RID: 3744 RVA: 0x00022A97 File Offset: 0x00020C97
			public Edit(PropertyDescriptor property, object propertyValue)
			{
				this.Property = property;
				this.PropertyValue = propertyValue;
			}

			// Token: 0x040003C1 RID: 961
			public readonly PropertyDescriptor Property;

			// Token: 0x040003C2 RID: 962
			public object PropertyValue;
		}

		// Token: 0x020001FD RID: 509
		private class SuppressEditingScope : IDisposable
		{
			// Token: 0x06000EA1 RID: 3745 RVA: 0x00022AA7 File Offset: 0x00020CA7
			public SuppressEditingScope(DictionaryAdapterBase adapter)
			{
				this.adapter = adapter;
				this.adapter.SuppressEditing();
			}

			// Token: 0x06000EA2 RID: 3746 RVA: 0x00022AC1 File Offset: 0x00020CC1
			public void Dispose()
			{
				this.adapter.ResumeEditing();
			}

			// Token: 0x040003C3 RID: 963
			private readonly DictionaryAdapterBase adapter;
		}

		// Token: 0x020001FE RID: 510
		private class NotificationSuppressionScope : IDisposable
		{
			// Token: 0x06000EA3 RID: 3747 RVA: 0x00022ACE File Offset: 0x00020CCE
			public NotificationSuppressionScope(DictionaryAdapterBase adapter)
			{
				this.adapter = adapter;
				this.adapter.SuppressNotifications();
			}

			// Token: 0x06000EA4 RID: 3748 RVA: 0x00022AE8 File Offset: 0x00020CE8
			public void Dispose()
			{
				this.adapter.ResumeNotifications();
			}

			// Token: 0x040003C4 RID: 964
			private readonly DictionaryAdapterBase adapter;
		}

		// Token: 0x020001FF RID: 511
		public class TrackPropertyChangeScope : IDisposable
		{
			// Token: 0x06000EA5 RID: 3749 RVA: 0x00022AF8 File Offset: 0x00020CF8
			public TrackPropertyChangeScope(DictionaryAdapterBase adapter)
			{
				this.adapter = adapter;
				this.readOnlyProperties = (from pd in adapter.This.Properties.Values
				where !pd.Property.CanWrite || pd.IsDynamicProperty
				select pd).ToDictionary((PropertyDescriptor pd) => pd, (PropertyDescriptor pd) => this.GetEffectivePropertyValue(pd));
			}

			// Token: 0x06000EA6 RID: 3750 RVA: 0x00022B7C File Offset: 0x00020D7C
			public TrackPropertyChangeScope(DictionaryAdapterBase adapter, PropertyDescriptor property, object existingValue) : this(adapter)
			{
				this.property = property;
				this.existingValue = existingValue;
				existingValue = adapter.GetProperty(property.PropertyName, true);
			}

			// Token: 0x06000EA7 RID: 3751 RVA: 0x00022BA2 File Offset: 0x00020DA2
			public void Dispose()
			{
				this.Notify();
			}

			// Token: 0x06000EA8 RID: 3752 RVA: 0x00022BAC File Offset: 0x00020DAC
			public bool Notify()
			{
				if (DictionaryAdapterBase.readOnlyTrackingScope == this)
				{
					DictionaryAdapterBase.readOnlyTrackingScope = null;
					return this.NotifyReadonly();
				}
				object effectivePropertyValue = this.GetEffectivePropertyValue(this.property);
				if (!this.NotifyIfChanged(this.property, this.existingValue, effectivePropertyValue))
				{
					return false;
				}
				if (DictionaryAdapterBase.readOnlyTrackingScope == null)
				{
					this.NotifyReadonly();
				}
				return true;
			}

			// Token: 0x06000EA9 RID: 3753 RVA: 0x00022C04 File Offset: 0x00020E04
			private bool NotifyReadonly()
			{
				bool flag = false;
				foreach (KeyValuePair<PropertyDescriptor, object> keyValuePair in this.readOnlyProperties)
				{
					PropertyDescriptor key = keyValuePair.Key;
					object effectivePropertyValue = this.GetEffectivePropertyValue(key);
					flag |= this.NotifyIfChanged(key, keyValuePair.Value, effectivePropertyValue);
				}
				this.adapter.Invalidate();
				return flag;
			}

			// Token: 0x06000EAA RID: 3754 RVA: 0x00022C84 File Offset: 0x00020E84
			private bool NotifyIfChanged(PropertyDescriptor descriptor, object oldValue, object newValue)
			{
				if (object.Equals(oldValue, newValue))
				{
					return false;
				}
				this.adapter.NotifyPropertyChanged(descriptor, oldValue, newValue);
				return true;
			}

			// Token: 0x06000EAB RID: 3755 RVA: 0x00022CA0 File Offset: 0x00020EA0
			private object GetEffectivePropertyValue(PropertyDescriptor property)
			{
				object obj = this.adapter.GetProperty(property.PropertyName, true);
				if (obj == null || !property.IsDynamicProperty)
				{
					return obj;
				}
				IDynamicValue dynamicValue = obj as IDynamicValue;
				if (dynamicValue == null)
				{
					return obj;
				}
				return dynamicValue.GetValue();
			}

			// Token: 0x040003C5 RID: 965
			private readonly DictionaryAdapterBase adapter;

			// Token: 0x040003C6 RID: 966
			private readonly PropertyDescriptor property;

			// Token: 0x040003C7 RID: 967
			private readonly object existingValue;

			// Token: 0x040003C8 RID: 968
			private Dictionary<PropertyDescriptor, object> readOnlyProperties;
		}
	}
}
