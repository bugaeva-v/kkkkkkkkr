using System;
using System.Security;
using System.Security.Permissions;

namespace System.Configuration
{
	/// <summary>Предоставляет структуру разрешения, которая позволяет методам или классам получать доступ к файлам конфигурации.</summary>
	// Token: 0x02000027 RID: 39
	[Serializable]
	public sealed class ConfigurationPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationPermission" />.</summary>
		/// <param name="state">Предоставляемый уровень разрешений.</param>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="state" /> не равно ни <see cref="F:System.Security.Permissions.PermissionState.Unrestricted" />, ни <see cref="F:System.Security.Permissions.PermissionState.None" />.</exception>
		// Token: 0x0600015A RID: 346 RVA: 0x00006114 File Offset: 0x00004314
		public ConfigurationPermission(PermissionState state)
		{
			this.unrestricted = (state == PermissionState.Unrestricted);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Configuration.ConfigurationPermission" /> с таким же уровнем разрешений.</summary>
		/// <returns>Новый объект <see cref="T:System.Configuration.ConfigurationPermission" /> с таким же уровнем разрешений.</returns>
		// Token: 0x0600015B RID: 347 RVA: 0x00006126 File Offset: 0x00004326
		public override IPermission Copy()
		{
			return new ConfigurationPermission(this.unrestricted ? PermissionState.Unrestricted : PermissionState.None);
		}

		/// <summary>Считывает значение состояния разрешения с XML.</summary>
		/// <param name="securityElement">Элемент конфигурации, с которого считывается состояние разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="securityElement" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение атрибута <see langword="unrestricted" /> для данного <paramref name="securityElement" /> не равно ни <see langword="true" />, ни <see langword="false" />.
		/// -или-
		/// <see cref="P:System.Security.SecurityElement.Tag" /> для данного <paramref name="securityElement" /> не является равным IPermission.
		/// -или-
		/// Атрибут <see langword="class" /> данного <paramref name="securityElement " /> равен <see langword="null" /> или не является именем типа для <see cref="T:System.Configuration.ConfigurationPermission" />.
		/// -или-
		/// Атрибут <see langword="version" /> для данного <paramref name="securityElement" /> не равняется 1.</exception>
		// Token: 0x0600015C RID: 348 RVA: 0x0000613C File Offset: 0x0000433C
		public override void FromXml(SecurityElement securityElement)
		{
			if (securityElement == null)
			{
				throw new ArgumentNullException("securityElement");
			}
			if (securityElement.Tag != "IPermission")
			{
				throw new ArgumentException("securityElement");
			}
			string text = securityElement.Attribute("Unrestricted");
			if (text != null)
			{
				this.unrestricted = (string.Compare(text, "true", StringComparison.InvariantCultureIgnoreCase) == 0);
			}
		}

		/// <summary>Возвращает логическое пересечение между объектом <see cref="T:System.Configuration.ConfigurationPermission" /> и данным объектом, который реализует интерфейс <see cref="T:System.Security.IPermission" />.</summary>
		/// <param name="target">Объект, содержащий разрешения на выполнение пересечения.</param>
		/// <returns>Логическое пересечение между объектом <see cref="T:System.Configuration.ConfigurationPermission" /> и данным объектом, который реализует <see cref="T:System.Security.IPermission" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не типизируется как <see cref="T:System.Configuration.ConfigurationPermission" />.</exception>
		// Token: 0x0600015D RID: 349 RVA: 0x00006198 File Offset: 0x00004398
		public override IPermission Intersect(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			ConfigurationPermission configurationPermission = target as ConfigurationPermission;
			if (configurationPermission == null)
			{
				throw new ArgumentException("target");
			}
			return new ConfigurationPermission((this.unrestricted && configurationPermission.IsUnrestricted()) ? PermissionState.Unrestricted : PermissionState.None);
		}

		/// <summary>Возвращает логическое объединение объекта <see cref="T:System.Configuration.ConfigurationPermission" /> и объекта, реализующего интерфейс <see cref="T:System.Security.IPermission" />.</summary>
		/// <param name="target">Объект, с которым необходимо выполнить объединение.</param>
		/// <returns>Логическое объединение объекта <see cref="T:System.Configuration.ConfigurationPermission" /> и объекта, реализующего <see cref="T:System.Security.IPermission" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не типизируется как <see cref="T:System.Configuration.ConfigurationPermission" />.</exception>
		// Token: 0x0600015E RID: 350 RVA: 0x000061D8 File Offset: 0x000043D8
		public override IPermission Union(IPermission target)
		{
			if (target == null)
			{
				return this.Copy();
			}
			ConfigurationPermission configurationPermission = target as ConfigurationPermission;
			if (configurationPermission == null)
			{
				throw new ArgumentException("target");
			}
			return new ConfigurationPermission((this.unrestricted || configurationPermission.IsUnrestricted()) ? PermissionState.Unrestricted : PermissionState.None);
		}

		/// <summary>Сравнивает объект <see cref="T:System.Configuration.ConfigurationPermission" /> с объектом, реализующим интерфейс <see cref="T:System.Security.IPermission" />.</summary>
		/// <param name="target">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если состояние разрешения является равным; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не типизируется как <see cref="T:System.Configuration.ConfigurationPermission" />.</exception>
		// Token: 0x0600015F RID: 351 RVA: 0x00006220 File Offset: 0x00004420
		public override bool IsSubsetOf(IPermission target)
		{
			if (target == null)
			{
				return !this.unrestricted;
			}
			ConfigurationPermission configurationPermission = target as ConfigurationPermission;
			if (configurationPermission == null)
			{
				throw new ArgumentException("target");
			}
			return !this.unrestricted || configurationPermission.IsUnrestricted();
		}

		/// <summary>Указывает, является ли состояние разрешения для объекта <see cref="T:System.Configuration.ConfigurationPermission" /> значением <see cref="F:System.Security.Permissions.PermissionState.Unrestricted" /> перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <returns>Значение <see langword="true" />, если состояние разрешения для <see cref="T:System.Configuration.ConfigurationPermission" /> является значением <see cref="F:System.Security.Permissions.PermissionState.Unrestricted" /> объекта <see cref="T:System.Security.Permissions.PermissionState" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000160 RID: 352 RVA: 0x0000625F File Offset: 0x0000445F
		public bool IsUnrestricted()
		{
			return this.unrestricted;
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.SecurityElement" /> со значением атрибута, основанном на текущем объекте <see cref="T:System.Configuration.ConfigurationPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" /> со значениями атрибута, основанными на текущем <see cref="T:System.Configuration.ConfigurationPermission" />.</returns>
		// Token: 0x06000161 RID: 353 RVA: 0x00006268 File Offset: 0x00004468
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = new SecurityElement("IPermission");
			securityElement.AddAttribute("class", base.GetType().AssemblyQualifiedName);
			securityElement.AddAttribute("version", "1");
			if (this.unrestricted)
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			return securityElement;
		}

		// Token: 0x0400009D RID: 157
		private bool unrestricted;
	}
}
