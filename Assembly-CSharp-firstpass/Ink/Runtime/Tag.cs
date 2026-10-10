using System;

namespace Ink.Runtime
{
	// Token: 0x02000038 RID: 56
	internal class Tag : Object
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00011C68 File Offset: 0x0000FE68
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00011C70 File Offset: 0x0000FE70
		public string text { get; private set; }

		// Token: 0x0600026E RID: 622 RVA: 0x00011C79 File Offset: 0x0000FE79
		public Tag(string tagText)
		{
			this.text = tagText;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00011C88 File Offset: 0x0000FE88
		public override string ToString()
		{
			return "# " + this.text;
		}
	}
}
