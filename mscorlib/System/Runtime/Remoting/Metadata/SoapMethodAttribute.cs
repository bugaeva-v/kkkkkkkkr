using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Настраивает генерирование и обработку SOAP для метода. Этот класс не наследуется.</summary>
	// Token: 0x020005DA RID: 1498
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class SoapMethodAttribute : SoapAttribute
	{
		/// <summary>Возвращает или задает имя элемента XML, используемое для ответа метода целевому методу.</summary>
		/// <returns>Имя элемента XML, используемое для ответа метода целевому методу.</returns>
		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x000CB030 File Offset: 0x000C9230
		// (set) Token: 0x06003905 RID: 14597 RVA: 0x000CB038 File Offset: 0x000C9238
		public string ResponseXmlElementName
		{
			get
			{
				return this._responseElement;
			}
			set
			{
				this._responseElement = value;
			}
		}

		/// <summary>Возвращает или задает пространство имен элемента XML, используемое для ответа метода целевому методу.</summary>
		/// <returns>Пространство имен элемента XML, используемое для ответа метода целевому методу.</returns>
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x000CB041 File Offset: 0x000C9241
		// (set) Token: 0x06003907 RID: 14599 RVA: 0x000CB049 File Offset: 0x000C9249
		public string ResponseXmlNamespace
		{
			get
			{
				return this._responseNamespace;
			}
			set
			{
				this._responseNamespace = value;
			}
		}

		/// <summary>Возвращает или задает имя элемента XML, используемое для возвращаемого значения из целевого метода.</summary>
		/// <returns>Имя элемента XML, используемое для возвращаемого значения из целевого метода.</returns>
		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x000CB052 File Offset: 0x000C9252
		// (set) Token: 0x06003909 RID: 14601 RVA: 0x000CB05A File Offset: 0x000C925A
		public string ReturnXmlElementName
		{
			get
			{
				return this._returnElement;
			}
			set
			{
				this._returnElement = value;
			}
		}

		/// <summary>Возвращает или задает поле заголовка SOAPAction, используемое с HTTP-запросами, отправляемыми с помощью этого метода. Это свойство в настоящее время не реализовано.</summary>
		/// <returns>Поле заголовка SOAPAction, используемое с HTTP-запросами, отправляемыми с помощью этого метода.</returns>
		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x000CB063 File Offset: 0x000C9263
		// (set) Token: 0x0600390B RID: 14603 RVA: 0x000CB06B File Offset: 0x000C926B
		public string SoapAction
		{
			get
			{
				return this._soapAction;
			}
			set
			{
				this._soapAction = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, будет ли сериализован целевой объект текущего атрибута как атрибут XML вместо поля XML.</summary>
		/// <returns>Текущая реализация всегда возвращает <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Была предпринята попытка задать текущее свойство.</exception>
		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x000CB074 File Offset: 0x000C9274
		// (set) Token: 0x0600390D RID: 14605 RVA: 0x000CB07C File Offset: 0x000C927C
		public override bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
			set
			{
				this._useAttribute = value;
			}
		}

		/// <summary>Возвращает или задает пространство имен XML, используемое при сериализации удаленных вызовов целевого метода.</summary>
		/// <returns>Пространство имен XML, используемое при сериализации удаленных вызовов целевого метода.</returns>
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x000CB085 File Offset: 0x000C9285
		// (set) Token: 0x0600390F RID: 14607 RVA: 0x000CB08D File Offset: 0x000C928D
		public override string XmlNamespace
		{
			get
			{
				return this._namespace;
			}
			set
			{
				this._namespace = value;
			}
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x000CB098 File Offset: 0x000C9298
		internal override void SetReflectionObject(object reflectionObject)
		{
			MethodBase methodBase = (MethodBase)reflectionObject;
			if (this._responseElement == null)
			{
				this._responseElement = methodBase.Name + "Response";
			}
			if (this._responseNamespace == null)
			{
				this._responseNamespace = SoapServices.GetXmlNamespaceForMethodResponse(methodBase);
			}
			if (this._returnElement == null)
			{
				this._returnElement = "return";
			}
			if (this._soapAction == null)
			{
				this._soapAction = SoapServices.GetXmlNamespaceForMethodCall(methodBase) + "#" + methodBase.Name;
			}
			if (this._namespace == null)
			{
				this._namespace = SoapServices.GetXmlNamespaceForMethodCall(methodBase);
			}
		}

		// Token: 0x04002605 RID: 9733
		private string _responseElement;

		// Token: 0x04002606 RID: 9734
		private string _responseNamespace;

		// Token: 0x04002607 RID: 9735
		private string _returnElement;

		// Token: 0x04002608 RID: 9736
		private string _soapAction;

		// Token: 0x04002609 RID: 9737
		private bool _useAttribute;

		// Token: 0x0400260A RID: 9738
		private string _namespace;
	}
}
