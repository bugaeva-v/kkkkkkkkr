using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую привязку и логику привязки объекта, участвующего в динамической привязке.
	///       </summary>
	// Token: 0x020002FD RID: 765
	public class DynamicMetaObject
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.DynamicMetaObject" />.
		///       </summary>
		/// <param name="expression">
		///           Выражение, представляющее это <see cref="T:System.Dynamic.DynamicMetaObject" /> в процессе динамической привязки.
		///         </param>
		/// <param name="restrictions">
		///           Набор ограничений, в которых привязка является допустимой привязки.
		///         </param>
		// Token: 0x0600170A RID: 5898 RVA: 0x0004D0D2 File Offset: 0x0004B2D2
		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions)
		{
			ContractUtils.RequiresNotNull(expression, "expression");
			ContractUtils.RequiresNotNull(restrictions, "restrictions");
			this.Expression = expression;
			this.Restrictions = restrictions;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.DynamicMetaObject" />.
		///       </summary>
		/// <param name="expression">
		///           Выражение, представляющее это <see cref="T:System.Dynamic.DynamicMetaObject" /> в процессе динамической привязки.
		///         </param>
		/// <param name="restrictions">
		///           Набор ограничений, в которых привязка является допустимой привязки.
		///         </param>
		/// <param name="value">
		///           Значение выполнения, представленное <see cref="T:System.Dynamic.DynamicMetaObject" />.
		///         </param>
		// Token: 0x0600170B RID: 5899 RVA: 0x0004D109 File Offset: 0x0004B309
		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value) : this(expression, restrictions)
		{
			this._value = value;
		}

		/// <summary>
		///         Выражения, представляющего <see cref="T:System.Dynamic.DynamicMetaObject" /> в процессе динамической привязки.
		///       </summary>
		/// <returns>
		///         Выражения, представляющего <see cref="T:System.Dynamic.DynamicMetaObject" /> в процессе динамической привязки.
		///       </returns>
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x0004D11A File Offset: 0x0004B31A
		public Expression Expression { get; }

		/// <summary>
		///         Набор ограничений, в которых привязка является допустимой привязки.
		///       </summary>
		/// <returns>
		///         Набор ограничений привязки.
		///       </returns>
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0004D122 File Offset: 0x0004B322
		public BindingRestrictions Restrictions { get; }

		/// <summary>
		///         Значение выполнения, представленный этим <see cref="T:System.Dynamic.DynamicMetaObject" />.
		///       </summary>
		/// <returns>
		///         Значение выполнения, представленный этим <see cref="T:System.Dynamic.DynamicMetaObject" />.
		///       </returns>
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0004D12A File Offset: 0x0004B32A
		public object Value
		{
			get
			{
				if (!this.HasValue)
				{
					return null;
				}
				return this._value;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, является ли <see cref="T:System.Dynamic.DynamicMetaObject" /> имеет значение времени выполнения.
		///       </summary>
		/// <returns>
		///         Значение true, если <see cref="T:System.Dynamic.DynamicMetaObject" /> имеет значение времени выполнения, в противном случае — значение false.
		///       </returns>
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0004D13C File Offset: 0x0004B33C
		public bool HasValue
		{
			get
			{
				return this._value != DynamicMetaObject.s_noValueSentinel;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Type" /> значение времени выполнения или значение null, если <see cref="T:System.Dynamic.DynamicMetaObject" /> Нет значения, связанные с ним.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Значение времени выполнения или значение null.
		///       </returns>
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x0004D150 File Offset: 0x0004B350
		public Type RuntimeType
		{
			get
			{
				if (!this.HasValue)
				{
					return null;
				}
				Type type = this.Expression.Type;
				if (type.IsValueType)
				{
					return type;
				}
				object value = this.Value;
				if (value == null)
				{
					return null;
				}
				return value.GetType();
			}
		}

		/// <summary>
		///         Возвращает тип ограничения <see cref="T:System.Dynamic.DynamicMetaObject" />.
		///       </summary>
		/// <returns>
		///         <see cref="P:System.Dynamic.DynamicMetaObject.RuntimeType" /> Если значение времени выполнения, тип <see cref="P:System.Dynamic.DynamicMetaObject.Expression" /> в противном случае.
		///       </returns>
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x0004D18E File Offset: 0x0004B38E
		public Type LimitType
		{
			get
			{
				return this.RuntimeType ?? this.Expression.Type;
			}
		}

		/// <summary>
		///         Выполняет привязку динамической операции преобразования.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.ConvertBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x06001712 RID: 5906 RVA: 0x0004D1A5 File Offset: 0x0004B3A5
		public virtual DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackConvert(this);
		}

		/// <summary>
		///         Выполняет привязку динамической операции получения члена.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.GetMemberBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x06001713 RID: 5907 RVA: 0x0004D1B9 File Offset: 0x0004B3B9
		public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackGetMember(this);
		}

		/// <summary>
		///         Выполняет привязку динамической операции задания члена.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.SetMemberBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <param name="value">
		///           <see cref="T:System.Dynamic.DynamicMetaObject" /> Представляет значение для операции задания члена.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x06001714 RID: 5908 RVA: 0x0004D1CD File Offset: 0x0004B3CD
		public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackSetMember(this, value);
		}

		/// <summary>
		///         Выполняет привязку динамической операции удаления члена.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.DeleteMemberBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x06001715 RID: 5909 RVA: 0x0004D1E2 File Offset: 0x0004B3E2
		public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackDeleteMember(this);
		}

		/// <summary>
		///         Выполняет привязку динамической операции получения индекса.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.GetIndexBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <param name="indexes">
		///           Массив <see cref="T:System.Dynamic.DynamicMetaObject" /> экземпляры - индексов для операции получения индекса.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x06001716 RID: 5910 RVA: 0x0004D1F6 File Offset: 0x0004B3F6
		public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackGetIndex(this, indexes);
		}

		/// <summary>
		///         Выполняет привязку динамической операции задания индекса.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.SetIndexBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <param name="indexes">
		///           Массив <see cref="T:System.Dynamic.DynamicMetaObject" /> экземпляры - индексов для операции задания индекса.
		///         </param>
		/// <param name="value">
		///           <see cref="T:System.Dynamic.DynamicMetaObject" /> Представляет значение для операции задания индекса.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x06001717 RID: 5911 RVA: 0x0004D20B File Offset: 0x0004B40B
		public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackSetIndex(this, indexes, value);
		}

		/// <summary>
		///         Выполняет привязку динамической операции удаления индекса.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.DeleteIndexBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <param name="indexes">
		///           Массив <see cref="T:System.Dynamic.DynamicMetaObject" /> экземпляры - индексов для операции удаления индекса.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x06001718 RID: 5912 RVA: 0x0004D221 File Offset: 0x0004B421
		public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackDeleteIndex(this, indexes);
		}

		/// <summary>
		///         Выполняет привязку динамической операции вызова члена.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.InvokeMemberBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <param name="args">
		///           Массив <see cref="T:System.Dynamic.DynamicMetaObject" /> экземпляры - аргументы операции вызова члена.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x06001719 RID: 5913 RVA: 0x0004D236 File Offset: 0x0004B436
		public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackInvokeMember(this, args);
		}

		/// <summary>
		///         Выполняет привязку динамической операции вызова.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.InvokeBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <param name="args">
		///           Массив <see cref="T:System.Dynamic.DynamicMetaObject" /> экземпляры - аргументы операции вызова.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x0600171A RID: 5914 RVA: 0x0004D24B File Offset: 0x0004B44B
		public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackInvoke(this, args);
		}

		/// <summary>
		///         Выполняет привязку динамической операции создания экземпляра.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.CreateInstanceBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <param name="args">
		///           Массив <see cref="T:System.Dynamic.DynamicMetaObject" /> экземпляры - аргументы для операции создания экземпляра.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x0600171B RID: 5915 RVA: 0x0004D260 File Offset: 0x0004B460
		public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackCreateInstance(this, args);
		}

		/// <summary>
		///         Выполняет привязку динамической унарной операции.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.UnaryOperationBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x0600171C RID: 5916 RVA: 0x0004D275 File Offset: 0x0004B475
		public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackUnaryOperation(this);
		}

		/// <summary>
		///         Выполняет привязку динамической бинарной операции.
		///       </summary>
		/// <param name="binder">
		///           Экземпляр <see cref="T:System.Dynamic.BinaryOperationBinder" /> представляющий сведения о динамической операции.
		///         </param>
		/// <param name="arg">
		///           Экземпляр <see cref="T:System.Dynamic.DynamicMetaObject" /> представляющий с правой стороны бинарной операции.
		///         </param>
		/// <returns>
		///         Новый <see cref="T:System.Dynamic.DynamicMetaObject" /> представляют результат привязки.
		///       </returns>
		// Token: 0x0600171D RID: 5917 RVA: 0x0004D289 File Offset: 0x0004B489
		public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackBinaryOperation(this, arg);
		}

		/// <summary>
		///         Возвращает перечисление всех имен динамических членов.
		///       </summary>
		/// <returns>
		///         Список имен динамических членов.
		///       </returns>
		// Token: 0x0600171E RID: 5918 RVA: 0x0004D29E File Offset: 0x0004B49E
		public virtual IEnumerable<string> GetDynamicMemberNames()
		{
			return Array.Empty<string>();
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0004D2A8 File Offset: 0x0004B4A8
		internal static Expression[] GetExpressions(DynamicMetaObject[] objects)
		{
			ContractUtils.RequiresNotNull(objects, "objects");
			Expression[] array = new Expression[objects.Length];
			for (int i = 0; i < objects.Length; i++)
			{
				DynamicMetaObject dynamicMetaObject = objects[i];
				ContractUtils.RequiresNotNull(dynamicMetaObject, "objects");
				Expression expression = dynamicMetaObject.Expression;
				array[i] = expression;
			}
			return array;
		}

		/// <summary>
		///         Создает объект метаданных для указанного объекта.
		///       </summary>
		/// <param name="value">
		///           Для получения объекта метаданных для объекта.
		///         </param>
		/// <param name="expression">
		///           Выражение, представляющее это <see cref="T:System.Dynamic.DynamicMetaObject" /> в процессе динамической привязки.
		///         </param>
		/// <returns>
		///         Если данный объект реализует интерфейс <see cref="T:System.Dynamic.IDynamicMetaObjectProvider" /> и не из удаленного объекта за пределами текущего домена приложения, возвращает объект определенного мета объект, возвращаемый <see cref="M:System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression)" />.
		///          В противном случае создается и возвращается обычный мета объекта без ограничений.
		///       </returns>
		// Token: 0x06001720 RID: 5920 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
		public static DynamicMetaObject Create(object value, Expression expression)
		{
			ContractUtils.RequiresNotNull(expression, "expression");
			IDynamicMetaObjectProvider dynamicMetaObjectProvider = value as IDynamicMetaObjectProvider;
			if (dynamicMetaObjectProvider == null)
			{
				return new DynamicMetaObject(expression, BindingRestrictions.Empty, value);
			}
			DynamicMetaObject metaObject = dynamicMetaObjectProvider.GetMetaObject(expression);
			if (metaObject == null || !metaObject.HasValue || metaObject.Value == null || metaObject.Expression != expression)
			{
				throw Error.InvalidMetaObjectCreated(dynamicMetaObjectProvider.GetType());
			}
			return metaObject;
		}

		/// <summary>
		///         Представляет пустой массив типа <see cref="T:System.Dynamic.DynamicMetaObject" />.
		///          Это поле доступно только для чтения.
		///       </summary>
		// Token: 0x04000B81 RID: 2945
		public static readonly DynamicMetaObject[] EmptyMetaObjects = Array.Empty<DynamicMetaObject>();

		// Token: 0x04000B82 RID: 2946
		private static readonly object s_noValueSentinel = new object();

		// Token: 0x04000B83 RID: 2947
		private readonly object _value = DynamicMetaObject.s_noValueSentinel;
	}
}
