using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000CE RID: 206
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class CollectionAccessAttribute : Attribute
	{
		// Token: 0x06000376 RID: 886 RVA: 0x00005E92 File Offset: 0x00004092
		public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
		{
			this.CollectionAccessType = collectionAccessType;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00005EA3 File Offset: 0x000040A3
		public CollectionAccessType CollectionAccessType { get; }
	}
}
