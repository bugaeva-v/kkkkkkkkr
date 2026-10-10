using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Маршалирует данные типа <see langword="VT_VARIANT | VT_BYREF" /> из управляемого кода в неуправляемый. Этот класс не наследуется.</summary>
	// Token: 0x020006E0 RID: 1760
	public sealed class VariantWrapper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.VariantWrapper" /> для заданного параметра <see cref="T:System.Object" />.</summary>
		/// <param name="obj">Объект для маршалинга.</param>
		// Token: 0x06004050 RID: 16464 RVA: 0x000E0E2F File Offset: 0x000DF02F
		public VariantWrapper(object obj)
		{
			this.m_WrappedObject = obj;
		}

		/// <summary>Возвращает объект, инкапсулированный с помощью объекта <see cref="T:System.Runtime.InteropServices.VariantWrapper" />.</summary>
		/// <returns>Объект, инкапсулированный с помощью объекта <see cref="T:System.Runtime.InteropServices.VariantWrapper" />.</returns>
		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x000E0E3E File Offset: 0x000DF03E
		public object WrappedObject
		{
			get
			{
				return this.m_WrappedObject;
			}
		}

		// Token: 0x04002A22 RID: 10786
		private object m_WrappedObject;
	}
}
