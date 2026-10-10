using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Drawing.Design
{
	/// <summary>Обеспечивает базовую реализацию элемента панели инструментов.</summary>
	// Token: 0x02000131 RID: 305
	[MonoTODO("Implementation is incomplete.")]
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	[Serializable]
	public class ToolboxItem : ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		// Token: 0x06000DCC RID: 3532 RVA: 0x0001F1CC File Offset: 0x0001D3CC
		public ToolboxItem()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.ToolboxItem" />, который создает определенный тип компонента.</summary>
		/// <param name="toolType">Тип <see cref="T:System.ComponentModel.IComponent" />, создаваемый элементом панели инструментов.</param>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Drawing.Design.ToolboxItem" /> был заблокирован.</exception>
		// Token: 0x06000DCD RID: 3533 RVA: 0x0001F1DF File Offset: 0x0001D3DF
		public ToolboxItem(Type toolType)
		{
			this.Initialize(toolType);
		}

		/// <summary>Получает или задает имя сборки, содержащей тип или типы, созданные элементом панели инструментов.</summary>
		/// <returns>Атрибут <see cref="T:System.Reflection.AssemblyName" />, указывающий сборку, которая содержит создаваемый тип или типы.</returns>
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0001F1F9 File Offset: 0x0001D3F9
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x0001F210 File Offset: 0x0001D410
		public AssemblyName AssemblyName
		{
			get
			{
				return (AssemblyName)this.properties["AssemblyName"];
			}
			set
			{
				this.SetValue("AssemblyName", value);
			}
		}

		/// <summary>Получает или задает растровое изображение для представления элемента панели инструментов на панели.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Bitmap" />, представляющий элемент панели инструментов на панели.</returns>
		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0001F21E File Offset: 0x0001D41E
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x0001F235 File Offset: 0x0001D435
		public Bitmap Bitmap
		{
			get
			{
				return (Bitmap)this.properties["Bitmap"];
			}
			set
			{
				this.SetValue("Bitmap", value);
			}
		}

		/// <summary>Получает или задает изображаемое имя для элемента панели инструментов.</summary>
		/// <returns>Изображаемое имя для данного элемента панели инструментов.</returns>
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0001F243 File Offset: 0x0001D443
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x0001F250 File Offset: 0x0001D450
		public string DisplayName
		{
			get
			{
				return this.GetValue("DisplayName");
			}
			set
			{
				this.SetValue("DisplayName", value);
			}
		}

		/// <summary>Получает или задает фильтр, определяющий, может ли элемент панели инструментов быть использован для конечного компонента.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" /> объектов <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" />.</returns>
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0001F260 File Offset: 0x0001D460
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x0001F28E File Offset: 0x0001D48E
		public ICollection Filter
		{
			get
			{
				ICollection collection = (ICollection)this.properties["Filter"];
				if (collection == null)
				{
					collection = new ToolboxItemFilterAttribute[0];
				}
				return collection;
			}
			set
			{
				this.SetValue("Filter", value);
			}
		}

		/// <summary>Возвращает значение, определяющее, заблокирован ли элемент <see cref="T:System.Drawing.Design.ToolboxItem" /> в текущий момент.</summary>
		/// <returns>Значение <see langword="true" />, если элемент панели инструментов заблокирован; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0001F29C File Offset: 0x0001D49C
		public virtual bool Locked
		{
			get
			{
				return this.locked;
			}
		}

		/// <summary>Получает или задает полное имя типа <see cref="T:System.ComponentModel.IComponent" />, который создает при вызове элемент панели инструментов.</summary>
		/// <returns>Полное имя типа компонента, который создал данный элемент панели инструментов.</returns>
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x0001F2B1 File Offset: 0x0001D4B1
		public string TypeName
		{
			get
			{
				return this.GetValue("TypeName");
			}
			set
			{
				this.SetValue("TypeName", value);
			}
		}

		/// <summary>Получает или задает имя компании для данного объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, который указывает компанию для этого объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0001F2BF File Offset: 0x0001D4BF
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x0001F2D6 File Offset: 0x0001D4D6
		public string Company
		{
			get
			{
				return (string)this.properties["Company"];
			}
			set
			{
				this.SetValue("Company", value);
			}
		}

		/// <summary>Возвращает тип компонента для данного объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, который указывает тип компонента для этого объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0001F2E4 File Offset: 0x0001D4E4
		public virtual string ComponentType
		{
			get
			{
				return ".NET Component";
			}
		}

		/// <summary>Получает или устанавливает объект <see cref="T:System.Reflection.AssemblyName" /> для элемента панели инструментов.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.AssemblyName" />.</returns>
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0001F2EB File Offset: 0x0001D4EB
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x0001F304 File Offset: 0x0001D504
		public AssemblyName[] DependentAssemblies
		{
			get
			{
				return (AssemblyName[])this.properties["DependentAssemblies"];
			}
			set
			{
				AssemblyName[] array = new AssemblyName[value.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = value[i];
				}
				this.SetValue("DependentAssemblies", array);
			}
		}

		/// <summary>Получает или задает описание для этого компонента <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, который указывает описанию для этого объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0001F33A File Offset: 0x0001D53A
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0001F351 File Offset: 0x0001D551
		public string Description
		{
			get
			{
				return (string)this.properties["Description"];
			}
			set
			{
				this.SetValue("Description", value);
			}
		}

		/// <summary>Возвращает значение, определяющее, является ли данный элемент панели инструментов переходным.</summary>
		/// <returns>Значение <see langword="true" />, если не следует хранить этот элемент панели инструментов при закрытии приложения, предоставляющего панель инструментов; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0001F360 File Offset: 0x0001D560
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0001F389 File Offset: 0x0001D589
		public bool IsTransient
		{
			get
			{
				object obj = this.properties["IsTransient"];
				return obj != null && (bool)obj;
			}
			set
			{
				this.SetValue("IsTransient", value);
			}
		}

		/// <summary>Возвращает словарь свойств.</summary>
		/// <returns>Словарь пар имя/значения (имена являются именами свойств, а значения — значениями свойств).</returns>
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0001F39C File Offset: 0x0001D59C
		public IDictionary Properties
		{
			get
			{
				return this.properties;
			}
		}

		/// <summary>Возвращает версию для этого объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, который указывает версию для этого объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
		public virtual string Version
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>Выдает исключение, если элемент панели инструментов заблокирован в данный момент.</summary>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Drawing.Design.ToolboxItem" /> заблокирован.</exception>
		// Token: 0x06000DE4 RID: 3556 RVA: 0x0001F3AB File Offset: 0x0001D5AB
		protected void CheckUnlocked()
		{
			if (this.locked)
			{
				throw new InvalidOperationException("The ToolboxItem is locked");
			}
		}

		/// <summary>Создает компоненты, для создания которых был сконфигурирован элемент панели инструментов.</summary>
		/// <returns>Массив созданных объектов интерфейса <see cref="T:System.ComponentModel.IComponent" />.</returns>
		// Token: 0x06000DE5 RID: 3557 RVA: 0x0001F3C0 File Offset: 0x0001D5C0
		public IComponent[] CreateComponents()
		{
			return this.CreateComponents(null);
		}

		/// <summary>Создает компоненты, для создания которых был сконфигурирован элемент панели инструментов, используя указанный узел конструктора.</summary>
		/// <param name="host">Интерфейс <see cref="T:System.ComponentModel.Design.IDesignerHost" />, используемый при создании этих компонентов.</param>
		/// <returns>Массив созданных объектов интерфейса <see cref="T:System.ComponentModel.IComponent" />.</returns>
		// Token: 0x06000DE6 RID: 3558 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		public IComponent[] CreateComponents(IDesignerHost host)
		{
			this.OnComponentsCreating(new ToolboxComponentsCreatingEventArgs(host));
			IComponent[] array = this.CreateComponentsCore(host);
			this.OnComponentsCreated(new ToolboxComponentsCreatedEventArgs(array));
			return array;
		}

		/// <summary>Создает компонент или массив компонентов при вызове элемента панели инструментов.</summary>
		/// <param name="host">Интерфейс <see cref="T:System.ComponentModel.Design.IDesignerHost" /> для размещения элемента панели инструментов.</param>
		/// <returns>Массив созданных объектов интерфейса <see cref="T:System.ComponentModel.IComponent" />.</returns>
		// Token: 0x06000DE7 RID: 3559 RVA: 0x0001F3FC File Offset: 0x0001D5FC
		protected virtual IComponent[] CreateComponentsCore(IDesignerHost host)
		{
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			Type type = this.GetType(host, this.AssemblyName, this.TypeName, true);
			IComponent[] result;
			if (type == null)
			{
				result = new IComponent[0];
			}
			else
			{
				result = new IComponent[]
				{
					host.CreateComponent(type)
				};
			}
			return result;
		}

		/// <summary>Создает массив компонентов при вызове элемента панели инструментов.</summary>
		/// <param name="host">Хост-узел конструктора, используемый при создании компонентов.</param>
		/// <param name="defaultValues">Словарь пар имя/значение для значений по умолчанию, с использованием которых выполняется инициализация компонента.</param>
		/// <returns>Массив созданных объектов интерфейса <see cref="T:System.ComponentModel.IComponent" />.</returns>
		// Token: 0x06000DE8 RID: 3560 RVA: 0x0001F450 File Offset: 0x0001D650
		protected virtual IComponent[] CreateComponentsCore(IDesignerHost host, IDictionary defaultValues)
		{
			IComponent[] array = this.CreateComponentsCore(host);
			foreach (Component component in array)
			{
				(host.GetDesigner(component) as IComponentInitializer).InitializeNewComponent(defaultValues);
			}
			return array;
		}

		/// <summary>Создает компоненты, для создания которых был сконфигурирован элемент панели инструментов с использованием указанного узла конструктора и значений по умолчанию.</summary>
		/// <param name="host">Интерфейс <see cref="T:System.ComponentModel.Design.IDesignerHost" />, используемый при создании этих компонентов.</param>
		/// <param name="defaultValues">Словарь пар имя/значение для значений по умолчанию, с использованием которых выполняется инициализация компонента.</param>
		/// <returns>Массив созданных объектов интерфейса <see cref="T:System.ComponentModel.IComponent" />.</returns>
		// Token: 0x06000DE9 RID: 3561 RVA: 0x0001F494 File Offset: 0x0001D694
		public IComponent[] CreateComponents(IDesignerHost host, IDictionary defaultValues)
		{
			this.OnComponentsCreating(new ToolboxComponentsCreatingEventArgs(host));
			IComponent[] array = this.CreateComponentsCore(host, defaultValues);
			this.OnComponentsCreated(new ToolboxComponentsCreatedEventArgs(array));
			return array;
		}

		/// <summary>Выполняет фильтрацию значения свойства перед его возвращением.</summary>
		/// <param name="propertyName">Имя отбираемого свойства.</param>
		/// <param name="value">Значение фильтра для свойства.</param>
		/// <returns>Значение отобранного свойства.</returns>
		// Token: 0x06000DEA RID: 3562 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		protected virtual object FilterPropertyValue(string propertyName, object value)
		{
			if (!(propertyName == "AssemblyName"))
			{
				if (!(propertyName == "DisplayName") && !(propertyName == "TypeName"))
				{
					if (!(propertyName == "Filter"))
					{
						return value;
					}
					if (value != null)
					{
						return value;
					}
					return new ToolboxItemFilterAttribute[0];
				}
				else
				{
					if (value != null)
					{
						return value;
					}
					return string.Empty;
				}
			}
			else
			{
				if (value != null)
				{
					return (value as ICloneable).Clone();
				}
				return null;
			}
		}

		/// <summary>Загружает статус элемента панели элементов из указанного объекта сведений сериализации.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, и которого выполняется загрузка.</param>
		/// <param name="context">Класс <see cref="T:System.Runtime.Serialization.StreamingContext" />, указывающий характеристики потока.</param>
		// Token: 0x06000DEB RID: 3563 RVA: 0x0001F530 File Offset: 0x0001D730
		protected virtual void Deserialize(SerializationInfo info, StreamingContext context)
		{
			this.AssemblyName = (AssemblyName)info.GetValue("AssemblyName", typeof(AssemblyName));
			this.Bitmap = (Bitmap)info.GetValue("Bitmap", typeof(Bitmap));
			this.Filter = (ICollection)info.GetValue("Filter", typeof(ICollection));
			this.DisplayName = info.GetString("DisplayName");
			this.locked = info.GetBoolean("Locked");
			this.TypeName = info.GetString("TypeName");
		}

		/// <summary>Определяет, равны ли два экземпляра <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, с которым сравнивается текущий объект <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Drawing.Design.ToolboxItem" /> равен текущему объекту <see cref="T:System.Drawing.Design.ToolboxItem" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000DEC RID: 3564 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
		public override bool Equals(object obj)
		{
			ToolboxItem toolboxItem = obj as ToolboxItem;
			return toolboxItem != null && (obj == this || (toolboxItem.AssemblyName.Equals(this.AssemblyName) && toolboxItem.Locked.Equals(this.locked) && toolboxItem.TypeName.Equals(this.TypeName) && toolboxItem.DisplayName.Equals(this.DisplayName) && toolboxItem.Bitmap.Equals(this.Bitmap)));
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x06000DED RID: 3565 RVA: 0x0001F651 File Offset: 0x0001D851
		public override int GetHashCode()
		{
			return (this.TypeName + this.DisplayName).GetHashCode();
		}

		/// <summary>Включает доступ к типу, который сопоставлен данному элементу панели инструментов.</summary>
		/// <param name="host">Хост-узел конструктора для запроса интерфейса <see cref="T:System.ComponentModel.Design.ITypeResolutionService" />.</param>
		/// <returns>Тип, сопоставленный данному элементу панели инструментов.</returns>
		// Token: 0x06000DEE RID: 3566 RVA: 0x0001F669 File Offset: 0x0001D869
		public Type GetType(IDesignerHost host)
		{
			return this.GetType(host, this.AssemblyName, this.TypeName, false);
		}

		/// <summary>Создает экземпляр указанного типа, при необходимости используя заданные узел конструктора и имя сборки.</summary>
		/// <param name="host">Объект <see cref="T:System.ComponentModel.Design.IDesignerHost" /> для текущего документа. Это может быть <see langword="null" />.</param>
		/// <param name="assemblyName">Объект <see cref="T:System.Reflection.AssemblyName" />, указывающий сборку, которая содержит загружаемый тип. Это может быть <see langword="null" />.</param>
		/// <param name="typeName">Имя типа создаваемого экземпляра.</param>
		/// <param name="reference">Значение, указывающее, добавлена или нет ссылка на сборку, которая содержит указанный тип, в набор ссылок узла конструктора.</param>
		/// <returns>Экземпляр указанного типа, если он может быть обнаружен.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> не задан.</exception>
		// Token: 0x06000DEF RID: 3567 RVA: 0x0001F680 File Offset: 0x0001D880
		protected virtual Type GetType(IDesignerHost host, AssemblyName assemblyName, string typeName, bool reference)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			if (host == null)
			{
				return null;
			}
			ITypeResolutionService typeResolutionService = host.GetService(typeof(ITypeResolutionService)) as ITypeResolutionService;
			Type result = null;
			if (typeResolutionService != null)
			{
				typeResolutionService.GetAssembly(assemblyName, true);
				if (reference)
				{
					typeResolutionService.ReferenceAssembly(assemblyName);
				}
				result = typeResolutionService.GetType(typeName, true);
			}
			else
			{
				Assembly assembly = Assembly.Load(assemblyName);
				if (assembly != null)
				{
					result = assembly.GetType(typeName);
				}
			}
			return result;
		}

		/// <summary>Инициализирует текущий элемент панели инструментов создаваемого типа.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, создаваемый элементом панели инструментов.</param>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Drawing.Design.ToolboxItem" /> был заблокирован.</exception>
		// Token: 0x06000DF0 RID: 3568 RVA: 0x0001F6F4 File Offset: 0x0001D8F4
		public virtual void Initialize(Type type)
		{
			this.CheckUnlocked();
			if (type == null)
			{
				return;
			}
			this.AssemblyName = type.Assembly.GetName();
			this.DisplayName = type.Name;
			this.TypeName = type.FullName;
			Image image = null;
			object[] customAttributes = type.GetCustomAttributes(true);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				ToolboxBitmapAttribute toolboxBitmapAttribute = customAttributes[i] as ToolboxBitmapAttribute;
				if (toolboxBitmapAttribute != null)
				{
					image = toolboxBitmapAttribute.GetImage(type);
					break;
				}
			}
			if (image == null)
			{
				image = ToolboxBitmapAttribute.GetImageFromResource(type, null, false);
			}
			if (image != null)
			{
				this.Bitmap = (image as Bitmap);
				if (this.Bitmap == null)
				{
					this.Bitmap = new Bitmap(image);
				}
			}
			this.Filter = type.GetCustomAttributes(typeof(ToolboxItemFilterAttribute), true);
		}

		/// <summary>Описание этого элемента содержится в методе <see cref="M:System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Конечный объект (см. <see cref="T:System.Runtime.Serialization.StreamingContext" />) для этой сериализации.</param>
		// Token: 0x06000DF1 RID: 3569 RVA: 0x0001F7AE File Offset: 0x0001D9AE
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			this.Serialize(info, context);
		}

		/// <summary>Блокирует элемент панели инструментов и предотвращает изменение его свойств.</summary>
		// Token: 0x06000DF2 RID: 3570 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
		public virtual void Lock()
		{
			this.locked = true;
		}

		/// <summary>Вызывает событие <see cref="E:System.Drawing.Design.ToolboxItem.ComponentsCreated" />.</summary>
		/// <param name="args">Объект <see cref="T:System.Drawing.Design.ToolboxComponentsCreatedEventArgs" />, который предоставляет данные для события.</param>
		// Token: 0x06000DF3 RID: 3571 RVA: 0x0001F7C1 File Offset: 0x0001D9C1
		protected virtual void OnComponentsCreated(ToolboxComponentsCreatedEventArgs args)
		{
			if (this.ComponentsCreated != null)
			{
				this.ComponentsCreated(this, args);
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.Drawing.Design.ToolboxItem.ComponentsCreating" />.</summary>
		/// <param name="args">Объект <see cref="T:System.Drawing.Design.ToolboxComponentsCreatingEventArgs" />, который предоставляет данные для события.</param>
		// Token: 0x06000DF4 RID: 3572 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		protected virtual void OnComponentsCreating(ToolboxComponentsCreatingEventArgs args)
		{
			if (this.ComponentsCreating != null)
			{
				this.ComponentsCreating(this, args);
			}
		}

		/// <summary>Сохраняет состояние элемента панели элементов в указанный объект данных сериализации.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, в который выполняется сохранение.</param>
		/// <param name="context">Класс <see cref="T:System.Runtime.Serialization.StreamingContext" />, указывающий характеристики потока.</param>
		// Token: 0x06000DF5 RID: 3573 RVA: 0x0001F7F0 File Offset: 0x0001D9F0
		protected virtual void Serialize(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("AssemblyName", this.AssemblyName);
			info.AddValue("Bitmap", this.Bitmap);
			info.AddValue("Filter", this.Filter);
			info.AddValue("DisplayName", this.DisplayName);
			info.AddValue("Locked", this.locked);
			info.AddValue("TypeName", this.TypeName);
		}

		/// <summary>Возвращает строку <see cref="T:System.String" />, которая представляет текущий объект <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, представляющий текущий объект <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x06000DF6 RID: 3574 RVA: 0x0001F863 File Offset: 0x0001DA63
		public override string ToString()
		{
			return this.DisplayName;
		}

		/// <summary>Проверяет соответствие объекта заданному типу.</summary>
		/// <param name="propertyName">Имя проверяемого свойства.</param>
		/// <param name="value">Необязательное значение, по которому выполняется проверка.</param>
		/// <param name="expectedType">Ожидаемый тип свойства.</param>
		/// <param name="allowNull">Значение <see langword="true" />, если допустимо значение <see langword="null" />; в обратном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> равно <see langword="null" />, а <paramref name="allowNull" /> равно <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="value" /> отличается от типа, заданного свойством <paramref name="expectedType" />.</exception>
		// Token: 0x06000DF7 RID: 3575 RVA: 0x0001F86C File Offset: 0x0001DA6C
		protected void ValidatePropertyType(string propertyName, object value, Type expectedType, bool allowNull)
		{
			if (!allowNull && value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value != null && !expectedType.Equals(value.GetType()))
			{
				throw new ArgumentException(Locale.GetText("Type mismatch between value ({0}) and expected type ({1}).", new object[]
				{
					value.GetType(),
					expectedType
				}), "value");
			}
		}

		/// <summary>Проверяет свойство перед его присваиванием словарю свойств.</summary>
		/// <param name="propertyName">Имя проверяемого свойства.</param>
		/// <param name="value">Значение, по которому выполняется проверка.</param>
		/// <returns>Значение, используемое для выполнения проверки.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> равно <see langword="null" />, а параметр <paramref name="propertyName" /> имеет значение "IsTransient".</exception>
		// Token: 0x06000DF8 RID: 3576 RVA: 0x0001F8C4 File Offset: 0x0001DAC4
		protected virtual object ValidatePropertyValue(string propertyName, object value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(propertyName);
			if (num <= 1629252038U)
			{
				if (num <= 982935374U)
				{
					if (num != 278446637U)
					{
						if (num != 982935374U)
						{
							return value;
						}
						if (!(propertyName == "TypeName"))
						{
							return value;
						}
					}
					else
					{
						if (!(propertyName == "IsTransient"))
						{
							return value;
						}
						this.ValidatePropertyType(propertyName, value, typeof(bool), false);
						return value;
					}
				}
				else if (num != 1561053712U)
				{
					if (num != 1629252038U)
					{
						return value;
					}
					if (!(propertyName == "AssemblyName"))
					{
						return value;
					}
					this.ValidatePropertyType(propertyName, value, typeof(AssemblyName), true);
					return value;
				}
				else
				{
					if (!(propertyName == "DependentAssemblies"))
					{
						return value;
					}
					this.ValidatePropertyType(propertyName, value, typeof(AssemblyName[]), true);
					return value;
				}
			}
			else if (num <= 1725856265U)
			{
				if (num != 1651150918U)
				{
					if (num != 1725856265U)
					{
						return value;
					}
					if (!(propertyName == "Description"))
					{
						return value;
					}
				}
				else
				{
					if (!(propertyName == "Bitmap"))
					{
						return value;
					}
					this.ValidatePropertyType(propertyName, value, typeof(Bitmap), true);
					return value;
				}
			}
			else if (num != 3250523996U)
			{
				if (num != 4104765591U)
				{
					if (num != 4176258230U)
					{
						return value;
					}
					if (!(propertyName == "DisplayName"))
					{
						return value;
					}
				}
				else
				{
					if (!(propertyName == "Filter"))
					{
						return value;
					}
					this.ValidatePropertyType(propertyName, value, typeof(ToolboxItemFilterAttribute[]), true);
					if (value == null)
					{
						return new ToolboxItemFilterAttribute[0];
					}
					return value;
				}
			}
			else if (!(propertyName == "Company"))
			{
				return value;
			}
			this.ValidatePropertyType(propertyName, value, typeof(string), true);
			if (value == null)
			{
				value = string.Empty;
			}
			return value;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0001FA9B File Offset: 0x0001DC9B
		private void SetValue(string propertyName, object value)
		{
			this.CheckUnlocked();
			this.properties[propertyName] = this.ValidatePropertyValue(propertyName, value);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		private string GetValue(string propertyName)
		{
			string text = (string)this.properties[propertyName];
			if (text != null)
			{
				return text;
			}
			return string.Empty;
		}

		/// <summary>Происходит непосредственно после создания компонентов.</summary>
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000DFB RID: 3579 RVA: 0x0001FAE4 File Offset: 0x0001DCE4
		// (remove) Token: 0x06000DFC RID: 3580 RVA: 0x0001FB1C File Offset: 0x0001DD1C
		public event ToolboxComponentsCreatedEventHandler ComponentsCreated;

		/// <summary>Происходит непосредственно перед созданием компонентов.</summary>
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000DFD RID: 3581 RVA: 0x0001FB54 File Offset: 0x0001DD54
		// (remove) Token: 0x06000DFE RID: 3582 RVA: 0x0001FB8C File Offset: 0x0001DD8C
		public event ToolboxComponentsCreatingEventHandler ComponentsCreating;

		/// <summary>Возвращает или задает исходное растровое изображение, которое будет использоваться на панели инструментов для этого элемента.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Bitmap" />, представляющий элемент панели инструментов на панели.</returns>
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0001FBC1 File Offset: 0x0001DDC1
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00005B7D File Offset: 0x00003D7D
		public Bitmap OriginalBitmap
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		// Token: 0x04000AA8 RID: 2728
		private bool locked;

		// Token: 0x04000AA9 RID: 2729
		private Hashtable properties = new Hashtable();
	}
}
