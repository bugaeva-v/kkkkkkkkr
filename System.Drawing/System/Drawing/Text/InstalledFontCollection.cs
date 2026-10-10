using System;

namespace System.Drawing.Text
{
	/// <summary>Представляет установленные в системе шрифты. Этот класс не наследуется.</summary>
	// Token: 0x020000B4 RID: 180
	public sealed class InstalledFontCollection : FontCollection
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Text.InstalledFontCollection" />.</summary>
		// Token: 0x06000A69 RID: 2665 RVA: 0x00017C38 File Offset: 0x00015E38
		public InstalledFontCollection()
		{
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipNewInstalledFontCollection(out this._nativeFontCollection));
		}
	}
}
