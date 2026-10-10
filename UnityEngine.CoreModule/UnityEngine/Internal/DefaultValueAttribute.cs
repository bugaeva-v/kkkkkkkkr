using System;

namespace UnityEngine.Internal
{
	// Token: 0x02000399 RID: 921
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	[Serializable]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x06001F04 RID: 7940 RVA: 0x00032878 File Offset: 0x00030A78
		public DefaultValueAttribute(string value)
		{
			this.DefaultValue = value;
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0003288C File Offset: 0x00030A8C
		public object Value
		{
			get
			{
				return this.DefaultValue;
			}
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x000328A4 File Offset: 0x00030AA4
		public override bool Equals(object obj)
		{
			DefaultValueAttribute defaultValueAttribute = obj as DefaultValueAttribute;
			bool flag = defaultValueAttribute == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = this.DefaultValue == null;
				if (flag2)
				{
					result = (defaultValueAttribute.Value == null);
				}
				else
				{
					result = this.DefaultValue.Equals(defaultValueAttribute.Value);
				}
			}
			return result;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x000328F4 File Offset: 0x00030AF4
		public override int GetHashCode()
		{
			bool flag = this.DefaultValue == null;
			int hashCode;
			if (flag)
			{
				hashCode = base.GetHashCode();
			}
			else
			{
				hashCode = this.DefaultValue.GetHashCode();
			}
			return hashCode;
		}

		// Token: 0x04000A37 RID: 2615
		private object DefaultValue;
	}
}
