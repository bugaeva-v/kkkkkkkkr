using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Linq
{
	/// <summary>Предоставляет возможность сравнивать узлы по их порядку в документе. Этот класс не наследуется.</summary>
	// Token: 0x02000057 RID: 87
	public sealed class XNodeDocumentOrderComparer : IComparer, IComparer<XNode>
	{
		/// <summary>Сравнивает два узла для определения их относительного порядка документов.</summary>
		/// <param name="x">Первый экземпляр <see cref="T:System.Xml.Linq.XNode" /> для сравнения.</param>
		/// <param name="y">Второй экземпляр <see cref="T:System.Xml.Linq.XNode" /> для сравнения.</param>
		/// <returns>
		///   <see cref="T:System.Int32" /> содержит 0, если узлы эквивалентны; -1, если <paramref name="x" /> предшествует <paramref name="y" />; и 1, если <paramref name="x" /> находится после <paramref name="y" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">У этих двух узлов нет общего предка.</exception>
		// Token: 0x06000313 RID: 787 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		public int Compare(XNode x, XNode y)
		{
			return XNode.CompareDocumentOrder(x, y);
		}

		/// <summary>Сравнивает два узла для определения их относительного порядка документов.</summary>
		/// <param name="x">Первый экземпляр <see cref="T:System.Xml.Linq.XNode" /> для сравнения.</param>
		/// <param name="y">Второй экземпляр <see cref="T:System.Xml.Linq.XNode" /> для сравнения.</param>
		/// <returns>
		///   <see cref="T:System.Int32" /> содержит 0, если узлы эквивалентны; -1, если <paramref name="x" /> предшествует <paramref name="y" />; и 1, если <paramref name="x" /> находится после <paramref name="y" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">У этих двух узлов нет общего предка.</exception>
		/// <exception cref="T:System.ArgumentException">Два узла не извлечены из <see cref="T:System.Xml.Linq.XNode" />.</exception>
		// Token: 0x06000314 RID: 788 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
		int IComparer.Compare(object x, object y)
		{
			XNode xnode = x as XNode;
			if (xnode == null && x != null)
			{
				throw new ArgumentException(SR.Format("The argument must be derived from {0}.", typeof(XNode)), "x");
			}
			XNode xnode2 = y as XNode;
			if (xnode2 == null && y != null)
			{
				throw new ArgumentException(SR.Format("The argument must be derived from {0}.", typeof(XNode)), "y");
			}
			return this.Compare(xnode, xnode2);
		}
	}
}
