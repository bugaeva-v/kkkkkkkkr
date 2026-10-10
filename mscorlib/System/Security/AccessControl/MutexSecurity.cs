using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;

namespace System.Security.AccessControl
{
	/// <summary>Представляет систему безопасности управления доступом Windows для именованного мьютекса. Этот класс не наследуется.</summary>
	// Token: 0x02000534 RID: 1332
	public sealed class MutexSecurity : NativeObjectSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.MutexSecurity" /> со значениями по умолчанию.</summary>
		/// <exception cref="T:System.NotSupportedException">В Windows 98 и Windows Millenium Edition этот класс не поддерживается.</exception>
		// Token: 0x060034A8 RID: 13480 RVA: 0x000BE9FB File Offset: 0x000BCBFB
		public MutexSecurity() : base(false, ResourceType.KernelObject)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.MutexSecurity" /> с указанными разделами правил безопасности управления доступом из системного мьютекса с указанным именем.</summary>
		/// <param name="name">Имя системного мьютекса, у которого запрашиваются правила безопасности управления доступом.</param>
		/// <param name="includeSections">Сочетание флагов <see cref="T:System.Security.AccessControl.AccessControlSections" />, которое определяет получаемые разделы.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Отсутствует системный объект с указанным именем.</exception>
		/// <exception cref="T:System.NotSupportedException">В Windows 98 и Windows Millenium Edition этот класс не поддерживается.</exception>
		// Token: 0x060034A9 RID: 13481 RVA: 0x000BF962 File Offset: 0x000BDB62
		public MutexSecurity(string name, AccessControlSections includeSections) : base(false, ResourceType.KernelObject, name, includeSections, new NativeObjectSecurity.ExceptionFromErrorCode(MutexSecurity.MutexExceptionFromErrorCode), null)
		{
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000BF97B File Offset: 0x000BDB7B
		internal MutexSecurity(SafeHandle handle, AccessControlSections includeSections) : base(false, ResourceType.KernelObject, handle, includeSections, new NativeObjectSecurity.ExceptionFromErrorCode(MutexSecurity.MutexExceptionFromErrorCode), null)
		{
		}

		/// <summary>Получает значение перечисления, используемое классом <see cref="T:System.Security.AccessControl.MutexSecurity" /> для обозначения прав доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий перечисление <see cref="T:System.Security.AccessControl.MutexRights" />.</returns>
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060034AB RID: 13483 RVA: 0x000BF994 File Offset: 0x000BDB94
		public override Type AccessRightType
		{
			get
			{
				return typeof(MutexRights);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.MutexSecurity" /> для обозначения правил доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.MutexAccessRule" />.</returns>
		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x000BF9A0 File Offset: 0x000BDBA0
		public override Type AccessRuleType
		{
			get
			{
				return typeof(MutexAccessRule);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.MutexSecurity" /> для обозначения правил аудита.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.MutexAuditRule" />.</returns>
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060034AD RID: 13485 RVA: 0x000BF9AC File Offset: 0x000BDBAC
		public override Type AuditRuleType
		{
			get
			{
				return typeof(MutexAuditRule);
			}
		}

		/// <summary>Создает новое правило управления доступом для указанного пользователя с указанными правами, типом управления доступом и флагами.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, идентифицирующий пользователя или группу, к которым относится данное правило.</param>
		/// <param name="accessMask">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.MutexRights" />, определяющее разрешаемые или запрещаемые права доступа, приведенное к целочисленному типу.</param>
		/// <param name="isInherited">Нет смысла использовать для именованных мьютексов, так как у них отсутствует иерархия.</param>
		/// <param name="inheritanceFlags">Нет смысла использовать для именованных мьютексов, так как у них отсутствует иерархия.</param>
		/// <param name="propagationFlags">Нет смысла использовать для именованных мьютексов, так как у них отсутствует иерархия.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.MutexAccessRule" />, представляющий указанные права для указанного пользователя.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="type" /> имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="accessMask" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x060034AE RID: 13486 RVA: 0x000BF9B8 File Offset: 0x000BDBB8
		public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		{
			return new MutexAccessRule(identityReference, (MutexRights)accessMask, type);
		}

		/// <summary>Выполняет поиск подходящего правила управления доступом, с которым можно объединить новое правило. Если поиск не дал результатов, добавляется новое правило.</summary>
		/// <param name="rule">Добавляемое правило управления доступом.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Principal.IdentityNotMappedException">
		///   <paramref name="rule" /> не может быть сопоставлен известному удостоверению.</exception>
		// Token: 0x060034AF RID: 13487 RVA: 0x000BC644 File Offset: 0x000BA844
		public void AddAccessRule(MutexAccessRule rule)
		{
			base.AddAccessRule(rule);
		}

		/// <summary>Осуществляет поиск правила управления доступом с тем же именем пользователя и значением <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и указанного правила, а также с совместимыми флагами наследования и распространения; если правило найдено, содержащиеся в указанном правиле доступа права удаляются.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.MutexAccessRule" />, определяющий пользователя и тип <see cref="T:System.Security.AccessControl.AccessControlType" /> для поиска, а также набор флагов наследования и распространения, с которыми должно быть совместимо найденное правило. Задает права, которые требуется удалить из совместимого правила, если оно будет найдено.</param>
		/// <returns>Значение <see langword="true" />, если совместимое правило найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034B0 RID: 13488 RVA: 0x000BC65F File Offset: 0x000BA85F
		public bool RemoveAccessRule(MutexAccessRule rule)
		{
			return base.RemoveAccessRule(rule);
		}

		/// <summary>Осуществляет поиск всех правил управления доступом с тем же именем пользователя и значением свойства <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и у указанного правила, и удаляет найденные правила.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.MutexAccessRule" />, определяющий пользователя и значение <see cref="T:System.Security.AccessControl.AccessControlType" /> для поиска. Все указанные в данном правиле права игнорируются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034B1 RID: 13489 RVA: 0x000BC668 File Offset: 0x000BA868
		public void RemoveAccessRuleAll(MutexAccessRule rule)
		{
			base.RemoveAccessRuleAll(rule);
		}

		/// <summary>Осуществляет поиск правила управления доступом, в точности соответствующего указанному правилу, и удаляет найденное правило.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.MutexAccessRule" /> для удаления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034B2 RID: 13490 RVA: 0x000BC671 File Offset: 0x000BA871
		public void RemoveAccessRuleSpecific(MutexAccessRule rule)
		{
			base.RemoveAccessRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила управления доступом с тем же именем пользователя, что и у указанного правила, вне зависимости от значения свойства <see cref="T:System.Security.AccessControl.AccessControlType" />, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.MutexAccessRule" />. Имя пользователя, заданное в этом правиле, определяет правила, которые необходимо удалить перед добавлением данного правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034B3 RID: 13491 RVA: 0x000BC656 File Offset: 0x000BA856
		public void ResetAccessRule(MutexAccessRule rule)
		{
			base.ResetAccessRule(rule);
		}

		/// <summary>Удаляет все правила управления доступом с тем же именем пользователя и значением свойства <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и у указанного правила, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.MutexAccessRule" />. Имя пользователя и значение <see cref="T:System.Security.AccessControl.AccessControlType" /> определяют правила, которые необходимо удалить перед добавлением этого правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034B4 RID: 13492 RVA: 0x000BC64D File Offset: 0x000BA84D
		public void SetAccessRule(MutexAccessRule rule)
		{
			base.SetAccessRule(rule);
		}

		/// <summary>Создает новое правило аудита, в котором указывается пользователь, к которому относится правило, правила доступа для аудита, а также событие, вызывающее срабатывание правила аудита.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, идентифицирующий пользователя или группу, к которым относится данное правило.</param>
		/// <param name="accessMask">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.MutexRights" />, определяющее права доступа для аудита, приведенное к целочисленному типу.</param>
		/// <param name="isInherited">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="inheritanceFlags">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="propagationFlags">Нет смысла использовать для именованных дескрипторов ожидания, так как у них отсутствует иерархия.</param>
		/// <param name="flags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.AuditFlags" />, определяющее предмет аудита — успешные попытки доступа, неудачные попытки доступа или все попытки доступа.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.MutexAuditRule" />, представляющий указанное правило аудита для указанного пользователя. Метод возвращает объект базового класса (<see cref="T:System.Security.AccessControl.AuditRule" />), но возвращаемое значение можно безопасно привести к производному классу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="flags" /> имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="accessMask" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x060034B5 RID: 13493 RVA: 0x000BF9C3 File Offset: 0x000BDBC3
		public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		{
			return new MutexAuditRule(identityReference, (MutexRights)accessMask, flags);
		}

		/// <summary>Осуществляет поиск правила аудита, с которым можно объединить новое правило. Если поиск не дал результатов, добавляется новое правило.</summary>
		/// <param name="rule">Добавляемое правило аудита. Поиск ведется по имени пользователя, указанному в этом правиле.</param>
		// Token: 0x060034B6 RID: 13494 RVA: 0x000BC67A File Offset: 0x000BA87A
		public void AddAuditRule(MutexAuditRule rule)
		{
			base.AddAuditRule(rule);
		}

		/// <summary>Осуществляет поиск правила управления аудитом с тем же именем пользователя, что и указанного правила доступа, а также с совместимыми флагами наследования и распространения; если совместимое правило найдено, содержащиеся в указанном правиле права удаляются.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.MutexAuditRule" />, определяющий пользователя для поиска, а также набор флагов наследования и распространения, с которыми должно быть совместимо найденное правило. Задает права, которые требуется удалить из совместимого правила, если оно будет найдено.</param>
		/// <returns>Значение <see langword="true" />, если совместимое правило найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034B7 RID: 13495 RVA: 0x000BC68C File Offset: 0x000BA88C
		public bool RemoveAuditRule(MutexAuditRule rule)
		{
			return base.RemoveAuditRule(rule);
		}

		/// <summary>Производит поиск всех правил аудита с тем же пользователем, что и у указанного правила, и удаляет найденные правила.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.MutexAuditRule" />, определяющий пользователя для поиска. Все указанные в данном правиле права игнорируются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034B8 RID: 13496 RVA: 0x000BC695 File Offset: 0x000BA895
		public void RemoveAuditRuleAll(MutexAuditRule rule)
		{
			base.RemoveAuditRuleAll(rule);
		}

		/// <summary>Осуществляет поиск правила аудита, в точности соответствующего указанному правилу, и удаляет найденное правило.</summary>
		/// <param name="rule">Удаляемый объект <see cref="T:System.Security.AccessControl.MutexAuditRule" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034B9 RID: 13497 RVA: 0x000BC69E File Offset: 0x000BA89E
		public void RemoveAuditRuleSpecific(MutexAuditRule rule)
		{
			base.RemoveAuditRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила аудита с тем же именем пользователя, что и у указанного правила, вне зависимости от значения свойства <see cref="T:System.Security.AccessControl.AuditFlags" />, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.MutexAuditRule" />. Имя пользователя, заданное в этом правиле, определяет правила, которые необходимо удалить перед добавлением данного правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034BA RID: 13498 RVA: 0x000BC683 File Offset: 0x000BA883
		public void SetAuditRule(MutexAuditRule rule)
		{
			base.SetAuditRule(rule);
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x000BF9CE File Offset: 0x000BDBCE
		private static Exception MutexExceptionFromErrorCode(int errorCode, string name, SafeHandle handle, object context)
		{
			if (errorCode == 2)
			{
				return new WaitHandleCannotBeOpenedException();
			}
			return NativeObjectSecurity.DefaultExceptionFromErrorCode(errorCode, name, handle, context);
		}
	}
}
