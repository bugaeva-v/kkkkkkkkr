using System;
using System.CodeDom;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Runtime.Serialization
{
	/// <summary>Предоставляет методы, необходимые для замены одного типа другим с помощью метода <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> во время сериализации, десериализации, а также экспорта и импорта документов схемы XML (XSD).</summary>
	// Token: 0x020000E5 RID: 229
	public interface IDataContractSurrogate
	{
		/// <summary>При выполнении сериализации, десериализации, а также импорта и экспорта схемы возвращает тип контракта данных, заменяющий указанный тип.</summary>
		/// <param name="type">Заменяемый тип среды CLR <see cref="T:System.Type" />.</param>
		/// <returns>Тип <see cref="T:System.Type" />, заменяемый значением <paramref name="type" />. Этот тип должен быть сериализуем методом <see cref="T:System.Runtime.Serialization.DataContractSerializer" />. Например, он должен быть помечен атрибутом <see cref="T:System.Runtime.Serialization.DataContractAttribute" /> или другими распознаваемыми сериализатором механизмами.</returns>
		// Token: 0x06000D2F RID: 3375
		Type GetDataContractType(Type type);

		/// <summary>При выполнении сериализации возвращает объект, заменяющий указанный объект.</summary>
		/// <param name="obj">Заменяемый объект.</param>
		/// <param name="targetType">Тип <see cref="T:System.Type" />, который назначается замененному объекту.</param>
		/// <returns>Замененный объект, который будет сериализован. Этот объект должен быть сериализуем методом <see cref="T:System.Runtime.Serialization.DataContractSerializer" />. Например, он должен быть помечен атрибутом <see cref="T:System.Runtime.Serialization.DataContractAttribute" /> или другими распознаваемыми сериализатором механизмами.</returns>
		// Token: 0x06000D30 RID: 3376
		object GetObjectToSerialize(object obj, Type targetType);

		/// <summary>При выполнении десериализации возвращает объект, являющийся заменой указанного объекта.</summary>
		/// <param name="obj">Заменяемый десериализованный объект.</param>
		/// <param name="targetType">Тип <see cref="T:System.Type" />, который назначается замененному объекту.</param>
		/// <returns>Замененный десериализованный объект. Этот объект должен иметь тип, сериализуемый методом <see cref="T:System.Runtime.Serialization.DataContractSerializer" />. Например, он должен быть помечен атрибутом <see cref="T:System.Runtime.Serialization.DataContractAttribute" /> или другими распознаваемыми сериализатором механизмами.</returns>
		// Token: 0x06000D31 RID: 3377
		object GetDeserializedObject(object obj, Type targetType);

		/// <summary>Во время операций экспорта схемы вставляет в схему заметки для возвращаемых значений, не равных null.</summary>
		/// <param name="memberInfo">Объект <see cref="T:System.Reflection.MemberInfo" />, описывающий элемент.</param>
		/// <param name="dataContractType">Объект <see cref="T:System.Type" />.</param>
		/// <returns>Объект, представляющий заметку, которая вставляется в определение схемы XML.</returns>
		// Token: 0x06000D32 RID: 3378
		object GetCustomDataToExport(MemberInfo memberInfo, Type dataContractType);

		/// <summary>Во время операций экспорта схемы вставляет в схему заметки для возвращаемых значений, не равных null.</summary>
		/// <param name="clrType">Заменяемый тип среды CLR.</param>
		/// <param name="dataContractType">Тип контракта данных, для которого создается заметка.</param>
		/// <returns>Объект, представляющий заметку, которая вставляется в определение схемы XML.</returns>
		// Token: 0x06000D33 RID: 3379
		object GetCustomDataToExport(Type clrType, Type dataContractType);

		/// <summary>Задает коллекцию известных типов, используемую для сериализации и десериализации пользовательских объектов данных.</summary>
		/// <param name="customDataTypes">Объект <see cref="T:System.Collections.ObjectModel.Collection`1" /> типа <see cref="T:System.Type" />, в который добавляются известные типы.</param>
		// Token: 0x06000D34 RID: 3380
		void GetKnownCustomDataTypes(Collection<Type> customDataTypes);

		/// <summary>При выполнении импорта схемы возвращает тип, на который ссылается схема.</summary>
		/// <param name="typeName">Имя типа в схеме.</param>
		/// <param name="typeNamespace">Пространство имен типа в схеме.</param>
		/// <param name="customData">Объект, представляющий вставленную в определение схемы XML заметку, содержащую данные, которые можно использовать для поиска типа, на который задана ссылка.</param>
		/// <returns>Тип <see cref="T:System.Type" />, используемый для типа, на который задана ссылка.</returns>
		// Token: 0x06000D35 RID: 3381
		Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData);

		/// <summary>Обрабатывает тип, созданный из импортированной схемы.</summary>
		/// <param name="typeDeclaration">Обрабатываемый объект <see cref="T:System.CodeDom.CodeTypeDeclaration" />, представляющий объявление типа, создаваемого при выполнении импорта схемы.</param>
		/// <param name="compileUnit">Объект <see cref="T:System.CodeDom.CodeCompileUnit" />, содержащий другой код, созданный при выполнении импорта схемы.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeDeclaration" />, содержащий обработанный тип.</returns>
		// Token: 0x06000D36 RID: 3382
		CodeTypeDeclaration ProcessImportedType(CodeTypeDeclaration typeDeclaration, CodeCompileUnit compileUnit);
	}
}
