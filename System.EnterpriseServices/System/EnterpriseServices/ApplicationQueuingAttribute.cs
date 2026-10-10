using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Включает поддержку очередей для отмеченной сборки и позволяет приложению считывать вызовы методов из очередей сообщений. Этот класс не наследуется.</summary>
	// Token: 0x02000010 RID: 16
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class ApplicationQueuingAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ApplicationQueuingAttribute" />, включая поддержку очередей для сборки и инициализируя объекты <see cref="P:System.EnterpriseServices.ApplicationQueuingAttribute.Enabled" />, <see cref="P:System.EnterpriseServices.ApplicationQueuingAttribute.QueueListenerEnabled" /> и <see cref="P:System.EnterpriseServices.ApplicationQueuingAttribute.MaxListenerThreads" />.</summary>
		// Token: 0x0600002E RID: 46 RVA: 0x0000216A File Offset: 0x0000036A
		public ApplicationQueuingAttribute()
		{
			this.enabled = true;
			this.queueListenerEnabled = false;
			this.maxListenerThreads = 0;
		}

		/// <summary>Возвращает или задает значение, показывающее, включена ли поддержка очередей.</summary>
		/// <returns>Значение <see langword="true" />, если поддержка очередей включена; в противном случае — значение <see langword="false" />. Значение по умолчанию, заданное конструктором, — <see langword="true" />.</returns>
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002187 File Offset: 0x00000387
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000218F File Offset: 0x0000038F
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		/// <summary>Возвращает или задает число потоков, используемых для извлечения сообщений из очереди и включения соответствующего компонента.</summary>
		/// <returns>Наибольшее число потоков, используемых для обработки сообщений, поступающих в очередь. По умолчанию используется значение ноль.</returns>
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002198 File Offset: 0x00000398
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000021A0 File Offset: 0x000003A0
		public int MaxListenerThreads
		{
			get
			{
				return this.maxListenerThreads;
			}
			set
			{
				this.maxListenerThreads = value;
			}
		}

		/// <summary>Возвращает или задает значение, показывающее, будет ли приложение принимать вызовы компонентов очереди от клиентов.</summary>
		/// <returns>Значение <see langword="true" />, если приложение принимает вызовы компонентов очереди, в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000021A9 File Offset: 0x000003A9
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000021B1 File Offset: 0x000003B1
		public bool QueueListenerEnabled
		{
			get
			{
				return this.queueListenerEnabled;
			}
			set
			{
				this.queueListenerEnabled = value;
			}
		}

		// Token: 0x0400003A RID: 58
		private bool enabled;

		// Token: 0x0400003B RID: 59
		private int maxListenerThreads;

		// Token: 0x0400003C RID: 60
		private bool queueListenerEnabled;
	}
}
