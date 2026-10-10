using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x020000AA RID: 170
	public class JSONNumber : JSONNode
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00029993 File Offset: 0x00027B93
		public override JSONNodeType Tag
		{
			get
			{
				return JSONNodeType.Number;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00029996 File Offset: 0x00027B96
		public override bool IsNumber
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0002999C File Offset: 0x00027B9C
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x000299B2 File Offset: 0x00027BB2
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000299C0 File Offset: 0x00027BC0
		public override string Value
		{
			get
			{
				return this.m_Data.ToString();
			}
			set
			{
				double data;
				if (double.TryParse(value, out data))
				{
					this.m_Data = data;
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000299DE File Offset: 0x00027BDE
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000299E6 File Offset: 0x00027BE6
		public override double AsDouble
		{
			get
			{
				return this.m_Data;
			}
			set
			{
				this.m_Data = value;
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000299EF File Offset: 0x00027BEF
		public JSONNumber(double aData)
		{
			this.m_Data = aData;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000299FE File Offset: 0x00027BFE
		public JSONNumber(string aData)
		{
			this.Value = aData;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00029A0D File Offset: 0x00027C0D
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append(this.m_Data);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00029A1C File Offset: 0x00027C1C
		private static bool IsNumeric(object value)
		{
			return value is int || value is uint || value is float || value is double || value is decimal || value is long || value is ulong || value is short || value is ushort || value is sbyte || value is byte;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00029A84 File Offset: 0x00027C84
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (base.Equals(obj))
			{
				return true;
			}
			JSONNumber jsonnumber = obj as JSONNumber;
			if (jsonnumber != null)
			{
				return this.m_Data == jsonnumber.m_Data;
			}
			return JSONNumber.IsNumeric(obj) && Convert.ToDouble(obj) == this.m_Data;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00029AD8 File Offset: 0x00027CD8
		public override int GetHashCode()
		{
			return this.m_Data.GetHashCode();
		}

		// Token: 0x0400029E RID: 670
		private double m_Data;
	}
}
