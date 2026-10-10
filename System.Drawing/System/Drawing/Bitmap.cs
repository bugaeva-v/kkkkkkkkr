using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Drawing
{
	/// <summary>Инкапсулирует точечный рисунок GDI+, состоящий из данных пикселей графического изображения и атрибутов рисунка. Объект <see cref="T:System.Drawing.Bitmap" /> используется для работы с изображениями, определяемыми данными пикселей.</summary>
	// Token: 0x0200004D RID: 77
	[ComVisible(true)]
	[Editor("System.Drawing.Design.BitmapEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Serializable]
	public sealed class Bitmap : Image
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x000085AF File Offset: 0x000067AF
		private Bitmap()
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000085B7 File Offset: 0x000067B7
		internal Bitmap(IntPtr ptr)
		{
			this.nativeObject = ptr;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000085C6 File Offset: 0x000067C6
		internal Bitmap(IntPtr ptr, Stream stream)
		{
			if (GDIPlus.RunningOnWindows())
			{
				this.stream = stream;
			}
			this.nativeObject = ptr;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> с заданным размером.</summary>
		/// <param name="width">Ширина в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="height">Высота в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x060002F6 RID: 758 RVA: 0x000085E3 File Offset: 0x000067E3
		public Bitmap(int width, int height) : this(width, height, PixelFormat.Format32bppArgb)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> с заданным размером и с разрешением указанного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="width">Ширина в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="height">Высота в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, который определяет разрешение нового объекта <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="g" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060002F7 RID: 759 RVA: 0x000085F4 File Offset: 0x000067F4
		public Bitmap(int width, int height, Graphics g)
		{
			if (g == null)
			{
				throw new ArgumentNullException("g");
			}
			IntPtr nativeObject;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateBitmapFromGraphics(width, height, g.nativeObject, out nativeObject));
			this.nativeObject = nativeObject;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> с заданными значениями размера и формата.</summary>
		/// <param name="width">Ширина в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="height">Высота в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="format">Формат пикселей для нового объекта <see cref="T:System.Drawing.Bitmap" />. Этот элемент должен задавать значение, начинающееся с Format.</param>
		/// <exception cref="T:System.ArgumentException">Задано значение <see cref="T:System.Drawing.Imaging.PixelFormat" />, имя которого не начинается с Format. Например, задание поля <see cref="F:System.Drawing.Imaging.PixelFormat.Gdi" /> приведет к <see cref="T:System.ArgumentException" />, но <see cref="F:System.Drawing.Imaging.PixelFormat.Format48bppRgb" /> не приведет.</exception>
		// Token: 0x060002F8 RID: 760 RVA: 0x00008630 File Offset: 0x00006830
		public Bitmap(int width, int height, PixelFormat format)
		{
			IntPtr nativeObject;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateBitmapFromScan0(width, height, 0, format, IntPtr.Zero, out nativeObject));
			this.nativeObject = nativeObject;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> из указанного существующего изображения.</summary>
		/// <param name="original">Объект <see cref="T:System.Drawing.Image" />, из которого будет создан новый объект <see cref="T:System.Drawing.Bitmap" />.</param>
		// Token: 0x060002F9 RID: 761 RVA: 0x0000865F File Offset: 0x0000685F
		public Bitmap(Image original) : this(original, original.Width, original.Height)
		{
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Bitmap" /> из указанного потока данных.</summary>
		/// <param name="stream">Поток данных, используемый для загрузки изображения.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="stream" /> не содержит данные изображения или равен <see langword="null" />.  
		/// -или- 
		///  Поток <paramref name="stream" /> содержит файл изображения PNG, один из размеров которого превышает 65535 пикселей.</exception>
		// Token: 0x060002FA RID: 762 RVA: 0x00008674 File Offset: 0x00006874
		public Bitmap(Stream stream) : this(stream, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> из указанного файла.</summary>
		/// <param name="filename">Имя файла растрового изображения и путь к нему.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный файл не найден.</exception>
		// Token: 0x060002FB RID: 763 RVA: 0x0000867E File Offset: 0x0000687E
		public Bitmap(string filename) : this(filename, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> из указанного существующего изображения, масштабированного до заданного размера.</summary>
		/// <param name="original">Объект <see cref="T:System.Drawing.Image" />, из которого будет создан новый объект <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="newSize">Структура <see cref="T:System.Drawing.Size" />, представляющая размер нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x060002FC RID: 764 RVA: 0x00008688 File Offset: 0x00006888
		public Bitmap(Image original, Size newSize) : this(original, newSize.Width, newSize.Height)
		{
		}

		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Bitmap" /> из указанного потока данных.</summary>
		/// <param name="stream">Поток данных, используемый для загрузки изображения.</param>
		/// <param name="useIcm">Значение <see langword="true" />, чтобы воспользоваться цветокоррекцией для этого изображения <see cref="T:System.Drawing.Bitmap" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="stream" /> не содержит данные изображения или равен <see langword="null" />.  
		/// -или- 
		///  Поток <paramref name="stream" /> содержит файл изображения PNG, один из размеров которого превышает 65535 пикселей.</exception>
		// Token: 0x060002FD RID: 765 RVA: 0x0000869F File Offset: 0x0000689F
		public Bitmap(Stream stream, bool useIcm)
		{
			this.nativeObject = Image.InitFromStream(stream);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> из указанного файла.</summary>
		/// <param name="filename">Имя файла точечного рисунка.</param>
		/// <param name="useIcm">Значение <see langword="true" />, чтобы воспользоваться цветокоррекцией для этого изображения <see cref="T:System.Drawing.Bitmap" />; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060002FE RID: 766 RVA: 0x000086B4 File Offset: 0x000068B4
		public Bitmap(string filename, bool useIcm)
		{
			if (filename == null)
			{
				throw new ArgumentNullException("filename");
			}
			IntPtr nativeObject;
			Status status;
			if (useIcm)
			{
				status = GDIPlus.GdipCreateBitmapFromFileICM(filename, out nativeObject);
			}
			else
			{
				status = GDIPlus.GdipCreateBitmapFromFile(filename, out nativeObject);
			}
			GDIPlus.CheckStatus(status);
			this.nativeObject = nativeObject;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> из указанного ресурса.</summary>
		/// <param name="type">Класс, используемый для извлечения ресурсов.</param>
		/// <param name="resource">Имя ресурса.</param>
		// Token: 0x060002FF RID: 767 RVA: 0x000086FC File Offset: 0x000068FC
		public Bitmap(Type type, string resource)
		{
			if (resource == null)
			{
				throw new ArgumentException("resource");
			}
			if (type == null)
			{
				throw new NullReferenceException();
			}
			Stream manifestResourceStream = type.GetTypeInfo().Assembly.GetManifestResourceStream(type, resource);
			if (manifestResourceStream == null)
			{
				throw new FileNotFoundException(Locale.GetText("Resource '{0}' was not found.", new object[]
				{
					resource
				}));
			}
			this.nativeObject = Image.InitFromStream(manifestResourceStream);
			if (GDIPlus.RunningOnWindows())
			{
				this.stream = manifestResourceStream;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> из указанного существующего изображения, масштабированного до заданного размера.</summary>
		/// <param name="original">Объект <see cref="T:System.Drawing.Image" />, из которого будет создан новый объект <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="width">Ширина в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="height">Высота в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x06000300 RID: 768 RVA: 0x00008776 File Offset: 0x00006976
		public Bitmap(Image original, int width, int height) : this(width, height, PixelFormat.Format32bppArgb)
		{
			Graphics graphics = Graphics.FromImage(this);
			graphics.DrawImage(original, 0, 0, width, height);
			graphics.Dispose();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Bitmap" /> с заданным размером, форматом и данными пикселей.</summary>
		/// <param name="width">Ширина в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="height">Высота в пикселях нового изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="stride">Целое число, определяющее смещение в байтах между строкой развертки и следующей строкой развертки. Обычно (но необязательно) это число байтов в формате пикселей (например, 2 для 16 битов на пиксель), умноженное на ширину точечного рисунка. Значение, переданное в этот параметр, должно быть кратно четырем.</param>
		/// <param name="format">Формат пикселей для нового объекта <see cref="T:System.Drawing.Bitmap" />. Этот элемент должен задавать значение, начинающееся с Format.</param>
		/// <param name="scan0">Указатель на массив байтов, содержащий данные пикселей.</param>
		/// <exception cref="T:System.ArgumentException">Задано значение <see cref="T:System.Drawing.Imaging.PixelFormat" />, имя которого не начинается с Format. Например, задание поля <see cref="F:System.Drawing.Imaging.PixelFormat.Gdi" /> приведет к <see cref="T:System.ArgumentException" />, но <see cref="F:System.Drawing.Imaging.PixelFormat.Format48bppRgb" /> не приведет.</exception>
		// Token: 0x06000301 RID: 769 RVA: 0x0000879C File Offset: 0x0000699C
		public Bitmap(int width, int height, int stride, PixelFormat format, IntPtr scan0)
		{
			IntPtr nativeObject;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateBitmapFromScan0(width, height, stride, format, scan0, out nativeObject));
			this.nativeObject = nativeObject;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000087C9 File Offset: 0x000069C9
		private Bitmap(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Возвращает цвет указанного пикселя в этом изображении <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <param name="x">Возвращаемая координата пикселя по оси X.</param>
		/// <param name="y">Возвращаемая координата пикселя по оси Y.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Color" />, представляющая цвет указанного пикселя.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="x" /> меньше 0, либо больше или равен <see cref="P:System.Drawing.Image.Width" />.  
		/// -или- 
		///  Параметр <paramref name="y" /> меньше 0, либо больше или равен <see cref="P:System.Drawing.Image.Height" />.</exception>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x06000303 RID: 771 RVA: 0x000087D4 File Offset: 0x000069D4
		public Color GetPixel(int x, int y)
		{
			int argb;
			GDIPlus.CheckStatus(GDIPlus.GdipBitmapGetPixel(this.nativeObject, x, y, out argb));
			return Color.FromArgb(argb);
		}

		/// <summary>Задает цвет указанного пикселя в этом объекте <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <param name="x">Координата X пикселя, который необходимо задать.</param>
		/// <param name="y">Координата Y пикселя, который необходимо задать.</param>
		/// <param name="color">Структура <see cref="T:System.Drawing.Color" />, представляющая цвет, который нужно назначить указанному пикселю.</param>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x06000304 RID: 772 RVA: 0x000087FB File Offset: 0x000069FB
		public void SetPixel(int x, int y, Color color)
		{
			Status status = GDIPlus.GdipBitmapSetPixel(this.nativeObject, x, y, color.ToArgb());
			if (status == Status.InvalidParameter && (base.PixelFormat & PixelFormat.Indexed) != PixelFormat.Undefined)
			{
				throw new InvalidOperationException(Locale.GetText("SetPixel cannot be called on indexed bitmaps."));
			}
			GDIPlus.CheckStatus(status);
		}

		/// <summary>Создает копию раздела этого объекта <see cref="T:System.Drawing.Bitmap" />, определяемого структурой <see cref="T:System.Drawing.Rectangle" /> и с указанным перечислением <see cref="T:System.Drawing.Imaging.PixelFormat" />.</summary>
		/// <param name="rect">Определяет копируемую часть объекта <see cref="T:System.Drawing.Bitmap" />. Координаты являются относительными для этого изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="format">Формат пикселей для нового объекта <see cref="T:System.Drawing.Bitmap" />. Этот элемент должен задавать значение, начинающееся с Format.</param>
		/// <returns>Новый объект <see cref="T:System.Drawing.Bitmap" />, созданный данным методом.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Параметр <paramref name="rect" /> находится за пределами исходного точечного рисунка.</exception>
		/// <exception cref="T:System.ArgumentException">Значение высоты или ширины объекта <paramref name="rect" /> равно 0.  
		/// -или- 
		/// Задано значение <see cref="T:System.Drawing.Imaging.PixelFormat" />, имя которого не начинается с Format. Например, задание поля <see cref="F:System.Drawing.Imaging.PixelFormat.Gdi" /> приведет к <see cref="T:System.ArgumentException" />, но <see cref="F:System.Drawing.Imaging.PixelFormat.Format48bppRgb" /> не приведет.</exception>
		// Token: 0x06000305 RID: 773 RVA: 0x00008838 File Offset: 0x00006A38
		public Bitmap Clone(Rectangle rect, PixelFormat format)
		{
			IntPtr ptr;
			GDIPlus.CheckStatus(GDIPlus.GdipCloneBitmapAreaI(rect.X, rect.Y, rect.Width, rect.Height, format, this.nativeObject, out ptr));
			return new Bitmap(ptr);
		}

		/// <summary>Создает копию части этого изображения <see cref="T:System.Drawing.Bitmap" />, определяемого заданным перечислением <see cref="T:System.Drawing.Imaging.PixelFormat" />.</summary>
		/// <param name="rect">Определяет копируемую часть объекта <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="format">Указывает перечисление <see cref="T:System.Drawing.Imaging.PixelFormat" /> для целевого изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Bitmap" />, создаваемый данным методом.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Параметр <paramref name="rect" /> находится за пределами исходного точечного рисунка.</exception>
		/// <exception cref="T:System.ArgumentException">Значение высоты или ширины объекта <paramref name="rect" /> равно 0.</exception>
		// Token: 0x06000306 RID: 774 RVA: 0x0000887C File Offset: 0x00006A7C
		public Bitmap Clone(RectangleF rect, PixelFormat format)
		{
			IntPtr ptr;
			GDIPlus.CheckStatus(GDIPlus.GdipCloneBitmapArea(rect.X, rect.Y, rect.Width, rect.Height, format, this.nativeObject, out ptr));
			return new Bitmap(ptr);
		}

		/// <summary>Создает изображение <see cref="T:System.Drawing.Bitmap" /> для значка из дескриптора Windows.</summary>
		/// <param name="hicon">Дескриптор для значка.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Bitmap" />, создаваемый данным методом.</returns>
		// Token: 0x06000307 RID: 775 RVA: 0x000088C0 File Offset: 0x00006AC0
		public static Bitmap FromHicon(IntPtr hicon)
		{
			IntPtr ptr;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateBitmapFromHICON(hicon, out ptr));
			return new Bitmap(ptr);
		}

		/// <summary>Создает изображение <see cref="T:System.Drawing.Bitmap" /> из указанного ресурса Windows.</summary>
		/// <param name="hinstance">Дескриптор экземпляра исполняемого файла, содержащего ресурс.</param>
		/// <param name="bitmapName">Строка, содержащая имя точечного рисунка ресурса.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Bitmap" />, создаваемый данным методом.</returns>
		// Token: 0x06000308 RID: 776 RVA: 0x000088E0 File Offset: 0x00006AE0
		public static Bitmap FromResource(IntPtr hinstance, string bitmapName)
		{
			IntPtr ptr;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateBitmapFromResource(hinstance, bitmapName, out ptr));
			return new Bitmap(ptr);
		}

		/// <summary>Создает объект точечного рисунка GDI из данного изображения <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <returns>Дескриптор для объекта точечного рисунка GDI, созданного этим методом.</returns>
		/// <exception cref="T:System.ArgumentException">Значение ширины или высоты точечного рисунка больше <see cref="F:System.Int16.MaxValue" />.</exception>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x06000309 RID: 777 RVA: 0x00008901 File Offset: 0x00006B01
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IntPtr GetHbitmap()
		{
			return this.GetHbitmap(Color.Gray);
		}

		/// <summary>Создает объект точечного рисунка GDI из данного изображения <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <param name="background">Структура <see cref="T:System.Drawing.Color" />, определяющая цвет фона. Этот параметр игнорируется, если точечный рисунок совершенно непрозрачен.</param>
		/// <returns>Дескриптор для объекта точечного рисунка GDI, созданного этим методом.</returns>
		/// <exception cref="T:System.ArgumentException">Значение ширины или высоты точечного рисунка больше <see cref="F:System.Int16.MaxValue" />.</exception>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x0600030A RID: 778 RVA: 0x00008910 File Offset: 0x00006B10
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IntPtr GetHbitmap(Color background)
		{
			IntPtr result;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateHBITMAPFromBitmap(this.nativeObject, out result, background.ToArgb()));
			return result;
		}

		/// <summary>Возвращает дескриптор для значка.</summary>
		/// <returns>Дескриптор Windows для значка с тем же изображением, что и <see cref="T:System.Drawing.Bitmap" />.</returns>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x0600030B RID: 779 RVA: 0x00008938 File Offset: 0x00006B38
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IntPtr GetHicon()
		{
			IntPtr result;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateHICONFromBitmap(this.nativeObject, out result));
			return result;
		}

		/// <summary>Блокирует объект <see cref="T:System.Drawing.Bitmap" /> в системной памяти.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает часть объекта <see cref="T:System.Drawing.Bitmap" /> для блокировки.</param>
		/// <param name="flags">Перечисление <see cref="T:System.Drawing.Imaging.ImageLockMode" />, задающее уровень доступа (чтение или запись) для объекта <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="format">Перечисление <see cref="T:System.Drawing.Imaging.PixelFormat" />, задающее формат данных этого изображения <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.BitmapData" />, содержащий сведения об этой операции блокирования.</returns>
		/// <exception cref="T:System.ArgumentException">Значение <see cref="T:System.Drawing.Imaging.PixelFormat" /> не является конкретным числом битов на пиксель.  
		/// -или- 
		/// Для точечного рисунка передан неверный формат <see cref="T:System.Drawing.Imaging.PixelFormat" />.</exception>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x0600030C RID: 780 RVA: 0x00008958 File Offset: 0x00006B58
		public BitmapData LockBits(Rectangle rect, ImageLockMode flags, PixelFormat format)
		{
			BitmapData bitmapData = new BitmapData();
			return this.LockBits(rect, flags, format, bitmapData);
		}

		/// <summary>Блокирует объект <see cref="T:System.Drawing.Bitmap" /> в оперативной памяти.</summary>
		/// <param name="rect">Структура прямоугольника, задающая часть объекта <see cref="T:System.Drawing.Bitmap" /> для блокировки.</param>
		/// <param name="flags">Одно из значений <see cref="T:System.Drawing.Imaging.ImageLockMode" />, задающее уровень доступа (чтение или запись) для объекта <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="format">Одно из значений <see cref="T:System.Drawing.Imaging.PixelFormat" />, задающее формат данных объекта <see cref="T:System.Drawing.Bitmap" />.</param>
		/// <param name="bitmapData">Объект <see cref="T:System.Drawing.Imaging.BitmapData" />, содержащий сведения об этой операции блокирования.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.BitmapData" />, содержащий сведения об этой операции блокирования.</returns>
		/// <exception cref="T:System.ArgumentException">Значение <see cref="T:System.Drawing.Imaging.PixelFormat" /> не является конкретным числом битов на пиксель.  
		/// -или- 
		/// Для точечного рисунка передан неверный формат <see cref="T:System.Drawing.Imaging.PixelFormat" />.</exception>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x0600030D RID: 781 RVA: 0x00008975 File Offset: 0x00006B75
		public BitmapData LockBits(Rectangle rect, ImageLockMode flags, PixelFormat format, BitmapData bitmapData)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipBitmapLockBits(this.nativeObject, ref rect, flags, format, bitmapData));
			return bitmapData;
		}

		/// <summary>Делает прозрачным прозрачный цвет по умолчанию для этого элемента <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Формат изображения <see cref="T:System.Drawing.Bitmap" /> — это формат значков.</exception>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x0600030E RID: 782 RVA: 0x00008990 File Offset: 0x00006B90
		public void MakeTransparent()
		{
			Color pixel = this.GetPixel(0, 0);
			this.MakeTransparent(pixel);
		}

		/// <summary>Делает заданный цвет прозрачным для данного изображения <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <param name="transparentColor">Структура <see cref="T:System.Drawing.Color" />, представляющая цвет, который делается прозрачным.</param>
		/// <exception cref="T:System.InvalidOperationException">Формат изображения <see cref="T:System.Drawing.Bitmap" /> — это формат значков.</exception>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x0600030F RID: 783 RVA: 0x000089B0 File Offset: 0x00006BB0
		public void MakeTransparent(Color transparentColor)
		{
			Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			Rectangle destRect = new Rectangle(0, 0, base.Width, base.Height);
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorKey(transparentColor, transparentColor);
			graphics.DrawImage(this, destRect, 0, 0, base.Width, base.Height, GraphicsUnit.Pixel, imageAttributes);
			IntPtr nativeObject = this.nativeObject;
			this.nativeObject = bitmap.nativeObject;
			bitmap.nativeObject = nativeObject;
			graphics.Dispose();
			bitmap.Dispose();
			imageAttributes.Dispose();
		}

		/// <summary>Задает разрешение для этого изображения <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <param name="xDpi">Горизонтальное разрешение изображения <see cref="T:System.Drawing.Bitmap" /> в точках на дюйм.</param>
		/// <param name="yDpi">Вертикальное разрешение изображения <see cref="T:System.Drawing.Bitmap" /> в пикселях на дюйм.</param>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x06000310 RID: 784 RVA: 0x00008A40 File Offset: 0x00006C40
		public void SetResolution(float xDpi, float yDpi)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipBitmapSetResolution(this.nativeObject, xDpi, yDpi));
		}

		/// <summary>Разблокирует это изображение <see cref="T:System.Drawing.Bitmap" /> из оперативной памяти.</summary>
		/// <param name="bitmapdata">Объект <see cref="T:System.Drawing.Imaging.BitmapData" />, задающий сведения об этой операции блокировки.</param>
		/// <exception cref="T:System.Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x06000311 RID: 785 RVA: 0x00008A54 File Offset: 0x00006C54
		public void UnlockBits(BitmapData bitmapdata)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipBitmapUnlockBits(this.nativeObject, bitmapdata));
		}
	}
}
