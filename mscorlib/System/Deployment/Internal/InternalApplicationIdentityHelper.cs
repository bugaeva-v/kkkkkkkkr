using System;
using System.Runtime.InteropServices;

namespace System.Deployment.Internal
{
	/// <summary>Предоставляет доступ ко внутренним свойствам объекта <see cref="T:System.ApplicationIdentity" />.</summary>
	// Token: 0x0200027E RID: 638
	[ComVisible(false)]
	public static class InternalApplicationIdentityHelper
	{
		/// <summary>Получает интерфейс IDefinitionAppId, представляющий уникальный идентификатор объекта <see cref="T:System.ApplicationIdentity" />.</summary>
		/// <param name="id">Объект, из которого извлекается идентификатор.</param>
		/// <returns>Уникальный идентификатор хранится в объекте <see cref="T:System.ApplicationIdentity" />.</returns>
		// Token: 0x06001D4F RID: 7503 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static object GetInternalAppId(ApplicationIdentity id)
		{
			throw new NotImplementedException();
		}
	}
}
