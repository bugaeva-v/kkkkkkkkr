using System;
using Unity;

namespace System.Configuration
{
	/// <summary>Определяет сопоставление файла конфигурации для EXE-файла приложения. Этот класс не наследуется.</summary>
	// Token: 0x02000040 RID: 64
	public sealed class ExeConfigurationFileMap : ConfigurationFileMap
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ExeConfigurationFileMap" />.</summary>
		// Token: 0x06000233 RID: 563 RVA: 0x00007944 File Offset: 0x00005B44
		public ExeConfigurationFileMap()
		{
			this.exeConfigFilename = "";
			this.localUserConfigFilename = "";
			this.roamingUserConfigFilename = "";
		}

		/// <summary>Получает или задает имя файла конфигурации.</summary>
		/// <returns>Имя файла конфигурации.</returns>
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000796D File Offset: 0x00005B6D
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00007975 File Offset: 0x00005B75
		public string ExeConfigFilename
		{
			get
			{
				return this.exeConfigFilename;
			}
			set
			{
				this.exeConfigFilename = value;
			}
		}

		/// <summary>Возвращает или задает имя файла конфигурации для локального пользователя.</summary>
		/// <returns>Имя файла конфигурации.</returns>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000797E File Offset: 0x00005B7E
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00007986 File Offset: 0x00005B86
		public string LocalUserConfigFilename
		{
			get
			{
				return this.localUserConfigFilename;
			}
			set
			{
				this.localUserConfigFilename = value;
			}
		}

		/// <summary>Возвращает или задает имя файла конфигурации для перемещаемого пользователя.</summary>
		/// <returns>Имя файла конфигурации.</returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000798F File Offset: 0x00005B8F
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00007997 File Offset: 0x00005B97
		public string RoamingUserConfigFilename
		{
			get
			{
				return this.roamingUserConfigFilename;
			}
			set
			{
				this.roamingUserConfigFilename = value;
			}
		}

		/// <summary>Создает копию существующего объекта <see cref="T:System.Configuration.ExeConfigurationFileMap" />.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.ExeConfigurationFileMap" />.</returns>
		// Token: 0x0600023A RID: 570 RVA: 0x000079A0 File Offset: 0x00005BA0
		public override object Clone()
		{
			return new ExeConfigurationFileMap
			{
				exeConfigFilename = this.exeConfigFilename,
				localUserConfigFilename = this.localUserConfigFilename,
				roamingUserConfigFilename = this.roamingUserConfigFilename,
				MachineConfigFilename = base.MachineConfigFilename
			};
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ExeConfigurationFileMap" />, используя заданное имя файла конфигурации компьютера.</summary>
		/// <param name="machineConfigFileName">Имя файла конфигурации компьютера, которое содержит полный физический путь (например, <c>c:\Windows\Microsoft.NET\Framework\v2.0.50727\CONFIG\machine.config</c>).</param>
		// Token: 0x0600023B RID: 571 RVA: 0x00003518 File Offset: 0x00001718
		public ExeConfigurationFileMap(string machineConfigFileName)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040000E5 RID: 229
		private string exeConfigFilename;

		// Token: 0x040000E6 RID: 230
		private string localUserConfigFilename;

		// Token: 0x040000E7 RID: 231
		private string roamingUserConfigFilename;
	}
}
