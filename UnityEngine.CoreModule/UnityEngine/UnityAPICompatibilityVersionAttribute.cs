using System;

namespace UnityEngine
{
	// Token: 0x02000225 RID: 549
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public class UnityAPICompatibilityVersionAttribute : Attribute
	{
		// Token: 0x0600179B RID: 6043 RVA: 0x0002638A File Offset: 0x0002458A
		[Obsolete("This overload of the attribute has been deprecated. Use the constructor that takes the version and a boolean", true)]
		public UnityAPICompatibilityVersionAttribute(string version)
		{
			this._version = version;
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0002639C File Offset: 0x0002459C
		public UnityAPICompatibilityVersionAttribute(string version, bool checkOnlyUnityVersion)
		{
			bool flag = !checkOnlyUnityVersion;
			if (flag)
			{
				throw new ArgumentException("You must pass 'true' to checkOnlyUnityVersion parameter.");
			}
			this._version = version;
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x000263CB File Offset: 0x000245CB
		public UnityAPICompatibilityVersionAttribute(string version, string[] configurationAssembliesHashes)
		{
			this._version = version;
			this._configurationAssembliesHashes = configurationAssembliesHashes;
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x000263E4 File Offset: 0x000245E4
		public string version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x000263FC File Offset: 0x000245FC
		internal string[] configurationAssembliesHashes
		{
			get
			{
				return this._configurationAssembliesHashes;
			}
		}

		// Token: 0x04000818 RID: 2072
		private string _version;

		// Token: 0x04000819 RID: 2073
		private string[] _configurationAssembliesHashes;
	}
}
