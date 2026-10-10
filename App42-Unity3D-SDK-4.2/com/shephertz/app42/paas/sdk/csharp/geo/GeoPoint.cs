using System;
using System.Text;

namespace com.shephertz.app42.paas.sdk.csharp.geo
{
	// Token: 0x02000050 RID: 80
	public class GeoPoint
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00010A9B File Offset: 0x0000EC9B
		public GeoPoint()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00010AA3 File Offset: 0x0000ECA3
		public GeoPoint(double lat, double lng, string marker)
		{
			this.lat = lat;
			this.lng = lng;
			this.marker = marker;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		public void SetLat(double lat)
		{
			this.lat = lat;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00010AC9 File Offset: 0x0000ECC9
		public double GetLat()
		{
			return this.lat;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00010AD1 File Offset: 0x0000ECD1
		public void SetLng(double lng)
		{
			this.lng = lng;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00010ADA File Offset: 0x0000ECDA
		public double GetLng()
		{
			return this.lng;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00010AE2 File Offset: 0x0000ECE2
		public void SetMarker(string marker)
		{
			this.marker = marker;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00010AEB File Offset: 0x0000ECEB
		public string GetMarker()
		{
			return this.marker;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		public StringBuilder GetJSONObject()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"lat\":\"" + this.lat + "\",");
			stringBuilder.Append("\"lng\":\"" + this.lng + "\",");
			stringBuilder.Append("\"marker\":\"" + this.marker + "\"}");
			return stringBuilder;
		}

		// Token: 0x04000155 RID: 341
		private double lat;

		// Token: 0x04000156 RID: 342
		private double lng;

		// Token: 0x04000157 RID: 343
		private string marker;
	}
}
