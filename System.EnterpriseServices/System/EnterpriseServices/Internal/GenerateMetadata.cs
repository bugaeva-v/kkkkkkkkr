using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Создает метаданные среды CLR для компонента COM+.</summary>
	// Token: 0x0200005D RID: 93
	[Guid("d8013ff1-730b-45e2-ba24-874b7242c425")]
	public class GenerateMetadata : IComSoapMetadata
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.GenerateMetadata" />.</summary>
		// Token: 0x06000164 RID: 356 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public GenerateMetadata()
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает или находит сборку, содержащую метаданные среды CLR для компонента COM+, представленного указанной библиотекой типов.</summary>
		/// <param name="strSrcTypeLib">Имя библиотеки типов, для которой создается сборка.</param>
		/// <param name="outPath">Папка, в которой требуется создать сборку или найти уже существующую сборку.</param>
		/// <returns>Имя созданной сборки или пустая строка, если входные данные недопустимы.</returns>
		// Token: 0x06000165 RID: 357 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string Generate(string strSrcTypeLib, string outPath)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает или находит сборку, содержащую метаданные среды CLR для компонента COM+, представленного указанной библиотекой типов, подписывает сборку парой ключей, образующих строгое имя, и устанавливает ее в глобальный кэш сборок.</summary>
		/// <param name="strSrcTypeLib">Имя библиотеки типов, для которой создается сборка.</param>
		/// <param name="outPath">Папка, в которой требуется создать сборку или найти уже существующую сборку.</param>
		/// <param name="PublicKey">Открытый ключ, используемый для импорта информации о библиотеке типов в сборку.</param>
		/// <param name="KeyPair">Пара ключей со строгим именем, используемая для подписи созданной сборки.</param>
		/// <returns>Имя созданной сборки или пустая строка, если входные данные недопустимы.</returns>
		// Token: 0x06000166 RID: 358 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string GenerateMetaData(string strSrcTypeLib, string outPath, byte[] PublicKey, StrongNameKeyPair KeyPair)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает или находит сборку, содержащую метаданные среды CLR для компонента COM+, представленного указанной библиотекой типов, подписывает сборку парой ключей, образующих строгое имя, и устанавливает ее в глобальный кэш сборок.</summary>
		/// <param name="strSrcTypeLib">Имя библиотеки типов, для которой создается сборка.</param>
		/// <param name="outPath">Папка, в которой требуется создать сборку или найти уже существующую сборку.</param>
		/// <param name="InstallGac">Не обрабатывается.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		/// <returns>Имя созданной сборки или пустая строка, если входные данные недопустимы.</returns>
		// Token: 0x06000167 RID: 359 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string GenerateSigned(string strSrcTypeLib, string outPath, bool InstallGac, out string Error)
		{
			throw new NotImplementedException();
		}

		/// <summary>Выполняет поиск указанного файла по указанному пути.</summary>
		/// <param name="path">Путь, по которому выполняется поиск файла.</param>
		/// <param name="fileName">Имя файла для поиска.</param>
		/// <param name="extension">Расширение, добавляемое к имени файла при его поиске.</param>
		/// <param name="numBufferChars">Размер буфера, принимающего допустимый путь и имя файла.</param>
		/// <param name="buffer">Буфер, в который передается путь и имя найденного файла.</param>
		/// <param name="filePart">Переменная, принимающая адрес последнего компонента допустимого пути и имени файла.</param>
		/// <returns>Если поиск завершается успешно, возвращается длина строки, скопированной в <paramref name="buffer" />. Если поиск заканчивается неудачно, возвращается значение 0.</returns>
		// Token: 0x06000168 RID: 360 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static int SearchPath(string path, string fileName, string extension, int numBufferChars, string buffer, int[] filePart)
		{
			throw new NotImplementedException();
		}
	}
}
