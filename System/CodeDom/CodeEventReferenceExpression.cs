using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на событие.</summary>
	// Token: 0x0200030C RID: 780
	[Serializable]
	public class CodeEventReferenceExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeEventReferenceExpression" />.</summary>
		// Token: 0x060018D8 RID: 6360 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeEventReferenceExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeEventReferenceExpression" />, используя указанные конечный объект и имя события.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает содержащий событие объект.</param>
		/// <param name="eventName">Имя события для ссылки.</param>
		// Token: 0x060018D9 RID: 6361 RVA: 0x0005FB74 File Offset: 0x0005DD74
		public CodeEventReferenceExpression(CodeExpression targetObject, string eventName)
		{
			this.TargetObject = targetObject;
			this._eventName = eventName;
		}

		/// <summary>Получает или задает объект, содержащий событие.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает содержащий событие объект.</returns>
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0005FB8A File Offset: 0x0005DD8A
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x0005FB92 File Offset: 0x0005DD92
		public CodeExpression TargetObject { get; set; }

		/// <summary>Получает или задает имя события.</summary>
		/// <returns>Имя события.</returns>
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x0005FB9B File Offset: 0x0005DD9B
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public string EventName
		{
			get
			{
				return this._eventName ?? string.Empty;
			}
			set
			{
				this._eventName = value;
			}
		}

		// Token: 0x04000D88 RID: 3464
		private string _eventName;
	}
}
