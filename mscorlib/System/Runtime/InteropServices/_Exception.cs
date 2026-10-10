using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым членам класса <see cref="T:System.Exception" />.</summary>
	// Token: 0x0200076D RID: 1901
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[Guid("b36b5c63-42ef-38bc-a07e-0b34c98f164a")]
	[ComVisible(true)]
	[CLSCompliant(false)]
	public interface _Exception
	{
		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Exception.HelpLink" />.</summary>
		/// <returns>Унифицированное имя ресурса (URN) или URL-адрес файла справки.</returns>
		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x0600432E RID: 17198
		// (set) Token: 0x0600432F RID: 17199
		string HelpLink { get; set; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Exception.InnerException" />.</summary>
		/// <returns>Экземпляр <see cref="T:System.Exception" />, описывающий ошибку, вызывающую текущее исключение. Свойство <see cref="P:System.Exception.InnerException" /> возвращает то же значение, что было передано конструктору, или пустую ссылку (<see langword="Nothing" /> в Visual Basic), если значение внутреннего исключения не было передано конструктору. Это свойство доступно только для чтения.</returns>
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06004330 RID: 17200
		Exception InnerException { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Exception.Message" />.</summary>
		/// <returns>Сообщение об ошибке с объяснением причин исключения или пустая строка ("").</returns>
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06004331 RID: 17201
		string Message { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Exception.Source" />.</summary>
		/// <returns>Имя приложения или объекта, вызвавшего ошибку.</returns>
		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06004332 RID: 17202
		// (set) Token: 0x06004333 RID: 17203
		string Source { get; set; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Exception.StackTrace" />.</summary>
		/// <returns>Строка, описывающая содержимое стека вызова, в которой первым отображается самый последний вызов метода.</returns>
		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06004334 RID: 17204
		string StackTrace { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Exception.TargetSite" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" />, вызвавший текущее исключение.</returns>
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06004335 RID: 17205
		MethodBase TargetSite { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, с которым сравнивается текущий объект <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004336 RID: 17206
		bool Equals(object obj);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Exception.GetBaseException" />.</summary>
		/// <returns>В цепочке исключений создается первое исключение. Если значением свойства <see cref="P:System.Exception.InnerException" /> текущего исключения является пустая ссылка (<see langword="Nothing" /> в Visual Basic), это свойство возвращает текущее исключение.</returns>
		// Token: 0x06004337 RID: 17207
		Exception GetBaseException();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x06004338 RID: 17208
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Exception.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта по возникающему исключению.</param>
		/// <param name="context">Структура <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащая контекстные сведения об источнике или назначении.</param>
		// Token: 0x06004339 RID: 17209
		void GetObjectData(SerializationInfo info, StreamingContext context);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Exception.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий точный тип среды выполнения текущего экземпляра.</returns>
		// Token: 0x0600433A RID: 17210
		Type GetType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Exception.ToString" />.</summary>
		/// <returns>Строка, представляющая текущий объект <see cref="T:System.Exception" />.</returns>
		// Token: 0x0600433B RID: 17211
		string ToString();
	}
}
