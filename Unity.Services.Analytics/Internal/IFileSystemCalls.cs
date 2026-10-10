using System;
using System.IO;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000031 RID: 49
	internal interface IFileSystemCalls
	{
		// Token: 0x06000153 RID: 339
		bool CanAccessFileSystem();

		// Token: 0x06000154 RID: 340
		bool FileExists(string path);

		// Token: 0x06000155 RID: 341
		void DeleteFile(string path);

		// Token: 0x06000156 RID: 342
		Stream OpenFileForWriting(string path);

		// Token: 0x06000157 RID: 343
		Stream OpenFileForReading(string path);
	}
}
