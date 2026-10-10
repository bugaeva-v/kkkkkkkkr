using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000165 RID: 357
	public class RadioButtonGroup : BaseField<int>, IGroupBox
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0002EB3E File Offset: 0x0002CD3E
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0002EB48 File Offset: 0x0002CD48
		public IEnumerable<string> choices
		{
			get
			{
				return this.m_Choices;
			}
			set
			{
				this.m_Choices = value;
				foreach (RadioButton radioButton in this.m_RadioButtons)
				{
					radioButton.UnregisterValueChangedCallback(this.m_RadioButtonValueChangedCallback);
					radioButton.RemoveFromHierarchy();
				}
				this.m_RadioButtons.Clear();
				bool flag = this.m_Choices != null;
				if (flag)
				{
					foreach (string text in this.m_Choices)
					{
						RadioButton radioButton2 = new RadioButton
						{
							text = text
						};
						radioButton2.RegisterValueChangedCallback(this.m_RadioButtonValueChangedCallback);
						this.m_RadioButtons.Add(radioButton2);
						base.visualInput.Add(radioButton2);
					}
					this.UpdateRadioButtons();
				}
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0002EC4C File Offset: 0x0002CE4C
		public RadioButtonGroup() : this(null, null)
		{
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0002EC58 File Offset: 0x0002CE58
		public RadioButtonGroup(string label, List<string> radioButtonChoices = null) : base(label, null)
		{
			base.AddToClassList(RadioButtonGroup.ussClassName);
			this.m_RadioButtonValueChangedCallback = new EventCallback<ChangeEvent<bool>>(this.RadioButtonValueChangedCallback);
			this.choices = radioButtonChoices;
			this.value = -1;
			base.visualInput.focusable = false;
			base.delegatesFocus = true;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0002ECC0 File Offset: 0x0002CEC0
		private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt)
		{
			bool newValue = evt.newValue;
			if (newValue)
			{
				this.value = this.m_RadioButtons.IndexOf(evt.target as RadioButton);
				evt.StopPropagation();
			}
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0002ECFE File Offset: 0x0002CEFE
		public override void SetValueWithoutNotify(int newValue)
		{
			base.SetValueWithoutNotify(newValue);
			this.UpdateRadioButtons();
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0002ED10 File Offset: 0x0002CF10
		private void UpdateRadioButtons()
		{
			bool flag = this.value >= 0 && this.value < this.m_RadioButtons.Count;
			if (flag)
			{
				this.m_RadioButtons[this.value].value = true;
			}
			else
			{
				foreach (RadioButton radioButton in this.m_RadioButtons)
				{
					radioButton.value = false;
				}
			}
		}

		// Token: 0x04000535 RID: 1333
		public new static readonly string ussClassName = "unity-radio-button-group";

		// Token: 0x04000536 RID: 1334
		private IEnumerable<string> m_Choices;

		// Token: 0x04000537 RID: 1335
		private List<RadioButton> m_RadioButtons = new List<RadioButton>();

		// Token: 0x04000538 RID: 1336
		private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback;

		// Token: 0x02000166 RID: 358
		public new class UxmlFactory : UxmlFactory<RadioButtonGroup, RadioButtonGroup.UxmlTraits>
		{
		}

		// Token: 0x02000167 RID: 359
		public new class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
			// Token: 0x06000B6B RID: 2923 RVA: 0x0002EDC4 File Offset: 0x0002CFC4
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				RadioButtonGroup radioButtonGroup = (RadioButtonGroup)ve;
				radioButtonGroup.choices = BaseField<int>.UxmlTraits.ParseChoiceList(this.m_Choices.GetValueFromBag(bag, cc));
			}

			// Token: 0x04000539 RID: 1337
			private UxmlStringAttributeDescription m_Choices = new UxmlStringAttributeDescription
			{
				name = "choices"
			};
		}
	}
}
