using System;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x0200025A RID: 602
	internal class DynamicAtlasPage : IDisposable
	{
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0004868F File Offset: 0x0004688F
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x00048697 File Offset: 0x00046897
		public TextureId textureId { get; private set; }

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x000486A0 File Offset: 0x000468A0
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x000486A8 File Offset: 0x000468A8
		public RenderTexture atlas { get; private set; }

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x000486B1 File Offset: 0x000468B1
		public RenderTextureFormat format { get; }

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000486B9 File Offset: 0x000468B9
		public FilterMode filterMode { get; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x000486C1 File Offset: 0x000468C1
		public Vector2Int minSize { get; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000486C9 File Offset: 0x000468C9
		public Vector2Int maxSize { get; }

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x000486D1 File Offset: 0x000468D1
		public Vector2Int currentSize
		{
			get
			{
				return this.m_CurrentSize;
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000486DC File Offset: 0x000468DC
		public DynamicAtlasPage(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize)
		{
			this.textureId = TextureRegistry.instance.AllocAndAcquireDynamic();
			this.format = format;
			this.filterMode = filterMode;
			this.minSize = minSize;
			this.maxSize = maxSize;
			this.m_Allocator = new Allocator2D(minSize, maxSize, this.m_2Padding);
			this.m_Blitter = new TextureBlitter(64);
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x0004874E File Offset: 0x0004694E
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x00048756 File Offset: 0x00046956
		private protected bool disposed { protected get; private set; }

		// Token: 0x06001262 RID: 4706 RVA: 0x0004875F File Offset: 0x0004695F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00048774 File Offset: 0x00046974
		protected virtual void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				if (disposing)
				{
					bool flag = this.atlas != null;
					if (flag)
					{
						UIRUtility.Destroy(this.atlas);
						this.atlas = null;
					}
					bool flag2 = this.m_Allocator != null;
					if (flag2)
					{
						this.m_Allocator = null;
					}
					bool flag3 = this.m_Blitter != null;
					if (flag3)
					{
						this.m_Blitter.Dispose();
						this.m_Blitter = null;
					}
					bool flag4 = this.textureId != TextureId.invalid;
					if (flag4)
					{
						TextureRegistry.instance.Release(this.textureId);
						this.textureId = TextureId.invalid;
					}
				}
				this.disposed = true;
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0004883C File Offset: 0x00046A3C
		public bool TryAdd(Texture2D image, out Allocator2D.Alloc2D alloc, out RectInt rect)
		{
			bool disposed = this.disposed;
			bool result;
			if (disposed)
			{
				DisposeHelper.NotifyDisposedUsed(this);
				alloc = default(Allocator2D.Alloc2D);
				rect = default(RectInt);
				result = false;
			}
			else
			{
				bool flag = !this.m_Allocator.TryAllocate(image.width + this.m_2Padding, image.height + this.m_2Padding, out alloc);
				if (flag)
				{
					rect = default(RectInt);
					result = false;
				}
				else
				{
					this.m_CurrentSize.x = Mathf.Max(this.m_CurrentSize.x, UIRUtility.GetNextPow2(alloc.rect.xMax));
					this.m_CurrentSize.y = Mathf.Max(this.m_CurrentSize.y, UIRUtility.GetNextPow2(alloc.rect.yMax));
					rect = new RectInt(alloc.rect.xMin + this.m_1Padding, alloc.rect.yMin + this.m_1Padding, image.width, image.height);
					this.Update(image, rect);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00048954 File Offset: 0x00046B54
		public void Update(Texture2D image, RectInt rect)
		{
			bool disposed = this.disposed;
			if (disposed)
			{
				DisposeHelper.NotifyDisposedUsed(this);
			}
			else
			{
				Debug.Assert(image != null && rect.width > 0 && rect.height > 0);
				this.m_Blitter.QueueBlit(image, new RectInt(0, 0, image.width, image.height), new Vector2Int(rect.x, rect.y), true, Color.white);
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000489D8 File Offset: 0x00046BD8
		public void Remove(Allocator2D.Alloc2D alloc)
		{
			bool disposed = this.disposed;
			if (disposed)
			{
				DisposeHelper.NotifyDisposedUsed(this);
			}
			else
			{
				Debug.Assert(alloc.rect.width > 0 && alloc.rect.height > 0);
				this.m_Allocator.Free(alloc);
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00048A30 File Offset: 0x00046C30
		public void Commit()
		{
			bool disposed = this.disposed;
			if (disposed)
			{
				DisposeHelper.NotifyDisposedUsed(this);
			}
			else
			{
				this.UpdateAtlasTexture();
				this.m_Blitter.Commit(this.atlas);
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00048A6C File Offset: 0x00046C6C
		private void UpdateAtlasTexture()
		{
			bool flag = this.atlas == null;
			if (flag)
			{
				this.atlas = this.CreateAtlasTexture();
			}
			else
			{
				bool flag2 = this.atlas.width != this.m_CurrentSize.x || this.atlas.height != this.m_CurrentSize.y;
				if (flag2)
				{
					RenderTexture renderTexture = this.CreateAtlasTexture();
					bool flag3 = renderTexture == null;
					if (flag3)
					{
						Debug.LogErrorFormat("Failed to allocate a render texture for the dynamic atlas. Current Size = {0}x{1}. Requested Size = {2}x{3}.", new object[]
						{
							this.atlas.width,
							this.atlas.height,
							this.m_CurrentSize.x,
							this.m_CurrentSize.y
						});
					}
					else
					{
						this.m_Blitter.BlitOneNow(renderTexture, this.atlas, new RectInt(0, 0, this.atlas.width, this.atlas.height), new Vector2Int(0, 0), false, Color.white);
					}
					UIRUtility.Destroy(this.atlas);
					this.atlas = renderTexture;
				}
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00048BA0 File Offset: 0x00046DA0
		private RenderTexture CreateAtlasTexture()
		{
			bool flag = this.m_CurrentSize.x == 0 || this.m_CurrentSize.y == 0;
			RenderTexture result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new RenderTexture(this.m_CurrentSize.x, this.m_CurrentSize.y, 0, this.format)
				{
					hideFlags = HideFlags.HideAndDontSave,
					name = "UIR Dynamic Atlas Page " + DynamicAtlasPage.s_TextureCounter++.ToString(),
					filterMode = this.filterMode
				};
			}
			return result;
		}

		// Token: 0x0400084A RID: 2122
		private readonly int m_1Padding = 1;

		// Token: 0x0400084B RID: 2123
		private readonly int m_2Padding = 2;

		// Token: 0x0400084C RID: 2124
		private Allocator2D m_Allocator;

		// Token: 0x0400084D RID: 2125
		private TextureBlitter m_Blitter;

		// Token: 0x0400084E RID: 2126
		private Vector2Int m_CurrentSize;

		// Token: 0x0400084F RID: 2127
		private static int s_TextureCounter;
	}
}
