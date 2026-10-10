using System;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000197 RID: 407
	public static class XmlSimpleSerializer
	{
		// Token: 0x06000CBA RID: 3258 RVA: 0x0001EACD File Offset: 0x0001CCCD
		private static string XmlConvert_ToString(DateTime value)
		{
			return XmlConvert.ToString(value, XmlDateTimeSerializationMode.RoundtripKind);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0001EAD6 File Offset: 0x0001CCD6
		private static DateTime XmlConvert_ToDateTime(string value)
		{
			return XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.RoundtripKind);
		}

		// Token: 0x040002B5 RID: 693
		public static readonly XmlTypeSerializer ForBoolean = new XmlSimpleSerializer<bool>(new Func<bool, string>(XmlConvert.ToString), new Func<string, bool>(XmlConvert.ToBoolean));

		// Token: 0x040002B6 RID: 694
		public static readonly XmlTypeSerializer ForChar = new XmlSimpleSerializer<char>(new Func<char, string>(XmlConvert.ToString), new Func<string, char>(XmlConvert.ToChar));

		// Token: 0x040002B7 RID: 695
		public static readonly XmlTypeSerializer ForSByte = new XmlSimpleSerializer<sbyte>(new Func<sbyte, string>(XmlConvert.ToString), new Func<string, sbyte>(XmlConvert.ToSByte));

		// Token: 0x040002B8 RID: 696
		public static readonly XmlTypeSerializer ForInt16 = new XmlSimpleSerializer<short>(new Func<short, string>(XmlConvert.ToString), new Func<string, short>(XmlConvert.ToInt16));

		// Token: 0x040002B9 RID: 697
		public static readonly XmlTypeSerializer ForInt32 = new XmlSimpleSerializer<int>(new Func<int, string>(XmlConvert.ToString), new Func<string, int>(XmlConvert.ToInt32));

		// Token: 0x040002BA RID: 698
		public static readonly XmlTypeSerializer ForInt64 = new XmlSimpleSerializer<long>(new Func<long, string>(XmlConvert.ToString), new Func<string, long>(XmlConvert.ToInt64));

		// Token: 0x040002BB RID: 699
		public static readonly XmlTypeSerializer ForByte = new XmlSimpleSerializer<byte>(new Func<byte, string>(XmlConvert.ToString), new Func<string, byte>(XmlConvert.ToByte));

		// Token: 0x040002BC RID: 700
		public static readonly XmlTypeSerializer ForUInt16 = new XmlSimpleSerializer<ushort>(new Func<ushort, string>(XmlConvert.ToString), new Func<string, ushort>(XmlConvert.ToUInt16));

		// Token: 0x040002BD RID: 701
		public static readonly XmlTypeSerializer ForUInt32 = new XmlSimpleSerializer<uint>(new Func<uint, string>(XmlConvert.ToString), new Func<string, uint>(XmlConvert.ToUInt32));

		// Token: 0x040002BE RID: 702
		public static readonly XmlTypeSerializer ForUInt64 = new XmlSimpleSerializer<ulong>(new Func<ulong, string>(XmlConvert.ToString), new Func<string, ulong>(XmlConvert.ToUInt64));

		// Token: 0x040002BF RID: 703
		public static readonly XmlTypeSerializer ForSingle = new XmlSimpleSerializer<float>(new Func<float, string>(XmlConvert.ToString), new Func<string, float>(XmlConvert.ToSingle));

		// Token: 0x040002C0 RID: 704
		public static readonly XmlTypeSerializer ForDouble = new XmlSimpleSerializer<double>(new Func<double, string>(XmlConvert.ToString), new Func<string, double>(XmlConvert.ToDouble));

		// Token: 0x040002C1 RID: 705
		public static readonly XmlTypeSerializer ForDecimal = new XmlSimpleSerializer<decimal>(new Func<decimal, string>(XmlConvert.ToString), new Func<string, decimal>(XmlConvert.ToDecimal));

		// Token: 0x040002C2 RID: 706
		public static readonly XmlTypeSerializer ForTimeSpan = new XmlSimpleSerializer<TimeSpan>(new Func<TimeSpan, string>(XmlConvert.ToString), new Func<string, TimeSpan>(XmlConvert.ToTimeSpan));

		// Token: 0x040002C3 RID: 707
		public static readonly XmlTypeSerializer ForDateTime = new XmlSimpleSerializer<DateTime>(new Func<DateTime, string>(XmlSimpleSerializer.XmlConvert_ToString), new Func<string, DateTime>(XmlSimpleSerializer.XmlConvert_ToDateTime));

		// Token: 0x040002C4 RID: 708
		public static readonly XmlTypeSerializer ForDateTimeOffset = new XmlSimpleSerializer<DateTimeOffset>(new Func<DateTimeOffset, string>(XmlConvert.ToString), new Func<string, DateTimeOffset>(XmlConvert.ToDateTimeOffset));

		// Token: 0x040002C5 RID: 709
		public static readonly XmlTypeSerializer ForGuid = new XmlSimpleSerializer<Guid>(new Func<Guid, string>(XmlConvert.ToString), new Func<string, Guid>(XmlConvert.ToGuid));

		// Token: 0x040002C6 RID: 710
		public static readonly XmlTypeSerializer ForByteArray = new XmlSimpleSerializer<byte[]>(new Func<byte[], string>(Convert.ToBase64String), new Func<string, byte[]>(Convert.FromBase64String));

		// Token: 0x040002C7 RID: 711
		public static readonly XmlTypeSerializer ForUri = new XmlSimpleSerializer<Uri>((Uri u) => u.ToString(), (string s) => new Uri(s, UriKind.RelativeOrAbsolute));
	}
}
