using System;
using System.Collections;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x0200004A RID: 74
	[AddComponentMenu("")]
	public class DOTweenComponent : MonoBehaviour, IDOTweenInit
	{
		// Token: 0x06000262 RID: 610 RVA: 0x0000D8FC File Offset: 0x0000BAFC
		private void Awake()
		{
			this.inspectorUpdater = 0;
			this._unscaledTime = Time.realtimeSinceStartup;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000D910 File Offset: 0x0000BB10
		private void Start()
		{
			if (DOTween.instance != this)
			{
				this._duplicateToDestroy = true;
				Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000D934 File Offset: 0x0000BB34
		private void Update()
		{
			this._unscaledDeltaTime = Time.realtimeSinceStartup - this._unscaledTime;
			if (DOTween.useSmoothDeltaTime && this._unscaledDeltaTime > DOTween.maxSmoothUnscaledTime)
			{
				this._unscaledDeltaTime = DOTween.maxSmoothUnscaledTime;
			}
			if (TweenManager.hasActiveDefaultTweens)
			{
				TweenManager.Update(UpdateType.Normal, (DOTween.useSmoothDeltaTime ? Time.smoothDeltaTime : Time.deltaTime) * DOTween.timeScale, this._unscaledDeltaTime * DOTween.timeScale);
			}
			this._unscaledTime = Time.realtimeSinceStartup;
			if (DOTween.isUnityEditor)
			{
				this.inspectorUpdater++;
				if (DOTween.showUnityEditorReport && TweenManager.hasActiveTweens)
				{
					if (TweenManager.totActiveTweeners > DOTween.maxActiveTweenersReached)
					{
						DOTween.maxActiveTweenersReached = TweenManager.totActiveTweeners;
					}
					if (TweenManager.totActiveSequences > DOTween.maxActiveSequencesReached)
					{
						DOTween.maxActiveSequencesReached = TweenManager.totActiveSequences;
					}
				}
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000D9FE File Offset: 0x0000BBFE
		private void LateUpdate()
		{
			if (TweenManager.hasActiveLateTweens)
			{
				TweenManager.Update(UpdateType.Late, (DOTween.useSmoothDeltaTime ? Time.smoothDeltaTime : Time.deltaTime) * DOTween.timeScale, this._unscaledDeltaTime * DOTween.timeScale);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000DA34 File Offset: 0x0000BC34
		private void FixedUpdate()
		{
			if (TweenManager.hasActiveFixedTweens && Time.timeScale > 0f)
			{
				TweenManager.Update(UpdateType.Fixed, (DOTween.useSmoothDeltaTime ? Time.smoothDeltaTime : Time.deltaTime) * DOTween.timeScale, (DOTween.useSmoothDeltaTime ? Time.smoothDeltaTime : Time.deltaTime) / Time.timeScale * DOTween.timeScale);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000DA92 File Offset: 0x0000BC92
		internal void ManualUpdate(float deltaTime, float unscaledDeltaTime)
		{
			if (TweenManager.hasActiveManualTweens)
			{
				TweenManager.Update(UpdateType.Manual, deltaTime * DOTween.timeScale, unscaledDeltaTime * DOTween.timeScale);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		private void OnDrawGizmos()
		{
			if (!DOTween.drawGizmos || !DOTween.isUnityEditor)
			{
				return;
			}
			int count = DOTween.GizmosDelegates.Count;
			if (count == 0)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				DOTween.GizmosDelegates[i]();
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		private void OnDestroy()
		{
			if (this._duplicateToDestroy)
			{
				return;
			}
			if (DOTween.showUnityEditorReport)
			{
				Debugger.LogReport(string.Concat(new object[]
				{
					"REPORT > Max overall simultaneous active Tweeners/Sequences: ",
					DOTween.maxActiveTweenersReached,
					"/",
					DOTween.maxActiveSequencesReached
				}));
			}
			if (DOTween.instance == this)
			{
				DOTween.instance = null;
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000DB62 File Offset: 0x0000BD62
		private void OnApplicationQuit()
		{
			DOTween.isQuitting = true;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000DB6A File Offset: 0x0000BD6A
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			TweenManager.SetCapacities(tweenersCapacity, sequencesCapacity);
			return this;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000DB74 File Offset: 0x0000BD74
		internal IEnumerator WaitForCompletion(Tween t)
		{
			while (t.active && !t.isComplete)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000DB83 File Offset: 0x0000BD83
		internal IEnumerator WaitForRewind(Tween t)
		{
			while (t.active && (!t.playedOnce || t.position * (float)(t.completedLoops + 1) > 0f))
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000DB92 File Offset: 0x0000BD92
		internal IEnumerator WaitForKill(Tween t)
		{
			while (t.active)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000DBA1 File Offset: 0x0000BDA1
		internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops)
		{
			while (t.active && t.completedLoops < elapsedLoops)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000DBB7 File Offset: 0x0000BDB7
		internal IEnumerator WaitForPosition(Tween t, float position)
		{
			while (t.active && t.position * (float)(t.completedLoops + 1) < position)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000DBCD File Offset: 0x0000BDCD
		internal IEnumerator WaitForStart(Tween t)
		{
			while (t.active && !t.playedOnce)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000DBDC File Offset: 0x0000BDDC
		internal static void Create()
		{
			if (DOTween.instance != null)
			{
				return;
			}
			GameObject gameObject = new GameObject("[DOTween]");
			Object.DontDestroyOnLoad(gameObject);
			DOTween.instance = gameObject.AddComponent<DOTweenComponent>();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000DC06 File Offset: 0x0000BE06
		internal static void DestroyInstance()
		{
			if (DOTween.instance != null)
			{
				Object.Destroy(DOTween.instance.gameObject);
			}
			DOTween.instance = null;
		}

		// Token: 0x0400011F RID: 287
		public int inspectorUpdater;

		// Token: 0x04000120 RID: 288
		private float _unscaledTime;

		// Token: 0x04000121 RID: 289
		private float _unscaledDeltaTime;

		// Token: 0x04000122 RID: 290
		private bool _duplicateToDestroy;
	}
}
