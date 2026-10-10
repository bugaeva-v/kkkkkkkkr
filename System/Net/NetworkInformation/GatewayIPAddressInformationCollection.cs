using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation
{
	/// <summary>Хранит набор типов <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" />.</summary>
	// Token: 0x020006DE RID: 1758
	public class GatewayIPAddressInformationCollection : ICollection<GatewayIPAddressInformation>, IEnumerable<GatewayIPAddressInformation>, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformationCollection" />.</summary>
		// Token: 0x06003860 RID: 14432 RVA: 0x000C80EE File Offset: 0x000C62EE
		protected internal GatewayIPAddressInformationCollection()
		{
		}

		/// <summary>Копирует элементы данной коллекции в одномерный массив типа <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" />.</summary>
		/// <param name="array">Одномерный массив, в который копируется коллекция.</param>
		/// <param name="offset">Индекс в массиве <paramref name="array" /> (начиная с нуля), с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Количество элементов в это массиве <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> превышает доступное место, начиная с индекса <paramref name="count" />, до конца целевого массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Элементы в этом массиве <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> нельзя автоматически привести к типу целевого массива <paramref name="array" />.</exception>
		// Token: 0x06003861 RID: 14433 RVA: 0x000C8101 File Offset: 0x000C6301
		public virtual void CopyTo(GatewayIPAddressInformation[] array, int offset)
		{
			this.addresses.CopyTo(array, offset);
		}

		/// <summary>Возвращает число типов <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> в данной коллекции.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, которое содержит число типов <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> в данной коллекции.</returns>
		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06003862 RID: 14434 RVA: 0x000C8110 File Offset: 0x000C6310
		public virtual int Count
		{
			get
			{
				return this.addresses.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, доступна ли данная коллекция только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x0000390E File Offset: 0x00001B0E
		public virtual bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> по указанному индексу коллекции.</summary>
		/// <param name="index">Интересующий индекс.</param>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" />, содержащийся в коллекции по определенному индексу.</returns>
		// Token: 0x17000BD3 RID: 3027
		public virtual GatewayIPAddressInformation this[int index]
		{
			get
			{
				return this.addresses[index];
			}
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		/// <param name="address">Объект, добавляемый в коллекцию.</param>
		// Token: 0x06003865 RID: 14437 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Add(GatewayIPAddressInformation address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x000C813C File Offset: 0x000C633C
		internal void InternalAdd(GatewayIPAddressInformation address)
		{
			this.addresses.Add(address);
		}

		/// <summary>Проверяет, содержит ли коллекция указанный объект <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" />.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" />, для которого выполняется поиск в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> присутствует в коллекции; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003867 RID: 14439 RVA: 0x000C814A File Offset: 0x000C634A
		public virtual bool Contains(GatewayIPAddressInformation address)
		{
			return this.addresses.Contains(address);
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> из этой коллекции.</returns>
		// Token: 0x06003868 RID: 14440 RVA: 0x000C8158 File Offset: 0x000C6358
		public virtual IEnumerator<GatewayIPAddressInformation> GetEnumerator()
		{
			return this.addresses.GetEnumerator();
		}

		/// <summary>Возвращает объект, который может использоваться для выполнения итерации элементов данной коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к типам <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> из этой коллекции.</returns>
		// Token: 0x06003869 RID: 14441 RVA: 0x000C8165 File Offset: 0x000C6365
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		/// <param name="address">Удаляемый объект.</param>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		// Token: 0x0600386A RID: 14442 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual bool Remove(GatewayIPAddressInformation address)
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		/// <summary>Генерирует исключение <see cref="T:System.NotSupportedException" />, поскольку данная операция не поддерживается для этой коллекции.</summary>
		// Token: 0x0600386B RID: 14443 RVA: 0x000C812B File Offset: 0x000C632B
		public virtual void Clear()
		{
			throw new NotSupportedException(SR.GetString("The collection is read-only."));
		}

		// Token: 0x04002151 RID: 8529
		private Collection<GatewayIPAddressInformation> addresses = new Collection<GatewayIPAddressInformation>();
	}
}
