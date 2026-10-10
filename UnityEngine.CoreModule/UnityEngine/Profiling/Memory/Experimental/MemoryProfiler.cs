using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Profiling.Experimental;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x02000281 RID: 641
	[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
	public sealed class MemoryProfiler
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06001BD5 RID: 7125 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
		// (remove) Token: 0x06001BD6 RID: 7126 RVA: 0x0002CADC File Offset: 0x0002ACDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static event Action<string, bool> m_SnapshotFinished;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06001BD7 RID: 7127 RVA: 0x0002CB10 File Offset: 0x0002AD10
		// (remove) Token: 0x06001BD8 RID: 7128 RVA: 0x0002CB44 File Offset: 0x0002AD44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static event Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06001BD9 RID: 7129 RVA: 0x0002CB78 File Offset: 0x0002AD78
		// (remove) Token: 0x06001BDA RID: 7130 RVA: 0x0002CBAC File Offset: 0x0002ADAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<MetaData> createMetaData;

		// Token: 0x06001BDB RID: 7131
		[StaticAccessor("profiling::memory::GetMemorySnapshotManager()", StaticAccessorType.Dot)]
		[NativeMethod("StartOperation")]
		[NativeConditional("ENABLE_PROFILER")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void StartOperation(uint captureFlag, bool requestScreenshot, string path, bool isRemote);

		// Token: 0x06001BDC RID: 7132 RVA: 0x0002CBDF File Offset: 0x0002ADDF
		public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = CaptureFlags.ManagedObjects | CaptureFlags.NativeObjects)
		{
			MemoryProfiler.TakeSnapshot(path, finishCallback, null, captureFlags);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0002CBEC File Offset: 0x0002ADEC
		public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = CaptureFlags.ManagedObjects | CaptureFlags.NativeObjects)
		{
			bool flag = MemoryProfiler.m_SnapshotFinished != null;
			if (flag)
			{
				Debug.LogWarning("Canceling snapshot, there is another snapshot in progress.");
				finishCallback(path, false);
			}
			else
			{
				MemoryProfiler.m_SnapshotFinished += finishCallback;
				MemoryProfiler.m_SaveScreenshotToDisk += screenshotCallback;
				MemoryProfiler.StartOperation((uint)captureFlags, MemoryProfiler.m_SaveScreenshotToDisk != null, path, false);
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0002CC40 File Offset: 0x0002AE40
		public static void TakeTempSnapshot(Action<string, bool> finishCallback, CaptureFlags captureFlags = CaptureFlags.ManagedObjects | CaptureFlags.NativeObjects)
		{
			string[] array = Application.dataPath.Split(new char[]
			{
				'/'
			});
			string str = array[array.Length - 2];
			string path = Application.temporaryCachePath + "/" + str + ".snap";
			MemoryProfiler.TakeSnapshot(path, finishCallback, captureFlags);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0002CC8C File Offset: 0x0002AE8C
		[RequiredByNativeCode]
		private static byte[] PrepareMetadata()
		{
			bool flag = MemoryProfiler.createMetaData == null;
			byte[] result;
			if (flag)
			{
				result = new byte[0];
			}
			else
			{
				MetaData metaData = new MetaData();
				MemoryProfiler.createMetaData(metaData);
				bool flag2 = metaData.content == null;
				if (flag2)
				{
					metaData.content = "";
				}
				bool flag3 = metaData.platform == null;
				if (flag3)
				{
					metaData.platform = "";
				}
				int num = 2 * metaData.content.Length;
				int num2 = 2 * metaData.platform.Length;
				int num3 = num + num2 + 12;
				byte[] array = new byte[num3];
				int offset = 0;
				offset = MemoryProfiler.WriteIntToByteArray(array, offset, metaData.content.Length);
				offset = MemoryProfiler.WriteStringToByteArray(array, offset, metaData.content);
				offset = MemoryProfiler.WriteIntToByteArray(array, offset, metaData.platform.Length);
				offset = MemoryProfiler.WriteStringToByteArray(array, offset, metaData.platform);
				result = array;
			}
			return result;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0002CD80 File Offset: 0x0002AF80
		internal unsafe static int WriteIntToByteArray(byte[] array, int offset, int value)
		{
			byte* ptr = (byte*)(&value);
			array[offset++] = *ptr;
			array[offset++] = ptr[1];
			array[offset++] = ptr[2];
			array[offset++] = ptr[3];
			return offset;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0002CDC8 File Offset: 0x0002AFC8
		internal unsafe static int WriteStringToByteArray(byte[] array, int offset, string value)
		{
			bool flag = value.Length != 0;
			if (flag)
			{
				fixed (string text = value)
				{
					char* ptr = text;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr2 = ptr;
					char* ptr3 = ptr + value.Length;
					while (ptr2 != ptr3)
					{
						for (int i = 0; i < 2; i++)
						{
							array[offset++] = *(byte*)(ptr2 + i / 2);
						}
						ptr2++;
					}
				}
			}
			return offset;
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0002CE4C File Offset: 0x0002B04C
		[RequiredByNativeCode]
		private static void FinalizeSnapshot(string path, bool result)
		{
			bool flag = MemoryProfiler.m_SnapshotFinished != null;
			if (flag)
			{
				Action<string, bool> snapshotFinished = MemoryProfiler.m_SnapshotFinished;
				MemoryProfiler.m_SnapshotFinished = null;
				snapshotFinished(path, result);
			}
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0002CE80 File Offset: 0x0002B080
		[RequiredByNativeCode]
		private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height)
		{
			bool flag = MemoryProfiler.m_SaveScreenshotToDisk != null;
			if (flag)
			{
				Action<string, bool, DebugScreenCapture> saveScreenshotToDisk = MemoryProfiler.m_SaveScreenshotToDisk;
				MemoryProfiler.m_SaveScreenshotToDisk = null;
				DebugScreenCapture arg = default(DebugScreenCapture);
				if (result)
				{
					NativeArray<byte> rawImageDataReference = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(pixelsPtr.ToPointer(), pixelsCount, Allocator.Persistent);
					arg.rawImageDataReference = rawImageDataReference;
					arg.height = height;
					arg.width = width;
					arg.imageFormat = format;
				}
				saveScreenshotToDisk(path, result, arg);
			}
		}
	}
}
