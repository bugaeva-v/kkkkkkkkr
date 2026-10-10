using System;

namespace System.CodeDom
{
	/// <summary>Представляет объявление для конструктора экземпляра типа.</summary>
	// Token: 0x02000304 RID: 772
	[Serializable]
	public class CodeConstructor : CodeMemberMethod
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeConstructor" />.</summary>
		// Token: 0x060018AE RID: 6318 RVA: 0x0005F92E File Offset: 0x0005DB2E
		public CodeConstructor()
		{
			base.Name = ".ctor";
		}

		/// <summary>Получает коллекцию аргументов базового конструктора.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpressionCollection" />, содержащий аргументы базового конструктора.</returns>
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x0005F957 File Offset: 0x0005DB57
		public CodeExpressionCollection BaseConstructorArgs { get; } = new CodeExpressionCollection();

		/// <summary>Получает коллекцию аргументов цепного конструктора.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpressionCollection" />, содержащий аргументы цепного конструктора.</returns>
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x0005F95F File Offset: 0x0005DB5F
		public CodeExpressionCollection ChainedConstructorArgs { get; } = new CodeExpressionCollection();
	}
}
