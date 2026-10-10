using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Primitives
{
	/// <summary>Представляет импорт, необходимый для объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />.</summary>
	// Token: 0x02000099 RID: 153
	public class ImportDefinition
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</summary>
		// Token: 0x060003F8 RID: 1016 RVA: 0x0000B4C3 File Offset: 0x000096C3
		protected ImportDefinition()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />, используя указанные ограничение, имя контракта и количество элементов, а также указывает, является ли определение импорта предварительным условием или разрешает рекомпозицию.</summary>
		/// <param name="constraint">Выражение, содержащее объект <see cref="T:System.Func`2" />, определяющий условия, которые должны удовлетворяться объектом <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> для соответствия определению импорта.</param>
		/// <param name="contractName">Имя контракта.</param>
		/// <param name="cardinality">Одно из значений перечисления, указывающее количество элементов объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, необходимых для определения импорта.</param>
		/// <param name="isRecomposable">Значение <see langword="true" />, указывающее, что определение импорта может удовлетворяться несколько раз на протяжении времени жизни объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isPrerequisite">Значение <see langword="true" />, указывающее, что определение импорта должно удовлетворяться, прежде чем объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> сможет начать создание экспортированных объектов; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="constraint" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="cardinality" /> не равно ни одному из значений объекта <see cref="T:System.ComponentModel.Composition.Primitives.ImportCardinality" />.</exception>
		// Token: 0x060003F9 RID: 1017 RVA: 0x0000B4EF File Offset: 0x000096EF
		public ImportDefinition(Expression<Func<ExportDefinition, bool>> constraint, string contractName, ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite) : this(contractName, cardinality, isRecomposable, isPrerequisite, MetadataServices.EmptyMetadata)
		{
			Requires.NotNull<Expression<Func<ExportDefinition, bool>>>(constraint, "constraint");
			this._constraint = constraint;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />, используя указанные ограничение, имя контракта, количество элементов и метаданные, а также указывает, является ли определение импорта предварительным условием или разрешает рекомпозицию.</summary>
		/// <param name="constraint">Выражение, содержащее объект <see cref="T:System.Func`2" />, определяющий условия, которые должны удовлетворяться объектом <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> для соответствия определению импорта.</param>
		/// <param name="contractName">Имя контракта.</param>
		/// <param name="cardinality">Одно из значений перечисления, указывающее количество элементов объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, необходимых для определения импорта.</param>
		/// <param name="isRecomposable">Значение <see langword="true" />, указывающее, что определение импорта может удовлетворяться несколько раз на протяжении времени жизни объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isPrerequisite">Значение <see langword="true" />, указывающее, что определение импорта должно удовлетворяться, прежде чем объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> сможет начать создание экспортированных объектов; в противном случае — значение <see langword="false" />.</param>
		/// <param name="metadata">Метаданные, связанные с импортом.</param>
		// Token: 0x060003FA RID: 1018 RVA: 0x0000B514 File Offset: 0x00009714
		public ImportDefinition(Expression<Func<ExportDefinition, bool>> constraint, string contractName, ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, IDictionary<string, object> metadata) : this(contractName, cardinality, isRecomposable, isPrerequisite, metadata)
		{
			Requires.NotNull<Expression<Func<ExportDefinition, bool>>>(constraint, "constraint");
			this._constraint = constraint;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000B538 File Offset: 0x00009738
		internal ImportDefinition(string contractName, ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, IDictionary<string, object> metadata)
		{
			if (cardinality != ImportCardinality.ExactlyOne && cardinality != ImportCardinality.ZeroOrMore && cardinality != ImportCardinality.ZeroOrOne)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.ArgumentOutOfRange_InvalidEnum, "cardinality", cardinality, typeof(ImportCardinality).Name), "cardinality");
			}
			this._contractName = (contractName ?? ImportDefinition.EmptyContractName);
			this._cardinality = cardinality;
			this._isRecomposable = isRecomposable;
			this._isPrerequisite = isPrerequisite;
			if (metadata != null)
			{
				this._metadata = metadata;
			}
		}

		/// <summary>Получает имя контракта.</summary>
		/// <returns>Имя контракта.</returns>
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000B5E0 File Offset: 0x000097E0
		public virtual string ContractName
		{
			get
			{
				return this._contractName;
			}
		}

		/// <summary>Получает метаданные, связанные с данным импортом.</summary>
		/// <returns>Коллекция, содержащая метаданные, связанные с этим импортом.</returns>
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000B5E8 File Offset: 0x000097E8
		public virtual IDictionary<string, object> Metadata
		{
			get
			{
				return this._metadata;
			}
		}

		/// <summary>Получает количество элементов экспортов, необходимых для определения импорта.</summary>
		/// <returns>Одно из значений перечисления, указывающее количество элементов объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, необходимых для объекта <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />. Значение по умолчанию: <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ExactlyOne" />.</returns>
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000B5F0 File Offset: 0x000097F0
		public virtual ImportCardinality Cardinality
		{
			get
			{
				return this._cardinality;
			}
		}

		/// <summary>Получает выражение, которое определяет условия, которые должны удовлетворяться импортом для соответствия определению импорта.</summary>
		/// <returns>Выражение, содержащее объект <see cref="T:System.Func`2" />, определяющий условия, которые должны удовлетворяться объектом <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> для соответствия объекту <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Свойство в производном классе не переопределено.</exception>
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000B5F8 File Offset: 0x000097F8
		public virtual Expression<Func<ExportDefinition, bool>> Constraint
		{
			get
			{
				if (this._constraint != null)
				{
					return this._constraint;
				}
				throw ExceptionBuilder.CreateNotOverriddenByDerived("Constraint");
			}
		}

		/// <summary>Получает значение, указывающее, должно ли удовлетворяться определение импорта, прежде чем часть сможет начать создание экспортированных объектов.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" /> должен удовлетворяться, прежде чем объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> сможет начать создание экспортированных объектов; в противном случае — значение <see langword="false" />. Значение по умолчанию: <see langword="true" />.</returns>
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000B613 File Offset: 0x00009813
		public virtual bool IsPrerequisite
		{
			get
			{
				return this._isPrerequisite;
			}
		}

		/// <summary>Получает значение, указывающее, может ли определение импорта удовлетворяться несколько раз.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" /> может удовлетворяться несколько раз на протяжении времени существования объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />; в противном случае — значение <see langword="false" />. Значение по умолчанию: <see langword="false" />.</returns>
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000B61B File Offset: 0x0000981B
		public virtual bool IsRecomposable
		{
			get
			{
				return this._isRecomposable;
			}
		}

		/// <summary>Получает значение, указывающее, удовлетворяет ли экспорт, представленный указанным определением, ограничениям данного определения импорта.</summary>
		/// <param name="exportDefinition">Проверяемое определение экспорта.</param>
		/// <returns>Значение <see langword="true" />, если ограничения удовлетворяются; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000402 RID: 1026 RVA: 0x0000B623 File Offset: 0x00009823
		public virtual bool IsConstraintSatisfiedBy(ExportDefinition exportDefinition)
		{
			Requires.NotNull<ExportDefinition>(exportDefinition, "exportDefinition");
			if (this._compiledConstraint == null)
			{
				this._compiledConstraint = this.Constraint.Compile();
			}
			return this._compiledConstraint(exportDefinition);
		}

		/// <summary>Возвращает строковое представление определения импорта.</summary>
		/// <returns>Строковое представление определения импорта.</returns>
		// Token: 0x06000403 RID: 1027 RVA: 0x0000B655 File Offset: 0x00009855
		public override string ToString()
		{
			return this.Constraint.Body.ToString();
		}

		// Token: 0x0400018D RID: 397
		internal static readonly string EmptyContractName = string.Empty;

		// Token: 0x0400018E RID: 398
		private readonly Expression<Func<ExportDefinition, bool>> _constraint;

		// Token: 0x0400018F RID: 399
		private readonly ImportCardinality _cardinality = ImportCardinality.ExactlyOne;

		// Token: 0x04000190 RID: 400
		private readonly string _contractName = ImportDefinition.EmptyContractName;

		// Token: 0x04000191 RID: 401
		private readonly bool _isRecomposable;

		// Token: 0x04000192 RID: 402
		private readonly bool _isPrerequisite = true;

		// Token: 0x04000193 RID: 403
		private Func<ExportDefinition, bool> _compiledConstraint;

		// Token: 0x04000194 RID: 404
		private readonly IDictionary<string, object> _metadata = MetadataServices.EmptyMetadata;
	}
}
