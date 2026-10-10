using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002DD RID: 733
	public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool>
	{
		// Token: 0x06001881 RID: 6273 RVA: 0x00064E15 File Offset: 0x00063015
		public UxmlBoolAttributeDescription()
		{
			base.type = "boolean";
			base.typeNamespace = "http://www.w3.org/2001/XMLSchema";
			base.defaultValue = false;
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x00064E40 File Offset: 0x00063040
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString().ToLower();
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00064E68 File Offset: 0x00063068
		public override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return base.GetValueFromBag<bool>(bag, cc, (string s, bool b) => UxmlBoolAttributeDescription.ConvertValueToBool(s, b), base.defaultValue);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00064EA8 File Offset: 0x000630A8
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref bool value)
		{
			return base.TryGetValueFromBag<bool>(bag, cc, (string s, bool b) => UxmlBoolAttributeDescription.ConvertValueToBool(s, b), base.defaultValue, ref value);
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00064EE8 File Offset: 0x000630E8
		private static bool ConvertValueToBool(string v, bool defaultValue)
		{
			bool flag2;
			bool flag = v == null || !bool.TryParse(v, out flag2);
			bool result;
			if (flag)
			{
				result = defaultValue;
			}
			else
			{
				result = flag2;
			}
			return result;
		}
	}
}
