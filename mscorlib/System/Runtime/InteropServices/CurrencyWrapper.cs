using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Инкапсулирует объекты, которые необходимо маршалировать, как <see langword="VT_CY" />.</summary>
	// Token: 0x020006D4 RID: 1748
	public sealed class CurrencyWrapper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.CurrencyWrapper" />, используя <see langword="Decimal" />, для инкапсуляции, а также для маршалинга как типа <see langword="VT_CY" />.</summary>
		/// <param name="obj">
		///   <see langword="Decimal" />, для которого требуется выполнить инкапсуляцию, а также маршалинг как типа <see langword="VT_CY" />.</param>
		// Token: 0x0600402B RID: 16427 RVA: 0x000E0C3E File Offset: 0x000DEE3E
		public CurrencyWrapper(decimal obj)
		{
			this.m_WrappedObject = obj;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.CurrencyWrapper" />, используя объект, содержащий <see langword="Decimal" />, для инкапсуляции, а также для маршалинга как типа <see langword="VT_CY" />.</summary>
		/// <param name="obj">Объект, содержащий <see langword="Decimal" />, для инкапсуляции, а также для маршалинга как типа <see langword="VT_CY" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="obj" /> не принадлежит к типу <see cref="T:System.Decimal" />.</exception>
		// Token: 0x0600402C RID: 16428 RVA: 0x000E0C4D File Offset: 0x000DEE4D
		public CurrencyWrapper(object obj)
		{
			if (!(obj is decimal))
			{
				throw new ArgumentException("Object must be of type Decimal.", "obj");
			}
			this.m_WrappedObject = (decimal)obj;
		}

		/// <summary>Возвращает инкапсулированный объект, который должен быть маршалирован как тип <see langword="VT_CY" />.</summary>
		/// <returns>Инкапсулированный объект, который должен быть маршалирован как тип <see langword="VT_CY" />.</returns>
		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600402D RID: 16429 RVA: 0x000E0C79 File Offset: 0x000DEE79
		public decimal WrappedObject
		{
			get
			{
				return this.m_WrappedObject;
			}
		}

		// Token: 0x04002A1C RID: 10780
		private decimal m_WrappedObject;
	}
}
