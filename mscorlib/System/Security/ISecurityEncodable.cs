using System;

namespace System.Security
{
	/// <summary>Определяет методы, которые преобразуют состояние объекта разрешений в представление элемента XML и обратно.</summary>
	// Token: 0x020003C6 RID: 966
	public interface ISecurityEncodable
	{
		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		// Token: 0x06002851 RID: 10321
		void FromXml(SecurityElement e);

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002852 RID: 10322
		SecurityElement ToXml();
	}
}
