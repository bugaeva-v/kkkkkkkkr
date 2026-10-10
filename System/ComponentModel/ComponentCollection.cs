using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Предоставляет доступный только для чтения контейнер для коллекции объектов <see cref="T:System.ComponentModel.IComponent" />.</summary>
	// Token: 0x02000365 RID: 869
	public class ComponentCollection : ReadOnlyCollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ComponentCollection" />, используя указанный массив компонентов.</summary>
		/// <param name="components">Массив объектов <see cref="T:System.ComponentModel.IComponent" />, используемых для инициализации коллекции.</param>
		// Token: 0x06001CDD RID: 7389 RVA: 0x0004DD5A File Offset: 0x0004BF5A
		public ComponentCollection(IComponent[] components)
		{
			base.InnerList.AddRange(components);
		}

		/// <summary>Возвращает любой компонент коллекции, соответствующий заданному имени.</summary>
		/// <param name="name">Имя получаемого объекта <see cref="T:System.ComponentModel.IComponent" />.</param>
		/// <returns>Компонент, имя которого соответствует имени, заданному параметром <paramref name="name" />, или <see langword="null" />, если названный компонент не удалось найти в коллекции.</returns>
		// Token: 0x170005D0 RID: 1488
		public virtual IComponent this[string name]
		{
			get
			{
				if (name != null)
				{
					foreach (object obj in ((IEnumerable)base.InnerList))
					{
						IComponent component = (IComponent)obj;
						if (component != null && component.Site != null && component.Site.Name != null && string.Equals(component.Site.Name, name, StringComparison.OrdinalIgnoreCase))
						{
							return component;
						}
					}
				}
				return null;
			}
		}

		/// <summary>Возвращает из коллекции объект <see cref="T:System.ComponentModel.Component" /> по указанному индексу.</summary>
		/// <param name="index">Индекс возвращаемого элемента <see cref="T:System.ComponentModel.Component" /> коллекции.</param>
		/// <returns>Параметр <see cref="T:System.ComponentModel.IComponent" /> по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Если заданный индекс выходит за пределы диапазона индексов коллекции.</exception>
		// Token: 0x170005D1 RID: 1489
		public virtual IComponent this[int index]
		{
			get
			{
				return (IComponent)base.InnerList[index];
			}
		}

		/// <summary>Копирует всю коллекцию в массив, начиная запись с заданного индекса массива.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.ComponentModel.IComponent" /> для копирования в коллекцию.</param>
		/// <param name="index">Индекс массива <paramref name="array" />, с которого должно начинаться копирование.</param>
		// Token: 0x06001CE0 RID: 7392 RVA: 0x0004DD9D File Offset: 0x0004BF9D
		public void CopyTo(IComponent[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}
	}
}
