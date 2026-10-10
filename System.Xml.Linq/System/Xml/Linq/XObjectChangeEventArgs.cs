using System;

namespace System.Xml.Linq
{
	/// <summary>Предоставляет данные для событий <see cref="E:System.Xml.Linq.XObject.Changing" /> и <see cref="E:System.Xml.Linq.XObject.Changed" />.</summary>
	// Token: 0x0200005E RID: 94
	public class XObjectChangeEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XObjectChangeEventArgs" />.</summary>
		/// <param name="objectChange">
		///   <see cref="T:System.Xml.Linq.XObjectChange" />, который содержит аргументы событий для событий LINQ to XML.</param>
		// Token: 0x06000389 RID: 905 RVA: 0x0001015F File Offset: 0x0000E35F
		public XObjectChangeEventArgs(XObjectChange objectChange)
		{
			this._objectChange = objectChange;
		}

		/// <summary>Получение типа изменения.</summary>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XObjectChange" />, который содержит тип изменения.</returns>
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0001016E File Offset: 0x0000E36E
		public XObjectChange ObjectChange
		{
			get
			{
				return this._objectChange;
			}
		}

		// Token: 0x040001D9 RID: 473
		private XObjectChange _objectChange;

		/// <summary>Аргумент события для события изменения <see cref="F:System.Xml.Linq.XObjectChange.Add" />.</summary>
		// Token: 0x040001DA RID: 474
		public static readonly XObjectChangeEventArgs Add = new XObjectChangeEventArgs(XObjectChange.Add);

		/// <summary>Аргумент события для события изменения <see cref="F:System.Xml.Linq.XObjectChange.Remove" />.</summary>
		// Token: 0x040001DB RID: 475
		public static readonly XObjectChangeEventArgs Remove = new XObjectChangeEventArgs(XObjectChange.Remove);

		/// <summary>Аргумент события для события изменения <see cref="F:System.Xml.Linq.XObjectChange.Name" />.</summary>
		// Token: 0x040001DC RID: 476
		public static readonly XObjectChangeEventArgs Name = new XObjectChangeEventArgs(XObjectChange.Name);

		/// <summary>Аргумент события для события изменения <see cref="F:System.Xml.Linq.XObjectChange.Value" />.</summary>
		// Token: 0x040001DD RID: 477
		public static readonly XObjectChangeEventArgs Value = new XObjectChangeEventArgs(XObjectChange.Value);
	}
}
