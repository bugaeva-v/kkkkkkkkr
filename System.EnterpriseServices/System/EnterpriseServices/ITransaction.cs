using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Соответствует интерфейсу <see langword="ITransaction" /> координатора распределенных транзакций (DTC) и поддерживается объектами, полученными посредством объекта <see cref="P:System.EnterpriseServices.ContextUtil.Transaction" />.</summary>
	// Token: 0x0200002D RID: 45
	[Guid("0FB15084-AF41-11CE-BD2B-204C4F4F5020")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface ITransaction
	{
		/// <summary>Отменяет транзакцию.</summary>
		/// <param name="pboidReason">Дополнительный объект <see cref="T:System.EnterpriseServices.BOID" />, указывающий причину отмены транзакции. Этот параметр может иметь значение <see langword="null" />, что говорит об отсутствии причин для прерывания.</param>
		/// <param name="fRetaining">Должно иметь значение <see langword="false" />.</param>
		/// <param name="fAsync">Если параметр <paramref name="fAsync" /> имеет значение <see langword="true" />, выполняется асинхронная отмена и для изучения результата транзакции вызывающий объект должен использовать <see langword="ITransactionOutcomeEvents" />.</param>
		// Token: 0x0600008F RID: 143
		void Abort(ref BOID pboidReason, int fRetaining, int fAsync);

		/// <summary>Завершает транзакцию.</summary>
		/// <param name="fRetaining">Должно иметь значение <see langword="false" />.</param>
		/// <param name="grfTC">Значение, взятое из перечисления OLE DB <see langword="XACTTC" />.</param>
		/// <param name="grfRM">Должен равняться нулю.</param>
		// Token: 0x06000090 RID: 144
		void Commit(int fRetaining, int grfTC, int grfRM);

		/// <summary>Возвращает сведения об объекте транзакции.</summary>
		/// <param name="pinfo">Указатель на структуру <see cref="T:System.EnterpriseServices.XACTTRANSINFO" />, отведенную для вызывающего объекта, которая будет получать сведения о транзакции. Значение не должно быть равно <see langword="null" />.</param>
		// Token: 0x06000091 RID: 145
		void GetTransactionInfo(out XACTTRANSINFO pinfo);
	}
}
