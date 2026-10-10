using System;
using UnityEngine;

// Token: 0x0200051A RID: 1306
[CreateAssetMenu(fileName = "assetCustomEffectsX", menuName = "ROMANCE/Create assetCustomEffects", order = 1)]
public class AssetCustomEffects : ScriptableObject
{
	// Token: 0x04002BCE RID: 11214
	public int index;

	// Token: 0x04002BCF RID: 11215
	public string effectId = "";

	// Token: 0x04002BD0 RID: 11216
	public EOJDHDECPFO effectType;

	// Token: 0x04002BD1 RID: 11217
	public Shader shader;

	// Token: 0x04002BD2 RID: 11218
	public Texture2D noiseTexture;

	// Token: 0x04002BD3 RID: 11219
	public Texture2D maskTexture;

	// Token: 0x04002BD4 RID: 11220
	public float defaultDuration = 0.4f;

	// Token: 0x04002BD5 RID: 11221
	public Vector4 params0 = Vector4.zero;

	// Token: 0x04002BD6 RID: 11222
	public float animationScaleImpact = 1f;
}
