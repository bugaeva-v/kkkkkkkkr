using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на значение свойства.</summary>
	// Token: 0x02000324 RID: 804
	[Serializable]
	public class CodePropertyReferenceExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodePropertyReferenceExpression" />.</summary>
		// Token: 0x060019A7 RID: 6567 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodePropertyReferenceExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodePropertyReferenceExpression" />, используя указанные целевой объект и имя свойства.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает объект, содержащий свойство для ссылки.</param>
		/// <param name="propertyName">Имя свойства для ссылки.</param>
		// Token: 0x060019A8 RID: 6568 RVA: 0x00060BB8 File Offset: 0x0005EDB8
		public CodePropertyReferenceExpression(CodeExpression targetObject, string propertyName)
		{
			this.TargetObject = targetObject;
			this.PropertyName = propertyName;
		}

		/// <summary>Получает или задает объект, содержащий свойство для ссылки.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает объект, содержащий свойство для ссылки.</returns>
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x00060BCE File Offset: 0x0005EDCE
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x00060BD6 File Offset: 0x0005EDD6
		public CodeExpression TargetObject { get; set; }

		/// <summary>Получает или задает имя свойства для ссылки.</summary>
		/// <returns>Имя свойства для ссылки.</returns>
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x00060BDF File Offset: 0x0005EDDF
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x00060BF0 File Offset: 0x0005EDF0
		public string PropertyName
		{
			get
			{
				return this._propertyName ?? string.Empty;
			}
			set
			{
				this._propertyName = value;
			}
		}

		// Token: 0x04000DCC RID: 3532
		private string _propertyName;
	}
}
