using System;

namespace NSubstitute.Core
{
	// Token: 0x02000092 RID: 146
	public interface IParameterInfo
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000220 RID: 544
		Type ParameterType { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000221 RID: 545
		bool IsParams { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000222 RID: 546
		bool IsOptional { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000223 RID: 547
		bool IsOut { get; }
	}
}
