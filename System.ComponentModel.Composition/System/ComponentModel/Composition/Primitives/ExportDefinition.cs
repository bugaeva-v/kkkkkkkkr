using System;
using System.Collections.Generic;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Primitives
{
	/// <summary>Описывает контракт, которому удовлетворяет определенный объект <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</summary>
	// Token: 0x02000094 RID: 148
	public class ExportDefinition
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />.</summary>
		// Token: 0x060003EC RID: 1004 RVA: 0x0000B385 File Offset: 0x00009585
		protected ExportDefinition()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" /> с помощью указанного имени контракта и метаданных.</summary>
		/// <param name="contractName">Имя контракта объекта <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />.</param>
		/// <param name="metadata">Метаданные объекта <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" /> или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Primitives.ExportDefinition.Metadata" /> пустой объект <see cref="T:System.Collections.Generic.IDictionary`2" />, доступный только для чтения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contractName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="contractName" /> является пустой строкой ("").</exception>
		// Token: 0x060003ED RID: 1005 RVA: 0x0000B398 File Offset: 0x00009598
		public ExportDefinition(string contractName, IDictionary<string, object> metadata)
		{
			Requires.NotNullOrEmpty(contractName, "contractName");
			this._contractName = contractName;
			if (metadata != null)
			{
				this._metadata = metadata.AsReadOnly();
			}
		}

		/// <summary>Получает имя контракта.</summary>
		/// <returns>Имя контракта объекта <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Свойство в производном классе не переопределено.</exception>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000B3CC File Offset: 0x000095CC
		public virtual string ContractName
		{
			get
			{
				if (this._contractName != null)
				{
					return this._contractName;
				}
				throw ExceptionBuilder.CreateNotOverriddenByDerived("ContractName");
			}
		}

		/// <summary>Получает метаданные контракта.</summary>
		/// <returns>Метаданные объекта <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />. Значением по умолчанию является пустой доступный только для чтения объект <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000B3E7 File Offset: 0x000095E7
		public virtual IDictionary<string, object> Metadata
		{
			get
			{
				return this._metadata;
			}
		}

		/// <summary>Возвращает строковое представление определения экспорта.</summary>
		/// <returns>Строковое представление определения экспорта.</returns>
		// Token: 0x060003F0 RID: 1008 RVA: 0x0000B3EF File Offset: 0x000095EF
		public override string ToString()
		{
			return this.ContractName;
		}

		// Token: 0x04000185 RID: 389
		private readonly IDictionary<string, object> _metadata = MetadataServices.EmptyMetadata;

		// Token: 0x04000186 RID: 390
		private readonly string _contractName;
	}
}
