using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002B9 RID: 697
	[HelpURL("UIE-tss")]
	[Serializable]
	public class ThemeStyleSheet : StyleSheet
	{
		// Token: 0x0600179C RID: 6044 RVA: 0x00062CCB File Offset: 0x00060ECB
		internal override void OnEnable()
		{
			base.isDefaultStyleSheet = true;
			base.OnEnable();
		}
	}
}
