using System;
using System.Collections;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет интерфейс для управления сериализацией во время разработки.</summary>
	// Token: 0x02000488 RID: 1160
	public interface IDesignerSerializationManager : IServiceProvider
	{
		/// <summary>Получает стековую, определяемую пользователем область памяти, которая используется для взаимодействия сериализаторов.</summary>
		/// <returns>Класс <see cref="T:System.ComponentModel.Design.Serialization.ContextStack" />, где хранятся данные.</returns>
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600251E RID: 9502
		ContextStack Context { get; }

		/// <summary>Определяет настраиваемые свойства, которые могут быть сериализованы с помощью доступных сериализаторов.</summary>
		/// <returns>Класс <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащий свойства, подлежащие сериализации.</returns>
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600251F RID: 9503
		PropertyDescriptorCollection Properties { get; }

		/// <summary>Возникает, если не удается найти заданное имя в таблице имен диспетчера сериализации с помощью метода <see cref="M:System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetName(System.Object)" />.</summary>
		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06002520 RID: 9504
		// (remove) Token: 0x06002521 RID: 9505
		event ResolveNameEventHandler ResolveName;

		/// <summary>Возникает при завершении сериализации.</summary>
		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06002522 RID: 9506
		// (remove) Token: 0x06002523 RID: 9507
		event EventHandler SerializationComplete;

		/// <summary>Добавляет диспетчеру сериализации заданный поставщик сериализации.</summary>
		/// <param name="provider">Добавляемый поставщик сериализации.</param>
		// Token: 0x06002524 RID: 9508
		void AddSerializationProvider(IDesignerSerializationProvider provider);

		/// <summary>Создает экземпляр заданного типа и добавляет его в коллекцию именованных экземпляров.</summary>
		/// <param name="type">Создаваемый тип данных.</param>
		/// <param name="arguments">Аргументы, передаваемые конструктору для данного типа.</param>
		/// <param name="name">Имя объекта. Это имя используется для доступа к объекту через класс <see cref="M:System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetInstance(System.String)" />. Если передается значение <see langword="null" />, объект создается, но к нему нельзя получить доступ по имени.</param>
		/// <param name="addToContainer">При значении <see langword="true" /> объект добавляется в контейнер проекта. Для этого объект должен реализовать класс <see cref="T:System.ComponentModel.IComponent" />.</param>
		/// <returns>Только что созданный экземпляр объекта.</returns>
		// Token: 0x06002525 RID: 9509
		object CreateInstance(Type type, ICollection arguments, string name, bool addToContainer);

		/// <summary>Получает экземпляр созданного объекта с указанным именем либо значение <see langword="null" />, если объект не существует.</summary>
		/// <param name="name">Имя получаемого объекта.</param>
		/// <returns>Экземпляр объекта с заданным именем либо значение <see langword="null" />, если не удается найти объект с указанным именем.</returns>
		// Token: 0x06002526 RID: 9510
		object GetInstance(string name);

		/// <summary>Получает имя указанного объекта или значение <see langword="null" />, если у объекта нет имени.</summary>
		/// <param name="value">Объект, для которого получается имя.</param>
		/// <returns>Имя объекта или значение <see langword="null" />, если у объекта нет имени.</returns>
		// Token: 0x06002527 RID: 9511
		string GetName(object value);

		/// <summary>Получает сериализатор запрошенного типа для указанного типа объекта.</summary>
		/// <param name="objectType">Тип объекта, для которого получается сериализатор.</param>
		/// <param name="serializerType">Тип загружаемого сериализатора.</param>
		/// <returns>Экземпляр запрошенного типа или значение <see langword="null" />, если не удается найти соответствующий сериализатор.</returns>
		// Token: 0x06002528 RID: 9512
		object GetSerializer(Type objectType, Type serializerType);

		/// <summary>Возвращает тип указанного имени.</summary>
		/// <param name="typeName">Полное имя загружаемого типа.</param>
		/// <returns>Экземпляр типа или значение <see langword="null" />, если не удается загрузить тип.</returns>
		// Token: 0x06002529 RID: 9513
		Type GetType(string typeName);

		/// <summary>Удаляет пользовательский поставщик сериализации из диспетчера сериализации.</summary>
		/// <param name="provider">Удаляемый поставщик. Этот объект должен добавляться с помощью метода <see cref="M:System.ComponentModel.Design.Serialization.IDesignerSerializationManager.AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider)" />.</param>
		// Token: 0x0600252A RID: 9514
		void RemoveSerializationProvider(IDesignerSerializationProvider provider);

		/// <summary>Сообщает об ошибке в сериализации.</summary>
		/// <param name="errorInformation">Ошибка для отчета. Этот объект данных может принадлежать к любому типу объектов. Если это исключение, пользователь получает сообщение об исключении. Если объект другого типа, то для представления сведений пользователю вызывается метод <see cref="M:System.Object.ToString" />.</param>
		// Token: 0x0600252B RID: 9515
		void ReportError(object errorInformation);

		/// <summary>Задает имя заданного существующего объекта.</summary>
		/// <param name="instance">Экземпляр объекта, которому необходимо задать имя.</param>
		/// <param name="name">Имя экземпляра.</param>
		// Token: 0x0600252C RID: 9516
		void SetName(object instance, string name);
	}
}
