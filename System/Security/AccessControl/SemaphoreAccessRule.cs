using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет набор прав доступа, разрешенных или запрещенных пользователю или группе. Этот класс не наследуется.</summary>
	// Token: 0x0200028E RID: 654
	[ComVisible(false)]
	public sealed class SemaphoreAccessRule : AccessRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" />, определяющий пользователя или группу, к которым применяются правило, права доступа, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Пользователь или группа, к которым относится данное правило. Должен обладать типом <see cref="T:System.Security.Principal.SecurityIdentifier" /> или таким типом, как <see cref="T:System.Security.Principal.NTAccount" />, чтобы его можно было преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="eventRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.SemaphoreRights" />, определяющее права, которые разрешаются или запрещаются.</param>
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
		// Token: 0x060014AE RID: 5294 RVA: 0x000543CE File Offset: 0x000525CE
		public SemaphoreAccessRule(IdentityReference identity, SemaphoreRights eventRights, AccessControlType type) : base(identity, (int)eventRights, false, InheritanceFlags.None, PropagationFlags.None, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.SemaphoreAccessRule" />, определяющий имя пользователя или группы, к которым применяются правило, права доступа, а также тип правила ("разрешить" или "запретить").</summary>
		/// <param name="identity">Имя пользователя или группы, к которым относится данное правило.</param>
		/// <param name="eventRights">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.SemaphoreRights" />, определяющее права, которые разрешаются или запрещаются.</param>
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
		// Token: 0x060014AF RID: 5295 RVA: 0x000543DC File Offset: 0x000525DC
		public SemaphoreAccessRule(string identity, SemaphoreRights eventRights, AccessControlType type) : this(new NTAccount(identity), eventRights, type)
		{
		}

		/// <summary>Получает права, разрешаемые или запрещаемые правилом доступа.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.AccessControl.SemaphoreRights" />, определяющее права, которые разрешаются или запрещаются правилом доступа.</returns>
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x000543EC File Offset: 0x000525EC
		public SemaphoreRights SemaphoreRights
		{
			get
			{
				return (SemaphoreRights)base.AccessMask;
			}
		}
	}
}
