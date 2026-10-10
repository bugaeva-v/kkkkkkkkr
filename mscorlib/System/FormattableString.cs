using System;
using System.Globalization;

namespace System
{
	/// <summary>Представляет строку составного формата вместе с аргументами для форматирования.</summary>
	// Token: 0x0200011C RID: 284
	public abstract class FormattableString : IFormattable
	{
		/// <summary>Возвращает строку составного формата.</summary>
		/// <returns>Строка составного формата.</returns>
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000AE6 RID: 2790
		public abstract string Format { get; }

		/// <summary>Возвращает массив объектов, содержащий один или более форматируемых объектов.</summary>
		/// <returns>Массив объектов, содержащий один или более форматируемых объектов.</returns>
		// Token: 0x06000AE7 RID: 2791
		public abstract object[] GetArguments();

		/// <summary>Возвращает число аргументов, подлежащих форматированию.</summary>
		/// <returns>Число аргументов, которые необходимо отформатировать.</returns>
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000AE8 RID: 2792
		public abstract int ArgumentCount { get; }

		/// <summary>Получает аргумент в заданной позиции индекса.</summary>
		/// <param name="index">Индекс аргумента. Значение находится в диапазоне от 0 до 1 или меньше значения <see cref="P:System.FormattableString.ArgumentCount" />.</param>
		/// <returns>Аргумент.</returns>
		// Token: 0x06000AE9 RID: 2793
		public abstract object GetArgument(int index);

		/// <summary>Возвращает строку, являющуюся результатом форматирования составной строки формата вместе с ее аргументами с помощью правил форматирования конкретного языка и региональных параметров.</summary>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Результирующая строка, отформатированная с помощью правил <paramref name="formatProvider" />.</returns>
		// Token: 0x06000AEA RID: 2794
		public abstract string ToString(IFormatProvider formatProvider);

		/// <summary>Возвращает строку, являющуюся результатом форматирования строки формата вместе с ее аргументами с помощью правил форматирования конкретного языка и региональных параметров.</summary>
		/// <param name="ignored">Строка. Этот аргумент игнорируется.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Строка, отформатированная с помощью правил параметра <paramref name="formatProvider" />.</returns>
		// Token: 0x06000AEB RID: 2795 RVA: 0x000288E6 File Offset: 0x00026AE6
		string IFormattable.ToString(string ignored, IFormatProvider formatProvider)
		{
			return this.ToString(formatProvider);
		}

		/// <summary>Возвращает результирующую строку, в которой аргументы форматируются с помощью правил инвариантного языка и региональных параметров.</summary>
		/// <param name="formattable">Объект, преобразуемый в результирующую строку.</param>
		/// <returns>Строка, являющаяся результатом форматирования текущего экземпляра с помощью правил инвариантного языка и региональных параметров.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="formattable" /> — <see langword="null" />.</exception>
		// Token: 0x06000AEC RID: 2796 RVA: 0x000288EF File Offset: 0x00026AEF
		public static string Invariant(FormattableString formattable)
		{
			if (formattable == null)
			{
				throw new ArgumentNullException("formattable");
			}
			return formattable.ToString(CultureInfo.InvariantCulture);
		}

		/// <summary>Возвращает строку, являющуюся результатом форматирования составной строки формата вместе с ее аргументами с помощью правил форматирования текущего языка и региональных параметров.</summary>
		/// <returns>Результирующая строка, отформатированная с помощью правил текущего языка и региональных параметров.</returns>
		// Token: 0x06000AED RID: 2797 RVA: 0x0002890A File Offset: 0x00026B0A
		public override string ToString()
		{
			return this.ToString(CultureInfo.CurrentCulture);
		}
	}
}
