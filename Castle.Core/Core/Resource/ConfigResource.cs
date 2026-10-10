using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace Castle.Core.Resource
{
	// Token: 0x020000BD RID: 189
	public class ConfigResource : AbstractResource
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x000103E7 File Offset: 0x0000E5E7
		public ConfigResource() : this("castle")
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000103F4 File Offset: 0x0000E5F4
		public ConfigResource(CustomUri uri) : this(uri.Host)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00010404 File Offset: 0x0000E604
		public ConfigResource(string sectionName)
		{
			this.sectionName = sectionName;
			XmlNode xmlNode = (XmlNode)ConfigurationManager.GetSection(sectionName);
			if (xmlNode == null)
			{
				throw new ConfigurationErrorsException(string.Format(CultureInfo.InvariantCulture, "Could not find section '{0}' in the configuration file associated with this domain.", new object[]
				{
					sectionName
				}));
			}
			this.configSectionNode = xmlNode;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00010453 File Offset: 0x0000E653
		public override TextReader GetStreamReader()
		{
			return new StringReader(this.configSectionNode.OuterXml);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00010465 File Offset: 0x0000E665
		public override TextReader GetStreamReader(Encoding encoding)
		{
			throw new NotSupportedException("Encoding is not supported");
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00010471 File Offset: 0x0000E671
		public override IResource CreateRelative(string relativePath)
		{
			return new ConfigResource(relativePath);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00010479 File Offset: 0x0000E679
		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "ConfigResource: [{0}]", new object[]
			{
				this.sectionName
			});
		}

		// Token: 0x0400014B RID: 331
		private readonly XmlNode configSectionNode;

		// Token: 0x0400014C RID: 332
		private readonly string sectionName;
	}
}
