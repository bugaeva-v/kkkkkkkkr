using System;
using System.Runtime.Serialization;

namespace System.Configuration.Provider
{
	/// <summary>При возникновении ошибки в поставщике конфигурации создается исключение. Этот класс исключения также используется поставщиком для создания исключений при возникновении внутренних ошибок с поставщиком, который не сопоставлен с другими существующими классами исключений.</summary>
	// Token: 0x02000079 RID: 121
	[Serializable]
	public class ProviderException : Exception
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Configuration.Provider.ProviderException" />.</summary>
		// Token: 0x060003F4 RID: 1012 RVA: 0x0000B15D File Offset: 0x0000935D
		public ProviderException()
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Configuration.Provider.ProviderException" />.</summary>
		/// <param name="info">Объект, содержащий сведения о выполнении десериализации.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060003F5 RID: 1013 RVA: 0x0000B165 File Offset: 0x00009365
		protected ProviderException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Configuration.Provider.ProviderException" />.</summary>
		/// <param name="message">Создано сообщение, описывающее причину возникновения <see cref="T:System.Configuration.Provider.ProviderException" />.</param>
		// Token: 0x060003F6 RID: 1014 RVA: 0x0000B16F File Offset: 0x0000936F
		public ProviderException(string message) : base(message)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Configuration.Provider.ProviderException" />.</summary>
		/// <param name="message">Создано сообщение, описывающее причину возникновения <see cref="T:System.Configuration.Provider.ProviderException" />.</param>
		/// <param name="innerException">Создано исключение, которое вызвало <see cref="T:System.Configuration.Provider.ProviderException" />.</param>
		// Token: 0x060003F7 RID: 1015 RVA: 0x0000B178 File Offset: 0x00009378
		public ProviderException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
