using System;
using System.Globalization;

namespace System.CodeDom.Compiler
{
	/// <summary>Представляет ошибку или предупреждение компилятора.</summary>
	// Token: 0x02000349 RID: 841
	[Serializable]
	public class CompilerError
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerError" />.</summary>
		// Token: 0x06001BAA RID: 7082 RVA: 0x00065FFC File Offset: 0x000641FC
		public CompilerError() : this(string.Empty, 0, 0, string.Empty, string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerError" />, используя указанное имя файла, строку, столбец, номер и текст ошибки.</summary>
		/// <param name="fileName">Имя файла, который обрабатывался компилятором во время обнаружения ошибки.</param>
		/// <param name="line">Номер строки источника ошибки.</param>
		/// <param name="column">Столбец источника ошибки.</param>
		/// <param name="errorNumber">Номер ошибки.</param>
		/// <param name="errorText">Текст сообщения об ошибке.</param>
		// Token: 0x06001BAB RID: 7083 RVA: 0x00066015 File Offset: 0x00064215
		public CompilerError(string fileName, int line, int column, string errorNumber, string errorText)
		{
			this.Line = line;
			this.Column = column;
			this.ErrorNumber = errorNumber;
			this.ErrorText = errorText;
			this.FileName = fileName;
		}

		/// <summary>Получает или задает номер строки, в которой находится источник ошибки.</summary>
		/// <returns>Номер строки исходного файла, в котором компилятор обнаружил ошибку.</returns>
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00066042 File Offset: 0x00064242
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0006604A File Offset: 0x0006424A
		public int Line { get; set; }

		/// <summary>Получает или задает номер столбца, в котором находится источник ошибки.</summary>
		/// <returns>Номер столбца исходного файла, в котором компилятор обнаружил ошибку.</returns>
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00066053 File Offset: 0x00064253
		// (set) Token: 0x06001BAF RID: 7087 RVA: 0x0006605B File Offset: 0x0006425B
		public int Column { get; set; }

		/// <summary>Получает или задает номер ошибки.</summary>
		/// <returns>Номер ошибки в виде строки.</returns>
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00066064 File Offset: 0x00064264
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x0006606C File Offset: 0x0006426C
		public string ErrorNumber { get; set; }

		/// <summary>Получает или задает текст сообщения об ошибке.</summary>
		/// <returns>Текст сообщения об ошибке.</returns>
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00066075 File Offset: 0x00064275
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0006607D File Offset: 0x0006427D
		public string ErrorText { get; set; }

		/// <summary>Получает или задает значение, указывающее, является ли ошибка предупреждением.</summary>
		/// <returns>
		///   <see langword="true" />, если ошибка является предупреждением; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00066086 File Offset: 0x00064286
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0006608E File Offset: 0x0006428E
		public bool IsWarning { get; set; }

		/// <summary>Получает или задает имя исходного файла, содержащего вызвавший ошибку код.</summary>
		/// <returns>Имя исходного файла, содержащего вызвавший ошибку код.</returns>
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00066097 File Offset: 0x00064297
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0006609F File Offset: 0x0006429F
		public string FileName { get; set; }

		/// <summary>Предоставляет реализацию метода <see cref="M:System.Object.ToString" /> класса Object.</summary>
		/// <returns>Строковое представление ошибки компилятора.</returns>
		// Token: 0x06001BB8 RID: 7096 RVA: 0x000660A8 File Offset: 0x000642A8
		public override string ToString()
		{
			if (this.FileName.Length <= 0)
			{
				return string.Format(CultureInfo.InvariantCulture, "{0} {1}: {2}", this.WarningString, this.ErrorNumber, this.ErrorText);
			}
			return string.Format(CultureInfo.InvariantCulture, "{0}({1},{2}) : {3} {4}: {5}", new object[]
			{
				this.FileName,
				this.Line,
				this.Column,
				this.WarningString,
				this.ErrorNumber,
				this.ErrorText
			});
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x0006613A File Offset: 0x0006433A
		private string WarningString
		{
			get
			{
				if (!this.IsWarning)
				{
					return "error";
				}
				return "warning";
			}
		}
	}
}
