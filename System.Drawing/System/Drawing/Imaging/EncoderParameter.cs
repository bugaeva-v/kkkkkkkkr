using System;
using System.Runtime.InteropServices;

namespace System.Drawing.Imaging
{
	/// <summary>Используется для передачи значения или массива значений кодировщику изображений.</summary>
	// Token: 0x02000102 RID: 258
	[StructLayout(LayoutKind.Sequential)]
	public sealed class EncoderParameter : IDisposable
	{
		/// <summary>Позволяет объекту <see cref="T:System.Drawing.Imaging.EncoderParameter" /> предпринять попытку освободить ресурсы и выполнить другие завершающие операции перед утилизацией объекта <see cref="T:System.Drawing.Imaging.EncoderParameter" /> в процессе сборки мусора.</summary>
		// Token: 0x06000C51 RID: 3153 RVA: 0x0001C420 File Offset: 0x0001A620
		~EncoderParameter()
		{
			this.Dispose(false);
		}

		/// <summary>Получает или задает объект <see cref="T:System.Drawing.Imaging.Encoder" />, связанный с объектом <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Объект <see cref="T:System.Drawing.Imaging.Encoder" /> инкапсулирует глобальный уникальный идентификатор (GUID), определяющий категорию (например <see cref="F:System.Drawing.Imaging.Encoder.Quality" />, <see cref="F:System.Drawing.Imaging.Encoder.ColorDepth" /> или <see cref="F:System.Drawing.Imaging.Encoder.Compression" />) параметра, хранящегося в этом объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.Encoder" />, инкапсулирующий глобальный уникальный идентификатор (GUID), который определяет категорию параметра, хранящегося в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</returns>
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0001C450 File Offset: 0x0001A650
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x0001C45D File Offset: 0x0001A65D
		public Encoder Encoder
		{
			get
			{
				return new Encoder(this._parameterGuid);
			}
			set
			{
				this._parameterGuid = value.Guid;
			}
		}

		/// <summary>Получает тип данных значений, хранящихся в этом объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</summary>
		/// <returns>Член перечисления <see cref="T:System.Drawing.Imaging.EncoderParameterValueType" />, указывающий тип данных значений, хранящихся в этом объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</returns>
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0001C46B File Offset: 0x0001A66B
		public EncoderParameterValueType Type
		{
			get
			{
				return this._parameterValueType;
			}
		}

		/// <summary>Получает тип данных значений, хранящихся в этом объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</summary>
		/// <returns>Член перечисления <see cref="T:System.Drawing.Imaging.EncoderParameterValueType" />, указывающий тип данных значений, хранящихся в этом объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</returns>
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0001C46B File Offset: 0x0001A66B
		public EncoderParameterValueType ValueType
		{
			get
			{
				return this._parameterValueType;
			}
		}

		/// <summary>Возвращает количество элементов массива значений, хранящихся в этом объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</summary>
		/// <returns>Целое число, определяющее количество элементов массива значений, которые хранятся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</returns>
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0001C473 File Offset: 0x0001A673
		public int NumberOfValues
		{
			get
			{
				return this._numberOfValues;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</summary>
		// Token: 0x06000C57 RID: 3159 RVA: 0x0001C47B File Offset: 0x0001A67B
		public void Dispose()
		{
			this.Dispose(true);
			GC.KeepAlive(this);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0001C490 File Offset: 0x0001A690
		private void Dispose(bool disposing)
		{
			if (this._parameterValue != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(this._parameterValue);
			}
			this._parameterValue = IntPtr.Zero;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> с указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и одним 8-разрядным целым числом без знака. Задает свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeByte" />, а свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — значение 1.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">8-разрядное целое число без знака, которое определяет значение, хранящееся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		// Token: 0x06000C59 RID: 3161 RVA: 0x0001C4BC File Offset: 0x0001A6BC
		public EncoderParameter(Encoder encoder, byte value)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeByte;
			this._numberOfValues = 1;
			this._parameterValue = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(byte)));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.WriteByte(this._parameterValue, value);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и одним 8-разрядным значением. Позволяет задать для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeUndefined" /> или <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeByte" />, а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — значение 1.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">Байт, который определяет значение, хранящееся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		/// <param name="undefined">Если <see langword="true" />, свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> присваивается значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeUndefined" />; в обратном случае свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> присваивается значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeByte" />.</param>
		// Token: 0x06000C5A RID: 3162 RVA: 0x0001C530 File Offset: 0x0001A730
		public EncoderParameter(Encoder encoder, byte value, bool undefined)
		{
			this._parameterGuid = encoder.Guid;
			if (undefined)
			{
				this._parameterValueType = EncoderParameterValueType.ValueTypeUndefined;
			}
			else
			{
				this._parameterValueType = EncoderParameterValueType.ValueTypeByte;
			}
			this._numberOfValues = 1;
			this._parameterValue = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(byte)));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.WriteByte(this._parameterValue, value);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> с указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и одним 16-разрядным целым числом. Задает свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeShort" />, а свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — значение 1.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">16-разрядное целое число, которое определяет значение, хранящееся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Должно быть неотрицательным значением.</param>
		// Token: 0x06000C5B RID: 3163 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		public EncoderParameter(Encoder encoder, short value)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeShort;
			this._numberOfValues = 1;
			this._parameterValue = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(short)));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.WriteInt16(this._parameterValue, value);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и одним 64-разрядным целым числом. Устанавливает для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeLong" /> (32 бита), а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — значение 1.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">64-разрядное целое число, которое определяет значение, хранящееся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Должно быть неотрицательным значением. Данный параметр преобразуется в 32-разрядное целое число перед сохранением в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		// Token: 0x06000C5C RID: 3164 RVA: 0x0001C624 File Offset: 0x0001A824
		public EncoderParameter(Encoder encoder, long value)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeLong;
			this._numberOfValues = 1;
			this._parameterValue = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.WriteInt32(this._parameterValue, (int)value);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> с указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и парой 32-разрядных целых чисел. Пара целых чисел представляет дробь, где первое целое число является числителем, а второе — знаменателем. Задает свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeRational" />, а свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — значение 1.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="numerator">32-разрядное целое число, представляющее числитель дроби. Должно быть неотрицательным значением.</param>
		/// <param name="denominator">32-разрядное целое число, представляющее знаменатель дроби. Должно быть неотрицательным значением.</param>
		// Token: 0x06000C5D RID: 3165 RVA: 0x0001C698 File Offset: 0x0001A898
		public EncoderParameter(Encoder encoder, int numerator, int denominator)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeRational;
			this._numberOfValues = 1;
			int num = Marshal.SizeOf(typeof(int));
			this._parameterValue = Marshal.AllocHGlobal(2 * num);
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.WriteInt32(this._parameterValue, numerator);
			Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, num), denominator);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и парой 64-разрядных целых чисел. Пара целых чисел представляет диапазон целых чисел, первое число является наименьшим в этом диапазоне, а второе — наибольшим. Задает свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeLongRange" />, а свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — значение 1.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="rangebegin">64-разрядное целое число представляет наименьшее число диапазона целых чисел. Должно быть неотрицательным значением. Данный параметр преобразуется в 32-разрядное целое число перед сохранением в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		/// <param name="rangeend">64-разрядное целое число представляет наибольшее число диапазона целых чисел. Должно быть неотрицательным значением. Данный параметр преобразуется в 32-разрядное целое число перед сохранением в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		// Token: 0x06000C5E RID: 3166 RVA: 0x0001C720 File Offset: 0x0001A920
		public EncoderParameter(Encoder encoder, long rangebegin, long rangeend)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeLongRange;
			this._numberOfValues = 1;
			int num = Marshal.SizeOf(typeof(int));
			this._parameterValue = Marshal.AllocHGlobal(2 * num);
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.WriteInt32(this._parameterValue, (int)rangebegin);
			Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, num), (int)rangeend);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и четырьмя 32-разрядным целыми числами. Четыре целых числа представляют диапазон дробей. Первые два целых числа представляют наименьшую дробь диапазона, а оставшиеся два — наибольшую. Задает свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeRationalRange" />, а свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — значение 1.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="numerator1">32-разрядное целое число, представляющее числитель наименьшей дроби диапазона. Должно быть неотрицательным значением.</param>
		/// <param name="demoninator1">32-разрядное целое число, представляющее знаменатель наименьшей дроби диапазона. Должно быть неотрицательным значением.</param>
		/// <param name="numerator2">32-разрядное целое число, представляющее знаменатель наименьшей дроби диапазона. Должно быть неотрицательным значением.</param>
		/// <param name="demoninator2">32-разрядное целое число, представляющее числитель наибольшей дроби диапазона. Должно быть неотрицательным значением.</param>
		// Token: 0x06000C5F RID: 3167 RVA: 0x0001C7AC File Offset: 0x0001A9AC
		public EncoderParameter(Encoder encoder, int numerator1, int demoninator1, int numerator2, int demoninator2)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeRationalRange;
			this._numberOfValues = 1;
			int num = Marshal.SizeOf(typeof(int));
			this._parameterValue = Marshal.AllocHGlobal(4 * num);
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.WriteInt32(this._parameterValue, numerator1);
			Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, num), demoninator1);
			Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, 2 * num), numerator2);
			Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, 3 * num), demoninator2);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> с указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и строкой символов. Строка преобразуется в строку ASCII-символов с завершающим нулем перед сохранением в объект <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Устанавливает для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeAscii" />, а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — длину строки ASCII-символов, включая символ конца строки NULL.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">Объект <see cref="T:System.String" />, который определяет значение, хранящееся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		// Token: 0x06000C60 RID: 3168 RVA: 0x0001C860 File Offset: 0x0001AA60
		public EncoderParameter(Encoder encoder, string value)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeAscii;
			this._numberOfValues = value.Length;
			this._parameterValue = Marshal.StringToHGlobalAnsi(value);
			GC.KeepAlive(this);
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и массивом из 8-разрядных целых чисел без знака. Позволяет задать для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeByte" />, а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — количество элементов массива.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">Массив из 8-разрядных целых чисел без знака, который определяет значения, хранящиеся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		// Token: 0x06000C61 RID: 3169 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		public EncoderParameter(Encoder encoder, byte[] value)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeByte;
			this._numberOfValues = value.Length;
			this._parameterValue = Marshal.AllocHGlobal(this._numberOfValues);
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.Copy(value, 0, this._parameterValue, this._numberOfValues);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и массивом байтов. Позволяет задать для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeUndefined" /> или <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeByte" />, а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — количество элементов массива.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">Массив байтов, который определяет значения, хранящиеся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		/// <param name="undefined">Если <see langword="true" />, свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> присваивается значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeUndefined" />; в обратном случае свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> присваивается значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeByte" />.</param>
		// Token: 0x06000C62 RID: 3170 RVA: 0x0001C934 File Offset: 0x0001AB34
		public EncoderParameter(Encoder encoder, byte[] value, bool undefined)
		{
			this._parameterGuid = encoder.Guid;
			if (undefined)
			{
				this._parameterValueType = EncoderParameterValueType.ValueTypeUndefined;
			}
			else
			{
				this._parameterValueType = EncoderParameterValueType.ValueTypeByte;
			}
			this._numberOfValues = value.Length;
			this._parameterValue = Marshal.AllocHGlobal(this._numberOfValues);
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.Copy(value, 0, this._parameterValue, this._numberOfValues);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и массивом из 16-разрядных целых чисел. Позволяет задать для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeShort" />, а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — количество элементов массива.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">Массив из 16-разрядных целых чисел, который определяет значения, хранящиеся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Целые числа массива должны быть неотрицательными.</param>
		// Token: 0x06000C63 RID: 3171 RVA: 0x0001C9B4 File Offset: 0x0001ABB4
		public EncoderParameter(Encoder encoder, short[] value)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeShort;
			this._numberOfValues = value.Length;
			int num = Marshal.SizeOf(typeof(short));
			this._parameterValue = Marshal.AllocHGlobal(checked(this._numberOfValues * num));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			Marshal.Copy(value, 0, this._parameterValue, this._numberOfValues);
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и массивом из 64-разрядных целых чисел. Установка для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значения <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeLong" /> (32-разрядное), а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — количества элементов массива.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="value">Массив из 64-разрядных целых чисел, который определяет значения, хранящиеся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Целые числа массива должны быть неотрицательными. 64-разрядные целые числа преобразуются в 32-разрядные перед сохранением в объект <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		// Token: 0x06000C64 RID: 3172 RVA: 0x0001CA38 File Offset: 0x0001AC38
		public unsafe EncoderParameter(Encoder encoder, long[] value)
		{
			this._parameterGuid = encoder.Guid;
			this._parameterValueType = EncoderParameterValueType.ValueTypeLong;
			this._numberOfValues = value.Length;
			int num = Marshal.SizeOf(typeof(int));
			this._parameterValue = Marshal.AllocHGlobal(checked(this._numberOfValues * num));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			int* ptr = (int*)((void*)this._parameterValue);
			fixed (long[] array = value)
			{
				long* ptr2;
				if (value == null || array.Length == 0)
				{
					ptr2 = null;
				}
				else
				{
					ptr2 = &array[0];
				}
				for (int i = 0; i < value.Length; i++)
				{
					ptr[i] = (int)ptr2[i];
				}
			}
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и двумя массивами из 32-разрядных целых чисел. Два массива представляют массив дробей. Устанавливает для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeRational" />, а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — количество элементов массива <paramref name="numerator" />, которое должно совпадать с количеством элементов массива <paramref name="denominator" />.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="numerator">Массив из 32-разрядных целых чисел, определяющий числители дробей. Целые числа массива должны быть неотрицательными.</param>
		/// <param name="denominator">Массив из 32-разрядных целых чисел, определяющий знаменатели дробей. Целые числа массива должны быть неотрицательными. Знаменатель с определенным индексом соответствует числителю с таким же индексом.</param>
		// Token: 0x06000C65 RID: 3173 RVA: 0x0001CAF4 File Offset: 0x0001ACF4
		public EncoderParameter(Encoder encoder, int[] numerator, int[] denominator)
		{
			this._parameterGuid = encoder.Guid;
			if (numerator.Length != denominator.Length)
			{
				throw SafeNativeMethods.Gdip.StatusException(2);
			}
			this._parameterValueType = EncoderParameterValueType.ValueTypeRational;
			this._numberOfValues = numerator.Length;
			int num = Marshal.SizeOf(typeof(int));
			this._parameterValue = Marshal.AllocHGlobal(checked(this._numberOfValues * 2 * num));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			for (int i = 0; i < this._numberOfValues; i++)
			{
				Marshal.WriteInt32(EncoderParameter.Add(i * 2 * num, this._parameterValue), numerator[i]);
				Marshal.WriteInt32(EncoderParameter.Add((i * 2 + 1) * num, this._parameterValue), denominator[i]);
			}
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и двумя массивами из 64-разрядных целых чисел. Два массива представляют массив диапазонов целых чисел. Устанавливает для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeLongRange" />, а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — количество элементов массива <paramref name="rangebegin" />, которое должно совпадать с количеством элементов массива <paramref name="rangeend" />.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="rangebegin">Массив из 64-разрядных целых чисел, который определяет наименьшие значения диапазонов целых чисел. Целые числа массива должны быть неотрицательными. 64-разрядные целые числа преобразуются в 32-разрядные перед сохранением в объект <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</param>
		/// <param name="rangeend">Массив из 64-разрядных целых чисел, который определяет наибольшие значения диапазонов целых чисел. Целые числа массива должны быть неотрицательными. 64-разрядные целые числа преобразуются в 32-разрядные перед сохранением в объект <see cref="T:System.Drawing.Imaging.EncoderParameters" />. Наибольшее значение с определенным индексом соответствует наименьшему значению с таким же индексом.</param>
		// Token: 0x06000C66 RID: 3174 RVA: 0x0001CBBC File Offset: 0x0001ADBC
		public EncoderParameter(Encoder encoder, long[] rangebegin, long[] rangeend)
		{
			this._parameterGuid = encoder.Guid;
			if (rangebegin.Length != rangeend.Length)
			{
				throw SafeNativeMethods.Gdip.StatusException(2);
			}
			this._parameterValueType = EncoderParameterValueType.ValueTypeLongRange;
			this._numberOfValues = rangebegin.Length;
			int num = Marshal.SizeOf(typeof(int));
			this._parameterValue = Marshal.AllocHGlobal(checked(this._numberOfValues * 2 * num));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			for (int i = 0; i < this._numberOfValues; i++)
			{
				Marshal.WriteInt32(EncoderParameter.Add(i * 2 * num, this._parameterValue), (int)rangebegin[i]);
				Marshal.WriteInt32(EncoderParameter.Add((i * 2 + 1) * num, this._parameterValue), (int)rangeend[i]);
			}
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и четырьмя массивами из 32-разрядных целых чисел. Четыре массива представляют рациональные диапазоны массива. Рациональный диапазон — это множество всех дробей от минимального дробного значения до максимального. Устанавливает для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" /> значение <see cref="F:System.Drawing.Imaging.EncoderParameterValueType.ValueTypeRationalRange" />, а для свойства <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" /> — количество элементов массива <paramref name="numerator1" />, которое должно совпадать с количеством элементов в трех других массивах.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="numerator1">Массив из 32-разрядных целых чисел, который определяет числители наименьших значений диапазонов. Целые числа массива должны быть неотрицательными.</param>
		/// <param name="denominator1">Массив из 32-разрядных целых чисел, который определяет знаменатели наименьших значений диапазонов. Целые числа массива должны быть неотрицательными.</param>
		/// <param name="numerator2">Массив из 32-разрядных целых чисел, который определяет числители наибольших значений диапазонов. Целые числа массива должны быть неотрицательными.</param>
		/// <param name="denominator2">Массив из 32-разрядных целых чисел, который определяет знаменатели наибольших значений диапазонов. Целые числа массива должны быть неотрицательными.</param>
		// Token: 0x06000C67 RID: 3175 RVA: 0x0001CC84 File Offset: 0x0001AE84
		public EncoderParameter(Encoder encoder, int[] numerator1, int[] denominator1, int[] numerator2, int[] denominator2)
		{
			this._parameterGuid = encoder.Guid;
			if (numerator1.Length != denominator1.Length || numerator1.Length != denominator2.Length || denominator1.Length != denominator2.Length)
			{
				throw SafeNativeMethods.Gdip.StatusException(2);
			}
			this._parameterValueType = EncoderParameterValueType.ValueTypeRationalRange;
			this._numberOfValues = numerator1.Length;
			int num = Marshal.SizeOf(typeof(int));
			this._parameterValue = Marshal.AllocHGlobal(checked(this._numberOfValues * 4 * num));
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			for (int i = 0; i < this._numberOfValues; i++)
			{
				Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, 4 * i * num), numerator1[i]);
				Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, (4 * i + 1) * num), denominator1[i]);
				Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, (4 * i + 2) * num), numerator2[i]);
				Marshal.WriteInt32(EncoderParameter.Add(this._parameterValue, (4 * i + 3) * num), denominator2[i]);
			}
			GC.KeepAlive(this);
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" /> и тремя целыми числами, определяющими количество значений, тип данных значений и указатель на значения, хранящиеся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="NumberOfValues">Целое число, которое определяет количество значений, хранящихся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Это значение присваивается свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" />.</param>
		/// <param name="Type">Член перечисления <see cref="T:System.Drawing.Imaging.EncoderParameterValueType" />, определяющий тип данных значений, хранящихся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Это значение устанавливается для свойства <see cref="T:System.Type" /> и <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" />.</param>
		/// <param name="Value">Указатель на массив значений, тип которых определен параметром <paramref name="Type" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Тип не является допустимым <see cref="T:System.Drawing.Imaging.EncoderParameterValueType" />.</exception>
		// Token: 0x06000C68 RID: 3176 RVA: 0x0001CD94 File Offset: 0x0001AF94
		[Obsolete("This constructor has been deprecated. Use EncoderParameter(Encoder encoder, int numberValues, EncoderParameterValueType type, IntPtr value) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public EncoderParameter(Encoder encoder, int NumberOfValues, int Type, int Value)
		{
			int num;
			switch (Type)
			{
			case 1:
			case 2:
				num = 1;
				break;
			case 3:
				num = 2;
				break;
			case 4:
				num = 4;
				break;
			case 5:
			case 6:
				num = 8;
				break;
			case 7:
				num = 1;
				break;
			case 8:
				num = 16;
				break;
			default:
				throw SafeNativeMethods.Gdip.StatusException(8);
			}
			int num2 = checked(num * NumberOfValues);
			this._parameterValue = Marshal.AllocHGlobal(num2);
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			for (int i = 0; i < num2; i++)
			{
				Marshal.WriteByte(EncoderParameter.Add(this._parameterValue, i), Marshal.ReadByte((IntPtr)(Value + i)));
			}
			this._parameterValueType = (EncoderParameterValueType)Type;
			this._numberOfValues = NumberOfValues;
			this._parameterGuid = encoder.Guid;
			GC.KeepAlive(this);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Imaging.EncoderParameter" /> с указанным объектом <see cref="T:System.Drawing.Imaging.Encoder" />, количеством значений, типом данных значений и указателем на значения, хранящиеся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />.</summary>
		/// <param name="encoder">Объект <see cref="T:System.Drawing.Imaging.Encoder" />, который инкапсулирует глобально уникальный идентификатор категории параметра.</param>
		/// <param name="numberValues">Целое число, которое определяет количество значений, хранящихся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Это значение присваивается свойству <see cref="P:System.Drawing.Imaging.EncoderParameter.NumberOfValues" />.</param>
		/// <param name="type">Член перечисления <see cref="T:System.Drawing.Imaging.EncoderParameterValueType" />, определяющий тип данных значений, хранящихся в объекте <see cref="T:System.Drawing.Imaging.EncoderParameter" />. Это значение устанавливается для свойства <see cref="T:System.Type" /> и <see cref="P:System.Drawing.Imaging.EncoderParameter.ValueType" />.</param>
		/// <param name="value">Указатель на массив значений, тип которых определен параметром <paramref name="Type" />.</param>
		// Token: 0x06000C69 RID: 3177 RVA: 0x0001CE68 File Offset: 0x0001B068
		public EncoderParameter(Encoder encoder, int numberValues, EncoderParameterValueType type, IntPtr value)
		{
			int num;
			switch (type)
			{
			case EncoderParameterValueType.ValueTypeByte:
			case EncoderParameterValueType.ValueTypeAscii:
				num = 1;
				break;
			case EncoderParameterValueType.ValueTypeShort:
				num = 2;
				break;
			case EncoderParameterValueType.ValueTypeLong:
				num = 4;
				break;
			case EncoderParameterValueType.ValueTypeRational:
			case EncoderParameterValueType.ValueTypeLongRange:
				num = 8;
				break;
			case EncoderParameterValueType.ValueTypeUndefined:
				num = 1;
				break;
			case EncoderParameterValueType.ValueTypeRationalRange:
				num = 16;
				break;
			default:
				throw SafeNativeMethods.Gdip.StatusException(8);
			}
			int num2 = checked(num * numberValues);
			this._parameterValue = Marshal.AllocHGlobal(num2);
			if (this._parameterValue == IntPtr.Zero)
			{
				throw SafeNativeMethods.Gdip.StatusException(3);
			}
			for (int i = 0; i < num2; i++)
			{
				Marshal.WriteByte(EncoderParameter.Add(this._parameterValue, i), Marshal.ReadByte(value + i));
			}
			this._parameterValueType = type;
			this._numberOfValues = numberValues;
			this._parameterGuid = encoder.Guid;
			GC.KeepAlive(this);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0001CF38 File Offset: 0x0001B138
		private static IntPtr Add(IntPtr a, int b)
		{
			return (IntPtr)((long)a + (long)b);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0001CF48 File Offset: 0x0001B148
		private static IntPtr Add(int a, IntPtr b)
		{
			return (IntPtr)((long)a + (long)b);
		}

		// Token: 0x0400097F RID: 2431
		[MarshalAs(UnmanagedType.Struct)]
		private Guid _parameterGuid;

		// Token: 0x04000980 RID: 2432
		private int _numberOfValues;

		// Token: 0x04000981 RID: 2433
		private EncoderParameterValueType _parameterValueType;

		// Token: 0x04000982 RID: 2434
		private IntPtr _parameterValue;
	}
}
