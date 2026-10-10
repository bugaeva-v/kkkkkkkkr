using System;

namespace System.Security
{
	/// <summary>Определяет методы, реализуемые типами разрешений.</summary>
	// Token: 0x020003C5 RID: 965
	public interface IPermission : ISecurityEncodable
	{
		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x0600284C RID: 10316
		IPermission Copy();

		/// <summary>Создает исключение <see cref="T:System.Security.SecurityException" /> во время выполнения, если требования безопасности не выполнены.</summary>
		// Token: 0x0600284D RID: 10317
		void Demand();

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Если пересечение пусто, новое разрешение имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и не является экземпляром того же класса, что и текущее разрешение.</exception>
		// Token: 0x0600284E RID: 10318
		IPermission Intersect(IPermission target);

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством заданного разрешения; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и не относится к тому же типу, что и текущее разрешение.</exception>
		// Token: 0x0600284F RID: 10319
		bool IsSubsetOf(IPermission target);

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и не относится к тому же типу, что и текущее разрешение.</exception>
		// Token: 0x06002850 RID: 10320
		IPermission Union(IPermission target);
	}
}
