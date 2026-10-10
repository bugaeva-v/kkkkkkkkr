using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Предоставляет простой выключатель, управляющий результатами отладки и трассировки.</summary>
	// Token: 0x02000212 RID: 530
	[SwitchLevel(typeof(bool))]
	public class BooleanSwitch : Switch
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.BooleanSwitch" /> заданным отображаемым именем и описанием.</summary>
		/// <param name="displayName">Имя, отображаемое в интерфейсе пользователя.</param>
		/// <param name="description">Описание переключателя.</param>
		// Token: 0x06000F47 RID: 3911 RVA: 0x00044ADF File Offset: 0x00042CDF
		public BooleanSwitch(string displayName, string description) : base(displayName, description)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.BooleanSwitch" /> указанным отображаемым именем, описанием и операцией и значением переключателя по умолчанию.</summary>
		/// <param name="displayName">Имя, отображаемое в интерфейсе пользователя.</param>
		/// <param name="description">Описание переключателя.</param>
		/// <param name="defaultSwitchValue">Значение по умолчанию переключателя.</param>
		// Token: 0x06000F48 RID: 3912 RVA: 0x00044AE9 File Offset: 0x00042CE9
		public BooleanSwitch(string displayName, string description, string defaultSwitchValue) : base(displayName, description, defaultSwitchValue)
		{
		}

		/// <summary>Возвращает или задает значение, указывающее, включен или отключен параметр.</summary>
		/// <returns>Значение <see langword="true" />, если параметр включен; в противном случае — значение <see langword="false" />. Значение по умолчанию: <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует правильное разрешение.</exception>
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00044AF4 File Offset: 0x00042CF4
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00044B01 File Offset: 0x00042D01
		public bool Enabled
		{
			get
			{
				return base.SwitchSetting != 0;
			}
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				base.SwitchSetting = (value ? 1 : 0);
			}
		}

		/// <summary>Определяет, можно ли проанализировать новое значение свойства <see cref="P:System.Diagnostics.Switch.Value" /> как логическое значение.</summary>
		// Token: 0x06000F4B RID: 3915 RVA: 0x00044B10 File Offset: 0x00042D10
		protected override void OnValueChanged()
		{
			bool flag;
			if (bool.TryParse(base.Value, out flag))
			{
				base.SwitchSetting = (flag ? 1 : 0);
				return;
			}
			base.OnValueChanged();
		}
	}
}
