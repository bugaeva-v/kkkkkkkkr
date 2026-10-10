using System;
using System.Drawing.Internal;
using System.Runtime.InteropServices;

namespace System.Drawing.Drawing2D
{
	/// <summary>Предоставляет возможность перемещаться по субконтурам в объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> и проверять типы фигур, содержащихся в каждом субконтуре. Этот класс не наследуется.</summary>
	// Token: 0x02000140 RID: 320
	public sealed class GraphicsPathIterator : MarshalByRefObject, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.GraphicsPathIterator" /> с указанным объектом <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="path">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, для которого необходимо инициализировать данный вспомогательный класс.</param>
		// Token: 0x06000E2E RID: 3630 RVA: 0x00020148 File Offset: 0x0001E348
		public GraphicsPathIterator(GraphicsPath path)
		{
			IntPtr zero = IntPtr.Zero;
			int num = GDIPlus.GdipCreatePathIter(out zero, new HandleRef(path, (path == null) ? IntPtr.Zero : path.nativePath));
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			this.nativeIter = zero;
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Drawing2D.GraphicsPathIterator" />.</summary>
		// Token: 0x06000E2F RID: 3631 RVA: 0x00020190 File Offset: 0x0001E390
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000201A0 File Offset: 0x0001E3A0
		private void Dispose(bool disposing)
		{
			if (this.nativeIter != IntPtr.Zero)
			{
				try
				{
					GDIPlus.GdipDeletePathIter(new HandleRef(this, this.nativeIter));
				}
				catch (Exception ex)
				{
					if (ClientUtils.IsSecurityOrCriticalException(ex))
					{
						throw;
					}
				}
				finally
				{
					this.nativeIter = IntPtr.Zero;
				}
			}
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x06000E31 RID: 3633 RVA: 0x00020208 File Offset: 0x0001E408
		~GraphicsPathIterator()
		{
			this.Dispose(false);
		}

		/// <summary>Перемещает объект <see cref="T:System.Drawing.Drawing2D.GraphicsPathIterator" /> в следующий субконтур в контуре. Начальный и конечный индексы следующего субконтура содержатся в параметрах [out].</summary>
		/// <param name="startIndex">[out] Получает начальный индекс следующего субконтура.</param>
		/// <param name="endIndex">[out] Получает конечный индекс следующего субконтура.</param>
		/// <param name="isClosed">[out] Указывает, является ли субконтур замкнутым.</param>
		/// <returns>Количество субконтуров в объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</returns>
		// Token: 0x06000E32 RID: 3634 RVA: 0x00020238 File Offset: 0x0001E438
		public int NextSubpath(out int startIndex, out int endIndex, out bool isClosed)
		{
			int result;
			int num2;
			int num3;
			int num = GDIPlus.GdipPathIterNextSubpath(new HandleRef(this, this.nativeIter), out result, out num2, out num3, out isClosed);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			startIndex = num2;
			endIndex = num3;
			return result;
		}

		/// <summary>Получает следующую фигуру (субконтур) из контура, связанного с этим объектом <see cref="T:System.Drawing.Drawing2D.GraphicsPathIterator" />.</summary>
		/// <param name="path">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, данные о точках которого установлены в соответствии с данными о точках извлекаемой фигуры (субконтура) для данного итератора.</param>
		/// <param name="isClosed">[out] Указывает, является ли текущий субконтур замкнутым. Принимает значение <see langword="true" />, если фигура замкнута; в противном случае значение равно <see langword="false" />.</param>
		/// <returns>Количество точек данных в извлеченной фигуре (субконтуре). Если больше нет фигур для извлечения, возвращается значение нуль.</returns>
		// Token: 0x06000E33 RID: 3635 RVA: 0x00020270 File Offset: 0x0001E470
		public int NextSubpath(GraphicsPath path, out bool isClosed)
		{
			int result;
			int num = GDIPlus.GdipPathIterNextSubpathPath(new HandleRef(this, this.nativeIter), out result, new HandleRef(path, (path == null) ? IntPtr.Zero : path.nativePath), out isClosed);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			return result;
		}

		/// <summary>Получает начальный и конечный индексы следующей группы точек данных, имеющих один и тот же тип.</summary>
		/// <param name="pathType">[out] Получает тип точки, общий для всех точек в группе. Возможные типы могут быть извлечены из перечисления <see cref="T:System.Drawing.Drawing2D.PathPointType" />.</param>
		/// <param name="startIndex">[out] Получает начальный индекс группы точек.</param>
		/// <param name="endIndex">[out] Получает конечный индекс группы точек.</param>
		/// <returns>Данный метод возвращает количество точек данных в группе. Если в контуре нет больше групп, метод возвращает значение 0.</returns>
		// Token: 0x06000E34 RID: 3636 RVA: 0x000202B4 File Offset: 0x0001E4B4
		public int NextPathType(out byte pathType, out int startIndex, out int endIndex)
		{
			int result;
			int num = GDIPlus.GdipPathIterNextPathType(new HandleRef(this, this.nativeIter), out result, out pathType, out startIndex, out endIndex);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			return result;
		}

		/// <summary>Увеличивает объект <see cref="T:System.Drawing.Drawing2D.GraphicsPathIterator" /> до следующего маркера в контуре и возвращает начальный и конечный индексы в виде параметров [out].</summary>
		/// <param name="startIndex">[out] Ссылка на целое число, предоставляемая данному параметру, получает индекс точки, с которой начинается субконтур.</param>
		/// <param name="endIndex">[out] Ссылка на целое число, предоставляемая данному параметру, получает индекс точки, которой заканчивается субконтур, на который указывает <paramref name="startIndex" />.</param>
		/// <returns>Количество точек между этим и следующим маркерами.</returns>
		// Token: 0x06000E35 RID: 3637 RVA: 0x000202E4 File Offset: 0x0001E4E4
		public int NextMarker(out int startIndex, out int endIndex)
		{
			int result;
			int num = GDIPlus.GdipPathIterNextMarker(new HandleRef(this, this.nativeIter), out result, out startIndex, out endIndex);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			return result;
		}

		/// <summary>У этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPathIterator" /> имеется связанный с ним объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />. Метод <see cref="M:System.Drawing.Drawing2D.GraphicsPathIterator.NextMarker(System.Drawing.Drawing2D.GraphicsPath)" /> увеличивает связанный с ним объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> до следующего маркера в его контуре и копирует все точки, содержащиеся между текущим и следующим маркерами (или концом контура), во второй объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, переданный в параметр.</summary>
		/// <param name="path">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, в который будут скопированы точки.</param>
		/// <returns>Количество точек между этим и следующим маркерами.</returns>
		// Token: 0x06000E36 RID: 3638 RVA: 0x00020314 File Offset: 0x0001E514
		public int NextMarker(GraphicsPath path)
		{
			int result;
			int num = GDIPlus.GdipPathIterNextMarkerPath(new HandleRef(this, this.nativeIter), out result, new HandleRef(path, (path == null) ? IntPtr.Zero : path.nativePath));
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			return result;
		}

		/// <summary>Получает количество точек в контуре.</summary>
		/// <returns>Количество точек в контуре.</returns>
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00020358 File Offset: 0x0001E558
		public int Count
		{
			get
			{
				int result;
				int num = GDIPlus.GdipPathIterGetCount(new HandleRef(this, this.nativeIter), out result);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
				return result;
			}
		}

		/// <summary>Получает количество субконтуров в контуре.</summary>
		/// <returns>Количество субконтуров в контуре.</returns>
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00020384 File Offset: 0x0001E584
		public int SubpathCount
		{
			get
			{
				int result;
				int num = GDIPlus.GdipPathIterGetSubpathCount(new HandleRef(this, this.nativeIter), out result);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
				return result;
			}
		}

		/// <summary>Определяет, содержит ли контур, связанный с этим объектом <see cref="T:System.Drawing.Drawing2D.GraphicsPathIterator" />, кривую.</summary>
		/// <returns>Метод возвращает значение <see langword="true" />, если текущий субконтур содержит кривую; в противном случае он возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000E39 RID: 3641 RVA: 0x000203B0 File Offset: 0x0001E5B0
		public bool HasCurve()
		{
			bool result;
			int num = GDIPlus.GdipPathIterHasCurve(new HandleRef(this, this.nativeIter), out result);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			return result;
		}

		/// <summary>Перематывает этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPathIterator" /> на начало связанного с ним контура.</summary>
		// Token: 0x06000E3A RID: 3642 RVA: 0x000203DC File Offset: 0x0001E5DC
		public void Rewind()
		{
			int num = GDIPlus.GdipPathIterRewind(new HandleRef(this, this.nativeIter));
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Копирует свойство <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathPoints" /> и массивы свойств <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathTypes" /> связанного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> в два указанных массива.</summary>
		/// <param name="points">По возвращении содержит массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки в контуре.</param>
		/// <param name="types">По возвращении содержит массив байтов, представляющий типы точек в контуре.</param>
		/// <returns>Число скопированных точек.</returns>
		// Token: 0x06000E3B RID: 3643 RVA: 0x00020408 File Offset: 0x0001E608
		public int Enumerate(ref PointF[] points, ref byte[] types)
		{
			if (points.Length != types.Length)
			{
				throw SafeNativeMethods.Gdip.StatusException(2);
			}
			int num = 0;
			int num2 = Marshal.SizeOf(typeof(GPPOINTF));
			int num3 = points.Length;
			byte[] array = new byte[num3];
			IntPtr intPtr = Marshal.AllocHGlobal(checked(num3 * num2));
			try
			{
				int num4 = GDIPlus.GdipPathIterEnumerate(new HandleRef(this, this.nativeIter), out num, intPtr, array, num3);
				if (num4 != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num4);
				}
				if (num < num3)
				{
					SafeNativeMethods.ZeroMemory(checked((long)intPtr + num * num2), (ulong)((long)((num3 - num) * num2)));
				}
				points = SafeNativeMethods.Gdip.ConvertGPPOINTFArrayF(intPtr, num3);
				array.CopyTo(types, 0);
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return num;
		}

		/// <summary>Копирует свойство <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathPoints" /> и массивы свойств <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathTypes" /> связанного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> в два указанных массива.</summary>
		/// <param name="points">По возвращении содержит массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки в контуре.</param>
		/// <param name="types">По возвращении содержит массив байтов, представляющий типы точек в контуре.</param>
		/// <param name="startIndex">Указывает начальный индекс массивов.</param>
		/// <param name="endIndex">Указывает конечный индекс массивов.</param>
		/// <returns>Число скопированных точек.</returns>
		// Token: 0x06000E3C RID: 3644 RVA: 0x000204C0 File Offset: 0x0001E6C0
		public int CopyData(ref PointF[] points, ref byte[] types, int startIndex, int endIndex)
		{
			if (points.Length != types.Length || endIndex - startIndex + 1 > points.Length)
			{
				throw SafeNativeMethods.Gdip.StatusException(2);
			}
			int num = 0;
			int num2 = Marshal.SizeOf(typeof(GPPOINTF));
			int num3 = points.Length;
			byte[] array = new byte[num3];
			IntPtr intPtr = Marshal.AllocHGlobal(checked(num3 * num2));
			try
			{
				int num4 = GDIPlus.GdipPathIterCopyData(new HandleRef(this, this.nativeIter), out num, intPtr, array, startIndex, endIndex);
				if (num4 != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num4);
				}
				if (num < num3)
				{
					SafeNativeMethods.ZeroMemory(checked((long)intPtr + num * num2), (ulong)((long)((num3 - num) * num2)));
				}
				points = SafeNativeMethods.Gdip.ConvertGPPOINTFArrayF(intPtr, num3);
				array.CopyTo(types, 0);
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return num;
		}

		// Token: 0x04000AE1 RID: 2785
		internal IntPtr nativeIter;
	}
}
