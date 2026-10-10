using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на локальную переменную.</summary>
	// Token: 0x0200033D RID: 829
	[Serializable]
	public class CodeVariableReferenceExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableReferenceExpression" />.</summary>
		// Token: 0x06001A5B RID: 6747 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeVariableReferenceExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeVariableReferenceExpression" />, используя указанное имя локальной переменной.</summary>
		/// <param name="variableName">Имя локальной переменной для ссылки.</param>
		// Token: 0x06001A5C RID: 6748 RVA: 0x0006185F File Offset: 0x0005FA5F
		public CodeVariableReferenceExpression(string variableName)
		{
			this._variableName = variableName;
		}

		/// <summary>Получает или задает имя локальной переменной для ссылки.</summary>
		/// <returns>Имя локальной переменной для ссылки.</returns>
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x0006186E File Offset: 0x0005FA6E
		// (set) Token: 0x06001A5E RID: 6750 RVA: 0x0006187F File Offset: 0x0005FA7F
		public string VariableName
		{
			get
			{
				return this._variableName ?? string.Empty;
			}
			set
			{
				this._variableName = value;
			}
		}

		// Token: 0x04000E00 RID: 3584
		private string _variableName;
	}
}
