using System;

namespace System.Net.Sockets
{
	/// <summary>Представляет элемент в массиве <see cref="T:System.Net.Sockets.SendPacketsElement" />.</summary>
	// Token: 0x020007B0 RID: 1968
	public class SendPacketsElement
	{
		// Token: 0x06003EBA RID: 16058 RVA: 0x0000219B File Offset: 0x0000039B
		private SendPacketsElement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SendPacketsElement" />, используя указанный файл.</summary>
		/// <param name="filepath">Имя файла, передаваемого с помощью метода <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="filepath" /> не может иметь значение null</exception>
		// Token: 0x06003EBB RID: 16059 RVA: 0x000D693C File Offset: 0x000D4B3C
		public SendPacketsElement(string filepath) : this(filepath, 0, 0, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SendPacketsElement" />, используя указанные имя файла, смещение и количество.</summary>
		/// <param name="filepath">Имя файла, передаваемого с помощью метода <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.</param>
		/// <param name="offset">Смещение (в байтах) от начала файла до места в нем, с которого начинается отправка файла, указанного в параметре <paramref name="filepath" />.</param>
		/// <param name="count">Количество байтов, отправляемых, начиная со смещения, заданного параметром <paramref name="offset" />. Если значение <paramref name="count" /> равно нулю, отправляется весь файл целиком.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="filepath" /> не может иметь значение null</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значения параметров <paramref name="offset" /> и <paramref name="count" /> должны быть больше или равны нулю.  
		/// Значения параметров <paramref name="offset" /> и <paramref name="count" /> должны быть меньше размера файла, указанного в параметре <paramref name="filepath" />.</exception>
		// Token: 0x06003EBC RID: 16060 RVA: 0x000D6948 File Offset: 0x000D4B48
		public SendPacketsElement(string filepath, int offset, int count) : this(filepath, offset, count, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SendPacketsElement" />, используя указанный путь к файлу, смещение буфера и количество, с возможностью объединения этого элемента со следующим элементом в одном запросе на отправку из уровня сокетов в транспорт.</summary>
		/// <param name="filepath">Имя файла, передаваемого с помощью метода <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.</param>
		/// <param name="offset">Смещение (в байтах) от начала файла до места в нем, с которого начинается отправка файла, указанного в параметре <paramref name="filepath" />.</param>
		/// <param name="count">Количество байтов, отправляемых, начиная со смещения, заданного параметром <paramref name="offset" />. Если значение <paramref name="count" /> равно нулю, отправляется весь файл целиком.</param>
		/// <param name="endOfPacket">Логическое значение, указывающее, что данный элемент не должен объединяться со следующим элементом в одном запросе на отправку из уровня сокетов в транспорт. Этот флаг используется для детального управления содержимым каждого сообщения на датаграмме или ориентированном на сообщения сокете.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="filepath" /> не может иметь значение null</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значения параметров <paramref name="offset" /> и <paramref name="count" /> должны быть больше или равны нулю.  
		/// Значения параметров <paramref name="offset" /> и <paramref name="count" /> должны быть меньше размера файла, указанного в параметре <paramref name="filepath" />.</exception>
		// Token: 0x06003EBD RID: 16061 RVA: 0x000D6954 File Offset: 0x000D4B54
		public SendPacketsElement(string filepath, int offset, int count, bool endOfPacket)
		{
			if (filepath == null)
			{
				throw new ArgumentNullException("filepath");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.Initialize(filepath, null, offset, count, endOfPacket);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SendPacketsElement" />, используя указанный буфер.</summary>
		/// <param name="buffer">Байтовый массив данных, отправляемый с помощью метода <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> не может иметь значение null</exception>
		// Token: 0x06003EBE RID: 16062 RVA: 0x000D6994 File Offset: 0x000D4B94
		public SendPacketsElement(byte[] buffer) : this(buffer, 0, (buffer != null) ? buffer.Length : 0, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SendPacketsElement" />, используя указанные буфер, смещение буфера и количество.</summary>
		/// <param name="buffer">Байтовый массив данных, отправляемый с помощью метода <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.</param>
		/// <param name="offset">Смещение (в байтах) от начала буфера <paramref name="buffer" /> до расположения в буфере <paramref name="buffer" />, с которого начинается отправка данных, указанных в параметре <paramref name="buffer" />.</param>
		/// <param name="count">Количество байтов, отправляемых, начиная со смещения, заданного параметром <paramref name="offset" />. Если значение <paramref name="count" /> равно нулю, ни одного байта не отправляется.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> не может иметь значение null</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значения параметров <paramref name="offset" /> и <paramref name="count" /> должны быть больше или равны нулю.  
		/// Значения параметров <paramref name="offset" /> и <paramref name="count" /> должны быть меньше размера буфера.</exception>
		// Token: 0x06003EBF RID: 16063 RVA: 0x000D69A8 File Offset: 0x000D4BA8
		public SendPacketsElement(byte[] buffer, int offset, int count) : this(buffer, offset, count, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SendPacketsElement" />, используя указанный буфер, смещение буфера и количество, с возможностью объединения этого элемента со следующим элементом в одном запросе на отправку из уровня сокетов в транспорт.</summary>
		/// <param name="buffer">Байтовый массив данных, отправляемый с помощью метода <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.</param>
		/// <param name="offset">Смещение (в байтах) от начала буфера <paramref name="buffer" /> до расположения в буфере <paramref name="buffer" />, с которого начинается отправка данных, указанных в параметре <paramref name="buffer" />.</param>
		/// <param name="count">Количество байтов, отправляемых, начиная со смещения, заданного параметром <paramref name="offset" />. Если значение <paramref name="count" /> равно нулю, ни одного байта не отправляется.</param>
		/// <param name="endOfPacket">Логическое значение, указывающее, что данный элемент не должен объединяться со следующим элементом в одном запросе на отправку из уровня сокетов в транспорт. Этот флаг используется для детального управления содержимым каждого сообщения на датаграмме или ориентированном на сообщения сокете.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> не может иметь значение null</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значения параметров <paramref name="offset" /> и <paramref name="count" /> должны быть больше или равны нулю.  
		/// Значения параметров <paramref name="offset" /> и <paramref name="count" /> должны быть меньше размера буфера.</exception>
		// Token: 0x06003EC0 RID: 16064 RVA: 0x000D69B4 File Offset: 0x000D4BB4
		public SendPacketsElement(byte[] buffer, int offset, int count, bool endOfPacket)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.Initialize(null, buffer, offset, count, endOfPacket);
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x000D6A0D File Offset: 0x000D4C0D
		private void Initialize(string filePath, byte[] buffer, int offset, int count, bool endOfPacket)
		{
			this.m_FilePath = filePath;
			this.m_Buffer = buffer;
			this.m_Offset = offset;
			this.m_Count = count;
			this.m_endOfPacket = endOfPacket;
		}

		/// <summary>Получает имя отправляемого файла, если класс <see cref="T:System.Net.Sockets.SendPacketsElement" /> был инициализирован с использованием параметра <paramref name="filepath" />.</summary>
		/// <returns>Имя отправляемого файла, если класс <see cref="T:System.Net.Sockets.SendPacketsElement" /> был инициализирован с использованием параметра <paramref name="filepath" />.</returns>
		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x000D6A34 File Offset: 0x000D4C34
		public string FilePath
		{
			get
			{
				return this.m_FilePath;
			}
		}

		/// <summary>Получает отправляемый буфер, если класс <see cref="T:System.Net.Sockets.SendPacketsElement" /> был инициализирован с помощью параметра <paramref name="buffer" />.</summary>
		/// <returns>Отправляемый буфер байтов, если класс <see cref="T:System.Net.Sockets.SendPacketsElement" /> был инициализирован с помощью параметра <paramref name="buffer" />.</returns>
		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06003EC3 RID: 16067 RVA: 0x000D6A3C File Offset: 0x000D4C3C
		public byte[] Buffer
		{
			get
			{
				return this.m_Buffer;
			}
		}

		/// <summary>Получает количество отправляемых байтов.</summary>
		/// <returns>Количество отправляемых байтов, если класс <see cref="T:System.Net.Sockets.SendPacketsElement" /> был инициализирован с использованием параметра <paramref name="count" />.</returns>
		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x000D6A44 File Offset: 0x000D4C44
		public int Count
		{
			get
			{
				return this.m_Count;
			}
		}

		/// <summary>Получает смещение (в байтах) от начала буфера данных или файла до расположения в буфере или файле, с которого начинается отправка данных.</summary>
		/// <returns>Смещение (в байтах) от начала буфера данных или файла до расположения в буфере или файле, с которого начинается отправка данных.</returns>
		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06003EC5 RID: 16069 RVA: 0x000D6A4C File Offset: 0x000D4C4C
		public int Offset
		{
			get
			{
				return this.m_Offset;
			}
		}

		/// <summary>Получает логическое значение, указывающее, что данный элемент не должен объединяться со следующим элементом в одном запросе на отправку из уровня сокетов в транспорт.</summary>
		/// <returns>Логическое значение, указывающее, что данный элемент не должен объединяться со следующим элементом в одном запросе.</returns>
		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06003EC6 RID: 16070 RVA: 0x000D6A54 File Offset: 0x000D4C54
		public bool EndOfPacket
		{
			get
			{
				return this.m_endOfPacket;
			}
		}

		// Token: 0x0400252B RID: 9515
		internal string m_FilePath;

		// Token: 0x0400252C RID: 9516
		internal byte[] m_Buffer;

		// Token: 0x0400252D RID: 9517
		internal int m_Offset;

		// Token: 0x0400252E RID: 9518
		internal int m_Count;

		// Token: 0x0400252F RID: 9519
		private bool m_endOfPacket;
	}
}
