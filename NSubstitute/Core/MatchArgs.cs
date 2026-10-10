using System;
using System.Diagnostics;

namespace NSubstitute.Core
{
	// Token: 0x020000A5 RID: 165
	[DebuggerDisplay("{_name}")]
	public class MatchArgs
	{
		// Token: 0x06000279 RID: 633 RVA: 0x00006A34 File Offset: 0x00004C34
		private MatchArgs(string name)
		{
			this._name = name;
		}

		// Token: 0x040000A6 RID: 166
		private readonly string _name;

		// Token: 0x040000A7 RID: 167
		public static readonly MatchArgs AsSpecifiedInCall = new MatchArgs("AsSpecifiedInCall");

		// Token: 0x040000A8 RID: 168
		public static readonly MatchArgs Any = new MatchArgs("Any");
	}
}
