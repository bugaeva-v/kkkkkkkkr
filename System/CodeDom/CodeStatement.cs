using System;

namespace System.CodeDom
{
	/// <summary>Представляет базовый класс <see langword="abstract" />, от которого наследуются все операторы кода.</summary>
	// Token: 0x0200032D RID: 813
	[Serializable]
	public class CodeStatement : CodeObject
	{
		/// <summary>Получает или задает строку, в которой содержится оператор кода.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeLinePragma" />, указывающий контекст оператора кода.</returns>
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00060D68 File Offset: 0x0005EF68
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x00060D70 File Offset: 0x0005EF70
		public CodeLinePragma LinePragma { get; set; }

		/// <summary>Получает объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий начальные директивы.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий начальные директивы.</returns>
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00060D7C File Offset: 0x0005EF7C
		public CodeDirectiveCollection StartDirectives
		{
			get
			{
				CodeDirectiveCollection result;
				if ((result = this._startDirectives) == null)
				{
					result = (this._startDirectives = new CodeDirectiveCollection());
				}
				return result;
			}
		}

		/// <summary>Получает объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий конечные директивы.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий конечные директивы.</returns>
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00060DA4 File Offset: 0x0005EFA4
		public CodeDirectiveCollection EndDirectives
		{
			get
			{
				CodeDirectiveCollection result;
				if ((result = this._endDirectives) == null)
				{
					result = (this._endDirectives = new CodeDirectiveCollection());
				}
				return result;
			}
		}

		// Token: 0x04000DDB RID: 3547
		private CodeDirectiveCollection _startDirectives;

		// Token: 0x04000DDC RID: 3548
		private CodeDirectiveCollection _endDirectives;
	}
}
