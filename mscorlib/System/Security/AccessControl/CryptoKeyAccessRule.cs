using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет правило доступа для ключа шифрования. Правило доступа представляет сочетание идентификатора пользователя, маски доступа и типа управления доступом ("разрешить" или "запретить"). Кроме того, в объекте правила доступа содержатся сведения о том, как правило наследуется дочерними объектами и как это наследование распространяется.</summary>
	// Token: 0x0200051B RID: 1307
	public sealed class CryptoKeyAccessRule : AccessRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CryptoKeyAccessRule" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа. Этот параметр должен быть объектом, который может быть приведен к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="cryptoKeyRights">Операция с ключом шифрования, за доступ к которой отвечает это правило доступа.</param>
		/// <param name="type">Допустимый тип управления доступом.</param>
		// Token: 0x060033D4 RID: 13268 RVA: 0x000BE06C File Offset: 0x000BC26C
		public CryptoKeyAccessRule(IdentityReference identity, CryptoKeyRights cryptoKeyRights, AccessControlType type) : base(identity, (int)cryptoKeyRights, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CryptoKeyAccessRule" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа.</param>
		/// <param name="cryptoKeyRights">Операция с ключом шифрования, за доступ к которой отвечает это правило доступа.</param>
		/// <param name="type">Допустимый тип управления доступом.</param>
		// Token: 0x060033D5 RID: 13269 RVA: 0x000BE07A File Offset: 0x000BC27A
		public CryptoKeyAccessRule(string identity, CryptoKeyRights cryptoKeyRights, AccessControlType type) : this(new NTAccount(identity), cryptoKeyRights, type)
		{
		}

		/// <summary>Получает операцию с ключом шифрования, за доступ к которой отвечает это правило доступа.</summary>
		/// <returns>Операция с ключом шифрования, за доступ к которой отвечает это правило доступа.</returns>
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x000BC722 File Offset: 0x000BA922
		public CryptoKeyRights CryptoKeyRights
		{
			get
			{
				return (CryptoKeyRights)base.AccessMask;
			}
		}
	}
}
