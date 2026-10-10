using System;
using System.Runtime.InteropServices;

namespace System.Transactions
{
	/// <summary>Описывает транзакцию DTC.</summary>
	// Token: 0x02000013 RID: 19
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDtcTransaction
	{
		/// <summary>Прерывает транзакцию.</summary>
		/// <param name="reason">Дополнительный объект <see cref="T:System.EnterpriseServices.BOID" />, указывающий причину отмены транзакции. Этот параметр может иметь значение <see langword="null" />, что говорит об отсутствии причин для прерывания.</param>
		/// <param name="retaining">Это значение должно быть равно <see langword="false" />.</param>
		/// <param name="async">Если параметр <paramref name="async" /> имеет значение <see langword="true" />, выполняется асинхронная отмена и для изучения результата транзакции вызывающий объект должен использовать <see langword="ITransactionOutcomeEvents" />.</param>
		// Token: 0x0600002C RID: 44
		void Abort(IntPtr reason, int retaining, int async);

		/// <summary>Фиксирует транзакцию.</summary>
		/// <param name="retaining">Это значение должно быть равно <see langword="false" />.</param>
		/// <param name="commitType">Значение, взятое из перечисления OLE DB <see langword="XACTTC" />.</param>
		/// <param name="reserved">Это значение должно быть равно нулю.</param>
		// Token: 0x0600002D RID: 45
		void Commit(int retaining, int commitType, int reserved);

		/// <summary>Извлекает сведения о транзакции.</summary>
		/// <param name="transactionInformation">Указатель на структуру <see cref="T:System.EnterpriseServices.XACTTRANSINFO" />, отведенную для вызывающего объекта, которая будет получать сведения о транзакции. Это значение не должно быть равно <see langword="null" />.</param>
		// Token: 0x0600002E RID: 46
		void GetTransactionInfo(IntPtr transactionInformation);
	}
}
