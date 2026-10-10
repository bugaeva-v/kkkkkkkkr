using System;

namespace System.CodeDom
{
	/// <summary>Представляет объявление переменной.</summary>
	// Token: 0x0200033C RID: 828
	[Serializable]
	public class CodeVariableDeclarationStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" />.</summary>
		// Token: 0x06001A4E RID: 6734 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeVariableDeclarationStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" />, используя указанные имя и тип.</summary>
		/// <param name="type">
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных переменной.</param>
		/// <param name="name">Имя переменной.</param>
		// Token: 0x06001A4F RID: 6735 RVA: 0x00061753 File Offset: 0x0005F953
		public CodeVariableDeclarationStatement(CodeTypeReference type, string name)
		{
			this.Type = type;
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" />, используя указанное имя типа данных и имя переменной.</summary>
		/// <param name="type">Имя типа данных переменной.</param>
		/// <param name="name">Имя переменной.</param>
		// Token: 0x06001A50 RID: 6736 RVA: 0x00061769 File Offset: 0x0005F969
		public CodeVariableDeclarationStatement(string type, string name)
		{
			this.Type = new CodeTypeReference(type);
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" />, используя указанные тип данных и имя переменной.</summary>
		/// <param name="type">Тип данных для переменной.</param>
		/// <param name="name">Имя переменной.</param>
		// Token: 0x06001A51 RID: 6737 RVA: 0x00061784 File Offset: 0x0005F984
		public CodeVariableDeclarationStatement(Type type, string name)
		{
			this.Type = new CodeTypeReference(type);
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" />, используя указанные тип данных, имя переменной и выражение инициализации.</summary>
		/// <param name="type">
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип переменной.</param>
		/// <param name="name">Имя переменной.</param>
		/// <param name="initExpression">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение инициализации для переменной.</param>
		// Token: 0x06001A52 RID: 6738 RVA: 0x0006179F File Offset: 0x0005F99F
		public CodeVariableDeclarationStatement(CodeTypeReference type, string name, CodeExpression initExpression)
		{
			this.Type = type;
			this.Name = name;
			this.InitExpression = initExpression;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" />, используя указанные тип данных, имя переменной и выражение инициализации.</summary>
		/// <param name="type">Имя типа данных переменной.</param>
		/// <param name="name">Имя переменной.</param>
		/// <param name="initExpression">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение инициализации для переменной.</param>
		// Token: 0x06001A53 RID: 6739 RVA: 0x000617BC File Offset: 0x0005F9BC
		public CodeVariableDeclarationStatement(string type, string name, CodeExpression initExpression)
		{
			this.Type = new CodeTypeReference(type);
			this.Name = name;
			this.InitExpression = initExpression;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" />, используя указанные тип данных, имя переменной и выражение инициализации.</summary>
		/// <param name="type">Тип данных переменной.</param>
		/// <param name="name">Имя переменной.</param>
		/// <param name="initExpression">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение инициализации для переменной.</param>
		// Token: 0x06001A54 RID: 6740 RVA: 0x000617DE File Offset: 0x0005F9DE
		public CodeVariableDeclarationStatement(Type type, string name, CodeExpression initExpression)
		{
			this.Type = new CodeTypeReference(type);
			this.Name = name;
			this.InitExpression = initExpression;
		}

		/// <summary>Получает или задает выражение инициализации для переменной.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение инициализации для переменной.</returns>
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x00061800 File Offset: 0x0005FA00
		// (set) Token: 0x06001A56 RID: 6742 RVA: 0x00061808 File Offset: 0x0005FA08
		public CodeExpression InitExpression { get; set; }

		/// <summary>Получает или задает имя переменной.</summary>
		/// <returns>Имя переменной.</returns>
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00061811 File Offset: 0x0005FA11
		// (set) Token: 0x06001A58 RID: 6744 RVA: 0x00061822 File Offset: 0x0005FA22
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

		/// <summary>Получает или задает тип данных переменной.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных переменной.</returns>
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x0006182C File Offset: 0x0005FA2C
		// (set) Token: 0x06001A5A RID: 6746 RVA: 0x00061856 File Offset: 0x0005FA56
		public CodeTypeReference Type
		{
			get
			{
				CodeTypeReference result;
				if ((result = this._type) == null)
				{
					result = (this._type = new CodeTypeReference(""));
				}
				return result;
			}
			set
			{
				this._type = value;
			}
		}

		// Token: 0x04000DFD RID: 3581
		private CodeTypeReference _type;

		// Token: 0x04000DFE RID: 3582
		private string _name;
	}
}
