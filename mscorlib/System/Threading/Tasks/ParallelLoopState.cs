using System;
using System.Diagnostics;
using Unity;

namespace System.Threading.Tasks
{
	/// <summary>Позволяет итерациям параллельных циклов взаимодействовать с другими итерациями. Экземпляр этого класса предоставляется каждому циклу классом <see cref="T:System.Threading.Tasks.Parallel" />; невозможно создавать экземпляры в коде.</summary>
	// Token: 0x02000328 RID: 808
	[DebuggerDisplay("ShouldExitCurrentIteration = {ShouldExitCurrentIteration}")]
	public class ParallelLoopState
	{
		// Token: 0x06002237 RID: 8759 RVA: 0x0007B930 File Offset: 0x00079B30
		internal ParallelLoopState(ParallelLoopStateFlags fbase)
		{
			this._flagsBase = fbase;
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x0007B93F File Offset: 0x00079B3F
		internal virtual bool InternalShouldExitCurrentIteration
		{
			get
			{
				throw new NotSupportedException("This method is not supported.");
			}
		}

		/// <summary>Получает значение, указывающее, следует ли текущей итерации цикла завершить работу на основе запросов от этой или других итераций.</summary>
		/// <returns>Значение <see langword="true" />, если текущая итерация должна завершать работу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x0007B94B File Offset: 0x00079B4B
		public bool ShouldExitCurrentIteration
		{
			get
			{
				return this.InternalShouldExitCurrentIteration;
			}
		}

		/// <summary>Получает значение, указывающее, вызывала ли какая-либо итерация цикла метод <see cref="M:System.Threading.Tasks.ParallelLoopState.Stop" />.</summary>
		/// <returns>Значение <see langword="true" />, если какая-либо итерация остановила цикл, вызвав метод <see cref="M:System.Threading.Tasks.ParallelLoopState.Stop" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0007B953 File Offset: 0x00079B53
		public bool IsStopped
		{
			get
			{
				return (this._flagsBase.LoopStateFlags & 4) != 0;
			}
		}

		/// <summary>Получает значение, указывающее, возникло ли в какой-либо итерации цикла исключение, не обработанное данной итерацией.</summary>
		/// <returns>Значение <see langword="true" />, если было вызвано необработанное исключение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x0007B965 File Offset: 0x00079B65
		public bool IsExceptional
		{
			get
			{
				return (this._flagsBase.LoopStateFlags & 1) != 0;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0007B93F File Offset: 0x00079B3F
		internal virtual long? InternalLowestBreakIteration
		{
			get
			{
				throw new NotSupportedException("This method is not supported.");
			}
		}

		/// <summary>Получает первую итерацию цикла, из которой был вызван метод <see cref="M:System.Threading.Tasks.ParallelLoopState.Break" />.</summary>
		/// <returns>Получает первую итерацию, из которой был вызван метод <see cref="M:System.Threading.Tasks.ParallelLoopState.Break" />. В случае цикла <see cref="M:System.Threading.Tasks.Parallel.ForEach``1(System.Collections.Concurrent.Partitioner{``0},System.Action{``0})" /> значение основано на внутренне создаваемом индексе.</returns>
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x0007B977 File Offset: 0x00079B77
		public long? LowestBreakIteration
		{
			get
			{
				return this.InternalLowestBreakIteration;
			}
		}

		/// <summary>Сообщает, что цикл <see cref="T:System.Threading.Tasks.Parallel" /> должен прекратить выполнение в первый удобный для системы момент.</summary>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Threading.Tasks.ParallelLoopState.Break" /> был вызван ранее. <see cref="M:System.Threading.Tasks.ParallelLoopState.Break" /> и <see cref="M:System.Threading.Tasks.ParallelLoopState.Stop" /> не могут использоваться в сочетании итерациями одного и того же цикла.</exception>
		// Token: 0x0600223E RID: 8766 RVA: 0x0007B97F File Offset: 0x00079B7F
		public void Stop()
		{
			this._flagsBase.Stop();
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0007B93F File Offset: 0x00079B3F
		internal virtual void InternalBreak()
		{
			throw new NotSupportedException("This method is not supported.");
		}

		/// <summary>Сообщает, что цикл <see cref="T:System.Threading.Tasks.Parallel" /> должен прекратить выполнение итераций после текущей в первый удобный для системы момент.</summary>
		/// <exception cref="T:System.InvalidOperationException">Был ранее вызван метод <see cref="M:System.Threading.Tasks.ParallelLoopState.Stop" />. <see cref="M:System.Threading.Tasks.ParallelLoopState.Break" /> и <see cref="M:System.Threading.Tasks.ParallelLoopState.Stop" /> не могут использоваться в сочетании итерациями одного и того же цикла.</exception>
		// Token: 0x06002240 RID: 8768 RVA: 0x0007B98C File Offset: 0x00079B8C
		public void Break()
		{
			this.InternalBreak();
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0007B994 File Offset: 0x00079B94
		internal static void Break(int iteration, ParallelLoopStateFlags32 pflags)
		{
			int num = 0;
			if (pflags.AtomicLoopStateUpdate(2, 13, ref num))
			{
				int lowestBreakIteration = pflags._lowestBreakIteration;
				if (iteration < lowestBreakIteration)
				{
					SpinWait spinWait = default(SpinWait);
					while (Interlocked.CompareExchange(ref pflags._lowestBreakIteration, iteration, lowestBreakIteration) != lowestBreakIteration)
					{
						spinWait.SpinOnce();
						lowestBreakIteration = pflags._lowestBreakIteration;
						if (iteration > lowestBreakIteration)
						{
							break;
						}
					}
				}
				return;
			}
			if ((num & 4) != 0)
			{
				throw new InvalidOperationException("Break was called after Stop was called.");
			}
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0007B9FC File Offset: 0x00079BFC
		internal static void Break(long iteration, ParallelLoopStateFlags64 pflags)
		{
			int num = 0;
			if (pflags.AtomicLoopStateUpdate(2, 13, ref num))
			{
				long lowestBreakIteration = pflags.LowestBreakIteration;
				if (iteration < lowestBreakIteration)
				{
					SpinWait spinWait = default(SpinWait);
					while (Interlocked.CompareExchange(ref pflags._lowestBreakIteration, iteration, lowestBreakIteration) != lowestBreakIteration)
					{
						spinWait.SpinOnce();
						lowestBreakIteration = pflags.LowestBreakIteration;
						if (iteration > lowestBreakIteration)
						{
							break;
						}
					}
				}
				return;
			}
			if ((num & 4) != 0)
			{
				throw new InvalidOperationException("Break was called after Stop was called.");
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x000173AD File Offset: 0x000155AD
		internal ParallelLoopState()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001C33 RID: 7219
		private readonly ParallelLoopStateFlags _flagsBase;
	}
}
