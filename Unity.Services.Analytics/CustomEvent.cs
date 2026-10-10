using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.Services.Analytics
{
	// Token: 0x0200000D RID: 13
	public class CustomEvent : Event, IEnumerable
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00002B8C File Offset: 0x00000D8C
		public CustomEvent(string name) : base(name)
		{
		}

		// Token: 0x17000026 RID: 38
		public object this[string key]
		{
			set
			{
				this.Add(key, value);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public void Add(string key, object value)
		{
			Type type = value.GetType();
			if (type == typeof(string))
			{
				base.SetParameter(key, (string)value);
				return;
			}
			if (type == typeof(int))
			{
				base.SetParameter(key, (int)value);
				return;
			}
			if (type == typeof(long))
			{
				base.SetParameter(key, (long)value);
				return;
			}
			if (type == typeof(float))
			{
				base.SetParameter(key, (float)value);
				return;
			}
			if (type == typeof(double))
			{
				base.SetParameter(key, (double)value);
				return;
			}
			if (type == typeof(bool))
			{
				base.SetParameter(key, (bool)value);
				return;
			}
			throw new ArgumentException(string.Format("Values of type {0} cannot be included as event parameters.", type));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002C84 File Offset: 0x00000E84
		public IEnumerator GetEnumerator()
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.m_Strings)
			{
				yield return new KeyValuePair<string, object>(keyValuePair.Key, keyValuePair.Value);
			}
			Dictionary<string, string>.Enumerator enumerator = default(Dictionary<string, string>.Enumerator);
			foreach (KeyValuePair<string, long> keyValuePair2 in this.m_Integers)
			{
				yield return new KeyValuePair<string, object>(keyValuePair2.Key, keyValuePair2.Value);
			}
			Dictionary<string, long>.Enumerator enumerator2 = default(Dictionary<string, long>.Enumerator);
			foreach (KeyValuePair<string, double> keyValuePair3 in this.m_Floats)
			{
				yield return new KeyValuePair<string, object>(keyValuePair3.Key, keyValuePair3.Value);
			}
			Dictionary<string, double>.Enumerator enumerator3 = default(Dictionary<string, double>.Enumerator);
			foreach (KeyValuePair<string, bool> keyValuePair4 in this.m_Booleans)
			{
				yield return new KeyValuePair<string, object>(keyValuePair4.Key, keyValuePair4.Value);
			}
			Dictionary<string, bool>.Enumerator enumerator4 = default(Dictionary<string, bool>.Enumerator);
			yield break;
			yield break;
		}
	}
}
