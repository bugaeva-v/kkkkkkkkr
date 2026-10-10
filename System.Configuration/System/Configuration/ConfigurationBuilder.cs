using System;
using System.Configuration.Provider;
using System.Xml;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет базовый класс, расширяемый пользовательскими реализациями построителя конфигурации.</summary>
	// Token: 0x0200008A RID: 138
	public abstract class ConfigurationBuilder : ProviderBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationBuilder" />.</summary>
		// Token: 0x0600048D RID: 1165 RVA: 0x00003518 File Offset: 0x00001718
		protected ConfigurationBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Принимает объект <see cref="T:System.Configuration.ConfigurationSection" /> из системы конфигурации и возвращает измененный или новый объект <see cref="T:System.Configuration.ConfigurationSection" /> для дальнейшего использования.</summary>
		/// <param name="configSection">Сообщение <see cref="T:System.Configuration.ConfigurationSection" /> для обработки.</param>
		/// <returns>Обработанный <see cref="T:System.Configuration.ConfigurationSection" />.</returns>
		// Token: 0x0600048E RID: 1166 RVA: 0x00003527 File Offset: 0x00001727
		public virtual ConfigurationSection ProcessConfigurationSection(ConfigurationSection configSection)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Принимает <see cref="T:System.Xml.XmlNode" />, представляющий необработанный раздел конфигурации из файла конфигурации, и возвращает измененный или новый <see cref="T:System.Xml.XmlNode" /> для дальнейшего использования.</summary>
		/// <param name="rawXml">Сообщение <see cref="T:System.Xml.XmlNode" /> для обработки.</param>
		/// <returns>Обработанный <see cref="T:System.Xml.XmlNode" />.</returns>
		// Token: 0x0600048F RID: 1167 RVA: 0x00003527 File Offset: 0x00001727
		public virtual XmlNode ProcessRawXml(XmlNode rawXml)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
