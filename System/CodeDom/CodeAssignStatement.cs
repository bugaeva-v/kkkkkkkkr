using System;

namespace System.CodeDom
{
	/// <summary>Представляет простой оператор присваивания.</summary>
	// Token: 0x020002F2 RID: 754
	[Serializable]
	public class CodeAssignStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAssignStatement" />.</summary>
		// Token: 0x06001821 RID: 6177 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeAssignStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAssignStatement" />, используя указанные выражения.</summary>
		/// <param name="left">Переменная, которой следует присвоить значение.</param>
		/// <param name="right">Присваиваемое значение.</param>
		// Token: 0x06001822 RID: 6178 RVA: 0x0005F0DD File Offset: 0x0005D2DD
		public CodeAssignStatement(CodeExpression left, CodeExpression right)
		{
			this.Left = left;
			this.Right = right;
		}

		/// <summary>Получает или задает выражение, представляющее объект или ссылку для присваивания.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает объект или ссылку для присваивания.</returns>
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x0005F0F3 File Offset: 0x0005D2F3
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x0005F0FB File Offset: 0x0005D2FB
		public CodeExpression Left { get; set; }

		/// <summary>Получает или задает выражение, представляющее объект или ссылку для присваивания.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий объект или ссылку для присваивания.</returns>
		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x0005F104 File Offset: 0x0005D304
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x0005F10C File Offset: 0x0005D30C
		public CodeExpression Right { get; set; }
	}
}
