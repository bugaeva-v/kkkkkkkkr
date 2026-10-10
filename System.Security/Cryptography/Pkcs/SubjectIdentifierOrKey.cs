using System;
using Unity;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey" /> определяет тип идентификатора субъекта, например <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" /> или <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />.  Субъект можно идентифицировать по поставщику и серийному номеру сертификата, хэшу ключа субъекта или ключу субъекта.</summary>
	// Token: 0x0200008A RID: 138
	public sealed class SubjectIdentifierOrKey
	{
		// Token: 0x06000499 RID: 1177 RVA: 0x0001498F File Offset: 0x00012B8F
		internal SubjectIdentifierOrKey(SubjectIdentifierOrKeyType type, object value)
		{
			this.Type = type;
			this.Value = value;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey.Type" /> возвращает тип идентификатора или ключа субъекта. Субъект можно идентифицировать по поставщику и серийному номеру сертификата, хэшу ключа субъекта или ключу субъекта.</summary>
		/// <returns>Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKeyType" />, определяющий тип идентификатора субъекта.</returns>
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000149A5 File Offset: 0x00012BA5
		public SubjectIdentifierOrKeyType Type { get; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey.Value" /> получает значение идентификатора или ключа субъекта. Свойство <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey.Type" /> позволяет определить тип идентификатора или ключа субъекта, а свойство <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey.Value" /> — получить соответствующее значение.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, которые представляет значение идентификатора или ключа субъекта. Этот объект <see cref="T:System.Object" /> может относиться к одному из следующих типов в зависимости от значения свойства <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey.Type" />.  
		///  Свойство<see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey.Type" />  
		///   Object 
		///   IssuerAndSerialNumber 
		///  <see cref="T:System.Security.Cryptography.Xml.X509IssuerSerial" /> SubjectKeyIdentifier 
		///  <see cref="T:System.String" /> PublicKeyInfo 
		///  <see cref="T:System.Security.Cryptography.Pkcs.PublicKeyInfo" /></returns>
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000149AD File Offset: 0x00012BAD
		public object Value { get; }

		// Token: 0x0600049C RID: 1180 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal SubjectIdentifierOrKey()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
