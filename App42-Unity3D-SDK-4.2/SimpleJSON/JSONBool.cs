using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x020000AB RID: 171
	public class JSONBool : JSONNode
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00029AE5 File Offset: 0x00027CE5
		public override JSONNodeType Tag
		{
			get
			{
				return JSONNodeType.Boolean;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00029AE8 File Offset: 0x00027CE8
		public override bool IsBoolean
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00029AEC File Offset: 0x00027CEC
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00029B02 File Offset: 0x00027D02
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00029B10 File Offset: 0x00027D10
		public override string Value
		{
			get
			{
				return this.m_Data.ToString();
			}
			set
			{
				bool data;
				if (bool.TryParse(value, out data))
				{
					this.m_Data = data;
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00029B2E File Offset: 0x00027D2E
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00029B36 File Offset: 0x00027D36
		public override bool AsBool
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

		// Token: 0x06000723 RID: 1827 RVA: 0x00029B3F File Offset: 0x00027D3F
		public JSONBool(bool aData)
		{
			this.m_Data = aData;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00029B4E File Offset: 0x00027D4E
		public JSONBool(string aData)
		{
			this.Value = aData;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00029B5D File Offset: 0x00027D5D
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append(this.m_Data ? "true" : "false");
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00029B7A File Offset: 0x00027D7A
		public override bool Equals(object obj)
		{
			return obj != null && obj is bool && this.m_Data == (bool)obj;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00029B99 File Offset: 0x00027D99
		public override int GetHashCode()
		{
			return this.m_Data.GetHashCode();
		}

		// Token: 0x0400029F RID: 671
		private bool m_Data;
	}
}
