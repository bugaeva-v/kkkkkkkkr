using System;
using System.ComponentModel;

namespace System.Configuration
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Configuration.ApplicationSettingsBase.SettingChanging" />.</summary>
	// Token: 0x020001BD RID: 445
	public class SettingChangingEventArgs : CancelEventArgs
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.Configuration.SettingChangingEventArgs" />.</summary>
		/// <param name="settingName">Объект <see cref="T:System.String" />, содержащий имя параметра приложения.</param>
		/// <param name="settingClass">Объект <see cref="T:System.String" />, содержащий описание категории параметра. Данный параметр часто задается для имени группы параметров приложения.</param>
		/// <param name="settingKey">Объект <see cref="T:System.String" />, содержащий ключ параметров приложения.</param>
		/// <param name="newValue">Объект <see cref="T:System.Object" />, содержащий новое значение, которое будет назначено свойству параметров приложения.</param>
		/// <param name="cancel">
		///   <see langword="true" /> для отмены события; в противном случае — <see langword="false" />.</param>
		// Token: 0x06000BA9 RID: 2985 RVA: 0x000314CE File Offset: 0x0002F6CE
		public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel) : base(cancel)
		{
			this.settingName = settingName;
			this.settingClass = settingClass;
			this.settingKey = settingKey;
			this.newValue = newValue;
		}

		/// <summary>Возвращает имя параметра приложения, связанное со свойством параметров приложения.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя параметра приложения.</returns>
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x000314F5 File Offset: 0x0002F6F5
		public string SettingName
		{
			get
			{
				return this.settingName;
			}
		}

		/// <summary>Возвращает категорию свойства параметров приложения.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий описание категории параметра. Этот параметр часто задается для имени группы параметров приложения.</returns>
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x000314FD File Offset: 0x0002F6FD
		public string SettingClass
		{
			get
			{
				return this.settingClass;
			}
		}

		/// <summary>Возвращает ключ параметров приложения, связанный со свойством.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий ключ параметров приложения.</returns>
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00031505 File Offset: 0x0002F705
		public string SettingKey
		{
			get
			{
				return this.settingKey;
			}
		}

		/// <summary>Возвращает новое значение, которое будет назначено свойству параметров приложения.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий новое значение, которое будет назначено свойству параметров приложения.</returns>
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0003150D File Offset: 0x0002F70D
		public object NewValue
		{
			get
			{
				return this.newValue;
			}
		}

		// Token: 0x04000786 RID: 1926
		private string settingName;

		// Token: 0x04000787 RID: 1927
		private string settingClass;

		// Token: 0x04000788 RID: 1928
		private string settingKey;

		// Token: 0x04000789 RID: 1929
		private object newValue;
	}
}
