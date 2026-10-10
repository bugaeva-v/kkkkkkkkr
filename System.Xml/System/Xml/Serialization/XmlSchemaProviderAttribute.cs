using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         При применении к типу хранит имя статического метода типа, возвращающего XML-схему и объект <see cref="T:System.Xml.XmlQualifiedName" /> (или <see cref="T:System.Xml.Schema.XmlSchemaType" /> для анонимных типов), который управляет сериализацией этого типа.
	///       </summary>
	// Token: 0x020002E5 RID: 741
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class XmlSchemaProviderAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute" />, принимая имя статического метода, который предоставляет XML-схему типа.
		///       </summary>
		/// <param name="methodName">
		///           Имя статического метода, который необходимо реализовать.
		///         </param>
		// Token: 0x06001D0F RID: 7439 RVA: 0x000A9DA9 File Offset: 0x000A7FA9
		public XmlSchemaProviderAttribute(string methodName)
		{
			this.methodName = methodName;
		}

		/// <summary>
		///         Получает имя статического метода, который предоставляет XML-схему типа и имя его типа данных XML-схемы.
		///       </summary>
		/// <returns>
		///         Имя метода, который вызывается инфраструктурой XML для возврата XML-схемы.
		///       </returns>
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x000A9DB8 File Offset: 0x000A7FB8
		public string MethodName
		{
			get
			{
				return this.methodName;
			}
		}

		/// <summary>
		///         Получает или задает значение, определяющее, является ли целевой класс подстановочным знаком, или содержит ли схема для класса только элемент <see langword="xs:any" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если класс является подстановочным знаком, или схема содержит только элемент <see langword="xs:any" />; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x000A9DC0 File Offset: 0x000A7FC0
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x000A9DC8 File Offset: 0x000A7FC8
		public bool IsAny
		{
			get
			{
				return this.any;
			}
			set
			{
				this.any = value;
			}
		}

		// Token: 0x04001A36 RID: 6710
		private string methodName;

		// Token: 0x04001A37 RID: 6711
		private bool any;
	}
}
