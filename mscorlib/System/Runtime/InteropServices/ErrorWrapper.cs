using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Инкапсулирует объекты, которые необходимо маршалировать, как <see langword="VT_ERROR" />.</summary>
	// Token: 0x020006D6 RID: 1750
	public sealed class ErrorWrapper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ErrorWrapper" />, используя значение HRESULT ошибки.</summary>
		/// <param name="errorCode">Значение HRESULT ошибки.</param>
		// Token: 0x0600402E RID: 16430 RVA: 0x000E0C81 File Offset: 0x000DEE81
		public ErrorWrapper(int errorCode)
		{
			this.m_ErrorCode = errorCode;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ErrorWrapper" /> с объектом, содержащим значение HRESULT ошибки.</summary>
		/// <param name="errorCode">Объект, содержащий значение HRESULT ошибки.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="errorCode" /> не принадлежит типу <see cref="T:System.Int32" />.</exception>
		// Token: 0x0600402F RID: 16431 RVA: 0x000E0C90 File Offset: 0x000DEE90
		public ErrorWrapper(object errorCode)
		{
			if (!(errorCode is int))
			{
				throw new ArgumentException("Object must be of type Int32.", "errorCode");
			}
			this.m_ErrorCode = (int)errorCode;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ErrorWrapper" /> со значением HRESULT, которое относится к выданному исключению.</summary>
		/// <param name="e">Исключение для преобразования в код ошибки.</param>
		// Token: 0x06004030 RID: 16432 RVA: 0x000E0CBC File Offset: 0x000DEEBC
		public ErrorWrapper(Exception e)
		{
			this.m_ErrorCode = Marshal.GetHRForException(e);
		}

		/// <summary>Возвращает код ошибки обертки.</summary>
		/// <returns>Значение HRESULT ошибки.</returns>
		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x000E0CD0 File Offset: 0x000DEED0
		public int ErrorCode
		{
			get
			{
				return this.m_ErrorCode;
			}
		}

		// Token: 0x04002A20 RID: 10784
		private int m_ErrorCode;
	}
}
