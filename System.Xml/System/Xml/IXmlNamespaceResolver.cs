using System;
using System.Collections.Generic;

namespace System.Xml
{
	/// <summary>
	///         Предоставляет доступ только для чтения к набору сопоставлений префиксов и пространств имен.
	///       </summary>
	// Token: 0x020001E5 RID: 485
	public interface IXmlNamespaceResolver
	{
		/// <summary>
		///         Возвращает коллекцию сопоставлений определенный префикс-пространство имен, которые в настоящее время находятся в области.
		///       </summary>
		/// <param name="scope">
		///           С помощью значения <see cref="T:System.Xml.XmlNamespaceScope" /> указывается тип узлов пространства имен, которые следует возвратить.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Collections.IDictionary" />, содержащий текущие пространства имен в области.
		///       </returns>
		// Token: 0x06001327 RID: 4903
		IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);

		/// <summary>
		///         Получает пространство имен URI, сопоставленную с указанным префиксом.
		///       </summary>
		/// <param name="prefix">
		///           Префикс, URI пространства имен которого нужно найти.
		///         </param>
		/// <returns>
		///         URI пространства имен, сопоставленное с префиксом; <see langword="null" />, если префикс не сопоставлен с URI пространства имен.
		///       </returns>
		// Token: 0x06001328 RID: 4904
		string LookupNamespace(string prefix);

		/// <summary>
		///         Возвращает префикс, сопоставленный с указанным URI пространства имен.
		///       </summary>
		/// <param name="namespaceName">
		///           URI пространства имен, префикс которого нужно найти.
		///         </param>
		/// <returns>
		///         Префикс, сопоставленный с URI пространства имен; <see langword="null" /> если URI пространства имен не сопоставлен с префиксом.
		///       </returns>
		// Token: 0x06001329 RID: 4905
		string LookupPrefix(string namespaceName);
	}
}
