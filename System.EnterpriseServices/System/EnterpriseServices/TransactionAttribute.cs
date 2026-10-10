using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Указывает тип транзакции, доступной для объекта с атрибутами. Допустимые значения являются членами перечисления <see cref="T:System.EnterpriseServices.TransactionOption" />.</summary>
	// Token: 0x02000051 RID: 81
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class TransactionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.TransactionAttribute" /> и задает запрошенный тип транзакции компонента для объекта <see cref="F:System.EnterpriseServices.TransactionOption.Required" />.</summary>
		// Token: 0x0600014E RID: 334 RVA: 0x00002664 File Offset: 0x00000864
		public TransactionAttribute() : this(TransactionOption.Required)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.TransactionAttribute" />, указывая тип транзакции.</summary>
		/// <param name="val">Указанный тип транзакции, значение <see cref="T:System.EnterpriseServices.TransactionOption" />.</param>
		// Token: 0x0600014F RID: 335 RVA: 0x0000266D File Offset: 0x0000086D
		public TransactionAttribute(TransactionOption val)
		{
			this.isolation = TransactionIsolationLevel.Serializable;
			this.timeout = -1;
			this.val = val;
		}

		/// <summary>Получает или задает уровень изоляции транзакции.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.TransactionIsolationLevel" />.</returns>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000268A File Offset: 0x0000088A
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002692 File Offset: 0x00000892
		public TransactionIsolationLevel Isolation
		{
			get
			{
				return this.isolation;
			}
			set
			{
				this.isolation = value;
			}
		}

		/// <summary>Получает или задает время ожидания для данной транзакции.</summary>
		/// <returns>Время ожидания транзакции в секундах.</returns>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000269B File Offset: 0x0000089B
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000026A3 File Offset: 0x000008A3
		public int Timeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				this.timeout = value;
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.EnterpriseServices.TransactionOption" /> для транзакции и дополнительно отключает службу транзакции.</summary>
		/// <returns>Указанный тип транзакции, значение <see cref="T:System.EnterpriseServices.TransactionOption" />.</returns>
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000026AC File Offset: 0x000008AC
		public TransactionOption Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x04000098 RID: 152
		private TransactionIsolationLevel isolation;

		// Token: 0x04000099 RID: 153
		private int timeout;

		// Token: 0x0400009A RID: 154
		private TransactionOption val;
	}
}
