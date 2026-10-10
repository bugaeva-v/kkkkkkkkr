using System;
using System.Diagnostics;

namespace UnityEngine.UIElements
{
	// Token: 0x02000186 RID: 390
	public abstract class TextInputBaseField<TValueType> : BaseField<TValueType>
	{
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00033379 File Offset: 0x00031579
		protected internal TextInputBaseField<TValueType>.TextInputBase textInputBase
		{
			get
			{
				return this.m_TextInputBase;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00033384 File Offset: 0x00031584
		internal TextHandle textHandle
		{
			get
			{
				return new TextHandle
				{
					textHandle = this.iTextHandle
				};
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x000333AC File Offset: 0x000315AC
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x000333B4 File Offset: 0x000315B4
		internal ITextHandle iTextHandle { get; private set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x000333C0 File Offset: 0x000315C0
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x000333DD File Offset: 0x000315DD
		public string text
		{
			get
			{
				return this.m_TextInputBase.text;
			}
			protected internal set
			{
				this.m_TextInputBase.text = value;
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000C51 RID: 3153 RVA: 0x000333F0 File Offset: 0x000315F0
		// (remove) Token: 0x06000C52 RID: 3154 RVA: 0x00033428 File Offset: 0x00031628
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event Action<bool> onIsReadOnlyChanged;

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00033460 File Offset: 0x00031660
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x0003347D File Offset: 0x0003167D
		public bool isReadOnly
		{
			get
			{
				return this.m_TextInputBase.isReadOnly;
			}
			set
			{
				this.m_TextInputBase.isReadOnly = value;
				Action<bool> action = this.onIsReadOnlyChanged;
				if (action != null)
				{
					action(value);
				}
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000334A0 File Offset: 0x000316A0
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x000334C0 File Offset: 0x000316C0
		public bool isPasswordField
		{
			get
			{
				return this.m_TextInputBase.isPasswordField;
			}
			set
			{
				bool flag = this.m_TextInputBase.isPasswordField == value;
				if (!flag)
				{
					this.m_TextInputBase.isPasswordField = value;
					this.m_TextInputBase.IncrementVersion(VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00033500 File Offset: 0x00031700
		public Color selectionColor
		{
			get
			{
				return this.m_TextInputBase.selectionColor;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003350D File Offset: 0x0003170D
		public Color cursorColor
		{
			get
			{
				return this.m_TextInputBase.cursorColor;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0003351A File Offset: 0x0003171A
		public int cursorIndex
		{
			get
			{
				return this.m_TextInputBase.cursorIndex;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00033527 File Offset: 0x00031727
		public int selectIndex
		{
			get
			{
				return this.m_TextInputBase.selectIndex;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00033534 File Offset: 0x00031734
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00033551 File Offset: 0x00031751
		public int maxLength
		{
			get
			{
				return this.m_TextInputBase.maxLength;
			}
			set
			{
				this.m_TextInputBase.maxLength = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00033564 File Offset: 0x00031764
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00033581 File Offset: 0x00031781
		public bool doubleClickSelectsWord
		{
			get
			{
				return this.m_TextInputBase.doubleClickSelectsWord;
			}
			set
			{
				this.m_TextInputBase.doubleClickSelectsWord = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00033594 File Offset: 0x00031794
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x000335B1 File Offset: 0x000317B1
		public bool tripleClickSelectsLine
		{
			get
			{
				return this.m_TextInputBase.tripleClickSelectsLine;
			}
			set
			{
				this.m_TextInputBase.tripleClickSelectsLine = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000335C4 File Offset: 0x000317C4
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x000335E1 File Offset: 0x000317E1
		public bool isDelayed
		{
			get
			{
				return this.m_TextInputBase.isDelayed;
			}
			set
			{
				this.m_TextInputBase.isDelayed = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x000335F4 File Offset: 0x000317F4
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00033611 File Offset: 0x00031811
		public char maskChar
		{
			get
			{
				return this.m_TextInputBase.maskChar;
			}
			set
			{
				this.m_TextInputBase.maskChar = value;
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00033624 File Offset: 0x00031824
		public Vector2 MeasureTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
		{
			return TextUtilities.MeasureVisualElementTextSize(this, textToMeasure, width, widthMode, height, heightMode, this.iTextHandle);
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00033649 File Offset: 0x00031849
		internal TextEditorEventHandler editorEventHandler
		{
			get
			{
				return this.m_TextInputBase.editorEventHandler;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00033656 File Offset: 0x00031856
		internal TextEditorEngine editorEngine
		{
			get
			{
				return this.m_TextInputBase.editorEngine;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00033663 File Offset: 0x00031863
		internal bool hasFocus
		{
			get
			{
				return this.m_TextInputBase.hasFocus;
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00024DA2 File Offset: 0x00022FA2
		protected virtual string ValueToString(TValueType value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00024DA2 File Offset: 0x00022FA2
		protected virtual TValueType StringToValue(string str)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00033670 File Offset: 0x00031870
		public void SelectAll()
		{
			this.m_TextInputBase.SelectAll();
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003367F File Offset: 0x0003187F
		internal void SyncTextEngine()
		{
			this.m_TextInputBase.SyncTextEngine();
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0003368E File Offset: 0x0003188E
		internal void DrawWithTextSelectionAndCursor(MeshGenerationContext mgc, string newText)
		{
			this.m_TextInputBase.DrawWithTextSelectionAndCursor(mgc, newText, base.scaledPixelsPerPoint);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000336A5 File Offset: 0x000318A5
		protected TextInputBaseField(int maxLength, char maskChar, TextInputBaseField<TValueType>.TextInputBase textInputBase) : this(null, maxLength, maskChar, textInputBase)
		{
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000336B4 File Offset: 0x000318B4
		protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBaseField<TValueType>.TextInputBase textInputBase) : base(label, textInputBase)
		{
			base.tabIndex = 0;
			base.delegatesFocus = true;
			base.labelElement.tabIndex = -1;
			base.AddToClassList(TextInputBaseField<TValueType>.ussClassName);
			base.labelElement.AddToClassList(TextInputBaseField<TValueType>.labelUssClassName);
			base.visualInput.AddToClassList(TextInputBaseField<TValueType>.inputUssClassName);
			base.visualInput.AddToClassList(TextInputBaseField<TValueType>.singleLineInputUssClassName);
			this.m_TextInputBase = textInputBase;
			this.m_TextInputBase.maxLength = maxLength;
			this.m_TextInputBase.maskChar = maskChar;
			base.RegisterCallback<AttachToPanelEvent>(new EventCallback<AttachToPanelEvent>(this.OnAttachToPanel), TrickleDown.NoTrickleDown);
			base.RegisterCallback<CustomStyleResolvedEvent>(new EventCallback<CustomStyleResolvedEvent>(this.OnFieldCustomStyleResolved), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00033772 File Offset: 0x00031972
		private void OnAttachToPanel(AttachToPanelEvent e)
		{
			this.iTextHandle = ((e.destinationPanel.contextType == ContextType.Editor) ? TextNativeHandle.New() : TextCoreHandle.New());
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00033796 File Offset: 0x00031996
		private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			this.m_TextInputBase.OnInputCustomStyleResolved(e);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000337A8 File Offset: 0x000319A8
		protected override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			base.ExecuteDefaultActionAtTarget(evt);
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = evt.eventTypeId == EventBase<KeyDownEvent>.TypeId();
				if (flag2)
				{
					KeyDownEvent keyDownEvent = evt as KeyDownEvent;
					char? c = (keyDownEvent != null) ? new char?(keyDownEvent.character) : null;
					int? num = (c != null) ? new int?((int)c.GetValueOrDefault()) : null;
					int num2 = 3;
					bool flag3;
					if (!(num.GetValueOrDefault() == num2 & num != null))
					{
						c = ((keyDownEvent != null) ? new char?(keyDownEvent.character) : null);
						num = ((c != null) ? new int?((int)c.GetValueOrDefault()) : null);
						num2 = 10;
						flag3 = (num.GetValueOrDefault() == num2 & num != null);
					}
					else
					{
						flag3 = true;
					}
					bool flag4 = flag3;
					if (flag4)
					{
						VisualElement visualInput = base.visualInput;
						if (visualInput != null)
						{
							visualInput.Focus();
						}
					}
				}
				else
				{
					bool flag5 = evt.eventTypeId == EventBase<FocusInEvent>.TypeId();
					if (flag5)
					{
						bool showMixedValue = base.showMixedValue;
						if (showMixedValue)
						{
							this.textInputBase.text = "";
						}
						bool flag6 = evt.leafTarget == this || evt.leafTarget == base.labelElement;
						if (flag6)
						{
							this.m_VisualInputTabIndex = base.visualInput.tabIndex;
							base.visualInput.tabIndex = -1;
						}
					}
					else
					{
						bool flag7 = evt.eventTypeId == EventBase<FocusEvent>.TypeId();
						if (flag7)
						{
							base.delegatesFocus = false;
						}
						else
						{
							bool flag8 = evt.eventTypeId == EventBase<BlurEvent>.TypeId();
							if (flag8)
							{
								bool showMixedValue2 = base.showMixedValue;
								if (showMixedValue2)
								{
									this.UpdateMixedValueContent();
								}
								base.delegatesFocus = true;
								bool flag9 = evt.leafTarget == this || evt.leafTarget == base.labelElement;
								if (flag9)
								{
									base.visualInput.tabIndex = this.m_VisualInputTabIndex;
								}
							}
							else
							{
								bool flag10 = evt.eventTypeId == EventBase<FocusInEvent>.TypeId();
								if (flag10)
								{
									bool showMixedValue3 = base.showMixedValue;
									if (showMixedValue3)
									{
										this.m_TextInputBase.ResetValueAndText();
									}
									bool flag11 = evt.leafTarget == this || evt.leafTarget == base.labelElement;
									if (flag11)
									{
										this.m_VisualInputTabIndex = base.visualInput.tabIndex;
										base.visualInput.tabIndex = -1;
									}
								}
								else
								{
									bool flag12 = evt.eventTypeId == EventBase<FocusEvent>.TypeId();
									if (flag12)
									{
										base.delegatesFocus = false;
									}
									else
									{
										bool flag13 = evt.eventTypeId == EventBase<BlurEvent>.TypeId();
										if (flag13)
										{
											base.delegatesFocus = true;
											bool flag14 = evt.leafTarget == this || evt.leafTarget == base.labelElement;
											if (flag14)
											{
												base.visualInput.tabIndex = this.m_VisualInputTabIndex;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00033A98 File Offset: 0x00031C98
		protected override void UpdateMixedValueContent()
		{
			bool showMixedValue = base.showMixedValue;
			if (showMixedValue)
			{
				this.textInputBase.text = BaseField<TValueType>.mixedValueString;
				base.AddToClassList(BaseField<TValueType>.mixedValueLabelUssClassName);
				VisualElement visualInput = base.visualInput;
				if (visualInput != null)
				{
					visualInput.AddToClassList(BaseField<TValueType>.mixedValueLabelUssClassName);
				}
			}
			else
			{
				this.textInputBase.UpdateTextFromValue();
				VisualElement visualInput2 = base.visualInput;
				if (visualInput2 != null)
				{
					visualInput2.RemoveFromClassList(BaseField<TValueType>.mixedValueLabelUssClassName);
				}
				base.RemoveFromClassList(BaseField<TValueType>.mixedValueLabelUssClassName);
			}
		}

		// Token: 0x040005CE RID: 1486
		private static CustomStyleProperty<Color> s_SelectionColorProperty = new CustomStyleProperty<Color>("--unity-selection-color");

		// Token: 0x040005CF RID: 1487
		private static CustomStyleProperty<Color> s_CursorColorProperty = new CustomStyleProperty<Color>("--unity-cursor-color");

		// Token: 0x040005D0 RID: 1488
		private int m_VisualInputTabIndex;

		// Token: 0x040005D1 RID: 1489
		private TextInputBaseField<TValueType>.TextInputBase m_TextInputBase;

		// Token: 0x040005D2 RID: 1490
		internal const int kMaxLengthNone = -1;

		// Token: 0x040005D3 RID: 1491
		internal const char kMaskCharDefault = '*';

		// Token: 0x040005D5 RID: 1493
		public new static readonly string ussClassName = "unity-base-text-field";

		// Token: 0x040005D6 RID: 1494
		public new static readonly string labelUssClassName = TextInputBaseField<TValueType>.ussClassName + "__label";

		// Token: 0x040005D7 RID: 1495
		public new static readonly string inputUssClassName = TextInputBaseField<TValueType>.ussClassName + "__input";

		// Token: 0x040005D8 RID: 1496
		public static readonly string singleLineInputUssClassName = TextInputBaseField<TValueType>.inputUssClassName + "--single-line";

		// Token: 0x040005D9 RID: 1497
		public static readonly string multilineInputUssClassName = TextInputBaseField<TValueType>.inputUssClassName + "--multiline";

		// Token: 0x040005DA RID: 1498
		public static readonly string textInputUssName = "unity-text-input";

		// Token: 0x02000187 RID: 391
		public new class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription>
		{
			// Token: 0x06000C75 RID: 3189 RVA: 0x00033BAC File Offset: 0x00031DAC
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				TextInputBaseField<TValueType> textInputBaseField = (TextInputBaseField<TValueType>)ve;
				textInputBaseField.maxLength = this.m_MaxLength.GetValueFromBag(bag, cc);
				textInputBaseField.isPasswordField = this.m_Password.GetValueFromBag(bag, cc);
				textInputBaseField.isReadOnly = this.m_IsReadOnly.GetValueFromBag(bag, cc);
				textInputBaseField.isDelayed = this.m_IsDelayed.GetValueFromBag(bag, cc);
				string valueFromBag = this.m_MaskCharacter.GetValueFromBag(bag, cc);
				bool flag = !string.IsNullOrEmpty(valueFromBag);
				if (flag)
				{
					textInputBaseField.maskChar = valueFromBag[0];
				}
				textInputBaseField.text = this.m_Text.GetValueFromBag(bag, cc);
			}

			// Token: 0x040005DC RID: 1500
			private UxmlIntAttributeDescription m_MaxLength = new UxmlIntAttributeDescription
			{
				name = "max-length",
				obsoleteNames = new string[]
				{
					"maxLength"
				},
				defaultValue = -1
			};

			// Token: 0x040005DD RID: 1501
			private UxmlBoolAttributeDescription m_Password = new UxmlBoolAttributeDescription
			{
				name = "password"
			};

			// Token: 0x040005DE RID: 1502
			private UxmlStringAttributeDescription m_MaskCharacter = new UxmlStringAttributeDescription
			{
				name = "mask-character",
				obsoleteNames = new string[]
				{
					"maskCharacter"
				},
				defaultValue = '*'.ToString()
			};

			// Token: 0x040005DF RID: 1503
			private UxmlStringAttributeDescription m_Text = new UxmlStringAttributeDescription
			{
				name = "text"
			};

			// Token: 0x040005E0 RID: 1504
			private UxmlBoolAttributeDescription m_IsReadOnly = new UxmlBoolAttributeDescription
			{
				name = "readonly"
			};

			// Token: 0x040005E1 RID: 1505
			private UxmlBoolAttributeDescription m_IsDelayed = new UxmlBoolAttributeDescription
			{
				name = "is-delayed"
			};
		}

		// Token: 0x02000188 RID: 392
		protected internal abstract class TextInputBase : VisualElement, ITextInputField, IEventHandler, ITextElement
		{
			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00033D41 File Offset: 0x00031F41
			internal string originalText
			{
				get
				{
					return this.m_OriginalText;
				}
			}

			// Token: 0x06000C78 RID: 3192 RVA: 0x00033D4C File Offset: 0x00031F4C
			public void ResetValueAndText()
			{
				this.m_OriginalText = (this.text = null);
			}

			// Token: 0x06000C79 RID: 3193 RVA: 0x00033D6B File Offset: 0x00031F6B
			private void SaveValueAndText()
			{
				this.m_OriginalText = this.text;
			}

			// Token: 0x06000C7A RID: 3194 RVA: 0x00033D7A File Offset: 0x00031F7A
			private void RestoreValueAndText()
			{
				this.text = this.m_OriginalText;
			}

			// Token: 0x06000C7B RID: 3195 RVA: 0x00033D8A File Offset: 0x00031F8A
			public void SelectAll()
			{
				TextEditorEngine editorEngine = this.editorEngine;
				if (editorEngine != null)
				{
					editorEngine.SelectAll();
				}
			}

			// Token: 0x06000C7C RID: 3196 RVA: 0x00033D9F File Offset: 0x00031F9F
			internal void SelectNone()
			{
				TextEditorEngine editorEngine = this.editorEngine;
				if (editorEngine != null)
				{
					editorEngine.SelectNone();
				}
			}

			// Token: 0x06000C7D RID: 3197 RVA: 0x00033DB4 File Offset: 0x00031FB4
			private void UpdateText(string value)
			{
				bool flag = this.text != value;
				if (flag)
				{
					using (InputEvent pooled = InputEvent.GetPooled(this.text, value))
					{
						pooled.target = base.parent;
						this.text = value;
						VisualElement parent = base.parent;
						if (parent != null)
						{
							parent.SendEvent(pooled);
						}
					}
				}
			}

			// Token: 0x06000C7E RID: 3198 RVA: 0x00033E28 File Offset: 0x00032028
			protected virtual TValueType StringToValue(string str)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000C7F RID: 3199 RVA: 0x00033E30 File Offset: 0x00032030
			internal void UpdateValueFromText()
			{
				TValueType value = this.StringToValue(this.text);
				TextInputBaseField<TValueType> textInputBaseField = (TextInputBaseField<TValueType>)base.parent;
				textInputBaseField.value = value;
			}

			// Token: 0x06000C80 RID: 3200 RVA: 0x00033E60 File Offset: 0x00032060
			internal void UpdateTextFromValue()
			{
				TextInputBaseField<TValueType> textInputBaseField = (TextInputBaseField<TValueType>)base.parent;
				this.text = textInputBaseField.ValueToString(textInputBaseField.rawValue);
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00033E90 File Offset: 0x00032090
			public int cursorIndex
			{
				get
				{
					return this.editorEngine.cursorIndex;
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00033EB0 File Offset: 0x000320B0
			public int selectIndex
			{
				get
				{
					return this.editorEngine.selectIndex;
				}
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00033ECD File Offset: 0x000320CD
			bool ITextInputField.isReadOnly
			{
				get
				{
					return this.isReadOnly || !base.enabledInHierarchy;
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00033EE3 File Offset: 0x000320E3
			// (set) Token: 0x06000C85 RID: 3205 RVA: 0x00033EEB File Offset: 0x000320EB
			public bool isReadOnly { get; set; }

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00033EF4 File Offset: 0x000320F4
			// (set) Token: 0x06000C87 RID: 3207 RVA: 0x00033EFC File Offset: 0x000320FC
			public int maxLength { get; set; }

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00033F05 File Offset: 0x00032105
			// (set) Token: 0x06000C89 RID: 3209 RVA: 0x00033F0D File Offset: 0x0003210D
			public char maskChar { get; set; }

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00033F16 File Offset: 0x00032116
			// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00033F1E File Offset: 0x0003211E
			public virtual bool isPasswordField { get; set; }

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00033F27 File Offset: 0x00032127
			// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00033F2F File Offset: 0x0003212F
			public bool doubleClickSelectsWord { get; set; }

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00033F38 File Offset: 0x00032138
			// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00033F40 File Offset: 0x00032140
			public bool tripleClickSelectsLine { get; set; }

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00033F49 File Offset: 0x00032149
			// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00033F51 File Offset: 0x00032151
			internal bool isDelayed { get; set; }

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00033F5A File Offset: 0x0003215A
			// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00033F62 File Offset: 0x00032162
			internal bool isDragging { get; set; }

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00033F6C File Offset: 0x0003216C
			private bool touchScreenTextField
			{
				get
				{
					return TouchScreenKeyboard.isSupported && !TouchScreenKeyboard.isInPlaceEditingAllowed;
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00033F90 File Offset: 0x00032190
			private bool touchScreenTextFieldChanged
			{
				get
				{
					return this.m_TouchScreenTextFieldInitialized != this.touchScreenTextField;
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00033FB3 File Offset: 0x000321B3
			public Color selectionColor
			{
				get
				{
					return this.m_SelectionColor;
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00033FBB File Offset: 0x000321BB
			public Color cursorColor
			{
				get
				{
					return this.m_CursorColor;
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00033FC4 File Offset: 0x000321C4
			internal bool hasFocus
			{
				get
				{
					return base.elementPanel != null && base.elementPanel.focusController.GetLeafFocusedElement() == this;
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00033FF4 File Offset: 0x000321F4
			// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00033FFC File Offset: 0x000321FC
			internal TextEditorEventHandler editorEventHandler { get; private set; }

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00034005 File Offset: 0x00032205
			// (set) Token: 0x06000C9C RID: 3228 RVA: 0x0003400D File Offset: 0x0003220D
			internal TextEditorEngine editorEngine { get; private set; }

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00034018 File Offset: 0x00032218
			// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00034030 File Offset: 0x00032230
			public string text
			{
				get
				{
					return this.m_Text;
				}
				set
				{
					bool flag = this.m_Text == value;
					if (!flag)
					{
						this.m_Text = value;
						this.editorEngine.text = value;
						base.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Repaint);
					}
				}
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x00034070 File Offset: 0x00032270
			internal TextInputBase()
			{
				this.isReadOnly = false;
				base.focusable = true;
				base.AddToClassList(TextInputBaseField<TValueType>.inputUssClassName);
				base.AddToClassList(TextInputBaseField<TValueType>.singleLineInputUssClassName);
				this.m_Text = string.Empty;
				base.name = TextInputBaseField<string>.textInputUssName;
				base.requireMeasureFunction = true;
				this.editorEngine = new TextEditorEngine(new TextEditorEngine.OnDetectFocusChangeFunction(this.OnDetectFocusChange), new TextEditorEngine.OnIndexChangeFunction(this.OnCursorIndexChange));
				this.editorEngine.style.richText = false;
				this.InitTextEditorEventHandler();
				this.editorEngine.style = new GUIStyle(this.editorEngine.style);
				base.RegisterCallback<CustomStyleResolvedEvent>(new EventCallback<CustomStyleResolvedEvent>(this.OnInputCustomStyleResolved), TrickleDown.NoTrickleDown);
				base.RegisterCallback<AttachToPanelEvent>(new EventCallback<AttachToPanelEvent>(this.OnAttachToPanel), TrickleDown.NoTrickleDown);
				base.generateVisualContent = (Action<MeshGenerationContext>)Delegate.Combine(base.generateVisualContent, new Action<MeshGenerationContext>(this.OnGenerateVisualContent));
			}

			// Token: 0x06000CA0 RID: 3232 RVA: 0x0003418C File Offset: 0x0003238C
			private void InitTextEditorEventHandler()
			{
				this.m_TouchScreenTextFieldInitialized = this.touchScreenTextField;
				bool touchScreenTextFieldInitialized = this.m_TouchScreenTextFieldInitialized;
				if (touchScreenTextFieldInitialized)
				{
					this.editorEventHandler = new TouchScreenTextEditorEventHandler(this.editorEngine, this);
				}
				else
				{
					this.doubleClickSelectsWord = true;
					this.tripleClickSelectsLine = true;
					this.editorEventHandler = new KeyboardTextEditorEventHandler(this.editorEngine, this);
				}
			}

			// Token: 0x06000CA1 RID: 3233 RVA: 0x000341EC File Offset: 0x000323EC
			private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a)
			{
				return (base.enabledInHierarchy && this.editorEngine.hasSelection && !this.isPasswordField) ? DropdownMenuAction.Status.Normal : DropdownMenuAction.Status.Disabled;
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x00034220 File Offset: 0x00032420
			private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a)
			{
				return ((!base.enabledInHierarchy || this.editorEngine.hasSelection) && !this.isPasswordField) ? DropdownMenuAction.Status.Normal : DropdownMenuAction.Status.Disabled;
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x00034254 File Offset: 0x00032454
			private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a)
			{
				return base.enabledInHierarchy ? (this.editorEngine.CanPaste() ? DropdownMenuAction.Status.Normal : DropdownMenuAction.Status.Disabled) : DropdownMenuAction.Status.Hidden;
			}

			// Token: 0x06000CA4 RID: 3236 RVA: 0x00034284 File Offset: 0x00032484
			private void ProcessMenuCommand(string command)
			{
				using (ExecuteCommandEvent pooled = CommandEventBase<ExecuteCommandEvent>.GetPooled(command))
				{
					pooled.target = this;
					this.SendEvent(pooled);
				}
			}

			// Token: 0x06000CA5 RID: 3237 RVA: 0x000342C8 File Offset: 0x000324C8
			private void Cut(DropdownMenuAction a)
			{
				this.ProcessMenuCommand("Cut");
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x000342D7 File Offset: 0x000324D7
			private void Copy(DropdownMenuAction a)
			{
				this.ProcessMenuCommand("Copy");
			}

			// Token: 0x06000CA7 RID: 3239 RVA: 0x000342E6 File Offset: 0x000324E6
			private void Paste(DropdownMenuAction a)
			{
				this.ProcessMenuCommand("Paste");
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x000342F8 File Offset: 0x000324F8
			internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e)
			{
				Color clear = Color.clear;
				Color clear2 = Color.clear;
				ICustomStyle customStyle = e.customStyle;
				bool flag = customStyle.TryGetValue(TextInputBaseField<TValueType>.s_SelectionColorProperty, out clear);
				if (flag)
				{
					this.m_SelectionColor = clear;
				}
				bool flag2 = customStyle.TryGetValue(TextInputBaseField<TValueType>.s_CursorColorProperty, out clear2);
				if (flag2)
				{
					this.m_CursorColor = clear2;
				}
				TextInputBaseField<TValueType>.TextInputBase.SyncGUIStyle(this, this.editorEngine.style);
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x0003435D File Offset: 0x0003255D
			private void OnAttachToPanel(AttachToPanelEvent attachEvent)
			{
				this.m_TextHandle = ((attachEvent.destinationPanel.contextType == ContextType.Editor) ? TextNativeHandle.New() : TextCoreHandle.New());
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x00034380 File Offset: 0x00032580
			internal virtual void SyncTextEngine()
			{
				this.editorEngine.text = this.CullString(this.text);
				this.editorEngine.SaveBackup();
				this.editorEngine.position = base.layout;
				this.editorEngine.DetectFocusChange();
			}

			// Token: 0x06000CAB RID: 3243 RVA: 0x000343D0 File Offset: 0x000325D0
			internal string CullString(string s)
			{
				bool flag = this.maxLength >= 0 && s != null && s.Length > this.maxLength;
				string result;
				if (flag)
				{
					result = s.Substring(0, this.maxLength);
				}
				else
				{
					result = s;
				}
				return result;
			}

			// Token: 0x06000CAC RID: 3244 RVA: 0x00034414 File Offset: 0x00032614
			internal void OnGenerateVisualContent(MeshGenerationContext mgc)
			{
				string text = this.text;
				bool isPasswordField = this.isPasswordField;
				if (isPasswordField)
				{
					text = "".PadRight(this.text.Length, this.maskChar);
				}
				bool touchScreenTextFieldInitialized = this.m_TouchScreenTextFieldInitialized;
				if (touchScreenTextFieldInitialized)
				{
					TouchScreenTextEditorEventHandler touchScreenTextEditorEventHandler = this.editorEventHandler as TouchScreenTextEditorEventHandler;
					bool flag = touchScreenTextEditorEventHandler != null;
					if (flag)
					{
						mgc.Text(MeshGenerationContextUtils.TextParams.MakeStyleBased(this, text), this.m_TextHandle, base.scaledPixelsPerPoint);
					}
				}
				else
				{
					bool flag2 = !this.hasFocus;
					if (flag2)
					{
						mgc.Text(MeshGenerationContextUtils.TextParams.MakeStyleBased(this, text), this.m_TextHandle, base.scaledPixelsPerPoint);
					}
					else
					{
						this.DrawWithTextSelectionAndCursor(mgc, text, base.scaledPixelsPerPoint);
					}
				}
			}

			// Token: 0x06000CAD RID: 3245 RVA: 0x000344D4 File Offset: 0x000326D4
			internal void DrawWithTextSelectionAndCursor(MeshGenerationContext mgc, string newText, float pixelsPerPoint)
			{
				Color playmodeTintColor = (base.panel.contextType == ContextType.Editor) ? UIElementsUtility.editorPlayModeTintColor : Color.white;
				KeyboardTextEditorEventHandler keyboardTextEditorEventHandler = this.editorEventHandler as KeyboardTextEditorEventHandler;
				bool flag = keyboardTextEditorEventHandler == null;
				if (!flag)
				{
					keyboardTextEditorEventHandler.PreDrawCursor(newText);
					int cursorIndex = this.editorEngine.cursorIndex;
					int selectIndex = this.editorEngine.selectIndex;
					Vector2 scrollOffset = this.editorEngine.scrollOffset;
					float num = TextUtilities.ComputeTextScaling(base.worldTransform, pixelsPerPoint);
					MeshGenerationContextUtils.TextParams textParams = MeshGenerationContextUtils.TextParams.MakeStyleBased(this, " ");
					float lineHeight = this.m_TextHandle.GetLineHeight(0, textParams, num, pixelsPerPoint);
					float wordWrapWidth = 0f;
					bool flag2 = this.editorEngine.multiline && base.resolvedStyle.whiteSpace == WhiteSpace.Normal;
					if (flag2)
					{
						wordWrapWidth = base.contentRect.width;
					}
					Vector2 p = this.editorEngine.graphicalCursorPos - scrollOffset;
					p.y += lineHeight;
					GUIUtility.compositionCursorPos = this.LocalToWorld(p);
					int num2 = string.IsNullOrEmpty(GUIUtility.compositionString) ? selectIndex : (cursorIndex + GUIUtility.compositionString.Length);
					bool flag3 = cursorIndex != num2 && !this.isDragging;
					if (flag3)
					{
						int cursorIndex2 = (cursorIndex < num2) ? cursorIndex : num2;
						int cursorIndex3 = (cursorIndex > num2) ? cursorIndex : num2;
						CursorPositionStylePainterParameters @default = CursorPositionStylePainterParameters.GetDefault(this, this.text);
						@default.text = this.editorEngine.text;
						@default.wordWrapWidth = wordWrapWidth;
						@default.cursorIndex = cursorIndex2;
						Vector2 vector = this.m_TextHandle.GetCursorPosition(@default, num);
						@default.cursorIndex = cursorIndex3;
						Vector2 vector2 = this.m_TextHandle.GetCursorPosition(@default, num);
						vector -= scrollOffset;
						vector2 -= scrollOffset;
						lineHeight = this.m_TextHandle.GetLineHeight(cursorIndex, textParams, num, pixelsPerPoint);
						bool flag4 = Mathf.Approximately(vector.y, vector2.y);
						if (flag4)
						{
							mgc.Rectangle(new MeshGenerationContextUtils.RectangleParams
							{
								rect = new Rect(vector.x, vector.y, vector2.x - vector.x, lineHeight),
								color = this.selectionColor,
								playmodeTintColor = playmodeTintColor
							});
						}
						else
						{
							mgc.Rectangle(new MeshGenerationContextUtils.RectangleParams
							{
								rect = new Rect(vector.x, vector.y, base.contentRect.xMax - vector.x, lineHeight),
								color = this.selectionColor,
								playmodeTintColor = playmodeTintColor
							});
							float num3 = vector2.y - vector.y - lineHeight;
							bool flag5 = num3 > 0f;
							if (flag5)
							{
								mgc.Rectangle(new MeshGenerationContextUtils.RectangleParams
								{
									rect = new Rect(base.contentRect.xMin, vector.y + lineHeight, base.contentRect.width, num3),
									color = this.selectionColor,
									playmodeTintColor = playmodeTintColor
								});
							}
							bool flag6 = vector2.x != base.contentRect.x;
							if (flag6)
							{
								mgc.Rectangle(new MeshGenerationContextUtils.RectangleParams
								{
									rect = new Rect(base.contentRect.xMin, vector2.y, vector2.x, lineHeight),
									color = this.selectionColor,
									playmodeTintColor = playmodeTintColor
								});
							}
						}
					}
					bool flag7 = !string.IsNullOrEmpty(this.editorEngine.text) && base.contentRect.width > 0f && base.contentRect.height > 0f;
					if (flag7)
					{
						textParams.rect = new Rect(base.contentRect.x - scrollOffset.x, base.contentRect.y - scrollOffset.y, base.contentRect.width + scrollOffset.x, base.contentRect.height + scrollOffset.y);
						textParams.text = this.editorEngine.text;
						mgc.Text(textParams, this.m_TextHandle, base.scaledPixelsPerPoint);
					}
					bool flag8 = !this.isReadOnly && !this.isDragging;
					if (flag8)
					{
						bool flag9 = cursorIndex == num2 && TextUtilities.IsFontAssigned(this);
						if (flag9)
						{
							CursorPositionStylePainterParameters @default = CursorPositionStylePainterParameters.GetDefault(this, this.text);
							@default.text = this.editorEngine.text;
							@default.wordWrapWidth = wordWrapWidth;
							@default.cursorIndex = cursorIndex;
							Vector2 vector3 = this.m_TextHandle.GetCursorPosition(@default, num);
							vector3 -= scrollOffset;
							mgc.Rectangle(new MeshGenerationContextUtils.RectangleParams
							{
								rect = new Rect(vector3.x, vector3.y, 1f, lineHeight),
								color = this.cursorColor,
								playmodeTintColor = playmodeTintColor
							});
						}
						bool flag10 = this.editorEngine.altCursorPosition != -1;
						if (flag10)
						{
							CursorPositionStylePainterParameters @default = CursorPositionStylePainterParameters.GetDefault(this, this.text);
							@default.text = this.editorEngine.text.Substring(0, this.editorEngine.altCursorPosition);
							@default.wordWrapWidth = wordWrapWidth;
							@default.cursorIndex = this.editorEngine.altCursorPosition;
							Vector2 vector4 = this.m_TextHandle.GetCursorPosition(@default, num);
							vector4 -= scrollOffset;
							mgc.Rectangle(new MeshGenerationContextUtils.RectangleParams
							{
								rect = new Rect(vector4.x, vector4.y, 1f, lineHeight),
								color = this.cursorColor,
								playmodeTintColor = playmodeTintColor
							});
						}
					}
					keyboardTextEditorEventHandler.PostDrawCursor();
				}
			}

			// Token: 0x06000CAE RID: 3246 RVA: 0x00034AF4 File Offset: 0x00032CF4
			internal virtual bool AcceptCharacter(char c)
			{
				return !this.isReadOnly && base.enabledInHierarchy;
			}

			// Token: 0x06000CAF RID: 3247 RVA: 0x00034B18 File Offset: 0x00032D18
			protected virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt)
			{
				bool flag = ((evt != null) ? evt.target : null) is TextInputBaseField<TValueType>.TextInputBase;
				if (flag)
				{
					bool flag2 = !this.isReadOnly;
					if (flag2)
					{
						evt.menu.AppendAction("Cut", new Action<DropdownMenuAction>(this.Cut), new Func<DropdownMenuAction, DropdownMenuAction.Status>(this.CutActionStatus), null);
					}
					evt.menu.AppendAction("Copy", new Action<DropdownMenuAction>(this.Copy), new Func<DropdownMenuAction, DropdownMenuAction.Status>(this.CopyActionStatus), null);
					bool flag3 = !this.isReadOnly;
					if (flag3)
					{
						evt.menu.AppendAction("Paste", new Action<DropdownMenuAction>(this.Paste), new Func<DropdownMenuAction, DropdownMenuAction.Status>(this.PasteActionStatus), null);
					}
				}
			}

			// Token: 0x06000CB0 RID: 3248 RVA: 0x00034BE0 File Offset: 0x00032DE0
			private void OnDetectFocusChange()
			{
				bool flag = this.editorEngine.m_HasFocus && !this.hasFocus;
				if (flag)
				{
					this.editorEngine.OnFocus();
				}
				bool flag2 = !this.editorEngine.m_HasFocus && this.hasFocus;
				if (flag2)
				{
					this.editorEngine.OnLostFocus();
				}
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x0000E357 File Offset: 0x0000C557
			private void OnCursorIndexChange()
			{
				base.IncrementVersion(VersionChangeType.Repaint);
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00034C44 File Offset: 0x00032E44
			protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
			{
				string text = this.m_Text;
				bool flag = string.IsNullOrEmpty(text);
				if (flag)
				{
					text = " ";
				}
				return TextUtilities.MeasureVisualElementTextSize(this, text, desiredWidth, widthMode, desiredHeight, heightMode, this.m_TextHandle);
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x00034C81 File Offset: 0x00032E81
			internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
			{
				base.ExecuteDefaultActionDisabledAtTarget(evt);
				this.ProcessEventAtTarget(evt);
			}

			// Token: 0x06000CB4 RID: 3252 RVA: 0x00034C94 File Offset: 0x00032E94
			protected override void ExecuteDefaultActionAtTarget(EventBase evt)
			{
				base.ExecuteDefaultActionAtTarget(evt);
				this.ProcessEventAtTarget(evt);
			}

			// Token: 0x06000CB5 RID: 3253 RVA: 0x00034CA8 File Offset: 0x00032EA8
			private void ProcessEventAtTarget(EventBase evt)
			{
				BaseVisualElementPanel elementPanel = base.elementPanel;
				if (elementPanel != null)
				{
					ContextualMenuManager contextualMenuManager = elementPanel.contextualMenuManager;
					if (contextualMenuManager != null)
					{
						contextualMenuManager.DisplayMenuIfEventMatches(evt, this);
					}
				}
				long? num = (evt != null) ? new long?(evt.eventTypeId) : null;
				long num2 = EventBase<ContextualMenuPopulateEvent>.TypeId();
				bool flag = num.GetValueOrDefault() == num2 & num != null;
				if (flag)
				{
					ContextualMenuPopulateEvent contextualMenuPopulateEvent = evt as ContextualMenuPopulateEvent;
					int count = contextualMenuPopulateEvent.menu.MenuItems().Count;
					this.BuildContextualMenu(contextualMenuPopulateEvent);
					bool flag2 = count > 0 && contextualMenuPopulateEvent.menu.MenuItems().Count > count;
					if (flag2)
					{
						contextualMenuPopulateEvent.menu.InsertSeparator(null, count);
					}
				}
				else
				{
					bool flag3 = evt.eventTypeId == EventBase<FocusInEvent>.TypeId();
					if (flag3)
					{
						this.SaveValueAndText();
						bool touchScreenTextFieldChanged = this.touchScreenTextFieldChanged;
						if (touchScreenTextFieldChanged)
						{
							this.InitTextEditorEventHandler();
						}
						bool flag4 = this.m_HardwareKeyboardPoller == null;
						if (flag4)
						{
							this.m_HardwareKeyboardPoller = base.schedule.Execute(delegate()
							{
								bool touchScreenTextFieldChanged2 = this.touchScreenTextFieldChanged;
								if (touchScreenTextFieldChanged2)
								{
									this.InitTextEditorEventHandler();
									this.Blur();
								}
							}).Every(250L);
						}
						else
						{
							this.m_HardwareKeyboardPoller.Resume();
						}
					}
					else
					{
						bool flag5 = evt.eventTypeId == EventBase<FocusOutEvent>.TypeId();
						if (flag5)
						{
							bool flag6 = this.m_HardwareKeyboardPoller != null;
							if (flag6)
							{
								this.m_HardwareKeyboardPoller.Pause();
							}
						}
						else
						{
							bool flag7 = evt.eventTypeId == EventBase<KeyDownEvent>.TypeId();
							if (flag7)
							{
								KeyDownEvent keyDownEvent = evt as KeyDownEvent;
								bool flag8 = keyDownEvent != null && keyDownEvent.keyCode == KeyCode.Escape;
								if (flag8)
								{
									this.RestoreValueAndText();
									base.parent.Focus();
								}
							}
						}
					}
				}
				this.editorEventHandler.ExecuteDefaultActionAtTarget(evt);
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x00034E6E File Offset: 0x0003306E
			protected override void ExecuteDefaultAction(EventBase evt)
			{
				base.ExecuteDefaultAction(evt);
				this.editorEventHandler.ExecuteDefaultAction(evt);
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00034E86 File Offset: 0x00033086
			bool ITextInputField.hasFocus
			{
				get
				{
					return this.hasFocus;
				}
			}

			// Token: 0x06000CB8 RID: 3256 RVA: 0x00034E8E File Offset: 0x0003308E
			void ITextInputField.SyncTextEngine()
			{
				this.SyncTextEngine();
			}

			// Token: 0x06000CB9 RID: 3257 RVA: 0x00034E98 File Offset: 0x00033098
			bool ITextInputField.AcceptCharacter(char c)
			{
				return this.AcceptCharacter(c);
			}

			// Token: 0x06000CBA RID: 3258 RVA: 0x00034EB4 File Offset: 0x000330B4
			string ITextInputField.CullString(string s)
			{
				return this.CullString(s);
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x00034ECD File Offset: 0x000330CD
			void ITextInputField.UpdateText(string value)
			{
				this.UpdateText(value);
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00034ED8 File Offset: 0x000330D8
			TextEditorEngine ITextInputField.editorEngine
			{
				get
				{
					return this.editorEngine;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00034EE0 File Offset: 0x000330E0
			bool ITextInputField.isDelayed
			{
				get
				{
					return this.isDelayed;
				}
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x00034EE8 File Offset: 0x000330E8
			void ITextInputField.UpdateValueFromText()
			{
				this.UpdateValueFromText();
			}

			// Token: 0x06000CBF RID: 3263 RVA: 0x00034EF2 File Offset: 0x000330F2
			private void DeferGUIStyleRectSync()
			{
				base.RegisterCallback<GeometryChangedEvent>(new EventCallback<GeometryChangedEvent>(this.OnPercentResolved), TrickleDown.NoTrickleDown);
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x00034F0C File Offset: 0x0003310C
			private void OnPercentResolved(GeometryChangedEvent evt)
			{
				base.UnregisterCallback<GeometryChangedEvent>(new EventCallback<GeometryChangedEvent>(this.OnPercentResolved), TrickleDown.NoTrickleDown);
				GUIStyle style = this.editorEngine.style;
				int left = (int)base.resolvedStyle.marginLeft;
				int top = (int)base.resolvedStyle.marginTop;
				int right = (int)base.resolvedStyle.marginRight;
				int bottom = (int)base.resolvedStyle.marginBottom;
				TextInputBaseField<TValueType>.TextInputBase.AssignRect(style.margin, left, top, right, bottom);
				left = (int)base.resolvedStyle.paddingLeft;
				top = (int)base.resolvedStyle.paddingTop;
				right = (int)base.resolvedStyle.paddingRight;
				bottom = (int)base.resolvedStyle.paddingBottom;
				TextInputBaseField<TValueType>.TextInputBase.AssignRect(style.padding, left, top, right, bottom);
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x00034FC8 File Offset: 0x000331C8
			private unsafe static void SyncGUIStyle(TextInputBaseField<TValueType>.TextInputBase textInput, GUIStyle style)
			{
				ComputedStyle computedStyle = *textInput.computedStyle;
				style.alignment = computedStyle.unityTextAlign;
				style.wordWrap = (computedStyle.whiteSpace == WhiteSpace.Normal);
				style.clipping = ((computedStyle.overflow == OverflowInternal.Visible) ? TextClipping.Overflow : TextClipping.Clip);
				style.font = TextUtilities.GetFont(textInput);
				style.fontSize = (int)computedStyle.fontSize.value;
				style.fontStyle = computedStyle.unityFontStyleAndWeight;
				int left = computedStyle.unitySliceLeft;
				int top = computedStyle.unitySliceTop;
				int right = computedStyle.unitySliceRight;
				int bottom = computedStyle.unitySliceBottom;
				TextInputBaseField<TValueType>.TextInputBase.AssignRect(style.border, left, top, right, bottom);
				bool flag = TextInputBaseField<TValueType>.TextInputBase.IsLayoutUsingPercent(textInput);
				if (flag)
				{
					textInput.DeferGUIStyleRectSync();
				}
				else
				{
					left = (int)computedStyle.marginLeft.value;
					top = (int)computedStyle.marginTop.value;
					right = (int)computedStyle.marginRight.value;
					bottom = (int)computedStyle.marginBottom.value;
					TextInputBaseField<TValueType>.TextInputBase.AssignRect(style.margin, left, top, right, bottom);
					left = (int)computedStyle.paddingLeft.value;
					top = (int)computedStyle.paddingTop.value;
					right = (int)computedStyle.paddingRight.value;
					bottom = (int)computedStyle.paddingBottom.value;
					TextInputBaseField<TValueType>.TextInputBase.AssignRect(style.padding, left, top, right, bottom);
				}
			}

			// Token: 0x06000CC2 RID: 3266 RVA: 0x00035158 File Offset: 0x00033358
			private unsafe static bool IsLayoutUsingPercent(VisualElement ve)
			{
				ComputedStyle computedStyle = *ve.computedStyle;
				bool flag = computedStyle.marginLeft.unit == LengthUnit.Percent || computedStyle.marginTop.unit == LengthUnit.Percent || computedStyle.marginRight.unit == LengthUnit.Percent || computedStyle.marginBottom.unit == LengthUnit.Percent;
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					bool flag2 = computedStyle.paddingLeft.unit == LengthUnit.Percent || computedStyle.paddingTop.unit == LengthUnit.Percent || computedStyle.paddingRight.unit == LengthUnit.Percent || computedStyle.paddingBottom.unit == LengthUnit.Percent;
					result = flag2;
				}
				return result;
			}

			// Token: 0x06000CC3 RID: 3267 RVA: 0x0003521F File Offset: 0x0003341F
			private static void AssignRect(RectOffset rect, int left, int top, int right, int bottom)
			{
				rect.left = left;
				rect.top = top;
				rect.right = right;
				rect.bottom = bottom;
			}

			// Token: 0x040005E2 RID: 1506
			private string m_OriginalText;

			// Token: 0x040005EB RID: 1515
			private bool m_TouchScreenTextFieldInitialized;

			// Token: 0x040005EC RID: 1516
			private IVisualElementScheduledItem m_HardwareKeyboardPoller = null;

			// Token: 0x040005ED RID: 1517
			private Color m_SelectionColor = Color.clear;

			// Token: 0x040005EE RID: 1518
			private Color m_CursorColor = Color.grey;

			// Token: 0x040005F1 RID: 1521
			private ITextHandle m_TextHandle;

			// Token: 0x040005F2 RID: 1522
			private string m_Text;
		}
	}
}
