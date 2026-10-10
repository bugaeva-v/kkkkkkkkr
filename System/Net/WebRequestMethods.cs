using System;

namespace System.Net
{
	/// <summary>Класс контейнеров для классов <see cref="T:System.Net.WebRequestMethods.Ftp" />, <see cref="T:System.Net.WebRequestMethods.File" /> и <see cref="T:System.Net.WebRequestMethods.Http" />. Этот класс не наследуется.</summary>
	// Token: 0x02000618 RID: 1560
	public static class WebRequestMethods
	{
		/// <summary>Представляет типы методов протокола FTP, которые могут использоваться вместе с FTP-запросом. Этот класс не наследуется.</summary>
		// Token: 0x02000619 RID: 1561
		public static class Ftp
		{
			/// <summary>Представляет метод протокола FTP RETR, используемый для загрузки файла с FTP-сервера.</summary>
			// Token: 0x04001CB2 RID: 7346
			public const string DownloadFile = "RETR";

			/// <summary>Представляет метод протокола FTP NLIST, который выдает краткий список файлов на FTP-сервере.</summary>
			// Token: 0x04001CB3 RID: 7347
			public const string ListDirectory = "NLST";

			/// <summary>Представляет метод протокола FTP STOR, используемый для передачи файла на FTP-сервер.</summary>
			// Token: 0x04001CB4 RID: 7348
			public const string UploadFile = "STOR";

			/// <summary>Представляет метод протокола FTP DELE, используемый для удаления файла с FTP-сервера.</summary>
			// Token: 0x04001CB5 RID: 7349
			public const string DeleteFile = "DELE";

			/// <summary>Представляет метод протокола FTP APPE, используемый для добавления файла к существующему файлу на FTP-сервере.</summary>
			// Token: 0x04001CB6 RID: 7350
			public const string AppendFile = "APPE";

			/// <summary>Представляет метод протокола FTP SIZE, используемый для определения размера файла на FTP-сервере.</summary>
			// Token: 0x04001CB7 RID: 7351
			public const string GetFileSize = "SIZE";

			/// <summary>Представляет метод протокола FTP STOU, который выгружает файл с уникальным именем на FTP-сервер.</summary>
			// Token: 0x04001CB8 RID: 7352
			public const string UploadFileWithUniqueName = "STOU";

			/// <summary>Представляет метод протокола FTP MKD, используемый для создания каталога на FTP-сервере.</summary>
			// Token: 0x04001CB9 RID: 7353
			public const string MakeDirectory = "MKD";

			/// <summary>Представляет метод протокола FTP RMD, который производит удаление каталога.</summary>
			// Token: 0x04001CBA RID: 7354
			public const string RemoveDirectory = "RMD";

			/// <summary>Представляет метод протокола FTP LIST, который выдает подробный список файлов на FTP-сервере.</summary>
			// Token: 0x04001CBB RID: 7355
			public const string ListDirectoryDetails = "LIST";

			/// <summary>Представляет метод протокола FTP MDTM, который используется для извлечения отметки даты и времени из файла на FTP-сервере.</summary>
			// Token: 0x04001CBC RID: 7356
			public const string GetDateTimestamp = "MDTM";

			/// <summary>Представляет метод протокола FTP PWD, который выводит название текущего рабочего каталога.</summary>
			// Token: 0x04001CBD RID: 7357
			public const string PrintWorkingDirectory = "PWD";

			/// <summary>Представляет метод протокола FTP RENAME, который переименовывает каталог.</summary>
			// Token: 0x04001CBE RID: 7358
			public const string Rename = "RENAME";
		}

		/// <summary>Представляет типы методов протокола HTTP, которые могут использоваться вместе с HTTP-запросом.</summary>
		// Token: 0x0200061A RID: 1562
		public static class Http
		{
			/// <summary>Представляет метод протокола HTTP GET.</summary>
			// Token: 0x04001CBF RID: 7359
			public const string Get = "GET";

			/// <summary>Представляет метод протокола HTTP CONNECT, который используется с прокси-сервера, который может динамически переключаться на туннелирование, как в случае туннелирование SSL.</summary>
			// Token: 0x04001CC0 RID: 7360
			public const string Connect = "CONNECT";

			/// <summary>Представляет метод протокола HTTP HEAD. Метод HEAD идентичен методу GET за исключением того, что сервер возвращает в ответе только заголовки сообщений без основного текста сообщений.</summary>
			// Token: 0x04001CC1 RID: 7361
			public const string Head = "HEAD";

			/// <summary>Представляет метод протокола HTTP PUT, который используется для замены сущности, указанной с помощью URI.</summary>
			// Token: 0x04001CC2 RID: 7362
			public const string Put = "PUT";

			/// <summary>Представляет метод протокола HTTP POST, который используется для публикации новой сущности в качестве дополнения к URI.</summary>
			// Token: 0x04001CC3 RID: 7363
			public const string Post = "POST";

			/// <summary>Представляет запрос HTTP MKCOL, который создает новую коллекцию (например, коллекцию страниц) в местоположении, указанном в URI запроса.</summary>
			// Token: 0x04001CC4 RID: 7364
			public const string MkCol = "MKCOL";
		}

		/// <summary>Представляет тип методов файловых протоколов, который может использоваться вместе с запросом FILE. Этот класс не наследуется.</summary>
		// Token: 0x0200061B RID: 1563
		public static class File
		{
			/// <summary>Представляет метод протокола FILE GET, который используется для получения файла из указанного расположения.</summary>
			// Token: 0x04001CC5 RID: 7365
			public const string DownloadFile = "GET";

			/// <summary>Представляет метод протокола FILE PUT, который используется для копирование файла в указанное расположение.</summary>
			// Token: 0x04001CC6 RID: 7366
			public const string UploadFile = "PUT";
		}
	}
}
