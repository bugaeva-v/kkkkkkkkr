using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System.Diagnostics.Contracts.Internal
{
	/// <summary>Предоставляет методы, которые используются двоичным модулем перезаписи для обработки сбоев контракта.</summary>
	// Token: 0x020009D3 RID: 2515
	[Obsolete("Use the ContractHelper class in the System.Runtime.CompilerServices namespace instead.")]
	public static class ContractHelper
	{
		/// <summary>Используется двоичным методом перезаписи для активации поведения при сбоях по умолчанию.</summary>
		/// <param name="failureKind">Тип сбоя.</param>
		/// <param name="userMessage">Дополнительные сведения о пользователе.</param>
		/// <param name="conditionText">Описание условия, вызвавшего сбой.</param>
		/// <param name="innerException">Внутреннее исключение, вызвавшее текущее исключение.</param>
		/// <returns>Пустая ссылка (<see langword="Nothing" /> в Visual Basic), если событие было обработано и не должно спровоцировать сбой; в противном случае возвращает локализованное сообщение об ошибке.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="failureKind" /> не является допустимым значением <see cref="T:System.Diagnostics.Contracts.ContractFailureKind" />.</exception>
		// Token: 0x06005A3A RID: 23098 RVA: 0x00134269 File Offset: 0x00132469
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[DebuggerNonUserCode]
		public static string RaiseContractFailedEvent(ContractFailureKind failureKind, string userMessage, string conditionText, Exception innerException)
		{
			return ContractHelper.RaiseContractFailedEvent(failureKind, userMessage, conditionText, innerException);
		}

		/// <summary>Активирует поведение при сбоях по умолчанию.</summary>
		/// <param name="kind">Тип сбоя.</param>
		/// <param name="displayMessage">Отображаемое сообщение.</param>
		/// <param name="userMessage">Дополнительные сведения о пользователе.</param>
		/// <param name="conditionText">Описание условия, вызвавшего сбой.</param>
		/// <param name="innerException">Внутреннее исключение, вызвавшее текущее исключение.</param>
		// Token: 0x06005A3B RID: 23099 RVA: 0x00134274 File Offset: 0x00132474
		[DebuggerNonUserCode]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void TriggerFailure(ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, Exception innerException)
		{
			ContractHelper.TriggerFailure(kind, displayMessage, userMessage, conditionText, innerException);
		}
	}
}
