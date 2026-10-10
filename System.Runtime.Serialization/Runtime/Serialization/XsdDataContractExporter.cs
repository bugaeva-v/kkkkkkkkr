using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization.Diagnostics;
using System.Xml;
using System.Xml.Schema;

namespace System.Runtime.Serialization
{
	/// <summary>Предоставляет возможность преобразования набора типов .NET Framework, используемых в контрактах данных, в файл схемы XML (XSD).</summary>
	// Token: 0x02000153 RID: 339
	public class XsdDataContractExporter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.XsdDataContractExporter" />.</summary>
		// Token: 0x06001207 RID: 4615 RVA: 0x0000222F File Offset: 0x0000042F
		public XsdDataContractExporter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.XsdDataContractExporter" /> с указанным набором схем.</summary>
		/// <param name="schemas">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />, содержащий экспортируемые схемы.</param>
		// Token: 0x06001208 RID: 4616 RVA: 0x00045FC6 File Offset: 0x000441C6
		public XsdDataContractExporter(XmlSchemaSet schemas)
		{
			this.schemas = schemas;
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Runtime.Serialization.ExportOptions" />, содержащий параметры, которые могут быть заданы для операции экспорта.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Serialization.ExportOptions" />, содержащий параметры, используемые для настройки экспорта типов в схемы.</returns>
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00045FD5 File Offset: 0x000441D5
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x00045FDD File Offset: 0x000441DD
		public ExportOptions Options
		{
			get
			{
				return this.options;
			}
			set
			{
				this.options = value;
			}
		}

		/// <summary>Возвращает коллекцию экспортированных схем XML.</summary>
		/// <returns>Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />, содержащий схемы, преобразованные из набора типов среды CLR после вызова метода <see cref="Overload:System.Runtime.Serialization.XsdDataContractExporter.Export" />.</returns>
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00045FE6 File Offset: 0x000441E6
		public XmlSchemaSet Schemas
		{
			get
			{
				XmlSchemaSet schemaSet = this.GetSchemaSet();
				SchemaImporter.CompileSchemaSet(schemaSet);
				return schemaSet;
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00045FF4 File Offset: 0x000441F4
		private XmlSchemaSet GetSchemaSet()
		{
			if (this.schemas == null)
			{
				this.schemas = new XmlSchemaSet();
				this.schemas.XmlResolver = null;
			}
			return this.schemas;
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0004601B File Offset: 0x0004421B
		private DataContractSet DataContractSet
		{
			get
			{
				if (this.dataContractSet == null)
				{
					this.dataContractSet = new DataContractSet((this.Options == null) ? null : this.Options.GetSurrogate());
				}
				return this.dataContractSet;
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0004604C File Offset: 0x0004424C
		private void TraceExportBegin()
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				TraceUtility.Trace(TraceEventType.Information, 196616, SR.GetString("XSD export begins"));
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0004606A File Offset: 0x0004426A
		private void TraceExportEnd()
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				TraceUtility.Trace(TraceEventType.Information, 196617, SR.GetString("XSD export ends"));
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00046088 File Offset: 0x00044288
		private void TraceExportError(Exception exception)
		{
			if (DiagnosticUtility.ShouldTraceError)
			{
				TraceUtility.Trace(TraceEventType.Error, 196620, SR.GetString("XSD export error"), null, exception);
			}
		}

		/// <summary>Преобразует типы, содержащиеся в указанной коллекции сборок.</summary>
		/// <param name="assemblies">Объект <see cref="T:System.Collections.Generic.ICollection`1" /> (класса <see cref="T:System.Reflection.Assembly" />), содержащий экспортируемые типы.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="assemblies" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="T:System.Reflection.Assembly" /> в коллекции имеет значение <see langword="null" />.</exception>
		// Token: 0x06001211 RID: 4625 RVA: 0x000460A8 File Offset: 0x000442A8
		public void Export(ICollection<Assembly> assemblies)
		{
			if (assemblies == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("assemblies"));
			}
			this.TraceExportBegin();
			DataContractSet dataContractSet = (this.dataContractSet == null) ? null : new DataContractSet(this.dataContractSet);
			try
			{
				foreach (Assembly assembly in assemblies)
				{
					if (assembly == null)
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(SR.GetString("Cannot export null assembly.", new object[]
						{
							"assemblies"
						})));
					}
					Type[] types = assembly.GetTypes();
					for (int i = 0; i < types.Length; i++)
					{
						this.CheckAndAddType(types[i]);
					}
				}
				this.Export();
			}
			catch (Exception exception)
			{
				if (Fx.IsFatal(exception))
				{
					throw;
				}
				this.dataContractSet = dataContractSet;
				this.TraceExportError(exception);
				throw;
			}
			this.TraceExportEnd();
		}

		/// <summary>Преобразует типы, содержащиеся в <see cref="T:System.Collections.Generic.ICollection`1" />, переданной в этот метод.</summary>
		/// <param name="types">Коллекция <see cref="T:System.Collections.Generic.ICollection`1" /> (сборок <see cref="T:System.Type" />), содержащая экспортируемые типы.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип в коллекции имеет значение <see langword="null" />.</exception>
		// Token: 0x06001212 RID: 4626 RVA: 0x000461A0 File Offset: 0x000443A0
		public void Export(ICollection<Type> types)
		{
			if (types == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("types"));
			}
			this.TraceExportBegin();
			DataContractSet dataContractSet = (this.dataContractSet == null) ? null : new DataContractSet(this.dataContractSet);
			try
			{
				foreach (Type type in types)
				{
					if (type == null)
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(SR.GetString("Cannot export null type.", new object[]
						{
							"types"
						})));
					}
					this.AddType(type);
				}
				this.Export();
			}
			catch (Exception exception)
			{
				if (Fx.IsFatal(exception))
				{
					throw;
				}
				this.dataContractSet = dataContractSet;
				this.TraceExportError(exception);
				throw;
			}
			this.TraceExportEnd();
		}

		/// <summary>Преобразует указанный тип .NET Framework в схему языка определения схемы XML (XSD).</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, преобразуемый в схему XML.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001213 RID: 4627 RVA: 0x0004627C File Offset: 0x0004447C
		public void Export(Type type)
		{
			if (type == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("type"));
			}
			this.TraceExportBegin();
			DataContractSet dataContractSet = (this.dataContractSet == null) ? null : new DataContractSet(this.dataContractSet);
			try
			{
				this.AddType(type);
				this.Export();
			}
			catch (Exception exception)
			{
				if (Fx.IsFatal(exception))
				{
					throw;
				}
				this.dataContractSet = dataContractSet;
				this.TraceExportError(exception);
				throw;
			}
			this.TraceExportEnd();
		}

		/// <summary>Возвращает имя контракта и пространство имен контракта для типа <see cref="T:System.Type" />.</summary>
		/// <param name="type">Экспортированный тип <see cref="T:System.Type" />.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlQualifiedName" />, представляющий имя контракта и пространство имен типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001214 RID: 4628 RVA: 0x00046300 File Offset: 0x00044500
		public XmlQualifiedName GetSchemaTypeName(Type type)
		{
			if (type == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("type"));
			}
			type = this.GetSurrogatedType(type);
			DataContract dataContract = DataContract.GetDataContract(type);
			DataContractSet.EnsureTypeNotGeneric(dataContract.UnderlyingType);
			XmlDataContract xmlDataContract = dataContract as XmlDataContract;
			if (xmlDataContract != null && xmlDataContract.IsAnonymous)
			{
				return XmlQualifiedName.Empty;
			}
			return dataContract.StableName;
		}

		/// <summary>Возвращает схему XML для заданного типа.</summary>
		/// <param name="type">Тип, для которого возвращается схема.</param>
		/// <returns>Объект <see cref="T:System.Xml.Schema.XmlSchemaType" />, содержащий схему XML.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001215 RID: 4629 RVA: 0x00046360 File Offset: 0x00044560
		public XmlSchemaType GetSchemaType(Type type)
		{
			if (type == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("type"));
			}
			type = this.GetSurrogatedType(type);
			DataContract dataContract = DataContract.GetDataContract(type);
			DataContractSet.EnsureTypeNotGeneric(dataContract.UnderlyingType);
			XmlDataContract xmlDataContract = dataContract as XmlDataContract;
			if (xmlDataContract != null && xmlDataContract.IsAnonymous)
			{
				return xmlDataContract.XsdType;
			}
			return null;
		}

		/// <summary>Возвращает имя верхнего уровня и пространство имен для типа <see cref="T:System.Type" />.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, которому направляется запрос.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlQualifiedName" />, представляющий имя верхнего уровня и пространство имен для типа <see cref="T:System.Type" />, который записывается в поток при записи этого объекта.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001216 RID: 4630 RVA: 0x000463BC File Offset: 0x000445BC
		public XmlQualifiedName GetRootElementName(Type type)
		{
			if (type == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("type"));
			}
			type = this.GetSurrogatedType(type);
			DataContract dataContract = DataContract.GetDataContract(type);
			DataContractSet.EnsureTypeNotGeneric(dataContract.UnderlyingType);
			if (dataContract.HasRoot)
			{
				return new XmlQualifiedName(dataContract.TopLevelElementName.Value, dataContract.TopLevelElementNamespace.Value);
			}
			return null;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00046424 File Offset: 0x00044624
		private Type GetSurrogatedType(Type type)
		{
			IDataContractSurrogate surrogate;
			if (this.options != null && (surrogate = this.Options.GetSurrogate()) != null)
			{
				type = DataContractSurrogateCaller.GetDataContractType(surrogate, type);
			}
			return type;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00046452 File Offset: 0x00044652
		private void CheckAndAddType(Type type)
		{
			type = this.GetSurrogatedType(type);
			if (!type.ContainsGenericParameters && DataContract.IsTypeSerializable(type))
			{
				this.AddType(type);
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00046474 File Offset: 0x00044674
		private void AddType(Type type)
		{
			this.DataContractSet.Add(type);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00046482 File Offset: 0x00044682
		private void Export()
		{
			this.AddKnownTypes();
			new SchemaExporter(this.GetSchemaSet(), this.DataContractSet).Export();
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000464A0 File Offset: 0x000446A0
		private void AddKnownTypes()
		{
			if (this.Options != null)
			{
				Collection<Type> knownTypes = this.Options.KnownTypes;
				if (knownTypes != null)
				{
					for (int i = 0; i < knownTypes.Count; i++)
					{
						Type type = knownTypes[i];
						if (type == null)
						{
							throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(SR.GetString("Cannot export null known type.")));
						}
						this.AddType(type);
					}
				}
			}
		}

		/// <summary>Возвращает значение, указывающее, возможен ли экспорт набора типов среды CLR, содержащегося в наборе сборок.</summary>
		/// <param name="assemblies">Объект <see cref="T:System.Collections.Generic.ICollection`1" /> класса <see cref="T:System.Reflection.Assembly" />, содержащий сборки с экспортируемыми типами.</param>
		/// <returns>Значение <see langword="true" />, если типы можно экспортировать; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600121C RID: 4636 RVA: 0x00046504 File Offset: 0x00044704
		public bool CanExport(ICollection<Assembly> assemblies)
		{
			if (assemblies == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("assemblies"));
			}
			DataContractSet dataContractSet = (this.dataContractSet == null) ? null : new DataContractSet(this.dataContractSet);
			bool result;
			try
			{
				foreach (Assembly assembly in assemblies)
				{
					if (assembly == null)
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(SR.GetString("Cannot export null assembly.", new object[]
						{
							"assemblies"
						})));
					}
					Type[] types = assembly.GetTypes();
					for (int i = 0; i < types.Length; i++)
					{
						this.CheckAndAddType(types[i]);
					}
				}
				this.AddKnownTypes();
				result = true;
			}
			catch (InvalidDataContractException)
			{
				this.dataContractSet = dataContractSet;
				result = false;
			}
			catch (Exception exception)
			{
				if (Fx.IsFatal(exception))
				{
					throw;
				}
				this.dataContractSet = dataContractSet;
				this.TraceExportError(exception);
				throw;
			}
			return result;
		}

		/// <summary>Возвращает значение, указывающее, возможен ли экспорт набора типов среды CLR, содержащегося в <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <param name="types">Объект <see cref="T:System.Collections.Generic.ICollection`1" />, содержащий указанные экспортируемые типы.</param>
		/// <returns>Значение <see langword="true" />, если типы можно экспортировать; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600121D RID: 4637 RVA: 0x00046610 File Offset: 0x00044810
		public bool CanExport(ICollection<Type> types)
		{
			if (types == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("types"));
			}
			DataContractSet dataContractSet = (this.dataContractSet == null) ? null : new DataContractSet(this.dataContractSet);
			bool result;
			try
			{
				foreach (Type type in types)
				{
					if (type == null)
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(SR.GetString("Cannot export null type.", new object[]
						{
							"types"
						})));
					}
					this.AddType(type);
				}
				this.AddKnownTypes();
				result = true;
			}
			catch (InvalidDataContractException)
			{
				this.dataContractSet = dataContractSet;
				result = false;
			}
			catch (Exception exception)
			{
				if (Fx.IsFatal(exception))
				{
					throw;
				}
				this.dataContractSet = dataContractSet;
				this.TraceExportError(exception);
				throw;
			}
			return result;
		}

		/// <summary>Возвращает значение, указывающее, возможен ли экспорт заданного типа среды CLR.</summary>
		/// <param name="type">Экспортируемый тип <see cref="T:System.Type" />.</param>
		/// <returns>Значение <see langword="true" />, если тип можно экспортировать; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600121E RID: 4638 RVA: 0x000466FC File Offset: 0x000448FC
		public bool CanExport(Type type)
		{
			if (type == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("type"));
			}
			DataContractSet dataContractSet = (this.dataContractSet == null) ? null : new DataContractSet(this.dataContractSet);
			bool result;
			try
			{
				this.AddType(type);
				this.AddKnownTypes();
				result = true;
			}
			catch (InvalidDataContractException)
			{
				this.dataContractSet = dataContractSet;
				result = false;
			}
			catch (Exception exception)
			{
				if (Fx.IsFatal(exception))
				{
					throw;
				}
				this.dataContractSet = dataContractSet;
				this.TraceExportError(exception);
				throw;
			}
			return result;
		}

		// Token: 0x04000738 RID: 1848
		private ExportOptions options;

		// Token: 0x04000739 RID: 1849
		private XmlSchemaSet schemas;

		// Token: 0x0400073A RID: 1850
		private DataContractSet dataContractSet;
	}
}
