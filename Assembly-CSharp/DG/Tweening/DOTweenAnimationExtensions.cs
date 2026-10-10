using System;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000514 RID: 1300
	public static class DOTweenAnimationExtensions
	{
		// Token: 0x06009CB1 RID: 40113 RVA: 0x00439ADB File Offset: 0x00437CDB
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return t is T;
		}
	}
}
