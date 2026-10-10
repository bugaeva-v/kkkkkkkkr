using System;

namespace System.Configuration.Internal
{
	/// <summary>Определяет класс, который позволяет инфраструктуре платформы .NET Framework определить аргументы события для событий конфигурации.</summary>
	// Token: 0x02000086 RID: 134
	public sealed class InternalConfigEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.Internal.InternalConfigEventArgs" />.</summary>
		/// <param name="configPath">Путь конфигурации.</param>
		// Token: 0x06000481 RID: 1153 RVA: 0x0000B3F3 File Offset: 0x000095F3
		public InternalConfigEventArgs(string configPath)
		{
			this.configPath = configPath;
		}

		/// <summary>Возвращает или устанавливает путь конфигурации, относительно объекта <see cref="T:System.Configuration.Internal.InternalConfigEventArgs" />.</summary>
		/// <returns>Значение строки, определяющее путь конфигурации.</returns>
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0000B402 File Offset: 0x00009602
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x0000B40A File Offset: 0x0000960A
		public string ConfigPath
		{
			get
			{
				return this.configPath;
			}
			set
			{
				this.configPath = value;
			}
		}

		// Token: 0x04000167 RID: 359
		private string configPath;
	}
}
