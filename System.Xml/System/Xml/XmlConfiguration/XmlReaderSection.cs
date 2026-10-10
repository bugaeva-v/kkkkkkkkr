using System;
using System.ComponentModel;
using System.Configuration;

namespace System.Xml.XmlConfiguration
{
	/// <summary>
	///         Представляет раздел средства чтения XML.
	///       </summary>
	// Token: 0x02000324 RID: 804
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class XmlReaderSection : ConfigurationSection
	{
		/// <summary>
		///         Возвращает или задает строку, представляющую распознаватель по умолчанию запретить.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.String" /> представляющий распознаватель по умолчанию запретить.
		///       </returns>
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x000D2502 File Offset: 0x000D0702
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x000D2514 File Offset: 0x000D0714
		[ConfigurationProperty("prohibitDefaultResolver", DefaultValue = "false")]
		public string ProhibitDefaultResolverString
		{
			get
			{
				return (string)base["prohibitDefaultResolver"];
			}
			set
			{
				base["prohibitDefaultResolver"] = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x000D2524 File Offset: 0x000D0724
		private bool _ProhibitDefaultResolver
		{
			get
			{
				bool result;
				XmlConvert.TryToBoolean(this.ProhibitDefaultResolverString, out result);
				return result;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x000D2540 File Offset: 0x000D0740
		internal static bool ProhibitDefaultUrlResolver
		{
			get
			{
				XmlReaderSection xmlReaderSection = ConfigurationManager.GetSection(XmlConfigurationString.XmlReaderSectionPath) as XmlReaderSection;
				return xmlReaderSection != null && xmlReaderSection._ProhibitDefaultResolver;
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000D2568 File Offset: 0x000D0768
		internal static XmlResolver CreateDefaultResolver()
		{
			if (XmlReaderSection.ProhibitDefaultUrlResolver)
			{
				return null;
			}
			return new XmlUrlResolver();
		}

		/// <summary>
		///         Получает или задает строку, которая представляет логическое значение, определяющее, свернуты ли пробелы в пустые строки.
		///          Значение по умолчанию — "false".
		///       </summary>
		/// <returns>
		///         Строка, которая представляет логическое значение, определяющее, свернуты ли пробелы в пустые строки.
		///       </returns>
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x000D2578 File Offset: 0x000D0778
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x000D258A File Offset: 0x000D078A
		[ConfigurationProperty("CollapseWhiteSpaceIntoEmptyString", DefaultValue = "false")]
		public string CollapseWhiteSpaceIntoEmptyStringString
		{
			get
			{
				return (string)base["CollapseWhiteSpaceIntoEmptyString"];
			}
			set
			{
				base["CollapseWhiteSpaceIntoEmptyString"] = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x000D2598 File Offset: 0x000D0798
		private bool _CollapseWhiteSpaceIntoEmptyString
		{
			get
			{
				bool result;
				XmlConvert.TryToBoolean(this.CollapseWhiteSpaceIntoEmptyStringString, out result);
				return result;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x000D25B4 File Offset: 0x000D07B4
		internal static bool CollapseWhiteSpaceIntoEmptyString
		{
			get
			{
				XmlReaderSection xmlReaderSection = ConfigurationManager.GetSection(XmlConfigurationString.XmlReaderSectionPath) as XmlReaderSection;
				return xmlReaderSection != null && xmlReaderSection._CollapseWhiteSpaceIntoEmptyString;
			}
		}
	}
}
