using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000117 RID: 279
	[DebuggerDisplay("Type: {Type.FullName,nq}")]
	public class DictionaryAdapterMeta
	{
		// Token: 0x060007A0 RID: 1952 RVA: 0x00015A04 File Offset: 0x00013C04
		public DictionaryAdapterMeta(Type type, Type implementation, object[] behaviors, IDictionaryMetaInitializer[] metaInitializers, IDictionaryInitializer[] initializers, IDictionary<string, PropertyDescriptor> properties, IDictionaryAdapterFactory factory, Func<DictionaryAdapterInstance, IDictionaryAdapter> creator)
		{
			this.Type = type;
			this.Implementation = implementation;
			this.Behaviors = behaviors;
			this.MetaInitializers = metaInitializers;
			this.Initializers = initializers;
			this.Properties = properties;
			this.Factory = factory;
			this.creator = creator;
			this.InitializeMeta();
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00015A5A File Offset: 0x00013C5A
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00015A62 File Offset: 0x00013C62
		public Type Type { get; private set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00015A6B File Offset: 0x00013C6B
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00015A73 File Offset: 0x00013C73
		public Type Implementation { get; private set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00015A7C File Offset: 0x00013C7C
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00015A84 File Offset: 0x00013C84
		public object[] Behaviors { get; private set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00015A8D File Offset: 0x00013C8D
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00015A95 File Offset: 0x00013C95
		public IDictionaryAdapterFactory Factory { get; private set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00015A9E File Offset: 0x00013C9E
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00015AA6 File Offset: 0x00013CA6
		public IDictionary<string, PropertyDescriptor> Properties { get; private set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00015AAF File Offset: 0x00013CAF
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x00015AB7 File Offset: 0x00013CB7
		public IDictionaryMetaInitializer[] MetaInitializers { get; private set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00015AC0 File Offset: 0x00013CC0
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x00015AC8 File Offset: 0x00013CC8
		public IDictionaryInitializer[] Initializers { get; private set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00015AD1 File Offset: 0x00013CD1
		public IDictionary ExtendedProperties
		{
			get
			{
				if (this.extendedProperties == null)
				{
					this.extendedProperties = new Dictionary<object, object>();
				}
				return this.extendedProperties;
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00015AEC File Offset: 0x00013CEC
		public PropertyDescriptor CreateDescriptor()
		{
			IDictionaryMetaInitializer[] metaInitializers = this.MetaInitializers;
			List<object> list = DictionaryAdapterMeta.CollectSharedBehaviors<object>(this.Behaviors, metaInitializers);
			List<IDictionaryInitializer> list2 = DictionaryAdapterMeta.CollectSharedBehaviors<IDictionaryInitializer>(this.Initializers, metaInitializers);
			PropertyDescriptor propertyDescriptor = (list != null) ? new PropertyDescriptor(list.ToArray()) : new PropertyDescriptor();
			PropertyDescriptor propertyDescriptor2 = propertyDescriptor;
			IDictionaryBehavior[] behaviors = metaInitializers;
			propertyDescriptor2.AddBehaviors(behaviors);
			if (list2 != null)
			{
				propertyDescriptor.AddBehaviors(list2);
			}
			return propertyDescriptor;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00015B48 File Offset: 0x00013D48
		private static List<T> CollectSharedBehaviors<T>(T[] source, IDictionaryMetaInitializer[] predicates)
		{
			List<T> list = null;
			foreach (T t in source)
			{
				for (int j = 0; j < predicates.Length; j++)
				{
					if (predicates[j].ShouldHaveBehavior(t))
					{
						if (list == null)
						{
							list = new List<T>(source.Length);
						}
						list.Add(t);
						break;
					}
				}
			}
			return list;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00015BAD File Offset: 0x00013DAD
		public DictionaryAdapterMeta GetAdapterMeta(Type type)
		{
			return this.Factory.GetAdapterMeta(type, this);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00015BBC File Offset: 0x00013DBC
		public object CreateInstance(IDictionary dictionary, PropertyDescriptor descriptor)
		{
			DictionaryAdapterInstance arg = new DictionaryAdapterInstance(dictionary, this, descriptor, this.Factory);
			return this.creator(arg);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00015BE4 File Offset: 0x00013DE4
		private void InitializeMeta()
		{
			IDictionaryMetaInitializer[] metaInitializers = this.MetaInitializers;
			for (int i = 0; i < metaInitializers.Length; i++)
			{
				metaInitializers[i].Initialize(this.Factory, this);
			}
		}

		// Token: 0x040001CF RID: 463
		private IDictionary extendedProperties;

		// Token: 0x040001D0 RID: 464
		private readonly Func<DictionaryAdapterInstance, IDictionaryAdapter> creator;
	}
}
