using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет тип мультимедиа типа с дополнительными коэффициентом качества, используемый в заголовке типа содержимого.</summary>
	// Token: 0x02000051 RID: 81
	public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />.</summary>
		/// <param name="mediaType">Объект <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />, представленный в виде строки для инициализации нового экземпляра.</param>
		// Token: 0x0600031A RID: 794 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public MediaTypeWithQualityHeaderValue(string mediaType) : base(mediaType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />.</summary>
		/// <param name="mediaType">Объект <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />, представленный в виде строки для инициализации нового экземпляра.</param>
		/// <param name="quality">Качество, связанные с этим значением заголовка.</param>
		// Token: 0x0600031B RID: 795 RVA: 0x0000B1A9 File Offset: 0x000093A9
		public MediaTypeWithQualityHeaderValue(string mediaType, double quality) : this(mediaType)
		{
			this.Quality = new double?(quality);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000B1BE File Offset: 0x000093BE
		private MediaTypeWithQualityHeaderValue()
		{
		}

		/// <summary>Получает или задает значение качества для <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />.</summary>
		/// <returns>Значение качества для объекта <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />.</returns>
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000B1C6 File Offset: 0x000093C6
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0000B1D3 File Offset: 0x000093D3
		public double? Quality
		{
			get
			{
				return QualityValue.GetValue(this.parameters);
			}
			set
			{
				QualityValue.SetValue(ref this.parameters, value);
			}
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая тип носителя со сведениями о значении качества заголовка.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> является недопустимым типом носителя со сведениями о значении качества заголовка.</exception>
		// Token: 0x0600031F RID: 799 RVA: 0x0000B1E4 File Offset: 0x000093E4
		public new static MediaTypeWithQualityHeaderValue Parse(string input)
		{
			MediaTypeWithQualityHeaderValue result;
			if (MediaTypeWithQualityHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException();
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000320 RID: 800 RVA: 0x0000B204 File Offset: 0x00009404
		public static bool TryParse(string input, out MediaTypeWithQualityHeaderValue parsedValue)
		{
			Token token;
			if (MediaTypeWithQualityHeaderValue.TryParseElement(new Lexer(input), out parsedValue, out token) && token == Token.Type.End)
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000B230 File Offset: 0x00009430
		private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			List<NameValueHeaderValue> parameters = null;
			string media_type;
			Token? token = MediaTypeHeaderValue.TryParseMediaType(lexer, out media_type);
			if (token == null)
			{
				t = Token.Empty;
				return false;
			}
			t = token.Value;
			if (t == Token.Type.SeparatorSemicolon && !NameValueHeaderValue.TryParseParameters(lexer, out parameters, out t))
			{
				return false;
			}
			parsedValue = new MediaTypeWithQualityHeaderValue();
			parsedValue.media_type = media_type;
			parsedValue.parameters = parameters;
			return true;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000B2A1 File Offset: 0x000094A1
		internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result)
		{
			return CollectionParser.TryParse<MediaTypeWithQualityHeaderValue>(input, minimalCount, new ElementTryParser<MediaTypeWithQualityHeaderValue>(MediaTypeWithQualityHeaderValue.TryParseElement), out result);
		}
	}
}
