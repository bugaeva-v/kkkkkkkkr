using System;
using System.IO;

namespace System.Drawing.Text
{
	/// <summary>Предоставляет коллекцию семейств шрифтов, созданных из файлов шрифтов, предоставленных клиентским приложением.</summary>
	// Token: 0x020000B6 RID: 182
	public sealed class PrivateFontCollection : FontCollection
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Text.PrivateFontCollection" />.</summary>
		// Token: 0x06000A6A RID: 2666 RVA: 0x00017C50 File Offset: 0x00015E50
		public PrivateFontCollection()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipNewPrivateFontCollection(out this._nativeFontCollection));
		}

		/// <summary>Добавляет шрифт из указанного файла в <see cref="T:System.Drawing.Text.PrivateFontCollection" />.</summary>
		/// <param name="filename">
		///   <see cref="T:System.String" /> содержит имя файла добавляемого шрифта.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный шрифт не поддерживается, или не удается найти файл шрифта.</exception>
		// Token: 0x06000A6B RID: 2667 RVA: 0x00017C68 File Offset: 0x00015E68
		public void AddFontFile(string filename)
		{
			if (filename == null)
			{
				throw new ArgumentNullException("filename");
			}
			string fullPath = Path.GetFullPath(filename);
			if (!File.Exists(fullPath))
			{
				throw new FileNotFoundException();
			}
			GDIPlus.CheckStatus(GDIPlus.GdipPrivateAddFontFile(this._nativeFontCollection, fullPath));
		}

		/// <summary>Добавляет шрифт из системной памяти в <see cref="T:System.Drawing.Text.PrivateFontCollection" />.</summary>
		/// <param name="memory">Адрес в памяти, по которому расположен добавляемый шрифт.</param>
		/// <param name="length">Объем памяти, занимаемый добавляемым шрифтом.</param>
		// Token: 0x06000A6C RID: 2668 RVA: 0x00017CA9 File Offset: 0x00015EA9
		public void AddMemoryFont(IntPtr memory, int length)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipPrivateAddMemoryFont(this._nativeFontCollection, memory, length));
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00017CBD File Offset: 0x00015EBD
		protected override void Dispose(bool disposing)
		{
			if (this._nativeFontCollection != IntPtr.Zero)
			{
				GDIPlus.GdipDeletePrivateFontCollection(ref this._nativeFontCollection);
				this._nativeFontCollection = IntPtr.Zero;
			}
			base.Dispose(disposing);
		}
	}
}
