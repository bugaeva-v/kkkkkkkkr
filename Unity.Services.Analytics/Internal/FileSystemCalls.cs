using System;
using System.IO;
using UnityEngine;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000032 RID: 50
	internal class FileSystemCalls : IFileSystemCalls
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00005D7C File Offset: 0x00003F7C
		internal FileSystemCalls()
		{
			this.m_CanAccessFileSystem = (Application.platform != RuntimePlatform.Switch && Application.platform != RuntimePlatform.GameCoreXboxOne && Application.platform != RuntimePlatform.GameCoreXboxSeries && Application.platform != RuntimePlatform.PS5 && Application.platform != RuntimePlatform.PS4 && !string.IsNullOrEmpty(Application.persistentDataPath));
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005DD2 File Offset: 0x00003FD2
		public bool CanAccessFileSystem()
		{
			return this.m_CanAccessFileSystem;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005DDA File Offset: 0x00003FDA
		public bool FileExists(string path)
		{
			return File.Exists(path);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005DE2 File Offset: 0x00003FE2
		public void DeleteFile(string path)
		{
			File.Delete(path);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005DEA File Offset: 0x00003FEA
		public Stream OpenFileForWriting(string path)
		{
			return new FileStream(path, FileMode.Create);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005DF3 File Offset: 0x00003FF3
		public Stream OpenFileForReading(string path)
		{
			return new FileStream(path, FileMode.Open);
		}

		// Token: 0x040000B8 RID: 184
		private readonly bool m_CanAccessFileSystem;
	}
}
