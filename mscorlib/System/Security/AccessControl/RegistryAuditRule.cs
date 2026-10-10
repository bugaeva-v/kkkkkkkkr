using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет набор прав доступа, подлежащих аудиту для пользователя или группы. Этот класс не наследуется.</summary>
	// Token: 0x020004FD RID: 1277
	public sealed class RegistryAuditRule : AuditRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> с указанием пользователя или группы для аудита, прав для аудита, необходимости учитывать наследование и подлежащих аудиту операций (успешных попыток доступа, неудачных попыток доступа или всех попыток доступа).</summary>
		/// <param name="identity">Пользователь или группа, к которым относится данное правило. Должен обладать типом <see cref="T:System.Security.Principal.SecurityIdentifier" /> или таким типом, как <see cref="T:System.Security.Principal.NTAccount" />, чтобы его можно было преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="registryRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее подлежащие аудиту права доступа.</param>
		/// <param name="inheritanceFlags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, которое определяет, должно ли правило аудита применяться к подразделам текущего раздела.</param>
		/// <param name="propagationFlags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, влияющее на способ распространения наследования правила аудита на подразделы текущего раздела.</param>
		/// <param name="flags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.AuditFlags" />, определяющее предмет аудита — успешные попытки доступа, неудачные попытки доступа или все попытки доступа.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="eventRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="flags" /> содержит недопустимое значение.  
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
		// Token: 0x06003331 RID: 13105 RVA: 0x000BC72A File Offset: 0x000BA92A
		public RegistryAuditRule(IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : this(identity, (int)registryRights, false, inheritanceFlags, propagationFlags, flags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> с указанием имени пользователя или группы для аудита, прав для аудита, необходимости учитывать наследование, и подлежащих аудиту операций (успешных попыток доступа, неудачных попыток доступа или всех попыток доступа).</summary>
		/// <param name="identity">Имя пользователя или группы, к которым относится данное правило.</param>
		/// <param name="registryRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее подлежащие аудиту права доступа.</param>
		/// <param name="inheritanceFlags">Побитовое сочетание флагов <see cref="T:System.Security.AccessControl.InheritanceFlags" />, которое определяет, должно ли правило аудита применяться к подразделам текущего раздела.</param>
		/// <param name="propagationFlags">Побитовое сочетание флагов <see cref="T:System.Security.AccessControl.PropagationFlags" />, влияющее на способ распространения наследования правила аудита на подразделы текущего раздела.</param>
		/// <param name="flags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.AuditFlags" />, определяющее предмет аудита — успешные попытки доступа, неудачные попытки доступа или все попытки доступа.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="eventRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="flags" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="inheritanceFlags" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="propagationFlags" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="registryRights" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="identity" /> представляет собой строку нулевой длины.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="identity" /> превышает 512 символов.</exception>
		// Token: 0x06003332 RID: 13106 RVA: 0x000BC73A File Offset: 0x000BA93A
		public RegistryAuditRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : this(new NTAccount(identity), (int)registryRights, false, inheritanceFlags, propagationFlags, flags)
		{
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x000BC74F File Offset: 0x000BA94F
		internal RegistryAuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, flags)
		{
		}

		/// <summary>Получает права доступа, на которые распространяется действие этого правила аудита.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее права, на которые распространяется действие этого правила аудита.</returns>
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06003334 RID: 13108 RVA: 0x000BC722 File Offset: 0x000BA922
		public RegistryRights RegistryRights
		{
			get
			{
				return (RegistryRights)base.AccessMask;
			}
		}
	}
}
