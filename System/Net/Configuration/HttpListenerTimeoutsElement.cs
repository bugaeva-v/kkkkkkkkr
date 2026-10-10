using System;
using System.Configuration;
using Unity;

namespace System.Net.Configuration
{
	/// <summary>Представляет элемент истечений времени ожидания <see cref="T:System.Net.HttpListener" /> в файле конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x02000876 RID: 2166
	public sealed class HttpListenerTimeoutsElement : ConfigurationElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.HttpListenerTimeoutsElement" />.</summary>
		// Token: 0x060044AB RID: 17579 RVA: 0x00013BCA File Offset: 0x00011DCA
		public HttpListenerTimeoutsElement()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает время в секундах, разрешенное для <see cref="T:System.Net.HttpListener" />, для утечки тела сущности на подключении с проверкой активности.</summary>
		/// <returns>Время в секундах, разрешенное для <see cref="T:System.Net.HttpListener" /> для утечки тела сущности на подключении активности.</returns>
		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x000ED0D8 File Offset: 0x000EB2D8
		public TimeSpan DrainEntityBody
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(TimeSpan);
			}
		}

		/// <summary>Получает Время в секундах, разрешенное для прибытия тела сущности запроса.</summary>
		/// <returns>Время в секундах, разрешенное для прибытия тела сущности запроса.</returns>
		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x060044AD RID: 17581 RVA: 0x000ED0F4 File Offset: 0x000EB2F4
		public TimeSpan EntityBody
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(TimeSpan);
			}
		}

		/// <summary>Получает Время в секундах, разрешенное для анализа заголовка запроса <see cref="T:System.Net.HttpListener" />.</summary>
		/// <returns>Время в секундах, разрешенное для анализа заголовка запроса <see cref="T:System.Net.HttpListener" />.</returns>
		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x000ED110 File Offset: 0x000EB310
		public TimeSpan HeaderWait
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(TimeSpan);
			}
		}

		/// <summary>Получает Время в секундах, разрешенное для бездействия подключения.</summary>
		/// <returns>Время в секундах, разрешенное для бездействия подключения.</returns>
		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x000ED12C File Offset: 0x000EB32C
		public TimeSpan IdleConnection
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(TimeSpan);
			}
		}

		/// <summary>Получает Минимум частоты отправки, в байтах в секунду, для ответа.</summary>
		/// <returns>Минимум частоты отправки, в байтах в секунду, для ответа.</returns>
		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x000ED148 File Offset: 0x000EB348
		public long MinSendBytesPerSecond
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0L;
			}
		}

		/// <summary>Получает Время в секундах, пока запросу разрешается оставаться в очереди пока <see cref="T:System.Net.HttpListener" /> его подбирает.</summary>
		/// <returns>Время в секундах, пока запросу разрешается оставаться в очереди пока <see cref="T:System.Net.HttpListener" /> его подбирает.</returns>
		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x060044B1 RID: 17585 RVA: 0x000ED164 File Offset: 0x000EB364
		public TimeSpan RequestQueue
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(TimeSpan);
			}
		}
	}
}
