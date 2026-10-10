using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E4 RID: 740
	public class UxmlHash128AttributeDescription : TypedUxmlAttributeDescription<Hash128>
	{
		// Token: 0x060018A3 RID: 6307 RVA: 0x000653C4 File Offset: 0x000635C4
		public UxmlHash128AttributeDescription()
		{
			base.type = "string";
			base.typeNamespace = "http://www.w3.org/2001/XMLSchema";
			base.defaultValue = default(Hash128);
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x00065404 File Offset: 0x00063604
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString();
			}
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0006542C File Offset: 0x0006362C
		public override Hash128 GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return base.GetValueFromBag<Hash128>(bag, cc, (string s, Hash128 i) => Hash128.Parse(s), base.defaultValue);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0006546C File Offset: 0x0006366C
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref Hash128 value)
		{
			return base.TryGetValueFromBag<Hash128>(bag, cc, (string s, Hash128 i) => Hash128.Parse(s), base.defaultValue, ref value);
		}
	}
}
