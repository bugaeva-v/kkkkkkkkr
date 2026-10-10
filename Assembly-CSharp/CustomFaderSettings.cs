using System;

// Token: 0x02000153 RID: 339
[Serializable]
public class CustomFaderSettings
{
	// Token: 0x04000D3A RID: 3386
	public int index;

	// Token: 0x04000D3B RID: 3387
	public int assetIndex;

	// Token: 0x04000D3C RID: 3388
	public string hint = "";

	// Token: 0x04000D3D RID: 3389
	public float forcedAnimationTime = -1f;

	// Token: 0x04000D3E RID: 3390
	public int idleFramesToWaitForSafeCollision = 3;
}
