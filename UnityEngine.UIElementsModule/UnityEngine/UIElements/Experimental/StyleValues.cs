using System;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x02000387 RID: 903
	public struct StyleValues
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x00089948 File Offset: 0x00087B48
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x00089972 File Offset: 0x00087B72
		public float top
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.Top).value;
			}
			set
			{
				this.SetValue(StylePropertyId.Top, value);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x00089984 File Offset: 0x00087B84
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x000899AE File Offset: 0x00087BAE
		public float left
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.Left).value;
			}
			set
			{
				this.SetValue(StylePropertyId.Left, value);
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x000899C0 File Offset: 0x00087BC0
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x000899EA File Offset: 0x00087BEA
		public float width
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.Width).value;
			}
			set
			{
				this.SetValue(StylePropertyId.Width, value);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x000899FC File Offset: 0x00087BFC
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x00089A26 File Offset: 0x00087C26
		public float height
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.Height).value;
			}
			set
			{
				this.SetValue(StylePropertyId.Height, value);
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x00089A38 File Offset: 0x00087C38
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x00089A62 File Offset: 0x00087C62
		public float right
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.Right).value;
			}
			set
			{
				this.SetValue(StylePropertyId.Right, value);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00089A74 File Offset: 0x00087C74
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x00089A9E File Offset: 0x00087C9E
		public float bottom
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.Bottom).value;
			}
			set
			{
				this.SetValue(StylePropertyId.Bottom, value);
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00089AB0 File Offset: 0x00087CB0
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x00089ADA File Offset: 0x00087CDA
		public Color color
		{
			get
			{
				return this.Values().GetStyleColor(StylePropertyId.Color).value;
			}
			set
			{
				this.SetValue(StylePropertyId.Color, value);
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00089AEC File Offset: 0x00087CEC
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x00089B16 File Offset: 0x00087D16
		public Color backgroundColor
		{
			get
			{
				return this.Values().GetStyleColor(StylePropertyId.BackgroundColor).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BackgroundColor, value);
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00089B28 File Offset: 0x00087D28
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x00089B52 File Offset: 0x00087D52
		public Color unityBackgroundImageTintColor
		{
			get
			{
				return this.Values().GetStyleColor(StylePropertyId.UnityBackgroundImageTintColor).value;
			}
			set
			{
				this.SetValue(StylePropertyId.UnityBackgroundImageTintColor, value);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00089B64 File Offset: 0x00087D64
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x00089B8E File Offset: 0x00087D8E
		public Color borderColor
		{
			get
			{
				return this.Values().GetStyleColor(StylePropertyId.BorderColor).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderColor, value);
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00089BA0 File Offset: 0x00087DA0
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x00089BCA File Offset: 0x00087DCA
		public float marginLeft
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.MarginLeft).value;
			}
			set
			{
				this.SetValue(StylePropertyId.MarginLeft, value);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00089BDC File Offset: 0x00087DDC
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x00089C06 File Offset: 0x00087E06
		public float marginTop
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.MarginTop).value;
			}
			set
			{
				this.SetValue(StylePropertyId.MarginTop, value);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00089C18 File Offset: 0x00087E18
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x00089C42 File Offset: 0x00087E42
		public float marginRight
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.MarginRight).value;
			}
			set
			{
				this.SetValue(StylePropertyId.MarginRight, value);
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00089C54 File Offset: 0x00087E54
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x00089C7E File Offset: 0x00087E7E
		public float marginBottom
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.MarginBottom).value;
			}
			set
			{
				this.SetValue(StylePropertyId.MarginBottom, value);
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00089C90 File Offset: 0x00087E90
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x00089CBA File Offset: 0x00087EBA
		public float paddingLeft
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.PaddingLeft).value;
			}
			set
			{
				this.SetValue(StylePropertyId.PaddingLeft, value);
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00089CCC File Offset: 0x00087ECC
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00089CF6 File Offset: 0x00087EF6
		public float paddingTop
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.PaddingTop).value;
			}
			set
			{
				this.SetValue(StylePropertyId.PaddingTop, value);
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00089D08 File Offset: 0x00087F08
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x00089D32 File Offset: 0x00087F32
		public float paddingRight
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.PaddingRight).value;
			}
			set
			{
				this.SetValue(StylePropertyId.PaddingRight, value);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00089D44 File Offset: 0x00087F44
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x00089D6E File Offset: 0x00087F6E
		public float paddingBottom
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.PaddingBottom).value;
			}
			set
			{
				this.SetValue(StylePropertyId.PaddingBottom, value);
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00089D80 File Offset: 0x00087F80
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00089DAA File Offset: 0x00087FAA
		public float borderLeftWidth
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.BorderLeftWidth).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderLeftWidth, value);
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00089DBC File Offset: 0x00087FBC
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00089DE6 File Offset: 0x00087FE6
		public float borderRightWidth
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.BorderRightWidth).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderRightWidth, value);
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00089DF8 File Offset: 0x00087FF8
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x00089E22 File Offset: 0x00088022
		public float borderTopWidth
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.BorderTopWidth).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderTopWidth, value);
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00089E34 File Offset: 0x00088034
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x00089E5E File Offset: 0x0008805E
		public float borderBottomWidth
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.BorderBottomWidth).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderBottomWidth, value);
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00089E70 File Offset: 0x00088070
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00089E9A File Offset: 0x0008809A
		public float borderTopLeftRadius
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.BorderTopLeftRadius).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderTopLeftRadius, value);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00089EAC File Offset: 0x000880AC
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x00089ED6 File Offset: 0x000880D6
		public float borderTopRightRadius
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.BorderTopRightRadius).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderTopRightRadius, value);
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00089EE8 File Offset: 0x000880E8
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00089F12 File Offset: 0x00088112
		public float borderBottomLeftRadius
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.BorderBottomLeftRadius).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderBottomLeftRadius, value);
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00089F24 File Offset: 0x00088124
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00089F4E File Offset: 0x0008814E
		public float borderBottomRightRadius
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.BorderBottomRightRadius).value;
			}
			set
			{
				this.SetValue(StylePropertyId.BorderBottomRightRadius, value);
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00089F60 File Offset: 0x00088160
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00089F8A File Offset: 0x0008818A
		public float opacity
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.Opacity).value;
			}
			set
			{
				this.SetValue(StylePropertyId.Opacity, value);
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00089F9C File Offset: 0x0008819C
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00089FC6 File Offset: 0x000881C6
		public float flexGrow
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.FlexGrow).value;
			}
			set
			{
				this.SetValue(StylePropertyId.FlexGrow, value);
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00089FD8 File Offset: 0x000881D8
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00089FC6 File Offset: 0x000881C6
		public float flexShrink
		{
			get
			{
				return this.Values().GetStyleFloat(StylePropertyId.FlexShrink).value;
			}
			set
			{
				this.SetValue(StylePropertyId.FlexGrow, value);
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0008A004 File Offset: 0x00088204
		internal void SetValue(StylePropertyId id, float value)
		{
			StyleValue styleValue = default(StyleValue);
			styleValue.id = id;
			styleValue.number = value;
			this.Values().SetStyleValue(styleValue);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0008A038 File Offset: 0x00088238
		internal void SetValue(StylePropertyId id, Color value)
		{
			StyleValue styleValue = default(StyleValue);
			styleValue.id = id;
			styleValue.color = value;
			this.Values().SetStyleValue(styleValue);
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0008A06C File Offset: 0x0008826C
		internal StyleValueCollection Values()
		{
			bool flag = this.m_StyleValues == null;
			if (flag)
			{
				this.m_StyleValues = new StyleValueCollection();
			}
			return this.m_StyleValues;
		}

		// Token: 0x04000EA1 RID: 3745
		internal StyleValueCollection m_StyleValues;
	}
}
