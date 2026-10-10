using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет набор прав доступа, подлежащих аудиту для пользователя или группы. Этот класс не наследуется.</summary>
	// Token: 0x02000532 RID: 1330
	public sealed class MutexAuditRule : AuditRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.MutexAuditRule" /> с указанием пользователя или группы для аудита, прав для аудита и подлежащих аудиту операций (успешных попыток доступа, неудачных попыток доступа или всех попыток доступа).</summary>
		/// <param name="identity">Пользователь или группа, к которым относится данное правило. Должен обладать типом <see cref="T:System.Security.Principal.SecurityIdentifier" /> или таким типом, как <see cref="T:System.Security.Principal.NTAccount" />, чтобы его можно было преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="eventRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.MutexRights" />, определяющее подлежащие аудиту права доступа.</param>
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
		// Token: 0x060034A6 RID: 13478 RVA: 0x000BE08A File Offset: 0x000BC28A
		public MutexAuditRule(IdentityReference identity, MutexRights eventRights, AuditFlags flags) : base(identity, (int)eventRights, false, InheritanceFlags.None, PropagationFlags.None, flags)
		{
		}

		/// <summary>Получает права доступа, на которые распространяется действие этого правила аудита.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.AccessControl.MutexRights" />, определяющее права, на которые распространяется действие этого правила аудита.</returns>
		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060034A7 RID: 13479 RVA: 0x000BC722 File Offset: 0x000BA922
		public MutexRights MutexRights
		{
			get
			{
				return (MutexRights)base.AccessMask;
			}
		}
	}
}
