using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет максимальную длину заголовков ответов. Этот класс не наследуется.</summary>
	// Token: 0x0200076A RID: 1898
	public sealed class HttpWebRequestElement : ConfigurationElement
	{
		// Token: 0x06003BDA RID: 15322 RVA: 0x000CD19C File Offset: 0x000CB39C
		static HttpWebRequestElement()
		{
			HttpWebRequestElement.properties.Add(HttpWebRequestElement.maximumErrorResponseLengthProp);
			HttpWebRequestElement.properties.Add(HttpWebRequestElement.maximumResponseHeadersLengthProp);
			HttpWebRequestElement.properties.Add(HttpWebRequestElement.maximumUnauthorizedUploadLengthProp);
			HttpWebRequestElement.properties.Add(HttpWebRequestElement.useUnsafeHeaderParsingProp);
		}

		/// <summary>Получает или задает максимальную допустимую длину ответа с сообщением об ошибке.</summary>
		/// <returns>Целое 32-разрядное число со знаком, содержащее максимальную длину ответов с сообщениями об ошибке в килобайтах (1024 байт). Значение по умолчанию — 64.</returns>
		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06003BDC RID: 15324 RVA: 0x000CD26D File Offset: 0x000CB46D
		// (set) Token: 0x06003BDD RID: 15325 RVA: 0x000CD27F File Offset: 0x000CB47F
		[ConfigurationProperty("maximumErrorResponseLength", DefaultValue = "64")]
		public int MaximumErrorResponseLength
		{
			get
			{
				return (int)base[HttpWebRequestElement.maximumErrorResponseLengthProp];
			}
			set
			{
				base[HttpWebRequestElement.maximumErrorResponseLengthProp] = value;
			}
		}

		/// <summary>Получает или задает максимальную допустимую длину заголовков ответов.</summary>
		/// <returns>Целое 32-разрядное число со знаком, содержащее максимальную длину заголовков ответов в килобайтах (1024 байта). Значение по умолчанию — 64.</returns>
		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06003BDE RID: 15326 RVA: 0x000CD292 File Offset: 0x000CB492
		// (set) Token: 0x06003BDF RID: 15327 RVA: 0x000CD2A4 File Offset: 0x000CB4A4
		[ConfigurationProperty("maximumResponseHeadersLength", DefaultValue = "64")]
		public int MaximumResponseHeadersLength
		{
			get
			{
				return (int)base[HttpWebRequestElement.maximumResponseHeadersLengthProp];
			}
			set
			{
				base[HttpWebRequestElement.maximumResponseHeadersLengthProp] = value;
			}
		}

		/// <summary>Получает или задает максимальный объем данных, передаваемых в ответ на код ошибки доступа.</summary>
		/// <returns>Целое 32-разрядное число со знаком указывает максимальный объем данных, передаваемых в ответ на код ошибки доступа (в нескольких единицах из 1 024 байт). Значение -1 указывает на отсутствие ограничений. Задание для свойства <see cref="P:System.Net.Configuration.HttpWebRequestElement.MaximumUnauthorizedUploadLength" />  любого другого значения позволит отправить тело запроса только в том случае, если оно меньше заданного количества байтов. Таким образом, значение 1 означает, что тело запроса отправляется только в том случае, если оно меньше 1024 байтов.  
		/// Значение этого свойства по умолчанию равно -1.</returns>
		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x000CD2B7 File Offset: 0x000CB4B7
		// (set) Token: 0x06003BE1 RID: 15329 RVA: 0x000CD2C9 File Offset: 0x000CB4C9
		[ConfigurationProperty("maximumUnauthorizedUploadLength", DefaultValue = "-1")]
		public int MaximumUnauthorizedUploadLength
		{
			get
			{
				return (int)base[HttpWebRequestElement.maximumUnauthorizedUploadLengthProp];
			}
			set
			{
				base[HttpWebRequestElement.maximumUnauthorizedUploadLengthProp] = value;
			}
		}

		/// <summary>Если это свойство задано, ошибки проверки при анализе HTTP, игнорируются.</summary>
		/// <returns>Логическое значение, показывающее, задано ли это свойство.</returns>
		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x000CD2DC File Offset: 0x000CB4DC
		// (set) Token: 0x06003BE3 RID: 15331 RVA: 0x000CD2EE File Offset: 0x000CB4EE
		[ConfigurationProperty("useUnsafeHeaderParsing", DefaultValue = "False")]
		public bool UseUnsafeHeaderParsing
		{
			get
			{
				return (bool)base[HttpWebRequestElement.useUnsafeHeaderParsingProp];
			}
			set
			{
				base[HttpWebRequestElement.useUnsafeHeaderParsingProp] = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x000CD301 File Offset: 0x000CB501
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return HttpWebRequestElement.properties;
			}
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x00066D7A File Offset: 0x00064F7A
		[MonoTODO]
		protected override void PostDeserialize()
		{
			base.PostDeserialize();
		}

		// Token: 0x04002394 RID: 9108
		private static ConfigurationProperty maximumErrorResponseLengthProp = new ConfigurationProperty("maximumErrorResponseLength", typeof(int), 64);

		// Token: 0x04002395 RID: 9109
		private static ConfigurationProperty maximumResponseHeadersLengthProp = new ConfigurationProperty("maximumResponseHeadersLength", typeof(int), 64);

		// Token: 0x04002396 RID: 9110
		private static ConfigurationProperty maximumUnauthorizedUploadLengthProp = new ConfigurationProperty("maximumUnauthorizedUploadLength", typeof(int), -1);

		// Token: 0x04002397 RID: 9111
		private static ConfigurationProperty useUnsafeHeaderParsingProp = new ConfigurationProperty("useUnsafeHeaderParsing", typeof(bool), false);

		// Token: 0x04002398 RID: 9112
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
