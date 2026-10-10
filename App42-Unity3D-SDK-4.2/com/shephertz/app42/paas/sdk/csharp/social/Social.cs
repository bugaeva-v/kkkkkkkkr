using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.social
{
	// Token: 0x020000AF RID: 175
	public class Social : App42Response
	{
		// Token: 0x06000750 RID: 1872 RVA: 0x00029EB9 File Offset: 0x000280B9
		public Social.FacebookProfile GetFacebookProfile()
		{
			return this.facebookProfile;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00029EC1 File Offset: 0x000280C1
		public void SetFacebookProfile(Social.FacebookProfile facebookProfile)
		{
			this.facebookProfile = facebookProfile;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00029ECA File Offset: 0x000280CA
		public IList<Social.PublicProfile> GetPublicProfile()
		{
			return this.publicProfile;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00029ED2 File Offset: 0x000280D2
		public void SetPublicProfile(IList<Social.PublicProfile> publicProfile)
		{
			this.publicProfile = publicProfile;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00029EDB File Offset: 0x000280DB
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00029EE3 File Offset: 0x000280E3
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00029EEC File Offset: 0x000280EC
		public string GetStatus()
		{
			return this.status;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00029EF4 File Offset: 0x000280F4
		public void SetStatus(string status)
		{
			this.status = status;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00029EFD File Offset: 0x000280FD
		public string GetFacebookAppId()
		{
			return this.facebookAppId;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00029F05 File Offset: 0x00028105
		public void SetFacebookAppId(string facebookAppId)
		{
			this.facebookAppId = facebookAppId;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00029F0E File Offset: 0x0002810E
		public string GetFacebookAppSecret()
		{
			return this.facebookAppSecret;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00029F16 File Offset: 0x00028116
		public void SetFacebookAppSecret(string facebookAppSecret)
		{
			this.facebookAppSecret = facebookAppSecret;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00029F1F File Offset: 0x0002811F
		public string GetFacebookAccessToken()
		{
			return this.facebookAccessToken;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00029F27 File Offset: 0x00028127
		public void SetFacebookAccessToken(string facebookAccessToken)
		{
			this.facebookAccessToken = facebookAccessToken;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00029F30 File Offset: 0x00028130
		public string GetTwitterConsumerKey()
		{
			return this.twitterConsumerKey;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00029F38 File Offset: 0x00028138
		public void SetTwitterConsumerKey(string twitterConsumerKey)
		{
			this.twitterConsumerKey = twitterConsumerKey;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00029F41 File Offset: 0x00028141
		public string GetTwitterConsumerSecret()
		{
			return this.twitterConsumerSecret;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00029F49 File Offset: 0x00028149
		public void SetTwitterConsumerSecret(string twitterConsumerSecret)
		{
			this.twitterConsumerSecret = twitterConsumerSecret;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00029F52 File Offset: 0x00028152
		public string GetTwitterAccessToken()
		{
			return this.twitterAccessToken;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00029F5A File Offset: 0x0002815A
		public void SetTwitterAccessToken(string twitterAccessToken)
		{
			this.twitterAccessToken = twitterAccessToken;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00029F63 File Offset: 0x00028163
		public string GetTwitterAccessTokenSecret()
		{
			return this.twitterAccessTokenSecret;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00029F6B File Offset: 0x0002816B
		public void SetTwitterAccessTokenSecret(string twitterAccessTokenSecret)
		{
			this.twitterAccessTokenSecret = twitterAccessTokenSecret;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00029F74 File Offset: 0x00028174
		public string GetLinkedinApiKey()
		{
			return this.linkedinApiKey;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00029F7C File Offset: 0x0002817C
		public void SetLinkedinApiKey(string linkedinApiKey)
		{
			this.linkedinApiKey = linkedinApiKey;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00029F85 File Offset: 0x00028185
		public string GetLinkedinSecretKey()
		{
			return this.linkedinSecretKey;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00029F8D File Offset: 0x0002818D
		public void SetLinkedinSecretKey(string linkedinSecretKey)
		{
			this.linkedinSecretKey = linkedinSecretKey;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00029F96 File Offset: 0x00028196
		public string GetLinkedinAccessToken()
		{
			return this.linkedinAccessToken;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00029F9E File Offset: 0x0002819E
		public void SetLinkedinAccessToken(string linkedinAccessToken)
		{
			this.linkedinAccessToken = linkedinAccessToken;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00029FA7 File Offset: 0x000281A7
		public string GetLinkedinAccessTokenSecret()
		{
			return this.linkedinAccessTokenSecret;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00029FAF File Offset: 0x000281AF
		public void SetLinkedinAccessTokenSecret(string linkedinAccessTokenSecret)
		{
			this.linkedinAccessTokenSecret = linkedinAccessTokenSecret;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00029FB8 File Offset: 0x000281B8
		public IList<Social.Friends> GetFriendList()
		{
			return this.friendsList;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00029FC0 File Offset: 0x000281C0
		public void SetFriendList(IList<Social.Friends> friendsList)
		{
			this.friendsList = friendsList;
		}

		// Token: 0x040002A4 RID: 676
		public string userName;

		// Token: 0x040002A5 RID: 677
		public string status;

		// Token: 0x040002A6 RID: 678
		public string facebookAppId;

		// Token: 0x040002A7 RID: 679
		public string facebookAppSecret;

		// Token: 0x040002A8 RID: 680
		public string facebookAccessToken;

		// Token: 0x040002A9 RID: 681
		public string twitterConsumerKey;

		// Token: 0x040002AA RID: 682
		public string twitterConsumerSecret;

		// Token: 0x040002AB RID: 683
		public string twitterAccessToken;

		// Token: 0x040002AC RID: 684
		public string twitterAccessTokenSecret;

		// Token: 0x040002AD RID: 685
		public string linkedinApiKey;

		// Token: 0x040002AE RID: 686
		public string linkedinSecretKey;

		// Token: 0x040002AF RID: 687
		public string linkedinAccessToken;

		// Token: 0x040002B0 RID: 688
		public string linkedinAccessTokenSecret;

		// Token: 0x040002B1 RID: 689
		private IList<Social.Friends> friendsList = new List<Social.Friends>();

		// Token: 0x040002B2 RID: 690
		public Social.FacebookProfile facebookProfile;

		// Token: 0x040002B3 RID: 691
		public IList<Social.PublicProfile> publicProfile = new List<Social.PublicProfile>();

		// Token: 0x020000B0 RID: 176
		public class Friends
		{
			// Token: 0x06000771 RID: 1905 RVA: 0x00029FE7 File Offset: 0x000281E7
			public Friends(Social social)
			{
				social.friendsList.Add(this);
			}

			// Token: 0x06000772 RID: 1906 RVA: 0x00029FFB File Offset: 0x000281FB
			public bool GetInstalled()
			{
				return this.installed;
			}

			// Token: 0x06000773 RID: 1907 RVA: 0x0002A003 File Offset: 0x00028203
			public void SetInstalled(bool installed)
			{
				this.installed = installed;
			}

			// Token: 0x06000774 RID: 1908 RVA: 0x0002A00C File Offset: 0x0002820C
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x06000775 RID: 1909 RVA: 0x0002A014 File Offset: 0x00028214
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x06000776 RID: 1910 RVA: 0x0002A01D File Offset: 0x0002821D
			public string GetPicture()
			{
				return this.picture;
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x0002A025 File Offset: 0x00028225
			public void SetPicture(string picture)
			{
				this.picture = picture;
			}

			// Token: 0x06000778 RID: 1912 RVA: 0x0002A02E File Offset: 0x0002822E
			public string GetId()
			{
				return this.id;
			}

			// Token: 0x06000779 RID: 1913 RVA: 0x0002A036 File Offset: 0x00028236
			public void SetId(string id)
			{
				this.id = id;
			}

			// Token: 0x040002B4 RID: 692
			public string name;

			// Token: 0x040002B5 RID: 693
			public string picture;

			// Token: 0x040002B6 RID: 694
			public string id;

			// Token: 0x040002B7 RID: 695
			public bool installed;
		}

		// Token: 0x020000B1 RID: 177
		public class FacebookProfile
		{
			// Token: 0x0600077A RID: 1914 RVA: 0x0002A03F File Offset: 0x0002823F
			public FacebookProfile(Social social)
			{
				social.facebookProfile = this;
			}

			// Token: 0x0600077B RID: 1915 RVA: 0x0002A04E File Offset: 0x0002824E
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x0600077C RID: 1916 RVA: 0x0002A057 File Offset: 0x00028257
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x0600077D RID: 1917 RVA: 0x0002A05F File Offset: 0x0002825F
			public string GetPicture()
			{
				return this.picture;
			}

			// Token: 0x0600077E RID: 1918 RVA: 0x0002A067 File Offset: 0x00028267
			public void SetPicture(string picture)
			{
				this.picture = picture;
			}

			// Token: 0x0600077F RID: 1919 RVA: 0x0002A070 File Offset: 0x00028270
			public string GetId()
			{
				return this.id;
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x0002A078 File Offset: 0x00028278
			public void SetId(string id)
			{
				this.id = id;
			}

			// Token: 0x06000781 RID: 1921 RVA: 0x0002A081 File Offset: 0x00028281
			public string GetFirstName()
			{
				return this.firstName;
			}

			// Token: 0x06000782 RID: 1922 RVA: 0x0002A089 File Offset: 0x00028289
			public void SetFirstName(string firstName)
			{
				this.firstName = firstName;
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x0002A092 File Offset: 0x00028292
			public string GetLastName()
			{
				return this.lastName;
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x0002A09A File Offset: 0x0002829A
			public void SetLastName(string lastName)
			{
				this.lastName = lastName;
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x0002A0A3 File Offset: 0x000282A3
			public string GetGender()
			{
				return this.gender;
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x0002A0AB File Offset: 0x000282AB
			public void SetGender(string gender)
			{
				this.gender = gender;
			}

			// Token: 0x06000787 RID: 1927 RVA: 0x0002A0B4 File Offset: 0x000282B4
			public string GetLink()
			{
				return this.link;
			}

			// Token: 0x06000788 RID: 1928 RVA: 0x0002A0BC File Offset: 0x000282BC
			public void SetLink(string link)
			{
				this.link = link;
			}

			// Token: 0x06000789 RID: 1929 RVA: 0x0002A0C5 File Offset: 0x000282C5
			public string GetLocale()
			{
				return this.locale;
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x0002A0CD File Offset: 0x000282CD
			public void SetLocale(string locale)
			{
				this.locale = locale;
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x0002A0D6 File Offset: 0x000282D6
			public string GetUsername()
			{
				return this.username;
			}

			// Token: 0x0600078C RID: 1932 RVA: 0x0002A0DE File Offset: 0x000282DE
			public void SetUsername(string username)
			{
				this.username = username;
			}

			// Token: 0x040002B8 RID: 696
			public string name;

			// Token: 0x040002B9 RID: 697
			public string picture;

			// Token: 0x040002BA RID: 698
			public string id;

			// Token: 0x040002BB RID: 699
			public string firstName;

			// Token: 0x040002BC RID: 700
			public string lastName;

			// Token: 0x040002BD RID: 701
			public string gender;

			// Token: 0x040002BE RID: 702
			public string link;

			// Token: 0x040002BF RID: 703
			public string locale;

			// Token: 0x040002C0 RID: 704
			public string username;
		}

		// Token: 0x020000B2 RID: 178
		public class PublicProfile
		{
			// Token: 0x0600078D RID: 1933 RVA: 0x0002A0E7 File Offset: 0x000282E7
			public PublicProfile(Social social)
			{
				social.publicProfile.Add(this);
			}

			// Token: 0x0600078E RID: 1934 RVA: 0x0002A0FB File Offset: 0x000282FB
			public string GetId()
			{
				return this.id;
			}

			// Token: 0x0600078F RID: 1935 RVA: 0x0002A103 File Offset: 0x00028303
			public void SetId(string id)
			{
				this.id = id;
			}

			// Token: 0x06000790 RID: 1936 RVA: 0x0002A10C File Offset: 0x0002830C
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x06000791 RID: 1937 RVA: 0x0002A114 File Offset: 0x00028314
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x06000792 RID: 1938 RVA: 0x0002A11D File Offset: 0x0002831D
			public string GetPicture()
			{
				return this.picture;
			}

			// Token: 0x06000793 RID: 1939 RVA: 0x0002A125 File Offset: 0x00028325
			public void SetPicture(string picture)
			{
				this.picture = picture;
			}

			// Token: 0x040002C1 RID: 705
			public string id;

			// Token: 0x040002C2 RID: 706
			public string name;

			// Token: 0x040002C3 RID: 707
			public string picture;
		}
	}
}
