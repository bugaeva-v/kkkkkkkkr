using System;

namespace System.CodeDom
{
	/// <summary>Представляет объявление атрибута.</summary>
	// Token: 0x020002F6 RID: 758
	[Serializable]
	public class CodeAttributeDeclaration
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeDeclaration" />.</summary>
		// Token: 0x06001842 RID: 6210 RVA: 0x0005F26C File Offset: 0x0005D46C
		public CodeAttributeDeclaration()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> с использованием указанного имени.</summary>
		/// <param name="name">Имя атрибута.</param>
		// Token: 0x06001843 RID: 6211 RVA: 0x0005F27F File Offset: 0x0005D47F
		public CodeAttributeDeclaration(string name)
		{
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, используя указанные имя и аргументы.</summary>
		/// <param name="name">Имя атрибута.</param>
		/// <param name="arguments">Массив типа <see cref="T:System.CodeDom.CodeAttributeArgument" />, содержащий аргументы для атрибута.</param>
		// Token: 0x06001844 RID: 6212 RVA: 0x0005F299 File Offset: 0x0005D499
		public CodeAttributeDeclaration(string name, params CodeAttributeArgument[] arguments)
		{
			this.Name = name;
			this.Arguments.AddRange(arguments);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, используя указанную ссылку типа кода.</summary>
		/// <param name="attributeType">Объект <see cref="T:System.CodeDom.CodeTypeReference" />, идентифицирующий атрибут.</param>
		// Token: 0x06001845 RID: 6213 RVA: 0x0005F2BF File Offset: 0x0005D4BF
		public CodeAttributeDeclaration(CodeTypeReference attributeType) : this(attributeType, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, используя указанную ссылку типа кода и аргументы.</summary>
		/// <param name="attributeType">Объект <see cref="T:System.CodeDom.CodeTypeReference" />, идентифицирующий атрибут.</param>
		/// <param name="arguments">Массив типа <see cref="T:System.CodeDom.CodeAttributeArgument" />, содержащий аргументы для атрибута.</param>
		// Token: 0x06001846 RID: 6214 RVA: 0x0005F2C9 File Offset: 0x0005D4C9
		public CodeAttributeDeclaration(CodeTypeReference attributeType, params CodeAttributeArgument[] arguments)
		{
			this._attributeType = attributeType;
			if (attributeType != null)
			{
				this._name = attributeType.BaseType;
			}
			if (arguments != null)
			{
				this.Arguments.AddRange(arguments);
			}
		}

		/// <summary>Получает или задает имя объявляемого атрибута.</summary>
		/// <returns>Имя атрибута.</returns>
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0005F301 File Offset: 0x0005D501
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x0005F312 File Offset: 0x0005D512
		public string Name
		{
			get
			{
				return this._name ?? string.Empty;
			}
			set
			{
				this._name = value;
				this._attributeType = new CodeTypeReference(this._name);
			}
		}

		/// <summary>Получает аргументы для атрибута.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" />, содержащий аргументы для атрибута.</returns>
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x0005F32C File Offset: 0x0005D52C
		public CodeAttributeArgumentCollection Arguments
		{
			get
			{
				return this._arguments;
			}
		}

		/// <summary>Получает ссылку типа кода для объявления атрибута кода.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeReference" />, идентифицирующий <see cref="T:System.CodeDom.CodeAttributeDeclaration" />.</returns>
		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x0005F334 File Offset: 0x0005D534
		public CodeTypeReference AttributeType
		{
			get
			{
				return this._attributeType;
			}
		}

		// Token: 0x04000D53 RID: 3411
		private string _name;

		// Token: 0x04000D54 RID: 3412
		private readonly CodeAttributeArgumentCollection _arguments = new CodeAttributeArgumentCollection();

		// Token: 0x04000D55 RID: 3413
		private CodeTypeReference _attributeType;
	}
}
