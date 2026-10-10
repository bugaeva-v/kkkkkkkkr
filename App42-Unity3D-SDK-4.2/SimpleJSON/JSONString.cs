using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x020000A9 RID: 169
	public class JSONString : JSONNode
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x000298D3 File Offset: 0x00027AD3
		public override JSONNodeType Tag
		{
			get
			{
				return JSONNodeType.String;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000298D6 File Offset: 0x00027AD6
		public override bool IsString
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000298DC File Offset: 0x00027ADC
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x000298F2 File Offset: 0x00027AF2
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x000298FA File Offset: 0x00027AFA
		public override string Value
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

		// Token: 0x0600070B RID: 1803 RVA: 0x00029903 File Offset: 0x00027B03
		public JSONString(string aData)
		{
			this.m_Data = aData;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00029912 File Offset: 0x00027B12
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append('"').Append(JSONNode.Escape(this.m_Data)).Append('"');
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00029934 File Offset: 0x00027B34
		public override bool Equals(object obj)
		{
			if (base.Equals(obj))
			{
				return true;
			}
			string text = obj as string;
			if (text != null)
			{
				return this.m_Data == text;
			}
			JSONString jsonstring = obj as JSONString;
			return jsonstring != null && this.m_Data == jsonstring.m_Data;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00029986 File Offset: 0x00027B86
		public override int GetHashCode()
		{
			return this.m_Data.GetHashCode();
		}

		// Token: 0x0400029D RID: 669
		private string m_Data;
	}
}
