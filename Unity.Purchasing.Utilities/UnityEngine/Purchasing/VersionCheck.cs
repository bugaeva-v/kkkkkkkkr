using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000011 RID: 17
	internal static class VersionCheck
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000253F File Offset: 0x0000073F
		public static bool GreaterThanOrEqual(string versionA, string versionB)
		{
			return !VersionCheck.LessThan(versionA, versionB);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000254B File Offset: 0x0000074B
		public static bool GreaterThan(string versionA, string versionB)
		{
			return !VersionCheck.LessThanOrEqual(versionA, versionB);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002558 File Offset: 0x00000758
		public static bool LessThan(string versionA, string versionB)
		{
			VersionCheck.Version version = VersionCheck.Parse(versionA);
			VersionCheck.Version version2 = VersionCheck.Parse(versionB);
			return version.major <= version2.major && (version.major < version2.major || (version.minor <= version2.minor && (version.minor < version2.minor || (version.patch <= version2.patch && version.patch < version2.patch))));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000025D4 File Offset: 0x000007D4
		public static bool LessThanOrEqual(string versionA, string versionB)
		{
			return VersionCheck.LessThan(versionA, versionB) || !VersionCheck.LessThan(versionB, versionA);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000025EB File Offset: 0x000007EB
		public static bool Equal(string versionA, string versionB)
		{
			return !VersionCheck.LessThan(versionA, versionB) && !VersionCheck.LessThan(versionB, versionA);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002602 File Offset: 0x00000802
		public static int MajorVersion(string version)
		{
			return VersionCheck.PartialVersion(version, 0);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000260B File Offset: 0x0000080B
		public static int MinorVersion(string version)
		{
			return VersionCheck.PartialVersion(version, 1);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002614 File Offset: 0x00000814
		public static int PatchVersion(string version)
		{
			return VersionCheck.PartialVersion(version, 2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002620 File Offset: 0x00000820
		public static VersionCheck.Version Parse(string version)
		{
			return new VersionCheck.Version
			{
				major = VersionCheck.MajorVersion(version),
				minor = VersionCheck.MinorVersion(version),
				patch = VersionCheck.PatchVersion(version)
			};
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002660 File Offset: 0x00000860
		private static int PartialVersion(string version, int index)
		{
			string text = version.Split(new char[]
			{
				'a',
				'b',
				'f',
				'p'
			})[0];
			int result = 0;
			string[] array = text.Split('.', StringSplitOptions.None);
			if (array.Length < index + 1)
			{
				return result;
			}
			int.TryParse(array[index], out result);
			return result;
		}

		// Token: 0x0200001B RID: 27
		internal struct Version
		{
			// Token: 0x0400002B RID: 43
			public int major;

			// Token: 0x0400002C RID: 44
			public int minor;

			// Token: 0x0400002D RID: 45
			public int patch;
		}
	}
}
