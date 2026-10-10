using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000116 RID: 278
	public class DictionaryAdapterInstance
	{
		// Token: 0x06000786 RID: 1926 RVA: 0x00015724 File Offset: 0x00013924
		public DictionaryAdapterInstance(IDictionary dictionary, DictionaryAdapterMeta meta, PropertyDescriptor descriptor, IDictionaryAdapterFactory factory)
		{
			this.Dictionary = dictionary;
			this.Descriptor = descriptor;
			this.Factory = factory;
			List<IDictionaryBehavior> behaviorsInternal;
			if (descriptor == null || (behaviorsInternal = descriptor.BehaviorsInternal) == null)
			{
				this.Initializers = meta.Initializers;
				this.Properties = DictionaryAdapterInstance.MergeProperties(meta.Properties);
				return;
			}
			this.Initializers = DictionaryAdapterInstance.MergeInitializers(meta.Initializers, behaviorsInternal);
			this.Properties = DictionaryAdapterInstance.MergeProperties(meta.Properties, behaviorsInternal);
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0001579C File Offset: 0x0001399C
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x000157A4 File Offset: 0x000139A4
		internal int? OldHashCode { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x000157AD File Offset: 0x000139AD
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x000157B5 File Offset: 0x000139B5
		public IDictionary Dictionary { get; private set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x000157BE File Offset: 0x000139BE
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x000157C6 File Offset: 0x000139C6
		public PropertyDescriptor Descriptor { get; private set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x000157CF File Offset: 0x000139CF
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x000157D7 File Offset: 0x000139D7
		public IDictionaryAdapterFactory Factory { get; private set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x000157E0 File Offset: 0x000139E0
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x000157E8 File Offset: 0x000139E8
		public IDictionaryInitializer[] Initializers { get; private set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x000157F1 File Offset: 0x000139F1
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x000157F9 File Offset: 0x000139F9
		public IDictionary<string, PropertyDescriptor> Properties { get; private set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00015802 File Offset: 0x00013A02
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x0001580A File Offset: 0x00013A0A
		public IDictionaryEqualityHashCodeStrategy EqualityHashCodeStrategy { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00015813 File Offset: 0x00013A13
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0001581B File Offset: 0x00013A1B
		public IDictionaryCreateStrategy CreateStrategy { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00015824 File Offset: 0x00013A24
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x0001582C File Offset: 0x00013A2C
		public IDictionaryCoerceStrategy CoerceStrategy { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00015838 File Offset: 0x00013A38
		public IEnumerable<IDictionaryCopyStrategy> CopyStrategies
		{
			get
			{
				IEnumerable<IDictionaryCopyStrategy> enumerable = this.copyStrategies;
				return enumerable ?? Enumerable.Empty<IDictionaryCopyStrategy>();
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00015856 File Offset: 0x00013A56
		public void AddCopyStrategy(IDictionaryCopyStrategy copyStrategy)
		{
			if (copyStrategy == null)
			{
				throw new ArgumentNullException("copyStrategy");
			}
			if (this.copyStrategies == null)
			{
				this.copyStrategies = new List<IDictionaryCopyStrategy>();
			}
			this.copyStrategies.Add(copyStrategy);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00015885 File Offset: 0x00013A85
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

		// Token: 0x0600079C RID: 1948 RVA: 0x000158A0 File Offset: 0x00013AA0
		private static IDictionaryInitializer[] MergeInitializers(IDictionaryInitializer[] source, List<IDictionaryBehavior> behaviors)
		{
			List<IDictionaryInitializer> list = null;
			int num = source.Length;
			for (int i = 0; i < num; i++)
			{
				PropertyDescriptor.MergeBehavior<IDictionaryInitializer>(ref list, source[i]);
			}
			num = behaviors.Count;
			for (int i = 0; i < num; i++)
			{
				IDictionaryInitializer behavior;
				if ((behavior = (behaviors[i] as IDictionaryInitializer)) != null)
				{
					PropertyDescriptor.MergeBehavior<IDictionaryInitializer>(ref list, behavior);
				}
			}
			if (list != null)
			{
				return list.ToArray();
			}
			return DictionaryAdapterInstance.NoInitializers;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00015904 File Offset: 0x00013B04
		private static IDictionary<string, PropertyDescriptor> MergeProperties(IDictionary<string, PropertyDescriptor> source)
		{
			Dictionary<string, PropertyDescriptor> dictionary = new Dictionary<string, PropertyDescriptor>();
			foreach (KeyValuePair<string, PropertyDescriptor> keyValuePair in source)
			{
				dictionary[keyValuePair.Key] = new PropertyDescriptor(keyValuePair.Value, true);
			}
			return dictionary;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00015968 File Offset: 0x00013B68
		private static IDictionary<string, PropertyDescriptor> MergeProperties(IDictionary<string, PropertyDescriptor> source, List<IDictionaryBehavior> behaviors)
		{
			int count = behaviors.Count;
			Dictionary<string, PropertyDescriptor> dictionary = new Dictionary<string, PropertyDescriptor>();
			foreach (KeyValuePair<string, PropertyDescriptor> keyValuePair in source)
			{
				PropertyDescriptor propertyDescriptor = new PropertyDescriptor(keyValuePair.Value, true);
				for (int i = 0; i < count; i++)
				{
					propertyDescriptor.AddBehavior(behaviors[i]);
				}
				dictionary[keyValuePair.Key] = propertyDescriptor;
			}
			return dictionary;
		}

		// Token: 0x040001C3 RID: 451
		private IDictionary extendedProperties;

		// Token: 0x040001C4 RID: 452
		private List<IDictionaryCopyStrategy> copyStrategies;

		// Token: 0x040001CE RID: 462
		private static readonly IDictionaryInitializer[] NoInitializers = new IDictionaryInitializer[0];
	}
}
