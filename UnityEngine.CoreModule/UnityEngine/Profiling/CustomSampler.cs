using System;
using System.Diagnostics;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	// Token: 0x0200027D RID: 637
	[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
	[NativeHeader("Runtime/Profiler/Marker.h")]
	[UsedByNativeCode]
	public sealed class CustomSampler : Sampler
	{
		// Token: 0x06001BC5 RID: 7109 RVA: 0x0002C9C9 File Offset: 0x0002ABC9
		internal CustomSampler()
		{
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0002C9D3 File Offset: 0x0002ABD3
		internal CustomSampler(IntPtr ptr)
		{
			this.m_Ptr = ptr;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0002C9E4 File Offset: 0x0002ABE4
		public static CustomSampler Create(string name, bool collectGpuData = false)
		{
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker(name, 1, MarkerFlags.AvailabilityNonDevelopment | (collectGpuData ? MarkerFlags.SampleGPU : MarkerFlags.Default), 0);
			bool flag = intPtr == IntPtr.Zero;
			CustomSampler result;
			if (flag)
			{
				result = CustomSampler.s_InvalidCustomSampler;
			}
			else
			{
				result = new CustomSampler(intPtr);
			}
			return result;
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0002CA29 File Offset: 0x0002AC29
		[Conditional("ENABLE_PROFILER")]
		public void Begin()
		{
			ProfilerUnsafeUtility.BeginSample(this.m_Ptr);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0002CA38 File Offset: 0x0002AC38
		[Conditional("ENABLE_PROFILER")]
		public void Begin(Object targetObject)
		{
			ProfilerUnsafeUtility.Internal_BeginWithObject(this.m_Ptr, targetObject);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0002CA48 File Offset: 0x0002AC48
		[Conditional("ENABLE_PROFILER")]
		public void End()
		{
			ProfilerUnsafeUtility.EndSample(this.m_Ptr);
		}

		// Token: 0x04000914 RID: 2324
		internal static CustomSampler s_InvalidCustomSampler = new CustomSampler();
	}
}
