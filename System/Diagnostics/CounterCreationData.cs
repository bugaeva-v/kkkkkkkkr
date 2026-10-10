using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Определяет тип настраиваемого счетчика, его имя и строку справки.</summary>
	// Token: 0x0200024C RID: 588
	[TypeConverter("System.Diagnostics.Design.CounterCreationDataConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Serializable]
	public class CounterCreationData
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.CounterCreationData" /> для счетчика типа <see langword="NumberOfItems32" /> с пустым именем и строкой справки.</summary>
		// Token: 0x06001215 RID: 4629 RVA: 0x0004E299 File Offset: 0x0004C499
		public CounterCreationData()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.CounterCreationData" /> для счетчика заданного типа, используя указанное имя счетчика и строки справки.</summary>
		/// <param name="counterName">Имя счетчика, которое должно быть уникальным в его категории.</param>
		/// <param name="counterHelp">Текст описания поведения счетчика.</param>
		/// <param name="counterType">Перечисление <see cref="T:System.Diagnostics.PerformanceCounterType" />, используемое для определения поведения счетчика.</param>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Значение задано для параметра <paramref name="counterType" />, который не является элементом перечисления <see cref="T:System.Diagnostics.PerformanceCounterType" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="counterHelp" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001216 RID: 4630 RVA: 0x0004E2AC File Offset: 0x0004C4AC
		public CounterCreationData(string counterName, string counterHelp, PerformanceCounterType counterType)
		{
			this.CounterName = counterName;
			this.CounterHelp = counterHelp;
			this.CounterType = counterType;
		}

		/// <summary>Возвращает или задает описание настраиваемого счетчика.</summary>
		/// <returns>Текст описания поведения счетчика.</returns>
		/// <exception cref="T:System.ArgumentNullException">Указанное значение равно <see langword="null" />.</exception>
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0004E2D4 File Offset: 0x0004C4D4
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		[DefaultValue("")]
		[MonitoringDescription("Description of this counter.")]
		public string CounterHelp
		{
			get
			{
				return this.help;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.help = value;
			}
		}

		/// <summary>Возвращает или задает имя настраиваемого счетчика.</summary>
		/// <returns>Имя счетчика, которое должно быть уникальным в его категории.</returns>
		/// <exception cref="T:System.ArgumentNullException">Указанное значение равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина указанного значения выходит за рамки диапазона от 1 до 80 символов или содержит двойные кавычки, управляющие символы либо начальные или концевые пробелы.</exception>
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x0004E2F3 File Offset: 0x0004C4F3
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x0004E2FB File Offset: 0x0004C4FB
		[DefaultValue("")]
		[MonitoringDescription("Name of this counter.")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string CounterName
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value == "")
				{
					throw new ArgumentException("value");
				}
				this.name = value;
			}
		}

		/// <summary>Возвращает или задает тип настраиваемого счетчика производительности.</summary>
		/// <returns>Перечисление <see cref="T:System.Diagnostics.PerformanceCounterType" />, определяющее поведение счетчика производительности.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Указан тип, который не является элементом перечисления <see cref="T:System.Diagnostics.PerformanceCounterType" />.</exception>
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0004E32A File Offset: 0x0004C52A
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x0004E332 File Offset: 0x0004C532
		[MonitoringDescription("Type of this counter.")]
		[DefaultValue(typeof(PerformanceCounterType), "NumberOfItems32")]
		public PerformanceCounterType CounterType
		{
			get
			{
				return this.type;
			}
			set
			{
				if (!Enum.IsDefined(typeof(PerformanceCounterType), value))
				{
					throw new InvalidEnumArgumentException();
				}
				this.type = value;
			}
		}

		// Token: 0x04000A8C RID: 2700
		private string help = string.Empty;

		// Token: 0x04000A8D RID: 2701
		private string name;

		// Token: 0x04000A8E RID: 2702
		private PerformanceCounterType type;
	}
}
