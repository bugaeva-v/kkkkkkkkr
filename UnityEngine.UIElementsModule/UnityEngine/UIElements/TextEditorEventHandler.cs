using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017D RID: 381
	internal class TextEditorEventHandler
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00032ACB File Offset: 0x00030CCB
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00032AD3 File Offset: 0x00030CD3
		private protected TextEditorEngine editorEngine { protected get; private set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00032ADC File Offset: 0x00030CDC
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00032AE4 File Offset: 0x00030CE4
		private protected ITextInputField textInputField { protected get; private set; }

		// Token: 0x06000C12 RID: 3090 RVA: 0x00032AED File Offset: 0x00030CED
		protected TextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField)
		{
			this.editorEngine = editorEngine;
			this.textInputField = textInputField;
			this.textInputField.SyncTextEngine();
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00002166 File Offset: 0x00000366
		public virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00032B14 File Offset: 0x00030D14
		public virtual void ExecuteDefaultAction(EventBase evt)
		{
			bool flag = evt.eventTypeId == EventBase<FocusEvent>.TypeId();
			if (flag)
			{
				this.editorEngine.OnFocus();
				this.editorEngine.SelectAll();
			}
			else
			{
				bool flag2 = evt.eventTypeId == EventBase<BlurEvent>.TypeId();
				if (flag2)
				{
					this.editorEngine.OnLostFocus();
					this.editorEngine.SelectNone();
				}
			}
		}
	}
}
