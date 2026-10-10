using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E6 RID: 486
	public class FocusEvent : FocusEventBase<FocusEvent>
	{
		// Token: 0x06000F66 RID: 3942 RVA: 0x0003F515 File Offset: 0x0003D715
		protected internal override void PreDispatch(IPanel panel)
		{
			base.PreDispatch(panel);
			base.focusController.DoFocusChange(base.target as Focusable);
		}
	}
}
