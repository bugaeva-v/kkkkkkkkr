using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000BA RID: 186
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
	public sealed class ValueProviderAttribute : Attribute
	{
		// Token: 0x06000343 RID: 835 RVA: 0x00005CAF File Offset: 0x00003EAF
		public ValueProviderAttribute([NotNull] string name)
		{
			this.Name = name;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00005CC0 File Offset: 0x00003EC0
		[NotNull]
		public string Name { get; }
	}
}
