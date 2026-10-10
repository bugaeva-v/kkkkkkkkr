using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A7 RID: 423
	public class XmlKnownTypeSet : IXmlKnownTypeMap, IEnumerable<IXmlKnownType>, IEnumerable
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x0001F645 File Offset: 0x0001D845
		public XmlKnownTypeSet(Type defaultType)
		{
			if (defaultType == null)
			{
				throw Error.ArgumentNull("defaultType");
			}
			this.itemsByXmlIdentity = new Dictionary<IXmlIdentity, IXmlKnownType>(XmlKnownTypeSet.XmlIdentityComparer.Instance);
			this.itemsByClrType = new Dictionary<Type, IXmlKnownType>();
			this.defaultType = defaultType;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0001F684 File Offset: 0x0001D884
		public IXmlKnownType Default
		{
			get
			{
				IXmlKnownType result;
				if (this.defaultType == null || !this.TryGet(this.defaultType, out result))
				{
					throw Error.NoDefaultKnownType();
				}
				return result;
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0001F6B8 File Offset: 0x0001D8B8
		public void Add(IXmlKnownType knownType, bool overwrite)
		{
			if (overwrite || !this.itemsByXmlIdentity.ContainsKey(knownType))
			{
				this.itemsByXmlIdentity[knownType] = knownType;
			}
			Type clrType = knownType.ClrType;
			if (overwrite || !this.itemsByClrType.ContainsKey(clrType))
			{
				this.itemsByClrType[clrType] = knownType;
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0001F708 File Offset: 0x0001D908
		public void AddXsiTypeDefaults()
		{
			Dictionary<IXmlKnownType, bool> dictionary = new Dictionary<IXmlKnownType, bool>(this.itemsByXmlIdentity.Count, XmlKnownTypeSet.XmlKnownTypeNameComparer.Instance);
			foreach (IXmlKnownType xmlKnownType in this.itemsByXmlIdentity.Values)
			{
				bool flag;
				dictionary[xmlKnownType] = (!dictionary.TryGetValue(xmlKnownType, out flag) && xmlKnownType.XsiType != XmlName.Empty);
			}
			foreach (KeyValuePair<IXmlKnownType, bool> keyValuePair in dictionary)
			{
				if (keyValuePair.Value)
				{
					IXmlKnownType key = keyValuePair.Key;
					XmlKnownType knownType = new XmlKnownType(key.Name, XmlName.Empty, key.ClrType);
					this.Add(knownType, true);
				}
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0001F804 File Offset: 0x0001DA04
		public bool TryGet(IXmlIdentity xmlIdentity, out IXmlKnownType knownType)
		{
			return this.itemsByXmlIdentity.TryGetValue(xmlIdentity, out knownType);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0001F813 File Offset: 0x0001DA13
		public bool TryGet(Type clrType, out IXmlKnownType knownType)
		{
			return this.itemsByClrType.TryGetValue(clrType, out knownType);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0001F822 File Offset: 0x0001DA22
		public IXmlKnownType[] ToArray()
		{
			return this.itemsByXmlIdentity.Values.ToArray<IXmlKnownType>();
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0001F834 File Offset: 0x0001DA34
		public IEnumerator<IXmlKnownType> GetEnumerator()
		{
			return this.itemsByXmlIdentity.Values.GetEnumerator();
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0001F84B File Offset: 0x0001DA4B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.itemsByXmlIdentity.Values.GetEnumerator();
		}

		// Token: 0x040002D7 RID: 727
		private readonly Dictionary<IXmlIdentity, IXmlKnownType> itemsByXmlIdentity;

		// Token: 0x040002D8 RID: 728
		private readonly Dictionary<Type, IXmlKnownType> itemsByClrType;

		// Token: 0x040002D9 RID: 729
		private readonly Type defaultType;

		// Token: 0x040002DA RID: 730
		private static readonly StringComparer NameComparer = StringComparer.OrdinalIgnoreCase;

		// Token: 0x040002DB RID: 731
		private static readonly XmlNameComparer XsiTypeComparer = XmlNameComparer.Default;

		// Token: 0x02000227 RID: 551
		private sealed class XmlIdentityComparer : IEqualityComparer<IXmlIdentity>
		{
			// Token: 0x06000F48 RID: 3912 RVA: 0x000240ED File Offset: 0x000222ED
			private XmlIdentityComparer()
			{
			}

			// Token: 0x06000F49 RID: 3913 RVA: 0x000240F8 File Offset: 0x000222F8
			public bool Equals(IXmlIdentity x, IXmlIdentity y)
			{
				XmlName name = x.Name;
				XmlName name2 = y.Name;
				return XmlKnownTypeSet.NameComparer.Equals(name.LocalName, name2.LocalName) && XmlKnownTypeSet.XsiTypeComparer.Equals(x.XsiType, y.XsiType) && (name.NamespaceUri == null || name2.NamespaceUri == null || XmlKnownTypeSet.NameComparer.Equals(name.NamespaceUri, name2.NamespaceUri));
			}

			// Token: 0x06000F4A RID: 3914 RVA: 0x00024178 File Offset: 0x00022378
			public int GetHashCode(IXmlIdentity name)
			{
				int num = XmlKnownTypeSet.NameComparer.GetHashCode(name.Name.LocalName);
				if (name.XsiType != XmlName.Empty)
				{
					num = ((num << 7 | num >> 25) ^ XmlKnownTypeSet.XsiTypeComparer.GetHashCode(name.XsiType));
				}
				return num;
			}

			// Token: 0x0400044A RID: 1098
			public static readonly XmlKnownTypeSet.XmlIdentityComparer Instance = new XmlKnownTypeSet.XmlIdentityComparer();
		}

		// Token: 0x02000228 RID: 552
		private sealed class XmlKnownTypeNameComparer : IEqualityComparer<IXmlKnownType>
		{
			// Token: 0x06000F4C RID: 3916 RVA: 0x000241D7 File Offset: 0x000223D7
			private XmlKnownTypeNameComparer()
			{
			}

			// Token: 0x06000F4D RID: 3917 RVA: 0x000241DF File Offset: 0x000223DF
			public bool Equals(IXmlKnownType knownTypeA, IXmlKnownType knownTypeB)
			{
				return XmlNameComparer.IgnoreCase.Equals(knownTypeA.Name, knownTypeB.Name);
			}

			// Token: 0x06000F4E RID: 3918 RVA: 0x000241F7 File Offset: 0x000223F7
			public int GetHashCode(IXmlKnownType knownType)
			{
				return XmlNameComparer.IgnoreCase.GetHashCode(knownType.Name);
			}

			// Token: 0x0400044B RID: 1099
			public static readonly XmlKnownTypeSet.XmlKnownTypeNameComparer Instance = new XmlKnownTypeSet.XmlKnownTypeNameComparer();
		}
	}
}
