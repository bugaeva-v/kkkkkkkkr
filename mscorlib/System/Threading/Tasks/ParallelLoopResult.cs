using System;

namespace System.Threading.Tasks
{
	/// <summary>Предоставляет состояние выполнения цикла <see cref="T:System.Threading.Tasks.Parallel" />.</summary>
	// Token: 0x0200032E RID: 814
	public struct ParallelLoopResult
	{
		/// <summary>Получает значение, указывающее, дошел ли цикл до завершения, то есть все итерации цикла выполнены и он не получил запроса на преждевременное прерывание работы.</summary>
		/// <returns>Значение true, если цикл был завершен; в противном случае — значение false.</returns>
		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x0007BD37 File Offset: 0x00079F37
		public bool IsCompleted
		{
			get
			{
				return this._completed;
			}
		}

		/// <summary>Получает индекс нижней итерации, из которой был вызван метод <see cref="M:System.Threading.Tasks.ParallelLoopState.Break" />.</summary>
		/// <returns>Возвращает целое число, представляющее самую нижнюю итерацию, из которой был вызван оператор Break.</returns>
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x0007BD3F File Offset: 0x00079F3F
		public long? LowestBreakIteration
		{
			get
			{
				return this._lowestBreakIteration;
			}
		}

		// Token: 0x04001C40 RID: 7232
		internal bool _completed;

		// Token: 0x04001C41 RID: 7233
		internal long? _lowestBreakIteration;
	}
}
