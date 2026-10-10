using System;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace System.Drawing
{
	/// <summary>Описывает внутреннюю часть графической формы, состоящей из прямоугольников и контуров. Этот класс не наследуется.</summary>
	// Token: 0x02000088 RID: 136
	public sealed class Region : MarshalByRefObject, IDisposable
	{
		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.Region" />.</summary>
		// Token: 0x06000711 RID: 1809 RVA: 0x00015161 File Offset: 0x00013361
		public Region()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCreateRegion(out this.nativeRegion));
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00015184 File Offset: 0x00013384
		internal Region(IntPtr native)
		{
			this.nativeRegion = native;
		}

		/// <summary>Инициализирует новый <see cref="T:System.Drawing.Region" /> с указанным <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="path">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, определяющий новый <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000713 RID: 1811 RVA: 0x0001519E File Offset: 0x0001339E
		public Region(GraphicsPath path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCreateRegionPath(path.nativePath, out this.nativeRegion));
		}

		/// <summary>Инициализирует новую область <see cref="T:System.Drawing.Region" /> из указанной структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, определяющая внутреннюю часть новой области <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000714 RID: 1812 RVA: 0x000151D5 File Offset: 0x000133D5
		public Region(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCreateRegionRectI(ref rect, out this.nativeRegion));
		}

		/// <summary>Инициализирует новую область <see cref="T:System.Drawing.Region" /> из указанной структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, определяющая внутреннюю часть новой области <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000715 RID: 1813 RVA: 0x000151FA File Offset: 0x000133FA
		public Region(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCreateRegionRect(ref rect, out this.nativeRegion));
		}

		/// <summary>Инициализирует новый <see cref="T:System.Drawing.Region" /> из указанных данных.</summary>
		/// <param name="rgnData">Объект <see cref="T:System.Drawing.Drawing2D.RegionData" />, определяющий внутреннюю часть нового <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rgnData" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000716 RID: 1814 RVA: 0x00015220 File Offset: 0x00013420
		public Region(RegionData rgnData)
		{
			if (rgnData == null)
			{
				throw new ArgumentNullException("rgnData");
			}
			if (rgnData.Data.Length == 0)
			{
				throw new ArgumentException("rgnData");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCreateRegionRgnData(rgnData.Data, rgnData.Data.Length, out this.nativeRegion));
		}

		/// <summary>Заменяет данную область <see cref="T:System.Drawing.Region" /> на ее объединение с указанным контуром <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="path">Область <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> для объединения с областью <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000717 RID: 1815 RVA: 0x0001527E File Offset: 0x0001347E
		public void Union(GraphicsPath path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionPath(this.nativeRegion, path.nativePath, CombineMode.Union));
		}

		/// <summary>Заменяет данную область <see cref="T:System.Drawing.Region" /> на ее объединение с указанной структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" /> для объединения с областью <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000718 RID: 1816 RVA: 0x000152A5 File Offset: 0x000134A5
		public void Union(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRectI(this.nativeRegion, ref rect, CombineMode.Union));
		}

		/// <summary>Заменяет данную область <see cref="T:System.Drawing.Region" /> на ее объединение с указанной структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" /> для объединения с областью <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000719 RID: 1817 RVA: 0x000152BA File Offset: 0x000134BA
		public void Union(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRect(this.nativeRegion, ref rect, CombineMode.Union));
		}

		/// <summary>Заменяет данную область <see cref="T:System.Drawing.Region" /> на ее объединение с указанным контуром <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="region">Область <see cref="T:System.Drawing.Region" /> для объединения с областью <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="region" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600071A RID: 1818 RVA: 0x000152CF File Offset: 0x000134CF
		public void Union(Region region)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRegion(this.nativeRegion, region.NativeObject, CombineMode.Union));
		}

		/// <summary>Заменяет этот объект <see cref="T:System.Drawing.Region" /> его пересечением с указанным прямоугольником <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="path">
		///   <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> для пересечения с <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x0600071B RID: 1819 RVA: 0x000152F6 File Offset: 0x000134F6
		public void Intersect(GraphicsPath path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionPath(this.nativeRegion, path.nativePath, CombineMode.Intersect));
		}

		/// <summary>Заменяет этот объект <see cref="T:System.Drawing.Region" /> его пересечением с указанной структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" /> для пересечения с <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x0600071C RID: 1820 RVA: 0x0001531D File Offset: 0x0001351D
		public void Intersect(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRectI(this.nativeRegion, ref rect, CombineMode.Intersect));
		}

		/// <summary>Заменяет этот объект <see cref="T:System.Drawing.Region" /> его пересечением с указанной структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" /> для пересечения с <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x0600071D RID: 1821 RVA: 0x00015332 File Offset: 0x00013532
		public void Intersect(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRect(this.nativeRegion, ref rect, CombineMode.Intersect));
		}

		/// <summary>Заменяет этот объект <see cref="T:System.Drawing.Region" /> его пересечением с указанным прямоугольником <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="region">
		///   <see cref="T:System.Drawing.Region" /> для пересечения с <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x0600071E RID: 1822 RVA: 0x00015347 File Offset: 0x00013547
		public void Intersect(Region region)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRegion(this.nativeRegion, region.NativeObject, CombineMode.Intersect));
		}

		/// <summary>Обновляет этот <see cref="T:System.Drawing.Region" />, чтобы включить в него часть указанного <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, которая не пересекается с этим <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="path">
		///   <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> в дополнение к этому <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600071F RID: 1823 RVA: 0x0001536E File Offset: 0x0001356E
		public void Complement(GraphicsPath path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionPath(this.nativeRegion, path.nativePath, CombineMode.Complement));
		}

		/// <summary>Обновляет область <see cref="T:System.Drawing.Region" />, чтобы включить часть указанной структуры <see cref="T:System.Drawing.Rectangle" />, не пересекающейся с областью <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, дополняющая область <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000720 RID: 1824 RVA: 0x00015395 File Offset: 0x00013595
		public void Complement(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRectI(this.nativeRegion, ref rect, CombineMode.Complement));
		}

		/// <summary>Обновляет область <see cref="T:System.Drawing.Region" />, чтобы включить часть указанной структуры <see cref="T:System.Drawing.RectangleF" />, не пересекающейся с областью <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, дополняющая область <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000721 RID: 1825 RVA: 0x000153AA File Offset: 0x000135AA
		public void Complement(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRect(this.nativeRegion, ref rect, CombineMode.Complement));
		}

		/// <summary>Обновляет этот <see cref="T:System.Drawing.Region" />, чтобы включить в него часть указанного <see cref="T:System.Drawing.Region" />, которая не пересекается с этим <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="region">Объект <see cref="T:System.Drawing.Region" />, который будет дополнением этого объекта <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="region" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000722 RID: 1826 RVA: 0x000153BF File Offset: 0x000135BF
		public void Complement(Region region)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRegion(this.nativeRegion, region.NativeObject, CombineMode.Complement));
		}

		/// <summary>Обновляет область <see cref="T:System.Drawing.Region" />, чтобы включить только часть ее внутренней области, не пересекающуюся с заданным контуром <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="path">Контур <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, исключаемый из области <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000723 RID: 1827 RVA: 0x000153E6 File Offset: 0x000135E6
		public void Exclude(GraphicsPath path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionPath(this.nativeRegion, path.nativePath, CombineMode.Exclude));
		}

		/// <summary>Обновляет область <see cref="T:System.Drawing.Region" />, чтобы включить только часть ее внутренней области, не пересекающуюся с заданной структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, исключаемая из этой области <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000724 RID: 1828 RVA: 0x0001540D File Offset: 0x0001360D
		public void Exclude(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRectI(this.nativeRegion, ref rect, CombineMode.Exclude));
		}

		/// <summary>Обновляет область <see cref="T:System.Drawing.Region" />, чтобы включить только часть ее внутренней области, не пересекающуюся с заданной структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, исключаемая из этой области <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000725 RID: 1829 RVA: 0x00015422 File Offset: 0x00013622
		public void Exclude(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRect(this.nativeRegion, ref rect, CombineMode.Exclude));
		}

		/// <summary>Обновляет область <see cref="T:System.Drawing.Region" />, чтобы включить только часть ее внутренней области, не пересекающуюся с заданным контуром <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="region">Контур <see cref="T:System.Drawing.Region" />, исключаемый из области <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="region" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000726 RID: 1830 RVA: 0x00015437 File Offset: 0x00013637
		public void Exclude(Region region)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRegion(this.nativeRegion, region.NativeObject, CombineMode.Exclude));
		}

		/// <summary>Заменяет данную область <see cref="T:System.Drawing.Region" /> разностью ее объединения и пересечения с указанным контуром <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="path">Контур <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> для выполнения операции <see cref="Overload:System.Drawing.Region.Xor" /> с этой областью <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000727 RID: 1831 RVA: 0x0001545E File Offset: 0x0001365E
		public void Xor(GraphicsPath path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionPath(this.nativeRegion, path.nativePath, CombineMode.Xor));
		}

		/// <summary>Заменяет данную область <see cref="T:System.Drawing.Region" /> разностью ее объединения и пересечения с указанной структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" /> для выполнения операции <see cref="Overload:System.Drawing.Region.Xor" /> с данной областью <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000728 RID: 1832 RVA: 0x00015485 File Offset: 0x00013685
		public void Xor(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRectI(this.nativeRegion, ref rect, CombineMode.Xor));
		}

		/// <summary>Заменяет данную область <see cref="T:System.Drawing.Region" /> разностью ее объединения и пересечения с указанной структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" /> для выполнения операции <see cref="M:System.Drawing.Region.Xor(System.Drawing.Drawing2D.GraphicsPath)" /> с данной областью <see cref="T:System.Drawing.Region" />.</param>
		// Token: 0x06000729 RID: 1833 RVA: 0x0001549A File Offset: 0x0001369A
		public void Xor(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRect(this.nativeRegion, ref rect, CombineMode.Xor));
		}

		/// <summary>Заменяет данную область <see cref="T:System.Drawing.Region" /> разностью ее объединения и пересечения с указанным контуром <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="region">Контур <see cref="T:System.Drawing.Region" /> для выполнения операции <see cref="Overload:System.Drawing.Region.Xor" /> с этой областью <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="region" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600072A RID: 1834 RVA: 0x000154AF File Offset: 0x000136AF
		public void Xor(Region region)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCombineRegionRegion(this.nativeRegion, region.NativeObject, CombineMode.Xor));
		}

		/// <summary>Возвращает структуру <see cref="T:System.Drawing.RectangleF" />, представляющую прямоугольник, ограничивающий область <see cref="T:System.Drawing.Region" /> на поверхности рисования объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="g">Поверхность <see cref="T:System.Drawing.Graphics" />, на которой рисуется область <see cref="T:System.Drawing.Region" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.RectangleF" />, представляющая ограничивающий прямоугольник для этой область <see cref="T:System.Drawing.Region" /> на указанной поверхности рисования.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="g" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600072B RID: 1835 RVA: 0x000154D8 File Offset: 0x000136D8
		public RectangleF GetBounds(Graphics g)
		{
			if (g == null)
			{
				throw new ArgumentNullException("g");
			}
			RectangleF result = default(Rectangle);
			GDIPlus.CheckStatus(GDIPlus.GdipGetRegionBounds(this.nativeRegion, g.NativeObject, ref result));
			return result;
		}

		/// <summary>Смещает координаты области <see cref="T:System.Drawing.Region" /> на указанную величину.</summary>
		/// <param name="dx">Величина смещения области <see cref="T:System.Drawing.Region" /> в горизонтальном направлении.</param>
		/// <param name="dy">Величина смещения области <see cref="T:System.Drawing.Region" /> в вертикальном направлении.</param>
		// Token: 0x0600072C RID: 1836 RVA: 0x0001551B File Offset: 0x0001371B
		public void Translate(int dx, int dy)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipTranslateRegionI(this.nativeRegion, dx, dy));
		}

		/// <summary>Смещает координаты области <see cref="T:System.Drawing.Region" /> на указанную величину.</summary>
		/// <param name="dx">Величина смещения области <see cref="T:System.Drawing.Region" /> в горизонтальном направлении.</param>
		/// <param name="dy">Величина смещения области <see cref="T:System.Drawing.Region" /> в вертикальном направлении.</param>
		// Token: 0x0600072D RID: 1837 RVA: 0x0001552F File Offset: 0x0001372F
		public void Translate(float dx, float dy)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipTranslateRegion(this.nativeRegion, dx, dy));
		}

		/// <summary>Проверяет, содержится ли указанная точка в области <see cref="T:System.Drawing.Region" /> при рисовании с использованием указанного графического контекста <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий графический контекст.</param>
		/// <returns>Значение <see langword="true" />, если указанная точка содержится в области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600072E RID: 1838 RVA: 0x00015544 File Offset: 0x00013744
		public bool IsVisible(int x, int y, Graphics g)
		{
			IntPtr graphics = (g == null) ? IntPtr.Zero : g.NativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionPointI(this.nativeRegion, x, y, graphics, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли какая-либо часть указанного прямоугольника в области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="x">Координата по оси X верхнего левого угла прямоугольника для проверки.</param>
		/// <param name="y">Координата по оси Y верхнего левого угла прямоугольника для проверки.</param>
		/// <param name="width">Ширина прямоугольника для проверки.</param>
		/// <param name="height">Высота прямоугольника для проверки.</param>
		/// <returns>Значение <see langword="true" />, если какая-либо часть заданного прямоугольника содержится в области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600072F RID: 1839 RVA: 0x00015578 File Offset: 0x00013778
		public bool IsVisible(int x, int y, int width, int height)
		{
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionRectI(this.nativeRegion, x, y, width, height, IntPtr.Zero, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли какая-либо часть указанного прямоугольника в области <see cref="T:System.Drawing.Region" /> при рисовании с использованием указанного графического контекста <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата по оси X верхнего левого угла прямоугольника для проверки.</param>
		/// <param name="y">Координата по оси Y верхнего левого угла прямоугольника для проверки.</param>
		/// <param name="width">Ширина прямоугольника для проверки.</param>
		/// <param name="height">Высота прямоугольника для проверки.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий графический контекст.</param>
		/// <returns>Значение <see langword="true" />, если какая-либо часть заданного прямоугольника содержится в области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000730 RID: 1840 RVA: 0x000155A4 File Offset: 0x000137A4
		public bool IsVisible(int x, int y, int width, int height, Graphics g)
		{
			IntPtr graphics = (g == null) ? IntPtr.Zero : g.NativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionRectI(this.nativeRegion, x, y, width, height, graphics, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли указанная структура <see cref="T:System.Drawing.Point" /> в области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="point">Структура <see cref="T:System.Drawing.Point" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, когда точка <paramref name="point" /> находится в данной области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000731 RID: 1841 RVA: 0x000155E0 File Offset: 0x000137E0
		public bool IsVisible(Point point)
		{
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionPointI(this.nativeRegion, point.X, point.Y, IntPtr.Zero, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли указанная структура <see cref="T:System.Drawing.PointF" /> в области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="point">Структура <see cref="T:System.Drawing.PointF" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, когда точка <paramref name="point" /> находится в данной области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000732 RID: 1842 RVA: 0x00015614 File Offset: 0x00013814
		public bool IsVisible(PointF point)
		{
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionPoint(this.nativeRegion, point.X, point.Y, IntPtr.Zero, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли указанная структура <see cref="T:System.Drawing.Point" /> в области <see cref="T:System.Drawing.Region" /> при рисовании с использованием заданного графического контекста <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="point">Структура <see cref="T:System.Drawing.Point" /> для проверки.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий графический контекст.</param>
		/// <returns>Значение <see langword="true" />, когда точка <paramref name="point" /> находится в данной области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000733 RID: 1843 RVA: 0x00015648 File Offset: 0x00013848
		public bool IsVisible(Point point, Graphics g)
		{
			IntPtr graphics = (g == null) ? IntPtr.Zero : g.NativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionPointI(this.nativeRegion, point.X, point.Y, graphics, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли указанная структура <see cref="T:System.Drawing.PointF" /> в области <see cref="T:System.Drawing.Region" /> при рисовании с использованием заданного графического контекста <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="point">Структура <see cref="T:System.Drawing.PointF" /> для проверки.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий графический контекст.</param>
		/// <returns>Значение <see langword="true" />, когда точка <paramref name="point" /> находится в данной области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000734 RID: 1844 RVA: 0x00015688 File Offset: 0x00013888
		public bool IsVisible(PointF point, Graphics g)
		{
			IntPtr graphics = (g == null) ? IntPtr.Zero : g.NativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionPoint(this.nativeRegion, point.X, point.Y, graphics, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли какая-либо часть указанной структуры <see cref="T:System.Drawing.Rectangle" /> в области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если какая-либо часть <paramref name="rect" /> содержится в области <see cref="T:System.Drawing.Region" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000735 RID: 1845 RVA: 0x000156C8 File Offset: 0x000138C8
		public bool IsVisible(Rectangle rect)
		{
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionRectI(this.nativeRegion, rect.X, rect.Y, rect.Width, rect.Height, IntPtr.Zero, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли какая-либо часть указанной структуры <see cref="T:System.Drawing.RectangleF" /> в области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если какая-либо часть <paramref name="rect" /> содержится в области <see cref="T:System.Drawing.Region" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000736 RID: 1846 RVA: 0x0001570C File Offset: 0x0001390C
		public bool IsVisible(RectangleF rect)
		{
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionRect(this.nativeRegion, rect.X, rect.Y, rect.Width, rect.Height, IntPtr.Zero, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли какая-либо часть указанной структуры <see cref="T:System.Drawing.Rectangle" /> в области <see cref="T:System.Drawing.Region" /> при рисовании с использованием указанного графического контекста <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" /> для проверки.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий графический контекст.</param>
		/// <returns>Значение <see langword="true" />, если какая-либо часть <paramref name="rect" /> содержится в области <see cref="T:System.Drawing.Region" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000737 RID: 1847 RVA: 0x00015750 File Offset: 0x00013950
		public bool IsVisible(Rectangle rect, Graphics g)
		{
			IntPtr graphics = (g == null) ? IntPtr.Zero : g.NativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionRectI(this.nativeRegion, rect.X, rect.Y, rect.Width, rect.Height, graphics, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли какая-либо часть указанной структуры <see cref="T:System.Drawing.RectangleF" /> в области <see cref="T:System.Drawing.Region" /> при рисовании с использованием указанного графического контекста <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" /> для проверки.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий графический контекст.</param>
		/// <returns>Значение <see langword="true" />, когда точка <paramref name="rect" /> находится в данной области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000738 RID: 1848 RVA: 0x000157A0 File Offset: 0x000139A0
		public bool IsVisible(RectangleF rect, Graphics g)
		{
			IntPtr graphics = (g == null) ? IntPtr.Zero : g.NativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionRect(this.nativeRegion, rect.X, rect.Y, rect.Width, rect.Height, graphics, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли указанная точка в области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <returns>Значение <see langword="true" />, если указанная точка содержится в области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000739 RID: 1849 RVA: 0x000157F0 File Offset: 0x000139F0
		public bool IsVisible(float x, float y)
		{
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionPoint(this.nativeRegion, x, y, IntPtr.Zero, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли указанная точка в области <see cref="T:System.Drawing.Region" /> при рисовании с использованием заданного графического контекста <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий графический контекст.</param>
		/// <returns>Значение <see langword="true" />, если указанная точка содержится в области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600073A RID: 1850 RVA: 0x00015818 File Offset: 0x00013A18
		public bool IsVisible(float x, float y, Graphics g)
		{
			IntPtr graphics = (g == null) ? IntPtr.Zero : g.NativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionPoint(this.nativeRegion, x, y, graphics, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли какая-либо часть указанного прямоугольника в области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="x">Координата по оси X верхнего левого угла прямоугольника для проверки.</param>
		/// <param name="y">Координата по оси Y верхнего левого угла прямоугольника для проверки.</param>
		/// <param name="width">Ширина прямоугольника для проверки.</param>
		/// <param name="height">Высота прямоугольника для проверки.</param>
		/// <returns>Значение <see langword="true" />, если какая-либо часть заданного прямоугольника содержится в области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600073B RID: 1851 RVA: 0x0001584C File Offset: 0x00013A4C
		public bool IsVisible(float x, float y, float width, float height)
		{
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionRect(this.nativeRegion, x, y, width, height, IntPtr.Zero, out result));
			return result;
		}

		/// <summary>Проверяет, содержится ли какая-либо часть указанного прямоугольника в области <see cref="T:System.Drawing.Region" /> при рисовании с использованием указанного графического контекста <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата по оси X верхнего левого угла прямоугольника для проверки.</param>
		/// <param name="y">Координата по оси Y верхнего левого угла прямоугольника для проверки.</param>
		/// <param name="width">Ширина прямоугольника для проверки.</param>
		/// <param name="height">Высота прямоугольника для проверки.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий графический контекст.</param>
		/// <returns>Значение <see langword="true" />, если какая-либо часть заданного прямоугольника содержится в области <see cref="T:System.Drawing.Region" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600073C RID: 1852 RVA: 0x00015878 File Offset: 0x00013A78
		public bool IsVisible(float x, float y, float width, float height, Graphics g)
		{
			IntPtr graphics = (g == null) ? IntPtr.Zero : g.NativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRegionRect(this.nativeRegion, x, y, width, height, graphics, out result));
			return result;
		}

		/// <summary>Проверяет, имеет ли область <see cref="T:System.Drawing.Region" /> пустую внутреннюю часть на указанной поверхности рисования.</summary>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий поверхность рисования.</param>
		/// <returns>Значение <see langword="true" />, если внутренняя часть области <see cref="T:System.Drawing.Region" /> является пустой при применении преобразования, связанного с параметром <paramref name="g" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="g" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600073D RID: 1853 RVA: 0x000158B4 File Offset: 0x00013AB4
		public bool IsEmpty(Graphics g)
		{
			if (g == null)
			{
				throw new ArgumentNullException("g");
			}
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsEmptyRegion(this.nativeRegion, g.NativeObject, out result));
			return result;
		}

		/// <summary>Проверяет, имеет ли область <see cref="T:System.Drawing.Region" /> бесконечную внутреннюю часть на указанной поверхности рисования.</summary>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий поверхность рисования.</param>
		/// <returns>Значение <see langword="true" />, если внутренняя часть области <see cref="T:System.Drawing.Region" /> является бесконечной при применении преобразования, связанного с параметром <paramref name="g" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="g" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600073E RID: 1854 RVA: 0x000158E8 File Offset: 0x00013AE8
		public bool IsInfinite(Graphics g)
		{
			if (g == null)
			{
				throw new ArgumentNullException("g");
			}
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsInfiniteRegion(this.nativeRegion, g.NativeObject, out result));
			return result;
		}

		/// <summary>Инициализирует область <see cref="T:System.Drawing.Region" /> для пустой внутренней части.</summary>
		// Token: 0x0600073F RID: 1855 RVA: 0x0001591C File Offset: 0x00013B1C
		public void MakeEmpty()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetEmpty(this.nativeRegion));
		}

		/// <summary>Инициализирует область <see cref="T:System.Drawing.Region" /> для бесконечной внутренней части.</summary>
		// Token: 0x06000740 RID: 1856 RVA: 0x0001592E File Offset: 0x00013B2E
		public void MakeInfinite()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetInfinite(this.nativeRegion));
		}

		/// <summary>Проверяет идентичность указанной области <see cref="T:System.Drawing.Region" /> заданной области <see cref="T:System.Drawing.Region" /> на заданной поверхности рисования.</summary>
		/// <param name="region">Объект <see cref="T:System.Drawing.Region" /> для проверки.</param>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, представляющий поверхность рисования.</param>
		/// <returns>Значение <see langword="true" />, если внутренняя часть области идентична внутренней части данной области при применении преобразования, связанного с параметром <paramref name="g" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="g" /> или <paramref name="region" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000741 RID: 1857 RVA: 0x00015940 File Offset: 0x00013B40
		public bool Equals(Region region, Graphics g)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			if (g == null)
			{
				throw new ArgumentNullException("g");
			}
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsEqualRegion(this.nativeRegion, region.NativeObject, g.NativeObject, out result));
			return result;
		}

		/// <summary>Инициализирует новую область <see cref="T:System.Drawing.Region" /> из дескриптора указанной существующей области GDI.</summary>
		/// <param name="hrgn">Дескриптор существующей области <see cref="T:System.Drawing.Region" />.</param>
		/// <returns>Новый объект <see cref="T:System.Drawing.Region" />.</returns>
		// Token: 0x06000742 RID: 1858 RVA: 0x00015988 File Offset: 0x00013B88
		public static Region FromHrgn(IntPtr hrgn)
		{
			if (hrgn == IntPtr.Zero)
			{
				throw new ArgumentException("hrgn");
			}
			IntPtr native;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateRegionHrgn(hrgn, out native));
			return new Region(native);
		}

		/// <summary>Возвращает дескриптор Windows для области <see cref="T:System.Drawing.Region" /> в указанном графическом контексте.</summary>
		/// <param name="g">Поверхность <see cref="T:System.Drawing.Graphics" />, на которой рисуется область <see cref="T:System.Drawing.Region" />.</param>
		/// <returns>Дескриптор Windows для этого объекта <see cref="T:System.Drawing.Region" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="g" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000743 RID: 1859 RVA: 0x000159C0 File Offset: 0x00013BC0
		public IntPtr GetHrgn(Graphics g)
		{
			if (g == null)
			{
				return this.nativeRegion;
			}
			IntPtr zero = IntPtr.Zero;
			GDIPlus.CheckStatus(GDIPlus.GdipGetRegionHRgn(this.nativeRegion, g.NativeObject, ref zero));
			return zero;
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Drawing2D.RegionData" />, представляющий данные, описывающие область <see cref="T:System.Drawing.Region" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Drawing2D.RegionData" />, представляющий данные, описывающие область <see cref="T:System.Drawing.Region" />.</returns>
		// Token: 0x06000744 RID: 1860 RVA: 0x000159F8 File Offset: 0x00013BF8
		public RegionData GetRegionData()
		{
			int num;
			GDIPlus.CheckStatus(GDIPlus.GdipGetRegionDataSize(this.nativeRegion, out num));
			byte[] array = new byte[num];
			int num2;
			GDIPlus.CheckStatus(GDIPlus.GdipGetRegionData(this.nativeRegion, array, num, out num2));
			return new RegionData(array);
		}

		/// <summary>Возвращает массив структур <see cref="T:System.Drawing.RectangleF" />, аппроксимирующих область <see cref="T:System.Drawing.Region" /> после применения заданного матричного преобразования.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, представляющий применяемое к области геометрическое преобразование.</param>
		/// <returns>Массив структур <see cref="T:System.Drawing.RectangleF" />, аппроксимирующих область <see cref="T:System.Drawing.Region" /> после применения заданного матричного преобразования.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="matrix" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000745 RID: 1861 RVA: 0x00015A38 File Offset: 0x00013C38
		public RectangleF[] GetRegionScans(Matrix matrix)
		{
			if (matrix == null)
			{
				throw new ArgumentNullException("matrix");
			}
			int num;
			GDIPlus.CheckStatus(GDIPlus.GdipGetRegionScansCount(this.nativeRegion, out num, matrix.NativeObject));
			if (num == 0)
			{
				return new RectangleF[0];
			}
			RectangleF[] array = new RectangleF[num];
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf<RectangleF>(array[0]) * num);
			try
			{
				GDIPlus.CheckStatus(GDIPlus.GdipGetRegionScans(this.nativeRegion, intPtr, out num, matrix.NativeObject));
			}
			finally
			{
				GDIPlus.FromUnManagedMemoryToRectangles(intPtr, array);
			}
			return array;
		}

		/// <summary>Преобразовывает область <see cref="T:System.Drawing.Region" /> с помощью заданной матрицы <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <param name="matrix">Матрица <see cref="T:System.Drawing.Drawing2D.Matrix" />, с помощью которой преобразуется область <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="matrix" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000746 RID: 1862 RVA: 0x00015AC4 File Offset: 0x00013CC4
		public void Transform(Matrix matrix)
		{
			if (matrix == null)
			{
				throw new ArgumentNullException("matrix");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipTransformRegion(this.nativeRegion, matrix.NativeObject));
		}

		/// <summary>Создает точную копию данного объекта <see cref="T:System.Drawing.Region" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Region" />, создаваемый данным методом.</returns>
		// Token: 0x06000747 RID: 1863 RVA: 0x00015AEC File Offset: 0x00013CEC
		public Region Clone()
		{
			IntPtr native;
			GDIPlus.CheckStatus(GDIPlus.GdipCloneRegion(this.nativeRegion, out native));
			return new Region(native);
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Region" />.</summary>
		// Token: 0x06000748 RID: 1864 RVA: 0x00015B11 File Offset: 0x00013D11
		public void Dispose()
		{
			this.DisposeHandle();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00015B1F File Offset: 0x00013D1F
		private void DisposeHandle()
		{
			if (this.nativeRegion != IntPtr.Zero)
			{
				GDIPlus.GdipDeleteRegion(this.nativeRegion);
				this.nativeRegion = IntPtr.Zero;
			}
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x0600074A RID: 1866 RVA: 0x00015B4C File Offset: 0x00013D4C
		~Region()
		{
			this.DisposeHandle();
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00015B78 File Offset: 0x00013D78
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00015B80 File Offset: 0x00013D80
		internal IntPtr NativeObject
		{
			get
			{
				return this.nativeRegion;
			}
			set
			{
				this.nativeRegion = value;
			}
		}

		/// <summary>Освобождает дескриптор <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="regionHandle">Дескриптор <see cref="T:System.Drawing.Region" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="regionHandle" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600074D RID: 1869 RVA: 0x00015B8C File Offset: 0x00013D8C
		public void ReleaseHrgn(IntPtr regionHandle)
		{
			if (regionHandle == IntPtr.Zero)
			{
				throw new ArgumentNullException("regionHandle");
			}
			Status status = Status.Ok;
			if (GDIPlus.RunningOnUnix())
			{
				status = GDIPlus.GdipDeleteRegion(regionHandle);
			}
			else if (!GDIPlus.DeleteObject(regionHandle))
			{
				status = Status.InvalidParameter;
			}
			GDIPlus.CheckStatus(status);
		}

		// Token: 0x04000566 RID: 1382
		private IntPtr nativeRegion = IntPtr.Zero;
	}
}
