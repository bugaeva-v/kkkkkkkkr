using System;
using System.Collections;
using System.Globalization;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />. Этот класс не наследуется.</summary>
	// Token: 0x020002D1 RID: 721
	public class X509Certificate2Collection : X509CertificateCollection
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> без дополнительной информации <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		// Token: 0x06001662 RID: 5730 RVA: 0x00059C1B File Offset: 0x00057E1B
		public X509Certificate2Collection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, используя заданную коллекцию сертификатов.</summary>
		/// <param name="certificates">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</param>
		// Token: 0x06001663 RID: 5731 RVA: 0x00059C23 File Offset: 0x00057E23
		public X509Certificate2Collection(X509Certificate2Collection certificates)
		{
			this.AddRange(certificates);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> с помощью объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, с которого начинается коллекция.</param>
		// Token: 0x06001664 RID: 5732 RVA: 0x00059C32 File Offset: 0x00057E32
		public X509Certificate2Collection(X509Certificate2 certificate)
		{
			this.Add(certificate);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, используя массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		/// <param name="certificates">Массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		// Token: 0x06001665 RID: 5733 RVA: 0x00059C42 File Offset: 0x00057E42
		public X509Certificate2Collection(X509Certificate2[] certificates)
		{
			this.AddRange(certificates);
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="index" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x17000437 RID: 1079
		public X509Certificate2 this[int index]
		{
			get
			{
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("negative index");
				}
				if (index >= base.InnerList.Count)
				{
					throw new ArgumentOutOfRangeException("index >= Count");
				}
				return (X509Certificate2)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		/// <summary>Добавляет объект в конец очереди <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="certificate">Сертификат X.509 представлен в качестве объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		/// <returns>Индекс <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, по которому добавлен параметр <paramref name="certificate" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001668 RID: 5736 RVA: 0x00059C8C File Offset: 0x00057E8C
		public int Add(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			return base.InnerList.Add(certificate);
		}

		/// <summary>Добавляет несколько объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> в массиве в объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="certificates">Массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificates" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001669 RID: 5737 RVA: 0x00059CA8 File Offset: 0x00057EA8
		[MonoTODO("Method isn't transactional (like documented)")]
		public void AddRange(X509Certificate2[] certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificates");
			}
			for (int i = 0; i < certificates.Length; i++)
			{
				base.InnerList.Add(certificates[i]);
			}
		}

		/// <summary>Добавляет несколько объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> к другому объекту <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="certificates">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificates" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600166A RID: 5738 RVA: 0x00059CE0 File Offset: 0x00057EE0
		[MonoTODO("Method isn't transactional (like documented)")]
		public void AddRange(X509Certificate2Collection certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificates");
			}
			base.InnerList.AddRange(certificates);
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> указанный сертификат.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, который требуется найти в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> содержит заданный объект <paramref name="certificate" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600166B RID: 5739 RVA: 0x00059CFC File Offset: 0x00057EFC
		public bool Contains(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			using (IEnumerator enumerator = base.InnerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((X509Certificate2)enumerator.Current).Equals(certificate))
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>Экспортирует сведения о сертификате X.509 в массив байтов.</summary>
		/// <param name="contentType">Поддерживаемый объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />.</param>
		/// <returns>Сведения о сертификате X.509 в массиве байтов.</returns>
		// Token: 0x0600166C RID: 5740 RVA: 0x00059D6C File Offset: 0x00057F6C
		[MonoTODO("only support X509ContentType.Cert")]
		public byte[] Export(X509ContentType contentType)
		{
			return this.Export(contentType, null);
		}

		/// <summary>Экспортирует сведения о сертификате X.509 в массив байтов, используя пароль.</summary>
		/// <param name="contentType">Поддерживаемый объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />.</param>
		/// <param name="password">Строка, используемая для защиты массива байтов.</param>
		/// <returns>Сведения о сертификате X.509 в массиве байтов.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Нечитаемый сертификат, недопустимое содержимое или, если используется сертификат с паролем, ошибка экспорта закрытого ключа из-за неправильного пароля.</exception>
		// Token: 0x0600166D RID: 5741 RVA: 0x00059D78 File Offset: 0x00057F78
		[MonoTODO("only support X509ContentType.Cert")]
		public byte[] Export(X509ContentType contentType, string password)
		{
			switch (contentType)
			{
			case X509ContentType.Cert:
			case X509ContentType.SerializedCert:
			case X509ContentType.Pfx:
				if (base.Count > 0)
				{
					return this[base.Count - 1].Export(contentType, password);
				}
				break;
			case X509ContentType.SerializedStore:
			case X509ContentType.Pkcs7:
				break;
			default:
				throw new CryptographicException(Locale.GetText("Cannot export certificate(s) to the '{0}' format", new object[]
				{
					contentType
				}));
			}
			return null;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00059DE4 File Offset: 0x00057FE4
		private string GetKeyIdentifier(X509Certificate2 x)
		{
			X509SubjectKeyIdentifierExtension x509SubjectKeyIdentifierExtension = x.Extensions["2.5.29.14"] as X509SubjectKeyIdentifierExtension;
			if (x509SubjectKeyIdentifierExtension == null)
			{
				x509SubjectKeyIdentifierExtension = new X509SubjectKeyIdentifierExtension(x.PublicKey, X509SubjectKeyIdentifierHashAlgorithm.CapiSha1, false);
			}
			return x509SubjectKeyIdentifierExtension.SubjectKeyIdentifier;
		}

		/// <summary>Выполняет поиск в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> с использованием критериев поиска, указанных в перечислении <see cref="T:System.Security.Cryptography.X509Certificates.X509FindType" /> и объекте <paramref name="findValue" />.</summary>
		/// <param name="findType">Одно из значений перечисления <see cref="T:System.Security.Cryptography.X509Certificates.X509FindType" />.</param>
		/// <param name="findValue">Критерий поиска в качестве объекта.</param>
		/// <param name="validOnly">Значение <see langword="true" /> разрешает возврат из поиска только допустимых сертификатов; в противном случае — <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///   <paramref name="findType" /> недопустим.</exception>
		// Token: 0x0600166F RID: 5743 RVA: 0x00059E20 File Offset: 0x00058020
		[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
		public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly)
		{
			if (findValue == null)
			{
				throw new ArgumentNullException("findValue");
			}
			string text = string.Empty;
			string text2 = string.Empty;
			X509KeyUsageFlags x509KeyUsageFlags = X509KeyUsageFlags.None;
			DateTime t = DateTime.MinValue;
			switch (findType)
			{
			case X509FindType.FindByThumbprint:
			case X509FindType.FindBySubjectName:
			case X509FindType.FindBySubjectDistinguishedName:
			case X509FindType.FindByIssuerName:
			case X509FindType.FindByIssuerDistinguishedName:
			case X509FindType.FindBySerialNumber:
			case X509FindType.FindByTemplateName:
			case X509FindType.FindBySubjectKeyIdentifier:
				try
				{
					text = (string)findValue;
					goto IL_190;
				}
				catch (Exception inner)
				{
					throw new CryptographicException(Locale.GetText("Invalid find value type '{0}', expected '{1}'.", new object[]
					{
						findValue.GetType(),
						"string"
					}), inner);
				}
				break;
			case X509FindType.FindByTimeValid:
			case X509FindType.FindByTimeNotYetValid:
			case X509FindType.FindByTimeExpired:
				goto IL_13C;
			case X509FindType.FindByApplicationPolicy:
			case X509FindType.FindByCertificatePolicy:
			case X509FindType.FindByExtension:
				break;
			case X509FindType.FindByKeyUsage:
				goto IL_107;
			default:
				goto IL_171;
			}
			try
			{
				text2 = (string)findValue;
			}
			catch (Exception inner2)
			{
				throw new CryptographicException(Locale.GetText("Invalid find value type '{0}', expected '{1}'.", new object[]
				{
					findValue.GetType(),
					"X509KeyUsageFlags"
				}), inner2);
			}
			try
			{
				CryptoConfig.EncodeOID(text2);
				goto IL_190;
			}
			catch (CryptographicUnexpectedOperationException)
			{
				string text3 = Locale.GetText("Invalid OID value '{0}'.", new object[]
				{
					text2
				});
				throw new ArgumentException("findValue", text3);
			}
			IL_107:
			try
			{
				x509KeyUsageFlags = (X509KeyUsageFlags)findValue;
				goto IL_190;
			}
			catch (Exception inner3)
			{
				throw new CryptographicException(Locale.GetText("Invalid find value type '{0}', expected '{1}'.", new object[]
				{
					findValue.GetType(),
					"X509KeyUsageFlags"
				}), inner3);
			}
			IL_13C:
			try
			{
				t = (DateTime)findValue;
				goto IL_190;
			}
			catch (Exception inner4)
			{
				throw new CryptographicException(Locale.GetText("Invalid find value type '{0}', expected '{1}'.", new object[]
				{
					findValue.GetType(),
					"X509DateTime"
				}), inner4);
			}
			IL_171:
			throw new CryptographicException(Locale.GetText("Invalid find type '{0}'.", new object[]
			{
				findType
			}));
			IL_190:
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
			foreach (object obj in base.InnerList)
			{
				X509Certificate2 x509Certificate = (X509Certificate2)obj;
				bool flag = false;
				switch (findType)
				{
				case X509FindType.FindByThumbprint:
					flag = (string.Compare(text, x509Certificate.Thumbprint, true, invariantCulture) == 0 || string.Compare(text, x509Certificate.GetCertHashString(), true, invariantCulture) == 0);
					break;
				case X509FindType.FindBySubjectName:
					foreach (string text4 in x509Certificate.SubjectName.Format(true).Split(X509Certificate2Collection.newline_split, StringSplitOptions.RemoveEmptyEntries))
					{
						int startIndex = text4.IndexOf('=');
						flag = (text4.IndexOf(text, startIndex, StringComparison.InvariantCultureIgnoreCase) >= 0);
						if (flag)
						{
							break;
						}
					}
					break;
				case X509FindType.FindBySubjectDistinguishedName:
					flag = (string.Compare(text, x509Certificate.Subject, true, invariantCulture) == 0);
					break;
				case X509FindType.FindByIssuerName:
					flag = (x509Certificate.GetNameInfo(X509NameType.SimpleName, true).IndexOf(text, StringComparison.InvariantCultureIgnoreCase) >= 0);
					break;
				case X509FindType.FindByIssuerDistinguishedName:
					flag = (string.Compare(text, x509Certificate.Issuer, true, invariantCulture) == 0);
					break;
				case X509FindType.FindBySerialNumber:
					flag = (string.Compare(text, x509Certificate.SerialNumber, true, invariantCulture) == 0);
					break;
				case X509FindType.FindByTimeValid:
					flag = (t >= x509Certificate.NotBefore && t <= x509Certificate.NotAfter);
					break;
				case X509FindType.FindByTimeNotYetValid:
					flag = (t < x509Certificate.NotBefore);
					break;
				case X509FindType.FindByTimeExpired:
					flag = (t > x509Certificate.NotAfter);
					break;
				case X509FindType.FindByApplicationPolicy:
					flag = (x509Certificate.Extensions.Count == 0);
					break;
				case X509FindType.FindByExtension:
					flag = (x509Certificate.Extensions[text2] != null);
					break;
				case X509FindType.FindByKeyUsage:
				{
					X509KeyUsageExtension x509KeyUsageExtension = x509Certificate.Extensions["2.5.29.15"] as X509KeyUsageExtension;
					flag = (x509KeyUsageExtension == null || (x509KeyUsageExtension.KeyUsages & x509KeyUsageFlags) == x509KeyUsageFlags);
					break;
				}
				case X509FindType.FindBySubjectKeyIdentifier:
					flag = (string.Compare(text, this.GetKeyIdentifier(x509Certificate), true, invariantCulture) == 0);
					break;
				}
				if (flag)
				{
					if (validOnly)
					{
						try
						{
							if (x509Certificate.Verify())
							{
								x509Certificate2Collection.Add(x509Certificate);
							}
							continue;
						}
						catch
						{
							continue;
						}
					}
					x509Certificate2Collection.Add(x509Certificate);
				}
			}
			return x509Certificate2Collection;
		}

		/// <summary>Возвращает перечислитель, который может выполнять итерацию объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator" />, который может выполнять итерацию в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</returns>
		// Token: 0x06001670 RID: 5744 RVA: 0x0005A2DC File Offset: 0x000584DC
		public new X509Certificate2Enumerator GetEnumerator()
		{
			return new X509Certificate2Enumerator(this);
		}

		/// <summary>Импортирует сертификат в форме массива байтов в объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		// Token: 0x06001671 RID: 5745 RVA: 0x0005A2E4 File Offset: 0x000584E4
		[MonoTODO("same limitations as X509Certificate2.Import")]
		public void Import(byte[] rawData)
		{
			X509Certificate2 certificate = new X509Certificate2(rawData);
			this.Add(certificate);
		}

		/// <summary>Импортирует сертификат в форме массива байтов, требующего пароля для доступа к сертификату, в объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные из объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		/// <param name="password">Пароль, необходимый для доступа к сведениям о сертификате.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как импортирован сертификат.</param>
		// Token: 0x06001672 RID: 5746 RVA: 0x0005A300 File Offset: 0x00058500
		[MonoTODO("same limitations as X509Certificate2.Import")]
		public void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
		{
			X509Certificate2 certificate = new X509Certificate2(rawData, password, keyStorageFlags);
			this.Add(certificate);
		}

		/// <summary>Импортирует файл сертификата в объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="fileName">Имя файла, содержащего сведения о сертификате.</param>
		// Token: 0x06001673 RID: 5747 RVA: 0x0005A320 File Offset: 0x00058520
		[MonoTODO("same limitations as X509Certificate2.Import")]
		public void Import(string fileName)
		{
			X509Certificate2 certificate = new X509Certificate2(fileName);
			this.Add(certificate);
		}

		/// <summary>Импортирует файл сертификата, требующий пароль, в объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="fileName">Имя файла, содержащего сведения о сертификате.</param>
		/// <param name="password">Пароль, необходимый для доступа к сведениям о сертификате.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как импортирован сертификат.</param>
		// Token: 0x06001674 RID: 5748 RVA: 0x0005A33C File Offset: 0x0005853C
		[MonoTODO("same limitations as X509Certificate2.Import")]
		public void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
		{
			X509Certificate2 certificate = new X509Certificate2(fileName, password, keyStorageFlags);
			this.Add(certificate);
		}

		/// <summary>Вставляет объект в объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому должен быть вставлен параметр <paramref name="certificate" />.</param>
		/// <param name="certificate">Вставляемый объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше значения свойства <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.  
		///
		/// или - 
		/// Коллекция имеет фиксированный размер.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001675 RID: 5749 RVA: 0x0005A35C File Offset: 0x0005855C
		public void Insert(int index, X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("negative index");
			}
			if (index >= base.InnerList.Count)
			{
				throw new ArgumentOutOfRangeException("index >= Count");
			}
			base.InnerList.Insert(index, certificate);
		}

		/// <summary>Удаляет первое вхождение сертификата из объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, удаляемый из объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001676 RID: 5750 RVA: 0x0005A3AC File Offset: 0x000585AC
		public void Remove(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			for (int i = 0; i < base.InnerList.Count; i++)
			{
				if (((X509Certificate)base.InnerList[i]).Equals(certificate))
				{
					base.InnerList.RemoveAt(i);
					return;
				}
			}
		}

		/// <summary>Удаляет несколько объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> в массиве из объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="certificates">Массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificates" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001677 RID: 5751 RVA: 0x0005A404 File Offset: 0x00058604
		[MonoTODO("Method isn't transactional (like documented)")]
		public void RemoveRange(X509Certificate2[] certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificate");
			}
			foreach (X509Certificate2 certificate in certificates)
			{
				this.Remove(certificate);
			}
		}

		/// <summary>Удаляет несколько объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> из другого объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="certificates">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificates" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001678 RID: 5752 RVA: 0x0005A43C File Offset: 0x0005863C
		[MonoTODO("Method isn't transactional (like documented)")]
		public void RemoveRange(X509Certificate2Collection certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificate");
			}
			foreach (X509Certificate2 certificate in certificates)
			{
				this.Remove(certificate);
			}
		}

		// Token: 0x04000CF7 RID: 3319
		private static string[] newline_split = new string[]
		{
			Environment.NewLine
		};
	}
}
