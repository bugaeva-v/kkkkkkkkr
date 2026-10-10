using System;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	// Token: 0x0200027B RID: 635
	[UsedByNativeCode]
	public sealed class Recorder
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x00008CE3 File Offset: 0x00006EE3
		internal Recorder()
		{
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0002C510 File Offset: 0x0002A710
		internal Recorder(ProfilerRecorderHandle handle)
		{
			bool flag = !handle.Valid;
			if (!flag)
			{
				this.m_RecorderCPU = new ProfilerRecorder(handle, 1, (ProfilerRecorderOptions)153);
				bool flag2 = (ProfilerRecorderHandle.GetDescription(handle).Flags & MarkerFlags.SampleGPU) > MarkerFlags.Default;
				if (flag2)
				{
					this.m_RecorderGPU = new ProfilerRecorder(handle, 1, (ProfilerRecorderOptions)217);
				}
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0002C574 File Offset: 0x0002A774
		~Recorder()
		{
			this.m_RecorderCPU.Dispose();
			this.m_RecorderGPU.Dispose();
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0002C5B8 File Offset: 0x0002A7B8
		public static Recorder Get(string samplerName)
		{
			ProfilerRecorderHandle handle = ProfilerRecorderHandle.Get(ProfilerCategory.Any, samplerName);
			bool flag = !handle.Valid;
			Recorder result;
			if (flag)
			{
				result = Recorder.s_InvalidRecorder;
			}
			else
			{
				result = new Recorder(handle);
			}
			return result;
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x0002C5F4 File Offset: 0x0002A7F4
		public bool isValid
		{
			get
			{
				return this.m_RecorderCPU.handle > 0UL;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x0002C618 File Offset: 0x0002A818
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0002C635 File Offset: 0x0002A835
		public bool enabled
		{
			get
			{
				return this.m_RecorderCPU.IsRunning;
			}
			set
			{
				this.SetEnabled(value);
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0002C640 File Offset: 0x0002A840
		public long elapsedNanoseconds
		{
			get
			{
				bool flag = !this.m_RecorderCPU.Valid;
				long result;
				if (flag)
				{
					result = 0L;
				}
				else
				{
					result = this.m_RecorderCPU.LastValue;
				}
				return result;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0002C674 File Offset: 0x0002A874
		public long gpuElapsedNanoseconds
		{
			get
			{
				bool flag = !this.m_RecorderGPU.Valid;
				long result;
				if (flag)
				{
					result = 0L;
				}
				else
				{
					result = this.m_RecorderGPU.LastValue;
				}
				return result;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0002C6A8 File Offset: 0x0002A8A8
		public int sampleBlockCount
		{
			get
			{
				bool flag = !this.m_RecorderCPU.Valid;
				int result;
				if (flag)
				{
					result = 0;
				}
				else
				{
					bool flag2 = this.m_RecorderCPU.Count != 1;
					if (flag2)
					{
						result = 0;
					}
					else
					{
						result = (int)this.m_RecorderCPU.GetSample(0).Count;
					}
				}
				return result;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0002C700 File Offset: 0x0002A900
		public int gpuSampleBlockCount
		{
			get
			{
				bool flag = !this.m_RecorderGPU.Valid;
				int result;
				if (flag)
				{
					result = 0;
				}
				else
				{
					bool flag2 = this.m_RecorderGPU.Count != 1;
					if (flag2)
					{
						result = 0;
					}
					else
					{
						result = (int)this.m_RecorderGPU.GetSample(0).Count;
					}
				}
				return result;
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0002C758 File Offset: 0x0002A958
		public void FilterToCurrentThread()
		{
			bool flag = !this.m_RecorderCPU.Valid;
			if (!flag)
			{
				this.m_RecorderCPU.FilterToCurrentThread();
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0002C788 File Offset: 0x0002A988
		public void CollectFromAllThreads()
		{
			bool flag = !this.m_RecorderCPU.Valid;
			if (!flag)
			{
				this.m_RecorderCPU.CollectFromAllThreads();
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
		private void SetEnabled(bool state)
		{
			if (state)
			{
				this.m_RecorderCPU.Start();
				bool valid = this.m_RecorderGPU.Valid;
				if (valid)
				{
					this.m_RecorderGPU.Start();
				}
			}
			else
			{
				this.m_RecorderCPU.Stop();
				bool valid2 = this.m_RecorderGPU.Valid;
				if (valid2)
				{
					this.m_RecorderGPU.Stop();
				}
			}
		}

		// Token: 0x0400090E RID: 2318
		private const ProfilerRecorderOptions s_RecorderDefaultOptions = (ProfilerRecorderOptions)153;

		// Token: 0x0400090F RID: 2319
		internal static Recorder s_InvalidRecorder = new Recorder();

		// Token: 0x04000910 RID: 2320
		private ProfilerRecorder m_RecorderCPU;

		// Token: 0x04000911 RID: 2321
		private ProfilerRecorder m_RecorderGPU;
	}
}
