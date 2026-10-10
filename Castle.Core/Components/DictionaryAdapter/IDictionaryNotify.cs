using System;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200012A RID: 298
	public interface IDictionaryNotify : INotifyPropertyChanging, INotifyPropertyChanged
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000805 RID: 2053
		bool CanNotify { get; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000806 RID: 2054
		bool ShouldNotify { get; }

		// Token: 0x06000807 RID: 2055
		IDisposable SuppressNotificationsBlock();

		// Token: 0x06000808 RID: 2056
		void SuppressNotifications();

		// Token: 0x06000809 RID: 2057
		void ResumeNotifications();
	}
}
