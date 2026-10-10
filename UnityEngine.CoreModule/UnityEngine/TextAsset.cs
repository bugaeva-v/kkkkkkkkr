using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200021F RID: 543
	[NativeHeader("Runtime/Scripting/TextAsset.h")]
	public class TextAsset : Object
	{
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001781 RID: 6017
		public extern byte[] bytes { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001782 RID: 6018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern byte[] GetPreviewBytes(int maxByteCount);

		// Token: 0x06001783 RID: 6019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateInstance([Writable] TextAsset self, string text);

		// Token: 0x06001784 RID: 6020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr GetDataPtr();

		// Token: 0x06001785 RID: 6021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern long GetDataSize();

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x00025F8C File Offset: 0x0002418C
		public string text
		{
			get
			{
				return TextAsset.DecodeString(this.bytes);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x00025FA9 File Offset: 0x000241A9
		public long dataSize
		{
			get
			{
				return this.GetDataSize();
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00025FB4 File Offset: 0x000241B4
		public override string ToString()
		{
			return this.text;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00025FCC File Offset: 0x000241CC
		public TextAsset() : this(TextAsset.CreateOptions.CreateNativeObject, null)
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00025FD8 File Offset: 0x000241D8
		public TextAsset(string text) : this(TextAsset.CreateOptions.CreateNativeObject, text)
		{
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00025FE4 File Offset: 0x000241E4
		internal TextAsset(TextAsset.CreateOptions options, string text)
		{
			bool flag = options == TextAsset.CreateOptions.CreateNativeObject;
			if (flag)
			{
				TextAsset.Internal_CreateInstance(this, text);
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0002600C File Offset: 0x0002420C
		public unsafe NativeArray<T> GetData<T>() where T : struct
		{
			long dataSize = this.GetDataSize();
			long num = (long)UnsafeUtility.SizeOf<T>();
			bool flag = dataSize % num != 0L;
			if (flag)
			{
				throw new ArgumentException(string.Format("Type passed to {0} can't capture the asset data. Data size is {1} which is not a multiple of type size {2}", "GetData", dataSize, num));
			}
			long num2 = dataSize / num;
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)this.GetDataPtr(), (int)num2, Allocator.None);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00026078 File Offset: 0x00024278
		internal string GetPreview(int maxChars)
		{
			return TextAsset.DecodeString(this.GetPreviewBytes(maxChars * 4));
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00026098 File Offset: 0x00024298
		internal static string DecodeString(byte[] bytes)
		{
			int num = TextAsset.EncodingUtility.encodingLookup.Length;
			int i = 0;
			int num2;
			while (i < num)
			{
				byte[] key = TextAsset.EncodingUtility.encodingLookup[i].Key;
				num2 = key.Length;
				bool flag = bytes.Length >= num2;
				if (flag)
				{
					for (int j = 0; j < num2; j++)
					{
						bool flag2 = key[j] != bytes[j];
						if (flag2)
						{
							num2 = -1;
						}
					}
					bool flag3 = num2 < 0;
					if (!flag3)
					{
						try
						{
							Encoding value = TextAsset.EncodingUtility.encodingLookup[i].Value;
							return value.GetString(bytes, num2, bytes.Length - num2);
						}
						catch
						{
						}
					}
				}
				IL_A2:
				i++;
				continue;
				goto IL_A2;
			}
			num2 = 0;
			Encoding targetEncoding = TextAsset.EncodingUtility.targetEncoding;
			return targetEncoding.GetString(bytes, num2, bytes.Length - num2);
		}

		// Token: 0x02000220 RID: 544
		internal enum CreateOptions
		{
			// Token: 0x04000811 RID: 2065
			None,
			// Token: 0x04000812 RID: 2066
			CreateNativeObject
		}

		// Token: 0x02000221 RID: 545
		private static class EncodingUtility
		{
			// Token: 0x0600178F RID: 6031 RVA: 0x00026184 File Offset: 0x00024384
			static EncodingUtility()
			{
				Encoding encoding = new UTF32Encoding(true, true, true);
				Encoding encoding2 = new UTF32Encoding(false, true, true);
				Encoding encoding3 = new UnicodeEncoding(true, true, true);
				Encoding encoding4 = new UnicodeEncoding(false, true, true);
				Encoding encoding5 = new UTF8Encoding(true, true);
				TextAsset.EncodingUtility.encodingLookup = new KeyValuePair<byte[], Encoding>[]
				{
					new KeyValuePair<byte[], Encoding>(encoding.GetPreamble(), encoding),
					new KeyValuePair<byte[], Encoding>(encoding2.GetPreamble(), encoding2),
					new KeyValuePair<byte[], Encoding>(encoding3.GetPreamble(), encoding3),
					new KeyValuePair<byte[], Encoding>(encoding4.GetPreamble(), encoding4),
					new KeyValuePair<byte[], Encoding>(encoding5.GetPreamble(), encoding5)
				};
			}

			// Token: 0x04000813 RID: 2067
			internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup;

			// Token: 0x04000814 RID: 2068
			internal static readonly Encoding targetEncoding = Encoding.GetEncoding(Encoding.UTF8.CodePage, new EncoderReplacementFallback("�"), new DecoderReplacementFallback("�"));
		}
	}
}
