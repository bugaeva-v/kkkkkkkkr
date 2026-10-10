using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.geo
{
	// Token: 0x0200004E RID: 78
	public class Geo : App42Response
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00010959 File Offset: 0x0000EB59
		public string GetStorageName()
		{
			return this.storageName;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00010961 File Offset: 0x0000EB61
		public void SetStorageName(string storageName)
		{
			this.storageName = storageName;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001096A File Offset: 0x0000EB6A
		public string GetSourceLat()
		{
			return this.sourceLat;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00010972 File Offset: 0x0000EB72
		public void SetSourceLat(string sourceLat)
		{
			this.sourceLat = sourceLat;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001097B File Offset: 0x0000EB7B
		public string GetSourceLng()
		{
			return this.sourceLng;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00010983 File Offset: 0x0000EB83
		public void SetSourceLng(string sourceLng)
		{
			this.sourceLng = sourceLng;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001098C File Offset: 0x0000EB8C
		public double GetDistanceInKM()
		{
			return this.distanceInKM;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00010994 File Offset: 0x0000EB94
		public void SetDistanceInKM(double distanceInKM)
		{
			this.distanceInKM = distanceInKM;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001099D File Offset: 0x0000EB9D
		public DateTime GetCreatedOn()
		{
			return this.createdOn;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000109A5 File Offset: 0x0000EBA5
		public void SetCreatedOn(DateTime createdOn)
		{
			this.createdOn = createdOn;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000109AE File Offset: 0x0000EBAE
		public IList<Geo.Point> GetPointList()
		{
			return this.pointList;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000109B6 File Offset: 0x0000EBB6
		public void SetPointList(IList<Geo.Point> pointList)
		{
			this.pointList = pointList;
		}

		// Token: 0x0400014C RID: 332
		public string storageName;

		// Token: 0x0400014D RID: 333
		public string sourceLat;

		// Token: 0x0400014E RID: 334
		public string sourceLng;

		// Token: 0x0400014F RID: 335
		public double distanceInKM;

		// Token: 0x04000150 RID: 336
		public DateTime createdOn;

		// Token: 0x04000151 RID: 337
		public IList<Geo.Point> pointList = new List<Geo.Point>();

		// Token: 0x0200004F RID: 79
		public class Point
		{
			// Token: 0x060002F6 RID: 758 RVA: 0x000109D2 File Offset: 0x0000EBD2
			public Point(double lat, double lng, string marker, Geo geo)
			{
				this.lat = lat;
				this.lng = lng;
				this.marker = marker;
				geo.pointList.Add(this);
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x000109FC File Offset: 0x0000EBFC
			public Point(Geo geo)
			{
				geo.pointList.Add(this);
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x00010A10 File Offset: 0x0000EC10
			public double GetLat()
			{
				return this.lat;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x00010A18 File Offset: 0x0000EC18
			public void SetLat(double lat)
			{
				this.lat = lat;
			}

			// Token: 0x060002FA RID: 762 RVA: 0x00010A21 File Offset: 0x0000EC21
			public double GetLng()
			{
				return this.lng;
			}

			// Token: 0x060002FB RID: 763 RVA: 0x00010A29 File Offset: 0x0000EC29
			public void SetLng(double lng)
			{
				this.lng = lng;
			}

			// Token: 0x060002FC RID: 764 RVA: 0x00010A32 File Offset: 0x0000EC32
			public string GetMarker()
			{
				return this.marker;
			}

			// Token: 0x060002FD RID: 765 RVA: 0x00010A3A File Offset: 0x0000EC3A
			public void SetMarker(string marker)
			{
				this.marker = marker;
			}

			// Token: 0x060002FE RID: 766 RVA: 0x00010A44 File Offset: 0x0000EC44
			public override string ToString()
			{
				return string.Concat(new object[]
				{
					"Lat : ",
					this.lat,
					" : Lang : ",
					this.lng,
					" : Marker : ",
					this.marker
				});
			}

			// Token: 0x04000152 RID: 338
			public double lat;

			// Token: 0x04000153 RID: 339
			public double lng;

			// Token: 0x04000154 RID: 340
			public string marker;
		}
	}
}
