using System;

namespace System.CodeDom
{
	/// <summary>Представляет компилируемый фрагмент исходного кода.</summary>
	// Token: 0x02000329 RID: 809
	[Serializable]
	public class CodeSnippetCompileUnit : CodeCompileUnit
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeSnippetCompileUnit" />.</summary>
		// Token: 0x060019BB RID: 6587 RVA: 0x00060CAB File Offset: 0x0005EEAB
		public CodeSnippetCompileUnit()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeSnippetCompileUnit" />.</summary>
		/// <param name="value">Фрагмент исходного кода для представления.</param>
		// Token: 0x060019BC RID: 6588 RVA: 0x00060CB3 File Offset: 0x0005EEB3
		public CodeSnippetCompileUnit(string value)
		{
			this.Value = value;
		}

		/// <summary>Получает или задает фрагмент исходного кода для представления.</summary>
		/// <returns>Фрагмент исходного кода.</returns>
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00060CC2 File Offset: 0x0005EEC2
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x00060CD3 File Offset: 0x0005EED3
		public string Value
		{
			get
			{
				return this._value ?? string.Empty;
			}
			set
			{
				this._value = value;
			}
		}

		/// <summary>Получает или задает строку и данные файла о расположении кода в документе исходного кода.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeLinePragma" />, указывающий позицию фрагмента кода.</returns>
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x00060CDC File Offset: 0x0005EEDC
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x00060CE4 File Offset: 0x0005EEE4
		public CodeLinePragma LinePragma { get; set; }

		// Token: 0x04000DD6 RID: 3542
		private string _value;
	}
}
