using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation
{
	/// <summary>Хранит набор типов <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" />.</summary>
	// Token: 0x0200070A RID: 1802
	public class UnicastIPAddressInformationCollection : ICollection<UnicastIPAddressInformation>, IEnumerable<UnicastIPAddressInformation>, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformationCollection" />.</summary>
		// Token: 0x060039BA RID: 14778 RVA: 0x000C8E41 File Offset: 0x000C7041
		protected internal UnicastIPAddressInformationCollection()
		{
		}

		/// <summary>Копирует элементы данной коллекции в одномерный массив типа <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" />.</summary>
		/// <param name="array">Одномерный массив, в который копируется коллекция.</param>
		/// <param name="offset">Индекс в массиве <paramref name="array" /> (начиная с нуля), с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Количество элементов в это массиве <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformationCollection" /> превышает доступное место, начиная с индекса <paramref name="offset" />, до конца целевого массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Элементы в этом массиве <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformationCollection" /> нельзя автоматически привести к типу целевого массива <paramref name="array" />.</exception>
		// Token: 0x060039BB RID: 14779 RVA: 0x000C8E54 File Offset: 0x000C7054
		public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset)
		{
			this.addresses.CopyTo(array, offset);
		}

		/// <summary>Возвращает число типов <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> в данной коллекции.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, которое содержит число типов <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> в данной коллекции.</returns>
		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x000C8E63 File Offset: 0x000C7063
		public virtual int Count
		{
			get
			{
				return this.addresses.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, доступна ли данная коллекция только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060039BD RID: 14781 RVA: 0x0000390E File Offset: 0x00001B0E
		public virtual bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		/// <param name="address">Объект, добавляемый в коллекцию.</param>
		// Token: 0x060039BE RID: 14782 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Add(UnicastIPAddressInformation address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x000C8E70 File Offset: 0x000C7070
		internal void InternalAdd(UnicastIPAddressInformation address)
		{
			this.addresses.Add(address);
		}

		/// <summary>Проверяет, содержит ли коллекция указанный объект <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" />.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" />, для которого выполняется поиск в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> присутствует в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060039C0 RID: 14784 RVA: 0x000C8E7E File Offset: 0x000C707E
		public virtual bool Contains(UnicastIPAddressInformation address)
		{
			return this.addresses.Contains(address);
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> из этой коллекции.</returns>
		// Token: 0x060039C1 RID: 14785 RVA: 0x000C8E8C File Offset: 0x000C708C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> из этой коллекции.</returns>
		// Token: 0x060039C2 RID: 14786 RVA: 0x000C8E94 File Offset: 0x000C7094
		public virtual IEnumerator<UnicastIPAddressInformation> GetEnumerator()
		{
			return this.addresses.GetEnumerator();
		}

		/// <summary>Возвращает экземпляр <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" />, содержащийся в коллекции по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс элемента.</param>
		/// <returns>Класс <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> в заданном местоположении.</returns>
		// Token: 0x17000CAB RID: 3243
		public virtual UnicastIPAddressInformation this[int index]
		{
			get
			{
				return this.addresses[index];
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, потому что коллекция доступна только для чтения и из нее нельзя удалять элементы.</summary>
		/// <param name="address">Удаляемый объект.</param>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		// Token: 0x060039C4 RID: 14788 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual bool Remove(UnicastIPAddressInformation address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		// Token: 0x060039C5 RID: 14789 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Clear()
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x040021DC RID: 8668
		private Collection<UnicastIPAddressInformation> addresses = new Collection<UnicastIPAddressInformation>();
	}
}
