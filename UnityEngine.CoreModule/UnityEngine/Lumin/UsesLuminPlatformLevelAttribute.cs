using System;

namespace UnityEngine.Lumin
{
	// Token: 0x02000397 RID: 919
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class UsesLuminPlatformLevelAttribute : Attribute
	{
		// Token: 0x06001F00 RID: 7936 RVA: 0x00032823 File Offset: 0x00030A23
		public UsesLuminPlatformLevelAttribute(uint platformLevel)
		{
			this.m_PlatformLevel = platformLevel;
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x00032834 File Offset: 0x00030A34
		public uint platformLevel
		{
			get
			{
				return this.m_PlatformLevel;
			}
		}

		// Token: 0x04000A35 RID: 2613
		private readonly uint m_PlatformLevel;
	}
}
