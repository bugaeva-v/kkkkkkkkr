using System;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет диапазон байтов в значении заголовка Range.</summary>
	// Token: 0x02000066 RID: 102
	public class RangeItemHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.RangeItemHeaderValue" />.</summary>
		/// <param name="from">Место начала передачи данных.</param>
		/// <param name="to">Место остановки передачи данных.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="from" /> больше <paramref name="to" />  
		///
		/// или - 
		/// Значение параметра <paramref name="from" /> или <paramref name="to" /> меньше 0.</exception>
		// Token: 0x06000395 RID: 917 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
		public RangeItemHeaderValue(long? from, long? to)
		{
			if (from == null && to == null)
			{
				throw new ArgumentException();
			}
			long? num2;
			if (from != null && to != null)
			{
				long? num = from;
				num2 = to;
				if (num.GetValueOrDefault() > num2.GetValueOrDefault() & (num != null & num2 != null))
				{
					throw new ArgumentOutOfRangeException("from");
				}
			}
			num2 = from;
			long num3 = 0L;
			if (num2.GetValueOrDefault() < num3 & num2 != null)
			{
				throw new ArgumentOutOfRangeException("from");
			}
			num2 = to;
			num3 = 0L;
			if (num2.GetValueOrDefault() < num3 & num2 != null)
			{
				throw new ArgumentOutOfRangeException("to");
			}
			this.From = from;
			this.To = to;
		}

		/// <summary>Возвращает позицию начала передачи данных.</summary>
		/// <returns>Место начала передачи данных.</returns>
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000C774 File Offset: 0x0000A974
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0000C77C File Offset: 0x0000A97C
		public long? From { get; private set; }

		/// <summary>Возвращает место остановки передачи данных.</summary>
		/// <returns>Место остановки передачи данных.</returns>
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000C785 File Offset: 0x0000A985
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000C78D File Offset: 0x0000A98D
		public long? To { get; private set; }

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.RangeItemHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x0600039A RID: 922 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.RangeItemHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x0600039B RID: 923 RVA: 0x0000C798 File Offset: 0x0000A998
		public override bool Equals(object obj)
		{
			RangeItemHeaderValue rangeItemHeaderValue = obj as RangeItemHeaderValue;
			if (rangeItemHeaderValue != null)
			{
				long? num = rangeItemHeaderValue.From;
				long? num2 = this.From;
				if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
				{
					num2 = rangeItemHeaderValue.To;
					num = this.To;
					return num2.GetValueOrDefault() == num.GetValueOrDefault() & num2 != null == (num != null);
				}
			}
			return false;
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.RangeItemHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x0600039C RID: 924 RVA: 0x0000C814 File Offset: 0x0000AA14
		public override int GetHashCode()
		{
			return this.From.GetHashCode() ^ this.To.GetHashCode();
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.RangeItemHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x0600039D RID: 925 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public override string ToString()
		{
			if (this.From == null)
			{
				return "-" + this.To.Value.ToString();
			}
			if (this.To == null)
			{
				return this.From.Value.ToString() + "-";
			}
			return this.From.Value.ToString() + "-" + this.To.Value.ToString();
		}
	}
}
