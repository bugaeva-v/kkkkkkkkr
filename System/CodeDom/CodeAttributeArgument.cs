using System;

namespace System.CodeDom
{
	/// <summary>Представляет аргумент, используемый в объявлении атрибута метаданных.</summary>
	// Token: 0x020002F4 RID: 756
	[Serializable]
	public class CodeAttributeArgument
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeArgument" />.</summary>
		// Token: 0x0600182E RID: 6190 RVA: 0x0000219B File Offset: 0x0000039B
		public CodeAttributeArgument()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeArgument" />, используя указанное значение.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeExpression" />, представляющий значение аргумента.</param>
		// Token: 0x0600182F RID: 6191 RVA: 0x0005F17B File Offset: 0x0005D37B
		public CodeAttributeArgument(CodeExpression value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeArgument" />, используя указанное имя и значение.</summary>
		/// <param name="name">Имя свойства атрибута, к которому применяется аргумент.</param>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeExpression" />, представляющий значение аргумента.</param>
		// Token: 0x06001830 RID: 6192 RVA: 0x0005F18A File Offset: 0x0005D38A
		public CodeAttributeArgument(string name, CodeExpression value)
		{
			this.Name = name;
			this.Value = value;
		}

		/// <summary>Возвращает или задает имя атрибута.</summary>
		/// <returns>Имя свойства атрибута, которому предназначается аргумент.</returns>
		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x0005F1B1 File Offset: 0x0005D3B1
		public string Name
		{
			get
			{
				return this._name ?? string.Empty;
			}
			set
			{
				this._name = value;
			}
		}

		/// <summary>Получает или задает значение для аргумента атрибута.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeExpression" />, указывающий значение для аргумента атрибута.</returns>
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0005F1BA File Offset: 0x0005D3BA
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x0005F1C2 File Offset: 0x0005D3C2
		public CodeExpression Value { get; set; }

		// Token: 0x04000D51 RID: 3409
		private string _name;
	}
}
