using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002DF RID: 735
	public class UxmlColorAttributeDescription : TypedUxmlAttributeDescription<Color>
	{
		// Token: 0x0600188A RID: 6282 RVA: 0x00064F2C File Offset: 0x0006312C
		public UxmlColorAttributeDescription()
		{
			base.type = "string";
			base.typeNamespace = "http://www.w3.org/2001/XMLSchema";
			base.defaultValue = new Color(0f, 0f, 0f, 1f);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00064F7C File Offset: 0x0006317C
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString();
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00064FA4 File Offset: 0x000631A4
		public override Color GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return base.GetValueFromBag<Color>(bag, cc, (string s, Color color) => UxmlColorAttributeDescription.ConvertValueToColor(s, color), base.defaultValue);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00064FE4 File Offset: 0x000631E4
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref Color value)
		{
			return base.TryGetValueFromBag<Color>(bag, cc, (string s, Color color) => UxmlColorAttributeDescription.ConvertValueToColor(s, color), base.defaultValue, ref value);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00065024 File Offset: 0x00063224
		private static Color ConvertValueToColor(string v, Color defaultValue)
		{
			Color color;
			bool flag = v == null || !ColorUtility.TryParseHtmlString(v, out color);
			Color result;
			if (flag)
			{
				result = defaultValue;
			}
			else
			{
				result = color;
			}
			return result;
		}
	}
}
