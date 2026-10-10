using System;
using System.IO;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Principal;
using System.Threading.Tasks;

namespace System.Net.Security
{
	/// <summary>Предоставляет поток, использующий протокол безопасности Negotiate для проверки подлинности клиента, и, при необходимости, сервера при обмене данными в системе клиент-сервер.</summary>
	// Token: 0x0200085B RID: 2139
	public class NegotiateStream : AuthenticatedStream
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Security.NegotiateStream" /> с использованием указанного объекта <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="innerStream">Объект <see cref="T:System.IO.Stream" />, используемый потоком <see cref="T:System.Net.Security.NegotiateStream" /> для отправки и получения данных.</param>
		// Token: 0x06004402 RID: 17410 RVA: 0x000EC80C File Offset: 0x000EAA0C
		[MonoTODO]
		public NegotiateStream(Stream innerStream) : base(innerStream, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Security.NegotiateStream" />, используя заданный поток <see cref="T:System.IO.Stream" /> и параметр, указывающий поведение потока при закрытии.</summary>
		/// <param name="innerStream">Объект <see cref="T:System.IO.Stream" />, используемый потоком <see cref="T:System.Net.Security.NegotiateStream" /> для отправки и получения данных.</param>
		/// <param name="leaveInnerStreamOpen">Значение <see langword="true" /> указывает, что закрытие этого потока <see cref="T:System.Net.Security.NegotiateStream" /> не влияет на поток, заданный параметром <paramref name="innerStream" />; значение <see langword="false" /> указывает, что закрытие потока <see cref="T:System.Net.Security.NegotiateStream" /> приводит также к закрытию потока <paramref name="innerStream" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="innerStream" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="innerStream" /> равно <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x06004403 RID: 17411 RVA: 0x000EC816 File Offset: 0x000EAA16
		[MonoTODO]
		public NegotiateStream(Stream innerStream, bool leaveInnerStreamOpen) : base(innerStream, leaveInnerStreamOpen)
		{
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, разрешено ли чтение из базового потока.</summary>
		/// <returns>Значение <see langword="true" />, если проверка подлинности выполнена, а чтение из базового потока разрешено; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x000EC820 File Offset: 0x000EAA20
		public override bool CanRead
		{
			get
			{
				return base.InnerStream.CanRead;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, разрешен ли поиск в базовом потоке.</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x000EC82D File Offset: 0x000EAA2D
		public override bool CanSeek
		{
			get
			{
				return base.InnerStream.CanSeek;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, поддерживает ли базовый поток использование времени ожидания.</summary>
		/// <returns>Значение <see langword="true" />, если базовый поток поддерживает время ожидания; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override bool CanTimeout
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, разрешена ли запись в базовый поток.</summary>
		/// <returns>Значение <see langword="true" />, если проверка подлинности выполнена, а запись в базовый поток разрешена; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x000EC83A File Offset: 0x000EAA3A
		public override bool CanWrite
		{
			get
			{
				return base.InnerStream.CanWrite;
			}
		}

		/// <summary>Возвращает значение, указывающее, как сервер может использовать учетные данные клиента.</summary>
		/// <returns>Одно из значений <see cref="T:System.Security.Principal.TokenImpersonationLevel" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности завершилась неудачно или не выполнялась.</exception>
		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual TokenImpersonationLevel ImpersonationLevel
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, была ли проверка подлинности успешной.</summary>
		/// <returns>Значение <see langword="true" />, если произошла успешная проверка подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06004409 RID: 17417 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override bool IsAuthenticated
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, использует ли данный поток <see cref="T:System.Net.Security.NegotiateStream" /> шифрование данных.</summary>
		/// <returns>Значение <see langword="true" />, если данные шифруются до передачи по сети и дешифруются при достижении удаленной конечной точки; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override bool IsEncrypted
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, что и сервер, и клиент прошли проверку подлинности.</summary>
		/// <returns>Значение <see langword="true" />, если подлинность сервера была проверена, иначе — <see langword="false" />.</returns>
		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override bool IsMutuallyAuthenticated
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, прошла ли локальная сторона соединения, используемого данным потоком <see cref="T:System.Net.Security.NegotiateStream" />, проверку подлинности как сервер.</summary>
		/// <returns>Значение <see langword="true" />, если локальная конечная точка успешно прошла проверку подлинности как серверная сторона соединения с проверкой подлинности; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override bool IsServer
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, подписаны ли данные, отправленные с помощью данного потока.</summary>
		/// <returns>Значение <see langword="true" />, если данные были подписаны перед передачей; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override bool IsSigned
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает длину данных в базовом потоке.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, указывающее длину базового потока.</returns>
		/// <exception cref="T:System.NotSupportedException">Возвращение значения данного свойства не поддерживается, если базовый поток является экземпляром класса <see cref="T:System.Net.Sockets.NetworkStream" />.</exception>
		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x00008083 File Offset: 0x00006283
		public override long Length
		{
			get
			{
				return base.InnerStream.Length;
			}
		}

		/// <summary>Возвращает или задает текущую позицию в базовом потоке.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, указывающее текущую позицию в базовом потока.</returns>
		/// <exception cref="T:System.NotSupportedException">Задание данного свойства не поддерживается.  
		/// -или- 
		/// Возвращение значения данного свойства не поддерживается, если базовый поток является экземпляром класса <see cref="T:System.Net.Sockets.NetworkStream" />.</exception>
		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x00008090 File Offset: 0x00006290
		// (set) Token: 0x06004410 RID: 17424 RVA: 0x000EC847 File Offset: 0x000EAA47
		public override long Position
		{
			get
			{
				return base.InnerStream.Position;
			}
			set
			{
				base.InnerStream.Position = value;
			}
		}

		/// <summary>Возвращает или задает временной интервал, в течение которого операция чтения будет блокироваться, ожидая получения данных.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, указывающее период времени (в миллисекундах), по истечении которого происходит сбой операции чтения.</returns>
		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x000EC855 File Offset: 0x000EAA55
		// (set) Token: 0x06004412 RID: 17426 RVA: 0x000EC85D File Offset: 0x000EAA5D
		public override int ReadTimeout
		{
			get
			{
				return this.readTimeout;
			}
			set
			{
				this.readTimeout = value;
			}
		}

		/// <summary>Возвращает сведения о идентификации удаленной стороны, использующей данный поток с проверкой подлинности.</summary>
		/// <returns>Объект <see cref="T:System.Security.Principal.IIdentity" />, описывающий идентификацию удаленной конечной точки.</returns>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности завершилась неудачно или не выполнялась.</exception>
		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IIdentity RemoteIdentity
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает или задает период времени, в течение которого операция записи блокирует выполнение, ожидая данных.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, указывающее период времени (в миллисекундах), по истечении которого происходит сбой операции записи.</returns>
		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x000EC866 File Offset: 0x000EAA66
		// (set) Token: 0x06004415 RID: 17429 RVA: 0x000EC86E File Offset: 0x000EAA6E
		public override int WriteTimeout
		{
			get
			{
				return this.writeTimeout;
			}
			set
			{
				this.writeTimeout = value;
			}
		}

		/// <summary>Вызывается клиентами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Этот метод не блокируется.</summary>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения о данной операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		// Token: 0x06004416 RID: 17430 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные и привязку канала. Этот метод не блокируется.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="binding">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, который используется для расширенной защиты.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции записи. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004417 RID: 17431 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные. Этот метод не блокируется.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции записи. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		// Token: 0x06004418 RID: 17432 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, string targetName, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные сервера и параметры проверки подлинности. Этот метод не блокируется.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="allowedImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции записи. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		// Token: 0x06004419 RID: 17433 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные, параметры проверки подлинности и привязку канала. Этот метод не блокируется.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="binding">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, который используется для расширенной защиты.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="allowedImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции записи. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x0600441A RID: 17434 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Начинает асинхронную операцию чтения, которая считывает данные из потока и сохраняет их в заданном массиве.</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, куда помещаются байты, считанные из потока.</param>
		/// <param name="offset">Расположение (начиная с 0) в массиве, заданном параметром <paramref name="buffer" />, с которого начинается сохранение данных, считанных из этого потока.</param>
		/// <param name="count">Максимальное число байтов, которое должно быть считано из потока.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, который следует вызвать после завершения операции чтения.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения о данной операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Сумма значений <paramref name="offset" /> и <paramref name="count" /> превышает длину массива <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Сбой операции чтения.  
		/// -или- 
		/// Используется шифрование, но не удается расшифровать данные.</exception>
		/// <exception cref="T:System.NotSupportedException">Уже существует выполняющаяся операция чтения.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		// Token: 0x0600441B RID: 17435 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Этот метод не блокируется.</summary>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения о данной операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		// Token: 0x0600441C RID: 17436 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsServer(AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные сервера, параметры проверки подлинности и политику расширенной защиты. Этот метод не блокируется.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="policy">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который используется для расширенной защиты.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="requiredImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции записи. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentException">Оба свойства <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding" /> и <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomServiceNames" /> в расширенной политике защиты, переданной параметром <paramref name="policy" />, имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="requiredImpersonationLevel" /> должен иметь значение <see cref="F:System.Security.Principal.TokenImpersonationLevel.Identification" />, <see cref="F:System.Security.Principal.TokenImpersonationLevel.Impersonation" /> или <see cref="F:System.Security.Principal.TokenImpersonationLevel.Delegation" />,</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны клиента. Этот поток нельзя использовать для повторной проверки подлинности со стороны сервера.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Параметру <paramref name="policy" /> было присвоено значение параметра <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always" /> на платформе, которая не поддерживает расширенную защиту.</exception>
		// Token: 0x0600441D RID: 17437 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsServer(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные сервера и параметры проверки подлинности. Этот метод не блокируется.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="requiredImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения о данной операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="requiredImpersonationLevel" /> должен иметь значение <see cref="F:System.Security.Principal.TokenImpersonationLevel.Identification" />, <see cref="F:System.Security.Principal.TokenImpersonationLevel.Impersonation" /> или <see cref="F:System.Security.Principal.TokenImpersonationLevel.Delegation" />,</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны клиента. Этот поток нельзя использовать для повторной проверки подлинности со стороны сервера.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		// Token: 0x0600441E RID: 17438 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsServer(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданную политику расширенной защиты. Этот метод не блокируется.</summary>
		/// <param name="policy">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который используется для расширенной защиты.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции записи. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentException">Оба свойства <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding" /> и <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomServiceNames" /> в расширенной политике защиты, переданной параметром <paramref name="policy" />, имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Параметру <paramref name="policy" /> было присвоено значение параметра <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always" /> на платформе, которая не поддерживает расширенную защиту.</exception>
		// Token: 0x0600441F RID: 17439 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual IAsyncResult BeginAuthenticateAsServer(ExtendedProtectionPolicy policy, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Начинает асинхронную операцию записи, которая записывает байты (<see cref="T:System.Byte" />) из указанного буфера в поток.</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, предоставляющий байты для записи в поток.</param>
		/// <param name="offset">Расположение (начиная с нуля) в массиве<paramref name="buffer" />, с которого требуется начать считывать байты, предназначенные для записи в поток.</param>
		/// <param name="count">Значение <see cref="T:System.Int32" />, определяющее количество байт, которые требуется считать из массива <paramref name="buffer" />.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, который следует вызвать после завершения операции записи.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции записи. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset is less than 0" />.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Сумма значений <paramref name="offset" /> и count превышает длину массива <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось выполнить операцию записи.  
		/// -или- 
		/// Используется шифрование, но не удается зашифровать данные.</exception>
		/// <exception cref="T:System.NotSupportedException">Уже существует выполняющаяся операция записи.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		// Token: 0x06004420 RID: 17440 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер.</summary>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		// Token: 0x06004421 RID: 17441 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsClient()
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные клиента.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004422 RID: 17442 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsClient(NetworkCredential credential, string targetName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные клиента и привязку канала.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="binding">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, который используется для расширенной защиты.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004423 RID: 17443 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные, параметры проверки подлинности и привязку канала.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="binding">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, который используется для расширенной защиты.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="allowedImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="allowedImpersonationLevel" /> не является допустимым значением.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004424 RID: 17444 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные сервера и параметры проверки подлинности.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="allowedImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="allowedImpersonationLevel" /> не является допустимым значением.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="targetName" /> имеет значение null.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		// Token: 0x06004425 RID: 17445 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsClient(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер.</summary>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		// Token: 0x06004426 RID: 17446 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsServer()
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданную политику расширенной защиты.</summary>
		/// <param name="policy">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который используется для расширенной защиты.</param>
		/// <exception cref="T:System.ArgumentException">Оба свойства <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding" /> и <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomServiceNames" /> в расширенной политике защиты, переданной параметром <paramref name="policy" />, имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Параметру <paramref name="policy" /> было присвоено значение параметра <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always" /> на платформе, которая не поддерживает расширенную защиту.</exception>
		// Token: 0x06004427 RID: 17447 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsServer(ExtendedProtectionPolicy policy)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные сервера, параметры проверки подлинности и политику расширенной защиты.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="policy">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который используется для расширенной защиты.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="requiredImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <exception cref="T:System.ArgumentException">Оба свойства <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding" /> и <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomServiceNames" /> в расширенной политике защиты, переданной параметром <paramref name="policy" />, имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="requiredImpersonationLevel" /> должен иметь значение <see cref="F:System.Security.Principal.TokenImpersonationLevel.Identification" />, <see cref="F:System.Security.Principal.TokenImpersonationLevel.Impersonation" /> или <see cref="F:System.Security.Principal.TokenImpersonationLevel.Delegation" />,</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны клиента. Этот поток нельзя использовать для повторной проверки подлинности со стороны сервера.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Параметру <paramref name="policy" /> было присвоено значение параметра <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always" /> на платформе, которая не поддерживает расширенную защиту.</exception>
		// Token: 0x06004428 RID: 17448 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsServer(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами для проверки подлинности клиента и, при необходимости, сервера в соединении клиент-сервер. Процесс проверки подлинности использует заданные учетные данные сервера и параметры проверки подлинности.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации сервера.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="requiredImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="requiredImpersonationLevel" /> должен иметь значение <see cref="F:System.Security.Principal.TokenImpersonationLevel.Identification" />, <see cref="F:System.Security.Principal.TokenImpersonationLevel.Impersonation" /> или <see cref="F:System.Security.Principal.TokenImpersonationLevel.Delegation" />,</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны клиента. Этот поток нельзя использовать для повторной проверки подлинности со стороны сервера.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		// Token: 0x06004429 RID: 17449 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void AuthenticateAsServer(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
		{
			throw new NotImplementedException();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Security.NegotiateStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600442A RID: 17450 RVA: 0x000EC877 File Offset: 0x000EAA77
		[MonoTODO]
		protected override void Dispose(bool disposing)
		{
		}

		/// <summary>Завершает находящуюся в состоянии ожидания асинхронную операцию проверки подлинности клиента, которая была до этого запущена вызовом метода <see cref="Overload:System.Net.Security.NegotiateStream.BeginAuthenticateAsClient" />.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="Overload:System.Net.Security.NegotiateStream.BeginAuthenticateAsClient" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="Overload:System.Net.Security.NegotiateStream.BeginAuthenticateAsClient" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нет ожидающей завершения операции проверки подлинности клиента.</exception>
		// Token: 0x0600442B RID: 17451 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
			throw new NotImplementedException();
		}

		/// <summary>Заканчивает асинхронную операцию чтения, запущенную до этого вызовом метода <see cref="M:System.Net.Security.NegotiateStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="M:System.Net.Security.NegotiateStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</param>
		/// <returns>Значение <see cref="T:System.Int32" />, указывающее количество байтов, считанное из базового потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение asyncResult не было создано при вызове метода <see cref="M:System.Net.Security.NegotiateStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нет ожидающей завершения операции чтения.
		///
		/// или -
		///
		/// Проверка подлинности не выполнялась.</exception>
		/// <exception cref="T:System.IO.IOException">Сбой операции чтения.</exception>
		// Token: 0x0600442C RID: 17452 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw new NotImplementedException();
		}

		/// <summary>Завершает находящуюся в состоянии ожидания асинхронную операцию проверки подлинности клиента, которая была до этого запущена вызовом метода <see cref="Overload:System.Net.Security.NegotiateStream.BeginAuthenticateAsServer" />.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="Overload:System.Net.Security.NegotiateStream.BeginAuthenticateAsServer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="Overload:System.Net.Security.NegotiateStream.BeginAuthenticateAsServer" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нет ожидающей завершения операции проверки подлинности.</exception>
		// Token: 0x0600442D RID: 17453 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult)
		{
			throw new NotImplementedException();
		}

		/// <summary>Заканчивает асинхронную операцию чтения, запущенную до этого вызовом метода <see cref="M:System.Net.Security.NegotiateStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="M:System.Net.Security.NegotiateStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение asyncResult не было создано при вызове метода <see cref="M:System.Net.Security.NegotiateStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нет ожидающей завершения операции записи.
		///
		/// или -
		///
		/// Проверка подлинности не выполнялась.</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось выполнить операцию записи.</exception>
		// Token: 0x0600442E RID: 17454 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw new NotImplementedException();
		}

		/// <summary>Принудительно записывает все буферизированные данные в базовое устройство.</summary>
		// Token: 0x0600442F RID: 17455 RVA: 0x00007E6C File Offset: 0x0000606C
		[MonoTODO]
		public override void Flush()
		{
			base.InnerStream.Flush();
		}

		/// <summary>Считывает данные из этого потока и сохраняет их в заданном массиве.</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, куда помещаются байты, считанные из потока.</param>
		/// <param name="offset">Значение <see cref="T:System.Int32" />, содержащее расположение (начиная с нуля) в массиве <paramref name="buffer" />, с которого следует начинать сохранение данных, считанных их этого потока.</param>
		/// <param name="count">Значение <see cref="T:System.Int32" />, содержащее максимальное количество байтов, которое требуется считать из потока.</param>
		/// <returns>Значение <see cref="T:System.Int32" />, указывающее количество байтов, считанное из базового потока. Когда данных для чтения не остается, возвращает 0.</returns>
		/// <exception cref="T:System.IO.IOException">Сбой операции чтения.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		/// <exception cref="T:System.NotSupportedException">Операция <see cref="M:System.Net.Security.NegotiateStream.Read(System.Byte[],System.Int32,System.Int32)" /> уже выполняется в настоящее время.</exception>
		// Token: 0x06004430 RID: 17456 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException();
		}

		/// <summary>Выдает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">Это значение игнорируется.</param>
		/// <param name="origin">Это значение игнорируется.</param>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Поиск в потоке <see cref="T:System.Net.Security.NegotiateStream" /> не поддерживается.</exception>
		// Token: 0x06004431 RID: 17457 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает длину данных в базовом потоке.</summary>
		/// <param name="value">Значение <see cref="T:System.Int64" />, указывающее длину потока.</param>
		// Token: 0x06004432 RID: 17458 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override void SetLength(long value)
		{
			throw new NotImplementedException();
		}

		/// <summary>Записывает указанное количество элементов <see cref="T:System.Byte" /> в базовый поток, используя заданный буфер (параметр buffer) и начальное расположение (параметр offset).</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, предоставляющий байты для записи в поток.</param>
		/// <param name="offset">Значение <see cref="T:System.Int32" />, содержащее расположение (начиная с нуля) в массиве <paramref name="buffer" />, с которого требуется начать чтение байтов, записываемых в поток.</param>
		/// <param name="count">Значение <see cref="T:System.Int32" />, содержащее количество байтов, считываемых из массива <paramref name="buffer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset is less than 0" />.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		///
		/// или - 
		/// Сумма значений <paramref name="offset" /> и count превышает длину массива <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось выполнить операцию записи.  
		/// -или- 
		/// Используется шифрование, но не удается зашифровать данные.</exception>
		/// <exception cref="T:System.NotSupportedException">Уже существует выполняющаяся операция записи.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		// Token: 0x06004433 RID: 17459 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		// Token: 0x06004434 RID: 17460 RVA: 0x000EC87B File Offset: 0x000EAA7B
		public virtual Task AuthenticateAsClientAsync()
		{
			return Task.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginAuthenticateAsClient), new Action<IAsyncResult>(this.EndAuthenticateAsClient), null);
		}

		/// <summary>Вызывается клиентами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция. Процесс проверки подлинности использует заданные учетные данные клиента.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004435 RID: 17461 RVA: 0x000EC8A2 File Offset: 0x000EAAA2
		public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, string targetName)
		{
			return Task.Factory.FromAsync<NetworkCredential, string>(new Func<NetworkCredential, string, AsyncCallback, object, IAsyncResult>(this.BeginAuthenticateAsClient), new Action<IAsyncResult>(this.EndAuthenticateAsClient), credential, targetName, null);
		}

		/// <summary>Вызывается клиентами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция. Процесс проверки подлинности использует заданные учетные данные сервера и параметры проверки подлинности.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="allowedImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="allowedImpersonationLevel" /> не является допустимым значением.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="targetName" /> имеет значение null.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		// Token: 0x06004436 RID: 17462 RVA: 0x000EC8CC File Offset: 0x000EAACC
		public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
		{
			return Task.Factory.FromAsync((AsyncCallback callback, object state) => this.BeginAuthenticateAsClient(credential, targetName, requiredProtectionLevel, allowedImpersonationLevel, callback, state), new Action<IAsyncResult>(this.EndAuthenticateAsClient), null);
		}

		/// <summary>Вызывается клиентами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция. Процесс проверки подлинности использует заданные учетные данные клиента и привязку канала.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="binding">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, который используется для расширенной защиты.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004437 RID: 17463 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, ChannelBinding binding, string targetName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается клиентами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция. Процесс проверки подлинности использует заданные учетные данные, параметры проверки подлинности и привязку канала.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="binding">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, который используется для расширенной защиты.</param>
		/// <param name="targetName">Имя участника-службы (SPN), уникально определяющее сервер, подлинность которого проверяется.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="allowedImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetName" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="allowedImpersonationLevel" /> не является допустимым значением.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны сервера. Этот поток нельзя использовать для повторной проверки подлинности со стороны клиента.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004438 RID: 17464 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		// Token: 0x06004439 RID: 17465 RVA: 0x000EC927 File Offset: 0x000EAB27
		public virtual Task AuthenticateAsServerAsync()
		{
			return Task.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginAuthenticateAsServer), new Action<IAsyncResult>(this.EndAuthenticateAsServer), null);
		}

		/// <summary>Вызывается серверами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция. Процесс проверки подлинности использует заданную политику расширенной защиты.</summary>
		/// <param name="policy">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который используется для расширенной защиты.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentException">Оба свойства <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding" /> и <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomServiceNames" /> в расширенной политике защиты, переданной параметром <paramref name="policy" />, имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Параметру <paramref name="policy" /> было присвоено значение параметра <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always" /> на платформе, которая не поддерживает расширенную защиту.</exception>
		// Token: 0x0600443A RID: 17466 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual Task AuthenticateAsServerAsync(ExtendedProtectionPolicy policy)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция. Процесс проверки подлинности использует заданные учетные данные сервера и параметры проверки подлинности.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации сервера.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="requiredImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="requiredImpersonationLevel" /> должен иметь значение <see cref="F:System.Security.Principal.TokenImpersonationLevel.Identification" />, <see cref="F:System.Security.Principal.TokenImpersonationLevel.Impersonation" /> или <see cref="F:System.Security.Principal.TokenImpersonationLevel.Delegation" />,</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны клиента. Этот поток нельзя использовать для повторной проверки подлинности со стороны сервера.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		// Token: 0x0600443B RID: 17467 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual Task AuthenticateAsServerAsync(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается серверами аутентификации клиента, и, при необходимости, сервера в соединении клиент-сервер как асинхронная операция. Процесс проверки подлинности использует заданные учетные данные сервера, параметры проверки подлинности и политику расширенной защиты.</summary>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, используемые для установления идентификации клиента.</param>
		/// <param name="policy">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который используется для расширенной защиты.</param>
		/// <param name="requiredProtectionLevel">Одно из значений перечисления <see cref="T:System.Net.Security.ProtectionLevel" />, указывающее службы безопасности для потока.</param>
		/// <param name="requiredImpersonationLevel">Одно из значений перечисления <see cref="T:System.Security.Principal.TokenImpersonationLevel" />, указывающее, как сервер может использовать учетные записи клиента для доступа к ресурсам.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentException">Оба свойства <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding" /> и <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomServiceNames" /> в расширенной политике защиты, переданной параметром <paramref name="policy" />, имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="credential" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="requiredImpersonationLevel" /> должен иметь значение <see cref="F:System.Security.Principal.TokenImpersonationLevel.Identification" />, <see cref="F:System.Security.Principal.TokenImpersonationLevel.Impersonation" /> или <see cref="F:System.Security.Principal.TokenImpersonationLevel.Delegation" />,</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.Security.Authentication.InvalidCredentialException">Сбой проверки подлинности. Этот объект можно использовать для повторной проверки подлинности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Этот поток уже использовался ранее при попытке проверки подлинности со стороны клиента. Этот поток нельзя использовать для повторной проверки подлинности со стороны сервера.</exception>
		/// <exception cref="T:System.NotSupportedException">Системы Windows 95 и Windows 98 не поддерживаются.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Параметру <paramref name="policy" /> было присвоено значение параметра <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always" /> на платформе, которая не поддерживает расширенную защиту.</exception>
		// Token: 0x0600443C RID: 17468 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual Task AuthenticateAsServerAsync(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400291E RID: 10526
		private int readTimeout;

		// Token: 0x0400291F RID: 10527
		private int writeTimeout;
	}
}
