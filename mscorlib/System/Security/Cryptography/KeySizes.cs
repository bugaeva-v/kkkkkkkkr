using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Определяет набор допустимых размеров ключа для симметричных алгоритмов шифрования.</summary>
	// Token: 0x02000482 RID: 1154
	[ComVisible(true)]
	public sealed class KeySizes
	{
		/// <summary>Задает минимальный размер ключа в битах.</summary>
		/// <returns>Минимальный размер ключа в битах.</returns>
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x000A67D4 File Offset: 0x000A49D4
		public int MinSize
		{
			get
			{
				return this.m_minSize;
			}
		}

		/// <summary>Задает максимальный размер ключа в битах.</summary>
		/// <returns>Максимальный размер ключа в битах.</returns>
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002E90 RID: 11920 RVA: 0x000A67DC File Offset: 0x000A49DC
		public int MaxSize
		{
			get
			{
				return this.m_maxSize;
			}
		}

		/// <summary>Задает интервал между допустимыми размерами ключа в битах.</summary>
		/// <returns>Интервал между допустимыми размерами ключа в битах.</returns>
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x000A67E4 File Offset: 0x000A49E4
		public int SkipSize
		{
			get
			{
				return this.m_skipSize;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.KeySizes" /> с указанными значениями ключа.</summary>
		/// <param name="minSize">Минимально допустимый размер ключа.</param>
		/// <param name="maxSize">Максимально допустимый размер ключа.</param>
		/// <param name="skipSize">Интервал между допустимыми размерами ключа.</param>
		// Token: 0x06002E92 RID: 11922 RVA: 0x000A67EC File Offset: 0x000A49EC
		public KeySizes(int minSize, int maxSize, int skipSize)
		{
			this.m_minSize = minSize;
			this.m_maxSize = maxSize;
			this.m_skipSize = skipSize;
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000A680C File Offset: 0x000A4A0C
		internal bool IsLegal(int keySize)
		{
			int num = keySize - this.MinSize;
			bool flag = num >= 0 && keySize <= this.MaxSize;
			if (this.SkipSize != 0)
			{
				return flag && num % this.SkipSize == 0;
			}
			return flag;
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x000A6850 File Offset: 0x000A4A50
		internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size)
		{
			for (int i = 0; i < legalKeys.Length; i++)
			{
				if (legalKeys[i].IsLegal(size))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0400213F RID: 8511
		private int m_minSize;

		// Token: 0x04002140 RID: 8512
		private int m_maxSize;

		// Token: 0x04002141 RID: 8513
		private int m_skipSize;
	}
}
