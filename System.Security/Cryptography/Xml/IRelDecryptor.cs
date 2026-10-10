using System;
using System.IO;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Определяет методы, с помощью которых расшифровывается XrML-элемент <see langword="&lt;encryptedGrant&gt;" />.</summary>
	// Token: 0x0200003F RID: 63
	public interface IRelDecryptor
	{
		/// <summary>Расшифровывает XrML-элемент <see langword="&lt;encryptedGrant&gt;" />, содержащийся в объекте <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="encryptionMethod">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptionMethod" />, инкапсулирующий алгоритм, который используется для XML-шифрования.</param>
		/// <param name="keyInfo">Объект <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />, который содержит асимметричный ключ, используемый для расшифровки.</param>
		/// <param name="toDecrypt">Объект потока, содержащий расшифровываемый элемент <see langword="&lt;encryptedGrant&gt;" />.</param>
		/// <returns>Объект <see cref="T:System.IO.Stream" />, содержащий расшифрованный элемент <see langword="&lt;encryptedGrant&gt;" />.</returns>
		// Token: 0x060001A1 RID: 417
		Stream Decrypt(EncryptionMethod encryptionMethod, KeyInfo keyInfo, Stream toDecrypt);
	}
}
