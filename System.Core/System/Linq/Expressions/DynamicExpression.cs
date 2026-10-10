using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет динамическую операцию.
	///       </summary>
	// Token: 0x02000249 RID: 585
	public class DynamicExpression : Expression, IDynamicExpression, IArgumentProvider
	{
		// Token: 0x0600102D RID: 4141 RVA: 0x000373B9 File Offset: 0x000355B9
		internal DynamicExpression(Type delegateType, CallSiteBinder binder)
		{
			this.DelegateType = delegateType;
			this.Binder = binder;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00007E1D File Offset: 0x0000601D
		public override bool CanReduce
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000373D0 File Offset: 0x000355D0
		public override Expression Reduce()
		{
			ConstantExpression constantExpression = Expression.Constant(CallSite.Create(this.DelegateType, this.Binder));
			return Expression.Invoke(Expression.Field(constantExpression, "Target"), this.Arguments.AddFirst(constantExpression));
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00037410 File Offset: 0x00035610
		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, ReadOnlyCollection<Expression> arguments)
		{
			if (returnType == typeof(object))
			{
				return new DynamicExpressionN(delegateType, binder, arguments);
			}
			return new TypedDynamicExpressionN(returnType, delegateType, binder, arguments);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00037436 File Offset: 0x00035636
		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0)
		{
			if (returnType == typeof(object))
			{
				return new DynamicExpression1(delegateType, binder, arg0);
			}
			return new TypedDynamicExpression1(returnType, delegateType, binder, arg0);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0003745C File Offset: 0x0003565C
		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
		{
			if (returnType == typeof(object))
			{
				return new DynamicExpression2(delegateType, binder, arg0, arg1);
			}
			return new TypedDynamicExpression2(returnType, delegateType, binder, arg0, arg1);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00037486 File Offset: 0x00035686
		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
		{
			if (returnType == typeof(object))
			{
				return new DynamicExpression3(delegateType, binder, arg0, arg1, arg2);
			}
			return new TypedDynamicExpression3(returnType, delegateType, binder, arg0, arg1, arg2);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000374B4 File Offset: 0x000356B4
		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			if (returnType == typeof(object))
			{
				return new DynamicExpression4(delegateType, binder, arg0, arg1, arg2, arg3);
			}
			return new TypedDynamicExpression4(returnType, delegateType, binder, arg0, arg1, arg2, arg3);
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.DynamicExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x000374E6 File Offset: 0x000356E6
		public override Type Type
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>
		///         Возвращает тип узла данного выражения.
		///          Узлы расширения должны возвращать <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> при переопределении этого метода.
		///       </summary>
		/// <returns>
		///         Тип <see cref="T:System.Linq.Expressions.ExpressionType" /> выражения.
		///       </returns>
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x000374F2 File Offset: 0x000356F2
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Dynamic;
			}
		}

		/// <summary>
		///         Получает <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />, который определяет поведение во время выполнения динамического сайта.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />, который определяет поведение во время выполнения динамического сайта.
		///       </returns>
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x000374F6 File Offset: 0x000356F6
		public CallSiteBinder Binder { get; }

		/// <summary>
		///         Получает тип делегата, используемого <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип делегата, используемого <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///       </returns>
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x000374FE File Offset: 0x000356FE
		public Type DelegateType { get; }

		/// <summary>
		///         Получает аргументы динамической операции.
		///       </summary>
		/// <returns>
		///         Коллекции только для чтения, содержащие аргументы динамической операции.
		///       </returns>
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00037506 File Offset: 0x00035706
		public ReadOnlyCollection<Expression> Arguments
		{
			get
			{
				return this.GetOrMakeArguments();
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			throw ContractUtils.Unreachable;
		}

		/// <summary>
		///         Отправляет в конкретный метод Visit для данного типа узла.
		///          Например, объект <see cref="T:System.Linq.Expressions.MethodCallExpression" /> вызывает метод <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.
		///       </summary>
		/// <param name="visitor">
		///           Посетитель, с помощью которого выполняется посещение этого узла.
		///         </param>
		/// <returns>
		///         Результат посещения этого узла.
		///       </returns>
		// Token: 0x0600103B RID: 4155 RVA: 0x00037510 File Offset: 0x00035710
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			DynamicExpressionVisitor dynamicExpressionVisitor = visitor as DynamicExpressionVisitor;
			if (dynamicExpressionVisitor != null)
			{
				return dynamicExpressionVisitor.VisitDynamic(this);
			}
			return visitor.VisitDynamic(this);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual DynamicExpression Rewrite(Expression[] args)
		{
			throw ContractUtils.Unreachable;
		}

		/// <summary>
		///         Сравнивает значение, переданное в параметр arguments, со свойством <see langword="Arguments" /> текущего экземпляра <see langword="DynamicExpression" />.
		///          Если значения параметра и свойства равны, возвращается текущий экземпляр.
		///          Если они не равны, возвращается новый экземпляр, <see langword="DynamicExpression" /> идентичный текущему экземпляру, за исключением того, что свойство <see langword="Arguments" /> имеет значение параметра arguments.
		///       </summary>
		/// <param name="arguments">
		///           Свойство <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" /> результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x0600103D RID: 4157 RVA: 0x00037538 File Offset: 0x00035738
		public DynamicExpression Update(IEnumerable<Expression> arguments)
		{
			ICollection<Expression> collection;
			if (arguments == null)
			{
				collection = null;
			}
			else
			{
				collection = (arguments as ICollection<Expression>);
				if (collection == null)
				{
					collection = (arguments = arguments.ToReadOnly<Expression>());
				}
			}
			if (this.SameArguments(collection))
			{
				return this;
			}
			return ExpressionExtension.MakeDynamic(this.DelegateType, this.Binder, arguments);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual bool SameArguments(ICollection<Expression> arguments)
		{
			throw ContractUtils.Unreachable;
		}

		/// <summary>
		///         Возвращает аргумент в индексе, создавая исключение, если индекс вне допустимых границ.
		///           Не следует использовать этот член.
		///           Он является открытым только из-за рефакторинга сборки и используется внутренне для оптимизации производительности.
		///       </summary>
		/// <param name="index">
		///           Индекс аргумента.
		///         </param>
		/// <returns>
		///         Возвращает <see cref="T:System.Linq.Expressions.Expression" />.
		///       </returns>
		// Token: 0x0600103F RID: 4159 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		Expression IArgumentProvider.GetArgument(int index)
		{
			throw ContractUtils.Unreachable;
		}

		/// <summary>
		///         Возвращает число аргументов для узла дерева выражения.
		///           Не следует использовать этот член.
		///           Он является открытым только из-за рефакторинга сборки и используется внутренне для оптимизации производительности.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Int32" />.
		///       </returns>
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		int IArgumentProvider.ArgumentCount
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>
		///         Создает выражение <see cref="T:System.Linq.Expressions.DynamicExpression" />, которое представляет динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />.
		///       </summary>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="returnType">
		///           Тип результата динамического выражения.
		///         </param>
		/// <param name="arguments">
		///           Аргументы динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001041 RID: 4161 RVA: 0x0003757D File Offset: 0x0003577D
		public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, params Expression[] arguments)
		{
			return ExpressionExtension.Dynamic(binder, returnType, arguments);
		}

		/// <summary>
		///         Создает выражение <see cref="T:System.Linq.Expressions.DynamicExpression" />, которое представляет динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />.
		///       </summary>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="returnType">
		///           Тип результата динамического выражения.
		///         </param>
		/// <param name="arguments">
		///           Аргументы динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001042 RID: 4162 RVA: 0x00037587 File Offset: 0x00035787
		public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments)
		{
			return ExpressionExtension.Dynamic(binder, returnType, arguments);
		}

		/// <summary>
		///         Создает выражение <see cref="T:System.Linq.Expressions.DynamicExpression" />, которое представляет динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />.
		///       </summary>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="returnType">
		///           Тип результата динамического выражения.
		///         </param>
		/// <param name="arg0">
		///           Первый аргумент динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001043 RID: 4163 RVA: 0x00037591 File Offset: 0x00035791
		public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0)
		{
			return ExpressionExtension.Dynamic(binder, returnType, arg0);
		}

		/// <summary>
		///         Создает выражение <see cref="T:System.Linq.Expressions.DynamicExpression" />, которое представляет динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />.
		///       </summary>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="returnType">
		///           Тип результата динамического выражения.
		///         </param>
		/// <param name="arg0">
		///           Первый аргумент динамической операции.
		///         </param>
		/// <param name="arg1">
		///           Второй аргумент динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001044 RID: 4164 RVA: 0x0003759B File Offset: 0x0003579B
		public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1)
		{
			return ExpressionExtension.Dynamic(binder, returnType, arg0, arg1);
		}

		/// <summary>
		///         Создает выражение <see cref="T:System.Linq.Expressions.DynamicExpression" />, которое представляет динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />.
		///       </summary>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="returnType">
		///           Тип результата динамического выражения.
		///         </param>
		/// <param name="arg0">
		///           Первый аргумент динамической операции.
		///         </param>
		/// <param name="arg1">
		///           Второй аргумент динамической операции.
		///         </param>
		/// <param name="arg2">
		///           Третий аргумент динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001045 RID: 4165 RVA: 0x000375A6 File Offset: 0x000357A6
		public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2)
		{
			return ExpressionExtension.Dynamic(binder, returnType, arg0, arg1, arg2);
		}

		/// <summary>
		///         Создает выражение <see cref="T:System.Linq.Expressions.DynamicExpression" />, которое представляет динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />.
		///       </summary>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="returnType">
		///           Тип результата динамического выражения.
		///         </param>
		/// <param name="arg0">
		///           Первый аргумент динамической операции.
		///         </param>
		/// <param name="arg1">
		///           Второй аргумент динамической операции.
		///         </param>
		/// <param name="arg2">
		///           Третий аргумент динамической операции.
		///         </param>
		/// <param name="arg3">
		///           Четвертый аргумент динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001046 RID: 4166 RVA: 0x000375B3 File Offset: 0x000357B3
		public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return ExpressionExtension.Dynamic(binder, returnType, arg0, arg1, arg2, arg3);
		}

		/// <summary>
		///         Создает выражение <see cref="T:System.Linq.Expressions.DynamicExpression" />, которое представляет динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />.
		///       </summary>
		/// <param name="delegateType">
		///           Тип делегата, используемого <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </param>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="arguments">
		///           Аргументы динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType" />, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001047 RID: 4167 RVA: 0x000375C2 File Offset: 0x000357C2
		public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments)
		{
			return ExpressionExtension.MakeDynamic(delegateType, binder, arguments);
		}

		/// <summary>
		///         Создает выражение <see cref="T:System.Linq.Expressions.DynamicExpression" />, которое представляет динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />.
		///       </summary>
		/// <param name="delegateType">
		///           Тип делегата, используемого <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </param>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="arguments">
		///           Аргументы динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType" />, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001048 RID: 4168 RVA: 0x000375CC File Offset: 0x000357CC
		public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, params Expression[] arguments)
		{
			return ExpressionExtension.MakeDynamic(delegateType, binder, arguments);
		}

		/// <summary>
		///         Создает объект <see cref="T:System.Linq.Expressions.DynamicExpression" />, представляющий динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" /> и одним аргументом.
		///       </summary>
		/// <param name="delegateType">
		///           Тип делегата, используемого <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </param>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="arg0">
		///           Аргумент динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType" />, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x06001049 RID: 4169 RVA: 0x000375D6 File Offset: 0x000357D6
		public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0)
		{
			return ExpressionExtension.MakeDynamic(delegateType, binder, arg0);
		}

		/// <summary>
		///         Создает объект <see cref="T:System.Linq.Expressions.DynamicExpression" />, представляющий динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" /> и двумя аргументами.
		///       </summary>
		/// <param name="delegateType">
		///           Тип делегата, используемого <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </param>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="arg0">
		///           Первый аргумент динамической операции.
		///         </param>
		/// <param name="arg1">
		///           Второй аргумент динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType" />, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x0600104A RID: 4170 RVA: 0x000375E0 File Offset: 0x000357E0
		public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
		{
			return ExpressionExtension.MakeDynamic(delegateType, binder, arg0, arg1);
		}

		/// <summary>
		///         Создает объект <see cref="T:System.Linq.Expressions.DynamicExpression" />, представляющий динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" /> и тремя аргументами.
		///       </summary>
		/// <param name="delegateType">
		///           Тип делегата, используемого <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </param>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="arg0">
		///           Первый аргумент динамической операции.
		///         </param>
		/// <param name="arg1">
		///           Второй аргумент динамической операции.
		///         </param>
		/// <param name="arg2">
		///           Третий аргумент динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType" />, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x0600104B RID: 4171 RVA: 0x000375EB File Offset: 0x000357EB
		public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
		{
			return ExpressionExtension.MakeDynamic(delegateType, binder, arg0, arg1, arg2);
		}

		/// <summary>
		///         Создает объект <see cref="T:System.Linq.Expressions.DynamicExpression" />, представляющий динамическую операцию, привязанную с использованием указанного объекта <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" /> и четырьмя аргументами.
		///       </summary>
		/// <param name="delegateType">
		///           Тип делегата, используемого <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </param>
		/// <param name="binder">
		///           Связыватель времени выполнения для динамической операции.
		///         </param>
		/// <param name="arg0">
		///           Первый аргумент динамической операции.
		///         </param>
		/// <param name="arg1">
		///           Второй аргумент динамической операции.
		///         </param>
		/// <param name="arg2">
		///           Третий аргумент динамической операции.
		///         </param>
		/// <param name="arg3">
		///           Четвертый аргумент динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.DynamicExpression" /> со свойством <see cref="P:System.Linq.Expressions.DynamicExpression.NodeType" />, равным <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic" />, и свойствами <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType" />, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder" /> и <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments" />, для которых заданы указанные значения.
		///       </returns>
		// Token: 0x0600104C RID: 4172 RVA: 0x000375F8 File Offset: 0x000357F8
		public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return ExpressionExtension.MakeDynamic(delegateType, binder, arg0, arg1, arg2, arg3);
		}

		/// <summary>
		///         Переопределите этот узел, заменив аргументы динамического выражения предоставленными значениями.
		///           Количество args должно совпадать с количеством аргументов в текущем выражении.
		///           Не следует использовать этот тип.
		///           Он является открытым только из-за рефакторинга сборки и используется внутренне для оптимизации производительности.
		///           Этот вспомогательный метод позволяет переопределять узлы независимо от конкретной реализации класса, производного от DynamicExpression, который используется на сайте вызова.
		///       </summary>
		/// <param name="args">
		///           Аргументы.
		///         </param>
		/// <returns>
		///         Возвращает переопределенное выражение <see cref="T:System.Linq.Expressions.Expression" />.
		///       </returns>
		// Token: 0x0600104D RID: 4173 RVA: 0x00037607 File Offset: 0x00035807
		Expression IDynamicExpression.Rewrite(Expression[] args)
		{
			return this.Rewrite(args);
		}

		/// <summary>
		///         При необходимости создает CallSite и возвращает этот CallSite для полиморфного встроенного кэша DynamicExpression.
		///           Не следует использовать этот член.
		///           Он является открытым только из-за рефакторинга сборки и используется внутренне для оптимизации производительности.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Object" />.
		///       </returns>
		// Token: 0x0600104E RID: 4174 RVA: 0x00037610 File Offset: 0x00035810
		object IDynamicExpression.CreateCallSite()
		{
			return CallSite.Create(this.DelegateType, this.Binder);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0000235B File Offset: 0x0000055B
		internal DynamicExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
