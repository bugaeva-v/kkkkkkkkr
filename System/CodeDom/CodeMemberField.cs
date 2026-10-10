using System;

namespace System.CodeDom
{
	/// <summary>Представляет объявление для поля типа.</summary>
	// Token: 0x02000317 RID: 791
	[Serializable]
	public class CodeMemberField : CodeTypeMember
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMemberField" />.</summary>
		// Token: 0x0600191B RID: 6427 RVA: 0x0005FE51 File Offset: 0x0005E051
		public CodeMemberField()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMemberField" />, используя указанные тип и имя поля.</summary>
		/// <param name="type">Объект, указывающий тип поля.</param>
		/// <param name="name">Имя поля.</param>
		// Token: 0x0600191C RID: 6428 RVA: 0x0005FEC5 File Offset: 0x0005E0C5
		public CodeMemberField(CodeTypeReference type, string name)
		{
			this.Type = type;
			base.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMemberField" />, используя указанные тип и имя поля.</summary>
		/// <param name="type">Тип поля.</param>
		/// <param name="name">Имя поля.</param>
		// Token: 0x0600191D RID: 6429 RVA: 0x0005FEDB File Offset: 0x0005E0DB
		public CodeMemberField(string type, string name)
		{
			this.Type = new CodeTypeReference(type);
			base.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMemberField" />, используя указанные тип и имя поля.</summary>
		/// <param name="type">Тип поля.</param>
		/// <param name="name">Имя поля.</param>
		// Token: 0x0600191E RID: 6430 RVA: 0x0005FEF6 File Offset: 0x0005E0F6
		public CodeMemberField(Type type, string name)
		{
			this.Type = new CodeTypeReference(type);
			base.Name = name;
		}

		/// <summary>Получает или задает тип поля.</summary>
		/// <returns>Тип поля.</returns>
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x0005FF14 File Offset: 0x0005E114
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x0005FF3E File Offset: 0x0005E13E
		public CodeTypeReference Type
		{
			get
			{
				CodeTypeReference result;
				if ((result = this._type) == null)
				{
					result = (this._type = new CodeTypeReference(""));
				}
				return result;
			}
			set
			{
				this._type = value;
			}
		}

		/// <summary>Получает или задает выражение инициализации для поля.</summary>
		/// <returns>Выражение инициализации для поля.</returns>
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x0005FF47 File Offset: 0x0005E147
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0005FF4F File Offset: 0x0005E14F
		public CodeExpression InitExpression { get; set; }

		// Token: 0x04000D9B RID: 3483
		private CodeTypeReference _type;
	}
}
