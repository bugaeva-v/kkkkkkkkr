using System;
using System.Globalization;

namespace System.Text
{
	/// <summary>Предоставляет буфер, позволяющий резервному обработчику возвращать в декодер альтернативную строку, если он не может декодировать входную последовательность байтов.</summary>
	// Token: 0x02000397 RID: 919
	public abstract class DecoderFallbackBuffer
	{
		/// <summary>При переопределении в производном классе готовит резервный буфер для обработки указанной входной последовательности байтов.</summary>
		/// <param name="bytesUnknown">Входной массив байтов.</param>
		/// <param name="index">Позиция байта в <paramref name="bytesUnknown" />.</param>
		/// <returns>
		///   <see langword="true" />, если резервный буфер может обработать <paramref name="bytesUnknown" />; <see langword="false" />, если резервный буфер игнорирует <paramref name="bytesUnknown" />.</returns>
		// Token: 0x060025BE RID: 9662
		public abstract bool Fallback(byte[] bytesUnknown, int index);

		/// <summary>При переопределении в производном классе извлекает следующий символ в резервном буфере.</summary>
		/// <returns>Следующий символ в резервном буфере.</returns>
		// Token: 0x060025BF RID: 9663
		public abstract char GetNextChar();

		/// <summary>При переопределении в производный класс становится причиной того, что в следующем вызове метод <see cref="M:System.Text.DecoderFallbackBuffer.GetNextChar" /> получает доступ к позиции символа в буфере данных, предшествующей текущей позиции символа.</summary>
		/// <returns>Значение <see langword="true" />, если операция <see cref="M:System.Text.DecoderFallbackBuffer.MovePrevious" /> выполнена успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060025C0 RID: 9664
		public abstract bool MovePrevious();

		/// <summary>При переопределении в производном классе возвращает максимальное число символов в текущем объекте <see cref="T:System.Text.DecoderFallbackBuffer" />, которые остаются для обработки.</summary>
		/// <returns>Количество символов в текущем резервном буфере, которые еще не были обработаны.</returns>
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060025C1 RID: 9665
		public abstract int Remaining { get; }

		/// <summary>Инициализирует все данные и сведения о состоянии, относящиеся к этому резервному буферу.</summary>
		// Token: 0x060025C2 RID: 9666 RVA: 0x00086073 File Offset: 0x00084273
		public virtual void Reset()
		{
			while (this.GetNextChar() != '\0')
			{
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0008607D File Offset: 0x0008427D
		internal void InternalReset()
		{
			this.byteStart = null;
			this.Reset();
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0008608D File Offset: 0x0008428D
		internal unsafe void InternalInitialize(byte* byteStart, char* charEnd)
		{
			this.byteStart = byteStart;
			this.charEnd = charEnd;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x000860A0 File Offset: 0x000842A0
		internal unsafe virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars)
		{
			if (this.Fallback(bytes, (int)((long)(pBytes - this.byteStart) - (long)bytes.Length)))
			{
				char* ptr = chars;
				bool flag = false;
				char nextChar;
				while ((nextChar = this.GetNextChar()) != '\0')
				{
					if (char.IsSurrogate(nextChar))
					{
						if (char.IsHighSurrogate(nextChar))
						{
							if (flag)
							{
								throw new ArgumentException("String contains invalid Unicode code points.");
							}
							flag = true;
						}
						else
						{
							if (!flag)
							{
								throw new ArgumentException("String contains invalid Unicode code points.");
							}
							flag = false;
						}
					}
					if (ptr >= this.charEnd)
					{
						return false;
					}
					*(ptr++) = nextChar;
				}
				if (flag)
				{
					throw new ArgumentException("String contains invalid Unicode code points.");
				}
				chars = ptr;
			}
			return true;
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00086130 File Offset: 0x00084330
		internal unsafe virtual int InternalFallback(byte[] bytes, byte* pBytes)
		{
			if (!this.Fallback(bytes, (int)((long)(pBytes - this.byteStart) - (long)bytes.Length)))
			{
				return 0;
			}
			int num = 0;
			bool flag = false;
			char nextChar;
			while ((nextChar = this.GetNextChar()) != '\0')
			{
				if (char.IsSurrogate(nextChar))
				{
					if (char.IsHighSurrogate(nextChar))
					{
						if (flag)
						{
							throw new ArgumentException("String contains invalid Unicode code points.");
						}
						flag = true;
					}
					else
					{
						if (!flag)
						{
							throw new ArgumentException("String contains invalid Unicode code points.");
						}
						flag = false;
					}
				}
				num++;
			}
			if (flag)
			{
				throw new ArgumentException("String contains invalid Unicode code points.");
			}
			return num;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000861B0 File Offset: 0x000843B0
		internal void ThrowLastBytesRecursive(byte[] bytesUnknown)
		{
			StringBuilder stringBuilder = new StringBuilder(bytesUnknown.Length * 3);
			int num = 0;
			while (num < bytesUnknown.Length && num < 20)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "\\x{0:X2}", bytesUnknown[num]);
				num++;
			}
			if (num == 20)
			{
				stringBuilder.Append(" ...");
			}
			throw new ArgumentException(SR.Format("Recursive fallback not allowed for bytes {0}.", stringBuilder.ToString()), "bytesUnknown");
		}

		// Token: 0x04001D9A RID: 7578
		internal unsafe byte* byteStart;

		// Token: 0x04001D9B RID: 7579
		internal unsafe char* charEnd;
	}
}
