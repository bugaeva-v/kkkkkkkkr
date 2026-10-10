using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Предоставляет краткое описание свойства в классе.</summary>
	// Token: 0x020003DF RID: 991
	public abstract class PropertyDescriptor : MemberDescriptor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyDescriptor" />, используя заданные имя и атрибуты.</summary>
		/// <param name="name">Имя свойства.</param>
		/// <param name="attrs">Массив типа <see cref="T:System.Attribute" />, содержащий атрибуты свойства.</param>
		// Token: 0x0600204C RID: 8268 RVA: 0x0006C2CB File Offset: 0x0006A4CB
		protected PropertyDescriptor(string name, Attribute[] attrs) : base(name, attrs)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyDescriptor" />, используя имя и атрибуты заданного объекта <see cref="T:System.ComponentModel.MemberDescriptor" />.</summary>
		/// <param name="descr">Дескриптор <see cref="T:System.ComponentModel.MemberDescriptor" />, содержащий имя свойства и его атрибуты.</param>
		// Token: 0x0600204D RID: 8269 RVA: 0x0006C2D5 File Offset: 0x0006A4D5
		protected PropertyDescriptor(MemberDescriptor descr) : base(descr)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyDescriptor" />, используя имя в заданном дескрипторе <see cref="T:System.ComponentModel.MemberDescriptor" /> и атрибуты как в дескрипторе <see cref="T:System.ComponentModel.MemberDescriptor" />, так и в массиве <see cref="T:System.Attribute" />.</summary>
		/// <param name="descr">Класс <see cref="T:System.ComponentModel.MemberDescriptor" />, содержащий имя члена и его атрибуты.</param>
		/// <param name="attrs">Массив <see cref="T:System.Attribute" />, содержащий атрибуты, которые нужно связать со свойством.</param>
		// Token: 0x0600204E RID: 8270 RVA: 0x0006C2DE File Offset: 0x0006A4DE
		protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs) : base(descr, attrs)
		{
		}

		/// <summary>При переопределении в производном классе возвращает тип компонента, с которым связано это свойство.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> представляющий тип компонента, с которым связано это свойство. При вызове методов <see cref="M:System.ComponentModel.PropertyDescriptor.GetValue(System.Object)" /> или <see cref="M:System.ComponentModel.PropertyDescriptor.SetValue(System.Object,System.Object)" /> заданный объект может быть экземпляром этого типа.</returns>
		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600204F RID: 8271
		public abstract Type ComponentType { get; }

		/// <summary>Возвращает преобразователь типов для этого свойства.</summary>
		/// <returns>Преобразователь <see cref="T:System.ComponentModel.TypeConverter" />, используемый для преобразования типа <see cref="T:System.Type" /> этого свойства.</returns>
		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x0006FD18 File Offset: 0x0006DF18
		public virtual TypeConverter Converter
		{
			get
			{
				AttributeCollection attributes = this.Attributes;
				if (this._converter == null)
				{
					TypeConverterAttribute typeConverterAttribute = (TypeConverterAttribute)attributes[typeof(TypeConverterAttribute)];
					if (typeConverterAttribute.ConverterTypeName != null && typeConverterAttribute.ConverterTypeName.Length > 0)
					{
						Type typeFromName = this.GetTypeFromName(typeConverterAttribute.ConverterTypeName);
						if (typeFromName != null && typeof(TypeConverter).IsAssignableFrom(typeFromName))
						{
							this._converter = (TypeConverter)this.CreateInstance(typeFromName);
						}
					}
					if (this._converter == null)
					{
						this._converter = TypeDescriptor.GetConverter(this.PropertyType);
					}
				}
				return this._converter;
			}
		}

		/// <summary>Возвращает значение, показывающее, должно ли быть локализовано это свойство (в соответствии с атрибутом <see cref="T:System.ComponentModel.LocalizableAttribute" />).</summary>
		/// <returns>Значение <see langword="true" />, если член помечен атрибутом <see cref="T:System.ComponentModel.LocalizableAttribute" />, равным <see langword="true" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0006FDB9 File Offset: 0x0006DFB9
		public virtual bool IsLocalizable
		{
			get
			{
				return LocalizableAttribute.Yes.Equals(this.Attributes[typeof(LocalizableAttribute)]);
			}
		}

		/// <summary>При переопределении в производном классе возвращает значение, показывающее, доступно ли свойство только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если свойство доступно только для чтения, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002052 RID: 8274
		public abstract bool IsReadOnly { get; }

		/// <summary>Возвращает значение, показывающее, должно ли это свойство быть сериализируемым (в соответствии с атрибутом <see cref="T:System.ComponentModel.DesignerSerializationVisibilityAttribute" />).</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.ComponentModel.DesignerSerializationVisibility" />, определяющее, должно ли это свойство быть сериализируемым.</returns>
		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x0006FDDA File Offset: 0x0006DFDA
		public DesignerSerializationVisibility SerializationVisibility
		{
			get
			{
				return ((DesignerSerializationVisibilityAttribute)this.Attributes[typeof(DesignerSerializationVisibilityAttribute)]).Visibility;
			}
		}

		/// <summary>При переопределении в производном классе возвращает тип свойства.</summary>
		/// <returns>Тип <see cref="T:System.Type" />, представляющий тип свойства.</returns>
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002054 RID: 8276
		public abstract Type PropertyType { get; }

		/// <summary>Позволяет уведомить другие объекты об изменении этого свойства.</summary>
		/// <param name="component">Компонент, для которого нужно добавить обработчик.</param>
		/// <param name="handler">Делегат, добавляемый в качестве прослушивателя.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="component" /> или <paramref name="handler" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002055 RID: 8277 RVA: 0x0006FDFC File Offset: 0x0006DFFC
		public virtual void AddValueChanged(object component, EventHandler handler)
		{
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			if (this._valueChangedHandlers == null)
			{
				this._valueChangedHandlers = new Hashtable();
			}
			EventHandler a = (EventHandler)this._valueChangedHandlers[component];
			this._valueChangedHandlers[component] = Delegate.Combine(a, handler);
		}

		/// <summary>При переопределении в производном классе возвращает значение, показывающее, изменяется ли значение объекта при его сбросе.</summary>
		/// <param name="component">Компонент для проверки на возможность сброса.</param>
		/// <returns>Значение <see langword="true" />, если сброс компонента изменяет его значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002056 RID: 8278
		public abstract bool CanResetValue(object component);

		/// <summary>Сравнивает данный объект с другим, проверяя их эквивалентность.</summary>
		/// <param name="obj">Объект, который требуется сравнить с данным объектом <see cref="T:System.ComponentModel.PropertyDescriptor" />.</param>
		/// <returns>Значение <see langword="true" />, если значения эквивалентны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002057 RID: 8279 RVA: 0x0006FE60 File Offset: 0x0006E060
		public override bool Equals(object obj)
		{
			try
			{
				if (obj == this)
				{
					return true;
				}
				if (obj == null)
				{
					return false;
				}
				PropertyDescriptor propertyDescriptor = obj as PropertyDescriptor;
				if (propertyDescriptor != null && propertyDescriptor.NameHashCode == this.NameHashCode && propertyDescriptor.PropertyType == this.PropertyType && propertyDescriptor.Name.Equals(this.Name))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		/// <summary>Создает экземпляр заданного типа.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, представляющий создаваемый тип.</param>
		/// <returns>Новый экземпляр типа.</returns>
		// Token: 0x06002058 RID: 8280 RVA: 0x0006FED8 File Offset: 0x0006E0D8
		protected object CreateInstance(Type type)
		{
			Type[] array = new Type[]
			{
				typeof(Type)
			};
			if (type.GetConstructor(array) != null)
			{
				return TypeDescriptor.CreateInstance(null, type, array, new object[]
				{
					this.PropertyType
				});
			}
			return TypeDescriptor.CreateInstance(null, type, null, null);
		}

		/// <summary>Добавляет атрибуты дескриптора <see cref="T:System.ComponentModel.PropertyDescriptor" /> в заданный список атрибутов родительского класса.</summary>
		/// <param name="attributeList">Интерфейс <see cref="T:System.Collections.IList" />, содержащий список атрибутов в родительском классе. Первоначально он пуст.</param>
		// Token: 0x06002059 RID: 8281 RVA: 0x0006FF29 File Offset: 0x0006E129
		protected override void FillAttributes(IList attributeList)
		{
			this._converter = null;
			this._editors = null;
			this._editorTypes = null;
			this._editorCount = 0;
			base.FillAttributes(attributeList);
		}

		/// <summary>По умолчанию возвращается значение <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />.</summary>
		/// <returns>Коллекция дескриптора свойств.</returns>
		// Token: 0x0600205A RID: 8282 RVA: 0x0006FF4E File Offset: 0x0006E14E
		public PropertyDescriptorCollection GetChildProperties()
		{
			return this.GetChildProperties(null, null);
		}

		/// <summary>Возвращает <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, используя заданный массив атрибутов как фильтр.</summary>
		/// <param name="filter">Массив типа <see cref="T:System.Attribute" />, используемый как фильтр.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, соответствующими заданным атрибутам.</returns>
		// Token: 0x0600205B RID: 8283 RVA: 0x0006FF58 File Offset: 0x0006E158
		public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
		{
			return this.GetChildProperties(null, filter);
		}

		/// <summary>Возвращает <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> для данного объекта.</summary>
		/// <param name="instance">Компонент, для которого требуется получить свойства.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами данного компонента.</returns>
		// Token: 0x0600205C RID: 8284 RVA: 0x0006FF62 File Offset: 0x0006E162
		public PropertyDescriptorCollection GetChildProperties(object instance)
		{
			return this.GetChildProperties(instance, null);
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> для данного объекта, используя заданный массив атрибутов как фильтр.</summary>
		/// <param name="instance">Компонент, для которого требуется получить свойства.</param>
		/// <param name="filter">Массив типа <see cref="T:System.Attribute" />, используемый как фильтр.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, соответствующими заданным атрибутам для заданного компонента.</returns>
		// Token: 0x0600205D RID: 8285 RVA: 0x0006FF6C File Offset: 0x0006E16C
		public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
		{
			if (instance == null)
			{
				return TypeDescriptor.GetProperties(this.PropertyType, filter);
			}
			return TypeDescriptor.GetProperties(instance, filter);
		}

		/// <summary>Возвращает редактор заданного типа.</summary>
		/// <param name="editorBaseType">Базовый тип редактора, применяемый, чтобы различать многочисленные редакторы, которые поддерживает свойство.</param>
		/// <returns>Экземпляр запрошенного типа редактора или <see langword="null" />, если редактор не найден.</returns>
		// Token: 0x0600205E RID: 8286 RVA: 0x0006FF88 File Offset: 0x0006E188
		public virtual object GetEditor(Type editorBaseType)
		{
			object obj = null;
			AttributeCollection attributes = this.Attributes;
			if (this._editorTypes != null)
			{
				for (int i = 0; i < this._editorCount; i++)
				{
					if (this._editorTypes[i] == editorBaseType)
					{
						return this._editors[i];
					}
				}
			}
			if (obj == null)
			{
				for (int j = 0; j < attributes.Count; j++)
				{
					EditorAttribute editorAttribute = attributes[j] as EditorAttribute;
					if (editorAttribute != null)
					{
						Type typeFromName = this.GetTypeFromName(editorAttribute.EditorBaseTypeName);
						if (editorBaseType == typeFromName)
						{
							Type typeFromName2 = this.GetTypeFromName(editorAttribute.EditorTypeName);
							if (typeFromName2 != null)
							{
								obj = this.CreateInstance(typeFromName2);
								break;
							}
						}
					}
				}
				if (obj == null)
				{
					obj = TypeDescriptor.GetEditor(this.PropertyType, editorBaseType);
				}
				if (this._editorTypes == null)
				{
					this._editorTypes = new Type[5];
					this._editors = new object[5];
				}
				if (this._editorCount >= this._editorTypes.Length)
				{
					Type[] array = new Type[this._editorTypes.Length * 2];
					object[] array2 = new object[this._editors.Length * 2];
					Array.Copy(this._editorTypes, array, this._editorTypes.Length);
					Array.Copy(this._editors, array2, this._editors.Length);
					this._editorTypes = array;
					this._editors = array2;
				}
				this._editorTypes[this._editorCount] = editorBaseType;
				object[] editors = this._editors;
				int editorCount = this._editorCount;
				this._editorCount = editorCount + 1;
				editors[editorCount] = obj;
			}
			return obj;
		}

		/// <summary>Возвращает хэш-код для этого объекта.</summary>
		/// <returns>Хэш-код для этого объекта.</returns>
		// Token: 0x0600205F RID: 8287 RVA: 0x000700FD File Offset: 0x0006E2FD
		public override int GetHashCode()
		{
			return this.NameHashCode ^ this.PropertyType.GetHashCode();
		}

		/// <summary>Этот метод возвращает объект, которой должен использоваться при вызове членов.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" /> адресата вызова.</param>
		/// <param name="instance">Возможный адресат вызова.</param>
		/// <returns>Объект <see cref="T:System.Object" />, который должен использоваться при вызове членов.</returns>
		// Token: 0x06002060 RID: 8288 RVA: 0x00070114 File Offset: 0x0006E314
		protected override object GetInvocationTarget(Type type, object instance)
		{
			object obj = base.GetInvocationTarget(type, instance);
			ICustomTypeDescriptor customTypeDescriptor = obj as ICustomTypeDescriptor;
			if (customTypeDescriptor != null)
			{
				obj = customTypeDescriptor.GetPropertyOwner(this);
			}
			return obj;
		}

		/// <summary>Возвращает тип, используя его имя.</summary>
		/// <param name="typeName">Имя возвращаемого типа с указанием сборки.</param>
		/// <returns>Тип <see cref="T:System.Type" />, совпадающий с данным именем типа, или <see langword="null" />, если совпадение не найдено.</returns>
		// Token: 0x06002061 RID: 8289 RVA: 0x00070140 File Offset: 0x0006E340
		protected Type GetTypeFromName(string typeName)
		{
			if (typeName == null || typeName.Length == 0)
			{
				return null;
			}
			Type type = Type.GetType(typeName);
			Type type2 = null;
			if (this.ComponentType != null && (type == null || this.ComponentType.Assembly.FullName.Equals(type.Assembly.FullName)))
			{
				int num = typeName.IndexOf(',');
				if (num != -1)
				{
					typeName = typeName.Substring(0, num);
				}
				type2 = this.ComponentType.Assembly.GetType(typeName);
			}
			return type2 ?? type;
		}

		/// <summary>В случае переопределения в производном классе, возвращает текущее значение свойства компонента.</summary>
		/// <param name="component">Компонент с свойством, для которого нужно получить значение.</param>
		/// <returns>Значение свойства для данного компонента.</returns>
		// Token: 0x06002062 RID: 8290
		public abstract object GetValue(object component);

		/// <summary>Вызывает реализованное вами событие <c>ValueChanged</c>.</summary>
		/// <param name="component">Объект, вызывающий событие.</param>
		/// <param name="e">Объект класса <see cref="T:System.EventArgs" />, содержащий данные события.</param>
		// Token: 0x06002063 RID: 8291 RVA: 0x000701CB File Offset: 0x0006E3CB
		protected virtual void OnValueChanged(object component, EventArgs e)
		{
			if (component != null)
			{
				Hashtable valueChangedHandlers = this._valueChangedHandlers;
				EventHandler eventHandler = (EventHandler)((valueChangedHandlers != null) ? valueChangedHandlers[component] : null);
				if (eventHandler == null)
				{
					return;
				}
				eventHandler(component, e);
			}
		}

		/// <summary>Позволяет уведомить другие объекты об изменении этого свойства.</summary>
		/// <param name="component">Компонент, для которого нужно удалить обработчик.</param>
		/// <param name="handler">Делегат, удаляемый как прослушиватель.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="component" /> или <paramref name="handler" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002064 RID: 8292 RVA: 0x000701F4 File Offset: 0x0006E3F4
		public virtual void RemoveValueChanged(object component, EventHandler handler)
		{
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			if (this._valueChangedHandlers != null)
			{
				EventHandler eventHandler = (EventHandler)this._valueChangedHandlers[component];
				eventHandler = (EventHandler)Delegate.Remove(eventHandler, handler);
				if (eventHandler != null)
				{
					this._valueChangedHandlers[component] = eventHandler;
					return;
				}
				this._valueChangedHandlers.Remove(component);
			}
		}

		/// <summary>Возвращает текущий набор обработчиков событий <c>ValueChanged</c> для конкретного компонента.</summary>
		/// <param name="component">Компонент, для которого возвращаются обработчики событий.</param>
		/// <returns>Объединенный многоадресный обработчик событий, или значение <see langword="null" />, если для компонента <paramref name="component" /> в данный момент не назначено ни одного обработчика событий.</returns>
		// Token: 0x06002065 RID: 8293 RVA: 0x00070261 File Offset: 0x0006E461
		protected internal EventHandler GetValueChangedHandler(object component)
		{
			if (component != null && this._valueChangedHandlers != null)
			{
				return (EventHandler)this._valueChangedHandlers[component];
			}
			return null;
		}

		/// <summary>В случае переопределения в производном классе, сбрасывает значение для этого свойства компонента в значение по умолчанию.</summary>
		/// <param name="component">Компонент со значением свойства, которое нужно сбросить в значение по умолчанию.</param>
		// Token: 0x06002066 RID: 8294
		public abstract void ResetValue(object component);

		/// <summary>При переопределении в производном классе устанавливает другое значение для компонента.</summary>
		/// <param name="component">Компонент со значением свойства, которое нужно установить.</param>
		/// <param name="value">Новое значение.</param>
		// Token: 0x06002067 RID: 8295
		public abstract void SetValue(object component, object value);

		/// <summary>При переопределении в производном классе определяет значение, показывающее, нужно ли сохранить данное значение свойства.</summary>
		/// <param name="component">Компонент со свойством, возможность сохранения которого нужно проверить.</param>
		/// <returns>Значение <see langword="true" />, если свойство следует сохранить; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002068 RID: 8296
		public abstract bool ShouldSerializeValue(object component);

		/// <summary>Возвращает значение, показывающее, могут ли уведомления об изменении значения инициироваться не из дескриптора свойств.</summary>
		/// <returns>Значение <see langword="true" />, если уведомления об изменении значений могут инициироваться вне дескриптора свойств; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool SupportsChangeEvents
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000FBF RID: 4031
		private TypeConverter _converter;

		// Token: 0x04000FC0 RID: 4032
		private Hashtable _valueChangedHandlers;

		// Token: 0x04000FC1 RID: 4033
		private object[] _editors;

		// Token: 0x04000FC2 RID: 4034
		private Type[] _editorTypes;

		// Token: 0x04000FC3 RID: 4035
		private int _editorCount;
	}
}
