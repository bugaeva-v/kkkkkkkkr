using System;
using System.Globalization;

namespace System.Numerics
{
	/// <summary>Представляет комплексное число.</summary>
	// Token: 0x02000014 RID: 20
	[Serializable]
	public struct Complex : IEquatable<Complex>, IFormattable
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.Complex" /> с использованием заданных значений действительного и мнимого чисел.</summary>
		/// <param name="real">Действительная часть комплексного числа.</param>
		/// <param name="imaginary">Мнимая часть комплексного числа.</param>
		// Token: 0x0600021D RID: 541 RVA: 0x0000FDCE File Offset: 0x0000DFCE
		public Complex(double real, double imaginary)
		{
			this.m_real = real;
			this.m_imaginary = imaginary;
		}

		/// <summary>Получает вещественную часть текущего объекта <see cref="T:System.Numerics.Complex" />.</summary>
		/// <returns>Действительная часть комплексного числа.</returns>
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000FDDE File Offset: 0x0000DFDE
		public double Real
		{
			get
			{
				return this.m_real;
			}
		}

		/// <summary>Получает мнимую часть текущего объекта <see cref="T:System.Numerics.Complex" />.</summary>
		/// <returns>Мнимая часть комплексного числа.</returns>
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000FDE6 File Offset: 0x0000DFE6
		public double Imaginary
		{
			get
			{
				return this.m_imaginary;
			}
		}

		/// <summary>Возвращает модуль (или абсолютное значение) комплексного числа.</summary>
		/// <returns>Модуль текущего экземпляра.</returns>
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000FDEE File Offset: 0x0000DFEE
		public double Magnitude
		{
			get
			{
				return Complex.Abs(this);
			}
		}

		/// <summary>Возвращает фазу комплексного числа.</summary>
		/// <returns>Фаза комплексного числа в радианах.</returns>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000FDFB File Offset: 0x0000DFFB
		public double Phase
		{
			get
			{
				return Math.Atan2(this.m_imaginary, this.m_real);
			}
		}

		/// <summary>Создает комплексное число из полярных координат точки.</summary>
		/// <param name="magnitude">Модуль, т. е. расстояние от начала координат (точки пересечения осей X и Y) до числа.</param>
		/// <param name="phase">Фаза, т. е. угол от прямой до горизонтальной оси в радианах.</param>
		/// <returns>Комплексное число.</returns>
		// Token: 0x06000222 RID: 546 RVA: 0x0000FE0E File Offset: 0x0000E00E
		public static Complex FromPolarCoordinates(double magnitude, double phase)
		{
			return new Complex(magnitude * Math.Cos(phase), magnitude * Math.Sin(phase));
		}

		/// <summary>Возвращает аддитивную инверсию указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Результат умножения частей <see cref="P:System.Numerics.Complex.Real" /> и <see cref="P:System.Numerics.Complex.Imaginary" /> параметра <paramref name="value" /> на -1.</returns>
		// Token: 0x06000223 RID: 547 RVA: 0x0000FE25 File Offset: 0x0000E025
		public static Complex Negate(Complex value)
		{
			return -value;
		}

		/// <summary>Складывает два комплексных числа и возвращает результат.</summary>
		/// <param name="left">Первое комплексное число для сложения.</param>
		/// <param name="right">Второе комплексное число для сложения.</param>
		/// <returns>Сумма <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x06000224 RID: 548 RVA: 0x0000FE2D File Offset: 0x0000E02D
		public static Complex Add(Complex left, Complex right)
		{
			return left + right;
		}

		/// <summary>Вычитает одно комплексное число из другого и возвращает результат.</summary>
		/// <param name="left">Значение, из которого следует вычитать (уменьшаемое).</param>
		/// <param name="right">Значение для вычитания (вычитаемое).</param>
		/// <returns>Результат вычитания <paramref name="right" /> из <paramref name="left" />.</returns>
		// Token: 0x06000225 RID: 549 RVA: 0x0000FE36 File Offset: 0x0000E036
		public static Complex Subtract(Complex left, Complex right)
		{
			return left - right;
		}

		/// <summary>Возвращает произведение двух комплексных чисел.</summary>
		/// <param name="left">Первое комплексное число для перемножения.</param>
		/// <param name="right">Второе комплексное число для перемножения.</param>
		/// <returns>Произведение параметров <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x06000226 RID: 550 RVA: 0x0000FE3F File Offset: 0x0000E03F
		public static Complex Multiply(Complex left, Complex right)
		{
			return left * right;
		}

		/// <summary>Делит одно комплексное число на другое и возвращает результат.</summary>
		/// <param name="dividend">Комплексное число-числитель.</param>
		/// <param name="divisor">Комплексное число-знаменатель.</param>
		/// <returns>Частное от деления.</returns>
		// Token: 0x06000227 RID: 551 RVA: 0x0000FE48 File Offset: 0x0000E048
		public static Complex Divide(Complex dividend, Complex divisor)
		{
			return dividend / divisor;
		}

		/// <summary>Возвращает аддитивную инверсию указанного комплексного числа.</summary>
		/// <param name="value">Инвертируемое значение.</param>
		/// <returns>Результат умножения частей <see cref="P:System.Numerics.Complex.Real" /> и <see cref="P:System.Numerics.Complex.Imaginary" /> параметра <paramref name="value" /> на -1.</returns>
		// Token: 0x06000228 RID: 552 RVA: 0x0000FE51 File Offset: 0x0000E051
		public static Complex operator -(Complex value)
		{
			return new Complex(-value.m_real, -value.m_imaginary);
		}

		/// <summary>Складывает два комплексных числа.</summary>
		/// <param name="left">Первое из складываемых значений.</param>
		/// <param name="right">Второе из складываемых значений.</param>
		/// <returns>Сумма <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x06000229 RID: 553 RVA: 0x0000FE66 File Offset: 0x0000E066
		public static Complex operator +(Complex left, Complex right)
		{
			return new Complex(left.m_real + right.m_real, left.m_imaginary + right.m_imaginary);
		}

		/// <summary>Вычитает комплексное число из другого комплексного числа.</summary>
		/// <param name="left">Значение, из которого следует вычитать (уменьшаемое).</param>
		/// <param name="right">Значение для вычитания (вычитаемое).</param>
		/// <returns>Результат вычитания <paramref name="right" /> из <paramref name="left" />.</returns>
		// Token: 0x0600022A RID: 554 RVA: 0x0000FE87 File Offset: 0x0000E087
		public static Complex operator -(Complex left, Complex right)
		{
			return new Complex(left.m_real - right.m_real, left.m_imaginary - right.m_imaginary);
		}

		/// <summary>Перемножает два заданных комплексных числа.</summary>
		/// <param name="left">Первое значение для перемножения.</param>
		/// <param name="right">Второе значение для перемножения.</param>
		/// <returns>Произведение <paramref name="left" /> на <paramref name="right" />.</returns>
		// Token: 0x0600022B RID: 555 RVA: 0x0000FEA8 File Offset: 0x0000E0A8
		public static Complex operator *(Complex left, Complex right)
		{
			double real = left.m_real * right.m_real - left.m_imaginary * right.m_imaginary;
			double imaginary = left.m_imaginary * right.m_real + left.m_real * right.m_imaginary;
			return new Complex(real, imaginary);
		}

		/// <summary>Делит одно указанное комплексное число на другое.</summary>
		/// <param name="left">Значение, которое необходимо разделить.</param>
		/// <param name="right">Значение, на которое необходимо разделить.</param>
		/// <returns>Результат деления <paramref name="left" /> на <paramref name="right" />.</returns>
		// Token: 0x0600022C RID: 556 RVA: 0x0000FEF4 File Offset: 0x0000E0F4
		public static Complex operator /(Complex left, Complex right)
		{
			double real = left.m_real;
			double imaginary = left.m_imaginary;
			double real2 = right.m_real;
			double imaginary2 = right.m_imaginary;
			if (Math.Abs(imaginary2) < Math.Abs(real2))
			{
				double num = imaginary2 / real2;
				return new Complex((real + imaginary * num) / (real2 + imaginary2 * num), (imaginary - real * num) / (real2 + imaginary2 * num));
			}
			double num2 = real2 / imaginary2;
			return new Complex((imaginary + real * num2) / (imaginary2 + real2 * num2), (-real + imaginary * num2) / (imaginary2 + real2 * num2));
		}

		/// <summary>Возвращает абсолютное значение (или величину) комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Абсолютное значение параметра <paramref name="value" />.</returns>
		// Token: 0x0600022D RID: 557 RVA: 0x0000FF75 File Offset: 0x0000E175
		public static double Abs(Complex value)
		{
			return Complex.Hypot(value.m_real, value.m_imaginary);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000FF88 File Offset: 0x0000E188
		private static double Hypot(double a, double b)
		{
			a = Math.Abs(a);
			b = Math.Abs(b);
			double num;
			double num2;
			if (a < b)
			{
				num = a;
				num2 = b;
			}
			else
			{
				num = b;
				num2 = a;
			}
			if (num == 0.0)
			{
				return num2;
			}
			if (double.IsPositiveInfinity(num2) && !double.IsNaN(num))
			{
				return double.PositiveInfinity;
			}
			double num3 = num / num2;
			return num2 * Math.Sqrt(1.0 + num3 * num3);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000FFF4 File Offset: 0x0000E1F4
		private static double Log1P(double x)
		{
			double num = 1.0 + x;
			if (num == 1.0)
			{
				return x;
			}
			if (x < 0.75)
			{
				return x * Math.Log(num) / (num - 1.0);
			}
			return Math.Log(num);
		}

		/// <summary>Вычисляет сопряженное число комплексного числа и возвращает результат.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Сопряженное число для <paramref name="value" />.</returns>
		// Token: 0x06000230 RID: 560 RVA: 0x00010042 File Offset: 0x0000E242
		public static Complex Conjugate(Complex value)
		{
			return new Complex(value.m_real, -value.m_imaginary);
		}

		/// <summary>Возвращает обратную величину комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Обратная величина значения <paramref name="value" />.</returns>
		// Token: 0x06000231 RID: 561 RVA: 0x00010056 File Offset: 0x0000E256
		public static Complex Reciprocal(Complex value)
		{
			if (value.m_real == 0.0 && value.m_imaginary == 0.0)
			{
				return Complex.Zero;
			}
			return Complex.One / value;
		}

		/// <summary>Возвращает значение, указывающее, равны ли два комплексных числа.</summary>
		/// <param name="left">Первое комплексное число для сравнения.</param>
		/// <param name="right">Второе комплексное число для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> имеют одинаковые значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000232 RID: 562 RVA: 0x0001008B File Offset: 0x0000E28B
		public static bool operator ==(Complex left, Complex right)
		{
			return left.m_real == right.m_real && left.m_imaginary == right.m_imaginary;
		}

		/// <summary>Возвращает значение, указывающее, равны ли два комплексных числа.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000233 RID: 563 RVA: 0x000100AB File Offset: 0x0000E2AB
		public static bool operator !=(Complex left, Complex right)
		{
			return left.m_real != right.m_real || left.m_imaginary != right.m_imaginary;
		}

		/// <summary>Возвращает значение, определяющее, равны ли текущий экземпляр и указанный объект.</summary>
		/// <param name="obj">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является объектом <see cref="T:System.Numerics.Complex" /> или типом, поддерживающим неявное преобразование в объект <see cref="T:System.Numerics.Complex" />, а его значение равняется текущему объекту <see cref="T:System.Numerics.Complex" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000234 RID: 564 RVA: 0x000100CE File Offset: 0x0000E2CE
		public override bool Equals(object obj)
		{
			return obj is Complex && this.Equals((Complex)obj);
		}

		/// <summary>Возвращает значение, указывающее, равны ли текущий экземпляр и указанное комплексное число.</summary>
		/// <param name="value">Комплексное число для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если значения комплексного числа и <paramref name="value" /> совпадают; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000235 RID: 565 RVA: 0x000100E6 File Offset: 0x0000E2E6
		public bool Equals(Complex value)
		{
			return this.m_real.Equals(value.m_real) && this.m_imaginary.Equals(value.m_imaginary);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Numerics.Complex" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000236 RID: 566 RVA: 0x00010110 File Offset: 0x0000E310
		public override int GetHashCode()
		{
			int num = 99999997;
			int num2 = this.m_real.GetHashCode() % num;
			int hashCode = this.m_imaginary.GetHashCode();
			return num2 ^ hashCode;
		}

		/// <summary>Преобразует значение текущего комплексного числа в эквивалентное строковое представление в прямоугольной системе координат.</summary>
		/// <returns>Строковое представление текущего экземпляра в прямоугольной системе координат.</returns>
		// Token: 0x06000237 RID: 567 RVA: 0x0001013E File Offset: 0x0000E33E
		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "({0}, {1})", this.m_real, this.m_imaginary);
		}

		/// <summary>Преобразует значение текущего комплексного числа в эквивалентное строковое представление в прямоугольной системе координат, используя указанный формат для действительной и мнимой частей.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <returns>Строковое представление текущего экземпляра в прямоугольной системе координат.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> не является допустимым форматом строки.</exception>
		// Token: 0x06000238 RID: 568 RVA: 0x00010165 File Offset: 0x0000E365
		public string ToString(string format)
		{
			return string.Format(CultureInfo.CurrentCulture, "({0}, {1})", this.m_real.ToString(format, CultureInfo.CurrentCulture), this.m_imaginary.ToString(format, CultureInfo.CurrentCulture));
		}

		/// <summary>Преобразует значение текущего комплексного числа в эквивалентное строковое представление в прямоугольной системе координат, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление текущего экземпляра в прямоугольной системе координат, заданное <paramref name="provider" />.</returns>
		// Token: 0x06000239 RID: 569 RVA: 0x00010198 File Offset: 0x0000E398
		public string ToString(IFormatProvider provider)
		{
			return string.Format(provider, "({0}, {1})", this.m_real, this.m_imaginary);
		}

		/// <summary>Преобразует значение текущего комплексного числа в эквивалентное строковое представление в прямоугольной системе координат, используя для действительной и мнимой частей указанный формат и сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление текущего экземпляра в прямоугольной системе координат, заданное <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> не является допустимым форматом строки.</exception>
		// Token: 0x0600023A RID: 570 RVA: 0x000101BB File Offset: 0x0000E3BB
		public string ToString(string format, IFormatProvider provider)
		{
			return string.Format(provider, "({0}, {1})", this.m_real.ToString(format, provider), this.m_imaginary.ToString(format, provider));
		}

		/// <summary>Возвращает синус указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Синус <paramref name="value" />.</returns>
		// Token: 0x0600023B RID: 571 RVA: 0x000101E4 File Offset: 0x0000E3E4
		public static Complex Sin(Complex value)
		{
			double num = Math.Exp(value.m_imaginary);
			double num2 = 1.0 / num;
			double num3 = (num - num2) * 0.5;
			double num4 = (num + num2) * 0.5;
			return new Complex(Math.Sin(value.m_real) * num4, Math.Cos(value.m_real) * num3);
		}

		/// <summary>Возвращает гиперболический синус указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Гиперболический синус <paramref name="value" />.</returns>
		// Token: 0x0600023C RID: 572 RVA: 0x00010244 File Offset: 0x0000E444
		public static Complex Sinh(Complex value)
		{
			Complex complex = Complex.Sin(new Complex(-value.m_imaginary, value.m_real));
			return new Complex(complex.m_imaginary, -complex.m_real);
		}

		/// <summary>Возвращает угол, представляющий собой арксинус указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Угол, представляющий собой арксинус параметра <paramref name="value" />.</returns>
		// Token: 0x0600023D RID: 573 RVA: 0x0001027C File Offset: 0x0000E47C
		public static Complex Asin(Complex value)
		{
			double d;
			double num;
			double num2;
			Complex.Asin_Internal(Math.Abs(value.Real), Math.Abs(value.Imaginary), out d, out num, out num2);
			double num3;
			if (num < 0.0)
			{
				num3 = Math.Asin(d);
			}
			else
			{
				num3 = Math.Atan(num);
			}
			if (value.Real < 0.0)
			{
				num3 = -num3;
			}
			if (value.Imaginary < 0.0)
			{
				num2 = -num2;
			}
			return new Complex(num3, num2);
		}

		/// <summary>Возвращает косинус указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Косинус <paramref name="value" />.</returns>
		// Token: 0x0600023E RID: 574 RVA: 0x000102FC File Offset: 0x0000E4FC
		public static Complex Cos(Complex value)
		{
			double num = Math.Exp(value.m_imaginary);
			double num2 = 1.0 / num;
			double num3 = (num - num2) * 0.5;
			double num4 = (num + num2) * 0.5;
			return new Complex(Math.Cos(value.m_real) * num4, -Math.Sin(value.m_real) * num3);
		}

		/// <summary>Возвращает гиперболический косинус указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Гиперболический косинус <paramref name="value" />.</returns>
		// Token: 0x0600023F RID: 575 RVA: 0x0001035D File Offset: 0x0000E55D
		public static Complex Cosh(Complex value)
		{
			return Complex.Cos(new Complex(-value.m_imaginary, value.m_real));
		}

		/// <summary>Возвращает угол, представляющий собой арккосинус указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число, представляющее косинус.</param>
		/// <returns>Угол (в радианах), представляющий собой арккосинус параметра <paramref name="value" />.</returns>
		// Token: 0x06000240 RID: 576 RVA: 0x00010378 File Offset: 0x0000E578
		public static Complex Acos(Complex value)
		{
			double d;
			double num;
			double num2;
			Complex.Asin_Internal(Math.Abs(value.Real), Math.Abs(value.Imaginary), out d, out num, out num2);
			double num3;
			if (num < 0.0)
			{
				num3 = Math.Acos(d);
			}
			else
			{
				num3 = Math.Atan(1.0 / num);
			}
			if (value.Real < 0.0)
			{
				num3 = 3.141592653589793 - num3;
			}
			if (value.Imaginary > 0.0)
			{
				num2 = -num2;
			}
			return new Complex(num3, num2);
		}

		/// <summary>Возвращает тангенс указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Тангенс <paramref name="value" />.</returns>
		// Token: 0x06000241 RID: 577 RVA: 0x00010408 File Offset: 0x0000E608
		public static Complex Tan(Complex value)
		{
			double num = 2.0 * value.m_real;
			double num2 = 2.0 * value.m_imaginary;
			double num3 = Math.Exp(num2);
			double num4 = 1.0 / num3;
			double num5 = (num3 + num4) * 0.5;
			if (Math.Abs(value.m_imaginary) <= 4.0)
			{
				double num6 = (num3 - num4) * 0.5;
				double num7 = Math.Cos(num) + num5;
				return new Complex(Math.Sin(num) / num7, num6 / num7);
			}
			double num8 = 1.0 + Math.Cos(num) / num5;
			return new Complex(Math.Sin(num) / num5 / num8, Math.Tanh(num2) / num8);
		}

		/// <summary>Возвращает гиперболический тангенс указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Гиперболический тангенс <paramref name="value" />.</returns>
		// Token: 0x06000242 RID: 578 RVA: 0x000104CC File Offset: 0x0000E6CC
		public static Complex Tanh(Complex value)
		{
			Complex complex = Complex.Tan(new Complex(-value.m_imaginary, value.m_real));
			return new Complex(complex.m_imaginary, -complex.m_real);
		}

		/// <summary>Возвращает угол, представляющий собой арктангенс указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Угол, представляющий собой арктангенс параметра <paramref name="value" />.</returns>
		// Token: 0x06000243 RID: 579 RVA: 0x00010504 File Offset: 0x0000E704
		public static Complex Atan(Complex value)
		{
			Complex right = new Complex(2.0, 0.0);
			return Complex.ImaginaryOne / right * (Complex.Log(Complex.One - Complex.ImaginaryOne * value) - Complex.Log(Complex.One + Complex.ImaginaryOne * value));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00010574 File Offset: 0x0000E774
		private static void Asin_Internal(double x, double y, out double b, out double bPrime, out double v)
		{
			if (x > Complex.s_asinOverflowThreshold || y > Complex.s_asinOverflowThreshold)
			{
				b = -1.0;
				bPrime = x / y;
				double num;
				double num2;
				if (x < y)
				{
					num = x;
					num2 = y;
				}
				else
				{
					num = y;
					num2 = x;
				}
				double num3 = num / num2;
				v = Complex.s_log2 + Math.Log(num2) + 0.5 * Complex.Log1P(num3 * num3);
				return;
			}
			double num4 = Complex.Hypot(x + 1.0, y);
			double num5 = Complex.Hypot(x - 1.0, y);
			double num6 = (num4 + num5) * 0.5;
			b = x / num6;
			if (b > 0.75)
			{
				if (x <= 1.0)
				{
					double num7 = (y * y / (num4 + (x + 1.0)) + (num5 + (1.0 - x))) * 0.5;
					bPrime = x / Math.Sqrt((num6 + x) * num7);
				}
				else
				{
					double num8 = (1.0 / (num4 + (x + 1.0)) + 1.0 / (num5 + (x - 1.0))) * 0.5;
					bPrime = x / y / Math.Sqrt((num6 + x) * num8);
				}
			}
			else
			{
				bPrime = -1.0;
			}
			if (num6 >= 1.5)
			{
				v = Math.Log(num6 + Math.Sqrt((num6 - 1.0) * (num6 + 1.0)));
				return;
			}
			if (x < 1.0)
			{
				double num9 = (1.0 / (num4 + (x + 1.0)) + 1.0 / (num5 + (1.0 - x))) * 0.5;
				double num10 = y * y * num9;
				v = Complex.Log1P(num10 + y * Math.Sqrt(num9 * (num6 + 1.0)));
				return;
			}
			double num11 = (y * y / (num4 + (x + 1.0)) + (num5 + (x - 1.0))) * 0.5;
			v = Complex.Log1P(num11 + Math.Sqrt(num11 * (num6 + 1.0)));
		}

		/// <summary>Возвращает натуральный логарифм (по основанию <see langword="e" />) указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Натуральный логарифм (по основанию <see langword="e" />) значения <paramref name="value" />.</returns>
		// Token: 0x06000245 RID: 581 RVA: 0x000107BD File Offset: 0x0000E9BD
		public static Complex Log(Complex value)
		{
			return new Complex(Math.Log(Complex.Abs(value)), Math.Atan2(value.m_imaginary, value.m_real));
		}

		/// <summary>Возвращает логарифм по заданному основанию указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <param name="baseValue">Основание логарифма.</param>
		/// <returns>Логарифм <paramref name="value" /> по основанию <paramref name="baseValue" />.</returns>
		// Token: 0x06000246 RID: 582 RVA: 0x000107E0 File Offset: 0x0000E9E0
		public static Complex Log(Complex value, double baseValue)
		{
			return Complex.Log(value) / Complex.Log(baseValue);
		}

		/// <summary>Возвращает логарифм по основанию 10 указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Логарифм <paramref name="value" /> по основанию 10.</returns>
		// Token: 0x06000247 RID: 583 RVA: 0x000107F8 File Offset: 0x0000E9F8
		public static Complex Log10(Complex value)
		{
			return Complex.Scale(Complex.Log(value), 0.43429448190325);
		}

		/// <summary>Возвращает число <see langword="e" />, возведенное в степень, определяемую комплексным числом.</summary>
		/// <param name="value">Комплексное число, определяющее степень.</param>
		/// <returns>Число <see langword="e" />, возведенное в степень <paramref name="value" />.</returns>
		// Token: 0x06000248 RID: 584 RVA: 0x00010810 File Offset: 0x0000EA10
		public static Complex Exp(Complex value)
		{
			double num = Math.Exp(value.m_real);
			double real = num * Math.Cos(value.m_imaginary);
			double imaginary = num * Math.Sin(value.m_imaginary);
			return new Complex(real, imaginary);
		}

		/// <summary>Возвращает квадратный корень из указанного комплексного числа.</summary>
		/// <param name="value">Комплексное число.</param>
		/// <returns>Квадратный корень числа <paramref name="value" />.</returns>
		// Token: 0x06000249 RID: 585 RVA: 0x0001084C File Offset: 0x0000EA4C
		public static Complex Sqrt(Complex value)
		{
			if (value.m_imaginary != 0.0)
			{
				bool flag = false;
				if (Math.Abs(value.m_real) >= Complex.s_sqrtRescaleThreshold || Math.Abs(value.m_imaginary) >= Complex.s_sqrtRescaleThreshold)
				{
					if (double.IsInfinity(value.m_imaginary) && !double.IsNaN(value.m_real))
					{
						return new Complex(double.PositiveInfinity, value.m_imaginary);
					}
					value.m_real *= 0.25;
					value.m_imaginary *= 0.25;
					flag = true;
				}
				double num;
				double num2;
				if (value.m_real >= 0.0)
				{
					num = Math.Sqrt((Complex.Hypot(value.m_real, value.m_imaginary) + value.m_real) * 0.5);
					num2 = value.m_imaginary / (2.0 * num);
				}
				else
				{
					num2 = Math.Sqrt((Complex.Hypot(value.m_real, value.m_imaginary) - value.m_real) * 0.5);
					if (value.m_imaginary < 0.0)
					{
						num2 = -num2;
					}
					num = value.m_imaginary / (2.0 * num2);
				}
				if (flag)
				{
					num *= 2.0;
					num2 *= 2.0;
				}
				return new Complex(num, num2);
			}
			if (value.m_real < 0.0)
			{
				return new Complex(0.0, Math.Sqrt(-value.m_real));
			}
			return new Complex(Math.Sqrt(value.m_real), 0.0);
		}

		/// <summary>Возвращает заданное комплексное число, возведенное в степень, заданную комплексным числом.</summary>
		/// <param name="value">Комплексное число для возведения в степень.</param>
		/// <param name="power">Комплексное число, определяющее степень.</param>
		/// <returns>Комплексное число <paramref name="value" />, возведенное в степень <paramref name="power" />.</returns>
		// Token: 0x0600024A RID: 586 RVA: 0x000109F0 File Offset: 0x0000EBF0
		public static Complex Pow(Complex value, Complex power)
		{
			if (power == Complex.Zero)
			{
				return Complex.One;
			}
			if (value == Complex.Zero)
			{
				return Complex.Zero;
			}
			double real = value.m_real;
			double imaginary = value.m_imaginary;
			double real2 = power.m_real;
			double imaginary2 = power.m_imaginary;
			double num = Complex.Abs(value);
			double num2 = Math.Atan2(imaginary, real);
			double num3 = real2 * num2 + imaginary2 * Math.Log(num);
			double num4 = Math.Pow(num, real2) * Math.Pow(2.718281828459045, -imaginary2 * num2);
			return new Complex(num4 * Math.Cos(num3), num4 * Math.Sin(num3));
		}

		/// <summary>Возвращает заданное комплексное число, возведенное в степень, заданную числом с плавающей запятой двойной точности.</summary>
		/// <param name="value">Комплексное число для возведения в степень.</param>
		/// <param name="power">Число двойной точности с плавающей запятой, задающее степень.</param>
		/// <returns>Комплексное число <paramref name="value" />, возведенное в степень <paramref name="power" />.</returns>
		// Token: 0x0600024B RID: 587 RVA: 0x00010A92 File Offset: 0x0000EC92
		public static Complex Pow(Complex value, double power)
		{
			return Complex.Pow(value, new Complex(power, 0.0));
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00010AAC File Offset: 0x0000ECAC
		private static Complex Scale(Complex value, double factor)
		{
			double real = factor * value.m_real;
			double imaginary = factor * value.m_imaginary;
			return new Complex(real, imaginary);
		}

		/// <summary>Определяет неявное преобразование 16-битового целого числа со знаком в комплексное число.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x0600024D RID: 589 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public static implicit operator Complex(short value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Определяет неявное преобразование 32-битового целого числа со знаком в комплексное число.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x0600024E RID: 590 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public static implicit operator Complex(int value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Определяет неявное преобразование 64-битового целого числа со знаком в комплексное число.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x0600024F RID: 591 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public static implicit operator Complex(long value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Определяет неявное преобразование 16-битного целого числа без знака в комплексное число.   
		/// Этот интерфейс API CLS-несовместим.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x06000250 RID: 592 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		[CLSCompliant(false)]
		public static implicit operator Complex(ushort value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Определяет неявное преобразование 32-битного целого числа без знака в комплексное число.   
		/// Этот интерфейс API CLS-несовместим.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x06000251 RID: 593 RVA: 0x00010AE2 File Offset: 0x0000ECE2
		[CLSCompliant(false)]
		public static implicit operator Complex(uint value)
		{
			return new Complex(value, 0.0);
		}

		/// <summary>Определяет неявное преобразование 64-битного целого числа без знака в комплексное число.   
		/// Этот интерфейс API CLS-несовместим.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x06000252 RID: 594 RVA: 0x00010AE2 File Offset: 0x0000ECE2
		[CLSCompliant(false)]
		public static implicit operator Complex(ulong value)
		{
			return new Complex(value, 0.0);
		}

		/// <summary>Определяет неявное преобразование байта со знаком в комплексное число.   
		/// Этот интерфейс API CLS-несовместим.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x06000253 RID: 595 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		[CLSCompliant(false)]
		public static implicit operator Complex(sbyte value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Определяет неявное преобразование байта без знака в комплексное число.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x06000254 RID: 596 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public static implicit operator Complex(byte value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Определяет неявное преобразование числа с плавающей запятой одиночной точности в комплексное число.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x06000255 RID: 597 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public static implicit operator Complex(float value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Определяет неявное преобразование числа с плавающей запятой двойной точности в комплексное число.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" /> как действительную часть и ноль как мнимую часть.</returns>
		// Token: 0x06000256 RID: 598 RVA: 0x00010AF5 File Offset: 0x0000ECF5
		public static implicit operator Complex(double value)
		{
			return new Complex(value, 0.0);
		}

		/// <summary>Определяет явное преобразование значения <see cref="T:System.Numerics.BigInteger" /> в комплексное число.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Комплексное число, вещественная часть которого равна параметру <paramref name="value" />, а мнимая часть равна нулю.</returns>
		// Token: 0x06000257 RID: 599 RVA: 0x00010B06 File Offset: 0x0000ED06
		public static explicit operator Complex(BigInteger value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Определяет явное преобразование значения <see cref="T:System.Decimal" /> в комплексное число.</summary>
		/// <param name="value">Значение, преобразуемое в комплексное число.</param>
		/// <returns>Комплексное число, вещественная часть которого равна параметру <paramref name="value" />, а мнимая часть равна нулю.</returns>
		// Token: 0x06000258 RID: 600 RVA: 0x00010B1D File Offset: 0x0000ED1D
		public static explicit operator Complex(decimal value)
		{
			return new Complex((double)value, 0.0);
		}

		/// <summary>Возвращает новый экземпляр объекта <see cref="T:System.Numerics.Complex" /> со значениями действительного и мнимого чисел, равными нулю.</summary>
		// Token: 0x0400008C RID: 140
		public static readonly Complex Zero = new Complex(0.0, 0.0);

		/// <summary>Возвращает новый экземпляр объекта <see cref="T:System.Numerics.Complex" /> со значением действительного числа, равным единице, и значением мнимого числа, равным нулю.</summary>
		// Token: 0x0400008D RID: 141
		public static readonly Complex One = new Complex(1.0, 0.0);

		/// <summary>Возвращает новый экземпляр объекта <see cref="T:System.Numerics.Complex" /> со значением действительного числа, равным нулю, и значением мнимого числа, равным единице.</summary>
		// Token: 0x0400008E RID: 142
		public static readonly Complex ImaginaryOne = new Complex(0.0, 1.0);

		// Token: 0x0400008F RID: 143
		private const double InverseOfLog10 = 0.43429448190325;

		// Token: 0x04000090 RID: 144
		private static readonly double s_sqrtRescaleThreshold = double.MaxValue / (Math.Sqrt(2.0) + 1.0);

		// Token: 0x04000091 RID: 145
		private static readonly double s_asinOverflowThreshold = Math.Sqrt(double.MaxValue) / 2.0;

		// Token: 0x04000092 RID: 146
		private static readonly double s_log2 = Math.Log(2.0);

		// Token: 0x04000093 RID: 147
		private double m_real;

		// Token: 0x04000094 RID: 148
		private double m_imaginary;
	}
}
