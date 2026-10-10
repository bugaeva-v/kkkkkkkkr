using System;
using System.Dynamic.Utils;
using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет бинарную динамическую операцию в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x020002EF RID: 751
	public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.BinaryOperationBinder" />.
		///       </summary>
		/// <param name="operation">
		///           Вид бинарной операции.
		///         </param>
		// Token: 0x060016BC RID: 5820 RVA: 0x0004C864 File Offset: 0x0004AA64
		protected BinaryOperationBinder(ExpressionType operation)
		{
			ContractUtils.Requires(BinaryOperationBinder.OperationIsValid(operation), "operation");
			this.Operation = operation;
		}

		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Тип результата операции.
		///       </returns>
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x000374E6 File Offset: 0x000356E6
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>
		///         Вид бинарной операции.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.ExpressionType" /> Объект, представляющий тип бинарной операции.
		///       </returns>
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x0004C883 File Offset: 0x0004AA83
		public ExpressionType Operation { get; }

		/// <summary>
		///         Выполняет привязку динамической бинарной операции, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической бинарной операции.
		///         </param>
		/// <param name="arg">
		///           Правый операнд динамической бинарной операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016BF RID: 5823 RVA: 0x0004C88B File Offset: 0x0004AA8B
		public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg)
		{
			return this.FallbackBinaryOperation(target, arg, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической бинарной операции, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической бинарной операции.
		///         </param>
		/// <param name="arg">
		///           Правый операнд динамической бинарной операции.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки в случае привязки, или значение null.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016C0 RID: 5824
		public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

		/// <summary>
		///         Выполняет привязку динамической бинарной операции.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016C1 RID: 5825 RVA: 0x0004C898 File Offset: 0x0004AA98
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNull(args, "args");
			ContractUtils.Requires(args.Length == 1, "args");
			DynamicMetaObject dynamicMetaObject = args[0];
			ContractUtils.RequiresNotNull(dynamicMetaObject, "args");
			return target.BindBinaryOperation(this, dynamicMetaObject);
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0004C8E4 File Offset: 0x0004AAE4
		internal static bool OperationIsValid(ExpressionType operation)
		{
			if (operation <= ExpressionType.Multiply)
			{
				if (operation != ExpressionType.Add && operation != ExpressionType.And)
				{
					switch (operation)
					{
					case ExpressionType.Divide:
					case ExpressionType.Equal:
					case ExpressionType.ExclusiveOr:
					case ExpressionType.GreaterThan:
					case ExpressionType.GreaterThanOrEqual:
					case ExpressionType.LeftShift:
					case ExpressionType.LessThan:
					case ExpressionType.LessThanOrEqual:
					case ExpressionType.Modulo:
					case ExpressionType.Multiply:
						break;
					case ExpressionType.Invoke:
					case ExpressionType.Lambda:
					case ExpressionType.ListInit:
					case ExpressionType.MemberAccess:
					case ExpressionType.MemberInit:
						return false;
					default:
						return false;
					}
				}
			}
			else
			{
				switch (operation)
				{
				case ExpressionType.NotEqual:
				case ExpressionType.Or:
				case ExpressionType.Power:
				case ExpressionType.RightShift:
				case ExpressionType.Subtract:
					break;
				case ExpressionType.OrElse:
				case ExpressionType.Parameter:
				case ExpressionType.Quote:
					return false;
				default:
					if (operation != ExpressionType.Extension && operation - ExpressionType.AddAssign > 10)
					{
						return false;
					}
					break;
				}
			}
			return true;
		}
	}
}
