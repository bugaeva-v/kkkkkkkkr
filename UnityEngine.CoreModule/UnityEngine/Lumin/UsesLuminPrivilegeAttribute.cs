using System;

namespace UnityEngine.Lumin
{
	// Token: 0x02000398 RID: 920
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class UsesLuminPrivilegeAttribute : Attribute
	{
		// Token: 0x06001F02 RID: 7938 RVA: 0x0003284C File Offset: 0x00030A4C
		public UsesLuminPrivilegeAttribute(string privilege)
		{
			this.m_Privilege = privilege;
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x00032860 File Offset: 0x00030A60
		public string privilege
		{
			get
			{
				return this.m_Privilege;
			}
		}

		// Token: 0x04000A36 RID: 2614
		private readonly string m_Privilege;
	}
}
