using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения о сетевых интерфейсах, поддерживающих протокол IPv6.</summary>
	// Token: 0x020006EB RID: 1771
	public abstract class IPv6InterfaceProperties
	{
		/// <summary>Получает индекс сетевого интерфейса, связанного с IPv6-адресом.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, содержащее индекс сетевого интерфейса для адреса IPv6.</returns>
		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060038E5 RID: 14565
		public abstract int Index { get; }

		/// <summary>Возвращает MTU данного сетевого интерфейса.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, обозначающее MTU.</returns>
		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060038E6 RID: 14566
		public abstract int Mtu { get; }

		/// <summary>Получает идентификатор области сетевого интерфейса, связанного с IPv6-адресом.</summary>
		/// <param name="scopeLevel">Уровень области.</param>
		/// <returns>Идентификатор области сетевого интерфейса, связанной с адресом IPv6.</returns>
		// Token: 0x060038E7 RID: 14567 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual long GetScopeId(ScopeLevel scopeLevel)
		{
			throw new NotImplementedException();
		}
	}
}
