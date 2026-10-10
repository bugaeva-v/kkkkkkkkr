using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Castle.Core.Internal;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000135 RID: 309
	[DebuggerDisplay("{Property.DeclaringType.FullName,nq}.{PropertyName,nq}")]
	public class PropertyDescriptor : IDictionaryKeyBuilder, IDictionaryBehavior, IDictionaryPropertyGetter, IDictionaryPropertySetter
	{
		// Token: 0x0600082D RID: 2093 RVA: 0x00016147 File Offset: 0x00014347
		public PropertyDescriptor()
		{
			this.Annotations = PropertyDescriptor.NoAnnotations;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0001615A File Offset: 0x0001435A
		public PropertyDescriptor(PropertyInfo property, object[] annotations) : this()
		{
			this.Property = property;
			this.Annotations = (annotations ?? PropertyDescriptor.NoAnnotations);
			this.IsDynamicProperty = typeof(IDynamicValue).IsAssignableFrom(property.PropertyType);
			this.ObtainTypeConverter();
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0001619A File Offset: 0x0001439A
		public PropertyDescriptor(object[] annotations)
		{
			this.Annotations = (annotations ?? PropertyDescriptor.NoAnnotations);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000161B4 File Offset: 0x000143B4
		public PropertyDescriptor(PropertyDescriptor source, bool copyBehaviors)
		{
			this.Property = source.Property;
			this.Annotations = source.Annotations;
			this.IsDynamicProperty = source.IsDynamicProperty;
			this.TypeConverter = source.TypeConverter;
			this.SuppressNotifications = source.SuppressNotifications;
			this.state = source.state;
			this.IfExists = source.IfExists;
			this.Fetch = source.Fetch;
			if (source.extendedProperties != null)
			{
				this.extendedProperties = new Dictionary<object, object>(source.extendedProperties);
			}
			if (copyBehaviors && source.dictionaryBehaviors != null)
			{
				this.dictionaryBehaviors = new List<IDictionaryBehavior>(source.dictionaryBehaviors);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0001625C File Offset: 0x0001445C
		public int ExecutionOrder
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0001625F File Offset: 0x0001445F
		public string PropertyName
		{
			get
			{
				if (!(this.Property != null))
				{
					return null;
				}
				return this.Property.Name;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0001627C File Offset: 0x0001447C
		public Type PropertyType
		{
			get
			{
				if (!(this.Property != null))
				{
					return null;
				}
				return this.Property.PropertyType;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00016299 File Offset: 0x00014499
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x000162A1 File Offset: 0x000144A1
		public PropertyInfo Property { get; private set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x000162AA File Offset: 0x000144AA
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x000162B2 File Offset: 0x000144B2
		public bool IsDynamicProperty { get; private set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x000162BC File Offset: 0x000144BC
		public IDictionary State
		{
			get
			{
				IDictionary result;
				if ((result = this.state) == null)
				{
					result = (this.state = new Dictionary<object, object>());
				}
				return result;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000162E1 File Offset: 0x000144E1
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x000162E9 File Offset: 0x000144E9
		public bool Fetch { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x000162F2 File Offset: 0x000144F2
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x000162FA File Offset: 0x000144FA
		public bool IfExists { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00016303 File Offset: 0x00014503
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0001630B File Offset: 0x0001450B
		public bool SuppressNotifications { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00016314 File Offset: 0x00014514
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0001631C File Offset: 0x0001451C
		public object[] Annotations { get; private set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00016325 File Offset: 0x00014525
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x0001632D File Offset: 0x0001452D
		public TypeConverter TypeConverter { get; private set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00016338 File Offset: 0x00014538
		public IDictionary ExtendedProperties
		{
			get
			{
				Dictionary<object, object> result;
				if ((result = this.extendedProperties) == null)
				{
					result = (this.extendedProperties = new Dictionary<object, object>());
				}
				return result;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00016360 File Offset: 0x00014560
		public IEnumerable<IDictionaryBehavior> Behaviors
		{
			get
			{
				IEnumerable<IDictionaryBehavior> enumerable = this.dictionaryBehaviors;
				return enumerable ?? Enumerable.Empty<IDictionaryBehavior>();
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0001637E File Offset: 0x0001457E
		internal List<IDictionaryBehavior> BehaviorsInternal
		{
			get
			{
				return this.dictionaryBehaviors;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00016386 File Offset: 0x00014586
		public IEnumerable<IDictionaryKeyBuilder> KeyBuilders
		{
			get
			{
				if (this.dictionaryBehaviors == null)
				{
					return Enumerable.Empty<IDictionaryKeyBuilder>();
				}
				return this.dictionaryBehaviors.OfType<IDictionaryKeyBuilder>();
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000163A1 File Offset: 0x000145A1
		public IEnumerable<IDictionaryPropertySetter> Setters
		{
			get
			{
				if (this.dictionaryBehaviors == null)
				{
					return Enumerable.Empty<IDictionaryPropertySetter>();
				}
				return this.dictionaryBehaviors.OfType<IDictionaryPropertySetter>();
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x000163BC File Offset: 0x000145BC
		public IEnumerable<IDictionaryPropertyGetter> Getters
		{
			get
			{
				if (this.dictionaryBehaviors == null)
				{
					return Enumerable.Empty<IDictionaryPropertyGetter>();
				}
				return this.dictionaryBehaviors.OfType<IDictionaryPropertyGetter>();
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x000163D7 File Offset: 0x000145D7
		public IEnumerable<IDictionaryInitializer> Initializers
		{
			get
			{
				if (this.dictionaryBehaviors == null)
				{
					return Enumerable.Empty<IDictionaryInitializer>();
				}
				return this.dictionaryBehaviors.OfType<IDictionaryInitializer>();
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x000163F2 File Offset: 0x000145F2
		public IEnumerable<IDictionaryMetaInitializer> MetaInitializers
		{
			get
			{
				if (this.dictionaryBehaviors == null)
				{
					return Enumerable.Empty<IDictionaryMetaInitializer>();
				}
				return this.dictionaryBehaviors.OfType<IDictionaryMetaInitializer>();
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00016410 File Offset: 0x00014610
		public string GetKey(IDictionaryAdapter dictionaryAdapter, string key, PropertyDescriptor descriptor)
		{
			List<IDictionaryBehavior> list = this.dictionaryBehaviors;
			if (list != null)
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					IDictionaryKeyBuilder dictionaryKeyBuilder = list[i] as IDictionaryKeyBuilder;
					if (dictionaryKeyBuilder != null)
					{
						key = dictionaryKeyBuilder.GetKey(dictionaryAdapter, key, this);
					}
				}
			}
			return key;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00016458 File Offset: 0x00014658
		public object GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor descriptor, bool ifExists)
		{
			key = this.GetKey(dictionaryAdapter, key, descriptor);
			storedValue = (storedValue ?? dictionaryAdapter.ReadProperty(key));
			List<IDictionaryBehavior> list = this.dictionaryBehaviors;
			if (list != null)
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					IDictionaryPropertyGetter dictionaryPropertyGetter = list[i] as IDictionaryPropertyGetter;
					if (dictionaryPropertyGetter != null)
					{
						storedValue = dictionaryPropertyGetter.GetPropertyValue(dictionaryAdapter, key, storedValue, this, this.IfExists || ifExists);
					}
				}
			}
			return storedValue;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000164C4 File Offset: 0x000146C4
		public bool SetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, ref object value, PropertyDescriptor descriptor)
		{
			key = this.GetKey(dictionaryAdapter, key, descriptor);
			List<IDictionaryBehavior> list = this.dictionaryBehaviors;
			if (list != null)
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					IDictionaryPropertySetter dictionaryPropertySetter = list[i] as IDictionaryPropertySetter;
					if (dictionaryPropertySetter != null && !dictionaryPropertySetter.SetPropertyValue(dictionaryAdapter, key, ref value, this))
					{
						return false;
					}
				}
			}
			dictionaryAdapter.StoreProperty(this, key, value);
			return true;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00016524 File Offset: 0x00014724
		public PropertyDescriptor AddBehavior(IDictionaryBehavior behavior)
		{
			if (behavior == null)
			{
				return this;
			}
			IDictionaryBehaviorBuilder dictionaryBehaviorBuilder = behavior as IDictionaryBehaviorBuilder;
			if (dictionaryBehaviorBuilder == null)
			{
				PropertyDescriptor.MergeBehavior<IDictionaryBehavior>(ref this.dictionaryBehaviors, behavior);
			}
			else
			{
				foreach (object obj in dictionaryBehaviorBuilder.BuildBehaviors())
				{
					this.AddBehavior(obj as IDictionaryBehavior);
				}
			}
			return this;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00016578 File Offset: 0x00014778
		public static void MergeBehavior<T>(ref List<T> dictionaryBehaviors, T behavior) where T : class, IDictionaryBehavior
		{
			List<T> list = dictionaryBehaviors;
			if (list == null)
			{
				dictionaryBehaviors = new List<T>
				{
					behavior
				};
				return;
			}
			int num = 0;
			int executionOrder = behavior.ExecutionOrder;
			int count = list.Count;
			IDictionaryBehavior dictionaryBehavior;
			int executionOrder2;
			for (;;)
			{
				dictionaryBehavior = list[num];
				executionOrder2 = dictionaryBehavior.ExecutionOrder;
				if (executionOrder2 >= executionOrder)
				{
					break;
				}
				if (++num == count)
				{
					goto Block_3;
				}
			}
			while (executionOrder2 == executionOrder)
			{
				if (dictionaryBehavior == behavior)
				{
					return;
				}
				if (++num == count)
				{
					list.Add(behavior);
					return;
				}
				dictionaryBehavior = list[num];
				executionOrder2 = dictionaryBehavior.ExecutionOrder;
			}
			list.Insert(num, behavior);
			return;
			Block_3:
			list.Add(behavior);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00016620 File Offset: 0x00014820
		public PropertyDescriptor AddBehaviors(params IDictionaryBehavior[] behaviors)
		{
			foreach (IDictionaryBehavior behavior in behaviors)
			{
				this.AddBehavior(behavior);
			}
			return this;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0001664C File Offset: 0x0001484C
		public PropertyDescriptor AddBehaviors(IEnumerable<IDictionaryBehavior> behaviors)
		{
			if (behaviors != null)
			{
				foreach (IDictionaryBehavior behavior in behaviors)
				{
					this.AddBehavior(behavior);
				}
			}
			return this;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0001669C File Offset: 0x0001489C
		public PropertyDescriptor CopyBehaviors(PropertyDescriptor other)
		{
			List<IDictionaryBehavior> list = this.dictionaryBehaviors;
			if (list != null)
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					IDictionaryBehavior dictionaryBehavior = list[i].Copy();
					if (dictionaryBehavior != null)
					{
						other.AddBehavior(dictionaryBehavior);
					}
				}
			}
			return this;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000166DF File Offset: 0x000148DF
		public IDictionaryBehavior Copy()
		{
			return new PropertyDescriptor(this, true);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000166E8 File Offset: 0x000148E8
		private void ObtainTypeConverter()
		{
			Type typeConverter = AttributesUtil.GetTypeConverter(this.Property);
			this.TypeConverter = ((typeConverter != null) ? ((TypeConverter)Activator.CreateInstance(typeConverter)) : TypeDescriptor.GetConverter(this.PropertyType));
		}

		// Token: 0x040001E5 RID: 485
		private IDictionary state;

		// Token: 0x040001E6 RID: 486
		private Dictionary<object, object> extendedProperties;

		// Token: 0x040001E7 RID: 487
		protected List<IDictionaryBehavior> dictionaryBehaviors;

		// Token: 0x040001E8 RID: 488
		private static readonly object[] NoAnnotations = new object[0];
	}
}
