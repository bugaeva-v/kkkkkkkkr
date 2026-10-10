using System;

namespace System.Net.Sockets
{
	/// <summary>Тип асинхронной операции сокета, выполненной последней с этим объектом контекста.</summary>
	// Token: 0x020007AF RID: 1967
	public enum SocketAsyncOperation
	{
		/// <summary>Ни одна из операций сокета.</summary>
		// Token: 0x04002521 RID: 9505
		None,
		/// <summary>Операция Accept сокета.</summary>
		// Token: 0x04002522 RID: 9506
		Accept,
		/// <summary>Операция Connect сокета.</summary>
		// Token: 0x04002523 RID: 9507
		Connect,
		/// <summary>Операция Disconnect сокета.</summary>
		// Token: 0x04002524 RID: 9508
		Disconnect,
		/// <summary>Операция Receive сокета.</summary>
		// Token: 0x04002525 RID: 9509
		Receive,
		/// <summary>Операция ReceiveFrom сокета.</summary>
		// Token: 0x04002526 RID: 9510
		ReceiveFrom,
		/// <summary>Операция ReceiveMessageFrom сокета.</summary>
		// Token: 0x04002527 RID: 9511
		ReceiveMessageFrom,
		/// <summary>Операция Send сокета.</summary>
		// Token: 0x04002528 RID: 9512
		Send,
		/// <summary>Операция SendPackets сокета.</summary>
		// Token: 0x04002529 RID: 9513
		SendPackets,
		/// <summary>Операция SendTo сокета.</summary>
		// Token: 0x0400252A RID: 9514
		SendTo
	}
}
