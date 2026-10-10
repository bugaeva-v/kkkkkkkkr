using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Предоставляет дополнительные метаданные для <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x020003F3 RID: 1011
	public abstract class TypeDescriptionProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeDescriptionProvider" />.</summary>
		// Token: 0x06002102 RID: 8450 RVA: 0x0000219B File Offset: 0x0000039B
		protected TypeDescriptionProvider()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeDescriptionProvider" />, используя поставщика описания родительского типа.</summary>
		/// <param name="parent">Поставщик описания родительского типа.</param>
		// Token: 0x06002103 RID: 8451 RVA: 0x00071C33 File Offset: 0x0006FE33
		protected TypeDescriptionProvider(TypeDescriptionProvider parent)
		{
			this._parent = parent;
		}

		/// <summary>Создает объект, которым можно заменить другой тип данных.</summary>
		/// <param name="provider">Необязательный поставщик услуги.</param>
		/// <param name="objectType">Тип создаваемого объекта. Значением этого параметра никогда не может быть <see langword="null" />.</param>
		/// <param name="argTypes">Необязательный массив типов, представляющих типы параметров, передаваемые конструктору объекта. Этот массив может быть представлять собой значение <see langword="null" /> или его длина может быть нулевой.</param>
		/// <param name="args">Необязательный массив значений параметров для передачи в конструктор объекта.</param>
		/// <returns>Объект <see cref="T:System.Object" /> для подстановки</returns>
		// Token: 0x06002104 RID: 8452 RVA: 0x00071C42 File Offset: 0x0006FE42
		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			if (this._parent != null)
			{
				return this._parent.CreateInstance(provider, objectType, argTypes, args);
			}
			if (objectType == null)
			{
				throw new ArgumentNullException("objectType");
			}
			return Activator.CreateInstance(objectType, args);
		}

		/// <summary>Возвращает кэш на пообъектной основе, доступный как пары "ключ-значение" <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="instance">Объект, для которого возвращается кэш.</param>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionary" />, если предоставленный объект поддерживает кэширование; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x06002105 RID: 8453 RVA: 0x00071C79 File Offset: 0x0006FE79
		public virtual IDictionary GetCache(object instance)
		{
			TypeDescriptionProvider parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetCache(instance);
		}

		/// <summary>Возвращает расширенный настраиваемый дескриптор типа для данного объекта.</summary>
		/// <param name="instance">Объект, для которого возвращается расширенный дескриптор типа.</param>
		/// <returns>Интерфейс <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />, который может предоставить расширенные метаданные для этого объекта.</returns>
		// Token: 0x06002106 RID: 8454 RVA: 0x00071C90 File Offset: 0x0006FE90
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			if (this._parent != null)
			{
				return this._parent.GetExtendedTypeDescriptor(instance);
			}
			TypeDescriptionProvider.EmptyCustomTypeDescriptor result;
			if ((result = this._emptyDescriptor) == null)
			{
				result = (this._emptyDescriptor = new TypeDescriptionProvider.EmptyCustomTypeDescriptor());
			}
			return result;
		}

		/// <summary>Получает поставщики расширителей для заданного объекта.</summary>
		/// <param name="instance">Объект, для которого необходимо получить поставщики расширителей.</param>
		/// <returns>Массив поставщиков расширителей для параметра <paramref name="instance" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="instance" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002107 RID: 8455 RVA: 0x00071CCA File Offset: 0x0006FECA
		protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
		{
			if (this._parent != null)
			{
				return this._parent.GetExtenderProviders(instance);
			}
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			return Array.Empty<IExtenderProvider>();
		}

		/// <summary>Возвращает имя заданного компонента или <see langword="null" />, если у компонента нет имени.</summary>
		/// <param name="component">Заданный компонент.</param>
		/// <returns>Имя заданного компонента.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="component" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002108 RID: 8456 RVA: 0x00071CF4 File Offset: 0x0006FEF4
		public virtual string GetFullComponentName(object component)
		{
			if (this._parent != null)
			{
				return this._parent.GetFullComponentName(component);
			}
			return this.GetTypeDescriptor(component).GetComponentName();
		}

		/// <summary>Выполняет обычное отражение для типа.</summary>
		/// <param name="objectType">Тип объекта, для которого возвращается интерфейс <see cref="T:System.Reflection.IReflect" />.</param>
		/// <returns>Тип отражения для этого объекта <paramref name="objectType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="objectType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002109 RID: 8457 RVA: 0x00071D17 File Offset: 0x0006FF17
		public Type GetReflectionType(Type objectType)
		{
			return this.GetReflectionType(objectType, null);
		}

		/// <summary>Выполняет обычное отражение для данного объекта.</summary>
		/// <param name="instance">Экземпляр типа (не должен быть значением <see langword="null" />).</param>
		/// <returns>Тип отражения для этого объекта <paramref name="instance" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="instance" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600210A RID: 8458 RVA: 0x00071D21 File Offset: 0x0006FF21
		public Type GetReflectionType(object instance)
		{
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			return this.GetReflectionType(instance.GetType(), instance);
		}

		/// <summary>Выполняет обычное отражение для заданного объекта с заданным типом.</summary>
		/// <param name="objectType">Тип объекта, для которого возвращается интерфейс <see cref="T:System.Reflection.IReflect" />.</param>
		/// <param name="instance">Экземпляр типа. Может принимать значение <see langword="null" />.</param>
		/// <returns>Тип отражения для этого объекта <paramref name="objectType" />.</returns>
		// Token: 0x0600210B RID: 8459 RVA: 0x00071D3E File Offset: 0x0006FF3E
		public virtual Type GetReflectionType(Type objectType, object instance)
		{
			if (this._parent != null)
			{
				return this._parent.GetReflectionType(objectType, instance);
			}
			return objectType;
		}

		/// <summary>Преобразует тип отражения в тип среды выполнения.</summary>
		/// <param name="reflectionType">Тип, который нужно преобразовать в соответствующий эквивалент среды выполнения.</param>
		/// <returns>Тип <see cref="T:System.Type" />, представляющий эквивалент среды выполнения для типа <paramref name="reflectionType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="reflectionType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600210C RID: 8460 RVA: 0x00071D58 File Offset: 0x0006FF58
		public virtual Type GetRuntimeType(Type reflectionType)
		{
			if (this._parent != null)
			{
				return this._parent.GetRuntimeType(reflectionType);
			}
			if (reflectionType == null)
			{
				throw new ArgumentNullException("reflectionType");
			}
			if (reflectionType.GetType().Assembly == typeof(object).Assembly)
			{
				return reflectionType;
			}
			return reflectionType.UnderlyingSystemType;
		}

		/// <summary>Возвращает настраиваемый дескриптор типа для заданного типа.</summary>
		/// <param name="objectType">Тип объекта, для которого возвращается дескриптор типа.</param>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />, который может предоставить метаданные для этого типа.</returns>
		// Token: 0x0600210D RID: 8461 RVA: 0x00071DB7 File Offset: 0x0006FFB7
		public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
		{
			return this.GetTypeDescriptor(objectType, null);
		}

		/// <summary>Возвращает настраиваемый дескриптор типа для заданного объекта.</summary>
		/// <param name="instance">Экземпляр типа. Может быть значением <see langword="null" />, если в дескриптор <see cref="T:System.ComponentModel.TypeDescriptor" /> не передан никакой экземпляр.</param>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />, который может предоставить метаданные для этого типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="instance" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600210E RID: 8462 RVA: 0x00071DC1 File Offset: 0x0006FFC1
		public ICustomTypeDescriptor GetTypeDescriptor(object instance)
		{
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			return this.GetTypeDescriptor(instance.GetType(), instance);
		}

		/// <summary>Возвращает настраиваемый дескриптор типа для заданного типа и объекта.</summary>
		/// <param name="objectType">Тип объекта, для которого возвращается дескриптор типа.</param>
		/// <param name="instance">Экземпляр типа. Может быть значением <see langword="null" />, если в дескриптор <see cref="T:System.ComponentModel.TypeDescriptor" /> не передан никакой экземпляр.</param>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />, который может предоставить метаданные для этого типа.</returns>
		// Token: 0x0600210F RID: 8463 RVA: 0x00071DE0 File Offset: 0x0006FFE0
		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			if (this._parent != null)
			{
				return this._parent.GetTypeDescriptor(objectType, instance);
			}
			TypeDescriptionProvider.EmptyCustomTypeDescriptor result;
			if ((result = this._emptyDescriptor) == null)
			{
				result = (this._emptyDescriptor = new TypeDescriptionProvider.EmptyCustomTypeDescriptor());
			}
			return result;
		}

		/// <summary>Получает значение, указывающее, совместим ли заданный тип с описанием типа и его цепочкой поставщиков описаний типов.</summary>
		/// <param name="type">Тип для проверки на совместимость.</param>
		/// <returns>Значение <see langword="true" />, если тип <paramref name="type" /> совместим с описанием типа и его цепочкой поставщиков описаний типов; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002110 RID: 8464 RVA: 0x00071E1B File Offset: 0x0007001B
		public virtual bool IsSupportedType(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return this._parent == null || this._parent.IsSupportedType(type);
		}

		// Token: 0x04000FF3 RID: 4083
		private readonly TypeDescriptionProvider _parent;

		// Token: 0x04000FF4 RID: 4084
		private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

		// Token: 0x020003F4 RID: 1012
		private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
		{
		}
	}
}
