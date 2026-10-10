using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022E RID: 558
	public abstract class TransitionEventBase<T> : EventBase<T>, ITransitionEvent where T : TransitionEventBase<T>, new()
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0004356B File Offset: 0x0004176B
		public StylePropertyNameCollection stylePropertyNames { get; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00043573 File Offset: 0x00041773
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x0004357B File Offset: 0x0004177B
		public double elapsedTime { get; protected set; }

		// Token: 0x060010F8 RID: 4344 RVA: 0x00043584 File Offset: 0x00041784
		protected TransitionEventBase()
		{
			this.stylePropertyNames = new StylePropertyNameCollection(new List<StylePropertyName>());
			this.LocalInit();
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x000435A5 File Offset: 0x000417A5
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x000435B6 File Offset: 0x000417B6
		private void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.Bubbles;
			base.propagateToIMGUI = false;
			this.stylePropertyNames.propertiesList.Clear();
			this.elapsedTime = 0.0;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000435EC File Offset: 0x000417EC
		public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.stylePropertyNames.propertiesList.Add(stylePropertyName);
			pooled.elapsedTime = elapsedTime;
			return pooled;
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0004362C File Offset: 0x0004182C
		public bool AffectsProperty(StylePropertyName stylePropertyName)
		{
			return this.stylePropertyNames.Contains(stylePropertyName);
		}
	}
}
