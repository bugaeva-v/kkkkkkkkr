using System;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200002F RID: 47
	internal static class ObjectUtility
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00006114 File Offset: 0x00004314
		internal static void DestroySafely<T>(T obj) where T : UnityEngine.Object
		{
			if (obj == null)
			{
				return;
			}
			if (Application.isPlaying)
			{
				UnityEngine.Object.Destroy(obj);
				return;
			}
			UnityEngine.Object.DestroyImmediate(obj);
		}
	}
}
