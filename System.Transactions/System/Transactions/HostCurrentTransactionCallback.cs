using System;

namespace System.Transactions
{
	/// <summary>Предоставляет механизм для обеспечения средой внешнего размещения собственного представления по умолчанию для свойства <see cref="P:System.Transactions.Transaction.Current" />.</summary>
	/// <returns>Объект <see cref="T:System.Transactions.Transaction" />.</returns>
	// Token: 0x0200000B RID: 11
	// (Invoke) Token: 0x06000019 RID: 25
	public delegate Transaction HostCurrentTransactionCallback();
}
