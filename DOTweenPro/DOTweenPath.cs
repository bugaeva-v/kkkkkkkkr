using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000006 RID: 6
	[AddComponentMenu("DOTween/DOTween Path")]
	public class DOTweenPath : ABSAnimationComponent
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000021AC File Offset: 0x000003AC
		private void Awake()
		{
			if (this.path == null || this.wps.Count < 1 || this.inspectorMode == DOTweenInspectorMode.OnlyPath)
			{
				return;
			}
			this.path.AssignDecoder(this.path.type);
			if (DOTween.isUnityEditor)
			{
				DOTween.GizmosDelegates.Add(new TweenCallback(this.path.Draw));
				this.path.gizmoColor = this.pathColor;
			}
			if (this.isLocal)
			{
				Transform transform = base.transform;
				if (transform.parent != null)
				{
					transform = transform.parent;
					Vector3 position = transform.position;
					int num = this.path.wps.Length;
					for (int i = 0; i < num; i++)
					{
						this.path.wps[i] = this.path.wps[i] - position;
					}
					num = this.path.controlPoints.Length;
					for (int j = 0; j < num; j++)
					{
						ControlPoint controlPoint = this.path.controlPoints[j];
						controlPoint.a -= position;
						controlPoint.b -= position;
						this.path.controlPoints[j] = controlPoint;
					}
				}
			}
			if (this.relative)
			{
				this.ReEvaluateRelativeTween();
			}
			if (this.pathMode == PathMode.Full3D && base.GetComponent<SpriteRenderer>() != null)
			{
				this.pathMode = PathMode.TopDown2D;
			}
			Rigidbody component = base.GetComponent<Rigidbody>();
			TweenerCore<Vector3, Path, PathOptions> tweenerCore;
			if (this.tweenRigidbody && component != null)
			{
				tweenerCore = (this.isLocal ? component.DOLocalPath(this.path, this.duration, this.pathMode).SetOptions(this.isClosedPath, AxisConstraint.None, this.lockRotation) : component.DOPath(this.path, this.duration, this.pathMode).SetOptions(this.isClosedPath, AxisConstraint.None, this.lockRotation));
			}
			else
			{
				tweenerCore = (this.isLocal ? base.transform.DOLocalPath(this.path, this.duration, this.pathMode).SetOptions(this.isClosedPath, AxisConstraint.None, this.lockRotation) : base.transform.DOPath(this.path, this.duration, this.pathMode).SetOptions(this.isClosedPath, AxisConstraint.None, this.lockRotation));
			}
			switch (this.orientType)
			{
			case OrientType.ToPath:
				if (this.assignForwardAndUp)
				{
					tweenerCore.SetLookAt(this.lookAhead, new Vector3?(this.forwardDirection), new Vector3?(this.upDirection));
				}
				else
				{
					tweenerCore.SetLookAt(this.lookAhead, null, null);
				}
				break;
			case OrientType.LookAtTransform:
				if (this.lookAtTransform != null)
				{
					if (this.assignForwardAndUp)
					{
						tweenerCore.SetLookAt(this.lookAtTransform, new Vector3?(this.forwardDirection), new Vector3?(this.upDirection));
					}
					else
					{
						tweenerCore.SetLookAt(this.lookAtTransform, null, null);
					}
				}
				break;
			case OrientType.LookAtPosition:
				if (this.assignForwardAndUp)
				{
					tweenerCore.SetLookAt(this.lookAtPosition, new Vector3?(this.forwardDirection), new Vector3?(this.upDirection));
				}
				else
				{
					tweenerCore.SetLookAt(this.lookAtPosition, null, null);
				}
				break;
			}
			tweenerCore.SetDelay(this.delay).SetLoops(this.loops, this.loopType).SetAutoKill(this.autoKill).SetUpdate(this.updateType).OnKill(delegate
			{
				this.tween = null;
			});
			if (this.isSpeedBased)
			{
				tweenerCore.SetSpeedBased<TweenerCore<Vector3, Path, PathOptions>>();
			}
			if (this.easeType == Ease.INTERNAL_Custom)
			{
				tweenerCore.SetEase(this.easeCurve);
			}
			else
			{
				tweenerCore.SetEase(this.easeType);
			}
			if (!string.IsNullOrEmpty(this.id))
			{
				tweenerCore.SetId(this.id);
			}
			if (this.hasOnStart)
			{
				if (this.onStart != null)
				{
					tweenerCore.OnStart(new TweenCallback(this.onStart.Invoke));
				}
			}
			else
			{
				this.onStart = null;
			}
			if (this.hasOnPlay)
			{
				if (this.onPlay != null)
				{
					tweenerCore.OnPlay(new TweenCallback(this.onPlay.Invoke));
				}
			}
			else
			{
				this.onPlay = null;
			}
			if (this.hasOnUpdate)
			{
				if (this.onUpdate != null)
				{
					tweenerCore.OnUpdate(new TweenCallback(this.onUpdate.Invoke));
				}
			}
			else
			{
				this.onUpdate = null;
			}
			if (this.hasOnStepComplete)
			{
				if (this.onStepComplete != null)
				{
					tweenerCore.OnStepComplete(new TweenCallback(this.onStepComplete.Invoke));
				}
			}
			else
			{
				this.onStepComplete = null;
			}
			if (this.hasOnComplete)
			{
				if (this.onComplete != null)
				{
					tweenerCore.OnComplete(new TweenCallback(this.onComplete.Invoke));
				}
			}
			else
			{
				this.onComplete = null;
			}
			if (this.hasOnRewind)
			{
				if (this.onRewind != null)
				{
					tweenerCore.OnRewind(new TweenCallback(this.onRewind.Invoke));
				}
			}
			else
			{
				this.onRewind = null;
			}
			if (this.autoPlay)
			{
				tweenerCore.Play<TweenerCore<Vector3, Path, PathOptions>>();
			}
			else
			{
				tweenerCore.Pause<TweenerCore<Vector3, Path, PathOptions>>();
			}
			this.tween = tweenerCore;
			if (this.hasOnTweenCreated && this.onTweenCreated != null)
			{
				this.onTweenCreated.Invoke();
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000273E File Offset: 0x0000093E
		private void Reset()
		{
			this.path = new Path(this.pathType, this.wps.ToArray(), 10, new Color?(this.pathColor));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002769 File Offset: 0x00000969
		private void OnDestroy()
		{
			if (this.tween != null && this.tween.active)
			{
				this.tween.Kill(false);
			}
			this.tween = null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002793 File Offset: 0x00000993
		public override void DOPlay()
		{
			this.tween.Play<Tween>();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000027A1 File Offset: 0x000009A1
		public override void DOPlayBackwards()
		{
			this.tween.PlayBackwards();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000027AE File Offset: 0x000009AE
		public override void DOPlayForward()
		{
			this.tween.PlayForward();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000027BB File Offset: 0x000009BB
		public override void DOPause()
		{
			this.tween.Pause<Tween>();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000027C9 File Offset: 0x000009C9
		public override void DOTogglePause()
		{
			this.tween.TogglePause();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000027D6 File Offset: 0x000009D6
		public override void DORewind()
		{
			this.tween.Rewind(true);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000027E4 File Offset: 0x000009E4
		public override void DORestart(bool fromHere = false)
		{
			if (this.tween == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(this.tween);
				}
				return;
			}
			if (fromHere && this.relative && !this.isLocal)
			{
				this.ReEvaluateRelativeTween();
			}
			this.tween.Restart(true, -1f);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002837 File Offset: 0x00000A37
		public override void DOComplete()
		{
			this.tween.Complete();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002844 File Offset: 0x00000A44
		public override void DOKill()
		{
			this.tween.Kill(false);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002854 File Offset: 0x00000A54
		public Tween GetTween()
		{
			if (this.tween == null || !this.tween.active)
			{
				if (Debugger.logPriority > 1)
				{
					if (this.tween == null)
					{
						Debugger.LogNullTween(this.tween);
					}
					else
					{
						Debugger.LogInvalidTween(this.tween);
					}
				}
				return null;
			}
			return this.tween;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000028A8 File Offset: 0x00000AA8
		public Vector3[] GetDrawPoints()
		{
			if (this.path.wps == null || this.path.nonLinearDrawWps == null)
			{
				Debugger.LogWarning("Draw points not ready yet. Returning NULL");
				return null;
			}
			if (this.pathType == PathType.Linear)
			{
				return this.path.wps;
			}
			return this.path.nonLinearDrawWps;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000028FC File Offset: 0x00000AFC
		internal Vector3[] GetFullWps()
		{
			int count = this.wps.Count;
			int num = count + 1;
			if (this.isClosedPath)
			{
				num++;
			}
			Vector3[] array = new Vector3[num];
			array[0] = base.transform.position;
			for (int i = 0; i < count; i++)
			{
				array[i + 1] = this.wps[i];
			}
			if (this.isClosedPath)
			{
				array[num - 1] = array[0];
			}
			return array;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002978 File Offset: 0x00000B78
		private void ReEvaluateRelativeTween()
		{
			Vector3 position = base.transform.position;
			if (position == this.lastSrcPosition)
			{
				return;
			}
			Vector3 b = position - this.lastSrcPosition;
			int num = this.path.wps.Length;
			for (int i = 0; i < num; i++)
			{
				this.path.wps[i] = this.path.wps[i] + b;
			}
			num = this.path.controlPoints.Length;
			for (int j = 0; j < num; j++)
			{
				ControlPoint controlPoint = this.path.controlPoints[j];
				controlPoint.a += b;
				controlPoint.b += b;
				this.path.controlPoints[j] = controlPoint;
			}
			this.lastSrcPosition = position;
		}

		// Token: 0x04000010 RID: 16
		public float delay;

		// Token: 0x04000011 RID: 17
		public float duration = 1f;

		// Token: 0x04000012 RID: 18
		public Ease easeType = Ease.OutQuad;

		// Token: 0x04000013 RID: 19
		public AnimationCurve easeCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000014 RID: 20
		public int loops = 1;

		// Token: 0x04000015 RID: 21
		public string id = "";

		// Token: 0x04000016 RID: 22
		public LoopType loopType;

		// Token: 0x04000017 RID: 23
		public OrientType orientType;

		// Token: 0x04000018 RID: 24
		public Transform lookAtTransform;

		// Token: 0x04000019 RID: 25
		public Vector3 lookAtPosition;

		// Token: 0x0400001A RID: 26
		public float lookAhead = 0.01f;

		// Token: 0x0400001B RID: 27
		public bool autoPlay = true;

		// Token: 0x0400001C RID: 28
		public bool autoKill = true;

		// Token: 0x0400001D RID: 29
		public bool relative;

		// Token: 0x0400001E RID: 30
		public bool isLocal;

		// Token: 0x0400001F RID: 31
		public bool isClosedPath;

		// Token: 0x04000020 RID: 32
		public int pathResolution = 10;

		// Token: 0x04000021 RID: 33
		public PathMode pathMode = PathMode.Full3D;

		// Token: 0x04000022 RID: 34
		public AxisConstraint lockRotation;

		// Token: 0x04000023 RID: 35
		public bool assignForwardAndUp;

		// Token: 0x04000024 RID: 36
		public Vector3 forwardDirection = Vector3.forward;

		// Token: 0x04000025 RID: 37
		public Vector3 upDirection = Vector3.up;

		// Token: 0x04000026 RID: 38
		public bool tweenRigidbody;

		// Token: 0x04000027 RID: 39
		public List<Vector3> wps = new List<Vector3>();

		// Token: 0x04000028 RID: 40
		public List<Vector3> fullWps = new List<Vector3>();

		// Token: 0x04000029 RID: 41
		public Path path;

		// Token: 0x0400002A RID: 42
		public DOTweenInspectorMode inspectorMode;

		// Token: 0x0400002B RID: 43
		public PathType pathType;

		// Token: 0x0400002C RID: 44
		public HandlesType handlesType;

		// Token: 0x0400002D RID: 45
		public bool livePreview = true;

		// Token: 0x0400002E RID: 46
		public HandlesDrawMode handlesDrawMode;

		// Token: 0x0400002F RID: 47
		public float perspectiveHandleSize = 0.5f;

		// Token: 0x04000030 RID: 48
		public bool showIndexes = true;

		// Token: 0x04000031 RID: 49
		public bool showWpLength;

		// Token: 0x04000032 RID: 50
		public Color pathColor = new Color(1f, 1f, 1f, 0.5f);

		// Token: 0x04000033 RID: 51
		public Vector3 lastSrcPosition;

		// Token: 0x04000034 RID: 52
		public bool wpsDropdown;

		// Token: 0x04000035 RID: 53
		public float dropToFloorOffset;
	}
}
