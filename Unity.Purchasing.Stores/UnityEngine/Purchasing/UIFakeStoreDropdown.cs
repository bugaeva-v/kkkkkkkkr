using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004A RID: 74
	internal class UIFakeStoreDropdown
	{
		// Token: 0x060001CC RID: 460 RVA: 0x00007860 File Offset: 0x00005A60
		public void DoPopup(int windowID)
		{
			if (this.m_Options != null)
			{
				this.scrollPosition = GUILayout.BeginScrollView(this.scrollPosition, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.box, Array.Empty<GUILayoutOption>());
				int count = this.m_Options.Count;
				for (int i = 0; i < count; i++)
				{
					if (GUILayout.Button(this.m_Options[i], Array.Empty<GUILayoutOption>()))
					{
						this.OnOptionSelected(i);
					}
				}
				GUILayout.EndScrollView();
				return;
			}
			GUILayout.Label("Error! No Dropdown options set!", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000078F7 File Offset: 0x00005AF7
		private void OnOptionSelected(int optionIndex)
		{
			Action<int, string> onDropdown = this.m_OnDropdown;
			if (onDropdown == null)
			{
				return;
			}
			onDropdown(optionIndex, this.m_Options[optionIndex]);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00007916 File Offset: 0x00005B16
		internal void SetOptions(List<string> options)
		{
			this.m_Options = new List<string>(options);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00007924 File Offset: 0x00005B24
		internal void SetSelectionAction(Action<int, string> onDropdown)
		{
			this.m_OnDropdown = onDropdown;
		}

		// Token: 0x040000B1 RID: 177
		private List<string> m_Options;

		// Token: 0x040000B2 RID: 178
		private Action<int, string> m_OnDropdown;

		// Token: 0x040000B3 RID: 179
		private Vector2 scrollPosition;
	}
}
