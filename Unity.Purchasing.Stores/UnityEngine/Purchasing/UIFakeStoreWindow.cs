using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004B RID: 75
	internal class UIFakeStoreWindow : MonoBehaviour
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00007938 File Offset: 0x00005B38
		private void OnGUI()
		{
			Rect clientRect = this.CreateCenteredWindowRect();
			if (this.m_DoDropdown)
			{
				GUI.Window(1, clientRect, new GUI.WindowFunction(this.m_Dropdown.DoPopup), "Select Response");
				return;
			}
			GUI.Window(0, clientRect, new GUI.WindowFunction(this.DoMainGUI), "Fake Store");
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000798C File Offset: 0x00005B8C
		private Rect CreateCenteredWindowRect()
		{
			float num = (float)Screen.width * 0.6f;
			float num2 = (float)Screen.height * 0.6f;
			float x = ((float)Screen.width - num) / 2f;
			float y = ((float)Screen.height - num2) / 2f;
			return new Rect(x, y, num, num2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000079D8 File Offset: 0x00005BD8
		private void DoMainGUI(int windowID)
		{
			this.scrollPosition = GUILayout.BeginScrollView(this.scrollPosition, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.box, Array.Empty<GUILayoutOption>());
			GUILayout.Label(this.m_QueryText, Array.Empty<GUILayoutOption>());
			if (this.m_DropdownEnabled && GUILayout.Button(this.m_LastSelectedOptionText, Array.Empty<GUILayoutOption>()))
			{
				this.DoDropDown();
			}
			if (GUILayout.Button(this.m_OkText, Array.Empty<GUILayoutOption>()))
			{
				this.OnOkClicked();
			}
			if (this.m_CancelEnabled && GUILayout.Button(this.m_CancelText, Array.Empty<GUILayoutOption>()))
			{
				this.OnCancelClicked();
			}
			GUILayout.EndScrollView();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00007A88 File Offset: 0x00005C88
		private void DoDropDown()
		{
			this.m_DoDropdown = true;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00007A91 File Offset: 0x00005C91
		private void OnOkClicked()
		{
			Action onOk = this.m_OnOk;
			if (onOk == null)
			{
				return;
			}
			onOk();
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00007AA3 File Offset: 0x00005CA3
		private void OnCancelClicked()
		{
			Action onCancel = this.m_OnCancel;
			if (onCancel == null)
			{
				return;
			}
			onCancel();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00007AB5 File Offset: 0x00005CB5
		internal void ConfigureMainDialogText(string queryText, string okText, string cancelText)
		{
			this.m_QueryText = queryText;
			this.m_OkText = okText;
			this.m_CancelText = cancelText;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00007ACC File Offset: 0x00005CCC
		internal void ConfigureDropdownOptions(List<string> options)
		{
			this.m_Dropdown.SetOptions(options);
			this.m_Dropdown.SetSelectionAction(new Action<int, string>(this.OnDropdown));
			if (options.Count > 0)
			{
				this.m_LastSelectedOptionText = options.First<string>();
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007B06 File Offset: 0x00005D06
		private void OnDropdown(int index, string selectionText)
		{
			this.m_LastSelectedOptionText = selectionText;
			Action<int> onDropdown = this.m_OnDropdown;
			if (onDropdown != null)
			{
				onDropdown(index);
			}
			this.m_DoDropdown = false;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00007B28 File Offset: 0x00005D28
		internal void AssignCallbacks(Action onOk, Action onCancel, Action<int> onDropdown)
		{
			this.m_OnOk = onOk;
			this.m_CancelEnabled = (onCancel != null);
			this.m_OnCancel = onCancel;
			this.m_DropdownEnabled = (onDropdown != null);
			this.m_OnDropdown = onDropdown;
		}

		// Token: 0x040000B4 RID: 180
		private string m_QueryText;

		// Token: 0x040000B5 RID: 181
		private string m_OkText;

		// Token: 0x040000B6 RID: 182
		private string m_CancelText;

		// Token: 0x040000B7 RID: 183
		private string m_LastSelectedOptionText;

		// Token: 0x040000B8 RID: 184
		private Action m_OnOk;

		// Token: 0x040000B9 RID: 185
		private Action m_OnCancel;

		// Token: 0x040000BA RID: 186
		private Action<int> m_OnDropdown;

		// Token: 0x040000BB RID: 187
		private bool m_CancelEnabled;

		// Token: 0x040000BC RID: 188
		private bool m_DropdownEnabled;

		// Token: 0x040000BD RID: 189
		private bool m_DoDropdown;

		// Token: 0x040000BE RID: 190
		private readonly UIFakeStoreDropdown m_Dropdown = new UIFakeStoreDropdown();

		// Token: 0x040000BF RID: 191
		private Vector2 scrollPosition;

		// Token: 0x040000C0 RID: 192
		private const float k_MenuScreenRatio = 0.6f;
	}
}
