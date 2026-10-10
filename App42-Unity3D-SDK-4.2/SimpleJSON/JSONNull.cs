using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x020000AC RID: 172
	public class JSONNull : JSONNode
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x00029BA6 File Offset: 0x00027DA6
		public static JSONNull CreateOrGet()
		{
			if (JSONNull.reuseSameInstance)
			{
				return JSONNull.m_StaticInstance;
			}
			return new JSONNull();
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00029BBA File Offset: 0x00027DBA
		private JSONNull()
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00029BC2 File Offset: 0x00027DC2
		public override JSONNodeType Tag
		{
			get
			{
				return JSONNodeType.NullValue;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00029BC5 File Offset: 0x00027DC5
		public override bool IsNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00029BC8 File Offset: 0x00027DC8
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00029BDE File Offset: 0x00027DDE
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00029BE5 File Offset: 0x00027DE5
		public override string Value
		{
			get
			{
				return "null";
			}
			set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00029BE7 File Offset: 0x00027DE7
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00029BEA File Offset: 0x00027DEA
		public override bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00029BEC File Offset: 0x00027DEC
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj) || obj is JSONNull;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00029C02 File Offset: 0x00027E02
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00029C05 File Offset: 0x00027E05
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append("null");
		}

		// Token: 0x040002A0 RID: 672
		private static JSONNull m_StaticInstance = new JSONNull();

		// Token: 0x040002A1 RID: 673
		public static bool reuseSameInstance = true;
	}
}
