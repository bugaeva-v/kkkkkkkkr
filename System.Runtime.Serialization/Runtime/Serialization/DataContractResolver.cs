using System;
using System.Xml;

namespace System.Runtime.Serialization
{
	/// <summary>Предоставляет механизм динамического сопоставления типов с представлением <see langword="xsi:type" /> во время сериализации и десериализации.</summary>
	// Token: 0x020000C5 RID: 197
	public abstract class DataContractResolver
	{
		/// <summary>Переопределение этого метода, чтобы во время сериализации сопоставить тип контракта данных с именем <see langword="xsi:type" /> и пространством имен.</summary>
		/// <param name="type">Сопоставляемый тип.</param>
		/// <param name="declaredType">Тип данных объявлен в контракте данных.</param>
		/// <param name="knownTypeResolver">Известный арбитр типов.</param>
		/// <param name="typeName">Имя xsi:type.</param>
		/// <param name="typeNamespace">Пространство имен xsi:type.</param>
		/// <returns>Значение <see langword="true" />, если сопоставление успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000B46 RID: 2886
		public abstract bool TryResolveType(Type type, Type declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace);

		/// <summary>Переопределение этого метода, чтобы во время десериализации сопоставить указанное имя <see langword="xsi:type" /> и пространство имен с типом контракта данных.</summary>
		/// <param name="typeName">Имя <see langword="xsi:type" /> для сопоставления.</param>
		/// <param name="typeNamespace">Пространство имен <see langword="xsi:type" /> для сопоставления.</param>
		/// <param name="declaredType">Тип данных объявлен в контракте данных.</param>
		/// <param name="knownTypeResolver">Известный арбитр типов.</param>
		/// <returns>Тип, с которым сопоставляются имя и пространство имен <see langword="xsi:type" />.</returns>
		// Token: 0x06000B47 RID: 2887
		public abstract Type ResolveName(string typeName, string typeNamespace, Type declaredType, DataContractResolver knownTypeResolver);
	}
}
