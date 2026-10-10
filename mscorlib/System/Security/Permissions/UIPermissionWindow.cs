using System;

namespace System.Security.Permissions
{
	/// <summary>Указывает тип окон, которые могут использоваться кодом.</summary>
	// Token: 0x02000431 RID: 1073
	public enum UIPermissionWindow
	{
		/// <summary>Пользователи могут использовать все окна и события пользовательского ввода без каких-либо ограничений.</summary>
		// Token: 0x04002000 RID: 8192
		AllWindows = 3,
		/// <summary>Пользователи не могут использовать никакие окна и события пользовательского интерфейса. Пользовательский интерфейс использовать нельзя.</summary>
		// Token: 0x04002001 RID: 8193
		NoWindows = 0,
		/// <summary>Пользователи могут использовать для рисования только <see cref="F:System.Security.Permissions.UIPermissionWindow.SafeSubWindows" />; события пользовательского ввода для интерфейса пользователя могут быть использованы только в этом дочернем окне. Примерами <see cref="F:System.Security.Permissions.UIPermissionWindow.SafeSubWindows" /> могут служить <see cref="T:System.Windows.Forms.MessageBox" />, общие элементы управления диалоговых окон и элемент управления, отображаемый в браузере.</summary>
		// Token: 0x04002002 RID: 8194
		SafeSubWindows,
		/// <summary>Пользователи могут применять для рисования только <see cref="F:System.Security.Permissions.UIPermissionWindow.SafeTopLevelWindows" /> и <see cref="F:System.Security.Permissions.UIPermissionWindow.SafeSubWindows" />; события пользовательского ввода для пользовательского интерфейса можно применять только в этих окнах верхнего уровня и подокнах.</summary>
		// Token: 0x04002003 RID: 8195
		SafeTopLevelWindows
	}
}
