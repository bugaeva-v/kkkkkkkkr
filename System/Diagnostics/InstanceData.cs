using System;

namespace System.Diagnostics
{
	/// <summary>Содержит данные экземпляра, связанные с образцом счетчика производительности.</summary>
	// Token: 0x02000269 RID: 617
	public class InstanceData
	{
		/// <summary>Инициализирует новый экземпляр класса InstanceData, используя указанный образец и экземпляр счетчика производительности.</summary>
		/// <param name="instanceName">Имя экземпляра, связанного со счетчиком производительности.</param>
		/// <param name="sample">Объект <see cref="T:System.Diagnostics.CounterSample" /> берется из экземпляра, заданного параметром <paramref name="instanceName" />.</param>
		// Token: 0x0600136C RID: 4972 RVA: 0x000517CC File Offset: 0x0004F9CC
		public InstanceData(string instanceName, CounterSample sample)
		{
			this.instanceName = instanceName;
			this.sample = sample;
		}

		/// <summary>Возвращает имя экземпляра, связанное с данными этого экземпляра.</summary>
		/// <returns>Имя экземпляра, связанного со счетчиком производительности.</returns>
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x000517E2 File Offset: 0x0004F9E2
		public string InstanceName
		{
			get
			{
				return this.instanceName;
			}
		}

		/// <summary>Возвращает начальное значение данных, связанное с образцом счетчика производительности.</summary>
		/// <returns>Начальное значение, которое считывается образцом счетчика производительности, связанным со свойством <see cref="P:System.Diagnostics.InstanceData.Sample" />.</returns>
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x000517EA File Offset: 0x0004F9EA
		public long RawValue
		{
			get
			{
				return this.sample.RawValue;
			}
		}

		/// <summary>Возвращает образец счетчика производительности, с помощью которого были созданы эти данные.</summary>
		/// <returns>Объект <see cref="T:System.Diagnostics.CounterSample" /> берется из экземпляра заданного свойством <see cref="P:System.Diagnostics.InstanceData.InstanceName" />.</returns>
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x000517F7 File Offset: 0x0004F9F7
		public CounterSample Sample
		{
			get
			{
				return this.sample;
			}
		}

		// Token: 0x04000B00 RID: 2816
		private string instanceName;

		// Token: 0x04000B01 RID: 2817
		private CounterSample sample;
	}
}
