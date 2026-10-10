using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Сохраняет 8-байтовую константу типа <see cref="T:System.DateTime" /> для поля или параметра.</summary>
	// Token: 0x020007EC RID: 2028
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[Serializable]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="DateTimeConstantAttribute" /> с числом 100-наносекундных импульсов, представляющим дату и время создания данного экземпляра.</summary>
		/// <param name="ticks">Число 100-наносекундных импульсов, представляющее дату и время создания данного экземпляра.</param>
		// Token: 0x060045F3 RID: 17907 RVA: 0x000E5767 File Offset: 0x000E3967
		public DateTimeConstantAttribute(long ticks)
		{
			this._date = new DateTime(ticks);
		}

		/// <summary>Возвращает число 100-наносекундных импульсов, представляющее дату и время создания данного экземпляра.</summary>
		/// <returns>Число 100-наносекундных импульсов, представляющее дату и время создания данного экземпляра.</returns>
		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x000E577B File Offset: 0x000E397B
		public override object Value
		{
			get
			{
				return this._date;
			}
		}

		// Token: 0x04002D36 RID: 11574
		private DateTime _date;
	}
}
