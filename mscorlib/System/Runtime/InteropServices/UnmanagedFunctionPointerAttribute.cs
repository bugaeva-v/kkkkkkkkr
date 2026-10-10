using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Управляет поведением при маршалинге сигнатуры делегата, передаваемой как указатель неуправляемой функции в неуправляемый код или из него. Этот класс не наследуется.</summary>
	// Token: 0x020006E2 RID: 1762
	[AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[ComVisible(true)]
	public sealed class UnmanagedFunctionPointerAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute" /> с заданным соглашением о вызове.</summary>
		/// <param name="callingConvention">Заданное соглашение о вызове.</param>
		// Token: 0x0600405B RID: 16475 RVA: 0x000E0F1A File Offset: 0x000DF11A
		public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
		{
			this.m_callingConvention = callingConvention;
		}

		/// <summary>Возвращает значение соглашения о вызове.</summary>
		/// <returns>Значение соглашения о вызове, указанное конструктором <see cref="M:System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute.#ctor(System.Runtime.InteropServices.CallingConvention)" />.</returns>
		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x0600405C RID: 16476 RVA: 0x000E0F29 File Offset: 0x000DF129
		public CallingConvention CallingConvention
		{
			get
			{
				return this.m_callingConvention;
			}
		}

		// Token: 0x04002A26 RID: 10790
		private CallingConvention m_callingConvention;

		/// <summary>Указывает способ маршалинга параметров строки для метода, а также управляет искажением имени.</summary>
		// Token: 0x04002A27 RID: 10791
		public CharSet CharSet;

		/// <summary>Включает или отключает поведение наилучшего сопоставления при преобразовании знаков Юникода в знаки ANSI.</summary>
		// Token: 0x04002A28 RID: 10792
		public bool BestFitMapping;

		/// <summary>Включает и отключает возникновение исключений для неотображаемых символов Юникода, преобразующихся в знаки вопроса ("?") ANSI.</summary>
		// Token: 0x04002A29 RID: 10793
		public bool ThrowOnUnmappableChar;

		/// <summary>Показывает, вызывает ли вызываемый объект функцию <see langword="SetLastError" /> интерфейса Win32 API перед возвращением из метода, использующего атрибуты.</summary>
		// Token: 0x04002A2A RID: 10794
		public bool SetLastError;
	}
}
