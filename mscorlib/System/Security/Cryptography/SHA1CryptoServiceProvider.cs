using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет значение хэша <see cref="T:System.Security.Cryptography.SHA1" /> для входных данных с помощью реализации, предоставляемой поставщиком служб шифрования (CSP). Этот класс не наследуется.</summary>
	// Token: 0x020004D0 RID: 1232
	[ComVisible(true)]
	public sealed class SHA1CryptoServiceProvider : SHA1
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />.</summary>
		// Token: 0x0600314B RID: 12619 RVA: 0x000B6A3C File Offset: 0x000B4C3C
		public SHA1CryptoServiceProvider()
		{
			this.sha = new SHA1Internal();
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x000B6A50 File Offset: 0x000B4C50
		~SHA1CryptoServiceProvider()
		{
			this.Dispose(false);
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x000B6A80 File Offset: 0x000B4C80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x000B6A89 File Offset: 0x000B4C89
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			this.State = 1;
			this.sha.HashCore(rgb, ibStart, cbSize);
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000B6AA0 File Offset: 0x000B4CA0
		protected override byte[] HashFinal()
		{
			this.State = 0;
			return this.sha.HashFinal();
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />.</summary>
		// Token: 0x06003150 RID: 12624 RVA: 0x000B6AB4 File Offset: 0x000B4CB4
		public override void Initialize()
		{
			this.sha.Initialize();
		}

		// Token: 0x04002277 RID: 8823
		private SHA1Internal sha;
	}
}
