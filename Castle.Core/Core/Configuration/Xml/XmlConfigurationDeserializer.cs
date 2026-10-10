using System;
using System.Text;
using System.Xml;

namespace Castle.Core.Configuration.Xml
{
	// Token: 0x020000F6 RID: 246
	public class XmlConfigurationDeserializer
	{
		// Token: 0x06000689 RID: 1673 RVA: 0x00012B82 File Offset: 0x00010D82
		public IConfiguration Deserialize(XmlNode node)
		{
			return XmlConfigurationDeserializer.GetDeserializedNode(node);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00012B8A File Offset: 0x00010D8A
		public static string GetConfigValue(string value)
		{
			if (value == string.Empty)
			{
				return null;
			}
			return value;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00012B9C File Offset: 0x00010D9C
		public static IConfiguration GetDeserializedNode(XmlNode node)
		{
			ConfigurationCollection configurationCollection = new ConfigurationCollection();
			StringBuilder stringBuilder = new StringBuilder();
			if (node.HasChildNodes)
			{
				foreach (object obj in node.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (XmlConfigurationDeserializer.IsTextNode(xmlNode))
					{
						stringBuilder.Append(xmlNode.Value);
					}
					else if (xmlNode.NodeType == XmlNodeType.Element)
					{
						configurationCollection.Add(XmlConfigurationDeserializer.GetDeserializedNode(xmlNode));
					}
				}
			}
			MutableConfiguration mutableConfiguration = new MutableConfiguration(node.Name, XmlConfigurationDeserializer.GetConfigValue(stringBuilder.ToString()));
			foreach (object obj2 in node.Attributes)
			{
				XmlAttribute xmlAttribute = (XmlAttribute)obj2;
				mutableConfiguration.Attributes.Add(xmlAttribute.Name, xmlAttribute.Value);
			}
			mutableConfiguration.Children.AddRange(configurationCollection);
			return mutableConfiguration;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00012CB8 File Offset: 0x00010EB8
		public static bool IsTextNode(XmlNode node)
		{
			return node.NodeType == XmlNodeType.Text || node.NodeType == XmlNodeType.CDATA;
		}
	}
}
