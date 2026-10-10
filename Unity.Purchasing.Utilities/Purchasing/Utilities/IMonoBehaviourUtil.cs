using System;
using System.Collections;
using UnityEngine;

namespace Purchasing.Utilities
{
	// Token: 0x02000008 RID: 8
	internal interface IMonoBehaviourUtil
	{
		// Token: 0x0600002A RID: 42
		GameObject[] GetGameObjects();

		// Token: 0x0600002B RID: 43
		IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay);

		// Token: 0x0600002C RID: 44
		Coroutine StartCoroutine(IEnumerator start);
	}
}
