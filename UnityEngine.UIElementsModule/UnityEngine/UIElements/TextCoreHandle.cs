using System;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x020002BD RID: 701
	internal struct TextCoreHandle : ITextHandle
	{
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x0006300D File Offset: 0x0006120D
		// (set) Token: 0x060017C0 RID: 6080 RVA: 0x00063015 File Offset: 0x00061215
		public Vector2 MeasuredSizes { readonly get; set; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x0006301E File Offset: 0x0006121E
		// (set) Token: 0x060017C2 RID: 6082 RVA: 0x00063026 File Offset: 0x00061226
		public Vector2 RoundedSizes { readonly get; set; }

		// Token: 0x060017C3 RID: 6083 RVA: 0x00063030 File Offset: 0x00061230
		public static ITextHandle New()
		{
			return new TextCoreHandle
			{
				m_CurrentGenerationSettings = new TextGenerationSettings()
			};
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0006305C File Offset: 0x0006125C
		internal TextInfo textInfoMesh
		{
			get
			{
				bool flag = this.m_TextInfoMesh == null;
				if (flag)
				{
					this.m_TextInfoMesh = new TextInfo();
				}
				return this.m_TextInfoMesh;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x00063090 File Offset: 0x00061290
		internal static TextInfo textInfoLayout
		{
			get
			{
				bool flag = TextCoreHandle.s_TextInfoLayout == null;
				if (flag)
				{
					TextCoreHandle.s_TextInfoLayout = new TextInfo();
				}
				return TextCoreHandle.s_TextInfoLayout;
			}
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x000630C0 File Offset: 0x000612C0
		internal bool IsTextInfoAllocated()
		{
			return this.m_TextInfoMesh != null;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000630DC File Offset: 0x000612DC
		public bool IsLegacy()
		{
			return false;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x000630EF File Offset: 0x000612EF
		public void SetDirty()
		{
			this.isDirty = true;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000630FC File Offset: 0x000612FC
		public bool IsDirty(MeshGenerationContextUtils.TextParams parms)
		{
			int hashCode = parms.GetHashCode();
			bool flag = this.m_PreviousGenerationSettingsHash == hashCode && !this.isDirty;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				this.m_PreviousGenerationSettingsHash = hashCode;
				this.isDirty = false;
				result = true;
			}
			return result;
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00063148 File Offset: 0x00061348
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling)
		{
			return TextGenerator.GetCursorPosition(this.textInfoMesh, parms.rect, parms.cursorIndex, true);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00063174 File Offset: 0x00061374
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			this.UpdatePreferredValues(parms);
			return this.m_PreferredSize.x;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0006319C File Offset: 0x0006139C
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			this.UpdatePreferredValues(parms);
			return this.m_PreferredSize.y;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000631C4 File Offset: 0x000613C4
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint)
		{
			bool flag = this.m_TextInfoMesh == null || this.m_TextInfoMesh.characterCount == 0;
			if (flag)
			{
				this.Update(textParams, pixelPerPoint);
			}
			return this.m_TextInfoMesh.lineInfo[0].lineHeight;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00063214 File Offset: 0x00061414
		public int VerticesCount(MeshGenerationContextUtils.TextParams parms, float pixelPerPoint)
		{
			this.Update(parms, pixelPerPoint);
			int num = 0;
			foreach (MeshInfo meshInfo2 in this.textInfoMesh.meshInfo)
			{
				num += meshInfo2.vertexCount;
			}
			return num;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00063260 File Offset: 0x00061460
		ITextHandle ITextHandle.New()
		{
			return TextCoreHandle.New();
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00063278 File Offset: 0x00061478
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint)
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
			bool flag2 = !this.IsDirty(parms);
			TextInfo textInfoMesh;
			if (flag2)
			{
				textInfoMesh = this.textInfoMesh;
			}
			else
			{
				TextCoreHandle.UpdateGenerationSettingsCommon(parms, this.m_CurrentGenerationSettings);
				this.m_CurrentGenerationSettings.color = parms.fontColor;
				this.m_CurrentGenerationSettings.inverseYAxis = true;
				this.textInfoMesh.isDirty = true;
				TextGenerator.GenerateText(this.m_CurrentGenerationSettings, this.textInfoMesh);
				textInfoMesh = this.textInfoMesh;
			}
			return textInfoMesh;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00063394 File Offset: 0x00061594
		private void UpdatePreferredValues(MeshGenerationContextUtils.TextParams parms)
		{
			Vector2 size = parms.rect.size;
			parms.rect = new Rect(Vector2.zero, size);
			TextCoreHandle.UpdateGenerationSettingsCommon(parms, TextCoreHandle.s_LayoutSettings);
			this.m_PreferredSize = TextGenerator.GetPreferredValues(TextCoreHandle.s_LayoutSettings, TextCoreHandle.textInfoLayout);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x000633E4 File Offset: 0x000615E4
		private static TextOverflowMode GetTextOverflowMode(MeshGenerationContextUtils.TextParams textParams)
		{
			bool flag = textParams.textOverflow == TextOverflow.Clip;
			TextOverflowMode result;
			if (flag)
			{
				result = TextOverflowMode.Masking;
			}
			else
			{
				bool flag2 = textParams.textOverflow != TextOverflow.Ellipsis;
				if (flag2)
				{
					result = TextOverflowMode.Overflow;
				}
				else
				{
					bool flag3 = !textParams.wordWrap && textParams.overflow == OverflowInternal.Hidden;
					if (flag3)
					{
						result = TextOverflowMode.Ellipsis;
					}
					else
					{
						result = TextOverflowMode.Overflow;
					}
				}
			}
			return result;
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00063438 File Offset: 0x00061638
		private static void UpdateGenerationSettingsCommon(MeshGenerationContextUtils.TextParams painterParams, TextGenerationSettings settings)
		{
			settings.textSettings = TextUtilities.GetTextSettingsFrom(painterParams);
			bool flag = settings.textSettings == null;
			if (!flag)
			{
				settings.fontAsset = TextUtilities.GetFontAsset(painterParams);
				bool flag2 = settings.fontAsset == null;
				if (!flag2)
				{
					settings.material = settings.fontAsset.material;
					settings.screenRect = painterParams.rect;
					settings.text = (string.IsNullOrEmpty(painterParams.text) ? "​" : (painterParams.text + "​"));
					settings.fontSize = (float)((painterParams.fontSize > 0) ? painterParams.fontSize : settings.fontAsset.faceInfo.pointSize);
					settings.fontStyle = TextGeneratorUtilities.LegacyStyleToNewStyle(painterParams.fontStyle);
					settings.textAlignment = TextGeneratorUtilities.LegacyAlignmentToNewAlignment(painterParams.anchor);
					settings.wordWrap = painterParams.wordWrap;
					settings.wordWrappingRatio = 0.4f;
					settings.richText = painterParams.richText;
					settings.overflowMode = TextCoreHandle.GetTextOverflowMode(painterParams);
					settings.characterSpacing = painterParams.letterSpacing.value;
					settings.wordSpacing = painterParams.wordSpacing.value;
					settings.paragraphSpacing = painterParams.paragraphSpacing.value;
				}
			}
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00063584 File Offset: 0x00061784
		public bool IsElided()
		{
			bool flag = this.m_TextInfoMesh == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = this.m_TextInfoMesh.characterCount == 0;
				result = (flag2 || this.m_TextInfoMesh.textElementInfo[this.m_TextInfoMesh.characterCount - 1].character == '…');
			}
			return result;
		}

		// Token: 0x04000A3E RID: 2622
		private Vector2 m_PreferredSize;

		// Token: 0x04000A3F RID: 2623
		private int m_PreviousGenerationSettingsHash;

		// Token: 0x04000A40 RID: 2624
		private TextGenerationSettings m_CurrentGenerationSettings;

		// Token: 0x04000A41 RID: 2625
		private static TextGenerationSettings s_LayoutSettings = new TextGenerationSettings();

		// Token: 0x04000A42 RID: 2626
		private TextInfo m_TextInfoMesh;

		// Token: 0x04000A43 RID: 2627
		private static TextInfo s_TextInfoLayout;

		// Token: 0x04000A44 RID: 2628
		private bool isDirty;
	}
}
