using System;
using System.Text;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x02000054 RID: 84
	public class GeoTag
	{
		// Token: 0x0600031B RID: 795 RVA: 0x00011A0F File Offset: 0x0000FC0F
		public GeoTag()
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00011A17 File Offset: 0x0000FC17
		public GeoTag(double lat, double lng)
		{
			this.lat = lat;
			this.lng = lng;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00011A2D File Offset: 0x0000FC2D
		public void SetLat(double lat)
		{
			this.lat = lat;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00011A36 File Offset: 0x0000FC36
		public double GetLat()
		{
			return this.lat;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00011A3E File Offset: 0x0000FC3E
		public void SetLng(double lng)
		{
			this.lng = lng;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00011A47 File Offset: 0x0000FC47
		public double GetLng()
		{
			return this.lng;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00011A50 File Offset: 0x0000FC50
		public StringBuilder GetJSONObject()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"lat\":\"" + this.lat + "\",");
			stringBuilder.Append("\"lng\":\"" + this.lng + "\"}");
			return stringBuilder;
		}

		// Token: 0x0400015A RID: 346
		private double lat;

		// Token: 0x0400015B RID: 347
		private double lng;
	}
}
