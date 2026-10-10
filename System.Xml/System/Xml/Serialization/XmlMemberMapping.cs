using System;
using System.CodeDom.Compiler;
using Unity;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Сопоставляет сущность кода в методе службы веб-.NET Framework с элементом в сообщении языка описания веб-служб (WSDL).
	///       </summary>
	// Token: 0x020002D7 RID: 727
	public class XmlMemberMapping
	{
		// Token: 0x06001C14 RID: 7188 RVA: 0x0009E8B9 File Offset: 0x0009CAB9
		internal XmlMemberMapping(MemberMapping mapping)
		{
			this.mapping = mapping;
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0009E8C8 File Offset: 0x0009CAC8
		internal MemberMapping Mapping
		{
			get
			{
				return this.mapping;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x0009E8D0 File Offset: 0x0009CAD0
		internal Accessor Accessor
		{
			get
			{
				return this.mapping.Accessor;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, соответствует ли тип .NET Framework XML-элемента или атрибута любого типа.
		///       </summary>
		/// <returns>
		///         <see langword="true" />, если тип сопоставляется XML любого элемента или атрибута; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0009E8DD File Offset: 0x0009CADD
		public bool Any
		{
			get
			{
				return this.Accessor.Any;
			}
		}

		/// <summary>
		///         Возвращает неполное имя объявления элемента XML, применяемое к данному сопоставлению.
		///       </summary>
		/// <returns>
		///         Неполное имя объявления элемента XML, применяемое к данному сопоставлению.
		///       </returns>
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0009E8EA File Offset: 0x0009CAEA
		public string ElementName
		{
			get
			{
				return Accessor.UnescapeName(this.Accessor.Name);
			}
		}

		/// <summary>
		///         Возвращает имя элемента XML, как он отображается в документ описания службы.
		///       </summary>
		/// <returns>
		///         Имя элемента XML.
		///       </returns>
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0009E8FC File Offset: 0x0009CAFC
		public string XsdElementName
		{
			get
			{
				return this.Accessor.Name;
			}
		}

		/// <summary>
		///         Получает пространство имен XML, применяемое к данному сопоставлению.
		///       </summary>
		/// <returns>
		///         Пространство имен XML, применяемое к данному сопоставлению.
		///       </returns>
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0009E909 File Offset: 0x0009CB09
		public string Namespace
		{
			get
			{
				return this.Accessor.Namespace;
			}
		}

		/// <summary>
		///         Получает имя члена метода веб-службы, представленного данным сопоставлением.
		///       </summary>
		/// <returns>
		///         Имя члена метода веб-службы, представленного данным сопоставлением.
		///       </returns>
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0009E916 File Offset: 0x0009CB16
		public string MemberName
		{
			get
			{
				return this.mapping.Name;
			}
		}

		/// <summary>
		///         Возвращает имя типа, типа платформы .NET Framework для данного сопоставления.
		///       </summary>
		/// <returns>
		///         Имя типа для этого сопоставления типа платформы .NET Framework.
		///       </returns>
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0009E923 File Offset: 0x0009CB23
		public string TypeName
		{
			get
			{
				if (this.Accessor.Mapping == null)
				{
					return string.Empty;
				}
				return this.Accessor.Mapping.TypeName;
			}
		}

		/// <summary>
		///         Получает пространство имен типа платформы .NET Framework для данного сопоставления.
		///       </summary>
		/// <returns>
		///         Пространство имен типа платформы .NET Framework для данного сопоставления.
		///       </returns>
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0009E948 File Offset: 0x0009CB48
		public string TypeNamespace
		{
			get
			{
				if (this.Accessor.Mapping == null)
				{
					return null;
				}
				return this.Accessor.Mapping.Namespace;
			}
		}

		/// <summary>
		///         Возвращает полное имя типа платформы .NET Framework для данного сопоставления.
		///       </summary>
		/// <returns>
		///         Полное имя типа имя типа платформы .NET Framework для данного сопоставления.
		///       </returns>
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0009E969 File Offset: 0x0009CB69
		public string TypeFullName
		{
			get
			{
				return this.mapping.TypeDesc.FullName;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, имеет ли сопроводительного поля в тип .NET Framework указанное значение.
		///       </summary>
		/// <returns>
		///         <see langword="true" />, если для сопроводительного поля указано значение; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0009E97B File Offset: 0x0009CB7B
		public bool CheckSpecified
		{
			get
			{
				return this.mapping.CheckSpecified > SpecifiedAccessor.None;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x0009E98B File Offset: 0x0009CB8B
		internal bool IsNullable
		{
			get
			{
				return this.mapping.IsNeedNullable;
			}
		}

		/// <summary>
		///         Возвращает имя типа, связанный с заданным <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />.
		///       </summary>
		/// <param name="codeProvider">
		///           Объект <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />  содержащий имя типа.
		///         </param>
		/// <returns>
		///         Имя типа.
		///       </returns>
		// Token: 0x06001C21 RID: 7201 RVA: 0x0009E998 File Offset: 0x0009CB98
		public string GenerateTypeName(CodeDomProvider codeProvider)
		{
			return this.mapping.GetTypeName(codeProvider);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00067344 File Offset: 0x00065544
		internal XmlMemberMapping()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001A00 RID: 6656
		private MemberMapping mapping;
	}
}
