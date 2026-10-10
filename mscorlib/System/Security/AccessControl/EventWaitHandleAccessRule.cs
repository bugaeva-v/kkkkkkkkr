using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет набор прав доступа, разрешенных или запрещенных пользователю или группе. Этот класс не наследуется.</summary>
	// Token: 0x02000523 RID: 1315
	public sealed class EventWaitHandleAccessRule : AccessRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" />, определяющий пользователя или группу, к которым применяются правило, права доступа, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Пользователь или группа, к которым относится данное правило. Должен обладать типом <see cref="T:System.Security.Principal.SecurityIdentifier" /> или таким типом, как <see cref="T:System.Security.Principal.NTAccount" />, чтобы его можно было преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="eventRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.EventWaitHandleRights" />, определяющее права, которые разрешаются или запрещаются.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="eventRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="type" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="eventRights" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identity" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x0600341E RID: 13342 RVA: 0x000BE06C File Offset: 0x000BC26C
		public EventWaitHandleAccessRule(IdentityReference identity, EventWaitHandleRights eventRights, AccessControlType type) : base(identity, (int)eventRights, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.EventWaitHandleAccessRule" />, определяющий имя пользователя или группы, к которым применяются правило, права доступа, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Имя пользователя или группы, к которым относится данное правило.</param>
		/// <param name="eventRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.EventWaitHandleRights" />, определяющее права, которые разрешаются или запрещаются.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="eventRights" /> содержит недопустимое значение.  
		///
		/// или - 
		/// Параметр <paramref name="type" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="eventRights" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="identity" /> представляет собой строку нулевой длины.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="identity" /> превышает 512 символов.</exception>
		// Token: 0x0600341F RID: 13343 RVA: 0x000BE9C6 File Offset: 0x000BCBC6
		public EventWaitHandleAccessRule(string identity, EventWaitHandleRights eventRights, AccessControlType type) : this(new NTAccount(identity), eventRights, type)
		{
		}

		/// <summary>Получает права, разрешаемые или запрещаемые правилом доступа.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.AccessControl.EventWaitHandleRights" />, определяющее права, которые разрешаются или запрещаются правилом доступа.</returns>
		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06003420 RID: 13344 RVA: 0x000BC722 File Offset: 0x000BA922
		public EventWaitHandleRights EventWaitHandleRights
		{
			get
			{
				return (EventWaitHandleRights)base.AccessMask;
			}
		}
	}
}
