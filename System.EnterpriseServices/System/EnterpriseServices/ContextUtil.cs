using System;
using System.Transactions;

namespace System.EnterpriseServices
{
	/// <summary>Получает сведения о контексте объекта COM+. Этот класс не наследуется.</summary>
	// Token: 0x02000019 RID: 25
	public sealed class ContextUtil
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000021E0 File Offset: 0x000003E0
		internal ContextUtil()
		{
		}

		/// <summary>Возвращает идентификатор GUID, который представляет действие, содержащее компонент.</summary>
		/// <returns>Идентификатор GUID для действия, если текущий контекст является ее частью действия; в противном случае — значение <see langword="GUID_NULL" />.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002085 File Offset: 0x00000285
		public static Guid ActivityId
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает идентификатор GUID для текущего приложения.</summary>
		/// <returns>Идентификатор GUID для текущего приложения.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является операционной системой Windows XP или более поздней версией.</exception>
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002085 File Offset: 0x00000285
		public static Guid ApplicationId
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает идентификатор GUID для текущего экземпляра приложения.</summary>
		/// <returns>Идентификатор GUID для текущего экземпляра приложения.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является операционной системой Windows XP или более поздней версией.</exception>
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002085 File Offset: 0x00000285
		public static Guid ApplicationInstanceId
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает идентификатор GUID для текущего контекста.</summary>
		/// <returns>Идентификатор GUID для текущего контекста.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002085 File Offset: 0x00000285
		public static Guid ContextId
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает бит <see langword="done" /> в контексте объекта COM+.</summary>
		/// <returns>Значение <see langword="true" />, если объект должен быть отключен при возврате методом значения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000228A File Offset: 0x0000048A
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002291 File Offset: 0x00000491
		public static bool DeactivateOnReturn
		{
			get
			{
				return ContextUtil.deactivateOnReturn;
			}
			set
			{
				ContextUtil.deactivateOnReturn = value;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли текущий контекст транзакционным.</summary>
		/// <returns>Значение <see langword="true" />, если текущий контекст является транзакционным; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002085 File Offset: 0x00000285
		public static bool IsInTransaction
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение, показывающее, включена ли безопасность на основе ролей в текущем контексте.</summary>
		/// <returns>Значение <see langword="true" />, если безопасность в текущем контексте включена; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002085 File Offset: 0x00000285
		public static bool IsSecurityEnabled
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает бит <see langword="consistent" /> в контексте объекта COM+.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.TransactionVote" />, или <see langword="Commit" /> или <see langword="Abort" />.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002299 File Offset: 0x00000499
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000022A0 File Offset: 0x000004A0
		[MonoTODO]
		public static TransactionVote MyTransactionVote
		{
			get
			{
				return ContextUtil.myTransactionVote;
			}
			set
			{
				ContextUtil.myTransactionVote = value;
			}
		}

		/// <summary>Возвращает идентификатор GUID текущего раздела.</summary>
		/// <returns>Идентификатор GUID для текущего раздела.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является операционной системой Windows XP или более поздней версией.</exception>
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002085 File Offset: 0x00000285
		public static Guid PartitionId
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает объект, описывающий текущую транзакцию DTC COM+.</summary>
		/// <returns>Объект, представляющий текущую транзакцию.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002085 File Offset: 0x00000285
		public static object Transaction
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает текущий контекст транзакции.</summary>
		/// <returns>Объект <see cref="T:System.Transactions.Transaction" />, представляющий текущий контекст транзакции.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002085 File Offset: 0x00000285
		public static Transaction SystemTransaction
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает идентификатор GUID текущей транзакции DTC COM+.</summary>
		/// <returns>Идентификатор GUID, предоставляющий текущую транзакцию DTC COM+, если она имеется.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002085 File Offset: 0x00000285
		public static Guid TransactionId
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Устанавливает для битов <see langword="consistent" /> и <see langword="done" /> значение <see langword="false" /> в контексте COM+.</summary>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		// Token: 0x06000056 RID: 86 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static void DisableCommit()
		{
			throw new NotImplementedException();
		}

		/// <summary>Устанавливает в контексте COM+ для бита <see langword="consistent" /> значение <see langword="true" />, а для бита <see langword="done" /> значение <see langword="false" />.</summary>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		// Token: 0x06000057 RID: 87 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static void EnableCommit()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает именованное свойство из контекста COM+.</summary>
		/// <param name="name">Имя запрошенного свойства.</param>
		/// <returns>Именованное свойство для контекста.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x06000058 RID: 88 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static object GetNamedProperty(string name)
		{
			throw new NotImplementedException();
		}

		/// <summary>Определяет, имеет ли вызывающий объект указанную роль.</summary>
		/// <param name="role">Имя проверяемой роли.</param>
		/// <returns>Значение <see langword="true" />, если вызывающий объект имеет указанную роль; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		// Token: 0x06000059 RID: 89 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static bool IsCallerInRole(string role)
		{
			throw new NotImplementedException();
		}

		/// <summary>Определяет, активирован ли обслуживаемый компонент в контексте по умолчанию. Обслуживаемые компоненты, в которых отсутствует информация каталога COM+, активируются в контексте по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если обслуживаемый компонент активируется в контексте по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600005A RID: 90 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static bool IsDefaultContext()
		{
			throw new NotImplementedException();
		}

		/// <summary>Устанавливает в контексте COM+ для бита <see langword="consistent" /> значение <see langword="false" />, а для бита <see langword="done" /> значение <see langword="true" />.</summary>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		// Token: 0x0600005B RID: 91 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static void SetAbort()
		{
			throw new NotImplementedException();
		}

		/// <summary>Устанавливает в контексте COM+ для бита <see langword="consistent" /> и для бита <see langword="done" /> значение <see langword="true" />.</summary>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		// Token: 0x0600005C RID: 92 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static void SetComplete()
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает именованное свойство для контекста COM+.</summary>
		/// <param name="name">Имя задаваемого свойства.</param>
		/// <param name="value">Объект, представляющий задаваемое значение свойства.</param>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст COM+ недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Эта платформа не является Windows 2000 или более поздней версии.</exception>
		// Token: 0x0600005D RID: 93 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static void SetNamedProperty(string name, object value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400004E RID: 78
		private static bool deactivateOnReturn;

		// Token: 0x0400004F RID: 79
		private static TransactionVote myTransactionVote;
	}
}
