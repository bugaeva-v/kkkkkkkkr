using System;
using System.Diagnostics;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет выражение именованного параметра.
	///       </summary>
	// Token: 0x02000291 RID: 657
	[DebuggerTypeProxy(typeof(Expression.ParameterExpressionProxy))]
	public class ParameterExpression : Expression
	{
		// Token: 0x06001304 RID: 4868 RVA: 0x0003C5C7 File Offset: 0x0003A7C7
		internal ParameterExpression(string name)
		{
			this.Name = name;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0003C5D8 File Offset: 0x0003A7D8
		internal static ParameterExpression Make(Type type, string name, bool isByRef)
		{
			if (isByRef)
			{
				return new ByRefParameterExpression(type, name);
			}
			if (!type.IsEnum)
			{
				switch (type.GetTypeCode())
				{
				case TypeCode.Object:
					if (type == typeof(object))
					{
						return new ParameterExpression(name);
					}
					if (type == typeof(Exception))
					{
						return new PrimitiveParameterExpression<Exception>(name);
					}
					if (type == typeof(object[]))
					{
						return new PrimitiveParameterExpression<object[]>(name);
					}
					break;
				case TypeCode.Boolean:
					return new PrimitiveParameterExpression<bool>(name);
				case TypeCode.Char:
					return new PrimitiveParameterExpression<char>(name);
				case TypeCode.SByte:
					return new PrimitiveParameterExpression<sbyte>(name);
				case TypeCode.Byte:
					return new PrimitiveParameterExpression<byte>(name);
				case TypeCode.Int16:
					return new PrimitiveParameterExpression<short>(name);
				case TypeCode.UInt16:
					return new PrimitiveParameterExpression<ushort>(name);
				case TypeCode.Int32:
					return new PrimitiveParameterExpression<int>(name);
				case TypeCode.UInt32:
					return new PrimitiveParameterExpression<uint>(name);
				case TypeCode.Int64:
					return new PrimitiveParameterExpression<long>(name);
				case TypeCode.UInt64:
					return new PrimitiveParameterExpression<ulong>(name);
				case TypeCode.Single:
					return new PrimitiveParameterExpression<float>(name);
				case TypeCode.Double:
					return new PrimitiveParameterExpression<double>(name);
				case TypeCode.Decimal:
					return new PrimitiveParameterExpression<decimal>(name);
				case TypeCode.DateTime:
					return new PrimitiveParameterExpression<DateTime>(name);
				case TypeCode.String:
					return new PrimitiveParameterExpression<string>(name);
				}
			}
			return new TypedParameterExpression(type, name);
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.ParameterExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x000374E6 File Offset: 0x000356E6
		public override Type Type
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>
		///         Возвращает тип узла данного <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" />, представляющий данное выражение.
		///       </returns>
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x0003C712 File Offset: 0x0003A912
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Parameter;
			}
		}

		/// <summary>
		///         Возвращает имя параметра или переменной.
		///       </summary>
		/// <returns>
		///         Строка <see cref="T:System.String" />, где содержится имя параметра.
		///       </returns>
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0003C716 File Offset: 0x0003A916
		public string Name { get; }

		/// <summary>
		///         Указывает, что эта ParameterExpression следует рассматривать <see langword="ByRef" /> параметр.
		///       </summary>
		/// <returns>
		///         Значение true, если ParameterExpression является <see langword="ByRef" /> параметром, в противном случае — false.
		///       </returns>
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x0003C71E File Offset: 0x0003A91E
		public bool IsByRef
		{
			get
			{
				return this.GetIsByRef();
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000023D1 File Offset: 0x000005D1
		internal virtual bool GetIsByRef()
		{
			return false;
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
		// Token: 0x0600130B RID: 4875 RVA: 0x0003C726 File Offset: 0x0003A926
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitParameter(this);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0000235B File Offset: 0x0000055B
		internal ParameterExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
