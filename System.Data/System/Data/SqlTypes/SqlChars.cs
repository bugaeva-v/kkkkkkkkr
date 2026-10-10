using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>
	///   <see cref="T:System.Data.SqlTypes.SqlChars" /> —изменяемый ссылочный тип, служащий оболочкой для массива <see cref="T:System.Char" /> или экземпляра <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
	// Token: 0x0200030B RID: 779
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public sealed class SqlChars : INullable, IXmlSerializable, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		// Token: 0x06002319 RID: 8985 RVA: 0x000A0EB0 File Offset: 0x0009F0B0
		public SqlChars()
		{
			this.SetNull();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlChars" /> на основе заданного массива знаков.</summary>
		/// <param name="buffer">Массив <see cref="T:System.Char" />.</param>
		// Token: 0x0600231A RID: 8986 RVA: 0x000A0EC0 File Offset: 0x0009F0C0
		public SqlChars(char[] buffer)
		{
			this._rgchBuf = buffer;
			this._stream = null;
			if (this._rgchBuf == null)
			{
				this._state = SqlBytesCharsState.Null;
				this._lCurLen = -1L;
			}
			else
			{
				this._state = SqlBytesCharsState.Buffer;
				this._lCurLen = (long)this._rgchBuf.Length;
			}
			this._rgchWorkBuf = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlChars" /> на основе указанного значения <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		// Token: 0x0600231B RID: 8987 RVA: 0x000A0F17 File Offset: 0x0009F117
		public SqlChars(SqlString value) : this(value.IsNull ? null : value.Value.ToCharArray())
		{
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x000A0F37 File Offset: 0x0009F137
		internal SqlChars(SqlStreamChars s)
		{
			this._rgchBuf = null;
			this._lCurLen = -1L;
			this._stream = s;
			this._state = ((s == null) ? SqlBytesCharsState.Null : SqlBytesCharsState.Stream);
			this._rgchWorkBuf = null;
		}

		/// <summary>Получает логическое значение, показывающее, имеет ли данный экземпляр <see cref="T:System.Data.SqlTypes.SqlChars" /> значение NULL.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Data.SqlTypes.SqlChars" /> имеет значение NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x000A0F69 File Offset: 0x0009F169
		public bool IsNull
		{
			get
			{
				return this._state == SqlBytesCharsState.Null;
			}
		}

		/// <summary>Возвращает ссылку на внутренний буфер.</summary>
		/// <returns>Ссылка на внутренний буфер. Для экземпляров <see cref="T:System.Data.SqlTypes.SqlChars" />, созданных поверх неуправляемых указателей, возвращает управляемую копию внутреннего буфера.</returns>
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000A0F74 File Offset: 0x0009F174
		public char[] Buffer
		{
			get
			{
				if (this.FStream())
				{
					this.CopyStreamToBuffer();
				}
				return this._rgchBuf;
			}
		}

		/// <summary>Получает длину значения, которое содержится в экземпляре <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, указывающее длину (в символах) значения, которое содержится в экземпляре <see cref="T:System.Data.SqlTypes.SqlChars" />.  
		/// Возвращает -1, если для экземпляра нет доступного буфера или если значение равно NULL.  
		/// Возвращает <see cref="P:System.IO.Stream.Length" /> для экземпляра, включенного в поток.</returns>
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x000A0F8C File Offset: 0x0009F18C
		public long Length
		{
			get
			{
				SqlBytesCharsState state = this._state;
				if (state == SqlBytesCharsState.Null)
				{
					throw new SqlNullValueException();
				}
				if (state != SqlBytesCharsState.Stream)
				{
					return this._lCurLen;
				}
				return this._stream.Length;
			}
		}

		/// <summary>Получает максимальную длину значения, которое может содержаться во внутреннем буфере, в двухбайтовых знаках.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, представляющее максимальную длину значения внутреннего буфера в двухбайтовых знаках.  
		/// Возвращает –1 для экземпляра <see cref="T:System.Data.SqlTypes.SqlChars" />, включенного в поток.</returns>
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000A0FC1 File Offset: 0x0009F1C1
		public long MaxLength
		{
			get
			{
				if (this._state == SqlBytesCharsState.Stream)
				{
					return -1L;
				}
				if (this._rgchBuf != null)
				{
					return (long)this._rgchBuf.Length;
				}
				return -1L;
			}
		}

		/// <summary>Возвращает управляемую копию значения, которое содержится в данном объекте <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <returns>Значение данного экземпляра <see cref="T:System.Data.SqlTypes.SqlChars" /> в виде массива знаков.</returns>
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x000A0FE4 File Offset: 0x0009F1E4
		public char[] Value
		{
			get
			{
				SqlBytesCharsState state = this._state;
				if (state != SqlBytesCharsState.Null)
				{
					char[] array;
					if (state != SqlBytesCharsState.Stream)
					{
						array = new char[this._lCurLen];
						Array.Copy(this._rgchBuf, 0, array, 0, (int)this._lCurLen);
					}
					else
					{
						if (this._stream.Length > 2147483647L)
						{
							throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
						}
						array = new char[this._stream.Length];
						if (this._stream.Position != 0L)
						{
							this._stream.Seek(0L, SeekOrigin.Begin);
						}
						this._stream.Read(array, 0, checked((int)this._stream.Length));
					}
					return array;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Получает или задает экземпляр <see cref="T:System.Data.SqlTypes.SqlChars" /> по указанному индексу.</summary>
		/// <param name="offset">Значение <see cref="T:System.Int64" />.</param>
		/// <returns>Значение <see cref="T:System.Char" />.</returns>
		// Token: 0x17000649 RID: 1609
		public char this[long offset]
		{
			get
			{
				if (offset < 0L || offset >= this.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				if (this._rgchWorkBuf == null)
				{
					this._rgchWorkBuf = new char[1];
				}
				this.Read(offset, this._rgchWorkBuf, 0, 1);
				return this._rgchWorkBuf[0];
			}
			set
			{
				if (this._rgchWorkBuf == null)
				{
					this._rgchWorkBuf = new char[1];
				}
				this._rgchWorkBuf[0] = value;
				this.Write(offset, this._rgchWorkBuf, 0, 1);
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000A1114 File Offset: 0x0009F314
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x000A112B File Offset: 0x0009F32B
		internal SqlStreamChars Stream
		{
			get
			{
				if (!this.FStream())
				{
					return new StreamOnSqlChars(this);
				}
				return this._stream;
			}
			set
			{
				this._lCurLen = -1L;
				this._stream = value;
				this._state = ((value == null) ? SqlBytesCharsState.Null : SqlBytesCharsState.Stream);
			}
		}

		/// <summary>Возвращает сведения о состоянии хранения данного экземпляра <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Data.SqlTypes.StorageState" />.</returns>
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000A114C File Offset: 0x0009F34C
		public StorageState Storage
		{
			get
			{
				switch (this._state)
				{
				case SqlBytesCharsState.Null:
					throw new SqlNullValueException();
				case SqlBytesCharsState.Buffer:
					return StorageState.Buffer;
				case SqlBytesCharsState.Stream:
					return StorageState.Stream;
				}
				return StorageState.UnmanagedBuffer;
			}
		}

		/// <summary>Задает для данного экземпляра <see cref="T:System.Data.SqlTypes.SqlChars" /> значение NULL.</summary>
		// Token: 0x06002327 RID: 8999 RVA: 0x000A1183 File Offset: 0x0009F383
		public void SetNull()
		{
			this._lCurLen = -1L;
			this._stream = null;
			this._state = SqlBytesCharsState.Null;
		}

		/// <summary>Задает длину данного экземпляра <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Int64" /><see langword="long" />, представляющее длину.</param>
		// Token: 0x06002328 RID: 9000 RVA: 0x000A119C File Offset: 0x0009F39C
		public void SetLength(long value)
		{
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (this.FStream())
			{
				this._stream.SetLength(value);
				return;
			}
			if (this._rgchBuf == null)
			{
				throw new SqlTypeException("There is no buffer. Read or write operation failed.");
			}
			if (value > (long)this._rgchBuf.Length)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (this.IsNull)
			{
				this._state = SqlBytesCharsState.Buffer;
			}
			this._lCurLen = value;
		}

		/// <summary>Копирует знаки из этого экземпляра <see cref="T:System.Data.SqlTypes.SqlChars" /> в буфер передачи и возвращает количество скопированных знаков.</summary>
		/// <param name="offset">Смещение значения <see cref="T:System.Int64" /><see langword="long" /> в значение, которое содержится в экземпляре <see cref="T:System.Data.SqlTypes.SqlChars" />.</param>
		/// <param name="buffer">Буфер массива знаков для копирования.</param>
		/// <param name="offsetInBuffer">Целочисленное смещение <see cref="T:System.Int32" /> в буфере для начала копирования.</param>
		/// <param name="count">Целое число <see cref="T:System.Int32" />, представляющее количество знаков для копирования.</param>
		/// <returns>Значение <see cref="T:System.Int64" /><see langword="long" />, представляющее число скопированных байтов.</returns>
		// Token: 0x06002329 RID: 9001 RVA: 0x000A1210 File Offset: 0x0009F410
		public long Read(long offset, char[] buffer, int offsetInBuffer, int count)
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset > this.Length || offset < 0L)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (offsetInBuffer > buffer.Length || offsetInBuffer < 0)
			{
				throw new ArgumentOutOfRangeException("offsetInBuffer");
			}
			if (count < 0 || count > buffer.Length - offsetInBuffer)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if ((long)count > this.Length - offset)
			{
				count = (int)(this.Length - offset);
			}
			if (count != 0)
			{
				if (this._state == SqlBytesCharsState.Stream)
				{
					if (this._stream.Position != offset)
					{
						this._stream.Seek(offset, SeekOrigin.Begin);
					}
					this._stream.Read(buffer, offsetInBuffer, count);
				}
				else
				{
					Array.Copy(this._rgchBuf, offset, buffer, (long)offsetInBuffer, (long)count);
				}
			}
			return (long)count;
		}

		/// <summary>Копирует знаки из буфера передачи в этот экземпляр <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <param name="offset">Смещение значения <see langword="long" /> в значении, которое содержится в экземпляре <see cref="T:System.Data.SqlTypes.SqlChars" />.</param>
		/// <param name="buffer">Буфер массива знаков для копирования.</param>
		/// <param name="offsetInBuffer">Целочисленное смещение <see cref="T:System.Int32" /> в буфере для начала копирования.</param>
		/// <param name="count">Целое число <see cref="T:System.Int32" />, представляющее количество знаков для копирования.</param>
		// Token: 0x0600232A RID: 9002 RVA: 0x000A12E8 File Offset: 0x0009F4E8
		public void Write(long offset, char[] buffer, int offsetInBuffer, int count)
		{
			if (this.FStream())
			{
				if (this._stream.Position != offset)
				{
					this._stream.Seek(offset, SeekOrigin.Begin);
				}
				this._stream.Write(buffer, offsetInBuffer, count);
				return;
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (this._rgchBuf == null)
			{
				throw new SqlTypeException("There is no buffer. Read or write operation failed.");
			}
			if (offset < 0L)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (offset > (long)this._rgchBuf.Length)
			{
				throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
			}
			if (offsetInBuffer < 0 || offsetInBuffer > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offsetInBuffer");
			}
			if (count < 0 || count > buffer.Length - offsetInBuffer)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if ((long)count > (long)this._rgchBuf.Length - offset)
			{
				throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
			}
			if (this.IsNull)
			{
				if (offset != 0L)
				{
					throw new SqlTypeException("Cannot write to non-zero offset, because current value is Null.");
				}
				this._lCurLen = 0L;
				this._state = SqlBytesCharsState.Buffer;
			}
			else if (offset > this._lCurLen)
			{
				throw new SqlTypeException("Cannot write from an offset that is larger than current length. It would leave uninitialized data in the buffer.");
			}
			if (count != 0)
			{
				Array.Copy(buffer, (long)offsetInBuffer, this._rgchBuf, offset, (long)count);
				if (this._lCurLen < offset + (long)count)
				{
					this._lCurLen = offset + (long)count;
				}
			}
		}

		/// <summary>Преобразует данный экземпляр <see cref="T:System.Data.SqlTypes.SqlChars" /> в эквивалентное представление <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Представление <see cref="T:System.Data.SqlTypes.SqlString" /> данного типа.</returns>
		// Token: 0x0600232B RID: 9003 RVA: 0x000A1423 File Offset: 0x0009F623
		public SqlString ToSqlString()
		{
			if (!this.IsNull)
			{
				return new string(this.Value);
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует структуру <see cref="T:System.Data.SqlTypes.SqlChars" /> в структуру <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlChars" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x0600232C RID: 9004 RVA: 0x000A1443 File Offset: 0x0009F643
		public static explicit operator SqlString(SqlChars value)
		{
			return value.ToSqlString();
		}

		/// <summary>Преобразует структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в структуру <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlChars" />.</returns>
		// Token: 0x0600232D RID: 9005 RVA: 0x000A144B File Offset: 0x0009F64B
		public static explicit operator SqlChars(SqlString value)
		{
			return new SqlChars(value);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x000A1453 File Offset: 0x0009F653
		[Conditional("DEBUG")]
		private void AssertValid()
		{
			bool isNull = this.IsNull;
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x000A145C File Offset: 0x0009F65C
		internal bool FStream()
		{
			return this._state == SqlBytesCharsState.Stream;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x000A1468 File Offset: 0x0009F668
		private void CopyStreamToBuffer()
		{
			long length = this._stream.Length;
			if (length >= 2147483647L)
			{
				throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
			}
			if (this._rgchBuf == null || (long)this._rgchBuf.Length < length)
			{
				this._rgchBuf = new char[length];
			}
			if (this._stream.Position != 0L)
			{
				this._stream.Seek(0L, SeekOrigin.Begin);
			}
			this._stream.Read(this._rgchBuf, 0, (int)length);
			this._stream = null;
			this._lCurLen = length;
			this._state = SqlBytesCharsState.Buffer;
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x000A14FC File Offset: 0x0009F6FC
		private void SetBuffer(char[] buffer)
		{
			this._rgchBuf = buffer;
			this._lCurLen = ((this._rgchBuf == null) ? -1L : ((long)this._rgchBuf.Length));
			this._stream = null;
			this._state = ((this._rgchBuf == null) ? SqlBytesCharsState.Null : SqlBytesCharsState.Buffer);
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <returns>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</returns>
		// Token: 0x06002332 RID: 9010 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="r">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x06002333 RID: 9011 RVA: 0x000A153C File Offset: 0x0009F73C
		void IXmlSerializable.ReadXml(XmlReader r)
		{
			string attribute = r.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				r.ReadElementString();
				this.SetNull();
				return;
			}
			char[] buffer = r.ReadElementString().ToCharArray();
			this.SetBuffer(buffer);
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x06002334 RID: 9012 RVA: 0x000A1588 File Offset: 0x0009F788
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			char[] buffer = this.Buffer;
			writer.WriteString(new string(buffer, 0, (int)this.Length));
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06002335 RID: 9013 RVA: 0x000A15D3 File Offset: 0x0009F7D3
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
		}

		/// <summary>Получает сведения о сериализации со всеми данными, необходимыми для повторного создания данного экземпляра <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <param name="info">Объект, для которого будут заполнены сведения о сериализации.</param>
		/// <param name="context">Контекст назначения сериализации.</param>
		// Token: 0x06002336 RID: 9014 RVA: 0x0004549D File Offset: 0x0004369D
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Возвращает пустой экземпляр данного объекта <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <returns>Экземпляр которого <see cref="P:System.Data.SqlTypes.SqlChars.IsNull" /> возвращает <see langword="true" />. Дополнительные сведения см. в разделе Handling Null Values.</returns>
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x000A15E4 File Offset: 0x0009F7E4
		public static SqlChars Null
		{
			get
			{
				return new SqlChars(null);
			}
		}

		// Token: 0x04001841 RID: 6209
		internal char[] _rgchBuf;

		// Token: 0x04001842 RID: 6210
		private long _lCurLen;

		// Token: 0x04001843 RID: 6211
		internal SqlStreamChars _stream;

		// Token: 0x04001844 RID: 6212
		private SqlBytesCharsState _state;

		// Token: 0x04001845 RID: 6213
		private char[] _rgchWorkBuf;

		// Token: 0x04001846 RID: 6214
		private const long x_lMaxLen = 2147483647L;

		// Token: 0x04001847 RID: 6215
		private const long x_lNull = -1L;
	}
}
