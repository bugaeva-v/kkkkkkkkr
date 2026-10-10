using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Services.Core.Configuration
{
	// Token: 0x0200000C RID: 12
	internal static class StreamingAssetsUtils
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002468 File Offset: 0x00000668
		public static Task<string> GetFileTextFromStreamingAssetsAsync(string path)
		{
			string path2 = Path.Combine(Application.streamingAssetsPath, path);
			TaskCompletionSource<string> taskCompletionSource = new TaskCompletionSource<string>();
			try
			{
				string result = File.ReadAllText(path2);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
			return taskCompletionSource.Task;
		}
	}
}
