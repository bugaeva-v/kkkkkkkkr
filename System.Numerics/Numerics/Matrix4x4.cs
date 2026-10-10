using System;
using System.Globalization;

namespace System.Numerics
{
	/// <summary>Представляет матрицу 4x4.</summary>
	// Token: 0x02000005 RID: 5
	public struct Matrix4x4 : IEquatable<Matrix4x4>
	{
		/// <summary>Получает матрицу мультипликативного тождества.</summary>
		/// <returns>Получает матрицу мультипликативного тождества.</returns>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000309A File Offset: 0x0000129A
		public static Matrix4x4 Identity
		{
			get
			{
				return Matrix4x4._identity;
			}
		}

		/// <summary>Указывает, является ли текущая матрица единичной матрицей.</summary>
		/// <returns>Значение <see langword="true" />, если текущая матрица — единичная матрица; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000030A4 File Offset: 0x000012A4
		public bool IsIdentity
		{
			get
			{
				return this.M11 == 1f && this.M22 == 1f && this.M33 == 1f && this.M44 == 1f && this.M12 == 0f && this.M13 == 0f && this.M14 == 0f && this.M21 == 0f && this.M23 == 0f && this.M24 == 0f && this.M31 == 0f && this.M32 == 0f && this.M34 == 0f && this.M41 == 0f && this.M42 == 0f && this.M43 == 0f;
			}
		}

		/// <summary>Получает или задает координату трансляции данной матрицы.</summary>
		/// <returns>Координата трансляции текущего экземпляра.</returns>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003195 File Offset: 0x00001395
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000031AE File Offset: 0x000013AE
		public Vector3 Translation
		{
			get
			{
				return new Vector3(this.M41, this.M42, this.M43);
			}
			set
			{
				this.M41 = value.X;
				this.M42 = value.Y;
				this.M43 = value.Z;
			}
		}

		/// <summary>Создает матрицу 4x4 на основе заданных координат.</summary>
		/// <param name="m11">Значение, которое присваивается первому элементу в первой строке.</param>
		/// <param name="m12">Значение, которое присваивается второму элементу в первой строке.</param>
		/// <param name="m13">Значение, которое присваивается третьему элементу в первой строке.</param>
		/// <param name="m14">Значение, которое присваивается четвертому элементу в первой строке.</param>
		/// <param name="m21">Значение, которое присваивается первому элементу во второй строке.</param>
		/// <param name="m22">Значение, которое присваивается второму элементу во второй строке.</param>
		/// <param name="m23">Значение, которое присваивается третьему элементу во второй строке.</param>
		/// <param name="m24">Значение, которое присваивается третьему элементу во второй строке.</param>
		/// <param name="m31">Значение, которое присваивается первому элементу в третьей строке.</param>
		/// <param name="m32">Значение, которое присваивается второму элементу в третьей строке.</param>
		/// <param name="m33">Значение, которое присваивается третьему элементу в третьей строке.</param>
		/// <param name="m34">Значение, которое присваивается четвертому элементу в третьей строке.</param>
		/// <param name="m41">Значение, которое присваивается первому элементу в четвертой строке.</param>
		/// <param name="m42">Значение, которое присваивается второму элементу в четвертой строке.</param>
		/// <param name="m43">Значение, которое присваивается третьему элементу в четвертой строке.</param>
		/// <param name="m44">Значение, которое присваивается четвертому элементу в четвертой строке.</param>
		// Token: 0x06000034 RID: 52 RVA: 0x000031D4 File Offset: 0x000013D4
		public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
		{
			this.M11 = m11;
			this.M12 = m12;
			this.M13 = m13;
			this.M14 = m14;
			this.M21 = m21;
			this.M22 = m22;
			this.M23 = m23;
			this.M24 = m24;
			this.M31 = m31;
			this.M32 = m32;
			this.M33 = m33;
			this.M34 = m34;
			this.M41 = m41;
			this.M42 = m42;
			this.M43 = m43;
			this.M44 = m44;
		}

		/// <summary>Создает объект <see cref="T:System.Numerics.Matrix4x4" /> из указанного объекта <see cref="T:System.Numerics.Matrix3x2" />.</summary>
		/// <param name="value">Матрица 3x2.</param>
		// Token: 0x06000035 RID: 53 RVA: 0x00003260 File Offset: 0x00001460
		public Matrix4x4(Matrix3x2 value)
		{
			this.M11 = value.M11;
			this.M12 = value.M12;
			this.M13 = 0f;
			this.M14 = 0f;
			this.M21 = value.M21;
			this.M22 = value.M22;
			this.M23 = 0f;
			this.M24 = 0f;
			this.M31 = 0f;
			this.M32 = 0f;
			this.M33 = 1f;
			this.M34 = 0f;
			this.M41 = value.M31;
			this.M42 = value.M32;
			this.M43 = 0f;
			this.M44 = 1f;
		}

		/// <summary>Создает сферический элемент с объявлением, который вращается вокруг заданной позиции объекта.</summary>
		/// <param name="objectPosition">Позиция объекта, вокруг которой будет вращаться элемент с объявлением.</param>
		/// <param name="cameraPosition">Положение камеры.</param>
		/// <param name="cameraUpVector">Вектор перемещения камеры вверх.</param>
		/// <param name="cameraForwardVector">Вектор перемещения камеры вперед.</param>
		/// <returns>Созданный элемент с объявлением.</returns>
		// Token: 0x06000036 RID: 54 RVA: 0x00003324 File Offset: 0x00001524
		public static Matrix4x4 CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3 cameraForwardVector)
		{
			Vector3 vector = new Vector3(objectPosition.X - cameraPosition.X, objectPosition.Y - cameraPosition.Y, objectPosition.Z - cameraPosition.Z);
			float num = vector.LengthSquared();
			if (num < 0.0001f)
			{
				vector = -cameraForwardVector;
			}
			else
			{
				vector = Vector3.Multiply(vector, 1f / MathF.Sqrt(num));
			}
			Vector3 vector2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector));
			Vector3 vector3 = Vector3.Cross(vector, vector2);
			Matrix4x4 result;
			result.M11 = vector2.X;
			result.M12 = vector2.Y;
			result.M13 = vector2.Z;
			result.M14 = 0f;
			result.M21 = vector3.X;
			result.M22 = vector3.Y;
			result.M23 = vector3.Z;
			result.M24 = 0f;
			result.M31 = vector.X;
			result.M32 = vector.Y;
			result.M33 = vector.Z;
			result.M34 = 0f;
			result.M41 = objectPosition.X;
			result.M42 = objectPosition.Y;
			result.M43 = objectPosition.Z;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает цилиндрический элемент с объявлением, который вращается вокруг заданной оси.</summary>
		/// <param name="objectPosition">Позиция объекта, вокруг которой будет вращаться элемент с объявлением.</param>
		/// <param name="cameraPosition">Положение камеры.</param>
		/// <param name="rotateAxis">Ось, вокруг которой будет вращаться элемент с объявлением.</param>
		/// <param name="cameraForwardVector">Вектор перемещения камеры вперед.</param>
		/// <param name="objectForwardVector">Вектор перемещения объекта вперед.</param>
		/// <returns>Матрица элемента с объявлением.</returns>
		// Token: 0x06000037 RID: 55 RVA: 0x00003470 File Offset: 0x00001670
		public static Matrix4x4 CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3 cameraForwardVector, Vector3 objectForwardVector)
		{
			Vector3 vector = new Vector3(objectPosition.X - cameraPosition.X, objectPosition.Y - cameraPosition.Y, objectPosition.Z - cameraPosition.Z);
			float num = vector.LengthSquared();
			if (num < 0.0001f)
			{
				vector = -cameraForwardVector;
			}
			else
			{
				vector = Vector3.Multiply(vector, 1f / MathF.Sqrt(num));
			}
			Vector3 vector2;
			Vector3 vector3;
			if (MathF.Abs(Vector3.Dot(rotateAxis, vector)) > 0.99825466f)
			{
				vector2 = objectForwardVector;
				if (MathF.Abs(Vector3.Dot(rotateAxis, vector2)) > 0.99825466f)
				{
					vector2 = ((MathF.Abs(rotateAxis.Z) > 0.99825466f) ? new Vector3(1f, 0f, 0f) : new Vector3(0f, 0f, -1f));
				}
				vector3 = Vector3.Normalize(Vector3.Cross(rotateAxis, vector2));
				vector2 = Vector3.Normalize(Vector3.Cross(vector3, rotateAxis));
			}
			else
			{
				vector3 = Vector3.Normalize(Vector3.Cross(rotateAxis, vector));
				vector2 = Vector3.Normalize(Vector3.Cross(vector3, rotateAxis));
			}
			Matrix4x4 result;
			result.M11 = vector3.X;
			result.M12 = vector3.Y;
			result.M13 = vector3.Z;
			result.M14 = 0f;
			result.M21 = rotateAxis.X;
			result.M22 = rotateAxis.Y;
			result.M23 = rotateAxis.Z;
			result.M24 = 0f;
			result.M31 = vector2.X;
			result.M32 = vector2.Y;
			result.M33 = vector2.Z;
			result.M34 = 0f;
			result.M41 = objectPosition.X;
			result.M42 = objectPosition.Y;
			result.M43 = objectPosition.Z;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу трансляции на основе заданного трехмерного вектора.</summary>
		/// <param name="position">Значение трансляции по каждой оси.</param>
		/// <returns>Матрица трансляции.</returns>
		// Token: 0x06000038 RID: 56 RVA: 0x0000364C File Offset: 0x0000184C
		public static Matrix4x4 CreateTranslation(Vector3 position)
		{
			Matrix4x4 result;
			result.M11 = 1f;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = 1f;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = 1f;
			result.M34 = 0f;
			result.M41 = position.X;
			result.M42 = position.Y;
			result.M43 = position.Z;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу трансляции на основе заданных координат X, Y и Z.</summary>
		/// <param name="xPosition">Значение трансляции по оси X.</param>
		/// <param name="yPosition">Значение трансляции по оси Y.</param>
		/// <param name="zPosition">Значение трансляции по оси Z.</param>
		/// <returns>Матрица трансляции.</returns>
		// Token: 0x06000039 RID: 57 RVA: 0x00003720 File Offset: 0x00001920
		public static Matrix4x4 CreateTranslation(float xPosition, float yPosition, float zPosition)
		{
			Matrix4x4 result;
			result.M11 = 1f;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = 1f;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = 1f;
			result.M34 = 0f;
			result.M41 = xPosition;
			result.M42 = yPosition;
			result.M43 = zPosition;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу масштабирования на основе заданных координат X, Y и Z.</summary>
		/// <param name="xScale">Значение для масштабирования по оси X.</param>
		/// <param name="yScale">Значение для масштабирования по оси Y.</param>
		/// <param name="zScale">Значение для масштабирования по оси Z.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x0600003A RID: 58 RVA: 0x000037E4 File Offset: 0x000019E4
		public static Matrix4x4 CreateScale(float xScale, float yScale, float zScale)
		{
			Matrix4x4 result;
			result.M11 = xScale;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = yScale;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = zScale;
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = 0f;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу масштабирования со смещением на заданную центральную точку.</summary>
		/// <param name="xScale">Значение для масштабирования по оси X.</param>
		/// <param name="yScale">Значение для масштабирования по оси Y.</param>
		/// <param name="zScale">Значение для масштабирования по оси Z.</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x0600003B RID: 59 RVA: 0x000038A8 File Offset: 0x00001AA8
		public static Matrix4x4 CreateScale(float xScale, float yScale, float zScale, Vector3 centerPoint)
		{
			float m = centerPoint.X * (1f - xScale);
			float m2 = centerPoint.Y * (1f - yScale);
			float m3 = centerPoint.Z * (1f - zScale);
			Matrix4x4 result;
			result.M11 = xScale;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = yScale;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = zScale;
			result.M34 = 0f;
			result.M41 = m;
			result.M42 = m2;
			result.M43 = m3;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу масштабирования на основе заданного масштаба вектора.</summary>
		/// <param name="scales">Используемый масштаб.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x0600003C RID: 60 RVA: 0x0000398C File Offset: 0x00001B8C
		public static Matrix4x4 CreateScale(Vector3 scales)
		{
			Matrix4x4 result;
			result.M11 = scales.X;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = scales.Y;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = scales.Z;
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = 0f;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу масштабирования с центральной точкой.</summary>
		/// <param name="scales">Вектор, который содержит значение масштабирования по каждой оси.</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x0600003D RID: 61 RVA: 0x00003A60 File Offset: 0x00001C60
		public static Matrix4x4 CreateScale(Vector3 scales, Vector3 centerPoint)
		{
			float m = centerPoint.X * (1f - scales.X);
			float m2 = centerPoint.Y * (1f - scales.Y);
			float m3 = centerPoint.Z * (1f - scales.Z);
			Matrix4x4 result;
			result.M11 = scales.X;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = scales.Y;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = scales.Z;
			result.M34 = 0f;
			result.M41 = m;
			result.M42 = m2;
			result.M43 = m3;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу равномерного масштабирования, выполняющую равномерное масштабирование по каждой оси.</summary>
		/// <param name="scale">Коэффициент равномерного масштабирования.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x0600003E RID: 62 RVA: 0x00003B64 File Offset: 0x00001D64
		public static Matrix4x4 CreateScale(float scale)
		{
			Matrix4x4 result;
			result.M11 = scale;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = scale;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = scale;
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = 0f;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу равномерного масштабирования, выполняющую равномерное масштабирование по каждой оси, с центральной точкой.</summary>
		/// <param name="scale">Коэффициент равномерного масштабирования.</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица масштабирования.</returns>
		// Token: 0x0600003F RID: 63 RVA: 0x00003C28 File Offset: 0x00001E28
		public static Matrix4x4 CreateScale(float scale, Vector3 centerPoint)
		{
			float m = centerPoint.X * (1f - scale);
			float m2 = centerPoint.Y * (1f - scale);
			float m3 = centerPoint.Z * (1f - scale);
			Matrix4x4 result;
			result.M11 = scale;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = scale;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = scale;
			result.M34 = 0f;
			result.M41 = m;
			result.M42 = m2;
			result.M43 = m3;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу для поворота точек вокруг оси X.</summary>
		/// <param name="radians">Значение поворота вокруг оси X (в радианах).</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x06000040 RID: 64 RVA: 0x00003D0C File Offset: 0x00001F0C
		public static Matrix4x4 CreateRotationX(float radians)
		{
			float num = MathF.Cos(radians);
			float num2 = MathF.Sin(radians);
			Matrix4x4 result;
			result.M11 = 1f;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = num;
			result.M23 = num2;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = -num2;
			result.M33 = num;
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = 0f;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу для поворота точек вокруг оси X относительно центральной точки.</summary>
		/// <param name="radians">Значение поворота вокруг оси X (в радианах).</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x06000041 RID: 65 RVA: 0x00003DDC File Offset: 0x00001FDC
		public static Matrix4x4 CreateRotationX(float radians, Vector3 centerPoint)
		{
			float num = MathF.Cos(radians);
			float num2 = MathF.Sin(radians);
			float m = centerPoint.Y * (1f - num) + centerPoint.Z * num2;
			float m2 = centerPoint.Z * (1f - num) - centerPoint.Y * num2;
			Matrix4x4 result;
			result.M11 = 1f;
			result.M12 = 0f;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = num;
			result.M23 = num2;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = -num2;
			result.M33 = num;
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = m;
			result.M43 = m2;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу для поворота точек вокруг оси Y.</summary>
		/// <param name="radians">Значение поворота вокруг оси Y (в радианах).</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x06000042 RID: 66 RVA: 0x00003ED4 File Offset: 0x000020D4
		public static Matrix4x4 CreateRotationY(float radians)
		{
			float num = MathF.Cos(radians);
			float num2 = MathF.Sin(radians);
			Matrix4x4 result;
			result.M11 = num;
			result.M12 = 0f;
			result.M13 = -num2;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = 1f;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = num2;
			result.M32 = 0f;
			result.M33 = num;
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = 0f;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Значение поворота вокруг оси Y относительно центральной точки (в радианах).</summary>
		/// <param name="radians">Значение поворота вокруг оси Y (в радианах).</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x06000043 RID: 67 RVA: 0x00003FA4 File Offset: 0x000021A4
		public static Matrix4x4 CreateRotationY(float radians, Vector3 centerPoint)
		{
			float num = MathF.Cos(radians);
			float num2 = MathF.Sin(radians);
			float m = centerPoint.X * (1f - num) - centerPoint.Z * num2;
			float m2 = centerPoint.Z * (1f - num) + centerPoint.X * num2;
			Matrix4x4 result;
			result.M11 = num;
			result.M12 = 0f;
			result.M13 = -num2;
			result.M14 = 0f;
			result.M21 = 0f;
			result.M22 = 1f;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = num2;
			result.M32 = 0f;
			result.M33 = num;
			result.M34 = 0f;
			result.M41 = m;
			result.M42 = 0f;
			result.M43 = m2;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу для поворота точек вокруг оси Z.</summary>
		/// <param name="radians">Значение поворота вокруг оси Z (в радианах).</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x06000044 RID: 68 RVA: 0x0000409C File Offset: 0x0000229C
		public static Matrix4x4 CreateRotationZ(float radians)
		{
			float num = MathF.Cos(radians);
			float num2 = MathF.Sin(radians);
			Matrix4x4 result;
			result.M11 = num;
			result.M12 = num2;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = -num2;
			result.M22 = num;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = 1f;
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = 0f;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу для поворота точек вокруг оси Z относительно центральной точки.</summary>
		/// <param name="radians">Значение поворота вокруг оси Z (в радианах).</param>
		/// <param name="centerPoint">Центральная точка.</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x06000045 RID: 69 RVA: 0x0000416C File Offset: 0x0000236C
		public static Matrix4x4 CreateRotationZ(float radians, Vector3 centerPoint)
		{
			float num = MathF.Cos(radians);
			float num2 = MathF.Sin(radians);
			float m = centerPoint.X * (1f - num) + centerPoint.Y * num2;
			float m2 = centerPoint.Y * (1f - num) - centerPoint.X * num2;
			Matrix4x4 result;
			result.M11 = num;
			result.M12 = num2;
			result.M13 = 0f;
			result.M14 = 0f;
			result.M21 = -num2;
			result.M22 = num;
			result.M23 = 0f;
			result.M24 = 0f;
			result.M31 = 0f;
			result.M32 = 0f;
			result.M33 = 1f;
			result.M34 = 0f;
			result.M41 = m;
			result.M42 = m2;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу, которая вращается вокруг произвольного вектора.</summary>
		/// <param name="axis">Ось вращения.</param>
		/// <param name="angle">Угол поворота вокруг <paramref name="axis" /> (в радианах).</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x06000046 RID: 70 RVA: 0x00004264 File Offset: 0x00002464
		public static Matrix4x4 CreateFromAxisAngle(Vector3 axis, float angle)
		{
			float x = axis.X;
			float y = axis.Y;
			float z = axis.Z;
			float num = MathF.Sin(angle);
			float num2 = MathF.Cos(angle);
			float num3 = x * x;
			float num4 = y * y;
			float num5 = z * z;
			float num6 = x * y;
			float num7 = x * z;
			float num8 = y * z;
			Matrix4x4 result;
			result.M11 = num3 + num2 * (1f - num3);
			result.M12 = num6 - num2 * num6 + num * z;
			result.M13 = num7 - num2 * num7 - num * y;
			result.M14 = 0f;
			result.M21 = num6 - num2 * num6 - num * z;
			result.M22 = num4 + num2 * (1f - num4);
			result.M23 = num8 - num2 * num8 + num * x;
			result.M24 = 0f;
			result.M31 = num7 - num2 * num7 + num * y;
			result.M32 = num8 - num2 * num8 - num * x;
			result.M33 = num5 + num2 * (1f - num5);
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = 0f;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу перспективы на основе поля зрения, пропорций и расстояния до ближней и дальней плоскости просмотра.</summary>
		/// <param name="fieldOfView">Поле зрения в направлении Y в радианах.</param>
		/// <param name="aspectRatio">Пропорции, определенные как ширина зрительного пространства, деленная на высоту.</param>
		/// <param name="nearPlaneDistance">Расстояние до ближней плоскости просмотра.</param>
		/// <param name="farPlaneDistance">Расстояние до дальней плоскости просмотра.</param>
		/// <returns>Матрица перспективы.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="fieldOfView" /> меньше или равно нулю.  
		/// -или- 
		///  Значение <paramref name="fieldOfView" /> больше или равно <see cref="F:System.Math.PI" />.  
		///  Значение <paramref name="nearPlaneDistance" /> меньше или равно нулю.  
		/// -или- 
		///  Значение <paramref name="farPlaneDistance" /> меньше или равно нулю.  
		/// -или- 
		///  Значение <paramref name="nearPlaneDistance" /> больше или равно <paramref name="farPlaneDistance" />.</exception>
		// Token: 0x06000047 RID: 71 RVA: 0x000043BC File Offset: 0x000025BC
		public static Matrix4x4 CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
		{
			if (fieldOfView <= 0f || fieldOfView >= 3.1415927f)
			{
				throw new ArgumentOutOfRangeException("fieldOfView");
			}
			if (nearPlaneDistance <= 0f)
			{
				throw new ArgumentOutOfRangeException("nearPlaneDistance");
			}
			if (farPlaneDistance <= 0f)
			{
				throw new ArgumentOutOfRangeException("farPlaneDistance");
			}
			if (nearPlaneDistance >= farPlaneDistance)
			{
				throw new ArgumentOutOfRangeException("nearPlaneDistance");
			}
			float num = 1f / MathF.Tan(fieldOfView * 0.5f);
			float m = num / aspectRatio;
			Matrix4x4 result;
			result.M11 = m;
			result.M12 = (result.M13 = (result.M14 = 0f));
			result.M22 = num;
			result.M21 = (result.M23 = (result.M24 = 0f));
			result.M31 = (result.M32 = 0f);
			float num2 = float.IsPositiveInfinity(farPlaneDistance) ? -1f : (farPlaneDistance / (nearPlaneDistance - farPlaneDistance));
			result.M33 = num2;
			result.M34 = -1f;
			result.M41 = (result.M42 = (result.M44 = 0f));
			result.M43 = nearPlaneDistance * num2;
			return result;
		}

		/// <summary>Создает матрицу перспективы на основе данных размеров отображаемого объема.</summary>
		/// <param name="width">Ширина отображаемого объема в ближней плоскости просмотра.</param>
		/// <param name="height">Высота отображаемого объема в ближней плоскости просмотра.</param>
		/// <param name="nearPlaneDistance">Расстояние до ближней плоскости просмотра.</param>
		/// <param name="farPlaneDistance">Расстояние до дальней плоскости просмотра.</param>
		/// <returns>Матрица перспективы.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="nearPlaneDistance" /> меньше или равно нулю.  
		/// -или- 
		///  Значение <paramref name="farPlaneDistance" /> меньше или равно нулю.  
		/// -или- 
		///  Значение <paramref name="nearPlaneDistance" /> больше или равно <paramref name="farPlaneDistance" />.</exception>
		// Token: 0x06000048 RID: 72 RVA: 0x000044F8 File Offset: 0x000026F8
		public static Matrix4x4 CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)
		{
			if (nearPlaneDistance <= 0f)
			{
				throw new ArgumentOutOfRangeException("nearPlaneDistance");
			}
			if (farPlaneDistance <= 0f)
			{
				throw new ArgumentOutOfRangeException("farPlaneDistance");
			}
			if (nearPlaneDistance >= farPlaneDistance)
			{
				throw new ArgumentOutOfRangeException("nearPlaneDistance");
			}
			Matrix4x4 result;
			result.M11 = 2f * nearPlaneDistance / width;
			result.M12 = (result.M13 = (result.M14 = 0f));
			result.M22 = 2f * nearPlaneDistance / height;
			result.M21 = (result.M23 = (result.M24 = 0f));
			float num = float.IsPositiveInfinity(farPlaneDistance) ? -1f : (farPlaneDistance / (nearPlaneDistance - farPlaneDistance));
			result.M33 = num;
			result.M31 = (result.M32 = 0f);
			result.M34 = -1f;
			result.M41 = (result.M42 = (result.M44 = 0f));
			result.M43 = nearPlaneDistance * num;
			return result;
		}

		/// <summary>Создает настраиваемую матрицу перспективы.</summary>
		/// <param name="left">Минимальное значение по оси X отображаемого объема в ближней плоскости просмотра.</param>
		/// <param name="right">Максимальное значение по оси X отображаемого объема в ближней плоскости просмотра.</param>
		/// <param name="bottom">Минимальное значение по оси Y отображаемого объема в ближней плоскости просмотра.</param>
		/// <param name="top">Максимальное значение по оси Y отображаемого объема в ближней плоскости просмотра.</param>
		/// <param name="nearPlaneDistance">Расстояние до ближней плоскости просмотра.</param>
		/// <param name="farPlaneDistance">Расстояние до дальней плоскости просмотра.</param>
		/// <returns>Матрица перспективы.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="nearPlaneDistance" /> меньше или равно нулю.  
		/// -или- 
		///  Значение <paramref name="farPlaneDistance" /> меньше или равно нулю.  
		/// -или- 
		///  Значение <paramref name="nearPlaneDistance" /> больше или равно <paramref name="farPlaneDistance" />.</exception>
		// Token: 0x06000049 RID: 73 RVA: 0x00004604 File Offset: 0x00002804
		public static Matrix4x4 CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)
		{
			if (nearPlaneDistance <= 0f)
			{
				throw new ArgumentOutOfRangeException("nearPlaneDistance");
			}
			if (farPlaneDistance <= 0f)
			{
				throw new ArgumentOutOfRangeException("farPlaneDistance");
			}
			if (nearPlaneDistance >= farPlaneDistance)
			{
				throw new ArgumentOutOfRangeException("nearPlaneDistance");
			}
			Matrix4x4 result;
			result.M11 = 2f * nearPlaneDistance / (right - left);
			result.M12 = (result.M13 = (result.M14 = 0f));
			result.M22 = 2f * nearPlaneDistance / (top - bottom);
			result.M21 = (result.M23 = (result.M24 = 0f));
			result.M31 = (left + right) / (right - left);
			result.M32 = (top + bottom) / (top - bottom);
			float num = float.IsPositiveInfinity(farPlaneDistance) ? -1f : (farPlaneDistance / (nearPlaneDistance - farPlaneDistance));
			result.M33 = num;
			result.M34 = -1f;
			result.M43 = nearPlaneDistance * num;
			result.M41 = (result.M42 = (result.M44 = 0f));
			return result;
		}

		/// <summary>Создает матрицу ортогональной перспективы на основе данных размеров отображаемого объема.</summary>
		/// <param name="width">Ширина отображаемого объема.</param>
		/// <param name="height">Высота отображаемого объема.</param>
		/// <param name="zNearPlane">Минимальное значение по оси Z отображаемого объема.</param>
		/// <param name="zFarPlane">Максимальное значение по оси Z отображаемого объема.</param>
		/// <returns>Матрица ортогональной проекции.</returns>
		// Token: 0x0600004A RID: 74 RVA: 0x00004728 File Offset: 0x00002928
		public static Matrix4x4 CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
		{
			Matrix4x4 result;
			result.M11 = 2f / width;
			result.M12 = (result.M13 = (result.M14 = 0f));
			result.M22 = 2f / height;
			result.M21 = (result.M23 = (result.M24 = 0f));
			result.M33 = 1f / (zNearPlane - zFarPlane);
			result.M31 = (result.M32 = (result.M34 = 0f));
			result.M41 = (result.M42 = 0f);
			result.M43 = zNearPlane / (zNearPlane - zFarPlane);
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает настраиваемую матрицу ортогональной проекции.</summary>
		/// <param name="left">Минимальное значение по оси X отображаемого объема.</param>
		/// <param name="right">Максимальное значение по оси X отображаемого объема.</param>
		/// <param name="bottom">Минимальное значение по оси Y отображаемого объема.</param>
		/// <param name="top">Максимальное значение по оси Y отображаемого объема.</param>
		/// <param name="zNearPlane">Минимальное значение по оси Z отображаемого объема.</param>
		/// <param name="zFarPlane">Максимальное значение по оси Z отображаемого объема.</param>
		/// <returns>Матрица ортогональной проекции.</returns>
		// Token: 0x0600004B RID: 75 RVA: 0x000047F0 File Offset: 0x000029F0
		public static Matrix4x4 CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
		{
			Matrix4x4 result;
			result.M11 = 2f / (right - left);
			result.M12 = (result.M13 = (result.M14 = 0f));
			result.M22 = 2f / (top - bottom);
			result.M21 = (result.M23 = (result.M24 = 0f));
			result.M33 = 1f / (zNearPlane - zFarPlane);
			result.M31 = (result.M32 = (result.M34 = 0f));
			result.M41 = (left + right) / (left - right);
			result.M42 = (top + bottom) / (bottom - top);
			result.M43 = zNearPlane / (zNearPlane - zFarPlane);
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу просмотра.</summary>
		/// <param name="cameraPosition">Положение камеры.</param>
		/// <param name="cameraTarget">Целевой объект, на который указывает камера.</param>
		/// <param name="cameraUpVector">Направление "вверх" с точки зрения камеры.</param>
		/// <returns>Матрица просмотра.</returns>
		// Token: 0x0600004C RID: 76 RVA: 0x000048C8 File Offset: 0x00002AC8
		public static Matrix4x4 CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
		{
			Vector3 vector = Vector3.Normalize(cameraPosition - cameraTarget);
			Vector3 vector2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector));
			Vector3 vector3 = Vector3.Cross(vector, vector2);
			Matrix4x4 result;
			result.M11 = vector2.X;
			result.M12 = vector3.X;
			result.M13 = vector.X;
			result.M14 = 0f;
			result.M21 = vector2.Y;
			result.M22 = vector3.Y;
			result.M23 = vector.Y;
			result.M24 = 0f;
			result.M31 = vector2.Z;
			result.M32 = vector3.Z;
			result.M33 = vector.Z;
			result.M34 = 0f;
			result.M41 = -Vector3.Dot(vector2, cameraPosition);
			result.M42 = -Vector3.Dot(vector3, cameraPosition);
			result.M43 = -Vector3.Dot(vector, cameraPosition);
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает мировую матрицу с заданными параметрами.</summary>
		/// <param name="position">Позиция объекта.</param>
		/// <param name="forward">Направление вперед объекта.</param>
		/// <param name="up">Направление вверх объекта. Его значение обычно равно <c>[0, 1, 0]</c>.</param>
		/// <returns>Мировая матрица.</returns>
		// Token: 0x0600004D RID: 77 RVA: 0x000049CC File Offset: 0x00002BCC
		public static Matrix4x4 CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
		{
			Vector3 vector = Vector3.Normalize(-forward);
			Vector3 vector2 = Vector3.Normalize(Vector3.Cross(up, vector));
			Vector3 vector3 = Vector3.Cross(vector, vector2);
			Matrix4x4 result;
			result.M11 = vector2.X;
			result.M12 = vector2.Y;
			result.M13 = vector2.Z;
			result.M14 = 0f;
			result.M21 = vector3.X;
			result.M22 = vector3.Y;
			result.M23 = vector3.Z;
			result.M24 = 0f;
			result.M31 = vector.X;
			result.M32 = vector.Y;
			result.M33 = vector.Z;
			result.M34 = 0f;
			result.M41 = position.X;
			result.M42 = position.Y;
			result.M43 = position.Z;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу поворота на основе заданного значения поворота кватерниона.</summary>
		/// <param name="quaternion">Исходный кватернион.</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x0600004E RID: 78 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public static Matrix4x4 CreateFromQuaternion(Quaternion quaternion)
		{
			float num = quaternion.X * quaternion.X;
			float num2 = quaternion.Y * quaternion.Y;
			float num3 = quaternion.Z * quaternion.Z;
			float num4 = quaternion.X * quaternion.Y;
			float num5 = quaternion.Z * quaternion.W;
			float num6 = quaternion.Z * quaternion.X;
			float num7 = quaternion.Y * quaternion.W;
			float num8 = quaternion.Y * quaternion.Z;
			float num9 = quaternion.X * quaternion.W;
			Matrix4x4 result;
			result.M11 = 1f - 2f * (num2 + num3);
			result.M12 = 2f * (num4 + num5);
			result.M13 = 2f * (num6 - num7);
			result.M14 = 0f;
			result.M21 = 2f * (num4 - num5);
			result.M22 = 1f - 2f * (num3 + num);
			result.M23 = 2f * (num8 + num9);
			result.M24 = 0f;
			result.M31 = 2f * (num6 + num7);
			result.M32 = 2f * (num8 - num9);
			result.M33 = 1f - 2f * (num2 + num);
			result.M34 = 0f;
			result.M41 = 0f;
			result.M42 = 0f;
			result.M43 = 0f;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Создает матрицу поворота на основе заданного значения нутации, прецессии и собственного вращения.</summary>
		/// <param name="yaw">Угол поворота вокруг оси Y (в радианах).</param>
		/// <param name="pitch">Угол поворота вокруг оси X (в радианах).</param>
		/// <param name="roll">Угол поворота вокруг оси Z (в радианах).</param>
		/// <returns>Матрица поворота.</returns>
		// Token: 0x0600004F RID: 79 RVA: 0x00004C5C File Offset: 0x00002E5C
		public static Matrix4x4 CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			return Matrix4x4.CreateFromQuaternion(Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll));
		}

		/// <summary>Создает матрицу, которая создает проекцию геометрической фигуры на указанной плоскости подобно отбрасыванию тени от указанного источника света.</summary>
		/// <param name="lightDirection">Направление, из которого поступает свет, отбрасывающий тень.</param>
		/// <param name="plane">Плоскость, на которой новая матрица должна создать проекцию геометрической фигуры, подобную отбрасыванию тени.</param>
		/// <returns>Новая матрица, которую можно использовать для создания проекции геометрической фигуры на указанной плоскости из заданного направления.</returns>
		// Token: 0x06000050 RID: 80 RVA: 0x00004C6C File Offset: 0x00002E6C
		public static Matrix4x4 CreateShadow(Vector3 lightDirection, Plane plane)
		{
			Plane plane2 = Plane.Normalize(plane);
			float num = plane2.Normal.X * lightDirection.X + plane2.Normal.Y * lightDirection.Y + plane2.Normal.Z * lightDirection.Z;
			float num2 = -plane2.Normal.X;
			float num3 = -plane2.Normal.Y;
			float num4 = -plane2.Normal.Z;
			float num5 = -plane2.D;
			Matrix4x4 result;
			result.M11 = num2 * lightDirection.X + num;
			result.M21 = num3 * lightDirection.X;
			result.M31 = num4 * lightDirection.X;
			result.M41 = num5 * lightDirection.X;
			result.M12 = num2 * lightDirection.Y;
			result.M22 = num3 * lightDirection.Y + num;
			result.M32 = num4 * lightDirection.Y;
			result.M42 = num5 * lightDirection.Y;
			result.M13 = num2 * lightDirection.Z;
			result.M23 = num3 * lightDirection.Z;
			result.M33 = num4 * lightDirection.Z + num;
			result.M43 = num5 * lightDirection.Z;
			result.M14 = 0f;
			result.M24 = 0f;
			result.M34 = 0f;
			result.M44 = num;
			return result;
		}

		/// <summary>Создает матрицу, отражающую систему координат для указанной плоскости.</summary>
		/// <param name="value">Плоскость, для которой будет создано отражение.</param>
		/// <returns>Новая матрица, выражающая отражение.</returns>
		// Token: 0x06000051 RID: 81 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public static Matrix4x4 CreateReflection(Plane value)
		{
			value = Plane.Normalize(value);
			float x = value.Normal.X;
			float y = value.Normal.Y;
			float z = value.Normal.Z;
			float num = -2f * x;
			float num2 = -2f * y;
			float num3 = -2f * z;
			Matrix4x4 result;
			result.M11 = num * x + 1f;
			result.M12 = num2 * x;
			result.M13 = num3 * x;
			result.M14 = 0f;
			result.M21 = num * y;
			result.M22 = num2 * y + 1f;
			result.M23 = num3 * y;
			result.M24 = 0f;
			result.M31 = num * z;
			result.M32 = num2 * z;
			result.M33 = num3 * z + 1f;
			result.M34 = 0f;
			result.M41 = num * value.D;
			result.M42 = num2 * value.D;
			result.M43 = num3 * value.D;
			result.M44 = 1f;
			return result;
		}

		/// <summary>Вычисляет определитель текущей матрицы 4x4.</summary>
		/// <returns>Определитель.</returns>
		// Token: 0x06000052 RID: 82 RVA: 0x00004F00 File Offset: 0x00003100
		public float GetDeterminant()
		{
			float m = this.M11;
			float m2 = this.M12;
			float m3 = this.M13;
			float m4 = this.M14;
			float m5 = this.M21;
			float m6 = this.M22;
			float m7 = this.M23;
			float m8 = this.M24;
			float m9 = this.M31;
			float m10 = this.M32;
			float m11 = this.M33;
			float m12 = this.M34;
			float m13 = this.M41;
			float m14 = this.M42;
			float m15 = this.M43;
			float m16 = this.M44;
			float num = m11 * m16 - m12 * m15;
			float num2 = m10 * m16 - m12 * m14;
			float num3 = m10 * m15 - m11 * m14;
			float num4 = m9 * m16 - m12 * m13;
			float num5 = m9 * m15 - m11 * m13;
			float num6 = m9 * m14 - m10 * m13;
			return m * (m6 * num - m7 * num2 + m8 * num3) - m2 * (m5 * num - m7 * num4 + m8 * num5) + m3 * (m5 * num2 - m6 * num4 + m8 * num6) - m4 * (m5 * num3 - m6 * num5 + m7 * num6);
		}

		/// <summary>Инвертирует заданную матрицу. Возвращаемое значение указывает, успешно ли выполнена операция.</summary>
		/// <param name="matrix">Инвертируемая матрица.</param>
		/// <param name="result">В качестве возвращаемого значения этот метод содержит инвертированную матрицу, если операция выполнена успешно.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="matrix" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000053 RID: 83 RVA: 0x0000501C File Offset: 0x0000321C
		public static bool Invert(Matrix4x4 matrix, out Matrix4x4 result)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float m3 = matrix.M13;
			float m4 = matrix.M14;
			float m5 = matrix.M21;
			float m6 = matrix.M22;
			float m7 = matrix.M23;
			float m8 = matrix.M24;
			float m9 = matrix.M31;
			float m10 = matrix.M32;
			float m11 = matrix.M33;
			float m12 = matrix.M34;
			float m13 = matrix.M41;
			float m14 = matrix.M42;
			float m15 = matrix.M43;
			float m16 = matrix.M44;
			float num = m11 * m16 - m12 * m15;
			float num2 = m10 * m16 - m12 * m14;
			float num3 = m10 * m15 - m11 * m14;
			float num4 = m9 * m16 - m12 * m13;
			float num5 = m9 * m15 - m11 * m13;
			float num6 = m9 * m14 - m10 * m13;
			float num7 = m6 * num - m7 * num2 + m8 * num3;
			float num8 = -(m5 * num - m7 * num4 + m8 * num5);
			float num9 = m5 * num2 - m6 * num4 + m8 * num6;
			float num10 = -(m5 * num3 - m6 * num5 + m7 * num6);
			float num11 = m * num7 + m2 * num8 + m3 * num9 + m4 * num10;
			if (MathF.Abs(num11) < 1E-45f)
			{
				result = new Matrix4x4(float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN);
				return false;
			}
			float num12 = 1f / num11;
			result.M11 = num7 * num12;
			result.M21 = num8 * num12;
			result.M31 = num9 * num12;
			result.M41 = num10 * num12;
			result.M12 = -(m2 * num - m3 * num2 + m4 * num3) * num12;
			result.M22 = (m * num - m3 * num4 + m4 * num5) * num12;
			result.M32 = -(m * num2 - m2 * num4 + m4 * num6) * num12;
			result.M42 = (m * num3 - m2 * num5 + m3 * num6) * num12;
			float num13 = m7 * m16 - m8 * m15;
			float num14 = m6 * m16 - m8 * m14;
			float num15 = m6 * m15 - m7 * m14;
			float num16 = m5 * m16 - m8 * m13;
			float num17 = m5 * m15 - m7 * m13;
			float num18 = m5 * m14 - m6 * m13;
			result.M13 = (m2 * num13 - m3 * num14 + m4 * num15) * num12;
			result.M23 = -(m * num13 - m3 * num16 + m4 * num17) * num12;
			result.M33 = (m * num14 - m2 * num16 + m4 * num18) * num12;
			result.M43 = -(m * num15 - m2 * num17 + m3 * num18) * num12;
			float num19 = m7 * m12 - m8 * m11;
			float num20 = m6 * m12 - m8 * m10;
			float num21 = m6 * m11 - m7 * m10;
			float num22 = m5 * m12 - m8 * m9;
			float num23 = m5 * m11 - m7 * m9;
			float num24 = m5 * m10 - m6 * m9;
			result.M14 = -(m2 * num19 - m3 * num20 + m4 * num21) * num12;
			result.M24 = (m * num19 - m3 * num22 + m4 * num23) * num12;
			result.M34 = -(m * num20 - m2 * num22 + m4 * num24) * num12;
			result.M44 = (m * num21 - m2 * num23 + m3 * num24) * num12;
			return true;
		}

		/// <summary>Пытается извлечь координаты масштаба, трансляции и поворота на основе данной матрицы масштабирования, поворота или трансляции. Возвращаемое значение указывает, успешно ли выполнена операция.</summary>
		/// <param name="matrix">Исходная матрица.</param>
		/// <param name="scale">В качестве возвращаемого значения этот метод содержит координату масштабирования матрицы преобразования, если операция выполнена успешно.</param>
		/// <param name="rotation">В качестве возвращаемого значения этот метод содержит координату поворота матрицы преобразования, если операция выполнена успешно.</param>
		/// <param name="translation">В качестве возвращаемого значения этот метод содержит координату трансляции матрицы трансляции, если операция выполнена успешно.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="matrix" /> успешно разложен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000054 RID: 84 RVA: 0x000053B0 File Offset: 0x000035B0
		public unsafe static bool Decompose(Matrix4x4 matrix, out Vector3 scale, out Quaternion rotation, out Vector3 translation)
		{
			bool result = true;
			fixed (Vector3* ptr = &scale)
			{
				float* ptr2 = (float*)ptr;
				Matrix4x4.VectorBasis vectorBasis;
				Vector3** ptr3 = (Vector3**)(&vectorBasis);
				Matrix4x4 identity = Matrix4x4.Identity;
				Matrix4x4.CanonicalBasis canonicalBasis = default(Matrix4x4.CanonicalBasis);
				Vector3* ptr4 = &canonicalBasis.Row0;
				canonicalBasis.Row0 = new Vector3(1f, 0f, 0f);
				canonicalBasis.Row1 = new Vector3(0f, 1f, 0f);
				canonicalBasis.Row2 = new Vector3(0f, 0f, 1f);
				translation = new Vector3(matrix.M41, matrix.M42, matrix.M43);
				*(IntPtr*)ptr3 = &identity.M11;
				*(IntPtr*)(ptr3 + sizeof(Vector3*) / sizeof(Vector3*)) = &identity.M21;
				*(IntPtr*)(ptr3 + (IntPtr)2 * (IntPtr)sizeof(Vector3*) / (IntPtr)sizeof(Vector3*)) = &identity.M31;
				*(*(IntPtr*)ptr3) = new Vector3(matrix.M11, matrix.M12, matrix.M13);
				*(*(IntPtr*)(ptr3 + sizeof(Vector3*) / sizeof(Vector3*))) = new Vector3(matrix.M21, matrix.M22, matrix.M23);
				*(*(IntPtr*)(ptr3 + (IntPtr)2 * (IntPtr)sizeof(Vector3*) / (IntPtr)sizeof(Vector3*))) = new Vector3(matrix.M31, matrix.M32, matrix.M33);
				scale.X = ((IntPtr*)ptr3)->Length();
				scale.Y = ((IntPtr*)(ptr3 + sizeof(Vector3*) / sizeof(Vector3*)))->Length();
				scale.Z = ((IntPtr*)(ptr3 + (IntPtr)2 * (IntPtr)sizeof(Vector3*) / (IntPtr)sizeof(Vector3*)))->Length();
				float num = *ptr2;
				float num2 = ptr2[1];
				float num3 = ptr2[2];
				uint num4;
				uint num5;
				uint num6;
				if (num < num2)
				{
					if (num2 < num3)
					{
						num4 = 2U;
						num5 = 1U;
						num6 = 0U;
					}
					else
					{
						num4 = 1U;
						if (num < num3)
						{
							num5 = 2U;
							num6 = 0U;
						}
						else
						{
							num5 = 0U;
							num6 = 2U;
						}
					}
				}
				else if (num < num3)
				{
					num4 = 2U;
					num5 = 0U;
					num6 = 1U;
				}
				else
				{
					num4 = 0U;
					if (num2 < num3)
					{
						num5 = 2U;
						num6 = 1U;
					}
					else
					{
						num5 = 1U;
						num6 = 2U;
					}
				}
				if (ptr2[(ulong)num4 * 4UL / 4UL] < 0.0001f)
				{
					*(*(IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = ptr4[(ulong)num4 * (ulong)((long)sizeof(Vector3)) / (ulong)sizeof(Vector3)];
				}
				*(*(IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Normalize(*(*(IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
				if (ptr2[(ulong)num5 * 4UL / 4UL] < 0.0001f)
				{
					float num7 = MathF.Abs(((IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*)))->X);
					float num8 = MathF.Abs(((IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*)))->Y);
					float num9 = MathF.Abs(((IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*)))->Z);
					uint num10;
					if (num7 < num8)
					{
						if (num8 < num9)
						{
							num10 = 0U;
						}
						else if (num7 < num9)
						{
							num10 = 0U;
						}
						else
						{
							num10 = 2U;
						}
					}
					else if (num7 < num9)
					{
						num10 = 1U;
					}
					else if (num8 < num9)
					{
						num10 = 1U;
					}
					else
					{
						num10 = 2U;
					}
					*(*(IntPtr*)(ptr3 + (ulong)num5 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Cross(*(*(IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))), ptr4[(ulong)num10 * (ulong)((long)sizeof(Vector3)) / (ulong)sizeof(Vector3)]);
				}
				*(*(IntPtr*)(ptr3 + (ulong)num5 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Normalize(*(*(IntPtr*)(ptr3 + (ulong)num5 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
				if (ptr2[(ulong)num6 * 4UL / 4UL] < 0.0001f)
				{
					*(*(IntPtr*)(ptr3 + (ulong)num6 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Cross(*(*(IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))), *(*(IntPtr*)(ptr3 + (ulong)num5 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
				}
				*(*(IntPtr*)(ptr3 + (ulong)num6 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Normalize(*(*(IntPtr*)(ptr3 + (ulong)num6 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
				float num11 = identity.GetDeterminant();
				if (num11 < 0f)
				{
					ptr2[(ulong)num4 * 4UL / 4UL] = -ptr2[(ulong)num4 * 4UL / 4UL];
					*(*(IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = -(*(*(IntPtr*)(ptr3 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
					num11 = -num11;
				}
				num11 -= 1f;
				num11 *= num11;
				if (0.0001f < num11)
				{
					rotation = Quaternion.Identity;
					result = false;
				}
				else
				{
					rotation = Quaternion.CreateFromRotationMatrix(identity);
				}
			}
			return result;
		}

		/// <summary>Преобразует заданную матрицу, применяя указанный поворот кватерниона.</summary>
		/// <param name="value">Преобразуемая матрица.</param>
		/// <param name="rotation">Применяемый поворот.</param>
		/// <returns>Преобразованная матрица.</returns>
		// Token: 0x06000055 RID: 85 RVA: 0x00005824 File Offset: 0x00003A24
		public static Matrix4x4 Transform(Matrix4x4 value, Quaternion rotation)
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
			float num13 = 1f - num10 - num12;
			float num14 = num8 - num6;
			float num15 = num9 + num5;
			float num16 = num8 + num6;
			float num17 = 1f - num7 - num12;
			float num18 = num11 - num4;
			float num19 = num9 - num5;
			float num20 = num11 + num4;
			float num21 = 1f - num7 - num10;
			Matrix4x4 result;
			result.M11 = value.M11 * num13 + value.M12 * num14 + value.M13 * num15;
			result.M12 = value.M11 * num16 + value.M12 * num17 + value.M13 * num18;
			result.M13 = value.M11 * num19 + value.M12 * num20 + value.M13 * num21;
			result.M14 = value.M14;
			result.M21 = value.M21 * num13 + value.M22 * num14 + value.M23 * num15;
			result.M22 = value.M21 * num16 + value.M22 * num17 + value.M23 * num18;
			result.M23 = value.M21 * num19 + value.M22 * num20 + value.M23 * num21;
			result.M24 = value.M24;
			result.M31 = value.M31 * num13 + value.M32 * num14 + value.M33 * num15;
			result.M32 = value.M31 * num16 + value.M32 * num17 + value.M33 * num18;
			result.M33 = value.M31 * num19 + value.M32 * num20 + value.M33 * num21;
			result.M34 = value.M34;
			result.M41 = value.M41 * num13 + value.M42 * num14 + value.M43 * num15;
			result.M42 = value.M41 * num16 + value.M42 * num17 + value.M43 * num18;
			result.M43 = value.M41 * num19 + value.M42 * num20 + value.M43 * num21;
			result.M44 = value.M44;
			return result;
		}

		/// <summary>Переставляет строки и столбцы матрицы.</summary>
		/// <param name="matrix">Преобразуемая матрица.</param>
		/// <returns>Преобразованная матрица.</returns>
		// Token: 0x06000056 RID: 86 RVA: 0x00005AE4 File Offset: 0x00003CE4
		public static Matrix4x4 Transpose(Matrix4x4 matrix)
		{
			Matrix4x4 result;
			result.M11 = matrix.M11;
			result.M12 = matrix.M21;
			result.M13 = matrix.M31;
			result.M14 = matrix.M41;
			result.M21 = matrix.M12;
			result.M22 = matrix.M22;
			result.M23 = matrix.M32;
			result.M24 = matrix.M42;
			result.M31 = matrix.M13;
			result.M32 = matrix.M23;
			result.M33 = matrix.M33;
			result.M34 = matrix.M43;
			result.M41 = matrix.M14;
			result.M42 = matrix.M24;
			result.M43 = matrix.M34;
			result.M44 = matrix.M44;
			return result;
		}

		/// <summary>Выполняет линейную интерполяцию из одной матрицы во вторую матрицу на основе значения, указывающего взвешивание второй матрицы.</summary>
		/// <param name="matrix1">Первая матрица.</param>
		/// <param name="matrix2">Вторая матрица.</param>
		/// <param name="amount">Относительное взвешивание матрицы <paramref name="matrix2" />.</param>
		/// <returns>Интерполированная матрица.</returns>
		// Token: 0x06000057 RID: 87 RVA: 0x00005BC4 File Offset: 0x00003DC4
		public static Matrix4x4 Lerp(Matrix4x4 matrix1, Matrix4x4 matrix2, float amount)
		{
			Matrix4x4 result;
			result.M11 = matrix1.M11 + (matrix2.M11 - matrix1.M11) * amount;
			result.M12 = matrix1.M12 + (matrix2.M12 - matrix1.M12) * amount;
			result.M13 = matrix1.M13 + (matrix2.M13 - matrix1.M13) * amount;
			result.M14 = matrix1.M14 + (matrix2.M14 - matrix1.M14) * amount;
			result.M21 = matrix1.M21 + (matrix2.M21 - matrix1.M21) * amount;
			result.M22 = matrix1.M22 + (matrix2.M22 - matrix1.M22) * amount;
			result.M23 = matrix1.M23 + (matrix2.M23 - matrix1.M23) * amount;
			result.M24 = matrix1.M24 + (matrix2.M24 - matrix1.M24) * amount;
			result.M31 = matrix1.M31 + (matrix2.M31 - matrix1.M31) * amount;
			result.M32 = matrix1.M32 + (matrix2.M32 - matrix1.M32) * amount;
			result.M33 = matrix1.M33 + (matrix2.M33 - matrix1.M33) * amount;
			result.M34 = matrix1.M34 + (matrix2.M34 - matrix1.M34) * amount;
			result.M41 = matrix1.M41 + (matrix2.M41 - matrix1.M41) * amount;
			result.M42 = matrix1.M42 + (matrix2.M42 - matrix1.M42) * amount;
			result.M43 = matrix1.M43 + (matrix2.M43 - matrix1.M43) * amount;
			result.M44 = matrix1.M44 + (matrix2.M44 - matrix1.M44) * amount;
			return result;
		}

		/// <summary>Преобразует заданную матрицу в отрицательную, умножая все ее значения на "-1".</summary>
		/// <param name="value">Матрица, преобразуемая в отрицательную.</param>
		/// <returns>Матрица, преобразованная в отрицательную.</returns>
		// Token: 0x06000058 RID: 88 RVA: 0x00005DA4 File Offset: 0x00003FA4
		public static Matrix4x4 Negate(Matrix4x4 value)
		{
			Matrix4x4 result;
			result.M11 = -value.M11;
			result.M12 = -value.M12;
			result.M13 = -value.M13;
			result.M14 = -value.M14;
			result.M21 = -value.M21;
			result.M22 = -value.M22;
			result.M23 = -value.M23;
			result.M24 = -value.M24;
			result.M31 = -value.M31;
			result.M32 = -value.M32;
			result.M33 = -value.M33;
			result.M34 = -value.M34;
			result.M41 = -value.M41;
			result.M42 = -value.M42;
			result.M43 = -value.M43;
			result.M44 = -value.M44;
			return result;
		}

		/// <summary>Складывает каждый элемент в одной матрице с соответствующим элементом во второй матрице.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица, содержащая суммарные значения <paramref name="value1" /> и <paramref name="value2" />.</returns>
		// Token: 0x06000059 RID: 89 RVA: 0x00005E94 File Offset: 0x00004094
		public static Matrix4x4 Add(Matrix4x4 value1, Matrix4x4 value2)
		{
			Matrix4x4 result;
			result.M11 = value1.M11 + value2.M11;
			result.M12 = value1.M12 + value2.M12;
			result.M13 = value1.M13 + value2.M13;
			result.M14 = value1.M14 + value2.M14;
			result.M21 = value1.M21 + value2.M21;
			result.M22 = value1.M22 + value2.M22;
			result.M23 = value1.M23 + value2.M23;
			result.M24 = value1.M24 + value2.M24;
			result.M31 = value1.M31 + value2.M31;
			result.M32 = value1.M32 + value2.M32;
			result.M33 = value1.M33 + value2.M33;
			result.M34 = value1.M34 + value2.M34;
			result.M41 = value1.M41 + value2.M41;
			result.M42 = value1.M42 + value2.M42;
			result.M43 = value1.M43 + value2.M43;
			result.M44 = value1.M44 + value2.M44;
			return result;
		}

		/// <summary>Вычитает каждый элемент во второй матрице из соответствующего элемента в первой матрице.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица, содержащая значения, которые являются результатом вычитания каждого элемента в <paramref name="value2" /> из соответствующего элемента в <paramref name="value1" />.</returns>
		// Token: 0x0600005A RID: 90 RVA: 0x00005FE4 File Offset: 0x000041E4
		public static Matrix4x4 Subtract(Matrix4x4 value1, Matrix4x4 value2)
		{
			Matrix4x4 result;
			result.M11 = value1.M11 - value2.M11;
			result.M12 = value1.M12 - value2.M12;
			result.M13 = value1.M13 - value2.M13;
			result.M14 = value1.M14 - value2.M14;
			result.M21 = value1.M21 - value2.M21;
			result.M22 = value1.M22 - value2.M22;
			result.M23 = value1.M23 - value2.M23;
			result.M24 = value1.M24 - value2.M24;
			result.M31 = value1.M31 - value2.M31;
			result.M32 = value1.M32 - value2.M32;
			result.M33 = value1.M33 - value2.M33;
			result.M34 = value1.M34 - value2.M34;
			result.M41 = value1.M41 - value2.M41;
			result.M42 = value1.M42 - value2.M42;
			result.M43 = value1.M43 - value2.M43;
			result.M44 = value1.M44 - value2.M44;
			return result;
		}

		/// <summary>Возвращает матрицу, полученную в результате перемножения двух матриц.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица произведения.</returns>
		// Token: 0x0600005B RID: 91 RVA: 0x00006134 File Offset: 0x00004334
		public static Matrix4x4 Multiply(Matrix4x4 value1, Matrix4x4 value2)
		{
			Matrix4x4 result;
			result.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21 + value1.M13 * value2.M31 + value1.M14 * value2.M41;
			result.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22 + value1.M13 * value2.M32 + value1.M14 * value2.M42;
			result.M13 = value1.M11 * value2.M13 + value1.M12 * value2.M23 + value1.M13 * value2.M33 + value1.M14 * value2.M43;
			result.M14 = value1.M11 * value2.M14 + value1.M12 * value2.M24 + value1.M13 * value2.M34 + value1.M14 * value2.M44;
			result.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21 + value1.M23 * value2.M31 + value1.M24 * value2.M41;
			result.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22 + value1.M23 * value2.M32 + value1.M24 * value2.M42;
			result.M23 = value1.M21 * value2.M13 + value1.M22 * value2.M23 + value1.M23 * value2.M33 + value1.M24 * value2.M43;
			result.M24 = value1.M21 * value2.M14 + value1.M22 * value2.M24 + value1.M23 * value2.M34 + value1.M24 * value2.M44;
			result.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value1.M33 * value2.M31 + value1.M34 * value2.M41;
			result.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value1.M33 * value2.M32 + value1.M34 * value2.M42;
			result.M33 = value1.M31 * value2.M13 + value1.M32 * value2.M23 + value1.M33 * value2.M33 + value1.M34 * value2.M43;
			result.M34 = value1.M31 * value2.M14 + value1.M32 * value2.M24 + value1.M33 * value2.M34 + value1.M34 * value2.M44;
			result.M41 = value1.M41 * value2.M11 + value1.M42 * value2.M21 + value1.M43 * value2.M31 + value1.M44 * value2.M41;
			result.M42 = value1.M41 * value2.M12 + value1.M42 * value2.M22 + value1.M43 * value2.M32 + value1.M44 * value2.M42;
			result.M43 = value1.M41 * value2.M13 + value1.M42 * value2.M23 + value1.M43 * value2.M33 + value1.M44 * value2.M43;
			result.M44 = value1.M41 * value2.M14 + value1.M42 * value2.M24 + value1.M43 * value2.M34 + value1.M44 * value2.M44;
			return result;
		}

		/// <summary>Возвращает матрицу, получаемую в результате масштабирования всех элементов заданной матрицы на скалярный множитель.</summary>
		/// <param name="value1">Масштабируемая матрица.</param>
		/// <param name="value2">Используемое значение масштабирования.</param>
		/// <returns>Масштабированная матрица.</returns>
		// Token: 0x0600005C RID: 92 RVA: 0x00006524 File Offset: 0x00004724
		public static Matrix4x4 Multiply(Matrix4x4 value1, float value2)
		{
			Matrix4x4 result;
			result.M11 = value1.M11 * value2;
			result.M12 = value1.M12 * value2;
			result.M13 = value1.M13 * value2;
			result.M14 = value1.M14 * value2;
			result.M21 = value1.M21 * value2;
			result.M22 = value1.M22 * value2;
			result.M23 = value1.M23 * value2;
			result.M24 = value1.M24 * value2;
			result.M31 = value1.M31 * value2;
			result.M32 = value1.M32 * value2;
			result.M33 = value1.M33 * value2;
			result.M34 = value1.M34 * value2;
			result.M41 = value1.M41 * value2;
			result.M42 = value1.M42 * value2;
			result.M43 = value1.M43 * value2;
			result.M44 = value1.M44 * value2;
			return result;
		}

		/// <summary>Преобразует заданную матрицу в отрицательную, умножая все ее значения на "-1".</summary>
		/// <param name="value">Матрица, преобразуемая в отрицательную.</param>
		/// <returns>Матрица, преобразованная в отрицательную.</returns>
		// Token: 0x0600005D RID: 93 RVA: 0x00006624 File Offset: 0x00004824
		public static Matrix4x4 operator -(Matrix4x4 value)
		{
			Matrix4x4 result;
			result.M11 = -value.M11;
			result.M12 = -value.M12;
			result.M13 = -value.M13;
			result.M14 = -value.M14;
			result.M21 = -value.M21;
			result.M22 = -value.M22;
			result.M23 = -value.M23;
			result.M24 = -value.M24;
			result.M31 = -value.M31;
			result.M32 = -value.M32;
			result.M33 = -value.M33;
			result.M34 = -value.M34;
			result.M41 = -value.M41;
			result.M42 = -value.M42;
			result.M43 = -value.M43;
			result.M44 = -value.M44;
			return result;
		}

		/// <summary>Складывает каждый элемент в одной матрице с соответствующим элементом во второй матрице.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица, содержащая суммарные значения.</returns>
		// Token: 0x0600005E RID: 94 RVA: 0x00006714 File Offset: 0x00004914
		public static Matrix4x4 operator +(Matrix4x4 value1, Matrix4x4 value2)
		{
			Matrix4x4 result;
			result.M11 = value1.M11 + value2.M11;
			result.M12 = value1.M12 + value2.M12;
			result.M13 = value1.M13 + value2.M13;
			result.M14 = value1.M14 + value2.M14;
			result.M21 = value1.M21 + value2.M21;
			result.M22 = value1.M22 + value2.M22;
			result.M23 = value1.M23 + value2.M23;
			result.M24 = value1.M24 + value2.M24;
			result.M31 = value1.M31 + value2.M31;
			result.M32 = value1.M32 + value2.M32;
			result.M33 = value1.M33 + value2.M33;
			result.M34 = value1.M34 + value2.M34;
			result.M41 = value1.M41 + value2.M41;
			result.M42 = value1.M42 + value2.M42;
			result.M43 = value1.M43 + value2.M43;
			result.M44 = value1.M44 + value2.M44;
			return result;
		}

		/// <summary>Вычитает каждый элемент во второй матрице из соответствующего элемента в первой матрице.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица, содержащая значения, которые являются результатом вычитания каждого элемента в <paramref name="value2" /> из соответствующего элемента в <paramref name="value1" />.</returns>
		// Token: 0x0600005F RID: 95 RVA: 0x00006864 File Offset: 0x00004A64
		public static Matrix4x4 operator -(Matrix4x4 value1, Matrix4x4 value2)
		{
			Matrix4x4 result;
			result.M11 = value1.M11 - value2.M11;
			result.M12 = value1.M12 - value2.M12;
			result.M13 = value1.M13 - value2.M13;
			result.M14 = value1.M14 - value2.M14;
			result.M21 = value1.M21 - value2.M21;
			result.M22 = value1.M22 - value2.M22;
			result.M23 = value1.M23 - value2.M23;
			result.M24 = value1.M24 - value2.M24;
			result.M31 = value1.M31 - value2.M31;
			result.M32 = value1.M32 - value2.M32;
			result.M33 = value1.M33 - value2.M33;
			result.M34 = value1.M34 - value2.M34;
			result.M41 = value1.M41 - value2.M41;
			result.M42 = value1.M42 - value2.M42;
			result.M43 = value1.M43 - value2.M43;
			result.M44 = value1.M44 - value2.M44;
			return result;
		}

		/// <summary>Возвращает матрицу, полученную в результате перемножения двух матриц.</summary>
		/// <param name="value1">Первая матрица.</param>
		/// <param name="value2">Вторая матрица.</param>
		/// <returns>Матрица произведения.</returns>
		// Token: 0x06000060 RID: 96 RVA: 0x000069B4 File Offset: 0x00004BB4
		public static Matrix4x4 operator *(Matrix4x4 value1, Matrix4x4 value2)
		{
			Matrix4x4 result;
			result.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21 + value1.M13 * value2.M31 + value1.M14 * value2.M41;
			result.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22 + value1.M13 * value2.M32 + value1.M14 * value2.M42;
			result.M13 = value1.M11 * value2.M13 + value1.M12 * value2.M23 + value1.M13 * value2.M33 + value1.M14 * value2.M43;
			result.M14 = value1.M11 * value2.M14 + value1.M12 * value2.M24 + value1.M13 * value2.M34 + value1.M14 * value2.M44;
			result.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21 + value1.M23 * value2.M31 + value1.M24 * value2.M41;
			result.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22 + value1.M23 * value2.M32 + value1.M24 * value2.M42;
			result.M23 = value1.M21 * value2.M13 + value1.M22 * value2.M23 + value1.M23 * value2.M33 + value1.M24 * value2.M43;
			result.M24 = value1.M21 * value2.M14 + value1.M22 * value2.M24 + value1.M23 * value2.M34 + value1.M24 * value2.M44;
			result.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value1.M33 * value2.M31 + value1.M34 * value2.M41;
			result.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value1.M33 * value2.M32 + value1.M34 * value2.M42;
			result.M33 = value1.M31 * value2.M13 + value1.M32 * value2.M23 + value1.M33 * value2.M33 + value1.M34 * value2.M43;
			result.M34 = value1.M31 * value2.M14 + value1.M32 * value2.M24 + value1.M33 * value2.M34 + value1.M34 * value2.M44;
			result.M41 = value1.M41 * value2.M11 + value1.M42 * value2.M21 + value1.M43 * value2.M31 + value1.M44 * value2.M41;
			result.M42 = value1.M41 * value2.M12 + value1.M42 * value2.M22 + value1.M43 * value2.M32 + value1.M44 * value2.M42;
			result.M43 = value1.M41 * value2.M13 + value1.M42 * value2.M23 + value1.M43 * value2.M33 + value1.M44 * value2.M43;
			result.M44 = value1.M41 * value2.M14 + value1.M42 * value2.M24 + value1.M43 * value2.M34 + value1.M44 * value2.M44;
			return result;
		}

		/// <summary>Возвращает матрицу, получаемую в результате масштабирования всех элементов заданной матрицы на скалярный множитель.</summary>
		/// <param name="value1">Масштабируемая матрица.</param>
		/// <param name="value2">Используемое значение масштабирования.</param>
		/// <returns>Масштабированная матрица.</returns>
		// Token: 0x06000061 RID: 97 RVA: 0x00006DA4 File Offset: 0x00004FA4
		public static Matrix4x4 operator *(Matrix4x4 value1, float value2)
		{
			Matrix4x4 result;
			result.M11 = value1.M11 * value2;
			result.M12 = value1.M12 * value2;
			result.M13 = value1.M13 * value2;
			result.M14 = value1.M14 * value2;
			result.M21 = value1.M21 * value2;
			result.M22 = value1.M22 * value2;
			result.M23 = value1.M23 * value2;
			result.M24 = value1.M24 * value2;
			result.M31 = value1.M31 * value2;
			result.M32 = value1.M32 * value2;
			result.M33 = value1.M33 * value2;
			result.M34 = value1.M34 * value2;
			result.M41 = value1.M41 * value2;
			result.M42 = value1.M42 * value2;
			result.M43 = value1.M43 * value2;
			result.M44 = value1.M44 * value2;
			return result;
		}

		/// <summary>Возвращает значение, указывающее на равенство заданных матриц.</summary>
		/// <param name="value1">Первая матрица для сравнения.</param>
		/// <param name="value2">Вторая матрица для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value1" /> и <paramref name="value2" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000062 RID: 98 RVA: 0x00006EA4 File Offset: 0x000050A4
		public static bool operator ==(Matrix4x4 value1, Matrix4x4 value2)
		{
			return value1.M11 == value2.M11 && value1.M22 == value2.M22 && value1.M33 == value2.M33 && value1.M44 == value2.M44 && value1.M12 == value2.M12 && value1.M13 == value2.M13 && value1.M14 == value2.M14 && value1.M21 == value2.M21 && value1.M23 == value2.M23 && value1.M24 == value2.M24 && value1.M31 == value2.M31 && value1.M32 == value2.M32 && value1.M34 == value2.M34 && value1.M41 == value2.M41 && value1.M42 == value2.M42 && value1.M43 == value2.M43;
		}

		/// <summary>Возвращает значение, указывающее на неравенство заданных матриц.</summary>
		/// <param name="value1">Первая матрица для сравнения.</param>
		/// <param name="value2">Вторая матрица для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value1" /> и <paramref name="value2" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000063 RID: 99 RVA: 0x00006FA8 File Offset: 0x000051A8
		public static bool operator !=(Matrix4x4 value1, Matrix4x4 value2)
		{
			return value1.M11 != value2.M11 || value1.M12 != value2.M12 || value1.M13 != value2.M13 || value1.M14 != value2.M14 || value1.M21 != value2.M21 || value1.M22 != value2.M22 || value1.M23 != value2.M23 || value1.M24 != value2.M24 || value1.M31 != value2.M31 || value1.M32 != value2.M32 || value1.M33 != value2.M33 || value1.M34 != value2.M34 || value1.M41 != value2.M41 || value1.M42 != value2.M42 || value1.M43 != value2.M43 || value1.M44 != value2.M44;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр другой матрице 4x4.</summary>
		/// <param name="other">Другая матрица.</param>
		/// <returns>Значение <see langword="true" />, если две матрицы равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000064 RID: 100 RVA: 0x000070B0 File Offset: 0x000052B0
		public bool Equals(Matrix4x4 other)
		{
			return this.M11 == other.M11 && this.M22 == other.M22 && this.M33 == other.M33 && this.M44 == other.M44 && this.M12 == other.M12 && this.M13 == other.M13 && this.M14 == other.M14 && this.M21 == other.M21 && this.M23 == other.M23 && this.M24 == other.M24 && this.M31 == other.M31 && this.M32 == other.M32 && this.M34 == other.M34 && this.M41 == other.M41 && this.M42 == other.M42 && this.M43 == other.M43;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />. Если значением параметра <paramref name="obj" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		// Token: 0x06000065 RID: 101 RVA: 0x000071B1 File Offset: 0x000053B1
		public override bool Equals(object obj)
		{
			return obj is Matrix4x4 && this.Equals((Matrix4x4)obj);
		}

		/// <summary>Возвращает строку, представляющую данную матрицу.</summary>
		/// <returns>Строковое представление данной матрицы.</returns>
		// Token: 0x06000066 RID: 102 RVA: 0x000071CC File Offset: 0x000053CC
		public override string ToString()
		{
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			return string.Format(currentCulture, "{{ {{M11:{0} M12:{1} M13:{2} M14:{3}}} {{M21:{4} M22:{5} M23:{6} M24:{7}}} {{M31:{8} M32:{9} M33:{10} M34:{11}}} {{M41:{12} M42:{13} M43:{14} M44:{15}}} }}", new object[]
			{
				this.M11.ToString(currentCulture),
				this.M12.ToString(currentCulture),
				this.M13.ToString(currentCulture),
				this.M14.ToString(currentCulture),
				this.M21.ToString(currentCulture),
				this.M22.ToString(currentCulture),
				this.M23.ToString(currentCulture),
				this.M24.ToString(currentCulture),
				this.M31.ToString(currentCulture),
				this.M32.ToString(currentCulture),
				this.M33.ToString(currentCulture),
				this.M34.ToString(currentCulture),
				this.M41.ToString(currentCulture),
				this.M42.ToString(currentCulture),
				this.M43.ToString(currentCulture),
				this.M44.ToString(currentCulture)
			});
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код.</returns>
		// Token: 0x06000067 RID: 103 RVA: 0x000072E8 File Offset: 0x000054E8
		public override int GetHashCode()
		{
			return this.M11.GetHashCode() + this.M12.GetHashCode() + this.M13.GetHashCode() + this.M14.GetHashCode() + this.M21.GetHashCode() + this.M22.GetHashCode() + this.M23.GetHashCode() + this.M24.GetHashCode() + this.M31.GetHashCode() + this.M32.GetHashCode() + this.M33.GetHashCode() + this.M34.GetHashCode() + this.M41.GetHashCode() + this.M42.GetHashCode() + this.M43.GetHashCode() + this.M44.GetHashCode();
		}

		/// <summary>Первый элемент первой строки.</summary>
		// Token: 0x04000045 RID: 69
		public float M11;

		/// <summary>Второй элемент первой строки.</summary>
		// Token: 0x04000046 RID: 70
		public float M12;

		/// <summary>Третий элемент первой строки.</summary>
		// Token: 0x04000047 RID: 71
		public float M13;

		/// <summary>Четвертый элемент первой строки.</summary>
		// Token: 0x04000048 RID: 72
		public float M14;

		/// <summary>Первый элемент второй строки.</summary>
		// Token: 0x04000049 RID: 73
		public float M21;

		/// <summary>Второй элемент второй строки.</summary>
		// Token: 0x0400004A RID: 74
		public float M22;

		/// <summary>Третий элемент второй строки.</summary>
		// Token: 0x0400004B RID: 75
		public float M23;

		/// <summary>Четвертый элемент второй строки.</summary>
		// Token: 0x0400004C RID: 76
		public float M24;

		/// <summary>Первый элемент третьей строки.</summary>
		// Token: 0x0400004D RID: 77
		public float M31;

		/// <summary>Второй элемент третьей строки.</summary>
		// Token: 0x0400004E RID: 78
		public float M32;

		/// <summary>Третий элемент третьей строки.</summary>
		// Token: 0x0400004F RID: 79
		public float M33;

		/// <summary>Четвертый элемент третьей строки.</summary>
		// Token: 0x04000050 RID: 80
		public float M34;

		/// <summary>Первый элемент четвертой строки.</summary>
		// Token: 0x04000051 RID: 81
		public float M41;

		/// <summary>Второй элемент четвертой строки.</summary>
		// Token: 0x04000052 RID: 82
		public float M42;

		/// <summary>Третий элемент четвертой строки.</summary>
		// Token: 0x04000053 RID: 83
		public float M43;

		/// <summary>Четвертый элемент четвертой строки.</summary>
		// Token: 0x04000054 RID: 84
		public float M44;

		// Token: 0x04000055 RID: 85
		private static readonly Matrix4x4 _identity = new Matrix4x4(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);

		// Token: 0x02000006 RID: 6
		private struct CanonicalBasis
		{
			// Token: 0x04000056 RID: 86
			public Vector3 Row0;

			// Token: 0x04000057 RID: 87
			public Vector3 Row1;

			// Token: 0x04000058 RID: 88
			public Vector3 Row2;
		}

		// Token: 0x02000007 RID: 7
		private struct VectorBasis
		{
			// Token: 0x04000059 RID: 89
			public unsafe Vector3* Element0;

			// Token: 0x0400005A RID: 90
			public unsafe Vector3* Element1;

			// Token: 0x0400005B RID: 91
			public unsafe Vector3* Element2;
		}
	}
}
