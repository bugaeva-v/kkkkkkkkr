using System;
using System.Collections.Generic;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics
{
	// Token: 0x0200000E RID: 14
	public abstract class Event
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002C94 File Offset: 0x00000E94
		protected Event(string name)
		{
			this.Name = name;
			this.m_Strings = new Dictionary<string, string>(StringComparer.Ordinal);
			this.m_Integers = new Dictionary<string, long>(StringComparer.Ordinal);
			this.m_Booleans = new Dictionary<string, bool>(StringComparer.Ordinal);
			this.m_Floats = new Dictionary<string, double>(StringComparer.Ordinal);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002CEE File Offset: 0x00000EEE
		internal Event(string name, bool standardEvent, int eventVersion) : this(name)
		{
			this.StandardEvent = standardEvent;
			this.EventVersion = eventVersion;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002D05 File Offset: 0x00000F05
		protected void SetParameter(string name, string value)
		{
			this.m_Strings[name] = value;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002D14 File Offset: 0x00000F14
		protected void SetParameter(string name, bool value)
		{
			this.m_Booleans[name] = value;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002D23 File Offset: 0x00000F23
		protected void SetParameter(string name, int value)
		{
			this.SetParameter(name, (long)value);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002D2E File Offset: 0x00000F2E
		protected void SetParameter(string name, long value)
		{
			this.m_Integers[name] = value;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002D3D File Offset: 0x00000F3D
		protected void SetParameter(string name, float value)
		{
			this.SetParameter(name, (double)value);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002D48 File Offset: 0x00000F48
		protected void SetParameter(string name, double value)
		{
			this.m_Floats[name] = value;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002D58 File Offset: 0x00000F58
		internal virtual void Serialize(IBuffer buffer)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.m_Strings)
			{
				buffer.PushString(keyValuePair.Key, keyValuePair.Value);
			}
			foreach (KeyValuePair<string, long> keyValuePair2 in this.m_Integers)
			{
				buffer.PushInt64(keyValuePair2.Key, keyValuePair2.Value);
			}
			foreach (KeyValuePair<string, double> keyValuePair3 in this.m_Floats)
			{
				buffer.PushDouble(keyValuePair3.Key, keyValuePair3.Value);
			}
			foreach (KeyValuePair<string, bool> keyValuePair4 in this.m_Booleans)
			{
				buffer.PushBool(keyValuePair4.Key, keyValuePair4.Value);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002EAC File Offset: 0x000010AC
		public virtual void Validate()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002EAE File Offset: 0x000010AE
		protected bool ParameterHasBeenSet(string name)
		{
			return this.m_Strings.ContainsKey(name) || this.m_Integers.ContainsKey(name) || this.m_Floats.ContainsKey(name) || this.m_Booleans.ContainsKey(name);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002EE8 File Offset: 0x000010E8
		public virtual void Reset()
		{
			this.m_Strings.Clear();
			this.m_Integers.Clear();
			this.m_Booleans.Clear();
			this.m_Floats.Clear();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002F18 File Offset: 0x00001118
		internal static string[] BakeEnum2String<T>(bool toUpper = false) where T : Enum
		{
			Array values = Enum.GetValues(typeof(T));
			string[] array = new string[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				if (toUpper)
				{
					array[i] = values.GetValue(i).ToString().ToUpperInvariant();
				}
				else
				{
					array[i] = values.GetValue(i).ToString();
				}
			}
			return array;
		}

		// Token: 0x04000039 RID: 57
		private protected readonly Dictionary<string, string> m_Strings;

		// Token: 0x0400003A RID: 58
		private protected readonly Dictionary<string, long> m_Integers;

		// Token: 0x0400003B RID: 59
		private protected readonly Dictionary<string, bool> m_Booleans;

		// Token: 0x0400003C RID: 60
		private protected readonly Dictionary<string, double> m_Floats;

		// Token: 0x0400003D RID: 61
		internal readonly string Name;

		// Token: 0x0400003E RID: 62
		internal readonly bool StandardEvent;

		// Token: 0x0400003F RID: 63
		internal readonly int EventVersion;
	}
}
