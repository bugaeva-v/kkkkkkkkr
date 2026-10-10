using System;
using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает коллекцию, которая хранит объекты <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
	// Token: 0x020002D6 RID: 726
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		// Token: 0x060016D0 RID: 5840 RVA: 0x0004E358 File Offset: 0x0004C558
		public X509CertificateCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> из массива объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, которыми следует инициализировать новый объект.</param>
		// Token: 0x060016D1 RID: 5841 RVA: 0x0005AF2C File Offset: 0x0005912C
		public X509CertificateCollection(X509Certificate[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> из другого <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> для инициализации нового объекта.</param>
		// Token: 0x060016D2 RID: 5842 RVA: 0x0005AF3B File Offset: 0x0005913B
		public X509CertificateCollection(X509CertificateCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает запись по указанному индексу в текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс записи для расположения в текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> по указанному индексу в текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x17000461 RID: 1121
		public X509Certificate this[int index]
		{
			get
			{
				return (X509Certificate)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		/// <summary>Добавляет <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с указанным значением в текущую коллекцию <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">Сертификат <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, добавляемый в текущую коллекцию <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</param>
		/// <returns>Индекс в текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, по которому был вставлен новый сертификат <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</returns>
		// Token: 0x060016D5 RID: 5845 RVA: 0x0005AF5D File Offset: 0x0005915D
		public int Add(X509Certificate value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return base.InnerList.Add(value);
		}

		/// <summary>Копирует элементы массива с типом <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в конец текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">Массив с типом <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, содержащий объекты для добавления в текущую коллекцию <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060016D6 RID: 5846 RVA: 0x0005AF7C File Offset: 0x0005917C
		public void AddRange(X509Certificate[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			for (int i = 0; i < value.Length; i++)
			{
				base.InnerList.Add(value[i]);
			}
		}

		/// <summary>Копирует элементы указанной коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> в конец текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, содержащая объекты для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060016D7 RID: 5847 RVA: 0x0005AFB4 File Offset: 0x000591B4
		public void AddRange(X509CertificateCollection value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			for (int i = 0; i < value.InnerList.Count; i++)
			{
				base.InnerList.Add(value[i]);
			}
		}

		/// <summary>Получает значение, указывающее, содержит ли текущая коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> указанный сертификат <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</param>
		/// <returns>Значение <see langword="true" />, если сертификат <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> содержится в этой коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060016D8 RID: 5848 RVA: 0x0005AFF8 File Offset: 0x000591F8
		public bool Contains(X509Certificate value)
		{
			if (value == null)
			{
				return false;
			}
			byte[] certHash = value.GetCertHash();
			for (int i = 0; i < base.InnerList.Count; i++)
			{
				X509Certificate x509Certificate = (X509Certificate)base.InnerList[i];
				if (this.Compare(x509Certificate.GetCertHash(), certHash))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Копирует значения <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> из текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> в экземпляр одномерного массива <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, который является целевым для значений, копируемых из <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</param>
		/// <param name="index">Индекс в <paramref name="array" />, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> больше, чем может поместиться в свободном пространстве между индексом <paramref name="arrayIndex" /> и концом массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="arrayIndex" /> меньше, чем нижняя граница параметра <paramref name="array" />.</exception>
		// Token: 0x060016D9 RID: 5849 RVA: 0x0004E442 File Offset: 0x0004C642
		public void CopyTo(X509Certificate[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель, выполняющий итерацию по коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <returns>Перечислитель подэлементов <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> можно использовать для прохода по коллекции.</returns>
		// Token: 0x060016DA RID: 5850 RVA: 0x0005B04B File Offset: 0x0005924B
		public new X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			return new X509CertificateCollection.X509CertificateEnumerator(this);
		}

		/// <summary>Строит хэш-значение на основе всех значений в текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <returns>Хэш-значение на основе всех значений в текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</returns>
		// Token: 0x060016DB RID: 5851 RVA: 0x0005B053 File Offset: 0x00059253
		public override int GetHashCode()
		{
			return base.InnerList.GetHashCode();
		}

		/// <summary>Возвращает индекс указанного объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в текущей <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</param>
		/// <returns>Индекс <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, указанного параметром <paramref name="value" /> в <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, если он найден; в противном случае — значение -1.</returns>
		// Token: 0x060016DC RID: 5852 RVA: 0x0004E451 File Offset: 0x0004C651
		public int IndexOf(X509Certificate value)
		{
			return base.InnerList.IndexOf(value);
		}

		/// <summary>Вставляет <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в текущую коллекцию <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить <paramref name="value" />.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</param>
		// Token: 0x060016DD RID: 5853 RVA: 0x0004E45F File Offset: 0x0004C65F
		public void Insert(int index, X509Certificate value)
		{
			base.InnerList.Insert(index, value);
		}

		/// <summary>Удаляет определенный <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> из текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">Сертификат <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, который требуется удалить из текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">Сертификат <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, заданный параметром <paramref name="value" />, не найден в текущей коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</exception>
		// Token: 0x060016DE RID: 5854 RVA: 0x0005B060 File Offset: 0x00059260
		public void Remove(X509Certificate value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this.IndexOf(value) == -1)
			{
				throw new ArgumentException("value", Locale.GetText("Not part of the collection."));
			}
			base.InnerList.Remove(value);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0005B09C File Offset: 0x0005929C
		private bool Compare(byte[] array1, byte[] array2)
		{
			if (array1 == null && array2 == null)
			{
				return true;
			}
			if (array1 == null || array2 == null)
			{
				return false;
			}
			if (array1.Length != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array1.Length; i++)
			{
				if (array1[i] != array2[i])
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Перечисляет объекты <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		// Token: 0x020002D7 RID: 727
		public class X509CertificateEnumerator : IEnumerator
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator" /> для указанного объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
			/// <param name="mappings">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> для перечисления.</param>
			// Token: 0x060016E0 RID: 5856 RVA: 0x0005B0DC File Offset: 0x000592DC
			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
				this.enumerator = ((IEnumerable)mappings).GetEnumerator();
			}

			/// <summary>Получает текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
			/// <returns>Текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0005B0F0 File Offset: 0x000592F0
			public X509Certificate Current
			{
				get
				{
					return (X509Certificate)this.enumerator.Current;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.IEnumerator.Current" />.</summary>
			/// <returns>Текущий объект сертификата X.509 в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0005B102 File Offset: 0x00059302
			object IEnumerator.Current
			{
				get
				{
					return this.enumerator.Current;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.IEnumerator.MoveNext" />.</summary>
			/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
			/// <exception cref="T:System.InvalidOperationException">Коллекция была изменена после создания перечислителя.</exception>
			// Token: 0x060016E3 RID: 5859 RVA: 0x0005B10F File Offset: 0x0005930F
			bool IEnumerator.MoveNext()
			{
				return this.enumerator.MoveNext();
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.IEnumerator.Reset" />.</summary>
			/// <exception cref="T:System.InvalidOperationException">Коллекция была изменена после создания перечислителя.</exception>
			// Token: 0x060016E4 RID: 5860 RVA: 0x0005B11C File Offset: 0x0005931C
			void IEnumerator.Reset()
			{
				this.enumerator.Reset();
			}

			/// <summary>Перемещает перечислитель к следующему элементу коллекции.</summary>
			/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
			/// <exception cref="T:System.InvalidOperationException">Коллекция была изменена после создания перечислителя.</exception>
			// Token: 0x060016E5 RID: 5861 RVA: 0x0005B10F File Offset: 0x0005930F
			public bool MoveNext()
			{
				return this.enumerator.MoveNext();
			}

			/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
			/// <exception cref="T:System.InvalidOperationException">Коллекция изменяется после создания экземпляра перечисления.</exception>
			// Token: 0x060016E6 RID: 5862 RVA: 0x0005B11C File Offset: 0x0005931C
			public void Reset()
			{
				this.enumerator.Reset();
			}

			// Token: 0x04000D00 RID: 3328
			private IEnumerator enumerator;
		}
	}
}
