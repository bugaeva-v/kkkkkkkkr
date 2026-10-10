using System;
using System.Collections;

namespace System.Xml.Xsl
{
	/// <summary>
	///         Содержит переменное число аргументов, являющихся либо параметрами XSLT, либо объектами расширения.
	///       </summary>
	// Token: 0x02000348 RID: 840
	public class XsltArgumentList
	{
		/// <summary>
		///         Возвращает параметр, связанный с полным именем пространства имен.
		///       </summary>
		/// <param name="name">
		///           Имя параметра.
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> не проверяет, чтобы гарантировать передаваемое имя допустимым локальным именем; Тем не менее, оно не может быть <see langword="null" />.
		///         </param>
		/// <param name="namespaceUri">
		///           URI пространства имен, связанный с параметром.
		///         </param>
		/// <returns>
		///         Объект параметра или <see langword="null" /> если он не был найден.
		///       </returns>
		// Token: 0x060022BF RID: 8895 RVA: 0x000DA602 File Offset: 0x000D8802
		public object GetParam(string name, string namespaceUri)
		{
			return this.parameters[new XmlQualifiedName(name, namespaceUri)];
		}

		/// <summary>
		///         Возвращает объект, связанный с заданным пространством имен.
		///       </summary>
		/// <param name="namespaceUri">
		///           Пространство имен URI объекта.
		///         </param>
		/// <returns>
		///         Объект URI пространства имен или <see langword="null" /> если он не был найден.
		///       </returns>
		// Token: 0x060022C0 RID: 8896 RVA: 0x000DA616 File Offset: 0x000D8816
		public object GetExtensionObject(string namespaceUri)
		{
			return this.extensions[namespaceUri];
		}

		/// <summary>
		///         Добавляет параметр <see cref="T:System.Xml.Xsl.XsltArgumentList" /> и связывает его с полным именем пространства имен.
		///       </summary>
		/// <param name="name">
		///           Имя, связанное с параметром.
		///         </param>
		/// <param name="namespaceUri">
		///           URI пространства имен для связи с параметром.
		///            Чтобы использовать пространство имен по умолчанию, укажите пустую строку.
		///         </param>
		/// <param name="parameter">
		///           Значение параметра или объект, добавляемый в список.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="namespaceUri" /> Либо <see langword="null" /> или http://www.w3.org/1999/XSL/Transform.
		///
		///             <paramref name="name" /> Не является допустимым именем в соответствии со спецификацией W3C XML.
		///
		///             <paramref name="namespaceUri" /> Уже имеется параметр, связанный с ним.
		///           </exception>
		// Token: 0x060022C1 RID: 8897 RVA: 0x000DA624 File Offset: 0x000D8824
		public void AddParam(string name, string namespaceUri, object parameter)
		{
			XsltArgumentList.CheckArgumentNull(name, "name");
			XsltArgumentList.CheckArgumentNull(namespaceUri, "namespaceUri");
			XsltArgumentList.CheckArgumentNull(parameter, "parameter");
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(name, namespaceUri);
			xmlQualifiedName.Verify();
			this.parameters.Add(xmlQualifiedName, parameter);
		}

		/// <summary>
		///         Добавляет новый объект <see cref="T:System.Xml.Xsl.XsltArgumentList" /> и связывает его с URI пространства имен.
		///       </summary>
		/// <param name="namespaceUri">
		///           URI пространства имен для связи с объектом.
		///            Чтобы использовать пространство имен по умолчанию, укажите пустую строку.
		///         </param>
		/// <param name="extension">
		///           Объект, который нужно добавить в список.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="namespaceUri" /> Либо <see langword="null" /> или http://www.w3.org/1999/XSL/Transform 
		///
		///             <paramref name="namespaceUri" /> Уже есть объект расширения, связанные с ним.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Вызывающий объект не имеет достаточных полномочий для вызова этого метода.
		///           </exception>
		// Token: 0x060022C2 RID: 8898 RVA: 0x000DA66D File Offset: 0x000D886D
		public void AddExtensionObject(string namespaceUri, object extension)
		{
			XsltArgumentList.CheckArgumentNull(namespaceUri, "namespaceUri");
			XsltArgumentList.CheckArgumentNull(extension, "extension");
			this.extensions.Add(namespaceUri, extension);
		}

		/// <summary>
		///         Удаляет параметр из <see cref="T:System.Xml.Xsl.XsltArgumentList" />.
		///       </summary>
		/// <param name="name">
		///           Имя удаляемого параметра.
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> не проверяет, чтобы гарантировать передаваемое имя допустимым локальным именем; Тем не менее, оно не может быть <see langword="null" />.
		///         </param>
		/// <param name="namespaceUri">
		///           Пространство имен URI для удаления параметра.
		///         </param>
		/// <returns>
		///         Объект параметра или <see langword="null" /> если он не был найден.
		///       </returns>
		// Token: 0x060022C3 RID: 8899 RVA: 0x000DA694 File Offset: 0x000D8894
		public object RemoveParam(string name, string namespaceUri)
		{
			XmlQualifiedName key = new XmlQualifiedName(name, namespaceUri);
			object result = this.parameters[key];
			this.parameters.Remove(key);
			return result;
		}

		/// <summary>
		///         Удаляет объект с URI пространства имен из <see cref="T:System.Xml.Xsl.XsltArgumentList" />.
		///       </summary>
		/// <param name="namespaceUri">
		///           Пространство имен URI, связанное с объектом для удаления.
		///         </param>
		/// <returns>
		///         Объект с URI пространства имен или <see langword="null" /> если он не был найден.
		///       </returns>
		// Token: 0x060022C4 RID: 8900 RVA: 0x000DA6C1 File Offset: 0x000D88C1
		public object RemoveExtensionObject(string namespaceUri)
		{
			object result = this.extensions[namespaceUri];
			this.extensions.Remove(namespaceUri);
			return result;
		}

		/// <summary>
		///         Происходит, когда сообщение указывается в таблице стилей, xsl:message элемент.
		///       </summary>
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060022C5 RID: 8901 RVA: 0x000DA6DB File Offset: 0x000D88DB
		// (remove) Token: 0x060022C6 RID: 8902 RVA: 0x000DA6F4 File Offset: 0x000D88F4
		public event XsltMessageEncounteredEventHandler XsltMessageEncountered
		{
			add
			{
				this.xsltMessageEncountered = (XsltMessageEncounteredEventHandler)Delegate.Combine(this.xsltMessageEncountered, value);
			}
			remove
			{
				this.xsltMessageEncountered = (XsltMessageEncounteredEventHandler)Delegate.Remove(this.xsltMessageEncountered, value);
			}
		}

		/// <summary>
		///         Удаляет все параметры и объекты расширения из <see cref="T:System.Xml.Xsl.XsltArgumentList" />.
		///       </summary>
		// Token: 0x060022C7 RID: 8903 RVA: 0x000DA70D File Offset: 0x000D890D
		public void Clear()
		{
			this.parameters.Clear();
			this.extensions.Clear();
			this.xsltMessageEncountered = null;
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000DA72C File Offset: 0x000D892C
		private static void CheckArgumentNull(object param, string paramName)
		{
			if (param == null)
			{
				throw new ArgumentNullException(paramName);
			}
		}

		// Token: 0x04001C4F RID: 7247
		private Hashtable parameters = new Hashtable();

		// Token: 0x04001C50 RID: 7248
		private Hashtable extensions = new Hashtable();

		// Token: 0x04001C51 RID: 7249
		internal XsltMessageEncounteredEventHandler xsltMessageEncountered;
	}
}
