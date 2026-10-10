using System;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Определяет свидетельство, представляющее запросы разрешений. Этот класс не наследуется.</summary>
	// Token: 0x0200041A RID: 1050
	[ComVisible(true)]
	[Serializable]
	public sealed class PermissionRequestEvidence : EvidenceBase, IBuiltInEvidence
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.PermissionRequestEvidence" /> с запросом разрешения сборки кода.</summary>
		/// <param name="request">Минимальный набор разрешений, который код запрашивает для выполнения.</param>
		/// <param name="optional">Разрешения, которые код может использовать в случае их предоставления, но они не являются обязательными.</param>
		/// <param name="denied">Разрешения, которые код явно запрашивает ему не предоставлять.</param>
		// Token: 0x06002ADB RID: 10971 RVA: 0x0009AD3A File Offset: 0x00098F3A
		public PermissionRequestEvidence(PermissionSet request, PermissionSet optional, PermissionSet denied)
		{
			if (request != null)
			{
				this.requested = new PermissionSet(request);
			}
			if (optional != null)
			{
				this.optional = new PermissionSet(optional);
			}
			if (denied != null)
			{
				this.denied = new PermissionSet(denied);
			}
		}

		/// <summary>Получает разрешения, которые код явно запрашивает ему не предоставлять.</summary>
		/// <returns>Разрешения, которые код явно запрашивает ему не предоставлять.</returns>
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x0009AD6F File Offset: 0x00098F6F
		public PermissionSet DeniedPermissions
		{
			get
			{
				return this.denied;
			}
		}

		/// <summary>Получает разрешения, которые код может использовать в случае их предоставления, но они не являются обязательными.</summary>
		/// <returns>Разрешения, которые код может использовать в случае их предоставления, но они не являются обязательными.</returns>
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x0009AD77 File Offset: 0x00098F77
		public PermissionSet OptionalPermissions
		{
			get
			{
				return this.optional;
			}
		}

		/// <summary>Получает минимальный набор разрешений, требуемый для запуска кода.</summary>
		/// <returns>Минимальный набор разрешений, который код запрашивает для выполнения.</returns>
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x0009AD7F File Offset: 0x00098F7F
		public PermissionSet RequestedPermissions
		{
			get
			{
				return this.requested;
			}
		}

		/// <summary>Создает эквивалентную копию текущего объекта <see cref="T:System.Security.Policy.PermissionRequestEvidence" />.</summary>
		/// <returns>Эквивалентная копия текущего объекта <see cref="T:System.Security.Policy.PermissionRequestEvidence" />.</returns>
		// Token: 0x06002ADF RID: 10975 RVA: 0x0009AD87 File Offset: 0x00098F87
		public PermissionRequestEvidence Copy()
		{
			return new PermissionRequestEvidence(this.requested, this.optional, this.denied);
		}

		/// <summary>Получает строковое представление состояния объекта <see cref="T:System.Security.Policy.PermissionRequestEvidence" />.</summary>
		/// <returns>Представление состояния объекта <see cref="T:System.Security.Policy.PermissionRequestEvidence" />.</returns>
		// Token: 0x06002AE0 RID: 10976 RVA: 0x0009ADA0 File Offset: 0x00098FA0
		public override string ToString()
		{
			SecurityElement securityElement = new SecurityElement("System.Security.Policy.PermissionRequestEvidence");
			securityElement.AddAttribute("version", "1");
			if (this.requested != null)
			{
				SecurityElement securityElement2 = new SecurityElement("Request");
				securityElement2.AddChild(this.requested.ToXml());
				securityElement.AddChild(securityElement2);
			}
			if (this.optional != null)
			{
				SecurityElement securityElement3 = new SecurityElement("Optional");
				securityElement3.AddChild(this.optional.ToXml());
				securityElement.AddChild(securityElement3);
			}
			if (this.denied != null)
			{
				SecurityElement securityElement4 = new SecurityElement("Denied");
				securityElement4.AddChild(this.denied.ToXml());
				securityElement.AddChild(securityElement4);
			}
			return securityElement.ToString();
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x0009AE50 File Offset: 0x00099050
		int IBuiltInEvidence.GetRequiredSize(bool verbose)
		{
			int num = verbose ? 3 : 1;
			if (this.requested != null)
			{
				int num2 = this.requested.ToXml().ToString().Length + (verbose ? 5 : 0);
				num += num2;
			}
			if (this.optional != null)
			{
				int num3 = this.optional.ToXml().ToString().Length + (verbose ? 5 : 0);
				num += num3;
			}
			if (this.denied != null)
			{
				int num4 = this.denied.ToXml().ToString().Length + (verbose ? 5 : 0);
				num += num4;
			}
			return num;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.InitFromBuffer(char[] buffer, int position)
		{
			return 0;
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.OutputToBuffer(char[] buffer, int position, bool verbose)
		{
			return 0;
		}

		// Token: 0x04001FA5 RID: 8101
		private PermissionSet requested;

		// Token: 0x04001FA6 RID: 8102
		private PermissionSet optional;

		// Token: 0x04001FA7 RID: 8103
		private PermissionSet denied;
	}
}
