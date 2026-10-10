using System;
using System.Collections;
using UnityEngine;

namespace Purchasing.Utilities
{
	// Token: 0x02000009 RID: 9
	[HideInInspector]
	[AddComponentMenu("")]
	internal class MonoBehaviourUtil : MonoBehaviour, IMonoBehaviourUtil
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002126 File Offset: 0x00000326
		public GameObject[] GetGameObjects()
		{
			return (GameObject[])UnityEngine.Object.FindObjectsOfType(typeof(GameObject));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000213C File Offset: 0x0000033C
		public IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay)
		{
			yield return new WaitForSeconds((float)delay);
			base.StartCoroutine(coroutine);
			yield break;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002159 File Offset: 0x00000359
		Coroutine IMonoBehaviourUtil.StartCoroutine(IEnumerator start)
		{
			return base.StartCoroutine(start);
		}
	}
}
