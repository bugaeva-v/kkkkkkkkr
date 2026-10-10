using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Представляет член класса, например свойство или событие. Этот класс является абстрактным базовым классом.</summary>
	// Token: 0x02000419 RID: 1049
	[ComVisible(true)]
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public abstract class MemberDescriptor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MemberDescriptor" /> с указанным именем члена.</summary>
		/// <param name="name">Имя элемента.</param>
		/// <exception cref="T:System.ArgumentException">Имя представляет собой пустую строку ("") или <see langword="null" />.</exception>
		// Token: 0x060021D5 RID: 8661 RVA: 0x00073C2A File Offset: 0x00071E2A
		protected MemberDescriptor(string name) : this(name, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MemberDescriptor" />, используя указанное имя члена и массив атрибутов.</summary>
		/// <param name="name">Имя элемента.</param>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, который содержит атрибуты члена.</param>
		/// <exception cref="T:System.ArgumentException">Имя представляет собой пустую строку ("") или <see langword="null" />.</exception>
		// Token: 0x060021D6 RID: 8662 RVA: 0x00073C34 File Offset: 0x00071E34
		protected MemberDescriptor(string name, Attribute[] attributes)
		{
			this.lockCookie = new object();
			base..ctor();
			try
			{
				if (name == null || name.Length == 0)
				{
					throw new ArgumentException(SR.GetString("Invalid member name."));
				}
				this.name = name;
				this.displayName = name;
				this.nameHash = name.GetHashCode();
				if (attributes != null)
				{
					this.attributes = attributes;
					this.attributesFiltered = false;
				}
				this.originalAttributes = this.attributes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MemberDescriptor" /> указанным значением <see cref="T:System.ComponentModel.MemberDescriptor" />.</summary>
		/// <param name="descr">Объект <see cref="T:System.ComponentModel.MemberDescriptor" />, который содержит имя члена и его атрибуты.</param>
		// Token: 0x060021D7 RID: 8663 RVA: 0x00073CB8 File Offset: 0x00071EB8
		protected MemberDescriptor(MemberDescriptor descr)
		{
			this.lockCookie = new object();
			base..ctor();
			this.name = descr.Name;
			this.displayName = this.name;
			this.nameHash = this.name.GetHashCode();
			this.attributes = new Attribute[descr.Attributes.Count];
			descr.Attributes.CopyTo(this.attributes, 0);
			this.attributesFiltered = true;
			this.originalAttributes = this.attributes;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MemberDescriptor" />, используя имя в заданном дескрипторе <see cref="T:System.ComponentModel.MemberDescriptor" /> и атрибуты как в старом дескрипторе <see cref="T:System.ComponentModel.MemberDescriptor" />, так и в массиве <see cref="T:System.Attribute" /> .</summary>
		/// <param name="oldMemberDescriptor">Объект <see cref="T:System.ComponentModel.MemberDescriptor" />, который содержит имя члена и его атрибуты.</param>
		/// <param name="newAttributes">Массив объектов <see cref="T:System.Attribute" /> с атрибутами, которые нужно добавить для члена.</param>
		// Token: 0x060021D8 RID: 8664 RVA: 0x00073D3C File Offset: 0x00071F3C
		protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
		{
			this.lockCookie = new object();
			base..ctor();
			this.name = oldMemberDescriptor.Name;
			this.displayName = oldMemberDescriptor.DisplayName;
			this.nameHash = this.name.GetHashCode();
			ArrayList arrayList = new ArrayList();
			if (oldMemberDescriptor.Attributes.Count != 0)
			{
				foreach (object value in oldMemberDescriptor.Attributes)
				{
					arrayList.Add(value);
				}
			}
			if (newAttributes != null)
			{
				foreach (Attribute value2 in newAttributes)
				{
					arrayList.Add(value2);
				}
			}
			this.attributes = new Attribute[arrayList.Count];
			arrayList.CopyTo(this.attributes, 0);
			this.attributesFiltered = false;
			this.originalAttributes = this.attributes;
		}

		/// <summary>Получает или задает массив атрибутов.</summary>
		/// <returns>Массив типа <see cref="T:System.Attribute" />, который содержит атрибуты этого члена.</returns>
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00073E38 File Offset: 0x00072038
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x00073E4C File Offset: 0x0007204C
		protected virtual Attribute[] AttributeArray
		{
			get
			{
				this.CheckAttributesValid();
				this.FilterAttributesIfNeeded();
				return this.attributes;
			}
			set
			{
				object obj = this.lockCookie;
				lock (obj)
				{
					this.attributes = value;
					this.originalAttributes = value;
					this.attributesFiltered = false;
					this.attributeCollection = null;
				}
			}
		}

		/// <summary>Возвращает коллекцию атрибутов для этого члена.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.AttributeCollection" />, содержащая атрибуты этого члена, или пустая коллекция, если атрибуты в массиве <see cref="P:System.ComponentModel.MemberDescriptor.AttributeArray" /> отсутствуют.</returns>
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x00073EA4 File Offset: 0x000720A4
		public virtual AttributeCollection Attributes
		{
			get
			{
				this.CheckAttributesValid();
				AttributeCollection attributeCollection = this.attributeCollection;
				if (attributeCollection == null)
				{
					object obj = this.lockCookie;
					lock (obj)
					{
						attributeCollection = this.CreateAttributeCollection();
						this.attributeCollection = attributeCollection;
					}
				}
				return attributeCollection;
			}
		}

		/// <summary>Возвращает имя категории, к которой принадлежит член, как это указано в объекте <see cref="T:System.ComponentModel.CategoryAttribute" />.</summary>
		/// <returns>Имя категории, к которой принадлежит член. Если атрибут <see cref="T:System.ComponentModel.CategoryAttribute" /> отсутствует, имя категории устанавливается в соответствии с категорией по умолчанию, <see langword="Misc" />.</returns>
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x00073F00 File Offset: 0x00072100
		public virtual string Category
		{
			get
			{
				if (this.category == null)
				{
					this.category = ((CategoryAttribute)this.Attributes[typeof(CategoryAttribute)]).Category;
				}
				return this.category;
			}
		}

		/// <summary>Возвращает описание члена, как указано атрибутом <see cref="T:System.ComponentModel.DescriptionAttribute" />.</summary>
		/// <returns>Описание члена. Если атрибут <see cref="T:System.ComponentModel.DescriptionAttribute" /> отсутствует, для свойства устанавливается значение по умолчанию, равное пустой строке ("").</returns>
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x00073F35 File Offset: 0x00072135
		public virtual string Description
		{
			get
			{
				if (this.description == null)
				{
					this.description = ((DescriptionAttribute)this.Attributes[typeof(DescriptionAttribute)]).Description;
				}
				return this.description;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли член отображаемым в обозревателе, как определено в атрибуте <see cref="T:System.ComponentModel.BrowsableAttribute" />.</summary>
		/// <returns>Значение <see langword="true" />, если член является отображаемым; в противном случае — значение <see langword="false" />. Если объект <see cref="T:System.ComponentModel.BrowsableAttribute" /> отсутствует, устанавливается значение свойства по умолчанию, равное <see langword="true" />.</returns>
		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x00073F6A File Offset: 0x0007216A
		public virtual bool IsBrowsable
		{
			get
			{
				return ((BrowsableAttribute)this.Attributes[typeof(BrowsableAttribute)]).Browsable;
			}
		}

		/// <summary>Возвращает имя члена.</summary>
		/// <returns>Имя элемента.</returns>
		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00073F8B File Offset: 0x0007218B
		public virtual string Name
		{
			get
			{
				if (this.name == null)
				{
					return "";
				}
				return this.name;
			}
		}

		/// <summary>Возвращает хэш-код для имени члена, как определено в методе <see cref="M:System.String.GetHashCode" />.</summary>
		/// <returns>Хэш-код для имени члена.</returns>
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x00073FA1 File Offset: 0x000721A1
		protected virtual int NameHashCode
		{
			get
			{
				return this.nameHash;
			}
		}

		/// <summary>Возвращает значение, показывающее, должен ли этот член устанавливаться только во время разработки, как указано атрибутом <see cref="T:System.ComponentModel.DesignOnlyAttribute" />.</summary>
		/// <returns>Значение <see langword="true" />, если член должен устанавливаться только во время разработки; значение <see langword="false" />, если возможна установка члена во время выполнения.</returns>
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x00073FA9 File Offset: 0x000721A9
		public virtual bool DesignTimeOnly
		{
			get
			{
				return DesignOnlyAttribute.Yes.Equals(this.Attributes[typeof(DesignOnlyAttribute)]);
			}
		}

		/// <summary>Возвращает имя, которое может быть отражено в окне, например в окне "Свойства".</summary>
		/// <returns>Имя, отображаемое для члена.</returns>
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x00073FCC File Offset: 0x000721CC
		public virtual string DisplayName
		{
			get
			{
				DisplayNameAttribute displayNameAttribute = this.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;
				if (displayNameAttribute == null || displayNameAttribute.IsDefaultAttribute())
				{
					return this.displayName;
				}
				return displayNameAttribute.DisplayName;
			}
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0007400C File Offset: 0x0007220C
		private void CheckAttributesValid()
		{
			if (this.attributesFiltered && this.metadataVersion != TypeDescriptor.MetadataVersion)
			{
				this.attributesFilled = false;
				this.attributesFiltered = false;
				this.attributeCollection = null;
			}
		}

		/// <summary>Создает коллекцию атрибутов, используя массив атрибутов, переданный в конструктор.</summary>
		/// <returns>Новый объект <see cref="T:System.ComponentModel.AttributeCollection" />, содержащий атрибуты <see cref="P:System.ComponentModel.MemberDescriptor.AttributeArray" /></returns>
		// Token: 0x060021E4 RID: 8676 RVA: 0x00074038 File Offset: 0x00072238
		protected virtual AttributeCollection CreateAttributeCollection()
		{
			return new AttributeCollection(this.AttributeArray);
		}

		/// <summary>Сравнивает этот экземпляр с заданным объектом, проверяя, являются ли они эквивалентными.</summary>
		/// <param name="obj">Объект, сравниваемый с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если объекты эквивалентны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060021E5 RID: 8677 RVA: 0x00074048 File Offset: 0x00072248
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != base.GetType())
			{
				return false;
			}
			MemberDescriptor memberDescriptor = (MemberDescriptor)obj;
			this.FilterAttributesIfNeeded();
			memberDescriptor.FilterAttributesIfNeeded();
			if (memberDescriptor.nameHash != this.nameHash)
			{
				return false;
			}
			if (memberDescriptor.category == null != (this.category == null) || (this.category != null && !memberDescriptor.category.Equals(this.category)))
			{
				return false;
			}
			if (!LocalAppContextSwitches.MemberDescriptorEqualsReturnsFalseIfEquivalent)
			{
				if (memberDescriptor.description == null != (this.description == null) || (this.description != null && !memberDescriptor.description.Equals(this.description)))
				{
					return false;
				}
			}
			else if (memberDescriptor.description == null != (this.description == null) || (this.description != null && !memberDescriptor.category.Equals(this.description)))
			{
				return false;
			}
			if (memberDescriptor.attributes == null != (this.attributes == null))
			{
				return false;
			}
			bool result = true;
			if (this.attributes != null)
			{
				if (this.attributes.Length != memberDescriptor.attributes.Length)
				{
					return false;
				}
				for (int i = 0; i < this.attributes.Length; i++)
				{
					if (!this.attributes[i].Equals(memberDescriptor.attributes[i]))
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}

		/// <summary>При переопределении в производном классе добавляет атрибуты наследуемого класса к указанному списку атрибутов в родительском классе.</summary>
		/// <param name="attributeList">Интерфейс <see cref="T:System.Collections.IList" />, содержащий список атрибутов в родительском классе. Первоначально он пуст.</param>
		// Token: 0x060021E6 RID: 8678 RVA: 0x00074198 File Offset: 0x00072398
		protected virtual void FillAttributes(IList attributeList)
		{
			if (this.originalAttributes != null)
			{
				foreach (Attribute value in this.originalAttributes)
				{
					attributeList.Add(value);
				}
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000741D0 File Offset: 0x000723D0
		private void FilterAttributesIfNeeded()
		{
			if (!this.attributesFiltered)
			{
				IList list;
				if (!this.attributesFilled)
				{
					list = new ArrayList();
					try
					{
						this.FillAttributes(list);
						goto IL_34;
					}
					catch (ThreadAbortException)
					{
						throw;
					}
					catch (Exception)
					{
						goto IL_34;
					}
				}
				list = new ArrayList(this.attributes);
				IL_34:
				Hashtable hashtable = new Hashtable(list.Count);
				foreach (object obj in list)
				{
					Attribute attribute = (Attribute)obj;
					hashtable[attribute.TypeId] = attribute;
				}
				Attribute[] array = new Attribute[hashtable.Values.Count];
				hashtable.Values.CopyTo(array, 0);
				object obj2 = this.lockCookie;
				lock (obj2)
				{
					this.attributes = array;
					this.attributesFiltered = true;
					this.attributesFilled = true;
					this.metadataVersion = TypeDescriptor.MetadataVersion;
				}
			}
		}

		/// <summary>Находит данный метод, используя отражение, выполняя поиск только для открытых методов.</summary>
		/// <param name="componentClass">Компонент, содержащий метод.</param>
		/// <param name="name">Имя искомого метода.</param>
		/// <param name="args">Массив параметров для метода, используемый для выбора между перегруженными методами.</param>
		/// <param name="returnType">Тип, возвращаемый для метода.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, или <see langword="null" />, если метод не найден.</returns>
		// Token: 0x060021E8 RID: 8680 RVA: 0x000742F4 File Offset: 0x000724F4
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType)
		{
			return MemberDescriptor.FindMethod(componentClass, name, args, returnType, true);
		}

		/// <summary>Находит данный метод, используя отражение, с возможностью поиска только открытых методов.</summary>
		/// <param name="componentClass">Компонент, содержащий метод.</param>
		/// <param name="name">Имя искомого метода.</param>
		/// <param name="args">Массив параметров для метода, используемый для выбора между перегруженными методами.</param>
		/// <param name="returnType">Тип, возвращаемый для метода.</param>
		/// <param name="publicOnly">Указывает, ограничен ли поиск только открытыми методами.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, или <see langword="null" />, если метод не найден.</returns>
		// Token: 0x060021E9 RID: 8681 RVA: 0x00074300 File Offset: 0x00072500
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly)
		{
			MethodInfo methodInfo;
			if (publicOnly)
			{
				methodInfo = componentClass.GetMethod(name, args);
			}
			else
			{
				methodInfo = componentClass.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, args, null);
			}
			if (methodInfo != null && !methodInfo.ReturnType.IsEquivalentTo(returnType))
			{
				methodInfo = null;
			}
			return methodInfo;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.MemberDescriptor" />.</returns>
		// Token: 0x060021EA RID: 8682 RVA: 0x00073FA1 File Offset: 0x000721A1
		public override int GetHashCode()
		{
			return this.nameHash;
		}

		/// <summary>Возвращает объект, который должен использоваться при вызове членов.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" /> адресата вызова.</param>
		/// <param name="instance">Возможный адресат вызова.</param>
		/// <returns>Объект, используемый при вызове членов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="instance" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060021EB RID: 8683 RVA: 0x00074345 File Offset: 0x00072545
		protected virtual object GetInvocationTarget(Type type, object instance)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			return TypeDescriptor.GetAssociation(type, instance);
		}

		/// <summary>Возвращает узел компонента для заданного компонента.</summary>
		/// <param name="component">Компонент, узел для которого нужно найти.</param>
		/// <returns>узел компонента или значение <see langword="null" />, если узел не существует.</returns>
		// Token: 0x060021EC RID: 8684 RVA: 0x00074370 File Offset: 0x00072570
		protected static ISite GetSite(object component)
		{
			if (!(component is IComponent))
			{
				return null;
			}
			return ((IComponent)component).Site;
		}

		/// <summary>Возвращает компонент, для которого вызывается метод.</summary>
		/// <param name="componentClass">Объект <see cref="T:System.Type" />, представляющий тип компонента, с которым связан этот дескриптор <see cref="T:System.ComponentModel.MemberDescriptor" />. Например, если этот дескриптор <see cref="T:System.ComponentModel.MemberDescriptor" /> описывает свойство, данный параметр должен быть классом, для которого объявлено это свойство.</param>
		/// <param name="component">Экземпляр вызываемого объекта.</param>
		/// <returns>Экземпляр вызываемого компонента. Этот метод возвращает визуальный конструктор, если свойство связано с визуальным конструктором.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="componentClass" /> или <paramref name="component" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060021ED RID: 8685 RVA: 0x00074387 File Offset: 0x00072587
		[Obsolete("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected static object GetInvokee(Type componentClass, object component)
		{
			if (componentClass == null)
			{
				throw new ArgumentNullException("componentClass");
			}
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			return TypeDescriptor.GetAssociation(componentClass, component);
		}

		// Token: 0x0400102B RID: 4139
		private string name;

		// Token: 0x0400102C RID: 4140
		private string displayName;

		// Token: 0x0400102D RID: 4141
		private int nameHash;

		// Token: 0x0400102E RID: 4142
		private AttributeCollection attributeCollection;

		// Token: 0x0400102F RID: 4143
		private Attribute[] attributes;

		// Token: 0x04001030 RID: 4144
		private Attribute[] originalAttributes;

		// Token: 0x04001031 RID: 4145
		private bool attributesFiltered;

		// Token: 0x04001032 RID: 4146
		private bool attributesFilled;

		// Token: 0x04001033 RID: 4147
		private int metadataVersion;

		// Token: 0x04001034 RID: 4148
		private string category;

		// Token: 0x04001035 RID: 4149
		private string description;

		// Token: 0x04001036 RID: 4150
		private object lockCookie;
	}
}
