using System;

namespace System.Transactions
{
	/// <summary>Содержит дополнительную информацию, которая задает поведение транзакции.</summary>
	// Token: 0x02000027 RID: 39
	public struct TransactionOptions
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00002DD7 File Offset: 0x00000FD7
		internal TransactionOptions(IsolationLevel level, TimeSpan timeout)
		{
			this.level = level;
			this.timeout = timeout;
		}

		/// <summary>Получает или задает уровень изоляции для транзакции.</summary>
		/// <returns>Значение перечисления <see cref="T:System.Transactions.IsolationLevel" />, задающее уровень изоляции транзакции.</returns>
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002DE7 File Offset: 0x00000FE7
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002DEF File Offset: 0x00000FEF
		public IsolationLevel IsolationLevel
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
			}
		}

		/// <summary>Получает или задает период ожидания для данной транзакции.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, задающее период ожидания для транзакции.</returns>
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002DF8 File Offset: 0x00000FF8
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002E00 File Offset: 0x00001000
		public TimeSpan Timeout
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

		/// <summary>Проверяет, эквивалентны ли два указанные экземпляра <see cref="T:System.Transactions.TransactionOptions" />.</summary>
		/// <param name="x">Экземпляр <see cref="T:System.Transactions.TransactionOptions" />, который находится слева от оператора равенства.</param>
		/// <param name="y">Экземпляр класса <see cref="T:System.Transactions.TransactionOptions" />, который находится справа от оператора равенства.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="x" /> и <paramref name="y" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000BC RID: 188 RVA: 0x00002E09 File Offset: 0x00001009
		public static bool operator ==(TransactionOptions x, TransactionOptions y)
		{
			return x.level == y.level && x.timeout == y.timeout;
		}

		/// <summary>Возвращает значение, указывающее, равны ли два экземпляра <see cref="T:System.Transactions.TransactionOptions" />.</summary>
		/// <param name="x">Экземпляр <see cref="T:System.Transactions.TransactionOptions" />, который находится слева от оператора равенства.</param>
		/// <param name="y">Экземпляр класса <see cref="T:System.Transactions.TransactionOptions" />, который находится справа от оператора равенства.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="x" /> и <paramref name="y" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000BD RID: 189 RVA: 0x00002E2C File Offset: 0x0000102C
		public static bool operator !=(TransactionOptions x, TransactionOptions y)
		{
			return x.level != y.level || x.timeout != y.timeout;
		}

		/// <summary>Определяет равенство данного экземпляра <see cref="T:System.Transactions.TransactionOptions" /> и указанного объекта.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" /> если <paramref name="obj" /> и данный экземпляр <see cref="T:System.Transactions.TransactionOptions" /> идентичны, в противном случае — <see langword="false" />.</returns>
		// Token: 0x060000BE RID: 190 RVA: 0x00002E4F File Offset: 0x0000104F
		public override bool Equals(object obj)
		{
			return obj is TransactionOptions && this == (TransactionOptions)obj;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060000BF RID: 191 RVA: 0x00002E6C File Offset: 0x0000106C
		public override int GetHashCode()
		{
			return (int)(this.level ^ (IsolationLevel)this.timeout.GetHashCode());
		}

		// Token: 0x04000065 RID: 101
		private IsolationLevel level;

		// Token: 0x04000066 RID: 102
		private TimeSpan timeout;
	}
}
