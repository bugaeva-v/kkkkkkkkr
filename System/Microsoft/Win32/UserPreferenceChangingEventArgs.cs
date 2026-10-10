using System;
using System.Security.Permissions;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет данные для события <see cref="E:Microsoft.Win32.SystemEvents.UserPreferenceChanging" />.</summary>
	// Token: 0x02000130 RID: 304
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public class UserPreferenceChangingEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.UserPreferenceChangingEventArgs" />, используя заданный идентификатор категории пользовательских параметров.</summary>
		/// <param name="category">Одно из значений <see cref="T:Microsoft.Win32.UserPreferenceCategory" />, показывающих изменяемую категорию пользовательских параметров.</param>
		// Token: 0x0600070D RID: 1805 RVA: 0x00013875 File Offset: 0x00011A75
		public UserPreferenceChangingEventArgs(UserPreferenceCategory category)
		{
			this.mycategory = category;
		}

		/// <summary>Возвращает категорию изменяемых пользовательских параметров.</summary>
		/// <returns>Одно из значений <see cref="T:Microsoft.Win32.UserPreferenceCategory" />, показывающих изменяемую категорию пользовательских параметров.</returns>
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00013884 File Offset: 0x00011A84
		public UserPreferenceCategory Category
		{
			get
			{
				return this.mycategory;
			}
		}

		// Token: 0x040004F6 RID: 1270
		private UserPreferenceCategory mycategory;
	}
}
