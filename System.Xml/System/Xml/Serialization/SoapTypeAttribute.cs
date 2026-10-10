using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Управляет схемой, созданной объектом <see cref="T:System.Xml.Serialization.XmlSerializer" /> при сериализации экземпляра класса как закодированного SOAP XML.
	///       </summary>
	// Token: 0x020002B7 RID: 695
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	public class SoapTypeAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.SoapTypeAttribute" />.
		///       </summary>
		// Token: 0x06001A57 RID: 6743 RVA: 0x00098810 File Offset: 0x00096A10
		public SoapTypeAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.SoapTypeAttribute" /> и задает имя типа XML.
		///       </summary>
		/// <param name="typeName">
		///           Имя XML-типа, <see cref="T:System.Xml.Serialization.XmlSerializer" /> приводит к возникновению ошибки при сериализации экземпляра класса (и распознаваемого при десериализации экземпляра класса).
		///         </param>
		// Token: 0x06001A58 RID: 6744 RVA: 0x0009881F File Offset: 0x00096A1F
		public SoapTypeAttribute(string typeName)
		{
			this.typeName = typeName;
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.SoapTypeAttribute" /> класса и указывает имя и пространство имен типа XML.
		///       </summary>
		/// <param name="typeName">
		///           Имя XML-типа, <see cref="T:System.Xml.Serialization.XmlSerializer" /> приводит к возникновению ошибки при сериализации экземпляра класса (и распознаваемого при десериализации экземпляра класса).
		///         </param>
		/// <param name="ns">
		///           Пространство имен типа XML.
		///         </param>
		// Token: 0x06001A59 RID: 6745 RVA: 0x00098835 File Offset: 0x00096A35
		public SoapTypeAttribute(string typeName, string ns)
		{
			this.typeName = typeName;
			this.ns = ns;
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, следует ли включать тип в закодированные SOAP документы схемы XML.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> для включения типа в документы XML-схемы с кодировкой SOAP; в противном случае — <see langword="false" />.
		///          Значение по умолчанию — <see langword="true" />.
		///       </returns>
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00098852 File Offset: 0x00096A52
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x0009885A File Offset: 0x00096A5A
		public bool IncludeInSchema
		{
			get
			{
				return this.includeInSchema;
			}
			set
			{
				this.includeInSchema = value;
			}
		}

		/// <summary>
		///         Возвращает или задает имя типа XML.
		///       </summary>
		/// <returns>
		///         Имя типа XML.
		///          Значение по умолчанию — это имя класса.
		///       </returns>
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x00098863 File Offset: 0x00096A63
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x00098879 File Offset: 0x00096A79
		public string TypeName
		{
			get
			{
				if (this.typeName != null)
				{
					return this.typeName;
				}
				return string.Empty;
			}
			set
			{
				this.typeName = value;
			}
		}

		/// <summary>
		///         Возвращает или задает пространство имен типа XML.
		///       </summary>
		/// <returns>
		///         Пространство имен типа XML.
		///          Значение по умолчанию — пустая строка ("").
		///       </returns>
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00098882 File Offset: 0x00096A82
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0009888A File Offset: 0x00096A8A
		public string Namespace
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
			}
		}

		// Token: 0x04001963 RID: 6499
		private string ns;

		// Token: 0x04001964 RID: 6500
		private string typeName;

		// Token: 0x04001965 RID: 6501
		private bool includeInSchema = true;
	}
}
