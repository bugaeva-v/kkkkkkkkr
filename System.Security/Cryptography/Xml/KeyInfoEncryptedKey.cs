using System;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Заключает в оболочку класс <see cref="T:System.Security.Cryptography.Xml.EncryptedKey" />, чтобы поместить его в качестве подэлемента класса <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</summary>
	// Token: 0x02000042 RID: 66
	public class KeyInfoEncryptedKey : KeyInfoClause
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoEncryptedKey" />.</summary>
		// Token: 0x060001B0 RID: 432 RVA: 0x00008215 File Offset: 0x00006415
		public KeyInfoEncryptedKey()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoEncryptedKey" /> с помощью объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedKey" />.</summary>
		/// <param name="encryptedKey">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedKey" />, инкапсулирующий зашифрованный ключ.</param>
		// Token: 0x060001B1 RID: 433 RVA: 0x0000821D File Offset: 0x0000641D
		public KeyInfoEncryptedKey(EncryptedKey encryptedKey)
		{
			this._encryptedKey = encryptedKey;
		}

		/// <summary>Получает или задает объект <see cref="T:System.Security.Cryptography.Xml.EncryptedKey" />, инкапсулирующий зашифрованный ключ.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedKey" />, инкапсулирующий зашифрованный ключ.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.Xml.KeyInfoEncryptedKey.EncryptedKey" /> — <see langword="null" />.</exception>
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000822C File Offset: 0x0000642C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00008234 File Offset: 0x00006434
		public EncryptedKey EncryptedKey
		{
			get
			{
				return this._encryptedKey;
			}
			set
			{
				this._encryptedKey = value;
			}
		}

		/// <summary>Возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoEncryptedKey" />.</summary>
		/// <returns>XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoEncryptedKey" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение зашифрованного ключа равно <see langword="null" />.</exception>
		// Token: 0x060001B4 RID: 436 RVA: 0x0000823D File Offset: 0x0000643D
		public override XmlElement GetXml()
		{
			if (this._encryptedKey == null)
			{
				throw new CryptographicException("Malformed element {0}.", "KeyInfoEncryptedKey");
			}
			return this._encryptedKey.GetXml();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00008262 File Offset: 0x00006462
		internal override XmlElement GetXml(XmlDocument xmlDocument)
		{
			if (this._encryptedKey == null)
			{
				throw new CryptographicException("Malformed element {0}.", "KeyInfoEncryptedKey");
			}
			return this._encryptedKey.GetXml(xmlDocument);
		}

		/// <summary>Выполняет анализ входного объекта <see cref="T:System.Xml.XmlElement" /> и настраивает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoEncryptedKey" /> для сопоставления.</summary>
		/// <param name="value">Объект <see cref="T:System.Xml.XmlElement" />, определяющий состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoEncryptedKey" />.</param>
		// Token: 0x060001B6 RID: 438 RVA: 0x00008288 File Offset: 0x00006488
		public override void LoadXml(XmlElement value)
		{
			this._encryptedKey = new EncryptedKey();
			this._encryptedKey.LoadXml(value);
		}

		// Token: 0x040001A6 RID: 422
		private EncryptedKey _encryptedKey;
	}
}
