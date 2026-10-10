using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016B RID: 363
	public class Scroller : VisualElement
	{
		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000B75 RID: 2933 RVA: 0x0002EF10 File Offset: 0x0002D110
		// (remove) Token: 0x06000B76 RID: 2934 RVA: 0x0002EF48 File Offset: 0x0002D148
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<float> valueChanged;

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0002EF7D File Offset: 0x0002D17D
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0002EF85 File Offset: 0x0002D185
		public Slider slider { get; private set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0002EF8E File Offset: 0x0002D18E
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x0002EF96 File Offset: 0x0002D196
		public RepeatButton lowButton { get; private set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0002EF9F File Offset: 0x0002D19F
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x0002EFA7 File Offset: 0x0002D1A7
		public RepeatButton highButton { get; private set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x0002EFCD File Offset: 0x0002D1CD
		public float value
		{
			get
			{
				return this.slider.value;
			}
			set
			{
				this.slider.value = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0002EFFD File Offset: 0x0002D1FD
		public float lowValue
		{
			get
			{
				return this.slider.lowValue;
			}
			set
			{
				this.slider.lowValue = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0002F010 File Offset: 0x0002D210
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x0002F02D File Offset: 0x0002D22D
		public float highValue
		{
			get
			{
				return this.slider.highValue;
			}
			set
			{
				this.slider.highValue = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0002F040 File Offset: 0x0002D240
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x0002F064 File Offset: 0x0002D264
		public SliderDirection direction
		{
			get
			{
				return (base.resolvedStyle.flexDirection == FlexDirection.Row) ? SliderDirection.Horizontal : SliderDirection.Vertical;
			}
			set
			{
				this.slider.direction = value;
				bool flag = value == SliderDirection.Horizontal;
				if (flag)
				{
					base.style.flexDirection = FlexDirection.Row;
					base.AddToClassList(Scroller.horizontalVariantUssClassName);
					base.RemoveFromClassList(Scroller.verticalVariantUssClassName);
				}
				else
				{
					base.style.flexDirection = FlexDirection.Column;
					base.AddToClassList(Scroller.verticalVariantUssClassName);
					base.RemoveFromClassList(Scroller.horizontalVariantUssClassName);
				}
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0002F0E1 File Offset: 0x0002D2E1
		public Scroller() : this(0f, 0f, null, SliderDirection.Vertical)
		{
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
		public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical)
		{
			base.AddToClassList(Scroller.ussClassName);
			this.slider = new Slider(lowValue, highValue, direction, 20f)
			{
				name = "unity-slider",
				viewDataKey = "Slider"
			};
			this.slider.AddToClassList(Scroller.sliderUssClassName);
			this.slider.RegisterValueChangedCallback(new EventCallback<ChangeEvent<float>>(this.OnSliderValueChange));
			this.slider.inverted = (direction == SliderDirection.Vertical);
			this.lowButton = new RepeatButton(new Action(this.ScrollPageUp), 250L, 30L)
			{
				name = "unity-low-button"
			};
			this.lowButton.AddToClassList(Scroller.lowButtonUssClassName);
			base.Add(this.lowButton);
			this.highButton = new RepeatButton(new Action(this.ScrollPageDown), 250L, 30L)
			{
				name = "unity-high-button"
			};
			this.highButton.AddToClassList(Scroller.highButtonUssClassName);
			base.Add(this.highButton);
			base.Add(this.slider);
			this.direction = direction;
			this.valueChanged = valueChanged;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0002F233 File Offset: 0x0002D433
		public void Adjust(float factor)
		{
			base.SetEnabled(factor < 1f);
			this.slider.AdjustDragElement(factor);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0002F252 File Offset: 0x0002D452
		private void OnSliderValueChange(ChangeEvent<float> evt)
		{
			this.value = evt.newValue;
			Action<float> action = this.valueChanged;
			if (action != null)
			{
				action(this.slider.value);
			}
			base.IncrementVersion(VersionChangeType.Repaint);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0002F28B File Offset: 0x0002D48B
		public void ScrollPageUp()
		{
			this.ScrollPageUp(1f);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0002F29A File Offset: 0x0002D49A
		public void ScrollPageDown()
		{
			this.ScrollPageDown(1f);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0002F2AC File Offset: 0x0002D4AC
		public void ScrollPageUp(float factor)
		{
			this.value -= factor * (this.slider.pageSize * ((this.slider.lowValue < this.slider.highValue) ? 1f : -1f));
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0002F2FC File Offset: 0x0002D4FC
		public void ScrollPageDown(float factor)
		{
			this.value += factor * (this.slider.pageSize * ((this.slider.lowValue < this.slider.highValue) ? 1f : -1f));
		}

		// Token: 0x04000542 RID: 1346
		internal const float kDefaultPageSize = 20f;

		// Token: 0x04000543 RID: 1347
		public static readonly string ussClassName = "unity-scroller";

		// Token: 0x04000544 RID: 1348
		public static readonly string horizontalVariantUssClassName = Scroller.ussClassName + "--horizontal";

		// Token: 0x04000545 RID: 1349
		public static readonly string verticalVariantUssClassName = Scroller.ussClassName + "--vertical";

		// Token: 0x04000546 RID: 1350
		public static readonly string sliderUssClassName = Scroller.ussClassName + "__slider";

		// Token: 0x04000547 RID: 1351
		public static readonly string lowButtonUssClassName = Scroller.ussClassName + "__low-button";

		// Token: 0x04000548 RID: 1352
		public static readonly string highButtonUssClassName = Scroller.ussClassName + "__high-button";

		// Token: 0x0200016C RID: 364
		public new class UxmlFactory : UxmlFactory<Scroller, Scroller.UxmlTraits>
		{
		}

		// Token: 0x0200016D RID: 365
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x1700023D RID: 573
			// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0002F3D0 File Offset: 0x0002D5D0
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get
				{
					yield break;
				}
			}

			// Token: 0x06000B90 RID: 2960 RVA: 0x0002F3F0 File Offset: 0x0002D5F0
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				Scroller scroller = (Scroller)ve;
				scroller.slider.lowValue = this.m_LowValue.GetValueFromBag(bag, cc);
				scroller.slider.highValue = this.m_HighValue.GetValueFromBag(bag, cc);
				scroller.direction = this.m_Direction.GetValueFromBag(bag, cc);
				scroller.value = this.m_Value.GetValueFromBag(bag, cc);
			}

			// Token: 0x04000549 RID: 1353
			private UxmlFloatAttributeDescription m_LowValue = new UxmlFloatAttributeDescription
			{
				name = "low-value",
				obsoleteNames = new string[]
				{
					"lowValue"
				}
			};

			// Token: 0x0400054A RID: 1354
			private UxmlFloatAttributeDescription m_HighValue = new UxmlFloatAttributeDescription
			{
				name = "high-value",
				obsoleteNames = new string[]
				{
					"highValue"
				}
			};

			// Token: 0x0400054B RID: 1355
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction = new UxmlEnumAttributeDescription<SliderDirection>
			{
				name = "direction",
				defaultValue = SliderDirection.Vertical
			};

			// Token: 0x0400054C RID: 1356
			private UxmlFloatAttributeDescription m_Value = new UxmlFloatAttributeDescription
			{
				name = "value"
			};
		}
	}
}
