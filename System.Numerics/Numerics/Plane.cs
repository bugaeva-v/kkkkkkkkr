using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	/// <summary>Представляет плоскость в трехмерном пространстве.</summary>
	// Token: 0x02000008 RID: 8
	public struct Plane : IEquatable<Plane>
	{
		/// <summary>Создает объект <see cref="T:System.Numerics.Plane" /> на основе координат X, Y и Z его нормали и расстояния от точки начала координат для этой нормали.</summary>
		/// <param name="x">Координата X нормали.</param>
		/// <param name="y">Координата Y нормали.</param>
		/// <param name="z">Координата Z нормали.</param>
		/// <param name="d">Расстояние плоскости вдоль ее нормали от начала координат.</param>
		// Token: 0x06000069 RID: 105 RVA: 0x0000741B File Offset: 0x0000561B
		public Plane(float x, float y, float z, float d)
		{
			this.Normal = new Vector3(x, y, z);
			this.D = d;
		}

		/// <summary>Создает объект <see cref="T:System.Numerics.Plane" /> на основе заданной нормали и расстояния вдоль нормали от начала координат.</summary>
		/// <param name="normal">Вектор нормали плоскости.</param>
		/// <param name="d">Расстояние плоскости от начала координат вдоль ее вектора нормали.</param>
		// Token: 0x0600006A RID: 106 RVA: 0x00007433 File Offset: 0x00005633
		public Plane(Vector3 normal, float d)
		{
			this.Normal = normal;
			this.D = d;
		}

		/// <summary>Создает объект <see cref="T:System.Numerics.Plane" /> на основе заданного четырехмерного вектора.</summary>
		/// <param name="value">Вектор, первые три элемента которого описывают вектор нормали и <see cref="F:System.Numerics.Vector4.W" /> которого определяет расстояние вдоль этой нормали от начала координат.</param>
		// Token: 0x0600006B RID: 107 RVA: 0x00007443 File Offset: 0x00005643
		public Plane(Vector4 value)
		{
			this.Normal = new Vector3(value.X, value.Y, value.Z);
			this.D = value.W;
		}

		/// <summary>Создает объект <see cref="T:System.Numerics.Plane" />, содержащий три заданные точки.</summary>
		/// <param name="point1">Первая точка, определяющая плоскость.</param>
		/// <param name="point2">Вторая точка, определяющая плоскость.</param>
		/// <param name="point3">Третья точка, определяющая плоскость.</param>
		/// <returns>Плоскость, содержащая три точки.</returns>
		// Token: 0x0600006C RID: 108 RVA: 0x00007470 File Offset: 0x00005670
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Plane CreateFromVertices(Vector3 point1, Vector3 point2, Vector3 point3)
		{
			if (Vector.IsHardwareAccelerated)
			{
				Vector3 vector = point2 - point1;
				Vector3 vector2 = point3 - point1;
				Vector3 vector3 = Vector3.Normalize(Vector3.Cross(vector, vector2));
				float d = -Vector3.Dot(vector3, point1);
				return new Plane(vector3, d);
			}
			float num = point2.X - point1.X;
			float num2 = point2.Y - point1.Y;
			float num3 = point2.Z - point1.Z;
			float num4 = point3.X - point1.X;
			float num5 = point3.Y - point1.Y;
			float num6 = point3.Z - point1.Z;
			float num7 = num2 * num6 - num3 * num5;
			float num8 = num3 * num4 - num * num6;
			float num9 = num * num5 - num2 * num4;
			float x = num7 * num7 + num8 * num8 + num9 * num9;
			float num10 = 1f / MathF.Sqrt(x);
			Vector3 vector4 = new Vector3(num7 * num10, num8 * num10, num9 * num10);
			return new Plane(vector4, -(vector4.X * point1.X + vector4.Y * point1.Y + vector4.Z * point1.Z));
		}

		/// <summary>Создает новый объект <see cref="T:System.Numerics.Plane" />, вектор нормали которого — нормализованный вектор нормали исходной плоскости.</summary>
		/// <param name="value">Исходная плоскость.</param>
		/// <returns>Нормализованная плоскость.</returns>
		// Token: 0x0600006D RID: 109 RVA: 0x00007598 File Offset: 0x00005798
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Plane Normalize(Plane value)
		{
			if (Vector.IsHardwareAccelerated)
			{
				float num = value.Normal.LengthSquared();
				if (MathF.Abs(num - 1f) < 1.1920929E-07f)
				{
					return value;
				}
				float num2 = MathF.Sqrt(num);
				return new Plane(value.Normal / num2, value.D / num2);
			}
			else
			{
				float num3 = value.Normal.X * value.Normal.X + value.Normal.Y * value.Normal.Y + value.Normal.Z * value.Normal.Z;
				if (MathF.Abs(num3 - 1f) < 1.1920929E-07f)
				{
					return value;
				}
				float num4 = 1f / MathF.Sqrt(num3);
				return new Plane(value.Normal.X * num4, value.Normal.Y * num4, value.Normal.Z * num4, value.D * num4);
			}
		}

		/// <summary>Преобразует нормализованную плоскость по матрице 4x4.</summary>
		/// <param name="plane">Нормализованная плоскость для преобразования.</param>
		/// <param name="matrix">Матрица преобразования, применяемая к <paramref name="plane" />.</param>
		/// <returns>Преобразованная плоскость.</returns>
		// Token: 0x0600006E RID: 110 RVA: 0x00007690 File Offset: 0x00005890
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Plane Transform(Plane plane, Matrix4x4 matrix)
		{
			Matrix4x4 matrix4x;
			Matrix4x4.Invert(matrix, out matrix4x);
			float x = plane.Normal.X;
			float y = plane.Normal.Y;
			float z = plane.Normal.Z;
			float d = plane.D;
			return new Plane(x * matrix4x.M11 + y * matrix4x.M12 + z * matrix4x.M13 + d * matrix4x.M14, x * matrix4x.M21 + y * matrix4x.M22 + z * matrix4x.M23 + d * matrix4x.M24, x * matrix4x.M31 + y * matrix4x.M32 + z * matrix4x.M33 + d * matrix4x.M34, x * matrix4x.M41 + y * matrix4x.M42 + z * matrix4x.M43 + d * matrix4x.M44);
		}

		/// <summary>Преобразует нормализованную плоскость по повороту кватерниона.</summary>
		/// <param name="plane">Нормализованная плоскость для преобразования.</param>
		/// <param name="rotation">Поворот кватерниона для применения к плоскости.</param>
		/// <returns>Новая плоскость, полученная в результате применения поворота кватерниона.</returns>
		// Token: 0x0600006F RID: 111 RVA: 0x00007768 File Offset: 0x00005968
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Plane Transform(Plane plane, Quaternion rotation)
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
			float x = plane.Normal.X;
			float y = plane.Normal.Y;
			float z = plane.Normal.Z;
			return new Plane(x * num13 + y * num14 + z * num15, x * num16 + y * num17 + z * num18, x * num19 + y * num20 + z * num21, plane.D);
		}

		/// <summary>Вычисляет скалярное произведение плоскости и четырехмерного вектора.</summary>
		/// <param name="plane">Плоскость.</param>
		/// <param name="value">Четырехмерный вектор.</param>
		/// <returns>Скалярное произведение.</returns>
		// Token: 0x06000070 RID: 112 RVA: 0x000078A8 File Offset: 0x00005AA8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Plane plane, Vector4 value)
		{
			return plane.Normal.X * value.X + plane.Normal.Y * value.Y + plane.Normal.Z * value.Z + plane.D * value.W;
		}

		/// <summary>Возвращает скалярное произведение заданного трехмерного вектора и вектора нормали этой плоскости, а также значение расстояния (<see cref="F:System.Numerics.Plane.D" />) плоскости.</summary>
		/// <param name="plane">Плоскость.</param>
		/// <param name="value">Трехмерный вектор.</param>
		/// <returns>Скалярное произведение.</returns>
		// Token: 0x06000071 RID: 113 RVA: 0x000078FC File Offset: 0x00005AFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float DotCoordinate(Plane plane, Vector3 value)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return Vector3.Dot(plane.Normal, value) + plane.D;
			}
			return plane.Normal.X * value.X + plane.Normal.Y * value.Y + plane.Normal.Z * value.Z + plane.D;
		}

		/// <summary>Возвращает скалярное произведение заданного трехмерного вектора и вектора <see cref="F:System.Numerics.Plane.Normal" /> этой плоскости.</summary>
		/// <param name="plane">Плоскость.</param>
		/// <param name="value">Трехмерный вектор.</param>
		/// <returns>Скалярное произведение.</returns>
		// Token: 0x06000072 RID: 114 RVA: 0x00007964 File Offset: 0x00005B64
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float DotNormal(Plane plane, Vector3 value)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return Vector3.Dot(plane.Normal, value);
			}
			return plane.Normal.X * value.X + plane.Normal.Y * value.Y + plane.Normal.Z * value.Z;
		}

		/// <summary>Возвращает значение, указывающее, равны ли две плоскости.</summary>
		/// <param name="value1">Первая сравниваемая плоскость.</param>
		/// <param name="value2">Вторая сравниваемая плоскость.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value1" /> и <paramref name="value2" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000073 RID: 115 RVA: 0x000079C0 File Offset: 0x00005BC0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Plane value1, Plane value2)
		{
			return value1.Normal.X == value2.Normal.X && value1.Normal.Y == value2.Normal.Y && value1.Normal.Z == value2.Normal.Z && value1.D == value2.D;
		}

		/// <summary>Возвращает значение, указывающее, что две плоскости не равны.</summary>
		/// <param name="value1">Первая сравниваемая плоскость.</param>
		/// <param name="value2">Вторая сравниваемая плоскость.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value1" /> и <paramref name="value2" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000074 RID: 116 RVA: 0x00007A28 File Offset: 0x00005C28
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Plane value1, Plane value2)
		{
			return value1.Normal.X != value2.Normal.X || value1.Normal.Y != value2.Normal.Y || value1.Normal.Z != value2.Normal.Z || value1.D != value2.D;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр другому объекту плоскости.</summary>
		/// <param name="other">Другая плоскость.</param>
		/// <returns>Значение <see langword="true" />, если две плоскости равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000075 RID: 117 RVA: 0x00007A90 File Offset: 0x00005C90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(Plane other)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return this.Normal.Equals(other.Normal) && this.D == other.D;
			}
			return this.Normal.X == other.Normal.X && this.Normal.Y == other.Normal.Y && this.Normal.Z == other.Normal.Z && this.D == other.D;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />. Если значением параметра <paramref name="obj" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		// Token: 0x06000076 RID: 118 RVA: 0x00007B20 File Offset: 0x00005D20
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			return obj is Plane && this.Equals((Plane)obj);
		}

		/// <summary>Возвращает строковое представление данного объекта плоскости.</summary>
		/// <returns>Строка, представляющая данный объект <see cref="T:System.Numerics.Plane" />.</returns>
		// Token: 0x06000077 RID: 119 RVA: 0x00007B38 File Offset: 0x00005D38
		public override string ToString()
		{
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			return string.Format(currentCulture, "{{Normal:{0} D:{1}}}", this.Normal.ToString(), this.D.ToString(currentCulture));
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код.</returns>
		// Token: 0x06000078 RID: 120 RVA: 0x00007B73 File Offset: 0x00005D73
		public override int GetHashCode()
		{
			return this.Normal.GetHashCode() + this.D.GetHashCode();
		}

		/// <summary>Вектор нормали плоскости.</summary>
		// Token: 0x0400005C RID: 92
		public Vector3 Normal;

		/// <summary>Расстояние плоскости вдоль ее нормали от начала координат.</summary>
		// Token: 0x0400005D RID: 93
		public float D;
	}
}
