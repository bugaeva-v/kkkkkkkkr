using System;
using com.shephertz.app42.paas.sdk.csharp.abTest;
using com.shephertz.app42.paas.sdk.csharp.achievement;
using com.shephertz.app42.paas.sdk.csharp.app42Event;
using com.shephertz.app42.paas.sdk.csharp.avatar;
using com.shephertz.app42.paas.sdk.csharp.bravoboard;
using com.shephertz.app42.paas.sdk.csharp.buddy;
using com.shephertz.app42.paas.sdk.csharp.customcode;
using com.shephertz.app42.paas.sdk.csharp.email;
using com.shephertz.app42.paas.sdk.csharp.gallery;
using com.shephertz.app42.paas.sdk.csharp.game;
using com.shephertz.app42.paas.sdk.csharp.geo;
using com.shephertz.app42.paas.sdk.csharp.gift;
using com.shephertz.app42.paas.sdk.csharp.imageProcessor;
using com.shephertz.app42.paas.sdk.csharp.log;
using com.shephertz.app42.paas.sdk.csharp.message;
using com.shephertz.app42.paas.sdk.csharp.pushNotification;
using com.shephertz.app42.paas.sdk.csharp.recommend;
using com.shephertz.app42.paas.sdk.csharp.review;
using com.shephertz.app42.paas.sdk.csharp.reward;
using com.shephertz.app42.paas.sdk.csharp.session;
using com.shephertz.app42.paas.sdk.csharp.shopping;
using com.shephertz.app42.paas.sdk.csharp.social;
using com.shephertz.app42.paas.sdk.csharp.storage;
using com.shephertz.app42.paas.sdk.csharp.timer;
using com.shephertz.app42.paas.sdk.csharp.upload;
using com.shephertz.app42.paas.sdk.csharp.user;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x0200009A RID: 154
	public class ServiceAPI
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x00027487 File Offset: 0x00025687
		public ServiceAPI(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			App42API.Initialize(apiKey, secretKey);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000274AF File Offset: 0x000256AF
		public string GetApiKey()
		{
			return this.apiKey;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000274B7 File Offset: 0x000256B7
		public void SetApiKey(string apiKey)
		{
			this.apiKey = apiKey;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000274C0 File Offset: 0x000256C0
		public string GetSecretKey()
		{
			return this.secretKey;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000274C8 File Offset: 0x000256C8
		public void SetSecretKey(string secretKey)
		{
			this.secretKey = secretKey;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000274D1 File Offset: 0x000256D1
		public string GetBaseURL()
		{
			return this.config.GetBaseURL();
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000274DE File Offset: 0x000256DE
		public void SetBaseURL(string protocol, string host, int port)
		{
			this.config.SetBaseURL(protocol, host, port);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000274EE File Offset: 0x000256EE
		public void SetBaseURL(string url)
		{
			this.config.SetBaseURL(url);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000274FC File Offset: 0x000256FC
		public UserService BuildUserService()
		{
			return new UserService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0002751C File Offset: 0x0002571C
		public ReviewService BuildReviewService()
		{
			return new ReviewService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0002753C File Offset: 0x0002573C
		public UploadService BuildUploadService()
		{
			return new UploadService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0002755C File Offset: 0x0002575C
		public SessionService BuildSessionService()
		{
			return new SessionService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002757C File Offset: 0x0002577C
		public RecommenderService BuildRecommenderService()
		{
			return new RecommenderService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0002759C File Offset: 0x0002579C
		public LogService BuildLogService()
		{
			return new LogService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000275BC File Offset: 0x000257BC
		public PhotoService BuildPhotoService()
		{
			return new PhotoService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000275DC File Offset: 0x000257DC
		public AlbumService BuildAlbumService()
		{
			return new AlbumService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000275FC File Offset: 0x000257FC
		public GameService BuildGameService()
		{
			return new GameService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0002761C File Offset: 0x0002581C
		public RewardService BuildRewardService()
		{
			return new RewardService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0002763C File Offset: 0x0002583C
		public ScoreService BuildScoreService()
		{
			return new ScoreService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0002765C File Offset: 0x0002585C
		public ScoreBoardService BuildScoreBoardService()
		{
			return new ScoreBoardService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0002767C File Offset: 0x0002587C
		public CartService BuildCartService()
		{
			return new CartService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0002769C File Offset: 0x0002589C
		public CatalogueService BuildCatalogueService()
		{
			return new CatalogueService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000276BC File Offset: 0x000258BC
		public QueueService BuildQueueService()
		{
			return new QueueService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000276DC File Offset: 0x000258DC
		public ImageProcessorService BuildImageProcessorService()
		{
			return new ImageProcessorService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000276FC File Offset: 0x000258FC
		public StorageService BuildStorageService()
		{
			return new StorageService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0002771C File Offset: 0x0002591C
		public EmailService BuildEmailService()
		{
			return new EmailService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0002773C File Offset: 0x0002593C
		public GeoService BuildGeoService()
		{
			return new GeoService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0002775C File Offset: 0x0002595C
		public SocialService BuildSocialService()
		{
			return new SocialService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0002777C File Offset: 0x0002597C
		public BuddyService BuildBuddyService()
		{
			return new BuddyService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002779C File Offset: 0x0002599C
		public AchievementService BuildAchievementService()
		{
			return new AchievementService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000277BC File Offset: 0x000259BC
		public AvatarService BuildAvatarService()
		{
			return new AvatarService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000277DC File Offset: 0x000259DC
		public ABTestService BuildABTestService()
		{
			return new ABTestService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000277FC File Offset: 0x000259FC
		public CustomCodeService BuildCustomCodeService()
		{
			return new CustomCodeService(this.apiKey, this.secretKey);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0002781C File Offset: 0x00025A1C
		public PushNotificationService BuildPushNotificationService()
		{
			return new PushNotificationService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002783C File Offset: 0x00025A3C
		public TimerService BuildTimerService()
		{
			return new TimerService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0002785C File Offset: 0x00025A5C
		public GiftService BuildGiftService()
		{
			return new GiftService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0002787C File Offset: 0x00025A7C
		public BravoBoardService BuildBravoBoardService()
		{
			return new BravoBoardService(this.apiKey, this.secretKey);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0002789C File Offset: 0x00025A9C
		public EventService BuildEventService()
		{
			return new EventService(this.apiKey, this.secretKey);
		}

		// Token: 0x04000276 RID: 630
		private string apiKey;

		// Token: 0x04000277 RID: 631
		private string secretKey;

		// Token: 0x04000278 RID: 632
		private Config config = Config.GetInstance();
	}
}
