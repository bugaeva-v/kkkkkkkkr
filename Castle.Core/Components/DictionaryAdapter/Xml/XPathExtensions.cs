using System;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000184 RID: 388
	public static class XPathExtensions
	{
		// Token: 0x06000C16 RID: 3094 RVA: 0x0001D343 File Offset: 0x0001B543
		public static XPathNavigator CreateNavigatorSafe(this IXPathNavigable source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.CreateNavigator();
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0001D359 File Offset: 0x0001B559
		public static bool MoveToLastChild(this XPathNavigator navigator)
		{
			if (!navigator.MoveToFirstChild())
			{
				return false;
			}
			while (navigator.MoveToNext())
			{
			}
			return true;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0001D36E File Offset: 0x0001B56E
		public static bool MoveToLastAttribute(this XPathNavigator navigator)
		{
			if (!navigator.MoveToFirstAttribute())
			{
				return false;
			}
			while (navigator.MoveToNextAttribute())
			{
			}
			return true;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0001D383 File Offset: 0x0001B583
		public static XPathNavigator GetRootElement(this XPathNavigator navigator)
		{
			navigator = navigator.Clone();
			navigator.MoveToRoot();
			if (navigator.NodeType == XPathNodeType.Root && !navigator.MoveToFirstChild())
			{
				throw Error.InvalidOperation();
			}
			return navigator;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0001D3AA File Offset: 0x0001B5AA
		public static XPathNavigator GetParent(this XPathNavigator navigator)
		{
			navigator = navigator.Clone();
			if (!navigator.MoveToParent())
			{
				throw Error.InvalidOperation();
			}
			return navigator;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0001D3C3 File Offset: 0x0001B5C3
		public static void DeleteChildren(this XPathNavigator node)
		{
			while (node.MoveToFirstChild())
			{
				node.DeleteSelf();
			}
			while (node.MoveToFirstAttribute())
			{
				node.DeleteSelf();
			}
		}
	}
}
