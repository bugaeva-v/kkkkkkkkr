using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Маршалирует данные типа <see langword="VT_BSTR" /> из управляемого кода в неуправляемый. Этот класс не наследуется.</summary>
	// Token: 0x020006D2 RID: 1746
	public sealed class BStrWrapper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.BStrWrapper" /> с указанным объектом <see cref="T:System.String" />.</summary>
		/// <param name="value">Объект, заключаемый в оболочку и маршалируемый как <see langword="VT_BSTR" />.</param>
		// Token: 0x06004028 RID: 16424 RVA: 0x000E0C13 File Offset: 0x000DEE13
		public BStrWrapper(string value)
		{
			this.m_WrappedObject = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.BStrWrapper" /> с указанным объектом <see cref="T:System.Object" />.</summary>
		/// <param name="value">Объект, заключаемый в оболочку и маршалируемый как <see langword="VT_BSTR" />.</param>
		// Token: 0x06004029 RID: 16425 RVA: 0x000E0C22 File Offset: 0x000DEE22
		public BStrWrapper(object value)
		{
			this.m_WrappedObject = (string)value;
		}

		/// <summary>Возвращает инкапсулированный объект <see cref="T:System.String" /> для маршалинга в качестве типа <see langword="VT_BSTR" />.</summary>
		/// <returns>Объект, заключенный в оболочку с помощью <see cref="T:System.Runtime.InteropServices.BStrWrapper" />.</returns>
		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x000E0C36 File Offset: 0x000DEE36
		public string WrappedObject
		{
			get
			{
				return this.m_WrappedObject;
			}
		}

		// Token: 0x04002A17 RID: 10775
		private string m_WrappedObject;
	}
}
