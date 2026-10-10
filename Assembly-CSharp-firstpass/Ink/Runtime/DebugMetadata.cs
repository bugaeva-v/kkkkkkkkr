using System;

namespace Ink.Runtime
{
	// Token: 0x02000023 RID: 35
	internal class DebugMetadata
	{
		// Token: 0x06000112 RID: 274 RVA: 0x000098E9 File Offset: 0x00007AE9
		public override string ToString()
		{
			if (this.fileName != null)
			{
				return string.Format("line {0} of {1}", this.startLineNumber, this.fileName);
			}
			return "line " + this.startLineNumber.ToString();
		}

		// Token: 0x0400011E RID: 286
		internal int startLineNumber;

		// Token: 0x0400011F RID: 287
		internal int endLineNumber;

		// Token: 0x04000120 RID: 288
		internal string fileName;

		// Token: 0x04000121 RID: 289
		internal string sourceName;
	}
}
