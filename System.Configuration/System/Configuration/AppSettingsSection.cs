using System;
using System.ComponentModel;
using System.IO;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Обеспечивает поддержку системы конфигурации для раздела конфигурации <see langword="appSettings" />. Этот класс не наследуется.</summary>
	// Token: 0x0200000B RID: 11
	public sealed class AppSettingsSection : ConfigurationSection
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000020D0 File Offset: 0x000002D0
		static AppSettingsSection()
		{
			AppSettingsSection._properties = new ConfigurationPropertyCollection();
			AppSettingsSection._properties.Add(AppSettingsSection._propFile);
			AppSettingsSection._properties.Add(AppSettingsSection._propSettings);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000214F File Offset: 0x0000034F
		protected internal override bool IsModified()
		{
			return this.Settings.IsModified();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000215C File Offset: 0x0000035C
		[MonoInternalNote("file path?  do we use a System.Configuration api for opening it?  do we keep it open?  do we open it writable?")]
		protected internal override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			base.DeserializeElement(reader, serializeCollectionKey);
			if (this.File != "")
			{
				try
				{
					string text = this.File;
					if (!Path.IsPathRooted(text))
					{
						text = Path.Combine(Path.GetDirectoryName(base.Configuration.FilePath), text);
					}
					FileStream fileStream = System.IO.File.OpenRead(text);
					XmlReader reader2 = new ConfigXmlTextReader(fileStream, text);
					base.DeserializeElement(reader2, serializeCollectionKey);
					fileStream.Close();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021DC File Offset: 0x000003DC
		protected internal override void Reset(ConfigurationElement parentSection)
		{
			AppSettingsSection appSettingsSection = parentSection as AppSettingsSection;
			if (appSettingsSection != null)
			{
				this.Settings.Reset(appSettingsSection.Settings);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002204 File Offset: 0x00000404
		[MonoTODO]
		protected internal override string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
		{
			if (this.File == "")
			{
				return base.SerializeSection(parentElement, name, saveMode);
			}
			throw new NotImplementedException();
		}

		/// <summary>Возвращает или задает файл конфигурации, предоставляющий дополнительные параметры или переопределяющий параметры, указанные в элементе <see langword="appSettings" />.</summary>
		/// <returns>Файл конфигурации, предоставляющий дополнительные параметры или переопределяющий параметры, указанные в элементе <see langword="appSettings" />.</returns>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002227 File Offset: 0x00000427
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002239 File Offset: 0x00000439
		[ConfigurationProperty("file", DefaultValue = "")]
		public string File
		{
			get
			{
				return (string)base[AppSettingsSection._propFile];
			}
			set
			{
				base[AppSettingsSection._propFile] = value;
			}
		}

		/// <summary>Возвращает коллекцию пар "ключ-значение", содержащую параметры приложения.</summary>
		/// <returns>Коллекция пар ключ/значение, которая содержит параметры приложения из файла конфигурации.</returns>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002247 File Offset: 0x00000447
		[ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public KeyValueConfigurationCollection Settings
		{
			get
			{
				return (KeyValueConfigurationCollection)base[AppSettingsSection._propSettings];
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002259 File Offset: 0x00000459
		protected internal override ConfigurationPropertyCollection Properties
		{
			get
			{
				return AppSettingsSection._properties;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002260 File Offset: 0x00000460
		protected internal override object GetRuntimeObject()
		{
			KeyValueInternalCollection keyValueInternalCollection = new KeyValueInternalCollection();
			foreach (string key in this.Settings.AllKeys)
			{
				KeyValueConfigurationElement keyValueConfigurationElement = this.Settings[key];
				keyValueInternalCollection.Add(keyValueConfigurationElement.Key, keyValueConfigurationElement.Value);
			}
			if (!ConfigurationManager.ConfigurationSystem.SupportsUserConfig)
			{
				keyValueInternalCollection.SetReadOnly();
			}
			return keyValueInternalCollection;
		}

		// Token: 0x0400002C RID: 44
		private static ConfigurationPropertyCollection _properties;

		// Token: 0x0400002D RID: 45
		private static readonly ConfigurationProperty _propFile = new ConfigurationProperty("file", typeof(string), "", new StringConverter(), null, ConfigurationPropertyOptions.None);

		// Token: 0x0400002E RID: 46
		private static readonly ConfigurationProperty _propSettings = new ConfigurationProperty("", typeof(KeyValueConfigurationCollection), null, null, null, ConfigurationPropertyOptions.IsDefaultCollection);
	}
}
