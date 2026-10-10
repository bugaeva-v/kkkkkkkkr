using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Cryptography
{
	/// <summary>Преобразует <see cref="T:System.Security.Cryptography.CryptoStream" /> в кодировку base64.</summary>
	// Token: 0x0200047E RID: 1150
	[ComVisible(true)]
	public class ToBase64Transform : ICryptoTransform, IDisposable
	{
		/// <summary>Возвращает размер входного блока.</summary>
		/// <returns>Размер входного блока данных в байтах.</returns>
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002E76 RID: 11894 RVA: 0x000221D2 File Offset: 0x000203D2
		public int InputBlockSize
		{
			get
			{
				return 3;
			}
		}

		/// <summary>Возвращает размер выходного блока.</summary>
		/// <returns>Размер выходного блока данных в байтах.</returns>
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x00022807 File Offset: 0x00020A07
		public int OutputBlockSize
		{
			get
			{
				return 4;
			}
		}

		/// <summary>Возвращает значение, указывающее на возможность преобразования нескольких блоков.</summary>
		/// <returns>Всегда <see langword="false" />.</returns>
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, указывающее, возможно ли повторное использование текущего преобразования.</summary>
		/// <returns>Всегда <see langword="true" />.</returns>
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		/// <summary>Преобразует заданную область входного массива байтов в кодировку base64 и копирует результат в заданную область выходного массива байтов.</summary>
		/// <param name="inputBuffer">Входные данные, подлежащие преобразованию в кодировку base64.</param>
		/// <param name="inputOffset">Смещение во входном массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="inputCount">Число байтов во входном массиве для использования в качестве данных.</param>
		/// <param name="outputBuffer">Выходной массив, в который записывается результат.</param>
		/// <param name="outputOffset">Смещение в выходном массиве байтов, начиная с которого следует записывать данные.</param>
		/// <returns>Число записанных байтов.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий объект <see cref="T:System.Security.Cryptography.ToBase64Transform" /> уже был удален.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый размер данных.</exception>
		/// <exception cref="T:System.ArgumentException">Для параметра <paramref name="inputBuffer" /> задано недопустимое значение смещения.  
		///
		/// или - 
		/// Параметр <paramref name="inputCount" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="inputBuffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="inputBuffer" /> не должно быть отрицательным.</exception>
		// Token: 0x06002E7A RID: 11898 RVA: 0x000A628C File Offset: 0x000A448C
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException("inputBuffer");
			}
			if (inputOffset < 0)
			{
				throw new ArgumentOutOfRangeException("inputOffset", Environment.GetResourceString("Non-negative number required."));
			}
			if (inputCount < 0 || inputCount > inputBuffer.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("Value was invalid."));
			}
			if (inputBuffer.Length - inputCount < inputOffset)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			char[] array = new char[4];
			Convert.ToBase64CharArray(inputBuffer, inputOffset, 3, array, 0);
			byte[] bytes = Encoding.ASCII.GetBytes(array);
			if (bytes.Length != 4)
			{
				throw new CryptographicException(Environment.GetResourceString("Length of the data to encrypt is invalid."));
			}
			Buffer.BlockCopy(bytes, 0, outputBuffer, outputOffset, bytes.Length);
			return bytes.Length;
		}

		/// <summary>Преобразует заданную область заданного массива байтов в кодировку base64.</summary>
		/// <param name="inputBuffer">Входные данные, подлежащие преобразованию в кодировку base64.</param>
		/// <param name="inputOffset">Смещение в массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="inputCount">Число байтов в массиве для использования в качестве данных.</param>
		/// <returns>Вычисляемое преобразование в кодировку base64.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий объект <see cref="T:System.Security.Cryptography.ToBase64Transform" /> уже был удален.</exception>
		/// <exception cref="T:System.ArgumentException">Для параметра <paramref name="inputBuffer" /> задано недопустимое значение смещения.  
		///
		/// или - 
		/// Параметр <paramref name="inputCount" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="inputBuffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="inputBuffer" /> не должно быть отрицательным.</exception>
		// Token: 0x06002E7B RID: 11899 RVA: 0x000A6338 File Offset: 0x000A4538
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException("inputBuffer");
			}
			if (inputOffset < 0)
			{
				throw new ArgumentOutOfRangeException("inputOffset", Environment.GetResourceString("Non-negative number required."));
			}
			if (inputCount < 0 || inputCount > inputBuffer.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("Value was invalid."));
			}
			if (inputBuffer.Length - inputCount < inputOffset)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			if (inputCount == 0)
			{
				return EmptyArray<byte>.Value;
			}
			char[] array = new char[4];
			Convert.ToBase64CharArray(inputBuffer, inputOffset, inputCount, array, 0);
			return Encoding.ASCII.GetBytes(array);
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.ToBase64Transform" />.</summary>
		// Token: 0x06002E7C RID: 11900 RVA: 0x000A63C4 File Offset: 0x000A45C4
		public void Dispose()
		{
			this.Clear();
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Security.Cryptography.ToBase64Transform" />.</summary>
		// Token: 0x06002E7D RID: 11901 RVA: 0x000A63CC File Offset: 0x000A45CC
		public void Clear()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.ToBase64Transform" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002E7E RID: 11902 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые <see cref="T:System.Security.Cryptography.ToBase64Transform" />.</summary>
		// Token: 0x06002E7F RID: 11903 RVA: 0x000A63DC File Offset: 0x000A45DC
		~ToBase64Transform()
		{
			this.Dispose(false);
		}
	}
}
