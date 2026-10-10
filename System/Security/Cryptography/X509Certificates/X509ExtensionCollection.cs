using System;
using System.Collections;
using Mono.Security;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />. Этот класс не наследуется.</summary>
	// Token: 0x020002E3 RID: 739
	public sealed class X509ExtensionCollection : ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		// Token: 0x0600177E RID: 6014 RVA: 0x0005D274 File Offset: 0x0005B474
		public X509ExtensionCollection()
		{
			this._list = new ArrayList();
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0005D288 File Offset: 0x0005B488
		internal X509ExtensionCollection(X509Certificate cert)
		{
			this._list = new ArrayList(cert.Extensions.Count);
			if (cert.Extensions.Count == 0)
			{
				return;
			}
			foreach (object obj in cert.Extensions)
			{
				X509Extension x509Extension = (X509Extension)obj;
				bool critical = x509Extension.Critical;
				string oid = x509Extension.Oid;
				byte[] array = null;
				ASN1 value = x509Extension.Value;
				if (value.Tag == 4 && value.Count > 0)
				{
					array = value[0].GetBytes();
				}
				X509Extension x509Extension2 = (X509Extension)CryptoConfig.CreateFromName(oid, new object[]
				{
					new AsnEncodedData(oid, array ?? X509ExtensionCollection.Empty),
					critical
				});
				if (x509Extension2 == null)
				{
					x509Extension2 = new X509Extension(oid, array ?? X509ExtensionCollection.Empty, critical);
				}
				this._list.Add(x509Extension2);
			}
		}

		/// <summary>Получает число объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <returns>Целое число, представляющее число объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Возвращает значение, указывающее, гарантируется ли потокобезопасность коллекции.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция является потокобезопасной; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x0005D3B1 File Offset: 0x0005B5B1
		public bool IsSynchronized
		{
			get
			{
				return this._list.IsSynchronized;
			}
		}

		/// <summary>Получает объект, который можно использовать для синхронизации доступа к объекту <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <returns>Объект, который можно использовать для синхронизации доступа к объекту <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x000075E1 File Offset: 0x000057E1
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> по указанному индексу.</summary>
		/// <param name="index">Расположение объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> для извлечения.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> больше или равно длине массива.</exception>
		// Token: 0x17000497 RID: 1175
		public X509Extension this[int index]
		{
			get
			{
				if (index < 0)
				{
					throw new InvalidOperationException("index");
				}
				return (X509Extension)this._list[index];
			}
		}

		/// <summary>Получает первый объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />, значение или понятное имя которого определяется идентификатором объекта.</summary>
		/// <param name="oid">Идентификатор объекта расширения для извлечения.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</returns>
		// Token: 0x17000498 RID: 1176
		public X509Extension this[string oid]
		{
			get
			{
				if (oid == null)
				{
					throw new ArgumentNullException("oid");
				}
				if (this._list.Count == 0 || oid.Length == 0)
				{
					return null;
				}
				foreach (object obj in this._list)
				{
					X509Extension x509Extension = (X509Extension)obj;
					if (x509Extension.Oid.Value.Equals(oid))
					{
						return x509Extension;
					}
				}
				return null;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> в объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <param name="extension">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />, добавляемый в объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</param>
		/// <returns>Индекс, по которому был добавлен параметр <paramref name="extension" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="extension" /> имеет значение <see langword="null" />;</exception>
		// Token: 0x06001785 RID: 6021 RVA: 0x0005D474 File Offset: 0x0005B674
		public int Add(X509Extension extension)
		{
			if (extension == null)
			{
				throw new ArgumentNullException("extension");
			}
			return this._list.Add(extension);
		}

		/// <summary>Копирует элемент коллекции в массив, начиная с заданного индекса.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</param>
		/// <param name="index">Расположение в массиве, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentException">В параметре <paramref name="index" /> содержится строка нулевой длины или недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="index" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> задает значение, не входящее в массив.</exception>
		// Token: 0x06001786 RID: 6022 RVA: 0x0005D490 File Offset: 0x0005B690
		public void CopyTo(X509Extension[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("negative index");
			}
			if (index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index >= array.Length");
			}
			this._list.CopyTo(array, index);
		}

		/// <summary>Копирует коллекцию в массив, начиная с заданного индекса.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</param>
		/// <param name="index">Расположение в массиве, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentException">В параметре <paramref name="index" /> содержится строка нулевой длины или недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="index" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> задает значение, не входящее в массив.</exception>
		// Token: 0x06001787 RID: 6023 RVA: 0x0005D4CD File Offset: 0x0005B6CD
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("negative index");
			}
			if (index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index >= array.Length");
			}
			this._list.CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель, который может выполнять итерацию объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator" />, используемый для выполнения итерации в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		// Token: 0x06001788 RID: 6024 RVA: 0x0005D50D File Offset: 0x0005B70D
		public X509ExtensionEnumerator GetEnumerator()
		{
			return new X509ExtensionEnumerator(this._list);
		}

		/// <summary>Возвращает перечислитель, который может выполнять итерацию объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, используемый для выполнения итерации в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		// Token: 0x06001789 RID: 6025 RVA: 0x0005D50D File Offset: 0x0005B70D
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new X509ExtensionEnumerator(this._list);
		}

		// Token: 0x04000D29 RID: 3369
		private static byte[] Empty = new byte[0];

		// Token: 0x04000D2A RID: 3370
		private ArrayList _list;
	}
}
