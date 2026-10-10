using System;
using System.IO;
using System.Reflection;

namespace System.Drawing
{
	/// <summary>Позволяет задать значок для представления элемента управления в контейнере, таком как конструктор форм Microsoft Visual Studio.</summary>
	// Token: 0x0200008E RID: 142
	[AttributeUsage(AttributeTargets.Class)]
	public class ToolboxBitmapAttribute : Attribute
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00002064 File Offset: 0x00000264
		private ToolboxBitmapAttribute()
		{
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.ToolboxBitmapAttribute" />, используя изображение из указанного файла.</summary>
		/// <param name="imageFile">Имя файла, содержащего точечный рисунок размером 16 x 16.</param>
		// Token: 0x060007AB RID: 1963 RVA: 0x00002064 File Offset: 0x00000264
		public ToolboxBitmapAttribute(string imageFile)
		{
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> на основе точечного рисунка с размерами 16 x 16, внедренного как ресурс в указанную сборку.</summary>
		/// <param name="t">Тип <see cref="T:System.Type" />, определенный в сборке, используемой для поиска ресурса точечного рисунка.</param>
		// Token: 0x060007AC RID: 1964 RVA: 0x00016760 File Offset: 0x00014960
		public ToolboxBitmapAttribute(Type t)
		{
			this.smallImage = ToolboxBitmapAttribute.GetImageFromResource(t, null, false);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> на основе точечного рисунка с размерами 16 x 16, внедренного как ресурс в указанную сборку.</summary>
		/// <param name="t">Тип <see cref="T:System.Type" />, определенный в сборке, используемой для поиска ресурса точечного рисунка.</param>
		/// <param name="name">Имя внедренного ресурса точечного рисунка.</param>
		// Token: 0x060007AD RID: 1965 RVA: 0x00016776 File Offset: 0x00014976
		public ToolboxBitmapAttribute(Type t, string name)
		{
			this.smallImage = ToolboxBitmapAttribute.GetImageFromResource(t, name, false);
		}

		/// <summary>Показывает, является ли заданный объект объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />, идентичным этому объекту <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если <paramref name="value" /> одновременно является объектом<see cref="T:System.Drawing.ToolboxBitmapAttribute" />, идентичным этому объекту <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</returns>
		// Token: 0x060007AE RID: 1966 RVA: 0x0001678C File Offset: 0x0001498C
		public override bool Equals(object value)
		{
			return value is ToolboxBitmapAttribute && (value == this || ((ToolboxBitmapAttribute)value).smallImage == this.smallImage);
		}

		/// <summary>Получает хэш-код для объекта <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</summary>
		/// <returns>Хэш-код для этого объекта <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</returns>
		// Token: 0x060007AF RID: 1967 RVA: 0x000167B1 File Offset: 0x000149B1
		public override int GetHashCode()
		{
			return this.smallImage.GetHashCode() ^ this.bigImage.GetHashCode();
		}

		/// <summary>Возвращает мелкое изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</summary>
		/// <param name="component">Если у объекта <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> отсутствует мелкое изображение, этот метод осуществляет поиск ресурса точечного рисунка в сборке, определяющей тип объекта, указанный параметром компонента. Например, если объект типа ControlA передан параметру компонента, метод выполняет поиск в сборке, определяющей тип ControlA.</param>
		/// <returns>Мелкое изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</returns>
		// Token: 0x060007B0 RID: 1968 RVA: 0x000167CA File Offset: 0x000149CA
		public Image GetImage(object component)
		{
			return this.GetImage(component.GetType(), null, false);
		}

		/// <summary>Получает мелкое или крупное изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</summary>
		/// <param name="component">Если у объекта <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> отсутствует мелкое изображение, этот метод осуществляет поиск ресурса точечного рисунка в сборке, определяющей тип объекта, указанный параметром компонента. Например, если объект типа ControlA передан параметру компонента, метод выполняет поиск в сборке, определяющей тип ControlA.</param>
		/// <param name="large">Определяет, возвращает ли метод крупное (<see langword="true" />) или мелкое изображение (<see langword="false" />). Мелкое изображение имеет размер 16 x 16, крупное — 32 x 32 точки.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Image" />, связанный с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</returns>
		// Token: 0x060007B1 RID: 1969 RVA: 0x000167DA File Offset: 0x000149DA
		public Image GetImage(object component, bool large)
		{
			return this.GetImage(component.GetType(), null, large);
		}

		/// <summary>Возвращает мелкое изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</summary>
		/// <param name="type">Если для объекта <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> пока не задано мелкое изображение, этот метод осуществляет поиск ресурса точечного рисунка в сборке, определяющей тип, указанный параметром типа. Например, если параметру типа передано выражение typeof(ControlA), метод выполняет поиск в сборке, определяющей тип ControlA.</param>
		/// <returns>Мелкое изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</returns>
		// Token: 0x060007B2 RID: 1970 RVA: 0x000167EA File Offset: 0x000149EA
		public Image GetImage(Type type)
		{
			return this.GetImage(type, null, false);
		}

		/// <summary>Получает мелкое или крупное изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</summary>
		/// <param name="type">Если для объекта <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> пока не задано мелкое изображение, этот метод осуществляет поиск ресурса точечного рисунка в сборке, определяющей тип, заданный типом компонента. Например, если параметру типа передано выражение typeof(ControlA), метод выполняет поиск в сборке, определяющей тип ControlA.</param>
		/// <param name="large">Определяет, возвращает ли метод крупное (<see langword="true" />) или мелкое изображение (<see langword="false" />). Мелкое изображение имеет размер 16 x 16, крупное — 32 x 32 точки.</param>
		/// <returns>Изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</returns>
		// Token: 0x060007B3 RID: 1971 RVA: 0x000167F5 File Offset: 0x000149F5
		public Image GetImage(Type type, bool large)
		{
			return this.GetImage(type, null, large);
		}

		/// <summary>Получает мелкое или крупное изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</summary>
		/// <param name="type">Если для объекта <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> пока не задано мелкое изображение, этот метод осуществляет поиск встроенного ресурса точечного рисунка в сборке, определяющей тип, заданный типом компонента. Например, если параметру типа передано выражение typeof(ControlA), метод выполняет поиск в сборке, определяющей тип ControlA.</param>
		/// <param name="imgName">Имя внедренного ресурса точечного рисунка.</param>
		/// <param name="large">Определяет, возвращает ли метод крупное (<see langword="true" />) или мелкое изображение (<see langword="false" />). Мелкое изображение имеет размер 16 x 16, крупное — 32 x 32 точки.</param>
		/// <returns>Изображение <see cref="T:System.Drawing.Image" />, связанное с объектом <see cref="T:System.Drawing.ToolboxBitmapAttribute" />.</returns>
		// Token: 0x060007B4 RID: 1972 RVA: 0x00016800 File Offset: 0x00014A00
		public Image GetImage(Type type, string imgName, bool large)
		{
			if (this.smallImage == null)
			{
				this.smallImage = ToolboxBitmapAttribute.GetImageFromResource(type, imgName, false);
			}
			if (large)
			{
				if (this.bigImage == null)
				{
					this.bigImage = new Bitmap(this.smallImage, 32, 32);
				}
				return this.bigImage;
			}
			return this.smallImage;
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Image" /> на основе ресурса точечного рисунка, внедренного в сборку.</summary>
		/// <param name="t">Этот метод выполняет поиск внедренного ресурса точечного рисунка в сборке, которая определяет тип, заданный параметром "t". Например, если параметру "t" передано выражение typeof(ControlA), метод выполняет поиск в сборке, определяющей ControlA.</param>
		/// <param name="imageName">Имя внедренного ресурса точечного рисунка.</param>
		/// <param name="large">Определяет то, какое изображение возвращает метод — крупное (true) или мелкое (false). Мелкое изображение имеет размер 16 x 16, крупное — 32 x 32 точки.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Image" /> на основе извлеченного точечного рисунка.</returns>
		// Token: 0x060007B5 RID: 1973 RVA: 0x00016850 File Offset: 0x00014A50
		public static Image GetImageFromResource(Type t, string imageName, bool large)
		{
			if (imageName == null)
			{
				imageName = t.Name + ".bmp";
			}
			Image result;
			try
			{
				Bitmap bitmap;
				using (Stream manifestResourceStream = t.GetTypeInfo().Assembly.GetManifestResourceStream(t.Namespace + "." + imageName))
				{
					if (manifestResourceStream == null)
					{
						return null;
					}
					bitmap = new Bitmap(manifestResourceStream, false);
				}
				if (large)
				{
					result = new Bitmap(bitmap, 32, 32);
				}
				else
				{
					result = bitmap;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x04000592 RID: 1426
		private Image smallImage;

		// Token: 0x04000593 RID: 1427
		private Image bigImage;

		/// <summary>Объект <see cref="T:System.Drawing.ToolboxBitmapAttribute" />, у которого как мелкое, так и крупное изображение установлено равным <see langword="null" />.</summary>
		// Token: 0x04000594 RID: 1428
		public static readonly ToolboxBitmapAttribute Default = new ToolboxBitmapAttribute();
	}
}
