using System;

namespace System.Globalization
{
	/// <summary>Определяет период летнего времени.</summary>
	// Token: 0x02000962 RID: 2402
	[Serializable]
	public class DaylightTime
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.DaylightTime" /> с указанными сведениями о начале, окончании и разнице во времени.</summary>
		/// <param name="start">Объект, представляющий дату и время начала летнего времени. Значение должно быть выражено в местном времени.</param>
		/// <param name="end">Объект, представляющий дату и время завершения летнего времени. Значение должно быть выражено в местном времени.</param>
		/// <param name="delta">Объект, представляющий разницу между стандартным и летним временем в квантах времени.</param>
		// Token: 0x0600553A RID: 21818 RVA: 0x0011DE50 File Offset: 0x0011C050
		public DaylightTime(DateTime start, DateTime end, TimeSpan delta)
		{
			this._start = start;
			this._end = end;
			this._delta = delta;
		}

		/// <summary>Возвращает объект, представляющий дату и время начала летнего времени.</summary>
		/// <returns>Объект, представляющий дату и время начала летнего времени. Значение выражено в местном времени.</returns>
		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x0011DE6D File Offset: 0x0011C06D
		public DateTime Start
		{
			get
			{
				return this._start;
			}
		}

		/// <summary>Возвращает объект, представляющий дату и время окончания летнего времени.</summary>
		/// <returns>Объект, представляющий дату и время окончания летнего времени. Значение выражено в местном времени.</returns>
		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x0600553C RID: 21820 RVA: 0x0011DE75 File Offset: 0x0011C075
		public DateTime End
		{
			get
			{
				return this._end;
			}
		}

		/// <summary>Возвращает интервал времени, представляющий разницу между стандартным и летним временем.</summary>
		/// <returns>Момент времени, представляющий разницу между стандартным и летним временем.</returns>
		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x0600553D RID: 21821 RVA: 0x0011DE7D File Offset: 0x0011C07D
		public TimeSpan Delta
		{
			get
			{
				return this._delta;
			}
		}

		// Token: 0x04003484 RID: 13444
		private readonly DateTime _start;

		// Token: 0x04003485 RID: 13445
		private readonly DateTime _end;

		// Token: 0x04003486 RID: 13446
		private readonly TimeSpan _delta;
	}
}
