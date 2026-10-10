using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.ReflectionModel
{
	/// <summary>Предоставляет методы расширения для создания и извлечения частей, основанных на отражении.</summary>
	// Token: 0x0200007E RID: 126
	public static class ReflectionModelServices
	{
		/// <summary>Получает тип части из указанного определения части.</summary>
		/// <param name="partDefinition">Проверяемое определение части.</param>
		/// <returns>Тип определяемой части.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="partDefinition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600034E RID: 846 RVA: 0x0000A0D2 File Offset: 0x000082D2
		public static Lazy<Type> GetPartType(ComposablePartDefinition partDefinition)
		{
			Requires.NotNull<ComposablePartDefinition>(partDefinition, "partDefinition");
			ReflectionComposablePartDefinition reflectionComposablePartDefinition = partDefinition as ReflectionComposablePartDefinition;
			if (reflectionComposablePartDefinition == null)
			{
				throw ExceptionBuilder.CreateReflectionModelInvalidPartDefinition("partDefinition", partDefinition.GetType());
			}
			return reflectionComposablePartDefinition.GetLazyPartType();
		}

		/// <summary>Определяет, требуется ли ликвидация для указанной части.</summary>
		/// <param name="partDefinition">Проверяемая часть.</param>
		/// <returns>Значение <see langword="true" />, если для части требуется ликвидация, в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="partDefinition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600034F RID: 847 RVA: 0x0000A0FE File Offset: 0x000082FE
		public static bool IsDisposalRequired(ComposablePartDefinition partDefinition)
		{
			Requires.NotNull<ComposablePartDefinition>(partDefinition, "partDefinition");
			ReflectionComposablePartDefinition reflectionComposablePartDefinition = partDefinition as ReflectionComposablePartDefinition;
			if (reflectionComposablePartDefinition == null)
			{
				throw ExceptionBuilder.CreateReflectionModelInvalidPartDefinition("partDefinition", partDefinition.GetType());
			}
			return reflectionComposablePartDefinition.IsDisposalRequired;
		}

		/// <summary>Получает экспортирующий член из заданного определения экспорта.</summary>
		/// <param name="exportDefinition">Проверяемое определение экспорта.</param>
		/// <returns>Член, указанный в определении экспорта.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="exportDefinition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000350 RID: 848 RVA: 0x0000A12A File Offset: 0x0000832A
		public static LazyMemberInfo GetExportingMember(ExportDefinition exportDefinition)
		{
			Requires.NotNull<ExportDefinition>(exportDefinition, "exportDefinition");
			ReflectionMemberExportDefinition reflectionMemberExportDefinition = exportDefinition as ReflectionMemberExportDefinition;
			if (reflectionMemberExportDefinition == null)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.ReflectionModel_InvalidExportDefinition, exportDefinition.GetType()), "exportDefinition");
			}
			return reflectionMemberExportDefinition.ExportingLazyMember;
		}

		/// <summary>Получает импортирующий член из заданного определения импорта.</summary>
		/// <param name="importDefinition">Проверяемое определение импорта.</param>
		/// <returns>Член, указанный в определении импорта.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="importDefinition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000351 RID: 849 RVA: 0x0000A165 File Offset: 0x00008365
		public static LazyMemberInfo GetImportingMember(ImportDefinition importDefinition)
		{
			Requires.NotNull<ImportDefinition>(importDefinition, "importDefinition");
			ReflectionMemberImportDefinition reflectionMemberImportDefinition = importDefinition as ReflectionMemberImportDefinition;
			if (reflectionMemberImportDefinition == null)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.ReflectionModel_InvalidMemberImportDefinition, importDefinition.GetType()), "importDefinition");
			}
			return reflectionMemberImportDefinition.ImportingLazyMember;
		}

		/// <summary>Получает импортирующий параметр из заданного определения импорта.</summary>
		/// <param name="importDefinition">Проверяемое определение импорта.</param>
		/// <returns>Параметр, указанный в определении импорта.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="importDefinition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000352 RID: 850 RVA: 0x0000A1A0 File Offset: 0x000083A0
		public static Lazy<ParameterInfo> GetImportingParameter(ImportDefinition importDefinition)
		{
			Requires.NotNull<ImportDefinition>(importDefinition, "importDefinition");
			ReflectionParameterImportDefinition reflectionParameterImportDefinition = importDefinition as ReflectionParameterImportDefinition;
			if (reflectionParameterImportDefinition == null)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.ReflectionModel_InvalidParameterImportDefinition, importDefinition.GetType()), "importDefinition");
			}
			return reflectionParameterImportDefinition.ImportingLazyParameter;
		}

		/// <summary>Определяет, какой элемент представляет определение импорта: член или параметр.</summary>
		/// <param name="importDefinition">Проверяемое определение импорта.</param>
		/// <returns>Значение <see langword="true" />, если определение импорта представляет параметр; в противном случае — определение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="importDefinition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000353 RID: 851 RVA: 0x0000A1DB File Offset: 0x000083DB
		public static bool IsImportingParameter(ImportDefinition importDefinition)
		{
			Requires.NotNull<ImportDefinition>(importDefinition, "importDefinition");
			if (!(importDefinition is ReflectionImportDefinition))
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.ReflectionModel_InvalidImportDefinition, importDefinition.GetType()), "importDefinition");
			}
			return importDefinition is ReflectionParameterImportDefinition;
		}

		/// <summary>Указывает, представляет ли указанное определение импорта фабрику экспорта (объект <see cref="T:System.ComponentModel.Composition.ExportFactory`1" /> или <see cref="T:System.ComponentModel.Composition.ExportFactory`2" />).</summary>
		/// <param name="importDefinition">Проверяемое определение импорта.</param>
		/// <returns>Значение <see langword="true" />, если указанное определение импорта представляет фабрику экспорта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000354 RID: 852 RVA: 0x0000A219 File Offset: 0x00008419
		public static bool IsExportFactoryImportDefinition(ImportDefinition importDefinition)
		{
			Requires.NotNull<ImportDefinition>(importDefinition, "importDefinition");
			return importDefinition is IPartCreatorImportDefinition;
		}

		/// <summary>Возвращает представление определения импорта как продукт фабрики экспорта.</summary>
		/// <param name="importDefinition">Представляемое определение импорта.</param>
		/// <returns>Представление определения импорта.</returns>
		// Token: 0x06000355 RID: 853 RVA: 0x0000A22F File Offset: 0x0000842F
		public static ContractBasedImportDefinition GetExportFactoryProductImportDefinition(ImportDefinition importDefinition)
		{
			Requires.NotNull<ImportDefinition>(importDefinition, "importDefinition");
			IPartCreatorImportDefinition partCreatorImportDefinition = importDefinition as IPartCreatorImportDefinition;
			if (partCreatorImportDefinition == null)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.ReflectionModel_InvalidImportDefinition, importDefinition.GetType()), "importDefinition");
			}
			return partCreatorImportDefinition.ProductImportDefinition;
		}

		/// <summary>Создает определение части, используя заданные тип части, импорты, экспорты, метаданные и источник.</summary>
		/// <param name="partType">Тип части.</param>
		/// <param name="isDisposalRequired">Значение <see langword="true" />, если для части требуется ликвидация, в противном случае — значение <see langword="false" />.</param>
		/// <param name="imports">Коллекция импортов части.</param>
		/// <param name="exports">Коллекция экспортов части.</param>
		/// <param name="metadata">Метаданные части.</param>
		/// <param name="origin">Источник части.</param>
		/// <returns>Определение части, созданное на основе заданных параметров.</returns>
		// Token: 0x06000356 RID: 854 RVA: 0x0000A26A File Offset: 0x0000846A
		public static ComposablePartDefinition CreatePartDefinition(Lazy<Type> partType, bool isDisposalRequired, Lazy<IEnumerable<ImportDefinition>> imports, Lazy<IEnumerable<ExportDefinition>> exports, Lazy<IDictionary<string, object>> metadata, ICompositionElement origin)
		{
			Requires.NotNull<Lazy<Type>>(partType, "partType");
			return new ReflectionComposablePartDefinition(new ReflectionPartCreationInfo(partType, isDisposalRequired, imports, exports, metadata, origin));
		}

		/// <summary>Создает определение экспорта из указанного члена, используя заданные имя контракта, метаданные и источник.</summary>
		/// <param name="exportingMember">Экспортируемый член.</param>
		/// <param name="contractName">Имя контракта, используемого для экспорта.</param>
		/// <param name="metadata">Метаданные для экспорта.</param>
		/// <param name="origin">Объект, от которого происходит экспорт.</param>
		/// <returns>Определение экспорта, созданное на основе заданных параметров.</returns>
		// Token: 0x06000357 RID: 855 RVA: 0x0000A289 File Offset: 0x00008489
		public static ExportDefinition CreateExportDefinition(LazyMemberInfo exportingMember, string contractName, Lazy<IDictionary<string, object>> metadata, ICompositionElement origin)
		{
			Requires.NotNullOrEmpty(contractName, "contractName");
			Requires.IsInMembertypeSet(exportingMember.MemberType, "exportingMember", MemberTypes.Field | MemberTypes.Method | MemberTypes.Property | MemberTypes.TypeInfo | MemberTypes.NestedType);
			return new ReflectionMemberExportDefinition(exportingMember, new LazyExportDefinition(contractName, metadata), origin);
		}

		/// <summary>Создает определение импорта для указанного члена, используя заданные имя контракта, удостоверение типа, метаданные импорта, количество элементов, политику рекомпозиции и политику создания.</summary>
		/// <param name="importingMember">Член, в который выполняется импорт.</param>
		/// <param name="contractName">Имя контракта, используемого для импорта.</param>
		/// <param name="requiredTypeIdentity">Требуемое удостоверение типа для импорта.</param>
		/// <param name="requiredMetadata">Требуемые метаданные для импорта.</param>
		/// <param name="cardinality">Количество элементов импорта.</param>
		/// <param name="isRecomposable">Значение <see langword="true" /> для указания того, что импорт разрешает рекомпозицию; в противном случае — значение <see langword="false" />.</param>
		/// <param name="requiredCreationPolicy">Одно из значений перечисления, определяющее политику создания импорта.</param>
		/// <param name="origin">Объект, в который выполняется импорт.</param>
		/// <returns>Определение импорта, созданное на основе заданных параметров.</returns>
		// Token: 0x06000358 RID: 856 RVA: 0x0000A2BC File Offset: 0x000084BC
		public static ContractBasedImportDefinition CreateImportDefinition(LazyMemberInfo importingMember, string contractName, string requiredTypeIdentity, IEnumerable<KeyValuePair<string, Type>> requiredMetadata, ImportCardinality cardinality, bool isRecomposable, CreationPolicy requiredCreationPolicy, ICompositionElement origin)
		{
			return ReflectionModelServices.CreateImportDefinition(importingMember, contractName, requiredTypeIdentity, requiredMetadata, cardinality, isRecomposable, requiredCreationPolicy, MetadataServices.EmptyMetadata, false, origin);
		}

		/// <summary>Создает определение импорта для указанного члена, используя заданные имя контракта, удостоверение типа, метаданные импорта и контракта, количество элементов, политику рекомпозиции и политику создания.</summary>
		/// <param name="importingMember">Член, в который выполняется импорт.</param>
		/// <param name="contractName">Имя контракта, используемого для импорта.</param>
		/// <param name="requiredTypeIdentity">Требуемое удостоверение типа для импорта.</param>
		/// <param name="requiredMetadata">Требуемые метаданные для импорта.</param>
		/// <param name="cardinality">Количество элементов импорта.</param>
		/// <param name="isRecomposable">Значение <see langword="true" /> для указания того, что импорт разрешает рекомпозицию; в противном случае — значение <see langword="false" />.</param>
		/// <param name="requiredCreationPolicy">Одно из значений перечисления, определяющее политику создания импорта.</param>
		/// <param name="metadata">Метаданные контракта.</param>
		/// <param name="isExportFactory">Значение <see langword="true" /> для указания того, что импорт представляет объект <see cref="T:System.ComponentModel.Composition.ExportFactory`1" />; в противном случае — значение <see langword="false" />.</param>
		/// <param name="origin">Объект, в который выполняется импорт.</param>
		/// <returns>Определение импорта, созданное на основе заданных параметров.</returns>
		// Token: 0x06000359 RID: 857 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public static ContractBasedImportDefinition CreateImportDefinition(LazyMemberInfo importingMember, string contractName, string requiredTypeIdentity, IEnumerable<KeyValuePair<string, Type>> requiredMetadata, ImportCardinality cardinality, bool isRecomposable, CreationPolicy requiredCreationPolicy, IDictionary<string, object> metadata, bool isExportFactory, ICompositionElement origin)
		{
			return ReflectionModelServices.CreateImportDefinition(importingMember, contractName, requiredTypeIdentity, requiredMetadata, cardinality, isRecomposable, false, requiredCreationPolicy, metadata, isExportFactory, origin);
		}

		/// <summary>Создает определение импорта для указанного члена, используя заданные имя контракта, удостоверение типа, метаданные импорта и контракта, количество элементов, политику рекомпозиции и политику создания.</summary>
		/// <param name="importingMember">Член, в который выполняется импорт.</param>
		/// <param name="contractName">Имя контракта, используемого для импорта.</param>
		/// <param name="requiredTypeIdentity">Требуемое удостоверение типа для импорта.</param>
		/// <param name="requiredMetadata">Требуемые метаданные для импорта.</param>
		/// <param name="cardinality">Количество элементов импорта.</param>
		/// <param name="isRecomposable">Значение <see langword="true" /> для указания того, что импорт разрешает рекомпозицию; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isPreRequisite">Значение <see langword="true" /> для указания того, что импорт является необходимым условием; в противном случае — значение <see langword="false" />.</param>
		/// <param name="requiredCreationPolicy">Одно из значений перечисления, определяющее политику создания импорта.</param>
		/// <param name="metadata">Метаданные контракта.</param>
		/// <param name="isExportFactory">Значение <see langword="true" /> для указания того, что импорт представляет объект <see cref="T:System.ComponentModel.Composition.ExportFactory`1" />; в противном случае — значение <see langword="false" />.</param>
		/// <param name="origin">Объект, в который выполняется импорт.</param>
		/// <returns>Определение импорта, созданное на основе заданных параметров.</returns>
		// Token: 0x0600035A RID: 858 RVA: 0x0000A304 File Offset: 0x00008504
		public static ContractBasedImportDefinition CreateImportDefinition(LazyMemberInfo importingMember, string contractName, string requiredTypeIdentity, IEnumerable<KeyValuePair<string, Type>> requiredMetadata, ImportCardinality cardinality, bool isRecomposable, bool isPreRequisite, CreationPolicy requiredCreationPolicy, IDictionary<string, object> metadata, bool isExportFactory, ICompositionElement origin)
		{
			Requires.NotNullOrEmpty(contractName, "contractName");
			Requires.IsInMembertypeSet(importingMember.MemberType, "importingMember", MemberTypes.Field | MemberTypes.Property);
			if (isExportFactory)
			{
				return new PartCreatorMemberImportDefinition(importingMember, origin, new ContractBasedImportDefinition(contractName, requiredTypeIdentity, requiredMetadata, cardinality, isRecomposable, isPreRequisite, CreationPolicy.NonShared, metadata));
			}
			return new ReflectionMemberImportDefinition(importingMember, contractName, requiredTypeIdentity, requiredMetadata, cardinality, isRecomposable, isPreRequisite, requiredCreationPolicy, metadata, origin);
		}

		/// <summary>Создает определение импорта для указанного параметра, используя заданные имя контракта, удостоверение типа, метаданные импорта, количество элементов и политику создания.</summary>
		/// <param name="parameter">Импортируемый параметр.</param>
		/// <param name="contractName">Имя контракта, используемого для импорта.</param>
		/// <param name="requiredTypeIdentity">Требуемое удостоверение типа для импорта.</param>
		/// <param name="requiredMetadata">Требуемые метаданные для импорта.</param>
		/// <param name="cardinality">Количество элементов импорта.</param>
		/// <param name="requiredCreationPolicy">Одно из значений перечисления, определяющее политику создания импорта.</param>
		/// <param name="origin">Объект, в который выполняется импорт.</param>
		/// <returns>Определение импорта, созданное на основе заданных параметров.</returns>
		// Token: 0x0600035B RID: 859 RVA: 0x0000A364 File Offset: 0x00008564
		public static ContractBasedImportDefinition CreateImportDefinition(Lazy<ParameterInfo> parameter, string contractName, string requiredTypeIdentity, IEnumerable<KeyValuePair<string, Type>> requiredMetadata, ImportCardinality cardinality, CreationPolicy requiredCreationPolicy, ICompositionElement origin)
		{
			return ReflectionModelServices.CreateImportDefinition(parameter, contractName, requiredTypeIdentity, requiredMetadata, cardinality, requiredCreationPolicy, MetadataServices.EmptyMetadata, false, origin);
		}

		/// <summary>Создает определение импорта для указанного параметра, используя заданные имя контракта, удостоверение типа, метаданные импорта и контракта, количество элементов и политику создания.</summary>
		/// <param name="parameter">Импортируемый параметр.</param>
		/// <param name="contractName">Имя контракта, используемого для импорта.</param>
		/// <param name="requiredTypeIdentity">Требуемое удостоверение типа для импорта.</param>
		/// <param name="requiredMetadata">Требуемые метаданные для импорта.</param>
		/// <param name="cardinality">Количество элементов импорта.</param>
		/// <param name="requiredCreationPolicy">Одно из значений перечисления, определяющее политику создания импорта.</param>
		/// <param name="metadata">Метаданные контракта</param>
		/// <param name="isExportFactory">Значение <see langword="true" /> для указания того, что импорт представляет объект <see cref="T:System.ComponentModel.Composition.ExportFactory`1" />; в противном случае — значение <see langword="false" />.</param>
		/// <param name="origin">Объект, в который выполняется импорт.</param>
		/// <returns>Определение импорта, созданное на основе заданных параметров.</returns>
		// Token: 0x0600035C RID: 860 RVA: 0x0000A388 File Offset: 0x00008588
		public static ContractBasedImportDefinition CreateImportDefinition(Lazy<ParameterInfo> parameter, string contractName, string requiredTypeIdentity, IEnumerable<KeyValuePair<string, Type>> requiredMetadata, ImportCardinality cardinality, CreationPolicy requiredCreationPolicy, IDictionary<string, object> metadata, bool isExportFactory, ICompositionElement origin)
		{
			Requires.NotNull<Lazy<ParameterInfo>>(parameter, "parameter");
			Requires.NotNullOrEmpty(contractName, "contractName");
			if (isExportFactory)
			{
				return new PartCreatorParameterImportDefinition(parameter, origin, new ContractBasedImportDefinition(contractName, requiredTypeIdentity, requiredMetadata, cardinality, false, true, CreationPolicy.NonShared, metadata));
			}
			return new ReflectionParameterImportDefinition(parameter, contractName, requiredTypeIdentity, requiredMetadata, cardinality, requiredCreationPolicy, metadata, origin);
		}

		/// <summary>Указывает, можно ли универсальный шаблон части специализировать предоставленными параметрами.</summary>
		/// <param name="partDefinition">Определение части.</param>
		/// <param name="genericParameters">Коллекция типов для задания универсальных параметров.</param>
		/// <param name="specialization">Когда выполнение этого метода завершается, содержит специальное определение части. Этот параметр обрабатывается как неинициализированный.</param>
		/// <returns>Значение <see langword="true" />, если сериализация прошла успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600035D RID: 861 RVA: 0x0000A3D8 File Offset: 0x000085D8
		public static bool TryMakeGenericPartDefinition(ComposablePartDefinition partDefinition, IEnumerable<Type> genericParameters, out ComposablePartDefinition specialization)
		{
			Requires.NotNull<ComposablePartDefinition>(partDefinition, "partDefinition");
			specialization = null;
			ReflectionComposablePartDefinition reflectionComposablePartDefinition = partDefinition as ReflectionComposablePartDefinition;
			if (reflectionComposablePartDefinition == null)
			{
				throw ExceptionBuilder.CreateReflectionModelInvalidPartDefinition("partDefinition", partDefinition.GetType());
			}
			return reflectionComposablePartDefinition.TryMakeGenericPartDefinition(genericParameters.ToArray<Type>(), out specialization);
		}
	}
}
