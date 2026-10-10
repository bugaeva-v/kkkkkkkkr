using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Элементы управления как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует член перечисления.
	///       </summary>
	// Token: 0x020002D2 RID: 722
	[AttributeUsage(AttributeTargets.Field)]
	public class XmlEnumAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlEnumAttribute" />.
		///       </summary>
		// Token: 0x06001BF8 RID: 7160 RVA: 0x000021EA File Offset: 0x000003EA
		public XmlEnumAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlEnumAttribute" /> и определяет значение XML, которое <see cref="T:System.Xml.Serialization.XmlSerializer" /> генерирует или распознает (когда он сериализует или десериализует соответственно).
		///       </summary>
		/// <param name="name">
		///           Переопределяющее имя члена перечисления.
		///         </param>
		// Token: 0x06001BF9 RID: 7161 RVA: 0x0009E6FE File Offset: 0x0009C8FE
		public XmlEnumAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>
		///         Возвращает или задает значение, создаваемое в документе XML экземпляром при <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует перечисление, или значение, распознаваемое при десериализации члена перечисления.
		///       </summary>
		/// <returns>
		///         Значение, созданное в документе XML экземпляром при <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует перечисление, или значение, распознаваемое при десериализации члена перечисления.
		///       </returns>
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x0009E70D File Offset: 0x0009C90D
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x0009E715 File Offset: 0x0009C915
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x040019F3 RID: 6643
		private string name;
	}
}
