using System;
using System.IO;
using System.Runtime.Versioning;
using System.Xml;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет раздел в файле конфигурации.</summary>
	// Token: 0x02000030 RID: 48
	public abstract class ConfigurationSection : ConfigurationElement
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000067C3 File Offset: 0x000049C3
		internal string ExternalDataXml
		{
			get
			{
				return this.externalDataXml;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000067CB File Offset: 0x000049CB
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000067D3 File Offset: 0x000049D3
		internal IConfigurationSectionHandler SectionHandler
		{
			get
			{
				return this.section_handler;
			}
			set
			{
				this.section_handler = value;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.SectionInformation" />, содержащий неизменяемую информацию и функциональность объекта <see cref="T:System.Configuration.ConfigurationSection" />.</summary>
		/// <returns>
		///   <see cref="T:System.Configuration.SectionInformation" />, содержащий неизменяемую информацию и функциональность объекта <see cref="T:System.Configuration.ConfigurationSection" />.</returns>
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000067DC File Offset: 0x000049DC
		[MonoTODO]
		public SectionInformation SectionInformation
		{
			get
			{
				if (this.sectionInformation == null)
				{
					this.sectionInformation = new SectionInformation();
				}
				return this.sectionInformation;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000067F7 File Offset: 0x000049F7
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000067FF File Offset: 0x000049FF
		internal object ConfigContext
		{
			get
			{
				return this._configContext;
			}
			set
			{
				this._configContext = value;
			}
		}

		/// <summary>Возвращает пользовательский объект при переопределении в производном классе.</summary>
		/// <returns>Объект, представляющий раздел.</returns>
		// Token: 0x060001AA RID: 426 RVA: 0x00006808 File Offset: 0x00004A08
		[MonoTODO("Provide ConfigContext. Likely the culprit of bug #322493")]
		protected internal virtual object GetRuntimeObject()
		{
			if (this.SectionHandler == null)
			{
				return this;
			}
			ConfigurationSection configurationSection = (this.sectionInformation != null) ? this.sectionInformation.GetParentSection() : null;
			object obj = (configurationSection != null) ? configurationSection.GetRuntimeObject() : null;
			if (base.RawXml == null)
			{
				return obj;
			}
			try
			{
				XmlReader reader = new ConfigXmlTextReader(new StringReader(base.RawXml), base.Configuration.FilePath);
				this.DoDeserializeSection(reader);
				if (!string.IsNullOrEmpty(this.SectionInformation.ConfigSource))
				{
					string text = this.SectionInformation.ConfigFilePath;
					if (!string.IsNullOrEmpty(text))
					{
						text = Path.GetDirectoryName(text);
					}
					else
					{
						text = string.Empty;
					}
					string path = Path.Combine(text, this.SectionInformation.ConfigSource);
					if (File.Exists(path))
					{
						base.RawXml = File.ReadAllText(path);
						this.SectionInformation.SetRawXml(base.RawXml);
					}
				}
			}
			catch
			{
			}
			XmlDocument xmlDocument = new ConfigurationXmlDocument();
			xmlDocument.LoadXml(base.RawXml);
			return this.SectionHandler.Create(obj, this.ConfigContext, xmlDocument.DocumentElement);
		}

		/// <summary>При реализации в производном классе указывает, был ли изменен данный элемент конфигурации с момента последнего сохранения или загрузки.</summary>
		/// <returns>Значение <see langword="true" />, если элемент был изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001AB RID: 427 RVA: 0x00006928 File Offset: 0x00004B28
		[MonoTODO]
		protected internal override bool IsModified()
		{
			return base.IsModified();
		}

		/// <summary>Переустанавливает значение метода <see cref="M:System.Configuration.ConfigurationElement.IsModified" /> в <see langword="false" /> при реализации в производном классе.</summary>
		// Token: 0x060001AC RID: 428 RVA: 0x00006930 File Offset: 0x00004B30
		[MonoTODO]
		protected internal override void ResetModified()
		{
			base.ResetModified();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00006938 File Offset: 0x00004B38
		private ConfigurationElement CreateElement(Type t)
		{
			ConfigurationElement configurationElement = (ConfigurationElement)Activator.CreateInstance(t);
			configurationElement.Init();
			configurationElement.Configuration = base.Configuration;
			if (this.IsReadOnly())
			{
				configurationElement.SetReadOnly();
			}
			return configurationElement;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00006974 File Offset: 0x00004B74
		private void DoDeserializeSection(XmlReader reader)
		{
			reader.MoveToContent();
			string text = null;
			string text2 = null;
			while (reader.MoveToNextAttribute())
			{
				string localName = reader.LocalName;
				if (localName == "configProtectionProvider")
				{
					text = reader.Value;
				}
				else if (localName == "configSource")
				{
					text2 = reader.Value;
				}
			}
			if (text != null)
			{
				ProtectedConfigurationProvider provider = ProtectedConfiguration.GetProvider(text, true);
				XmlDocument xmlDocument = new ConfigurationXmlDocument();
				reader.MoveToElement();
				xmlDocument.Load(new StringReader(reader.ReadInnerXml()));
				reader = new XmlNodeReader(provider.Decrypt(xmlDocument));
				this.SectionInformation.ProtectSection(text);
				reader.MoveToContent();
			}
			if (text2 != null)
			{
				this.SectionInformation.ConfigSource = text2;
			}
			this.SectionInformation.SetRawXml(base.RawXml);
			if (this.SectionHandler == null)
			{
				this.DeserializeElement(reader, false);
			}
		}

		/// <summary>Считывает XML из файла конфигурации.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />, считывающий данные из файла конфигурации.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">
		///   <paramref name="reader" /> не обнаружил ни одного элемента в файле конфигурации.</exception>
		// Token: 0x060001AF RID: 431 RVA: 0x00006A40 File Offset: 0x00004C40
		[MonoInternalNote("find the proper location for the decryption stuff")]
		protected internal virtual void DeserializeSection(XmlReader reader)
		{
			try
			{
				this.DoDeserializeSection(reader);
			}
			catch (ConfigurationErrorsException ex)
			{
				throw new ConfigurationErrorsException(string.Format("Error deserializing configuration section {0}: {1}", this.SectionInformation.Name, ex.Message));
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00006A88 File Offset: 0x00004C88
		internal void DeserializeConfigSource(string basePath)
		{
			string configSource = this.SectionInformation.ConfigSource;
			if (string.IsNullOrEmpty(configSource))
			{
				return;
			}
			if (Path.IsPathRooted(configSource))
			{
				throw new ConfigurationErrorsException("The configSource attribute must be a relative physical path.");
			}
			if (this.HasLocalModifications())
			{
				throw new ConfigurationErrorsException("A section using 'configSource' may contain no other attributes or elements.");
			}
			string text = Path.Combine(basePath, configSource);
			if (!File.Exists(text))
			{
				base.RawXml = null;
				this.SectionInformation.SetRawXml(null);
				throw new ConfigurationErrorsException(string.Format("Unable to open configSource file '{0}'.", text));
			}
			base.RawXml = File.ReadAllText(text);
			this.SectionInformation.SetRawXml(base.RawXml);
			this.DeserializeElement(new ConfigXmlTextReader(new StringReader(base.RawXml), text), false);
		}

		/// <summary>Создает XML-строку, содержащую разъединенное представление об объекте <see cref="T:System.Configuration.ConfigurationSection" />, как об отдельном разделе, записываемым в файл.</summary>
		/// <param name="parentElement">Экземпляр <see cref="T:System.Configuration.ConfigurationElement" />, используемый как родительский при выполнении операции разъединения.</param>
		/// <param name="name">Имя создаваемого раздела.</param>
		/// <param name="saveMode">Экземпляр <see cref="T:System.Configuration.ConfigurationSaveMode" />, используемый при записи в строку.</param>
		/// <returns>XML-строка, содержащая разъединенное представление объекта <see cref="T:System.Configuration.ConfigurationSection" />.</returns>
		// Token: 0x060001B1 RID: 433 RVA: 0x00006B3C File Offset: 0x00004D3C
		protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
		{
			this.externalDataXml = null;
			ConfigurationElement configurationElement;
			if (parentElement != null)
			{
				configurationElement = this.CreateElement(base.GetType());
				configurationElement.Unmerge(this, parentElement, saveMode);
			}
			else
			{
				configurationElement = this;
			}
			configurationElement.PrepareSave(parentElement, saveMode);
			bool flag = configurationElement.HasValues(parentElement, saveMode);
			string result;
			using (StringWriter stringWriter = new StringWriter())
			{
				using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
				{
					xmlTextWriter.Formatting = Formatting.Indented;
					if (flag)
					{
						configurationElement.SerializeToXmlElement(xmlTextWriter, name);
					}
					else if (saveMode == ConfigurationSaveMode.Modified && configurationElement.IsModified())
					{
						xmlTextWriter.WriteStartElement(name);
						xmlTextWriter.WriteEndElement();
					}
					xmlTextWriter.Close();
				}
				result = stringWriter.ToString();
			}
			string configSource = this.SectionInformation.ConfigSource;
			if (string.IsNullOrEmpty(configSource))
			{
				return result;
			}
			this.externalDataXml = result;
			string result2;
			using (StringWriter stringWriter2 = new StringWriter())
			{
				bool flag2 = !string.IsNullOrEmpty(name);
				using (XmlTextWriter xmlTextWriter2 = new XmlTextWriter(stringWriter2))
				{
					if (flag2)
					{
						xmlTextWriter2.WriteStartElement(name);
					}
					xmlTextWriter2.WriteAttributeString("configSource", configSource);
					if (flag2)
					{
						xmlTextWriter2.WriteEndElement();
					}
				}
				result2 = stringWriter2.ToString();
			}
			return result2;
		}

		/// <summary>Указывает, нужно ли выполнять сериализацию указанного элемента во время сериализации иерархии объекта конфигурации для заданной целевой версии .NET Framework.</summary>
		/// <param name="element">Объект <see cref="T:System.Configuration.ConfigurationElement" />, для которого рассматривается возможность сериализации.</param>
		/// <param name="elementName">Имя объекта <see cref="T:System.Configuration.ConfigurationElement" /> в формате XML.</param>
		/// <param name="targetFramework">Целевая версия .NET Framework.</param>
		/// <returns>Значение <see langword="true" />, если свойство <paramref name="element" /> должно быть сериализовано; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001B2 RID: 434 RVA: 0x00006CA4 File Offset: 0x00004EA4
		protected internal virtual bool ShouldSerializeElementInTargetVersion(ConfigurationElement element, string elementName, FrameworkName targetFramework)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>Указывает, нужно ли выполнять сериализацию указанного свойства во время сериализации иерархии объекта конфигурации для заданной целевой версии .NET Framework.</summary>
		/// <param name="property">Объект <see cref="T:System.Configuration.ConfigurationProperty" />, для которого рассматривается возможность сериализации.</param>
		/// <param name="propertyName">Имя объекта <see cref="T:System.Configuration.ConfigurationProperty" /> в формате XML.</param>
		/// <param name="targetFramework">Целевая версия .NET Framework.</param>
		/// <param name="parentConfigurationElement">Родительский элемент свойства.</param>
		/// <returns>Значение <see langword="true" />, если свойство <paramref name="property" /> должно быть сериализовано; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001B3 RID: 435 RVA: 0x00006CC0 File Offset: 0x00004EC0
		protected internal virtual bool ShouldSerializePropertyInTargetVersion(ConfigurationProperty property, string propertyName, FrameworkName targetFramework, ConfigurationElement parentConfigurationElement)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>Указывает, нужно ли выполнять сериализацию текущего экземпляра <see cref="T:System.Configuration.ConfigurationSection" /> во время сериализации иерархии объекта конфигурации для заданной целевой версии .NET Framework.</summary>
		/// <param name="targetFramework">Целевая версия .NET Framework.</param>
		/// <returns>Значение <see langword="true" />, если текущий раздел должен быть сериализован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001B4 RID: 436 RVA: 0x00006CDC File Offset: 0x00004EDC
		protected internal virtual bool ShouldSerializeSectionInTargetVersion(FrameworkName targetFramework)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		// Token: 0x040000BC RID: 188
		private SectionInformation sectionInformation;

		// Token: 0x040000BD RID: 189
		private IConfigurationSectionHandler section_handler;

		// Token: 0x040000BE RID: 190
		private string externalDataXml;

		// Token: 0x040000BF RID: 191
		private object _configContext;
	}
}
