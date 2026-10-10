using System;
using System.Security.Policy;

namespace System.Security
{
	/// <summary>Поддерживает методы, которые преобразуют состояние объекта разрешений в представление элемента XML и обратно.</summary>
	// Token: 0x020003C8 RID: 968
	public interface ISecurityPolicyEncodable
	{
		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст уровня политики, используемый для обработки ссылок на именованные наборы разрешений.</param>
		// Token: 0x06002854 RID: 10324
		void FromXml(SecurityElement e, PolicyLevel level);

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <param name="level">Контекст уровня политики, используемый для обработки ссылок на именованные наборы разрешений.</param>
		/// <returns>Корневой элемент XML-представления объекта политики.</returns>
		// Token: 0x06002855 RID: 10325
		SecurityElement ToXml(PolicyLevel level);
	}
}
