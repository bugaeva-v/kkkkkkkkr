using System;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет маски, соответствующие стандарту PKCS #1, для использования алгоритмами обмена ключами.</summary>
	// Token: 0x0200049F RID: 1183
	[ComVisible(true)]
	public class PKCS1MaskGenerationMethod : MaskGenerationMethod
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PKCS1MaskGenerationMethod" />.</summary>
		// Token: 0x06002F5C RID: 12124 RVA: 0x000A8C4B File Offset: 0x000A6E4B
		public PKCS1MaskGenerationMethod()
		{
			this.HashNameValue = "SHA1";
		}

		/// <summary>Возвращает или задает имя типа хэш-алгоритма, используемого для создания маски.</summary>
		/// <returns>Имя типа, который реализует хэш-алгоритм для вычисления маски.</returns>
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x000A8C5E File Offset: 0x000A6E5E
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x000A8C66 File Offset: 0x000A6E66
		public string HashName
		{
			get
			{
				return this.HashNameValue;
			}
			set
			{
				this.HashNameValue = value;
				if (this.HashNameValue == null)
				{
					this.HashNameValue = "SHA1";
				}
			}
		}

		/// <summary>Создает и возвращает маску из заданного случайного начального значения указанной длины.</summary>
		/// <param name="rgbSeed">Случайное начальное значение, используемое для вычисления маски.</param>
		/// <param name="cbReturn">Длина создаваемой маски в байтах.</param>
		/// <returns>Созданная случайным образом маска, длина которой равна значению параметра <paramref name="cbReturn" />.</returns>
		// Token: 0x06002F5F RID: 12127 RVA: 0x000A8C82 File Offset: 0x000A6E82
		public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn)
		{
			return PKCS1.MGF1(HashAlgorithm.Create(this.HashNameValue), rgbSeed, cbReturn);
		}

		// Token: 0x04002191 RID: 8593
		private string HashNameValue;
	}
}
