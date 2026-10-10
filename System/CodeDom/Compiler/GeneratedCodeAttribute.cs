using System;

namespace System.CodeDom.Compiler
{
	/// <summary>Определяет код, созданный средством. Этот класс не наследуется.</summary>
	// Token: 0x02000356 RID: 854
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	public sealed class GeneratedCodeAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.GeneratedCodeAttribute" /> с указанием имени и версии средства, сгенерировавшего код.</summary>
		/// <param name="tool">Имя средства, сгенерировавшего код.</param>
		/// <param name="version">Версия средства, сгенерировавшего код.</param>
		// Token: 0x06001C47 RID: 7239 RVA: 0x00066CE4 File Offset: 0x00064EE4
		public GeneratedCodeAttribute(string tool, string version)
		{
			this.tool = tool;
			this.version = version;
		}

		/// <summary>Получает имя средства, сгенерировавшего код.</summary>
		/// <returns>Имя средства, сгенерировавшего код.</returns>
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00066CFA File Offset: 0x00064EFA
		public string Tool
		{
			get
			{
				return this.tool;
			}
		}

		/// <summary>Получает версию средства, сгенерировавшего код.</summary>
		/// <returns>Версия средства, сгенерировавшего код.</returns>
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00066D02 File Offset: 0x00064F02
		public string Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x04000E73 RID: 3699
		private readonly string tool;

		// Token: 0x04000E74 RID: 3700
		private readonly string version;
	}
}
