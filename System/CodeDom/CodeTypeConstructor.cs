using System;

namespace System.CodeDom
{
	/// <summary>Представляет статический конструктор для класса.</summary>
	// Token: 0x02000332 RID: 818
	[Serializable]
	public class CodeTypeConstructor : CodeMemberMethod
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeConstructor" />.</summary>
		// Token: 0x060019EB RID: 6635 RVA: 0x00060F80 File Offset: 0x0005F180
		public CodeTypeConstructor()
		{
			base.Name = ".cctor";
		}
	}
}
