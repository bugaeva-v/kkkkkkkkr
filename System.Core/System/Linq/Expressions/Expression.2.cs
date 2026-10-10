using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Linq.Expressions.Compiler;
using System.Runtime.CompilerServices;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет строго типизированное лямбда-выражение как структуру данных в виде дерева выражений.
	///          Этот класс не наследуется.
	///       </summary>
	/// <typeparam name="TDelegate">
	///           Тип делегата, <see cref="T:System.Linq.Expressions.Expression`1" /> представляет.
	///         </typeparam>
	// Token: 0x0200026C RID: 620
	public class Expression<TDelegate> : LambdaExpression
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x0003AF6E File Offset: 0x0003916E
		internal Expression(Expression body) : base(body)
		{
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x0000BEAA File Offset: 0x0000A0AA
		internal sealed override Type TypeCore
		{
			get
			{
				return typeof(TDelegate);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x0003AF77 File Offset: 0x00039177
		internal override Type PublicType
		{
			get
			{
				return typeof(Expression<TDelegate>);
			}
		}

		/// <summary>
		///         Компилирует лямбда-выражение, описанное с помощью дерева выражений в исполняемый код и создает делегат, представляющий лямбда-выражение.
		///       </summary>
		/// <returns>
		///         Делегат типа <paramref name="TDelegate" /> представляющий скомпилированный лямбда-выражение, описываемых <see cref="T:System.Linq.Expressions.Expression`1" />.
		///       </returns>
		// Token: 0x06001223 RID: 4643 RVA: 0x0003AF83 File Offset: 0x00039183
		public new TDelegate Compile()
		{
			return this.Compile(false);
		}

		/// <summary>
		///         Компилирует лямбда-выражение, описанное с помощью дерева выражений, в интерпретированный или скомпилированный код и создает делегат, представляющий лямбда-выражение.
		///       </summary>
		/// <param name="preferInterpretation">
		///           <see langword="true" />, чтобы указать, что выражение должно быть скомпилировано в интерпретированную форму, если она доступна; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Делегат, представляющий скомпилированное лямбда-выражение, описанное <see cref="T:System.Linq.Expressions.Expression`1" />.
		///       </returns>
		// Token: 0x06001224 RID: 4644 RVA: 0x0003AF8C File Offset: 0x0003918C
		public new TDelegate Compile(bool preferInterpretation)
		{
			return (TDelegate)((object)LambdaCompiler.Compile(this));
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="body">
		///           <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> Свойства результата.
		///         </param>
		/// <param name="parameters">
		///           <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001225 RID: 4645 RVA: 0x0003AF9C File Offset: 0x0003919C
		public Expression<TDelegate> Update(Expression body, IEnumerable<ParameterExpression> parameters)
		{
			if (body == base.Body)
			{
				ICollection<ParameterExpression> collection;
				if (parameters == null)
				{
					collection = null;
				}
				else
				{
					collection = (parameters as ICollection<ParameterExpression>);
					if (collection == null)
					{
						collection = (parameters = parameters.ToReadOnly<ParameterExpression>());
					}
				}
				if (this.SameParameters(collection))
				{
					return this;
				}
			}
			return Expression.Lambda<TDelegate>(body, base.Name, base.TailCall, parameters);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual bool SameParameters(ICollection<ParameterExpression> parameters)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0003AFEB File Offset: 0x000391EB
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitLambda<TDelegate>(this);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0003AFF4 File Offset: 0x000391F4
		internal override LambdaExpression Accept(StackSpiller spiller)
		{
			return spiller.Rewrite<TDelegate>(this);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0003B000 File Offset: 0x00039200
		internal static Expression<TDelegate> Create(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters)
		{
			if (name != null || tailCall)
			{
				return new FullExpression<TDelegate>(body, name, tailCall, parameters);
			}
			switch (parameters.Count)
			{
			case 0:
				return new Expression0<TDelegate>(body);
			case 1:
				return new Expression1<TDelegate>(body, parameters[0]);
			case 2:
				return new Expression2<TDelegate>(body, parameters[0], parameters[1]);
			case 3:
				return new Expression3<TDelegate>(body, parameters[0], parameters[1], parameters[2]);
			default:
				return new ExpressionN<TDelegate>(body, parameters);
			}
		}

		/// <summary>
		///         Создает делегат, представляющий лямбда-выражение.
		///       </summary>
		/// <param name="debugInfoGenerator">
		///           Генератор отладочной информации, используемый компилятором для пометки точек следования и аннотировать локальных переменных.
		///         </param>
		/// <returns>
		///         Делегат, содержащий скомпилированную версию лямбда-выражения.
		///       </returns>
		// Token: 0x0600122B RID: 4651 RVA: 0x0003B089 File Offset: 0x00039289
		public new TDelegate Compile(DebugInfoGenerator debugInfoGenerator)
		{
			return this.Compile();
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0000235B File Offset: 0x0000055B
		internal Expression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
