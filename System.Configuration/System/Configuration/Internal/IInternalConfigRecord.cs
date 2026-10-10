using System;
using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейсы, используемые внутренними структурами .NET, для поддержки создания новых записей конфигурации.</summary>
	// Token: 0x02000082 RID: 130
	[ComVisible(false)]
	public interface IInternalConfigRecord
	{
		/// <summary>Возвращает объект, представляющий раздел конфигурации из последнего удачного состояния (LKG) конфигурации.</summary>
		/// <param name="configKey">Строка, представляющая ключ для раздела конфигурации.</param>
		/// <returns>Экземпляр <see cref="T:System.Object" />, представляющий раздел последнего удачного состояния, определенный параметром <paramref name="configKey" />.</returns>
		// Token: 0x06000469 RID: 1129
		object GetLkgSection(string configKey);

		/// <summary>Возвращает экземпляр <see cref="T:System.Object" />, представляющий раздел файла конфигурации.</summary>
		/// <param name="configKey">Строка, представляющая ключ для раздела конфигурации.</param>
		/// <returns>Экземпляр <see cref="T:System.Object" />, представляющий раздел файла конфигурации.</returns>
		// Token: 0x0600046A RID: 1130
		object GetSection(string configKey);

		/// <summary>Вызывает повторную инициализацию указанного раздела объекта конфигурации.</summary>
		/// <param name="configKey">Строка, представляющая ключ для раздела конфигурации, который должен быть обновлен.</param>
		// Token: 0x0600046B RID: 1131
		void RefreshSection(string configKey);

		/// <summary>Удаляет запись конфигурации.</summary>
		// Token: 0x0600046C RID: 1132
		void Remove();

		/// <summary>Предоставляет разрешение объекту конфигурации создавать исключение, если ошибка происходит во время инициализации.</summary>
		// Token: 0x0600046D RID: 1133
		void ThrowIfInitErrors();

		/// <summary>Возвращает строку, представляющую путь файла конфигурации.</summary>
		/// <returns>Строка, представляющая путь файла конфигурации.</returns>
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600046E RID: 1134
		string ConfigPath { get; }

		/// <summary>Возвращает значение, определяющее, будет ли возникать ошибка во время инициализации объекта конфигурации.</summary>
		/// <returns>
		///   <see langword="true" /> если возникает ошибка во время инициализации объекта конфигурации; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600046F RID: 1135
		bool HasInitErrors { get; }

		/// <summary>Возвращает имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</summary>
		/// <returns>Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</returns>
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000470 RID: 1136
		string StreamName { get; }
	}
}
