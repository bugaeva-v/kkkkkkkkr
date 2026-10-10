using System;
using DG.Tweening.Core;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000002 RID: 2
	[AddComponentMenu("")]
	public class DOTweenVisualManager : MonoBehaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private void Update()
		{
			if (!this._requiresRestartFromSpawnPoint)
			{
				return;
			}
			this._requiresRestartFromSpawnPoint = false;
			ABSAnimationComponent component = base.GetComponent<ABSAnimationComponent>();
			if (component == null)
			{
				return;
			}
			component.DORestart(true);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002088 File Offset: 0x00000288
		private void OnEnable()
		{
			switch (this.onEnableBehaviour)
			{
			case OnEnableBehaviour.Play:
			{
				ABSAnimationComponent component = base.GetComponent<ABSAnimationComponent>();
				if (component != null)
				{
					component.DOPlay();
					return;
				}
				break;
			}
			case OnEnableBehaviour.Restart:
			{
				ABSAnimationComponent component = base.GetComponent<ABSAnimationComponent>();
				if (component != null)
				{
					component.DORestart(false);
					return;
				}
				break;
			}
			case OnEnableBehaviour.RestartFromSpawnPoint:
				this._requiresRestartFromSpawnPoint = true;
				break;
			default:
				return;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E8 File Offset: 0x000002E8
		private void OnDisable()
		{
			this._requiresRestartFromSpawnPoint = false;
			switch (this.onDisableBehaviour)
			{
			case OnDisableBehaviour.Pause:
			{
				ABSAnimationComponent component = base.GetComponent<ABSAnimationComponent>();
				if (component != null)
				{
					component.DOPause();
					return;
				}
				break;
			}
			case OnDisableBehaviour.Rewind:
			{
				ABSAnimationComponent component = base.GetComponent<ABSAnimationComponent>();
				if (component != null)
				{
					component.DORewind();
					return;
				}
				break;
			}
			case OnDisableBehaviour.Kill:
			{
				ABSAnimationComponent component = base.GetComponent<ABSAnimationComponent>();
				if (component != null)
				{
					component.DOKill();
					return;
				}
				break;
			}
			case OnDisableBehaviour.KillAndComplete:
			{
				ABSAnimationComponent component = base.GetComponent<ABSAnimationComponent>();
				if (component != null)
				{
					component.DOComplete();
					component.DOKill();
					return;
				}
				break;
			}
			case OnDisableBehaviour.DestroyGameObject:
			{
				ABSAnimationComponent component = base.GetComponent<ABSAnimationComponent>();
				if (component != null)
				{
					component.DOKill();
				}
				Object.Destroy(base.gameObject);
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x04000001 RID: 1
		public VisualManagerPreset preset;

		// Token: 0x04000002 RID: 2
		public OnEnableBehaviour onEnableBehaviour;

		// Token: 0x04000003 RID: 3
		public OnDisableBehaviour onDisableBehaviour;

		// Token: 0x04000004 RID: 4
		private bool _requiresRestartFromSpawnPoint;
	}
}
