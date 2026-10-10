using System;

namespace System
{
	/// <summary>Представляет генератор псевдослучайных чисел, то есть устройство, которое выдает последовательность чисел, отвечающую определенным статистическим критериям случайности.</summary>
	// Token: 0x02000172 RID: 370
	public class Random
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Random" /> с помощью зависимого от времени начального значения по умолчанию.</summary>
		// Token: 0x06000E95 RID: 3733 RVA: 0x0003BB5F File Offset: 0x00039D5F
		public Random() : this(Random.GenerateSeed())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Random" /> с помощью указанного начального значения.</summary>
		/// <param name="Seed">Число, используемое для вычисления начального значения последовательности псевдослучайных чисел. Если задано отрицательное число, используется его абсолютное значение.</param>
		// Token: 0x06000E96 RID: 3734 RVA: 0x0003BB6C File Offset: 0x00039D6C
		public Random(int Seed)
		{
			int num = 0;
			int num2 = (Seed == int.MinValue) ? int.MaxValue : Math.Abs(Seed);
			int num3 = 161803398 - num2;
			this._seedArray[55] = num3;
			int num4 = 1;
			for (int i = 1; i < 55; i++)
			{
				if ((num += 21) >= 55)
				{
					num -= 55;
				}
				this._seedArray[num] = num4;
				num4 = num3 - num4;
				if (num4 < 0)
				{
					num4 += int.MaxValue;
				}
				num3 = this._seedArray[num];
			}
			for (int j = 1; j < 5; j++)
			{
				for (int k = 1; k < 56; k++)
				{
					int num5 = k + 30;
					if (num5 >= 55)
					{
						num5 -= 55;
					}
					this._seedArray[k] -= this._seedArray[1 + num5];
					if (this._seedArray[k] < 0)
					{
						this._seedArray[k] += int.MaxValue;
					}
				}
			}
			this._inext = 0;
			this._inextp = 21;
			Seed = 1;
		}

		/// <summary>Возвращает случайное число с плавающей запятой в диапазоне от 0,0 до 1,0.</summary>
		/// <returns>Число двойной точности с плавающей запятой, которое больше или равно 0,0, и меньше 1,0.</returns>
		// Token: 0x06000E97 RID: 3735 RVA: 0x0003BC7F File Offset: 0x00039E7F
		protected virtual double Sample()
		{
			return (double)this.InternalSample() * 4.656612875245797E-10;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0003BC94 File Offset: 0x00039E94
		private int InternalSample()
		{
			int num = this._inext;
			int num2 = this._inextp;
			if (++num >= 56)
			{
				num = 1;
			}
			if (++num2 >= 56)
			{
				num2 = 1;
			}
			int num3 = this._seedArray[num] - this._seedArray[num2];
			if (num3 == 2147483647)
			{
				num3--;
			}
			if (num3 < 0)
			{
				num3 += int.MaxValue;
			}
			this._seedArray[num] = num3;
			this._inext = num;
			this._inextp = num2;
			return num3;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0003BD08 File Offset: 0x00039F08
		private static int GenerateSeed()
		{
			Random random = Random.t_threadRandom;
			if (random == null)
			{
				Random obj = Random.s_globalRandom;
				int seed;
				lock (obj)
				{
					seed = Random.s_globalRandom.Next();
				}
				random = new Random(seed);
				Random.t_threadRandom = random;
			}
			return random.Next();
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0003BD68 File Offset: 0x00039F68
		private unsafe static int GenerateGlobalSeed()
		{
			int result;
			Interop.GetRandomBytes((byte*)(&result), 4);
			return result;
		}

		/// <summary>Возвращает неотрицательное случайное целое число.</summary>
		/// <returns>32-разрядное целое число со знаком, которое больше или равно нулю и меньше чем <see cref="F:System.Int32.MaxValue" />.</returns>
		// Token: 0x06000E9B RID: 3739 RVA: 0x0003BD7F File Offset: 0x00039F7F
		public virtual int Next()
		{
			return this.InternalSample();
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0003BD88 File Offset: 0x00039F88
		private double GetSampleForLargeRange()
		{
			int num = this.InternalSample();
			if (this.InternalSample() % 2 == 0)
			{
				num = -num;
			}
			return ((double)num + 2147483646.0) / 4294967293.0;
		}

		/// <summary>Возвращает случайное целое число в указанном диапазоне.</summary>
		/// <param name="minValue">Включенной нижний предел возвращаемого случайного числа.</param>
		/// <param name="maxValue">Исключенный верхний предел возвращаемого случайного числа. Значение свойства <paramref name="maxValue" /> должно быть больше или равно значению свойства <paramref name="minValue" />.</param>
		/// <returns>32-разрядное целое число со знаком большее или равное <paramref name="minValue" /> и меньше, чем <paramref name="maxValue" />; то есть, диапазон возвращаемого значения включает <paramref name="minValue" />, не включает <paramref name="maxValue" />. Если значение параметра <paramref name="minValue" /> равно значению параметра <paramref name="maxValue" />, то возвращается значение <paramref name="minValue" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="minValue" /> больше значения <paramref name="maxValue" />.</exception>
		// Token: 0x06000E9D RID: 3741 RVA: 0x0003BDC8 File Offset: 0x00039FC8
		public virtual int Next(int minValue, int maxValue)
		{
			if (minValue > maxValue)
			{
				throw new ArgumentOutOfRangeException("minValue", SR.Format("'{0}' cannot be greater than {1}.", "minValue", "maxValue"));
			}
			long num = (long)maxValue - (long)minValue;
			if (num <= 2147483647L)
			{
				return (int)(this.Sample() * (double)num) + minValue;
			}
			return (int)((long)(this.GetSampleForLargeRange() * (double)num) + (long)minValue);
		}

		/// <summary>Возвращает неотрицательное случайное целое число, которое меньше максимально допустимого значения.</summary>
		/// <param name="maxValue">Эксклюзивная верхняя граница создаваемого случайного числа. <paramref name="maxValue" /> должно быть больше либо равно 0.</param>
		/// <returns>32-разрядное целое число со знаком, большее или равное 0 и меньшее, чем <paramref name="maxValue" />. То есть диапазон возвращаемых значений включает в себя 0, но не включает <paramref name="maxValue" />. Однако если значение параметра <paramref name="maxValue" /> равно нулю, возвращается значение <paramref name="maxValue" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="maxValue" /> меньше 0.</exception>
		// Token: 0x06000E9E RID: 3742 RVA: 0x0003BE22 File Offset: 0x0003A022
		public virtual int Next(int maxValue)
		{
			if (maxValue < 0)
			{
				throw new ArgumentOutOfRangeException("maxValue", SR.Format("'{0}' must be greater than zero.", "maxValue"));
			}
			return (int)(this.Sample() * (double)maxValue);
		}

		/// <summary>Возвращает случайное число с плавающей запятой, которое больше или равно 0,0 и меньше 1,0.</summary>
		/// <returns>Число двойной точности с плавающей запятой, которое больше или равно 0,0, и меньше 1,0.</returns>
		// Token: 0x06000E9F RID: 3743 RVA: 0x0003BE4C File Offset: 0x0003A04C
		public virtual double NextDouble()
		{
			return this.Sample();
		}

		/// <summary>Заполняет элементы указанного массива байтов случайными числами.</summary>
		/// <param name="buffer">Массив байтов, содержащий случайные числа.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		// Token: 0x06000EA0 RID: 3744 RVA: 0x0003BE54 File Offset: 0x0003A054
		public virtual void NextBytes(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			for (int i = 0; i < buffer.Length; i++)
			{
				buffer[i] = (byte)this.InternalSample();
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0003BE88 File Offset: 0x0003A088
		public unsafe virtual void NextBytes(Span<byte> buffer)
		{
			for (int i = 0; i < buffer.Length; i++)
			{
				*buffer[i] = (byte)this.Next();
			}
		}

		// Token: 0x040012C4 RID: 4804
		private const int MBIG = 2147483647;

		// Token: 0x040012C5 RID: 4805
		private const int MSEED = 161803398;

		// Token: 0x040012C6 RID: 4806
		private const int MZ = 0;

		// Token: 0x040012C7 RID: 4807
		private int _inext;

		// Token: 0x040012C8 RID: 4808
		private int _inextp;

		// Token: 0x040012C9 RID: 4809
		private int[] _seedArray = new int[56];

		// Token: 0x040012CA RID: 4810
		[ThreadStatic]
		private static Random t_threadRandom;

		// Token: 0x040012CB RID: 4811
		private static readonly Random s_globalRandom = new Random(Random.GenerateGlobalSeed());
	}
}
