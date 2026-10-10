using System;
using System.Security;
using System.Security.Permissions;

namespace System.Configuration
{
	/// <summary>Создает объект <see cref="T:System.Configuration.ConfigurationPermission" />, который предоставляет или отменяет помеченные целевые разрешения для доступа к разделам файлов конфигурации.</summary>
	// Token: 0x02000028 RID: 40
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class ConfigurationPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationPermissionAttribute" />.</summary>
		/// <param name="action">Мера безопасности, представленная элементом перечисления <see cref="T:System.Security.Permissions.SecurityAction" />. Определяет состояние разрешения атрибута.</param>
		// Token: 0x06000162 RID: 354 RVA: 0x000062BF File Offset: 0x000044BF
		public ConfigurationPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Создает и возвращает объект, реализующий интерфейс <see cref="T:System.Security.IPermission" />.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Security.IPermission" />.</returns>
		// Token: 0x06000163 RID: 355 RVA: 0x000062C8 File Offset: 0x000044C8
		public override IPermission CreatePermission()
		{
			return new ConfigurationPermission(base.Unrestricted ? PermissionState.Unrestricted : PermissionState.None);
		}
	}
}
