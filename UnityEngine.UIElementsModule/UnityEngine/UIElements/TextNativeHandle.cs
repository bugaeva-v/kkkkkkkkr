using System;
using Unity.Collections;
using UnityEngine.Assertions;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x020002BE RID: 702
	internal struct TextNativeHandle : ITextHandle
	{
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x000635F2 File Offset: 0x000617F2
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x000635FA File Offset: 0x000617FA
		public Vector2 MeasuredSizes { readonly get; set; }

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x00063603 File Offset: 0x00061803
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0006360B File Offset: 0x0006180B
		public Vector2 RoundedSizes { readonly get; set; }

		// Token: 0x060017DA RID: 6106 RVA: 0x00063614 File Offset: 0x00061814
		public static ITextHandle New()
		{
			return new TextNativeHandle
			{
				textVertices = default(NativeArray<TextVertex>)
			};
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00063644 File Offset: 0x00061844
		public bool IsLegacy()
		{
			return true;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00002166 File Offset: 0x00000366
		public void SetDirty()
		{
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00063658 File Offset: 0x00061858
		ITextHandle ITextHandle.New()
		{
			return TextNativeHandle.New();
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00063670 File Offset: 0x00061870
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint)
		{
			textParams.wordWrapWidth = 0f;
			textParams.wordWrap = false;
			return this.ComputeTextHeight(textParams, textScaling);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000636A0 File Offset: 0x000618A0
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint)
		{
			Debug.Log("TextNative Update should not be called");
			return null;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000636C0 File Offset: 0x000618C0
		public int VerticesCount(MeshGenerationContextUtils.TextParams parms, float pixelPerPoint)
		{
			return this.GetVertices(parms, pixelPerPoint).Length;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000636E4 File Offset: 0x000618E4
		public NativeArray<TextVertex> GetVertices(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			Vector2 vector = parms.rect.size;
			bool flag = Mathf.Abs(parms.rect.size.x - this.RoundedSizes.x) < 0.01f && Mathf.Abs(parms.rect.size.y - this.RoundedSizes.y) < 0.01f;
			if (flag)
			{
				vector = this.MeasuredSizes;
				parms.wordWrapWidth = vector.x;
			}
			else
			{
				this.RoundedSizes = vector;
				this.MeasuredSizes = vector;
			}
			parms.rect = new Rect(Vector2.zero, vector);
			int hashCode = parms.GetHashCode();
			bool flag2 = this.m_PreviousTextParamsHash == hashCode;
			NativeArray<TextVertex> result;
			if (flag2)
			{
				result = this.textVertices;
			}
			else
			{
				this.m_PreviousTextParamsHash = hashCode;
				TextNativeSettings textNativeSettings = MeshGenerationContextUtils.TextParams.GetTextNativeSettings(parms, scaling);
				Assert.IsNotNull<Font>(textNativeSettings.font);
				this.textVertices = TextNative.GetVertices(textNativeSettings);
				result = this.textVertices;
			}
			return result;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x000637F0 File Offset: 0x000619F0
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling)
		{
			return TextNative.GetCursorPosition(parms.GetTextNativeSettings(scaling), parms.rect, parms.cursorIndex);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0006381C File Offset: 0x00061A1C
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			float num = TextNative.ComputeTextWidth(MeshGenerationContextUtils.TextParams.GetTextNativeSettings(parms, scaling));
			bool flag = scaling != 1f && num != 0f;
			float result;
			if (flag)
			{
				result = num + 0.0001f;
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00063860 File Offset: 0x00061A60
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return TextNative.ComputeTextHeight(MeshGenerationContextUtils.TextParams.GetTextNativeSettings(parms, scaling));
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00063880 File Offset: 0x00061A80
		public bool IsElided()
		{
			return false;
		}

		// Token: 0x04000A47 RID: 2631
		internal NativeArray<TextVertex> textVertices;

		// Token: 0x04000A48 RID: 2632
		private int m_PreviousTextParamsHash;
	}
}
