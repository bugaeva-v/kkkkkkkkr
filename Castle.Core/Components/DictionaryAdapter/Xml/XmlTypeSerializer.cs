using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200019A RID: 410
	public abstract class XmlTypeSerializer
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000CC3 RID: 3267
		public abstract XmlTypeKind Kind { get; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0001EDB2 File Offset: 0x0001CFB2
		public virtual bool CanGetStub
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0001EDB5 File Offset: 0x0001CFB5
		public virtual object GetStub(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000CC6 RID: 3270
		public abstract object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor);

		// Token: 0x06000CC7 RID: 3271
		public abstract void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value);

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0001EDBC File Offset: 0x0001CFBC
		public static XmlTypeSerializer For(Type type)
		{
			return XmlTypeSerializerCache.Instance[type];
		}
	}
}
