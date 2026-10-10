using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" /> представляет набор объектов <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />. Класс <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" /> реализует интерфейс списка <see cref="T:System.Collections.ICollection" />.</summary>
	// Token: 0x0200006A RID: 106
	public sealed class CmsRecipientCollection : ICollection, IEnumerable
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		// Token: 0x06000382 RID: 898 RVA: 0x00010ED2 File Offset: 0x0000F0D2
		public CmsRecipientCollection()
		{
			this._recipients = new List<CmsRecipient>();
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.#ctor(System.Security.Cryptography.Pkcs.CmsRecipient)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" /> и добавляет к нему указанного получателя.</summary>
		/// <param name="recipient">Экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, представляющий указанного получателя CMS/PKCS 7.</param>
		// Token: 0x06000383 RID: 899 RVA: 0x00010EE5 File Offset: 0x0000F0E5
		public CmsRecipientCollection(CmsRecipient recipient)
		{
			this._recipients = new List<CmsRecipient>(1);
			this._recipients.Add(recipient);
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType,System.Security.Cryptography.X509Certificates.X509Certificate2Collection)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" /> и добавляет к нему получателя на основании указанного идентификатора субъекта и набора сертификатов, определяющих получателей.</summary>
		/// <param name="recipientIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий тип идентификатора субъекта.</param>
		/// <param name="certificates">Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, которая содержит сертификаты, определяющие получателей.</param>
		// Token: 0x06000384 RID: 900 RVA: 0x00010F08 File Offset: 0x0000F108
		public CmsRecipientCollection(SubjectIdentifierType recipientIdentifierType, X509Certificate2Collection certificates)
		{
			if (certificates == null)
			{
				throw new NullReferenceException();
			}
			this._recipients = new List<CmsRecipient>(certificates.Count);
			for (int i = 0; i < certificates.Count; i++)
			{
				this._recipients.Add(new CmsRecipient(recipientIdentifierType, certificates[i]));
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsRecipientCollection.Item(System.Int32)" /> возвращает объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, расположенный в коллекции по указанному индексу.</summary>
		/// <param name="index">Значение типа <see cref="T:System.Int32" />, представляющее индекс в коллекции. Индексация начинается с нуля.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение аргумента находится вне допустимого диапазона значений, определенного вызываемым методом.</exception>
		// Token: 0x170000BE RID: 190
		public CmsRecipient this[int index]
		{
			get
			{
				if (index < 0 || index >= this._recipients.Count)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				return this._recipients[index];
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsRecipientCollection.Count" /> возвращает число элементов в коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, представляющее число элементов в коллекции.</returns>
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00010F8E File Offset: 0x0000F18E
		public int Count
		{
			get
			{
				return this._recipients.Count;
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.Add(System.Security.Cryptography.Pkcs.CmsRecipient)" /> добавляет в коллекцию <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" /> одного получателя.</summary>
		/// <param name="recipient">Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, представляющий получателя, который добавляется в коллекцию <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</param>
		/// <returns>Если метод выполнен успешно, возвращается значение типа <see cref="T:System.Int32" />, представляющее отсчитываемый от нуля номер позиции, в которую помещается получатель.  
		/// При сбое метода создается исключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="recipient" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000387 RID: 903 RVA: 0x00010F9B File Offset: 0x0000F19B
		public int Add(CmsRecipient recipient)
		{
			if (recipient == null)
			{
				throw new ArgumentNullException("recipient");
			}
			int count = this._recipients.Count;
			this._recipients.Add(recipient);
			return count;
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.Remove(System.Security.Cryptography.Pkcs.CmsRecipient)" /> удаляет получателя из коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		/// <param name="recipient">Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, представляющий получателя, которого необходимо удалить из коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="recipient" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000388 RID: 904 RVA: 0x00010FC2 File Offset: 0x0000F1C2
		public void Remove(CmsRecipient recipient)
		{
			if (recipient == null)
			{
				throw new ArgumentNullException("recipient");
			}
			this._recipients.Remove(recipient);
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.GetEnumerator" /> возвращает объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator" />, который служит для перебора элементов коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</returns>
		// Token: 0x06000389 RID: 905 RVA: 0x00010FDF File Offset: 0x0000F1DF
		public CmsRecipientEnumerator GetEnumerator()
		{
			return new CmsRecipientEnumerator(this);
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.System#Collections#IEnumerable#GetEnumerator" /> возвращает объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator" />, который служит для перебора элементов коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</returns>
		// Token: 0x0600038A RID: 906 RVA: 0x00010FDF File Offset: 0x0000F1DF
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new CmsRecipientEnumerator(this);
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.CopyTo(System.Array,System.Int32)" /> копирует коллекцию <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" /> в массив.</summary>
		/// <param name="array">Объект <see cref="T:System.Array" />, в который должна быть скопирована коллекция <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, который обозначает позицию для копирования коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">Размер массива -   <paramref name="array" /> недостаточен для хранения указанных элементов.  
		/// – -или- 
		///
		/// <paramref name="array" /> не содержит достаточное количество измерений.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона элементов массива <paramref name="array" />.</exception>
		// Token: 0x0600038B RID: 907 RVA: 0x00010FE8 File Offset: 0x0000F1E8
		public void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			if (index < 0 || index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (index > array.Length - this.Count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			for (int i = 0; i < this.Count; i++)
			{
				array.SetValue(this[i], index);
				index++;
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientCollection.CopyTo(System.Security.Cryptography.Pkcs.CmsRecipient[],System.Int32)" /> копирует коллекцию <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" /> в массив <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, в который необходимо скопировать коллекцию <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</param>
		/// <param name="index">Отсчитываемый от нуля индекс массива <paramref name="array" /> объектов <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, в который копируется коллекция <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">Размер массива -   <paramref name="array" /> недостаточен для хранения указанных элементов.  
		/// – -или- 
		///
		/// <paramref name="array" /> не содержит достаточное количество измерений.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона элементов массива <paramref name="array" />.</exception>
		// Token: 0x0600038C RID: 908 RVA: 0x00011074 File Offset: 0x0000F274
		public void CopyTo(CmsRecipient[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (index > array.Length - this.Count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			this._recipients.CopyTo(array, index);
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsRecipientCollection.IsSynchronized" /> возвращает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным). Это свойство всегда возвращает значение <see langword="false" />, показывающее, что коллекция не является потокобезопасной.</summary>
		/// <returns>Значение типа <see cref="T:System.Boolean" />, равное <see langword="false" />, что означает, что коллекция не потокобезопасной.</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00002856 File Offset: 0x00000A56
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsRecipientCollection.SyncRoot" /> возвращает объект <see cref="T:System.Object" />, который используется для синхронизации доступа к коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который служит для синхронизации доступа к коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00002859 File Offset: 0x00000A59
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000266 RID: 614
		private readonly List<CmsRecipient> _recipients;
	}
}
