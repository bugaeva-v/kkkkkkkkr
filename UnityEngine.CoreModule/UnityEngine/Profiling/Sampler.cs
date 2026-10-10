using System;
using System.Collections.Generic;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	// Token: 0x0200027C RID: 636
	[UsedByNativeCode]
	[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
	public class Sampler
	{
		// Token: 0x06001BBD RID: 7101 RVA: 0x00008CE3 File Offset: 0x00006EE3
		internal Sampler()
		{
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0002C82B File Offset: 0x0002AA2B
		internal Sampler(IntPtr ptr)
		{
			this.m_Ptr = ptr;
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x0002C83C File Offset: 0x0002AA3C
		public bool isValid
		{
			get
			{
				return this.m_Ptr != IntPtr.Zero;
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0002C860 File Offset: 0x0002AA60
		public Recorder GetRecorder()
		{
			ProfilerRecorderHandle handle = new ProfilerRecorderHandle((ulong)this.m_Ptr.ToInt64());
			return new Recorder(handle);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0002C88C File Offset: 0x0002AA8C
		public static Sampler Get(string name)
		{
			IntPtr marker = ProfilerUnsafeUtility.GetMarker(name);
			bool flag = marker == IntPtr.Zero;
			Sampler result;
			if (flag)
			{
				result = Sampler.s_InvalidSampler;
			}
			else
			{
				result = new Sampler(marker);
			}
			return result;
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0002C8C4 File Offset: 0x0002AAC4
		public static int GetNames(List<string> names)
		{
			List<ProfilerRecorderHandle> list = new List<ProfilerRecorderHandle>();
			ProfilerRecorderHandle.GetAvailable(list);
			bool flag = names != null;
			if (flag)
			{
				bool flag2 = names.Count < list.Count;
				if (flag2)
				{
					names.Capacity = list.Count;
					for (int i = names.Count; i < list.Count; i++)
					{
						names.Add(null);
					}
				}
				int num = 0;
				foreach (ProfilerRecorderHandle handle in list)
				{
					names[num] = ProfilerRecorderHandle.GetDescription(handle).Name;
					num++;
				}
			}
			return list.Count;
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		public string name
		{
			get
			{
				return ProfilerUnsafeUtility.Internal_GetName(this.m_Ptr);
			}
		}

		// Token: 0x04000912 RID: 2322
		internal IntPtr m_Ptr;

		// Token: 0x04000913 RID: 2323
		internal static Sampler s_InvalidSampler = new Sampler();
	}
}
