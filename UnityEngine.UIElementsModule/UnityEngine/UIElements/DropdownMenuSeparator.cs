using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000022 RID: 34
	public class DropdownMenuSeparator : DropdownMenuItem
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000050B3 File Offset: 0x000032B3
		public string subMenuPath { get; }

		// Token: 0x060000E0 RID: 224 RVA: 0x000050BB File Offset: 0x000032BB
		public DropdownMenuSeparator(string subMenuPath)
		{
			this.subMenuPath = subMenuPath;
		}
	}
}
