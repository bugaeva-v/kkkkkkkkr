using System;

namespace UnityEngine.Sprites
{
	// Token: 0x0200026F RID: 623
	public sealed class DataUtility
	{
		// Token: 0x06001B1F RID: 6943 RVA: 0x0002B890 File Offset: 0x00029A90
		public static Vector4 GetInnerUV(Sprite sprite)
		{
			return sprite.GetInnerUVs();
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0002B8A8 File Offset: 0x00029AA8
		public static Vector4 GetOuterUV(Sprite sprite)
		{
			return sprite.GetOuterUVs();
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0002B8C0 File Offset: 0x00029AC0
		public static Vector4 GetPadding(Sprite sprite)
		{
			return sprite.GetPadding();
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0002B8D8 File Offset: 0x00029AD8
		public static Vector2 GetMinSize(Sprite sprite)
		{
			Vector2 result;
			result.x = sprite.border.x + sprite.border.z;
			result.y = sprite.border.y + sprite.border.w;
			return result;
		}
	}
}
