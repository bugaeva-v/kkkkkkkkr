using System;
using System.IO;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000B RID: 11
	internal class FileReference
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000021A8 File Offset: 0x000003A8
		internal static FileReference CreateInstance(string filename, ILogger logger, IUtil util)
		{
			FileReference result;
			try
			{
				string path = Path.Combine(util.persistentDataPath, "Unity");
				string path2 = Path.Combine(util.cloudProjectId, "IAP");
				string text = Path.Combine(path, path2);
				Directory.CreateDirectory(text);
				result = new FileReference(Path.Combine(text, filename), logger);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002208 File Offset: 0x00000408
		internal FileReference(string filePath, ILogger logger)
		{
			this.m_FilePath = filePath;
			this.m_Logger = logger;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002220 File Offset: 0x00000420
		internal void Save(string payload)
		{
			try
			{
				File.WriteAllText(this.m_FilePath, payload);
			}
			catch (Exception arg)
			{
				this.m_Logger.LogIAPError(string.Format("Failed persisting content: {0}", arg));
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002264 File Offset: 0x00000464
		internal string Load()
		{
			string result;
			try
			{
				result = File.ReadAllText(this.m_FilePath);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002298 File Offset: 0x00000498
		internal void Delete()
		{
			try
			{
				File.Delete(this.m_FilePath);
			}
			catch (Exception arg)
			{
				this.m_Logger.LogIAPWarning(string.Format("Failed deleting cached content: {0}", arg));
			}
		}

		// Token: 0x04000005 RID: 5
		private readonly string m_FilePath;

		// Token: 0x04000006 RID: 6
		private readonly ILogger m_Logger;
	}
}
