using System;

namespace System.Net
{
	/// <summary>Диспетчер времени ожидания, используемый для объекта <see cref="T:System.Net.HttpListener" />.</summary>
	// Token: 0x02000691 RID: 1681
	public class HttpListenerTimeoutManager
	{
		/// <summary>Получает или задает Время в секундах, разрешенное для прибытия тела сущности запроса.</summary>
		/// <returns>Время в секундах, разрешенное для прибытия тела сущности запроса.</returns>
		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public TimeSpan EntityBody
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает время в секундах, разрешенное для <see cref="T:System.Net.HttpListener" />, для утечки тела сущности в подключении с проверкой активности.</summary>
		/// <returns>Время в секундах, разрешенное для <see cref="T:System.Net.HttpListener" /> для утечки тела сущности на подключении активности.</returns>
		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public TimeSpan DrainEntityBody
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает Время в секундах, пока запросу разрешается оставаться в очереди пока <see cref="T:System.Net.HttpListener" /> его подбирает.</summary>
		/// <returns>Время в секундах, пока запросу разрешается оставаться в очереди пока <see cref="T:System.Net.HttpListener" /> его подбирает.</returns>
		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public TimeSpan RequestQueue
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает Время в секундах, разрешенное для бездействия подключения.</summary>
		/// <returns>Время в секундах, разрешенное для бездействия подключения.</returns>
		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x06003561 RID: 13665 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public TimeSpan IdleConnection
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает Время в секундах, разрешенное для анализа заголовка запроса <see cref="T:System.Net.HttpListener" />.</summary>
		/// <returns>Время в секундах, разрешенное для анализа заголовка запроса <see cref="T:System.Net.HttpListener" />.</returns>
		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public TimeSpan HeaderWait
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает Минимум частоты отправки, в байтах в секунду, для ответа.</summary>
		/// <returns>Минимум частоты отправки, в байтах в секунду, для ответа.</returns>
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public long MinSendBytesPerSecond
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
