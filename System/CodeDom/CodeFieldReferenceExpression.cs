using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на поле.</summary>
	// Token: 0x02000310 RID: 784
	[Serializable]
	public class CodeFieldReferenceExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeFieldReferenceExpression" />.</summary>
		// Token: 0x060018F0 RID: 6384 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeFieldReferenceExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeFieldReferenceExpression" />, используя указанные конечный объект и имя поля.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий содержащий поле объект.</param>
		/// <param name="fieldName">Имя поля.</param>
		// Token: 0x060018F1 RID: 6385 RVA: 0x0005FC78 File Offset: 0x0005DE78
		public CodeFieldReferenceExpression(CodeExpression targetObject, string fieldName)
		{
			this.TargetObject = targetObject;
			this.FieldName = fieldName;
		}

		/// <summary>Получает или задает объект, содержащий поле для ссылки.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий объект, содержащий поле для ссылки.</returns>
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x0005FC8E File Offset: 0x0005DE8E
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x0005FC96 File Offset: 0x0005DE96
		public CodeExpression TargetObject { get; set; }

		/// <summary>Получает или задает имя поля для ссылки.</summary>
		/// <returns>Строка, содержащая имя поля.</returns>
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0005FC9F File Offset: 0x0005DE9F
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0005FCB0 File Offset: 0x0005DEB0
		public string FieldName
		{
			get
			{
				return this._fieldName ?? string.Empty;
			}
			set
			{
				this._fieldName = value;
			}
		}

		// Token: 0x04000D8B RID: 3467
		private string _fieldName;
	}
}
