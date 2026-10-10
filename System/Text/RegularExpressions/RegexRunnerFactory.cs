using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Создает класс <see cref="T:System.Text.RegularExpressions.RegexRunner" /> для скомпилированного регулярного выражения.</summary>
	// Token: 0x0200020D RID: 525
	public abstract class RegexRunnerFactory
	{
		/// <summary>При переопределении в производный класс создает объект <see cref="T:System.Text.RegularExpressions.RegexRunner" /> для конкретного скомпилированного регулярного выражения.</summary>
		/// <returns>Объект <see cref="T:System.Text.RegularExpressions.RegexRunner" /> разработан для выполнения конкретного скомпилированного регулярного выражения.</returns>
		// Token: 0x06000F2F RID: 3887
		protected internal abstract RegexRunner CreateInstance();
	}
}
