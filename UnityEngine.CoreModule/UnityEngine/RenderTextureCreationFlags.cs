using System;

namespace UnityEngine
{
	// Token: 0x02000182 RID: 386
	[Flags]
	public enum RenderTextureCreationFlags
	{
		// Token: 0x04000559 RID: 1369
		MipMap = 1,
		// Token: 0x0400055A RID: 1370
		AutoGenerateMips = 2,
		// Token: 0x0400055B RID: 1371
		SRGB = 4,
		// Token: 0x0400055C RID: 1372
		EyeTexture = 8,
		// Token: 0x0400055D RID: 1373
		EnableRandomWrite = 16,
		// Token: 0x0400055E RID: 1374
		CreatedFromScript = 32,
		// Token: 0x0400055F RID: 1375
		AllowVerticalFlip = 128,
		// Token: 0x04000560 RID: 1376
		NoResolvedColorSurface = 256,
		// Token: 0x04000561 RID: 1377
		DynamicallyScalable = 1024,
		// Token: 0x04000562 RID: 1378
		BindMS = 2048
	}
}
