using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002D3 RID: 723
	public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string>
	{
		// Token: 0x06001855 RID: 6229 RVA: 0x000648BB File Offset: 0x00062ABB
		public UxmlStringAttributeDescription()
		{
			base.type = "string";
			base.typeNamespace = "http://www.w3.org/2001/XMLSchema";
			base.defaultValue = "";
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x000648EC File Offset: 0x00062AEC
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue;
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00064904 File Offset: 0x00062B04
		public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return base.GetValueFromBag<string>(bag, cc, (string s, string t) => s, base.defaultValue);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00064944 File Offset: 0x00062B44
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value)
		{
			return base.TryGetValueFromBag<string>(bag, cc, (string s, string t) => s, base.defaultValue, ref value);
		}
	}
}
