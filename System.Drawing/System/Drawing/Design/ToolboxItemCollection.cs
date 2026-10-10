using System;
using System.Collections;

namespace System.Drawing.Design
{
	/// <summary>Представляет коллекцию элементов панели элементов.</summary>
	// Token: 0x0200012D RID: 301
	public sealed class ToolboxItemCollection : ReadOnlyCollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.ToolboxItemCollection" /> с использованием указанной коллекции.</summary>
		/// <param name="value">Коллекция <see cref="T:System.Drawing.Design.ToolboxItemCollection" /> для заполнения новой коллекции.</param>
		// Token: 0x06000DB7 RID: 3511 RVA: 0x0001EF88 File Offset: 0x0001D188
		public ToolboxItemCollection(ToolboxItemCollection value)
		{
			base.InnerList.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.ToolboxItemCollection" />, используя указанный массив элементов панели инструментов.</summary>
		/// <param name="value">Массив объектов типа <see cref="T:System.Drawing.Design.ToolboxItem" />, содержащий заполняющие коллекцию элементы панели инструментов.</param>
		// Token: 0x06000DB8 RID: 3512 RVA: 0x0001EF88 File Offset: 0x0001D188
		public ToolboxItemCollection(ToolboxItem[] value)
		{
			base.InnerList.AddRange(value);
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Design.ToolboxItem" /> по указанному индексу.</summary>
		/// <param name="index">Индекс объекта, который требуется возвратить или задать.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Design.ToolboxItem" /> для каждого допустимого в коллекции индекса.</returns>
		// Token: 0x170003AB RID: 939
		public ToolboxItem this[int index]
		{
			get
			{
				return (ToolboxItem)base.InnerList[index];
			}
		}

		/// <summary>Указывает, содержит ли коллекция заданный объект <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Drawing.Design.ToolboxItem" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000DBA RID: 3514 RVA: 0x0001EFAF File Offset: 0x0001D1AF
		public bool Contains(ToolboxItem value)
		{
			return base.InnerList.Contains(value);
		}

		/// <summary>Копирует коллекцию в указанный массив, начинающийся определенным индексом назначения.</summary>
		/// <param name="array">Массив для копирования данных.</param>
		/// <param name="index">Индекс, начиная с которого будет выполняться копирование.</param>
		// Token: 0x06000DBB RID: 3515 RVA: 0x0001EFBD File Offset: 0x0001D1BD
		public void CopyTo(ToolboxItem[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}

		/// <summary>Получает индекс указанного объекта <see cref="T:System.Drawing.Design.ToolboxItem" />, если он содержится в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, получающий индекс в коллекции.</param>
		/// <returns>Индекс указанного объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x06000DBC RID: 3516 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		public int IndexOf(ToolboxItem value)
		{
			return base.InnerList.IndexOf(value);
		}
	}
}
