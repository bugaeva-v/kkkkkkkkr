using System;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device.Internal;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000027 RID: 39
	internal class IdentityManager : IIdentityManager
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000043C8 File Offset: 0x000025C8
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000043D0 File Offset: 0x000025D0
		public string UserId { get; private set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000043D9 File Offset: 0x000025D9
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000043E1 File Offset: 0x000025E1
		public string InstallId { get; private set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000043EA File Offset: 0x000025EA
		public string PlayerId
		{
			get
			{
				IPlayerId playerId = this.m_PlayerId;
				if (playerId == null)
				{
					return null;
				}
				return playerId.PlayerId;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000043FD File Offset: 0x000025FD
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00004405 File Offset: 0x00002605
		public string ExternalId { get; private set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000440E File Offset: 0x0000260E
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00004416 File Offset: 0x00002616
		public bool IsNewPlayer { get; private set; }

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000FB RID: 251 RVA: 0x00004420 File Offset: 0x00002620
		// (remove) Token: 0x060000FC RID: 252 RVA: 0x00004458 File Offset: 0x00002658
		public event Action OnPlayerChanged;

		// Token: 0x060000FD RID: 253 RVA: 0x00004490 File Offset: 0x00002690
		public IdentityManager(IInstallationId installId, IPlayerId playerId, IExternalUserId externalId, IPersistence persistence)
		{
			this.InstallId = installId.GetOrCreateIdentifier();
			this.m_PlayerId = playerId;
			this.m_ExternalIdProvider = externalId;
			this.m_Persistence = persistence;
			if (this.m_ExternalIdProvider != null)
			{
				this.m_ExternalIdProvider.UserIdChanged += this.ExternalUserIdChanged;
				this.ExternalId = this.m_ExternalIdProvider.UserId;
			}
			this.UserId = ((!string.IsNullOrEmpty(this.ExternalId)) ? this.ExternalId : this.InstallId);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004518 File Offset: 0x00002718
		public void Initialize()
		{
			if (!this.m_Initialized)
			{
				string text = this.m_Persistence.LoadString("UnityAnalyticsUserId");
				bool flag = false;
				if (string.IsNullOrEmpty(text))
				{
					text = this.m_Persistence.LoadString("UnityAnalyticsInstallationId");
					this.m_Persistence.ClearValue("UnityAnalyticsInstallationId");
					flag = !string.IsNullOrEmpty(text);
				}
				if (this.m_ExternalIdProvider != null)
				{
					this.ExternalId = this.m_ExternalIdProvider.UserId;
				}
				this.UserId = (string.IsNullOrEmpty(this.ExternalId) ? this.InstallId : this.ExternalId);
				this.IsNewPlayer = (string.IsNullOrEmpty(text) || !text.Equals(this.UserId, StringComparison.Ordinal));
				if (this.IsNewPlayer || flag)
				{
					this.m_Persistence.SaveValue("UnityAnalyticsUserId", this.UserId);
				}
				this.m_Initialized = true;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000045F8 File Offset: 0x000027F8
		private void ExternalUserIdChanged(string newName)
		{
			if (this.m_Initialized)
			{
				if (!this.UserId.Equals(newName, StringComparison.Ordinal))
				{
					if (string.IsNullOrEmpty(newName))
					{
						this.UserId = this.InstallId;
					}
					else if (string.IsNullOrEmpty(this.ExternalId))
					{
						this.UserId = newName;
					}
					else if (!this.ExternalId.Equals(newName, StringComparison.Ordinal))
					{
						this.UserId = newName;
					}
					this.m_Persistence.SaveValue("UnityAnalyticsUserId", this.UserId);
					this.ExternalId = newName;
					this.IsNewPlayer = true;
					Action onPlayerChanged = this.OnPlayerChanged;
					if (onPlayerChanged == null)
					{
						return;
					}
					onPlayerChanged();
					return;
				}
			}
			else
			{
				this.ExternalId = newName;
				this.UserId = ((!string.IsNullOrEmpty(this.ExternalId)) ? this.ExternalId : this.InstallId);
			}
		}

		// Token: 0x04000075 RID: 117
		internal const string k_UnityAnalyticsInstallationIdKey = "UnityAnalyticsInstallationId";

		// Token: 0x04000076 RID: 118
		internal const string k_UnityAnalyticsUserIdKey = "UnityAnalyticsUserId";

		// Token: 0x04000077 RID: 119
		private readonly IPlayerId m_PlayerId;

		// Token: 0x04000078 RID: 120
		private readonly IExternalUserId m_ExternalIdProvider;

		// Token: 0x04000079 RID: 121
		private readonly IPersistence m_Persistence;

		// Token: 0x0400007A RID: 122
		private bool m_Initialized;
	}
}
