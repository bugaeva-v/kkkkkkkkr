using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200031F RID: 799
	internal class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<Color>
	{
		// Token: 0x06001A24 RID: 6692 RVA: 0x0006EC88 File Offset: 0x0006CE88
		public ShaderInfoStorageRGBAFloat(int initialSize = 64, int maxSize = 4096) : base(TextureFormat.RGBAFloat, ShaderInfoStorageRGBAFloat.s_Convert, initialSize, maxSize)
		{
		}

		// Token: 0x04000BE5 RID: 3045
		private static readonly Func<Color, Color> s_Convert = (Color c) => c;
	}
}
