using System;

namespace System.Reflection
{
	/// <summary>Получает сопоставление интерфейса в фактических методах для класса, реализующего этот интерфейс.</summary>
	// Token: 0x020008A5 RID: 2213
	public struct InterfaceMapping
	{
		/// <summary>Представляет тип, который использовался для создания отображения интерфейса.</summary>
		// Token: 0x04002EB3 RID: 11955
		public Type TargetType;

		/// <summary>Показывает тип, представляющий интерфейс.</summary>
		// Token: 0x04002EB4 RID: 11956
		public Type InterfaceType;

		/// <summary>Показывает методы, которые реализуют интерфейс.</summary>
		// Token: 0x04002EB5 RID: 11957
		public MethodInfo[] TargetMethods;

		/// <summary>Показывает методы, определенные в интерфейсе.</summary>
		// Token: 0x04002EB6 RID: 11958
		public MethodInfo[] InterfaceMethods;
	}
}
