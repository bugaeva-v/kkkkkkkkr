using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет набор прав доступа, подлежащих аудиту для пользователя или группы. Этот класс не наследуется.</summary>
	// Token: 0x02000524 RID: 1316
	public sealed class EventWaitHandleAuditRule : AuditRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.EventWaitHandleAuditRule" /> с указанием пользователя или группы для аудита, прав для аудита и подлежащих аудиту операций (успешных попыток доступа, неудачных попыток доступа или всех попыток доступа).</summary>
		/// <param name="identity">Пользователь или группа, к которым относится данное правило. Должен обладать типом <see cref="T:System.Security.Principal.SecurityIdentifier" /> или таким типом, как <see cref="T:System.Security.Principal.NTAccount" />, чтобы его можно было преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="eventRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.EventWaitHandleRights" />, определяющее подлежащие аудиту права доступа.</param>
		/// <param name="flags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.AuditFlags" />, определяющее предмет аудита — успешные попытки доступа, неудачные попытки доступа или все попытки доступа.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="eventRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="flags" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="eventRights" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identity" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x06003421 RID: 13345 RVA: 0x000BE9D6 File Offset: 0x000BCBD6
		public EventWaitHandleAuditRule(IdentityReference identity, EventWaitHandleRights eventRights, AuditFlags flags) : base(identity, (int)eventRights, false, InheritanceFlags.None, PropagationFlags.None, flags)
		{
			if (eventRights < EventWaitHandleRights.Modify || eventRights > EventWaitHandleRights.FullControl)
			{
				throw new ArgumentOutOfRangeException("eventRights");
			}
		}

		/// <summary>Получает права доступа, на которые распространяется действие этого правила аудита.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.AccessControl.EventWaitHandleRights" />, определяющее права, на которые распространяется действие этого правила аудита.</returns>
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06003422 RID: 13346 RVA: 0x000BC722 File Offset: 0x000BA922
		public EventWaitHandleRights EventWaitHandleRights
		{
			get
			{
				return (EventWaitHandleRights)base.AccessMask;
			}
		}
	}
}
