using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002F RID: 47
	public class FocusChangeDirection : IDisposable
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00005EA7 File Offset: 0x000040A7
		public static FocusChangeDirection unspecified { get; } = new FocusChangeDirection(-1);

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00005EAE File Offset: 0x000040AE
		public static FocusChangeDirection none { get; } = new FocusChangeDirection(0);

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00005EB5 File Offset: 0x000040B5
		protected static FocusChangeDirection lastValue { get; } = FocusChangeDirection.none;

		// Token: 0x0600012A RID: 298 RVA: 0x00005EBC File Offset: 0x000040BC
		protected FocusChangeDirection(int value)
		{
			this.m_Value = value;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005ED0 File Offset: 0x000040D0
		public static implicit operator int(FocusChangeDirection fcd)
		{
			return (fcd != null) ? fcd.m_Value : 0;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005EEE File Offset: 0x000040EE
		void IDisposable.Dispose()
		{
			this.Dispose();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002166 File Offset: 0x00000366
		protected virtual void Dispose()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005EF7 File Offset: 0x000040F7
		internal virtual void ApplyTo(FocusController focusController, Focusable f)
		{
			focusController.SwitchFocus(f, this, false, DispatchMode.Default);
		}

		// Token: 0x04000087 RID: 135
		private readonly int m_Value;
	}
}
