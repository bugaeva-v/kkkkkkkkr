using System;
using System.Collections.Generic;

namespace Firebase
{
	// Token: 0x02000008 RID: 8
	internal static class VariantExtension
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002570 File Offset: 0x00000770
		public static object ToObject(this Variant variant)
		{
			return variant.ToObject(VariantExtension.KeyOptions.UseObjectKeys);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000258C File Offset: 0x0000078C
		public static object ToObject(this Variant variant, VariantExtension.KeyOptions options)
		{
			object result = variant.ToObjectInternal(options);
			GC.KeepAlive(variant);
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000025B0 File Offset: 0x000007B0
		private static object ToObjectInternal(this Variant variant, VariantExtension.KeyOptions options)
		{
			switch (variant.type())
			{
			case Variant.Type.Int64:
				return variant.int64_value();
			case Variant.Type.Double:
				return variant.double_value();
			case Variant.Type.Bool:
				return variant.bool_value();
			case Variant.Type.StaticString:
			case Variant.Type.MutableString:
				return variant.string_value();
			case Variant.Type.Vector:
			{
				List<object> list = new List<object>();
				foreach (Variant variant2 in variant.vector())
				{
					list.Add(variant2.ToObjectInternal(options));
				}
				return list;
			}
			case Variant.Type.Map:
			{
				bool flag = options == VariantExtension.KeyOptions.UseStringKeys;
				if (flag)
				{
					return variant.map().ToStringVariantMap(options);
				}
				Dictionary<object, object> dictionary = new Dictionary<object, object>();
				foreach (KeyValuePair<Variant, Variant> keyValuePair in variant.map())
				{
					object key = keyValuePair.Key.ToObjectInternal(options);
					object value = keyValuePair.Value.ToObjectInternal(options);
					dictionary[key] = value;
				}
				return dictionary;
			}
			case Variant.Type.StaticBlob:
			case Variant.Type.MutableBlob:
				return variant.blob_as_bytes();
			}
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002738 File Offset: 0x00000938
		public static IDictionary<string, object> ToStringVariantMap(this VariantVariantMap originalMap)
		{
			return originalMap.ToStringVariantMap(VariantExtension.KeyOptions.UseObjectKeys);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002754 File Offset: 0x00000954
		public static IDictionary<string, object> ToStringVariantMap(this VariantVariantMap originalMap, VariantExtension.KeyOptions options)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			foreach (KeyValuePair<Variant, Variant> keyValuePair in originalMap)
			{
				bool flag = keyValuePair.Key.is_string();
				string key;
				if (flag)
				{
					key = keyValuePair.Key.string_value();
				}
				else
				{
					bool flag2 = keyValuePair.Key.is_fundamental_type();
					if (!flag2)
					{
						throw new InvalidCastException("Unable to convert dictionary keys to string");
					}
					key = keyValuePair.Key.AsString().string_value();
				}
				object value = keyValuePair.Value.ToObject(options);
				dictionary[key] = value;
			}
			return dictionary;
		}

		// Token: 0x0400001C RID: 28
		private const VariantExtension.KeyOptions DefaultKeyOptions = VariantExtension.KeyOptions.UseObjectKeys;

		// Token: 0x02000021 RID: 33
		internal enum KeyOptions
		{
			// Token: 0x0400006C RID: 108
			UseObjectKeys,
			// Token: 0x0400006D RID: 109
			UseStringKeys
		}
	}
}
