using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс для управления транзакциями и компонентами конструктора.</summary>
	// Token: 0x0200045C RID: 1116
	public interface IDesignerHost : IServiceContainer, IServiceProvider
	{
		/// <summary>Получает значение, показывающее, загружается ли в текущий момент документ хостом конструктора.</summary>
		/// <returns>Значение <see langword="true" />, если документ загружается в текущий момент хостом конструктора; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002423 RID: 9251
		bool Loading { get; }

		/// <summary>Получает значение, показывающее, находится ли хост конструктора в текущий момент в процессе транзакции.</summary>
		/// <returns>Значение <see langword="true" />, если транзакция выполняется; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002424 RID: 9252
		bool InTransaction { get; }

		/// <summary>Получает контейнер для данного хоста конструктора.</summary>
		/// <returns>Класс <see cref="T:System.ComponentModel.IContainer" /> для данного хоста.</returns>
		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002425 RID: 9253
		IContainer Container { get; }

		/// <summary>Получает экземпляр базового класса, используемого в качестве корневого компонента для текущего конструктора.</summary>
		/// <returns>Экземпляр класса корневого компонента.</returns>
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002426 RID: 9254
		IComponent RootComponent { get; }

		/// <summary>Получает полное имя разрабатываемого класса.</summary>
		/// <returns>Полное имя класса базового компонента.</returns>
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002427 RID: 9255
		string RootComponentClassName { get; }

		/// <summary>Получает описание текущей транзакции.</summary>
		/// <returns>Описание текущей транзакции.</returns>
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002428 RID: 9256
		string TransactionDescription { get; }

		/// <summary>Возникает, когда конструктор активизирован.</summary>
		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06002429 RID: 9257
		// (remove) Token: 0x0600242A RID: 9258
		event EventHandler Activated;

		/// <summary>Возникает, когда данный конструктор отключен.</summary>
		// Token: 0x1400003F RID: 63
		// (add) Token: 0x0600242B RID: 9259
		// (remove) Token: 0x0600242C RID: 9260
		event EventHandler Deactivated;

		/// <summary>Возникает, когда конструктор завершил загрузку документа.</summary>
		// Token: 0x14000040 RID: 64
		// (add) Token: 0x0600242D RID: 9261
		// (remove) Token: 0x0600242E RID: 9262
		event EventHandler LoadComplete;

		/// <summary>Добавляет обработчик событий для события <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosed" />.</summary>
		// Token: 0x14000041 RID: 65
		// (add) Token: 0x0600242F RID: 9263
		// (remove) Token: 0x06002430 RID: 9264
		event DesignerTransactionCloseEventHandler TransactionClosed;

		/// <summary>Добавляет обработчик событий для события <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosing" />.</summary>
		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06002431 RID: 9265
		// (remove) Token: 0x06002432 RID: 9266
		event DesignerTransactionCloseEventHandler TransactionClosing;

		/// <summary>Добавляет обработчик событий для события <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionOpened" />.</summary>
		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06002433 RID: 9267
		// (remove) Token: 0x06002434 RID: 9268
		event EventHandler TransactionOpened;

		/// <summary>Добавляет обработчик событий для события <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionOpening" />.</summary>
		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06002435 RID: 9269
		// (remove) Token: 0x06002436 RID: 9270
		event EventHandler TransactionOpening;

		/// <summary>Активизирует конструктор, размещенный на данном хосте.</summary>
		// Token: 0x06002437 RID: 9271
		void Activate();

		/// <summary>Создает компонент указанного типа и добавляет его в документ проекта.</summary>
		/// <param name="componentClass">Тип создаваемого компонента.</param>
		/// <returns>Вновь созданный компонент.</returns>
		// Token: 0x06002438 RID: 9272
		IComponent CreateComponent(Type componentClass);

		/// <summary>Создает компонент с заданным типом и именем и добавляет его в документ проекта.</summary>
		/// <param name="componentClass">Тип создаваемого компонента.</param>
		/// <param name="name">Имя компонента.</param>
		/// <returns>Вновь созданный компонент.</returns>
		// Token: 0x06002439 RID: 9273
		IComponent CreateComponent(Type componentClass, string name);

		/// <summary>Создает класс <see cref="T:System.ComponentModel.Design.DesignerTransaction" />, который может инкапсулировать последовательности событий для повышения производительности, а также для включения вспомогательных функциональных возможностей: отмены и возврата.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerTransaction" />. По завершении этапов транзакции необходимо вызвать для этого объекта метод <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" />.</returns>
		// Token: 0x0600243A RID: 9274
		DesignerTransaction CreateTransaction();

		/// <summary>Создает класс <see cref="T:System.ComponentModel.Design.DesignerTransaction" />, который может инкапсулировать последовательности событий для повышения производительности, а также для включения вспомогательных функциональных возможностей: отмены и возврата, с помощью заданного описания транзакции.</summary>
		/// <param name="description">Заголовок или описание для вновь созданной транзакции.</param>
		/// <returns>Новый объект <see cref="T:System.ComponentModel.Design.DesignerTransaction" />. По завершении этапов транзакции необходимо вызвать для этого объекта метод <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" />.</returns>
		// Token: 0x0600243B RID: 9275
		DesignerTransaction CreateTransaction(string description);

		/// <summary>Уничтожает заданный компонент и удаляет его из контейнера конструктора.</summary>
		/// <param name="component">Уничтожаемый компонент.</param>
		// Token: 0x0600243C RID: 9276
		void DestroyComponent(IComponent component);

		/// <summary>Получает экземпляр конструктора, содержащий указанный компонент.</summary>
		/// <param name="component">Класс <see cref="T:System.ComponentModel.IComponent" />, для которого загружается конструктор.</param>
		/// <returns>Класс <see cref="T:System.ComponentModel.Design.IDesigner" /> или значение <see langword="null" />, если для указанного компонента не существует конструктора.</returns>
		// Token: 0x0600243D RID: 9277
		IDesigner GetDesigner(IComponent component);

		/// <summary>Получает экземпляр заданного полного имени типа.</summary>
		/// <param name="typeName">Имя загружаемого типа.</param>
		/// <returns>Объект типа для заданного имени типа или значение <see langword="null" />, если тип не найден.</returns>
		// Token: 0x0600243E RID: 9278
		Type GetType(string typeName);
	}
}
