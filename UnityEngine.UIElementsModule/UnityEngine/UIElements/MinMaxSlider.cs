using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000156 RID: 342
	public class MinMaxSlider : BaseField<Vector2>
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0002D320 File Offset: 0x0002B520
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x0002D328 File Offset: 0x0002B528
		internal VisualElement dragElement { get; private set; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0002D331 File Offset: 0x0002B531
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0002D339 File Offset: 0x0002B539
		internal VisualElement dragMinThumb { get; private set; }

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0002D342 File Offset: 0x0002B542
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0002D34A File Offset: 0x0002B54A
		internal VisualElement dragMaxThumb { get; private set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0002D353 File Offset: 0x0002B553
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x0002D35B File Offset: 0x0002B55B
		internal ClampedDragger<float> clampedDragger { get; private set; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0002D364 File Offset: 0x0002B564
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x0002D381 File Offset: 0x0002B581
		public float minValue
		{
			get
			{
				return this.value.x;
			}
			set
			{
				base.value = this.ClampValues(new Vector2(value, base.rawValue.y));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0002D3A4 File Offset: 0x0002B5A4
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0002D3C1 File Offset: 0x0002B5C1
		public float maxValue
		{
			get
			{
				return this.value.y;
			}
			set
			{
				base.value = this.ClampValues(new Vector2(base.rawValue.x, value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0002D3E4 File Offset: 0x0002B5E4
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x0002D3FC File Offset: 0x0002B5FC
		public override Vector2 value
		{
			get
			{
				return base.value;
			}
			set
			{
				base.value = this.ClampValues(value);
			}
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0002D40D File Offset: 0x0002B60D
		public override void SetValueWithoutNotify(Vector2 newValue)
		{
			base.SetValueWithoutNotify(this.ClampValues(newValue));
			this.UpdateDragElementPosition();
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0002D428 File Offset: 0x0002B628
		public float range
		{
			get
			{
				return Math.Abs(this.highLimit - this.lowLimit);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0002D44C File Offset: 0x0002B64C
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x0002D464 File Offset: 0x0002B664
		public float lowLimit
		{
			get
			{
				return this.m_MinLimit;
			}
			set
			{
				bool flag = !Mathf.Approximately(this.m_MinLimit, value);
				if (flag)
				{
					bool flag2 = value > this.m_MaxLimit;
					if (flag2)
					{
						throw new ArgumentException("lowLimit is greater than highLimit");
					}
					this.m_MinLimit = value;
					this.value = base.rawValue;
					this.UpdateDragElementPosition();
					bool flag3 = !string.IsNullOrEmpty(base.viewDataKey);
					if (flag3)
					{
						base.SaveViewData();
					}
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0002D4D4 File Offset: 0x0002B6D4
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0002D4EC File Offset: 0x0002B6EC
		public float highLimit
		{
			get
			{
				return this.m_MaxLimit;
			}
			set
			{
				bool flag = !Mathf.Approximately(this.m_MaxLimit, value);
				if (flag)
				{
					bool flag2 = value < this.m_MinLimit;
					if (flag2)
					{
						throw new ArgumentException("highLimit is smaller than lowLimit");
					}
					this.m_MaxLimit = value;
					this.value = base.rawValue;
					this.UpdateDragElementPosition();
					bool flag3 = !string.IsNullOrEmpty(base.viewDataKey);
					if (flag3)
					{
						base.SaveViewData();
					}
				}
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0002D55C File Offset: 0x0002B75C
		public MinMaxSlider() : this(null, 0f, 10f, float.MinValue, float.MaxValue)
		{
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0002D57B File Offset: 0x0002B77B
		public MinMaxSlider(float minValue, float maxValue, float minLimit, float maxLimit) : this(null, minValue, maxValue, minLimit, maxLimit)
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0002D58C File Offset: 0x0002B78C
		public MinMaxSlider(string label, float minValue = 0f, float maxValue = 10f, float minLimit = -3.4028235E+38f, float maxLimit = 3.4028235E+38f) : base(label, null)
		{
			this.lowLimit = minLimit;
			this.highLimit = maxLimit;
			this.minValue = minValue;
			this.maxValue = maxValue;
			base.AddToClassList(MinMaxSlider.ussClassName);
			base.labelElement.AddToClassList(MinMaxSlider.labelUssClassName);
			base.visualInput.AddToClassList(MinMaxSlider.inputUssClassName);
			base.pickingMode = PickingMode.Ignore;
			this.m_DragState = MinMaxSlider.DragState.NoThumb;
			base.visualInput.pickingMode = PickingMode.Position;
			VisualElement visualElement = new VisualElement
			{
				name = "unity-tracker"
			};
			visualElement.AddToClassList(MinMaxSlider.trackerUssClassName);
			base.visualInput.Add(visualElement);
			this.dragElement = new VisualElement
			{
				name = "unity-dragger"
			};
			this.dragElement.AddToClassList(MinMaxSlider.draggerUssClassName);
			this.dragElement.RegisterCallback<GeometryChangedEvent>(new EventCallback<GeometryChangedEvent>(this.UpdateDragElementPosition), TrickleDown.NoTrickleDown);
			base.visualInput.Add(this.dragElement);
			this.dragMinThumb = new VisualElement
			{
				name = "unity-thumb-min"
			};
			this.dragMaxThumb = new VisualElement
			{
				name = "unity-thumb-max"
			};
			this.dragMinThumb.AddToClassList(MinMaxSlider.minThumbUssClassName);
			this.dragMaxThumb.AddToClassList(MinMaxSlider.maxThumbUssClassName);
			this.dragElement.Add(this.dragMinThumb);
			this.dragElement.Add(this.dragMaxThumb);
			this.clampedDragger = new ClampedDragger<float>(null, new Action(this.SetSliderValueFromClick), new Action(this.SetSliderValueFromDrag));
			base.visualInput.AddManipulator(this.clampedDragger);
			this.m_MinLimit = minLimit;
			this.m_MaxLimit = maxLimit;
			base.rawValue = this.ClampValues(new Vector2(minValue, maxValue));
			this.UpdateDragElementPosition();
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0002D768 File Offset: 0x0002B968
		private Vector2 ClampValues(Vector2 valueToClamp)
		{
			bool flag = this.m_MinLimit > this.m_MaxLimit;
			if (flag)
			{
				this.m_MinLimit = this.m_MaxLimit;
			}
			Vector2 result = default(Vector2);
			bool flag2 = valueToClamp.y > this.m_MaxLimit;
			if (flag2)
			{
				valueToClamp.y = this.m_MaxLimit;
			}
			result.x = Mathf.Clamp(valueToClamp.x, this.m_MinLimit, valueToClamp.y);
			result.y = Mathf.Clamp(valueToClamp.y, valueToClamp.x, this.m_MaxLimit);
			return result;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0002D800 File Offset: 0x0002BA00
		private void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
			bool flag = evt.oldRect.size == evt.newRect.size;
			if (!flag)
			{
				this.UpdateDragElementPosition();
			}
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0002D840 File Offset: 0x0002BA40
		private void UpdateDragElementPosition()
		{
			bool flag = base.panel == null;
			if (!flag)
			{
				float num = -this.dragElement.resolvedStyle.marginLeft - this.dragElement.resolvedStyle.marginRight;
				int num2 = this.dragElement.resolvedStyle.unitySliceLeft + this.dragElement.resolvedStyle.unitySliceRight;
				float num3 = Mathf.Round(this.SliderLerpUnclamped((float)this.dragElement.resolvedStyle.unitySliceLeft, base.visualInput.layout.width + num - (float)this.dragElement.resolvedStyle.unitySliceRight, this.SliderNormalizeValue(this.minValue, this.lowLimit, this.highLimit)) - (float)this.dragElement.resolvedStyle.unitySliceLeft);
				float num4 = Mathf.Round(this.SliderLerpUnclamped((float)this.dragElement.resolvedStyle.unitySliceLeft, base.visualInput.layout.width + num - (float)this.dragElement.resolvedStyle.unitySliceRight, this.SliderNormalizeValue(this.maxValue, this.lowLimit, this.highLimit)) + (float)this.dragElement.resolvedStyle.unitySliceRight);
				this.dragElement.style.width = Mathf.Max((float)num2, num4 - num3);
				this.dragElement.style.left = num3;
				float left = this.dragElement.resolvedStyle.left;
				float x = this.dragElement.resolvedStyle.left + (this.dragElement.resolvedStyle.width - (float)this.dragElement.resolvedStyle.unitySliceRight);
				float y = this.dragElement.layout.yMin + this.dragMinThumb.resolvedStyle.marginTop;
				float y2 = this.dragElement.layout.yMin + this.dragMaxThumb.resolvedStyle.marginTop;
				float height = Mathf.Max(this.dragElement.resolvedStyle.height, this.dragMinThumb.resolvedStyle.height);
				float height2 = Mathf.Max(this.dragElement.resolvedStyle.height, this.dragMaxThumb.resolvedStyle.height);
				this.m_DragMinThumbRect = new Rect(left, y, (float)this.dragElement.resolvedStyle.unitySliceLeft, height);
				this.m_DragMaxThumbRect = new Rect(x, y2, (float)this.dragElement.resolvedStyle.unitySliceRight, height2);
				this.dragMaxThumb.style.left = this.dragElement.resolvedStyle.width - (float)this.dragElement.resolvedStyle.unitySliceRight;
				this.dragMaxThumb.style.top = 0f;
				this.dragMinThumb.style.width = this.m_DragMinThumbRect.width;
				this.dragMinThumb.style.height = this.m_DragMinThumbRect.height;
				this.dragMinThumb.style.left = 0f;
				this.dragMinThumb.style.top = 0f;
				this.dragMaxThumb.style.width = this.m_DragMaxThumbRect.width;
				this.dragMaxThumb.style.height = this.m_DragMaxThumbRect.height;
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0002DBF0 File Offset: 0x0002BDF0
		internal float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			return Mathf.LerpUnclamped(a, b, interpolant);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0002DC0C File Offset: 0x0002BE0C
		internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return (currentValue - lowerValue) / (higherValue - lowerValue);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0002DC28 File Offset: 0x0002BE28
		private float ComputeValueFromPosition(float positionToConvert)
		{
			float interpolant = this.SliderNormalizeValue(positionToConvert, (float)this.dragElement.resolvedStyle.unitySliceLeft, base.visualInput.layout.width - (float)this.dragElement.resolvedStyle.unitySliceRight);
			return this.SliderLerpUnclamped(this.lowLimit, this.highLimit, interpolant);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0002DC8C File Offset: 0x0002BE8C
		protected override void ExecuteDefaultAction(EventBase evt)
		{
			base.ExecuteDefaultAction(evt);
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = evt.eventTypeId == EventBase<GeometryChangedEvent>.TypeId();
				if (flag2)
				{
					this.UpdateDragElementPosition((GeometryChangedEvent)evt);
				}
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0002DCD0 File Offset: 0x0002BED0
		private void SetSliderValueFromDrag()
		{
			bool flag = this.clampedDragger.dragDirection != ClampedDragger<float>.DragDirection.Free;
			if (!flag)
			{
				float x = this.m_DragElementStartPos.x;
				float dragElementEndPos = x + this.clampedDragger.delta.x;
				this.ComputeValueFromDraggingThumb(x, dragElementEndPos);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0002DD20 File Offset: 0x0002BF20
		private void SetSliderValueFromClick()
		{
			bool flag = this.clampedDragger.dragDirection == ClampedDragger<float>.DragDirection.Free;
			if (!flag)
			{
				bool flag2 = this.m_DragMinThumbRect.Contains(this.clampedDragger.startMousePosition);
				if (flag2)
				{
					this.m_DragState = MinMaxSlider.DragState.MinThumb;
				}
				else
				{
					bool flag3 = this.m_DragMaxThumbRect.Contains(this.clampedDragger.startMousePosition);
					if (flag3)
					{
						this.m_DragState = MinMaxSlider.DragState.MaxThumb;
					}
					else
					{
						bool flag4 = this.clampedDragger.startMousePosition.x > this.dragElement.layout.xMin && this.clampedDragger.startMousePosition.x < this.dragElement.layout.xMax;
						if (flag4)
						{
							this.m_DragState = MinMaxSlider.DragState.MiddleThumb;
						}
						else
						{
							this.m_DragState = MinMaxSlider.DragState.NoThumb;
						}
					}
				}
				bool flag5 = this.m_DragState == MinMaxSlider.DragState.NoThumb;
				if (flag5)
				{
					float num = this.ComputeValueFromPosition(this.clampedDragger.startMousePosition.x);
					bool flag6 = this.clampedDragger.startMousePosition.x < this.dragElement.layout.x;
					if (flag6)
					{
						this.m_DragState = MinMaxSlider.DragState.MinThumb;
						this.value = new Vector2(num, this.value.y);
					}
					else
					{
						this.m_DragState = MinMaxSlider.DragState.MaxThumb;
						this.value = new Vector2(this.value.x, num);
					}
				}
				this.m_ValueStartPos = this.value;
				this.clampedDragger.dragDirection = ClampedDragger<float>.DragDirection.Free;
				this.m_DragElementStartPos = this.clampedDragger.startMousePosition;
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0002DEC4 File Offset: 0x0002C0C4
		private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos)
		{
			float num = this.ComputeValueFromPosition(dragElementStartPos);
			float num2 = this.ComputeValueFromPosition(dragElementEndPos);
			float num3 = num2 - num;
			switch (this.m_DragState)
			{
			case MinMaxSlider.DragState.MinThumb:
			{
				float num4 = this.m_ValueStartPos.x + num3;
				bool flag = num4 > this.maxValue;
				if (flag)
				{
					num4 = this.maxValue;
				}
				else
				{
					bool flag2 = num4 < this.lowLimit;
					if (flag2)
					{
						num4 = this.lowLimit;
					}
				}
				this.value = new Vector2(num4, this.maxValue);
				break;
			}
			case MinMaxSlider.DragState.MiddleThumb:
			{
				Vector2 value = this.value;
				value.x = this.m_ValueStartPos.x + num3;
				value.y = this.m_ValueStartPos.y + num3;
				float num5 = this.m_ValueStartPos.y - this.m_ValueStartPos.x;
				bool flag3 = value.x < this.lowLimit;
				if (flag3)
				{
					value.x = this.lowLimit;
					value.y = this.lowLimit + num5;
				}
				else
				{
					bool flag4 = value.y > this.highLimit;
					if (flag4)
					{
						value.y = this.highLimit;
						value.x = this.highLimit - num5;
					}
				}
				this.value = value;
				break;
			}
			case MinMaxSlider.DragState.MaxThumb:
			{
				float num6 = this.m_ValueStartPos.y + num3;
				bool flag5 = num6 < this.minValue;
				if (flag5)
				{
					num6 = this.minValue;
				}
				else
				{
					bool flag6 = num6 > this.highLimit;
					if (flag6)
					{
						num6 = this.highLimit;
					}
				}
				this.value = new Vector2(this.minValue, num6);
				break;
			}
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00002166 File Offset: 0x00000366
		protected override void UpdateMixedValueContent()
		{
		}

		// Token: 0x040004FD RID: 1277
		private Vector2 m_DragElementStartPos;

		// Token: 0x040004FE RID: 1278
		private Vector2 m_ValueStartPos;

		// Token: 0x040004FF RID: 1279
		private Rect m_DragMinThumbRect;

		// Token: 0x04000500 RID: 1280
		private Rect m_DragMaxThumbRect;

		// Token: 0x04000501 RID: 1281
		private MinMaxSlider.DragState m_DragState;

		// Token: 0x04000502 RID: 1282
		private float m_MinLimit;

		// Token: 0x04000503 RID: 1283
		private float m_MaxLimit;

		// Token: 0x04000504 RID: 1284
		internal const float kDefaultHighValue = 10f;

		// Token: 0x04000505 RID: 1285
		public new static readonly string ussClassName = "unity-min-max-slider";

		// Token: 0x04000506 RID: 1286
		public new static readonly string labelUssClassName = MinMaxSlider.ussClassName + "__label";

		// Token: 0x04000507 RID: 1287
		public new static readonly string inputUssClassName = MinMaxSlider.ussClassName + "__input";

		// Token: 0x04000508 RID: 1288
		public static readonly string trackerUssClassName = MinMaxSlider.ussClassName + "__tracker";

		// Token: 0x04000509 RID: 1289
		public static readonly string draggerUssClassName = MinMaxSlider.ussClassName + "__dragger";

		// Token: 0x0400050A RID: 1290
		public static readonly string minThumbUssClassName = MinMaxSlider.ussClassName + "__min-thumb";

		// Token: 0x0400050B RID: 1291
		public static readonly string maxThumbUssClassName = MinMaxSlider.ussClassName + "__max-thumb";

		// Token: 0x02000157 RID: 343
		public new class UxmlFactory : UxmlFactory<MinMaxSlider, MinMaxSlider.UxmlTraits>
		{
		}

		// Token: 0x02000158 RID: 344
		public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
		{
			// Token: 0x06000B32 RID: 2866 RVA: 0x0002E11C File Offset: 0x0002C31C
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				MinMaxSlider minMaxSlider = (MinMaxSlider)ve;
				minMaxSlider.minValue = this.m_MinValue.GetValueFromBag(bag, cc);
				minMaxSlider.maxValue = this.m_MaxValue.GetValueFromBag(bag, cc);
				minMaxSlider.lowLimit = this.m_LowLimit.GetValueFromBag(bag, cc);
				minMaxSlider.highLimit = this.m_HighLimit.GetValueFromBag(bag, cc);
			}

			// Token: 0x0400050C RID: 1292
			private UxmlFloatAttributeDescription m_MinValue = new UxmlFloatAttributeDescription
			{
				name = "min-value",
				defaultValue = 0f
			};

			// Token: 0x0400050D RID: 1293
			private UxmlFloatAttributeDescription m_MaxValue = new UxmlFloatAttributeDescription
			{
				name = "max-value",
				defaultValue = 10f
			};

			// Token: 0x0400050E RID: 1294
			private UxmlFloatAttributeDescription m_LowLimit = new UxmlFloatAttributeDescription
			{
				name = "low-limit",
				defaultValue = float.MinValue
			};

			// Token: 0x0400050F RID: 1295
			private UxmlFloatAttributeDescription m_HighLimit = new UxmlFloatAttributeDescription
			{
				name = "high-limit",
				defaultValue = float.MaxValue
			};
		}

		// Token: 0x02000159 RID: 345
		private enum DragState
		{
			// Token: 0x04000511 RID: 1297
			NoThumb,
			// Token: 0x04000512 RID: 1298
			MinThumb,
			// Token: 0x04000513 RID: 1299
			MiddleThumb,
			// Token: 0x04000514 RID: 1300
			MaxThumb
		}
	}
}
