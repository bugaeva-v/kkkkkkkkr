using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net
{
	/// <summary>Класс <see cref="T:System.Net.TransportContext" /> предоставляет дополнительный контекст о подлежащем транспортном слое.</summary>
	// Token: 0x02000602 RID: 1538
	public abstract class TransportContext
	{
		/// <summary>Извлекает запрошенную привязку канала.</summary>
		/// <param name="kind">Тип привязки канала, которую требуется извлечь.</param>
		/// <returns>Запрошенная привязка <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> или <see langword="null" />, если привязка канала не поддерживается текущим транспортом или операционной системой.</returns>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="kind" /> должен быть равен <see cref="F:System.Security.Authentication.ExtendedProtection.ChannelBindingKind.Endpoint" /> для использования с объектом <see cref="T:System.Net.TransportContext" />, извлеченным из свойства <see cref="P:System.Net.HttpListenerRequest.TransportContext" />.</exception>
		// Token: 0x060030A7 RID: 12455
		public abstract ChannelBinding GetChannelBinding(ChannelBindingKind kind);

		/// <summary>Возвращает привязки токенов уровня безопасности транспорта.</summary>
		/// <returns>Привязки токенов уровня безопасности транспорта.</returns>
		// Token: 0x060030A8 RID: 12456 RVA: 0x000044FA File Offset: 0x000026FA
		public virtual IEnumerable<TokenBinding> GetTlsTokenBindings()
		{
			throw new NotSupportedException();
		}
	}
}
