using System;
using System.Dynamic.Utils;
using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет унарную динамическую операцию в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x02000321 RID: 801
	public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.BinaryOperationBinder" />.
		///       </summary>
		/// <param name="operation">
		///           Вид унарной операции.
		///         </param>
		// Token: 0x06001819 RID: 6169 RVA: 0x0004FB99 File Offset: 0x0004DD99
		protected UnaryOperationBinder(ExpressionType operation)
		{
			ContractUtils.Requires(UnaryOperationBinder.OperationIsValid(operation), "operation");
			this.Operation = operation;
		}

		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип результата операции.
		///       </returns>
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0004FBB8 File Offset: 0x0004DDB8
		public sealed override Type ReturnType
		{
			get
			{
				ExpressionType operation = this.Operation;
				if (operation - ExpressionType.IsTrue <= 1)
				{
					return typeof(bool);
				}
				return typeof(object);
			}
		}

		/// <summary>
		///         Вид унарной операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" /> представляющий вид унарной операции.
		///       </returns>
		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x0004FBE8 File Offset: 0x0004DDE8
		public ExpressionType Operation { get; }

		/// <summary>
		///         Выполняет привязку динамической унарной операции, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической унарной операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x0600181C RID: 6172 RVA: 0x0004FBF0 File Offset: 0x0004DDF0
		public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target)
		{
			return this.FallbackUnaryOperation(target, null);
		}

		/// <summary>
		///         Выполняет привязку динамической унарной операции, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической унарной операции.
		///         </param>
		/// <param name="errorSuggestion">
		///           Привязка привести в случае сбоя привязки или значение null.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x0600181D RID: 6173
		public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		/// <summary>
		///         Выполняет привязку динамической унарной операции.
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
		// Token: 0x0600181E RID: 6174 RVA: 0x0004FBFA File Offset: 0x0004DDFA
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.Requires(args == null || args.Length == 0, "args");
			return target.BindUnaryOperation(this);
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0004FC23 File Offset: 0x0004DE23
		internal static bool OperationIsValid(ExpressionType operation)
		{
			if (operation <= ExpressionType.Decrement)
			{
				if (operation - ExpressionType.Negate > 1 && operation != ExpressionType.Not && operation != ExpressionType.Decrement)
				{
					return false;
				}
			}
			else if (operation != ExpressionType.Extension && operation != ExpressionType.Increment && operation - ExpressionType.OnesComplement > 2)
			{
				return false;
			}
			return true;
		}
	}
}
