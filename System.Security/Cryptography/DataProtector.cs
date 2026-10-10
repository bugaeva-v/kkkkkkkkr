using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Security.Cryptography
{
	/// <summary>Предоставляет базовый класс для предохранителей данных.</summary>
	// Token: 0x02000012 RID: 18
	public abstract class DataProtector
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Security.Cryptography.DataProtector" />, используя предоставленное имя приложения, первичную цель и определенные цели.</summary>
		/// <param name="applicationName">Имя приложения.</param>
		/// <param name="primaryPurpose">Основное назначение для защищенных данных.</param>
		/// <param name="specificPurposes">Определенное назначение для защищенных данных.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="applicationName" /> является пустой строкой или <see langword="null" />.  
		/// -или- 
		///  <paramref name="primaryPurpose" /> является пустой строкой или <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="specificPurposes" /> содержит пустую строку или имеет значение <see langword="null" />.</exception>
		// Token: 0x06000046 RID: 70 RVA: 0x00002B8C File Offset: 0x00000D8C
		protected DataProtector(string applicationName, string primaryPurpose, string[] specificPurposes)
		{
			if (string.IsNullOrWhiteSpace(applicationName))
			{
				throw new ArgumentException("Invalid application name and/or purpose", "applicationName");
			}
			if (string.IsNullOrWhiteSpace(primaryPurpose))
			{
				throw new ArgumentException("Invalid application name and/or purpose", "primaryPurpose");
			}
			if (specificPurposes != null)
			{
				for (int i = 0; i < specificPurposes.Length; i++)
				{
					if (string.IsNullOrWhiteSpace(specificPurposes[i]))
					{
						throw new ArgumentException("Invalid application name and/or purpose", "specificPurposes");
					}
				}
			}
			this.m_applicationName = applicationName;
			this.m_primaryPurpose = primaryPurpose;
			List<string> list = new List<string>();
			if (specificPurposes != null)
			{
				list.AddRange(specificPurposes);
			}
			this.m_specificPurposes = list;
		}

		/// <summary>Возвращает имя приложения.</summary>
		/// <returns>Имя приложения.</returns>
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002C21 File Offset: 0x00000E21
		protected string ApplicationName
		{
			get
			{
				return this.m_applicationName;
			}
		}

		/// <summary>Определяет, добавляется ли хэш в начало массива текста перед шифрованием.</summary>
		/// <returns>Всегда <see langword="true" />.</returns>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002C29 File Offset: 0x00000E29
		protected virtual bool PrependHashedPurposeToPlaintext
		{
			get
			{
				return true;
			}
		}

		/// <summary>Создает хэш значений свойств, определяемых конструктором.</summary>
		/// <returns>Массив байтов, содержащий хэш свойств <see cref="P:System.Security.Cryptography.DataProtector.ApplicationName" />, <see cref="P:System.Security.Cryptography.DataProtector.PrimaryPurpose" /> и <see cref="P:System.Security.Cryptography.DataProtector.SpecificPurposes" />.</returns>
		// Token: 0x06000049 RID: 73 RVA: 0x00002C2C File Offset: 0x00000E2C
		protected virtual byte[] GetHashedPurpose()
		{
			if (this.m_hashedPurpose == null)
			{
				using (HashAlgorithm hashAlgorithm = HashAlgorithm.Create("System.Security.Cryptography.Sha256Cng"))
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(new CryptoStream(new MemoryStream(), hashAlgorithm, CryptoStreamMode.Write), new UTF8Encoding(false, true)))
					{
						binaryWriter.Write(this.ApplicationName);
						binaryWriter.Write(this.PrimaryPurpose);
						foreach (string value in this.SpecificPurposes)
						{
							binaryWriter.Write(value);
						}
					}
					this.m_hashedPurpose = hashAlgorithm.Hash;
				}
			}
			return this.m_hashedPurpose;
		}

		/// <summary>Указывает, необходимо ли перешифрование для указанных зашифрованных данных.</summary>
		/// <param name="encryptedData">Зашифрованные данные для оценки.</param>
		/// <returns>Значение <see langword="true" />, если данные должны быть заново зашифрованы; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600004A RID: 74
		public abstract bool IsReprotectRequired(byte[] encryptedData);

		/// <summary>Получает основное назначение для защищенных данных.</summary>
		/// <returns>Основное назначение для защищенных данных.</returns>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002D08 File Offset: 0x00000F08
		protected string PrimaryPurpose
		{
			get
			{
				return this.m_primaryPurpose;
			}
		}

		/// <summary>Получает определенное назначение для защищенных данных.</summary>
		/// <returns>Коллекция определенных назначений для защищенных данных.</returns>
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002D10 File Offset: 0x00000F10
		protected IEnumerable<string> SpecificPurposes
		{
			get
			{
				return this.m_specificPurposes;
			}
		}

		/// <summary>Создает экземпляр реализации предохранителя данных с помощью указанного имени класса предохранителя данных, имени приложения, первичной цели и определенных целей.</summary>
		/// <param name="providerClass">Имя класса для предохранителя данных.</param>
		/// <param name="applicationName">Имя приложения.</param>
		/// <param name="primaryPurpose">Основное назначение для защищенных данных.</param>
		/// <param name="specificPurposes">Определенное назначение для защищенных данных.</param>
		/// <returns>Объект реализации предохранителя данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="providerClass" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600004D RID: 77 RVA: 0x00002D18 File Offset: 0x00000F18
		public static DataProtector Create(string providerClass, string applicationName, string primaryPurpose, params string[] specificPurposes)
		{
			if (providerClass == null)
			{
				throw new ArgumentNullException("providerClass");
			}
			return (DataProtector)CryptoConfig.CreateFromName(providerClass, new object[]
			{
				applicationName,
				primaryPurpose,
				specificPurposes
			});
		}

		/// <summary>Защищает заданные пользовательские данные.</summary>
		/// <param name="userData">Защищаемые данные.</param>
		/// <returns>Массив байтов, содержащий зашифрованные данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="userData" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600004E RID: 78 RVA: 0x00002D48 File Offset: 0x00000F48
		public byte[] Protect(byte[] userData)
		{
			if (userData == null)
			{
				throw new ArgumentNullException("userData");
			}
			if (this.PrependHashedPurposeToPlaintext)
			{
				byte[] hashedPurpose = this.GetHashedPurpose();
				byte[] array = new byte[userData.Length + hashedPurpose.Length];
				Array.Copy(hashedPurpose, 0, array, 0, hashedPurpose.Length);
				Array.Copy(userData, 0, array, hashedPurpose.Length, userData.Length);
				userData = array;
			}
			return this.ProviderProtect(userData);
		}

		/// <summary>Задает метод делегата в производном классе, в адрес которого метод <see cref="M:System.Security.Cryptography.DataProtector.Protect(System.Byte[])" /> в базовом классе выполняет обратный вызов.</summary>
		/// <param name="userData">Данные, предназначенные для шифрования.</param>
		/// <returns>Массив байтов, содержащий зашифрованные данные.</returns>
		// Token: 0x0600004F RID: 79
		protected abstract byte[] ProviderProtect(byte[] userData);

		/// <summary>Задает метод делегата в производном классе, в адрес которого метод <see cref="M:System.Security.Cryptography.DataProtector.Unprotect(System.Byte[])" /> в базовом классе выполняет обратный вызов.</summary>
		/// <param name="encryptedData">Шифруемые данные.</param>
		/// <returns>Незашифрованные данные.</returns>
		// Token: 0x06000050 RID: 80
		protected abstract byte[] ProviderUnprotect(byte[] encryptedData);

		/// <summary>Снимает защиту с указанных защищенных данных.</summary>
		/// <param name="encryptedData">Зашифрованные данные, для которых требуется снять защиту.</param>
		/// <returns>Массив байтов, содержащий данные открытого текста.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="encryptedData" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///   <paramref name="encryptedData" /> содержит недопустимую назначение.</exception>
		// Token: 0x06000051 RID: 81 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public byte[] Unprotect(byte[] encryptedData)
		{
			if (encryptedData == null)
			{
				throw new ArgumentNullException("encryptedData");
			}
			if (!this.PrependHashedPurposeToPlaintext)
			{
				return this.ProviderUnprotect(encryptedData);
			}
			byte[] array = this.ProviderUnprotect(encryptedData);
			byte[] hashedPurpose = this.GetHashedPurpose();
			bool flag = array.Length >= hashedPurpose.Length;
			for (int i = 0; i < hashedPurpose.Length; i++)
			{
				if (hashedPurpose[i] != array[i % array.Length])
				{
					flag = false;
				}
			}
			if (!flag)
			{
				throw new CryptographicException("Invalid data protection purpose");
			}
			byte[] array2 = new byte[array.Length - hashedPurpose.Length];
			Array.Copy(array, hashedPurpose.Length, array2, 0, array2.Length);
			return array2;
		}

		// Token: 0x04000089 RID: 137
		private string m_applicationName;

		// Token: 0x0400008A RID: 138
		private string m_primaryPurpose;

		// Token: 0x0400008B RID: 139
		private IEnumerable<string> m_specificPurposes;

		// Token: 0x0400008C RID: 140
		private volatile byte[] m_hashedPurpose;
	}
}
