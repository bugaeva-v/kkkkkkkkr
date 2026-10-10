using System;
using System.Reflection;

namespace System.CodeDom
{
	/// <summary>Представляет объявление делегата.</summary>
	// Token: 0x02000335 RID: 821
	[Serializable]
	public class CodeTypeDelegate : CodeTypeDeclaration
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeDelegate" />.</summary>
		// Token: 0x06001A0E RID: 6670 RVA: 0x0006131C File Offset: 0x0005F51C
		public CodeTypeDelegate()
		{
			base.TypeAttributes &= ~TypeAttributes.ClassSemanticsMask;
			base.TypeAttributes |= TypeAttributes.NotPublic;
			base.BaseTypes.Clear();
			base.BaseTypes.Add(new CodeTypeReference("System.Delegate"));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeDelegate" />.</summary>
		/// <param name="name">Имя делегата.</param>
		// Token: 0x06001A0F RID: 6671 RVA: 0x00061378 File Offset: 0x0005F578
		public CodeTypeDelegate(string name) : this()
		{
			base.Name = name;
		}

		/// <summary>Получает или задает возвращаемый тип делегата.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий возвращаемый тип делегата.</returns>
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00061388 File Offset: 0x0005F588
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x000613B2 File Offset: 0x0005F5B2
		public CodeTypeReference ReturnType
		{
			get
			{
				CodeTypeReference result;
				if ((result = this._returnType) == null)
				{
					result = (this._returnType = new CodeTypeReference(""));
				}
				return result;
			}
			set
			{
				this._returnType = value;
			}
		}

		/// <summary>Получает параметры делегата.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" />, указывающий параметры делегата.</returns>
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x000613BB File Offset: 0x0005F5BB
		public CodeParameterDeclarationExpressionCollection Parameters { get; } = new CodeParameterDeclarationExpressionCollection();

		// Token: 0x04000DEE RID: 3566
		private CodeTypeReference _returnType;
	}
}
