using System;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace System.Runtime.Hosting
{
	/// <summary>Предоставляет данные для активации сборок на основе манифестов. Этот класс не наследуется.</summary>
	// Token: 0x02000555 RID: 1365
	[ComVisible(true)]
	[Serializable]
	public sealed class ActivationArguments : EvidenceBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Hosting.ActivationArguments" /> с заданным контекстом активации.</summary>
		/// <param name="activationData">Объект, определяющий приложение, активируемое на основе манифеста.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="activationData" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060035C1 RID: 13761 RVA: 0x000C206E File Offset: 0x000C026E
		public ActivationArguments(ActivationContext activationData)
		{
			if (activationData == null)
			{
				throw new ArgumentNullException("activationData");
			}
			this._context = activationData;
			this._identity = activationData.Identity;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Hosting.ActivationArguments" /> с заданной идентификацией приложения.</summary>
		/// <param name="applicationIdentity">Объект, определяющий приложение, активируемое на основе манифеста.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="applicationIdentity" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060035C2 RID: 13762 RVA: 0x000C2097 File Offset: 0x000C0297
		public ActivationArguments(ApplicationIdentity applicationIdentity)
		{
			if (applicationIdentity == null)
			{
				throw new ArgumentNullException("applicationIdentity");
			}
			this._identity = applicationIdentity;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Hosting.ActivationArguments" /> с заданным контекстом активации и данными активации.</summary>
		/// <param name="activationContext">Объект, определяющий приложение, активируемое на основе манифеста.</param>
		/// <param name="activationData">Массив строк, содержащий предоставленные ведущим приложением данные активации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="activationContext" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060035C3 RID: 13763 RVA: 0x000C20B4 File Offset: 0x000C02B4
		public ActivationArguments(ActivationContext activationContext, string[] activationData)
		{
			if (activationContext == null)
			{
				throw new ArgumentNullException("activationContext");
			}
			this._context = activationContext;
			this._identity = activationContext.Identity;
			this._data = activationData;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Hosting.ActivationArguments" /> с заданной идентификацией приложения и данными активации.</summary>
		/// <param name="applicationIdentity">Объект, определяющий приложение, активируемое на основе манифеста.</param>
		/// <param name="activationData">Массив строк, содержащий предоставленные ведущим приложением данные активации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="applicationIdentity" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060035C4 RID: 13764 RVA: 0x000C20E4 File Offset: 0x000C02E4
		public ActivationArguments(ApplicationIdentity applicationIdentity, string[] activationData)
		{
			if (applicationIdentity == null)
			{
				throw new ArgumentNullException("applicationIdentity");
			}
			this._identity = applicationIdentity;
			this._data = activationData;
		}

		/// <summary>Возвращает контекст активации, предназначенный для активации приложения на основе манифеста.</summary>
		/// <returns>Объект, определяющий приложение, активируемое на основе манифеста.</returns>
		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x000C2108 File Offset: 0x000C0308
		public ActivationContext ActivationContext
		{
			get
			{
				return this._context;
			}
		}

		/// <summary>Возвращает данные активации, полученные от ведущего приложения.</summary>
		/// <returns>Массив строк, содержащий предоставленные ведущим приложением данные активации.</returns>
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000C2110 File Offset: 0x000C0310
		public string[] ActivationData
		{
			get
			{
				return this._data;
			}
		}

		/// <summary>Возвращает идентификацию приложения для приложения на основе манифеста.</summary>
		/// <returns>Объект, определяющий приложение для активации на основе манифеста.</returns>
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x000C2118 File Offset: 0x000C0318
		public ApplicationIdentity ApplicationIdentity
		{
			get
			{
				return this._identity;
			}
		}

		// Token: 0x0400250F RID: 9487
		private ActivationContext _context;

		// Token: 0x04002510 RID: 9488
		private ApplicationIdentity _identity;

		// Token: 0x04002511 RID: 9489
		private string[] _data;
	}
}
