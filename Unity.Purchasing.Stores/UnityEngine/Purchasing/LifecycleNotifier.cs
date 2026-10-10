using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000048 RID: 72
	internal class LifecycleNotifier : MonoBehaviour
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x000073C6 File Offset: 0x000055C6
		private void OnDestroy()
		{
			Action onDestroyCallback = this.OnDestroyCallback;
			if (onDestroyCallback == null)
			{
				return;
			}
			onDestroyCallback();
		}

		// Token: 0x040000A8 RID: 168
		public Action OnDestroyCallback;
	}
}
