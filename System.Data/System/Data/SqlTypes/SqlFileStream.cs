using System;
using System.IO;
using System.Runtime.InteropServices;
using Unity;

namespace System.Data.SqlTypes
{
	/// <summary>Предоставляет данные сервера SQL Server, сохраненные с помощью атрибута столбца FILESTREAM, как последовательность байтов.</summary>
	// Token: 0x020003EB RID: 1003
	public sealed class SqlFileStream : Stream
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlFileStream" />.</summary>
		/// <param name="path">Логический путь к файлу. Путь можно получить с помощью функции Pathname Transact-SQL в основном столбце FILESTREAM в таблице.</param>
		/// <param name="transactionContext">Контекст транзакции для объекта <see langword="SqlFileStream" />. Приложения должны возвращать массив байтов, возвращаемый путем вызова метода GET_FILESTREAM_TRANSACTION_CONTEXT.</param>
		/// <param name="access">Режим доступа, используемый при открытии файла. Поддерживаются следующие значения перечисления <see cref="T:System.IO.FileAccess" />: <see cref="F:System.IO.FileAccess.Read" />, <see cref="F:System.IO.FileAccess.Write" /> и <see cref="F:System.IO.FileAccess.ReadWrite" />.  
		/// При использовании <see langword="FileAccess.Read" /> объект <see langword="SqlFileStream" /> можно использовать для считывания всех существующих данных.  
		/// При использовании <see langword="FileAccess.Write" /><see langword="SqlFileStream" /> указывает на файл нулевой длины. Существующие данные будут перезаписаны при закрытии объекта и фиксации транзакции.  
		/// При использовании <see langword="FileAccess.ReadWrite" /><see langword="SqlFileStream" /> указывает на файл, содержащий все существующие данные. Дескриптор размещается в начале файла. Для перемещения положения дескриптора в файле с целью записи или добавления новых данных можно использовать один из методов <see langword="System.IO" /><see langword="Seek" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> является пустой ссылкой, или <paramref name="transactionContext" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		///  <paramref name="path" /> начинается с "\\.\", например "\\.\PHYSICALDRIVE0".  
		/// Маркер, возвращенный вызовом в NTCreateFile, не относится к типу FILE_TYPE_DISK.  
		///  <paramref name="options" /> содержит неподдерживаемое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый <paramref name="path" /> (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный доступ не разрешен операционной системой для указанного пути. Это происходит, если задан режим доступа с правом чтения или чтения и записи, а для файла или каталога задан режим доступа только для чтения.</exception>
		/// <exception cref="T:System.InvalidOperationException">NtCreateFile завершается сбоем с кодом ошибки ERROR_SHARING_VIOLATION.</exception>
		// Token: 0x06002F70 RID: 12144 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlFileStream(string path, byte[] transactionContext, FileAccess access)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlFileStream" />.</summary>
		/// <param name="path">Логический путь к файлу. Путь можно получить с помощью функции Pathname Transact-SQL в основном столбце FILESTREAM в таблице.</param>
		/// <param name="transactionContext">Контекст транзакции для объекта <see langword="SqlFileStream" />. Если задано значение NULL, для объекта <see langword="SqlFileStream" /> будет использоваться неявная транзакция. Приложения должны возвращать массив байтов, возвращаемый путем вызова метода GET_FILESTREAM_TRANSACTION_CONTEXT.</param>
		/// <param name="access">Режим доступа, используемый при открытии файла. Поддерживаются следующие значения перечисления <see cref="T:System.IO.FileAccess" />: <see cref="F:System.IO.FileAccess.Read" />, <see cref="F:System.IO.FileAccess.Write" /> и <see cref="F:System.IO.FileAccess.ReadWrite" />.  
		/// При использовании <see langword="FileAccess.Read" /> объект <see langword="SqlFileStream" /> можно использовать для считывания всех существующих данных.  
		/// При использовании <see langword="FileAccess.Write" /><see langword="SqlFileStream" /> указывает на файл нулевой длины. Существующие данные будут перезаписаны при закрытии объекта и фиксации транзакции.  
		/// При использовании <see langword="FileAccess.ReadWrite" /><see langword="SqlFileStream" /> указывает на файл, содержащий все существующие данные. Дескриптор размещается в начале файла. Для перемещения положения дескриптора в файле с целью записи или добавления новых данных можно использовать один из методов <see langword="System.IO" /><see langword="Seek" />.</param>
		/// <param name="options">Задает параметр, используемый при открытии файла. Допустимые значения <see cref="T:System.IO.FileOptions" />: <see cref="F:System.IO.FileOptions.Asynchronous" />, <see cref="F:System.IO.FileOptions.WriteThrough" />, <see cref="F:System.IO.FileOptions.SequentialScan" /> и <see cref="F:System.IO.FileOptions.RandomAccess" />.</param>
		/// <param name="allocationSize">Размер выделения для использования при создании файла. Если задано значение 0, используется значение по умолчанию.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> является пустой ссылкой, или <paramref name="transactionContext" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		///  <paramref name="path" /> начинается с "\\.\", например "\\.\PHYSICALDRIVE0".  
		/// Дескриптор, возвращенный вызовом NTCreateFile, не относится к типу FILE_TYPE_DISK.  
		///  <paramref name="options" /> содержит неподдерживаемое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый <paramref name="path" /> (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный доступ не разрешен операционной системой для указанного пути. Это происходит, если задан режим доступа с правом чтения или чтения и записи, а для файла или каталога задан режим доступа только для чтения.</exception>
		/// <exception cref="T:System.InvalidOperationException">NtCreateFile завершается сбоем с кодом ошибки ERROR_SHARING_VIOLATION.</exception>
		// Token: 0x06002F71 RID: 12145 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlFileStream(string path, byte[] transactionContext, FileAccess access, FileOptions options, long allocationSize)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций чтения.</summary>
		/// <returns>Значение <see langword="true" />, если текущий поток поддерживает чтение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x000CB9B4 File Offset: 0x000C9BB4
		public override bool CanRead
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций поиска.</summary>
		/// <returns>Значение <see langword="true" />, если текущий поток поддерживает поиск. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x000CB9D0 File Offset: 0x000C9BD0
		public override bool CanSeek
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций записи.</summary>
		/// <returns>Значение <see langword="true" />, если текущий поток поддерживает запись. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x000CB9EC File Offset: 0x000C9BEC
		public override bool CanWrite
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>Возвращает значение, указывающее длину текущего потока в байтах.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, указывающее длину текущего потока в байтах.</returns>
		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x000CBA08 File Offset: 0x000C9C08
		public override long Length
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0L;
			}
		}

		/// <summary>Возвращает логический путь <see cref="T:System.Data.SqlTypes.SqlFileStream" />, переданного в конструктор.</summary>
		/// <returns>Строковое значение, указывающее имя <see cref="T:System.Data.SqlTypes.SqlFileStream" />.</returns>
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x00060C51 File Offset: 0x0005EE51
		public string Name
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Возвращает или задает позицию в текущем потоке.</summary>
		/// <returns>Текущая позиция в потоке <see cref="T:System.Data.SqlTypes.SqlFileStream" />.</returns>
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x000CBA24 File Offset: 0x000C9C24
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public override long Position
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0L;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>Возвращает или задает контекст транзакции для данного объекта <see cref="T:System.Data.SqlTypes.SqlFileStream" />.</summary>
		/// <returns>Массив <paramref name="transactionContext" />, который был передан в конструктор для этого объекта <see cref="T:System.Data.SqlTypes.SqlFileStream" />.</returns>
		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x00060C51 File Offset: 0x0005EE51
		public byte[] TransactionContext
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Очищает все буферы для этого потока и приводит к записи всех буферизованных данных в базовое устройство.</summary>
		// Token: 0x06002F7A RID: 12154 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public override void Flush()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Считывает последовательность байтов из текущего потока и перемещает позицию внутри потока на число считанных байтов.</summary>
		/// <param name="buffer">Массив байтов. После завершения выполнения данного метода буфер содержит указанный массив байтов, в котором значения в интервале между смещением и величиной "смещение + счетчик – 1" заменены байтами, считанными из текущего источника.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в буфере, с которого начинается сохранение данных, считанных из текущего потока.</param>
		/// <param name="count">Максимальное количество байтов, которое должно быть считано из текущего потока.</param>
		/// <returns>Общее количество байтов, считанных в буфер. Это число может быть меньше количества запрошенных байтов, если столько байтов в настоящее время недоступно, а также равняться нулю (0), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект не поддерживает чтение данных.</exception>
		// Token: 0x06002F7B RID: 12155 RVA: 0x000CBA40 File Offset: 0x000C9C40
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			ThrowStub.ThrowNotSupportedException();
			return 0;
		}

		/// <summary>Задает позицию в текущем потоке.</summary>
		/// <param name="offset">Смещение в байтах относительно параметра <paramref name="origin" />.</param>
		/// <param name="origin">Значение типа <see cref="T:System.IO.SeekOrigin" />, указывающее опорную точку, которая используется для получения новой позиции.</param>
		/// <returns>Новая позиция в текущем потоке.</returns>
		// Token: 0x06002F7C RID: 12156 RVA: 0x000CBA5C File Offset: 0x000C9C5C
		public override long Seek(long offset, SeekOrigin origin)
		{
			ThrowStub.ThrowNotSupportedException();
			return 0L;
		}

		/// <summary>Устанавливает длину текущего потока.</summary>
		/// <param name="value">Нужная длина текущего потока в байтах.</param>
		/// <exception cref="T:System.NotSupportedException">Объект не поддерживает чтение данных.</exception>
		// Token: 0x06002F7D RID: 12157 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public override void SetLength(long value)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Записывает последовательность байтов в текущий поток и перемещает текущую позицию внутри потока на число записанных байтов.</summary>
		/// <param name="buffer">Массив байтов. Этот метод копирует байты <paramref name="count" /> из <paramref name="buffer" /> в текущий поток.</param>
		/// <param name="offset">Отсчитываемое от нуля смещение байтов в буфере <paramref name="buffer" />, с которого начинается копирование байтов в текущий поток.</param>
		/// <param name="count">Количество байтов, которое необходимо записать в текущий поток.</param>
		/// <exception cref="T:System.NotSupportedException">Объект не поддерживает запись данных.</exception>
		// Token: 0x06002F7E RID: 12158 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public override void Write(byte[] buffer, int offset, int count)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
