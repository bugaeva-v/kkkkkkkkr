using System;
using System.Runtime.Serialization;
using Unity;

namespace System.Transactions
{
	/// <summary>Описывает клон транзакции, гарантирующий невозможность фиксации транзакции до тех пор, пока приложение не дойдет до выполнения последних действий, связанных с операциями по транзакции. Этот класс не наследуется.</summary>
	// Token: 0x0200000F RID: 15
	[MonoTODO("Not supported yet")]
	[Serializable]
	public sealed class DependentTransaction : Transaction, ISerializable
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000021A0 File Offset: 0x000003A0
		internal DependentTransaction(Transaction parent, DependentCloneOption option) : base(parent.IsolationLevel)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000021AE File Offset: 0x000003AE
		internal bool Completed
		{
			get
			{
				return this.completed;
			}
		}

		/// <summary>Пытается завершить зависимую транзакцию.</summary>
		/// <exception cref="T:System.Transactions.TransactionException">Любая попытка выполнения дополнительных операций по транзакции после вызова этого метода. К ним относится вызов методов, таких как <see cref="Overload:System.Transactions.Transaction.EnlistVolatile" />, <see cref="Overload:System.Transactions.Transaction.EnlistDurable" />, <see cref="M:System.Transactions.Transaction.Clone" />, <see cref="M:System.Transactions.Transaction.DependentClone(System.Transactions.DependentCloneOption)" />, или какие-либо операции сериализации по транзакции.</exception>
		// Token: 0x06000026 RID: 38 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		public void Complete()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021B6 File Offset: 0x000003B6
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			this.completed = info.GetBoolean("completed");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000021C9 File Offset: 0x000003C9
		internal DependentTransaction()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000032 RID: 50
		private bool completed;
	}
}
