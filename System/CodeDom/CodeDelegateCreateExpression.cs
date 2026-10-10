using System;

namespace System.CodeDom
{
	/// <summary>Представляет создающее делегат выражение.</summary>
	// Token: 0x02000306 RID: 774
	[Serializable]
	public class CodeDelegateCreateExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDelegateCreateExpression" />.</summary>
		// Token: 0x060018B5 RID: 6325 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeDelegateCreateExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDelegateCreateExpression" />.</summary>
		/// <param name="delegateType">Значение <see cref="T:System.CodeDom.CodeTypeReference" />, указывающее тип данных делегата.</param>
		/// <param name="targetObject">Значение <see cref="T:System.CodeDom.CodeExpression" />, указывающее объект, содержащий метод обработчика событий.</param>
		/// <param name="methodName">Имя метода обработчика событий.</param>
		// Token: 0x060018B6 RID: 6326 RVA: 0x0005F9AB File Offset: 0x0005DBAB
		public CodeDelegateCreateExpression(CodeTypeReference delegateType, CodeExpression targetObject, string methodName)
		{
			this._delegateType = delegateType;
			this.TargetObject = targetObject;
			this._methodName = methodName;
		}

		/// <summary>Получает или задает тип данных делегата.</summary>
		/// <returns>Значение <see cref="T:System.CodeDom.CodeTypeReference" />, указывающее тип данных делегата.</returns>
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0005F9C8 File Offset: 0x0005DBC8
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x0005F9F2 File Offset: 0x0005DBF2
		public CodeTypeReference DelegateType
		{
			get
			{
				CodeTypeReference result;
				if ((result = this._delegateType) == null)
				{
					result = (this._delegateType = new CodeTypeReference(""));
				}
				return result;
			}
			set
			{
				this._delegateType = value;
			}
		}

		/// <summary>Получает или задает объект, содержащий метод обработчика событий.</summary>
		/// <returns>Значение <see cref="T:System.CodeDom.CodeExpression" />, указывающее объект, содержащий метод обработчика событий.</returns>
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0005F9FB File Offset: 0x0005DBFB
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x0005FA03 File Offset: 0x0005DC03
		public CodeExpression TargetObject { get; set; }

		/// <summary>Получает или задает имя метода обработчика событий.</summary>
		/// <returns>Имя метода обработчика событий.</returns>
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0005FA0C File Offset: 0x0005DC0C
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x0005FA1D File Offset: 0x0005DC1D
		public string MethodName
		{
			get
			{
				return this._methodName ?? string.Empty;
			}
			set
			{
				this._methodName = value;
			}
		}

		// Token: 0x04000D81 RID: 3457
		private CodeTypeReference _delegateType;

		// Token: 0x04000D82 RID: 3458
		private string _methodName;
	}
}
