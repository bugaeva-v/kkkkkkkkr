using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Представляет объект типа awaiter, который планирует продолжение работы после завершения операции await.</summary>
	// Token: 0x020007F7 RID: 2039
	public interface ICriticalNotifyCompletion : INotifyCompletion
	{
		/// <summary>Планирует действие продолжения, которое вызывается, когда завершается экземпляр.</summary>
		/// <param name="continuation">Действие, вызываемое по завершении операции.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuation" /> имеет значение NULL (Nothing в Visual Basic).</exception>
		// Token: 0x06004609 RID: 17929
		void UnsafeOnCompleted(Action continuation);
	}
}
