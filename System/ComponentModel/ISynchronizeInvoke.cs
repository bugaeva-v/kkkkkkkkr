using System;

namespace System.ComponentModel
{
	/// <summary>Обеспечивает возможность синхронного или асинхронного выполнения делегата.</summary>
	// Token: 0x02000371 RID: 881
	public interface ISynchronizeInvoke
	{
		/// <summary>Возвращает значение, показывающее, должен ли вызывающий объект вызвать метод <see cref="M:System.ComponentModel.ISynchronizeInvoke.Invoke(System.Delegate,System.Object[])" /> при вызове объекта, реализующего этот интерфейс.</summary>
		/// <returns>Значение <see langword="true" />, если вызывающий объект должен вызвать метод <see cref="M:System.ComponentModel.ISynchronizeInvoke.Invoke(System.Delegate,System.Object[])" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001D1C RID: 7452
		bool InvokeRequired { get; }

		/// <summary>Асинхронно выполняет делегата для потока, создавшего этот объект.</summary>
		/// <param name="method">Делегат <see cref="T:System.Delegate" /> для метода, принимающего параметры в том же количестве и того же типа, что и содержащиеся в <paramref name="args" />.</param>
		/// <param name="args">Массив типа <see cref="T:System.Object" /> для передачи аргументов в заданный метод. Это может быть значение <see langword="null" />, если аргументы не требуются.</param>
		/// <returns>Интерфейс <see cref="T:System.IAsyncResult" />, который представляет асинхронную операцию, запущенную вызовом этого метода.</returns>
		// Token: 0x06001D1D RID: 7453
		IAsyncResult BeginInvoke(Delegate method, object[] args);

		/// <summary>Ожидает завершения процесса, запущенного вызовом метода <see cref="M:System.ComponentModel.ISynchronizeInvoke.BeginInvoke(System.Delegate,System.Object[])" />, а затем возвращает значение, созданное процессом.</summary>
		/// <param name="result">Интерфейс <see cref="T:System.IAsyncResult" />, представляющий асинхронную операцию, запущенную вызовом метода <see cref="M:System.ComponentModel.ISynchronizeInvoke.BeginInvoke(System.Delegate,System.Object[])" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий возвращаемое значение, сформированное асинхронной операцией.</returns>
		// Token: 0x06001D1E RID: 7454
		object EndInvoke(IAsyncResult result);

		/// <summary>Синхронно выполняет делегат в потоке, создавшем этот объект, а затем выполняет маршалинг вызова в текущий поток.</summary>
		/// <param name="method">Объект <see cref="T:System.Delegate" />, который содержит вызываемый метод, используемый в контексте потока для управления.</param>
		/// <param name="args">Массив типа <see cref="T:System.Object" />, представляющий аргументы для передачи в заданный метод. Это может быть значение <see langword="null" />, если аргументы не требуются.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий возвращаемое из вызванного делегата значение, или значение <see langword="null" />, если делегат не возвращает значение.</returns>
		// Token: 0x06001D1F RID: 7455
		object Invoke(Delegate method, object[] args);
	}
}
