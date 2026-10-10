using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000409 RID: 1033
	public static class RenderPipelineManager
	{
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x0003B142 File Offset: 0x00039342
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x0003B149 File Offset: 0x00039349
		public static RenderPipeline currentPipeline
		{
			get
			{
				return RenderPipelineManager.s_currentPipeline;
			}
			private set
			{
				RenderPipelineManager.s_currentPipelineType = ((value != null) ? value.GetType().ToString() : "Built-in Pipeline");
				RenderPipelineManager.s_currentPipeline = value;
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06002329 RID: 9001 RVA: 0x0003B16C File Offset: 0x0003936C
		// (remove) Token: 0x0600232A RID: 9002 RVA: 0x0003B1A0 File Offset: 0x000393A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<ScriptableRenderContext, List<Camera>> beginContextRendering;

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x0600232B RID: 9003 RVA: 0x0003B1D4 File Offset: 0x000393D4
		// (remove) Token: 0x0600232C RID: 9004 RVA: 0x0003B208 File Offset: 0x00039408
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<ScriptableRenderContext, List<Camera>> endContextRendering;

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x0600232D RID: 9005 RVA: 0x0003B23C File Offset: 0x0003943C
		// (remove) Token: 0x0600232E RID: 9006 RVA: 0x0003B270 File Offset: 0x00039470
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<ScriptableRenderContext, Camera[]> beginFrameRendering;

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x0600232F RID: 9007 RVA: 0x0003B2A4 File Offset: 0x000394A4
		// (remove) Token: 0x06002330 RID: 9008 RVA: 0x0003B2D8 File Offset: 0x000394D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<ScriptableRenderContext, Camera> beginCameraRendering;

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06002331 RID: 9009 RVA: 0x0003B30C File Offset: 0x0003950C
		// (remove) Token: 0x06002332 RID: 9010 RVA: 0x0003B340 File Offset: 0x00039540
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<ScriptableRenderContext, Camera[]> endFrameRendering;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06002333 RID: 9011 RVA: 0x0003B374 File Offset: 0x00039574
		// (remove) Token: 0x06002334 RID: 9012 RVA: 0x0003B3A8 File Offset: 0x000395A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<ScriptableRenderContext, Camera> endCameraRendering;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06002335 RID: 9013 RVA: 0x0003B3DC File Offset: 0x000395DC
		// (remove) Token: 0x06002336 RID: 9014 RVA: 0x0003B410 File Offset: 0x00039610
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action activeRenderPipelineTypeChanged;

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x0003B443 File Offset: 0x00039643
		public static bool pipelineSwitchCompleted
		{
			get
			{
				return RenderPipelineManager.s_CurrentPipelineAsset == GraphicsSettings.currentRenderPipeline && !RenderPipelineManager.IsPipelineRequireCreation();
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06002338 RID: 9016 RVA: 0x0003B45C File Offset: 0x0003965C
		// (remove) Token: 0x06002339 RID: 9017 RVA: 0x0003B490 File Offset: 0x00039690
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action activeRenderPipelineCreated;

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x0600233A RID: 9018 RVA: 0x0003B4C4 File Offset: 0x000396C4
		// (remove) Token: 0x0600233B RID: 9019 RVA: 0x0003B4F8 File Offset: 0x000396F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action activeRenderPipelineDisposed;

		// Token: 0x0600233C RID: 9020 RVA: 0x0003B52B File Offset: 0x0003972B
		internal static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			Action<ScriptableRenderContext, Camera[]> action = RenderPipelineManager.beginFrameRendering;
			if (action != null)
			{
				action(context, cameras.ToArray());
			}
			Action<ScriptableRenderContext, List<Camera>> action2 = RenderPipelineManager.beginContextRendering;
			if (action2 != null)
			{
				action2(context, cameras);
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0003B559 File Offset: 0x00039759
		internal static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			Action<ScriptableRenderContext, Camera> action = RenderPipelineManager.beginCameraRendering;
			if (action != null)
			{
				action(context, camera);
			}
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0003B56F File Offset: 0x0003976F
		internal static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			Action<ScriptableRenderContext, Camera[]> action = RenderPipelineManager.endFrameRendering;
			if (action != null)
			{
				action(context, cameras.ToArray());
			}
			Action<ScriptableRenderContext, List<Camera>> action2 = RenderPipelineManager.endContextRendering;
			if (action2 != null)
			{
				action2(context, cameras);
			}
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0003B59D File Offset: 0x0003979D
		internal static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			Action<ScriptableRenderContext, Camera> action = RenderPipelineManager.endCameraRendering;
			if (action != null)
			{
				action(context, camera);
			}
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0003B5B3 File Offset: 0x000397B3
		[RequiredByNativeCode]
		internal static void OnActiveRenderPipelineTypeChanged()
		{
			Action action = RenderPipelineManager.activeRenderPipelineTypeChanged;
			if (action != null)
			{
				action();
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0003B5C8 File Offset: 0x000397C8
		[RequiredByNativeCode]
		internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
		{
			bool flag = RenderPipelineManager.s_CurrentPipelineAsset != pipelineAsset;
			bool flag2 = flag;
			if (flag2)
			{
				RenderPipelineManager.CleanupRenderPipeline();
				RenderPipelineManager.s_CurrentPipelineAsset = pipelineAsset;
			}
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0003B5F8 File Offset: 0x000397F8
		[RequiredByNativeCode]
		internal static void CleanupRenderPipeline()
		{
			bool flag = RenderPipelineManager.currentPipeline != null && !RenderPipelineManager.currentPipeline.disposed;
			if (flag)
			{
				Action action = RenderPipelineManager.activeRenderPipelineDisposed;
				if (action != null)
				{
					action();
				}
				RenderPipelineManager.currentPipeline.Dispose();
				RenderPipelineManager.s_CurrentPipelineAsset = null;
				RenderPipelineManager.currentPipeline = null;
				SupportedRenderingFeatures.active = new SupportedRenderingFeatures();
			}
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0003B658 File Offset: 0x00039858
		[RequiredByNativeCode]
		private static string GetCurrentPipelineAssetType()
		{
			return RenderPipelineManager.s_currentPipelineType;
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0003B670 File Offset: 0x00039870
		[RequiredByNativeCode]
		private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, List<Camera.RenderRequest> renderRequests)
		{
			RenderPipelineManager.PrepareRenderPipeline(pipe);
			bool flag = RenderPipelineManager.currentPipeline == null;
			if (!flag)
			{
				ScriptableRenderContext context = new ScriptableRenderContext(loopPtr);
				RenderPipelineManager.s_Cameras.Clear();
				context.GetCameras(RenderPipelineManager.s_Cameras);
				bool flag2 = renderRequests == null;
				if (flag2)
				{
					RenderPipelineManager.currentPipeline.InternalRender(context, RenderPipelineManager.s_Cameras);
				}
				else
				{
					RenderPipelineManager.currentPipeline.InternalRenderWithRequests(context, RenderPipelineManager.s_Cameras, renderRequests);
				}
				RenderPipelineManager.s_Cameras.Clear();
			}
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0003B6EC File Offset: 0x000398EC
		internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
			RenderPipelineManager.HandleRenderPipelineChange(pipelineAsset);
			bool flag = RenderPipelineManager.IsPipelineRequireCreation();
			if (flag)
			{
				RenderPipelineManager.currentPipeline = RenderPipelineManager.s_CurrentPipelineAsset.InternalCreatePipeline();
				Action action = RenderPipelineManager.activeRenderPipelineCreated;
				if (action != null)
				{
					action();
				}
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0003B72D File Offset: 0x0003992D
		private static bool IsPipelineRequireCreation()
		{
			return RenderPipelineManager.s_CurrentPipelineAsset != null && (RenderPipelineManager.currentPipeline == null || RenderPipelineManager.currentPipeline.disposed);
		}

		// Token: 0x04000D0D RID: 3341
		internal static RenderPipelineAsset s_CurrentPipelineAsset;

		// Token: 0x04000D0E RID: 3342
		private static List<Camera> s_Cameras = new List<Camera>();

		// Token: 0x04000D0F RID: 3343
		private static string s_currentPipelineType = "Built-in Pipeline";

		// Token: 0x04000D10 RID: 3344
		private const string s_builtinPipelineName = "Built-in Pipeline";

		// Token: 0x04000D11 RID: 3345
		private static RenderPipeline s_currentPipeline = null;
	}
}
