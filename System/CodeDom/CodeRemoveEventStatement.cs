using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор, удаляющий обработчик событий.</summary>
	// Token: 0x02000328 RID: 808
	[Serializable]
	public class CodeRemoveEventStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeRemoveEventStatement" />.</summary>
		// Token: 0x060019B4 RID: 6580 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeRemoveEventStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeRemoveEventStatement" /> с указанным событием и обработчиком событий.</summary>
		/// <param name="eventRef">
		///   <see cref="T:System.CodeDom.CodeEventReferenceExpression" /> указывает событие, от которого следует отделить обработчик событий.</param>
		/// <param name="listener">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает обработчик событий для удаления.</param>
		// Token: 0x060019B5 RID: 6581 RVA: 0x00060C3A File Offset: 0x0005EE3A
		public CodeRemoveEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener)
		{
			this._eventRef = eventRef;
			this.Listener = listener;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeRemoveEventStatement" />, используя указанные конечный объект, имя события и обработчик событий.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает содержащий событие объект.</param>
		/// <param name="eventName">Имя события.</param>
		/// <param name="listener">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает обработчик событий для удаления.</param>
		// Token: 0x060019B6 RID: 6582 RVA: 0x00060C50 File Offset: 0x0005EE50
		public CodeRemoveEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener)
		{
			this._eventRef = new CodeEventReferenceExpression(targetObject, eventName);
			this.Listener = listener;
		}

		/// <summary>Получает или задает событие, из которого следует удалить прослушиватель.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeEventReferenceExpression" /> указывает событие, из которого следует удалить прослушиватель.</returns>
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00060C6C File Offset: 0x0005EE6C
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x00060C91 File Offset: 0x0005EE91
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

		/// <summary>Получает или задает обработчик событий для удаления.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает обработчик событий для удаления.</returns>
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00060C9A File Offset: 0x0005EE9A
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x00060CA2 File Offset: 0x0005EEA2
		public CodeExpression Listener { get; set; }

		// Token: 0x04000DD4 RID: 3540
		private CodeEventReferenceExpression _eventRef;
	}
}
