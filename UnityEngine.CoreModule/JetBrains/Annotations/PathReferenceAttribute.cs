using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000CB RID: 203
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class PathReferenceAttribute : Attribute
	{
		// Token: 0x0600036B RID: 875 RVA: 0x00002059 File Offset: 0x00000259
		public PathReferenceAttribute()
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00005E46 File Offset: 0x00004046
		public PathReferenceAttribute([NotNull] [PathReference] string basePath)
		{
			this.BasePath = basePath;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00005E57 File Offset: 0x00004057
		[CanBeNull]
		public string BasePath { get; }
	}
}
