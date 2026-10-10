using System;

namespace System.CodeDom
{
	/// <summary>Представляет директиву импорта пространства имен, указывающую пространство имен для использования.</summary>
	// Token: 0x0200031E RID: 798
	[Serializable]
	public class CodeNamespaceImport : CodeObject
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeNamespaceImport" />.</summary>
		// Token: 0x06001964 RID: 6500 RVA: 0x0005F685 File Offset: 0x0005D885
		public CodeNamespaceImport()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeNamespaceImport" />, используя указанное импортируемое пространство имен.</summary>
		/// <param name="nameSpace">Имя пространства имен для импорта.</param>
		// Token: 0x06001965 RID: 6501 RVA: 0x000606FC File Offset: 0x0005E8FC
		public CodeNamespaceImport(string nameSpace)
		{
			this.Namespace = nameSpace;
		}

		/// <summary>Получает или задает строку и файл, где происходит оператор.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeLinePragma" />, указывающий контекст оператора.</returns>
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0006070B File Offset: 0x0005E90B
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00060713 File Offset: 0x0005E913
		public CodeLinePragma LinePragma { get; set; }

		/// <summary>Получает или задает пространство имен для импорта.</summary>
		/// <returns>Имя пространства имен для импорта.</returns>
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0006071C File Offset: 0x0005E91C
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x0006072D File Offset: 0x0005E92D
		public string Namespace
		{
			get
			{
				return this._nameSpace ?? string.Empty;
			}
			set
			{
				this._nameSpace = value;
			}
		}

		// Token: 0x04000DC1 RID: 3521
		private string _nameSpace;
	}
}
