using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор с меткой или отдельную метку.</summary>
	// Token: 0x02000314 RID: 788
	[Serializable]
	public class CodeLabeledStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeLabeledStatement" />.</summary>
		// Token: 0x06001908 RID: 6408 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeLabeledStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeLabeledStatement" />, используя указанное имя метки.</summary>
		/// <param name="label">Имя метки.</param>
		// Token: 0x06001909 RID: 6409 RVA: 0x0005FDC0 File Offset: 0x0005DFC0
		public CodeLabeledStatement(string label)
		{
			this._label = label;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeLabeledStatement" />, используя указанные имя метки и оператор.</summary>
		/// <param name="label">Имя метки.</param>
		/// <param name="statement">
		///   <see cref="T:System.CodeDom.CodeStatement" /> для связи с меткой.</param>
		// Token: 0x0600190A RID: 6410 RVA: 0x0005FDCF File Offset: 0x0005DFCF
		public CodeLabeledStatement(string label, CodeStatement statement)
		{
			this._label = label;
			this.Statement = statement;
		}

		/// <summary>Получает или задает имя метки.</summary>
		/// <returns>Имя метки.</returns>
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x0005FDE5 File Offset: 0x0005DFE5
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x0005FDF6 File Offset: 0x0005DFF6
		public string Label
		{
			get
			{
				return this._label ?? string.Empty;
			}
			set
			{
				this._label = value;
			}
		}

		/// <summary>Получает или задает необязательный соответствующий оператор.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatement" />, указывающий связанный с меткой оператор.</returns>
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x0005FDFF File Offset: 0x0005DFFF
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x0005FE07 File Offset: 0x0005E007
		public CodeStatement Statement { get; set; }

		// Token: 0x04000D94 RID: 3476
		private string _label;
	}
}
