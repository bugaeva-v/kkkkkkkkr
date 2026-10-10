using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет посетителя или модуль записи для деревьев выражений.
	///       </summary>
	// Token: 0x0200025A RID: 602
	public abstract class ExpressionVisitor
	{
		/// <summary>
		///         Отправляет выражение с одним или более узких методов просмотра в данном классе.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001182 RID: 4482 RVA: 0x0003A016 File Offset: 0x00038216
		public virtual Expression Visit(Expression node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Accept(this);
		}

		/// <summary>
		///         Отправляет список выражений для одного или более узких методов просмотра в данном классе.
		///       </summary>
		/// <param name="nodes">
		///           Выражения для посещения.
		///         </param>
		/// <returns>
		///         Измененный список выражений в случае изменения одного из элементов; в противном случае возвращается исходный список выражение.
		///       </returns>
		// Token: 0x06001183 RID: 4483 RVA: 0x0003A024 File Offset: 0x00038224
		public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
		{
			ContractUtils.RequiresNotNull(nodes, "nodes");
			Expression[] array = null;
			int i = 0;
			int count = nodes.Count;
			while (i < count)
			{
				Expression expression = this.Visit(nodes[i]);
				if (array != null)
				{
					array[i] = expression;
				}
				else if (expression != nodes[i])
				{
					array = new Expression[count];
					for (int j = 0; j < i; j++)
					{
						array[j] = nodes[j];
					}
					array[i] = expression;
				}
				i++;
			}
			if (array == null)
			{
				return nodes;
			}
			return new TrueReadOnlyCollection<Expression>(array);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0003A0A4 File Offset: 0x000382A4
		private Expression[] VisitArguments(IArgumentProvider nodes)
		{
			return ExpressionVisitorUtils.VisitArguments(this, nodes);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0003A0AD File Offset: 0x000382AD
		private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName)
		{
			return ExpressionVisitorUtils.VisitParameters(this, nodes, callerName);
		}

		/// <summary>
		///         Посещает все узлы в коллекции с помощью посетителя указанного элемента.
		///       </summary>
		/// <param name="nodes">
		///           Узлы посетить.
		///         </param>
		/// <param name="elementVisitor">
		///           Делегат, который просматривает отдельный элемент, при необходимости заменяя его новым элементом.
		///         </param>
		/// <typeparam name="T">
		///           Типы узлов.
		///         </typeparam>
		/// <returns>
		///         Измененный список узлов, если были изменены какие-либо элементы; в противном случае — возвращает исходный список узлов.
		///       </returns>
		// Token: 0x06001186 RID: 4486 RVA: 0x0003A0B8 File Offset: 0x000382B8
		public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
		{
			ContractUtils.RequiresNotNull(nodes, "nodes");
			ContractUtils.RequiresNotNull(elementVisitor, "elementVisitor");
			T[] array = null;
			int i = 0;
			int count = nodes.Count;
			while (i < count)
			{
				T t = elementVisitor(nodes[i]);
				if (array != null)
				{
					array[i] = t;
				}
				else if (t != nodes[i])
				{
					array = new T[count];
					for (int j = 0; j < i; j++)
					{
						array[j] = nodes[j];
					}
					array[i] = t;
				}
				i++;
			}
			if (array == null)
			{
				return nodes;
			}
			return new TrueReadOnlyCollection<T>(array);
		}

		/// <summary>
		///         Просматривает выражение, приводя результат к типу исходного выражения.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <param name="callerName">
		///           Имя вызывающего метода. используется для отчетов и отчетов сообщение об ошибке.
		///         </param>
		/// <typeparam name="T">
		///           Тип выражения.
		///         </typeparam>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Метод visit для данного узла вернул другой тип.
		///           </exception>
		// Token: 0x06001187 RID: 4487 RVA: 0x0003A15C File Offset: 0x0003835C
		public T VisitAndConvert<T>(T node, string callerName) where T : Expression
		{
			if (node == null)
			{
				return default(T);
			}
			node = (this.Visit(node) as T);
			if (node == null)
			{
				throw Error.MustRewriteToSameNode(callerName, typeof(T), callerName);
			}
			return node;
		}

		/// <summary>
		///         Просматривает выражение, приводя результат к типу исходного выражения.
		///       </summary>
		/// <param name="nodes">
		///           Выражение для посещения.
		///         </param>
		/// <param name="callerName">
		///           Имя вызывающего метода. используется для отчетов и отчетов сообщение об ошибке.
		///         </param>
		/// <typeparam name="T">
		///           Тип выражения.
		///         </typeparam>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Метод visit для данного узла вернул другой тип.
		///           </exception>
		// Token: 0x06001188 RID: 4488 RVA: 0x0003A1B0 File Offset: 0x000383B0
		public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
		{
			ContractUtils.RequiresNotNull(nodes, "nodes");
			T[] array = null;
			int i = 0;
			int count = nodes.Count;
			while (i < count)
			{
				T t = this.Visit(nodes[i]) as T;
				if (t == null)
				{
					throw Error.MustRewriteToSameNode(callerName, typeof(T), callerName);
				}
				if (array != null)
				{
					array[i] = t;
				}
				else if (t != nodes[i])
				{
					array = new T[count];
					for (int j = 0; j < i; j++)
					{
						array[j] = nodes[j];
					}
					array[i] = t;
				}
				i++;
			}
			if (array == null)
			{
				return nodes;
			}
			return new TrueReadOnlyCollection<T>(array);
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.BinaryExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001189 RID: 4489 RVA: 0x0003A275 File Offset: 0x00038475
		protected internal virtual Expression VisitBinary(BinaryExpression node)
		{
			return ExpressionVisitor.ValidateBinary(node, node.Update(this.Visit(node.Left), this.VisitAndConvert<LambdaExpression>(node.Conversion, "VisitBinary"), this.Visit(node.Right)));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.BlockExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600118A RID: 4490 RVA: 0x0003A2AC File Offset: 0x000384AC
		protected internal virtual Expression VisitBlock(BlockExpression node)
		{
			Expression[] array = ExpressionVisitorUtils.VisitBlockExpressions(this, node);
			ReadOnlyCollection<ParameterExpression> readOnlyCollection = this.VisitAndConvert<ParameterExpression>(node.Variables, "VisitBlock");
			if (readOnlyCollection == node.Variables && array == null)
			{
				return node;
			}
			return node.Rewrite(readOnlyCollection, array);
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.ConditionalExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600118B RID: 4491 RVA: 0x0003A2E9 File Offset: 0x000384E9
		protected internal virtual Expression VisitConditional(ConditionalExpression node)
		{
			return node.Update(this.Visit(node.Test), this.Visit(node.IfTrue), this.Visit(node.IfFalse));
		}

		/// <summary>
		///         Посещает <see cref="T:System.Linq.Expressions.ConstantExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600118C RID: 4492 RVA: 0x000022AA File Offset: 0x000004AA
		protected internal virtual Expression VisitConstant(ConstantExpression node)
		{
			return node;
		}

		/// <summary>
		///         Посещает <see cref="T:System.Linq.Expressions.DebugInfoExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600118D RID: 4493 RVA: 0x000022AA File Offset: 0x000004AA
		protected internal virtual Expression VisitDebugInfo(DebugInfoExpression node)
		{
			return node;
		}

		/// <summary>
		///         Посещает <see cref="T:System.Linq.Expressions.DefaultExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600118E RID: 4494 RVA: 0x000022AA File Offset: 0x000004AA
		protected internal virtual Expression VisitDefault(DefaultExpression node)
		{
			return node;
		}

		/// <summary>
		///         Просматривает дочерний элемент выражения расширения.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600118F RID: 4495 RVA: 0x0003A315 File Offset: 0x00038515
		protected internal virtual Expression VisitExtension(Expression node)
		{
			return node.VisitChildren(this);
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.GotoExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001190 RID: 4496 RVA: 0x0003A31E File Offset: 0x0003851E
		protected internal virtual Expression VisitGoto(GotoExpression node)
		{
			return node.Update(this.VisitLabelTarget(node.Target), this.Visit(node.Value));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.InvocationExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001191 RID: 4497 RVA: 0x0003A340 File Offset: 0x00038540
		protected internal virtual Expression VisitInvocation(InvocationExpression node)
		{
			Expression expression = this.Visit(node.Expression);
			Expression[] array = this.VisitArguments(node);
			if (expression == node.Expression && array == null)
			{
				return node;
			}
			return node.Rewrite(expression, array);
		}

		/// <summary>
		///         Посещает <see cref="T:System.Linq.Expressions.LabelTarget" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001192 RID: 4498 RVA: 0x000022AA File Offset: 0x000004AA
		protected virtual LabelTarget VisitLabelTarget(LabelTarget node)
		{
			return node;
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.LabelExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001193 RID: 4499 RVA: 0x0003A378 File Offset: 0x00038578
		protected internal virtual Expression VisitLabel(LabelExpression node)
		{
			return node.Update(this.VisitLabelTarget(node.Target), this.Visit(node.DefaultValue));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.Expression`1" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата.
		///         </typeparam>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001194 RID: 4500 RVA: 0x0003A398 File Offset: 0x00038598
		protected internal virtual Expression VisitLambda<T>(Expression<T> node)
		{
			Expression expression = this.Visit(node.Body);
			ParameterExpression[] array = this.VisitParameters(node, "VisitLambda");
			if (expression == node.Body && array == null)
			{
				return node;
			}
			return node.Rewrite(expression, array);
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.LoopExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001195 RID: 4501 RVA: 0x0003A3D5 File Offset: 0x000385D5
		protected internal virtual Expression VisitLoop(LoopExpression node)
		{
			return node.Update(this.VisitLabelTarget(node.BreakLabel), this.VisitLabelTarget(node.ContinueLabel), this.Visit(node.Body));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.MemberExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001196 RID: 4502 RVA: 0x0003A401 File Offset: 0x00038601
		protected internal virtual Expression VisitMember(MemberExpression node)
		{
			return node.Update(this.Visit(node.Expression));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.IndexExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001197 RID: 4503 RVA: 0x0003A418 File Offset: 0x00038618
		protected internal virtual Expression VisitIndex(IndexExpression node)
		{
			Expression expression = this.Visit(node.Object);
			Expression[] array = this.VisitArguments(node);
			if (expression == node.Object && array == null)
			{
				return node;
			}
			return node.Rewrite(expression, array);
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.MethodCallExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001198 RID: 4504 RVA: 0x0003A450 File Offset: 0x00038650
		protected internal virtual Expression VisitMethodCall(MethodCallExpression node)
		{
			Expression expression = this.Visit(node.Object);
			Expression[] array = this.VisitArguments(node);
			if (expression == node.Object && array == null)
			{
				return node;
			}
			return node.Rewrite(expression, array);
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.NewArrayExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001199 RID: 4505 RVA: 0x0003A488 File Offset: 0x00038688
		protected internal virtual Expression VisitNewArray(NewArrayExpression node)
		{
			return node.Update(this.Visit(node.Expressions));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.NewExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600119A RID: 4506 RVA: 0x0003A49C File Offset: 0x0003869C
		protected internal virtual Expression VisitNew(NewExpression node)
		{
			Expression[] array = this.VisitArguments(node);
			if (array == null)
			{
				return node;
			}
			return node.Update(array);
		}

		/// <summary>
		///         Посещает <see cref="T:System.Linq.Expressions.ParameterExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600119B RID: 4507 RVA: 0x000022AA File Offset: 0x000004AA
		protected internal virtual Expression VisitParameter(ParameterExpression node)
		{
			return node;
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.RuntimeVariablesExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600119C RID: 4508 RVA: 0x0003A4BD File Offset: 0x000386BD
		protected internal virtual Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
		{
			return node.Update(this.VisitAndConvert<ParameterExpression>(node.Variables, "VisitRuntimeVariables"));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.SwitchCase" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600119D RID: 4509 RVA: 0x0003A4D6 File Offset: 0x000386D6
		protected virtual SwitchCase VisitSwitchCase(SwitchCase node)
		{
			return node.Update(this.Visit(node.TestValues), this.Visit(node.Body));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.SwitchExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600119E RID: 4510 RVA: 0x0003A4F6 File Offset: 0x000386F6
		protected internal virtual Expression VisitSwitch(SwitchExpression node)
		{
			return ExpressionVisitor.ValidateSwitch(node, node.Update(this.Visit(node.SwitchValue), ExpressionVisitor.Visit<SwitchCase>(node.Cases, new Func<SwitchCase, SwitchCase>(this.VisitSwitchCase)), this.Visit(node.DefaultBody)));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.CatchBlock" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x0600119F RID: 4511 RVA: 0x0003A534 File Offset: 0x00038734
		protected virtual CatchBlock VisitCatchBlock(CatchBlock node)
		{
			return node.Update(this.VisitAndConvert<ParameterExpression>(node.Variable, "VisitCatchBlock"), this.Visit(node.Filter), this.Visit(node.Body));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.TryExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A0 RID: 4512 RVA: 0x0003A568 File Offset: 0x00038768
		protected internal virtual Expression VisitTry(TryExpression node)
		{
			return node.Update(this.Visit(node.Body), ExpressionVisitor.Visit<CatchBlock>(node.Handlers, new Func<CatchBlock, CatchBlock>(this.VisitCatchBlock)), this.Visit(node.Finally), this.Visit(node.Fault));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.TypeBinaryExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A1 RID: 4513 RVA: 0x0003A5B7 File Offset: 0x000387B7
		protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node)
		{
			return node.Update(this.Visit(node.Expression));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.UnaryExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A2 RID: 4514 RVA: 0x0003A5CB File Offset: 0x000387CB
		protected internal virtual Expression VisitUnary(UnaryExpression node)
		{
			return ExpressionVisitor.ValidateUnary(node, node.Update(this.Visit(node.Operand)));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.MemberInitExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A3 RID: 4515 RVA: 0x0003A5E5 File Offset: 0x000387E5
		protected internal virtual Expression VisitMemberInit(MemberInitExpression node)
		{
			return node.Update(this.VisitAndConvert<NewExpression>(node.NewExpression, "VisitMemberInit"), ExpressionVisitor.Visit<MemberBinding>(node.Bindings, new Func<MemberBinding, MemberBinding>(this.VisitMemberBinding)));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.ListInitExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A4 RID: 4516 RVA: 0x0003A616 File Offset: 0x00038816
		protected internal virtual Expression VisitListInit(ListInitExpression node)
		{
			return node.Update(this.VisitAndConvert<NewExpression>(node.NewExpression, "VisitListInit"), ExpressionVisitor.Visit<ElementInit>(node.Initializers, new Func<ElementInit, ElementInit>(this.VisitElementInit)));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.ElementInit" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A5 RID: 4517 RVA: 0x0003A647 File Offset: 0x00038847
		protected virtual ElementInit VisitElementInit(ElementInit node)
		{
			return node.Update(this.Visit(node.Arguments));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.MemberBinding" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A6 RID: 4518 RVA: 0x0003A65C File Offset: 0x0003885C
		protected virtual MemberBinding VisitMemberBinding(MemberBinding node)
		{
			switch (node.BindingType)
			{
			case MemberBindingType.Assignment:
				return this.VisitMemberAssignment((MemberAssignment)node);
			case MemberBindingType.MemberBinding:
				return this.VisitMemberMemberBinding((MemberMemberBinding)node);
			case MemberBindingType.ListBinding:
				return this.VisitMemberListBinding((MemberListBinding)node);
			default:
				throw Error.UnhandledBindingType(node.BindingType);
			}
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.MemberAssignment" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A7 RID: 4519 RVA: 0x0003A6BB File Offset: 0x000388BB
		protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment node)
		{
			return node.Update(this.Visit(node.Expression));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.MemberMemberBinding" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A8 RID: 4520 RVA: 0x0003A6CF File Offset: 0x000388CF
		protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
		{
			return node.Update(ExpressionVisitor.Visit<MemberBinding>(node.Bindings, new Func<MemberBinding, MemberBinding>(this.VisitMemberBinding)));
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.MemberListBinding" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011A9 RID: 4521 RVA: 0x0003A6EF File Offset: 0x000388EF
		protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding node)
		{
			return node.Update(ExpressionVisitor.Visit<ElementInit>(node.Initializers, new Func<ElementInit, ElementInit>(this.VisitElementInit)));
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0003A710 File Offset: 0x00038910
		private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after)
		{
			if (before != after && before.Method == null)
			{
				if (after.Method != null)
				{
					throw Error.MustRewriteWithoutMethod(after.Method, "VisitUnary");
				}
				if (before.Operand != null && after.Operand != null)
				{
					ExpressionVisitor.ValidateChildType(before.Operand.Type, after.Operand.Type, "VisitUnary");
				}
			}
			return after;
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0003A780 File Offset: 0x00038980
		private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after)
		{
			if (before != after && before.Method == null)
			{
				if (after.Method != null)
				{
					throw Error.MustRewriteWithoutMethod(after.Method, "VisitBinary");
				}
				ExpressionVisitor.ValidateChildType(before.Left.Type, after.Left.Type, "VisitBinary");
				ExpressionVisitor.ValidateChildType(before.Right.Type, after.Right.Type, "VisitBinary");
			}
			return after;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0003A7FF File Offset: 0x000389FF
		private static SwitchExpression ValidateSwitch(SwitchExpression before, SwitchExpression after)
		{
			if (before.Comparison == null && after.Comparison != null)
			{
				throw Error.MustRewriteWithoutMethod(after.Comparison, "VisitSwitch");
			}
			return after;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0003A82F File Offset: 0x00038A2F
		private static void ValidateChildType(Type before, Type after, string methodName)
		{
			if (before.IsValueType)
			{
				if (TypeUtils.AreEquivalent(before, after))
				{
					return;
				}
			}
			else if (!after.IsValueType)
			{
				return;
			}
			throw Error.MustRewriteChildToSameType(before, after, methodName);
		}

		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.DynamicExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Измененное выражение, если был изменен или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x060011AE RID: 4526 RVA: 0x0003A854 File Offset: 0x00038A54
		protected internal virtual Expression VisitDynamic(DynamicExpression node)
		{
			Expression[] array = this.VisitArguments(node);
			if (array == null)
			{
				return node;
			}
			return node.Rewrite(array);
		}
	}
}
