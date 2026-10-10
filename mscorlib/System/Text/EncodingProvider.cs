using System;

namespace System.Text
{
	/// <summary>Предоставляет базовый класс для поставщика кодировки, обеспечивающего кодировки, недоступные в определенной платформе.</summary>
	// Token: 0x020003A8 RID: 936
	public abstract class EncodingProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.EncodingProvider" />.</summary>
		// Token: 0x0600265E RID: 9822 RVA: 0x0000259F File Offset: 0x0000079F
		public EncodingProvider()
		{
		}

		/// <summary>Возвращает кодировку с указанным именем.</summary>
		/// <param name="name">Имя запрошенной кодировки.</param>
		/// <returns>Кодировка, связанная с указанным именем, или <see langword="null" />, если этот поставщик <see cref="T:System.Text.EncodingProvider" /> не может вернуть допустимую кодировку, соответствующую <paramref name="name" />.</returns>
		// Token: 0x0600265F RID: 9823
		public abstract Encoding GetEncoding(string name);

		/// <summary>Возвращает кодировку, связанную с указанным идентификатором кодовой страницы.</summary>
		/// <param name="codepage">Идентификатор кодовой страницы запрошенной кодировки.</param>
		/// <returns>Кодировка, связанная с указанной кодовой страницей, или <see langword="null" />, если этот поставщик <see cref="T:System.Text.EncodingProvider" /> не может вернуть допустимую кодировку, соответствующую <paramref name="codepage" />.</returns>
		// Token: 0x06002660 RID: 9824
		public abstract Encoding GetEncoding(int codepage);

		/// <summary>Возвращает кодировку, связанную с заданным именем. С помощью параметров задается обработчик ошибок для символов, которые не удается закодировать, и последовательностей байтов, которые не удается декодировать.</summary>
		/// <param name="name">Имя предпочтительной кодировки.</param>
		/// <param name="encoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда символ не может быть закодирован с использованием этой кодировки.</param>
		/// <param name="decoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда последовательность байтов не может быть декодирована с использованием текущей кодировки.</param>
		/// <returns>Кодировка, связанная с указанным именем, или <see langword="null" />, если этот поставщик <see cref="T:System.Text.EncodingProvider" /> не может вернуть допустимую кодировку, соответствующую <paramref name="name" />.</returns>
		// Token: 0x06002661 RID: 9825 RVA: 0x000880B4 File Offset: 0x000862B4
		public virtual Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			Encoding encoding = this.GetEncoding(name);
			if (encoding != null)
			{
				encoding = (Encoding)this.GetEncoding(name).Clone();
				encoding.EncoderFallback = encoderFallback;
				encoding.DecoderFallback = decoderFallback;
			}
			return encoding;
		}

		/// <summary>Возвращает кодировку, связанную с указанным идентификатором кодовой страницы. С помощью параметров задается обработчик ошибок для символов, которые не удается закодировать, и последовательностей байтов, которые не удается декодировать.</summary>
		/// <param name="codepage">Идентификатор кодовой страницы запрошенной кодировки.</param>
		/// <param name="encoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда символ не может быть закодирован с использованием этой кодировки.</param>
		/// <param name="decoderFallback">Объект, предоставляющий процедуру обработки ошибок, когда последовательность байтов не может быть декодирована с использованием этой кодировки.</param>
		/// <returns>Кодировка, связанная с указанной кодовой страницей, или <see langword="null" />, если этот поставщик <see cref="T:System.Text.EncodingProvider" /> не может вернуть допустимую кодировку, соответствующую <paramref name="codepage" />.</returns>
		// Token: 0x06002662 RID: 9826 RVA: 0x000880F0 File Offset: 0x000862F0
		public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			Encoding encoding = this.GetEncoding(codepage);
			if (encoding != null)
			{
				encoding = (Encoding)this.GetEncoding(codepage).Clone();
				encoding.EncoderFallback = encoderFallback;
				encoding.DecoderFallback = decoderFallback;
			}
			return encoding;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x0008812C File Offset: 0x0008632C
		internal static void AddProvider(EncodingProvider provider)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("provider");
			}
			object obj = EncodingProvider.s_InternalSyncObject;
			lock (obj)
			{
				if (EncodingProvider.s_providers == null)
				{
					EncodingProvider.s_providers = new EncodingProvider[]
					{
						provider
					};
				}
				else if (Array.IndexOf<EncodingProvider>(EncodingProvider.s_providers, provider) < 0)
				{
					EncodingProvider[] array = new EncodingProvider[EncodingProvider.s_providers.Length + 1];
					Array.Copy(EncodingProvider.s_providers, array, EncodingProvider.s_providers.Length);
					array[array.Length - 1] = provider;
					EncodingProvider.s_providers = array;
				}
			}
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000881D8 File Offset: 0x000863D8
		internal static Encoding GetEncodingFromProvider(int codepage)
		{
			if (EncodingProvider.s_providers == null)
			{
				return null;
			}
			EncodingProvider[] array = EncodingProvider.s_providers;
			for (int i = 0; i < array.Length; i++)
			{
				Encoding encoding = array[i].GetEncoding(codepage);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00088218 File Offset: 0x00086418
		internal static Encoding GetEncodingFromProvider(string encodingName)
		{
			if (EncodingProvider.s_providers == null)
			{
				return null;
			}
			EncodingProvider[] array = EncodingProvider.s_providers;
			for (int i = 0; i < array.Length; i++)
			{
				Encoding encoding = array[i].GetEncoding(encodingName);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00088258 File Offset: 0x00086458
		internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			if (EncodingProvider.s_providers == null)
			{
				return null;
			}
			EncodingProvider[] array = EncodingProvider.s_providers;
			for (int i = 0; i < array.Length; i++)
			{
				Encoding encoding = array[i].GetEncoding(codepage, enc, dec);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00088298 File Offset: 0x00086498
		internal static Encoding GetEncodingFromProvider(string encodingName, EncoderFallback enc, DecoderFallback dec)
		{
			if (EncodingProvider.s_providers == null)
			{
				return null;
			}
			EncodingProvider[] array = EncodingProvider.s_providers;
			for (int i = 0; i < array.Length; i++)
			{
				Encoding encoding = array[i].GetEncoding(encodingName, enc, dec);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x04001DC7 RID: 7623
		private static object s_InternalSyncObject = new object();

		// Token: 0x04001DC8 RID: 7624
		private static volatile EncodingProvider[] s_providers;
	}
}
