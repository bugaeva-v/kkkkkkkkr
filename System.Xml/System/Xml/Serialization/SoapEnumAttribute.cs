using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Элементы управления как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует член перечисления.
	///       </summary>
	// Token: 0x020002B0 RID: 688
	[AttributeUsage(AttributeTargets.Field)]
	public class SoapEnumAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.SoapEnumAttribute" />.
		///       </summary>
		// Token: 0x060019EE RID: 6638 RVA: 0x000021EA File Offset: 0x000003EA
		public SoapEnumAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.SoapEnumAttribute" /> с использованием указанного имени элемента.
		///       </summary>
		/// <param name="name">
		///           Имя элемента XML, созданные <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///         </param>
		// Token: 0x060019EF RID: 6639 RVA: 0x00094D27 File Offset: 0x00092F27
		public SoapEnumAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>
		///         Возвращает или задает значение, создаваемое в XML-документ при <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует перечисление, или значение, распознаваемое при десериализации члена перечисления.
		///       </summary>
		/// <returns>
		///         Значение, созданное в XML-документ при <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует перечисление, или значение, распознаваемое при десериализации члена перечисления.
		///       </returns>
		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00094D36 File Offset: 0x00092F36
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00094D4C File Offset: 0x00092F4C
		public string Name
		{
			get
			{
				if (this.name != null)
				{
					return this.name;
				}
				return string.Empty;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x04001950 RID: 6480
		private string name;
	}
}
