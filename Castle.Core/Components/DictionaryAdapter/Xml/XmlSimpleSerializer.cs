using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000196 RID: 406
	public class XmlSimpleSerializer<T> : XmlTypeSerializer
	{
		// Token: 0x06000CB6 RID: 3254 RVA: 0x0001EA81 File Offset: 0x0001CC81
		public XmlSimpleSerializer(Func<T, string> getString, Func<string, T> getObject)
		{
			this.getString = getString;
			this.getObject = getObject;
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0001EA97 File Offset: 0x0001CC97
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Simple;
			}
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0001EA9A File Offset: 0x0001CC9A
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			return this.getObject(node.Value);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0001EAB2 File Offset: 0x0001CCB2
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			node.Value = this.getString((T)((object)value));
		}

		// Token: 0x040002B3 RID: 691
		private readonly Func<T, string> getString;

		// Token: 0x040002B4 RID: 692
		private readonly Func<string, T> getObject;
	}
}
