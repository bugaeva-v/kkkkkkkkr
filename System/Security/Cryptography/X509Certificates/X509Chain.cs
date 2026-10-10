using System;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Представляет обработчик для создания цепочки для сертификатов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
	// Token: 0x020002D9 RID: 729
	public class X509Chain : IDisposable
	{
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0005B298 File Offset: 0x00059498
		internal X509ChainImpl Impl
		{
			get
			{
				X509Helper2.ThrowIfContextInvalid(this.impl);
				return this.impl;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x0005B2AB File Offset: 0x000594AB
		internal bool IsValid
		{
			get
			{
				return X509Helper2.IsValid(this.impl);
			}
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0005B2B8 File Offset: 0x000594B8
		internal void ThrowIfContextInvalid()
		{
			X509Helper2.ThrowIfContextInvalid(this.impl);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />.</summary>
		// Token: 0x060016F3 RID: 5875 RVA: 0x0005B2C5 File Offset: 0x000594C5
		public X509Chain() : this(false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />, который задает значение, определяющее, должен ли использоваться контекст компьютера.</summary>
		/// <param name="useMachineContext">Значение <see langword="true" /> для использования контекста компьютера; значение <see langword="false" /> для использования контекста текущего пользователя.</param>
		// Token: 0x060016F4 RID: 5876 RVA: 0x0005B2CE File Offset: 0x000594CE
		public X509Chain(bool useMachineContext)
		{
			this.impl = X509Helper2.CreateChainImpl(useMachineContext);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0005B2E2 File Offset: 0x000594E2
		internal X509Chain(X509ChainImpl impl)
		{
			X509Helper2.ThrowIfContextInvalid(impl);
			this.impl = impl;
		}

		/// <summary>Инициализирует в цепочке X.509 новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> с помощью дескриптора <see cref="T:System.IntPtr" />.</summary>
		/// <param name="chainContext">Дескриптор <see cref="T:System.IntPtr" />в цепочке X.509.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="chainContext" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="chainContext" /> указывает на недопустимый контекст.</exception>
		// Token: 0x060016F6 RID: 5878 RVA: 0x0005B2F7 File Offset: 0x000594F7
		[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
		public X509Chain(IntPtr chainContext)
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает дескриптор цепочки X.509.</summary>
		/// <returns>Дескриптор <see cref="T:System.IntPtr" />в цепочке X.509.</returns>
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0005B304 File Offset: 0x00059504
		[MonoTODO("Mono's X509Chain is fully managed. Always returns IntPtr.Zero.")]
		public IntPtr ChainContext
		{
			get
			{
				if (this.impl != null && this.impl.IsValid)
				{
					return this.impl.Handle;
				}
				return IntPtr.Zero;
			}
		}

		/// <summary>Возвращает коллекцию объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</returns>
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0005B32C File Offset: 0x0005952C
		public X509ChainElementCollection ChainElements
		{
			get
			{
				return this.Impl.ChainElements;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" />, используемый для создания цепочки сертификатов X.509.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" />, связанный с данной цепочкой X.509.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для этого свойства устанавливается значение <see langword="null" />.</exception>
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0005B339 File Offset: 0x00059539
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x0005B346 File Offset: 0x00059546
		public X509ChainPolicy ChainPolicy
		{
			get
			{
				return this.Impl.ChainPolicy;
			}
			set
			{
				this.Impl.ChainPolicy = value;
			}
		}

		/// <summary>Возвращает состояние каждого элемента в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainStatus" />.</returns>
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x0005B354 File Offset: 0x00059554
		public X509ChainStatus[] ChainStatus
		{
			get
			{
				return this.Impl.ChainStatus;
			}
		}

		/// <summary>Возвращает безопасный дескриптор для данного экземпляра <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />.</summary>
		/// <returns>Безопасный дескриптор для данного <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> экземпляра.</returns>
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x0000829A File Offset: 0x0000649A
		public SafeX509ChainHandle SafeHandle
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Создает цепочку X.509 с использованием политики, указанной в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" />.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		/// <returns>Значение <see langword="true" />, если сертификат X.509 действителен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Сертификат <paramref name="certificate" />недействителен, или значение равно <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Нечитаемый сертификат <paramref name="certificate" />.</exception>
		// Token: 0x060016FD RID: 5885 RVA: 0x0005B361 File Offset: 0x00059561
		[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		public bool Build(X509Certificate2 certificate)
		{
			return this.Impl.Build(certificate);
		}

		/// <summary>Очищает текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />.</summary>
		// Token: 0x060016FE RID: 5886 RVA: 0x0005B36F File Offset: 0x0005956F
		public void Reset()
		{
			this.Impl.Reset();
		}

		/// <summary>Создает объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> после запроса сопоставления, заданного в файле CryptoConfig, и сопоставляет цепочку с имеющимся сопоставлением.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />.</returns>
		// Token: 0x060016FF RID: 5887 RVA: 0x0005B37C File Offset: 0x0005957C
		public static X509Chain Create()
		{
			return (X509Chain)CryptoConfig.CreateFromName("X509Chain");
		}

		/// <summary>Освобождает все ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />.</summary>
		// Token: 0x06001700 RID: 5888 RVA: 0x0005B38D File Offset: 0x0005958D
		[SecuritySafeCritical]
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06001701 RID: 5889 RVA: 0x0005B39C File Offset: 0x0005959C
		protected virtual void Dispose(bool disposing)
		{
			if (this.impl != null)
			{
				this.impl.Dispose();
				this.impl = null;
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0005B3B8 File Offset: 0x000595B8
		~X509Chain()
		{
			this.Dispose(false);
		}

		// Token: 0x04000D02 RID: 3330
		private X509ChainImpl impl;
	}
}
