using System;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Unity.Services.Core.Internal.Serialization
{
	// Token: 0x02000059 RID: 89
	internal class NewtonsoftSerializer : IJsonSerializer
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00004169 File Offset: 0x00002369
		public NewtonsoftSerializer(JsonSerializerSettings settings = null) : this(JsonSerializer.Create(settings))
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004177 File Offset: 0x00002377
		internal NewtonsoftSerializer(JsonSerializer serializer)
		{
			this.m_Serializer = serializer;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00004188 File Offset: 0x00002388
		public string SerializeObject<T>(T value)
		{
			string result;
			using (StringWriter stringWriter = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture))
			{
				using (JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter))
				{
					jsonTextWriter.Formatting = this.m_Serializer.Formatting;
					this.m_Serializer.Serialize(jsonTextWriter, value, typeof(T));
					result = stringWriter.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004218 File Offset: 0x00002418
		public T DeserializeObject<T>(string value)
		{
			T result;
			using (JsonTextReader jsonTextReader = new JsonTextReader(new StringReader(value)))
			{
				result = (T)((object)this.m_Serializer.Deserialize(jsonTextReader, typeof(T)));
			}
			return result;
		}

		// Token: 0x04000079 RID: 121
		private readonly JsonSerializer m_Serializer;
	}
}
