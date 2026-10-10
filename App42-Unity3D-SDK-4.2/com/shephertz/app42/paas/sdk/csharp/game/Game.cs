using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.game
{
	// Token: 0x02000047 RID: 71
	public class Game : App42Response
	{
		// Token: 0x060002AA RID: 682 RVA: 0x0000FAE1 File Offset: 0x0000DCE1
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000FAE9 File Offset: 0x0000DCE9
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000FAF2 File Offset: 0x0000DCF2
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000FAFA File Offset: 0x0000DCFA
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000FB03 File Offset: 0x0000DD03
		public IList<Game.Score> GetScoreList()
		{
			return this.scoreList;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000FB0B File Offset: 0x0000DD0B
		public void SetScoreList(IList<Game.Score> scoreList)
		{
			this.scoreList = scoreList;
		}

		// Token: 0x04000133 RID: 307
		public string name;

		// Token: 0x04000134 RID: 308
		public string description;

		// Token: 0x04000135 RID: 309
		public IList<Game.Score> scoreList = new List<Game.Score>();

		// Token: 0x0200004A RID: 74
		public class Score : MetaResponse
		{
			// Token: 0x060002C6 RID: 710 RVA: 0x0000FC21 File Offset: 0x0000DE21
			public Game.Score.FacebookProfile GetFacebookProfile()
			{
				return this.facebookProfile;
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x0000FC29 File Offset: 0x0000DE29
			public void SetFacebookProfile(Game.Score.FacebookProfile facebookProfile1)
			{
				this.facebookProfile = facebookProfile1;
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x0000FC32 File Offset: 0x0000DE32
			public Score(Game game)
			{
				game.scoreList.Add(this);
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x0000FC46 File Offset: 0x0000DE46
			public string GetUserName()
			{
				return this.userName;
			}

			// Token: 0x060002CA RID: 714 RVA: 0x0000FC4E File Offset: 0x0000DE4E
			public void SetUserName(string userName)
			{
				this.userName = userName;
			}

			// Token: 0x060002CB RID: 715 RVA: 0x0000FC57 File Offset: 0x0000DE57
			public string GetScoreId()
			{
				return this.scoreId;
			}

			// Token: 0x060002CC RID: 716 RVA: 0x0000FC5F File Offset: 0x0000DE5F
			public void SetScoreId(string scoreId)
			{
				this.scoreId = scoreId;
			}

			// Token: 0x060002CD RID: 717 RVA: 0x0000FC68 File Offset: 0x0000DE68
			public string GetRank()
			{
				return this.rank;
			}

			// Token: 0x060002CE RID: 718 RVA: 0x0000FC70 File Offset: 0x0000DE70
			public void SetRank(string rank)
			{
				this.rank = rank;
			}

			// Token: 0x060002CF RID: 719 RVA: 0x0000FC79 File Offset: 0x0000DE79
			public double GetValue()
			{
				return this.value;
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x0000FC81 File Offset: 0x0000DE81
			public void SetValue(double value)
			{
				this.value = value;
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x0000FC8A File Offset: 0x0000DE8A
			public DateTime GetCreatedOn()
			{
				return this.createdOn;
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x0000FC92 File Offset: 0x0000DE92
			public void SetCreatedOn(DateTime createdOn)
			{
				this.createdOn = createdOn;
			}

			// Token: 0x0400013F RID: 319
			public Game.Score.FacebookProfile facebookProfile;

			// Token: 0x04000140 RID: 320
			public string userName;

			// Token: 0x04000141 RID: 321
			public string rank;

			// Token: 0x04000142 RID: 322
			public double value;

			// Token: 0x04000143 RID: 323
			public DateTime createdOn;

			// Token: 0x04000144 RID: 324
			public string scoreId;

			// Token: 0x0200004B RID: 75
			public class FacebookProfile
			{
				// Token: 0x060002D3 RID: 723 RVA: 0x0000FC9B File Offset: 0x0000DE9B
				public FacebookProfile(Game.Score score)
				{
					score.facebookProfile = this;
				}

				// Token: 0x060002D4 RID: 724 RVA: 0x0000FCAA File Offset: 0x0000DEAA
				public string GetId()
				{
					return this.id;
				}

				// Token: 0x060002D5 RID: 725 RVA: 0x0000FCB2 File Offset: 0x0000DEB2
				public void SetId(string id)
				{
					this.id = id;
				}

				// Token: 0x060002D6 RID: 726 RVA: 0x0000FCBB File Offset: 0x0000DEBB
				public string GetName()
				{
					return this.name;
				}

				// Token: 0x060002D7 RID: 727 RVA: 0x0000FCC3 File Offset: 0x0000DEC3
				public void SetName(string name)
				{
					this.name = name;
				}

				// Token: 0x060002D8 RID: 728 RVA: 0x0000FCCC File Offset: 0x0000DECC
				public string GetPicture()
				{
					return this.picture;
				}

				// Token: 0x060002D9 RID: 729 RVA: 0x0000FCD4 File Offset: 0x0000DED4
				public void SetPicture(string picture)
				{
					this.picture = picture;
				}

				// Token: 0x04000145 RID: 325
				public string name;

				// Token: 0x04000146 RID: 326
				public string id;

				// Token: 0x04000147 RID: 327
				public string picture;
			}
		}
	}
}
