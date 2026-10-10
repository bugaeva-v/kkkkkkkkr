using System;
using System.Runtime.InteropServices;

namespace System.Drawing.Text
{
	/// <summary>Предоставляет базовый класс для установленных и закрытых коллекций шрифтов.</summary>
	// Token: 0x020000B1 RID: 177
	public abstract class FontCollection : IDisposable
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00017B65 File Offset: 0x00015D65
		internal FontCollection()
		{
			this._nativeFontCollection = IntPtr.Zero;
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Text.FontCollection" />.</summary>
		// Token: 0x06000A65 RID: 2661 RVA: 0x00017B78 File Offset: 0x00015D78
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Drawing.Text.FontCollection" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06000A66 RID: 2662 RVA: 0x000049FE File Offset: 0x00002BFE
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Получает массив объектов <see cref="T:System.Drawing.FontFamily" />, связанных с <see cref="T:System.Drawing.Text.FontCollection" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Drawing.FontFamily" />.</returns>
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00017B88 File Offset: 0x00015D88
		public FontFamily[] Families
		{
			get
			{
				int num = 0;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetFontCollectionFamilyCount(new HandleRef(this, this._nativeFontCollection), out num));
				IntPtr[] array = new IntPtr[num];
				int num2 = 0;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetFontCollectionFamilyList(new HandleRef(this, this._nativeFontCollection), num, array, out num2));
				FontFamily[] array2 = new FontFamily[num2];
				for (int i = 0; i < num2; i++)
				{
					IntPtr fntfamily;
					GDIPlus.GdipCloneFontFamily(new HandleRef(null, array[i]), out fntfamily);
					array2[i] = new FontFamily(fntfamily);
				}
				return array2;
			}
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x06000A68 RID: 2664 RVA: 0x00017C08 File Offset: 0x00015E08
		~FontCollection()
		{
			this.Dispose(false);
		}

		// Token: 0x0400064D RID: 1613
		internal IntPtr _nativeFontCollection;
	}
}
