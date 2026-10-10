using System;
using System.Reflection;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс для извлечения сборки или типа по имени.</summary>
	// Token: 0x0200046E RID: 1134
	public interface ITypeResolutionService
	{
		/// <summary>Получает запрошенную сборку.</summary>
		/// <param name="name">Имя извлекаемой сборки.</param>
		/// <returns>Экземпляр запрошенной сборки, либо значение <see langword="null" />, если сборку найти невозможно.</returns>
		// Token: 0x06002480 RID: 9344
		Assembly GetAssembly(AssemblyName name);

		/// <summary>Получает запрошенную сборку.</summary>
		/// <param name="name">Имя извлекаемой сборки.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, если этот метод должен создать исключение в случае, если сборка не может быть найдена; в противном случае — <see langword="false" />. Метод возвращает значение <see langword="null" />, если сборку найти невозможно.</param>
		/// <returns>Экземпляр запрошенной сборки, либо значение <see langword="null" />, если сборку найти невозможно.</returns>
		// Token: 0x06002481 RID: 9345
		Assembly GetAssembly(AssemblyName name, bool throwOnError);

		/// <summary>Загружает тип с указанным именем.</summary>
		/// <param name="name">Имя типа. Если имя типа не является полным именем, определяющим сборку, служба будет выполнять поиск внутреннего набора сборок, на которые существуют ссылки.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Type" />, соответствующий указанному имени, или значение <see langword="null" />, если тип найти невозможно.</returns>
		// Token: 0x06002482 RID: 9346
		Type GetType(string name);

		/// <summary>Загружает тип с указанным именем.</summary>
		/// <param name="name">Имя типа. Если имя типа не является полным именем, определяющим сборку, служба будет выполнять поиск внутреннего набора сборок, на которые существуют ссылки.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, если этот метод должен создать исключение в случае, если сборка не может быть найдена; в противном случае — <see langword="false" />. Метод возвращает значение <see langword="null" />, если сборку найти невозможно.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Type" />, соответствующий указанному имени, или значение <see langword="null" />, если тип найти невозможно.</returns>
		// Token: 0x06002483 RID: 9347
		Type GetType(string name, bool throwOnError);

		/// <summary>Загружает тип с указанным именем.</summary>
		/// <param name="name">Имя типа. Если имя типа не является полным именем, определяющим сборку, служба будет выполнять поиск внутреннего набора сборок, на которые существуют ссылки.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, если этот метод должен создать исключение в случае, если сборка не может быть найдена; в противном случае — <see langword="false" />. Метод возвращает значение <see langword="null" />, если сборку найти невозможно.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при поиске типов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Type" />, соответствующий указанному имени, или значение <see langword="null" />, если тип найти невозможно.</returns>
		// Token: 0x06002484 RID: 9348
		Type GetType(string name, bool throwOnError, bool ignoreCase);

		/// <summary>Добавляет ссылку на указанную сборку.</summary>
		/// <param name="name">Класс <see cref="T:System.Reflection.AssemblyName" />, определяющий сборку, на которую нужно установить ссылку.</param>
		// Token: 0x06002485 RID: 9349
		void ReferenceAssembly(AssemblyName name);

		/// <summary>Возвращает путь к файлу, из которого загружена сборка.</summary>
		/// <param name="name">Имя сборки.</param>
		/// <returns>Путь к файлу, из которого загружена сборка.</returns>
		// Token: 0x06002486 RID: 9350
		string GetPathOfAssembly(AssemblyName name);
	}
}
