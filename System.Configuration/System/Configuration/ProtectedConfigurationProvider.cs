using System;
using System.Configuration.Provider;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Базовый класс для создания поставщиков для шифрования и дешифрования данных с защищенной конфигурацией.</summary>
	// Token: 0x0200005D RID: 93
	public abstract class ProtectedConfigurationProvider : ProviderBase
	{
		/// <summary>Расшифровывает объект <see cref="T:System.Xml.XmlNode" /> переданный из файла конфигурации.</summary>
		/// <param name="encryptedNode">Объект <see cref="T:System.Xml.XmlNode" /> для расшифровки.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlNode" />, содержащий расшифрованные данные.</returns>
		// Token: 0x0600030D RID: 781
		public abstract XmlNode Decrypt(XmlNode encryptedNode);

		/// <summary>Шифрует объект <see cref="T:System.Xml.XmlNode" />, переданный из файла конфигурации.</summary>
		/// <param name="node">Объект <see cref="T:System.Xml.XmlNode" /> для шифровки.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlNode" />, содержащий шифрованные данные.</returns>
		// Token: 0x0600030E RID: 782
		public abstract XmlNode Encrypt(XmlNode node);
	}
}
