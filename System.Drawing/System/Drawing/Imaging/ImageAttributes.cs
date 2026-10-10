using System;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Drawing.Imaging
{
	/// <summary>Содержит сведения о том, каким образом обрабатываются цвета точечных рисунков и метафайлов во время отрисовки.</summary>
	// Token: 0x02000107 RID: 263
	[StructLayout(LayoutKind.Sequential)]
	public sealed class ImageAttributes : ICloneable, IDisposable
	{
		// Token: 0x06000C7C RID: 3196 RVA: 0x0001D270 File Offset: 0x0001B470
		internal void SetNativeImageAttributes(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException("handle");
			}
			this.nativeImageAttributes = handle;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Imaging.ImageAttributes" />.</summary>
		// Token: 0x06000C7D RID: 3197 RVA: 0x0001D294 File Offset: 0x0001B494
		public ImageAttributes()
		{
			IntPtr zero = IntPtr.Zero;
			int num = GDIPlus.GdipCreateImageAttributes(out zero);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			this.SetNativeImageAttributes(zero);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0001D2C6 File Offset: 0x0001B4C6
		internal ImageAttributes(IntPtr newNativeImageAttributes)
		{
			this.SetNativeImageAttributes(newNativeImageAttributes);
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Imaging.ImageAttributes" />.</summary>
		// Token: 0x06000C7F RID: 3199 RVA: 0x0001D2D5 File Offset: 0x0001B4D5
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		private void Dispose(bool disposing)
		{
			if (this.nativeImageAttributes != IntPtr.Zero)
			{
				try
				{
					GDIPlus.GdipDisposeImageAttributes(new HandleRef(this, this.nativeImageAttributes));
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
					this.nativeImageAttributes = IntPtr.Zero;
				}
			}
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x06000C81 RID: 3201 RVA: 0x0001D34C File Offset: 0x0001B54C
		~ImageAttributes()
		{
			this.Dispose(false);
		}

		/// <summary>Создает точную копию объекта <see cref="T:System.Drawing.Imaging.ImageAttributes" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, который создает этот класс, приводя как объект.</returns>
		// Token: 0x06000C82 RID: 3202 RVA: 0x0001D37C File Offset: 0x0001B57C
		public object Clone()
		{
			IntPtr zero = IntPtr.Zero;
			int num = GDIPlus.GdipCloneImageAttributes(new HandleRef(this, this.nativeImageAttributes), out zero);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			return new ImageAttributes(zero);
		}

		/// <summary>Задает матрицу настройки цвета для категории по умолчанию.</summary>
		/// <param name="newColorMatrix">Матрица настройки цвета.</param>
		// Token: 0x06000C83 RID: 3203 RVA: 0x0001D3B3 File Offset: 0x0001B5B3
		public void SetColorMatrix(ColorMatrix newColorMatrix)
		{
			this.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Default);
		}

		/// <summary>Задает матрицу настройки цвета для категории по умолчанию.</summary>
		/// <param name="newColorMatrix">Матрица настройки цвета.</param>
		/// <param name="flags">Элемент <see cref="T:System.Drawing.Imaging.ColorMatrixFlag" />, определяющий тип изображения и цвет, на которые будет влиять матрица настройки цвета.</param>
		// Token: 0x06000C84 RID: 3204 RVA: 0x0001D3BE File Offset: 0x0001B5BE
		public void SetColorMatrix(ColorMatrix newColorMatrix, ColorMatrixFlag flags)
		{
			this.SetColorMatrix(newColorMatrix, flags, ColorAdjustType.Default);
		}

		/// <summary>Задает матрицу настройки цвета для указанной категории.</summary>
		/// <param name="newColorMatrix">Матрица настройки цвета.</param>
		/// <param name="mode">Элемент <see cref="T:System.Drawing.Imaging.ColorMatrixFlag" />, определяющий тип изображения и цвет, на которые будет влиять матрица настройки цвета.</param>
		/// <param name="type">Элемент <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой задается матрица настройки цвета.</param>
		// Token: 0x06000C85 RID: 3205 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		public void SetColorMatrix(ColorMatrix newColorMatrix, ColorMatrixFlag mode, ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesColorMatrix(new HandleRef(this, this.nativeImageAttributes), type, true, newColorMatrix, null, mode);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Очищает матрицу настройки цвета для категории по умолчанию.</summary>
		// Token: 0x06000C86 RID: 3206 RVA: 0x0001D3FA File Offset: 0x0001B5FA
		public void ClearColorMatrix()
		{
			this.ClearColorMatrix(ColorAdjustType.Default);
		}

		/// <summary>Очищает матрицу настройки цвета для определенной категории.</summary>
		/// <param name="type">Элемент перечисления <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, определяющий категорию, для которой очищается матрица настройки цвета.</param>
		// Token: 0x06000C87 RID: 3207 RVA: 0x0001D404 File Offset: 0x0001B604
		public void ClearColorMatrix(ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesColorMatrix(new HandleRef(this, this.nativeImageAttributes), type, false, null, null, ColorMatrixFlag.Default);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Задает матрицу настройки цвета и матрицу настройки оттенков серого для категории по умолчанию.</summary>
		/// <param name="newColorMatrix">Матрица настройки цвета.</param>
		/// <param name="grayMatrix">Матрица настройки оттенков серого.</param>
		// Token: 0x06000C88 RID: 3208 RVA: 0x0001D432 File Offset: 0x0001B632
		public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix)
		{
			this.SetColorMatrices(newColorMatrix, grayMatrix, ColorMatrixFlag.Default, ColorAdjustType.Default);
		}

		/// <summary>Задает матрицу настройки цвета и матрицу настройки оттенков серого для категории по умолчанию.</summary>
		/// <param name="newColorMatrix">Матрица настройки цвета.</param>
		/// <param name="grayMatrix">Матрица настройки оттенков серого.</param>
		/// <param name="flags">Элемент <see cref="T:System.Drawing.Imaging.ColorMatrixFlag" />, определяющий тип изображения и цвет, на которые будут влиять матрицы настройки цвета и оттенков серого.</param>
		// Token: 0x06000C89 RID: 3209 RVA: 0x0001D43E File Offset: 0x0001B63E
		public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix, ColorMatrixFlag flags)
		{
			this.SetColorMatrices(newColorMatrix, grayMatrix, flags, ColorAdjustType.Default);
		}

		/// <summary>Задает матрицу настройки цвета и матрицу настройки оттенков серого для указанной категории.</summary>
		/// <param name="newColorMatrix">Матрица настройки цвета.</param>
		/// <param name="grayMatrix">Матрица настройки оттенков серого.</param>
		/// <param name="mode">Элемент <see cref="T:System.Drawing.Imaging.ColorMatrixFlag" />, определяющий тип изображения и цвет, на которые будут влиять матрицы настройки цвета и оттенков серого.</param>
		/// <param name="type">Элемент <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой устанавливается матрица настройки цвета и матрица настройки оттенков серого.</param>
		// Token: 0x06000C8A RID: 3210 RVA: 0x0001D44C File Offset: 0x0001B64C
		public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix, ColorMatrixFlag mode, ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesColorMatrix(new HandleRef(this, this.nativeImageAttributes), type, true, newColorMatrix, grayMatrix, mode);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Задает пороговое значение (диапазон прозрачности) для категории по умолчанию.</summary>
		/// <param name="threshold">Вещественное число, задающее пороговое значение.</param>
		// Token: 0x06000C8B RID: 3211 RVA: 0x0001D47B File Offset: 0x0001B67B
		public void SetThreshold(float threshold)
		{
			this.SetThreshold(threshold, ColorAdjustType.Default);
		}

		/// <summary>Задает пороговое значение (диапазон прозрачности) для указанной категории.</summary>
		/// <param name="threshold">Пороговое значение в диапазоне от 0,0 до 1,0, используемое в качестве контрольной точки для сортировки цветов, которые будут преобразованы либо в максимальное, либо в минимальное значение.</param>
		/// <param name="type">Элемент <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой задается пороговое значение цвета.</param>
		// Token: 0x06000C8C RID: 3212 RVA: 0x0001D488 File Offset: 0x0001B688
		public void SetThreshold(float threshold, ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesThreshold(new HandleRef(this, this.nativeImageAttributes), type, true, threshold);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Очищает пороговое значение для категории по умолчанию.</summary>
		// Token: 0x06000C8D RID: 3213 RVA: 0x0001D4B4 File Offset: 0x0001B6B4
		public void ClearThreshold()
		{
			this.ClearThreshold(ColorAdjustType.Default);
		}

		/// <summary>Очищает пороговое значение для определенной категории.</summary>
		/// <param name="type">Элемент типа <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой очищается пороговое значение.</param>
		// Token: 0x06000C8E RID: 3214 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
		public void ClearThreshold(ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesThreshold(new HandleRef(this, this.nativeImageAttributes), type, false, 0f);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Задает гамма-значение для категории по умолчанию.</summary>
		/// <param name="gamma">Значение гамма-коррекции.</param>
		// Token: 0x06000C8F RID: 3215 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		public void SetGamma(float gamma)
		{
			this.SetGamma(gamma, ColorAdjustType.Default);
		}

		/// <summary>Задает гамма-значение для определенной категории.</summary>
		/// <param name="gamma">Значение гамма-коррекции.</param>
		/// <param name="type">Элемент перечисления <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, определяющий категорию, для которой задается гамма-значение.</param>
		// Token: 0x06000C90 RID: 3216 RVA: 0x0001D4FC File Offset: 0x0001B6FC
		public void SetGamma(float gamma, ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesGamma(new HandleRef(this, this.nativeImageAttributes), type, true, gamma);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Отключает гамма-коррекцию для категории по умолчанию.</summary>
		// Token: 0x06000C91 RID: 3217 RVA: 0x0001D528 File Offset: 0x0001B728
		public void ClearGamma()
		{
			this.ClearGamma(ColorAdjustType.Default);
		}

		/// <summary>Отключает гамма-коррекцию для определенной категории.</summary>
		/// <param name="type">Элемент перечисления <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, определяющий категорию, для которой отключается гамма-коррекция.</param>
		// Token: 0x06000C92 RID: 3218 RVA: 0x0001D534 File Offset: 0x0001B734
		public void ClearGamma(ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesGamma(new HandleRef(this, this.nativeImageAttributes), type, false, 0f);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Отключает настройку цвета для категории по умолчанию. Можно вызвать метод <see cref="Overload:System.Drawing.Imaging.ImageAttributes.ClearNoOp" />, чтобы восстановить параметры настройки цвета, использовавшиеся до вызова метода <see cref="Overload:System.Drawing.Imaging.ImageAttributes.SetNoOp" />.</summary>
		// Token: 0x06000C93 RID: 3219 RVA: 0x0001D564 File Offset: 0x0001B764
		public void SetNoOp()
		{
			this.SetNoOp(ColorAdjustType.Default);
		}

		/// <summary>Отключает настройку цвета для определенной категории. Можно вызвать метод <see cref="Overload:System.Drawing.Imaging.ImageAttributes.ClearNoOp" />, чтобы восстановить параметры настройки цвета, использовавшиеся до вызова метода <see cref="Overload:System.Drawing.Imaging.ImageAttributes.SetNoOp" />.</summary>
		/// <param name="type">Элемент <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой отключается цветовая коррекция.</param>
		// Token: 0x06000C94 RID: 3220 RVA: 0x0001D570 File Offset: 0x0001B770
		public void SetNoOp(ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesNoOp(new HandleRef(this, this.nativeImageAttributes), type, true);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Очищает параметр <see langword="NoOp" /> для категории по умолчанию.</summary>
		// Token: 0x06000C95 RID: 3221 RVA: 0x0001D59B File Offset: 0x0001B79B
		public void ClearNoOp()
		{
			this.ClearNoOp(ColorAdjustType.Default);
		}

		/// <summary>Очищает параметр <see langword="NoOp" /> для указанной категории.</summary>
		/// <param name="type">Элемент типа <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой очищается параметр <see langword="NoOp" />.</param>
		// Token: 0x06000C96 RID: 3222 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
		public void ClearNoOp(ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesNoOp(new HandleRef(this, this.nativeImageAttributes), type, false);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Задает цветовой ключ для категории по умолчанию.</summary>
		/// <param name="colorLow">Низкое значение цветового ключа.</param>
		/// <param name="colorHigh">Высокое значение цветового ключа.</param>
		// Token: 0x06000C97 RID: 3223 RVA: 0x0001D5CF File Offset: 0x0001B7CF
		public void SetColorKey(Color colorLow, Color colorHigh)
		{
			this.SetColorKey(colorLow, colorHigh, ColorAdjustType.Default);
		}

		/// <summary>Задает цветовой ключ (диапазон прозрачности) для определенной категории.</summary>
		/// <param name="colorLow">Низкое значение цветового ключа.</param>
		/// <param name="colorHigh">Высокое значение цветового ключа.</param>
		/// <param name="type">Элемент <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, определяющий категорию, для которой устанавливается цветовой ключ.</param>
		// Token: 0x06000C98 RID: 3224 RVA: 0x0001D5DC File Offset: 0x0001B7DC
		public void SetColorKey(Color colorLow, Color colorHigh, ColorAdjustType type)
		{
			int colorLow2 = colorLow.ToArgb();
			int colorHigh2 = colorHigh.ToArgb();
			int num = GDIPlus.GdipSetImageAttributesColorKeys(new HandleRef(this, this.nativeImageAttributes), type, true, colorLow2, colorHigh2);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Очищает цветовой ключ (диапазон прозрачности) для категории по умолчанию.</summary>
		// Token: 0x06000C99 RID: 3225 RVA: 0x0001D619 File Offset: 0x0001B819
		public void ClearColorKey()
		{
			this.ClearColorKey(ColorAdjustType.Default);
		}

		/// <summary>Очищает цветовой ключ (диапазон прозрачности) для указанной категории.</summary>
		/// <param name="type">Элемент типа <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, задающий категорию, для которой очищается цветовой ключ.</param>
		// Token: 0x06000C9A RID: 3226 RVA: 0x0001D624 File Offset: 0x0001B824
		public void ClearColorKey(ColorAdjustType type)
		{
			int num = 0;
			int num2 = GDIPlus.GdipSetImageAttributesColorKeys(new HandleRef(this, this.nativeImageAttributes), type, false, num, num);
			if (num2 != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num2);
			}
		}

		/// <summary>Устанавливает выходной канал CMYK (cyan-magenta-yellow-black или голубой-пурпурный-желтый-черный) для категории по умолчанию.</summary>
		/// <param name="flags">Элемент <see cref="T:System.Drawing.Imaging.ColorChannelFlag" />, который задает выходной канал.</param>
		// Token: 0x06000C9B RID: 3227 RVA: 0x0001D653 File Offset: 0x0001B853
		public void SetOutputChannel(ColorChannelFlag flags)
		{
			this.SetOutputChannel(flags, ColorAdjustType.Default);
		}

		/// <summary>Устанавливает выходной канал CMYK (cyan-magenta-yellow-black или голубой-пурпурный-желтый-черный) для указанной категории.</summary>
		/// <param name="flags">Элемент <see cref="T:System.Drawing.Imaging.ColorChannelFlag" />, который задает выходной канал.</param>
		/// <param name="type">Элемент <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой задается выходной канал.</param>
		// Token: 0x06000C9C RID: 3228 RVA: 0x0001D660 File Offset: 0x0001B860
		public void SetOutputChannel(ColorChannelFlag flags, ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesOutputChannel(new HandleRef(this, this.nativeImageAttributes), type, true, flags);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Очищает параметр CMYK (cyan-magenta-yellow-black или голубой-пурпурный-желтый-черный) выходного канала для категории по умолчанию.</summary>
		// Token: 0x06000C9D RID: 3229 RVA: 0x0001D68C File Offset: 0x0001B88C
		public void ClearOutputChannel()
		{
			this.ClearOutputChannel(ColorAdjustType.Default);
		}

		/// <summary>Очищает параметр CMYK (cyan-magenta-yellow-black или голубой-пурпурный-желтый-черный) выходного канала  для указанной категории.</summary>
		/// <param name="type">Элемент типа <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой очищается параметр выходного канала.</param>
		// Token: 0x06000C9E RID: 3230 RVA: 0x0001D698 File Offset: 0x0001B898
		public void ClearOutputChannel(ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesOutputChannel(new HandleRef(this, this.nativeImageAttributes), type, false, ColorChannelFlag.ColorChannelLast);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Задает файл цветового профиля выходного канала для категории по умолчанию.</summary>
		/// <param name="colorProfileFilename">Имя пути к файлу цветового профиля. Если файл цветового профиля находится в каталоге %SystemRoot%\System32\Spool\Drivers\Color, то этим параметром может быть имя файла. В противном случае этот параметр должен быть полным путем к файлу.</param>
		// Token: 0x06000C9F RID: 3231 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
		public void SetOutputChannelColorProfile(string colorProfileFilename)
		{
			this.SetOutputChannelColorProfile(colorProfileFilename, ColorAdjustType.Default);
		}

		/// <summary>Задает файл цветового профиля выходного канала для указанной категории.</summary>
		/// <param name="colorProfileFilename">Имя пути к файлу цветового профиля. Если файл цветового профиля находится в каталоге %SystemRoot%\System32\Spool\Drivers\Color, то этим параметром может быть имя файла. В противном случае этот параметр должен быть полным путем к файлу.</param>
		/// <param name="type">Элемент перечисления <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, определяющий категорию, для которой задан файл цветового профиля канала вывода.</param>
		// Token: 0x06000CA0 RID: 3232 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
		public void SetOutputChannelColorProfile(string colorProfileFilename, ColorAdjustType type)
		{
			Path.GetFullPath(colorProfileFilename);
			int num = GDIPlus.GdipSetImageAttributesOutputChannelColorProfile(new HandleRef(this, this.nativeImageAttributes), type, true, colorProfileFilename);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Очищает настройку цветового профиля выходного канала для категории по умолчанию.</summary>
		// Token: 0x06000CA1 RID: 3233 RVA: 0x0001D68C File Offset: 0x0001B88C
		public void ClearOutputChannelColorProfile()
		{
			this.ClearOutputChannel(ColorAdjustType.Default);
		}

		/// <summary>Очищает настройку цветового профиля выходного канала для указанной категории.</summary>
		/// <param name="type">Элемент перечисления <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, определяющий категорию, для которой очищается параметр профиля канала вывода.</param>
		// Token: 0x06000CA2 RID: 3234 RVA: 0x0001D704 File Offset: 0x0001B904
		public void ClearOutputChannelColorProfile(ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesOutputChannel(new HandleRef(this, this.nativeImageAttributes), type, false, ColorChannelFlag.ColorChannelLast);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Задает таблицу преобразования цветов для категории по умолчанию.</summary>
		/// <param name="map">Массив пар цветов типа <see cref="T:System.Drawing.Imaging.ColorMap" />. Каждая пара цветов содержит существующий цвет (первое значение) и цвет, с которым он будет сопоставлен (второе значение).</param>
		// Token: 0x06000CA3 RID: 3235 RVA: 0x0001D730 File Offset: 0x0001B930
		public void SetRemapTable(ColorMap[] map)
		{
			this.SetRemapTable(map, ColorAdjustType.Default);
		}

		/// <summary>Задает таблицу преобразования цветов для определенной категории.</summary>
		/// <param name="map">Массив пар цветов типа <see cref="T:System.Drawing.Imaging.ColorMap" />. Каждая пара цветов содержит существующий цвет (первое значение) и цвет, с которым он будет сопоставлен (второе значение).</param>
		/// <param name="type">Элемент <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой задается таблица преобразования цветов.</param>
		// Token: 0x06000CA4 RID: 3236 RVA: 0x0001D73C File Offset: 0x0001B93C
		public void SetRemapTable(ColorMap[] map, ColorAdjustType type)
		{
			int num = map.Length;
			int num2 = 4;
			IntPtr intPtr = Marshal.AllocHGlobal(checked(num * num2 * 2));
			try
			{
				for (int i = 0; i < num; i++)
				{
					Marshal.StructureToPtr<int>(map[i].OldColor.ToArgb(), (IntPtr)((long)intPtr + (long)(i * num2 * 2)), false);
					Marshal.StructureToPtr<int>(map[i].NewColor.ToArgb(), (IntPtr)((long)intPtr + (long)(i * num2 * 2) + (long)num2), false);
				}
				int num3 = GDIPlus.GdipSetImageAttributesRemapTable(new HandleRef(this, this.nativeImageAttributes), type, true, num, new HandleRef(null, intPtr));
				if (num3 != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num3);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}

		/// <summary>Очищает таблицу преобразования цветов для категории по умолчанию.</summary>
		// Token: 0x06000CA5 RID: 3237 RVA: 0x0001D800 File Offset: 0x0001BA00
		public void ClearRemapTable()
		{
			this.ClearRemapTable(ColorAdjustType.Default);
		}

		/// <summary>Очищает таблицу преобразования цветов для указанной категории.</summary>
		/// <param name="type">Элемент типа <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, указывающий категорию, для которой очищается таблица преобразования цветов.</param>
		// Token: 0x06000CA6 RID: 3238 RVA: 0x0001D80C File Offset: 0x0001BA0C
		public void ClearRemapTable(ColorAdjustType type)
		{
			int num = GDIPlus.GdipSetImageAttributesRemapTable(new HandleRef(this, this.nativeImageAttributes), type, false, 0, NativeMethods.NullHandleRef);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Задает таблицу преобразования цветов для категории кистей.</summary>
		/// <param name="map">Массив объектов <see cref="T:System.Drawing.Imaging.ColorMap" />.</param>
		// Token: 0x06000CA7 RID: 3239 RVA: 0x0001D83D File Offset: 0x0001BA3D
		public void SetBrushRemapTable(ColorMap[] map)
		{
			this.SetRemapTable(map, ColorAdjustType.Brush);
		}

		/// <summary>Очищает таблицу преобразования цветов кисти этого объекта <see cref="T:System.Drawing.Imaging.ImageAttributes" />.</summary>
		// Token: 0x06000CA8 RID: 3240 RVA: 0x0001D847 File Offset: 0x0001BA47
		public void ClearBrushRemapTable()
		{
			this.ClearRemapTable(ColorAdjustType.Brush);
		}

		/// <summary>Задает режим переноса, который используется для принятия решения о способе печати текстуры по всей фигуре или на границах фигуры. Текстура накладывается по всей фигуре, заполняя ее, если текстура меньше заполняемой фигуры.</summary>
		/// <param name="mode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.WrapMode" />, который определяет, как повторяющиеся копии изображения используются для мозаичного заполнения области.</param>
		// Token: 0x06000CA9 RID: 3241 RVA: 0x0001D850 File Offset: 0x0001BA50
		public void SetWrapMode(WrapMode mode)
		{
			this.SetWrapMode(mode, default(Color), false);
		}

		/// <summary>Задает режим переноса и цвет, которые используются для определения метода мозаичного наложения текстуры: по всей фигуре или на краях фигуры. Текстура накладывается по всей фигуре, заполняя ее, если текстура меньше заполняемой фигуры.</summary>
		/// <param name="mode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.WrapMode" />, который определяет, как повторяющиеся копии изображения используются для мозаичного заполнения области.</param>
		/// <param name="color">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, определяющий цвет пикселей за пределами отрисованного изображения. Данный цвет является видимым, если для параметра режима установлено значение <see cref="F:System.Drawing.Drawing2D.WrapMode.Clamp" />, и исходный прямоугольник, переданный в <see cref="Overload:System.Drawing.Graphics.DrawImage" />, больше самого изображения.</param>
		// Token: 0x06000CAA RID: 3242 RVA: 0x0001D86E File Offset: 0x0001BA6E
		public void SetWrapMode(WrapMode mode, Color color)
		{
			this.SetWrapMode(mode, color, false);
		}

		/// <summary>Задает режим переноса и цвет, которые используются для определения метода мозаичного наложения текстуры: по всей фигуре или на краях фигуры. Текстура накладывается по всей фигуре, заполняя ее, если текстура меньше заполняемой фигуры.</summary>
		/// <param name="mode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.WrapMode" />, который определяет, как повторяющиеся копии изображения используются для мозаичного заполнения области.</param>
		/// <param name="color">Цветовой объект, определяющий цвет пикселей за пределами отрисованного изображения. Данный цвет является видимым, если для параметра режима установлено значение <see cref="F:System.Drawing.Drawing2D.WrapMode.Clamp" />, и исходный прямоугольник, переданный в <see cref="Overload:System.Drawing.Graphics.DrawImage" />, больше самого изображения.</param>
		/// <param name="clamp">Данный параметр не оказывает влияния. Задайте для него значение <see langword="false" />.</param>
		// Token: 0x06000CAB RID: 3243 RVA: 0x0001D87C File Offset: 0x0001BA7C
		public void SetWrapMode(WrapMode mode, Color color, bool clamp)
		{
			int num = GDIPlus.GdipSetImageAttributesWrapMode(new HandleRef(this, this.nativeImageAttributes), (int)mode, color.ToArgb(), clamp);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Настраивает цвета в палитре согласно параметрам настройки указанной категории.</summary>
		/// <param name="palette">Объект <see cref="T:System.Drawing.Imaging.ColorPalette" />, во входных данных которого содержится палитра для настройки, а в выходных данных — настроенная палитра.</param>
		/// <param name="type">Элемент перечисления <see cref="T:System.Drawing.Imaging.ColorAdjustType" />, определяющий категорию, параметры настройки которой будут применены к палитре.</param>
		// Token: 0x06000CAC RID: 3244 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		public void GetAdjustedPalette(ColorPalette palette, ColorAdjustType type)
		{
			IntPtr intPtr = palette.ConvertToMemory();
			try
			{
				int num = GDIPlus.GdipGetImageAttributesAdjustedPalette(new HandleRef(this, this.nativeImageAttributes), new HandleRef(null, intPtr), type);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
				palette.ConvertFromMemory(intPtr);
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
		}

		// Token: 0x040009AA RID: 2474
		internal IntPtr nativeImageAttributes;
	}
}
