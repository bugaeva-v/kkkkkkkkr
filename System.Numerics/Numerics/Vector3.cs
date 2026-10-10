using System;
using System.Globalization;
using System.Numerics.Hashing;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Numerics
{
	/// <summary>Представляет вектор с тремя значениями одинарной точности с плавающей запятой.</summary>
	// Token: 0x0200000B RID: 11
	public struct Vector3 : IEquatable<Vector3>, IFormattable
	{
		/// <summary>Получает вектор, три элемента которого равны нулю.</summary>
		/// <returns>Вектор, три элемента которого равны нулю (то есть он возвращает вектор <c>(0,0,0)</c>.</returns>
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000094C4 File Offset: 0x000076C4
		public static Vector3 Zero
		{
			get
			{
				return default(Vector3);
			}
		}

		/// <summary>Получает вектор, три элемента которого равны единице.</summary>
		/// <returns>Вектор, три элемента которого равны единице (то есть он возвращает вектор <c>(1,1,1)</c>.</returns>
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000094DA File Offset: 0x000076DA
		public static Vector3 One
		{
			get
			{
				return new Vector3(1f, 1f, 1f);
			}
		}

		/// <summary>Получает вектор (1,0,0).</summary>
		/// <returns>Вектор <c>(1,0,0)</c>.</returns>
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000094F0 File Offset: 0x000076F0
		public static Vector3 UnitX
		{
			get
			{
				return new Vector3(1f, 0f, 0f);
			}
		}

		/// <summary>Получает вектор (1,0,0).</summary>
		/// <returns>Вектор <c>(0,1,0)</c>.</returns>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00009506 File Offset: 0x00007706
		public static Vector3 UnitY
		{
			get
			{
				return new Vector3(0f, 1f, 0f);
			}
		}

		/// <summary>Получает вектор (0,0,1).</summary>
		/// <returns>Вектор <c>(0,0,1)</c>.</returns>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000951C File Offset: 0x0000771C
		public static Vector3 UnitZ
		{
			get
			{
				return new Vector3(0f, 0f, 1f);
			}
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код.</returns>
		// Token: 0x060000D2 RID: 210 RVA: 0x00009532 File Offset: 0x00007732
		public override int GetHashCode()
		{
			return HashHelpers.Combine(HashHelpers.Combine(this.X.GetHashCode(), this.Y.GetHashCode()), this.Z.GetHashCode());
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />. Если значением параметра <paramref name="obj" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		// Token: 0x060000D3 RID: 211 RVA: 0x0000955F File Offset: 0x0000775F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			return obj is Vector3 && this.Equals((Vector3)obj);
		}

		/// <summary>Возвращает строковое представление текущего экземпляра, используя форматирование по умолчанию.</summary>
		/// <returns>Строковое представление текущего экземпляра.</returns>
		// Token: 0x060000D4 RID: 212 RVA: 0x00009577 File Offset: 0x00007777
		public override string ToString()
		{
			return this.ToString("G", CultureInfo.CurrentCulture);
		}

		/// <summary>Возвращает строковое представление текущего экземпляра, используя заданную строку форматирования для форматирования отдельных элементов.</summary>
		/// <param name="format">Строка стандартного или настраиваемого числового формата, определяющая формат отдельных элементов.</param>
		/// <returns>Строковое представление текущего экземпляра.</returns>
		// Token: 0x060000D5 RID: 213 RVA: 0x00009589 File Offset: 0x00007789
		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.CurrentCulture);
		}

		/// <summary>Возвращает строковое представление текущего экземпляра, используя заданную строку форматирования для форматирования отдельных элементов и заданный поставщик формата для указания форматирования, определяемого языком и региональными параметрами.</summary>
		/// <param name="format">Строка стандартного или настраиваемого числового формата, определяющая формат отдельных элементов.</param>
		/// <param name="formatProvider">Поставщик формата, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление текущего экземпляра.</returns>
		// Token: 0x060000D6 RID: 214 RVA: 0x00009598 File Offset: 0x00007798
		public string ToString(string format, IFormatProvider formatProvider)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			stringBuilder.Append('<');
			stringBuilder.Append(((IFormattable)this.X).ToString(format, formatProvider));
			stringBuilder.Append(numberGroupSeparator);
			stringBuilder.Append(' ');
			stringBuilder.Append(((IFormattable)this.Y).ToString(format, formatProvider));
			stringBuilder.Append(numberGroupSeparator);
			stringBuilder.Append(' ');
			stringBuilder.Append(((IFormattable)this.Z).ToString(format, formatProvider));
			stringBuilder.Append('>');
			return stringBuilder.ToString();
		}

		/// <summary>Возвращает длину данного объекта вектора.</summary>
		/// <returns>Длина вектора.</returns>
		// Token: 0x060000D7 RID: 215 RVA: 0x0000963C File Offset: 0x0000783C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float Length()
		{
			if (Vector.IsHardwareAccelerated)
			{
				return MathF.Sqrt(Vector3.Dot(this, this));
			}
			return MathF.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z);
		}

		/// <summary>Возвращает длину вектора в квадрате.</summary>
		/// <returns>Длина вектора в квадрате.</returns>
		// Token: 0x060000D8 RID: 216 RVA: 0x00009698 File Offset: 0x00007898
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float LengthSquared()
		{
			if (Vector.IsHardwareAccelerated)
			{
				return Vector3.Dot(this, this);
			}
			return this.X * this.X + this.Y * this.Y + this.Z * this.Z;
		}

		/// <summary>Вычисляет евклидово расстояние между двумя заданными точками.</summary>
		/// <param name="value1">Первая точка.</param>
		/// <param name="value2">Вторая точка.</param>
		/// <returns>Расстояние.</returns>
		// Token: 0x060000D9 RID: 217 RVA: 0x000096E8 File Offset: 0x000078E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(Vector3 value1, Vector3 value2)
		{
			if (Vector.IsHardwareAccelerated)
			{
				Vector3 vector = value1 - value2;
				return MathF.Sqrt(Vector3.Dot(vector, vector));
			}
			float num = value1.X - value2.X;
			float num2 = value1.Y - value2.Y;
			float num3 = value1.Z - value2.Z;
			return MathF.Sqrt(num * num + num2 * num2 + num3 * num3);
		}

		/// <summary>Возвращает квадрат евклидова расстояния между двумя заданными точками.</summary>
		/// <param name="value1">Первая точка.</param>
		/// <param name="value2">Вторая точка.</param>
		/// <returns>Квадрат расстояния.</returns>
		// Token: 0x060000DA RID: 218 RVA: 0x00009748 File Offset: 0x00007948
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float DistanceSquared(Vector3 value1, Vector3 value2)
		{
			if (Vector.IsHardwareAccelerated)
			{
				Vector3 vector = value1 - value2;
				return Vector3.Dot(vector, vector);
			}
			float num = value1.X - value2.X;
			float num2 = value1.Y - value2.Y;
			float num3 = value1.Z - value2.Z;
			return num * num + num2 * num2 + num3 * num3;
		}

		/// <summary>Возвращает вектор с тем же направлением, что и заданный вектор, но с длиной равной единице.</summary>
		/// <param name="value">Нормализуемый вектор.</param>
		/// <returns>Нормализованный вектор.</returns>
		// Token: 0x060000DB RID: 219 RVA: 0x000097A0 File Offset: 0x000079A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Normalize(Vector3 value)
		{
			if (Vector.IsHardwareAccelerated)
			{
				float value2 = value.Length();
				return value / value2;
			}
			float num = MathF.Sqrt(value.X * value.X + value.Y * value.Y + value.Z * value.Z);
			return new Vector3(value.X / num, value.Y / num, value.Z / num);
		}

		/// <summary>Вычисляет векторное произведение двух векторов.</summary>
		/// <param name="vector1">Первый вектор.</param>
		/// <param name="vector2">Второй вектор.</param>
		/// <returns>Векторное произведение.</returns>
		// Token: 0x060000DC RID: 220 RVA: 0x00009810 File Offset: 0x00007A10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Cross(Vector3 vector1, Vector3 vector2)
		{
			return new Vector3(vector1.Y * vector2.Z - vector1.Z * vector2.Y, vector1.Z * vector2.X - vector1.X * vector2.Z, vector1.X * vector2.Y - vector1.Y * vector2.X);
		}

		/// <summary>Возвращает отражение вектора от поверхности, которая имеет заданную нормаль.</summary>
		/// <param name="vector">Исходный вектор.</param>
		/// <param name="normal">Нормаль отражаемой поверхности.</param>
		/// <returns>Отраженный вектор.</returns>
		// Token: 0x060000DD RID: 221 RVA: 0x00009874 File Offset: 0x00007A74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Reflect(Vector3 vector, Vector3 normal)
		{
			if (Vector.IsHardwareAccelerated)
			{
				float right = Vector3.Dot(vector, normal);
				Vector3 right2 = normal * right * 2f;
				return vector - right2;
			}
			float num = vector.X * normal.X + vector.Y * normal.Y + vector.Z * normal.Z;
			float num2 = normal.X * num * 2f;
			float num3 = normal.Y * num * 2f;
			float num4 = normal.Z * num * 2f;
			return new Vector3(vector.X - num2, vector.Y - num3, vector.Z - num4);
		}

		/// <summary>Ограничивает минимальное и максимальное значение вектора.</summary>
		/// <param name="value1">Ограничиваемый вектор.</param>
		/// <param name="min">Минимальное значение.</param>
		/// <param name="max">Максимальное значение.</param>
		/// <returns>Ограниченный вектор.</returns>
		// Token: 0x060000DE RID: 222 RVA: 0x00009924 File Offset: 0x00007B24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max)
		{
			float num = value1.X;
			num = ((num > max.X) ? max.X : num);
			num = ((num < min.X) ? min.X : num);
			float num2 = value1.Y;
			num2 = ((num2 > max.Y) ? max.Y : num2);
			num2 = ((num2 < min.Y) ? min.Y : num2);
			float num3 = value1.Z;
			num3 = ((num3 > max.Z) ? max.Z : num3);
			num3 = ((num3 < min.Z) ? min.Z : num3);
			return new Vector3(num, num2, num3);
		}

		/// <summary>Выполняет линейную интерполяцию между двумя векторами на основе заданного взвешивания.</summary>
		/// <param name="value1">Первый вектор.</param>
		/// <param name="value2">Второй вектор.</param>
		/// <param name="amount">Значение от 0 до 1, указывающее вес <paramref name="value2" />.</param>
		/// <returns>Интерполированный вектор.</returns>
		// Token: 0x060000DF RID: 223 RVA: 0x000099C0 File Offset: 0x00007BC0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
		{
			if (Vector.IsHardwareAccelerated)
			{
				Vector3 left = value1 * (1f - amount);
				Vector3 right = value2 * amount;
				return left + right;
			}
			return new Vector3(value1.X + (value2.X - value1.X) * amount, value1.Y + (value2.Y - value1.Y) * amount, value1.Z + (value2.Z - value1.Z) * amount);
		}

		/// <summary>Преобразует вектор посредством заданной матрицы 4x4.</summary>
		/// <param name="position">Преобразуемый вектор.</param>
		/// <param name="matrix">Матрица преобразования.</param>
		/// <returns>Преобразованный вектор.</returns>
		// Token: 0x060000E0 RID: 224 RVA: 0x00009A38 File Offset: 0x00007C38
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Transform(Vector3 position, Matrix4x4 matrix)
		{
			return new Vector3(position.X * matrix.M11 + position.Y * matrix.M21 + position.Z * matrix.M31 + matrix.M41, position.X * matrix.M12 + position.Y * matrix.M22 + position.Z * matrix.M32 + matrix.M42, position.X * matrix.M13 + position.Y * matrix.M23 + position.Z * matrix.M33 + matrix.M43);
		}

		/// <summary>Преобразует нормаль вектора посредством заданной матрицы 4x4.</summary>
		/// <param name="normal">Исходный вектор.</param>
		/// <param name="matrix">Матрица.</param>
		/// <returns>Преобразованный вектор.</returns>
		// Token: 0x060000E1 RID: 225 RVA: 0x00009ADC File Offset: 0x00007CDC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 TransformNormal(Vector3 normal, Matrix4x4 matrix)
		{
			return new Vector3(normal.X * matrix.M11 + normal.Y * matrix.M21 + normal.Z * matrix.M31, normal.X * matrix.M12 + normal.Y * matrix.M22 + normal.Z * matrix.M32, normal.X * matrix.M13 + normal.Y * matrix.M23 + normal.Z * matrix.M33);
		}

		/// <summary>Преобразует вектор посредством заданного значения поворота кватерниона.</summary>
		/// <param name="value">Поворачиваемый вектор.</param>
		/// <param name="rotation">Применяемый поворот.</param>
		/// <returns>Преобразованный вектор.</returns>
		// Token: 0x060000E2 RID: 226 RVA: 0x00009B6C File Offset: 0x00007D6C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Transform(Vector3 value, Quaternion rotation)
		{
			float num = rotation.X + rotation.X;
			float num2 = rotation.Y + rotation.Y;
			float num3 = rotation.Z + rotation.Z;
			float num4 = rotation.W * num;
			float num5 = rotation.W * num2;
			float num6 = rotation.W * num3;
			float num7 = rotation.X * num;
			float num8 = rotation.X * num2;
			float num9 = rotation.X * num3;
			float num10 = rotation.Y * num2;
			float num11 = rotation.Y * num3;
			float num12 = rotation.Z * num3;
			return new Vector3(value.X * (1f - num10 - num12) + value.Y * (num8 - num6) + value.Z * (num9 + num5), value.X * (num8 + num6) + value.Y * (1f - num7 - num12) + value.Z * (num11 - num4), value.X * (num9 - num5) + value.Y * (num11 + num4) + value.Z * (1f - num7 - num10));
		}

		/// <summary>Складывает два вектора.</summary>
		/// <param name="left">Первый складываемый вектор.</param>
		/// <param name="right">Второй складываемый вектор.</param>
		/// <returns>Суммарный вектор.</returns>
		// Token: 0x060000E3 RID: 227 RVA: 0x00009C83 File Offset: 0x00007E83
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Add(Vector3 left, Vector3 right)
		{
			return left + right;
		}

		/// <summary>Вычитает второй вектор из первого.</summary>
		/// <param name="left">Первый вектор.</param>
		/// <param name="right">Второй вектор.</param>
		/// <returns>Вектор отличия.</returns>
		// Token: 0x060000E4 RID: 228 RVA: 0x00009C8C File Offset: 0x00007E8C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Subtract(Vector3 left, Vector3 right)
		{
			return left - right;
		}

		/// <summary>Возвращает новый вектор, значения которого являются произведением каждой пары элементов в двух заданных векторах.</summary>
		/// <param name="left">Первый вектор.</param>
		/// <param name="right">Второй вектор.</param>
		/// <returns>Поэлементный вектор произведения.</returns>
		// Token: 0x060000E5 RID: 229 RVA: 0x00009C95 File Offset: 0x00007E95
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3 left, Vector3 right)
		{
			return left * right;
		}

		/// <summary>Умножает вектор на заданный скаляр.</summary>
		/// <param name="left">Умножаемый вектор.</param>
		/// <param name="right">Скалярное значение.</param>
		/// <returns>Масштабированный вектор.</returns>
		// Token: 0x060000E6 RID: 230 RVA: 0x00009C9E File Offset: 0x00007E9E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3 left, float right)
		{
			return left * right;
		}

		/// <summary>Умножает скалярное значение на заданный вектор.</summary>
		/// <param name="left">Масштабированное значение.</param>
		/// <param name="right">Вектор.</param>
		/// <returns>Масштабированный вектор.</returns>
		// Token: 0x060000E7 RID: 231 RVA: 0x00009CA7 File Offset: 0x00007EA7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(float left, Vector3 right)
		{
			return left * right;
		}

		/// <summary>Делит первый вектор на второй.</summary>
		/// <param name="left">Первый вектор.</param>
		/// <param name="right">Второй вектор.</param>
		/// <returns>Вектор, полученный в результате деления.</returns>
		// Token: 0x060000E8 RID: 232 RVA: 0x00009CB0 File Offset: 0x00007EB0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(Vector3 left, Vector3 right)
		{
			return left / right;
		}

		/// <summary>Делит заданный вектор на указанное скалярное значение.</summary>
		/// <param name="left">Вектор.</param>
		/// <param name="divisor">Скалярное значение.</param>
		/// <returns>Вектор, полученный в результате деления.</returns>
		// Token: 0x060000E9 RID: 233 RVA: 0x00009CB9 File Offset: 0x00007EB9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(Vector3 left, float divisor)
		{
			return left / divisor;
		}

		/// <summary>Преобразует заданный вектор в отрицательный.</summary>
		/// <param name="value">Вектор, преобразуемый в отрицательный.</param>
		/// <returns>Вектор, преобразованный в отрицательный.</returns>
		// Token: 0x060000EA RID: 234 RVA: 0x00009CC2 File Offset: 0x00007EC2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Negate(Vector3 value)
		{
			return -value;
		}

		/// <summary>Создает новый объект <see cref="T:System.Numerics.Vector3" /> с тремя элементами, имеющими одинаковое значение.</summary>
		/// <param name="value">Значение, присваиваемое всем трем элементам.</param>
		// Token: 0x060000EB RID: 235 RVA: 0x00009CCA File Offset: 0x00007ECA
		[Intrinsic]
		public Vector3(float value)
		{
			this = new Vector3(value, value, value);
		}

		/// <summary>Создает новый объект <see cref="T:System.Numerics.Vector3" /> на основе заданного объекта <see cref="T:System.Numerics.Vector2" /> и значения.</summary>
		/// <param name="value">Вектор с двумя элементами.</param>
		/// <param name="z">Дополнительное значение, присваиваемое полю <see cref="F:System.Numerics.Vector3.Z" />.</param>
		// Token: 0x060000EC RID: 236 RVA: 0x00009CD5 File Offset: 0x00007ED5
		public Vector3(Vector2 value, float z)
		{
			this = new Vector3(value.X, value.Y, z);
		}

		/// <summary>Создает вектор, элементы которого имеют заданные значения.</summary>
		/// <param name="x">Значение, присваиваемое полю <see cref="F:System.Numerics.Vector3.X" />.</param>
		/// <param name="y">Значение, присваиваемое полю <see cref="F:System.Numerics.Vector3.Y" />.</param>
		/// <param name="z">Значение, присваиваемое полю <see cref="F:System.Numerics.Vector3.Z" />.</param>
		// Token: 0x060000ED RID: 237 RVA: 0x00009CEA File Offset: 0x00007EEA
		[Intrinsic]
		public Vector3(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		/// <summary>Копирует элементы вектора в заданный массив.</summary>
		/// <param name="array">Массив назначения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Количество элементов в текущем экземпляре больше, чем в массиве.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x060000EE RID: 238 RVA: 0x00009D01 File Offset: 0x00007F01
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CopyTo(float[] array)
		{
			this.CopyTo(array, 0);
		}

		/// <summary>Копирует элементы вектора в заданный массив, начиная с указанной позиции индекса.</summary>
		/// <param name="array">Массив назначения.</param>
		/// <param name="index">Индекс, с которого начинается копирование первого элемента вектора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Количество элементов в текущем экземпляре больше, чем в массиве.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Длина параметра <paramref name="index" /> больше или равна длине массива.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x060000EF RID: 239 RVA: 0x00009D0C File Offset: 0x00007F0C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CopyTo(float[] array, int index)
		{
			if (array == null)
			{
				throw new NullReferenceException("The method was called with a null array argument.");
			}
			if (index < 0 || index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index", SR.Format("Index was out of bounds:", index));
			}
			if (array.Length - index < 3)
			{
				throw new ArgumentException(SR.Format("Number of elements in source vector is greater than the destination array", index));
			}
			array[index] = this.X;
			array[index + 1] = this.Y;
			array[index + 2] = this.Z;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр другому вектору.</summary>
		/// <param name="other">Другой вектор.</param>
		/// <returns>Значение <see langword="true" />, если два вектора равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000F0 RID: 240 RVA: 0x00009D89 File Offset: 0x00007F89
		[Intrinsic]
		public bool Equals(Vector3 other)
		{
			return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
		}

		/// <summary>Возвращает скалярное произведение двух векторов.</summary>
		/// <param name="vector1">Первый вектор.</param>
		/// <param name="vector2">Второй вектор.</param>
		/// <returns>Скалярное произведение.</returns>
		// Token: 0x060000F1 RID: 241 RVA: 0x00009DB7 File Offset: 0x00007FB7
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Vector3 vector1, Vector3 vector2)
		{
			return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z;
		}

		/// <summary>Возвращает вектор, элементы которого являются минимальными значениями каждой пары элементов в двух заданных векторах.</summary>
		/// <param name="value1">Первый вектор.</param>
		/// <param name="value2">Второй вектор.</param>
		/// <returns>Вектор, приведенный к минимуму.</returns>
		// Token: 0x060000F2 RID: 242 RVA: 0x00009DE4 File Offset: 0x00007FE4
		[Intrinsic]
		public static Vector3 Min(Vector3 value1, Vector3 value2)
		{
			return new Vector3((value1.X < value2.X) ? value1.X : value2.X, (value1.Y < value2.Y) ? value1.Y : value2.Y, (value1.Z < value2.Z) ? value1.Z : value2.Z);
		}

		/// <summary>Возвращает вектор, элементы которого являются максимальными значениями каждой пары элементов в двух заданных векторах.</summary>
		/// <param name="value1">Первый вектор.</param>
		/// <param name="value2">Второй вектор.</param>
		/// <returns>Вектор, приведенный к максимуму.</returns>
		// Token: 0x060000F3 RID: 243 RVA: 0x00009E4C File Offset: 0x0000804C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Max(Vector3 value1, Vector3 value2)
		{
			return new Vector3((value1.X > value2.X) ? value1.X : value2.X, (value1.Y > value2.Y) ? value1.Y : value2.Y, (value1.Z > value2.Z) ? value1.Z : value2.Z);
		}

		/// <summary>Возвращает вектор, элементы которого являются абсолютными значениями каждого из элементов заданного вектора.</summary>
		/// <param name="value">Вектор.</param>
		/// <returns>Вектор абсолютного значения.</returns>
		// Token: 0x060000F4 RID: 244 RVA: 0x00009EB2 File Offset: 0x000080B2
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Abs(Vector3 value)
		{
			return new Vector3(MathF.Abs(value.X), MathF.Abs(value.Y), MathF.Abs(value.Z));
		}

		/// <summary>Возвращает вектор, элементы которого являются квадратным корнем каждого из элементов заданного вектора.</summary>
		/// <param name="value">Вектор.</param>
		/// <returns>Вектор квадратного корня.</returns>
		// Token: 0x060000F5 RID: 245 RVA: 0x00009EDA File Offset: 0x000080DA
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 SquareRoot(Vector3 value)
		{
			return new Vector3(MathF.Sqrt(value.X), MathF.Sqrt(value.Y), MathF.Sqrt(value.Z));
		}

		/// <summary>Складывает два вектора.</summary>
		/// <param name="left">Первый складываемый вектор.</param>
		/// <param name="right">Второй складываемый вектор.</param>
		/// <returns>Суммарный вектор.</returns>
		// Token: 0x060000F6 RID: 246 RVA: 0x00009F02 File Offset: 0x00008102
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator +(Vector3 left, Vector3 right)
		{
			return new Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
		}

		/// <summary>Вычитает второй вектор из первого.</summary>
		/// <param name="left">Первый вектор.</param>
		/// <param name="right">Второй вектор.</param>
		/// <returns>Вектор, полученный в результате вычитания <paramref name="right" /> из <paramref name="left" />.</returns>
		// Token: 0x060000F7 RID: 247 RVA: 0x00009F30 File Offset: 0x00008130
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator -(Vector3 left, Vector3 right)
		{
			return new Vector3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
		}

		/// <summary>Возвращает новый вектор, значения которого являются произведением каждой пары элементов в двух заданных векторах.</summary>
		/// <param name="left">Первый вектор.</param>
		/// <param name="right">Второй вектор.</param>
		/// <returns>Поэлементный вектор произведения.</returns>
		// Token: 0x060000F8 RID: 248 RVA: 0x00009F5E File Offset: 0x0000815E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator *(Vector3 left, Vector3 right)
		{
			return new Vector3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
		}

		/// <summary>Умножает заданный вектор на указанное скалярное значение.</summary>
		/// <param name="left">Вектор.</param>
		/// <param name="right">Скалярное значение.</param>
		/// <returns>Масштабированный вектор.</returns>
		// Token: 0x060000F9 RID: 249 RVA: 0x00009F8C File Offset: 0x0000818C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator *(Vector3 left, float right)
		{
			return left * new Vector3(right);
		}

		/// <summary>Умножает скалярное значение на заданный вектор.</summary>
		/// <param name="left">Вектор.</param>
		/// <param name="right">Скалярное значение.</param>
		/// <returns>Масштабированный вектор.</returns>
		// Token: 0x060000FA RID: 250 RVA: 0x00009F9A File Offset: 0x0000819A
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator *(float left, Vector3 right)
		{
			return new Vector3(left) * right;
		}

		/// <summary>Делит первый вектор на второй.</summary>
		/// <param name="left">Первый вектор.</param>
		/// <param name="right">Второй вектор.</param>
		/// <returns>Вектор, полученный в результате деления <paramref name="left" /> на <paramref name="right" />.</returns>
		// Token: 0x060000FB RID: 251 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator /(Vector3 left, Vector3 right)
		{
			return new Vector3(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
		}

		/// <summary>Делит заданный вектор на указанное скалярное значение.</summary>
		/// <param name="value1">Вектор.</param>
		/// <param name="value2">Скалярное значение.</param>
		/// <returns>Результат деления.</returns>
		// Token: 0x060000FC RID: 252 RVA: 0x00009FD6 File Offset: 0x000081D6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator /(Vector3 value1, float value2)
		{
			return value1 / new Vector3(value2);
		}

		/// <summary>Преобразует заданный вектор в отрицательный.</summary>
		/// <param name="value">Вектор, преобразуемый в отрицательный.</param>
		/// <returns>Вектор, преобразованный в отрицательный.</returns>
		// Token: 0x060000FD RID: 253 RVA: 0x00009FE4 File Offset: 0x000081E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator -(Vector3 value)
		{
			return Vector3.Zero - value;
		}

		/// <summary>Возвращает значение, указывающее, равна ли каждая пара элементов в двух заданных векторах.</summary>
		/// <param name="left">Первый сравниваемый вектор.</param>
		/// <param name="right">Второй сравниваемый вектор.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000FE RID: 254 RVA: 0x00009D89 File Offset: 0x00007F89
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Vector3 left, Vector3 right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		/// <summary>Возвращает значение, указывающее на неравенство двух заданных векторов.</summary>
		/// <param name="left">Первый сравниваемый вектор.</param>
		/// <param name="right">Второй сравниваемый вектор.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000FF RID: 255 RVA: 0x00009FF1 File Offset: 0x000081F1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Vector3 left, Vector3 right)
		{
			return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
		}

		/// <summary>Координата X вектора.</summary>
		// Token: 0x04000064 RID: 100
		public float X;

		/// <summary>Координата Y вектора.</summary>
		// Token: 0x04000065 RID: 101
		public float Y;

		/// <summary>Координата Z вектора.</summary>
		// Token: 0x04000066 RID: 102
		public float Z;
	}
}
