using System;
using System.Security.Permissions;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет данные для события <see cref="E:Microsoft.Win32.SystemEvents.UserPreferenceChanged" />.</summary>
	// Token: 0x0200012E RID: 302
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public class UserPreferenceChangedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.UserPreferenceChangedEventArgs" />, используя заданный идентификатор категории пользовательских параметров.</summary>
		/// <param name="category">Одно из значений <see cref="T:Microsoft.Win32.UserPreferenceCategory" />, показывающих измененную категорию пользовательских параметров.</param>
		// Token: 0x06000707 RID: 1799 RVA: 0x0001385E File Offset: 0x00011A5E
		public UserPreferenceChangedEventArgs(UserPreferenceCategory category)
		{
			this.mycategory = category;
		}

		/// <summary>Возвращает измененную категорию пользовательских параметров.</summary>
		/// <returns>Одно из значений <see cref="T:Microsoft.Win32.UserPreferenceCategory" />, показывающих измененную категорию пользовательских параметров.</returns>
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0001386D File Offset: 0x00011A6D
		public UserPreferenceCategory Category
		{
			get
			{
				return this.mycategory;
			}
		}

		// Token: 0x040004F5 RID: 1269
		private UserPreferenceCategory mycategory;
	}
}
