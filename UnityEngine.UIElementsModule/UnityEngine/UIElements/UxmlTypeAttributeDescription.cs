using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E1 RID: 737
	public class UxmlTypeAttributeDescription<TBase> : TypedUxmlAttributeDescription<Type>
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x00065065 File Offset: 0x00063265
		public UxmlTypeAttributeDescription()
		{
			base.type = "string";
			base.typeNamespace = "http://www.w3.org/2001/XMLSchema";
			base.defaultValue = null;
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00065090 File Offset: 0x00063290
		public override string defaultValueAsString
		{
			get
			{
				return (base.defaultValue == null) ? "null" : base.defaultValue.FullName;
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x000650BC File Offset: 0x000632BC
		public override Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return base.GetValueFromBag<Type>(bag, cc, (string s, Type type1) => this.ConvertValueToType(s, type1), base.defaultValue);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x000650E8 File Offset: 0x000632E8
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref Type value)
		{
			return base.TryGetValueFromBag<Type>(bag, cc, (string s, Type type1) => this.ConvertValueToType(s, type1), base.defaultValue, ref value);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00065118 File Offset: 0x00063318
		private Type ConvertValueToType(string v, Type defaultValue)
		{
			bool flag = string.IsNullOrEmpty(v);
			Type result;
			if (flag)
			{
				result = defaultValue;
			}
			else
			{
				try
				{
					Type type = Type.GetType(v, true);
					bool flag2 = !typeof(TBase).IsAssignableFrom(type);
					if (!flag2)
					{
						return type;
					}
					Debug.LogError(string.Concat(new string[]
					{
						"Type: Invalid type \"",
						v,
						"\". Type must derive from ",
						typeof(TBase).FullName,
						"."
					}));
				}
				catch (Exception exception)
				{
					Debug.LogException(exception);
				}
				result = defaultValue;
			}
			return result;
		}
	}
}
