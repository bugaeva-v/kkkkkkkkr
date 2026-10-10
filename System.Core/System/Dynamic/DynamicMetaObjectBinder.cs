using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Linq.Expressions.Compiler;
using System.Runtime.CompilerServices;

namespace System.Dynamic
{
	/// <summary>
	///         Привязки узла динамического вызова, который участвует в <see cref="T:System.Dynamic.DynamicMetaObject" /> протокол привязки.
	///       </summary>
	// Token: 0x020002FE RID: 766
	public abstract class DynamicMetaObjectBinder : CallSiteBinder
	{
		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип результата операции.
		///       </returns>
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x000374E6 File Offset: 0x000356E6
		public virtual Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>
		///         Выполняет привязку динамической операции на набор аргументов среды выполнения.
		///       </summary>
		/// <param name="args">
		///           Массив аргументов динамической операции.
		///         </param>
		/// <param name="parameters">
		///           Массив <see cref="T:System.Linq.Expressions.ParameterExpression" /> экземпляры, которые представляют параметры вызова в процессе привязки.
		///         </param>
		/// <param name="returnLabel">
		///           Элемент LabelTarget возвращают результат динамической привязки.
		///         </param>
		/// <returns>
		///         Выражение, проверяющее аргументы динамической операции и выполняющее эту операцию, если проверки пройдены успешно.
		///          Если тесты будут завершаться при последующих выполнениях динамической операции, привязка будет снова вызван для создания нового <see cref="T:System.Linq.Expressions.Expression" /> для новых типов аргументов.
		///       </returns>
		// Token: 0x06001724 RID: 5924 RVA: 0x0004D370 File Offset: 0x0004B570
		public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel)
		{
			ContractUtils.RequiresNotNull(args, "args");
			ContractUtils.RequiresNotNull(parameters, "parameters");
			ContractUtils.RequiresNotNull(returnLabel, "returnLabel");
			if (args.Length == 0)
			{
				throw Error.OutOfRange("args.Length", 1);
			}
			if (parameters.Count == 0)
			{
				throw Error.OutOfRange("parameters.Count", 1);
			}
			if (args.Length != parameters.Count)
			{
				throw new ArgumentOutOfRangeException("args");
			}
			Type type;
			if (this.IsStandardBinder)
			{
				type = this.ReturnType;
				if (returnLabel.Type != typeof(void) && !TypeUtils.AreReferenceAssignable(returnLabel.Type, type))
				{
					throw Error.BinderNotCompatibleWithCallSite(type, this, returnLabel.Type);
				}
			}
			else
			{
				type = returnLabel.Type;
			}
			DynamicMetaObject dynamicMetaObject = DynamicMetaObject.Create(args[0], parameters[0]);
			DynamicMetaObject[] args2 = DynamicMetaObjectBinder.CreateArgumentMetaObjects(args, parameters);
			DynamicMetaObject dynamicMetaObject2 = this.Bind(dynamicMetaObject, args2);
			if (dynamicMetaObject2 == null)
			{
				throw Error.BindingCannotBeNull();
			}
			Expression expression = dynamicMetaObject2.Expression;
			BindingRestrictions restrictions = dynamicMetaObject2.Restrictions;
			if (type != typeof(void) && !TypeUtils.AreReferenceAssignable(type, expression.Type))
			{
				if (dynamicMetaObject.Value is IDynamicMetaObjectProvider)
				{
					throw Error.DynamicObjectResultNotAssignable(expression.Type, dynamicMetaObject.Value.GetType(), this, type);
				}
				throw Error.DynamicBinderResultNotAssignable(expression.Type, this, type);
			}
			else
			{
				if (this.IsStandardBinder && args[0] is IDynamicMetaObjectProvider && restrictions == BindingRestrictions.Empty)
				{
					throw Error.DynamicBindingNeedsRestrictions(dynamicMetaObject.Value.GetType(), this);
				}
				if (expression.NodeType != ExpressionType.Goto)
				{
					expression = Expression.Return(returnLabel, expression);
				}
				if (restrictions != BindingRestrictions.Empty)
				{
					expression = Expression.IfThen(restrictions.ToExpression(), expression);
				}
				return expression;
			}
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0004D510 File Offset: 0x0004B710
		private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters)
		{
			DynamicMetaObject[] array;
			if (args.Length != 1)
			{
				array = new DynamicMetaObject[args.Length - 1];
				for (int i = 1; i < args.Length; i++)
				{
					array[i - 1] = DynamicMetaObject.Create(args[i], parameters[i]);
				}
			}
			else
			{
				array = DynamicMetaObject.EmptyMetaObjects;
			}
			return array;
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции.
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
		// Token: 0x06001726 RID: 5926
		public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

		/// <summary>
		///         Возвращает выражение, которое вызовет обновление привязки.
		///          Указывает, что привязка выражения больше не действительна.
		///          Обычно это используется «версией» динамический объект был изменен.
		///       </summary>
		/// <param name="type">
		///           <see cref="P:System.Linq.Expressions.Expression.Type" /> Свойства результирующего выражения; может быть любого типа.
		///         </param>
		/// <returns>
		///         Выражение обновления.
		///       </returns>
		// Token: 0x06001727 RID: 5927 RVA: 0x0004D559 File Offset: 0x0004B759
		public Expression GetUpdateExpression(Type type)
		{
			return Expression.Goto(CallSiteBinder.UpdateLabel, type);
		}

		/// <summary>
		///         Откладывает привязки операции до позднее время, когда после вычисления значений времени выполнения всех аргументов динамической операции.
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
		// Token: 0x06001728 RID: 5928 RVA: 0x0004D568 File Offset: 0x0004B768
		public DynamicMetaObject Defer(DynamicMetaObject target, params DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			if (args == null)
			{
				return this.MakeDeferred(target.Restrictions, new DynamicMetaObject[]
				{
					target
				});
			}
			return this.MakeDeferred(target.Restrictions.Merge(BindingRestrictions.Combine(args)), args.AddFirst(target));
		}

		/// <summary>
		///         Откладывает привязки операции до позднее время, когда после вычисления значений времени выполнения всех аргументов динамической операции.
		///       </summary>
		/// <param name="args">
		///           Массив аргументов динамической операции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001729 RID: 5929 RVA: 0x0004D5B8 File Offset: 0x0004B7B8
		public DynamicMetaObject Defer(params DynamicMetaObject[] args)
		{
			return this.MakeDeferred(BindingRestrictions.Combine(args), args);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0004D5C8 File Offset: 0x0004B7C8
		private DynamicMetaObject MakeDeferred(BindingRestrictions rs, params DynamicMetaObject[] args)
		{
			Expression[] expressions = DynamicMetaObject.GetExpressions(args);
			Type delegateType = DelegateHelpers.MakeDeferredSiteDelegate(args, this.ReturnType);
			return new DynamicMetaObject(DynamicExpression.Make(this.ReturnType, delegateType, this, new TrueReadOnlyCollection<Expression>(expressions)), rs);
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x000023D1 File Offset: 0x000005D1
		internal virtual bool IsStandardBinder
		{
			get
			{
				return false;
			}
		}
	}
}
