using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на значение по умолчанию.</summary>
	// Token: 0x02000305 RID: 773
	[Serializable]
	public class CodeDefaultValueExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDefaultValueExpression" />.</summary>
		// Token: 0x060018B1 RID: 6321 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeDefaultValueExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDefaultValueExpression" />, используя указанную ссылку типа кода.</summary>
		/// <param name="type">Свойство <see cref="T:System.CodeDom.CodeTypeReference" />, указывающее тип значения для ссылки.</param>
		// Token: 0x060018B2 RID: 6322 RVA: 0x0005F967 File Offset: 0x0005DB67
		public CodeDefaultValueExpression(CodeTypeReference type)
		{
			this._type = type;
		}

		/// <summary>Получает или задает ссылку типа данных для значения по умолчанию.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeReference" />, представляющий тип данных, имеющий значение по умолчанию.</returns>
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x0005F978 File Offset: 0x0005DB78
		// (set) Token: 0x060018B4 RID: 6324 RVA: 0x0005F9A2 File Offset: 0x0005DBA2
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

		// Token: 0x04000D80 RID: 3456
		private CodeTypeReference _type;
	}
}
