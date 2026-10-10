using System;
using System.Configuration;
using Unity;

namespace System.Net.Configuration
{
	/// <summary>Представляет элемент HttpListener в файле конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x02000875 RID: 2165
	public sealed class HttpListenerElement : ConfigurationElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.HttpListenerElement" />.</summary>
		// Token: 0x060044A8 RID: 17576 RVA: 0x00013BCA File Offset: 0x00011DCA
		public HttpListenerElement()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает Элементы времени ожидания по умолчанию, используемые для объекта <see cref="T:System.Net.HttpListener" />.</summary>
		/// <returns>Элементы времени ожидания, используемые для объекта <see cref="T:System.Net.HttpListener" />.</returns>
		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x00032884 File Offset: 0x00030A84
		public HttpListenerTimeoutsElement Timeouts
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает значение, определяющее, использует ли <see cref="T:System.Net.HttpListener" /> не преобразованный в escape-последовательность URI вместо преобразованного.</summary>
		/// <returns>Логическое значение, определяющее, использует ли <see cref="T:System.Net.HttpListener" /> не преобразованный в escape-последовательность URI вместо преобразованного.</returns>
		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x000ED0BC File Offset: 0x000EB2BC
		public bool UnescapeRequestUrl
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}
	}
}
