using System;

namespace System
{
	/// <summary>Предоставляет механизм для освобождения неуправляемых ресурсов.</summary>
	// Token: 0x0200013D RID: 317
	public interface IDisposable
	{
		/// <summary>Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.</summary>
		// Token: 0x06000BFD RID: 3069
		void Dispose();
	}
}
