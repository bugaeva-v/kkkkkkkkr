using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200031D RID: 797
	internal class ShaderInfoStorageRGBA32 : ShaderInfoStorage<Color32>
	{
		// Token: 0x06001A1F RID: 6687 RVA: 0x0006EC4B File Offset: 0x0006CE4B
		public ShaderInfoStorageRGBA32(int initialSize = 64, int maxSize = 4096) : base(TextureFormat.RGBA32, ShaderInfoStorageRGBA32.s_Convert, initialSize, maxSize)
		{
		}

		// Token: 0x04000BE3 RID: 3043
		private static readonly Func<Color, Color32> s_Convert = (Color c) => c;
	}
}
