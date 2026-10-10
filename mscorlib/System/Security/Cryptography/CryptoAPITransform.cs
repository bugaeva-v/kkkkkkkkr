using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>Выполняет криптографическое преобразование данных. Этот класс не наследуется.</summary>
	// Token: 0x020004C5 RID: 1221
	[ComVisible(true)]
	public sealed class CryptoAPITransform : ICryptoTransform, IDisposable
	{
		// Token: 0x060030CD RID: 12493 RVA: 0x000B1A0F File Offset: 0x000AFC0F
		internal CryptoAPITransform()
		{
			this.m_disposed = false;
		}

		/// <summary>Возвращает значение, указывающее, возможно ли повторное использование текущего преобразования.</summary>
		/// <returns>Всегда <see langword="true" />.</returns>
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x000040F7 File Offset: 0x000022F7
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение, указывающее на возможность преобразования нескольких блоков.</summary>
		/// <returns>Значение <see langword="true" />, если возможно преобразование нескольких блоков; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x000040F7 File Offset: 0x000022F7
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает размер входного блока.</summary>
		/// <returns>Размер входного блока в байтах.</returns>
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public int InputBlockSize
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Получает дескриптор ключа.</summary>
		/// <returns>Дескриптор ключа.</returns>
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x000B1A1E File Offset: 0x000AFC1E
		public IntPtr KeyHandle
		{
			[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
			get
			{
				return IntPtr.Zero;
			}
		}

		/// <summary>Возвращает размер выходного блока.</summary>
		/// <returns>Размер выходного блока в байтах.</returns>
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public int OutputBlockSize
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.CryptoAPITransform" />.</summary>
		// Token: 0x060030D3 RID: 12499 RVA: 0x000B1A25 File Offset: 0x000AFC25
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает все ресурсы, используемые методом <see cref="T:System.Security.Cryptography.CryptoAPITransform" />.</summary>
		// Token: 0x060030D4 RID: 12500 RVA: 0x000B1A34 File Offset: 0x000AFC34
		public void Clear()
		{
			this.Dispose(false);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x000B1A3D File Offset: 0x000AFC3D
		private void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				this.m_disposed = true;
			}
		}

		/// <summary>Вычисляет преобразование для заданной области входного массива байтов и копирует результирующее преобразование в заданную область выходного массива байтов.</summary>
		/// <param name="inputBuffer">Входные данные для выполнения операции.</param>
		/// <param name="inputOffset">Позиция во входном массиве байтов, начиная с которой следует использовать данные.</param>
		/// <param name="inputCount">Число байтов во входном массиве для использования в качестве данных.</param>
		/// <param name="outputBuffer">Объект для записи выходных данных.</param>
		/// <param name="outputOffset">Позиция в выходном массиве байтов, начиная с которой следует записывать данные.</param>
		/// <returns>Число записанных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="inputBuffer" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="outputBuffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина входного буфера меньше суммы начальной позиции и количества считываемых байтов.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="inputOffset" /> выходит за пределы диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		// Token: 0x060030D6 RID: 12502 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[SecuritySafeCritical]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		/// <summary>Вычисляет преобразование для заданной области заданного массива байтов.</summary>
		/// <param name="inputBuffer">Входные данные для выполнения операции.</param>
		/// <param name="inputOffset">Позиция в массиве байтов, начиная с которой следует использовать данные.</param>
		/// <param name="inputCount">Число байтов в массиве для использования в качестве данных.</param>
		/// <returns>Вычисленное преобразование.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="inputBuffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="inputOffset" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="inputCount" /> меньше нуля.  
		///
		/// или - 
		/// Длина входного буфера меньше суммы начальной позиции и количества считываемых байтов.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимое заполнение <see cref="F:System.Security.Cryptography.PaddingMode.PKCS7" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="inputOffset" /> вне диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		// Token: 0x060030D7 RID: 12503 RVA: 0x0000AF5E File Offset: 0x0000915E
		[SecuritySafeCritical]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		/// <summary>Восстанавливает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.CryptoAPITransform" />, чтобы его можно было использовать для новых операций расшифрования и зашифрования.</summary>
		// Token: 0x060030D8 RID: 12504 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ComVisible(false)]
		public void Reset()
		{
		}

		// Token: 0x04002243 RID: 8771
		private bool m_disposed;
	}
}
