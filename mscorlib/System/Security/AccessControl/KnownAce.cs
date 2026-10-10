using System;
using System.Globalization;
using System.Security.Principal;
using System.Text;
using Unity;

namespace System.Security.AccessControl
{
	/// <summary>Инкапсулирует все типы элементов управления доступом, которые в настоящее время определены корпорацией Майкрософт. Все объекты <see cref="T:System.Security.AccessControl.KnownAce" /> содержат 32-битные маски доступа и объект <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
	// Token: 0x02000530 RID: 1328
	public abstract class KnownAce : GenericAce
	{
		// Token: 0x0600349A RID: 13466 RVA: 0x000BF892 File Offset: 0x000BDA92
		internal KnownAce(AceType type, AceFlags flags) : base(type, flags)
		{
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x000BF89C File Offset: 0x000BDA9C
		internal KnownAce(byte[] binaryForm, int offset) : base(binaryForm, offset)
		{
		}

		/// <summary>Получает или задает маску доступа для данного объекта <see cref="T:System.Security.AccessControl.KnownAce" />.</summary>
		/// <returns>Маска доступа для данного объекта <see cref="T:System.Security.AccessControl.KnownAce" />.</returns>
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x000BF8A6 File Offset: 0x000BDAA6
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x000BF8AE File Offset: 0x000BDAAE
		public int AccessMask
		{
			get
			{
				return this.access_mask;
			}
			set
			{
				this.access_mask = value;
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, связанный с объектом <see cref="T:System.Security.AccessControl.KnownAce" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, связанный с данным объектом <see cref="T:System.Security.AccessControl.KnownAce" />.</returns>
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x000BF8B7 File Offset: 0x000BDAB7
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x000BF8BF File Offset: 0x000BDABF
		public SecurityIdentifier SecurityIdentifier
		{
			get
			{
				return this.identifier;
			}
			set
			{
				this.identifier = value;
			}
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000BF8C8 File Offset: 0x000BDAC8
		internal static string GetSddlAccessRights(int accessMask)
		{
			string sddlAliasRights = KnownAce.GetSddlAliasRights(accessMask);
			if (!string.IsNullOrEmpty(sddlAliasRights))
			{
				return sddlAliasRights;
			}
			return string.Format(CultureInfo.InvariantCulture, "0x{0:x}", accessMask);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x000BF8FC File Offset: 0x000BDAFC
		private static string GetSddlAliasRights(int accessMask)
		{
			SddlAccessRight[] array = SddlAccessRight.Decompose(accessMask);
			if (array == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (SddlAccessRight sddlAccessRight in array)
			{
				stringBuilder.Append(sddlAccessRight.Name);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x000173AD File Offset: 0x000155AD
		internal KnownAce()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040024AE RID: 9390
		private int access_mask;

		// Token: 0x040024AF RID: 9391
		private SecurityIdentifier identifier;
	}
}
