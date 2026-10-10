using System;
using System.Globalization;

namespace System.Numerics
{
	/// <summary>Представляет матрицу 3x2.</summary>
	// Token: 0x02000004 RID: 4
	public struct Matrix3x2 : IEquatable<Matrix3x2>
	{
		/// <summary>Получает матрицу мультипликативного тождества.</summary>
		/// <returns>Матрица мультипликативного тождества.</returns>
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020B9 File Offset: 0x000002B9
		public static Matrix3x2 Identity
		{
			get
			{
				return Matrix3x2._identity;
			}
		}

		/// <summary>Указывает, является ли текущая матрица единичной матрицей.</summary>
		/// <returns>Значение <see langword="true" />, если текущая матрица — единичная матрица; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020C0 File Offset: 0x000002C0
		public bool IsIdentity
		{
			get
			{
				return this.M11 == 1f && this.M22 == 1f && this.M12 == 0f && this.M21 == 0f && this.M31 == 0f && this.M32 == 0f;
			}
		}

		/// <summary>Получает или задает координату трансляции данной матрицы.</summary>
		/// <returns>Координата трансляции текущего экземпляра.</returns>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000211D File Offset: 0x0000031D
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002130 File Offset: 0x00000330
		public Vector2 Translation
		{
			get
			{
				return new Vector2(this.M31, this.M32);
			}
			set
			{
				this.M31 = value.X;
				this.M32 = value.Y;
			}
		}

		/// <summary>Создает матрицу 3x2 на основе заданных координат.</summary>
		/// <param name="m11">Значение, которое присваивается первому элементу в первой строке.</param>
		/// <param name="m12">Значение, которое присваивается второму элементу в первой строке.</param>
		/// <param name="m21">Значение, которое присваивается первому элементу во второй строке.</param>
		/// <param name="m22">Значение, которое присваивается второму элементу во второй строке.</param>
		/// <param name="m31">Значение, которое присваивается первому элементу в третьей строке.</param>
		/// <param name="m32">Значение, которое присваивается второму элементу в третьей строке.</param>
		// Token: 0x0600000F RID: 15 RVA: 0x0000214A File Offset: 0x0000034A
		public Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32)
		{
			this.M11 = m11;
			this.M12 = m12;
			this.M21 = m21;
			this.M22 = m22;
			this.M31 = m31;
			this.M32 = m32;
		}

		/// <summary>Создает матрицу трансляции на основе заданного двухмерного вектора.</summary>
		/// <param name="position">Позиция трансляции.</param>
		/// <returns>Матрица трансляции.</returns>
		// Token: 0x06000010 RID: 16 RVA: 0x0000217C File Offset: 0x0000037C
		public static Matrix3x2 CreateTranslation(Vector2 position)
		{
			Matrix3x2 result;
			result.M11 = 1f;
			result.M12 = 0f;
			result.M21 = 0f;
			result.M22 = 1f;
			result.M31 = position.X;
			result.M32 = position.Y;
			return result;
		}

		/// <summary>Создает матрицу трансляции на основе заданных координат X и Y.</summary>
		/// <param name="xPosition">Позиция по оси Х.</param>
		/// <param name="yPosition">Позиция по оси Y.</param>
		/// <returns>Матрица трансляции.</returns>
		// Token: 0x06000011 RID: 17 RVA: 0x000021D4 File Offset: 0x000003D4
		public static Matrix3x2 CreateTranslation(float xPosition, float yPosition)
		{
			Matrix3x2 result;
			result.M11 = 1f;
			result.M12 = 0f;
			result.M21 = 0f;
			result.M22 = 1f;
			result.M31 = xPosition;
			result.M32 = yPosition;
			return result;
		}

		/// <summary>Создает матрицу масштабирования на основе заданных координат X и Y.</summary>
		/// <param name="xScale">Значение для масштабирования по оси X.</param>
		/// <param name="yScale">Значение для масштабирования по оси Y.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x06000012 RID: 18 RVA: 0x00002224 File Offset: 0x00000424
		public static Matrix3x2 CreateScale(float xScale, float yScale)
		{
			Matrix3x2 result;
			result.M11 = xScale;
			result.M12 = 0f;
			result.M21 = 0f;
			result.M22 = yScale;
			result.M31 = 0f;
			result.M32 = 0f;
			return result;
		}

		/// <summary>Создает матрицу масштабирования со смещением на заданную центральную точку.</summary>
		/// <param name="xScale">Значение для масштабирования по оси X.</param>
		/// <param name="yScale">Значение для масштабирования по оси Y.</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x06000013 RID: 19 RVA: 0x00002274 File Offset: 0x00000474
		public static Matrix3x2 CreateScale(float xScale, float yScale, Vector2 centerPoint)
		{
			float m = centerPoint.X * (1f - xScale);
			float m2 = centerPoint.Y * (1f - yScale);
			Matrix3x2 result;
			result.M11 = xScale;
			result.M12 = 0f;
			result.M21 = 0f;
			result.M22 = yScale;
			result.M31 = m;
			result.M32 = m2;
			return result;
		}

		/// <summary>Создает матрицу масштабирования на основе заданного масштаба вектора.</summary>
		/// <param name="scales">Используемый масштаб.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x06000014 RID: 20 RVA: 0x000022D8 File Offset: 0x000004D8
		public static Matrix3x2 CreateScale(Vector2 scales)
		{
			Matrix3x2 result;
			result.M11 = scales.X;
			result.M12 = 0f;
			result.M21 = 0f;
			result.M22 = scales.Y;
			result.M31 = 0f;
			result.M32 = 0f;
			return result;
		}

		/// <summary>Создает матрицу масштабирования на основе заданного масштаба вектора со смещением от указанной центральной точки.</summary>
		/// <param name="scales">Используемый масштаб.</param>
		/// <param name="centerPoint">Смещение от центра.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x06000015 RID: 21 RVA: 0x00002330 File Offset: 0x00000530
		public static Matrix3x2 CreateScale(Vector2 scales, Vector2 centerPoint)
		{
			float m = centerPoint.X * (1f - scales.X);
			float m2 = centerPoint.Y * (1f - scales.Y);
			Matrix3x2 result;
			result.M11 = scales.X;
			result.M12 = 0f;
			result.M21 = 0f;
			result.M22 = scales.Y;
			result.M31 = m;
			result.M32 = m2;
			return result;
		}

		/// <summary>Создает матрицу масштабирования с равномерным масштабированием с данным масштабом.</summary>
		/// <param name="scale">Используемый равномерный масштаб.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x06000016 RID: 22 RVA: 0x000023A8 File Offset: 0x000005A8
		public static Matrix3x2 CreateScale(float scale)
		{
			Matrix3x2 result;
			result.M11 = scale;
			result.M12 = 0f;
			result.M21 = 0f;
			result.M22 = scale;
			result.M31 = 0f;
			result.M32 = 0f;
			return result;
		}

		/// <summary>Создает матрицу масштабирования с равномерным масштабированием с данным масштабом со смещением от указанного центра.</summary>
		/// <param name="scale">Используемый равномерный масштаб.</param>
		/// <param name="centerPoint">Смещение от центра.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x06000017 RID: 23 RVA: 0x000023F8 File Offset: 0x000005F8
		public static Matrix3x2 CreateScale(float scale, Vector2 centerPoint)
		{
			float m = centerPoint.X * (1f - scale);
			float m2 = centerPoint.Y * (1f - scale);
			Matrix3x2 result;
			result.M11 = scale;
			result.M12 = 0f;
			result.M21 = 0f;
			result.M22 = scale;
			result.M31 = m;
			result.M32 = m2;
			return result;
		}

		/// <summary>Создает матрицу наклона на основе заданных углов в радианах.</summary>
		/// <param name="radiansX">Угол X (в радианах).</param>
		/// <param name="radiansY">Угол Y (в радианах).</param>
		/// <returns>Матрица наклона.</returns>
		// Token: 0x06000018 RID: 24 RVA: 0x0000245C File Offset: 0x0000065C
		public static Matrix3x2 CreateSkew(float radiansX, float radiansY)
		{
			float m = MathF.Tan(radiansX);
			float m2 = MathF.Tan(radiansY);
			Matrix3x2 result;
			result.M11 = 1f;
			result.M12 = m2;
			result.M21 = m;
			result.M22 = 1f;
			result.M31 = 0f;
			result.M32 = 0f;
			return result;
		}

		/// <summary>Создает матрицу наклона на основе заданных углов в радианах и центральной точки.</summary>
		/// <param name="radiansX">Угол X (в радианах).</param>
		/// <param name="radiansY">Угол Y (в радианах).</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица наклона.</returns>
		// Token: 0x06000019 RID: 25 RVA: 0x000024B8 File Offset: 0x000006B8
		public static Matrix3x2 CreateSkew(float radiansX, float radiansY, Vector2 centerPoint)
		{
			float num = MathF.Tan(radiansX);
			float num2 = MathF.Tan(radiansY);
			float m = -centerPoint.Y * num;
			float m2 = -centerPoint.X * num2;
			Matrix3x2 result;
			result.M11 = 1f;
			result.M12 = num2;
			result.M21 = num;
			result.M22 = 1f;
			result.M31 = m;
			result.M32 = m2;
			return result;
		}

		/// <summary>Создает матрицу поворота на основе заданного угла поворота в радианах.</summary>
		/// <param name="radians">Значение поворота (в радианах).</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x0600001A RID: 26 RVA: 0x00002524 File Offset: 0x00000724
		public static Matrix3x2 CreateRotation(float radians)
		{
			radians = MathF.IEEERemainder(radians, 6.2831855f);
			float num;
			float num2;
			if (radians > -1.7453294E-05f && radians < 1.7453294E-05f)
			{
				num = 1f;
				num2 = 0f;
			}
			else if (radians > 1.570779f && radians < 1.5708138f)
			{
				num = 0f;
				num2 = 1f;
			}
			else if (radians < -3.1415753f || radians > 3.1415753f)
			{
				num = -1f;
				num2 = 0f;
			}
			else if (radians > -1.5708138f && radians < -1.570779f)
			{
				num = 0f;
				num2 = -1f;
			}
			else
			{
				num = MathF.Cos(radians);
				num2 = MathF.Sin(radians);
			}
			Matrix3x2 result;
			result.M11 = num;
			result.M12 = num2;
			result.M21 = -num2;
			result.M22 = num;
			result.M31 = 0f;
			result.M32 = 0f;
			return result;
		}

		/// <summary>Создает матрицу поворота на основе заданного угла поворота в радианах и центральной точки.</summary>
		/// <param name="radians">Значение поворота (в радианах).</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x0600001B RID: 27 RVA: 0x00002600 File Offset: 0x00000800
		public static Matrix3x2 CreateRotation(float radians, Vector2 centerPoint)
		{
			radians = MathF.IEEERemainder(radians, 6.2831855f);
			float num;
			float num2;
			if (radians > -1.7453294E-05f && radians < 1.7453294E-05f)
			{
				num = 1f;
				num2 = 0f;
			}
			else if (radians > 1.570779f && radians < 1.5708138f)
			{
				num = 0f;
				num2 = 1f;
			}
			else if (radians < -3.1415753f || radians > 3.1415753f)
			{
				num = -1f;
				num2 = 0f;
			}
			else if (radians > -1.5708138f && radians < -1.570779f)
			{
				num = 0f;
				num2 = -1f;
			}
			else
			{
				num = MathF.Cos(radians);
				num2 = MathF.Sin(radians);
			}
			float m = centerPoint.X * (1f - num) + centerPoint.Y * num2;
			float m2 = centerPoint.Y * (1f - num) - centerPoint.X * num2;
			Matrix3x2 result;
			result.M11 = num;
			result.M12 = num2;
			result.M21 = -num2;
			result.M22 = num;
			result.M31 = m;
			result.M32 = m2;
			return result;
		}

		/// <summary>Вычисляет определитель данной матрицы.</summary>
		/// <returns>Определитель.</returns>
		// Token: 0x0600001C RID: 28 RVA: 0x00002704 File Offset: 0x00000904
		public float GetDeterminant()
		{
			return this.M11 * this.M22 - this.M21 * this.M12;
		}

		/// <summary>Инвертирует заданную матрицу. Возвращаемое значение указывает, успешно ли выполнена операция.</summary>
		/// <param name="matrix">Инвертируемая матрица.</param>
		/// <param name="result">В качестве возвращаемого значения этот метод содержит инвертированную матрицу, если операция выполнена успешно.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="matrix" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600001D RID: 29 RVA: 0x00002724 File Offset: 0x00000924
		public static bool Invert(Matrix3x2 matrix, out Matrix3x2 result)
		{
			float num = matrix.M11 * matrix.M22 - matrix.M21 * matrix.M12;
			if (MathF.Abs(num) < 1E-45f)
			{
				result = new Matrix3x2(float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN);
				return false;
			}
			float num2 = 1f / num;
			result.M11 = matrix.M22 * num2;
			result.M12 = -matrix.M12 * num2;
			result.M21 = -matrix.M21 * num2;
			result.M22 = matrix.M11 * num2;
			result.M31 = (matrix.M21 * matrix.M32 - matrix.M31 * matrix.M22) * num2;
			result.M32 = (matrix.M31 * matrix.M12 - matrix.M11 * matrix.M32) * num2;
			return true;
		}

		/// <summary>Выполняет линейную интерполяцию из одной матрицы во вторую матрицу на основе значения, указывающего взвешивание второй матрицы.</summary>
		/// <param name="matrix1">Первая матрица.</param>
		/// <param name="matrix2">Вторая матрица.</param>
		/// <param name="amount">Относительное взвешивание матрицы <paramref name="matrix2" />.</param>
		/// <returns>Интерполированная матрица.</returns>
		// Token: 0x0600001E RID: 30 RVA: 0x00002810 File Offset: 0x00000A10
		public static Matrix3x2 Lerp(Matrix3x2 matrix1, Matrix3x2 matrix2, float amount)
		{
			Matrix3x2 result;
			result.M11 = matrix1.M11 + (matrix2.M11 - matrix1.M11) * amount;
			result.M12 = matrix1.M12 + (matrix2.M12 - matrix1.M12) * amount;
			result.M21 = matrix1.M21 + (matrix2.M21 - matrix1.M21) * amount;
			result.M22 = matrix1.M22 + (matrix2.M22 - matrix1.M22) * amount;
			result.M31 = matrix1.M31 + (matrix2.M31 - matrix1.M31) * amount;
			result.M32 = matrix1.M32 + (matrix2.M32 - matrix1.M32) * amount;
			return result;
		}

		/// <summary>Преобразует заданную матрицу в отрицательную, умножая все ее значения на "-1".</summary>
		/// <param name="value">Матрица, преобразуемая в отрицательную.</param>
		/// <returns>Матрица, преобразованная в отрицательную.</returns>
		// Token: 0x0600001F RID: 31 RVA: 0x000028CC File Offset: 0x00000ACC
		public static Matrix3x2 Negate(Matrix3x2 value)
		{
			Matrix3x2 result;
			result.M11 = -value.M11;
			result.M12 = -value.M12;
			result.M21 = -value.M21;
			result.M22 = -value.M22;
			result.M31 = -value.M31;
			result.M32 = -value.M32;
			return result;
		}

		/// <summary>Складывает каждый элемент в одной матрице с соответствующим элементом во второй матрице.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица, содержащая суммарные значения <paramref name="value1" /> и <paramref name="value2" />.</returns>
		// Token: 0x06000020 RID: 32 RVA: 0x00002930 File Offset: 0x00000B30
		public static Matrix3x2 Add(Matrix3x2 value1, Matrix3x2 value2)
		{
			Matrix3x2 result;
			result.M11 = value1.M11 + value2.M11;
			result.M12 = value1.M12 + value2.M12;
			result.M21 = value1.M21 + value2.M21;
			result.M22 = value1.M22 + value2.M22;
			result.M31 = value1.M31 + value2.M31;
			result.M32 = value1.M32 + value2.M32;
			return result;
		}

		/// <summary>Вычитает каждый элемент во второй матрице из соответствующего элемента в первой матрице.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица, содержащая значения, которые являются результатом вычитания каждого элемента в <paramref name="value2" /> из соответствующего элемента в <paramref name="value1" />.</returns>
		// Token: 0x06000021 RID: 33 RVA: 0x000029B8 File Offset: 0x00000BB8
		public static Matrix3x2 Subtract(Matrix3x2 value1, Matrix3x2 value2)
		{
			Matrix3x2 result;
			result.M11 = value1.M11 - value2.M11;
			result.M12 = value1.M12 - value2.M12;
			result.M21 = value1.M21 - value2.M21;
			result.M22 = value1.M22 - value2.M22;
			result.M31 = value1.M31 - value2.M31;
			result.M32 = value1.M32 - value2.M32;
			return result;
		}

		/// <summary>Возвращает матрицу, полученную в результате перемножения двух матриц.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица произведения.</returns>
		// Token: 0x06000022 RID: 34 RVA: 0x00002A40 File Offset: 0x00000C40
		public static Matrix3x2 Multiply(Matrix3x2 value1, Matrix3x2 value2)
		{
			Matrix3x2 result;
			result.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21;
			result.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22;
			result.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21;
			result.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22;
			result.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value2.M31;
			result.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value2.M32;
			return result;
		}

		/// <summary>Возвращает матрицу, получаемую в результате масштабирования всех элементов заданной матрицы на скалярный множитель.</summary>
		/// <param name="value1">Масштабируемая матрица.</param>
		/// <param name="value2">Используемое значение масштабирования.</param>
		/// <returns>Масштабированная матрица.</returns>
		// Token: 0x06000023 RID: 35 RVA: 0x00002B28 File Offset: 0x00000D28
		public static Matrix3x2 Multiply(Matrix3x2 value1, float value2)
		{
			Matrix3x2 result;
			result.M11 = value1.M11 * value2;
			result.M12 = value1.M12 * value2;
			result.M21 = value1.M21 * value2;
			result.M22 = value1.M22 * value2;
			result.M31 = value1.M31 * value2;
			result.M32 = value1.M32 * value2;
			return result;
		}

		/// <summary>Преобразует заданную матрицу в отрицательную, умножая все ее значения на "-1".</summary>
		/// <param name="value">Матрица, преобразуемая в отрицательную.</param>
		/// <returns>Матрица, преобразованная в отрицательную.</returns>
		// Token: 0x06000024 RID: 36 RVA: 0x00002B90 File Offset: 0x00000D90
		public static Matrix3x2 operator -(Matrix3x2 value)
		{
			Matrix3x2 result;
			result.M11 = -value.M11;
			result.M12 = -value.M12;
			result.M21 = -value.M21;
			result.M22 = -value.M22;
			result.M31 = -value.M31;
			result.M32 = -value.M32;
			return result;
		}

		/// <summary>Складывает каждый элемент в одной матрице с соответствующим элементом во второй матрице.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица, содержащая суммарные значения.</returns>
		// Token: 0x06000025 RID: 37 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public static Matrix3x2 operator +(Matrix3x2 value1, Matrix3x2 value2)
		{
			Matrix3x2 result;
			result.M11 = value1.M11 + value2.M11;
			result.M12 = value1.M12 + value2.M12;
			result.M21 = value1.M21 + value2.M21;
			result.M22 = value1.M22 + value2.M22;
			result.M31 = value1.M31 + value2.M31;
			result.M32 = value1.M32 + value2.M32;
			return result;
		}

		/// <summary>Вычитает каждый элемент во второй матрице из соответствующего элемента в первой матрице.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица, содержащая значения, которые являются результатом вычитания каждого элемента в <paramref name="value2" /> из соответствующего элемента в <paramref name="value1" />.</returns>
		// Token: 0x06000026 RID: 38 RVA: 0x00002C7C File Offset: 0x00000E7C
		public static Matrix3x2 operator -(Matrix3x2 value1, Matrix3x2 value2)
		{
			Matrix3x2 result;
			result.M11 = value1.M11 - value2.M11;
			result.M12 = value1.M12 - value2.M12;
			result.M21 = value1.M21 - value2.M21;
			result.M22 = value1.M22 - value2.M22;
			result.M31 = value1.M31 - value2.M31;
			result.M32 = value1.M32 - value2.M32;
			return result;
		}

		/// <summary>Возвращает матрицу, полученную в результате перемножения двух матриц.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица произведения.</returns>
		// Token: 0x06000027 RID: 39 RVA: 0x00002D04 File Offset: 0x00000F04
		public static Matrix3x2 operator *(Matrix3x2 value1, Matrix3x2 value2)
		{
			Matrix3x2 result;
			result.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21;
			result.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22;
			result.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21;
			result.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22;
			result.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value2.M31;
			result.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value2.M32;
			return result;
		}

		/// <summary>Возвращает матрицу, получаемую в результате масштабирования всех элементов заданной матрицы на скалярный множитель.</summary>
		/// <param name="value1">Масштабируемая матрица.</param>
		/// <param name="value2">Используемое значение масштабирования.</param>
		/// <returns>Масштабированная матрица.</returns>
		// Token: 0x06000028 RID: 40 RVA: 0x00002DEC File Offset: 0x00000FEC
		public static Matrix3x2 operator *(Matrix3x2 value1, float value2)
		{
			Matrix3x2 result;
			result.M11 = value1.M11 * value2;
			result.M12 = value1.M12 * value2;
			result.M21 = value1.M21 * value2;
			result.M22 = value1.M22 * value2;
			result.M31 = value1.M31 * value2;
			result.M32 = value1.M32 * value2;
			return result;
		}

		/// <summary>Возвращает значение, указывающее на равенство заданных матриц.</summary>
		/// <param name="value1">Первая матрица для сравнения.</param>
		/// <param name="value2">Вторая матрица для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value1" /> и <paramref name="value2" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000029 RID: 41 RVA: 0x00002E54 File Offset: 0x00001054
		public static bool operator ==(Matrix3x2 value1, Matrix3x2 value2)
		{
			return value1.M11 == value2.M11 && value1.M22 == value2.M22 && value1.M12 == value2.M12 && value1.M21 == value2.M21 && value1.M31 == value2.M31 && value1.M32 == value2.M32;
		}

		/// <summary>Возвращает значение, указывающее на неравенство заданных матриц.</summary>
		/// <param name="value1">Первая матрица для сравнения.</param>
		/// <param name="value2">Вторая матрица для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value1" /> и <paramref name="value2" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600002A RID: 42 RVA: 0x00002EB8 File Offset: 0x000010B8
		public static bool operator !=(Matrix3x2 value1, Matrix3x2 value2)
		{
			return value1.M11 != value2.M11 || value1.M12 != value2.M12 || value1.M21 != value2.M21 || value1.M22 != value2.M22 || value1.M31 != value2.M31 || value1.M32 != value2.M32;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр другой матрице 3х2.</summary>
		/// <param name="other">Другая матрица.</param>
		/// <returns>Значение <see langword="true" />, если две матрицы равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600002B RID: 43 RVA: 0x00002F20 File Offset: 0x00001120
		public bool Equals(Matrix3x2 other)
		{
			return this.M11 == other.M11 && this.M22 == other.M22 && this.M12 == other.M12 && this.M21 == other.M21 && this.M31 == other.M31 && this.M32 == other.M32;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />. Если значением параметра <paramref name="obj" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		// Token: 0x0600002C RID: 44 RVA: 0x00002F83 File Offset: 0x00001183
		public override bool Equals(object obj)
		{
			return obj is Matrix3x2 && this.Equals((Matrix3x2)obj);
		}

		/// <summary>Возвращает строку, представляющую данную матрицу.</summary>
		/// <returns>Строковое представление данной матрицы.</returns>
		// Token: 0x0600002D RID: 45 RVA: 0x00002F9C File Offset: 0x0000119C
		public override string ToString()
		{
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			return string.Format(currentCulture, "{{ {{M11:{0} M12:{1}}} {{M21:{2} M22:{3}}} {{M31:{4} M32:{5}}} }}", new object[]
			{
				this.M11.ToString(currentCulture),
				this.M12.ToString(currentCulture),
				this.M21.ToString(currentCulture),
				this.M22.ToString(currentCulture),
				this.M31.ToString(currentCulture),
				this.M32.ToString(currentCulture)
			});
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код.</returns>
		// Token: 0x0600002E RID: 46 RVA: 0x0000301C File Offset: 0x0000121C
		public override int GetHashCode()
		{
			return this.M11.GetHashCode() + this.M12.GetHashCode() + this.M21.GetHashCode() + this.M22.GetHashCode() + this.M31.GetHashCode() + this.M32.GetHashCode();
		}

		/// <summary>Первый элемент первой строки.</summary>
		// Token: 0x0400003E RID: 62
		public float M11;

		/// <summary>Второй элемент первой строки.</summary>
		// Token: 0x0400003F RID: 63
		public float M12;

		/// <summary>Первый элемент второй строки.</summary>
		// Token: 0x04000040 RID: 64
		public float M21;

		/// <summary>Второй элемент второй строки.</summary>
		// Token: 0x04000041 RID: 65
		public float M22;

		/// <summary>Первый элемент третьей строки.</summary>
		// Token: 0x04000042 RID: 66
		public float M31;

		/// <summary>Второй элемент третьей строки.</summary>
		// Token: 0x04000043 RID: 67
		public float M32;

		// Token: 0x04000044 RID: 68
		private static readonly Matrix3x2 _identity = new Matrix3x2(1f, 0f, 0f, 1f, 0f, 0f);
	}
}
