using System;

namespace com.shephertz.app42.paas.sdk.csharp.user
{
	// Token: 0x0200007E RID: 126
	public class ProfileData
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x0001C38F File Offset: 0x0001A58F
		public string GetFirstName()
		{
			return this.firstName;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001C397 File Offset: 0x0001A597
		public void SetFirstName(string firstName)
		{
			this.firstName = firstName;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0001C3A0 File Offset: 0x0001A5A0
		public string GetLastName()
		{
			return this.lastName;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		public void SetLastName(string lastName)
		{
			this.lastName = lastName;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001C3B1 File Offset: 0x0001A5B1
		public string GetSex()
		{
			return this.sex;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001C3B9 File Offset: 0x0001A5B9
		public void SetSex(string userGender)
		{
			if (!UserGender.MALE.ToString().Equals(userGender) && !UserGender.FEMALE.ToString().Equals(userGender))
			{
				throw new App42Exception("Invalid User Gender. Could be either Male or Female");
			}
			this.sex = userGender;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0001C3F1 File Offset: 0x0001A5F1
		public string GetMobile()
		{
			return this.mobile;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0001C3F9 File Offset: 0x0001A5F9
		public void SetMobile(string mobile)
		{
			this.mobile = mobile;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001C402 File Offset: 0x0001A602
		public string GetLine1()
		{
			return this.line1;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0001C40A File Offset: 0x0001A60A
		public void SetLine1(string line1)
		{
			this.line1 = line1;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001C413 File Offset: 0x0001A613
		public string GetLine2()
		{
			return this.line2;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0001C41B File Offset: 0x0001A61B
		public void SetLine2(string line2)
		{
			this.line2 = line2;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0001C424 File Offset: 0x0001A624
		public string GetCity()
		{
			return this.city;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0001C42C File Offset: 0x0001A62C
		public void SetCity(string city)
		{
			this.city = city;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0001C435 File Offset: 0x0001A635
		public string GetState()
		{
			return this.state;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0001C43D File Offset: 0x0001A63D
		public void SetState(string state)
		{
			this.state = state;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0001C446 File Offset: 0x0001A646
		public string GetCountry()
		{
			return this.country;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0001C44E File Offset: 0x0001A64E
		public void SetCountry(string country)
		{
			this.country = country;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001C457 File Offset: 0x0001A657
		public string GetPincode()
		{
			return this.pincode;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001C45F File Offset: 0x0001A65F
		public void SetPincode(string pincode)
		{
			this.pincode = pincode;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001C468 File Offset: 0x0001A668
		public string GetHomeLandLine()
		{
			return this.homeLandLine;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0001C470 File Offset: 0x0001A670
		public void SetHomeLandLine(string homeLandLine)
		{
			this.homeLandLine = homeLandLine;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001C479 File Offset: 0x0001A679
		public string GetOfficeLandLine()
		{
			return this.officeLandLine;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001C481 File Offset: 0x0001A681
		public void SetOfficeLandLine(string officeLandLine)
		{
			this.officeLandLine = officeLandLine;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0001C48A File Offset: 0x0001A68A
		public DateTime GetDateOfBirth()
		{
			return this.dateOfBirth;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001C492 File Offset: 0x0001A692
		public void SetDateOfBirth(DateTime dateOfBirth)
		{
			this.dateOfBirth = dateOfBirth;
		}

		// Token: 0x0400022A RID: 554
		private string firstName;

		// Token: 0x0400022B RID: 555
		private string lastName;

		// Token: 0x0400022C RID: 556
		private string sex;

		// Token: 0x0400022D RID: 557
		private string mobile;

		// Token: 0x0400022E RID: 558
		private string line1;

		// Token: 0x0400022F RID: 559
		private string line2;

		// Token: 0x04000230 RID: 560
		private string city;

		// Token: 0x04000231 RID: 561
		private string state;

		// Token: 0x04000232 RID: 562
		private string country;

		// Token: 0x04000233 RID: 563
		private string pincode;

		// Token: 0x04000234 RID: 564
		private string homeLandLine;

		// Token: 0x04000235 RID: 565
		private string officeLandLine;

		// Token: 0x04000236 RID: 566
		private DateTime dateOfBirth;
	}
}
