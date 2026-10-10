using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет набор прав доступа, разрешенных или запрещенных пользователю или группе. Этот класс не наследуется.</summary>
	// Token: 0x02000531 RID: 1329
	public sealed class MutexAccessRule : AccessRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.MutexAccessRule" />, определяющий пользователя или группу, к которым применяются правило, права доступа, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Пользователь или группа, к которым относится данное правило. Должен обладать типом <see cref="T:System.Security.Principal.SecurityIdentifier" /> или таким типом, как <see cref="T:System.Security.Principal.NTAccount" />, чтобы его можно было преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="eventRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.MutexRights" />, определяющее права, которые разрешаются или запрещаются.</param>
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
		// Token: 0x060034A3 RID: 13475 RVA: 0x000BF944 File Offset: 0x000BDB44
		public MutexAccessRule(IdentityReference identity, MutexRights eventRights, AccessControlType type) : base(identity, (int)eventRights, false, InheritanceFlags.None, PropagationFlags.None, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.MutexAccessRule" />, определяющий имя пользователя или группы, к которым применяются правило, права доступа, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Имя пользователя или группы, к которым относится данное правило.</param>
		/// <param name="eventRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.MutexRights" />, определяющее права, которые разрешаются или запрещаются.</param>
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
		// Token: 0x060034A4 RID: 13476 RVA: 0x000BF952 File Offset: 0x000BDB52
		public MutexAccessRule(string identity, MutexRights eventRights, AccessControlType type) : this(new NTAccount(identity), eventRights, type)
		{
		}

		/// <summary>Получает права, разрешаемые или запрещаемые правилом доступа.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.AccessControl.MutexRights" />, определяющее права, которые разрешаются или запрещаются правилом доступа.</returns>
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x000BC722 File Offset: 0x000BA922
		public MutexRights MutexRights
		{
			get
			{
				return (MutexRights)base.AccessMask;
			}
		}
	}
}
