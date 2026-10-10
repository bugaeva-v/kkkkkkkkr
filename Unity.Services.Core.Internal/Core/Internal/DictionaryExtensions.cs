using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000056 RID: 86
	internal static class DictionaryExtensions
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00003FA8 File Offset: 0x000021A8
		public static TDictionary MergeNoOverride<TDictionary, TKey, TValue>(this TDictionary self, [NotNull] IDictionary<TKey, TValue> dictionary) where TDictionary : IDictionary<TKey, TValue>
		{
			foreach (KeyValuePair<TKey, TValue> keyValuePair in dictionary)
			{
				if (!self.ContainsKey(keyValuePair.Key))
				{
					self[keyValuePair.Key] = keyValuePair.Value;
				}
			}
			return self;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000401C File Offset: 0x0000221C
		public static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(this TDictionary self, [NotNull] IDictionary<TKey, TValue> dictionary) where TDictionary : IDictionary<TKey, TValue>
		{
			foreach (KeyValuePair<TKey, TValue> keyValuePair in dictionary)
			{
				self[keyValuePair.Key] = keyValuePair.Value;
			}
			return self;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000407C File Offset: 0x0000227C
		public static bool ValueEquals<TKey, TValue>(this IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y)
		{
			return x.ValueEquals(y, EqualityComparer<TValue>.Default);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000408C File Offset: 0x0000228C
		public static bool ValueEquals<TKey, TValue, TComparer>(this IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y, TComparer valueComparer) where TComparer : IEqualityComparer<TValue>
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null || x.Count != y.Count)
			{
				return false;
			}
			foreach (KeyValuePair<TKey, TValue> keyValuePair in x)
			{
				TValue y2;
				if (!y.TryGetValue(keyValuePair.Key, out y2) || !valueComparer.Equals(keyValuePair.Value, y2))
				{
					return false;
				}
			}
			return true;
		}
	}
}
