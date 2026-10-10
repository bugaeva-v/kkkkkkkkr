using System;

namespace System.Net.Mime
{
	/// <summary>Указывает сведения о типе мультимедиа для вложения сообщения электронной почты.</summary>
	// Token: 0x02000800 RID: 2048
	public static class MediaTypeNames
	{
		/// <summary>Указывает тип текстовых данных во вложении сообщения электронной почты.</summary>
		// Token: 0x02000801 RID: 2049
		public static class Text
		{
			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Text" /> являются обычным текстом.</summary>
			// Token: 0x0400279D RID: 10141
			public const string Plain = "text/plain";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Text" /> имеют формат HTML.</summary>
			// Token: 0x0400279E RID: 10142
			public const string Html = "text/html";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Text" /> имеют формат XML.</summary>
			// Token: 0x0400279F RID: 10143
			public const string Xml = "text/xml";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Text" /> имеют формат RTF.</summary>
			// Token: 0x040027A0 RID: 10144
			public const string RichText = "text/richtext";
		}

		/// <summary>Указывает тип данных приложения во вложении сообщения электронной почты.</summary>
		// Token: 0x02000802 RID: 2050
		public static class Application
		{
			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Application" /> представляют собой документ SOAP.</summary>
			// Token: 0x040027A1 RID: 10145
			public const string Soap = "application/soap+xml";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Application" /> не интерпретируются.</summary>
			// Token: 0x040027A2 RID: 10146
			public const string Octet = "application/octet-stream";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Application" /> имеют формат RTF.</summary>
			// Token: 0x040027A3 RID: 10147
			public const string Rtf = "application/rtf";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Application" /> имеют формат PDF.</summary>
			// Token: 0x040027A4 RID: 10148
			public const string Pdf = "application/pdf";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Application" /> сжаты.</summary>
			// Token: 0x040027A5 RID: 10149
			public const string Zip = "application/zip";

			// Token: 0x040027A6 RID: 10150
			public const string Json = "application/json";

			// Token: 0x040027A7 RID: 10151
			public const string Xml = "application/xml";
		}

		/// <summary>Указывает тип графических данных во вложении сообщения электронной почты.</summary>
		// Token: 0x02000803 RID: 2051
		public static class Image
		{
			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Image" /> имеют формат GIF.</summary>
			// Token: 0x040027A8 RID: 10152
			public const string Gif = "image/gif";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Image" /> имеют формат TIFF.</summary>
			// Token: 0x040027A9 RID: 10153
			public const string Tiff = "image/tiff";

			/// <summary>Указывает, что данные <see cref="T:System.Net.Mime.MediaTypeNames.Image" /> имеют формат JPEG.</summary>
			// Token: 0x040027AA RID: 10154
			public const string Jpeg = "image/jpeg";
		}
	}
}
