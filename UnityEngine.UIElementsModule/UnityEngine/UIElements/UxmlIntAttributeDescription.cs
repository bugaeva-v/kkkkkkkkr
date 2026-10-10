using System;
using System.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020002D9 RID: 729
	public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int>
	{
		// Token: 0x0600186F RID: 6255 RVA: 0x00064BE3 File Offset: 0x00062DE3
		public UxmlIntAttributeDescription()
		{
			base.type = "int";
			base.typeNamespace = "http://www.w3.org/2001/XMLSchema";
			base.defaultValue = 0;
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00064C10 File Offset: 0x00062E10
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00064C3C File Offset: 0x00062E3C
		public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return base.GetValueFromBag<int>(bag, cc, (string s, int i) => UxmlIntAttributeDescription.ConvertValueToInt(s, i), base.defaultValue);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00064C7C File Offset: 0x00062E7C
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value)
		{
			return base.TryGetValueFromBag<int>(bag, cc, (string s, int i) => UxmlIntAttributeDescription.ConvertValueToInt(s, i), base.defaultValue, ref value);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00064CBC File Offset: 0x00062EBC
		private static int ConvertValueToInt(string v, int defaultValue)
		{
			int num;
			bool flag = v == null || !int.TryParse(v, out num);
			int result;
			if (flag)
			{
				result = defaultValue;
			}
			else
			{
				result = num;
			}
			return result;
		}
	}
}
