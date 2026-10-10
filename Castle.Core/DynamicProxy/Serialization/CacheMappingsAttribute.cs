using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy.Serialization
{
	// Token: 0x02000024 RID: 36
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	[CLSCompliant(false)]
	public class CacheMappingsAttribute : Attribute
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00004F74 File Offset: 0x00003174
		public CacheMappingsAttribute(byte[] serializedCacheMappings)
		{
			this.serializedCacheMappings = serializedCacheMappings;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00004F83 File Offset: 0x00003183
		public byte[] SerializedCacheMappings
		{
			get
			{
				return this.serializedCacheMappings;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004F8C File Offset: 0x0000318C
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dictionary<CacheKey, string> GetDeserializedMappings()
		{
			Dictionary<CacheKey, string> result;
			using (MemoryStream memoryStream = new MemoryStream(this.SerializedCacheMappings))
			{
				result = (Dictionary<CacheKey, string>)new BinaryFormatter().Deserialize(memoryStream);
			}
			return result;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004FD4 File Offset: 0x000031D4
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ApplyTo(AssemblyBuilder assemblyBuilder, Dictionary<CacheKey, string> mappings)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new BinaryFormatter().Serialize(memoryStream, mappings);
				byte[] array = memoryStream.ToArray();
				CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(CacheMappingsAttribute.constructor, new object[]
				{
					array
				});
				assemblyBuilder.SetCustomAttribute(customAttribute);
			}
		}

		// Token: 0x04000053 RID: 83
		private static readonly ConstructorInfo constructor = typeof(CacheMappingsAttribute).GetConstructor(new Type[]
		{
			typeof(byte[])
		});

		// Token: 0x04000054 RID: 84
		private readonly byte[] serializedCacheMappings;
	}
}
