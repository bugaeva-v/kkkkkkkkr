using System;

namespace System.CodeDom
{
	/// <summary>Представляет параметр типа универсального типа или метода.</summary>
	// Token: 0x02000339 RID: 825
	[Serializable]
	public class CodeTypeParameter : CodeObject
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeParameter" />.</summary>
		// Token: 0x06001A32 RID: 6706 RVA: 0x0005F685 File Offset: 0x0005D885
		public CodeTypeParameter()
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeTypeParameter" /> с указанным именем параметра типа.</summary>
		/// <param name="name">Имя параметра типа.</param>
		// Token: 0x06001A33 RID: 6707 RVA: 0x000615AF File Offset: 0x0005F7AF
		public CodeTypeParameter(string name)
		{
			this._name = name;
		}

		/// <summary>Возвращает или задает имя типа параметра.</summary>
		/// <returns>Имя параметра типа. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000615BE File Offset: 0x0005F7BE
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x000615CF File Offset: 0x0005F7CF
		public string Name
		{
			get
			{
				return this._name ?? string.Empty;
			}
			set
			{
				this._name = value;
			}
		}

		/// <summary>Получает ограничения для параметра типа.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, содержащий ограничения для параметра типа.</returns>
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x000615D8 File Offset: 0x0005F7D8
		public CodeTypeReferenceCollection Constraints
		{
			get
			{
				CodeTypeReferenceCollection result;
				if ((result = this._constraints) == null)
				{
					result = (this._constraints = new CodeTypeReferenceCollection());
				}
				return result;
			}
		}

		/// <summary>Получает пользовательские атрибуты параметра типа.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, указывающий пользовательские атрибуты параметра типа. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00061600 File Offset: 0x0005F800
		public CodeAttributeDeclarationCollection CustomAttributes
		{
			get
			{
				CodeAttributeDeclarationCollection result;
				if ((result = this._customAttributes) == null)
				{
					result = (this._customAttributes = new CodeAttributeDeclarationCollection());
				}
				return result;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, имеет ли параметр типа ограничение конструктора.</summary>
		/// <returns>Значение <see langword="true" />, если параметр типа имеет ограничение конструктора; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00061625 File Offset: 0x0005F825
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x0006162D File Offset: 0x0005F82D
		public bool HasConstructorConstraint { get; set; }

		// Token: 0x04000DF8 RID: 3576
		private string _name;

		// Token: 0x04000DF9 RID: 3577
		private CodeAttributeDeclarationCollection _customAttributes;

		// Token: 0x04000DFA RID: 3578
		private CodeTypeReferenceCollection _constraints;
	}
}
