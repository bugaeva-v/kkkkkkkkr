using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.UI;

namespace DG.Tweening
{
	// Token: 0x020000CC RID: 204
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		// Token: 0x06001E18 RID: 7704 RVA: 0x000D89B7 File Offset: 0x000D6BB7
		private void Awake()
		{
			if (!this.isActive || !this.isValid)
			{
				return;
			}
			if (this.animationType != DOTweenAnimationType.Move || !this.useTargetAsV3)
			{
				this.CreateTween();
				this._tweenCreated = true;
			}
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000D89E8 File Offset: 0x000D6BE8
		private void Start()
		{
			if (this._tweenCreated || !this.isActive || !this.isValid)
			{
				return;
			}
			this.CreateTween();
			this._tweenCreated = true;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000D8A10 File Offset: 0x000D6C10
		private void OnDestroy()
		{
			if (this.tween != null && this.tween.IsActive())
			{
				this.tween.Kill(false);
			}
			this.tween = null;
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x000D8A3C File Offset: 0x000D6C3C
		public void CreateTween()
		{
			if (this.target == null)
			{
				Debug.LogWarning(string.Format("{0} :: This tween's target is NULL, because the animation was created with a DOTween Pro version older than 0.9.255. To fix this, exit Play mode then simply select this object, and it will update automatically", base.gameObject.name), base.gameObject);
				return;
			}
			if (this.forcedTargetType != TargetType.Unset)
			{
				this.targetType = this.forcedTargetType;
			}
			if (this.targetType == TargetType.Unset)
			{
				this.targetType = DOTweenAnimation.TypeToDOTargetType(this.target.GetType());
			}
			switch (this.animationType)
			{
			case DOTweenAnimationType.Move:
				if (this.useTargetAsV3)
				{
					this.isRelative = false;
					if (this.endValueTransform == null)
					{
						Debug.LogWarning(string.Format("{0} :: This tween's TO target is NULL, a Vector3 of (0,0,0) will be used instead", base.gameObject.name), base.gameObject);
						this.endValueV3 = Vector3.zero;
					}
					else if (this.targetType == TargetType.RectTransform)
					{
						RectTransform rectTransform = this.endValueTransform as RectTransform;
						if (rectTransform == null)
						{
							Debug.LogWarning(string.Format("{0} :: This tween's TO target should be a RectTransform, a Vector3 of (0,0,0) will be used instead", base.gameObject.name), base.gameObject);
							this.endValueV3 = Vector3.zero;
						}
						else
						{
							RectTransform rectTransform2 = this.target as RectTransform;
							if (rectTransform2 == null)
							{
								Debug.LogWarning(string.Format("{0} :: This tween's target and TO target are not of the same type. Please reassign the values", base.gameObject.name), base.gameObject);
							}
							else
							{
								this.endValueV3 = DOTweenUtils46.SwitchToRectTransform(rectTransform, rectTransform2);
							}
						}
					}
					else
					{
						this.endValueV3 = this.endValueTransform.position;
					}
				}
				switch (this.targetType)
				{
				case TargetType.RectTransform:
					this.tween = ((RectTransform)this.target).DOAnchorPos3D(this.endValueV3, this.duration, this.optionalBool0);
					break;
				case TargetType.Rigidbody:
					this.tween = ((Rigidbody)this.target).DOMove(this.endValueV3, this.duration, this.optionalBool0);
					break;
				case TargetType.Rigidbody2D:
					this.tween = ((Rigidbody2D)this.target).DOMove(this.endValueV3, this.duration, this.optionalBool0);
					break;
				case TargetType.Transform:
					this.tween = ((Transform)this.target).DOMove(this.endValueV3, this.duration, this.optionalBool0);
					break;
				}
				break;
			case DOTweenAnimationType.LocalMove:
				this.tween = base.transform.DOLocalMove(this.endValueV3, this.duration, this.optionalBool0);
				break;
			case DOTweenAnimationType.Rotate:
				switch (this.targetType)
				{
				case TargetType.Rigidbody:
					this.tween = ((Rigidbody)this.target).DORotate(this.endValueV3, this.duration, this.optionalRotationMode);
					break;
				case TargetType.Rigidbody2D:
					this.tween = ((Rigidbody2D)this.target).DORotate(this.endValueFloat, this.duration);
					break;
				case TargetType.Transform:
					this.tween = ((Transform)this.target).DORotate(this.endValueV3, this.duration, this.optionalRotationMode);
					break;
				}
				break;
			case DOTweenAnimationType.LocalRotate:
				this.tween = base.transform.DOLocalRotate(this.endValueV3, this.duration, this.optionalRotationMode);
				break;
			case DOTweenAnimationType.Scale:
			{
				TargetType targetType = this.targetType;
				this.tween = base.transform.DOScale(this.optionalBool0 ? new Vector3(this.endValueFloat, this.endValueFloat, this.endValueFloat) : this.endValueV3, this.duration);
				break;
			}
			case DOTweenAnimationType.Color:
				this.isRelative = false;
				switch (this.targetType)
				{
				case TargetType.Image:
					this.tween = ((Image)this.target).DOColor(this.endValueColor, this.duration);
					break;
				case TargetType.Light:
					this.tween = ((Light)this.target).DOColor(this.endValueColor, this.duration);
					break;
				case TargetType.Renderer:
					this.tween = ((Renderer)this.target).material.DOColor(this.endValueColor, this.duration);
					break;
				case TargetType.SpriteRenderer:
					this.tween = ((SpriteRenderer)this.target).DOColor(this.endValueColor, this.duration);
					break;
				case TargetType.Text:
					this.tween = ((Text)this.target).DOColor(this.endValueColor, this.duration);
					break;
				}
				break;
			case DOTweenAnimationType.Fade:
				this.isRelative = false;
				switch (this.targetType)
				{
				case TargetType.CanvasGroup:
					this.tween = ((CanvasGroup)this.target).DOFade(this.endValueFloat, this.duration);
					break;
				case TargetType.Image:
					this.tween = ((Image)this.target).DOFade(this.endValueFloat, this.duration);
					break;
				case TargetType.Light:
					this.tween = ((Light)this.target).DOIntensity(this.endValueFloat, this.duration);
					break;
				case TargetType.Renderer:
					this.tween = ((Renderer)this.target).material.DOFade(this.endValueFloat, this.duration);
					break;
				case TargetType.SpriteRenderer:
					this.tween = ((SpriteRenderer)this.target).DOFade(this.endValueFloat, this.duration);
					break;
				case TargetType.Text:
					this.tween = ((Text)this.target).DOFade(this.endValueFloat, this.duration);
					break;
				}
				break;
			case DOTweenAnimationType.Text:
				if (this.targetType == TargetType.Text)
				{
					this.tween = ((Text)this.target).DOText(this.endValueString, this.duration, this.optionalBool0, this.optionalScrambleMode, this.optionalString);
				}
				break;
			case DOTweenAnimationType.PunchPosition:
			{
				TargetType targetType2 = this.targetType;
				if (targetType2 != TargetType.RectTransform)
				{
					if (targetType2 == TargetType.Transform)
					{
						this.tween = ((Transform)this.target).DOPunchPosition(this.endValueV3, this.duration, this.optionalInt0, this.optionalFloat0, this.optionalBool0);
					}
				}
				else
				{
					this.tween = ((RectTransform)this.target).DOPunchAnchorPos(this.endValueV3, this.duration, this.optionalInt0, this.optionalFloat0, this.optionalBool0);
				}
				break;
			}
			case DOTweenAnimationType.PunchRotation:
				this.tween = base.transform.DOPunchRotation(this.endValueV3, this.duration, this.optionalInt0, this.optionalFloat0);
				break;
			case DOTweenAnimationType.PunchScale:
				this.tween = base.transform.DOPunchScale(this.endValueV3, this.duration, this.optionalInt0, this.optionalFloat0);
				break;
			case DOTweenAnimationType.ShakePosition:
			{
				TargetType targetType2 = this.targetType;
				if (targetType2 != TargetType.RectTransform)
				{
					if (targetType2 == TargetType.Transform)
					{
						this.tween = ((Transform)this.target).DOShakePosition(this.duration, this.endValueV3, this.optionalInt0, this.optionalFloat0, this.optionalBool0, true);
					}
				}
				else
				{
					this.tween = ((RectTransform)this.target).DOShakeAnchorPos(this.duration, this.endValueV3, this.optionalInt0, this.optionalFloat0, this.optionalBool0, true);
				}
				break;
			}
			case DOTweenAnimationType.ShakeRotation:
				this.tween = base.transform.DOShakeRotation(this.duration, this.endValueV3, this.optionalInt0, this.optionalFloat0, true);
				break;
			case DOTweenAnimationType.ShakeScale:
				this.tween = base.transform.DOShakeScale(this.duration, this.endValueV3, this.optionalInt0, this.optionalFloat0, true);
				break;
			case DOTweenAnimationType.CameraAspect:
				this.tween = ((Camera)this.target).DOAspect(this.endValueFloat, this.duration);
				break;
			case DOTweenAnimationType.CameraBackgroundColor:
				this.tween = ((Camera)this.target).DOColor(this.endValueColor, this.duration);
				break;
			case DOTweenAnimationType.CameraFieldOfView:
				this.tween = ((Camera)this.target).DOFieldOfView(this.endValueFloat, this.duration);
				break;
			case DOTweenAnimationType.CameraOrthoSize:
				this.tween = ((Camera)this.target).DOOrthoSize(this.endValueFloat, this.duration);
				break;
			case DOTweenAnimationType.CameraPixelRect:
				this.tween = ((Camera)this.target).DOPixelRect(this.endValueRect, this.duration);
				break;
			case DOTweenAnimationType.CameraRect:
				this.tween = ((Camera)this.target).DORect(this.endValueRect, this.duration);
				break;
			case DOTweenAnimationType.UIWidthHeight:
				this.tween = ((RectTransform)this.target).DOSizeDelta(this.optionalBool0 ? new Vector2(this.endValueFloat, this.endValueFloat) : this.endValueV2, this.duration, false);
				break;
			}
			if (this.tween == null)
			{
				return;
			}
			if (this.isFrom)
			{
				((Tweener)this.tween).From(this.isRelative);
			}
			else
			{
				this.tween.SetRelative(this.isRelative);
			}
			this.tween.SetTarget(base.gameObject).SetDelay(this.delay).SetLoops(this.loops, this.loopType).SetAutoKill(this.autoKill).OnKill(delegate
			{
				this.tween = null;
			});
			if (this.isSpeedBased)
			{
				this.tween.SetSpeedBased<Tween>();
			}
			if (this.easeType == Ease.INTERNAL_Custom)
			{
				this.tween.SetEase(this.easeCurve);
			}
			else
			{
				this.tween.SetEase(this.easeType);
			}
			if (!string.IsNullOrEmpty(this.id))
			{
				this.tween.SetId(this.id);
			}
			this.tween.SetUpdate(this.isIndependentUpdate);
			if (this.hasOnStart)
			{
				if (this.onStart != null)
				{
					this.tween.OnStart(new TweenCallback(this.onStart.Invoke));
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
					this.tween.OnPlay(new TweenCallback(this.onPlay.Invoke));
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
					this.tween.OnUpdate(new TweenCallback(this.onUpdate.Invoke));
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
					this.tween.OnStepComplete(new TweenCallback(this.onStepComplete.Invoke));
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
					this.tween.OnComplete(new TweenCallback(this.onComplete.Invoke));
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
					this.tween.OnRewind(new TweenCallback(this.onRewind.Invoke));
				}
			}
			else
			{
				this.onRewind = null;
			}
			if (this.autoPlay)
			{
				this.tween.Play<Tween>();
			}
			else
			{
				this.tween.Pause<Tween>();
			}
			if (this.hasOnTweenCreated && this.onTweenCreated != null)
			{
				this.onTweenCreated.Invoke();
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000D961C File Offset: 0x000D781C
		public override void DOPlay()
		{
			DOTween.Play(base.gameObject);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000D962A File Offset: 0x000D782A
		public override void DOPlayBackwards()
		{
			DOTween.PlayBackwards(base.gameObject);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000D9638 File Offset: 0x000D7838
		public override void DOPlayForward()
		{
			DOTween.PlayForward(base.gameObject);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x000D9646 File Offset: 0x000D7846
		public override void DOPause()
		{
			DOTween.Pause(base.gameObject);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x000D9654 File Offset: 0x000D7854
		public override void DOTogglePause()
		{
			DOTween.TogglePause(base.gameObject);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000D9664 File Offset: 0x000D7864
		public override void DORewind()
		{
			this._playCount = -1;
			DOTweenAnimation[] components = base.gameObject.GetComponents<DOTweenAnimation>();
			for (int i = components.Length - 1; i > -1; i--)
			{
				Tween tween = components[i].tween;
				if (tween != null && tween.IsInitialized())
				{
					components[i].tween.Rewind(true);
				}
			}
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x000D96B8 File Offset: 0x000D78B8
		public override void DORestart(bool fromHere = false)
		{
			this._playCount = -1;
			if (this.tween == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(this.tween);
				}
				return;
			}
			if (fromHere && this.isRelative)
			{
				this.ReEvaluateRelativeTween();
			}
			DOTween.Restart(base.gameObject, true, -1f);
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x000D970B File Offset: 0x000D790B
		public override void DOComplete()
		{
			DOTween.Complete(base.gameObject, false);
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x000D971A File Offset: 0x000D791A
		public override void DOKill()
		{
			DOTween.Kill(base.gameObject, false);
			this.tween = null;
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x000D9730 File Offset: 0x000D7930
		public void DOPlayById(string id)
		{
			DOTween.Play(base.gameObject, id);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000D973F File Offset: 0x000D793F
		public void DOPlayAllById(string id)
		{
			DOTween.Play(id);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x000D9748 File Offset: 0x000D7948
		public void DOPauseAllById(string id)
		{
			DOTween.Pause(id);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x000D9751 File Offset: 0x000D7951
		public void DOPlayBackwardsById(string id)
		{
			DOTween.PlayBackwards(base.gameObject, id);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x000D9760 File Offset: 0x000D7960
		public void DOPlayBackwardsAllById(string id)
		{
			DOTween.PlayBackwards(id);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x000D9769 File Offset: 0x000D7969
		public void DOPlayForwardById(string id)
		{
			DOTween.PlayForward(base.gameObject, id);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x000D9778 File Offset: 0x000D7978
		public void DOPlayForwardAllById(string id)
		{
			DOTween.PlayForward(id);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x000D9784 File Offset: 0x000D7984
		public void DOPlayNext()
		{
			DOTweenAnimation[] components = base.GetComponents<DOTweenAnimation>();
			while (this._playCount < components.Length - 1)
			{
				this._playCount++;
				DOTweenAnimation dotweenAnimation = components[this._playCount];
				if (dotweenAnimation != null && dotweenAnimation.tween != null && !dotweenAnimation.tween.IsPlaying() && !dotweenAnimation.tween.IsComplete())
				{
					dotweenAnimation.tween.Play<Tween>();
					return;
				}
			}
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x000D97F6 File Offset: 0x000D79F6
		public void DORewindAndPlayNext()
		{
			this._playCount = -1;
			DOTween.Rewind(base.gameObject, true);
			this.DOPlayNext();
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000D9812 File Offset: 0x000D7A12
		public void DORestartById(string id)
		{
			this._playCount = -1;
			DOTween.Restart(base.gameObject, id, true, -1f);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000D982E File Offset: 0x000D7A2E
		public void DORestartAllById(string id)
		{
			this._playCount = -1;
			DOTween.Restart(id, true, -1f);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000D9844 File Offset: 0x000D7A44
		public List<Tween> GetTweens()
		{
			List<Tween> list = new List<Tween>();
			foreach (DOTweenAnimation dotweenAnimation in base.GetComponents<DOTweenAnimation>())
			{
				list.Add(dotweenAnimation.tween);
			}
			return list;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000D9880 File Offset: 0x000D7A80
		public static TargetType TypeToDOTargetType(Type t)
		{
			string text = t.ToString();
			int num = text.LastIndexOf(".");
			if (num != -1)
			{
				text = text.Substring(num + 1);
			}
			if (text.IndexOf("Renderer") != -1 && text != "SpriteRenderer")
			{
				text = "Renderer";
			}
			return (TargetType)Enum.Parse(typeof(TargetType), text);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000D98E4 File Offset: 0x000D7AE4
		private void ReEvaluateRelativeTween()
		{
			if (this.animationType == DOTweenAnimationType.Move)
			{
				((Tweener)this.tween).ChangeEndValue(base.transform.position + this.endValueV3, true);
				return;
			}
			if (this.animationType == DOTweenAnimationType.LocalMove)
			{
				((Tweener)this.tween).ChangeEndValue(base.transform.localPosition + this.endValueV3, true);
			}
		}

		// Token: 0x0400088F RID: 2191
		public float delay;

		// Token: 0x04000890 RID: 2192
		public float duration = 1f;

		// Token: 0x04000891 RID: 2193
		public Ease easeType = Ease.OutQuad;

		// Token: 0x04000892 RID: 2194
		public AnimationCurve easeCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000893 RID: 2195
		public LoopType loopType;

		// Token: 0x04000894 RID: 2196
		public int loops = 1;

		// Token: 0x04000895 RID: 2197
		public string id = "";

		// Token: 0x04000896 RID: 2198
		public bool isRelative;

		// Token: 0x04000897 RID: 2199
		public bool isFrom;

		// Token: 0x04000898 RID: 2200
		public bool isIndependentUpdate;

		// Token: 0x04000899 RID: 2201
		public bool autoKill = true;

		// Token: 0x0400089A RID: 2202
		public bool isActive = true;

		// Token: 0x0400089B RID: 2203
		public bool isValid;

		// Token: 0x0400089C RID: 2204
		public Component target;

		// Token: 0x0400089D RID: 2205
		public DOTweenAnimationType animationType;

		// Token: 0x0400089E RID: 2206
		public TargetType targetType;

		// Token: 0x0400089F RID: 2207
		public TargetType forcedTargetType;

		// Token: 0x040008A0 RID: 2208
		public bool autoPlay = true;

		// Token: 0x040008A1 RID: 2209
		public bool useTargetAsV3;

		// Token: 0x040008A2 RID: 2210
		public float endValueFloat;

		// Token: 0x040008A3 RID: 2211
		public Vector3 endValueV3;

		// Token: 0x040008A4 RID: 2212
		public Vector2 endValueV2;

		// Token: 0x040008A5 RID: 2213
		public Color endValueColor = new Color(1f, 1f, 1f, 1f);

		// Token: 0x040008A6 RID: 2214
		public string endValueString = "";

		// Token: 0x040008A7 RID: 2215
		public Rect endValueRect = new Rect(0f, 0f, 0f, 0f);

		// Token: 0x040008A8 RID: 2216
		public Transform endValueTransform;

		// Token: 0x040008A9 RID: 2217
		public bool optionalBool0;

		// Token: 0x040008AA RID: 2218
		public float optionalFloat0;

		// Token: 0x040008AB RID: 2219
		public int optionalInt0;

		// Token: 0x040008AC RID: 2220
		public RotateMode optionalRotationMode;

		// Token: 0x040008AD RID: 2221
		public ScrambleMode optionalScrambleMode;

		// Token: 0x040008AE RID: 2222
		public string optionalString;

		// Token: 0x040008AF RID: 2223
		private bool _tweenCreated;

		// Token: 0x040008B0 RID: 2224
		private int _playCount = -1;
	}
}
