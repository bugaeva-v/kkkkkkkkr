using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор, присоединяющий делегат обработчика событий к событию.</summary>
	// Token: 0x020002F3 RID: 755
	[Serializable]
	public class CodeAttachEventStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttachEventStatement" />.</summary>
		// Token: 0x06001827 RID: 6183 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeAttachEventStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttachEventStatement" />, используя указанное событие и делегат.</summary>
		/// <param name="eventRef">
		///   <see cref="T:System.CodeDom.CodeEventReferenceExpression" /> указывает событие, к которому следует присоединить обработчик событий.</param>
		/// <param name="listener">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает новый обработчик событий.</param>
		// Token: 0x06001828 RID: 6184 RVA: 0x0005F115 File Offset: 0x0005D315
		public CodeAttachEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener)
		{
			this._eventRef = eventRef;
			this.Listener = listener;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttachEventStatement" />, используя указанный объект, содержащий событие, имя события и делегат обработчика событий.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает содержащий событие объект.</param>
		/// <param name="eventName">Имя события, к которому следует присоединить обработчик событий.</param>
		/// <param name="listener">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает новый обработчик событий.</param>
		// Token: 0x06001829 RID: 6185 RVA: 0x0005F12B File Offset: 0x0005D32B
		public CodeAttachEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener) : this(new CodeEventReferenceExpression(targetObject, eventName), listener)
		{
		}

		/// <summary>Получает или задает событие, к которому следует присоединить делегат обработчика событий.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeEventReferenceExpression" /> указывает событие, к которому следует присоединить обработчик событий.</returns>
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x0005F13C File Offset: 0x0005D33C
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x0005F161 File Offset: 0x0005D361
		public CodeEventReferenceExpression Event
		{
			get
			{
				CodeEventReferenceExpression result;
				if ((result = this._eventRef) == null)
				{
					result = (this._eventRef = new CodeEventReferenceExpression());
				}
				return result;
			}
			set
			{
				this._eventRef = value;
			}
		}

		/// <summary>Получает или задает новый делегат обработчика событий, который следует присоединить к событию.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий новый присоединяемый обработчик событий.</returns>
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0005F16A File Offset: 0x0005D36A
		// (set) Token: 0x0600182D RID: 6189 RVA: 0x0005F172 File Offset: 0x0005D372
		public CodeExpression Listener { get; set; }

		// Token: 0x04000D4F RID: 3407
		private CodeEventReferenceExpression _eventRef;
	}
}
