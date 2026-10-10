using System;
using System.Collections;

namespace System.Security.AccessControl
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.AccessControl.AuthorizationRule" />.</summary>
	// Token: 0x0200050D RID: 1293
	public sealed class AuthorizationRuleCollection : ReadOnlyCollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuthorizationRuleCollection" />.</summary>
		// Token: 0x06003358 RID: 13144 RVA: 0x000BCA33 File Offset: 0x000BAC33
		public AuthorizationRuleCollection()
		{
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000BCA3B File Offset: 0x000BAC3B
		internal AuthorizationRuleCollection(AuthorizationRule[] rules)
		{
			base.InnerList.AddRange(rules);
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.AccessControl.AuthorizationRule" /> в коллекцию.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.AuthorizationRule" /> для добавления в коллекцию.</param>
		// Token: 0x0600335A RID: 13146 RVA: 0x000BCA4F File Offset: 0x000BAC4F
		public void AddRule(AuthorizationRule rule)
		{
			base.InnerList.Add(rule);
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.AccessControl.AuthorizationRule" /> по указанному индексу коллекции.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс возвращаемого объекта <see cref="T:System.Security.AccessControl.AuthorizationRule" />.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.AuthorizationRule" />, расположенный по указанному индексу.</returns>
		// Token: 0x170006F8 RID: 1784
		public AuthorizationRule this[int index]
		{
			get
			{
				return (AuthorizationRule)base.InnerList[index];
			}
		}

		/// <summary>Копирует содержимое коллекции в массив.</summary>
		/// <param name="rules">Массив, в который следует скопировать содержимое коллекции.</param>
		/// <param name="index">Отсчитываемый от нуля индекс, с которого должно начаться копирование.</param>
		// Token: 0x0600335C RID: 13148 RVA: 0x000BCA71 File Offset: 0x000BAC71
		public void CopyTo(AuthorizationRule[] rules, int index)
		{
			base.InnerList.CopyTo(rules, index);
		}
	}
}
