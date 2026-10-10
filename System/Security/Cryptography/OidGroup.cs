using System;

namespace System.Security.Cryptography
{
	/// <summary>Определяет группы идентификаторов криптографического объекта (OID) Windows.</summary>
	// Token: 0x020002B8 RID: 696
	public enum OidGroup
	{
		/// <summary>Все группы.</summary>
		// Token: 0x04000C39 RID: 3129
		All,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_HASH_ALG_OID_GROUP_ID.</summary>
		// Token: 0x04000C3A RID: 3130
		HashAlgorithm,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_ENCRYPT_ALG_OID_GROUP_ID.</summary>
		// Token: 0x04000C3B RID: 3131
		EncryptionAlgorithm,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_PUBKEY_ALG_OID_GROUP_ID.</summary>
		// Token: 0x04000C3C RID: 3132
		PublicKeyAlgorithm,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_SIGN_ALG_OID_GROUP_ID.</summary>
		// Token: 0x04000C3D RID: 3133
		SignatureAlgorithm,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_RDN_ATTR_OID_GROUP_ID.</summary>
		// Token: 0x04000C3E RID: 3134
		Attribute,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_EXT_OR_ATTR_OID_GROUP_ID.</summary>
		// Token: 0x04000C3F RID: 3135
		ExtensionOrAttribute,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_ENHKEY_USAGE_OID_GROUP_ID.</summary>
		// Token: 0x04000C40 RID: 3136
		EnhancedKeyUsage,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_POLICY_OID_GROUP_ID.</summary>
		// Token: 0x04000C41 RID: 3137
		Policy,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_TEMPLATE_OID_GROUP_ID.</summary>
		// Token: 0x04000C42 RID: 3138
		Template,
		/// <summary>Группа Windows, представляемая идентификатором CRYPT_KDF_OID_GROUP_ID.</summary>
		// Token: 0x04000C43 RID: 3139
		KeyDerivationFunction
	}
}
