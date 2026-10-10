using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Предоставляет многоуровневый переключатель для управления выводом трассировки и отладки без повторной компиляции кода.</summary>
	// Token: 0x02000236 RID: 566
	[SwitchLevel(typeof(TraceLevel))]
	public class TraceSwitch : Switch
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TraceSwitch" />, используя указанные отображаемое имя и описание.</summary>
		/// <param name="displayName">Имя, отображаемое в интерфейсе пользователя.</param>
		/// <param name="description">Описание переключателя.</param>
		// Token: 0x060010FD RID: 4349 RVA: 0x00044ADF File Offset: 0x00042CDF
		public TraceSwitch(string displayName, string description) : base(displayName, description)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TraceSwitch" />, используя указанные отображаемое имя, описание и значение по умолчанию переключателя.</summary>
		/// <param name="displayName">Имя, отображаемое в интерфейсе пользователя.</param>
		/// <param name="description">Описание переключателя.</param>
		/// <param name="defaultSwitchValue">Значение по умолчанию переключателя.</param>
		// Token: 0x060010FE RID: 4350 RVA: 0x00044AE9 File Offset: 0x00042CE9
		public TraceSwitch(string displayName, string description, string defaultSwitchValue) : base(displayName, description, defaultSwitchValue)
		{
		}

		/// <summary>Получает или задает уровень трассировки, которым определяются сообщения, активируемые переключателем.</summary>
		/// <returns>Один из <see cref="T:System.Diagnostics.TraceLevel" /> значений, определяющее уровень сообщений, которые допускаются переключателя.</returns>
		/// <exception cref="T:System.ArgumentException">Для свойства <see cref="P:System.Diagnostics.TraceSwitch.Level" /> установлено значение, которое не является одним из значений <see cref="T:System.Diagnostics.TraceLevel" />.</exception>
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0004647C File Offset: 0x0004467C
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0004A759 File Offset: 0x00048959
		public TraceLevel Level
		{
			get
			{
				return (TraceLevel)base.SwitchSetting;
			}
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				if (value < TraceLevel.Off || value > TraceLevel.Verbose)
				{
					throw new ArgumentException(SR.GetString("The Level must be set to a value in the enumeration TraceLevel."));
				}
				base.SwitchSetting = (int)value;
			}
		}

		/// <summary>Получает значение, указывающее, активирует ли переключатель сообщения обработки ошибок.</summary>
		/// <returns>Значение <see langword="true" />, если для свойства <see cref="P:System.Diagnostics.TraceSwitch.Level" /> задано значение <see cref="F:System.Diagnostics.TraceLevel.Error" />, <see cref="F:System.Diagnostics.TraceLevel.Warning" />, <see cref="F:System.Diagnostics.TraceLevel.Info" /> или <see cref="F:System.Diagnostics.TraceLevel.Verbose" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0004A77A File Offset: 0x0004897A
		public bool TraceError
		{
			get
			{
				return this.Level >= TraceLevel.Error;
			}
		}

		/// <summary>Получает значение, указывающее, активирует ли переключатель предупреждающие сообщения.</summary>
		/// <returns>Значение <see langword="true" />, если для свойства <see cref="P:System.Diagnostics.TraceSwitch.Level" /> задано значение <see cref="F:System.Diagnostics.TraceLevel.Warning" />, <see cref="F:System.Diagnostics.TraceLevel.Info" /> или <see cref="F:System.Diagnostics.TraceLevel.Verbose" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0004A788 File Offset: 0x00048988
		public bool TraceWarning
		{
			get
			{
				return this.Level >= TraceLevel.Warning;
			}
		}

		/// <summary>Получает значение, указывающее, активирует ли переключатель информационные сообщения.</summary>
		/// <returns>Значение <see langword="true" />, если для свойства <see cref="P:System.Diagnostics.TraceSwitch.Level" /> задано значение <see cref="F:System.Diagnostics.TraceLevel.Info" /> или <see cref="F:System.Diagnostics.TraceLevel.Verbose" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0004A796 File Offset: 0x00048996
		public bool TraceInfo
		{
			get
			{
				return this.Level >= TraceLevel.Info;
			}
		}

		/// <summary>Получает значение, указывающее, активирует ли переключатель все сообщения.</summary>
		/// <returns>Значение <see langword="true" />, если для свойства <see cref="P:System.Diagnostics.TraceSwitch.Level" /> задано значение <see cref="F:System.Diagnostics.TraceLevel.Verbose" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0004A7A4 File Offset: 0x000489A4
		public bool TraceVerbose
		{
			get
			{
				return this.Level == TraceLevel.Verbose;
			}
		}

		/// <summary>Обновляет и исправляет уровень для данного переключателя.</summary>
		// Token: 0x06001105 RID: 4357 RVA: 0x0004A7B0 File Offset: 0x000489B0
		protected override void OnSwitchSettingChanged()
		{
			int switchSetting = base.SwitchSetting;
			if (switchSetting < 0)
			{
				base.SwitchSetting = 0;
				return;
			}
			if (switchSetting > 4)
			{
				base.SwitchSetting = 4;
			}
		}

		/// <summary>Присваивает свойству <see cref="P:System.Diagnostics.Switch.SwitchSetting" /> целочисленный эквивалент свойства <see cref="P:System.Diagnostics.Switch.Value" />.</summary>
		// Token: 0x06001106 RID: 4358 RVA: 0x0004A7DB File Offset: 0x000489DB
		protected override void OnValueChanged()
		{
			base.SwitchSetting = (int)Enum.Parse(typeof(TraceLevel), base.Value, true);
		}
	}
}
