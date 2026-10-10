using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Позволяет <see cref="T:System.Xml.Serialization.XmlSerializer" /> распознать тип при сериализации или десериализации объекта как закодированного SOAP XML.
	///       </summary>
	// Token: 0x020002B2 RID: 690
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface, AllowMultiple = true)]
	public class SoapIncludeAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.SoapIncludeAttribute" />, используя указанный тип.
		///       </summary>
		/// <param name="type">
		///           Тип объекта.
		///         </param>
		// Token: 0x060019F3 RID: 6643 RVA: 0x00094D55 File Offset: 0x00092F55
		public SoapIncludeAttribute(Type type)
		{
			this.type = type;
		}

		/// <summary>
		///         Возвращает или задает тип объекта для использования при сериализации или десериализации объекта.
		///       </summary>
		/// <returns>
		///         Тип объекта.
		///       </returns>
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00094D64 File Offset: 0x00092F64
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x00094D6C File Offset: 0x00092F6C
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

		// Token: 0x04001951 RID: 6481
		private Type type;
	}
}
