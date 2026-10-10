using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет функции безопасности управления доступом Windows для именованного системного дескриптора ожидания. Этот класс не наследуется.</summary>
	// Token: 0x02000526 RID: 1318
	public sealed class EventWaitHandleSecurity : NativeObjectSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" /> со значениями по умолчанию.</summary>
		/// <exception cref="T:System.NotSupportedException">В Windows 98 и Windows Millenium Edition этот класс не поддерживается.</exception>
		// Token: 0x06003423 RID: 13347 RVA: 0x000BE9FB File Offset: 0x000BCBFB
		public EventWaitHandleSecurity() : base(false, ResourceType.KernelObject)
		{
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000BEA05 File Offset: 0x000BCC05
		internal EventWaitHandleSecurity(SafeHandle handle, AccessControlSections includeSections) : base(false, ResourceType.KernelObject, handle, includeSections)
		{
		}

		/// <summary>Получает значение перечисления, используемое классом <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" /> для обозначения прав доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий перечисление <see cref="T:System.Security.AccessControl.EventWaitHandleRights" />.</returns>
		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06003425 RID: 13349 RVA: 0x000BEA11 File Offset: 0x000BCC11
		public override Type AccessRightType
		{
			get
			{
				return typeof(EventWaitHandleRights);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" /> для обозначения правил доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" />.</returns>
		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06003426 RID: 13350 RVA: 0x000BEA1D File Offset: 0x000BCC1D
		public override Type AccessRuleType
		{
			get
			{
				return typeof(EventWaitHandleAccessRule);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" /> для обозначения правил аудита.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.EventWaitHandleAuditRule" />.</returns>
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x000BEA29 File Offset: 0x000BCC29
		public override Type AuditRuleType
		{
			get
			{
				return typeof(EventWaitHandleAuditRule);
			}
		}

		/// <summary>Создает новое правило управления доступом для указанного пользователя с указанными правами, типом управления доступом и флагами.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, идентифицирующий пользователя или группу, к которым относится данное правило.</param>
		/// <param name="accessMask">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.EventWaitHandleRights" />, определяющее разрешаемые или запрещаемые права доступа, приведенное к целочисленному типу.</param>
		/// <param name="isInherited">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="inheritanceFlags">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="propagationFlags">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" />, представляющий указанные права для указанного пользователя.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="type" /> имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="accessMask" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x06003428 RID: 13352 RVA: 0x000BEA35 File Offset: 0x000BCC35
		public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		{
			return new EventWaitHandleAccessRule(identityReference, (EventWaitHandleRights)accessMask, type);
		}

		/// <summary>Выполняет поиск подходящего правила управления доступом, с которым можно объединить новое правило. Если поиск не дал результатов, добавляется новое правило.</summary>
		/// <param name="rule">Добавляемое правило управления доступом.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003429 RID: 13353 RVA: 0x000BC644 File Offset: 0x000BA844
		public void AddAccessRule(EventWaitHandleAccessRule rule)
		{
			base.AddAccessRule(rule);
		}

		/// <summary>Осуществляет поиск правила управления доступом с тем же именем пользователя и значением <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и указанного правила доступа, а также с совместимыми флагами наследования и распространения; если правило найдено, содержащиеся в указанном правиле доступа права удаляются.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" />, определяющий пользователя и тип <see cref="T:System.Security.AccessControl.AccessControlType" /> для поиска, а также набор флагов наследования и распространения, с которыми должно быть совместимо найденное правило. Задает права, которые требуется удалить из совместимого правила, если оно будет найдено.</param>
		/// <returns>Значение <see langword="true" />, если совместимое правило найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600342A RID: 13354 RVA: 0x000BC65F File Offset: 0x000BA85F
		public bool RemoveAccessRule(EventWaitHandleAccessRule rule)
		{
			return base.RemoveAccessRule(rule);
		}

		/// <summary>Осуществляет поиск всех правил управления доступом с тем же именем пользователя и значением свойства <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и у указанного правила, и удаляет найденные правила.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" />, определяющий пользователя и значение <see cref="T:System.Security.AccessControl.AccessControlType" /> для поиска. Все указанные в данном правиле права игнорируются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600342B RID: 13355 RVA: 0x000BC668 File Offset: 0x000BA868
		public void RemoveAccessRuleAll(EventWaitHandleAccessRule rule)
		{
			base.RemoveAccessRuleAll(rule);
		}

		/// <summary>Осуществляет поиск правила управления доступом, в точности соответствующего указанному правилу, и удаляет найденное правило.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" /> для удаления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600342C RID: 13356 RVA: 0x000BC671 File Offset: 0x000BA871
		public void RemoveAccessRuleSpecific(EventWaitHandleAccessRule rule)
		{
			base.RemoveAccessRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила управления доступом с тем же именем пользователя, что и у указанного правила, вне зависимости от значения свойства <see cref="T:System.Security.AccessControl.AccessControlType" />, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" />. Имя пользователя, заданное в этом правиле, определяет правила, которые необходимо удалить перед добавлением данного правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600342D RID: 13357 RVA: 0x000BC656 File Offset: 0x000BA856
		public void ResetAccessRule(EventWaitHandleAccessRule rule)
		{
			base.ResetAccessRule(rule);
		}

		/// <summary>Удаляет все правила управления доступом с тем же именем пользователя и значением свойства <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и у указанного правила, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" />. Имя пользователя и значение <see cref="T:System.Security.AccessControl.AccessControlType" /> определяют правила, которые необходимо удалить перед добавлением этого правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600342E RID: 13358 RVA: 0x000BC64D File Offset: 0x000BA84D
		public void SetAccessRule(EventWaitHandleAccessRule rule)
		{
			base.SetAccessRule(rule);
		}

		/// <summary>Создает новое правило аудита, в котором указывается пользователь, к которому относится правило, правила доступа для аудита, а также событие, вызывающее срабатывание правила аудита.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, идентифицирующий пользователя или группу, к которым относится данное правило.</param>
		/// <param name="accessMask">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.EventWaitHandleRights" />, определяющее права доступа для аудита, приведенное к целочисленному типу.</param>
		/// <param name="isInherited">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="inheritanceFlags">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="propagationFlags">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="flags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.AuditFlags" />, определяющее предмет аудита — успешные попытки доступа, неудачные попытки доступа или все попытки доступа.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.EventWaitHandleAuditRule" />, представляющий указанное правило аудита для указанного пользователя. Метод возвращает объект базового класса (<see cref="T:System.Security.AccessControl.AuditRule" />), но возвращаемое значение можно безопасно привести к производному классу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="flags" /> имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="accessMask" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x0600342F RID: 13359 RVA: 0x000BEA40 File Offset: 0x000BCC40
		public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		{
			return new EventWaitHandleAuditRule(identityReference, (EventWaitHandleRights)accessMask, flags);
		}

		/// <summary>Осуществляет поиск правила аудита, с которым можно объединить новое правило. Если поиск не дал результатов, добавляется новое правило.</summary>
		/// <param name="rule">Добавляемое правило аудита. Поиск ведется по имени пользователя, указанному в этом правиле.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003430 RID: 13360 RVA: 0x000BC67A File Offset: 0x000BA87A
		public void AddAuditRule(EventWaitHandleAuditRule rule)
		{
			base.AddAuditRule(rule);
		}

		/// <summary>Осуществляет поиск правила аудита с тем же именем пользователя, что и указанного правила доступа, а также с совместимыми флагами наследования и распространения; если совместимое правило найдено, содержащиеся в указанном правиле права удаляются.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.EventWaitHandleAuditRule" />, определяющий пользователя для поиска, а также набор флагов наследования и распространения, с которыми должно быть совместимо найденное правило. Задает права, которые требуется удалить из совместимого правила, если оно будет найдено.</param>
		/// <returns>Значение <see langword="true" />, если совместимое правило найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003431 RID: 13361 RVA: 0x000BC68C File Offset: 0x000BA88C
		public bool RemoveAuditRule(EventWaitHandleAuditRule rule)
		{
			return base.RemoveAuditRule(rule);
		}

		/// <summary>Производит поиск всех правил аудита с тем же пользователем, что и у указанного правила, и удаляет найденные правила.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.EventWaitHandleAuditRule" />, определяющий пользователя для поиска. Все указанные в данном правиле права игнорируются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003432 RID: 13362 RVA: 0x000BC695 File Offset: 0x000BA895
		public void RemoveAuditRuleAll(EventWaitHandleAuditRule rule)
		{
			base.RemoveAuditRuleAll(rule);
		}

		/// <summary>Осуществляет поиск правила аудита, в точности соответствующего указанному правилу, и удаляет найденное правило.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.EventWaitHandleAuditRule" /> для удаления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003433 RID: 13363 RVA: 0x000BC69E File Offset: 0x000BA89E
		public void RemoveAuditRuleSpecific(EventWaitHandleAuditRule rule)
		{
			base.RemoveAuditRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила аудита с тем же именем пользователя, что и у указанного правила, вне зависимости от значения свойства <see cref="T:System.Security.AccessControl.AuditFlags" />, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.EventWaitHandleAuditRule" />. Имя пользователя, заданное в этом правиле, определяет правила, которые необходимо удалить перед добавлением данного правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003434 RID: 13364 RVA: 0x000BC683 File Offset: 0x000BA883
		public void SetAuditRule(EventWaitHandleAuditRule rule)
		{
			base.SetAuditRule(rule);
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x000BEA4B File Offset: 0x000BCC4B
		internal void Persist(SafeHandle handle)
		{
			base.PersistModifications(handle);
		}
	}
}
