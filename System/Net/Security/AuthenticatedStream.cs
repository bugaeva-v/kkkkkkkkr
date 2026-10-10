using System;
using System.IO;

namespace System.Net.Security
{
	/// <summary>Предоставляет методы для передачи учетных данных через поток, а также для запроса или выполнения проверки подлинности в клиент-серверных приложениях.</summary>
	// Token: 0x02000856 RID: 2134
	public abstract class AuthenticatedStream : Stream
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Security.AuthenticatedStream" />.</summary>
		/// <param name="innerStream">Объект <see cref="T:System.IO.Stream" />, используемый потоком <see cref="T:System.Net.Security.AuthenticatedStream" /> для отправки и получения данных.</param>
		/// <param name="leaveInnerStreamOpen">Объект <see cref="T:System.Boolean" />, указывающий, приводит ли закрытие данного объекта <see cref="T:System.Net.Security.AuthenticatedStream" /> к закрытию параметра <paramref name="innerStream" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="innerStream" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="innerStream" /> равно <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x060043F5 RID: 17397 RVA: 0x000EC754 File Offset: 0x000EA954
		protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
		{
			if (innerStream == null || innerStream == Stream.Null)
			{
				throw new ArgumentNullException("innerStream");
			}
			if (!innerStream.CanRead || !innerStream.CanWrite)
			{
				throw new ArgumentException(SR.GetString("The stream has to be read/write."), "innerStream");
			}
			this._InnerStream = innerStream;
			this._LeaveStreamOpen = leaveInnerStreamOpen;
		}

		/// <summary>Возвращает значение, определяющее, оставлен ли открытым поток, используемый данным объектом <see cref="T:System.Net.Security.AuthenticatedStream" /> для отправки и получения данных.</summary>
		/// <returns>Значение <see langword="true" />, если внутренний поток был оставлен открытым; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060043F6 RID: 17398 RVA: 0x000EC7B0 File Offset: 0x000EA9B0
		public bool LeaveInnerStreamOpen
		{
			get
			{
				return this._LeaveStreamOpen;
			}
		}

		/// <summary>Возвращает поток, используемый данным объектом <see cref="T:System.Net.Security.AuthenticatedStream" /> для отправки и получения данных.</summary>
		/// <returns>Объект <see cref="T:System.IO.Stream" />.</returns>
		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x000EC7B8 File Offset: 0x000EA9B8
		protected Stream InnerStream
		{
			get
			{
				return this._InnerStream;
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Security.AuthenticatedStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060043F8 RID: 17400 RVA: 0x000EC7C0 File Offset: 0x000EA9C0
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					if (this._LeaveStreamOpen)
					{
						this._InnerStream.Flush();
					}
					else
					{
						this._InnerStream.Close();
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, была ли проверка подлинности успешной.</summary>
		/// <returns>Значение <see langword="true" />, если произошла успешная проверка подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060043F9 RID: 17401
		public abstract bool IsAuthenticated { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, была ли проведена проверка подлинности как для сервера, так и для клиента.</summary>
		/// <returns>Значение <see langword="true" />, если и клиент, и сервер прошли проверку подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x060043FA RID: 17402
		public abstract bool IsMutuallyAuthenticated { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, являются ли зашифрованными данные, переданные с помощью данного потока <see cref="T:System.Net.Security.AuthenticatedStream" />.</summary>
		/// <returns>Значение <see langword="true" />, если данные шифруются до передачи по сети и дешифруются при достижении удаленной конечной точки; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060043FB RID: 17403
		public abstract bool IsEncrypted { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, подписаны ли данные, отправленные с помощью данного потока.</summary>
		/// <returns>Значение <see langword="true" />, если данные были подписаны перед передачей; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x060043FC RID: 17404
		public abstract bool IsSigned { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, прошла ли локальная сторона соединения проверку подлинности как сервер.</summary>
		/// <returns>Значение <see langword="true" />, если локальная конечная точка прошла проверку подлинности как серверная сторона соединения клиент-сервер с проверкой подлинности; значение <see langword="false" />, если локальная конечная точка прошла проверку подлинности как клиент.</returns>
		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x060043FD RID: 17405
		public abstract bool IsServer { get; }

		// Token: 0x04002910 RID: 10512
		private Stream _InnerStream;

		// Token: 0x04002911 RID: 10513
		private bool _LeaveStreamOpen;
	}
}
