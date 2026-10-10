using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.AttributedModel;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.ComponentModel.Composition.ReflectionModel;
using System.Linq;
using System.Reflection;
using Microsoft.Internal;

namespace System.ComponentModel.Composition
{
	/// <summary>Содержит вспомогательные методы для использования помеченной атрибутами модели программирования MEF с композицией.</summary>
	// Token: 0x0200001F RID: 31
	public static class AttributedModelServices
	{
		/// <summary>Получает объект представления метаданных из словаря или свободных метаданных.</summary>
		/// <param name="metadata">Коллекция свободных метаданных.</param>
		/// <typeparam name="TMetadataView">Тип получаемого объекта представления метаданных.</typeparam>
		/// <returns>Представление метаданных, содержащее заданные метаданные.</returns>
		// Token: 0x0600010E RID: 270 RVA: 0x00003F37 File Offset: 0x00002137
		public static TMetadataView GetMetadataView<TMetadataView>(IDictionary<string, object> metadata)
		{
			Requires.NotNull<IDictionary<string, object>>(metadata, "metadata");
			return MetadataViewProvider.GetMetadataView<TMetadataView>(metadata);
		}

		/// <summary>Создает часть с поддержкой композиции из указанного помеченного атрибутами объекта.</summary>
		/// <param name="attributedPart">Помеченный атрибутами объект.</param>
		/// <returns>Созданная часть.</returns>
		// Token: 0x0600010F RID: 271 RVA: 0x00003F4A File Offset: 0x0000214A
		public static ComposablePart CreatePart(object attributedPart)
		{
			Requires.NotNull<object>(attributedPart, "attributedPart");
			return AttributedModelDiscovery.CreatePart(attributedPart);
		}

		/// <summary>Создает часть с поддержкой композиции из заданного объекта, помеченного атрибутами, с помощью указанного контекста отражения.</summary>
		/// <param name="attributedPart">Помеченный атрибутами объект.</param>
		/// <param name="reflectionContext">Контекст отражения для части.</param>
		/// <returns>Созданная часть.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="reflectionContext" /> — <see langword="null" />.</exception>
		// Token: 0x06000110 RID: 272 RVA: 0x00003F5D File Offset: 0x0000215D
		public static ComposablePart CreatePart(object attributedPart, ReflectionContext reflectionContext)
		{
			Requires.NotNull<object>(attributedPart, "attributedPart");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			return AttributedModelDiscovery.CreatePart(attributedPart, reflectionContext);
		}

		/// <summary>Создает часть с поддержкой композиции из заданного объекта, помеченного атрибутами, с помощью указанного определения части.</summary>
		/// <param name="partDefinition">Определение новой части.</param>
		/// <param name="attributedPart">Помеченный атрибутами объект.</param>
		/// <returns>Созданная часть.</returns>
		// Token: 0x06000111 RID: 273 RVA: 0x00003F7C File Offset: 0x0000217C
		public static ComposablePart CreatePart(ComposablePartDefinition partDefinition, object attributedPart)
		{
			Requires.NotNull<ComposablePartDefinition>(partDefinition, "partDefinition");
			Requires.NotNull<object>(attributedPart, "attributedPart");
			ReflectionComposablePartDefinition reflectionComposablePartDefinition = partDefinition as ReflectionComposablePartDefinition;
			if (reflectionComposablePartDefinition == null)
			{
				throw ExceptionBuilder.CreateReflectionModelInvalidPartDefinition("partDefinition", partDefinition.GetType());
			}
			return AttributedModelDiscovery.CreatePart(reflectionComposablePartDefinition, attributedPart);
		}

		/// <summary>Создает определение части с указанным типом и источником.</summary>
		/// <param name="type">Тип определения.</param>
		/// <param name="origin">Источник определения.</param>
		/// <returns>Определение новой части.</returns>
		// Token: 0x06000112 RID: 274 RVA: 0x00003FB4 File Offset: 0x000021B4
		public static ComposablePartDefinition CreatePartDefinition(Type type, ICompositionElement origin)
		{
			Requires.NotNull<Type>(type, "type");
			return AttributedModelServices.CreatePartDefinition(type, origin, false);
		}

		/// <summary>Создает определение части с указанным типом и источником.</summary>
		/// <param name="type">Тип определения.</param>
		/// <param name="origin">Источник определения.</param>
		/// <param name="ensureIsDiscoverable">Значение, указывающее, должно ли быть обнаруживаемым новое определение.</param>
		/// <returns>Определение новой части.</returns>
		// Token: 0x06000113 RID: 275 RVA: 0x00003FC9 File Offset: 0x000021C9
		public static ComposablePartDefinition CreatePartDefinition(Type type, ICompositionElement origin, bool ensureIsDiscoverable)
		{
			Requires.NotNull<Type>(type, "type");
			if (ensureIsDiscoverable)
			{
				return AttributedModelDiscovery.CreatePartDefinitionIfDiscoverable(type, origin);
			}
			return AttributedModelDiscovery.CreatePartDefinition(type, null, false, origin);
		}

		/// <summary>Получает уникальный идентификатор заданного типа.</summary>
		/// <param name="type">Изучаемый тип.</param>
		/// <returns>Уникальный идентификатор типа.</returns>
		// Token: 0x06000114 RID: 276 RVA: 0x00003FEA File Offset: 0x000021EA
		public static string GetTypeIdentity(Type type)
		{
			Requires.NotNull<Type>(type, "type");
			return ContractNameServices.GetTypeIdentity(type);
		}

		/// <summary>Получает уникальный идентификатор заданного метода.</summary>
		/// <param name="method">Изучаемый метод.</param>
		/// <returns>Уникальный идентификатор метода.</returns>
		// Token: 0x06000115 RID: 277 RVA: 0x00003FFD File Offset: 0x000021FD
		public static string GetTypeIdentity(MethodInfo method)
		{
			Requires.NotNull<MethodInfo>(method, "method");
			return ContractNameServices.GetTypeIdentityFromMethod(method);
		}

		/// <summary>Получает каноническое имя контракта для заданного типа.</summary>
		/// <param name="type">Используемый тип.</param>
		/// <returns>Имя контракта, созданное на основе заданного типа.</returns>
		// Token: 0x06000116 RID: 278 RVA: 0x00004010 File Offset: 0x00002210
		public static string GetContractName(Type type)
		{
			Requires.NotNull<Type>(type, "type");
			return AttributedModelServices.GetTypeIdentity(type);
		}

		/// <summary>Создает часть из заданного значения и добавляет ее в указанный пакет.</summary>
		/// <param name="batch">Пакет, в который добавляется часть.</param>
		/// <param name="exportedValue">Добавляемое значение.</param>
		/// <typeparam name="T">Тип новой части.</typeparam>
		/// <returns>Новая часть.</returns>
		// Token: 0x06000117 RID: 279 RVA: 0x00004024 File Offset: 0x00002224
		public static ComposablePart AddExportedValue<T>(this CompositionBatch batch, T exportedValue)
		{
			Requires.NotNull<CompositionBatch>(batch, "batch");
			string contractName = AttributedModelServices.GetContractName(typeof(T));
			return batch.AddExportedValue(contractName, exportedValue);
		}

		/// <summary>Создает часть из заданного значения и выполняет ее композицию в указанном контейнере композиции.</summary>
		/// <param name="container">Контейнер композиции, в котором следует выполнить композицию.</param>
		/// <param name="exportedValue">Значение, для которого выполняется композиция.</param>
		/// <typeparam name="T">Тип новой части.</typeparam>
		// Token: 0x06000118 RID: 280 RVA: 0x00004054 File Offset: 0x00002254
		public static void ComposeExportedValue<T>(this CompositionContainer container, T exportedValue)
		{
			Requires.NotNull<CompositionContainer>(container, "container");
			CompositionBatch batch = new CompositionBatch();
			batch.AddExportedValue(exportedValue);
			container.Compose(batch);
		}

		/// <summary>Создает часть из заданного значения и добавляет ее в указанный пакет с указанным именем контракта.</summary>
		/// <param name="batch">Пакет, в который добавляется часть.</param>
		/// <param name="contractName">Имя контракта экспорта.</param>
		/// <param name="exportedValue">Добавляемое значение.</param>
		/// <typeparam name="T">Тип новой части.</typeparam>
		/// <returns>Новая часть.</returns>
		// Token: 0x06000119 RID: 281 RVA: 0x00004084 File Offset: 0x00002284
		public static ComposablePart AddExportedValue<T>(this CompositionBatch batch, string contractName, T exportedValue)
		{
			Requires.NotNull<CompositionBatch>(batch, "batch");
			string typeIdentity = AttributedModelServices.GetTypeIdentity(typeof(T));
			return batch.AddExport(new Export(contractName, new Dictionary<string, object>
			{
				{
					"ExportTypeIdentity",
					typeIdentity
				}
			}, () => exportedValue));
		}

		/// <summary>Создает часть из заданного объекта в рамках указанного имени контракта и выполняет ее композицию в указанном контейнере композиции.</summary>
		/// <param name="container">Контейнер композиции, в котором следует выполнить композицию.</param>
		/// <param name="contractName">Имя контракта, в рамках которого экспортируется часть.</param>
		/// <param name="exportedValue">Значение, для которого выполняется композиция.</param>
		/// <typeparam name="T">Тип новой части.</typeparam>
		// Token: 0x0600011A RID: 282 RVA: 0x000040E4 File Offset: 0x000022E4
		public static void ComposeExportedValue<T>(this CompositionContainer container, string contractName, T exportedValue)
		{
			Requires.NotNull<CompositionContainer>(container, "container");
			CompositionBatch batch = new CompositionBatch();
			batch.AddExportedValue(contractName, exportedValue);
			container.Compose(batch);
		}

		/// <summary>Создает часть с поддержкой композиции из заданного объекта, помеченного атрибутами, и добавляет ее в указанный пакет композиции.</summary>
		/// <param name="batch">Пакет, в который добавляется часть.</param>
		/// <param name="attributedPart">Добавляемый объект.</param>
		/// <returns>Новая часть.</returns>
		// Token: 0x0600011B RID: 283 RVA: 0x00004114 File Offset: 0x00002314
		public static ComposablePart AddPart(this CompositionBatch batch, object attributedPart)
		{
			Requires.NotNull<CompositionBatch>(batch, "batch");
			Requires.NotNull<object>(attributedPart, "attributedPart");
			ComposablePart composablePart = AttributedModelServices.CreatePart(attributedPart);
			batch.AddPart(composablePart);
			return composablePart;
		}

		/// <summary>Создает части с поддержкой композиции из массива помеченных атрибутами объектов и выполняет их композицию в указанном контейнере композиции.</summary>
		/// <param name="container">Контейнер композиции, в котором следует выполнить композицию.</param>
		/// <param name="attributedParts">Массив помеченных атрибутами объектов для композиции.</param>
		// Token: 0x0600011C RID: 284 RVA: 0x00004148 File Offset: 0x00002348
		public static void ComposeParts(this CompositionContainer container, params object[] attributedParts)
		{
			Requires.NotNull<CompositionContainer>(container, "container");
			Requires.NotNullOrNullElements<object>(attributedParts, "attributedParts");
			CompositionBatch batch = new CompositionBatch((from attributedPart in attributedParts
			select AttributedModelServices.CreatePart(attributedPart)).ToArray<ComposablePart>(), Enumerable.Empty<ComposablePart>());
			container.Compose(batch);
		}

		/// <summary>Выполняет композицию заданной части, используя указанную службу композиции, с выключенной рекомпозицией.</summary>
		/// <param name="compositionService">Используемая служба композиции.</param>
		/// <param name="attributedPart">Часть, для которой выполняется композиция.</param>
		/// <returns>Часть, для которой выполнена композиция.</returns>
		// Token: 0x0600011D RID: 285 RVA: 0x000041A8 File Offset: 0x000023A8
		public static ComposablePart SatisfyImportsOnce(this ICompositionService compositionService, object attributedPart)
		{
			Requires.NotNull<ICompositionService>(compositionService, "compositionService");
			Requires.NotNull<object>(attributedPart, "attributedPart");
			ComposablePart composablePart = AttributedModelServices.CreatePart(attributedPart);
			compositionService.SatisfyImportsOnce(composablePart);
			return composablePart;
		}

		/// <summary>Составляет заданную часть, используя указанную службу композиции, с выключенной рекомпозицией и используя заданный контекст отражения.</summary>
		/// <param name="compositionService">Используемая служба композиции.</param>
		/// <param name="attributedPart">Часть, для которой выполняется композиция.</param>
		/// <param name="reflectionContext">Контекст отражения для части.</param>
		/// <returns>Часть, для которой выполнена композиция.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="reflectionContext" /> — <see langword="null" />.</exception>
		// Token: 0x0600011E RID: 286 RVA: 0x000041DC File Offset: 0x000023DC
		public static ComposablePart SatisfyImportsOnce(this ICompositionService compositionService, object attributedPart, ReflectionContext reflectionContext)
		{
			Requires.NotNull<ICompositionService>(compositionService, "compositionService");
			Requires.NotNull<object>(attributedPart, "attributedPart");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			ComposablePart composablePart = AttributedModelServices.CreatePart(attributedPart, reflectionContext);
			compositionService.SatisfyImportsOnce(composablePart);
			return composablePart;
		}

		/// <summary>Возвращает значение, указывающее, содержит ли указанная часть экспорт, который соответствует заданному контракту.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="contractType">Тип контракта.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> содержит определение экспорта, соответствующее <paramref name="contractType" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600011F RID: 287 RVA: 0x0000421A File Offset: 0x0000241A
		public static bool Exports(this ComposablePartDefinition part, Type contractType)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			Requires.NotNull<Type>(contractType, "contractType");
			return part.Exports(AttributedModelServices.GetContractName(contractType));
		}

		/// <summary>Возвращает значение, указывающее, содержит ли указанная часть экспорт, который соответствует заданному контракту.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <typeparam name="T">Тип контракта.</typeparam>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> содержит определение экспорта типа <paramref name="T" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000120 RID: 288 RVA: 0x0000423E File Offset: 0x0000243E
		public static bool Exports<T>(this ComposablePartDefinition part)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			return part.Exports(typeof(T));
		}

		/// <summary>Возвращает значение, указывающее, содержит ли указанная часть импорт, который соответствует заданному контракту.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="contractType">Тип контракта.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> содержит определение импорта, соответствующее <paramref name="contractType" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000121 RID: 289 RVA: 0x0000425B File Offset: 0x0000245B
		public static bool Imports(this ComposablePartDefinition part, Type contractType)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			Requires.NotNull<Type>(contractType, "contractType");
			return part.Imports(AttributedModelServices.GetContractName(contractType));
		}

		/// <summary>Возвращает значение, указывающее, содержит ли указанная часть импорт, который соответствует заданному контракту.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <typeparam name="T">Тип контракта.</typeparam>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> содержит определение импорта типа <paramref name="T" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000122 RID: 290 RVA: 0x0000427F File Offset: 0x0000247F
		public static bool Imports<T>(this ComposablePartDefinition part)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			return part.Imports(typeof(T));
		}

		/// <summary>Возвращает значение, указывающее, содержит ли указанная часть импорт, который соответствует заданному контракту и количеству элементов импорта.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="contractType">Тип контракта.</param>
		/// <param name="importCardinality">Важное количество элементов.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> содержит определение импорта, соответствующее <paramref name="contractType" /> и <paramref name="importCardinality" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000123 RID: 291 RVA: 0x0000429C File Offset: 0x0000249C
		public static bool Imports(this ComposablePartDefinition part, Type contractType, ImportCardinality importCardinality)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			Requires.NotNull<Type>(contractType, "contractType");
			return part.Imports(AttributedModelServices.GetContractName(contractType), importCardinality);
		}

		/// <summary>Возвращает значение, указывающее, содержит ли указанная часть импорт, который соответствует заданному контракту и количеству элементов импорта.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="importCardinality">Важное количество элементов.</param>
		/// <typeparam name="T">Тип контракта.</typeparam>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> содержит определение импорта типа <paramref name="T" />, которое имеет указанное количество элементов импорта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000124 RID: 292 RVA: 0x000042C1 File Offset: 0x000024C1
		public static bool Imports<T>(this ComposablePartDefinition part, ImportCardinality importCardinality)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			return part.Imports(typeof(T), importCardinality);
		}
	}
}
