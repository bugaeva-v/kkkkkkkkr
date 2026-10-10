using System;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000038 RID: 56
	public struct StringOptions : IPlugOptions
	{
		// Token: 0x06000213 RID: 531 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		public void Reset()
		{
			this.richTextEnabled = false;
			this.scrambleMode = ScrambleMode.None;
			this.scrambledChars = null;
			this.startValueStrippedLength = (this.changeValueStrippedLength = 0);
		}

		// Token: 0x040000E9 RID: 233
		public bool richTextEnabled;

		// Token: 0x040000EA RID: 234
		public ScrambleMode scrambleMode;

		// Token: 0x040000EB RID: 235
		public char[] scrambledChars;

		// Token: 0x040000EC RID: 236
		internal int startValueStrippedLength;

		// Token: 0x040000ED RID: 237
		internal int changeValueStrippedLength;
	}
}
