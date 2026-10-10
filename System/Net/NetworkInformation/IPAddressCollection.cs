using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation
{
	/// <summary>Хранит набор типов <see cref="T:System.Net.IPAddress" />.</summary>
	// Token: 0x020006DF RID: 1759
	public class IPAddressCollection : ICollection<IPAddress>, IEnumerable<IPAddress>, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.IPAddressCollection" />.</summary>
		// Token: 0x0600386C RID: 14444 RVA: 0x000C816D File Offset: 0x000C636D
		protected internal IPAddressCollection()
		{
		}

		/// <summary>Копирует элементы данной коллекции в одномерный массив типа <see cref="T:System.Net.IPAddress" />.</summary>
		/// <param name="array">Одномерный массив, в который копируется коллекция.</param>
		/// <param name="offset">Индекс в массиве <paramref name="array" /> (начиная с нуля), с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Количество элементов в это массиве <see cref="T:System.Net.NetworkInformation.IPAddressCollection" /> превышает доступное место, начиная с индекса <paramref name="offset" />, до конца целевого массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Элементы в этом массиве <see cref="T:System.Net.NetworkInformation.IPAddressCollection" /> нельзя автоматически привести к типу целевого массива <paramref name="array" />.</exception>
		// Token: 0x0600386D RID: 14445 RVA: 0x000C8180 File Offset: 0x000C6380
		public virtual void CopyTo(IPAddress[] array, int offset)
		{
			this.addresses.CopyTo(array, offset);
		}

		/// <summary>Возвращает число типов <see cref="T:System.Net.IPAddress" /> в данной коллекции.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, которое содержит число типов <see cref="T:System.Net.IPAddress" /> в данной коллекции.</returns>
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x000C818F File Offset: 0x000C638F
		public virtual int Count
		{
			get
			{
				return this.addresses.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, доступна ли данная коллекция только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600386F RID: 14447 RVA: 0x0000390E File Offset: 0x00001B0E
		public virtual bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		/// <param name="address">Объект, добавляемый в коллекцию.</param>
		// Token: 0x06003870 RID: 14448 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Add(IPAddress address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x000C819C File Offset: 0x000C639C
		internal void InternalAdd(IPAddress address)
		{
			this.addresses.Add(address);
		}

		/// <summary>Проверяет, содержит ли коллекция указанный объект <see cref="T:System.Net.IPAddress" />.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.IPAddress" />, для которого выполняется поиск в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.IPAddress" /> присутствует в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003872 RID: 14450 RVA: 0x000C81AA File Offset: 0x000C63AA
		public virtual bool Contains(IPAddress address)
		{
			return this.addresses.Contains(address);
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.IPAddressCollection" /> из этой коллекции.</returns>
		// Token: 0x06003873 RID: 14451 RVA: 0x000C81B8 File Offset: 0x000C63B8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.IPAddressCollection" /> из этой коллекции.</returns>
		// Token: 0x06003874 RID: 14452 RVA: 0x000C81C0 File Offset: 0x000C63C0
		public virtual IEnumerator<IPAddress> GetEnumerator()
		{
			return this.addresses.GetEnumerator();
		}

		/// <summary>Получает объект <see cref="T:System.Net.IPAddress" /> по указанному индексу коллекции.</summary>
		/// <param name="index">Интересующий индекс.</param>
		/// <returns>Объект <see cref="T:System.Net.IPAddress" />, содержащийся в коллекции по определенному индексу.</returns>
		// Token: 0x17000BD6 RID: 3030
		public virtual IPAddress this[int index]
		{
			get
			{
				return this.addresses[index];
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		/// <param name="address">Удаляемый объект.</param>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		// Token: 0x06003876 RID: 14454 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual bool Remove(IPAddress address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		// Token: 0x06003877 RID: 14455 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Clear()
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x04002152 RID: 8530
		private Collection<IPAddress> addresses = new Collection<IPAddress>();
	}
}
