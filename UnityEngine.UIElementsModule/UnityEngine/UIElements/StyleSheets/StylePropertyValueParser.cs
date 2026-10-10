using System;
using System.Collections.Generic;
using System.Text;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000378 RID: 888
	internal class StylePropertyValueParser
	{
		// Token: 0x06001CA4 RID: 7332 RVA: 0x00087B3C File Offset: 0x00085D3C
		public string[] Parse(string propertyValue)
		{
			this.m_PropertyValue = propertyValue;
			this.m_ValueList.Clear();
			this.m_StringBuilder.Remove(0, this.m_StringBuilder.Length);
			this.m_ParseIndex = 0;
			while (this.m_ParseIndex < this.m_PropertyValue.Length)
			{
				char c = this.m_PropertyValue[this.m_ParseIndex];
				char c2 = c;
				char c3 = c2;
				if (c3 != ' ')
				{
					if (c3 != '(')
					{
						if (c3 != ',')
						{
							this.m_StringBuilder.Append(c);
						}
						else
						{
							this.EatSpace();
							this.AddValuePart();
							this.m_ValueList.Add(",");
						}
					}
					else
					{
						this.AppendFunction();
					}
				}
				else
				{
					this.EatSpace();
					this.AddValuePart();
				}
				this.m_ParseIndex++;
			}
			string text = this.m_StringBuilder.ToString();
			bool flag = !string.IsNullOrEmpty(text);
			if (flag)
			{
				this.m_ValueList.Add(text);
			}
			return this.m_ValueList.ToArray();
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00087C5C File Offset: 0x00085E5C
		private void AddValuePart()
		{
			string item = this.m_StringBuilder.ToString();
			this.m_StringBuilder.Remove(0, this.m_StringBuilder.Length);
			this.m_ValueList.Add(item);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00087C9C File Offset: 0x00085E9C
		private void AppendFunction()
		{
			while (this.m_ParseIndex < this.m_PropertyValue.Length && this.m_PropertyValue[this.m_ParseIndex] != ')')
			{
				this.m_StringBuilder.Append(this.m_PropertyValue[this.m_ParseIndex]);
				this.m_ParseIndex++;
			}
			this.m_StringBuilder.Append(this.m_PropertyValue[this.m_ParseIndex]);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00087D28 File Offset: 0x00085F28
		private void EatSpace()
		{
			while (this.m_ParseIndex + 1 < this.m_PropertyValue.Length && this.m_PropertyValue[this.m_ParseIndex + 1] == ' ')
			{
				this.m_ParseIndex++;
			}
		}

		// Token: 0x04000E49 RID: 3657
		private string m_PropertyValue;

		// Token: 0x04000E4A RID: 3658
		private List<string> m_ValueList = new List<string>();

		// Token: 0x04000E4B RID: 3659
		private StringBuilder m_StringBuilder = new StringBuilder();

		// Token: 0x04000E4C RID: 3660
		private int m_ParseIndex = 0;
	}
}
