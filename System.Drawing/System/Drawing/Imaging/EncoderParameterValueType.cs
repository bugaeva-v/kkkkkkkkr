using System;

namespace System.Drawing.Imaging
{
	/// <summary>Используется для определения типа данных <see cref="T:System.Drawing.Imaging.EncoderParameter" />, применяемого с методом изображения <see cref="Overload:System.Drawing.Image.Save" /> или <see cref="Overload:System.Drawing.Image.SaveAdd" />.</summary>
	// Token: 0x02000103 RID: 259
	public enum EncoderParameterValueType
	{
		/// <summary>Указывает, что каждое значение в массиве является 8-разрядным целым числом без знака.</summary>
		// Token: 0x04000984 RID: 2436
		ValueTypeByte = 1,
		/// <summary>Указывает, что массив значений является строкой ASCII-символов с завершающим нулем. Обратите внимание, что член данных <see langword="NumberOfValues" /> объекта <see cref="T:System.Drawing.Imaging.EncoderParameter" /> определяет длину строки символов, включая символ конца строки NULL.</summary>
		// Token: 0x04000985 RID: 2437
		ValueTypeAscii,
		/// <summary>Указывает, что каждое значение в массиве является 16-разрядным целым числом без знака.</summary>
		// Token: 0x04000986 RID: 2438
		ValueTypeShort,
		/// <summary>Указывает, что каждое значение в массиве является 32-разрядным целым числом без знака.</summary>
		// Token: 0x04000987 RID: 2439
		ValueTypeLong,
		/// <summary>Указывает, что каждое значение в массиве является парой 32-разрядных целых чисел без знака. Каждая пара представляет собой дробь, где первое число является числителем, а второе – знаменателем.</summary>
		// Token: 0x04000988 RID: 2440
		ValueTypeRational,
		/// <summary>Указывает, что каждое значение в массиве является парой 32-разрядных целых чисел без знака. Каждая пара представляет собой диапазон чисел.</summary>
		// Token: 0x04000989 RID: 2441
		ValueTypeLongRange,
		/// <summary>Указывает, что массив значений является массивом байтов, для которых не определен тип данных.</summary>
		// Token: 0x0400098A RID: 2442
		ValueTypeUndefined,
		/// <summary>Указывает, что каждое значение в массиве является набором из четырех 32-разрядных целых чисел без знака. Первая пара чисел представляет первую дробь, а вторая пара – вторую. Две дроби представляют диапазон рациональных чисел. Первая дробь является наименьшим рациональным числом диапазона, а вторая – наибольшим.</summary>
		// Token: 0x0400098B RID: 2443
		ValueTypeRationalRange
	}
}
