using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation
{
	/// <summary>Хранит набор типов <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" />.</summary>
	// Token: 0x020006EF RID: 1775
	public class MulticastIPAddressInformationCollection : ICollection<MulticastIPAddressInformation>, IEnumerable<MulticastIPAddressInformation>, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformationCollection" />.</summary>
		// Token: 0x0600392C RID: 14636 RVA: 0x000C8286 File Offset: 0x000C6486
		protected internal MulticastIPAddressInformationCollection()
		{
		}

		/// <summary>Копирует элементы данной коллекции в одномерный массив типа <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" />.</summary>
		/// <param name="array">Одномерный массив, в который копируется коллекция.</param>
		/// <param name="offset">Индекс в массиве <paramref name="array" /> (начиная с нуля), с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Количество элементов в это массиве <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" /> превышает доступное место, начиная с индекса <paramref name="count" />, до конца целевого массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Элементы в этом массиве <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" /> нельзя автоматически привести к типу целевого массива <paramref name="array" />.</exception>
		// Token: 0x0600392D RID: 14637 RVA: 0x000C8299 File Offset: 0x000C6499
		public virtual void CopyTo(MulticastIPAddressInformation[] array, int offset)
		{
			this.addresses.CopyTo(array, offset);
		}

		/// <summary>Возвращает число типов <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" /> в данной коллекции.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, которое содержит число типов <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" /> в данной коллекции.</returns>
		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x000C82A8 File Offset: 0x000C64A8
		public virtual int Count
		{
			get
			{
				return this.addresses.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, доступна ли данная коллекция только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x0000390E File Offset: 0x00001B0E
		public virtual bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, потому что коллекция доступна только для чтения и в нее нельзя добавлять элементы.</summary>
		/// <param name="address">Объект, добавляемый в коллекцию.</param>
		// Token: 0x06003930 RID: 14640 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Add(MulticastIPAddressInformation address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x000C82B5 File Offset: 0x000C64B5
		internal void InternalAdd(MulticastIPAddressInformation address)
		{
			this.addresses.Add(address);
		}

		/// <summary>Проверяет, содержит ли коллекция указанный объект <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" />.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" />, для которого выполняется поиск в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" /> присутствует в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003932 RID: 14642 RVA: 0x000C82C3 File Offset: 0x000C64C3
		public virtual bool Contains(MulticastIPAddressInformation address)
		{
			return this.addresses.Contains(address);
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> из этой коллекции.</returns>
		// Token: 0x06003933 RID: 14643 RVA: 0x000C82D1 File Offset: 0x000C64D1
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> из этой коллекции.</returns>
		// Token: 0x06003934 RID: 14644 RVA: 0x000C82D9 File Offset: 0x000C64D9
		public virtual IEnumerator<MulticastIPAddressInformation> GetEnumerator()
		{
			return this.addresses.GetEnumerator();
		}

		/// <summary>Получает объект <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" /> по указанному индексу коллекции.</summary>
		/// <param name="index">Интересующий индекс.</param>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformation" />, содержащийся в коллекции по определенному индексу.</returns>
		// Token: 0x17000C65 RID: 3173
		public virtual MulticastIPAddressInformation this[int index]
		{
			get
			{
				return this.addresses[index];
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, потому что коллекция доступна только для чтения и из нее нельзя удалять элементы.</summary>
		/// <param name="address">Удаляемый объект.</param>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		// Token: 0x06003936 RID: 14646 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual bool Remove(MulticastIPAddressInformation address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, потому что коллекция доступна только для чтения и из нее нельзя удалять элементы.</summary>
		// Token: 0x06003937 RID: 14647 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Clear()
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x0400218A RID: 8586
		private Collection<MulticastIPAddressInformation> addresses = new Collection<MulticastIPAddressInformation>();
	}
}
