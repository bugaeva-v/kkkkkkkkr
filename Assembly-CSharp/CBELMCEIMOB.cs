using System;
using TMPro;

// Token: 0x0200030A RID: 778
public static class CBELMCEIMOB
{
	// Token: 0x06005E59 RID: 24153 RVA: 0x002ADAB0 File Offset: 0x002ABCB0
	public static void BBNGCBHBGHH(this TextMeshProUGUI PHLJNFHEEIB, string DIMBCOBNMAM)
	{
		TextMeshProUGUI[] componentsInChildren = PHLJNFHEEIB.GetComponentsInChildren<TextMeshProUGUI>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].SetText(DIMBCOBNMAM, true);
		}
	}
}
