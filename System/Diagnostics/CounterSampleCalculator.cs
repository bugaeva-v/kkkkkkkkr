using System;

namespace System.Diagnostics
{
	/// <summary>Содержит набор служебных функций для обработки данных счетчика производительности.</summary>
	// Token: 0x0200024F RID: 591
	public static class CounterSampleCalculator
	{
		/// <summary>Вычисляет расчетное значение одного экземпляра необработанных данных счетчика.</summary>
		/// <param name="newSample">Структура <see cref="T:System.Diagnostics.CounterSample" />, указывающая на последний взятый системой экземпляр.</param>
		/// <returns>Представление расчетного значения счетчика производительности в виде значения с плавающей запятой.</returns>
		// Token: 0x0600123D RID: 4669 RVA: 0x0004E670 File Offset: 0x0004C870
		public static float ComputeCounterValue(CounterSample newSample)
		{
			PerformanceCounterType counterType = newSample.CounterType;
			if (counterType <= PerformanceCounterType.NumberOfItemsHEX64)
			{
				if (counterType != PerformanceCounterType.NumberOfItemsHEX32 && counterType != PerformanceCounterType.NumberOfItemsHEX64)
				{
					goto IL_3E;
				}
			}
			else if (counterType != PerformanceCounterType.NumberOfItems32 && counterType != PerformanceCounterType.NumberOfItems64 && counterType != PerformanceCounterType.RawFraction)
			{
				goto IL_3E;
			}
			return (float)newSample.RawValue;
			IL_3E:
			return 0f;
		}

		/// <summary>Вычисляет расчетное значение двух экземпляров необработанных данных счетчика.</summary>
		/// <param name="oldSample">Структура <see cref="T:System.Diagnostics.CounterSample" />, указывающая на предыдущий взятый системой экземпляр.</param>
		/// <param name="newSample">Структура <see cref="T:System.Diagnostics.CounterSample" />, указывающая на последний взятый системой экземпляр.</param>
		/// <returns>Представление расчетного значения счетчика производительности в виде значения с плавающей запятой.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для параметра <paramref name="oldSample" /> используется тип счетчика, отличный от <paramref name="newSample" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Тип счетчика <paramref name="newSample" /> вызывает ошибку поддержки данных производительности (PDH). Дополнительные сведения см. в параграфе о проверке возвращаемых значений интерфейса PDH в разделах настоящей документации, посвященных разработке для Win32 и модели COM.</exception>
		// Token: 0x0600123E RID: 4670 RVA: 0x0004E6C0 File Offset: 0x0004C8C0
		[MonoTODO("What's the algorithm?")]
		public static float ComputeCounterValue(CounterSample oldSample, CounterSample newSample)
		{
			if (newSample.CounterType != oldSample.CounterType)
			{
				throw new Exception("The counter samples must be of the same type");
			}
			PerformanceCounterType counterType = newSample.CounterType;
			if (counterType <= PerformanceCounterType.RawFraction)
			{
				if (counterType <= PerformanceCounterType.CounterDelta32)
				{
					if (counterType <= PerformanceCounterType.NumberOfItemsHEX64)
					{
						if (counterType != PerformanceCounterType.NumberOfItemsHEX32 && counterType != PerformanceCounterType.NumberOfItemsHEX64)
						{
							goto IL_36C;
						}
					}
					else if (counterType != PerformanceCounterType.NumberOfItems32 && counterType != PerformanceCounterType.NumberOfItems64)
					{
						if (counterType != PerformanceCounterType.CounterDelta32)
						{
							goto IL_36C;
						}
						goto IL_1C3;
					}
				}
				else if (counterType <= PerformanceCounterType.CountPerTimeInterval64)
				{
					if (counterType == PerformanceCounterType.CounterDelta64)
					{
						goto IL_1C3;
					}
					if (counterType != PerformanceCounterType.CountPerTimeInterval32 && counterType != PerformanceCounterType.CountPerTimeInterval64)
					{
						goto IL_36C;
					}
					goto IL_298;
				}
				else
				{
					if (counterType == PerformanceCounterType.RateOfCountsPerSecond32 || counterType == PerformanceCounterType.RateOfCountsPerSecond64)
					{
						return (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp - oldSample.TimeStamp) * 10000000f;
					}
					if (counterType != PerformanceCounterType.RawFraction)
					{
						goto IL_36C;
					}
				}
				return (float)newSample.RawValue;
				IL_1C3:
				return (float)(newSample.RawValue - oldSample.RawValue);
			}
			if (counterType <= PerformanceCounterType.CounterMultiTimer)
			{
				if (counterType <= PerformanceCounterType.Timer100Ns)
				{
					if (counterType != PerformanceCounterType.CounterTimer)
					{
						if (counterType != PerformanceCounterType.Timer100Ns)
						{
							goto IL_36C;
						}
						return (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp - oldSample.TimeStamp) * 100f;
					}
				}
				else
				{
					if (counterType == PerformanceCounterType.CounterTimerInverse)
					{
						return (1f - (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp100nSec - oldSample.TimeStamp100nSec)) * 100f;
					}
					if (counterType == PerformanceCounterType.Timer100NsInverse)
					{
						return (1f - (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp - oldSample.TimeStamp)) * 100f;
					}
					if (counterType != PerformanceCounterType.CounterMultiTimer)
					{
						goto IL_36C;
					}
					return (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp - oldSample.TimeStamp) * 100f / (float)newSample.BaseValue;
				}
			}
			else if (counterType <= PerformanceCounterType.CounterMultiTimer100NsInverse)
			{
				if (counterType == PerformanceCounterType.CounterMultiTimer100Ns)
				{
					return (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp100nSec - oldSample.TimeStamp100nSec) * 100f / (float)newSample.BaseValue;
				}
				if (counterType == PerformanceCounterType.CounterMultiTimerInverse)
				{
					return ((float)newSample.BaseValue - (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp - oldSample.TimeStamp)) * 100f;
				}
				if (counterType != PerformanceCounterType.CounterMultiTimer100NsInverse)
				{
					goto IL_36C;
				}
				return ((float)newSample.BaseValue - (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp100nSec - oldSample.TimeStamp100nSec)) * 100f;
			}
			else
			{
				if (counterType == PerformanceCounterType.AverageTimer32)
				{
					return (float)(newSample.RawValue - oldSample.RawValue) / (float)newSample.SystemFrequency / (float)(newSample.BaseValue - oldSample.BaseValue);
				}
				if (counterType == PerformanceCounterType.ElapsedTime)
				{
					return 0f;
				}
				if (counterType != PerformanceCounterType.AverageCount64)
				{
					goto IL_36C;
				}
				return (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.BaseValue - oldSample.BaseValue);
			}
			IL_298:
			return (float)(newSample.RawValue - oldSample.RawValue) / (float)(newSample.TimeStamp - oldSample.TimeStamp);
			IL_36C:
			Console.WriteLine("Counter type {0} not handled", newSample.CounterType);
			return 0f;
		}
	}
}
