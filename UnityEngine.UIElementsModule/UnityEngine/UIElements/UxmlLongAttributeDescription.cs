using System;
using System.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020002DB RID: 731
	public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long>
	{
		// Token: 0x06001878 RID: 6264 RVA: 0x00064CFD File Offset: 0x00062EFD
		public UxmlLongAttributeDescription()
		{
			base.type = "long";
			base.typeNamespace = "http://www.w3.org/2001/XMLSchema";
			base.defaultValue = 0L;
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x00064D28 File Offset: 0x00062F28
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00064D54 File Offset: 0x00062F54
		public override long GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return base.GetValueFromBag<long>(bag, cc, (string s, long l) => UxmlLongAttributeDescription.ConvertValueToLong(s, l), base.defaultValue);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00064D94 File Offset: 0x00062F94
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref long value)
		{
			return base.TryGetValueFromBag<long>(bag, cc, (string s, long l) => UxmlLongAttributeDescription.ConvertValueToLong(s, l), base.defaultValue, ref value);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00064DD4 File Offset: 0x00062FD4
		private static long ConvertValueToLong(string v, long defaultValue)
		{
			long num;
			bool flag = v == null || !long.TryParse(v, out num);
			long result;
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
