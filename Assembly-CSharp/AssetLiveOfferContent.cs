using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003C0 RID: 960
[CreateAssetMenu(fileName = "assetLiveOfferContentX", menuName = "ROMANCE/Create assetLiveOfferContentX", order = 1)]
public class AssetLiveOfferContent : ScriptableObject
{
	// Token: 0x040020FE RID: 8446
	public int index;

	// Token: 0x040020FF RID: 8447
	public List<Sprite> frames;

	// Token: 0x04002100 RID: 8448
	public float frameChangeInterval = 0.1f;

	// Token: 0x04002101 RID: 8449
	public AudioClip audioClip;

	// Token: 0x04002102 RID: 8450
	public Color textFooterColor;

	// Token: 0x04002103 RID: 8451
	public string textFooterId = "";

	// Token: 0x04002104 RID: 8452
	public int textLeft;

	// Token: 0x04002105 RID: 8453
	public int textRight;

	// Token: 0x04002106 RID: 8454
	public int texTop;

	// Token: 0x04002107 RID: 8455
	public int textBottom;

	// Token: 0x04002108 RID: 8456
	public int textMaxWidth = 470;

	// Token: 0x04002109 RID: 8457
	public int textLineHeight = 100;

	// Token: 0x0400210A RID: 8458
	public int textMaxSize = 24;

	// Token: 0x0400210B RID: 8459
	public Color textColor;

	// Token: 0x0400210C RID: 8460
	public string textBodyId = "";

	// Token: 0x0400210D RID: 8461
	public int textSubtitleLeft;

	// Token: 0x0400210E RID: 8462
	public int textSubtitleRight;

	// Token: 0x0400210F RID: 8463
	public int textSubtitleTop;

	// Token: 0x04002110 RID: 8464
	public int textSubtitleBottom;

	// Token: 0x04002111 RID: 8465
	public int textSubtitleMaxWidth = 470;

	// Token: 0x04002112 RID: 8466
	public int textSubtitleMaxSize = 24;

	// Token: 0x04002113 RID: 8467
	public Color textSubtitleColor;

	// Token: 0x04002114 RID: 8468
	public string textSubtitleId = "";

	// Token: 0x04002115 RID: 8469
	public bool textSubtitleIsItalic;

	// Token: 0x04002116 RID: 8470
	public int textTimerLeft;

	// Token: 0x04002117 RID: 8471
	public int textTimerRight;

	// Token: 0x04002118 RID: 8472
	public int textTimerTop;

	// Token: 0x04002119 RID: 8473
	public int textTimerBottom;

	// Token: 0x0400211A RID: 8474
	public int textTimerMaxWidth = 470;

	// Token: 0x0400211B RID: 8475
	public int textTimerMaxSize = 24;

	// Token: 0x0400211C RID: 8476
	public Color textTimerColor;

	// Token: 0x0400211D RID: 8477
	public string textButtonId = "";

	// Token: 0x0400211E RID: 8478
	public string textInfoTitleId = "";

	// Token: 0x0400211F RID: 8479
	public string textInfoBodyId = "";

	// Token: 0x04002120 RID: 8480
	public string textInfoBodyId2 = "";
}
