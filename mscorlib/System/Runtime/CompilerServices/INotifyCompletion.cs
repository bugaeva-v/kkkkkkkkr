using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Представляет операцию, которая планирует продолжение работы после ее завершения.</summary>
	// Token: 0x020007F6 RID: 2038
	public interface INotifyCompletion
	{
		/// <summary>Планирует действие продолжения, которое вызывается, когда завершается экземпляр.</summary>
		/// <param name="continuation">Действие, вызываемое по завершении операции.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuation" /> имеет значение NULL (Nothing в Visual Basic).</exception>
		// Token: 0x06004608 RID: 17928
		void OnCompleted(Action continuation);
	}
}
