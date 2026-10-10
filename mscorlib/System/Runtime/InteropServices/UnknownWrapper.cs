using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Инкапсулирует объекты, которые необходимо маршалировать, как <see langword="VT_UNKNOWN" />.</summary>
	// Token: 0x020006DF RID: 1759
	public sealed class UnknownWrapper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.UnknownWrapper" /> инкапсулируемым в обертку объектом.</summary>
		/// <param name="obj">Инкапсулируемый в обертку объект.</param>
		// Token: 0x0600404E RID: 16462 RVA: 0x000E0E18 File Offset: 0x000DF018
		public UnknownWrapper(object obj)
		{
			this.m_WrappedObject = obj;
		}

		/// <summary>Возвращает объект, содержащийся в этой обертке.</summary>
		/// <returns>Инкапсулированный в обертку объект.</returns>
		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600404F RID: 16463 RVA: 0x000E0E27 File Offset: 0x000DF027
		public object WrappedObject
		{
			get
			{
				return this.m_WrappedObject;
			}
		}

		// Token: 0x04002A21 RID: 10785
		private object m_WrappedObject;
	}
}
