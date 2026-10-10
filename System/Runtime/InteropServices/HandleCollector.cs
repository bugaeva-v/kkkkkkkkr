using System;
using System.Threading;

namespace System.Runtime.InteropServices
{
	/// <summary>Отслеживает незавершенные обработчики и инициирует сбор мусора при достижении заданного порогового значения.</summary>
	// Token: 0x02000185 RID: 389
	public sealed class HandleCollector
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.HandleCollector" />, используя имя и порог, достижение которого вызывает сбор дескрипторов.</summary>
		/// <param name="name">Имя сборщика. Этот параметр позволяет называть сборщики, независимо отслеживающие типы дескрипторов.</param>
		/// <param name="initialThreshold">Значение, определяющее точку, с которой должен начаться сбор.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="initialThreshold" /> меньше 0.</exception>
		// Token: 0x06000A67 RID: 2663 RVA: 0x0002D4F0 File Offset: 0x0002B6F0
		public HandleCollector(string name, int initialThreshold) : this(name, initialThreshold, int.MaxValue)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.HandleCollector" />, используя имя, порог начала сбора дескрипторов и порок, при котором должен быть выполнен сбор дескрипторов.</summary>
		/// <param name="name">Имя сборщика.  Этот параметр позволяет называть сборщики, независимо отслеживающие типы дескрипторов.</param>
		/// <param name="initialThreshold">Значение, определяющее точку, с которой должен начаться сбор.</param>
		/// <param name="maximumThreshold">Значение, определяющее точку, в которой должен быть выполнен сбор. Оно должно быть равно максимальному числу доступных дескрипторов.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="initialThreshold" /> меньше 0.  
		///
		/// или - 
		/// Значение параметра <paramref name="maximumThreshold" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="maximumThreshold" /> меньше значения параметра <paramref name="initialThreshold" />.</exception>
		// Token: 0x06000A68 RID: 2664 RVA: 0x0002D500 File Offset: 0x0002B700
		public HandleCollector(string name, int initialThreshold, int maximumThreshold)
		{
			if (initialThreshold < 0)
			{
				throw new ArgumentOutOfRangeException("initialThreshold", SR.GetString("Non-negative number required."));
			}
			if (maximumThreshold < 0)
			{
				throw new ArgumentOutOfRangeException("maximumThreshold", SR.GetString("Non-negative number required."));
			}
			if (initialThreshold > maximumThreshold)
			{
				throw new ArgumentException(SR.GetString("maximumThreshold cannot be less than initialThreshold."));
			}
			if (name != null)
			{
				this.name = name;
			}
			else
			{
				this.name = string.Empty;
			}
			this.initialThreshold = initialThreshold;
			this.maximumThreshold = maximumThreshold;
			this.threshold = initialThreshold;
			this.handleCount = 0;
		}

		/// <summary>Возвращает количество собранных дескрипторов.</summary>
		/// <returns>Количество собранных дескрипторов.</returns>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0002D598 File Offset: 0x0002B798
		public int Count
		{
			get
			{
				return this.handleCount;
			}
		}

		/// <summary>Возвращает значение, определяющее точку, с которой должен начаться сбор.</summary>
		/// <returns>Значение, определяющее точку, с которой должен начаться сбор.</returns>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		public int InitialThreshold
		{
			get
			{
				return this.initialThreshold;
			}
		}

		/// <summary>Возвращает значение, определяющее точку, в которой должен быть выполнен сбор.</summary>
		/// <returns>Значение, определяющее точку, в которой должен быть выполнен сбор.</returns>
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		public int MaximumThreshold
		{
			get
			{
				return this.maximumThreshold;
			}
		}

		/// <summary>Возвращает имя объекта <see cref="T:System.Runtime.InteropServices.HandleCollector" />.</summary>
		/// <returns>Это свойство <see cref="P:System.Runtime.InteropServices.HandleCollector.Name" /> позволяет называть сборщики, независимо отслеживающие типы дескрипторов.</returns>
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002D5B0 File Offset: 0x0002B7B0
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Увеличивает текущий счетчик дескрипторов.</summary>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Runtime.InteropServices.HandleCollector.Count" /> меньше 0.</exception>
		// Token: 0x06000A6D RID: 2669 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		public void Add()
		{
			int num = -1;
			Interlocked.Increment(ref this.handleCount);
			if (this.handleCount < 0)
			{
				throw new InvalidOperationException(SR.GetString("Handle collector count overflows or underflows."));
			}
			if (this.handleCount > this.threshold)
			{
				lock (this)
				{
					this.threshold = this.handleCount + this.handleCount / 10;
					num = this.gc_gen;
					if (this.gc_gen < 2)
					{
						this.gc_gen++;
					}
				}
			}
			if (num >= 0 && (num == 0 || this.gc_counts[num] == GC.CollectionCount(num)))
			{
				GC.Collect(num);
				Thread.Sleep(10 * num);
			}
			for (int i = 1; i < 3; i++)
			{
				this.gc_counts[i] = GC.CollectionCount(i);
			}
		}

		/// <summary>Уменьшает текущий счетчик дескрипторов.</summary>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Runtime.InteropServices.HandleCollector.Count" /> меньше 0.</exception>
		// Token: 0x06000A6E RID: 2670 RVA: 0x0002D698 File Offset: 0x0002B898
		public void Remove()
		{
			Interlocked.Decrement(ref this.handleCount);
			if (this.handleCount < 0)
			{
				throw new InvalidOperationException(SR.GetString("Handle collector count overflows or underflows."));
			}
			int num = this.handleCount + this.handleCount / 10;
			if (num < this.threshold - this.threshold / 10)
			{
				lock (this)
				{
					if (num > this.initialThreshold)
					{
						this.threshold = num;
					}
					else
					{
						this.threshold = this.initialThreshold;
					}
					this.gc_gen = 0;
				}
			}
			for (int i = 1; i < 3; i++)
			{
				this.gc_counts[i] = GC.CollectionCount(i);
			}
		}

		// Token: 0x040006E8 RID: 1768
		private const int deltaPercent = 10;

		// Token: 0x040006E9 RID: 1769
		private string name;

		// Token: 0x040006EA RID: 1770
		private int initialThreshold;

		// Token: 0x040006EB RID: 1771
		private int maximumThreshold;

		// Token: 0x040006EC RID: 1772
		private int threshold;

		// Token: 0x040006ED RID: 1773
		private int handleCount;

		// Token: 0x040006EE RID: 1774
		private int[] gc_counts = new int[3];

		// Token: 0x040006EF RID: 1775
		private int gc_gen;
	}
}
