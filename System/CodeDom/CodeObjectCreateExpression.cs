using System;

namespace System.CodeDom
{
	/// <summary>Представляет выражение, создающее новый экземпляр типа.</summary>
	// Token: 0x02000320 RID: 800
	[Serializable]
	public class CodeObjectCreateExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeObjectCreateExpression" />.</summary>
		// Token: 0x06001983 RID: 6531 RVA: 0x00060950 File Offset: 0x0005EB50
		public CodeObjectCreateExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeObjectCreateExpression" />, используя указанные тип и параметры.</summary>
		/// <param name="createType">
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных объекта для создания.</param>
		/// <param name="parameters">Массив объектов <see cref="T:System.CodeDom.CodeExpression" />, указывающий используемые для создания объекта параметры.</param>
		// Token: 0x06001984 RID: 6532 RVA: 0x00060963 File Offset: 0x0005EB63
		public CodeObjectCreateExpression(CodeTypeReference createType, params CodeExpression[] parameters)
		{
			this.CreateType = createType;
			this.Parameters.AddRange(parameters);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeObjectCreateExpression" />, используя указанные тип и параметры.</summary>
		/// <param name="createType">Имя типа данных создаваемого объекта.</param>
		/// <param name="parameters">Массив объектов <see cref="T:System.CodeDom.CodeExpression" />, указывающий используемые для создания объекта параметры.</param>
		// Token: 0x06001985 RID: 6533 RVA: 0x00060989 File Offset: 0x0005EB89
		public CodeObjectCreateExpression(string createType, params CodeExpression[] parameters)
		{
			this.CreateType = new CodeTypeReference(createType);
			this.Parameters.AddRange(parameters);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeObjectCreateExpression" />, используя указанные тип и параметры.</summary>
		/// <param name="createType">Тип данных создаваемого объекта.</param>
		/// <param name="parameters">Массив объектов <see cref="T:System.CodeDom.CodeExpression" />, указывающий используемые для создания объекта параметры.</param>
		// Token: 0x06001986 RID: 6534 RVA: 0x000609B4 File Offset: 0x0005EBB4
		public CodeObjectCreateExpression(Type createType, params CodeExpression[] parameters)
		{
			this.CreateType = new CodeTypeReference(createType);
			this.Parameters.AddRange(parameters);
		}

		/// <summary>Получает или задает тип данных создаваемого объекта.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" /> на тип данных создаваемого объекта.</returns>
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x000609E0 File Offset: 0x0005EBE0
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x00060A0A File Offset: 0x0005EC0A
		public CodeTypeReference CreateType
		{
			get
			{
				CodeTypeReference result;
				if ((result = this._createType) == null)
				{
					result = (this._createType = new CodeTypeReference(""));
				}
				return result;
			}
			set
			{
				this._createType = value;
			}
		}

		/// <summary>Получает или задает параметры для использования при создании объекта.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpressionCollection" /> указывает параметры для использования при создании объекта.</returns>
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x00060A13 File Offset: 0x0005EC13
		public CodeExpressionCollection Parameters { get; } = new CodeExpressionCollection();

		// Token: 0x04000DC5 RID: 3525
		private CodeTypeReference _createType;
	}
}
