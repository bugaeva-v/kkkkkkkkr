using System;
using System.Collections.Generic;
using System.Globalization;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000015 RID: 21
	public sealed class LevelPlaySegment
	{
		// Token: 0x06000128 RID: 296 RVA: 0x000041A1 File Offset: 0x000023A1
		public void SetCustom(string key, string value)
		{
			this.CustomData[key] = value;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000041B0 File Offset: 0x000023B0
		public Dictionary<string, string> GetSegmentAsDictionary()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (this.Level != -1)
			{
				dictionary.Add("level", this.Level.ToString());
			}
			if (this.IsPaying > -1 && this.IsPaying < 2)
			{
				dictionary.Add("isPaying", this.IsPaying.ToString());
			}
			if (this.UserCreationDate != -1L)
			{
				dictionary.Add("userCreationDate", this.UserCreationDate.ToString());
			}
			if (!string.IsNullOrEmpty(this.SegmentName))
			{
				dictionary.Add("segmentName", this.SegmentName);
			}
			if (this.IapTotal > 0.0)
			{
				dictionary.Add("iapt", this.IapTotal.ToString(CultureInfo.InvariantCulture));
			}
			foreach (KeyValuePair<string, string> keyValuePair in this.CustomData)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			return dictionary;
		}

		// Token: 0x0400006A RID: 106
		public int Level = -1;

		// Token: 0x0400006B RID: 107
		public int IsPaying = -1;

		// Token: 0x0400006C RID: 108
		public long UserCreationDate = -1L;

		// Token: 0x0400006D RID: 109
		public double IapTotal;

		// Token: 0x0400006E RID: 110
		public string SegmentName;

		// Token: 0x0400006F RID: 111
		public readonly Dictionary<string, string> CustomData = new Dictionary<string, string>();
	}
}
