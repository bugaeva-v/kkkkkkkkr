using System;
using System.Runtime.ExceptionServices;

namespace System.Security
{
	/// <summary>Представляет текст, который должен оставаться конфиденциальным, например, путем его удаления из памяти компьютера, если он больше не нужен. Этот класс не наследуется.</summary>
	// Token: 0x020003E4 RID: 996
	[MonoTODO("work in progress - encryption is missing")]
	public sealed class SecureString : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecureString" />.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка при защите значения этого экземпляра или снятии с него защиты.</exception>
		/// <exception cref="T:System.NotSupportedException">Эта операция не поддерживается этой платформой.</exception>
		// Token: 0x06002900 RID: 10496 RVA: 0x000948B8 File Offset: 0x00092AB8
		public SecureString()
		{
			this.Alloc(8, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecureString" /> из подмассива объектов <see cref="T:System.Char" />.  
		/// Этот конструктор несовместим с CLS. CLS-совместимая альтернатива — <see cref="M:System.Security.SecureString.#ctor" />.</summary>
		/// <param name="value">Указатель на массив объектов <see cref="T:System.Char" />.</param>
		/// <param name="length">Число элементов массива <paramref name="value" />, включаемых в новый экземпляр.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="length" /> меньше нуля или больше 65 536.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка при защите значения этой защищенной строки или снятии с него защиты.</exception>
		/// <exception cref="T:System.NotSupportedException">Эта операция не поддерживается этой платформой.</exception>
		// Token: 0x06002901 RID: 10497 RVA: 0x000948C8 File Offset: 0x00092AC8
		[CLSCompliant(false)]
		public unsafe SecureString(char* value, int length)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (length < 0 || length > 65536)
			{
				throw new ArgumentOutOfRangeException("length", "< 0 || > 65536");
			}
			this.length = length;
			this.Alloc(length, false);
			int num = 0;
			for (int i = 0; i < length; i++)
			{
				char c = *(value++);
				this.data[num++] = (byte)(c >> 8);
				this.data[num++] = (byte)c;
			}
			this.Encrypt();
		}

		/// <summary>Возвращает количество символов в текущей защищенной строке.</summary>
		/// <returns>Количество объектов <see cref="T:System.Char" /> в этой защищенной строке.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x00094950 File Offset: 0x00092B50
		public int Length
		{
			get
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException("SecureString");
				}
				return this.length;
			}
		}

		/// <summary>Добавляет знак в конец текущей защищенной строки.</summary>
		/// <param name="c">Знак, добавляемый к защищенной строке.</param>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данная защищенная строка доступна только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">При выполнении этой операции длина защищенной строки превысит 65 536 символов.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка при защите значения этой защищенной строки или снятии с него защиты.</exception>
		// Token: 0x06002903 RID: 10499 RVA: 0x0009496C File Offset: 0x00092B6C
		[HandleProcessCorruptedStateExceptions]
		public void AppendChar(char c)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("SecureString");
			}
			if (this.read_only)
			{
				throw new InvalidOperationException(Locale.GetText("SecureString is read-only."));
			}
			if (this.length == 65536)
			{
				throw new ArgumentOutOfRangeException("length", "> 65536");
			}
			try
			{
				this.Decrypt();
				int num = this.length * 2;
				int num2 = this.length + 1;
				this.length = num2;
				this.Alloc(num2, true);
				this.data[num++] = (byte)(c >> 8);
				this.data[num++] = (byte)c;
			}
			finally
			{
				this.Encrypt();
			}
		}

		/// <summary>Удаляет значение текущей защищенной строки.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данная защищенная строка доступна только для чтения.</exception>
		// Token: 0x06002904 RID: 10500 RVA: 0x00094A20 File Offset: 0x00092C20
		public void Clear()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("SecureString");
			}
			if (this.read_only)
			{
				throw new InvalidOperationException(Locale.GetText("SecureString is read-only."));
			}
			Array.Clear(this.data, 0, this.data.Length);
			this.length = 0;
		}

		/// <summary>Создает копию текущей защищенной строки.</summary>
		/// <returns>Копия этой защищенной строки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка при защите значения этой защищенной строки или снятии с него защиты.</exception>
		// Token: 0x06002905 RID: 10501 RVA: 0x00094A73 File Offset: 0x00092C73
		public SecureString Copy()
		{
			return new SecureString
			{
				data = (byte[])this.data.Clone(),
				length = this.length
			};
		}

		/// <summary>Освобождает все ресурсы, используемые текущим объектом <see cref="T:System.Security.SecureString" />.</summary>
		// Token: 0x06002906 RID: 10502 RVA: 0x00094A9C File Offset: 0x00092C9C
		[SecuritySafeCritical]
		public void Dispose()
		{
			this.disposed = true;
			if (this.data != null)
			{
				Array.Clear(this.data, 0, this.data.Length);
				this.data = null;
			}
			this.length = 0;
		}

		/// <summary>Вставляет знак в заданную индексом позицию защищенной строки.</summary>
		/// <param name="index">Индекс позиции вставки параметра <paramref name="c" />.</param>
		/// <param name="c">Вставляемый знак.</param>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данная защищенная строка доступна только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> менее нуля или более длины защищенной строки.  
		/// -или- 
		/// При выполнении этой операции длина защищенной строки превысит 65 536 символов.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка при защите значения этой защищенной строки или снятии с него защиты.</exception>
		// Token: 0x06002907 RID: 10503 RVA: 0x00094AD0 File Offset: 0x00092CD0
		[HandleProcessCorruptedStateExceptions]
		public void InsertAt(int index, char c)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("SecureString");
			}
			if (this.read_only)
			{
				throw new InvalidOperationException(Locale.GetText("SecureString is read-only."));
			}
			if (index < 0 || index > this.length)
			{
				throw new ArgumentOutOfRangeException("index", "< 0 || > length");
			}
			if (this.length >= 65536)
			{
				string text = Locale.GetText("Maximum string size is '{0}'.", new object[]
				{
					65536
				});
				throw new ArgumentOutOfRangeException("index", text);
			}
			try
			{
				this.Decrypt();
				int num = this.length + 1;
				this.length = num;
				this.Alloc(num, true);
				int num2 = index * 2;
				Buffer.BlockCopy(this.data, num2, this.data, num2 + 2, this.data.Length - num2 - 2);
				this.data[num2++] = (byte)(c >> 8);
				this.data[num2] = (byte)c;
			}
			finally
			{
				this.Encrypt();
			}
		}

		/// <summary>Указывает, что защищенная строка доступна только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если защищенная строка доступна только для чтения; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		// Token: 0x06002908 RID: 10504 RVA: 0x00094BD4 File Offset: 0x00092DD4
		public bool IsReadOnly()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("SecureString");
			}
			return this.read_only;
		}

		/// <summary>Делает текстовое значение этой защищенной строки доступным только для чтения.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		// Token: 0x06002909 RID: 10505 RVA: 0x00094BEF File Offset: 0x00092DEF
		public void MakeReadOnly()
		{
			this.read_only = true;
		}

		/// <summary>Удаляет из защищенной строки знак, расположенный по указанному индексу.</summary>
		/// <param name="index">Индекс знака в защищенной строке.</param>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данная защищенная строка доступна только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> меньше нуля или больше или равно длине данной защищенной строки.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка при защите значения этой защищенной строки или снятии с него защиты.</exception>
		// Token: 0x0600290A RID: 10506 RVA: 0x00094BF8 File Offset: 0x00092DF8
		[HandleProcessCorruptedStateExceptions]
		public void RemoveAt(int index)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("SecureString");
			}
			if (this.read_only)
			{
				throw new InvalidOperationException(Locale.GetText("SecureString is read-only."));
			}
			if (index < 0 || index >= this.length)
			{
				throw new ArgumentOutOfRangeException("index", "< 0 || > length");
			}
			try
			{
				this.Decrypt();
				Buffer.BlockCopy(this.data, index * 2 + 2, this.data, index * 2, this.data.Length - index * 2 - 2);
				int num = this.length - 1;
				this.length = num;
				this.Alloc(num, true);
			}
			finally
			{
				this.Encrypt();
			}
		}

		/// <summary>Заменяет расположенный по указанному индексу знак другим знаком.</summary>
		/// <param name="index">Индекс имеющегося знака в защищенной строке.</param>
		/// <param name="c">Знак, заменяющий имеющийся знак.</param>
		/// <exception cref="T:System.ObjectDisposedException">Защищенная строка уже удалена.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данная защищенная строка доступна только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> меньше нуля или больше или равно длине данной защищенной строки.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка при защите значения этой защищенной строки или снятии с него защиты.</exception>
		// Token: 0x0600290B RID: 10507 RVA: 0x00094CAC File Offset: 0x00092EAC
		[HandleProcessCorruptedStateExceptions]
		public void SetAt(int index, char c)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("SecureString");
			}
			if (this.read_only)
			{
				throw new InvalidOperationException(Locale.GetText("SecureString is read-only."));
			}
			if (index < 0 || index >= this.length)
			{
				throw new ArgumentOutOfRangeException("index", "< 0 || > length");
			}
			try
			{
				this.Decrypt();
				int num = index * 2;
				this.data[num++] = (byte)(c >> 8);
				this.data[num] = (byte)c;
			}
			finally
			{
				this.Encrypt();
			}
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00094D40 File Offset: 0x00092F40
		private void Encrypt()
		{
			if (this.data != null)
			{
				int num = this.data.Length;
			}
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00094D40 File Offset: 0x00092F40
		private void Decrypt()
		{
			if (this.data != null)
			{
				int num = this.data.Length;
			}
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00094D54 File Offset: 0x00092F54
		private void Alloc(int length, bool realloc)
		{
			if (length < 0 || length > 65536)
			{
				throw new ArgumentOutOfRangeException("length", "< 0 || > 65536");
			}
			int num = (length >> 3) + (((length & 7) == 0) ? 0 : 1) << 4;
			if (realloc && this.data != null && num == this.data.Length)
			{
				return;
			}
			if (realloc)
			{
				byte[] array = new byte[num];
				Array.Copy(this.data, 0, array, 0, Math.Min(this.data.Length, array.Length));
				Array.Clear(this.data, 0, this.data.Length);
				this.data = array;
				return;
			}
			this.data = new byte[num];
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00094DF4 File Offset: 0x00092FF4
		internal byte[] GetBuffer()
		{
			byte[] array = new byte[this.length << 1];
			try
			{
				this.Decrypt();
				Buffer.BlockCopy(this.data, 0, array, 0, array.Length);
			}
			finally
			{
				this.Encrypt();
			}
			return array;
		}

		// Token: 0x04001ECC RID: 7884
		private const int BlockSize = 16;

		// Token: 0x04001ECD RID: 7885
		private const int MaxSize = 65536;

		// Token: 0x04001ECE RID: 7886
		private int length;

		// Token: 0x04001ECF RID: 7887
		private bool disposed;

		// Token: 0x04001ED0 RID: 7888
		private bool read_only;

		// Token: 0x04001ED1 RID: 7889
		private byte[] data;
	}
}
