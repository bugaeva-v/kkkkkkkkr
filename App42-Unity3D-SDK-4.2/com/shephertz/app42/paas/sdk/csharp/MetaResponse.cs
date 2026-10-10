using System;
using System.Collections.Generic;
using com.shephertz.app42.paas.sdk.csharp.storage;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000048 RID: 72
	public class MetaResponse
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x0000FB27 File Offset: 0x0000DD27
		public void SetJsonDocList(IList<MetaResponse.JSONDocument> jsonDocList)
		{
			this.jsonDocList = jsonDocList;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000FB30 File Offset: 0x0000DD30
		public IList<MetaResponse.JSONDocument> GetJsonDocList()
		{
			return this.jsonDocList;
		}

		// Token: 0x04000136 RID: 310
		public IList<MetaResponse.JSONDocument> jsonDocList = new List<MetaResponse.JSONDocument>();

		// Token: 0x02000049 RID: 73
		public class JSONDocument
		{
			// Token: 0x060002B4 RID: 692 RVA: 0x0000FB4B File Offset: 0x0000DD4B
			public JSONDocument(MetaResponse metaResponse)
			{
				metaResponse.jsonDocList.Add(this);
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000FB6A File Offset: 0x0000DD6A
			public string GetEvent()
			{
				return this.eventName;
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0000FB72 File Offset: 0x0000DD72
			public void SetEvent(string eventName)
			{
				this.eventName = eventName;
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0000FB7B File Offset: 0x0000DD7B
			public string GetJsonDoc()
			{
				return this.jsonDoc;
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x0000FB83 File Offset: 0x0000DD83
			public void SetJsonDoc(string jsonDoc)
			{
				this.jsonDoc = jsonDoc;
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000FB8C File Offset: 0x0000DD8C
			public string GetDocId()
			{
				return this.docId;
			}

			// Token: 0x060002BA RID: 698 RVA: 0x0000FB94 File Offset: 0x0000DD94
			public void SetDocId(string docId)
			{
				this.docId = docId;
			}

			// Token: 0x060002BB RID: 699 RVA: 0x0000FB9D File Offset: 0x0000DD9D
			public string GetCreatedAt()
			{
				return this.createdAt;
			}

			// Token: 0x060002BC RID: 700 RVA: 0x0000FBA5 File Offset: 0x0000DDA5
			public void SetCreatedAt(string createdAt)
			{
				this.createdAt = createdAt;
			}

			// Token: 0x060002BD RID: 701 RVA: 0x0000FBAE File Offset: 0x0000DDAE
			public string GetUpdatedAt()
			{
				return this.updatedAt;
			}

			// Token: 0x060002BE RID: 702 RVA: 0x0000FBB6 File Offset: 0x0000DDB6
			public void SetUpdatedAt(string updatedAt)
			{
				this.updatedAt = updatedAt;
			}

			// Token: 0x060002BF RID: 703 RVA: 0x0000FBBF File Offset: 0x0000DDBF
			public GeoTag GetLocation()
			{
				return this.loc;
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x0000FBC7 File Offset: 0x0000DDC7
			public void SetLocation(GeoTag loc)
			{
				this.loc = loc;
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
			public override string ToString()
			{
				if (this.docId != null && this.jsonDoc != null)
				{
					return this.docId + " : " + this.jsonDoc;
				}
				return base.ToString();
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x0000FBFF File Offset: 0x0000DDFF
			public HashSet<ACL> GetAclList()
			{
				return this.aclList;
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x0000FC07 File Offset: 0x0000DE07
			public void SetAclList(HashSet<ACL> aclSet)
			{
				this.aclList = aclSet;
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0000FC10 File Offset: 0x0000DE10
			public string GetOwner()
			{
				return this.owner;
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x0000FC18 File Offset: 0x0000DE18
			public void SetOwner(string owner)
			{
				this.owner = owner;
			}

			// Token: 0x04000137 RID: 311
			public string jsonDoc;

			// Token: 0x04000138 RID: 312
			public string docId;

			// Token: 0x04000139 RID: 313
			public string eventName;

			// Token: 0x0400013A RID: 314
			private string owner;

			// Token: 0x0400013B RID: 315
			public string createdAt;

			// Token: 0x0400013C RID: 316
			public string updatedAt;

			// Token: 0x0400013D RID: 317
			public GeoTag loc;

			// Token: 0x0400013E RID: 318
			public HashSet<ACL> aclList = new HashSet<ACL>();
		}
	}
}
