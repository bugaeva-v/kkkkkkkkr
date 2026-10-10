using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает <see cref="T:System.Xml.Serialization.XmlSerializer" /> элемента, которые должны обрабатываться как текст XML, когда класс, содержащий его сериализации или десериализации.
	///       </summary>
	// Token: 0x02000308 RID: 776
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlTextAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlTextAttribute" />.
		///       </summary>
		// Token: 0x0600204D RID: 8269 RVA: 0x000021EA File Offset: 0x000003EA
		public XmlTextAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlTextAttribute" />.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Сериализуемого члена.
		///         </param>
		// Token: 0x0600204E RID: 8270 RVA: 0x000D0B7F File Offset: 0x000CED7F
		public XmlTextAttribute(Type type)
		{
			this.type = type;
		}

		/// <summary>
		///         Возвращает или задает тип элемента.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Элемента.
		///       </returns>
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x000D0B8E File Offset: 0x000CED8E
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x000D0B96 File Offset: 0x000CED96
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

		/// <summary>
		///         Возвращает или задает XML-схемы (XSD) тип данных языка определения текста, созданных <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </summary>
		/// <returns>
		///         Схемы XML (XSD) типа данных, как определено документом консорциума World Wide Web (www.w3.org) «XML схема часть 2: типы данных».
		///       </returns>
		/// <exception cref="T:System.Exception">
		///             Указанный тип данных схемы XML не может быть сопоставлен с типом данных .NET.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Указанный тип данных схемы XML недопустим для свойства и не может быть преобразован в тип члена.
		///           </exception>
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x000D0B9F File Offset: 0x000CED9F
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x000D0BB5 File Offset: 0x000CEDB5
		public string DataType
		{
			get
			{
				if (this.dataType != null)
				{
					return this.dataType;
				}
				return string.Empty;
			}
			set
			{
				this.dataType = value;
			}
		}

		// Token: 0x04001B25 RID: 6949
		private Type type;

		// Token: 0x04001B26 RID: 6950
		private string dataType;
	}
}
