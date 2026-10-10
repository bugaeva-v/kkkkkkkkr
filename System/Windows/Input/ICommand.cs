using System;
using System.Runtime.CompilerServices;

namespace System.Windows.Input
{
	/// <summary>Определяет команду.</summary>
	// Token: 0x0200017A RID: 378
	[TypeForwardedFrom("PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
	public interface ICommand
	{
		/// <summary>Определяет метод, который определяет, может ли данная команда выполняться в ее текущем состоянии.</summary>
		/// <param name="parameter">Данные, используемые данной командой.  Если команда не требует передачи данных, этому объект может быть присвоено значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если эту команду можно выполнить; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A18 RID: 2584
		bool CanExecute(object parameter);

		/// <summary>Определяет метод, вызываемый при вызове данной команды.</summary>
		/// <param name="parameter">Данные, используемые данной командой.  Если команда не требует передачи данных, этому объект может быть присвоено значение <see langword="null" />.</param>
		// Token: 0x06000A19 RID: 2585
		void Execute(object parameter);

		/// <summary>Происходит при изменениях, влияющих на то, должна выполняться данная команда или нет.</summary>
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000A1A RID: 2586
		// (remove) Token: 0x06000A1B RID: 2587
		event EventHandler CanExecuteChanged;
	}
}
