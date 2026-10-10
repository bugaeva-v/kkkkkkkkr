using System;
using System.Collections.Specialized;
using System.Security.Permissions;

namespace System.Configuration
{
	/// <summary>Обеспечивает сохраняемость для классов параметров приложений.</summary>
	// Token: 0x020001B8 RID: 440
	public class LocalFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.LocalFileSettingsProvider" />.</summary>
		// Token: 0x06000B98 RID: 2968 RVA: 0x0003133F File Offset: 0x0002F53F
		public LocalFileSettingsProvider()
		{
			this.impl = new CustomizableFileSettingsProvider();
		}

		/// <summary>Возвращает значение именованного свойства параметров для предыдущей версии того же приложения.</summary>
		/// <param name="context">Объект <see cref="T:System.Configuration.SettingsContext" />, описывающий, где используются свойства параметров приложения.</param>
		/// <param name="property">
		///   <see cref="T:System.Configuration.SettingsProperty" />, значение которого должно быть возвращено.</param>
		/// <returns>Объект <see cref="T:System.Configuration.SettingsPropertyValue" />, представляющий параметр приложения, если он найдены; в противном случае — <see langword="null" />.</returns>
		// Token: 0x06000B99 RID: 2969 RVA: 0x00031352 File Offset: 0x0002F552
		[MonoTODO]
		[FileIOPermission(SecurityAction.Assert, AllFiles = (FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery))]
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
		public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property)
		{
			return this.impl.GetPreviousVersion(context, property);
		}

		/// <summary>Возвращает коллекцию значений свойств параметров для указанного экземпляра приложения и группу свойств параметров.</summary>
		/// <param name="context">Объект <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		/// <param name="properties">Объект <see cref="T:System.Configuration.SettingsPropertyCollection" />, содержащий группу свойств параметров, значения которых необходимо извлечь.</param>
		/// <returns>Объект <see cref="T:System.Configuration.SettingsPropertyValueCollection" />, содержащий значения для указанной группы свойств параметров.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Был обнаружен параметр на уровне пользователя, но текущая конфигурация поддерживает только параметры на уровне приложения.</exception>
		// Token: 0x06000B9A RID: 2970 RVA: 0x00031361 File Offset: 0x0002F561
		[MonoTODO]
		public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties)
		{
			return this.impl.GetPropertyValues(context, properties);
		}

		/// <summary>Инициализирует этот поставщик.</summary>
		/// <param name="name">Понятное имя поставщика.</param>
		/// <param name="values">Коллекция пар "имя-значение", представляющих атрибуты поставщика, указанные в конфигурации для этого поставщика.</param>
		// Token: 0x06000B9B RID: 2971 RVA: 0x00031370 File Offset: 0x0002F570
		public override void Initialize(string name, NameValueCollection values)
		{
			if (name == null)
			{
				name = "LocalFileSettingsProvider";
			}
			if (values != null)
			{
				this.impl.ApplicationName = values["applicationName"];
			}
			base.Initialize(name, values);
		}

		/// <summary>Сбрасывает все свойства параметров приложения, связанные с указанным приложением, к значениям по умолчанию.</summary>
		/// <param name="context">Объект <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Был обнаружен параметр на уровне пользователя, но текущая конфигурация поддерживает только параметры на уровне приложения.</exception>
		// Token: 0x06000B9C RID: 2972 RVA: 0x0003139D File Offset: 0x0002F59D
		[MonoTODO]
		public void Reset(SettingsContext context)
		{
			this.impl.Reset(context);
		}

		/// <summary>Задает значения указанной группы параметров свойств.</summary>
		/// <param name="context">Объект <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		/// <param name="values">Объект <see cref="T:System.Configuration.SettingsPropertyValueCollection" />, представляющий группу параметров свойств, которые необходимо задать.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Был обнаружен параметр на уровне пользователя, но текущая конфигурация поддерживает только параметры на уровне приложения.  
		///
		/// или - 
		/// Произошла общая ошибка при сохранении параметров в файле конфигурации.</exception>
		// Token: 0x06000B9D RID: 2973 RVA: 0x000313AB File Offset: 0x0002F5AB
		[MonoTODO]
		public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
		{
			this.impl.SetPropertyValues(context, values);
		}

		/// <summary>Выполняет попытку переместить предыдущие параметры на уровне пользователя из предыдущих версий того же приложения.</summary>
		/// <param name="context">Объект <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		/// <param name="properties">
		///   <see cref="T:System.Configuration.SettingsPropertyCollection" />, содержащий группу свойств параметров, значения которых необходимо извлечь.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Был обнаружен параметр на уровне пользователя, но текущая конфигурация поддерживает только параметры на уровне приложения.  
		///
		/// или - 
		/// Не удалось получить доступ к предыдущей версии файла конфигурации.</exception>
		// Token: 0x06000B9E RID: 2974 RVA: 0x000313BA File Offset: 0x0002F5BA
		[MonoTODO]
		public void Upgrade(SettingsContext context, SettingsPropertyCollection properties)
		{
			this.impl.Upgrade(context, properties);
		}

		/// <summary>Возвращает или задает имя работающего в данный момент приложения.</summary>
		/// <returns>Имя строки, поддерживающей монитор приложения.</returns>
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x000313C9 File Offset: 0x0002F5C9
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000313D6 File Offset: 0x0002F5D6
		public override string ApplicationName
		{
			get
			{
				return this.impl.ApplicationName;
			}
			set
			{
				this.impl.ApplicationName = value;
			}
		}

		// Token: 0x04000785 RID: 1925
		private CustomizableFileSettingsProvider impl;
	}
}
