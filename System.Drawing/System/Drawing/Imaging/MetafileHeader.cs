using System;
using System.Runtime.InteropServices;
using Unity;

namespace System.Drawing.Imaging
{
	/// <summary>Содержит атрибуты связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" />. Не наследуется.</summary>
	// Token: 0x0200011F RID: 287
	[MonoTODO("Metafiles, both WMF and EMF formats, aren't supported.")]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class MetafileHeader
	{
		// Token: 0x06000D58 RID: 3416 RVA: 0x0001EE63 File Offset: 0x0001D063
		internal MetafileHeader(IntPtr henhmetafile)
		{
			Marshal.PtrToStructure<MetafileHeader>(henhmetafile, this);
		}

		/// <summary>Возвращает значение, указывающее, является ли связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> аппаратно-зависимым.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> является аппаратно-зависимым; в противном случае возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000D59 RID: 3417 RVA: 0x0000C228 File Offset: 0x0000A428
		[MonoTODO("always returns false")]
		public bool IsDisplay()
		{
			return false;
		}

		/// <summary>Возвращает значение, указывающее, имеет ли связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> формат Windows EMF.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> имеет формат Windows EMF; в противном случае возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000D5A RID: 3418 RVA: 0x0001EE72 File Offset: 0x0001D072
		public bool IsEmf()
		{
			return this.Type == MetafileType.Emf;
		}

		/// <summary>Возвращает значение, указывающее, какой формат имеет связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> — Windows EMF или Windows EMF+.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> имеет формат Windows EMF или Windows EMF+; иначе возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000D5B RID: 3419 RVA: 0x0001EE7D File Offset: 0x0001D07D
		public bool IsEmfOrEmfPlus()
		{
			return this.Type >= MetafileType.Emf;
		}

		/// <summary>Возвращает значение, указывающее, является ли форматом связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> Windows EMF+.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> имеет формат Windows EMF+; в противном случае возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000D5C RID: 3420 RVA: 0x0001EE8B File Offset: 0x0001D08B
		public bool IsEmfPlus()
		{
			return this.Type >= MetafileType.EmfPlusOnly;
		}

		/// <summary>Возвращает значение, указывающее, имеет ли соответствующий объект <see cref="T:System.Drawing.Imaging.Metafile" /> формат расширенного метафайла Dual. Данный формат поддерживает как формат EMF, так и формат EMF+.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> имеет формат Dual; в противном случае возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000D5D RID: 3421 RVA: 0x0001EE99 File Offset: 0x0001D099
		public bool IsEmfPlusDual()
		{
			return this.Type == MetafileType.EmfPlusDual;
		}

		/// <summary>Возвращает значение, указывающее, поддерживает ли связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> только формат Windows EMF+.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> поддерживает только формат Windows EMF+; в противном случае возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000D5E RID: 3422 RVA: 0x0001EEA4 File Offset: 0x0001D0A4
		public bool IsEmfPlusOnly()
		{
			return this.Type == MetafileType.EmfPlusOnly;
		}

		/// <summary>Возвращает значение, указывающее, имеет ли связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> формат метафайла Windows.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> имеет формат метафайла Windows; в противном случае возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000D5F RID: 3423 RVA: 0x0001EEAF File Offset: 0x0001D0AF
		public bool IsWmf()
		{
			return this.Type <= MetafileType.WmfPlaceable;
		}

		/// <summary>Возвращает значение, указывающее, имеет ли связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> формат размещаемого метафайла Windows.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если связанный объект <see cref="T:System.Drawing.Imaging.Metafile" /> имеет формат размещаемого метафайла Windows; в противном случае возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000D60 RID: 3424 RVA: 0x0001EEBD File Offset: 0x0001D0BD
		public bool IsWmfPlaceable()
		{
			return this.Type == MetafileType.WmfPlaceable;
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Rectangle" />, ограничивающий связанный объект <see cref="T:System.Drawing.Imaging.Metafile" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Rectangle" />, ограничивающий связанный объект <see cref="T:System.Drawing.Imaging.Metafile" />.</returns>
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
		public Rectangle Bounds
		{
			get
			{
				return new Rectangle(this.header.x, this.header.y, this.header.width, this.header.height);
			}
		}

		/// <summary>Возвращает разрешение связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по горизонтали в точках на дюйм.</summary>
		/// <returns>Разрешение связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по горизонтали в точках на дюйм.</returns>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x0001EEFB File Offset: 0x0001D0FB
		public float DpiX
		{
			get
			{
				return this.header.dpi_x;
			}
		}

		/// <summary>Возвращает разрешение связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по вертикали в точках на дюйм.</summary>
		/// <returns>Разрешение связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по вертикали в точках на дюйм.</returns>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0001EF08 File Offset: 0x0001D108
		public float DpiY
		{
			get
			{
				return this.header.dpi_y;
			}
		}

		/// <summary>Получает размер расширенного метафайла и файла заголовка в байтах.</summary>
		/// <returns>Размер расширенного метафайла и файла заголовка в байтах.</returns>
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0001EF15 File Offset: 0x0001D115
		public int EmfPlusHeaderSize
		{
			get
			{
				return this.header.emfplus_header_size;
			}
		}

		/// <summary>Возвращает логическое разрешение связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по горизонтали в точках на дюйм.</summary>
		/// <returns>Логическое разрешение связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по горизонтали в точках на дюйм.</returns>
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0001EF22 File Offset: 0x0001D122
		public int LogicalDpiX
		{
			get
			{
				return this.header.logical_dpi_x;
			}
		}

		/// <summary>Возвращает логическое разрешение связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по вертикали в точках на дюйм.</summary>
		/// <returns>Логическое разрешение связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по вертикали в точках на дюйм.</returns>
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0001EF2F File Offset: 0x0001D12F
		public int LogicalDpiY
		{
			get
			{
				return this.header.logical_dpi_y;
			}
		}

		/// <summary>Возвращает размер связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> в байтах.</summary>
		/// <returns>Размер связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> в байтах.</returns>
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0001EF3C File Offset: 0x0001D13C
		public int MetafileSize
		{
			get
			{
				return this.header.size;
			}
		}

		/// <summary>Возвращает тип связанного объекта<see cref="T:System.Drawing.Imaging.Metafile" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.Imaging.MetafileType" />, представляющее тип связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" />.</returns>
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x0001EF49 File Offset: 0x0001D149
		public MetafileType Type
		{
			get
			{
				return this.header.type;
			}
		}

		/// <summary>Возвращает номер версии связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" />.</summary>
		/// <returns>Номер версии связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" />.</returns>
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0001EF56 File Offset: 0x0001D156
		public int Version
		{
			get
			{
				return this.header.version;
			}
		}

		/// <summary>Возвращает файл заголовка формата WMF для связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.MetaHeader" />, содержащий файл заголовка формата WMF для связанного объекта <see cref="T:System.Drawing.Imaging.Metafile" />.</returns>
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0001EF63 File Offset: 0x0001D163
		public MetaHeader WmfHeader
		{
			get
			{
				if (this.IsWmf())
				{
					return new MetaHeader(this.header.wmf_header);
				}
				throw new ArgumentException("WmfHeader only available on WMF files.");
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00005B7D File Offset: 0x00003D7D
		internal MetafileHeader()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000A9A RID: 2714
		private MonoMetafileHeader header;
	}
}
