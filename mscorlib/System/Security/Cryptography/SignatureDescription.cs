using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Содержит сведения о свойствах цифровой подписи.</summary>
	// Token: 0x020004B8 RID: 1208
	[ComVisible(true)]
	public class SignatureDescription
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.SignatureDescription" />.</summary>
		// Token: 0x06003074 RID: 12404 RVA: 0x0000259F File Offset: 0x0000079F
		public SignatureDescription()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.SignatureDescription" /> из указанного потока <see cref="T:System.Security.SecurityElement" />.</summary>
		/// <param name="el">Объект <see cref="T:System.Security.SecurityElement" />, из которого необходимо получить алгоритмы для описания подписи.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="el" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003075 RID: 12405 RVA: 0x000B0B04 File Offset: 0x000AED04
		public SignatureDescription(SecurityElement el)
		{
			if (el == null)
			{
				throw new ArgumentNullException("el");
			}
			this._strKey = el.SearchForTextOfTag("Key");
			this._strDigest = el.SearchForTextOfTag("Digest");
			this._strFormatter = el.SearchForTextOfTag("Formatter");
			this._strDeformatter = el.SearchForTextOfTag("Deformatter");
		}

		/// <summary>Получает или задает алгоритм с ключом для описания подписи.</summary>
		/// <returns>Алгоритм с ключом для описания подписи.</returns>
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x000B0B69 File Offset: 0x000AED69
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x000B0B71 File Offset: 0x000AED71
		public string KeyAlgorithm
		{
			get
			{
				return this._strKey;
			}
			set
			{
				this._strKey = value;
			}
		}

		/// <summary>Получает или задает алгоритм дайджеста для описания подписи.</summary>
		/// <returns>Алгоритм дайджеста для описания подписи.</returns>
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x000B0B7A File Offset: 0x000AED7A
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x000B0B82 File Offset: 0x000AED82
		public string DigestAlgorithm
		{
			get
			{
				return this._strDigest;
			}
			set
			{
				this._strDigest = value;
			}
		}

		/// <summary>Получает или задает алгоритм создания подписи для описания подписи.</summary>
		/// <returns>Алгоритм создания подписи для описания подписи.</returns>
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x000B0B8B File Offset: 0x000AED8B
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x000B0B93 File Offset: 0x000AED93
		public string FormatterAlgorithm
		{
			get
			{
				return this._strFormatter;
			}
			set
			{
				this._strFormatter = value;
			}
		}

		/// <summary>Получает или задает алгоритм проверки подписи для описания подписи.</summary>
		/// <returns>Алгоритм проверки подписи для описания подписи.</returns>
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x000B0B9C File Offset: 0x000AED9C
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x000B0BA4 File Offset: 0x000AEDA4
		public string DeformatterAlgorithm
		{
			get
			{
				return this._strDeformatter;
			}
			set
			{
				this._strDeformatter = value;
			}
		}

		/// <summary>Создает экземпляр <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" /> с заданным ключом, используя свойство <see cref="P:System.Security.Cryptography.SignatureDescription.DeformatterAlgorithm" />.</summary>
		/// <param name="key">Ключ, используемый в <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" />.</param>
		/// <returns>Вновь созданный экземпляр <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" />.</returns>
		// Token: 0x0600307E RID: 12414 RVA: 0x000B0BAD File Offset: 0x000AEDAD
		public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			AsymmetricSignatureDeformatter asymmetricSignatureDeformatter = (AsymmetricSignatureDeformatter)CryptoConfig.CreateFromName(this._strDeformatter);
			asymmetricSignatureDeformatter.SetKey(key);
			return asymmetricSignatureDeformatter;
		}

		/// <summary>Создает экземпляр <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" /> с заданным ключом, используя свойство <see cref="P:System.Security.Cryptography.SignatureDescription.FormatterAlgorithm" />.</summary>
		/// <param name="key">Ключ, используемый в <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" />.</param>
		/// <returns>Вновь созданный экземпляр <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" />.</returns>
		// Token: 0x0600307F RID: 12415 RVA: 0x000B0BC6 File Offset: 0x000AEDC6
		public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			AsymmetricSignatureFormatter asymmetricSignatureFormatter = (AsymmetricSignatureFormatter)CryptoConfig.CreateFromName(this._strFormatter);
			asymmetricSignatureFormatter.SetKey(key);
			return asymmetricSignatureFormatter;
		}

		/// <summary>Создает экземпляр <see cref="T:System.Security.Cryptography.HashAlgorithm" /> с помощью свойства <see cref="P:System.Security.Cryptography.SignatureDescription.DigestAlgorithm" />.</summary>
		/// <returns>Вновь созданный экземпляр <see cref="T:System.Security.Cryptography.HashAlgorithm" />.</returns>
		// Token: 0x06003080 RID: 12416 RVA: 0x000B0BDF File Offset: 0x000AEDDF
		public virtual HashAlgorithm CreateDigest()
		{
			return (HashAlgorithm)CryptoConfig.CreateFromName(this._strDigest);
		}

		// Token: 0x040021E9 RID: 8681
		private string _strKey;

		// Token: 0x040021EA RID: 8682
		private string _strDigest;

		// Token: 0x040021EB RID: 8683
		private string _strFormatter;

		// Token: 0x040021EC RID: 8684
		private string _strDeformatter;
	}
}
