using System;
using System.Collections;
using Unity;

namespace System.Configuration
{
	/// <summary>Содержит метаинформацию об индивидуальном элементе в пределах конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x0200003F RID: 63
	public sealed class ElementInformation
	{
		// Token: 0x06000227 RID: 551 RVA: 0x000077AC File Offset: 0x000059AC
		internal ElementInformation(ConfigurationElement owner, PropertyInformation propertyInfo)
		{
			this.propertyInfo = propertyInfo;
			this.owner = owner;
			this.properties = new PropertyInformationCollection();
			foreach (object obj in owner.Properties)
			{
				ConfigurationProperty property = (ConfigurationProperty)obj;
				this.properties.Add(new PropertyInformation(owner, property));
			}
		}

		/// <summary>Возвращает ошибки для связанного элемента и подэлементов.</summary>
		/// <returns>Коллекция, содержащая ошибки для связанного элемента и подэлементов.</returns>
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000371B File Offset: 0x0000191B
		[MonoTODO]
		public ICollection Errors
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли связанный объект <see cref="T:System.Configuration.ConfigurationElement" /> коллекцией <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <returns>
		///   <see langword="true" />, если связанный объект <see cref="T:System.Configuration.ConfigurationElement" /> является коллекцией <see cref="T:System.Configuration.ConfigurationElementCollection" />, иначе <see langword="false" />.</returns>
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00007830 File Offset: 0x00005A30
		public bool IsCollection
		{
			get
			{
				return this.owner is ConfigurationElementCollection;
			}
		}

		/// <summary>Возвращает значение, определяющее, можно ли изменять связанный объект <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>
		///   <see langword="true" />, если связанный объект <see cref="T:System.Configuration.ConfigurationElement" /> не может быть изменен, иначе <see langword="false" />.</returns>
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00007840 File Offset: 0x00005A40
		public bool IsLocked
		{
			get
			{
				return this.propertyInfo != null && this.propertyInfo.IsLocked;
			}
		}

		/// <summary>Возвращает значение, указывающее, находится ли связанный объект <see cref="T:System.Configuration.ConfigurationElement" /> в файле конфигурации.</summary>
		/// <returns>
		///   <see langword="true" />, если связанный объект <see cref="T:System.Configuration.ConfigurationElement" /> находится в файле конфигурации, в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00007857 File Offset: 0x00005A57
		[MonoTODO("Support multiple levels of inheritance")]
		public bool IsPresent
		{
			get
			{
				return this.owner.IsElementPresent;
			}
		}

		/// <summary>Возвращает номер строки в файле конфигурации, в котором определен связанный объект <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>Номер строки в файле конфигурации, в котором определен связанный объект <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00007864 File Offset: 0x00005A64
		public int LineNumber
		{
			get
			{
				if (this.propertyInfo == null)
				{
					return 0;
				}
				return this.propertyInfo.LineNumber;
			}
		}

		/// <summary>Возвращает исходный файл, в котором порожден связанный объект <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>Исходный файл, в котором порожден связанный объект <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000787B File Offset: 0x00005A7B
		public string Source
		{
			get
			{
				if (this.propertyInfo == null)
				{
					return null;
				}
				return this.propertyInfo.Source;
			}
		}

		/// <summary>Возвращает тип связанного объекта <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>Тип связанного объекта <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00007892 File Offset: 0x00005A92
		public Type Type
		{
			get
			{
				if (this.propertyInfo == null)
				{
					return this.owner.GetType();
				}
				return this.propertyInfo.Type;
			}
		}

		/// <summary>Возвращает объект, использовавшийся для проверки связанного объекта <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>Объект, использовавшийся для проверки связанного объекта <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000078B3 File Offset: 0x00005AB3
		public ConfigurationValidatorBase Validator
		{
			get
			{
				if (this.propertyInfo == null)
				{
					return new DefaultValidator();
				}
				return this.propertyInfo.Validator;
			}
		}

		/// <summary>Возвращает коллекцию свойств <see cref="T:System.Configuration.PropertyInformationCollection" /> в связанном объекте <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>Коллекция свойств <see cref="T:System.Configuration.PropertyInformationCollection" /> в связанном объекте <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000078CE File Offset: 0x00005ACE
		public PropertyInformationCollection Properties
		{
			get
			{
				return this.properties;
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000078D8 File Offset: 0x00005AD8
		internal void Reset(ElementInformation parentInfo)
		{
			foreach (object obj in this.Properties)
			{
				PropertyInformation propertyInformation = (PropertyInformation)obj;
				PropertyInformation parentProperty = parentInfo.Properties[propertyInformation.Name];
				propertyInformation.Reset(parentProperty);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00003518 File Offset: 0x00001718
		internal ElementInformation()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040000E2 RID: 226
		private readonly PropertyInformation propertyInfo;

		// Token: 0x040000E3 RID: 227
		private readonly ConfigurationElement owner;

		// Token: 0x040000E4 RID: 228
		private readonly PropertyInformationCollection properties;
	}
}
