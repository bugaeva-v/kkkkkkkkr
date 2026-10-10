using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Указывает базовый класс атрибутов для декларативной безопасности, производным от которого является <see cref="T:System.Security.Permissions.CodeAccessSecurityAttribute" />.</summary>
	// Token: 0x02000456 RID: 1110
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public abstract class SecurityAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Permissions.SecurityAttribute" /> с указанным <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002D0D RID: 11533 RVA: 0x000A1B07 File Offset: 0x0009FD07
		protected SecurityAttribute(SecurityAction action)
		{
			this.Action = action;
		}

		/// <summary>При переопределении в производном классе создает объект разрешения, который затем можно сериализовать в двоичную форму и постоянно хранить вместе с <see cref="T:System.Security.Permissions.SecurityAction" /> в метаданных сборки.</summary>
		/// <returns>Сериализуемый объект разрешения.</returns>
		// Token: 0x06002D0E RID: 11534
		public abstract IPermission CreatePermission();

		/// <summary>Возвращает или задает значение, определяющее, объявлено ли полное (неограниченное) разрешение доступа к ресурсу, защищенному атрибутом.</summary>
		/// <returns>Значение <see langword="true" />, если объявлено полное разрешение на доступ к защищенному ресурсу, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000A1B16 File Offset: 0x0009FD16
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x000A1B1E File Offset: 0x0009FD1E
		public bool Unrestricted
		{
			get
			{
				return this.m_Unrestricted;
			}
			set
			{
				this.m_Unrestricted = value;
			}
		}

		/// <summary>Возвращает или задает действие по обеспечению безопасности.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</returns>
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x000A1B27 File Offset: 0x0009FD27
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x000A1B2F File Offset: 0x0009FD2F
		public SecurityAction Action
		{
			get
			{
				return this.m_Action;
			}
			set
			{
				this.m_Action = value;
			}
		}

		// Token: 0x04002093 RID: 8339
		private SecurityAction m_Action;

		// Token: 0x04002094 RID: 8340
		private bool m_Unrestricted;
	}
}
