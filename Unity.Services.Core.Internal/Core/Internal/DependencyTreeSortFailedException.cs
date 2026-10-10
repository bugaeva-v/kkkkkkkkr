using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000040 RID: 64
	internal class DependencyTreeSortFailedException : Exception
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00002FC4 File Offset: 0x000011C4
		public DependencyTreeSortFailedException(DependencyTree tree, ICollection<int> target) : base(DependencyTreeSortFailedException.CreateExceptionMessage(tree, target, null))
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002FD4 File Offset: 0x000011D4
		public DependencyTreeSortFailedException(DependencyTree tree, ICollection<int> target, Exception inner) : base(DependencyTreeSortFailedException.CreateExceptionMessage(tree, target, inner), inner)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002FE8 File Offset: 0x000011E8
		private static string CreateExceptionMessage(DependencyTree tree, ICollection<int> target, Exception inner = null)
		{
			string str = tree.ToJson(target);
			return "Failed to sort tree! It is likely there is a missing required dependency:\n" + str + ((inner != null) ? ("\n Error: " + inner.Message) : string.Empty);
		}
	}
}
