using System;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Описывает типы узлов для узлов дерева выражений.
	///       </summary>
	// Token: 0x02000259 RID: 601
	public enum ExpressionType
	{
		/// <summary>
		///         Операции сложения, например a + b, без проверки переполнения для числовых операндов.
		///       </summary>
		// Token: 0x04000996 RID: 2454
		Add,
		/// <summary>
		///         Операции сложения, например (a + b), с проверкой переполнения для числовых операндов.
		///       </summary>
		// Token: 0x04000997 RID: 2455
		AddChecked,
		/// <summary>
		///         Побитовое или логических <see langword="AND" /> операции, такие как (a &amp; b) в C# и (a And b) в Visual Basic.
		///       </summary>
		// Token: 0x04000998 RID: 2456
		And,
		/// <summary>
		///         Условную <see langword="AND" /> операции, вычисляющую второй операнд, только в том случае, если первый операнд имеет значение <see langword="true" />.
		///          Он соответствует (a &amp;&amp; b) в C# и (a AndAlso b) в Visual Basic.
		///       </summary>
		// Token: 0x04000999 RID: 2457
		AndAlso,
		/// <summary>
		///         Операция получения длины одномерного массива, такие как array.Length.
		///       </summary>
		// Token: 0x0400099A RID: 2458
		ArrayLength,
		/// <summary>
		///         Индексирование операции в одномерный массив, например array[index] в C# или array(index) в Visual Basic.
		///       </summary>
		// Token: 0x0400099B RID: 2459
		ArrayIndex,
		/// <summary>
		///         Вызов метода, таких как obj.sampleMethod() выражение.
		///       </summary>
		// Token: 0x0400099C RID: 2460
		Call,
		/// <summary>
		///         Узел, представляющий объединяющую операцию null, например (a ?? b) в C# или If(a, b) в Visual Basic.
		///       </summary>
		// Token: 0x0400099D RID: 2461
		Coalesce,
		/// <summary>
		///         Условной операции, такие как a &gt; b ? a : b в C# или If(a &gt; b, a, b) в Visual Basic.
		///       </summary>
		// Token: 0x0400099E RID: 2462
		Conditional,
		/// <summary>
		///         Постоянное значение.
		///       </summary>
		// Token: 0x0400099F RID: 2463
		Constant,
		/// <summary>
		///         Операция приведения или преобразования, такие как (SampleType)obj в C#или CType(obj, SampleType) в Visual Basic.
		///          Числовые преобразования если преобразованное значение слишком велико для целевого типа, исключение не возникает.
		///       </summary>
		// Token: 0x040009A0 RID: 2464
		Convert,
		/// <summary>
		///         Операция приведения или преобразования, такие как (SampleType)obj в C#или CType(obj, SampleType) в Visual Basic.
		///          Числовые преобразования если преобразованное значение не соответствует целевого типа, исключение.
		///       </summary>
		// Token: 0x040009A1 RID: 2465
		ConvertChecked,
		/// <summary>
		///         Операции деления, такие как (a / b), для числовых операндов.
		///       </summary>
		// Token: 0x040009A2 RID: 2466
		Divide,
		/// <summary>
		///         Узел, представляющий сравнение равенства, таких как (a == b) в C# или (a = b) в Visual Basic.
		///       </summary>
		// Token: 0x040009A3 RID: 2467
		Equal,
		/// <summary>
		///         Побитовое или логических <see langword="XOR" /> операции, такие как (a ^ b) в C# или (a Xor b) в Visual Basic.
		///       </summary>
		// Token: 0x040009A4 RID: 2468
		ExclusiveOr,
		/// <summary>
		///         Сравнение «больше чем», такие как (a &gt; b).
		///       </summary>
		// Token: 0x040009A5 RID: 2469
		GreaterThan,
		/// <summary>
		///         Сравнение «больше или равно», такие как (a &gt;= b).
		///       </summary>
		// Token: 0x040009A6 RID: 2470
		GreaterThanOrEqual,
		/// <summary>
		///         Операция, которая вызывает делегат или лямбда-выражения, такие как sampleDelegate.Invoke().
		///       </summary>
		// Token: 0x040009A7 RID: 2471
		Invoke,
		/// <summary>
		///         Лямбда-выражения, такие как a =&gt; a + a в C# или Function(a) a + a в Visual Basic.
		///       </summary>
		// Token: 0x040009A8 RID: 2472
		Lambda,
		/// <summary>
		///         Операция побитового сдвига влево, например (a &lt;&lt; b).
		///       </summary>
		// Token: 0x040009A9 RID: 2473
		LeftShift,
		/// <summary>
		///         Сравнения «меньше чем», такие как (a &lt; b).
		///       </summary>
		// Token: 0x040009AA RID: 2474
		LessThan,
		/// <summary>
		///         «Меньше или равно» сравнения, таких как (a &lt;= b).
		///       </summary>
		// Token: 0x040009AB RID: 2475
		LessThanOrEqual,
		/// <summary>
		///         Операция создания нового <see cref="T:System.Collections.IEnumerable" /> объекта и инициализирует его из списка элементов, таких как new List&lt;SampleType&gt;(){ a, b, c } в C# или Dim sampleList = { a, b, c } в Visual Basic.
		///       </summary>
		// Token: 0x040009AC RID: 2476
		ListInit,
		/// <summary>
		///         Операция чтения из поля или свойства, такие как obj.SampleProperty.
		///       </summary>
		// Token: 0x040009AD RID: 2477
		MemberAccess,
		/// <summary>
		///         Операция, которая создает новый объект и инициализирует один или несколько его элементов, таких как new Point { X = 1, Y = 2 } в C# или New Point With {.X = 1, .Y = 2} в Visual Basic.
		///       </summary>
		// Token: 0x040009AE RID: 2478
		MemberInit,
		/// <summary>
		///         Арифметический остаток от деления операции, такие как (a % b) в C# или (a Mod b) в Visual Basic.
		///       </summary>
		// Token: 0x040009AF RID: 2479
		Modulo,
		/// <summary>
		///         Операции умножения, такие как (a * b), без проверки переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009B0 RID: 2480
		Multiply,
		/// <summary>
		///         Операция арифметического умножения, например (a * b), с проверкой переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009B1 RID: 2481
		MultiplyChecked,
		/// <summary>
		///         Операцию арифметического отрицания, такие как (-a).
		///          Объект a не должны быть изменены на месте.
		///       </summary>
		// Token: 0x040009B2 RID: 2482
		Negate,
		/// <summary>
		///         Унарный плюс операции, такие как (+a).
		///          Результат предопределенные унарный плюс операции является значение операнда, но определенные пользователем реализации могут иметь нетривиальные результаты.
		///       </summary>
		// Token: 0x040009B3 RID: 2483
		UnaryPlus,
		/// <summary>
		///         Операцию арифметического отрицания, такие как (-a), с проверкой переполнения.
		///          Объект a не должны быть изменены на месте.
		///       </summary>
		// Token: 0x040009B4 RID: 2484
		NegateChecked,
		/// <summary>
		///         Операция, которая вызывает конструктор для создания нового объекта, например new SampleType().
		///       </summary>
		// Token: 0x040009B5 RID: 2485
		New,
		/// <summary>
		///         Операция, которая создает новый одномерный массив и инициализирует его из списка элементов, таких как new SampleType[]{a, b, c} в C# или New SampleType(){a, b, c} в Visual Basic.
		///       </summary>
		// Token: 0x040009B6 RID: 2486
		NewArrayInit,
		/// <summary>
		///         Операцию, которая создает новый массив, в котором указаны границы для каждого измерения, такие как new SampleType[dim1, dim2] в C# или New SampleType(dim1, dim2) в Visual Basic.
		///       </summary>
		// Token: 0x040009B7 RID: 2487
		NewArrayBounds,
		/// <summary>
		///         Побитовое дополнение или операцию логического отрицания.
		///          В C# это эквивалентно (~a) для целочисленных типов и в (!a) для логических значений.
		///          В Visual Basic, это эквивалентно (Not a).
		///          Объект a не должны быть изменены на месте.
		///       </summary>
		// Token: 0x040009B8 RID: 2488
		Not,
		/// <summary>
		///         Сравнение неравенства, например (a != b) в C# или (a &lt;&gt; b) в Visual Basic.
		///       </summary>
		// Token: 0x040009B9 RID: 2489
		NotEqual,
		/// <summary>
		///         Побитовое или логических <see langword="OR" /> операции, такие как (a | b) в C# или (a Or b) в Visual Basic.
		///       </summary>
		// Token: 0x040009BA RID: 2490
		Or,
		/// <summary>
		///         Сокращенное вычисление условную <see langword="OR" /> операции, такие как (a || b) в C# или (a OrElse b) в Visual Basic.
		///       </summary>
		// Token: 0x040009BB RID: 2491
		OrElse,
		/// <summary>
		///         Ссылка на параметр или переменную, которая определена в контексте выражения.
		///          Дополнительные сведения см. в разделе <see cref="T:System.Linq.Expressions.ParameterExpression" />.
		///       </summary>
		// Token: 0x040009BC RID: 2492
		Parameter,
		/// <summary>
		///         Математические операции возведения числа в степень, такие как (a ^ b) в Visual Basic.
		///       </summary>
		// Token: 0x040009BD RID: 2493
		Power,
		/// <summary>
		///         Выражение, которое содержит постоянное значение типа <see cref="T:System.Linq.Expressions.Expression" />.
		///          A <see cref="F:System.Linq.Expressions.ExpressionType.Quote" /> узел может содержать ссылки на параметры, определенные в контексте выражения, он представляет.
		///       </summary>
		// Token: 0x040009BE RID: 2494
		Quote,
		/// <summary>
		///         Операция побитового сдвига вправо, например (a &gt;&gt; b).
		///       </summary>
		// Token: 0x040009BF RID: 2495
		RightShift,
		/// <summary>
		///         Операция арифметического вычитания, например (a - b), без проверки переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009C0 RID: 2496
		Subtract,
		/// <summary>
		///         Операция арифметического вычитания, например (a - b), с проверкой переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009C1 RID: 2497
		SubtractChecked,
		/// <summary>
		///         Явной ссылки или упаковки-преобразования, в котором <see langword="null" /> предоставляется, если преобразование завершается неудачей, такие как (obj as SampleType) в C# или TryCast(obj, SampleType) в Visual Basic.
		///       </summary>
		// Token: 0x040009C2 RID: 2498
		TypeAs,
		/// <summary>
		///         Тип теста, таких как obj is SampleType в C# или TypeOf obj is SampleType в Visual Basic.
		///       </summary>
		// Token: 0x040009C3 RID: 2499
		TypeIs,
		/// <summary>
		///         Операция присваивания, такие как (a = b).
		///       </summary>
		// Token: 0x040009C4 RID: 2500
		Assign,
		/// <summary>
		///         Блок выражений.
		///       </summary>
		// Token: 0x040009C5 RID: 2501
		Block,
		/// <summary>
		///         Отладочная информация.
		///       </summary>
		// Token: 0x040009C6 RID: 2502
		DebugInfo,
		/// <summary>
		///         Унарный уменьшения операции, такие как (a - 1) в C# и Visual Basic.
		///          Объект a не должны быть изменены на месте.
		///       </summary>
		// Token: 0x040009C7 RID: 2503
		Decrement,
		/// <summary>
		///         Динамической операции.
		///       </summary>
		// Token: 0x040009C8 RID: 2504
		Dynamic,
		/// <summary>
		///         Значение по умолчанию.
		///       </summary>
		// Token: 0x040009C9 RID: 2505
		Default,
		/// <summary>
		///         Выражение расширения.
		///       </summary>
		// Token: 0x040009CA RID: 2506
		Extension,
		/// <summary>
		///         Объект ««перейти к» выражения, такие как goto Label в C# или GoTo Label в Visual Basic.
		///       </summary>
		// Token: 0x040009CB RID: 2507
		Goto,
		/// <summary>
		///         Унарная операция инкремента, такие как (a + 1) в C# и Visual Basic.
		///          Объект a не должны быть изменены на месте.
		///       </summary>
		// Token: 0x040009CC RID: 2508
		Increment,
		/// <summary>
		///         Операция индекса или операция, которая обращается к свойству, которое принимает аргументы.
		///       </summary>
		// Token: 0x040009CD RID: 2509
		Index,
		/// <summary>
		///         Метка.
		///       </summary>
		// Token: 0x040009CE RID: 2510
		Label,
		/// <summary>
		///         Список переменных времени выполнения.
		///          Дополнительные сведения см. в разделе <see cref="T:System.Linq.Expressions.RuntimeVariablesExpression" />.
		///       </summary>
		// Token: 0x040009CF RID: 2511
		RuntimeVariables,
		/// <summary>
		///         Объект цикл, такой как for или while.
		///       </summary>
		// Token: 0x040009D0 RID: 2512
		Loop,
		/// <summary>
		///         Объект переключения операции, такие как <see langword="switch" /> в C# или <see langword="Select Case" /> в Visual Basic.
		///       </summary>
		// Token: 0x040009D1 RID: 2513
		Switch,
		/// <summary>
		///         Операция, которая создает исключение, такие как throw new Exception().
		///       </summary>
		// Token: 0x040009D2 RID: 2514
		Throw,
		/// <summary>
		///         A <see langword="try-catch" /> выражение.
		///       </summary>
		// Token: 0x040009D3 RID: 2515
		Try,
		/// <summary>
		///         Значение распаковки-преобразования типа операции, такие как <see langword="unbox" /> и <see langword="unbox.any" /> в MSIL.
		///       </summary>
		// Token: 0x040009D4 RID: 2516
		Unbox,
		/// <summary>
		///         Это дополнение Операция составного присваивания, такие как (a += b), без проверки переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009D5 RID: 2517
		AddAssign,
		/// <summary>
		///         Побитовое или логических <see langword="AND" /> Операция составного присваивания, такие как (a &amp;= b) в C#.
		///       </summary>
		// Token: 0x040009D6 RID: 2518
		AndAssign,
		/// <summary>
		///         Операция составного присваивания деления, такие как (a /= b), для числовых операндов.
		///       </summary>
		// Token: 0x040009D7 RID: 2519
		DivideAssign,
		/// <summary>
		///         Побитовое или логических <see langword="XOR" /> Операция составного присваивания, такие как (a ^= b) в C#.
		///       </summary>
		// Token: 0x040009D8 RID: 2520
		ExclusiveOrAssign,
		/// <summary>
		///         Побитового сдвига влево составного присваивания, например (a &lt;&lt;= b).
		///       </summary>
		// Token: 0x040009D9 RID: 2521
		LeftShiftAssign,
		/// <summary>
		///         Арифметического остатка Операция составного присваивания, такие как (a %= b) в C#.
		///       </summary>
		// Token: 0x040009DA RID: 2522
		ModuloAssign,
		/// <summary>
		///         Составного присваивания арифметического умножения, например (a *= b), без проверки переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009DB RID: 2523
		MultiplyAssign,
		/// <summary>
		///         Побитовое или логических <see langword="OR" /> Составное присваивание, такие как (a |= b) в C#.
		///       </summary>
		// Token: 0x040009DC RID: 2524
		OrAssign,
		/// <summary>
		///         Операция составного присваивания возведения числа в степень, такие как (a ^= b) в Visual Basic.
		///       </summary>
		// Token: 0x040009DD RID: 2525
		PowerAssign,
		/// <summary>
		///         Побитового сдвига вправо Операция составного присваивания, такие как (a &gt;&gt;= b).
		///       </summary>
		// Token: 0x040009DE RID: 2526
		RightShiftAssign,
		/// <summary>
		///         Вычитание Операция составного присваивания, такие как (a -= b), без проверки переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009DF RID: 2527
		SubtractAssign,
		/// <summary>
		///         Это дополнение Операция составного присваивания, такие как (a += b), с проверкой переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009E0 RID: 2528
		AddAssignChecked,
		/// <summary>
		///         Составного присваивания арифметического умножения, например (a *= b), с проверкой переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009E1 RID: 2529
		MultiplyAssignChecked,
		/// <summary>
		///         Вычитание Операция составного присваивания, такие как (a -= b), с проверкой переполнения для числовых операндов.
		///       </summary>
		// Token: 0x040009E2 RID: 2530
		SubtractAssignChecked,
		/// <summary>
		///         Унарный префиксный инкремент, такие как (++a).
		///          Объект a должен быть изменен.
		///       </summary>
		// Token: 0x040009E3 RID: 2531
		PreIncrementAssign,
		/// <summary>
		///         Унарный Префиксный декремент, такие как (--a).
		///          Объект a должен быть изменен.
		///       </summary>
		// Token: 0x040009E4 RID: 2532
		PreDecrementAssign,
		/// <summary>
		///         Унарное Постфиксное приращение, такие как (a++).
		///          Объект a должен быть изменен.
		///       </summary>
		// Token: 0x040009E5 RID: 2533
		PostIncrementAssign,
		/// <summary>
		///         Унарное Постфиксное уменьшение, например (a--).
		///          Объект a должен быть изменен.
		///       </summary>
		// Token: 0x040009E6 RID: 2534
		PostDecrementAssign,
		/// <summary>
		///         Проверка совпадения типа.
		///       </summary>
		// Token: 0x040009E7 RID: 2535
		TypeEqual,
		/// <summary>
		///         А те операцию дополнения до единицы, такие как (~a) в C#.
		///       </summary>
		// Token: 0x040009E8 RID: 2536
		OnesComplement,
		/// <summary>
		///         A <see langword="true" /> условие значение.
		///       </summary>
		// Token: 0x040009E9 RID: 2537
		IsTrue,
		/// <summary>
		///         A <see langword="false" /> условие значение.
		///       </summary>
		// Token: 0x040009EA RID: 2538
		IsFalse
	}
}
