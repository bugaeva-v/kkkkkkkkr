using System;
using System.Collections.Generic;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B9 RID: 185
	public class TextElement : BindableElement, ITextElement, INotifyValueChanged<string>
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00016D7C File Offset: 0x00014F7C
		public TextElement()
		{
			base.requireMeasureFunction = true;
			base.AddToClassList(TextElement.ussClassName);
			base.generateVisualContent = (Action<MeshGenerationContext>)Delegate.Combine(base.generateVisualContent, new Action<MeshGenerationContext>(this.OnGenerateVisualContent));
			base.RegisterCallback<GeometryChangedEvent>(new EventCallback<GeometryChangedEvent>(this.OnGeometryChanged), TrickleDown.NoTrickleDown);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00016E08 File Offset: 0x00015008
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00016E20 File Offset: 0x00015020
		internal ITextHandle textHandle
		{
			get
			{
				return this.m_TextHandle;
			}
			set
			{
				this.m_TextHandle = value;
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00016E2C File Offset: 0x0001502C
		public override void HandleEvent(EventBase evt)
		{
			bool flag;
			if (evt.eventTypeId == EventBase<AttachToPanelEvent>.TypeId())
			{
				AttachToPanelEvent attachToPanelEvent = evt as AttachToPanelEvent;
				flag = (attachToPanelEvent != null);
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			if (flag2)
			{
				this.textHandle = TextCoreHandle.New();
			}
			else
			{
				bool flag3;
				if (evt.eventTypeId == EventBase<DetachFromPanelEvent>.TypeId())
				{
					DetachFromPanelEvent detachFromPanelEvent = evt as DetachFromPanelEvent;
					flag3 = (detachFromPanelEvent != null);
				}
				else
				{
					flag3 = false;
				}
				bool flag4 = flag3;
				if (flag4)
				{
				}
			}
			base.HandleEvent(evt);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00016E92 File Offset: 0x00015092
		private void OnGeometryChanged(GeometryChangedEvent e)
		{
			this.UpdateVisibleText();
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00016E9C File Offset: 0x0001509C
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00016EB4 File Offset: 0x000150B4
		public virtual string text
		{
			get
			{
				return ((INotifyValueChanged<string>)this).value;
			}
			set
			{
				((INotifyValueChanged<string>)this).value = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00016EC0 File Offset: 0x000150C0
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00016ED8 File Offset: 0x000150D8
		public bool enableRichText
		{
			get
			{
				return this.m_EnableRichText;
			}
			set
			{
				bool flag = this.m_EnableRichText == value;
				if (!flag)
				{
					this.m_EnableRichText = value;
					base.MarkDirtyRepaint();
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00016F04 File Offset: 0x00015104
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00016F1C File Offset: 0x0001511C
		public bool displayTooltipWhenElided
		{
			get
			{
				return this.m_DisplayTooltipWhenElided;
			}
			set
			{
				bool flag = this.m_DisplayTooltipWhenElided != value;
				if (flag)
				{
					this.m_DisplayTooltipWhenElided = value;
					this.UpdateVisibleText();
					base.MarkDirtyRepaint();
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00016F51 File Offset: 0x00015151
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00016F59 File Offset: 0x00015159
		public bool isElided { get; private set; }

		// Token: 0x06000627 RID: 1575 RVA: 0x00016F64 File Offset: 0x00015164
		private void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			this.UpdateVisibleText();
			mgc.Text(this.m_TextParams, this.m_TextHandle, base.scaledPixelsPerPoint);
			bool flag = this.ShouldElide() && this.TextLibraryCanElide();
			if (flag)
			{
				this.isElided = this.textHandle.IsElided();
			}
			this.UpdateTooltip();
			this.m_UpdateTextParams = true;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00016FC8 File Offset: 0x000151C8
		internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
		{
			float num = base.resolvedStyle.paddingRight;
			bool flag = float.IsNaN(num);
			if (flag)
			{
				num = 0f;
			}
			float num2 = Mathf.Clamp(num, 1f / base.scaledPixelsPerPoint, 1f);
			Vector2 vector = this.MeasureTextSize(drawText, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
			bool flag2 = vector.x <= width + num2 || string.IsNullOrEmpty(ellipsisText);
			string result;
			if (flag2)
			{
				result = drawText;
			}
			else
			{
				string text = (drawText.Length > 1) ? ellipsisText : drawText;
				Vector2 vector2 = this.MeasureTextSize(text, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
				bool flag3 = vector2.x >= width;
				if (flag3)
				{
					result = text;
				}
				else
				{
					int num3 = drawText.Length - 1;
					int num4 = -1;
					string text2 = drawText;
					int i = (textOverflowPosition == TextOverflowPosition.Start) ? 1 : 0;
					int num5 = (textOverflowPosition == TextOverflowPosition.Start || textOverflowPosition == TextOverflowPosition.Middle) ? num3 : (num3 - 1);
					int num6 = (i + num5) / 2;
					while (i <= num5)
					{
						bool flag4 = textOverflowPosition == TextOverflowPosition.Start;
						if (flag4)
						{
							text2 = ellipsisText + drawText.Substring(num6, num3 - (num6 - 1));
						}
						else
						{
							bool flag5 = textOverflowPosition == TextOverflowPosition.End;
							if (flag5)
							{
								text2 = drawText.Substring(0, num6) + ellipsisText;
							}
							else
							{
								bool flag6 = textOverflowPosition == TextOverflowPosition.Middle;
								if (flag6)
								{
									text2 = ((num6 - 1 <= 0) ? "" : drawText.Substring(0, num6 - 1)) + ellipsisText + ((num3 - (num6 - 1) <= 0) ? "" : drawText.Substring(num3 - (num6 - 1)));
								}
							}
						}
						vector = this.MeasureTextSize(text2, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
						bool flag7 = Math.Abs(vector.x - width) < 1E-30f;
						if (flag7)
						{
							return text2;
						}
						bool flag8 = textOverflowPosition == TextOverflowPosition.Start;
						if (flag8)
						{
							bool flag9 = vector.x > width;
							if (flag9)
							{
								bool flag10 = num4 == num6 - 1;
								if (flag10)
								{
									return ellipsisText + drawText.Substring(num4, num3 - (num4 - 1));
								}
								i = num6 + 1;
							}
							else
							{
								num5 = num6 - 1;
								num4 = num6;
							}
						}
						else
						{
							bool flag11 = textOverflowPosition == TextOverflowPosition.End || textOverflowPosition == TextOverflowPosition.Middle;
							if (flag11)
							{
								bool flag12 = vector.x > width;
								if (flag12)
								{
									bool flag13 = num4 == num6 - 1;
									if (flag13)
									{
										bool flag14 = textOverflowPosition == TextOverflowPosition.End;
										if (flag14)
										{
											return drawText.Substring(0, num4) + ellipsisText;
										}
										return drawText.Substring(0, Mathf.Max(num4 - 1, 0)) + ellipsisText + drawText.Substring(num3 - Mathf.Max(num4 - 1, 0));
									}
									else
									{
										num5 = num6 - 1;
									}
								}
								else
								{
									i = num6 + 1;
									num4 = num6;
								}
							}
						}
						num6 = (i + num5) / 2;
					}
					result = text2;
				}
			}
			return result;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000172A0 File Offset: 0x000154A0
		private void UpdateTooltip()
		{
			bool flag = this.displayTooltipWhenElided && this.isElided;
			bool flag2 = flag;
			if (flag2)
			{
				base.tooltip = this.text;
				this.m_WasElided = true;
			}
			else
			{
				bool wasElided = this.m_WasElided;
				if (wasElided)
				{
					base.tooltip = null;
					this.m_WasElided = false;
				}
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000172F8 File Offset: 0x000154F8
		private void UpdateVisibleText()
		{
			MeshGenerationContextUtils.TextParams textParams = MeshGenerationContextUtils.TextParams.MakeStyleBased(this, this.text);
			int hashCode = textParams.GetHashCode();
			bool flag = this.m_UpdateTextParams || hashCode != this.m_PreviousTextParamsHashCode;
			if (flag)
			{
				this.m_TextParams = textParams;
				bool flag2 = this.ShouldElide();
				bool flag3 = flag2 && this.TextLibraryCanElide();
				if (!flag3)
				{
					bool flag4 = flag2;
					if (flag4)
					{
						this.m_TextParams.text = this.ElideText(this.m_TextParams.text, TextElement.k_EllipsisText, this.m_TextParams.rect.width, this.m_TextParams.textOverflowPosition);
						this.isElided = (flag2 && this.m_TextParams.text != this.text);
						this.m_TextParams.textOverflow = TextOverflow.Clip;
					}
					else
					{
						this.m_TextParams.textOverflow = TextOverflow.Clip;
						this.isElided = false;
					}
				}
				this.m_PreviousTextParamsHashCode = hashCode;
				this.m_UpdateTextParams = false;
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00017404 File Offset: 0x00015604
		private bool ShouldElide()
		{
			return base.computedStyle.textOverflow == TextOverflow.Ellipsis && base.computedStyle.overflow == OverflowInternal.Hidden && base.computedStyle.whiteSpace == WhiteSpace.NoWrap;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00017444 File Offset: 0x00015644
		private bool TextLibraryCanElide()
		{
			bool flag = this.textHandle.IsLegacy();
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = this.m_TextParams.textOverflowPosition == TextOverflowPosition.End;
				result = flag2;
			}
			return result;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00017480 File Offset: 0x00015680
		public Vector2 MeasureTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
		{
			return TextUtilities.MeasureVisualElementTextSize(this, textToMeasure, width, widthMode, height, heightMode, this.m_TextHandle);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000174A8 File Offset: 0x000156A8
		internal static Vector2 MeasureVisualElementTextSize(VisualElement ve, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, TextHandle textHandle)
		{
			return TextUtilities.MeasureVisualElementTextSize(ve, textToMeasure, width, widthMode, height, heightMode, textHandle.textHandle);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000174D0 File Offset: 0x000156D0
		protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return this.MeasureTextSize(this.text, desiredWidth, widthMode, desiredHeight, heightMode);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000174F4 File Offset: 0x000156F4
		internal int VerticesCount(string text)
		{
			MeshGenerationContextUtils.TextParams textParams = this.m_TextParams;
			textParams.text = text;
			return this.textHandle.VerticesCount(textParams, base.scaledPixelsPerPoint);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00017528 File Offset: 0x00015728
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x0001754C File Offset: 0x0001574C
		string INotifyValueChanged<string>.value
		{
			get
			{
				return this.m_Text ?? string.Empty;
			}
			set
			{
				bool flag = this.m_Text != value;
				if (flag)
				{
					bool flag2 = base.panel != null;
					if (flag2)
					{
						using (ChangeEvent<string> pooled = ChangeEvent<string>.GetPooled(this.text, value))
						{
							pooled.target = this;
							((INotifyValueChanged<string>)this).SetValueWithoutNotify(value);
							this.SendEvent(pooled);
						}
					}
					else
					{
						((INotifyValueChanged<string>)this).SetValueWithoutNotify(value);
					}
				}
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000175CC File Offset: 0x000157CC
		void INotifyValueChanged<string>.SetValueWithoutNotify(string newValue)
		{
			bool flag = this.m_Text != newValue;
			if (flag)
			{
				this.m_Text = newValue;
				base.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Repaint);
				bool flag2 = !string.IsNullOrEmpty(base.viewDataKey);
				if (flag2)
				{
					base.SaveViewData();
				}
			}
		}

		// Token: 0x0400026B RID: 619
		public static readonly string ussClassName = "unity-text-element";

		// Token: 0x0400026C RID: 620
		private ITextHandle m_TextHandle;

		// Token: 0x0400026D RID: 621
		internal static int maxTextVertices = MeshBuilder.s_MaxTextMeshVertices;

		// Token: 0x0400026E RID: 622
		[SerializeField]
		private string m_Text = string.Empty;

		// Token: 0x0400026F RID: 623
		private bool m_EnableRichText = true;

		// Token: 0x04000270 RID: 624
		private bool m_DisplayTooltipWhenElided = true;

		// Token: 0x04000272 RID: 626
		internal static readonly string k_EllipsisText = "...";

		// Token: 0x04000273 RID: 627
		private bool m_WasElided;

		// Token: 0x04000274 RID: 628
		private bool m_UpdateTextParams = true;

		// Token: 0x04000275 RID: 629
		private MeshGenerationContextUtils.TextParams m_TextParams;

		// Token: 0x04000276 RID: 630
		private int m_PreviousTextParamsHashCode = int.MaxValue;

		// Token: 0x020000BA RID: 186
		public new class UxmlFactory : UxmlFactory<TextElement, TextElement.UxmlTraits>
		{
		}

		// Token: 0x020000BB RID: 187
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x1700016D RID: 365
			// (get) Token: 0x06000636 RID: 1590 RVA: 0x00017644 File Offset: 0x00015844
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get
				{
					yield break;
				}
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x00017664 File Offset: 0x00015864
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				TextElement textElement = (TextElement)ve;
				textElement.text = this.m_Text.GetValueFromBag(bag, cc);
				textElement.enableRichText = this.m_EnableRichText.GetValueFromBag(bag, cc);
				textElement.displayTooltipWhenElided = this.m_DisplayTooltipWhenElided.GetValueFromBag(bag, cc);
			}

			// Token: 0x04000277 RID: 631
			private UxmlStringAttributeDescription m_Text = new UxmlStringAttributeDescription
			{
				name = "text"
			};

			// Token: 0x04000278 RID: 632
			private UxmlBoolAttributeDescription m_EnableRichText = new UxmlBoolAttributeDescription
			{
				name = "enable-rich-text",
				defaultValue = true
			};

			// Token: 0x04000279 RID: 633
			private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided = new UxmlBoolAttributeDescription
			{
				name = "display-tooltip-when-elided"
			};
		}
	}
}
