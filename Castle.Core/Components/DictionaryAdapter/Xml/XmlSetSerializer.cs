using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000195 RID: 405
	public class XmlSetSerializer : XmlCollectionSerializer
	{
		// Token: 0x06000CB3 RID: 3251 RVA: 0x0001EA61 File Offset: 0x0001CC61
		protected XmlSetSerializer()
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0001EA69 File Offset: 0x0001CC69
		public override Type ListTypeConstructor
		{
			get
			{
				return typeof(XmlNodeSet<>);
			}
		}

		// Token: 0x040002B2 RID: 690
		public static readonly XmlSetSerializer Instance = new XmlSetSerializer();
	}
}
