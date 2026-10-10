using System;

namespace Ink.Runtime
{
	// Token: 0x02000027 RID: 39
	internal interface INamedContent
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600012F RID: 303
		string name { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000130 RID: 304
		bool hasValidName { get; }
	}
}
