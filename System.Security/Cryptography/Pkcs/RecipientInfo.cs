using System;
using Internal.Cryptography;
using Unity;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> представляет информацию о получателе сообщения CMS/PKCS 7. Класс <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> является абстрактным классом, которому наследуют классы <see cref="T:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo" /> и <see cref="T:System.Security.Cryptography.Pkcs.KeyTransRecipientInfo" />.</summary>
	// Token: 0x02000080 RID: 128
	public abstract class RecipientInfo
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x00012CE8 File Offset: 0x00010EE8
		internal RecipientInfo(RecipientInfoType type, RecipientInfoPal pal)
		{
			this.Type = type;
			this.Pal = pal;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfo.Type" /> возвращает тип получателя. Тип получателя определяет один из двух основных протоколов, которые используются для установки ключа между отправителем и получателем сообщения CMS/PKCS 7.</summary>
		/// <returns>Значение из перечисления <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoType" />, определяющее тип получателя.</returns>
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00012CFE File Offset: 0x00010EFE
		public RecipientInfoType Type { get; }

		/// <summary>Абстрактное свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfo.Version" /> возвращает версию информации о получателе. В объектах производных классов это свойство настраивается автоматически, а его значение указывает на тип защиты сообщений — PKCS 7 или CMS (Cryptographic Message Syntax). Версия также определяет алгоритм получения ключа объектом <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> — с помощью согласования ключей или с помощью передачи ключей.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, представляющее версию объекта <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />.</returns>
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000425 RID: 1061
		public abstract int Version { get; }

		/// <summary>Абстрактное свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfo.RecipientIdentifier" /> возвращает тип идентификатора получателя.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifier" />, который содержит идентификатор получателя.</returns>
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000426 RID: 1062
		public abstract SubjectIdentifier RecipientIdentifier { get; }

		/// <summary>Абстрактное свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfo.KeyEncryptionAlgorithm" /> возвращает алгоритм, с помощью которого осуществляется определение ключей.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" />, содержащий значение алгоритма, который используется для определения ключа для отправителя и получателя сообщения CMS/PKCS 7.</returns>
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000427 RID: 1063
		public abstract AlgorithmIdentifier KeyEncryptionAlgorithm { get; }

		/// <summary>Абстрактное свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfo.EncryptedKey" /> возвращает зашифрованный материал ключа получателя.</summary>
		/// <returns>Массив байтовых значений, который содержит зашифрованный материал ключа получателя.</returns>
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000428 RID: 1064
		public abstract byte[] EncryptedKey { get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00012D06 File Offset: 0x00010F06
		internal RecipientInfoPal Pal { get; }

		// Token: 0x0600042A RID: 1066 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal RecipientInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
