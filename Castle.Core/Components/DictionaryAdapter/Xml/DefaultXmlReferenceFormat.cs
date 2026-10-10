using System;
using System.Globalization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000152 RID: 338
	public sealed class DefaultXmlReferenceFormat : IXmlReferenceFormat
	{
		// Token: 0x0600098B RID: 2443 RVA: 0x00017BF1 File Offset: 0x00015DF1
		private DefaultXmlReferenceFormat()
		{
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00017BF9 File Offset: 0x00015DF9
		public bool TryGetIdentity(IXmlNode node, out int id)
		{
			return int.TryParse(node.GetAttribute(XRef.Id), NumberStyles.Integer, DefaultXmlReferenceFormat.Culture, out id);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00017C12 File Offset: 0x00015E12
		public bool TryGetReference(IXmlNode node, out int id)
		{
			return int.TryParse(node.GetAttribute(XRef.Ref), NumberStyles.Integer, DefaultXmlReferenceFormat.Culture, out id);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00017C2B File Offset: 0x00015E2B
		public void SetIdentity(IXmlNode node, int id)
		{
			node.SetAttribute(XRef.Id, id.ToString(DefaultXmlReferenceFormat.Culture));
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00017C44 File Offset: 0x00015E44
		public void SetReference(IXmlNode node, int id)
		{
			node.SetAttribute(XRef.Ref, id.ToString(DefaultXmlReferenceFormat.Culture));
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00017C5D File Offset: 0x00015E5D
		public void ClearIdentity(IXmlNode node)
		{
			node.SetAttribute(XRef.Id, null);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00017C6B File Offset: 0x00015E6B
		public void ClearReference(IXmlNode node)
		{
			node.SetAttribute(XRef.Ref, null);
		}

		// Token: 0x04000211 RID: 529
		public static readonly DefaultXmlReferenceFormat Instance = new DefaultXmlReferenceFormat();

		// Token: 0x04000212 RID: 530
		private const NumberStyles IntegerStyle = NumberStyles.Integer;

		// Token: 0x04000213 RID: 531
		private static readonly IFormatProvider Culture = CultureInfo.InvariantCulture;
	}
}
