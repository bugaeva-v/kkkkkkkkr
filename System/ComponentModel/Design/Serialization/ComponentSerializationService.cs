using System;
using System.Collections;
using System.IO;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет базовый класс для сериализации набора компонентов или сериализуемых объектов в хранилище сериализации.</summary>
	// Token: 0x02000480 RID: 1152
	public abstract class ComponentSerializationService
	{
		/// <summary>Создает новый экземпляр <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />.</summary>
		/// <returns>Новое хранилище сериализованных объектов.</returns>
		// Token: 0x060024F4 RID: 9460
		public abstract SerializationStore CreateStore();

		/// <summary>Загружает хранилище <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" /> из потока.</summary>
		/// <param name="stream">Поток <see cref="T:System.IO.Stream" />, из которого загружается хранилище.</param>
		/// <returns>Новый экземпляр <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="stream" /> не содержит данных, сохраненных при предыдущем вызове в метод <see cref="M:System.ComponentModel.Design.Serialization.SerializationStore.Save(System.IO.Stream)" />.</exception>
		// Token: 0x060024F5 RID: 9461
		public abstract SerializationStore LoadStore(Stream stream);

		/// <summary>Выполняет сериализацию заданного объекта в заданное хранилище <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />.</summary>
		/// <param name="store">Класс <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, в который будет записано состояние параметра <paramref name="value" />.</param>
		/// <param name="value">Объект для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="store" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хранилище <paramref name="store" /> закрыто, или <paramref name="store" /> не является поддерживаемым типом хранилища сериализации. Используйте хранилище, возвращаемое методом <see cref="M:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService.CreateStore" />.</exception>
		// Token: 0x060024F6 RID: 9462
		public abstract void Serialize(SerializationStore store, object value);

		/// <summary>Выполняет сериализацию заданного объекта, учитывая значения свойств по умолчанию.</summary>
		/// <param name="store">Класс <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, в который будет выполнена сериализация состояния параметра <paramref name="value" />.</param>
		/// <param name="value">Объект для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="store" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хранилище <paramref name="store" /> закрыто, или <paramref name="store" /> не является поддерживаемым типом хранилища сериализации. Используйте хранилище, возвращаемое методом <see cref="M:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService.CreateStore" />.</exception>
		// Token: 0x060024F7 RID: 9463
		public abstract void SerializeAbsolute(SerializationStore store, object value);

		/// <summary>Сериализует заданный элемент в заданном объекте.</summary>
		/// <param name="store">Класс <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, в который будет выполнена сериализация состояния параметра <paramref name="member" />.</param>
		/// <param name="owningObject">Объект, к которому привязывается параметр <paramref name="member" />.</param>
		/// <param name="member">Объект <see cref="T:System.ComponentModel.MemberDescriptor" />, указывающий член для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="store" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хранилище <paramref name="store" /> закрыто, или <paramref name="store" /> не является поддерживаемым типом хранилища сериализации. Используйте хранилище, возвращаемое методом <see cref="M:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService.CreateStore" />.</exception>
		// Token: 0x060024F8 RID: 9464
		public abstract void SerializeMember(SerializationStore store, object owningObject, MemberDescriptor member);

		/// <summary>Выполняет сериализацию заданного элемента в заданный объект, учитывая значение свойства по умолчанию.</summary>
		/// <param name="store">Класс <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, в который будет выполнена сериализация состояния параметра <paramref name="member" />.</param>
		/// <param name="owningObject">Объект, к которому привязывается параметр <paramref name="member" />.</param>
		/// <param name="member">Элемент для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="store" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хранилище <paramref name="store" /> закрыто, или <paramref name="store" /> не является поддерживаемым типом хранилища сериализации. Используйте хранилище, возвращаемое методом <see cref="M:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService.CreateStore" />.</exception>
		// Token: 0x060024F9 RID: 9465
		public abstract void SerializeMemberAbsolute(SerializationStore store, object owningObject, MemberDescriptor member);

		/// <summary>Выполняет десериализацию заданного хранилища для создания коллекции объектов.</summary>
		/// <param name="store">Объект <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, предназначенный для выполнения десериализации.</param>
		/// <returns>Коллекция объектов, созданная в соответствии с состоянием хранения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="store" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="store" /> не содержит данных в формате обработки контейнера сериализации.</exception>
		// Token: 0x060024FA RID: 9466
		public abstract ICollection Deserialize(SerializationStore store);

		/// <summary>Выполняет десериализацию заданного хранилища и заполняет заданное хранилище <see cref="T:System.ComponentModel.IContainer" /> десериализованными объектами <see cref="T:System.ComponentModel.IComponent" />.</summary>
		/// <param name="store">Объект <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, предназначенный для выполнения десериализации.</param>
		/// <param name="container">Класс <see cref="T:System.ComponentModel.IContainer" />, в который будут добавляться объекты <see cref="T:System.ComponentModel.IComponent" />.</param>
		/// <returns>Коллекция объектов, созданная в соответствии с состоянием хранения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="store" /> или <paramref name="container" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="store" /> не содержит данных в формате обработки контейнера сериализации.</exception>
		// Token: 0x060024FB RID: 9467
		public abstract ICollection Deserialize(SerializationStore store, IContainer container);

		/// <summary>Выполняет десериализацию заданного объекта <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" /> в заданный контейнер (при необходимости применяются значения свойств по умолчанию).</summary>
		/// <param name="store">Объект <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, предназначенный для выполнения десериализации.</param>
		/// <param name="container">Контейнер, в который добавляются объекты <see cref="T:System.ComponentModel.IComponent" />.</param>
		/// <param name="validateRecycledTypes">Значение <see langword="true" /> гарантирует, что в процессе десериализации используется объект того же типа.</param>
		/// <param name="applyDefaults">Значение <see langword="true" /> указывает, что используются значения свойств по умолчанию.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="store" /> или <paramref name="container" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="store" /> не содержит данных в формате обработки контейнера сериализации.</exception>
		// Token: 0x060024FC RID: 9468
		public abstract void DeserializeTo(SerializationStore store, IContainer container, bool validateRecycledTypes, bool applyDefaults);

		/// <summary>Выполняет десериализацию заданного объекта <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" /> в заданный контейнер.</summary>
		/// <param name="store">Объект <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, предназначенный для выполнения десериализации.</param>
		/// <param name="container">Контейнер, в который добавляются объекты <see cref="T:System.ComponentModel.IComponent" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="store" /> или <paramref name="container" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="store" /> не содержит данных в формате обработки контейнера сериализации.</exception>
		// Token: 0x060024FD RID: 9469 RVA: 0x000829E6 File Offset: 0x00080BE6
		public void DeserializeTo(SerializationStore store, IContainer container)
		{
			this.DeserializeTo(store, container, true, true);
		}

		/// <summary>Выполняет десериализацию заданного объекта <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" /> в заданный контейнер (при необходимости выполняется проверка очищенных типов).</summary>
		/// <param name="store">Объект <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, предназначенный для выполнения десериализации.</param>
		/// <param name="container">Контейнер, в который добавляются объекты <see cref="T:System.ComponentModel.IComponent" />.</param>
		/// <param name="validateRecycledTypes">Значение <see langword="true" /> гарантирует, что в процессе десериализации используется объект того же типа.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="store" /> или <paramref name="container" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="store" /> не содержит данных в формате обработки контейнера сериализации.</exception>
		// Token: 0x060024FE RID: 9470 RVA: 0x000829F2 File Offset: 0x00080BF2
		public void DeserializeTo(SerializationStore store, IContainer container, bool validateRecycledTypes)
		{
			this.DeserializeTo(store, container, validateRecycledTypes, true);
		}
	}
}
