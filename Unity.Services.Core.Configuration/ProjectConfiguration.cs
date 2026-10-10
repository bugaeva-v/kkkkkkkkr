using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Internal.Serialization;

namespace Unity.Services.Core.Configuration
{
	// Token: 0x02000009 RID: 9
	internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002228 File Offset: 0x00000428
		internal IJsonSerializer Serializer { get; }

		// Token: 0x0600001B RID: 27 RVA: 0x00002230 File Offset: 0x00000430
		public ProjectConfiguration(IReadOnlyDictionary<string, ConfigurationEntry> configValues, IJsonSerializer serializer)
		{
			this.m_ConfigValues = configValues;
			this.Serializer = serializer;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002248 File Offset: 0x00000448
		public bool GetBool(string key, bool defaultValue = false)
		{
			bool result;
			if (!bool.TryParse(this.GetString(key, null), out result))
			{
				return defaultValue;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000226C File Offset: 0x0000046C
		public int GetInt(string key, int defaultValue = 0)
		{
			int result;
			if (!int.TryParse(this.GetString(key, null), out result))
			{
				return defaultValue;
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002290 File Offset: 0x00000490
		public float GetFloat(string key, float defaultValue = 0f)
		{
			float result;
			if (!float.TryParse(this.GetString(key, null), NumberStyles.Float, CultureInfo.InvariantCulture, out result))
			{
				return defaultValue;
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000022BC File Offset: 0x000004BC
		public string GetString(string key, string defaultValue = null)
		{
			ConfigurationEntry configurationEntry;
			if (!this.m_ConfigValues.TryGetValue(key, out configurationEntry))
			{
				return defaultValue;
			}
			return configurationEntry.Value;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000022E4 File Offset: 0x000004E4
		public string ToJson()
		{
			if (this.m_JsonCache == null)
			{
				Dictionary<string, string> value = this.m_ConfigValues.ToDictionary((KeyValuePair<string, ConfigurationEntry> pair) => pair.Key, (KeyValuePair<string, ConfigurationEntry> pair) => pair.Value.Value);
				this.m_JsonCache = this.Serializer.SerializeObject<Dictionary<string, string>>(value);
			}
			return this.m_JsonCache;
		}

		// Token: 0x04000006 RID: 6
		private string m_JsonCache;

		// Token: 0x04000007 RID: 7
		private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues;
	}
}
