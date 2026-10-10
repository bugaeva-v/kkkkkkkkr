using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Cryptography
{
	/// <summary>Преобразует поток <see cref="T:System.Security.Cryptography.CryptoStream" /> из кодировки base64.</summary>
	// Token: 0x0200047F RID: 1151
	[ComVisible(true)]
	public class FromBase64Transform : ICryptoTransform, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.FromBase64Transform" />.</summary>
		// Token: 0x06002E81 RID: 11905 RVA: 0x000A640C File Offset: 0x000A460C
		public FromBase64Transform() : this(FromBase64TransformMode.IgnoreWhiteSpaces)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.FromBase64Transform" /> в соответствии с заданным режимом преобразования.</summary>
		/// <param name="whitespaces">Одно из значений перечисления <see cref="T:System.Security.Cryptography.FromBase64Transform" />.</param>
		// Token: 0x06002E82 RID: 11906 RVA: 0x000A6415 File Offset: 0x000A4615
		public FromBase64Transform(FromBase64TransformMode whitespaces)
		{
			this._whitespaces = whitespaces;
			this._inputIndex = 0;
		}

		/// <summary>Возвращает размер входного блока.</summary>
		/// <returns>Размер входного блока данных в байтах.</returns>
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x000040F7 File Offset: 0x000022F7
		public int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		/// <summary>Возвращает размер выходного блока.</summary>
		/// <returns>Размер выходного блока данных в байтах.</returns>
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002E84 RID: 11908 RVA: 0x000221D2 File Offset: 0x000203D2
		public int OutputBlockSize
		{
			get
			{
				return 3;
			}
		}

		/// <summary>Возвращает значение, указывающее на возможность преобразования нескольких блоков.</summary>
		/// <returns>Всегда <see langword="false" />.</returns>
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, указывающее, возможно ли повторное использование текущего преобразования.</summary>
		/// <returns>Всегда <see langword="true" />.</returns>
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		/// <summary>Преобразует заданную область входного массива байтов из кодировки base64 и копирует результат в заданную область выходного массива байтов.</summary>
		/// <param name="inputBuffer">Входные данные для вычисления преобразования из кодировки base64.</param>
		/// <param name="inputOffset">Смещение во входном массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="inputCount">Число байтов во входном массиве для использования в качестве данных.</param>
		/// <param name="outputBuffer">Выходной массив, в который записывается результат.</param>
		/// <param name="outputOffset">Смещение в выходном массиве байтов, начиная с которого следует записывать данные.</param>
		/// <returns>Число записанных байтов.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий объект <see cref="T:System.Security.Cryptography.FromBase64Transform" /> уже был удален.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение параметра <paramref name="inputCount" />.  
		///
		/// или - 
		/// Для параметра <paramref name="inputBuffer" /> задано недопустимое смещение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="inputOffset" /> выходит за пределы диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inputBuffer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002E87 RID: 11911 RVA: 0x000A6438 File Offset: 0x000A4638
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
			if (this._inputBuffer == null)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a disposed object."));
			}
			byte[] array = new byte[inputCount];
			int num;
			if (this._whitespaces == FromBase64TransformMode.IgnoreWhiteSpaces)
			{
				array = this.DiscardWhiteSpaces(inputBuffer, inputOffset, inputCount);
				num = array.Length;
			}
			else
			{
				Buffer.InternalBlockCopy(inputBuffer, inputOffset, array, 0, inputCount);
				num = inputCount;
			}
			if (num + this._inputIndex < 4)
			{
				Buffer.InternalBlockCopy(array, 0, this._inputBuffer, this._inputIndex, num);
				this._inputIndex += num;
				return 0;
			}
			int num2 = (num + this._inputIndex) / 4;
			byte[] array2 = new byte[this._inputIndex + num];
			Buffer.InternalBlockCopy(this._inputBuffer, 0, array2, 0, this._inputIndex);
			Buffer.InternalBlockCopy(array, 0, array2, this._inputIndex, num);
			this._inputIndex = (num + this._inputIndex) % 4;
			Buffer.InternalBlockCopy(array, num - this._inputIndex, this._inputBuffer, 0, this._inputIndex);
			byte[] array3 = Convert.FromBase64CharArray(Encoding.ASCII.GetChars(array2, 0, 4 * num2), 0, 4 * num2);
			Buffer.BlockCopy(array3, 0, outputBuffer, outputOffset, array3.Length);
			return array3.Length;
		}

		/// <summary>Преобразует заданную область заданного массива байтов из кодировки base64.</summary>
		/// <param name="inputBuffer">Входные данные, которые необходимо преобразовать из кодировки base64.</param>
		/// <param name="inputOffset">Смещение в массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="inputCount">Число байтов в массиве для использования в качестве данных.</param>
		/// <returns>Вычисляемое преобразование.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий объект <see cref="T:System.Security.Cryptography.FromBase64Transform" /> уже был удален.</exception>
		/// <exception cref="T:System.ArgumentException">Для параметра <paramref name="inputBuffer" /> задано недопустимое смещение.  
		///
		/// или - 
		/// Недопустимое значение параметра <paramref name="inputCount" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="inputOffset" /> выходит за пределы диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inputBuffer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002E88 RID: 11912 RVA: 0x000A65AC File Offset: 0x000A47AC
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
			if (this._inputBuffer == null)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a disposed object."));
			}
			byte[] array = new byte[inputCount];
			int num;
			if (this._whitespaces == FromBase64TransformMode.IgnoreWhiteSpaces)
			{
				array = this.DiscardWhiteSpaces(inputBuffer, inputOffset, inputCount);
				num = array.Length;
			}
			else
			{
				Buffer.InternalBlockCopy(inputBuffer, inputOffset, array, 0, inputCount);
				num = inputCount;
			}
			if (num + this._inputIndex < 4)
			{
				this.Reset();
				return EmptyArray<byte>.Value;
			}
			int num2 = (num + this._inputIndex) / 4;
			byte[] array2 = new byte[this._inputIndex + num];
			Buffer.InternalBlockCopy(this._inputBuffer, 0, array2, 0, this._inputIndex);
			Buffer.InternalBlockCopy(array, 0, array2, this._inputIndex, num);
			this._inputIndex = (num + this._inputIndex) % 4;
			Buffer.InternalBlockCopy(array, num - this._inputIndex, this._inputBuffer, 0, this._inputIndex);
			byte[] result = Convert.FromBase64CharArray(Encoding.ASCII.GetChars(array2, 0, 4 * num2), 0, 4 * num2);
			this.Reset();
			return result;
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000A66F8 File Offset: 0x000A48F8
		private byte[] DiscardWhiteSpaces(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			int num = 0;
			for (int i = 0; i < inputCount; i++)
			{
				if (char.IsWhiteSpace((char)inputBuffer[inputOffset + i]))
				{
					num++;
				}
			}
			byte[] array = new byte[inputCount - num];
			num = 0;
			for (int i = 0; i < inputCount; i++)
			{
				if (!char.IsWhiteSpace((char)inputBuffer[inputOffset + i]))
				{
					array[num++] = inputBuffer[inputOffset + i];
				}
			}
			return array;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.FromBase64Transform" />.</summary>
		// Token: 0x06002E8A RID: 11914 RVA: 0x000A6753 File Offset: 0x000A4953
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000A6762 File Offset: 0x000A4962
		private void Reset()
		{
			this._inputIndex = 0;
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Security.Cryptography.FromBase64Transform" />.</summary>
		// Token: 0x06002E8C RID: 11916 RVA: 0x000A676B File Offset: 0x000A496B
		public void Clear()
		{
			this.Dispose();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.FromBase64Transform" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002E8D RID: 11917 RVA: 0x000A6773 File Offset: 0x000A4973
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this._inputBuffer != null)
				{
					Array.Clear(this._inputBuffer, 0, this._inputBuffer.Length);
				}
				this._inputBuffer = null;
				this._inputIndex = 0;
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые <see cref="T:System.Security.Cryptography.FromBase64Transform" />.</summary>
		// Token: 0x06002E8E RID: 11918 RVA: 0x000A67A4 File Offset: 0x000A49A4
		~FromBase64Transform()
		{
			this.Dispose(false);
		}

		// Token: 0x04002130 RID: 8496
		private byte[] _inputBuffer = new byte[4];

		// Token: 0x04002131 RID: 8497
		private int _inputIndex;

		// Token: 0x04002132 RID: 8498
		private FromBase64TransformMode _whitespaces;
	}
}
