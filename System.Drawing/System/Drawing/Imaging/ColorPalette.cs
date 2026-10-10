using System;
using System.Runtime.InteropServices;

namespace System.Drawing.Imaging
{
	/// <summary>Определяет массив цветов, образующий цветовую палитру. Цвета — это 32-разрядные цвета ARGB. Не наследуется.</summary>
	// Token: 0x020000FD RID: 253
	public sealed class ColorPalette
	{
		/// <summary>Возвращает значение, указывающее, как интерпретировать цветовую информацию в массиве цветов.</summary>
		/// <returns>Допустимы следующие значения флага: 
		/// 0x00000001 Значения цветов в массиве содержат сведения об альфа-составляющей.  
		/// 0x00000002 Цвета в массиве являются значениями черно-белого.  
		/// 0x00000004 Цвета в массиве являются полутонами.</returns>
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0001C101 File Offset: 0x0001A301
		public int Flags
		{
			get
			{
				return this._flags;
			}
		}

		/// <summary>Возвращает массив структур <see cref="T:System.Drawing.Color" />.</summary>
		/// <returns>Массив структур <see cref="T:System.Drawing.Color" />, который образует объект <see cref="T:System.Drawing.Imaging.ColorPalette" />.</returns>
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0001C109 File Offset: 0x0001A309
		public Color[] Entries
		{
			get
			{
				return this._entries;
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0001C111 File Offset: 0x0001A311
		internal ColorPalette(int count)
		{
			this._entries = new Color[count];
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0001C125 File Offset: 0x0001A325
		internal ColorPalette()
		{
			this._entries = new Color[1];
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0001C13C File Offset: 0x0001A33C
		internal void ConvertFromMemory(IntPtr memory)
		{
			this._flags = Marshal.ReadInt32(memory);
			int num = Marshal.ReadInt32((IntPtr)((long)memory + 4L));
			this._entries = new Color[num];
			for (int i = 0; i < num; i++)
			{
				int argb = Marshal.ReadInt32((IntPtr)((long)memory + 8L + (long)(i * 4)));
				this._entries[i] = Color.FromArgb(argb);
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		internal IntPtr ConvertToMemory()
		{
			int num = this._entries.Length;
			IntPtr intPtr;
			checked
			{
				intPtr = Marshal.AllocHGlobal(4 * (2 + num));
				Marshal.WriteInt32(intPtr, 0, this._flags);
				Marshal.WriteInt32((IntPtr)((long)intPtr + 4L), 0, num);
			}
			for (int i = 0; i < num; i++)
			{
				Marshal.WriteInt32((IntPtr)((long)intPtr + (long)(4 * (i + 2))), 0, this._entries[i].ToArgb());
			}
			return intPtr;
		}

		// Token: 0x0400086D RID: 2157
		private int _flags;

		// Token: 0x0400086E RID: 2158
		private Color[] _entries;
	}
}
