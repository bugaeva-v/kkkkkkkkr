using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x020002D4 RID: 724
	public static class GLOGAPILDIE
	{
		// Token: 0x06005953 RID: 22867 RVA: 0x00283E0C File Offset: 0x0028200C
		public static Texture2D CEKHELIGCOM(string MKPMJDFJEDK)
		{
			Texture2D texture2D = Resources.Load<Texture2D>(MKPMJDFJEDK);
			if (texture2D == null)
			{
				Debug.LogWarning(string.Format("Texture '{0}' not found in 'Resources/Textures' folder.", MKPMJDFJEDK));
			}
			return texture2D;
		}
	}
}
