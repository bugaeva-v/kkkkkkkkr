using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;
using Unity;

namespace System.Transactions
{
	/// <summary>Представляет транзакцию.</summary>
	// Token: 0x0200001D RID: 29
	[Serializable]
	public class Transaction : IDisposable, ISerializable
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000022E2 File Offset: 0x000004E2
		internal List<IEnlistmentNotification> Volatiles
		{
			get
			{
				if (this.volatiles == null)
				{
					this.volatiles = new List<IEnlistmentNotification>();
				}
				return this.volatiles;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000022FD File Offset: 0x000004FD
		internal List<ISinglePhaseNotification> Durables
		{
			get
			{
				if (this.durables == null)
				{
					this.durables = new List<ISinglePhaseNotification>();
				}
				return this.durables;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002318 File Offset: 0x00000518
		internal IPromotableSinglePhaseNotification Pspe
		{
			get
			{
				return this.pspe;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002320 File Offset: 0x00000520
		internal Transaction(IsolationLevel isolationLevel)
		{
			this.dependents = new ArrayList();
			this.tag = Guid.NewGuid();
			base..ctor();
			this.info = new TransactionInformation();
			this.level = isolationLevel;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002350 File Offset: 0x00000550
		internal Transaction(Transaction other)
		{
			this.dependents = new ArrayList();
			this.tag = Guid.NewGuid();
			base..ctor();
			this.level = other.level;
			this.info = other.info;
			this.dependents = other.dependents;
			this.volatiles = other.Volatiles;
			this.durables = other.Durables;
			this.pspe = other.Pspe;
			this.TransactionCompletedInternal = other.TransactionCompletedInternal;
			this.internalTransaction = other;
		}

		/// <summary>Получает <see cref="T:System.Runtime.Serialization.SerializationInfo" /> вместе с данными, необходимыми для сериализации данной транзакции.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Конечный объект (см. <see cref="T:System.Runtime.Serialization.StreamingContext" />) для этой сериализации.</param>
		// Token: 0x06000052 RID: 82 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000053 RID: 83 RVA: 0x000023D4 File Offset: 0x000005D4
		// (remove) Token: 0x06000054 RID: 84 RVA: 0x0000240C File Offset: 0x0000060C
		internal event TransactionCompletedEventHandler TransactionCompletedInternal;

		/// <summary>Указывает, что транзакция завершена.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Попытка подписаться на данное событие для транзакции, которая была удалена.</exception>
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000055 RID: 85 RVA: 0x00002441 File Offset: 0x00000641
		// (remove) Token: 0x06000056 RID: 86 RVA: 0x00002464 File Offset: 0x00000664
		public event TransactionCompletedEventHandler TransactionCompleted
		{
			add
			{
				if (this.internalTransaction != null)
				{
					this.internalTransaction.TransactionCompleted += value;
				}
				this.TransactionCompletedInternal += value;
			}
			remove
			{
				if (this.internalTransaction != null)
				{
					this.internalTransaction.TransactionCompleted -= value;
				}
				this.TransactionCompletedInternal -= value;
			}
		}

		/// <summary>Возвращает или задает внешнюю транзакцию.</summary>
		/// <returns>Элемент <see cref="T:System.Transactions.Transaction" />, описывающий текущую транзакцию.</returns>
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002487 File Offset: 0x00000687
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002493 File Offset: 0x00000693
		public static Transaction Current
		{
			get
			{
				Transaction.EnsureIncompleteCurrentScope();
				return Transaction.CurrentInternal;
			}
			set
			{
				Transaction.EnsureIncompleteCurrentScope();
				Transaction.CurrentInternal = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000024A0 File Offset: 0x000006A0
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000024A7 File Offset: 0x000006A7
		internal static Transaction CurrentInternal
		{
			get
			{
				return Transaction.ambient;
			}
			set
			{
				Transaction.ambient = value;
			}
		}

		/// <summary>Получает уровень изоляции транзакции.</summary>
		/// <returns>Одно из значений <see cref="T:System.Transactions.IsolationLevel" />, указывающее уровень изоляции транзакции.</returns>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000024AF File Offset: 0x000006AF
		public IsolationLevel IsolationLevel
		{
			get
			{
				Transaction.EnsureIncompleteCurrentScope();
				return this.level;
			}
		}

		/// <summary>Извлекает дополнительные сведения о транзакции.</summary>
		/// <returns>Объект <see cref="T:System.Transactions.TransactionInformation" />, содержащий дополнительные сведения о транзакции.</returns>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000024BC File Offset: 0x000006BC
		public TransactionInformation TransactionInformation
		{
			get
			{
				Transaction.EnsureIncompleteCurrentScope();
				return this.info;
			}
		}

		/// <summary>Создает копию транзакции.</summary>
		/// <returns>Объект <see cref="T:System.Transactions.Transaction" />, являющийся копией текущего объекта транзакции.</returns>
		// Token: 0x0600005D RID: 93 RVA: 0x000024C9 File Offset: 0x000006C9
		public Transaction Clone()
		{
			return new Transaction(this);
		}

		/// <summary>Освобождает ресурсы, удерживаемые объектом.</summary>
		// Token: 0x0600005E RID: 94 RVA: 0x000024D1 File Offset: 0x000006D1
		public void Dispose()
		{
			if (this.TransactionInformation.Status == TransactionStatus.Active)
			{
				this.Rollback();
			}
		}

		/// <summary>Создает зависимую копию транзакции.</summary>
		/// <param name="cloneOption">Значение <see cref="T:System.Transactions.DependentCloneOption" />, определяющее тип создаваемой зависимой транзакции.</param>
		/// <returns>Объект <see cref="T:System.Transactions.DependentTransaction" />, представляющий зависимую копию.</returns>
		// Token: 0x0600005F RID: 95 RVA: 0x000024E8 File Offset: 0x000006E8
		[MonoTODO]
		public DependentTransaction DependentClone(DependentCloneOption cloneOption)
		{
			DependentTransaction dependentTransaction = new DependentTransaction(this, cloneOption);
			this.dependents.Add(dependentTransaction);
			return dependentTransaction;
		}

		/// <summary>Присоединяет диспетчер долгосрочных ресурсов, поддерживающий двухфазную фиксацию, для участия в транзакции.</summary>
		/// <param name="resourceManagerIdentifier">Уникальный идентификатор диспетчера ресурсов, который должен оставаться неизменным при сбое в работе диспетчера ресурсов или при перезагрузке.</param>
		/// <param name="enlistmentNotification">Объект, реализующий интерфейс <see cref="T:System.Transactions.IEnlistmentNotification" /> для получения уведомлений о двухфазной фиксации.</param>
		/// <param name="enlistmentOptions">
		///   <see cref="F:System.Transactions.EnlistmentOptions.EnlistDuringPrepareRequired" />, если диспетчер ресурсов будет выполнять дополнительные действия на этапе подготовки.</param>
		/// <returns>Объект <see cref="T:System.Transactions.Enlistment" />, который описывает перечисление.</returns>
		// Token: 0x06000060 RID: 96 RVA: 0x0000250B File Offset: 0x0000070B
		[MonoTODO("Only SinglePhase commit supported for durable resource managers.")]
		[PermissionSet(SecurityAction.LinkDemand)]
		public Enlistment EnlistDurable(Guid resourceManagerIdentifier, IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions)
		{
			throw new NotImplementedException("DTC unsupported, only SinglePhase commit supported for durable resource managers.");
		}

		/// <summary>Присоединяет диспетчер долгосрочных ресурсов, поддерживающий однофазную оптимизацию фиксации, для участия в транзакции.</summary>
		/// <param name="resourceManagerIdentifier">Уникальный идентификатор диспетчера ресурсов, который должен оставаться неизменным при сбое в работе диспетчера ресурсов или при перезагрузке.</param>
		/// <param name="singlePhaseNotification">Объект, реализующий интерфейс <see cref="T:System.Transactions.ISinglePhaseNotification" />, который должен быть способен получать уведомления об однофазной и двухфазной фиксации.</param>
		/// <param name="enlistmentOptions">
		///   <see cref="F:System.Transactions.EnlistmentOptions.EnlistDuringPrepareRequired" />, если диспетчер ресурсов будет выполнять дополнительные действия на этапе подготовки.</param>
		/// <returns>Объект <see cref="T:System.Transactions.Enlistment" />, который описывает перечисление.</returns>
		// Token: 0x06000061 RID: 97 RVA: 0x00002518 File Offset: 0x00000718
		[MonoTODO("Only Local Transaction Manager supported. Cannot have more than 1 durable resource per transaction. Only EnlistmentOptions.None supported yet.")]
		[PermissionSet(SecurityAction.LinkDemand)]
		public Enlistment EnlistDurable(Guid resourceManagerIdentifier, ISinglePhaseNotification singlePhaseNotification, EnlistmentOptions enlistmentOptions)
		{
			Transaction.EnsureIncompleteCurrentScope();
			if (this.pspe != null || this.Durables.Count > 0)
			{
				throw new NotImplementedException("DTC unsupported, multiple durable resource managers aren't supported.");
			}
			if (enlistmentOptions != EnlistmentOptions.None)
			{
				throw new NotImplementedException("EnlistmentOptions other than None aren't supported");
			}
			this.Durables.Add(singlePhaseNotification);
			return new Enlistment();
		}

		/// <summary>Присоединяет диспетчер ресурсов, имеющий внутреннюю транзакцию, с помощью повышаемого однофазного зачисления (PSPE).</summary>
		/// <param name="promotableSinglePhaseNotification">Интерфейс <see cref="T:System.Transactions.IPromotableSinglePhaseNotification" />, реализованный участником.</param>
		/// <returns>Реализация интерфейса <see cref="T:System.Transactions.SinglePhaseEnlistment" />, описывающая зачисление.</returns>
		// Token: 0x06000062 RID: 98 RVA: 0x0000256A File Offset: 0x0000076A
		public bool EnlistPromotableSinglePhase(IPromotableSinglePhaseNotification promotableSinglePhaseNotification)
		{
			Transaction.EnsureIncompleteCurrentScope();
			if (this.pspe != null || this.Durables.Count > 0)
			{
				return false;
			}
			this.pspe = promotableSinglePhaseNotification;
			this.pspe.Initialize();
			return true;
		}

		/// <summary>Задает идентификатор распределенной транзакции, созданный отличным от MSDTC активатором.</summary>
		/// <param name="promotableNotification">Интерфейс <see cref="T:System.Transactions.IPromotableSinglePhaseNotification" />, реализованный участником.</param>
		/// <param name="distributedTransactionIdentifier">Идентификатор транзакции, используемой диспетчером распределенных транзакций.</param>
		// Token: 0x06000063 RID: 99 RVA: 0x0000216A File Offset: 0x0000036A
		public void SetDistributedTransactionIdentifier(IPromotableSinglePhaseNotification promotableNotification, Guid distributedTransactionIdentifier)
		{
			throw new NotImplementedException();
		}

		/// <summary>Присоединяет диспетчер ресурсов, имеющий внутреннюю транзакцию, с помощью повышаемого однофазного зачисления (PSPE).</summary>
		/// <param name="promotableSinglePhaseNotification">Интерфейс <see cref="T:System.Transactions.IPromotableSinglePhaseNotification" />, реализованный участником.</param>
		/// <param name="promoterType">Тип обработчика распределенных транзакций.</param>
		/// <returns>Реализация интерфейса <see cref="T:System.Transactions.SinglePhaseEnlistment" />, описывающая зачисление.</returns>
		// Token: 0x06000064 RID: 100 RVA: 0x0000216A File Offset: 0x0000036A
		public bool EnlistPromotableSinglePhase(IPromotableSinglePhaseNotification promotableSinglePhaseNotification, Guid promoterType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает массив byte[], возвращенный методом Promote при повышении уровня транзакции.</summary>
		/// <returns>Массив byte[], возвращенный методом Promote при повышении уровня транзакции.</returns>
		// Token: 0x06000065 RID: 101 RVA: 0x0000216A File Offset: 0x0000036A
		public byte[] GetPromotedToken()
		{
			throw new NotImplementedException();
		}

		/// <summary>Однозначно определяет формат массива byte[], возвращенного методом Promote при повышении уровня транзакции.</summary>
		/// <returns>Guid, который однозначно определяет формат byte [] возвращенного методом Promote при повышении уровня транзакции.</returns>
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000216A File Offset: 0x0000036A
		public Guid PromoterType
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Включает диспетчер быстро изменяющихся ресурсов с поддержкой двухфазной фиксации для участия в транзакции.</summary>
		/// <param name="enlistmentNotification">Объект, который реализует интерфейс <see cref="T:System.Transactions.IEnlistmentNotification" /> для получения уведомлений о двухфазной фиксации.</param>
		/// <param name="enlistmentOptions">
		///   <see cref="F:System.Transactions.EnlistmentOptions.EnlistDuringPrepareRequired" />, если диспетчер ресурсов будет выполнять дополнительные действия на этапе подготовки.</param>
		/// <returns>Объект <see cref="T:System.Transactions.Enlistment" />, который описывает перечисление.</returns>
		// Token: 0x06000067 RID: 103 RVA: 0x0000259C File Offset: 0x0000079C
		[MonoTODO("EnlistmentOptions being ignored")]
		public Enlistment EnlistVolatile(IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions)
		{
			return this.EnlistVolatileInternal(enlistmentNotification, enlistmentOptions);
		}

		/// <summary>Присоединяет диспетчер переменных ресурсов, поддерживающий однофазную оптимизацию фиксации, для участия в транзакции.</summary>
		/// <param name="singlePhaseNotification">Объект, реализующий интерфейс <see cref="T:System.Transactions.ISinglePhaseNotification" />, который должен быть способен получать уведомления об однофазной и двухфазной фиксации.</param>
		/// <param name="enlistmentOptions">
		///   <see cref="F:System.Transactions.EnlistmentOptions.EnlistDuringPrepareRequired" />, если диспетчер ресурсов будет выполнять дополнительные действия на этапе подготовки.</param>
		/// <returns>Объект <see cref="T:System.Transactions.Enlistment" />, который описывает перечисление.</returns>
		// Token: 0x06000068 RID: 104 RVA: 0x0000259C File Offset: 0x0000079C
		[MonoTODO("EnlistmentOptions being ignored")]
		public Enlistment EnlistVolatile(ISinglePhaseNotification singlePhaseNotification, EnlistmentOptions enlistmentOptions)
		{
			return this.EnlistVolatileInternal(singlePhaseNotification, enlistmentOptions);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000025A6 File Offset: 0x000007A6
		private Enlistment EnlistVolatileInternal(IEnlistmentNotification notification, EnlistmentOptions options)
		{
			Transaction.EnsureIncompleteCurrentScope();
			this.Volatiles.Add(notification);
			return new Enlistment();
		}

		/// <summary>Продвигает и присоединяет диспетчер долгосрочных ресурсов, поддерживающий двухфазную фиксацию, для участия в транзакции.</summary>
		/// <param name="resourceManagerIdentifier">Уникальный идентификатор диспетчера ресурсов, который должен оставаться неизменным при сбое в работе диспетчера ресурсов или при перезагрузке.</param>
		/// <param name="promotableNotification">Объект, действующий в качестве делегата фиксации для нераспределенной транзакции, которая является внутренней для диспетчера ресурсов.</param>
		/// <param name="enlistmentNotification">Объект, реализующий интерфейс <see cref="T:System.Transactions.IEnlistmentNotification" /> для получения уведомлений о двухфазной фиксации.</param>
		/// <param name="enlistmentOptions">
		///   <see cref="F:System.Transactions.EnlistmentOptions.EnlistDuringPrepareRequired" />, если диспетчер ресурсов будет выполнять дополнительные действия на этапе подготовки.</param>
		// Token: 0x0600006A RID: 106 RVA: 0x000025BE File Offset: 0x000007BE
		[MonoTODO("Only Local Transaction Manager supported. Cannot have more than 1 durable resource per transaction.")]
		[PermissionSet(SecurityAction.LinkDemand)]
		public Enlistment PromoteAndEnlistDurable(Guid manager, IPromotableSinglePhaseNotification promotableNotification, ISinglePhaseNotification notification, EnlistmentOptions options)
		{
			throw new NotImplementedException("DTC unsupported, multiple durable resource managers aren't supported.");
		}

		/// <summary>Определяет, равны ли данная транзакция и указанный объект.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="obj" /> и данная транзакция идентичны, в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600006B RID: 107 RVA: 0x000025CA File Offset: 0x000007CA
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Transaction);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000025D8 File Offset: 0x000007D8
		private bool Equals(Transaction t)
		{
			return t == this || (t != null && this.level == t.level && this.info == t.info);
		}

		/// <summary>Проверяет, эквивалентны ли два указанные экземпляра <see cref="T:System.Transactions.Transaction" />.</summary>
		/// <param name="x">Экземпляр <see cref="T:System.Transactions.Transaction" />, который находится слева от оператора равенства.</param>
		/// <param name="y">Экземпляр класса <see cref="T:System.Transactions.Transaction" />, который находится справа от оператора равенства.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="x" /> и <paramref name="y" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600006D RID: 109 RVA: 0x00002603 File Offset: 0x00000803
		public static bool operator ==(Transaction x, Transaction y)
		{
			if (x == null)
			{
				return y == null;
			}
			return x.Equals(y);
		}

		/// <summary>Возвращает значение, указывающее, равны ли два экземпляра <see cref="T:System.Transactions.Transaction" />.</summary>
		/// <param name="x">Экземпляр <see cref="T:System.Transactions.Transaction" />, который находится слева от оператора неравенства.</param>
		/// <param name="y">Экземпляр класса <see cref="T:System.Transactions.Transaction" />, который находится справа от оператора неравенства.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="x" /> и <paramref name="y" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600006E RID: 110 RVA: 0x00002614 File Offset: 0x00000814
		public static bool operator !=(Transaction x, Transaction y)
		{
			return !(x == y);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600006F RID: 111 RVA: 0x00002620 File Offset: 0x00000820
		public override int GetHashCode()
		{
			return (int)(this.level ^ (IsolationLevel)this.info.GetHashCode() ^ (IsolationLevel)this.dependents.GetHashCode());
		}

		/// <summary>Выполняет откат транзакции (прерывает ее).</summary>
		// Token: 0x06000070 RID: 112 RVA: 0x00002640 File Offset: 0x00000840
		public void Rollback()
		{
			this.Rollback(null);
		}

		/// <summary>Выполняет откат транзакции (прерывает ее).</summary>
		/// <param name="e">Объяснение, почему произошел откат.</param>
		// Token: 0x06000071 RID: 113 RVA: 0x00002649 File Offset: 0x00000849
		public void Rollback(Exception e)
		{
			Transaction.EnsureIncompleteCurrentScope();
			this.Rollback(e, null);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002658 File Offset: 0x00000858
		internal void Rollback(Exception ex, object abortingEnlisted)
		{
			if (this.aborted)
			{
				this.FireCompleted();
				return;
			}
			if (this.info.Status == TransactionStatus.Committed)
			{
				throw new TransactionException("Transaction has already been committed. Cannot accept any new work.");
			}
			this.innerException = ex;
			SinglePhaseEnlistment singlePhaseEnlistment = new SinglePhaseEnlistment();
			foreach (IEnlistmentNotification enlistmentNotification in this.Volatiles)
			{
				if (enlistmentNotification != abortingEnlisted)
				{
					enlistmentNotification.Rollback(singlePhaseEnlistment);
				}
			}
			List<ISinglePhaseNotification> list = this.Durables;
			if (list.Count > 0 && list[0] != abortingEnlisted)
			{
				list[0].Rollback(singlePhaseEnlistment);
			}
			if (this.pspe != null && this.pspe != abortingEnlisted)
			{
				this.pspe.Rollback(singlePhaseEnlistment);
			}
			this.Aborted = true;
			this.FireCompleted();
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002738 File Offset: 0x00000938
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002740 File Offset: 0x00000940
		private bool Aborted
		{
			get
			{
				return this.aborted;
			}
			set
			{
				this.aborted = value;
				if (this.aborted)
				{
					this.info.Status = TransactionStatus.Aborted;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000275D File Offset: 0x0000095D
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002765 File Offset: 0x00000965
		internal TransactionScope Scope
		{
			get
			{
				return this.scope;
			}
			set
			{
				this.scope = value;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002770 File Offset: 0x00000970
		protected IAsyncResult BeginCommitInternal(AsyncCallback callback)
		{
			if (this.committed || this.committing)
			{
				throw new InvalidOperationException("Commit has already been called for this transaction.");
			}
			this.committing = true;
			this.asyncCommit = new Transaction.AsyncCommit(this.DoCommit);
			return this.asyncCommit.BeginInvoke(callback, null);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000027BE File Offset: 0x000009BE
		protected void EndCommitInternal(IAsyncResult ar)
		{
			this.asyncCommit.EndInvoke(ar);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000027CC File Offset: 0x000009CC
		internal void CommitInternal()
		{
			if (this.committed || this.committing)
			{
				throw new InvalidOperationException("Commit has already been called for this transaction.");
			}
			this.committing = true;
			try
			{
				this.DoCommit();
			}
			catch (TransactionException)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw new TransactionAbortedException("Transaction failed", ex);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002830 File Offset: 0x00000A30
		private void DoCommit()
		{
			if (this.Scope != null && (!this.Scope.IsComplete || !this.Scope.IsDisposed))
			{
				this.Rollback(null, null);
				this.CheckAborted();
			}
			List<IEnlistmentNotification> list = this.Volatiles;
			List<ISinglePhaseNotification> list2 = this.Durables;
			if (list.Count == 1 && list2.Count == 0)
			{
				ISinglePhaseNotification singlePhaseNotification = list[0] as ISinglePhaseNotification;
				if (singlePhaseNotification != null)
				{
					this.DoSingleCommit(singlePhaseNotification);
					this.Complete();
					return;
				}
			}
			if (list.Count > 0)
			{
				this.DoPreparePhase();
			}
			if (list2.Count > 0)
			{
				this.DoSingleCommit(list2[0]);
			}
			if (this.pspe != null)
			{
				this.DoSingleCommit(this.pspe);
			}
			if (list.Count > 0)
			{
				this.DoCommitPhase();
			}
			this.Complete();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000028F8 File Offset: 0x00000AF8
		private void Complete()
		{
			this.committing = false;
			this.committed = true;
			if (!this.aborted)
			{
				this.info.Status = TransactionStatus.Committed;
			}
			this.FireCompleted();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002922 File Offset: 0x00000B22
		internal void InitScope(TransactionScope scope)
		{
			this.CheckAborted();
			if (this.committed)
			{
				throw new InvalidOperationException("Commit has already been called on this transaction.");
			}
			this.Scope = scope;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002944 File Offset: 0x00000B44
		private static void PrepareCallbackWrapper(object state)
		{
			PreparingEnlistment preparingEnlistment = state as PreparingEnlistment;
			try
			{
				preparingEnlistment.EnlistmentNotification.Prepare(preparingEnlistment);
			}
			catch (Exception exception)
			{
				preparingEnlistment.Exception = exception;
				if (!preparingEnlistment.IsPrepared)
				{
					((ManualResetEvent)preparingEnlistment.WaitHandle).Set();
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000299C File Offset: 0x00000B9C
		private void DoPreparePhase()
		{
			foreach (IEnlistmentNotification enlisted in this.Volatiles)
			{
				PreparingEnlistment preparingEnlistment = new PreparingEnlistment(this, enlisted);
				ThreadPool.QueueUserWorkItem(new WaitCallback(Transaction.PrepareCallbackWrapper), preparingEnlistment);
				TimeSpan timeout = (this.Scope != null) ? this.Scope.Timeout : TransactionManager.DefaultTimeout;
				if (!preparingEnlistment.WaitHandle.WaitOne(timeout, true))
				{
					this.Aborted = true;
					throw new TimeoutException("Transaction timedout");
				}
				if (preparingEnlistment.Exception != null)
				{
					this.innerException = preparingEnlistment.Exception;
					this.Aborted = true;
					break;
				}
				if (!preparingEnlistment.IsPrepared)
				{
					this.Aborted = true;
					break;
				}
			}
			this.CheckAborted();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002A7C File Offset: 0x00000C7C
		private void DoCommitPhase()
		{
			foreach (IEnlistmentNotification enlistmentNotification in this.Volatiles)
			{
				Enlistment enlistment = new Enlistment();
				enlistmentNotification.Commit(enlistment);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002AD4 File Offset: 0x00000CD4
		private void DoSingleCommit(ISinglePhaseNotification single)
		{
			if (single == null)
			{
				return;
			}
			single.SinglePhaseCommit(new SinglePhaseEnlistment(this, single));
			this.CheckAborted();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002AED File Offset: 0x00000CED
		private void DoSingleCommit(IPromotableSinglePhaseNotification single)
		{
			if (single == null)
			{
				return;
			}
			single.SinglePhaseCommit(new SinglePhaseEnlistment(this, single));
			this.CheckAborted();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002B06 File Offset: 0x00000D06
		private void CheckAborted()
		{
			if (this.aborted || (this.Scope != null && this.Scope.IsAborted))
			{
				throw new TransactionAbortedException("Transaction has aborted", this.innerException);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002B36 File Offset: 0x00000D36
		private void FireCompleted()
		{
			if (this.TransactionCompletedInternal != null)
			{
				this.TransactionCompletedInternal(this, new TransactionEventArgs(this));
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002B52 File Offset: 0x00000D52
		private static void EnsureIncompleteCurrentScope()
		{
			if (Transaction.CurrentInternal == null)
			{
				return;
			}
			if (Transaction.CurrentInternal.Scope != null && Transaction.CurrentInternal.Scope.IsComplete)
			{
				throw new InvalidOperationException("The current TransactionScope is already complete");
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000021C9 File Offset: 0x000003C9
		internal Transaction()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400004A RID: 74
		[ThreadStatic]
		private static Transaction ambient;

		// Token: 0x0400004B RID: 75
		private Transaction internalTransaction;

		// Token: 0x0400004C RID: 76
		private IsolationLevel level;

		// Token: 0x0400004D RID: 77
		private TransactionInformation info;

		// Token: 0x0400004E RID: 78
		private ArrayList dependents;

		// Token: 0x0400004F RID: 79
		private List<IEnlistmentNotification> volatiles;

		// Token: 0x04000050 RID: 80
		private List<ISinglePhaseNotification> durables;

		// Token: 0x04000051 RID: 81
		private IPromotableSinglePhaseNotification pspe;

		// Token: 0x04000052 RID: 82
		private Transaction.AsyncCommit asyncCommit;

		// Token: 0x04000053 RID: 83
		private bool committing;

		// Token: 0x04000054 RID: 84
		private bool committed;

		// Token: 0x04000055 RID: 85
		private bool aborted;

		// Token: 0x04000056 RID: 86
		private TransactionScope scope;

		// Token: 0x04000057 RID: 87
		private Exception innerException;

		// Token: 0x04000058 RID: 88
		private Guid tag;

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000087 RID: 135
		private delegate void AsyncCommit();
	}
}
