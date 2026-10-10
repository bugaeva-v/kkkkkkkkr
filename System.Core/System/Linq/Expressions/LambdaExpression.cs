using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Linq.Expressions.Compiler;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Описывает лямбда-выражение.
	///          Здесь фиксируется блок кода, аналогичный телу метода .NET.
	///       </summary>
	// Token: 0x0200026B RID: 619
	[DebuggerTypeProxy(typeof(Expression.LambdaExpressionProxy))]
	public abstract class LambdaExpression : Expression, IParameterProvider
	{
		// Token: 0x06001208 RID: 4616 RVA: 0x0003AEB1 File Offset: 0x000390B1
		internal LambdaExpression(Expression body)
		{
			this._body = body;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.LambdaExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0003AEC0 File Offset: 0x000390C0
		public sealed override Type Type
		{
			get
			{
				return this.TypeCore;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600120A RID: 4618
		internal abstract Type TypeCore { get; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600120B RID: 4619
		internal abstract Type PublicType { get; }

		/// <summary>
		///         Возвращает тип узла данного <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" />, представляющий данное выражение.
		///       </returns>
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0003AEC8 File Offset: 0x000390C8
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Lambda;
			}
		}

		/// <summary>
		///         Возвращает параметры лямбда-выражения.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> из <see cref="T:System.Linq.Expressions.ParameterExpression" /> объектов, которые представляют параметры лямбда-выражения.
		///       </returns>
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0003AECC File Offset: 0x000390CC
		public ReadOnlyCollection<ParameterExpression> Parameters
		{
			get
			{
				return this.GetOrMakeParameters();
			}
		}

		/// <summary>
		///         Возвращает имя лямбда-выражения.
		///       </summary>
		/// <returns>
		///         Имя лямбда-выражения.
		///       </returns>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x0003AED4 File Offset: 0x000390D4
		public string Name
		{
			get
			{
				return this.NameCore;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0000392D File Offset: 0x00001B2D
		internal virtual string NameCore
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///         Возвращает тело лямбда-выражения.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Представляющий тело лямбда-выражения.
		///       </returns>
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0003AEDC File Offset: 0x000390DC
		public Expression Body
		{
			get
			{
				return this._body;
			}
		}

		/// <summary>
		///         Возвращает возвращаемый тип лямбда-выражения.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Объект, представляющий тип лямбда-выражения.
		///       </returns>
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0003AEE4 File Offset: 0x000390E4
		public Type ReturnType
		{
			get
			{
				return this.Type.GetInvokeMethod().ReturnType;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, что лямбда-выражения компилируются с оптимизацию вызовов с префиксом tail.
		///       </summary>
		/// <returns>
		///         Значение true, если лямбда-выражения компилируются с помощью заключительного вызова оптимизации, в противном случае — значение false.
		///       </returns>
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0003AEF6 File Offset: 0x000390F6
		public bool TailCall
		{
			get
			{
				return this.TailCallCore;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000023D1 File Offset: 0x000005D1
		internal virtual bool TailCallCore
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeParameters()
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0003AEFE File Offset: 0x000390FE
		[ExcludeFromCodeCoverage]
		ParameterExpression IParameterProvider.GetParameter(int index)
		{
			return this.GetParameter(index);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual ParameterExpression GetParameter(int index)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0003AF07 File Offset: 0x00039107
		[ExcludeFromCodeCoverage]
		int IParameterProvider.ParameterCount
		{
			get
			{
				return this.ParameterCount;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual int ParameterCount
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>
		///         Создает делегат, представляющий лямбда-выражение.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Delegate" /> содержащий скомпилированную версию лямбда-выражения.
		///       </returns>
		// Token: 0x06001219 RID: 4633 RVA: 0x0003AF0F File Offset: 0x0003910F
		public Delegate Compile()
		{
			return this.Compile(false);
		}

		/// <summary>
		///         Создает интерпретированный или скомпилированный делегат, который представляет лямбда-выражение.
		///       </summary>
		/// <param name="preferInterpretation">
		///           <see langword="true" />, чтобы указать, что выражение должно быть скомпилировано в интерпретируемой форме, если она доступна; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Делегат, представляющий скомпилированное лямбда-выражение, описанное объектом <see cref="T:System.Linq.Expressions.LambdaExpression" />.
		///       </returns>
		// Token: 0x0600121A RID: 4634 RVA: 0x0003AF18 File Offset: 0x00039118
		public Delegate Compile(bool preferInterpretation)
		{
			return LambdaCompiler.Compile(this);
		}

		/// <summary>
		///         Компилирует лямбда-выражение в определение метода.
		///       </summary>
		/// <param name="method">
		///           A <see cref="T:System.Reflection.Emit.MethodBuilder" /> которого будет использоваться для хранения IL лямбда-выражения.
		///         </param>
		// Token: 0x0600121B RID: 4635 RVA: 0x0003AF20 File Offset: 0x00039120
		public void CompileToMethod(MethodBuilder method)
		{
			ContractUtils.RequiresNotNull(method, "method");
			ContractUtils.Requires(method.IsStatic, "method");
			if (method.DeclaringType as TypeBuilder == null)
			{
				throw Error.MethodBuilderDoesNotHaveTypeBuilder();
			}
			LambdaCompiler.Compile(this, method);
		}

		// Token: 0x0600121C RID: 4636
		internal abstract LambdaExpression Accept(StackSpiller spiller);

		/// <summary>
		///         Создает делегат, представляющий лямбда-выражение.
		///       </summary>
		/// <param name="debugInfoGenerator">
		///           Генератор отладочной информации, используемый компилятором для пометки точек следования и аннотировать локальных переменных.
		///         </param>
		/// <returns>
		///         Делегат, содержащий скомпилированную версию лямбда-выражения.
		///       </returns>
		// Token: 0x0600121D RID: 4637 RVA: 0x0003AF5D File Offset: 0x0003915D
		public Delegate Compile(DebugInfoGenerator debugInfoGenerator)
		{
			return this.Compile();
		}

		/// <summary>
		///         Компилирует лямбда-выражение в определение метода и пользовательскую отладочную информацию.
		///       </summary>
		/// <param name="method">
		///           A <see cref="T:System.Reflection.Emit.MethodBuilder" /> которого будет использоваться для хранения IL лямбда-выражения.
		///         </param>
		/// <param name="debugInfoGenerator">
		///           Генератор отладочной информации, используемый компилятором для пометки точек следования и аннотировать локальных переменных.
		///         </param>
		// Token: 0x0600121E RID: 4638 RVA: 0x0003AF65 File Offset: 0x00039165
		public void CompileToMethod(MethodBuilder method, DebugInfoGenerator debugInfoGenerator)
		{
			this.CompileToMethod(method);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0000235B File Offset: 0x0000055B
		internal LambdaExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000A0D RID: 2573
		private readonly Expression _body;
	}
}
