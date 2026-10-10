using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Представляет конечные автоматы, созданные для асинхронных методов. Этот тип предназначен только для внутреннего использования компиляторами.</summary>
	// Token: 0x020007F5 RID: 2037
	public interface IAsyncStateMachine
	{
		/// <summary>Перемещает конечный автомат в его следующее состояние.</summary>
		// Token: 0x06004606 RID: 17926
		void MoveNext();

		/// <summary>Настраивает конечный автомат с размещенной в куче репликой.</summary>
		/// <param name="stateMachine">Размещенная в куче реплика.</param>
		// Token: 0x06004607 RID: 17927
		void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
