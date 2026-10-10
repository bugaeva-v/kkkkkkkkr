using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Обеспечивает безопасность управления доступом Windows для именованного семафора. Этот класс не наследуется.</summary>
	// Token: 0x02000291 RID: 657
	[ComVisible(false)]
	public sealed class SemaphoreSecurity : NativeObjectSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.SemaphoreSecurity" /> со значениями по умолчанию.</summary>
		/// <exception cref="T:System.NotSupportedException">В Windows 98 и Windows Millenium Edition этот класс не поддерживается.</exception>
		// Token: 0x060014B3 RID: 5299 RVA: 0x00054402 File Offset: 0x00052602
		public SemaphoreSecurity() : base(false, ResourceType.KernelObject)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.SemaphoreSecurity" /> с указанными разделами правил безопасности управления доступом из системного семафора с указанным именем.</summary>
		/// <param name="name">Имя системного семафора, у которого запрашиваются правила безопасности управления доступом.</param>
		/// <param name="includeSections">Сочетание флагов <see cref="T:System.Security.AccessControl.AccessControlSections" />, которое определяет получаемые разделы.</param>
		/// <exception cref="T:System.NotSupportedException">В Windows 98 и Windows Millenium Edition этот класс не поддерживается.</exception>
		// Token: 0x060014B4 RID: 5300 RVA: 0x0005440C File Offset: 0x0005260C
		public SemaphoreSecurity(string name, AccessControlSections includeSections) : base(false, ResourceType.KernelObject, name, includeSections)
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00054418 File Offset: 0x00052618
		internal SemaphoreSecurity(SafeHandle handle, AccessControlSections includeSections) : base(false, ResourceType.KernelObject, handle, includeSections)
		{
		}

		/// <summary>Получает значение перечисления, используемое классом <see cref="T:System.Security.AccessControl.SemaphoreSecurity" /> для обозначения прав доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий перечисление <see cref="T:System.Security.AccessControl.SemaphoreRights" />.</returns>
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00054424 File Offset: 0x00052624
		public override Type AccessRightType
		{
			get
			{
				return typeof(SemaphoreRights);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.SemaphoreSecurity" /> для обозначения правил доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" />.</returns>
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00054430 File Offset: 0x00052630
		public override Type AccessRuleType
		{
			get
			{
				return typeof(SemaphoreAccessRule);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.SemaphoreSecurity" /> для обозначения правил аудита.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.SemaphoreAuditRule" />.</returns>
		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0005443C File Offset: 0x0005263C
		public override Type AuditRuleType
		{
			get
			{
				return typeof(SemaphoreAuditRule);
			}
		}

		/// <summary>Создает новое правило управления доступом для указанного пользователя с указанными правами, типом управления доступом и флагами.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, идентифицирующий пользователя или группу, к которым относится данное правило.</param>
		/// <param name="accessMask">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.SemaphoreRights" />, определяющее разрешаемые или запрещаемые права доступа, приведенное к целочисленному типу.</param>
		/// <param name="isInherited">Нет смысла использовать для именованных семафоров, так как у них отсутствует иерархия.</param>
		/// <param name="inheritanceFlags">Нет смысла использовать для именованных семафоров, так как у них отсутствует иерархия.</param>
		/// <param name="propagationFlags">Нет смысла использовать для именованных семафоров, так как у них отсутствует иерархия.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" />, представляющий указанные права для указанного пользователя.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="type" /> имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="accessMask" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x060014B9 RID: 5305 RVA: 0x00054448 File Offset: 0x00052648
		public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		{
			return new SemaphoreAccessRule(identityReference, (SemaphoreRights)accessMask, type);
		}

		/// <summary>Осуществляет поиск подходящего правила, с которым можно объединить новое правило. Если поиск не дал результатов, добавляется новое правило.</summary>
		/// <param name="rule">Добавляемое правило управления доступом.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014BA RID: 5306 RVA: 0x00054453 File Offset: 0x00052653
		public void AddAccessRule(SemaphoreAccessRule rule)
		{
			base.AddAccessRule(rule);
		}

		/// <summary>Осуществляет поиск правила управления доступом с тем же именем пользователя и значением <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и указанного правила, а также с совместимыми флагами наследования и распространения; если правило найдено, содержащиеся в указанном правиле доступа права удаляются.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" />, определяющий пользователя и тип <see cref="T:System.Security.AccessControl.AccessControlType" /> для поиска, а также набор флагов наследования и распространения, с которыми должно быть совместимо найденное правило. Задает права, которые требуется удалить из совместимого правила, если оно будет найдено.</param>
		/// <returns>Значение <see langword="true" />, если совместимое правило найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014BB RID: 5307 RVA: 0x0005445C File Offset: 0x0005265C
		public bool RemoveAccessRule(SemaphoreAccessRule rule)
		{
			return base.RemoveAccessRule(rule);
		}

		/// <summary>Осуществляет поиск всех правил управления доступом с тем же именем пользователя и значением свойства <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и у указанного правила, и удаляет найденные правила.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" />, определяющий пользователя и значение <see cref="T:System.Security.AccessControl.AccessControlType" /> для поиска. Все указанные в данном правиле права игнорируются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014BC RID: 5308 RVA: 0x00054465 File Offset: 0x00052665
		public void RemoveAccessRuleAll(SemaphoreAccessRule rule)
		{
			base.RemoveAccessRuleAll(rule);
		}

		/// <summary>Осуществляет поиск правила управления доступом, в точности соответствующего указанному правилу, и удаляет найденное правило.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" /> для удаления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014BD RID: 5309 RVA: 0x0005446E File Offset: 0x0005266E
		public void RemoveAccessRuleSpecific(SemaphoreAccessRule rule)
		{
			base.RemoveAccessRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила управления доступом с тем же именем пользователя, что и у указанного правила, вне зависимости от значения свойства <see cref="T:System.Security.AccessControl.AccessControlType" />, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" />. Имя пользователя, заданное в этом правиле, определяет правила, которые необходимо удалить перед добавлением данного правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014BE RID: 5310 RVA: 0x00054477 File Offset: 0x00052677
		public void ResetAccessRule(SemaphoreAccessRule rule)
		{
			base.ResetAccessRule(rule);
		}

		/// <summary>Удаляет все правила управления доступом с тем же именем пользователя и значением свойства <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и у указанного правила, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" />. Имя пользователя и значение <see cref="T:System.Security.AccessControl.AccessControlType" /> определяют правила, которые необходимо удалить перед добавлением этого правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014BF RID: 5311 RVA: 0x00054480 File Offset: 0x00052680
		public void SetAccessRule(SemaphoreAccessRule rule)
		{
			base.SetAccessRule(rule);
		}

		/// <summary>Создает новое правило аудита, в котором указывается пользователь, к которому относится правило, правила доступа для аудита, а также событие, вызывающее срабатывание правила аудита.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, идентифицирующий пользователя или группу, к которым относится данное правило.</param>
		/// <param name="accessMask">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.SemaphoreRights" />, определяющее права доступа для аудита, приведенное к целочисленному типу.</param>
		/// <param name="isInherited">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="inheritanceFlags">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="propagationFlags">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="flags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.AuditFlags" />, определяющее предмет аудита — успешные попытки доступа, неудачные попытки доступа или все попытки доступа.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.SemaphoreAuditRule" />, представляющий указанное правило аудита для указанного пользователя. Метод возвращает объект базового класса (<see cref="T:System.Security.AccessControl.AuditRule" />), но возвращаемое значение можно безопасно привести к производному классу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="flags" /> имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="accessMask" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x060014C0 RID: 5312 RVA: 0x00054489 File Offset: 0x00052689
		public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		{
			return new SemaphoreAuditRule(identityReference, (SemaphoreRights)accessMask, flags);
		}

		/// <summary>Осуществляет поиск правила аудита, с которым можно объединить новое правило. Если поиск не дал результатов, добавляется новое правило.</summary>
		/// <param name="rule">Добавляемое правило аудита. Поиск ведется по имени пользователя, указанному в этом правиле.</param>
		// Token: 0x060014C1 RID: 5313 RVA: 0x00054494 File Offset: 0x00052694
		public void AddAuditRule(SemaphoreAuditRule rule)
		{
			base.AddAuditRule(rule);
		}

		/// <summary>Осуществляет поиск правила управления аудитом с тем же именем пользователя, что и указанного правила доступа, а также с совместимыми флагами наследования и распространения; если совместимое правило найдено, содержащиеся в указанном правиле права удаляются.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.SemaphoreAuditRule" />, определяющий пользователя для поиска, а также набор флагов наследования и распространения, с которыми должно быть совместимо найденное правило. Задает права, которые требуется удалить из совместимого правила, если оно будет найдено.</param>
		/// <returns>Значение <see langword="true" />, если совместимое правило найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014C2 RID: 5314 RVA: 0x0005449D File Offset: 0x0005269D
		public bool RemoveAuditRule(SemaphoreAuditRule rule)
		{
			return base.RemoveAuditRule(rule);
		}

		/// <summary>Производит поиск всех правил аудита с тем же пользователем, что и у указанного правила, и удаляет найденные правила.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.SemaphoreAuditRule" />, определяющий пользователя для поиска. Все указанные в данном правиле права игнорируются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014C3 RID: 5315 RVA: 0x000544A6 File Offset: 0x000526A6
		public void RemoveAuditRuleAll(SemaphoreAuditRule rule)
		{
			base.RemoveAuditRuleAll(rule);
		}

		/// <summary>Осуществляет поиск правила аудита, в точности соответствующего указанному правилу, и удаляет найденное правило.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.SemaphoreAuditRule" /> для удаления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014C4 RID: 5316 RVA: 0x000544AF File Offset: 0x000526AF
		public void RemoveAuditRuleSpecific(SemaphoreAuditRule rule)
		{
			base.RemoveAuditRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила аудита с тем же именем пользователя, что и у указанного правила, вне зависимости от значения свойства <see cref="T:System.Security.AccessControl.AuditFlags" />, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.SemaphoreAuditRule" />. Имя пользователя, заданное в этом правиле, определяет правила, которые необходимо удалить перед добавлением данного правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014C5 RID: 5317 RVA: 0x000544B8 File Offset: 0x000526B8
		public void SetAuditRule(SemaphoreAuditRule rule)
		{
			base.SetAuditRule(rule);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000544C4 File Offset: 0x000526C4
		internal void Persist(SafeHandle handle)
		{
			base.WriteLock();
			try
			{
				base.Persist(handle, (base.AccessRulesModified ? AccessControlSections.Access : AccessControlSections.None) | (base.AuditRulesModified ? AccessControlSections.Audit : AccessControlSections.None) | (base.OwnerModified ? AccessControlSections.Owner : AccessControlSections.None) | (base.GroupModified ? AccessControlSections.Group : AccessControlSections.None), null);
			}
			finally
			{
				base.WriteUnlock();
			}
		}
	}
}
