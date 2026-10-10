using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Text
{
	/// <summary>Представляет кодировку символов.</summary>
	// Token: 0x020003BC RID: 956
	[ComVisible(true)]
	[Serializable]
	public abstract class Encoding : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.Encoding" />.</summary>
		// Token: 0x06002799 RID: 10137 RVA: 0x00090422 File Offset: 0x0008E622
		protected Encoding() : this(0)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.Encoding" />, соответствующий заданной кодовой странице.</summary>
		/// <param name="codePage">Идентификатор кодовой страницы предпочтительной кодировки.  
		///
		/// или - 
		/// 0, если требуется использовать кодировку по умолчанию.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="codePage" /> меньше нуля.</exception>
		// Token: 0x0600279A RID: 10138 RVA: 0x0009042B File Offset: 0x0008E62B
		protected Encoding(int codePage)
		{
			this.m_isReadOnly = true;
			base..ctor();
			if (codePage < 0)
			{
				throw new ArgumentOutOfRangeException("codePage");
			}
			this.m_codePage = codePage;
			this.SetDefaultFallbacks();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.Encoding" />, соответствующий заданной кодовой странице, с использованием указанных стратегий резервирования кодировщика и декодера.</summary>
		/// <param name="codePage">Идентификатор кодовой страницы кодировки.</param>
		/// <param name="encoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда символ не может быть закодирован с использованием текущей кодировки.</param>
		/// <param name="decoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда последовательность байтов не может быть декодирована с использованием текущей кодировки.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="codePage" /> меньше нуля.</exception>
		// Token: 0x0600279B RID: 10139 RVA: 0x00090458 File Offset: 0x0008E658
		protected Encoding(int codePage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			this.m_isReadOnly = true;
			base..ctor();
			if (codePage < 0)
			{
				throw new ArgumentOutOfRangeException("codePage");
			}
			this.m_codePage = codePage;
			this.encoderFallback = (encoderFallback ?? new InternalEncoderBestFitFallback(this));
			this.decoderFallback = (decoderFallback ?? new InternalDecoderBestFitFallback(this));
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x000904AA File Offset: 0x0008E6AA
		internal virtual void SetDefaultFallbacks()
		{
			this.encoderFallback = new InternalEncoderBestFitFallback(this);
			this.decoderFallback = new InternalDecoderBestFitFallback(this);
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000904C4 File Offset: 0x0008E6C4
		internal void OnDeserializing()
		{
			this.encoderFallback = null;
			this.decoderFallback = null;
			this.m_isReadOnly = true;
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000904DB File Offset: 0x0008E6DB
		internal void OnDeserialized()
		{
			if (this.encoderFallback == null || this.decoderFallback == null)
			{
				this.m_deserializedFromEverett = true;
				this.SetDefaultFallbacks();
			}
			this.dataItem = null;
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00090501 File Offset: 0x0008E701
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.OnDeserializing();
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00090509 File Offset: 0x0008E709
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00090511 File Offset: 0x0008E711
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this.dataItem = null;
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0009051C File Offset: 0x0008E71C
		internal void DeserializeEncoding(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.m_codePage = (int)info.GetValue("m_codePage", typeof(int));
			this.dataItem = null;
			try
			{
				this.m_isReadOnly = (bool)info.GetValue("m_isReadOnly", typeof(bool));
				this.encoderFallback = (EncoderFallback)info.GetValue("encoderFallback", typeof(EncoderFallback));
				this.decoderFallback = (DecoderFallback)info.GetValue("decoderFallback", typeof(DecoderFallback));
			}
			catch (SerializationException)
			{
				this.m_deserializedFromEverett = true;
				this.m_isReadOnly = true;
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000905E8 File Offset: 0x0008E7E8
		internal void SerializeEncoding(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("m_isReadOnly", this.m_isReadOnly);
			info.AddValue("encoderFallback", this.EncoderFallback);
			info.AddValue("decoderFallback", this.DecoderFallback);
			info.AddValue("m_codePage", this.m_codePage);
			info.AddValue("dataItem", null);
			info.AddValue("Encoding+m_codePage", this.m_codePage);
			info.AddValue("Encoding+dataItem", null);
		}

		/// <summary>Преобразует весь массив байтов из одной кодировки в другую.</summary>
		/// <param name="srcEncoding">Формат кодировки параметра <paramref name="bytes" />.</param>
		/// <param name="dstEncoding">Целевой формат кодировки.</param>
		/// <param name="bytes">Преобразуемые байты.</param>
		/// <returns>Массив типа <see cref="T:System.Byte" />, содержащий результаты преобразования <paramref name="bytes" /> из <paramref name="srcEncoding" /> в <paramref name="dstEncoding" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="srcEncoding" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="dstEncoding" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// srcEncoding. Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// dstEncoding. Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027A4 RID: 10148 RVA: 0x00090670 File Offset: 0x0008E870
		public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes");
			}
			return Encoding.Convert(srcEncoding, dstEncoding, bytes, 0, bytes.Length);
		}

		/// <summary>Преобразует диапазон байтов в массиве байтов из одной кодировки в другую.</summary>
		/// <param name="srcEncoding">Кодировка исходного массива, <paramref name="bytes" />.</param>
		/// <param name="dstEncoding">Кодировка выходного массива.</param>
		/// <param name="bytes">Преобразуемый массив байтов.</param>
		/// <param name="index">Индекс первого элемента преобразуемого массива байтов <paramref name="bytes" />.</param>
		/// <param name="count">Число байтов, которые требуется преобразовать.</param>
		/// <returns>Массив типа <see cref="T:System.Byte" />, содержащий результат преобразования диапазона байтов из массива <paramref name="bytes" /> из <paramref name="srcEncoding" /> в <paramref name="dstEncoding" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="srcEncoding" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="dstEncoding" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> и <paramref name="count" /> не определяют допустимый диапазон в массиве байтов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// srcEncoding. Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// dstEncoding. Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027A5 RID: 10149 RVA: 0x0009068C File Offset: 0x0008E88C
		public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count)
		{
			if (srcEncoding == null || dstEncoding == null)
			{
				throw new ArgumentNullException((srcEncoding == null) ? "srcEncoding" : "dstEncoding", Environment.GetResourceString("Array cannot be null."));
			}
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			return dstEncoding.GetBytes(srcEncoding.GetChars(bytes, index, count));
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x000906E8 File Offset: 0x0008E8E8
		private static object InternalSyncObject
		{
			get
			{
				if (Encoding.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange<object>(ref Encoding.s_InternalSyncObject, value, null);
				}
				return Encoding.s_InternalSyncObject;
			}
		}

		/// <summary>Регистрирует поставщик кодировки.</summary>
		/// <param name="provider">Подкласс класса <see cref="T:System.Text.EncodingProvider" />, который предоставляет доступ к дополнительным кодировкам символов.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="provider" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060027A7 RID: 10151 RVA: 0x00090714 File Offset: 0x0008E914
		[SecurityCritical]
		public static void RegisterProvider(EncodingProvider provider)
		{
			EncodingProvider.AddProvider(provider);
		}

		/// <summary>Возвращает кодировку, связанную с указанным идентификатором кодовой страницы.</summary>
		/// <param name="codepage">Идентификатор кодовой страницы предпочтительной кодировки. Возможные значения перечислены в столбце кодовой страницы таблицы, которая отображается в теме класса <see cref="T:System.Text.Encoding" />.  
		///
		/// или - 
		/// 0 (ноль), если требуется использовать кодировку по умолчанию.</param>
		/// <returns>Кодирование, связанное с заданной страницей кода.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="codepage" /> меньше нуля или больше 65 535.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="codepage" /> не поддерживается используемой платформой.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="codepage" /> не поддерживается используемой платформой.</exception>
		// Token: 0x060027A8 RID: 10152 RVA: 0x0009071C File Offset: 0x0008E91C
		[SecuritySafeCritical]
		public static Encoding GetEncoding(int codepage)
		{
			Encoding encoding = EncodingProvider.GetEncodingFromProvider(codepage);
			if (encoding != null)
			{
				return encoding;
			}
			if (codepage < 0 || codepage > 65535)
			{
				throw new ArgumentOutOfRangeException("codepage", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					0,
					65535
				}));
			}
			if (Encoding.encodings != null)
			{
				Encoding.encodings.TryGetValue(codepage, out encoding);
			}
			if (encoding == null)
			{
				object internalSyncObject = Encoding.InternalSyncObject;
				lock (internalSyncObject)
				{
					if (Encoding.encodings == null)
					{
						Encoding.encodings = new Dictionary<int, Encoding>();
					}
					if (Encoding.encodings.TryGetValue(codepage, out encoding))
					{
						return encoding;
					}
					if (codepage <= 1201)
					{
						if (codepage <= 3)
						{
							if (codepage == 0)
							{
								encoding = Encoding.Default;
								goto IL_233;
							}
							if (codepage - 1 > 2)
							{
								goto IL_1B0;
							}
						}
						else if (codepage != 42)
						{
							if (codepage == 1200)
							{
								encoding = Encoding.Unicode;
								goto IL_233;
							}
							if (codepage != 1201)
							{
								goto IL_1B0;
							}
							encoding = Encoding.BigEndianUnicode;
							goto IL_233;
						}
						throw new ArgumentException(Environment.GetResourceString("{0} is not a supported code page.", new object[]
						{
							codepage
						}), "codepage");
					}
					if (codepage <= 20127)
					{
						if (codepage == 12000)
						{
							encoding = Encoding.UTF32;
							goto IL_233;
						}
						if (codepage == 12001)
						{
							encoding = new UTF32Encoding(true, true);
							goto IL_233;
						}
						if (codepage == 20127)
						{
							encoding = Encoding.ASCII;
							goto IL_233;
						}
					}
					else
					{
						if (codepage == 28591)
						{
							encoding = Encoding.Latin1;
							goto IL_233;
						}
						if (codepage == 65000)
						{
							encoding = Encoding.UTF7;
							goto IL_233;
						}
						if (codepage == 65001)
						{
							encoding = Encoding.UTF8;
							goto IL_233;
						}
					}
					IL_1B0:
					if (EncodingTable.GetCodePageDataItem(codepage) == null)
					{
						throw new NotSupportedException(Environment.GetResourceString("No data is available for encoding {0}. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.", new object[]
						{
							codepage
						}));
					}
					if (codepage != 12000)
					{
						if (codepage != 12001)
						{
							encoding = (Encoding)EncodingHelper.InvokeI18N("GetEncoding", new object[]
							{
								codepage
							});
							if (encoding == null)
							{
								throw new NotSupportedException(string.Format("Encoding {0} data could not be found. Make sure you have correct international codeset assembly installed and enabled.", codepage));
							}
						}
						else
						{
							encoding = new UTF32Encoding(true, true);
						}
					}
					else
					{
						encoding = Encoding.UTF32;
					}
					IL_233:
					Encoding.encodings.Add(codepage, encoding);
				}
				return encoding;
			}
			return encoding;
		}

		/// <summary>Возвращает кодировку, связанную с указанным идентификатором кодовой страницы. С помощью параметров задается обработчик ошибок для символов, которые не удается закодировать, и последовательностей байтов, которые не удается декодировать.</summary>
		/// <param name="codepage">Идентификатор кодовой страницы предпочтительной кодировки. Возможные значения перечислены в столбце кодовой страницы таблицы, которая отображается в теме класса <see cref="T:System.Text.Encoding" />.  
		///
		/// или - 
		/// 0 (ноль), если требуется использовать кодировку по умолчанию.</param>
		/// <param name="encoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда символ не может быть закодирован с использованием текущей кодировки.</param>
		/// <param name="decoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда последовательность байтов не может быть декодирована с использованием текущей кодировки.</param>
		/// <returns>Кодирование, связанное с заданной страницей кода.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="codepage" /> меньше нуля или больше 65 535.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="codepage" /> не поддерживается используемой платформой.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="codepage" /> не поддерживается используемой платформой.</exception>
		// Token: 0x060027A9 RID: 10153 RVA: 0x00090998 File Offset: 0x0008EB98
		public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			Encoding encoding = EncodingProvider.GetEncodingFromProvider(codepage, encoderFallback, decoderFallback);
			if (encoding != null)
			{
				return encoding;
			}
			encoding = Encoding.GetEncoding(codepage);
			Encoding encoding2 = (Encoding)encoding.Clone();
			encoding2.EncoderFallback = encoderFallback;
			encoding2.DecoderFallback = decoderFallback;
			return encoding2;
		}

		/// <summary>Возвращает кодировку, связанную с указанным именем кодовой страницы.</summary>
		/// <param name="name">Имя кодовой страницы предпочтительной кодировки. Любое значение, возвращаемое свойством <see cref="P:System.Text.Encoding.WebName" />, является допустимым. Возможные значения перечислены в столбце "Имя" таблицы, отображаемой в разделе класса <see cref="T:System.Text.Encoding" />.</param>
		/// <returns>Кодировка, связанная с указанной кодовой страницей.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> не является допустимым именем кодовой страницы.  
		///
		/// или - 
		/// Кодовая страница, указанная с помощью параметра <paramref name="name" />, не поддерживается используемой платформой.</exception>
		// Token: 0x060027AA RID: 10154 RVA: 0x000909D4 File Offset: 0x0008EBD4
		public static Encoding GetEncoding(string name)
		{
			Encoding encodingFromProvider = EncodingProvider.GetEncodingFromProvider(name);
			if (encodingFromProvider != null)
			{
				return encodingFromProvider;
			}
			return Encoding.GetEncoding(EncodingTable.GetCodePageFromName(name));
		}

		/// <summary>Возвращает кодировку, связанную с указанным именем кодовой страницы. С помощью параметров задается обработчик ошибок для символов, которые не удается закодировать, и последовательностей байтов, которые не удается декодировать.</summary>
		/// <param name="name">Имя кодовой страницы предпочтительной кодировки. Любое значение, возвращаемое свойством <see cref="P:System.Text.Encoding.WebName" />, является допустимым. Возможные значения перечислены в столбце "Имя" таблицы, отображаемой в разделе класса <see cref="T:System.Text.Encoding" />.</param>
		/// <param name="encoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда символ не может быть закодирован с использованием текущей кодировки.</param>
		/// <param name="decoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда последовательность байтов не может быть декодирована с использованием текущей кодировки.</param>
		/// <returns>Кодирование, связанное с заданной страницей кода.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> не является допустимым именем кодовой страницы.  
		///
		/// или - 
		/// Кодовая страница, указанная с помощью параметра <paramref name="name" />, не поддерживается используемой платформой.</exception>
		// Token: 0x060027AB RID: 10155 RVA: 0x000909F8 File Offset: 0x0008EBF8
		public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			Encoding encodingFromProvider = EncodingProvider.GetEncodingFromProvider(name, encoderFallback, decoderFallback);
			if (encodingFromProvider != null)
			{
				return encodingFromProvider;
			}
			return Encoding.GetEncoding(EncodingTable.GetCodePageFromName(name), encoderFallback, decoderFallback);
		}

		/// <summary>Возвращает массив, содержащий все кодировки.</summary>
		/// <returns>Массив, содержащий все кодировки.</returns>
		// Token: 0x060027AC RID: 10156 RVA: 0x00090A20 File Offset: 0x0008EC20
		public static EncodingInfo[] GetEncodings()
		{
			return EncodingTable.GetEncodings();
		}

		/// <summary>При переопределении в производном классе возвращает последовательность байтов, задающую используемую кодировку.</summary>
		/// <returns>Массив байтов, в котором содержится последовательность байтов, задающая используемую кодировку.  
		///
		/// или - 
		/// Массив байтов нулевой длины, если преамбула не требуется.</returns>
		// Token: 0x060027AD RID: 10157 RVA: 0x00090A27 File Offset: 0x0008EC27
		public virtual byte[] GetPreamble()
		{
			return EmptyArray<byte>.Value;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x00090A2E File Offset: 0x0008EC2E
		public virtual ReadOnlySpan<byte> Preamble
		{
			get
			{
				return this.GetPreamble();
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00090A3C File Offset: 0x0008EC3C
		private void GetDataItem()
		{
			if (this.dataItem == null)
			{
				this.dataItem = EncodingTable.GetCodePageDataItem(this.m_codePage);
				if (this.dataItem == null)
				{
					throw new NotSupportedException(Environment.GetResourceString("No data is available for encoding {0}. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.", new object[]
					{
						this.m_codePage
					}));
				}
			}
		}

		/// <summary>При переопределении в производном классе получает имя текущей кодировки, которое может использоваться с тегами текста сообщения почтового агента.</summary>
		/// <returns>Имя текущего объекта <see cref="T:System.Text.Encoding" />, которое может использоваться с тегами текста сообщения почтового агента.  
		///
		/// или - 
		/// Пустая строка (""), если текущий объект <see cref="T:System.Text.Encoding" /> не может использоваться.</returns>
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x00090A8E File Offset: 0x0008EC8E
		public virtual string BodyName
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return this.dataItem.BodyName;
			}
		}

		/// <summary>При переопределении в производном классе получает описание текущей кодировки, которое может быть прочитано пользователем.</summary>
		/// <returns>Описание текущего объекта <see cref="T:System.Text.Encoding" />, которое может быть прочитано пользователем.</returns>
		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00090AA9 File Offset: 0x0008ECA9
		public virtual string EncodingName
		{
			get
			{
				return Environment.GetResourceStringEncodingName(this.m_codePage);
			}
		}

		/// <summary>При переопределении в производном классе получает имя текущей кодировки, которое может использоваться с тегами заголовка сообщения почтового агента.</summary>
		/// <returns>Имя текущего объекта <see cref="T:System.Text.Encoding" />, которое может использоваться с тегами заголовка сообщения почтового агента.  
		///
		/// или - 
		/// Пустая строка (""), если текущий объект <see cref="T:System.Text.Encoding" /> не может использоваться.</returns>
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x00090AB6 File Offset: 0x0008ECB6
		public virtual string HeaderName
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return this.dataItem.HeaderName;
			}
		}

		/// <summary>При переопределении в производном классе получает для текущей кодировки имя, зарегистрированное в IANA (Internet Assigned Numbers Authority).</summary>
		/// <returns>Имя IANA для текущего объекта <see cref="T:System.Text.Encoding" />.</returns>
		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x00090AD1 File Offset: 0x0008ECD1
		public virtual string WebName
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return this.dataItem.WebName;
			}
		}

		/// <summary>При переопределении в производном классе получает кодовую страницу операционной системы Windows, наиболее точно соответствующую текущей кодировке.</summary>
		/// <returns>Кодовая страница операционной системы Windows, наиболее точно соответствующая текущему объекту <see cref="T:System.Text.Encoding" />.</returns>
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x00090AEC File Offset: 0x0008ECEC
		public virtual int WindowsCodePage
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return this.dataItem.UIFamilyCodePage;
			}
		}

		/// <summary>При переопределении в производном классе получает значение, указывающее, может ли текущая кодировка использоваться клиентами браузера для отображения содержимого.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект <see cref="T:System.Text.Encoding" /> может использоваться клиентами браузера для отображения содержимого; в противоположном случае — <see langword="false" />.</returns>
		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x00090B07 File Offset: 0x0008ED07
		public virtual bool IsBrowserDisplay
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return (this.dataItem.Flags & 2U) > 0U;
			}
		}

		/// <summary>При переопределении в производном классе получает значение, указывающее, может ли текущая кодировка использоваться клиентами браузера для сохранения содержимого.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект <see cref="T:System.Text.Encoding" /> может использоваться клиентами браузера для сохранения содержимого; в противоположном случае — <see langword="false" />.</returns>
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x00090B27 File Offset: 0x0008ED27
		public virtual bool IsBrowserSave
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return (this.dataItem.Flags & 512U) > 0U;
			}
		}

		/// <summary>При переопределении в производном классе получает значение, указывающее, может ли текущая кодировка использоваться клиентами электронной почты и новостей для отображения содержимого.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект <see cref="T:System.Text.Encoding" /> может использоваться клиентами электронной почты и новостей для отображения содержимого; в противоположном случае — <see langword="false" />.</returns>
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x00090B4B File Offset: 0x0008ED4B
		public virtual bool IsMailNewsDisplay
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return (this.dataItem.Flags & 1U) > 0U;
			}
		}

		/// <summary>При переопределении в производном классе получает значение, указывающее, может ли текущая кодировка использоваться клиентами электронной почты и новостей для сохранения содержимого.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект <see cref="T:System.Text.Encoding" /> может использоваться клиентами почты и новостей для сохранения содержимого; в противоположном случае — <see langword="false" />.</returns>
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x00090B6B File Offset: 0x0008ED6B
		public virtual bool IsMailNewsSave
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return (this.dataItem.Flags & 256U) > 0U;
			}
		}

		/// <summary>При переопределении в производном классе получает значение, указывающее, используются ли в текущей кодировке однобайтовые кодовые точки.</summary>
		/// <returns>
		///   <see langword="true" />, если в текущем объекте <see cref="T:System.Text.Encoding" /> используются однобайтовые кодовые точки; в противоположном случае — <see langword="false" />.</returns>
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[ComVisible(false)]
		public virtual bool IsSingleByte
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Text.EncoderFallback" /> для текущего объекта <see cref="T:System.Text.Encoding" />.</summary>
		/// <returns>Резервный объект кодировщика для текущего объекта <see cref="T:System.Text.Encoding" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">В операции задания значением является <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Невозможно задать значение, поскольку текущий объект <see cref="T:System.Text.Encoding" /> предназначен только для чтения.</exception>
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x00090B8F File Offset: 0x0008ED8F
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x00090B97 File Offset: 0x0008ED97
		[ComVisible(false)]
		public EncoderFallback EncoderFallback
		{
			get
			{
				return this.encoderFallback;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.encoderFallback = value;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Text.DecoderFallback" /> для текущего объекта <see cref="T:System.Text.Encoding" />.</summary>
		/// <returns>Резервный объект декодера для текущего объекта <see cref="T:System.Text.Encoding" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">В операции задания значением является <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Невозможно задать значение, поскольку текущий объект <see cref="T:System.Text.Encoding" /> предназначен только для чтения.</exception>
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x00090BC6 File Offset: 0x0008EDC6
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x00090BCE File Offset: 0x0008EDCE
		[ComVisible(false)]
		public DecoderFallback DecoderFallback
		{
			get
			{
				return this.decoderFallback;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.decoderFallback = value;
			}
		}

		/// <summary>При переопределении в производном классе создается неполная копия текущего объекта <see cref="T:System.Text.Encoding" />.</summary>
		/// <returns>Копия текущего объекта <see cref="T:System.Text.Encoding" />.</returns>
		// Token: 0x060027BE RID: 10174 RVA: 0x00090BFD File Offset: 0x0008EDFD
		[ComVisible(false)]
		public virtual object Clone()
		{
			Encoding encoding = (Encoding)base.MemberwiseClone();
			encoding.m_isReadOnly = false;
			return encoding;
		}

		/// <summary>При переопределении в производном классе получает значение, указывающее, является ли текущая кодировка доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Text.Encoding" /> доступен только для чтения, в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x00090C11 File Offset: 0x0008EE11
		[ComVisible(false)]
		public bool IsReadOnly
		{
			get
			{
				return this.m_isReadOnly;
			}
		}

		/// <summary>Получает кодировку для набора символов ASCII (7-разрядных).</summary>
		/// <returns>Кодировка набора символов ASCII (7-разрядных).</returns>
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x00090C19 File Offset: 0x0008EE19
		public static Encoding ASCII
		{
			get
			{
				if (Encoding.asciiEncoding == null)
				{
					Encoding.asciiEncoding = new ASCIIEncoding();
				}
				return Encoding.asciiEncoding;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x00090C37 File Offset: 0x0008EE37
		private static Encoding Latin1
		{
			get
			{
				if (Encoding.latin1Encoding == null)
				{
					Encoding.latin1Encoding = new Latin1Encoding();
				}
				return Encoding.latin1Encoding;
			}
		}

		/// <summary>При переопределении в производном классе вычисляет количество байтов, полученных при кодировании всех символов из заданного массива символов.</summary>
		/// <param name="chars">Массив символов, содержащий символы, которые требуется закодировать.</param>
		/// <returns>Количество байтов, полученных при кодировании всех символов из указанного массива символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027C2 RID: 10178 RVA: 0x00090C55 File Offset: 0x0008EE55
		public virtual int GetByteCount(char[] chars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", Environment.GetResourceString("Array cannot be null."));
			}
			return this.GetByteCount(chars, 0, chars.Length);
		}

		/// <summary>При переопределении в производном классе вычисляет число байтов, полученных при кодировании символов в заданной строке.</summary>
		/// <param name="s">Строка, содержащая набор символов для кодирования.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027C3 RID: 10179 RVA: 0x00090C7C File Offset: 0x0008EE7C
		public virtual int GetByteCount(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			char[] array = s.ToCharArray();
			return this.GetByteCount(array, 0, array.Length);
		}

		/// <summary>При переопределении в производном классе вычисляет количество байтов, полученных при кодировании набора символов из указанного массива символов.</summary>
		/// <param name="chars">Массив символов, содержащий набор кодируемых символов.</param>
		/// <param name="index">Индекс первого кодируемого символа.</param>
		/// <param name="count">Число кодируемых символов.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="chars" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027C4 RID: 10180
		public abstract int GetByteCount(char[] chars, int index, int count);

		// Token: 0x060027C5 RID: 10181 RVA: 0x00090CA9 File Offset: 0x0008EEA9
		public int GetByteCount(string str, int index, int count)
		{
			return this.GetByteCount(str.ToCharArray(), index, count);
		}

		/// <summary>При переопределении в производном классе вычисляет количество байтов, полученных при кодировании набора символов, начиная с заданного указателя символа.</summary>
		/// <param name="chars">Указатель на первый кодируемый символ.</param>
		/// <param name="count">Число кодируемых символов.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027C6 RID: 10182 RVA: 0x00090CBC File Offset: 0x0008EEBC
		[SecurityCritical]
		[CLSCompliant(false)]
		[ComVisible(false)]
		public unsafe virtual int GetByteCount(char* chars, int count)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", Environment.GetResourceString("Array cannot be null."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			char[] array = new char[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = chars[i];
			}
			return this.GetByteCount(array, 0, count);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x00090D22 File Offset: 0x0008EF22
		[SecurityCritical]
		internal unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			return this.GetByteCount(chars, count);
		}

		/// <summary>При переопределении в производном классе кодирует все символы из указанного массива символов в последовательность байтов.</summary>
		/// <param name="chars">Массив символов, содержащий символы, которые требуется закодировать.</param>
		/// <returns>Массив байтов, содержащий результаты кодирования указанного набора символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027C8 RID: 10184 RVA: 0x00090D2C File Offset: 0x0008EF2C
		public virtual byte[] GetBytes(char[] chars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", Environment.GetResourceString("Array cannot be null."));
			}
			return this.GetBytes(chars, 0, chars.Length);
		}

		/// <summary>При переопределении в производном классе кодирует набор символов из указанного массива символов в последовательность байтов.</summary>
		/// <param name="chars">Массив символов, содержащий набор кодируемых символов.</param>
		/// <param name="index">Индекс первого кодируемого символа.</param>
		/// <param name="count">Число кодируемых символов.</param>
		/// <returns>Массив байтов, содержащий результаты кодирования указанного набора символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="chars" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027C9 RID: 10185 RVA: 0x00090D54 File Offset: 0x0008EF54
		public virtual byte[] GetBytes(char[] chars, int index, int count)
		{
			byte[] array = new byte[this.GetByteCount(chars, index, count)];
			this.GetBytes(chars, index, count, array, 0);
			return array;
		}

		/// <summary>При переопределении в производном классе кодирует набор символов из указанного массива символов в указанный массив байтов.</summary>
		/// <param name="chars">Массив символов, содержащий набор кодируемых символов.</param>
		/// <param name="charIndex">Индекс первого кодируемого символа.</param>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <param name="bytes">Массив байтов, в который будет помещена результирующая последовательность байтов.</param>
		/// <param name="byteIndex">Индекс, с которого начинается запись результирующей последовательности байтов.</param>
		/// <returns>Фактическое число байтов, записанных в <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charIndex" />, <paramref name="charCount" /> или <paramref name="byteIndex" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="charIndex" /> и <paramref name="charCount" /> не указывают допустимый диапазон в <paramref name="chars" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="byteIndex" /> не является допустимым индексом в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недостаточно емкости <paramref name="bytes" /> от <paramref name="byteIndex" /> до конца массива для размещения полученных байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027CA RID: 10186
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

		/// <summary>При переопределении в производном классе кодирует все символы заданной строки в последовательность байтов.</summary>
		/// <param name="s">Строка, содержащая символы, которые требуется закодировать.</param>
		/// <returns>Массив байтов, содержащий результаты кодирования указанного набора символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027CB RID: 10187 RVA: 0x00090D80 File Offset: 0x0008EF80
		public virtual byte[] GetBytes(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s", Environment.GetResourceString("String reference not set to an instance of a String."));
			}
			byte[] array = new byte[this.GetByteCount(s)];
			this.GetBytes(s, 0, s.Length, array, 0);
			return array;
		}

		/// <summary>При переопределении в производном классе кодирует набор символов из заданной строки в заданный массив байтов.</summary>
		/// <param name="s">Строка, содержащая набор символов для кодирования.</param>
		/// <param name="charIndex">Индекс первого кодируемого символа.</param>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <param name="bytes">Массив байтов, в который будет помещена результирующая последовательность байтов.</param>
		/// <param name="byteIndex">Индекс, с которого начинается запись результирующей последовательности байтов.</param>
		/// <returns>Фактическое число байтов, записанных в <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charIndex" />, <paramref name="charCount" /> или <paramref name="byteIndex" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="charIndex" /> и <paramref name="charCount" /> не указывают допустимый диапазон в <paramref name="chars" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="byteIndex" /> не является допустимым индексом в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недостаточно емкости <paramref name="bytes" /> от <paramref name="byteIndex" /> до конца массива для размещения полученных байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027CC RID: 10188 RVA: 0x00090DC4 File Offset: 0x0008EFC4
		public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			return this.GetBytes(s.ToCharArray(), charIndex, charCount, bytes, byteIndex);
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00090DE6 File Offset: 0x0008EFE6
		[SecurityCritical]
		internal unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			return this.GetBytes(chars, charCount, bytes, byteCount);
		}

		/// <summary>При переопределении в производном классе кодирует набор символов, начало которого задается указателем символа, в последовательность байтов, которые сохраняются, начиная с заданного указателя байта.</summary>
		/// <param name="chars">Указатель на первый кодируемый символ.</param>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <param name="bytes">Указатель на положение, с которого начинается запись результирующей последовательности байтов.</param>
		/// <param name="byteCount">Максимальное число байтов для записи.</param>
		/// <returns>Фактическое число байтов, записанных в местоположение, которое задано параметром <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charCount" /> или <paramref name="byteCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="byteCount" /> меньше результирующего числа байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027CE RID: 10190 RVA: 0x00090DF4 File Offset: 0x0008EFF4
		[SecurityCritical]
		[ComVisible(false)]
		[CLSCompliant(false)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", Environment.GetResourceString("Array cannot be null."));
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", Environment.GetResourceString("Non-negative number required."));
			}
			char[] array = new char[charCount];
			for (int i = 0; i < charCount; i++)
			{
				array[i] = chars[i];
			}
			byte[] array2 = new byte[byteCount];
			int bytes2 = this.GetBytes(array, 0, charCount, array2, 0);
			if (bytes2 < byteCount)
			{
				byteCount = bytes2;
			}
			for (int i = 0; i < byteCount; i++)
			{
				bytes[i] = array2[i];
			}
			return byteCount;
		}

		/// <summary>При переопределении в производном классе вычисляет количество символов, полученных при декодировании всех байтов из заданного массива байтов.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <returns>Число символов, полученных при декодировании заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027CF RID: 10191 RVA: 0x00090EA4 File Offset: 0x0008F0A4
		public virtual int GetCharCount(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			return this.GetCharCount(bytes, 0, bytes.Length);
		}

		/// <summary>При переопределении в производном классе вычисляет количество символов, полученных при декодировании последовательности байтов из заданного массива байтов.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="index">Индекс первого декодируемого байта.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <returns>Число символов, полученных при декодировании заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027D0 RID: 10192
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		/// <summary>При переопределении в производном классе вычисляет количество символов, полученных при декодировании последовательности байтов, начало которой задается указателем байтов.</summary>
		/// <param name="bytes">Указатель на первый декодируемый байт.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <returns>Число символов, полученных при декодировании заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027D1 RID: 10193 RVA: 0x00090ECC File Offset: 0x0008F0CC
		[SecurityCritical]
		[CLSCompliant(false)]
		[ComVisible(false)]
		public unsafe virtual int GetCharCount(byte* bytes, int count)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			byte[] array = new byte[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = bytes[i];
			}
			return this.GetCharCount(array, 0, count);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00090F2F File Offset: 0x0008F12F
		[SecurityCritical]
		internal unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			return this.GetCharCount(bytes, count);
		}

		/// <summary>При переопределении в производном классе декодирует все байты из указанного массива байтов в набор символов.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <returns>Массив символов, содержащий результаты декодирования указанной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027D3 RID: 10195 RVA: 0x00090F39 File Offset: 0x0008F139
		public virtual char[] GetChars(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			return this.GetChars(bytes, 0, bytes.Length);
		}

		/// <summary>При переопределении в производном классе декодирует последовательность байтов из указанного массива байтов в набор символов.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="index">Индекс первого декодируемого байта.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <returns>Массив символов, содержащий результаты декодирования указанной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027D4 RID: 10196 RVA: 0x00090F60 File Offset: 0x0008F160
		public virtual char[] GetChars(byte[] bytes, int index, int count)
		{
			char[] array = new char[this.GetCharCount(bytes, index, count)];
			this.GetChars(bytes, index, count, array, 0);
			return array;
		}

		/// <summary>При переопределении в производном классе декодирует последовательность байтов из указанного массива байтов в указанный массив символов.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="byteIndex">Индекс первого декодируемого байта.</param>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <param name="chars">Массив символов, в который будет помещен результирующий набор символов.</param>
		/// <param name="charIndex">Индекс, с которого начинается запись результирующего набора символов.</param>
		/// <returns>Фактическое число символов, записанных в <paramref name="chars" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteIndex" />, <paramref name="byteCount" /> или <paramref name="charIndex" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="byteindex" /> и <paramref name="byteCount" /> не указывают допустимый диапазон в <paramref name="bytes" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="charIndex" /> не является допустимым индексом в <paramref name="chars" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недостаточно емкости <paramref name="chars" /> от <paramref name="charIndex" /> до конца массива для размещения полученных символов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027D5 RID: 10197
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		/// <summary>При переопределении в производном классе декодирует последовательность байтов, которая начинается с заданного указателя байта, в набор символов, которые сохраняются, начиная с заданного указателя символа.</summary>
		/// <param name="bytes">Указатель на первый декодируемый байт.</param>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <param name="chars">Указатель на положение, с которого начинается запись результирующего набора символов.</param>
		/// <param name="charCount">Наибольшее количество символов для записи.</param>
		/// <returns>Фактическое число символов, записанных в местоположение, которое задано параметром <paramref name="chars" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteCount" /> или <paramref name="charCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="charCount" /> меньше результирующего числа символов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027D6 RID: 10198 RVA: 0x00090F8C File Offset: 0x0008F18C
		[ComVisible(false)]
		[CLSCompliant(false)]
		[SecurityCritical]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", Environment.GetResourceString("Array cannot be null."));
			}
			if (byteCount < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteCount < 0) ? "byteCount" : "charCount", Environment.GetResourceString("Non-negative number required."));
			}
			byte[] array = new byte[byteCount];
			for (int i = 0; i < byteCount; i++)
			{
				array[i] = bytes[i];
			}
			char[] array2 = new char[charCount];
			int chars2 = this.GetChars(array, 0, byteCount, array2, 0);
			if (chars2 < charCount)
			{
				charCount = chars2;
			}
			for (int i = 0; i < charCount; i++)
			{
				chars[i] = array2[i];
			}
			return charCount;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0009103C File Offset: 0x0008F23C
		[SecurityCritical]
		internal unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			return this.GetChars(bytes, byteCount, chars, charCount);
		}

		/// <summary>При переопределении в производном классе декодирует указанное количество байтов начиная с указанного адреса в строку.</summary>
		/// <param name="bytes">Указатель на массив байтов.</param>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <returns>Строка, содержащая результаты декодирования заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> является пустым указателем</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027D8 RID: 10200 RVA: 0x00091049 File Offset: 0x0008F249
		[SecurityCritical]
		[CLSCompliant(false)]
		[ComVisible(false)]
		public unsafe string GetString(byte* bytes, int byteCount)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", Environment.GetResourceString("Non-negative number required."));
			}
			return string.CreateStringFromEncoding(bytes, byteCount, this);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00091088 File Offset: 0x0008F288
		public unsafe virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				fixed (char* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
				{
					char* chars2 = nonNullPinnableReference2;
					return this.GetChars(bytes2, bytes.Length, chars2, chars.Length);
				}
			}
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000910C0 File Offset: 0x0008F2C0
		public unsafe string GetString(ReadOnlySpan<byte> bytes)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				return this.GetString(bytes2, bytes.Length);
			}
		}

		/// <summary>При переопределении в производном классе получает идентификатор кодовой страницы текущего объекта <see cref="T:System.Text.Encoding" />.</summary>
		/// <returns>Идентификатор кодовой страницы текущего объекта <see cref="T:System.Text.Encoding" />.</returns>
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000910E5 File Offset: 0x0008F2E5
		public virtual int CodePage
		{
			get
			{
				return this.m_codePage;
			}
		}

		/// <summary>Получает значение, которое указывает, является ли текущая кодировка всегда нормализованной с использованием формы нормализации по умолчанию.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект <see cref="T:System.Text.Encoding" /> всегда нормирован; в противоположном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x060027DC RID: 10204 RVA: 0x000910ED File Offset: 0x0008F2ED
		[ComVisible(false)]
		public bool IsAlwaysNormalized()
		{
			return this.IsAlwaysNormalized(NormalizationForm.FormC);
		}

		/// <summary>При переопределении в производном классе получает значение, которое указывает, является ли текущая кодировка всегда нормализованной с использованием заданной по умолчанию формы нормализации.</summary>
		/// <param name="form">Одно из значений перечисления <see cref="T:System.Text.NormalizationForm" />.</param>
		/// <returns>
		///   <see langword="true" />, если текущий объект <see cref="T:System.Text.Encoding" /> всегда нормализуется с использованием заданного значения <see cref="T:System.Text.NormalizationForm" />; в противоположном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x060027DD RID: 10205 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[ComVisible(false)]
		public virtual bool IsAlwaysNormalized(NormalizationForm form)
		{
			return false;
		}

		/// <summary>При переопределении в производном классе получает декодер, который преобразует последовательность байтов в последовательность символов.</summary>
		/// <returns>Объект <see cref="T:System.Text.Decoder" />, преобразующий закодированную последовательность байтов в последовательность символов.</returns>
		// Token: 0x060027DE RID: 10206 RVA: 0x000910F6 File Offset: 0x0008F2F6
		public virtual Decoder GetDecoder()
		{
			return new Encoding.DefaultDecoder(this);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x000910FE File Offset: 0x0008F2FE
		[SecurityCritical]
		private static Encoding CreateDefaultEncoding()
		{
			Encoding encoding = EncodingHelper.GetDefaultEncoding();
			encoding.m_isReadOnly = true;
			return encoding;
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0009110C File Offset: 0x0008F30C
		internal void setReadOnly(bool value = true)
		{
			this.m_isReadOnly = value;
		}

		/// <summary>Возвращает кодировку по умолчанию для данной реализации .NET.</summary>
		/// <returns>Кодировка по умолчанию для данной реализации .NET.</returns>
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00091115 File Offset: 0x0008F315
		public static Encoding Default
		{
			[SecuritySafeCritical]
			get
			{
				if (Encoding.defaultEncoding == null)
				{
					Encoding.defaultEncoding = Encoding.CreateDefaultEncoding();
				}
				return Encoding.defaultEncoding;
			}
		}

		/// <summary>При переопределении в производном классе получает кодировщик, который преобразует последовательность символов Юникода в закодированную последовательность байтов.</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoder" />, преобразующий последовательность символов Юникода в закодированную последовательность байтов.</returns>
		// Token: 0x060027E2 RID: 10210 RVA: 0x00091133 File Offset: 0x0008F333
		public virtual Encoder GetEncoder()
		{
			return new Encoding.DefaultEncoder(this);
		}

		/// <summary>При переопределении в производном классе вычисляет максимальное количество байтов, полученных при кодировании заданного количества символов.</summary>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <returns>Максимальное количество байтов, полученных при кодировании заданного количества символов.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060027E3 RID: 10211
		public abstract int GetMaxByteCount(int charCount);

		/// <summary>При переопределении в производном классе вычисляет максимальное количество символов, полученных при декодировании заданного количества байтов.</summary>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <returns>Максимальное количество символов, полученных при декодировании заданного количества байтов.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027E4 RID: 10212
		public abstract int GetMaxCharCount(int byteCount);

		/// <summary>При переопределении в производном классе декодирует все байты из указанного массива байтов в строку.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <returns>Строка, содержащая результаты декодирования заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentException">Массив байтов содержит недопустимые точки кода Юникод.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027E5 RID: 10213 RVA: 0x0009113B File Offset: 0x0008F33B
		public virtual string GetString(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			return this.GetString(bytes, 0, bytes.Length);
		}

		/// <summary>При переопределении в производном классе декодирует последовательность байтов из указанного массива байтов в строку.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="index">Индекс первого декодируемого байта.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <returns>Строка, содержащая результаты декодирования заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentException">Массив байтов содержит недопустимые точки кода Юникод.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060027E6 RID: 10214 RVA: 0x00091160 File Offset: 0x0008F360
		public virtual string GetString(byte[] bytes, int index, int count)
		{
			return new string(this.GetChars(bytes, index, count));
		}

		/// <summary>Получает кодировку для формата UTF-16 с прямым порядком байтов.</summary>
		/// <returns>Кодировка для формата UTF-16 с прямым порядком байтов.</returns>
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x00091170 File Offset: 0x0008F370
		public static Encoding Unicode
		{
			get
			{
				if (Encoding.unicodeEncoding == null)
				{
					Encoding.unicodeEncoding = new UnicodeEncoding(false, true);
				}
				return Encoding.unicodeEncoding;
			}
		}

		/// <summary>Получает кодировку для формата UTF-16 с обратным порядком байтов.</summary>
		/// <returns>Объект кодировки для формата UTF-16 с обратным порядком байтов.</returns>
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x00091190 File Offset: 0x0008F390
		public static Encoding BigEndianUnicode
		{
			get
			{
				if (Encoding.bigEndianUnicode == null)
				{
					Encoding.bigEndianUnicode = new UnicodeEncoding(true, true);
				}
				return Encoding.bigEndianUnicode;
			}
		}

		/// <summary>Получает кодировку для формата UTF-7.</summary>
		/// <returns>Кодировка для формата UTF-7.</returns>
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x000911B0 File Offset: 0x0008F3B0
		public static Encoding UTF7
		{
			get
			{
				if (Encoding.utf7Encoding == null)
				{
					Encoding.utf7Encoding = new UTF7Encoding();
				}
				return Encoding.utf7Encoding;
			}
		}

		/// <summary>Получает кодировку для формата UTF-8.</summary>
		/// <returns>Кодировка для формата UTF-8.</returns>
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x000911CE File Offset: 0x0008F3CE
		public static Encoding UTF8
		{
			get
			{
				if (Encoding.utf8Encoding == null)
				{
					Encoding.utf8Encoding = new UTF8Encoding(true);
				}
				return Encoding.utf8Encoding;
			}
		}

		/// <summary>Получает кодировку для формата UTF-32 с прямым порядком байтов.</summary>
		/// <returns>Объект кодировки для формата UTF-32 с прямым порядком байтов.</returns>
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x000911ED File Offset: 0x0008F3ED
		public static Encoding UTF32
		{
			get
			{
				if (Encoding.utf32Encoding == null)
				{
					Encoding.utf32Encoding = new UTF32Encoding(false, true);
				}
				return Encoding.utf32Encoding;
			}
		}

		/// <summary>Определяет, равен ли указанный объект <see cref="T:System.Object" /> текущему экземпляру.</summary>
		/// <param name="value">
		///   <see cref="T:System.Object" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> является экземпляром <see cref="T:System.Text.Encoding" />, равным текущему экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060027EC RID: 10220 RVA: 0x00091210 File Offset: 0x0008F410
		public override bool Equals(object value)
		{
			Encoding encoding = value as Encoding;
			return encoding != null && (this.m_codePage == encoding.m_codePage && this.EncoderFallback.Equals(encoding.EncoderFallback)) && this.DecoderFallback.Equals(encoding.DecoderFallback);
		}

		/// <summary>Возвращает хэш-код текущего экземпляра.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x060027ED RID: 10221 RVA: 0x0009125D File Offset: 0x0008F45D
		public override int GetHashCode()
		{
			return this.m_codePage + this.EncoderFallback.GetHashCode() + this.DecoderFallback.GetHashCode();
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x0009127D File Offset: 0x0008F47D
		internal virtual char[] GetBestFitUnicodeToBytesData()
		{
			return EmptyArray<char>.Value;
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x0009127D File Offset: 0x0008F47D
		internal virtual char[] GetBestFitBytesToUnicodeData()
		{
			return EmptyArray<char>.Value;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00091284 File Offset: 0x0008F484
		internal void ThrowBytesOverflow()
		{
			throw new ArgumentException(Environment.GetResourceString("The output byte buffer is too small to contain the encoded data, encoding '{0}' fallback '{1}'.", new object[]
			{
				this.EncodingName,
				this.EncoderFallback.GetType()
			}), "bytes");
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000912B7 File Offset: 0x0008F4B7
		[SecurityCritical]
		internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
		{
			if (encoder == null || encoder._throwOnOverflow || nothingEncoded)
			{
				if (encoder != null && encoder.InternalHasFallbackBuffer)
				{
					encoder.FallbackBuffer.InternalReset();
				}
				this.ThrowBytesOverflow();
			}
			encoder.ClearMustFlush();
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000912EB File Offset: 0x0008F4EB
		internal void ThrowCharsOverflow()
		{
			throw new ArgumentException(Environment.GetResourceString("The output char buffer is too small to contain the decoded characters, encoding '{0}' fallback '{1}'.", new object[]
			{
				this.EncodingName,
				this.DecoderFallback.GetType()
			}), "chars");
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x0009131E File Offset: 0x0008F51E
		[SecurityCritical]
		internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
		{
			if (decoder == null || decoder._throwOnOverflow || nothingDecoded)
			{
				if (decoder != null && decoder.InternalHasFallbackBuffer)
				{
					decoder.FallbackBuffer.InternalReset();
				}
				this.ThrowCharsOverflow();
			}
			decoder.ClearMustFlush();
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00091354 File Offset: 0x0008F554
		public unsafe virtual int GetCharCount(ReadOnlySpan<byte> bytes)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				return this.GetCharCount(bytes2, bytes.Length);
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0009137C File Offset: 0x0008F57C
		public unsafe virtual int GetByteCount(ReadOnlySpan<char> chars)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				return this.GetByteCount(chars2, chars.Length);
			}
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000913A4 File Offset: 0x0008F5A4
		public unsafe virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				fixed (byte* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
				{
					byte* bytes2 = nonNullPinnableReference2;
					return this.GetBytes(chars2, chars.Length, bytes2, bytes.Length);
				}
			}
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x000913DC File Offset: 0x0008F5DC
		public unsafe byte[] GetBytes(string s, int index, int count)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s", "String reference not set to an instance of a String.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (index > s.Length - count)
			{
				throw new ArgumentOutOfRangeException("index", "Index and count must refer to a location within the string.");
			}
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			int byteCount = this.GetByteCount(ptr + index, count);
			if (byteCount == 0)
			{
				return Array.Empty<byte>();
			}
			byte[] array = new byte[byteCount];
			fixed (byte* ptr2 = &array[0])
			{
				byte* bytes = ptr2;
				this.GetBytes(ptr + index, count, bytes, byteCount);
			}
			return array;
		}

		// Token: 0x04001E14 RID: 7700
		private static volatile Encoding defaultEncoding;

		// Token: 0x04001E15 RID: 7701
		private static volatile Encoding unicodeEncoding;

		// Token: 0x04001E16 RID: 7702
		private static volatile Encoding bigEndianUnicode;

		// Token: 0x04001E17 RID: 7703
		private static volatile Encoding utf7Encoding;

		// Token: 0x04001E18 RID: 7704
		private static volatile Encoding utf8Encoding;

		// Token: 0x04001E19 RID: 7705
		private static volatile Encoding utf32Encoding;

		// Token: 0x04001E1A RID: 7706
		private static volatile Encoding asciiEncoding;

		// Token: 0x04001E1B RID: 7707
		private static volatile Encoding latin1Encoding;

		// Token: 0x04001E1C RID: 7708
		private static volatile Dictionary<int, Encoding> encodings;

		// Token: 0x04001E1D RID: 7709
		private const int MIMECONTF_MAILNEWS = 1;

		// Token: 0x04001E1E RID: 7710
		private const int MIMECONTF_BROWSER = 2;

		// Token: 0x04001E1F RID: 7711
		private const int MIMECONTF_SAVABLE_MAILNEWS = 256;

		// Token: 0x04001E20 RID: 7712
		private const int MIMECONTF_SAVABLE_BROWSER = 512;

		// Token: 0x04001E21 RID: 7713
		private const int CodePageDefault = 0;

		// Token: 0x04001E22 RID: 7714
		private const int CodePageNoOEM = 1;

		// Token: 0x04001E23 RID: 7715
		private const int CodePageNoMac = 2;

		// Token: 0x04001E24 RID: 7716
		private const int CodePageNoThread = 3;

		// Token: 0x04001E25 RID: 7717
		private const int CodePageNoSymbol = 42;

		// Token: 0x04001E26 RID: 7718
		private const int CodePageUnicode = 1200;

		// Token: 0x04001E27 RID: 7719
		private const int CodePageBigEndian = 1201;

		// Token: 0x04001E28 RID: 7720
		private const int CodePageWindows1252 = 1252;

		// Token: 0x04001E29 RID: 7721
		private const int CodePageMacGB2312 = 10008;

		// Token: 0x04001E2A RID: 7722
		private const int CodePageGB2312 = 20936;

		// Token: 0x04001E2B RID: 7723
		private const int CodePageMacKorean = 10003;

		// Token: 0x04001E2C RID: 7724
		private const int CodePageDLLKorean = 20949;

		// Token: 0x04001E2D RID: 7725
		private const int ISO2022JP = 50220;

		// Token: 0x04001E2E RID: 7726
		private const int ISO2022JPESC = 50221;

		// Token: 0x04001E2F RID: 7727
		private const int ISO2022JPSISO = 50222;

		// Token: 0x04001E30 RID: 7728
		private const int ISOKorean = 50225;

		// Token: 0x04001E31 RID: 7729
		private const int ISOSimplifiedCN = 50227;

		// Token: 0x04001E32 RID: 7730
		private const int EUCJP = 51932;

		// Token: 0x04001E33 RID: 7731
		private const int ChineseHZ = 52936;

		// Token: 0x04001E34 RID: 7732
		private const int DuplicateEUCCN = 51936;

		// Token: 0x04001E35 RID: 7733
		private const int EUCCN = 936;

		// Token: 0x04001E36 RID: 7734
		private const int EUCKR = 51949;

		// Token: 0x04001E37 RID: 7735
		internal const int CodePageASCII = 20127;

		// Token: 0x04001E38 RID: 7736
		internal const int ISO_8859_1 = 28591;

		// Token: 0x04001E39 RID: 7737
		private const int ISCIIAssemese = 57006;

		// Token: 0x04001E3A RID: 7738
		private const int ISCIIBengali = 57003;

		// Token: 0x04001E3B RID: 7739
		private const int ISCIIDevanagari = 57002;

		// Token: 0x04001E3C RID: 7740
		private const int ISCIIGujarathi = 57010;

		// Token: 0x04001E3D RID: 7741
		private const int ISCIIKannada = 57008;

		// Token: 0x04001E3E RID: 7742
		private const int ISCIIMalayalam = 57009;

		// Token: 0x04001E3F RID: 7743
		private const int ISCIIOriya = 57007;

		// Token: 0x04001E40 RID: 7744
		private const int ISCIIPanjabi = 57011;

		// Token: 0x04001E41 RID: 7745
		private const int ISCIITamil = 57004;

		// Token: 0x04001E42 RID: 7746
		private const int ISCIITelugu = 57005;

		// Token: 0x04001E43 RID: 7747
		private const int GB18030 = 54936;

		// Token: 0x04001E44 RID: 7748
		private const int ISO_8859_8I = 38598;

		// Token: 0x04001E45 RID: 7749
		private const int ISO_8859_8_Visual = 28598;

		// Token: 0x04001E46 RID: 7750
		private const int ENC50229 = 50229;

		// Token: 0x04001E47 RID: 7751
		private const int CodePageUTF7 = 65000;

		// Token: 0x04001E48 RID: 7752
		private const int CodePageUTF8 = 65001;

		// Token: 0x04001E49 RID: 7753
		private const int CodePageUTF32 = 12000;

		// Token: 0x04001E4A RID: 7754
		private const int CodePageUTF32BE = 12001;

		// Token: 0x04001E4B RID: 7755
		internal int m_codePage;

		// Token: 0x04001E4C RID: 7756
		internal CodePageDataItem dataItem;

		// Token: 0x04001E4D RID: 7757
		[NonSerialized]
		internal bool m_deserializedFromEverett;

		// Token: 0x04001E4E RID: 7758
		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x04001E4F RID: 7759
		[OptionalField(VersionAdded = 2)]
		internal EncoderFallback encoderFallback;

		// Token: 0x04001E50 RID: 7760
		[OptionalField(VersionAdded = 2)]
		internal DecoderFallback decoderFallback;

		// Token: 0x04001E51 RID: 7761
		private static object s_InternalSyncObject;

		// Token: 0x020003BD RID: 957
		[Serializable]
		internal class DefaultEncoder : Encoder, ISerializable, IObjectReference
		{
			// Token: 0x060027F8 RID: 10232 RVA: 0x0009148D File Offset: 0x0008F68D
			public DefaultEncoder(Encoding encoding)
			{
				this.m_encoding = encoding;
				this.m_hasInitializedEncoding = true;
			}

			// Token: 0x060027F9 RID: 10233 RVA: 0x000914A4 File Offset: 0x0008F6A4
			internal DefaultEncoder(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				this.m_encoding = (Encoding)info.GetValue("encoding", typeof(Encoding));
				try
				{
					this._fallback = (EncoderFallback)info.GetValue("_fallback", typeof(EncoderFallback));
					this.charLeftOver = (char)info.GetValue("charLeftOver", typeof(char));
				}
				catch (SerializationException)
				{
				}
			}

			// Token: 0x060027FA RID: 10234 RVA: 0x0009153C File Offset: 0x0008F73C
			[SecurityCritical]
			public object GetRealObject(StreamingContext context)
			{
				if (this.m_hasInitializedEncoding)
				{
					return this;
				}
				Encoder encoder = this.m_encoding.GetEncoder();
				if (this._fallback != null)
				{
					encoder._fallback = this._fallback;
				}
				if (this.charLeftOver != '\0')
				{
					EncoderNLS encoderNLS = encoder as EncoderNLS;
					if (encoderNLS != null)
					{
						encoderNLS._charLeftOver = this.charLeftOver;
					}
				}
				return encoder;
			}

			// Token: 0x060027FB RID: 10235 RVA: 0x00091592 File Offset: 0x0008F792
			[SecurityCritical]
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				info.AddValue("encoding", this.m_encoding);
			}

			// Token: 0x060027FC RID: 10236 RVA: 0x000915B3 File Offset: 0x0008F7B3
			public override int GetByteCount(char[] chars, int index, int count, bool flush)
			{
				return this.m_encoding.GetByteCount(chars, index, count);
			}

			// Token: 0x060027FD RID: 10237 RVA: 0x000915C3 File Offset: 0x0008F7C3
			[SecurityCritical]
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				return this.m_encoding.GetByteCount(chars, count);
			}

			// Token: 0x060027FE RID: 10238 RVA: 0x000915D2 File Offset: 0x0008F7D2
			public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
			{
				return this.m_encoding.GetBytes(chars, charIndex, charCount, bytes, byteIndex);
			}

			// Token: 0x060027FF RID: 10239 RVA: 0x000915E6 File Offset: 0x0008F7E6
			[SecurityCritical]
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
			{
				return this.m_encoding.GetBytes(chars, charCount, bytes, byteCount);
			}

			// Token: 0x04001E52 RID: 7762
			private Encoding m_encoding;

			// Token: 0x04001E53 RID: 7763
			[NonSerialized]
			private bool m_hasInitializedEncoding;

			// Token: 0x04001E54 RID: 7764
			[NonSerialized]
			internal char charLeftOver;
		}

		// Token: 0x020003BE RID: 958
		[Serializable]
		internal class DefaultDecoder : Decoder, ISerializable, IObjectReference
		{
			// Token: 0x06002800 RID: 10240 RVA: 0x000915F8 File Offset: 0x0008F7F8
			public DefaultDecoder(Encoding encoding)
			{
				this.m_encoding = encoding;
				this.m_hasInitializedEncoding = true;
			}

			// Token: 0x06002801 RID: 10241 RVA: 0x00091610 File Offset: 0x0008F810
			internal DefaultDecoder(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				this.m_encoding = (Encoding)info.GetValue("encoding", typeof(Encoding));
				try
				{
					this._fallback = (DecoderFallback)info.GetValue("_fallback", typeof(DecoderFallback));
				}
				catch (SerializationException)
				{
					this._fallback = null;
				}
			}

			// Token: 0x06002802 RID: 10242 RVA: 0x00091690 File Offset: 0x0008F890
			[SecurityCritical]
			public object GetRealObject(StreamingContext context)
			{
				if (this.m_hasInitializedEncoding)
				{
					return this;
				}
				Decoder decoder = this.m_encoding.GetDecoder();
				if (this._fallback != null)
				{
					decoder._fallback = this._fallback;
				}
				return decoder;
			}

			// Token: 0x06002803 RID: 10243 RVA: 0x000916C8 File Offset: 0x0008F8C8
			[SecurityCritical]
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				info.AddValue("encoding", this.m_encoding);
			}

			// Token: 0x06002804 RID: 10244 RVA: 0x0008627E File Offset: 0x0008447E
			public override int GetCharCount(byte[] bytes, int index, int count)
			{
				return this.GetCharCount(bytes, index, count, false);
			}

			// Token: 0x06002805 RID: 10245 RVA: 0x000916E9 File Offset: 0x0008F8E9
			public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
			{
				return this.m_encoding.GetCharCount(bytes, index, count);
			}

			// Token: 0x06002806 RID: 10246 RVA: 0x000916F9 File Offset: 0x0008F8F9
			[SecurityCritical]
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				return this.m_encoding.GetCharCount(bytes, count);
			}

			// Token: 0x06002807 RID: 10247 RVA: 0x00086356 File Offset: 0x00084556
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
			{
				return this.GetChars(bytes, byteIndex, byteCount, chars, charIndex, false);
			}

			// Token: 0x06002808 RID: 10248 RVA: 0x00091708 File Offset: 0x0008F908
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
			{
				return this.m_encoding.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
			}

			// Token: 0x06002809 RID: 10249 RVA: 0x0009171C File Offset: 0x0008F91C
			[SecurityCritical]
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
			{
				return this.m_encoding.GetChars(bytes, byteCount, chars, charCount);
			}

			// Token: 0x04001E55 RID: 7765
			private Encoding m_encoding;

			// Token: 0x04001E56 RID: 7766
			[NonSerialized]
			private bool m_hasInitializedEncoding;
		}

		// Token: 0x020003BF RID: 959
		internal class EncodingCharBuffer
		{
			// Token: 0x0600280A RID: 10250 RVA: 0x00091730 File Offset: 0x0008F930
			[SecurityCritical]
			internal unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
			{
				this.enc = enc;
				this.decoder = decoder;
				this.chars = charStart;
				this.charStart = charStart;
				this.charEnd = charStart + charCount;
				this.byteStart = byteStart;
				this.bytes = byteStart;
				this.byteEnd = byteStart + byteCount;
				if (this.decoder == null)
				{
					this.fallbackBuffer = enc.DecoderFallback.CreateFallbackBuffer();
				}
				else
				{
					this.fallbackBuffer = this.decoder.FallbackBuffer;
				}
				this.fallbackBuffer.InternalInitialize(this.bytes, this.charEnd);
			}

			// Token: 0x0600280B RID: 10251 RVA: 0x000917CC File Offset: 0x0008F9CC
			[SecurityCritical]
			internal unsafe bool AddChar(char ch, int numBytes)
			{
				if (this.chars != null)
				{
					if (this.chars >= this.charEnd)
					{
						this.bytes -= numBytes;
						this.enc.ThrowCharsOverflow(this.decoder, this.bytes == this.byteStart);
						return false;
					}
					char* ptr = this.chars;
					this.chars = ptr + 1;
					*ptr = ch;
				}
				this.charCountResult++;
				return true;
			}

			// Token: 0x0600280C RID: 10252 RVA: 0x00091845 File Offset: 0x0008FA45
			[SecurityCritical]
			internal bool AddChar(char ch)
			{
				return this.AddChar(ch, 1);
			}

			// Token: 0x0600280D RID: 10253 RVA: 0x00091850 File Offset: 0x0008FA50
			[SecurityCritical]
			internal bool AddChar(char ch1, char ch2, int numBytes)
			{
				if (this.chars >= this.charEnd - 1)
				{
					this.bytes -= numBytes;
					this.enc.ThrowCharsOverflow(this.decoder, this.bytes == this.byteStart);
					return false;
				}
				return this.AddChar(ch1, numBytes) && this.AddChar(ch2, numBytes);
			}

			// Token: 0x0600280E RID: 10254 RVA: 0x000918B3 File Offset: 0x0008FAB3
			[SecurityCritical]
			internal void AdjustBytes(int count)
			{
				this.bytes += count;
			}

			// Token: 0x170004E4 RID: 1252
			// (get) Token: 0x0600280F RID: 10255 RVA: 0x000918C3 File Offset: 0x0008FAC3
			internal bool MoreData
			{
				[SecurityCritical]
				get
				{
					return this.bytes < this.byteEnd;
				}
			}

			// Token: 0x06002810 RID: 10256 RVA: 0x000918D3 File Offset: 0x0008FAD3
			[SecurityCritical]
			internal bool EvenMoreData(int count)
			{
				return this.bytes == this.byteEnd - count;
			}

			// Token: 0x06002811 RID: 10257 RVA: 0x000918E8 File Offset: 0x0008FAE8
			[SecurityCritical]
			internal unsafe byte GetNextByte()
			{
				if (this.bytes >= this.byteEnd)
				{
					return 0;
				}
				byte* ptr = this.bytes;
				this.bytes = ptr + 1;
				return *ptr;
			}

			// Token: 0x170004E5 RID: 1253
			// (get) Token: 0x06002812 RID: 10258 RVA: 0x00091917 File Offset: 0x0008FB17
			internal int BytesUsed
			{
				[SecurityCritical]
				get
				{
					return (int)((long)(this.bytes - this.byteStart));
				}
			}

			// Token: 0x06002813 RID: 10259 RVA: 0x0009192C File Offset: 0x0008FB2C
			[SecurityCritical]
			internal bool Fallback(byte fallbackByte)
			{
				byte[] byteBuffer = new byte[]
				{
					fallbackByte
				};
				return this.Fallback(byteBuffer);
			}

			// Token: 0x06002814 RID: 10260 RVA: 0x0009194C File Offset: 0x0008FB4C
			[SecurityCritical]
			internal bool Fallback(byte byte1, byte byte2)
			{
				byte[] byteBuffer = new byte[]
				{
					byte1,
					byte2
				};
				return this.Fallback(byteBuffer);
			}

			// Token: 0x06002815 RID: 10261 RVA: 0x00091970 File Offset: 0x0008FB70
			[SecurityCritical]
			internal bool Fallback(byte byte1, byte byte2, byte byte3, byte byte4)
			{
				byte[] byteBuffer = new byte[]
				{
					byte1,
					byte2,
					byte3,
					byte4
				};
				return this.Fallback(byteBuffer);
			}

			// Token: 0x06002816 RID: 10262 RVA: 0x0009199C File Offset: 0x0008FB9C
			[SecurityCritical]
			internal unsafe bool Fallback(byte[] byteBuffer)
			{
				if (this.chars != null)
				{
					char* ptr = this.chars;
					if (!this.fallbackBuffer.InternalFallback(byteBuffer, this.bytes, ref this.chars))
					{
						this.bytes -= byteBuffer.Length;
						this.fallbackBuffer.InternalReset();
						this.enc.ThrowCharsOverflow(this.decoder, this.chars == this.charStart);
						return false;
					}
					this.charCountResult += (int)((long)(this.chars - ptr));
				}
				else
				{
					this.charCountResult += this.fallbackBuffer.InternalFallback(byteBuffer, this.bytes);
				}
				return true;
			}

			// Token: 0x170004E6 RID: 1254
			// (get) Token: 0x06002817 RID: 10263 RVA: 0x00091A4B File Offset: 0x0008FC4B
			internal int Count
			{
				get
				{
					return this.charCountResult;
				}
			}

			// Token: 0x04001E57 RID: 7767
			[SecurityCritical]
			private unsafe char* chars;

			// Token: 0x04001E58 RID: 7768
			[SecurityCritical]
			private unsafe char* charStart;

			// Token: 0x04001E59 RID: 7769
			[SecurityCritical]
			private unsafe char* charEnd;

			// Token: 0x04001E5A RID: 7770
			private int charCountResult;

			// Token: 0x04001E5B RID: 7771
			private Encoding enc;

			// Token: 0x04001E5C RID: 7772
			private DecoderNLS decoder;

			// Token: 0x04001E5D RID: 7773
			[SecurityCritical]
			private unsafe byte* byteStart;

			// Token: 0x04001E5E RID: 7774
			[SecurityCritical]
			private unsafe byte* byteEnd;

			// Token: 0x04001E5F RID: 7775
			[SecurityCritical]
			private unsafe byte* bytes;

			// Token: 0x04001E60 RID: 7776
			private DecoderFallbackBuffer fallbackBuffer;
		}

		// Token: 0x020003C0 RID: 960
		internal class EncodingByteBuffer
		{
			// Token: 0x06002818 RID: 10264 RVA: 0x00091A54 File Offset: 0x0008FC54
			[SecurityCritical]
			internal unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
			{
				this.enc = inEncoding;
				this.encoder = inEncoder;
				this.charStart = inCharStart;
				this.chars = inCharStart;
				this.charEnd = inCharStart + inCharCount;
				this.bytes = inByteStart;
				this.byteStart = inByteStart;
				this.byteEnd = inByteStart + inByteCount;
				if (this.encoder == null)
				{
					this.fallbackBuffer = this.enc.EncoderFallback.CreateFallbackBuffer();
				}
				else
				{
					this.fallbackBuffer = this.encoder.FallbackBuffer;
					if (this.encoder._throwOnOverflow && this.encoder.InternalHasFallbackBuffer && this.fallbackBuffer.Remaining > 0)
					{
						throw new ArgumentException(Environment.GetResourceString("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", new object[]
						{
							this.encoder.Encoding.EncodingName,
							this.encoder.Fallback.GetType()
						}));
					}
				}
				this.fallbackBuffer.InternalInitialize(this.chars, this.charEnd, this.encoder, this.bytes != null);
			}

			// Token: 0x06002819 RID: 10265 RVA: 0x00091B6C File Offset: 0x0008FD6C
			[SecurityCritical]
			internal unsafe bool AddByte(byte b, int moreBytesExpected)
			{
				if (this.bytes != null)
				{
					if (this.bytes >= this.byteEnd - moreBytesExpected)
					{
						this.MovePrevious(true);
						return false;
					}
					byte* ptr = this.bytes;
					this.bytes = ptr + 1;
					*ptr = b;
				}
				this.byteCountResult++;
				return true;
			}

			// Token: 0x0600281A RID: 10266 RVA: 0x00091BBE File Offset: 0x0008FDBE
			[SecurityCritical]
			internal bool AddByte(byte b1)
			{
				return this.AddByte(b1, 0);
			}

			// Token: 0x0600281B RID: 10267 RVA: 0x00091BC8 File Offset: 0x0008FDC8
			[SecurityCritical]
			internal bool AddByte(byte b1, byte b2)
			{
				return this.AddByte(b1, b2, 0);
			}

			// Token: 0x0600281C RID: 10268 RVA: 0x00091BD3 File Offset: 0x0008FDD3
			[SecurityCritical]
			internal bool AddByte(byte b1, byte b2, int moreBytesExpected)
			{
				return this.AddByte(b1, 1 + moreBytesExpected) && this.AddByte(b2, moreBytesExpected);
			}

			// Token: 0x0600281D RID: 10269 RVA: 0x00091BEB File Offset: 0x0008FDEB
			[SecurityCritical]
			internal bool AddByte(byte b1, byte b2, byte b3)
			{
				return this.AddByte(b1, b2, b3, 0);
			}

			// Token: 0x0600281E RID: 10270 RVA: 0x00091BF7 File Offset: 0x0008FDF7
			[SecurityCritical]
			internal bool AddByte(byte b1, byte b2, byte b3, int moreBytesExpected)
			{
				return this.AddByte(b1, 2 + moreBytesExpected) && this.AddByte(b2, 1 + moreBytesExpected) && this.AddByte(b3, moreBytesExpected);
			}

			// Token: 0x0600281F RID: 10271 RVA: 0x00091C1E File Offset: 0x0008FE1E
			[SecurityCritical]
			internal bool AddByte(byte b1, byte b2, byte b3, byte b4)
			{
				return this.AddByte(b1, 3) && this.AddByte(b2, 2) && this.AddByte(b3, 1) && this.AddByte(b4, 0);
			}

			// Token: 0x06002820 RID: 10272 RVA: 0x00091C4C File Offset: 0x0008FE4C
			[SecurityCritical]
			internal void MovePrevious(bool bThrow)
			{
				if (this.fallbackBuffer.bFallingBack)
				{
					this.fallbackBuffer.MovePrevious();
				}
				else if (this.chars != this.charStart)
				{
					this.chars--;
				}
				if (bThrow)
				{
					this.enc.ThrowBytesOverflow(this.encoder, this.bytes == this.byteStart);
				}
			}

			// Token: 0x06002821 RID: 10273 RVA: 0x00091CB2 File Offset: 0x0008FEB2
			[SecurityCritical]
			internal bool Fallback(char charFallback)
			{
				return this.fallbackBuffer.InternalFallback(charFallback, ref this.chars);
			}

			// Token: 0x170004E7 RID: 1255
			// (get) Token: 0x06002822 RID: 10274 RVA: 0x00091CC6 File Offset: 0x0008FEC6
			internal bool MoreData
			{
				[SecurityCritical]
				get
				{
					return this.fallbackBuffer.Remaining > 0 || this.chars < this.charEnd;
				}
			}

			// Token: 0x06002823 RID: 10275 RVA: 0x00091CE8 File Offset: 0x0008FEE8
			[SecurityCritical]
			internal unsafe char GetNextChar()
			{
				char c = this.fallbackBuffer.InternalGetNextChar();
				if (c == '\0' && this.chars < this.charEnd)
				{
					char* ptr = this.chars;
					this.chars = ptr + 1;
					c = *ptr;
				}
				return c;
			}

			// Token: 0x170004E8 RID: 1256
			// (get) Token: 0x06002824 RID: 10276 RVA: 0x00091D26 File Offset: 0x0008FF26
			internal int CharsUsed
			{
				[SecurityCritical]
				get
				{
					return (int)((long)(this.chars - this.charStart));
				}
			}

			// Token: 0x170004E9 RID: 1257
			// (get) Token: 0x06002825 RID: 10277 RVA: 0x00091D39 File Offset: 0x0008FF39
			internal int Count
			{
				get
				{
					return this.byteCountResult;
				}
			}

			// Token: 0x04001E61 RID: 7777
			[SecurityCritical]
			private unsafe byte* bytes;

			// Token: 0x04001E62 RID: 7778
			[SecurityCritical]
			private unsafe byte* byteStart;

			// Token: 0x04001E63 RID: 7779
			[SecurityCritical]
			private unsafe byte* byteEnd;

			// Token: 0x04001E64 RID: 7780
			[SecurityCritical]
			private unsafe char* chars;

			// Token: 0x04001E65 RID: 7781
			[SecurityCritical]
			private unsafe char* charStart;

			// Token: 0x04001E66 RID: 7782
			[SecurityCritical]
			private unsafe char* charEnd;

			// Token: 0x04001E67 RID: 7783
			private int byteCountResult;

			// Token: 0x04001E68 RID: 7784
			private Encoding enc;

			// Token: 0x04001E69 RID: 7785
			private EncoderNLS encoder;

			// Token: 0x04001E6A RID: 7786
			internal EncoderFallbackBuffer fallbackBuffer;
		}
	}
}
