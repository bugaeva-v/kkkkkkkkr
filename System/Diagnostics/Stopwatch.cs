using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	/// <summary>Предоставляет набор методов и свойств, которые можно использовать для точного измерения затраченного времени.</summary>
	// Token: 0x02000280 RID: 640
	public class Stopwatch
	{
		/// <summary>Получает текущее число тактов временного механизма.</summary>
		/// <returns>Длинное целое число со знаком, представляющее значение счетчика тактов базового механизма таймера.</returns>
		// Token: 0x0600145A RID: 5210
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTimestamp();

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Stopwatch" />, задает свойство затраченного времени равным нулю и запускает измерение затраченного времени.</summary>
		/// <returns>Экземпляр <see cref="T:System.Diagnostics.Stopwatch" />, который только что начал измерять затраченное время.</returns>
		// Token: 0x0600145B RID: 5211 RVA: 0x0005313A File Offset: 0x0005133A
		public static Stopwatch StartNew()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			return stopwatch;
		}

		/// <summary>Получает общее затраченное время, измеренное текущим экземпляром.</summary>
		/// <returns>Доступный только для чтения экземпляр <see cref="T:System.TimeSpan" /> представляет общее затраченное время, измеренное текущим экземпляром.</returns>
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x00053147 File Offset: 0x00051347
		public TimeSpan Elapsed
		{
			get
			{
				if (Stopwatch.IsHighResolution)
				{
					return TimeSpan.FromTicks(this.ElapsedTicks / (Stopwatch.Frequency / 10000000L));
				}
				return TimeSpan.FromTicks(this.ElapsedTicks);
			}
		}

		/// <summary>Получает общее затраченное время в миллисекундах, измеренное текущим экземпляром.</summary>
		/// <returns>Доступное только для чтения длинное целое число, представляющее общее число миллисекунд, измеренное текущим экземпляром.</returns>
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00053174 File Offset: 0x00051374
		public long ElapsedMilliseconds
		{
			get
			{
				if (Stopwatch.IsHighResolution)
				{
					return this.ElapsedTicks / (Stopwatch.Frequency / 1000L);
				}
				return checked((long)this.Elapsed.TotalMilliseconds);
			}
		}

		/// <summary>Получает общее затраченное время в тактах таймера, измеренное текущим экземпляром.</summary>
		/// <returns>Доступное только для чтения длинное целое число, представляющее общее число тактов таймера, измеренное текущим экземпляром.</returns>
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x000531AB File Offset: 0x000513AB
		public long ElapsedTicks
		{
			get
			{
				if (!this.is_running)
				{
					return this.elapsed;
				}
				return Stopwatch.GetTimestamp() - this.started + this.elapsed;
			}
		}

		/// <summary>Получает значение, указывающее, запущен ли таймер <see cref="T:System.Diagnostics.Stopwatch" />.</summary>
		/// <returns>Значение <see langword="true" />, если экземпляр <see cref="T:System.Diagnostics.Stopwatch" /> в настоящее время выполняется и измеряет затраченное время интервала; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x000531CF File Offset: 0x000513CF
		public bool IsRunning
		{
			get
			{
				return this.is_running;
			}
		}

		/// <summary>Останавливает измерение интервала времени и обнуляет затраченное время.</summary>
		// Token: 0x06001461 RID: 5217 RVA: 0x000531D7 File Offset: 0x000513D7
		public void Reset()
		{
			this.elapsed = 0L;
			this.is_running = false;
		}

		/// <summary>Запускает или возобновляет измерение затраченного времени для интервала.</summary>
		// Token: 0x06001462 RID: 5218 RVA: 0x000531E8 File Offset: 0x000513E8
		public void Start()
		{
			if (this.is_running)
			{
				return;
			}
			this.started = Stopwatch.GetTimestamp();
			this.is_running = true;
		}

		/// <summary>Останавливает измерение затраченного времени для интервала.</summary>
		// Token: 0x06001463 RID: 5219 RVA: 0x00053205 File Offset: 0x00051405
		public void Stop()
		{
			if (!this.is_running)
			{
				return;
			}
			this.elapsed += Stopwatch.GetTimestamp() - this.started;
			if (this.elapsed < 0L)
			{
				this.elapsed = 0L;
			}
			this.is_running = false;
		}

		/// <summary>Останавливает измерение интервала времени, обнуляет затраченное время и начинает измерение затраченного времени.</summary>
		// Token: 0x06001464 RID: 5220 RVA: 0x00053242 File Offset: 0x00051442
		public void Restart()
		{
			this.started = Stopwatch.GetTimestamp();
			this.elapsed = 0L;
			this.is_running = true;
		}

		/// <summary>Получает частоту таймера в виде количества тактов в секунду. Это поле доступно только для чтения.</summary>
		// Token: 0x04000B62 RID: 2914
		public static readonly long Frequency = 10000000L;

		/// <summary>Указывает, зависит ли таймер от счетчика производительности высокого разрешения. Это поле доступно только для чтения.</summary>
		// Token: 0x04000B63 RID: 2915
		public static readonly bool IsHighResolution = true;

		// Token: 0x04000B64 RID: 2916
		private long elapsed;

		// Token: 0x04000B65 RID: 2917
		private long started;

		// Token: 0x04000B66 RID: 2918
		private bool is_running;
	}
}
