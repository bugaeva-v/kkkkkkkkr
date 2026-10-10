using System;

namespace UnityEngine.Playables
{
	// Token: 0x0200043A RID: 1082
	public class Notification : INotification
	{
		// Token: 0x06002590 RID: 9616 RVA: 0x0003F6A9 File Offset: 0x0003D8A9
		public Notification(string name)
		{
			this.id = new PropertyName(name);
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x0003F6BF File Offset: 0x0003D8BF
		public PropertyName id { get; }
	}
}
