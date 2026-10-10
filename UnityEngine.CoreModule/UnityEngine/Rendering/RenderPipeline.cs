using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000406 RID: 1030
	public abstract class RenderPipeline
	{
		// Token: 0x060022FC RID: 8956
		protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

		// Token: 0x060022FD RID: 8957 RVA: 0x00004563 File Offset: 0x00002763
		protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, List<Camera.RenderRequest> renderRequests)
		{
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x0003AF61 File Offset: 0x00039161
		protected static void BeginFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
			RenderPipelineManager.BeginContextRendering(context, new List<Camera>(cameras));
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x0003AF71 File Offset: 0x00039171
		protected static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			RenderPipelineManager.BeginContextRendering(context, cameras);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0003AF7C File Offset: 0x0003917C
		protected static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			RenderPipelineManager.BeginCameraRendering(context, camera);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0003AF87 File Offset: 0x00039187
		protected static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			RenderPipelineManager.EndContextRendering(context, cameras);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0003AF92 File Offset: 0x00039192
		protected static void EndFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
			RenderPipelineManager.EndContextRendering(context, new List<Camera>(cameras));
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0003AFA2 File Offset: 0x000391A2
		protected static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			RenderPipelineManager.EndCameraRendering(context, camera);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0003AFAD File Offset: 0x000391AD
		protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
		{
			this.Render(context, cameras.ToArray());
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0003AFC0 File Offset: 0x000391C0
		internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
		{
			bool disposed = this.disposed;
			if (disposed)
			{
				throw new ObjectDisposedException(string.Format("{0} has been disposed. Do not call Render on disposed a RenderPipeline.", this));
			}
			this.Render(context, cameras);
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0003AFF4 File Offset: 0x000391F4
		internal void InternalRenderWithRequests(ScriptableRenderContext context, List<Camera> cameras, List<Camera.RenderRequest> renderRequests)
		{
			bool disposed = this.disposed;
			if (disposed)
			{
				throw new ObjectDisposedException(string.Format("{0} has been disposed. Do not call Render on disposed a RenderPipeline.", this));
			}
			this.ProcessRenderRequests(context, (cameras == null || cameras.Count == 0) ? null : cameras[0], renderRequests);
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0003B03B File Offset: 0x0003923B
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0003B043 File Offset: 0x00039243
		public bool disposed { get; private set; }

		// Token: 0x06002309 RID: 8969 RVA: 0x0003B04C File Offset: 0x0003924C
		internal void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
			this.disposed = true;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00004563 File Offset: 0x00002763
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x0003B068 File Offset: 0x00039268
		public virtual RenderPipelineGlobalSettings defaultSettings
		{
			get
			{
				return null;
			}
		}
	}
}
