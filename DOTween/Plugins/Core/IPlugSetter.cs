using System;
using DG.Tweening.Core;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x0200003C RID: 60
	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions>
	{
		// Token: 0x06000219 RID: 537
		DOGetter<T1> Getter();

		// Token: 0x0600021A RID: 538
		DOSetter<T1> Setter();

		// Token: 0x0600021B RID: 539
		T2 EndValue();

		// Token: 0x0600021C RID: 540
		TPlugOptions GetOptions();
	}
}
