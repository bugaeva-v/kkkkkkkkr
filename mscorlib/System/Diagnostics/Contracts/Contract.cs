using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Diagnostics.Contracts
{
	/// <summary>Содержит статические методы для представления контрактов программы, таких как предусловие, постусловие и инвариантность объектов.</summary>
	// Token: 0x020009CF RID: 2511
	public static class Contract
	{
		/// <summary>Инструктирует инструменты анализа кода полагать, что указанным условием является <see langword="true" />, даже если статически невозможно подтвердить постоянное значение <see langword="true" />.</summary>
		/// <param name="condition">Предполагаемое условное выражение <see langword="true" />.</param>
		// Token: 0x06005A0F RID: 23055 RVA: 0x00133DD5 File Offset: 0x00131FD5
		[Conditional("DEBUG")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[Conditional("CONTRACTS_FULL")]
		public static void Assume(bool condition)
		{
			if (!condition)
			{
				Contract.ReportFailure(ContractFailureKind.Assume, null, null, null);
			}
		}

		/// <summary>Инструктирует инструменты анализа кода полагать, что условием является <see langword="true" />, даже если статически невозможно подтвердить постоянное значение <see langword="true" />, и отображает сообщение, если предположение было ошибочным.</summary>
		/// <param name="condition">Предполагаемое условное выражение <see langword="true" />.</param>
		/// <param name="userMessage">Сообщение, создаваемое при ошибочном предположении.</param>
		// Token: 0x06005A10 RID: 23056 RVA: 0x00133DE3 File Offset: 0x00131FE3
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[Conditional("CONTRACTS_FULL")]
		[Conditional("DEBUG")]
		public static void Assume(bool condition, string userMessage)
		{
			if (!condition)
			{
				Contract.ReportFailure(ContractFailureKind.Assume, userMessage, null, null);
			}
		}

		/// <summary>Проверяет условие; если условие имеет значение <see langword="false" />, следует политике эскалации, установленной для анализатора.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		// Token: 0x06005A11 RID: 23057 RVA: 0x00133DF1 File Offset: 0x00131FF1
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[Conditional("CONTRACTS_FULL")]
		[Conditional("DEBUG")]
		public static void Assert(bool condition)
		{
			if (!condition)
			{
				Contract.ReportFailure(ContractFailureKind.Assert, null, null, null);
			}
		}

		/// <summary>Проверяет условие; если условие имеет значение <see langword="false" />, следует политике эскалации, установленной анализатором, и отображает указанное сообщение.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		/// <param name="userMessage">Сообщение, отображаемое при несоответствии условия.</param>
		// Token: 0x06005A12 RID: 23058 RVA: 0x00133DFF File Offset: 0x00131FFF
		[Conditional("CONTRACTS_FULL")]
		[Conditional("DEBUG")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void Assert(bool condition, string userMessage)
		{
			if (!condition)
			{
				Contract.ReportFailure(ContractFailureKind.Assert, userMessage, null, null);
			}
		}

		/// <summary>Указывает контракт предусловия для включающего метода или свойства.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		// Token: 0x06005A13 RID: 23059 RVA: 0x00133E0D File Offset: 0x0013200D
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[Conditional("CONTRACTS_FULL")]
		public static void Requires(bool condition)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Precondition, "Requires");
		}

		/// <summary>Указывает контракт предусловия для включающего метода или свойства и отображает сообщение, если условие для контракта не выполняется.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		/// <param name="userMessage">Отображаемое сообщение при условии <see langword="false" />.</param>
		// Token: 0x06005A14 RID: 23060 RVA: 0x00133E0D File Offset: 0x0013200D
		[Conditional("CONTRACTS_FULL")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void Requires(bool condition, string userMessage)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Precondition, "Requires");
		}

		/// <summary>Указывает контракт предусловия для включающего метода или свойства и выдает исключение, если условие для контракта не выполняется.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		/// <typeparam name="TException">Выдаваемое исключение при условии <see langword="false" />.</typeparam>
		// Token: 0x06005A15 RID: 23061 RVA: 0x00133E1A File Offset: 0x0013201A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void Requires<TException>(bool condition) where TException : Exception
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Precondition, "Requires<TException>");
		}

		/// <summary>Задает контракт предусловия для включающего метода или свойства и создает исключение с предоставленным сообщением, если условие для контракта не выполняется.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		/// <param name="userMessage">Отображаемое сообщение при условии <see langword="false" />.</param>
		/// <typeparam name="TException">Выдаваемое исключение при условии <see langword="false" />.</typeparam>
		// Token: 0x06005A16 RID: 23062 RVA: 0x00133E1A File Offset: 0x0013201A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void Requires<TException>(bool condition, string userMessage) where TException : Exception
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Precondition, "Requires<TException>");
		}

		/// <summary>Указывает контракт постусловия для включающего метода или свойства.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке. Выражение может включать значения <see cref="M:System.Diagnostics.Contracts.Contract.OldValue``1(``0)" />, <see cref="M:System.Diagnostics.Contracts.Contract.ValueAtReturn``1(``0@)" /> и <see cref="M:System.Diagnostics.Contracts.Contract.Result``1" />.</param>
		// Token: 0x06005A17 RID: 23063 RVA: 0x00133E27 File Offset: 0x00132027
		[Conditional("CONTRACTS_FULL")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void Ensures(bool condition)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Postcondition, "Ensures");
		}

		/// <summary>Указывает контракт постусловия для предоставленного выходного условия и сообщение, отображаемое, если условие имеет значение <see langword="false" />.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке. Выражение может включать значения <see cref="M:System.Diagnostics.Contracts.Contract.OldValue``1(``0)" /> и <see cref="M:System.Diagnostics.Contracts.Contract.Result``1" />.</param>
		/// <param name="userMessage">Сообщение, отображаемое в том случае, если выражение не является <see langword="true" />.</param>
		// Token: 0x06005A18 RID: 23064 RVA: 0x00133E27 File Offset: 0x00132027
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[Conditional("CONTRACTS_FULL")]
		public static void Ensures(bool condition, string userMessage)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Postcondition, "Ensures");
		}

		/// <summary>Задает контракт постусловия для включающего метода или свойства на основе предоставленных исключения и состояния.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		/// <typeparam name="TException">Тип исключения, вызвавшего проверку постусловия.</typeparam>
		// Token: 0x06005A19 RID: 23065 RVA: 0x00133E34 File Offset: 0x00132034
		[Conditional("CONTRACTS_FULL")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void EnsuresOnThrow<TException>(bool condition) where TException : Exception
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.PostconditionOnException, "EnsuresOnThrow");
		}

		/// <summary>Задает контракт постусловия и сообщение, которое необходимо отобразить, если условие имеет значение <see langword="false" />, для включающего метода или свойства на основе предоставленных исключения и условия.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		/// <param name="userMessage">Отображаемое сообщение при выражении <see langword="false" />.</param>
		/// <typeparam name="TException">Тип исключения, вызвавшего проверку постусловия.</typeparam>
		// Token: 0x06005A1A RID: 23066 RVA: 0x00133E34 File Offset: 0x00132034
		[Conditional("CONTRACTS_FULL")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void EnsuresOnThrow<TException>(bool condition, string userMessage) where TException : Exception
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.PostconditionOnException, "EnsuresOnThrow");
		}

		/// <summary>Представляет возвращаемое значение метода или свойства.</summary>
		/// <typeparam name="T">Тип возвращаемого значения включающего метода или свойства.</typeparam>
		/// <returns>Возвращаемое значение включающего метода или свойства.</returns>
		// Token: 0x06005A1B RID: 23067 RVA: 0x00133E44 File Offset: 0x00132044
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static T Result<T>()
		{
			return default(T);
		}

		/// <summary>Представляет итоговое (выходное) значение параметра <see langword="out" /> по возвращении из метода.</summary>
		/// <param name="value">Параметр <see langword="out" />.</param>
		/// <typeparam name="T">Тип параметра <see langword="out" />.</typeparam>
		/// <returns>Выходное значение параметра <see langword="out" />.</returns>
		// Token: 0x06005A1C RID: 23068 RVA: 0x00133E5A File Offset: 0x0013205A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static T ValueAtReturn<T>(out T value)
		{
			value = default(T);
			return value;
		}

		/// <summary>Представляет значения, какими они были в начале метода или свойства.</summary>
		/// <param name="value">Представляемое значение (поле или параметр).</param>
		/// <typeparam name="T">Тип значения.</typeparam>
		/// <returns>Значение параметра или поля при запуске метода или свойства.</returns>
		// Token: 0x06005A1D RID: 23069 RVA: 0x00133E6C File Offset: 0x0013206C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static T OldValue<T>(T value)
		{
			return default(T);
		}

		/// <summary>Задает инвариантный контракт ля включающего метода или свойства.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		// Token: 0x06005A1E RID: 23070 RVA: 0x00133E82 File Offset: 0x00132082
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[Conditional("CONTRACTS_FULL")]
		public static void Invariant(bool condition)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Invariant, "Invariant");
		}

		/// <summary>Указывает инвариантный контракт для включающего метода или свойства и отображает сообщение, если условие для контракта не выполняется.</summary>
		/// <param name="condition">Условное выражение, которое требуется подвергнуть проверке.</param>
		/// <param name="userMessage">Отображаемое сообщение при условии <see langword="false" />.</param>
		// Token: 0x06005A1F RID: 23071 RVA: 0x00133E82 File Offset: 0x00132082
		[Conditional("CONTRACTS_FULL")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void Invariant(bool condition, string userMessage)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Invariant, "Invariant");
		}

		/// <summary>Определяет, выполняется ли определенное условие для всех целых чисел в указанном диапазоне.</summary>
		/// <param name="fromInclusive">Первое целое число для передачи в <paramref name="predicate" />.</param>
		/// <param name="toExclusive">Последнее целое число для передачи в <paramref name="predicate" /> плюс один.</param>
		/// <param name="predicate">Функция, оцениваемая, чтобы установить существование целых чисел в указанном диапазоне.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="predicate" /> возвращает <see langword="true" /> для всех целых чисел, начиная от <paramref name="fromInclusive" /> до <paramref name="toExclusive" /> минус один.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="predicate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="toExclusive" /> меньше <paramref name="fromInclusive" />.</exception>
		// Token: 0x06005A20 RID: 23072 RVA: 0x00133E90 File Offset: 0x00132090
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static bool ForAll(int fromInclusive, int toExclusive, Predicate<int> predicate)
		{
			if (fromInclusive > toExclusive)
			{
				throw new ArgumentException("fromInclusive must be less than or equal to toExclusive.");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			for (int i = fromInclusive; i < toExclusive; i++)
			{
				if (!predicate(i))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Определяет, существуют ли в рамках функции все элементы в коллекции.</summary>
		/// <param name="collection">Коллекция, из которой будут извлекаться элементы типа T для передачи в <paramref name="predicate" />.</param>
		/// <param name="predicate">Функция, оцениваемая на предмет наличия всех элементов, содержащихся в параметре <paramref name="collection" />.</param>
		/// <typeparam name="T">Тип, содержащийся в <paramref name="collection" />.</typeparam>
		/// <returns>Значение <see langword="true" />, если и только если <paramref name="predicate" /> возвращает значение <see langword="true" /> для всех элементов типа <paramref name="T" />, содержащихся в параметре <paramref name="collection" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="collection" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005A21 RID: 23073 RVA: 0x00133ED4 File Offset: 0x001320D4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			foreach (T obj in collection)
			{
				if (!predicate(obj))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Определяет, удовлетворяет ли проверке какое-либо целое число в диапазоне целых чисел.</summary>
		/// <param name="fromInclusive">Первое целое число для передачи в <paramref name="predicate" />.</param>
		/// <param name="toExclusive">Последнее целое число для передачи в <paramref name="predicate" /> плюс один.</param>
		/// <param name="predicate">Функция, оцениваемая на предмет любого значения целого числа в указанном диапазоне.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="predicate" /> возвращает <see langword="true" /> для любого целого числа, начиная от <paramref name="fromInclusive" /> до <paramref name="toExclusive" /> минус один.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="predicate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="toExclusive" /> меньше <paramref name="fromInclusive" />.</exception>
		// Token: 0x06005A22 RID: 23074 RVA: 0x00133F44 File Offset: 0x00132144
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static bool Exists(int fromInclusive, int toExclusive, Predicate<int> predicate)
		{
			if (fromInclusive > toExclusive)
			{
				throw new ArgumentException("fromInclusive must be less than or equal to toExclusive.");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			for (int i = fromInclusive; i < toExclusive; i++)
			{
				if (predicate(i))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Определяет, существует ли в рамках функции элемент в указанной коллекции элементов.</summary>
		/// <param name="collection">Коллекция, из которой будут извлекаться элементы типа T для передачи в <paramref name="predicate" />.</param>
		/// <param name="predicate">Функция, оцениваемая на предмет элемента, содержащегося в параметре <paramref name="collection" />.</param>
		/// <typeparam name="T">Тип, содержащийся в <paramref name="collection" />.</typeparam>
		/// <returns>Значение <see langword="true" />, если и только если <paramref name="predicate" /> возвращает значение <see langword="true" /> для любого из элементов типа <paramref name="T" />, содержащихся в параметре <paramref name="collection" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="collection" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005A23 RID: 23075 RVA: 0x00133F88 File Offset: 0x00132188
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static bool Exists<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			foreach (T obj in collection)
			{
				if (predicate(obj))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Помечает конец раздела контракта, когда контракты метода содержат только предусловия вида <see langword="if" />-<see langword="then" />-<see langword="throw" />.</summary>
		// Token: 0x06005A24 RID: 23076 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[Conditional("CONTRACTS_FULL")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void EndContractBlock()
		{
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x00133FF8 File Offset: 0x001321F8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[DebuggerNonUserCode]
		private static void ReportFailure(ContractFailureKind failureKind, string userMessage, string conditionText, Exception innerException)
		{
			if (failureKind < ContractFailureKind.Precondition || failureKind > ContractFailureKind.Assume)
			{
				throw new ArgumentException(Environment.GetResourceString("Illegal enum value: {0}.", new object[]
				{
					failureKind
				}), "failureKind");
			}
			string text = ContractHelper.RaiseContractFailedEvent(failureKind, userMessage, conditionText, innerException);
			if (text == null)
			{
				return;
			}
			ContractHelper.TriggerFailure(failureKind, text, userMessage, conditionText, innerException);
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x0013404C File Offset: 0x0013224C
		[SecuritySafeCritical]
		private static void AssertMustUseRewriter(ContractFailureKind kind, string contractKind)
		{
			if (Contract._assertingMustUseRewriter)
			{
				System.Diagnostics.Assert.Fail("Asserting that we must use the rewriter went reentrant.", "Didn't rewrite this mscorlib?");
			}
			Contract._assertingMustUseRewriter = true;
			Assembly assembly = typeof(Contract).Assembly;
			StackTrace stackTrace = new StackTrace();
			Assembly assembly2 = null;
			for (int i = 0; i < stackTrace.FrameCount; i++)
			{
				Assembly assembly3 = stackTrace.GetFrame(i).GetMethod().DeclaringType.Assembly;
				if (assembly3 != assembly)
				{
					assembly2 = assembly3;
					break;
				}
			}
			if (assembly2 == null)
			{
				assembly2 = assembly;
			}
			string name = assembly2.GetName().Name;
			ContractHelper.TriggerFailure(kind, Environment.GetResourceString("An assembly (probably \"{1}\") must be rewritten using the code contracts binary rewriter (CCRewrite) because it is calling Contract.{0} and the CONTRACTS_FULL symbol is defined.  Remove any explicit definitions of the CONTRACTS_FULL symbol from your project and rebuild.  CCRewrite can be downloaded from http://go.microsoft.com/fwlink/?LinkID=169180. \\r\\nAfter the rewriter is installed, it can be enabled in Visual Studio from the project's Properties page on the Code Contracts pane.  Ensure that \"Perform Runtime Contract Checking\" is enabled, which will define CONTRACTS_FULL.", new object[]
			{
				contractKind,
				name
			}), null, null, null);
			Contract._assertingMustUseRewriter = false;
		}

		/// <summary>Происходит, когда контракт не выполняется.</summary>
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06005A27 RID: 23079 RVA: 0x00134108 File Offset: 0x00132308
		// (remove) Token: 0x06005A28 RID: 23080 RVA: 0x00134110 File Offset: 0x00132310
		public static event EventHandler<ContractFailedEventArgs> ContractFailed
		{
			[SecurityCritical]
			add
			{
				ContractHelper.InternalContractFailed += value;
			}
			[SecurityCritical]
			remove
			{
				ContractHelper.InternalContractFailed -= value;
			}
		}

		// Token: 0x040037AB RID: 14251
		[ThreadStatic]
		private static bool _assertingMustUseRewriter;
	}
}
