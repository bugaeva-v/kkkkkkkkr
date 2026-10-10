using System;

namespace Ink.Runtime
{
	// Token: 0x02000035 RID: 53
	public class StoryException : Exception
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0001075F File Offset: 0x0000E95F
		public StoryException()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00010767 File Offset: 0x0000E967
		public StoryException(string message) : base(message)
		{
		}

		// Token: 0x04000185 RID: 389
		internal bool useEndLineNumber;
	}
}
