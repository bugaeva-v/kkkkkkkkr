using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет правило аудита для ключа шифрования. Правило аудита представляет сочетание идентификатора пользователя и маски доступа. Кроме того, в правиле аудита содержатся сведения о том, как правило наследуется дочерними объектами, как это наследование распространяется, а также об условиях, при которых выполняется аудит.</summary>
	// Token: 0x0200051C RID: 1308
	public sealed class CryptoKeyAuditRule : AuditRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CryptoKeyAuditRule" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило аудита. Этот параметр должен быть объектом, который может быть приведен к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="cryptoKeyRights">Операция с ключом шифрования, для которой проводится аудит в соответствии с правилом аудита.</param>
		/// <param name="flags">Условия проведения аудита.</param>
		// Token: 0x060033D7 RID: 13271 RVA: 0x000BE08A File Offset: 0x000BC28A
		public CryptoKeyAuditRule(IdentityReference identity, CryptoKeyRights cryptoKeyRights, AuditFlags flags) : base(identity, (int)cryptoKeyRights, false, InheritanceFlags.None, PropagationFlags.None, flags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CryptoKeyAuditRule" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило аудита.</param>
		/// <param name="cryptoKeyRights">Операция с ключом шифрования, для которой проводится аудит в соответствии с правилом аудита.</param>
		/// <param name="flags">Условия проведения аудита.</param>
		// Token: 0x060033D8 RID: 13272 RVA: 0x000BE098 File Offset: 0x000BC298
		public CryptoKeyAuditRule(string identity, CryptoKeyRights cryptoKeyRights, AuditFlags flags) : this(new NTAccount(identity), cryptoKeyRights, flags)
		{
		}

		/// <summary>Получает операцию с ключом шифрования, для которой проводится аудит в соответствии с правилом аудита.</summary>
		/// <returns>Операция с ключом шифрования, для которой проводится аудит в соответствии с правилом аудита.</returns>
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x000BC722 File Offset: 0x000BA922
		public CryptoKeyRights CryptoKeyRights
		{
			get
			{
				return (CryptoKeyRights)base.AccessMask;
			}
		}
	}
}
