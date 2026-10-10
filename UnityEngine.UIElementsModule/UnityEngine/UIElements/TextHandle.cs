using System;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x020002BC RID: 700
	internal struct TextHandle : ITextHandle
	{
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x00062EA6 File Offset: 0x000610A6
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x00062EB3 File Offset: 0x000610B3
		public Vector2 MeasuredSizes
		{
			get
			{
				return this.textHandle.MeasuredSizes;
			}
			set
			{
				this.textHandle.MeasuredSizes = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00062EC2 File Offset: 0x000610C2
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00062ECF File Offset: 0x000610CF
		public Vector2 RoundedSizes
		{
			get
			{
				return this.textHandle.RoundedSizes;
			}
			set
			{
				this.textHandle.RoundedSizes = value;
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00062EE0 File Offset: 0x000610E0
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling)
		{
			return this.textHandle.GetCursorPosition(parms, scaling);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00062F00 File Offset: 0x00061100
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint)
		{
			return this.textHandle.GetLineHeight(characterIndex, textParams, textScaling, pixelPerPoint);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00062F24 File Offset: 0x00061124
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return this.textHandle.ComputeTextWidth(parms, scaling);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00062F44 File Offset: 0x00061144
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return this.textHandle.ComputeTextHeight(parms, scaling);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00062F64 File Offset: 0x00061164
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint)
		{
			return this.textHandle.Update(parms, pixelsPerPoint);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00062F84 File Offset: 0x00061184
		public int VerticesCount(MeshGenerationContextUtils.TextParams parms, float pixelPerPoint)
		{
			return this.textHandle.VerticesCount(parms, pixelPerPoint);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00062FA4 File Offset: 0x000611A4
		public ITextHandle New()
		{
			return this.textHandle.New();
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00062FC4 File Offset: 0x000611C4
		public bool IsLegacy()
		{
			return this.textHandle.IsLegacy();
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00062FE1 File Offset: 0x000611E1
		public void SetDirty()
		{
			this.textHandle.SetDirty();
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00062FF0 File Offset: 0x000611F0
		public bool IsElided()
		{
			return this.textHandle.IsElided();
		}

		// Token: 0x04000A3B RID: 2619
		internal ITextHandle textHandle;
	}
}
