using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.gallery
{
	// Token: 0x0200000E RID: 14
	public class Album : App42Response
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00003B31 File Offset: 0x00001D31
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003B39 File Offset: 0x00001D39
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003B42 File Offset: 0x00001D42
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003B4A File Offset: 0x00001D4A
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003B53 File Offset: 0x00001D53
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003B5B File Offset: 0x00001D5B
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003B64 File Offset: 0x00001D64
		public IList<Album.Photo> GetPhotoList()
		{
			return this.photoList;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003B6C File Offset: 0x00001D6C
		public void SetPhotoList(IList<Album.Photo> photoList)
		{
			this.photoList = photoList;
		}

		// Token: 0x04000029 RID: 41
		public string userName;

		// Token: 0x0400002A RID: 42
		public string name;

		// Token: 0x0400002B RID: 43
		public string description;

		// Token: 0x0400002C RID: 44
		public IList<Album.Photo> photoList = new List<Album.Photo>();

		// Token: 0x0200000F RID: 15
		public class Photo
		{
			// Token: 0x06000072 RID: 114 RVA: 0x00003B88 File Offset: 0x00001D88
			public Photo(Album album)
			{
				album.photoList.Add(this);
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00003BA7 File Offset: 0x00001DA7
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x06000074 RID: 116 RVA: 0x00003BAF File Offset: 0x00001DAF
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00003BB8 File Offset: 0x00001DB8
			public string GetDescription()
			{
				return this.description;
			}

			// Token: 0x06000076 RID: 118 RVA: 0x00003BC0 File Offset: 0x00001DC0
			public void SetDescription(string description)
			{
				this.description = description;
			}

			// Token: 0x06000077 RID: 119 RVA: 0x00003BC9 File Offset: 0x00001DC9
			public string GetUrl()
			{
				return this.url;
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00003BD1 File Offset: 0x00001DD1
			public void SetUrl(string url)
			{
				this.url = url;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00003BDA File Offset: 0x00001DDA
			public IList<string> GetTagList()
			{
				return this.tagList;
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00003BE2 File Offset: 0x00001DE2
			public void SetTagList(IList<string> tagList)
			{
				this.tagList = tagList;
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00003BEB File Offset: 0x00001DEB
			public string GetTinyUrl()
			{
				return this.tinyUrl;
			}

			// Token: 0x0600007C RID: 124 RVA: 0x00003BF3 File Offset: 0x00001DF3
			public void SetTinyUrl(string tinyUrl)
			{
				this.tinyUrl = tinyUrl;
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00003BFC File Offset: 0x00001DFC
			public string GetThumbNailUrl()
			{
				return this.thumbNailUrl;
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00003C04 File Offset: 0x00001E04
			public void SetThumbNailUrl(string thumbNailUrl)
			{
				this.thumbNailUrl = thumbNailUrl;
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00003C0D File Offset: 0x00001E0D
			public string GetThumbNailTinyUrl()
			{
				return this.thumbNailTinyUrl;
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00003C15 File Offset: 0x00001E15
			public void SetThumbNailTinyUrl(string thumbNailTinyUrl)
			{
				this.thumbNailTinyUrl = thumbNailTinyUrl;
			}

			// Token: 0x06000081 RID: 129 RVA: 0x00003C20 File Offset: 0x00001E20
			public override string ToString()
			{
				return string.Concat(new object[]
				{
					" name : ",
					this.name,
					" : description : ",
					this.description,
					" : url : ",
					this.url,
					" : tinyUrl : ",
					this.tinyUrl,
					" : thumbNailUrl : ",
					this.thumbNailUrl,
					" :  thumbNailTinyUrl  : ",
					this.thumbNailTinyUrl,
					" : tagList : ",
					this.tagList
				});
			}

			// Token: 0x0400002D RID: 45
			public string name;

			// Token: 0x0400002E RID: 46
			public string description;

			// Token: 0x0400002F RID: 47
			public string url;

			// Token: 0x04000030 RID: 48
			public string tinyUrl;

			// Token: 0x04000031 RID: 49
			public string thumbNailUrl;

			// Token: 0x04000032 RID: 50
			public string thumbNailTinyUrl;

			// Token: 0x04000033 RID: 51
			public IList<string> tagList = new List<string>();
		}
	}
}
