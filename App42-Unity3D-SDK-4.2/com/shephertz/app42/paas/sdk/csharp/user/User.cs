using System;
using System.Collections.Generic;
using com.shephertz.app42.paas.sdk.csharp.storage;

namespace com.shephertz.app42.paas.sdk.csharp.user
{
	// Token: 0x020000C4 RID: 196
	public class User : App42Response
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x00032020 File Offset: 0x00030220
		public IList<User.JSONDocument> GetJsonDocList()
		{
			return this.jsonDocList;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00032028 File Offset: 0x00030228
		public void SetJsonDocList(IList<User.JSONDocument> jsonDocList)
		{
			this.jsonDocList = jsonDocList;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00032031 File Offset: 0x00030231
		public IList<string> GetRoleList()
		{
			return this.roleList;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00032039 File Offset: 0x00030239
		public void SetRoleList(IList<string> roleList)
		{
			this.roleList = roleList;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00032042 File Offset: 0x00030242
		public string GetSessionId()
		{
			return this.sessionId;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0003204A File Offset: 0x0003024A
		public void SetSessionId(string sessionId)
		{
			this.sessionId = sessionId;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00032053 File Offset: 0x00030253
		public User.Profile GetProfile()
		{
			return this.profile;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0003205B File Offset: 0x0003025B
		public void SetProfile(User.Profile profile)
		{
			this.profile = profile;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00032064 File Offset: 0x00030264
		public bool IsAccountLocked()
		{
			return this.accountLocked;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0003206C File Offset: 0x0003026C
		public void SetAccountLocked(bool accountLocked)
		{
			this.accountLocked = accountLocked;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00032075 File Offset: 0x00030275
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0003207D File Offset: 0x0003027D
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00032086 File Offset: 0x00030286
		public string GetPassword()
		{
			return this.password;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0003208E File Offset: 0x0003028E
		public void SetPassword(string password)
		{
			this.password = password;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00032097 File Offset: 0x00030297
		public string GetEmail()
		{
			return this.email;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0003209F File Offset: 0x0003029F
		public void SetEmail(string email)
		{
			this.email = email;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000320A8 File Offset: 0x000302A8
		public DateTime GetCreatedOn()
		{
			return this.createdOn;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000320B0 File Offset: 0x000302B0
		public void SetCreatedOn(DateTime createdOn)
		{
			this.createdOn = createdOn;
		}

		// Token: 0x040002FD RID: 765
		public string userName;

		// Token: 0x040002FE RID: 766
		public string password;

		// Token: 0x040002FF RID: 767
		public string email;

		// Token: 0x04000300 RID: 768
		public string sessionId;

		// Token: 0x04000301 RID: 769
		private User.Profile profile;

		// Token: 0x04000302 RID: 770
		public bool accountLocked;

		// Token: 0x04000303 RID: 771
		public DateTime createdOn;

		// Token: 0x04000304 RID: 772
		public IList<string> roleList = new List<string>();

		// Token: 0x04000305 RID: 773
		public IList<User.JSONDocument> jsonDocList = new List<User.JSONDocument>();

		// Token: 0x020000C5 RID: 197
		public class Profile
		{
			// Token: 0x06000869 RID: 2153 RVA: 0x000320D7 File Offset: 0x000302D7
			public Profile(User user)
			{
				user.profile = this;
			}

			// Token: 0x0600086A RID: 2154 RVA: 0x000320E8 File Offset: 0x000302E8
			public Profile()
			{
				User user = new User();
				user.profile = this;
			}

			// Token: 0x0600086B RID: 2155 RVA: 0x00032108 File Offset: 0x00030308
			public string GetSex()
			{
				return this.sex;
			}

			// Token: 0x0600086C RID: 2156 RVA: 0x00032110 File Offset: 0x00030310
			public void SetSex(string sex)
			{
				this.sex = sex;
			}

			// Token: 0x0600086D RID: 2157 RVA: 0x00032119 File Offset: 0x00030319
			public string GetFirstName()
			{
				return this.firstName;
			}

			// Token: 0x0600086E RID: 2158 RVA: 0x00032121 File Offset: 0x00030321
			public void SetFirstName(string firstName)
			{
				this.firstName = firstName;
			}

			// Token: 0x0600086F RID: 2159 RVA: 0x0003212A File Offset: 0x0003032A
			public string GetLastName()
			{
				return this.lastName;
			}

			// Token: 0x06000870 RID: 2160 RVA: 0x00032132 File Offset: 0x00030332
			public void SetLastName(string lastName)
			{
				this.lastName = lastName;
			}

			// Token: 0x06000871 RID: 2161 RVA: 0x0003213B File Offset: 0x0003033B
			public string GetMobile()
			{
				return this.mobile;
			}

			// Token: 0x06000872 RID: 2162 RVA: 0x00032143 File Offset: 0x00030343
			public void SetMobile(string mobile)
			{
				this.mobile = mobile;
			}

			// Token: 0x06000873 RID: 2163 RVA: 0x0003214C File Offset: 0x0003034C
			public string GetLine1()
			{
				return this.line1;
			}

			// Token: 0x06000874 RID: 2164 RVA: 0x00032154 File Offset: 0x00030354
			public void SetLine1(string line1)
			{
				this.line1 = line1;
			}

			// Token: 0x06000875 RID: 2165 RVA: 0x0003215D File Offset: 0x0003035D
			public string GetLine2()
			{
				return this.line2;
			}

			// Token: 0x06000876 RID: 2166 RVA: 0x00032165 File Offset: 0x00030365
			public void SetLine2(string line2)
			{
				this.line2 = line2;
			}

			// Token: 0x06000877 RID: 2167 RVA: 0x0003216E File Offset: 0x0003036E
			public string GetCity()
			{
				return this.city;
			}

			// Token: 0x06000878 RID: 2168 RVA: 0x00032176 File Offset: 0x00030376
			public void SetCity(string city)
			{
				this.city = city;
			}

			// Token: 0x06000879 RID: 2169 RVA: 0x0003217F File Offset: 0x0003037F
			public string GetState()
			{
				return this.state;
			}

			// Token: 0x0600087A RID: 2170 RVA: 0x00032187 File Offset: 0x00030387
			public void SetState(string state)
			{
				this.state = state;
			}

			// Token: 0x0600087B RID: 2171 RVA: 0x00032190 File Offset: 0x00030390
			public string GetCountry()
			{
				return this.country;
			}

			// Token: 0x0600087C RID: 2172 RVA: 0x00032198 File Offset: 0x00030398
			public void SetCountry(string country)
			{
				this.country = country;
			}

			// Token: 0x0600087D RID: 2173 RVA: 0x000321A1 File Offset: 0x000303A1
			public string GetPincode()
			{
				return this.pincode;
			}

			// Token: 0x0600087E RID: 2174 RVA: 0x000321A9 File Offset: 0x000303A9
			public void SetPincode(string pincode)
			{
				this.pincode = pincode;
			}

			// Token: 0x0600087F RID: 2175 RVA: 0x000321B2 File Offset: 0x000303B2
			public string GetHomeLandLine()
			{
				return this.homeLandLine;
			}

			// Token: 0x06000880 RID: 2176 RVA: 0x000321BA File Offset: 0x000303BA
			public void SetHomeLandLine(string homeLandLine)
			{
				this.homeLandLine = homeLandLine;
			}

			// Token: 0x06000881 RID: 2177 RVA: 0x000321C3 File Offset: 0x000303C3
			public string GetOfficeLandLine()
			{
				return this.officeLandLine;
			}

			// Token: 0x06000882 RID: 2178 RVA: 0x000321CB File Offset: 0x000303CB
			public void SetOfficeLandLine(string officeLandLine)
			{
				this.officeLandLine = officeLandLine;
			}

			// Token: 0x06000883 RID: 2179 RVA: 0x000321D4 File Offset: 0x000303D4
			public DateTime GetDateOfBirth()
			{
				return this.dateOfBirth;
			}

			// Token: 0x06000884 RID: 2180 RVA: 0x000321DC File Offset: 0x000303DC
			public void SetDateOfBirth(DateTime dateOfBirth)
			{
				this.dateOfBirth = dateOfBirth;
			}

			// Token: 0x04000306 RID: 774
			public string firstName;

			// Token: 0x04000307 RID: 775
			public string lastName;

			// Token: 0x04000308 RID: 776
			public string sex;

			// Token: 0x04000309 RID: 777
			public string mobile;

			// Token: 0x0400030A RID: 778
			public string line1;

			// Token: 0x0400030B RID: 779
			public string line2;

			// Token: 0x0400030C RID: 780
			public string city;

			// Token: 0x0400030D RID: 781
			public string state;

			// Token: 0x0400030E RID: 782
			public string country;

			// Token: 0x0400030F RID: 783
			public string pincode;

			// Token: 0x04000310 RID: 784
			public string homeLandLine;

			// Token: 0x04000311 RID: 785
			public string officeLandLine;

			// Token: 0x04000312 RID: 786
			public DateTime dateOfBirth;
		}

		// Token: 0x020000C6 RID: 198
		public class JSONDocument
		{
			// Token: 0x06000885 RID: 2181 RVA: 0x000321E5 File Offset: 0x000303E5
			public JSONDocument(User user)
			{
				user.jsonDocList.Add(this);
			}

			// Token: 0x06000886 RID: 2182 RVA: 0x00032204 File Offset: 0x00030404
			public string GetEvent()
			{
				return this.eventName;
			}

			// Token: 0x06000887 RID: 2183 RVA: 0x0003220C File Offset: 0x0003040C
			public void SetEvent(string eventName)
			{
				this.eventName = eventName;
			}

			// Token: 0x06000888 RID: 2184 RVA: 0x00032215 File Offset: 0x00030415
			public string GetJsonDoc()
			{
				return this.jsonDoc;
			}

			// Token: 0x06000889 RID: 2185 RVA: 0x0003221D File Offset: 0x0003041D
			public void SetJsonDoc(string jsonDoc)
			{
				this.jsonDoc = jsonDoc;
			}

			// Token: 0x0600088A RID: 2186 RVA: 0x00032226 File Offset: 0x00030426
			public string GetDocId()
			{
				return this.docId;
			}

			// Token: 0x0600088B RID: 2187 RVA: 0x0003222E File Offset: 0x0003042E
			public void SetDocId(string docId)
			{
				this.docId = docId;
			}

			// Token: 0x0600088C RID: 2188 RVA: 0x00032237 File Offset: 0x00030437
			public string GetCreatedAt()
			{
				return this.createdAt;
			}

			// Token: 0x0600088D RID: 2189 RVA: 0x0003223F File Offset: 0x0003043F
			public void SetCreatedAt(string createdAt)
			{
				this.createdAt = createdAt;
			}

			// Token: 0x0600088E RID: 2190 RVA: 0x00032248 File Offset: 0x00030448
			public string GetUpdatedAt()
			{
				return this.updatedAt;
			}

			// Token: 0x0600088F RID: 2191 RVA: 0x00032250 File Offset: 0x00030450
			public void SetUpdatedAt(string updatedAt)
			{
				this.updatedAt = updatedAt;
			}

			// Token: 0x06000890 RID: 2192 RVA: 0x00032259 File Offset: 0x00030459
			public GeoTag GetLocation()
			{
				return this.loc;
			}

			// Token: 0x06000891 RID: 2193 RVA: 0x00032261 File Offset: 0x00030461
			public void SetLocation(GeoTag loc)
			{
				this.loc = loc;
			}

			// Token: 0x06000892 RID: 2194 RVA: 0x0003226A File Offset: 0x0003046A
			public override string ToString()
			{
				if (this.docId != null && this.jsonDoc != null)
				{
					return this.docId + " : " + this.jsonDoc;
				}
				return base.ToString();
			}

			// Token: 0x06000893 RID: 2195 RVA: 0x00032299 File Offset: 0x00030499
			public HashSet<ACL> GetAclList()
			{
				return this.aclList;
			}

			// Token: 0x06000894 RID: 2196 RVA: 0x000322A1 File Offset: 0x000304A1
			public void SetAclList(HashSet<ACL> aclSet)
			{
				this.aclList = aclSet;
			}

			// Token: 0x06000895 RID: 2197 RVA: 0x000322AA File Offset: 0x000304AA
			public string GetOwner()
			{
				return this.owner;
			}

			// Token: 0x06000896 RID: 2198 RVA: 0x000322B2 File Offset: 0x000304B2
			public void SetOwner(string owner)
			{
				this.owner = owner;
			}

			// Token: 0x04000313 RID: 787
			public string jsonDoc;

			// Token: 0x04000314 RID: 788
			public string docId;

			// Token: 0x04000315 RID: 789
			private string owner;

			// Token: 0x04000316 RID: 790
			private string eventName;

			// Token: 0x04000317 RID: 791
			public string createdAt;

			// Token: 0x04000318 RID: 792
			public string updatedAt;

			// Token: 0x04000319 RID: 793
			public GeoTag loc;

			// Token: 0x0400031A RID: 794
			public HashSet<ACL> aclList = new HashSet<ACL>();
		}
	}
}
