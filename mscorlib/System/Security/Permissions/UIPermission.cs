using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Управляет разрешениями, относящимися к пользовательским интерфейсам и буферу обмена. Этот класс не наследуется.</summary>
	// Token: 0x02000460 RID: 1120
	[ComVisible(true)]
	[Serializable]
	public sealed class UIPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.UIPermission" /> указанным состоянием доступа: полностью ограниченный или неограниченный.</summary>
		/// <param name="state">Одно из значений перечисления.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002D81 RID: 11649 RVA: 0x000A3211 File Offset: 0x000A1411
		public UIPermission(PermissionState state)
		{
			if (CodeAccessPermission.CheckPermissionState(state, true) == PermissionState.Unrestricted)
			{
				this._clipboard = UIPermissionClipboard.AllClipboard;
				this._window = UIPermissionWindow.AllWindows;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.UIPermission" /> с доступом к буферу обмена и без доступа к окнам.</summary>
		/// <param name="clipboardFlag">Одно из значений перечисления.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="clipboardFlag" /> не является допустимым значением <see cref="T:System.Security.Permissions.UIPermissionClipboard" />.</exception>
		// Token: 0x06002D82 RID: 11650 RVA: 0x000A3231 File Offset: 0x000A1431
		public UIPermission(UIPermissionClipboard clipboardFlag)
		{
			this.Clipboard = clipboardFlag;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.UIPermission" /> с доступом к окнам и без доступа к буферу обмена.</summary>
		/// <param name="windowFlag">Одно из значений перечисления.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="windowFlag" /> не является допустимым значением <see cref="T:System.Security.Permissions.UIPermissionWindow" />.</exception>
		// Token: 0x06002D83 RID: 11651 RVA: 0x000A3240 File Offset: 0x000A1440
		public UIPermission(UIPermissionWindow windowFlag)
		{
			this.Window = windowFlag;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.UIPermission" /> указанными разрешениями для доступа к окнам и буферу обмена.</summary>
		/// <param name="windowFlag">Одно из значений перечисления.</param>
		/// <param name="clipboardFlag">Одно из значений перечисления.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="windowFlag" /> не является допустимым значением <see cref="T:System.Security.Permissions.UIPermissionWindow" />.  
		///
		/// или - 
		/// Параметр <paramref name="clipboardFlag" /> не является допустимым значением <see cref="T:System.Security.Permissions.UIPermissionClipboard" />.</exception>
		// Token: 0x06002D84 RID: 11652 RVA: 0x000A324F File Offset: 0x000A144F
		public UIPermission(UIPermissionWindow windowFlag, UIPermissionClipboard clipboardFlag)
		{
			this.Clipboard = clipboardFlag;
			this.Window = windowFlag;
		}

		/// <summary>Получает или задает уровень доступа к буферу обмена, представленный разрешением.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.Permissions.UIPermissionClipboard" />.</returns>
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000A3265 File Offset: 0x000A1465
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x000A326D File Offset: 0x000A146D
		public UIPermissionClipboard Clipboard
		{
			get
			{
				return this._clipboard;
			}
			set
			{
				if (!Enum.IsDefined(typeof(UIPermissionClipboard), value))
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), value), "UIPermissionClipboard");
				}
				this._clipboard = value;
			}
		}

		/// <summary>Возвращает или задает уровень доступа к окну, представленный разрешением.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.Permissions.UIPermissionWindow" />.</returns>
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002D87 RID: 11655 RVA: 0x000A32AD File Offset: 0x000A14AD
		// (set) Token: 0x06002D88 RID: 11656 RVA: 0x000A32B5 File Offset: 0x000A14B5
		public UIPermissionWindow Window
		{
			get
			{
				return this._window;
			}
			set
			{
				if (!Enum.IsDefined(typeof(UIPermissionWindow), value))
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), value), "UIPermissionWindow");
				}
				this._window = value;
			}
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002D89 RID: 11657 RVA: 0x000A32F5 File Offset: 0x000A14F5
		public override IPermission Copy()
		{
			return new UIPermission(this._window, this._clipboard);
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="esd" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="esd" /> не является допустимым элементом разрешения.  
		///
		/// или - 
		/// Недопустимый номер версии параметра <paramref name="esd" />.</exception>
		// Token: 0x06002D8A RID: 11658 RVA: 0x000A3308 File Offset: 0x000A1508
		public override void FromXml(SecurityElement esd)
		{
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			if (CodeAccessPermission.IsUnrestricted(esd))
			{
				this._window = UIPermissionWindow.AllWindows;
				this._clipboard = UIPermissionClipboard.AllClipboard;
				return;
			}
			string text = esd.Attribute("Window");
			if (text == null)
			{
				this._window = UIPermissionWindow.NoWindows;
			}
			else
			{
				this._window = (UIPermissionWindow)Enum.Parse(typeof(UIPermissionWindow), text);
			}
			string text2 = esd.Attribute("Clipboard");
			if (text2 == null)
			{
				this._clipboard = UIPermissionClipboard.NoClipboard;
				return;
			}
			this._clipboard = (UIPermissionClipboard)Enum.Parse(typeof(UIPermissionClipboard), text2);
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002D8B RID: 11659 RVA: 0x000A33A0 File Offset: 0x000A15A0
		public override IPermission Intersect(IPermission target)
		{
			UIPermission uipermission = this.Cast(target);
			if (uipermission == null)
			{
				return null;
			}
			UIPermissionWindow uipermissionWindow = (this._window < uipermission._window) ? this._window : uipermission._window;
			UIPermissionClipboard uipermissionClipboard = (this._clipboard < uipermission._clipboard) ? this._clipboard : uipermission._clipboard;
			if (this.IsEmpty(uipermissionWindow, uipermissionClipboard))
			{
				return null;
			}
			return new UIPermission(uipermissionWindow, uipermissionClipboard);
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение на проверку наличия связи подмножеств. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002D8C RID: 11660 RVA: 0x000A3408 File Offset: 0x000A1608
		public override bool IsSubsetOf(IPermission target)
		{
			UIPermission uipermission = this.Cast(target);
			if (uipermission == null)
			{
				return this.IsEmpty(this._window, this._clipboard);
			}
			return uipermission.IsUnrestricted() || (this._window <= uipermission._window && this._clipboard <= uipermission._clipboard);
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002D8D RID: 11661 RVA: 0x000A345E File Offset: 0x000A165E
		public bool IsUnrestricted()
		{
			return this._window == UIPermissionWindow.AllWindows && this._clipboard == UIPermissionClipboard.AllClipboard;
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002D8E RID: 11662 RVA: 0x000A3474 File Offset: 0x000A1674
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (this._window == UIPermissionWindow.AllWindows && this._clipboard == UIPermissionClipboard.AllClipboard)
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			else
			{
				if (this._window != UIPermissionWindow.NoWindows)
				{
					securityElement.AddAttribute("Window", this._window.ToString());
				}
				if (this._clipboard != UIPermissionClipboard.NoClipboard)
				{
					securityElement.AddAttribute("Clipboard", this._clipboard.ToString());
				}
			}
			return securityElement;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002D8F RID: 11663 RVA: 0x000A34F8 File Offset: 0x000A16F8
		public override IPermission Union(IPermission target)
		{
			UIPermission uipermission = this.Cast(target);
			if (uipermission == null)
			{
				return this.Copy();
			}
			UIPermissionWindow uipermissionWindow = (this._window > uipermission._window) ? this._window : uipermission._window;
			UIPermissionClipboard uipermissionClipboard = (this._clipboard > uipermission._clipboard) ? this._clipboard : uipermission._clipboard;
			if (this.IsEmpty(uipermissionWindow, uipermissionClipboard))
			{
				return null;
			}
			return new UIPermission(uipermissionWindow, uipermissionClipboard);
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x0003227E File Offset: 0x0003047E
		int IBuiltInPermission.GetTokenIndex()
		{
			return 7;
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000A3564 File Offset: 0x000A1764
		private bool IsEmpty(UIPermissionWindow w, UIPermissionClipboard c)
		{
			return w == UIPermissionWindow.NoWindows && c == UIPermissionClipboard.NoClipboard;
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000A356F File Offset: 0x000A176F
		private UIPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			UIPermission uipermission = target as UIPermission;
			if (uipermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(UIPermission));
			}
			return uipermission;
		}

		// Token: 0x040020B8 RID: 8376
		private UIPermissionWindow _window;

		// Token: 0x040020B9 RID: 8377
		private UIPermissionClipboard _clipboard;

		// Token: 0x040020BA RID: 8378
		private const int version = 1;
	}
}
