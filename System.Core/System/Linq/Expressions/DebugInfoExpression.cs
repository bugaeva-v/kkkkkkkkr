using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Создает или очищает точку последовательности для информации об отладке.
	///          Это позволяет отладчику выделить правильный исходный код при отладке.
	///       </summary>
	// Token: 0x02000243 RID: 579
	[DebuggerTypeProxy(typeof(Expression.DebugInfoExpressionProxy))]
	public class DebugInfoExpression : Expression
	{
		// Token: 0x06000FC5 RID: 4037 RVA: 0x000358EF File Offset: 0x00033AEF
		internal DebugInfoExpression(SymbolDocumentInfo document)
		{
			this.Document = document;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.DebugInfoExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x000358FE File Offset: 0x00033AFE
		public sealed override Type Type
		{
			get
			{
				return typeof(void);
			}
		}

		/// <summary>
		///         Возвращает тип узла данного <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" />, представляющий данное выражение.
		///       </returns>
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0003590A File Offset: 0x00033B0A
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.DebugInfo;
			}
		}

		/// <summary>
		///         Возвращает начальную строку <see cref="T:System.Linq.Expressions.DebugInfoExpression" />.
		///       </summary>
		/// <returns>
		///         Номер начальной строки кода, который был использован для заключенное в оболочку выражение.
		///       </returns>
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		public virtual int StartLine
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>
		///         Возвращает начальный столбец данного выражения <see cref="T:System.Linq.Expressions.DebugInfoExpression" />.
		///       </summary>
		/// <returns>
		///         Номер начального столбца кода, который был использован для заключенное в оболочку выражение.
		///       </returns>
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		public virtual int StartColumn
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>
		///         Получает конечную строку <see cref="T:System.Linq.Expressions.DebugInfoExpression" />.
		///       </summary>
		/// <returns>
		///         Номер конечной строки кода, который был использован для заключенное в оболочку выражение.
		///       </returns>
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		public virtual int EndLine
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>
		///         Получает конечный столбец данного выражения <see cref="T:System.Linq.Expressions.DebugInfoExpression" />.
		///       </summary>
		/// <returns>
		///         Номер конечного столбца кода, которое было создано заключенное в оболочку выражение.
		///       </returns>
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		public virtual int EndColumn
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Linq.Expressions.SymbolDocumentInfo" /> представляющий исходный файл.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.SymbolDocumentInfo" />, представляющий исходный файл.
		///       </returns>
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0003590E File Offset: 0x00033B0E
		public SymbolDocumentInfo Document { get; }

		/// <summary>
		///         Возвращает значение, указывающее, если <see cref="T:System.Linq.Expressions.DebugInfoExpression" /> для очистки точки последовательности.
		///       </summary>
		/// <returns>
		///         Значение true, если <see cref="T:System.Linq.Expressions.DebugInfoExpression" /> для очистки точки последовательности, в противном случае — значение false.
		///       </returns>
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		public virtual bool IsClear
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
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
		// Token: 0x06000FCE RID: 4046 RVA: 0x00035916 File Offset: 0x00033B16
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitDebugInfo(this);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0000235B File Offset: 0x0000055B
		internal DebugInfoExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
