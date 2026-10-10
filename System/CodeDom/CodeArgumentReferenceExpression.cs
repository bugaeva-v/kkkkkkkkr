using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на значение аргумента, передаваемого методу.</summary>
	// Token: 0x020002EF RID: 751
	[Serializable]
	public class CodeArgumentReferenceExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeArgumentReferenceExpression" />.</summary>
		// Token: 0x06001807 RID: 6151 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeArgumentReferenceExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeArgumentReferenceExpression" />, используя указанное имя параметра.</summary>
		/// <param name="parameterName">Имя параметра для ссылки.</param>
		// Token: 0x06001808 RID: 6152 RVA: 0x0005EE90 File Offset: 0x0005D090
		public CodeArgumentReferenceExpression(string parameterName)
		{
			this._parameterName = parameterName;
		}

		/// <summary>Получает или задает имя параметра, на которое ссылается данное выражение.</summary>
		/// <returns>Имя параметра для ссылки.</returns>
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x0005EE9F File Offset: 0x0005D09F
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x0005EEB0 File Offset: 0x0005D0B0
		public string ParameterName
		{
			get
			{
				return this._parameterName ?? string.Empty;
			}
			set
			{
				this._parameterName = value;
			}
		}

		// Token: 0x04000D46 RID: 3398
		private string _parameterName;
	}
}
