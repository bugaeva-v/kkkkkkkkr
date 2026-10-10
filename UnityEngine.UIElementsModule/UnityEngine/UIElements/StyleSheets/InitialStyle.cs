using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000357 RID: 855
	internal static class InitialStyle
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x000807D0 File Offset: 0x0007E9D0
		public static ref ComputedStyle Get()
		{
			return ref InitialStyle.s_InitialStyle;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000807E8 File Offset: 0x0007E9E8
		public static ComputedStyle Acquire()
		{
			return InitialStyle.s_InitialStyle.Acquire();
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00080804 File Offset: 0x0007EA04
		static InitialStyle()
		{
			InitialStyle.s_InitialStyle.layoutData.Write().alignContent = Align.FlexStart;
			InitialStyle.s_InitialStyle.layoutData.Write().alignItems = Align.Stretch;
			InitialStyle.s_InitialStyle.layoutData.Write().alignSelf = Align.Auto;
			InitialStyle.s_InitialStyle.visualData.Write().backgroundColor = Color.clear;
			InitialStyle.s_InitialStyle.visualData.Write().backgroundImage = default(Background);
			InitialStyle.s_InitialStyle.visualData.Write().borderBottomColor = Color.clear;
			InitialStyle.s_InitialStyle.visualData.Write().borderBottomLeftRadius = 0f;
			InitialStyle.s_InitialStyle.visualData.Write().borderBottomRightRadius = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().borderBottomWidth = 0f;
			InitialStyle.s_InitialStyle.visualData.Write().borderLeftColor = Color.clear;
			InitialStyle.s_InitialStyle.layoutData.Write().borderLeftWidth = 0f;
			InitialStyle.s_InitialStyle.visualData.Write().borderRightColor = Color.clear;
			InitialStyle.s_InitialStyle.layoutData.Write().borderRightWidth = 0f;
			InitialStyle.s_InitialStyle.visualData.Write().borderTopColor = Color.clear;
			InitialStyle.s_InitialStyle.visualData.Write().borderTopLeftRadius = 0f;
			InitialStyle.s_InitialStyle.visualData.Write().borderTopRightRadius = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().borderTopWidth = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().bottom = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.inheritedData.Write().color = Color.black;
			InitialStyle.s_InitialStyle.rareData.Write().cursor = default(Cursor);
			InitialStyle.s_InitialStyle.layoutData.Write().display = DisplayStyle.Flex;
			InitialStyle.s_InitialStyle.layoutData.Write().flexBasis = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.layoutData.Write().flexDirection = FlexDirection.Column;
			InitialStyle.s_InitialStyle.layoutData.Write().flexGrow = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().flexShrink = 1f;
			InitialStyle.s_InitialStyle.layoutData.Write().flexWrap = Wrap.NoWrap;
			InitialStyle.s_InitialStyle.inheritedData.Write().fontSize = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().height = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.layoutData.Write().justifyContent = Justify.FlexStart;
			InitialStyle.s_InitialStyle.layoutData.Write().left = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.inheritedData.Write().letterSpacing = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().marginBottom = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().marginLeft = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().marginRight = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().marginTop = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().maxHeight = StyleKeyword.None.ToLength();
			InitialStyle.s_InitialStyle.layoutData.Write().maxWidth = StyleKeyword.None.ToLength();
			InitialStyle.s_InitialStyle.layoutData.Write().minHeight = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.layoutData.Write().minWidth = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.visualData.Write().opacity = 1f;
			InitialStyle.s_InitialStyle.visualData.Write().overflow = OverflowInternal.Visible;
			InitialStyle.s_InitialStyle.layoutData.Write().paddingBottom = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().paddingLeft = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().paddingRight = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().paddingTop = 0f;
			InitialStyle.s_InitialStyle.layoutData.Write().position = Position.Relative;
			InitialStyle.s_InitialStyle.layoutData.Write().right = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.transformData.Write().rotate = StyleKeyword.None.ToRotate();
			InitialStyle.s_InitialStyle.transformData.Write().scale = StyleKeyword.None.ToScale();
			InitialStyle.s_InitialStyle.rareData.Write().textOverflow = TextOverflow.Clip;
			InitialStyle.s_InitialStyle.inheritedData.Write().textShadow = default(TextShadow);
			InitialStyle.s_InitialStyle.layoutData.Write().top = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.transformData.Write().transformOrigin = TransformOrigin.Initial();
			InitialStyle.s_InitialStyle.transitionData.Write().transitionDelay = new List<TimeValue>
			{
				0f
			};
			InitialStyle.s_InitialStyle.transitionData.Write().transitionDuration = new List<TimeValue>
			{
				0f
			};
			InitialStyle.s_InitialStyle.transitionData.Write().transitionProperty = new List<StylePropertyName>
			{
				"all"
			};
			InitialStyle.s_InitialStyle.transitionData.Write().transitionTimingFunction = new List<EasingFunction>
			{
				EasingMode.Ease
			};
			InitialStyle.s_InitialStyle.transformData.Write().translate = StyleKeyword.None.ToTranslate();
			InitialStyle.s_InitialStyle.rareData.Write().unityBackgroundImageTintColor = Color.white;
			InitialStyle.s_InitialStyle.rareData.Write().unityBackgroundScaleMode = ScaleMode.StretchToFill;
			InitialStyle.s_InitialStyle.inheritedData.Write().unityFont = null;
			InitialStyle.s_InitialStyle.inheritedData.Write().unityFontDefinition = default(FontDefinition);
			InitialStyle.s_InitialStyle.inheritedData.Write().unityFontStyleAndWeight = FontStyle.Normal;
			InitialStyle.s_InitialStyle.rareData.Write().unityOverflowClipBox = OverflowClipBox.PaddingBox;
			InitialStyle.s_InitialStyle.inheritedData.Write().unityParagraphSpacing = 0f;
			InitialStyle.s_InitialStyle.rareData.Write().unitySliceBottom = 0;
			InitialStyle.s_InitialStyle.rareData.Write().unitySliceLeft = 0;
			InitialStyle.s_InitialStyle.rareData.Write().unitySliceRight = 0;
			InitialStyle.s_InitialStyle.rareData.Write().unitySliceTop = 0;
			InitialStyle.s_InitialStyle.inheritedData.Write().unityTextAlign = TextAnchor.UpperLeft;
			InitialStyle.s_InitialStyle.inheritedData.Write().unityTextOutlineColor = Color.clear;
			InitialStyle.s_InitialStyle.inheritedData.Write().unityTextOutlineWidth = 0f;
			InitialStyle.s_InitialStyle.rareData.Write().unityTextOverflowPosition = TextOverflowPosition.End;
			InitialStyle.s_InitialStyle.inheritedData.Write().visibility = Visibility.Visible;
			InitialStyle.s_InitialStyle.inheritedData.Write().whiteSpace = WhiteSpace.Normal;
			InitialStyle.s_InitialStyle.layoutData.Write().width = StyleKeyword.Auto.ToLength();
			InitialStyle.s_InitialStyle.inheritedData.Write().wordSpacing = 0f;
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x00080FEB File Offset: 0x0007F1EB
		public static Align alignContent
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().alignContent;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00081001 File Offset: 0x0007F201
		public static Align alignItems
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().alignItems;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00081017 File Offset: 0x0007F217
		public static Align alignSelf
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().alignSelf;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0008102D File Offset: 0x0007F22D
		public static Color backgroundColor
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().backgroundColor;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x00081043 File Offset: 0x0007F243
		public static Background backgroundImage
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().backgroundImage;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00081059 File Offset: 0x0007F259
		public static Color borderBottomColor
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().borderBottomColor;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0008106F File Offset: 0x0007F26F
		public static Length borderBottomLeftRadius
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().borderBottomLeftRadius;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x00081085 File Offset: 0x0007F285
		public static Length borderBottomRightRadius
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().borderBottomRightRadius;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x0008109B File Offset: 0x0007F29B
		public static float borderBottomWidth
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().borderBottomWidth;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x000810B1 File Offset: 0x0007F2B1
		public static Color borderLeftColor
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().borderLeftColor;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000810C7 File Offset: 0x0007F2C7
		public static float borderLeftWidth
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().borderLeftWidth;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x000810DD File Offset: 0x0007F2DD
		public static Color borderRightColor
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().borderRightColor;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x000810F3 File Offset: 0x0007F2F3
		public static float borderRightWidth
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().borderRightWidth;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00081109 File Offset: 0x0007F309
		public static Color borderTopColor
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().borderTopColor;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0008111F File Offset: 0x0007F31F
		public static Length borderTopLeftRadius
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().borderTopLeftRadius;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x00081135 File Offset: 0x0007F335
		public static Length borderTopRightRadius
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().borderTopRightRadius;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0008114B File Offset: 0x0007F34B
		public static float borderTopWidth
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().borderTopWidth;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x00081161 File Offset: 0x0007F361
		public static Length bottom
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().bottom;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x00081177 File Offset: 0x0007F377
		public static Color color
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().color;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0008118D File Offset: 0x0007F38D
		public static Cursor cursor
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().cursor;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000811A3 File Offset: 0x0007F3A3
		public static DisplayStyle display
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().display;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x000811B9 File Offset: 0x0007F3B9
		public static Length flexBasis
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().flexBasis;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000811CF File Offset: 0x0007F3CF
		public static FlexDirection flexDirection
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().flexDirection;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x000811E5 File Offset: 0x0007F3E5
		public static float flexGrow
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().flexGrow;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x000811FB File Offset: 0x0007F3FB
		public static float flexShrink
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().flexShrink;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00081211 File Offset: 0x0007F411
		public static Wrap flexWrap
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().flexWrap;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00081227 File Offset: 0x0007F427
		public static Length fontSize
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().fontSize;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0008123D File Offset: 0x0007F43D
		public static Length height
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().height;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00081253 File Offset: 0x0007F453
		public static Justify justifyContent
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().justifyContent;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x00081269 File Offset: 0x0007F469
		public static Length left
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().left;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x0008127F File Offset: 0x0007F47F
		public static Length letterSpacing
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().letterSpacing;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00081295 File Offset: 0x0007F495
		public static Length marginBottom
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().marginBottom;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x000812AB File Offset: 0x0007F4AB
		public static Length marginLeft
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().marginLeft;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x000812C1 File Offset: 0x0007F4C1
		public static Length marginRight
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().marginRight;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x000812D7 File Offset: 0x0007F4D7
		public static Length marginTop
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().marginTop;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x000812ED File Offset: 0x0007F4ED
		public static Length maxHeight
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().maxHeight;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x00081303 File Offset: 0x0007F503
		public static Length maxWidth
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().maxWidth;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00081319 File Offset: 0x0007F519
		public static Length minHeight
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().minHeight;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x0008132F File Offset: 0x0007F52F
		public static Length minWidth
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().minWidth;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00081345 File Offset: 0x0007F545
		public static float opacity
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().opacity;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0008135B File Offset: 0x0007F55B
		public static OverflowInternal overflow
		{
			get
			{
				return InitialStyle.s_InitialStyle.visualData.Read().overflow;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00081371 File Offset: 0x0007F571
		public static Length paddingBottom
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().paddingBottom;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00081387 File Offset: 0x0007F587
		public static Length paddingLeft
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().paddingLeft;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x0008139D File Offset: 0x0007F59D
		public static Length paddingRight
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().paddingRight;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x000813B3 File Offset: 0x0007F5B3
		public static Length paddingTop
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().paddingTop;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x000813C9 File Offset: 0x0007F5C9
		public static Position position
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().position;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x000813DF File Offset: 0x0007F5DF
		public static Length right
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().right;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x000813F5 File Offset: 0x0007F5F5
		public static Rotate rotate
		{
			get
			{
				return InitialStyle.s_InitialStyle.transformData.Read().rotate;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0008140B File Offset: 0x0007F60B
		public static Scale scale
		{
			get
			{
				return InitialStyle.s_InitialStyle.transformData.Read().scale;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00081421 File Offset: 0x0007F621
		public static TextOverflow textOverflow
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().textOverflow;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00081437 File Offset: 0x0007F637
		public static TextShadow textShadow
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().textShadow;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0008144D File Offset: 0x0007F64D
		public static Length top
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().top;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00081463 File Offset: 0x0007F663
		public static TransformOrigin transformOrigin
		{
			get
			{
				return InitialStyle.s_InitialStyle.transformData.Read().transformOrigin;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00081479 File Offset: 0x0007F679
		public static List<TimeValue> transitionDelay
		{
			get
			{
				return InitialStyle.s_InitialStyle.transitionData.Read().transitionDelay;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0008148F File Offset: 0x0007F68F
		public static List<TimeValue> transitionDuration
		{
			get
			{
				return InitialStyle.s_InitialStyle.transitionData.Read().transitionDuration;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x000814A5 File Offset: 0x0007F6A5
		public static List<StylePropertyName> transitionProperty
		{
			get
			{
				return InitialStyle.s_InitialStyle.transitionData.Read().transitionProperty;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x000814BB File Offset: 0x0007F6BB
		public static List<EasingFunction> transitionTimingFunction
		{
			get
			{
				return InitialStyle.s_InitialStyle.transitionData.Read().transitionTimingFunction;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x000814D1 File Offset: 0x0007F6D1
		public static Translate translate
		{
			get
			{
				return InitialStyle.s_InitialStyle.transformData.Read().translate;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x000814E7 File Offset: 0x0007F6E7
		public static Color unityBackgroundImageTintColor
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().unityBackgroundImageTintColor;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x000814FD File Offset: 0x0007F6FD
		public static ScaleMode unityBackgroundScaleMode
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().unityBackgroundScaleMode;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00081513 File Offset: 0x0007F713
		public static Font unityFont
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().unityFont;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00081529 File Offset: 0x0007F729
		public static FontDefinition unityFontDefinition
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().unityFontDefinition;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x0008153F File Offset: 0x0007F73F
		public static FontStyle unityFontStyleAndWeight
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().unityFontStyleAndWeight;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00081555 File Offset: 0x0007F755
		public static OverflowClipBox unityOverflowClipBox
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().unityOverflowClipBox;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x0008156B File Offset: 0x0007F76B
		public static Length unityParagraphSpacing
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().unityParagraphSpacing;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00081581 File Offset: 0x0007F781
		public static int unitySliceBottom
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().unitySliceBottom;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00081597 File Offset: 0x0007F797
		public static int unitySliceLeft
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().unitySliceLeft;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x000815AD File Offset: 0x0007F7AD
		public static int unitySliceRight
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().unitySliceRight;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000815C3 File Offset: 0x0007F7C3
		public static int unitySliceTop
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().unitySliceTop;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x000815D9 File Offset: 0x0007F7D9
		public static TextAnchor unityTextAlign
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().unityTextAlign;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x000815EF File Offset: 0x0007F7EF
		public static Color unityTextOutlineColor
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().unityTextOutlineColor;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00081605 File Offset: 0x0007F805
		public static float unityTextOutlineWidth
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().unityTextOutlineWidth;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0008161B File Offset: 0x0007F81B
		public static TextOverflowPosition unityTextOverflowPosition
		{
			get
			{
				return InitialStyle.s_InitialStyle.rareData.Read().unityTextOverflowPosition;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00081631 File Offset: 0x0007F831
		public static Visibility visibility
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().visibility;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00081647 File Offset: 0x0007F847
		public static WhiteSpace whiteSpace
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().whiteSpace;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x0008165D File Offset: 0x0007F85D
		public static Length width
		{
			get
			{
				return InitialStyle.s_InitialStyle.layoutData.Read().width;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00081673 File Offset: 0x0007F873
		public static Length wordSpacing
		{
			get
			{
				return InitialStyle.s_InitialStyle.inheritedData.Read().wordSpacing;
			}
		}

		// Token: 0x04000D63 RID: 3427
		private static ComputedStyle s_InitialStyle = ComputedStyle.CreateInitial();
	}
}
