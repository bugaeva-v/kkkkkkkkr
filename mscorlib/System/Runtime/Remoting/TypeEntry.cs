using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Реализует базовый класс, который содержит сведения конфигурации, используемые для активации экземпляра удаленного типа.</summary>
	// Token: 0x02000576 RID: 1398
	[ComVisible(true)]
	public class TypeEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.TypeEntry" />.</summary>
		// Token: 0x060036EF RID: 14063 RVA: 0x0000259F File Offset: 0x0000079F
		protected TypeEntry()
		{
		}

		/// <summary>Получает имя сборки типа объекта, сконфигурированного для работы в качестве типа удаленной активации.</summary>
		/// <returns>Имя сборки типа объекта, сконфигурированного для работы в качестве типа удаленной активации.</returns>
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x000C6624 File Offset: 0x000C4824
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x000C662C File Offset: 0x000C482C
		public string AssemblyName
		{
			get
			{
				return this.assembly_name;
			}
			set
			{
				this.assembly_name = value;
			}
		}

		/// <summary>Получает полное имя сборки типа объекта, сконфигурированного для работы в качестве типа удаленной активации.</summary>
		/// <returns>Полное имя сборки типа объекта, сконфигурированного для работы в качестве типа удаленной активации.</returns>
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x000C6635 File Offset: 0x000C4835
		// (set) Token: 0x060036F3 RID: 14067 RVA: 0x000C663D File Offset: 0x000C483D
		public string TypeName
		{
			get
			{
				return this.type_name;
			}
			set
			{
				this.type_name = value;
			}
		}

		// Token: 0x04002568 RID: 9576
		private string assembly_name;

		// Token: 0x04002569 RID: 9577
		private string type_name;
	}
}
