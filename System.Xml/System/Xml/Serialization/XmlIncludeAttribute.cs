using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Позволяет <see cref="T:System.Xml.Serialization.XmlSerializer" /> распознать тип при сериализации или десериализации объекта.
	///       </summary>
	// Token: 0x020002D4 RID: 724
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface, AllowMultiple = true)]
	public class XmlIncludeAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlIncludeAttribute" />.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта для включения.
		///         </param>
		// Token: 0x06001BFD RID: 7165 RVA: 0x0009E71E File Offset: 0x0009C91E
		public XmlIncludeAttribute(Type type)
		{
			this.type = type;
		}

		/// <summary>
		///         Возвращает или задает тип объекта.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Объекта для включения.
		///       </returns>
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x0009E72D File Offset: 0x0009C92D
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x0009E735 File Offset: 0x0009C935
		public Type Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		// Token: 0x040019F4 RID: 6644
		private Type type;
	}
}
