using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x020000B5 RID: 181
	public class Storage : App42Response
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x0002BD18 File Offset: 0x00029F18
		public long GetRecordCount()
		{
			return this.recordCount;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0002BD20 File Offset: 0x00029F20
		public void SetRecordCount(long recordCount)
		{
			this.recordCount = recordCount;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0002BD29 File Offset: 0x00029F29
		public string GetDbName()
		{
			return this.dbName;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0002BD31 File Offset: 0x00029F31
		public void SetDbName(string dbName)
		{
			this.dbName = dbName;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0002BD3A File Offset: 0x00029F3A
		public string GetCollectionName()
		{
			return this.collectionName;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0002BD42 File Offset: 0x00029F42
		public void SetCollectionName(string collectionName)
		{
			this.collectionName = collectionName;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0002BD4B File Offset: 0x00029F4B
		public IList<Storage.JSONDocument> GetJsonDocList()
		{
			return this.jsonDocList;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002BD53 File Offset: 0x00029F53
		public void SetJsonDocList(IList<Storage.JSONDocument> jsonDocList)
		{
			this.jsonDocList = jsonDocList;
		}

		// Token: 0x040002CC RID: 716
		public string dbName;

		// Token: 0x040002CD RID: 717
		public string collectionName;

		// Token: 0x040002CE RID: 718
		public long recordCount;

		// Token: 0x040002CF RID: 719
		public IList<Storage.JSONDocument> jsonDocList = new List<Storage.JSONDocument>();

		// Token: 0x020000B6 RID: 182
		public class JSONDocument
		{
			// Token: 0x060007B5 RID: 1973 RVA: 0x0002BD6F File Offset: 0x00029F6F
			public IList<App42File> GetFileList()
			{
				return this.fileList;
			}

			// Token: 0x060007B6 RID: 1974 RVA: 0x0002BD77 File Offset: 0x00029F77
			public JSONDocument(Storage storage)
			{
				storage.jsonDocList.Add(this);
			}

			// Token: 0x060007B7 RID: 1975 RVA: 0x0002BDA1 File Offset: 0x00029FA1
			public string GetEvent()
			{
				return this.eventName;
			}

			// Token: 0x060007B8 RID: 1976 RVA: 0x0002BDA9 File Offset: 0x00029FA9
			public void SetEvent(string eventName)
			{
				this.eventName = eventName;
			}

			// Token: 0x060007B9 RID: 1977 RVA: 0x0002BDB2 File Offset: 0x00029FB2
			public string GetJsonDoc()
			{
				return this.jsonDoc;
			}

			// Token: 0x060007BA RID: 1978 RVA: 0x0002BDBA File Offset: 0x00029FBA
			public void SetJsonDoc(string jsonDoc)
			{
				this.jsonDoc = jsonDoc;
			}

			// Token: 0x060007BB RID: 1979 RVA: 0x0002BDC3 File Offset: 0x00029FC3
			public string GetDocId()
			{
				return this.docId;
			}

			// Token: 0x060007BC RID: 1980 RVA: 0x0002BDCB File Offset: 0x00029FCB
			public void SetDocId(string docId)
			{
				this.docId = docId;
			}

			// Token: 0x060007BD RID: 1981 RVA: 0x0002BDD4 File Offset: 0x00029FD4
			public string GetCreatedAt()
			{
				return this.createdAt;
			}

			// Token: 0x060007BE RID: 1982 RVA: 0x0002BDDC File Offset: 0x00029FDC
			public void SetCreatedAt(string createdAt)
			{
				this.createdAt = createdAt;
			}

			// Token: 0x060007BF RID: 1983 RVA: 0x0002BDE5 File Offset: 0x00029FE5
			public string GetUpdatedAt()
			{
				return this.updatedAt;
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x0002BDED File Offset: 0x00029FED
			public void SetUpdatedAt(string updatedAt)
			{
				this.updatedAt = updatedAt;
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x0002BDF6 File Offset: 0x00029FF6
			public GeoTag GetLocation()
			{
				return this.loc;
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x0002BDFE File Offset: 0x00029FFE
			public void SetLocation(GeoTag loc)
			{
				this.loc = loc;
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x0002BE07 File Offset: 0x0002A007
			public override string ToString()
			{
				if (this.docId != null && this.jsonDoc != null)
				{
					return this.docId + " : " + this.jsonDoc;
				}
				return base.ToString();
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x0002BE36 File Offset: 0x0002A036
			public HashSet<ACL> GetAclList()
			{
				return this.aclList;
			}

			// Token: 0x060007C5 RID: 1989 RVA: 0x0002BE3E File Offset: 0x0002A03E
			public void SetAclList(HashSet<ACL> aclSet)
			{
				this.aclList = aclSet;
			}

			// Token: 0x060007C6 RID: 1990 RVA: 0x0002BE47 File Offset: 0x0002A047
			public string GetOwner()
			{
				return this.owner;
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x0002BE4F File Offset: 0x0002A04F
			public void SetOwner(string owner)
			{
				this.owner = owner;
			}

			// Token: 0x040002D0 RID: 720
			public string jsonDoc;

			// Token: 0x040002D1 RID: 721
			public string docId;

			// Token: 0x040002D2 RID: 722
			private string owner;

			// Token: 0x040002D3 RID: 723
			public string createdAt;

			// Token: 0x040002D4 RID: 724
			public string updatedAt;

			// Token: 0x040002D5 RID: 725
			public GeoTag loc;

			// Token: 0x040002D6 RID: 726
			public HashSet<ACL> aclList = new HashSet<ACL>();

			// Token: 0x040002D7 RID: 727
			public string eventName;

			// Token: 0x040002D8 RID: 728
			public IList<App42File> fileList = new List<App42File>();
		}
	}
}
