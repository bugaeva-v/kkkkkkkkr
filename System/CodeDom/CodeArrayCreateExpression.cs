using System;

namespace System.CodeDom
{
	/// <summary>Представляет выражение, создающее массив.</summary>
	// Token: 0x020002F0 RID: 752
	[Serializable]
	public class CodeArrayCreateExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeArrayCreateExpression" />.</summary>
		// Token: 0x0600180B RID: 6155 RVA: 0x0005EEB9 File Offset: 0x0005D0B9
		public CodeArrayCreateExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные тип данных массива и выражения инициализации.</summary>
		/// <param name="createType">
		///   <see cref="T:System.CodeDom.CodeTypeReference" /> указывает тип данных создаваемого массива.</param>
		/// <param name="initializers">Массив выражений, используемых для инициализации массива.</param>
		// Token: 0x0600180C RID: 6156 RVA: 0x0005EECC File Offset: 0x0005D0CC
		public CodeArrayCreateExpression(CodeTypeReference createType, params CodeExpression[] initializers)
		{
			this._createType = createType;
			this._initializers.AddRange(initializers);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные имя типа данных массива и инициализаторы.</summary>
		/// <param name="createType">Имя типа данных создаваемого массива.</param>
		/// <param name="initializers">Массив выражений, используемых для инициализации массива.</param>
		// Token: 0x0600180D RID: 6157 RVA: 0x0005EEF2 File Offset: 0x0005D0F2
		public CodeArrayCreateExpression(string createType, params CodeExpression[] initializers)
		{
			this._createType = new CodeTypeReference(createType);
			this._initializers.AddRange(initializers);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные тип данных массива и инициализаторы.</summary>
		/// <param name="createType">Тип данных создаваемого массива.</param>
		/// <param name="initializers">Массив выражений, используемых для инициализации массива.</param>
		// Token: 0x0600180E RID: 6158 RVA: 0x0005EF1D File Offset: 0x0005D11D
		public CodeArrayCreateExpression(Type createType, params CodeExpression[] initializers)
		{
			this._createType = new CodeTypeReference(createType);
			this._initializers.AddRange(initializers);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные тип данных массива и число индексов для массива.</summary>
		/// <param name="createType">
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных создаваемого массива.</param>
		/// <param name="size">Число индексов создаваемого массива.</param>
		// Token: 0x0600180F RID: 6159 RVA: 0x0005EF48 File Offset: 0x0005D148
		public CodeArrayCreateExpression(CodeTypeReference createType, int size)
		{
			this._createType = createType;
			this.Size = size;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные имя типа данных массива и число индексов для массива.</summary>
		/// <param name="createType">Имя типа данных создаваемого массива.</param>
		/// <param name="size">Число индексов создаваемого массива.</param>
		// Token: 0x06001810 RID: 6160 RVA: 0x0005EF69 File Offset: 0x0005D169
		public CodeArrayCreateExpression(string createType, int size)
		{
			this._createType = new CodeTypeReference(createType);
			this.Size = size;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные тип данных массива и число индексов для массива.</summary>
		/// <param name="createType">Тип данных создаваемого массива.</param>
		/// <param name="size">Число индексов создаваемого массива.</param>
		// Token: 0x06001811 RID: 6161 RVA: 0x0005EF8F File Offset: 0x0005D18F
		public CodeArrayCreateExpression(Type createType, int size)
		{
			this._createType = new CodeTypeReference(createType);
			this.Size = size;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные тип данных массива и кодовое выражение, показывающее число индексов для массива.</summary>
		/// <param name="createType">
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных создаваемого массива.</param>
		/// <param name="size">Выражение, показывающее число индексов создаваемого массива.</param>
		// Token: 0x06001812 RID: 6162 RVA: 0x0005EFB5 File Offset: 0x0005D1B5
		public CodeArrayCreateExpression(CodeTypeReference createType, CodeExpression size)
		{
			this._createType = createType;
			this.SizeExpression = size;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные имя типа данных массива и кодовое выражение, показывающее число индексов для массива.</summary>
		/// <param name="createType">Имя типа данных создаваемого массива.</param>
		/// <param name="size">Выражение, показывающее число индексов создаваемого массива.</param>
		// Token: 0x06001813 RID: 6163 RVA: 0x0005EFD6 File Offset: 0x0005D1D6
		public CodeArrayCreateExpression(string createType, CodeExpression size)
		{
			this._createType = new CodeTypeReference(createType);
			this.SizeExpression = size;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, используя указанные тип данных массива и кодовое выражение, показывающее число индексов для массива.</summary>
		/// <param name="createType">Тип данных создаваемого массива.</param>
		/// <param name="size">Выражение, показывающее число индексов создаваемого массива.</param>
		// Token: 0x06001814 RID: 6164 RVA: 0x0005EFFC File Offset: 0x0005D1FC
		public CodeArrayCreateExpression(Type createType, CodeExpression size)
		{
			this._createType = new CodeTypeReference(createType);
			this.SizeExpression = size;
		}

		/// <summary>Возвращает или задает тип создаваемого массива.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип массива.</returns>
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x0005F024 File Offset: 0x0005D224
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0005F04E File Offset: 0x0005D24E
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

		/// <summary>Получает инициализаторы, которыми следует инициализировать массив.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpressionCollection" />, указывающий значения инициализации.</returns>
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x0005F057 File Offset: 0x0005D257
		public CodeExpressionCollection Initializers
		{
			get
			{
				return this._initializers;
			}
		}

		/// <summary>Возвращает или задает число индексов в массиве.</summary>
		/// <returns>Число индексов в массиве.</returns>
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0005F05F File Offset: 0x0005D25F
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x0005F067 File Offset: 0x0005D267
		public int Size { get; set; }

		/// <summary>Возвращает или задает выражение, указывающее размер массива.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий размер массива.</returns>
		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0005F070 File Offset: 0x0005D270
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x0005F078 File Offset: 0x0005D278
		public CodeExpression SizeExpression { get; set; }

		// Token: 0x04000D47 RID: 3399
		private readonly CodeExpressionCollection _initializers = new CodeExpressionCollection();

		// Token: 0x04000D48 RID: 3400
		private CodeTypeReference _createType;
	}
}
