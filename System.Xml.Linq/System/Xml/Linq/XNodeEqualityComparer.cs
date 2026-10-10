using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Linq
{
	/// <summary>Сравнивает узлы, чтобы определить, эквивалентны ли они. Этот класс не наследуется.</summary>
	// Token: 0x02000058 RID: 88
	public sealed class XNodeEqualityComparer : IEqualityComparer, IEqualityComparer<XNode>
	{
		/// <summary>Сравнивает значения двух узлов.</summary>
		/// <param name="x">Первый экземпляр <see cref="T:System.Xml.Linq.XNode" /> для сравнения.</param>
		/// <param name="y">Второй экземпляр <see cref="T:System.Xml.Linq.XNode" /> для сравнения.</param>
		/// <returns>
		///   <see cref="T:System.Boolean" />, показывающий — эквивалентны ли узлы.</returns>
		// Token: 0x06000316 RID: 790 RVA: 0x0000E23D File Offset: 0x0000C43D
		public bool Equals(XNode x, XNode y)
		{
			return XNode.DeepEquals(x, y);
		}

		/// <summary>Возвращает хэш-код, основанный на <see cref="T:System.Xml.Linq.XNode" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Xml.Linq.XNode" /> для хэширования.</param>
		/// <returns>
		///   <see cref="T:System.Int32" /> содержит основанный на некотором значении хэш-код для узла.</returns>
		// Token: 0x06000317 RID: 791 RVA: 0x0000E246 File Offset: 0x0000C446
		public int GetHashCode(XNode obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetDeepHashCode();
		}

		/// <summary>Сравнивает значения двух узлов.</summary>
		/// <param name="x">Первый экземпляр <see cref="T:System.Xml.Linq.XNode" /> для сравнения.</param>
		/// <param name="y">Второй экземпляр <see cref="T:System.Xml.Linq.XNode" /> для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если узлы равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000318 RID: 792 RVA: 0x0000E254 File Offset: 0x0000C454
		bool IEqualityComparer.Equals(object x, object y)
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
			return this.Equals(xnode, xnode2);
		}

		/// <summary>Возвращает хэш-код, основанный на значении узла.</summary>
		/// <param name="obj">Узел для хэширования.</param>
		/// <returns>
		///   <see cref="T:System.Int32" /> содержит основанный на некотором значении хэш-код для узла.</returns>
		// Token: 0x06000319 RID: 793 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
		int IEqualityComparer.GetHashCode(object obj)
		{
			XNode xnode = obj as XNode;
			if (xnode == null && obj != null)
			{
				throw new ArgumentException(SR.Format("The argument must be derived from {0}.", typeof(XNode)), "obj");
			}
			return this.GetHashCode(xnode);
		}
	}
}
