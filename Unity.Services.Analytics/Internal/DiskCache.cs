using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000033 RID: 51
	internal class DiskCache : IDiskCache
	{
		// Token: 0x0600015E RID: 350 RVA: 0x00005DFC File Offset: 0x00003FFC
		internal DiskCache(IFileSystemCalls systemCalls)
		{
			if (systemCalls.CanAccessFileSystem())
			{
				this.k_CacheFilePath = Application.persistentDataPath + "/eventcache";
			}
			this.k_SystemCalls = systemCalls;
			this.k_CacheFileMaximumSize = 5242880L;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005E34 File Offset: 0x00004034
		internal DiskCache(string cacheFilePath, IFileSystemCalls systemCalls, long maximumFileSize)
		{
			this.k_CacheFilePath = cacheFilePath;
			this.k_SystemCalls = systemCalls;
			this.k_CacheFileMaximumSize = maximumFileSize;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005E54 File Offset: 0x00004054
		public void Write(List<EventSummary> eventSummaries, Stream payload)
		{
			if (eventSummaries.Count > 0 && this.k_SystemCalls.CanAccessFileSystem())
			{
				int num = 0;
				int num2 = 0;
				for (int i = 0; i < eventSummaries.Count; i++)
				{
					if ((long)eventSummaries[i].EndIndex < this.k_CacheFileMaximumSize)
					{
						num = eventSummaries[i].EndIndex;
						num2 = i + 1;
					}
				}
				using (Stream stream = this.k_SystemCalls.OpenFileForWriting(this.k_CacheFilePath))
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(stream))
					{
						binaryWriter.Write("UGSEventCache");
						binaryWriter.Write(2);
						binaryWriter.Write(num2);
						for (int j = 0; j < num2; j++)
						{
							binaryWriter.Write(eventSummaries[j].StartIndex);
							binaryWriter.Write(eventSummaries[j].EndIndex);
							binaryWriter.Write(eventSummaries[j].Id);
						}
						long position = payload.Position;
						payload.Position = 0L;
						for (int k = 0; k < num; k++)
						{
							binaryWriter.Write((byte)payload.ReadByte());
						}
						payload.Position = position;
					}
				}
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005FA4 File Offset: 0x000041A4
		public void Clear()
		{
			if (this.k_SystemCalls.CanAccessFileSystem() && this.k_SystemCalls.FileExists(this.k_CacheFilePath))
			{
				this.k_SystemCalls.DeleteFile(this.k_CacheFilePath);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005FD8 File Offset: 0x000041D8
		public bool Read(List<EventSummary> eventSummaries, Stream buffer)
		{
			if (this.k_SystemCalls.CanAccessFileSystem() && this.k_SystemCalls.FileExists(this.k_CacheFilePath))
			{
				using (Stream stream = this.k_SystemCalls.OpenFileForReading(this.k_CacheFilePath))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						try
						{
							if (binaryReader.ReadString() == "UGSEventCache")
							{
								int num = binaryReader.ReadInt32();
								if (num == 1)
								{
									this.ReadVersionOneCacheFile(eventSummaries, binaryReader, buffer);
									return true;
								}
								if (num == 2)
								{
									this.ReadVersionTwoCacheFile(eventSummaries, binaryReader, buffer);
									return true;
								}
								Debug.LogWarning(string.Format("Unable to read event cache file: unknown file format version {0}", num));
								this.Clear();
							}
							else
							{
								Debug.LogWarning("Unable to read event cache file: corrupt");
								this.Clear();
							}
						}
						catch (Exception)
						{
							Debug.LogWarning("Unable to read event cache file: corrupt");
							this.Clear();
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000060E8 File Offset: 0x000042E8
		private void ReadVersionOneCacheFile(in List<EventSummary> eventEndIndices, BinaryReader reader, in Stream buffer)
		{
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int endIndex = reader.ReadInt32();
				eventEndIndices.Add(new EventSummary
				{
					StartIndex = ((i == 0) ? 0 : eventEndIndices[eventEndIndices.Count - 1].EndIndex),
					EndIndex = endIndex,
					Id = string.Format("loadedFromOldCache{0}", i)
				});
			}
			buffer.SetLength(0L);
			buffer.Position = 0L;
			reader.ReadBytes(14);
			reader.BaseStream.CopyTo(buffer);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00006188 File Offset: 0x00004388
		private void ReadVersionTwoCacheFile(in List<EventSummary> eventSummaries, BinaryReader reader, in Stream buffer)
		{
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int startIndex = reader.ReadInt32();
				int endIndex = reader.ReadInt32();
				string id = reader.ReadString();
				eventSummaries.Add(new EventSummary
				{
					StartIndex = startIndex,
					EndIndex = endIndex,
					Id = id
				});
			}
			buffer.SetLength(0L);
			buffer.Position = 0L;
			reader.BaseStream.CopyTo(buffer);
		}

		// Token: 0x040000B9 RID: 185
		internal const string k_FileHeaderString = "UGSEventCache";

		// Token: 0x040000BA RID: 186
		internal const int k_CacheFileVersionOne = 1;

		// Token: 0x040000BB RID: 187
		internal const int k_CacheFileVersionTwo = 2;

		// Token: 0x040000BC RID: 188
		private readonly string k_CacheFilePath;

		// Token: 0x040000BD RID: 189
		private readonly IFileSystemCalls k_SystemCalls;

		// Token: 0x040000BE RID: 190
		private readonly long k_CacheFileMaximumSize;
	}
}
