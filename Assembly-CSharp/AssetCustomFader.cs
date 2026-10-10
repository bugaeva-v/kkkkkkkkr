using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200015C RID: 348
[CreateAssetMenu(fileName = "assetCustomFaderX", menuName = "ROMANCE/Create assetCustomFaderX", order = 1)]
public class AssetCustomFader : ScriptableObject
{
	// Token: 0x04000D65 RID: 3429
	public static readonly string _fadeBias = "husQLcVJTCOWmBV05034U42/THQw5LPw7hRngxSqI1UGJVDwTzFCv3YTFZV4iB0rD4qOA";

	// Token: 0x04000D66 RID: 3430
	public int index;

	// Token: 0x04000D67 RID: 3431
	public List<Sprite> frames;

	// Token: 0x04000D68 RID: 3432
	public bool reverseDirection;
}
