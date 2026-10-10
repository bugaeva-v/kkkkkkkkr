using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation
{
	/// <summary>Хранит набор типов <see cref="T:System.Net.NetworkInformation.IPAddressInformation" />.</summary>
	// Token: 0x020006E1 RID: 1761
	public class IPAddressInformationCollection : ICollection<IPAddressInformation>, IEnumerable<IPAddressInformation>, IEnumerable
	{
		// Token: 0x0600387C RID: 14460 RVA: 0x000C81DB File Offset: 0x000C63DB
		internal IPAddressInformationCollection()
		{
		}

		/// <summary>Копирует коллекцию в указанный массив.</summary>
		/// <param name="array">Одномерный массив, в который копируется коллекция.</param>
		/// <param name="offset">Индекс в массиве <paramref name="array" /> (начиная с нуля), с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Количество элементов в это массиве <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> превышает доступное место, начиная с индекса <paramref name="offset" />, до конца целевого массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Элементы в этом массиве <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> нельзя автоматически привести к типу целевого массива <paramref name="array" />.</exception>
		// Token: 0x0600387D RID: 14461 RVA: 0x000C81EE File Offset: 0x000C63EE
		public virtual void CopyTo(IPAddressInformation[] array, int offset)
		{
			this.addresses.CopyTo(array, offset);
		}

		/// <summary>Возвращает число типов <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> в данной коллекции.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, которое содержит число типов <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> в данной коллекции.</returns>
		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x000C81FD File Offset: 0x000C63FD
		public virtual int Count
		{
			get
			{
				return this.addresses.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, доступна ли данная коллекция только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x0000390E File Offset: 0x00001B0E
		public virtual bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		/// <param name="address">Объект, добавляемый в коллекцию.</param>
		// Token: 0x06003880 RID: 14464 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Add(IPAddressInformation address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x000C820A File Offset: 0x000C640A
		internal void InternalAdd(IPAddressInformation address)
		{
			this.addresses.Add(address);
		}

		/// <summary>Проверяет, содержит ли коллекция указанный объект <see cref="T:System.Net.NetworkInformation.IPAddressInformation" />.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.NetworkInformation.IPAddressInformation" />, для которого выполняется поиск в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> присутствует в коллекции; в противном случае. <see langword="false" />.</returns>
		// Token: 0x06003882 RID: 14466 RVA: 0x000C8218 File Offset: 0x000C6418
		public virtual bool Contains(IPAddressInformation address)
		{
			return this.addresses.Contains(address);
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> из этой коллекции.</returns>
		// Token: 0x06003883 RID: 14467 RVA: 0x000C8226 File Offset: 0x000C6426
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> из этой коллекции.</returns>
		// Token: 0x06003884 RID: 14468 RVA: 0x000C822E File Offset: 0x000C642E
		public virtual IEnumerator<IPAddressInformation> GetEnumerator()
		{
			return this.addresses.GetEnumerator();
		}

		/// <summary>Возвращает элемент <see cref="T:System.Net.NetworkInformation.IPAddressInformation" />, содержащийся в коллекции по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс элемента.</param>
		/// <returns>Класс <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> в заданном местоположении.</returns>
		// Token: 0x17000BDC RID: 3036
		public virtual IPAddressInformation this[int index]
		{
			get
			{
				return this.addresses[index];
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		/// <param name="address">Удаляемый объект.</param>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		// Token: 0x06003886 RID: 14470 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual bool Remove(IPAddressInformation address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		// Token: 0x06003887 RID: 14471 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Clear()
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x04002153 RID: 8531
		private Collection<IPAddressInformation> addresses = new Collection<IPAddressInformation>();
	}
}
