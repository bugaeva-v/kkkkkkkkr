using System;

namespace System.Diagnostics
{
	/// <summary>Определяет структуру, содержащую необработанные данные для счетчика производительности.</summary>
	// Token: 0x0200024E RID: 590
	public struct CounterSample
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Diagnostics.CounterSample" /> и задает свойству <see cref="P:System.Diagnostics.CounterSample.CounterTimeStamp" /> значение 0 (ноль).</summary>
		/// <param name="rawValue">Числовое значение, связанное с образцом счетчика производительности.</param>
		/// <param name="baseValue">Дополнительное базовое начальное значение для счетчика, используемое, только если в основе образца лежат несколько счетчиков.</param>
		/// <param name="counterFrequency">Частота, с которой счетчик считывается.</param>
		/// <param name="systemFrequency">Частота, с которой данные счетчика считываются системой.</param>
		/// <param name="timeStamp">Начальный штамп времени.</param>
		/// <param name="timeStamp100nSec">Начальный штамп времени с высокой точностью.</param>
		/// <param name="counterType">Объект <see cref="T:System.Diagnostics.PerformanceCounterType" />, указывающий тип счетчика, для которого данный образец является снимком.</param>
		// Token: 0x0600122B RID: 4651 RVA: 0x0004E498 File Offset: 0x0004C698
		public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType)
		{
			this = new CounterSample(rawValue, baseValue, counterFrequency, systemFrequency, timeStamp, timeStamp100nSec, counterType, 0L);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Diagnostics.CounterSample" /> и задает передаваемое значение свойству <see cref="P:System.Diagnostics.CounterSample.CounterTimeStamp" />.</summary>
		/// <param name="rawValue">Числовое значение, связанное с образцом счетчика производительности.</param>
		/// <param name="baseValue">Дополнительное базовое начальное значение для счетчика, используемое, только если в основе образца лежат несколько счетчиков.</param>
		/// <param name="counterFrequency">Частота, с которой счетчик считывается.</param>
		/// <param name="systemFrequency">Частота, с которой данные счетчика считываются системой.</param>
		/// <param name="timeStamp">Начальный штамп времени.</param>
		/// <param name="timeStamp100nSec">Начальный штамп времени с высокой точностью.</param>
		/// <param name="counterType">Объект <see cref="T:System.Diagnostics.PerformanceCounterType" />, указывающий тип счетчика, для которого данный образец является снимком.</param>
		/// <param name="counterTimeStamp">Время получения образца.</param>
		// Token: 0x0600122C RID: 4652 RVA: 0x0004E4B8 File Offset: 0x0004C6B8
		public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType, long counterTimeStamp)
		{
			this.rawValue = rawValue;
			this.baseValue = baseValue;
			this.counterFrequency = counterFrequency;
			this.systemFrequency = systemFrequency;
			this.timeStamp = timeStamp;
			this.timeStamp100nSec = timeStamp100nSec;
			this.counterType = counterType;
			this.counterTimeStamp = counterTimeStamp;
		}

		/// <summary>Возвращает дополнительное базовое начальное значение для счетчика.</summary>
		/// <returns>Базовое начальное значение для счетчика, используемое, только если в основе образца лежат несколько счетчиков.</returns>
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0004E4F7 File Offset: 0x0004C6F7
		public long BaseValue
		{
			get
			{
				return this.baseValue;
			}
		}

		/// <summary>Возвращает начальную частоту счетчика.</summary>
		/// <returns>Частота, с которой счетчик считывается.</returns>
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0004E4FF File Offset: 0x0004C6FF
		public long CounterFrequency
		{
			get
			{
				return this.counterFrequency;
			}
		}

		/// <summary>Возвращает штамп времени счетчика.</summary>
		/// <returns>Время получения образца.</returns>
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0004E507 File Offset: 0x0004C707
		public long CounterTimeStamp
		{
			get
			{
				return this.counterTimeStamp;
			}
		}

		/// <summary>Возвращает тип счетчика производительности.</summary>
		/// <returns>Объект <see cref="T:System.Diagnostics.PerformanceCounterType" />, указывающий тип счетчика, для которого данный образец является снимком.</returns>
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x0004E50F File Offset: 0x0004C70F
		public PerformanceCounterType CounterType
		{
			get
			{
				return this.counterType;
			}
		}

		/// <summary>Возвращает начальное значение счетчика.</summary>
		/// <returns>Числовое значение, связанное с образцом счетчика производительности.</returns>
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x0004E517 File Offset: 0x0004C717
		public long RawValue
		{
			get
			{
				return this.rawValue;
			}
		}

		/// <summary>Возвращает начальную частоту системы.</summary>
		/// <returns>Частота, с которой данные счетчика считываются системой.</returns>
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x0004E51F File Offset: 0x0004C71F
		public long SystemFrequency
		{
			get
			{
				return this.systemFrequency;
			}
		}

		/// <summary>Возвращает начальный штамп времени.</summary>
		/// <returns>Штамп времени системы.</returns>
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x0004E527 File Offset: 0x0004C727
		public long TimeStamp
		{
			get
			{
				return this.timeStamp;
			}
		}

		/// <summary>Возвращает начальный штамп времени с высокой точностью.</summary>
		/// <returns>Штамп времени системы, представленный значением 0,1 миллисекунды.</returns>
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x0004E52F File Offset: 0x0004C72F
		public long TimeStamp100nSec
		{
			get
			{
				return this.timeStamp100nSec;
			}
		}

		/// <summary>Вычисляет данные производительности счетчика, используя одну точку измерения. Этот метод обычно используется для типов счетчиков с нераcсчитанной производительностью.</summary>
		/// <param name="counterSample">Структура <see cref="T:System.Diagnostics.CounterSample" />, используемая в качестве базовой точки для расчета данных производительности.</param>
		/// <returns>Вычисляемое значение производительности.</returns>
		// Token: 0x06001235 RID: 4661 RVA: 0x0004E537 File Offset: 0x0004C737
		public static float Calculate(CounterSample counterSample)
		{
			return CounterSampleCalculator.ComputeCounterValue(counterSample);
		}

		/// <summary>Вычисляет данные производительности счетчика, используя две точки измерения. Этот метод обычно используется для типов счетчиков с вычисляемой производительностью (например, средние значения).</summary>
		/// <param name="counterSample">Структура <see cref="T:System.Diagnostics.CounterSample" />, используемая в качестве базовой точки для расчета данных производительности.</param>
		/// <param name="nextCounterSample">Структура <see cref="T:System.Diagnostics.CounterSample" />, используемая в качестве конечной точки для расчета данных производительности.</param>
		/// <returns>Вычисляемое значение производительности.</returns>
		// Token: 0x06001236 RID: 4662 RVA: 0x0004E53F File Offset: 0x0004C73F
		public static float Calculate(CounterSample counterSample, CounterSample nextCounterSample)
		{
			return CounterSampleCalculator.ComputeCounterValue(counterSample, nextCounterSample);
		}

		/// <summary>Указывает, является ли заданная структура структурой <see cref="T:System.Diagnostics.CounterSample" />, и идентична ли она текущей структуре <see cref="T:System.Diagnostics.CounterSample" />.</summary>
		/// <param name="o">Структура <see cref="T:System.Diagnostics.CounterSample" />, которую необходимо сравнить с текущей структурой.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="o" /> является структурой <see cref="T:System.Diagnostics.CounterSample" /> и идентична текущему экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001237 RID: 4663 RVA: 0x0004E548 File Offset: 0x0004C748
		public override bool Equals(object o)
		{
			return o is CounterSample && this.Equals((CounterSample)o);
		}

		/// <summary>Указывает, равна ли заданная структура <see cref="T:System.Diagnostics.CounterSample" /> текущей структуре <see cref="T:System.Diagnostics.CounterSample" />.</summary>
		/// <param name="sample">Структура <see cref="T:System.Diagnostics.CounterSample" />, которую необходимо сравнить с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="sample" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001238 RID: 4664 RVA: 0x0004E560 File Offset: 0x0004C760
		public bool Equals(CounterSample sample)
		{
			return this.rawValue == sample.rawValue && this.baseValue == sample.counterFrequency && this.counterFrequency == sample.counterFrequency && this.systemFrequency == sample.systemFrequency && this.timeStamp == sample.timeStamp && this.timeStamp100nSec == sample.timeStamp100nSec && this.counterTimeStamp == sample.counterTimeStamp && this.counterType == sample.counterType;
		}

		/// <summary>Возвращает значение, указывающее, равны ли между собой две структуры <see cref="T:System.Diagnostics.CounterSample" />.</summary>
		/// <param name="a">Структура <see cref="T:System.Diagnostics.CounterSample" />.</param>
		/// <param name="b">Другая структура <see cref="T:System.Diagnostics.CounterSample" /> для сравнения со структурой, указанной параметром <paramref name="a" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001239 RID: 4665 RVA: 0x0004E5DF File Offset: 0x0004C7DF
		public static bool operator ==(CounterSample a, CounterSample b)
		{
			return a.Equals(b);
		}

		/// <summary>Возвращает значение, указывающее о неравенстве двух структур <see cref="T:System.Diagnostics.CounterSample" />.</summary>
		/// <param name="a">Структура <see cref="T:System.Diagnostics.CounterSample" />.</param>
		/// <param name="b">Другая структура <see cref="T:System.Diagnostics.CounterSample" /> для сравнения со структурой, указанной параметром <paramref name="a" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="a" /> и <paramref name="b" /> не идентичны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600123A RID: 4666 RVA: 0x0004E5E9 File Offset: 0x0004C7E9
		public static bool operator !=(CounterSample a, CounterSample b)
		{
			return !a.Equals(b);
		}

		/// <summary>Возвращает хэш-код для текущего образца счетчика.</summary>
		/// <returns>Хэш-код для текущего образца счетчика.</returns>
		// Token: 0x0600123B RID: 4667 RVA: 0x0004E5F8 File Offset: 0x0004C7F8
		public override int GetHashCode()
		{
			return (int)(this.rawValue << 28 ^ (this.baseValue << 24 ^ (this.counterFrequency << 20 ^ (this.systemFrequency << 16 ^ (this.timeStamp << 8 ^ (this.timeStamp100nSec << 4 ^ (this.counterTimeStamp ^ (long)this.counterType)))))));
		}

		// Token: 0x04000A8F RID: 2703
		private long rawValue;

		// Token: 0x04000A90 RID: 2704
		private long baseValue;

		// Token: 0x04000A91 RID: 2705
		private long counterFrequency;

		// Token: 0x04000A92 RID: 2706
		private long systemFrequency;

		// Token: 0x04000A93 RID: 2707
		private long timeStamp;

		// Token: 0x04000A94 RID: 2708
		private long timeStamp100nSec;

		// Token: 0x04000A95 RID: 2709
		private long counterTimeStamp;

		// Token: 0x04000A96 RID: 2710
		private PerformanceCounterType counterType;

		/// <summary>Определяет пустой, неинициализированный образец счетчика производительности с типом <see langword="NumberOfItems32" />.</summary>
		// Token: 0x04000A97 RID: 2711
		public static CounterSample Empty = new CounterSample(0L, 0L, 0L, 0L, 0L, 0L, PerformanceCounterType.NumberOfItems32, 0L);
	}
}
