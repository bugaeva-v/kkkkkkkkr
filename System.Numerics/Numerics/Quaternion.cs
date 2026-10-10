using System;
using System.Globalization;

namespace System.Numerics
{
	/// <summary>Представляет вектор, используемый для кодирования трехмерных физических поворотов.</summary>
	// Token: 0x02000009 RID: 9
	public struct Quaternion : IEquatable<Quaternion>
	{
		/// <summary>Получает кватернион, который представляет отсутствие вращения.</summary>
		/// <returns>Кватернион, значения которого являются <c>(0, 0, 0, 1)</c>.</returns>
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00007B92 File Offset: 0x00005D92
		public static Quaternion Identity
		{
			get
			{
				return new Quaternion(0f, 0f, 0f, 1f);
			}
		}

		/// <summary>Получает значение, указывающее, является ли текущий экземпляр единичным кватернионом.</summary>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр является единичным кватернионом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00007BAD File Offset: 0x00005DAD
		public bool IsIdentity
		{
			get
			{
				return this.X == 0f && this.Y == 0f && this.Z == 0f && this.W == 1f;
			}
		}

		/// <summary>Создает кватернион на основе заданных координат.</summary>
		/// <param name="x">Значение, назначаемое координате X кватерниона.</param>
		/// <param name="y">Значение, назначаемое координате Y кватерниона.</param>
		/// <param name="z">Значение, назначаемое координате Z кватерниона.</param>
		/// <param name="w">Значение, назначаемое координате W кватерниона.</param>
		// Token: 0x0600007B RID: 123 RVA: 0x00007BE5 File Offset: 0x00005DE5
		public Quaternion(float x, float y, float z, float w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		/// <summary>Создает кватернион на основе заданного вектора и частей поворота.</summary>
		/// <param name="vectorPart">Часть вектора кватерниона.</param>
		/// <param name="scalarPart">Часть поворота кватерниона.</param>
		// Token: 0x0600007C RID: 124 RVA: 0x00007C04 File Offset: 0x00005E04
		public Quaternion(Vector3 vectorPart, float scalarPart)
		{
			this.X = vectorPart.X;
			this.Y = vectorPart.Y;
			this.Z = vectorPart.Z;
			this.W = scalarPart;
		}

		/// <summary>Вычисляет длину кватерниона.</summary>
		/// <returns>Вычисленная длина кватерниона.</returns>
		// Token: 0x0600007D RID: 125 RVA: 0x00007C31 File Offset: 0x00005E31
		public float Length()
		{
			return MathF.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W);
		}

		/// <summary>Вычисляет длину кватерниона в квадрате.</summary>
		/// <returns>Длина кватерниона в квадрате.</returns>
		// Token: 0x0600007E RID: 126 RVA: 0x00007C6F File Offset: 0x00005E6F
		public float LengthSquared()
		{
			return this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W;
		}

		/// <summary>Делит каждую координату указанного кватерниона <see cref="T:System.Numerics.Quaternion" /> на его длину.</summary>
		/// <param name="value">Нормализуемый кватернион.</param>
		/// <returns>Нормализованный кватернион.</returns>
		// Token: 0x0600007F RID: 127 RVA: 0x00007CA8 File Offset: 0x00005EA8
		public static Quaternion Normalize(Quaternion value)
		{
			float x = value.X * value.X + value.Y * value.Y + value.Z * value.Z + value.W * value.W;
			float num = 1f / MathF.Sqrt(x);
			Quaternion result;
			result.X = value.X * num;
			result.Y = value.Y * num;
			result.Z = value.Z * num;
			result.W = value.W * num;
			return result;
		}

		/// <summary>Возвращает сопряженный объект заданного кватерниона.</summary>
		/// <param name="value">Кватернион.</param>
		/// <returns>Новый кватернион, который является сопряженным объектом <see langword="value" />.</returns>
		// Token: 0x06000080 RID: 128 RVA: 0x00007D38 File Offset: 0x00005F38
		public static Quaternion Conjugate(Quaternion value)
		{
			Quaternion result;
			result.X = -value.X;
			result.Y = -value.Y;
			result.Z = -value.Z;
			result.W = value.W;
			return result;
		}

		/// <summary>Возвращает инверсный объект кватерниона.</summary>
		/// <param name="value">Кватернион.</param>
		/// <returns>Инвертированный кватернион.</returns>
		// Token: 0x06000081 RID: 129 RVA: 0x00007D80 File Offset: 0x00005F80
		public static Quaternion Inverse(Quaternion value)
		{
			float num = value.X * value.X + value.Y * value.Y + value.Z * value.Z + value.W * value.W;
			float num2 = 1f / num;
			Quaternion result;
			result.X = -value.X * num2;
			result.Y = -value.Y * num2;
			result.Z = -value.Z * num2;
			result.W = value.W * num2;
			return result;
		}

		/// <summary>Создает кватернион на основе единичного вектора и угла поворота вокруг вектора.</summary>
		/// <param name="axis">Единичный вектор, вокруг которого необходимо выполнить поворот.</param>
		/// <param name="angle">Угол в радианах для поворота вокруг вектора.</param>
		/// <returns>Только что созданный кватернион.</returns>
		// Token: 0x06000082 RID: 130 RVA: 0x00007E10 File Offset: 0x00006010
		public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
		{
			float x = angle * 0.5f;
			float num = MathF.Sin(x);
			float w = MathF.Cos(x);
			Quaternion result;
			result.X = axis.X * num;
			result.Y = axis.Y * num;
			result.Z = axis.Z * num;
			result.W = w;
			return result;
		}

		/// <summary>Создает новый кватернион на основе заданного значения нутации, прецессии и собственного вращения.</summary>
		/// <param name="yaw">Угол нутации вокруг оси Y в радианах.</param>
		/// <param name="pitch">Угол прецессии вокруг оси X в радианах.</param>
		/// <param name="roll">Угол собственного вращения вокруг оси Z в радианах.</param>
		/// <returns>Полученный кватернион.</returns>
		// Token: 0x06000083 RID: 131 RVA: 0x00007E68 File Offset: 0x00006068
		public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			float x = roll * 0.5f;
			float num = MathF.Sin(x);
			float num2 = MathF.Cos(x);
			float x2 = pitch * 0.5f;
			float num3 = MathF.Sin(x2);
			float num4 = MathF.Cos(x2);
			float x3 = yaw * 0.5f;
			float num5 = MathF.Sin(x3);
			float num6 = MathF.Cos(x3);
			Quaternion result;
			result.X = num6 * num3 * num2 + num5 * num4 * num;
			result.Y = num5 * num4 * num2 - num6 * num3 * num;
			result.Z = num6 * num4 * num - num5 * num3 * num2;
			result.W = num6 * num4 * num2 + num5 * num3 * num;
			return result;
		}

		/// <summary>Создает кватернион на основе заданной матрицы поворота.</summary>
		/// <param name="matrix">Матрица поворота.</param>
		/// <returns>Только что созданный кватернион.</returns>
		// Token: 0x06000084 RID: 132 RVA: 0x00007F08 File Offset: 0x00006108
		public static Quaternion CreateFromRotationMatrix(Matrix4x4 matrix)
		{
			float num = matrix.M11 + matrix.M22 + matrix.M33;
			Quaternion result = default(Quaternion);
			if (num > 0f)
			{
				float num2 = MathF.Sqrt(num + 1f);
				result.W = num2 * 0.5f;
				num2 = 0.5f / num2;
				result.X = (matrix.M23 - matrix.M32) * num2;
				result.Y = (matrix.M31 - matrix.M13) * num2;
				result.Z = (matrix.M12 - matrix.M21) * num2;
			}
			else if (matrix.M11 >= matrix.M22 && matrix.M11 >= matrix.M33)
			{
				float num3 = MathF.Sqrt(1f + matrix.M11 - matrix.M22 - matrix.M33);
				float num4 = 0.5f / num3;
				result.X = 0.5f * num3;
				result.Y = (matrix.M12 + matrix.M21) * num4;
				result.Z = (matrix.M13 + matrix.M31) * num4;
				result.W = (matrix.M23 - matrix.M32) * num4;
			}
			else if (matrix.M22 > matrix.M33)
			{
				float num5 = MathF.Sqrt(1f + matrix.M22 - matrix.M11 - matrix.M33);
				float num6 = 0.5f / num5;
				result.X = (matrix.M21 + matrix.M12) * num6;
				result.Y = 0.5f * num5;
				result.Z = (matrix.M32 + matrix.M23) * num6;
				result.W = (matrix.M31 - matrix.M13) * num6;
			}
			else
			{
				float num7 = MathF.Sqrt(1f + matrix.M33 - matrix.M11 - matrix.M22);
				float num8 = 0.5f / num7;
				result.X = (matrix.M31 + matrix.M13) * num8;
				result.Y = (matrix.M32 + matrix.M23) * num8;
				result.Z = 0.5f * num7;
				result.W = (matrix.M12 - matrix.M21) * num8;
			}
			return result;
		}

		/// <summary>Вычисляет скалярное произведение двух кватернионов.</summary>
		/// <param name="quaternion1">Первый кватернион.</param>
		/// <param name="quaternion2">Второй кватернион.</param>
		/// <returns>Скалярное произведение.</returns>
		// Token: 0x06000085 RID: 133 RVA: 0x00008159 File Offset: 0x00006359
		public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
		{
			return quaternion1.X * quaternion2.X + quaternion1.Y * quaternion2.Y + quaternion1.Z * quaternion2.Z + quaternion1.W * quaternion2.W;
		}

		/// <summary>Выполняет интерполяцию между двумя кватернионами, используя сферическую линейную интерполяцию.</summary>
		/// <param name="quaternion1">Первый кватернион.</param>
		/// <param name="quaternion2">Второй кватернион.</param>
		/// <param name="amount">Относительный вес второго кватерниона в интерполяции.</param>
		/// <returns>Интерполированный кватернион.</returns>
		// Token: 0x06000086 RID: 134 RVA: 0x00008194 File Offset: 0x00006394
		public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			float num = quaternion1.X * quaternion2.X + quaternion1.Y * quaternion2.Y + quaternion1.Z * quaternion2.Z + quaternion1.W * quaternion2.W;
			bool flag = false;
			if (num < 0f)
			{
				flag = true;
				num = -num;
			}
			float num2;
			float num3;
			if (num > 0.999999f)
			{
				num2 = 1f - amount;
				num3 = (flag ? (-amount) : amount);
			}
			else
			{
				float num4 = MathF.Acos(num);
				float num5 = 1f / MathF.Sin(num4);
				num2 = MathF.Sin((1f - amount) * num4) * num5;
				num3 = (flag ? (-MathF.Sin(amount * num4) * num5) : (MathF.Sin(amount * num4) * num5));
			}
			Quaternion result;
			result.X = num2 * quaternion1.X + num3 * quaternion2.X;
			result.Y = num2 * quaternion1.Y + num3 * quaternion2.Y;
			result.Z = num2 * quaternion1.Z + num3 * quaternion2.Z;
			result.W = num2 * quaternion1.W + num3 * quaternion2.W;
			return result;
		}

		/// <summary>Выполняет линейную интерполяцию между двумя кватернионами на основе значения, указывающего взвешивание второго кватерниона.</summary>
		/// <param name="quaternion1">Первый кватернион.</param>
		/// <param name="quaternion2">Второй кватернион.</param>
		/// <param name="amount">Относительный вес <paramref name="quaternion2" /> в интерполяции.</param>
		/// <returns>Интерполированный кватернион.</returns>
		// Token: 0x06000087 RID: 135 RVA: 0x000082B8 File Offset: 0x000064B8
		public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			float num = 1f - amount;
			Quaternion quaternion3 = default(Quaternion);
			if (quaternion1.X * quaternion2.X + quaternion1.Y * quaternion2.Y + quaternion1.Z * quaternion2.Z + quaternion1.W * quaternion2.W >= 0f)
			{
				quaternion3.X = num * quaternion1.X + amount * quaternion2.X;
				quaternion3.Y = num * quaternion1.Y + amount * quaternion2.Y;
				quaternion3.Z = num * quaternion1.Z + amount * quaternion2.Z;
				quaternion3.W = num * quaternion1.W + amount * quaternion2.W;
			}
			else
			{
				quaternion3.X = num * quaternion1.X - amount * quaternion2.X;
				quaternion3.Y = num * quaternion1.Y - amount * quaternion2.Y;
				quaternion3.Z = num * quaternion1.Z - amount * quaternion2.Z;
				quaternion3.W = num * quaternion1.W - amount * quaternion2.W;
			}
			float x = quaternion3.X * quaternion3.X + quaternion3.Y * quaternion3.Y + quaternion3.Z * quaternion3.Z + quaternion3.W * quaternion3.W;
			float num2 = 1f / MathF.Sqrt(x);
			quaternion3.X *= num2;
			quaternion3.Y *= num2;
			quaternion3.Z *= num2;
			quaternion3.W *= num2;
			return quaternion3;
		}

		/// <summary>Сцепляет два кватерниона.</summary>
		/// <param name="value1">Поворот первого кватерниона в серии.</param>
		/// <param name="value2">Поворот второго кватерниона в серии.</param>
		/// <returns>Новый кватернион, представляющий результат сцепления поворота <paramref name="value1" />, за которым следует поворот <paramref name="value2" />.</returns>
		// Token: 0x06000088 RID: 136 RVA: 0x00008454 File Offset: 0x00006654
		public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
		{
			float x = value2.X;
			float y = value2.Y;
			float z = value2.Z;
			float w = value2.W;
			float x2 = value1.X;
			float y2 = value1.Y;
			float z2 = value1.Z;
			float w2 = value1.W;
			float num = y * z2 - z * y2;
			float num2 = z * x2 - x * z2;
			float num3 = x * y2 - y * x2;
			float num4 = x * x2 + y * y2 + z * z2;
			Quaternion result;
			result.X = x * w2 + x2 * w + num;
			result.Y = y * w2 + y2 * w + num2;
			result.Z = z * w2 + z2 * w + num3;
			result.W = w * w2 - num4;
			return result;
		}

		/// <summary>Обращает знак каждой координаты кватерниона.</summary>
		/// <param name="value">Кватернион, преобразуемый в отрицательный.</param>
		/// <returns>Кватернион, преобразованный в отрицательный.</returns>
		// Token: 0x06000089 RID: 137 RVA: 0x0000851C File Offset: 0x0000671C
		public static Quaternion Negate(Quaternion value)
		{
			Quaternion result;
			result.X = -value.X;
			result.Y = -value.Y;
			result.Z = -value.Z;
			result.W = -value.W;
			return result;
		}

		/// <summary>Складывает каждый элемент в одном кватернионе с соответствующим элементом во втором кватернионе.</summary>
		/// <param name="value1">Первый кватернион.</param>
		/// <param name="value2">Второй кватернион.</param>
		/// <returns>Кватернион, содержащий суммарные значения <paramref name="value1" /> и <paramref name="value2" />.</returns>
		// Token: 0x0600008A RID: 138 RVA: 0x00008564 File Offset: 0x00006764
		public static Quaternion Add(Quaternion value1, Quaternion value2)
		{
			Quaternion result;
			result.X = value1.X + value2.X;
			result.Y = value1.Y + value2.Y;
			result.Z = value1.Z + value2.Z;
			result.W = value1.W + value2.W;
			return result;
		}

		/// <summary>Вычитает каждый элемент во втором кватернионе из соответствующего элемента в первом кватернионе.</summary>
		/// <param name="value1">Первый кватернион.</param>
		/// <param name="value2">Второй кватернион.</param>
		/// <returns>Кватернион, содержащий значения, которые являются результатом вычитания каждого элемента в <paramref name="value2" /> из соответствующего элемента в <paramref name="value1" />.</returns>
		// Token: 0x0600008B RID: 139 RVA: 0x000085C4 File Offset: 0x000067C4
		public static Quaternion Subtract(Quaternion value1, Quaternion value2)
		{
			Quaternion result;
			result.X = value1.X - value2.X;
			result.Y = value1.Y - value2.Y;
			result.Z = value1.Z - value2.Z;
			result.W = value1.W - value2.W;
			return result;
		}

		/// <summary>Возвращает кватернион, являющийся результатом перемножения двух кватернионов.</summary>
		/// <param name="value1">Первый кватернион.</param>
		/// <param name="value2">Второй кватернион.</param>
		/// <returns>Кватернион произведения.</returns>
		// Token: 0x0600008C RID: 140 RVA: 0x00008624 File Offset: 0x00006824
		public static Quaternion Multiply(Quaternion value1, Quaternion value2)
		{
			float x = value1.X;
			float y = value1.Y;
			float z = value1.Z;
			float w = value1.W;
			float x2 = value2.X;
			float y2 = value2.Y;
			float z2 = value2.Z;
			float w2 = value2.W;
			float num = y * z2 - z * y2;
			float num2 = z * x2 - x * z2;
			float num3 = x * y2 - y * x2;
			float num4 = x * x2 + y * y2 + z * z2;
			Quaternion result;
			result.X = x * w2 + x2 * w + num;
			result.Y = y * w2 + y2 * w + num2;
			result.Z = z * w2 + z2 * w + num3;
			result.W = w * w2 - num4;
			return result;
		}

		/// <summary>Возвращает кватернион, получаемый в результате масштабирования всех координат заданного кватерниона на скалярный множитель.</summary>
		/// <param name="value1">Исходный кватернион.</param>
		/// <param name="value2">Скалярное значение.</param>
		/// <returns>Масштабированный кватернион.</returns>
		// Token: 0x0600008D RID: 141 RVA: 0x000086EC File Offset: 0x000068EC
		public static Quaternion Multiply(Quaternion value1, float value2)
		{
			Quaternion result;
			result.X = value1.X * value2;
			result.Y = value1.Y * value2;
			result.Z = value1.Z * value2;
			result.W = value1.W * value2;
			return result;
		}

		/// <summary>Делит один кватернион на второй кватернион.</summary>
		/// <param name="value1">Делимое.</param>
		/// <param name="value2">Делитель.</param>
		/// <returns>Кватернион, полученный в результате деления <paramref name="value1" /> на <paramref name="value2" />.</returns>
		// Token: 0x0600008E RID: 142 RVA: 0x00008738 File Offset: 0x00006938
		public static Quaternion Divide(Quaternion value1, Quaternion value2)
		{
			float x = value1.X;
			float y = value1.Y;
			float z = value1.Z;
			float w = value1.W;
			float num = value2.X * value2.X + value2.Y * value2.Y + value2.Z * value2.Z + value2.W * value2.W;
			float num2 = 1f / num;
			float num3 = -value2.X * num2;
			float num4 = -value2.Y * num2;
			float num5 = -value2.Z * num2;
			float num6 = value2.W * num2;
			float num7 = y * num5 - z * num4;
			float num8 = z * num3 - x * num5;
			float num9 = x * num4 - y * num3;
			float num10 = x * num3 + y * num4 + z * num5;
			Quaternion result;
			result.X = x * num6 + num3 * w + num7;
			result.Y = y * num6 + num4 * w + num8;
			result.Z = z * num6 + num5 * w + num9;
			result.W = w * num6 - num10;
			return result;
		}

		/// <summary>Обращает знак каждой координаты кватерниона.</summary>
		/// <param name="value">Кватернион, преобразуемый в отрицательный.</param>
		/// <returns>Кватернион, преобразованный в отрицательный.</returns>
		// Token: 0x0600008F RID: 143 RVA: 0x00008854 File Offset: 0x00006A54
		public static Quaternion operator -(Quaternion value)
		{
			Quaternion result;
			result.X = -value.X;
			result.Y = -value.Y;
			result.Z = -value.Z;
			result.W = -value.W;
			return result;
		}

		/// <summary>Складывает каждый элемент в одном кватернионе с соответствующим элементом во втором кватернионе.</summary>
		/// <param name="value1">Первый кватернион.</param>
		/// <param name="value2">Второй кватернион.</param>
		/// <returns>Кватернион, содержащий суммарные значения <paramref name="value1" /> и <paramref name="value2" />.</returns>
		// Token: 0x06000090 RID: 144 RVA: 0x0000889C File Offset: 0x00006A9C
		public static Quaternion operator +(Quaternion value1, Quaternion value2)
		{
			Quaternion result;
			result.X = value1.X + value2.X;
			result.Y = value1.Y + value2.Y;
			result.Z = value1.Z + value2.Z;
			result.W = value1.W + value2.W;
			return result;
		}

		/// <summary>Вычитает каждый элемент во втором кватернионе из соответствующего элемента в первом кватернионе.</summary>
		/// <param name="value1">Первый кватернион.</param>
		/// <param name="value2">Второй кватернион.</param>
		/// <returns>Кватернион, содержащий значения, которые являются результатом вычитания каждого элемента в <paramref name="value2" /> из соответствующего элемента в <paramref name="value1" />.</returns>
		// Token: 0x06000091 RID: 145 RVA: 0x000088FC File Offset: 0x00006AFC
		public static Quaternion operator -(Quaternion value1, Quaternion value2)
		{
			Quaternion result;
			result.X = value1.X - value2.X;
			result.Y = value1.Y - value2.Y;
			result.Z = value1.Z - value2.Z;
			result.W = value1.W - value2.W;
			return result;
		}

		/// <summary>Возвращает кватернион, являющийся результатом перемножения двух кватернионов.</summary>
		/// <param name="value1">Первый кватернион.</param>
		/// <param name="value2">Второй кватернион.</param>
		/// <returns>Кватернион произведения.</returns>
		// Token: 0x06000092 RID: 146 RVA: 0x0000895C File Offset: 0x00006B5C
		public static Quaternion operator *(Quaternion value1, Quaternion value2)
		{
			float x = value1.X;
			float y = value1.Y;
			float z = value1.Z;
			float w = value1.W;
			float x2 = value2.X;
			float y2 = value2.Y;
			float z2 = value2.Z;
			float w2 = value2.W;
			float num = y * z2 - z * y2;
			float num2 = z * x2 - x * z2;
			float num3 = x * y2 - y * x2;
			float num4 = x * x2 + y * y2 + z * z2;
			Quaternion result;
			result.X = x * w2 + x2 * w + num;
			result.Y = y * w2 + y2 * w + num2;
			result.Z = z * w2 + z2 * w + num3;
			result.W = w * w2 - num4;
			return result;
		}

		/// <summary>Возвращает кватернион, получаемый в результате масштабирования всех координат заданного кватерниона на скалярный множитель.</summary>
		/// <param name="value1">Исходный кватернион.</param>
		/// <param name="value2">Скалярное значение.</param>
		/// <returns>Масштабированный кватернион.</returns>
		// Token: 0x06000093 RID: 147 RVA: 0x00008A24 File Offset: 0x00006C24
		public static Quaternion operator *(Quaternion value1, float value2)
		{
			Quaternion result;
			result.X = value1.X * value2;
			result.Y = value1.Y * value2;
			result.Z = value1.Z * value2;
			result.W = value1.W * value2;
			return result;
		}

		/// <summary>Делит один кватернион на второй кватернион.</summary>
		/// <param name="value1">Делимое.</param>
		/// <param name="value2">Делитель.</param>
		/// <returns>Кватернион, полученный в результате деления <paramref name="value1" /> на <paramref name="value2" />.</returns>
		// Token: 0x06000094 RID: 148 RVA: 0x00008A70 File Offset: 0x00006C70
		public static Quaternion operator /(Quaternion value1, Quaternion value2)
		{
			float x = value1.X;
			float y = value1.Y;
			float z = value1.Z;
			float w = value1.W;
			float num = value2.X * value2.X + value2.Y * value2.Y + value2.Z * value2.Z + value2.W * value2.W;
			float num2 = 1f / num;
			float num3 = -value2.X * num2;
			float num4 = -value2.Y * num2;
			float num5 = -value2.Z * num2;
			float num6 = value2.W * num2;
			float num7 = y * num5 - z * num4;
			float num8 = z * num3 - x * num5;
			float num9 = x * num4 - y * num3;
			float num10 = x * num3 + y * num4 + z * num5;
			Quaternion result;
			result.X = x * num6 + num3 * w + num7;
			result.Y = y * num6 + num4 * w + num8;
			result.Z = z * num6 + num5 * w + num9;
			result.W = w * num6 - num10;
			return result;
		}

		/// <summary>Возвращает значение, указывающее на равенство двух кватернионов.</summary>
		/// <param name="value1">Первый сравниваемый кватернион.</param>
		/// <param name="value2">Второй сравниваемый кватернион.</param>
		/// <returns>Значение <see langword="true" />, если два кватерниона равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000095 RID: 149 RVA: 0x00008B89 File Offset: 0x00006D89
		public static bool operator ==(Quaternion value1, Quaternion value2)
		{
			return value1.X == value2.X && value1.Y == value2.Y && value1.Z == value2.Z && value1.W == value2.W;
		}

		/// <summary>Возвращает значение, указывающее на неравенство двух кватернионов.</summary>
		/// <param name="value1">Первый сравниваемый кватернион.</param>
		/// <param name="value2">Второй сравниваемый кватернион.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value1" /> и <paramref name="value2" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000096 RID: 150 RVA: 0x00008BC5 File Offset: 0x00006DC5
		public static bool operator !=(Quaternion value1, Quaternion value2)
		{
			return value1.X != value2.X || value1.Y != value2.Y || value1.Z != value2.Z || value1.W != value2.W;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр другому кватерниону.</summary>
		/// <param name="other">Другой кватернион.</param>
		/// <returns>Значение <see langword="true" />, если два кватерниона равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000097 RID: 151 RVA: 0x00008B89 File Offset: 0x00006D89
		public bool Equals(Quaternion other)
		{
			return this.X == other.X && this.Y == other.Y && this.Z == other.Z && this.W == other.W;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />. Если значением параметра <paramref name="obj" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		// Token: 0x06000098 RID: 152 RVA: 0x00008C04 File Offset: 0x00006E04
		public override bool Equals(object obj)
		{
			return obj is Quaternion && this.Equals((Quaternion)obj);
		}

		/// <summary>Возвращает строку, представляющую данный кватернион.</summary>
		/// <returns>Строковое представление данного кватерниона.</returns>
		// Token: 0x06000099 RID: 153 RVA: 0x00008C1C File Offset: 0x00006E1C
		public override string ToString()
		{
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			return string.Format(currentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", new object[]
			{
				this.X.ToString(currentCulture),
				this.Y.ToString(currentCulture),
				this.Z.ToString(currentCulture),
				this.W.ToString(currentCulture)
			});
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код.</returns>
		// Token: 0x0600009A RID: 154 RVA: 0x00008C7C File Offset: 0x00006E7C
		public override int GetHashCode()
		{
			return this.X.GetHashCode() + this.Y.GetHashCode() + this.Z.GetHashCode() + this.W.GetHashCode();
		}

		/// <summary>Значение X координаты вектора кватерниона.</summary>
		// Token: 0x0400005E RID: 94
		public float X;

		/// <summary>Значение Y координаты вектора кватерниона.</summary>
		// Token: 0x0400005F RID: 95
		public float Y;

		/// <summary>Значение Z координаты вектора кватерниона.</summary>
		// Token: 0x04000060 RID: 96
		public float Z;

		/// <summary>Получает координату поворота кватерниона.</summary>
		// Token: 0x04000061 RID: 97
		public float W;
	}
}
