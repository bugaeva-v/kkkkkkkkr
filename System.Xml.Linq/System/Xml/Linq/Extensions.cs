using System;
using System.Collections.Generic;

namespace System.Xml.Linq
{
	/// <summary>Содержит методы расширения LINQ to XML.</summary>
	// Token: 0x02000010 RID: 16
	public static class Extensions
	{
		/// <summary>Возвращает коллекцию атрибутов каждого элемента в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XAttribute" />, содержащий атрибуты каждого элемента в исходной коллекции.</returns>
		// Token: 0x06000074 RID: 116 RVA: 0x00003EEF File Offset: 0x000020EF
		public static IEnumerable<XAttribute> Attributes(this IEnumerable<XElement> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.GetAttributes(source, null);
		}

		/// <summary>Возвращает отфильтрованную коллекцию атрибутов каждого элемента в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" /> для соответствия.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XAttribute" />, содержащий отфильтрованную коллекцию атрибутов каждого элемента в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x06000075 RID: 117 RVA: 0x00003F06 File Offset: 0x00002106
		public static IEnumerable<XAttribute> Attributes(this IEnumerable<XElement> source, XName name)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (!(name != null))
			{
				return XAttribute.EmptySequence;
			}
			return Extensions.GetAttributes(source, name);
		}

		/// <summary>Возвращает коллекцию элементов, содержащую предков каждого узла в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XNode" />, содержащий исходную коллекцию.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XNode" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащий предков каждого узла в исходной коллекции.</returns>
		// Token: 0x06000076 RID: 118 RVA: 0x00003F2C File Offset: 0x0000212C
		public static IEnumerable<XElement> Ancestors<T>(this IEnumerable<T> source) where T : XNode
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.GetAncestors<T>(source, null, false);
		}

		/// <summary>Возвращает отфильтрованную коллекцию элементов, содержащую предков каждого узла в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XNode" />, содержащий исходную коллекцию.</param>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" /> для соответствия.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XNode" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащий предков каждого узла в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x06000077 RID: 119 RVA: 0x00003F44 File Offset: 0x00002144
		public static IEnumerable<XElement> Ancestors<T>(this IEnumerable<T> source, XName name) where T : XNode
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (!(name != null))
			{
				return XElement.EmptySequence;
			}
			return Extensions.GetAncestors<T>(source, name, false);
		}

		/// <summary>Возвращает коллекцию элементов, которые содержат каждый элемент в исходной коллекции и предков каждого элемента в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащий каждый элемент в исходной коллекции и предков каждого элемента в исходной коллекции.</returns>
		// Token: 0x06000078 RID: 120 RVA: 0x00003F6B File Offset: 0x0000216B
		public static IEnumerable<XElement> AncestorsAndSelf(this IEnumerable<XElement> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.GetAncestors<XElement>(source, null, true);
		}

		/// <summary>Возвращает отфильтрованную коллекцию элементов, содержащую каждый элемент в исходной коллекции и предков каждого элемента в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" /> для соответствия.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащий каждый элемент в исходной коллекции и предков каждого элемента в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x06000079 RID: 121 RVA: 0x00003F83 File Offset: 0x00002183
		public static IEnumerable<XElement> AncestorsAndSelf(this IEnumerable<XElement> source, XName name)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (!(name != null))
			{
				return XElement.EmptySequence;
			}
			return Extensions.GetAncestors<XElement>(source, name, true);
		}

		/// <summary>Возвращает коллекцию дочерних узлов каждого документа и элемента в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XNode" />, содержащий исходную коллекцию.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XContainer" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XNode" /> дочерних узлов каждого документа и элемента в исходной коллекции.</returns>
		// Token: 0x0600007A RID: 122 RVA: 0x00003FAA File Offset: 0x000021AA
		public static IEnumerable<XNode> Nodes<T>(this IEnumerable<T> source) where T : XContainer
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.NodesIterator<T>(source);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003FC0 File Offset: 0x000021C0
		private static IEnumerable<XNode> NodesIterator<T>(IEnumerable<T> source) where T : XContainer
		{
			foreach (T t in source)
			{
				XContainer root = t;
				if (root != null)
				{
					XNode i = root.LastNode;
					if (i != null)
					{
						do
						{
							i = i.next;
							yield return i;
						}
						while (i.parent == root && i != root.content);
					}
					i = null;
				}
				root = null;
			}
			IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		/// <summary>Возвращает коллекцию подчиненных узлов каждого документа и элемента в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XContainer" />, содержащий исходную коллекцию.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XContainer" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XNode" /> подчиненных узлов каждого документа и элемента в исходной коллекции.</returns>
		// Token: 0x0600007C RID: 124 RVA: 0x00003FD0 File Offset: 0x000021D0
		public static IEnumerable<XNode> DescendantNodes<T>(this IEnumerable<T> source) where T : XContainer
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.GetDescendantNodes<T>(source, false);
		}

		/// <summary>Возвращает коллекцию элементов, содержащую подчиненные элементы каждого элемента и документа в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XContainer" />, содержащий исходную коллекцию.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XContainer" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащий подчиненные элементы каждого элемента и документа в исходной коллекции.</returns>
		// Token: 0x0600007D RID: 125 RVA: 0x00003FE7 File Offset: 0x000021E7
		public static IEnumerable<XElement> Descendants<T>(this IEnumerable<T> source) where T : XContainer
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.GetDescendants<T>(source, null, false);
		}

		/// <summary>Возвращает отфильтрованную коллекцию элементов, содержащую подчиненные элементы каждого элемента и документа в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XContainer" />, содержащий исходную коллекцию.</param>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" /> для соответствия.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XContainer" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащий подчиненные элементы каждого элемента и документа в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x0600007E RID: 126 RVA: 0x00003FFF File Offset: 0x000021FF
		public static IEnumerable<XElement> Descendants<T>(this IEnumerable<T> source, XName name) where T : XContainer
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (!(name != null))
			{
				return XElement.EmptySequence;
			}
			return Extensions.GetDescendants<T>(source, name, false);
		}

		/// <summary>Возвращает коллекцию узлов, содержащую каждый элемент в исходной коллекции и подчиненные узлы каждого элемента в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XNode" />, содержащий каждый элемент в исходной коллекции и подчиненные узлы каждого элемента в исходной коллекции.</returns>
		// Token: 0x0600007F RID: 127 RVA: 0x00004026 File Offset: 0x00002226
		public static IEnumerable<XNode> DescendantNodesAndSelf(this IEnumerable<XElement> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.GetDescendantNodes<XElement>(source, true);
		}

		/// <summary>Возвращает коллекцию элементов, содержащую каждый элемент в исходной коллекции и подчиненные элементы каждого элемента в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащий каждый элемент в исходной коллекции и подчиненные элементы каждого элемента в исходной коллекции.</returns>
		// Token: 0x06000080 RID: 128 RVA: 0x0000403D File Offset: 0x0000223D
		public static IEnumerable<XElement> DescendantsAndSelf(this IEnumerable<XElement> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.GetDescendants<XElement>(source, null, true);
		}

		/// <summary>Возвращает отфильтрованную коллекцию элементов, содержащую каждый элемент в исходной коллекции и подчиненные элементы каждого элемента в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" /> для соответствия.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащий каждый элемент в исходной коллекции и подчиненные элементы каждого элемента в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x06000081 RID: 129 RVA: 0x00004055 File Offset: 0x00002255
		public static IEnumerable<XElement> DescendantsAndSelf(this IEnumerable<XElement> source, XName name)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (!(name != null))
			{
				return XElement.EmptySequence;
			}
			return Extensions.GetDescendants<XElement>(source, name, true);
		}

		/// <summary>Возвращает коллекцию дочерних элементов каждого элемента и документа в исходной коллекции.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XContainer" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" /> дочерних элементов каждого элемента или документа в исходной коллекции.</returns>
		// Token: 0x06000082 RID: 130 RVA: 0x0000407C File Offset: 0x0000227C
		public static IEnumerable<XElement> Elements<T>(this IEnumerable<T> source) where T : XContainer
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.GetElements<T>(source, null);
		}

		/// <summary>Возвращает отфильтрованную коллекцию дочерних элементов каждого элемента и документа в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XElement" />, содержащий исходную коллекцию.</param>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" /> для соответствия.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XContainer" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" /> дочерних элементов каждого элемента и документа в исходной коллекции. В коллекцию включаются только элементы, соответствующие <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x06000083 RID: 131 RVA: 0x00004093 File Offset: 0x00002293
		public static IEnumerable<XElement> Elements<T>(this IEnumerable<T> source, XName name) where T : XContainer
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (!(name != null))
			{
				return XElement.EmptySequence;
			}
			return Extensions.GetElements<T>(source, name);
		}

		/// <summary>Возвращает коллекцию узлов, содержащую все узлы в исходной коллекции, отсортированные в порядке следования документов.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XNode" />, содержащий исходную коллекцию.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XNode" />.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XNode" />, содержащий все узлы в исходной коллекции, отсортированные в порядке следования документов.</returns>
		// Token: 0x06000084 RID: 132 RVA: 0x000040B9 File Offset: 0x000022B9
		public static IEnumerable<T> InDocumentOrder<T>(this IEnumerable<T> source) where T : XNode
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return Extensions.DocumentOrderIterator<T>(source);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000040CF File Offset: 0x000022CF
		private static IEnumerable<T> DocumentOrderIterator<T>(IEnumerable<T> source) where T : XNode
		{
			int count;
			T[] items = EnumerableHelpers.ToArray<T>(source, out count);
			if (count > 0)
			{
				XNode[] array = items;
				Array.Sort<XNode>(array, 0, count, XNode.DocumentOrderComparer);
				int num;
				for (int i = 0; i != count; i = num)
				{
					yield return items[i];
					num = i + 1;
				}
			}
			yield break;
		}

		/// <summary>Удаление каждого атрибута в исходной коллекции из родительского элемента.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XAttribute" />, содержащий исходную коллекцию.</param>
		// Token: 0x06000086 RID: 134 RVA: 0x000040E0 File Offset: 0x000022E0
		public static void Remove(this IEnumerable<XAttribute> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			int num;
			XAttribute[] array = EnumerableHelpers.ToArray<XAttribute>(source, out num);
			for (int i = 0; i < num; i++)
			{
				XAttribute xattribute = array[i];
				if (xattribute != null)
				{
					xattribute.Remove();
				}
			}
		}

		/// <summary>Удаление каждого узла в исходной коллекции из родительского узла.</summary>
		/// <param name="source">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> узла <see cref="T:System.Xml.Linq.XNode" />, содержащий исходную коллекцию.</param>
		/// <typeparam name="T">Тип объектов в <paramref name="source" />, ограниченный узлом <see cref="T:System.Xml.Linq.XNode" />.</typeparam>
		// Token: 0x06000087 RID: 135 RVA: 0x00004120 File Offset: 0x00002320
		public static void Remove<T>(this IEnumerable<T> source) where T : XNode
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			int num;
			T[] array = EnumerableHelpers.ToArray<T>(source, out num);
			for (int i = 0; i < num; i++)
			{
				T t = array[i];
				if (t != null)
				{
					t.Remove();
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000416B File Offset: 0x0000236B
		private static IEnumerable<XAttribute> GetAttributes(IEnumerable<XElement> source, XName name)
		{
			foreach (XElement e in source)
			{
				if (e != null)
				{
					XAttribute a = e.lastAttr;
					if (a != null)
					{
						do
						{
							a = a.next;
							if (name == null || a.name == name)
							{
								yield return a;
							}
						}
						while (a.parent == e && a != e.lastAttr);
					}
					a = null;
				}
				e = null;
			}
			IEnumerator<XElement> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004182 File Offset: 0x00002382
		private static IEnumerable<XElement> GetAncestors<T>(IEnumerable<T> source, XName name, bool self) where T : XNode
		{
			foreach (T t in source)
			{
				XNode xnode = t;
				if (xnode != null)
				{
					XElement e;
					for (e = ((self ? xnode : xnode.parent) as XElement); e != null; e = (e.parent as XElement))
					{
						if (name == null || e.name == name)
						{
							yield return e;
						}
					}
					e = null;
				}
			}
			IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000041A0 File Offset: 0x000023A0
		private static IEnumerable<XNode> GetDescendantNodes<T>(IEnumerable<T> source, bool self) where T : XContainer
		{
			foreach (T t in source)
			{
				XContainer root = t;
				if (root != null)
				{
					if (self)
					{
						yield return root;
					}
					XNode i = root;
					for (;;)
					{
						XContainer xcontainer = i as XContainer;
						XNode firstNode;
						if (xcontainer != null && (firstNode = xcontainer.FirstNode) != null)
						{
							i = firstNode;
						}
						else
						{
							while (i != null && i != root && i == i.parent.content)
							{
								i = i.parent;
							}
							if (i == null || i == root)
							{
								break;
							}
							i = i.next;
						}
						yield return i;
					}
					i = null;
				}
				root = null;
			}
			IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000041B7 File Offset: 0x000023B7
		private static IEnumerable<XElement> GetDescendants<T>(IEnumerable<T> source, XName name, bool self) where T : XContainer
		{
			foreach (T t in source)
			{
				XContainer root = t;
				if (root != null)
				{
					if (self)
					{
						XElement xelement = (XElement)root;
						if (name == null || xelement.name == name)
						{
							yield return xelement;
						}
					}
					XNode i = root;
					XContainer xcontainer = root;
					for (;;)
					{
						if (xcontainer != null && xcontainer.content is XNode)
						{
							i = ((XNode)xcontainer.content).next;
						}
						else
						{
							while (i != null && i != root && i == i.parent.content)
							{
								i = i.parent;
							}
							if (i == null || i == root)
							{
								break;
							}
							i = i.next;
						}
						XElement e = i as XElement;
						if (e != null && (name == null || e.name == name))
						{
							yield return e;
						}
						xcontainer = e;
						e = null;
					}
					i = null;
				}
				root = null;
			}
			IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000041D5 File Offset: 0x000023D5
		private static IEnumerable<XElement> GetElements<T>(IEnumerable<T> source, XName name) where T : XContainer
		{
			foreach (T t in source)
			{
				XContainer root = t;
				if (root != null)
				{
					XNode i = root.content as XNode;
					if (i != null)
					{
						do
						{
							i = i.next;
							XElement xelement = i as XElement;
							if (xelement != null && (name == null || xelement.name == name))
							{
								yield return xelement;
							}
						}
						while (i.parent == root && i != root.content);
					}
					i = null;
				}
				root = null;
			}
			IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}
	}
}
