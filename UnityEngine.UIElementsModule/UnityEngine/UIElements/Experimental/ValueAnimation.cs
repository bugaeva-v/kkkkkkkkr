using System;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x0200038C RID: 908
	public sealed class ValueAnimation<T> : IValueAnimationUpdate, IValueAnimation
	{
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x0008A464 File Offset: 0x00088664
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0008A47C File Offset: 0x0008867C
		public int durationMs
		{
			get
			{
				return this.m_DurationMs;
			}
			set
			{
				bool flag = value < 1;
				if (flag)
				{
					value = 1;
				}
				this.m_DurationMs = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x0008A49E File Offset: 0x0008869E
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0008A4A6 File Offset: 0x000886A6
		public Func<float, float> easingCurve { get; set; }

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x0008A4AF File Offset: 0x000886AF
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x0008A4B7 File Offset: 0x000886B7
		public bool isRunning { get; private set; }

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0008A4C0 File Offset: 0x000886C0
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0008A4C8 File Offset: 0x000886C8
		public Action onAnimationCompleted { get; set; }

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x0008A4D1 File Offset: 0x000886D1
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0008A4D9 File Offset: 0x000886D9
		public bool autoRecycle { get; set; }

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0008A4E2 File Offset: 0x000886E2
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0008A4EA File Offset: 0x000886EA
		private bool recycled { get; set; }

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0008A4F3 File Offset: 0x000886F3
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0008A4FB File Offset: 0x000886FB
		private VisualElement owner { get; set; }

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0008A504 File Offset: 0x00088704
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0008A50C File Offset: 0x0008870C
		public Action<VisualElement, T> valueUpdated { get; set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0008A515 File Offset: 0x00088715
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0008A51D File Offset: 0x0008871D
		public Func<VisualElement, T> initialValue { get; set; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0008A526 File Offset: 0x00088726
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0008A52E File Offset: 0x0008872E
		public Func<T, T, float, T> interpolator { get; set; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0008A538 File Offset: 0x00088738
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0008A586 File Offset: 0x00088786
		public T from
		{
			get
			{
				bool flag = !this.fromValueSet;
				if (flag)
				{
					bool flag2 = this.initialValue != null;
					if (flag2)
					{
						this.from = this.initialValue(this.owner);
					}
				}
				return this._from;
			}
			set
			{
				this.fromValueSet = true;
				this._from = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0008A597 File Offset: 0x00088797
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0008A59F File Offset: 0x0008879F
		public T to { get; set; }

		// Token: 0x06001D64 RID: 7524 RVA: 0x0008A5A8 File Offset: 0x000887A8
		public ValueAnimation()
		{
			this.SetDefaultValues();
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x0008A5C0 File Offset: 0x000887C0
		public void Start()
		{
			this.CheckNotRecycled();
			bool flag = this.owner != null;
			if (flag)
			{
				this.m_StartTimeMs = Panel.TimeSinceStartupMs();
				this.Register();
				this.isRunning = true;
			}
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x0008A600 File Offset: 0x00088800
		public void Stop()
		{
			this.CheckNotRecycled();
			bool isRunning = this.isRunning;
			if (isRunning)
			{
				this.Unregister();
				this.isRunning = false;
				Action onAnimationCompleted = this.onAnimationCompleted;
				if (onAnimationCompleted != null)
				{
					onAnimationCompleted();
				}
				bool autoRecycle = this.autoRecycle;
				if (autoRecycle)
				{
					bool flag = !this.recycled;
					if (flag)
					{
						this.Recycle();
					}
				}
			}
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0008A664 File Offset: 0x00088864
		public void Recycle()
		{
			this.CheckNotRecycled();
			bool isRunning = this.isRunning;
			if (isRunning)
			{
				bool flag = !this.autoRecycle;
				if (!flag)
				{
					this.Stop();
					return;
				}
				this.Stop();
			}
			this.SetDefaultValues();
			this.recycled = true;
			ValueAnimation<T>.sObjectPool.Release(this);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0008A6C4 File Offset: 0x000888C4
		void IValueAnimationUpdate.Tick(long currentTimeMs)
		{
			this.CheckNotRecycled();
			long num = currentTimeMs - this.m_StartTimeMs;
			float num2 = (float)num / (float)this.durationMs;
			bool flag = false;
			bool flag2 = num2 >= 1f;
			if (flag2)
			{
				num2 = 1f;
				flag = true;
			}
			Func<float, float> easingCurve = this.easingCurve;
			num2 = ((easingCurve != null) ? easingCurve(num2) : num2);
			bool flag3 = this.interpolator != null;
			if (flag3)
			{
				T arg = this.interpolator(this.from, this.to, num2);
				Action<VisualElement, T> valueUpdated = this.valueUpdated;
				if (valueUpdated != null)
				{
					valueUpdated(this.owner, arg);
				}
			}
			bool flag4 = flag;
			if (flag4)
			{
				this.Stop();
			}
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0008A774 File Offset: 0x00088974
		private void SetDefaultValues()
		{
			this.m_DurationMs = 400;
			this.autoRecycle = true;
			this.owner = null;
			this.m_StartTimeMs = 0L;
			this.onAnimationCompleted = null;
			this.valueUpdated = null;
			this.initialValue = null;
			this.interpolator = null;
			this.to = default(T);
			this.from = default(T);
			this.fromValueSet = false;
			this.easingCurve = new Func<float, float>(Easing.OutQuad);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0008A800 File Offset: 0x00088A00
		private void Unregister()
		{
			bool flag = this.owner != null;
			if (flag)
			{
				this.owner.UnregisterAnimation(this);
			}
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0008A82C File Offset: 0x00088A2C
		private void Register()
		{
			bool flag = this.owner != null;
			if (flag)
			{
				this.owner.RegisterAnimation(this);
			}
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0008A858 File Offset: 0x00088A58
		internal void SetOwner(VisualElement e)
		{
			bool isRunning = this.isRunning;
			if (isRunning)
			{
				this.Unregister();
			}
			this.owner = e;
			bool isRunning2 = this.isRunning;
			if (isRunning2)
			{
				this.Register();
			}
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x0008A894 File Offset: 0x00088A94
		private void CheckNotRecycled()
		{
			bool recycled = this.recycled;
			if (recycled)
			{
				throw new InvalidOperationException("Animation object has been recycled. Use KeepAlive() to keep a reference to an animation after it has been stopped.");
			}
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0008A8B8 File Offset: 0x00088AB8
		public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator)
		{
			ValueAnimation<T> valueAnimation = ValueAnimation<T>.sObjectPool.Get();
			valueAnimation.recycled = false;
			valueAnimation.SetOwner(e);
			valueAnimation.interpolator = interpolator;
			return valueAnimation;
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0008A8F0 File Offset: 0x00088AF0
		public ValueAnimation<T> Ease(Func<float, float> easing)
		{
			this.easingCurve = easing;
			return this;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0008A90C File Offset: 0x00088B0C
		public ValueAnimation<T> OnCompleted(Action callback)
		{
			this.onAnimationCompleted = callback;
			return this;
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0008A928 File Offset: 0x00088B28
		public ValueAnimation<T> KeepAlive()
		{
			this.autoRecycle = false;
			return this;
		}

		// Token: 0x04000EA2 RID: 3746
		private const int k_DefaultDurationMs = 400;

		// Token: 0x04000EA3 RID: 3747
		private const int k_DefaultMaxPoolSize = 100;

		// Token: 0x04000EA4 RID: 3748
		private long m_StartTimeMs;

		// Token: 0x04000EA5 RID: 3749
		private int m_DurationMs;

		// Token: 0x04000EAB RID: 3755
		private static ObjectPool<ValueAnimation<T>> sObjectPool = new ObjectPool<ValueAnimation<T>>(100);

		// Token: 0x04000EB0 RID: 3760
		private T _from;

		// Token: 0x04000EB1 RID: 3761
		private bool fromValueSet = false;
	}
}
