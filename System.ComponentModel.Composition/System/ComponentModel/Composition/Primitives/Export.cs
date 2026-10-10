using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Primitives
{
	/// <summary>Представляет экспорт, который является типом, состоящим из экспортированного объекта с отложенным созданием и метаданных, описывающих этот объект.</summary>
	// Token: 0x02000093 RID: 147
	public class Export
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</summary>
		// Token: 0x060003E3 RID: 995 RVA: 0x0000B284 File Offset: 0x00009484
		protected Export()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> с помощью указанного имени контракта и метода получения экспортированного значения.</summary>
		/// <param name="contractName">Имя контракта объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</param>
		/// <param name="exportedValueGetter">Метод, вызываемый для создания экспортированного объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" />. При этом создание объекта откладывается до вызова метода <see cref="P:System.ComponentModel.Composition.Primitives.Export.Value" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contractName" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="exportedObjectGetter" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="contractName" /> является пустой строкой ("").</exception>
		// Token: 0x060003E4 RID: 996 RVA: 0x0000B299 File Offset: 0x00009499
		public Export(string contractName, Func<object> exportedValueGetter) : this(new ExportDefinition(contractName, null), exportedValueGetter)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> с помощью указанного имени контракта, метаданных и метода получения экспортированного значения.</summary>
		/// <param name="contractName">Имя контракта объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</param>
		/// <param name="metadata">Метаданные объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Primitives.Export.Metadata" /> пустой объект <see cref="T:System.Collections.Generic.IDictionary`2" />, доступный только для чтения.</param>
		/// <param name="exportedValueGetter">Метод, вызываемый для создания экспортированного объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" />. При этом создание объекта откладывается до вызова метода <see cref="P:System.ComponentModel.Composition.Primitives.Export.Value" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contractName" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="exportedObjectGetter" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="contractName" /> является пустой строкой ("").</exception>
		// Token: 0x060003E5 RID: 997 RVA: 0x0000B2A9 File Offset: 0x000094A9
		public Export(string contractName, IDictionary<string, object> metadata, Func<object> exportedValueGetter) : this(new ExportDefinition(contractName, metadata), exportedValueGetter)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> заданными определением экспорта и методом получения экспортированного объекта.</summary>
		/// <param name="definition">Объект, описывающий контракт, которому удовлетворяет объект <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</param>
		/// <param name="exportedValueGetter">Метод, вызываемый для создания экспортированного объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" />. При этом создание объекта откладывается до вызова метода <see cref="P:System.ComponentModel.Composition.Primitives.Export.Value" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="definition" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="exportedObjectGetter" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060003E6 RID: 998 RVA: 0x0000B2B9 File Offset: 0x000094B9
		public Export(ExportDefinition definition, Func<object> exportedValueGetter)
		{
			Requires.NotNull<ExportDefinition>(definition, "definition");
			Requires.NotNull<Func<object>>(exportedValueGetter, "exportedValueGetter");
			this._definition = definition;
			this._exportedValueGetter = exportedValueGetter;
		}

		/// <summary>Получает определение, описывающее контракт, которому удовлетворяет экспорт.</summary>
		/// <returns>Определение, описывающее контракт, которому удовлетворяет объект <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Это свойство не переопределено в производном классе.</exception>
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000B2F2 File Offset: 0x000094F2
		public virtual ExportDefinition Definition
		{
			get
			{
				if (this._definition != null)
				{
					return this._definition;
				}
				throw ExceptionBuilder.CreateNotOverriddenByDerived("Definition");
			}
		}

		/// <summary>Получает метаданные для экспорта.</summary>
		/// <returns>Метаданные объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Свойство <see cref="P:System.ComponentModel.Composition.Primitives.Export.Definition" /> не переопределено в производном классе.</exception>
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000B30D File Offset: 0x0000950D
		public IDictionary<string, object> Metadata
		{
			get
			{
				return this.Definition.Metadata;
			}
		}

		/// <summary>Предоставляет объект, который представляет данный экспорт.</summary>
		/// <returns>Объект, который представляет данный экспорт.</returns>
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000B31C File Offset: 0x0000951C
		public object Value
		{
			get
			{
				if (this._exportedValue == Export._EmptyValue)
				{
					object exportedValueCore = this.GetExportedValueCore();
					Interlocked.CompareExchange(ref this._exportedValue, exportedValueCore, Export._EmptyValue);
				}
				return this._exportedValue;
			}
		}

		/// <summary>Возвращает экспортированный объект, который предоставляется экспортом.</summary>
		/// <returns>Экспортированный объект, который предоставляется экспортом.</returns>
		/// <exception cref="T:System.NotImplementedException">Метод <see cref="M:System.ComponentModel.Composition.Primitives.Export.GetExportedValueCore" /> не переопределен в производном классе.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionException">Произошла ошибка при композиции. <see cref="P:System.ComponentModel.Composition.CompositionException.Errors" /> будет содержать коллекцию произошедших ошибок.</exception>
		// Token: 0x060003EA RID: 1002 RVA: 0x0000B359 File Offset: 0x00009559
		protected virtual object GetExportedValueCore()
		{
			if (this._exportedValueGetter != null)
			{
				return this._exportedValueGetter();
			}
			throw ExceptionBuilder.CreateNotOverriddenByDerived("GetExportedValueCore");
		}

		// Token: 0x04000181 RID: 385
		private readonly ExportDefinition _definition;

		// Token: 0x04000182 RID: 386
		private readonly Func<object> _exportedValueGetter;

		// Token: 0x04000183 RID: 387
		private static readonly object _EmptyValue = new object();

		// Token: 0x04000184 RID: 388
		private volatile object _exportedValue = Export._EmptyValue;
	}
}
