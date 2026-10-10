using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный базовый класс, от которого наследуются все классы, получающие последовательности байтов заданной длины.</summary>
	// Token: 0x02000487 RID: 1159
	[ComVisible(true)]
	public abstract class DeriveBytes : IDisposable
	{
		/// <summary>Если переопределено в производном классе, возвращает псевдослучайные байты ключа.</summary>
		/// <param name="cb">Число генерируемых псевдослучайных байтов ключа.</param>
		/// <returns>Массив байтов, заполненный псевдослучайными байтами ключа.</returns>
		// Token: 0x06002EB1 RID: 11953
		public abstract byte[] GetBytes(int cb);

		/// <summary>Если переопределено в производном классе, восстанавливает состояние данной операции.</summary>
		// Token: 0x06002EB2 RID: 11954
		public abstract void Reset();

		/// <summary>Если переопределено в производном классе, освобождает все ресурсы, используемые текущим объектом <see cref="T:System.Security.Cryptography.DeriveBytes" />.</summary>
		// Token: 0x06002EB3 RID: 11955 RVA: 0x000A6B1B File Offset: 0x000A4D1B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Если переопределено в производном классе, освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.Security.Cryptography.DeriveBytes" />, и опционально освобождает управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002EB4 RID: 11956 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
