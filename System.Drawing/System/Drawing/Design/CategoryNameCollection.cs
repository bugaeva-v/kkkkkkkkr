using System;
using System.Collections;

namespace System.Drawing.Design
{
	/// <summary>Представляет коллекцию строк имен категорий.</summary>
	// Token: 0x02000120 RID: 288
	public sealed class CategoryNameCollection : ReadOnlyCollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.CategoryNameCollection" /> с использованием указанной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Drawing.Design.CategoryNameCollection" />, содержащий имена для инициализации значений в коллекции.</param>
		// Token: 0x06000D6C RID: 3436 RVA: 0x0001EF88 File Offset: 0x0001D188
		public CategoryNameCollection(CategoryNameCollection value)
		{
			base.InnerList.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.CategoryNameCollection" />, используя указанный массив имен.</summary>
		/// <param name="value">Массив строк, содержащий имена категорий для инициализации значений в коллекции.</param>
		// Token: 0x06000D6D RID: 3437 RVA: 0x0001EF88 File Offset: 0x0001D188
		public CategoryNameCollection(string[] value)
		{
			base.InnerList.AddRange(value);
		}

		/// <summary>Получает имя категории с указанным индексом.</summary>
		/// <param name="index">Индекс доступа к элементу коллекции.</param>
		/// <returns>Имя категории с указанным индексом.</returns>
		// Token: 0x1700039E RID: 926
		public string this[int index]
		{
			get
			{
				return (string)base.InnerList[index];
			}
		}

		/// <summary>Определяет, содержится ли указанная категория в коллекции.</summary>
		/// <param name="value">Строка для проверки в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если указанная категория присутствует в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000D6F RID: 3439 RVA: 0x0001EFAF File Offset: 0x0001D1AF
		public bool Contains(string value)
		{
			return base.InnerList.Contains(value);
		}

		/// <summary>Копирует элементы коллекции в указанный массив с определенным индексом.</summary>
		/// <param name="array">Массив для копирования данных.</param>
		/// <param name="index">Индекс массива назначения, в который начинается копирование.</param>
		// Token: 0x06000D70 RID: 3440 RVA: 0x0001EFBD File Offset: 0x0001D1BD
		public void CopyTo(string[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}

		/// <summary>Получает индекс указанного значения.</summary>
		/// <param name="value">Имя категории для извлечения индекса в коллекции.</param>
		/// <returns>Индекс в коллекции или <see langword="null" />, если строка не существует в коллекции.</returns>
		// Token: 0x06000D71 RID: 3441 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		public int IndexOf(string value)
		{
			return base.InnerList.IndexOf(value);
		}
	}
}
