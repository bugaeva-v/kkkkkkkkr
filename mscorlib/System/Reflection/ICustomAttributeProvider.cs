using System;

namespace System.Reflection
{
	/// <summary>Предоставляет настраиваемые атрибуты для объектов отражения, которые их поддерживают.</summary>
	// Token: 0x020008A1 RID: 2209
	public interface ICustomAttributeProvider
	{
		/// <summary>Возвращает массив всех настраиваемых атрибутов, определенных для этого элемента, за исключением именованных атрибутов, или пустой массив, если атрибуты отсутствуют.</summary>
		/// <param name="inherit">Значение <see langword="true" />, если требуется просмотреть цепочку иерархии для поиска унаследованного настраиваемого атрибута.</param>
		/// <returns>Массив объектов, представляющих настраиваемые атрибуты, или пустой массив.</returns>
		/// <exception cref="T:System.TypeLoadException">Невозможно загрузить тип настраиваемого атрибута.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Для этого элемента определено более одного атрибута типа <paramref name="attributeType" />.</exception>
		// Token: 0x060048F3 RID: 18675
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Возвращает массив настраиваемых атрибутов, определенных для этого элемента с учетом типа, или пустой массив, если отсутствуют настраиваемые атрибуты определенного типа.</summary>
		/// <param name="attributeType">Тип настраиваемых атрибутов.</param>
		/// <param name="inherit">Значение <see langword="true" />, если требуется просмотреть цепочку иерархии для поиска унаследованного настраиваемого атрибута.</param>
		/// <returns>Массив объектов, представляющих настраиваемые атрибуты, или пустой массив.</returns>
		/// <exception cref="T:System.TypeLoadException">Невозможно загрузить тип настраиваемого атрибута.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060048F4 RID: 18676
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Указывает, сколько экземпляров <paramref name="attributeType" /> определено для этого элемента.</summary>
		/// <param name="attributeType">Тип настраиваемых атрибутов.</param>
		/// <param name="inherit">Значение <see langword="true" />, если требуется просмотреть цепочку иерархии для поиска унаследованного настраиваемого атрибута.</param>
		/// <returns>Значение <see langword="true" />, если для этого элемента определен тип <paramref name="attributeType" />. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060048F5 RID: 18677
		bool IsDefined(Type attributeType, bool inherit);
	}
}
