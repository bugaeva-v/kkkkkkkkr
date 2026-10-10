using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет набор прав доступа, разрешенных или запрещенных пользователю или группе. Этот класс не наследуется.</summary>
	// Token: 0x020004FC RID: 1276
	public sealed class RegistryAccessRule : AccessRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RegistryAccessRule" />, определяющий пользователя или группу, к которым применяются правило, права доступа, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Пользователь или группа, к которым относится данное правило. Должен обладать типом <see cref="T:System.Security.Principal.SecurityIdentifier" /> или таким типом, как <see cref="T:System.Security.Principal.NTAccount" />, чтобы его можно было преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="registryRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее права, которые разрешаются или запрещаются.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="registryRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="type" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="eventRights" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identity" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x0600332B RID: 13099 RVA: 0x000BC6CB File Offset: 0x000BA8CB
		public RegistryAccessRule(IdentityReference identity, RegistryRights registryRights, AccessControlType type) : this(identity, (int)registryRights, false, InheritanceFlags.None, PropagationFlags.None, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RegistryAccessRule" />, определяющий имя пользователя или группы, к которым применяются правило, права доступа, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Имя пользователя или группы, к которым относится данное правило.</param>
		/// <param name="registryRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее права, которые разрешаются или запрещаются.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="registryRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="type" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="registryRights" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="identity" /> представляет собой строку нулевой длины.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="identity" /> превышает 512 символов.</exception>
		// Token: 0x0600332C RID: 13100 RVA: 0x000BC6D9 File Offset: 0x000BA8D9
		public RegistryAccessRule(string identity, RegistryRights registryRights, AccessControlType type) : this(new NTAccount(identity), (int)registryRights, false, InheritanceFlags.None, PropagationFlags.None, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RegistryAccessRule" />, определяющий имя пользователя или группы, на которые распространяется действие правила, права доступа, флаги наследования, флаги распространения, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Пользователь или группа, к которым относится данное правило. Должен обладать типом <see cref="T:System.Security.Principal.SecurityIdentifier" /> или таким типом, как <see cref="T:System.Security.Principal.NTAccount" />, чтобы его можно было преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="registryRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее права, которые разрешаются или запрещаются.</param>
		/// <param name="inheritanceFlags">Побитовое сочетание флагов <see cref="T:System.Security.AccessControl.InheritanceFlags" />, которое определяет порядок наследования прав доступа у других объектов.</param>
		/// <param name="propagationFlags">Побитовое сочетание флагов <see cref="T:System.Security.AccessControl.PropagationFlags" />, которое определяет порядок распространения прав доступа на другие объекты.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="registryRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="type" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="inheritanceFlags" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="propagationFlags" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="registryRights" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identity" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x0600332D RID: 13101 RVA: 0x000BC6EC File Offset: 0x000BA8EC
		public RegistryAccessRule(IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : this(identity, (int)registryRights, false, inheritanceFlags, propagationFlags, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RegistryAccessRule" />, определяющий имя пользователя или группы, на которые распространяется действие правила, права доступа, флаги наследования, флаги распространения, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Имя пользователя или группы, к которым относится данное правило.</param>
		/// <param name="registryRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее права, которые разрешаются или запрещаются.</param>
		/// <param name="inheritanceFlags">Побитовое сочетание флагов <see cref="T:System.Security.AccessControl.InheritanceFlags" />, которое определяет порядок наследования прав доступа у других объектов.</param>
		/// <param name="propagationFlags">Побитовое сочетание флагов <see cref="T:System.Security.AccessControl.PropagationFlags" />, которое определяет порядок распространения прав доступа на другие объекты.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="registryRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="type" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="inheritanceFlags" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="propagationFlags" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="eventRights" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="identity" /> представляет собой строку нулевой длины.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="identity" /> превышает 512 символов.</exception>
		// Token: 0x0600332E RID: 13102 RVA: 0x000BC6FC File Offset: 0x000BA8FC
		public RegistryAccessRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : this(new NTAccount(identity), (int)registryRights, false, inheritanceFlags, propagationFlags, type)
		{
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x000BC711 File Offset: 0x000BA911
		internal RegistryAccessRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, type)
		{
		}

		/// <summary>Получает права, разрешаемые или запрещаемые правилом доступа.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее права, которые разрешаются или запрещаются правилом доступа.</returns>
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06003330 RID: 13104 RVA: 0x000BC722 File Offset: 0x000BA922
		public RegistryRights RegistryRights
		{
			get
			{
				return (RegistryRights)base.AccessMask;
			}
		}
	}
}
