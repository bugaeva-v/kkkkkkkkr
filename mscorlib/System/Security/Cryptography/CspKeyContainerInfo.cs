using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Cryptography
{
	/// <summary>Предоставляет дополнительные сведения о паре криптографических ключей шифрования. Этот класс не наследуется.</summary>
	// Token: 0x020004C7 RID: 1223
	[ComVisible(true)]
	public sealed class CspKeyContainerInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" />, используя заданные параметры.</summary>
		/// <param name="parameters">Объект <see cref="T:System.Security.Cryptography.CspParameters" />, который предоставляет сведения о ключе.</param>
		// Token: 0x060030E5 RID: 12517 RVA: 0x000B3207 File Offset: 0x000B1407
		public CspKeyContainerInfo(CspParameters parameters)
		{
			this._params = parameters;
			this._random = true;
		}

		/// <summary>Получает значение, указывающее на доступность ключа в контейнере ключей.</summary>
		/// <returns>Значение <see langword="true" />, если ключ доступен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Тип ключа не поддерживается.</exception>
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x000040F7 File Offset: 0x000022F7
		public bool Accessible
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />, представляющий права доступа и правила аудита для контейнера.</summary>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />, представляющий права доступа и правила аудита для контейнера.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Тип ключа не поддерживается.</exception>
		/// <exception cref="T:System.NotSupportedException">Поставщик служб шифрования не найден.  
		///
		/// или - 
		/// Контейнер ключей не найден.</exception>
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060030E7 RID: 12519 RVA: 0x0000AF5E File Offset: 0x0000915E
		public CryptoKeySecurity CryptoKeySecurity
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает значение, указывающее на возможность экспорта ключа из контейнера ключей.</summary>
		/// <returns>Значение <see langword="true" />, если ключ можно экспортировать; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Тип ключа не поддерживается.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Поставщик служб шифрования не найден.  
		///
		/// или - 
		/// Контейнер ключей не найден.</exception>
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000040F7 File Offset: 0x000022F7
		public bool Exportable
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение, указывающее, является ли ключ аппаратным.</summary>
		/// <returns>Значение <see langword="true" />, если ключ является аппаратным; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Поставщик служб шифрования не найден.</exception>
		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060030E9 RID: 12521 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool HardwareDevice
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает имя контейнера ключа.</summary>
		/// <returns>Имя контейнера ключа.</returns>
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x000B321D File Offset: 0x000B141D
		public string KeyContainerName
		{
			get
			{
				return this._params.KeyContainerName;
			}
		}

		/// <summary>Получает значение, описывающее, был ли асимметричный ключ создан как ключ подписи или ключ обмена.</summary>
		/// <returns>Одно из значений <see cref="T:System.Security.Cryptography.KeyNumber" />, описывающее, был ли асимметричный ключ создан как ключ подписи или ключ обмена.</returns>
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x000B322A File Offset: 0x000B142A
		public KeyNumber KeyNumber
		{
			get
			{
				return (KeyNumber)this._params.KeyNumber;
			}
		}

		/// <summary>Получает значение, указывающее, происходит ли ключ из набора ключей компьютера.</summary>
		/// <returns>Значение <see langword="true" />, если ключ происходит из набора ключей компьютера; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool MachineKeyStore
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, является ли пара ключей защищенной.</summary>
		/// <returns>Значение <see langword="true" />, если пара ключей защищена; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Тип ключа не поддерживается.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Поставщик служб шифрования не найден.  
		///
		/// или - 
		/// Контейнер ключей не найден.</exception>
		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool Protected
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает имя поставщика ключа.</summary>
		/// <returns>Имя поставщика.</returns>
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x000B3237 File Offset: 0x000B1437
		public string ProviderName
		{
			get
			{
				return this._params.ProviderName;
			}
		}

		/// <summary>Получает тип поставщика ключа.</summary>
		/// <returns>Тип поставщика. Значение по умолчанию — 1.</returns>
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x000B3244 File Offset: 0x000B1444
		public int ProviderType
		{
			get
			{
				return this._params.ProviderType;
			}
		}

		/// <summary>Возвращает значение, указывающее, был ли контейнер ключей создан случайным образом классом криптографии управляемого кода.</summary>
		/// <returns>Значение <see langword="true" />, если контейнер ключей был создан случайным образом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x000B3251 File Offset: 0x000B1451
		public bool RandomlyGenerated
		{
			get
			{
				return this._random;
			}
		}

		/// <summary>Получает значение, указывающее на возможность удаления ключа из контейнера ключей.</summary>
		/// <returns>Значение <see langword="true" />, если ключ можно удалить; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Поставщик служб шифрования (CSP) не найден.</exception>
		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool Removable
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает уникальное имя контейнера ключей.</summary>
		/// <returns>Уникальное имя контейнера ключей.</returns>
		/// <exception cref="T:System.NotSupportedException">Тип ключа не поддерживается.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Поставщик служб шифрования не найден.  
		///
		/// или - 
		/// Контейнер ключей не найден.</exception>
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x000B3259 File Offset: 0x000B1459
		public string UniqueKeyContainerName
		{
			get
			{
				return this._params.ProviderName + "\\" + this._params.KeyContainerName;
			}
		}

		// Token: 0x04002246 RID: 8774
		private CspParameters _params;

		// Token: 0x04002247 RID: 8775
		internal bool _random;
	}
}
