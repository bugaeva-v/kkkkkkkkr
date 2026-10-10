using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию получения индекса в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x02000319 RID: 793
	public abstract class GetIndexBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.GetIndexBinder" />.
		///       </summary>
		/// <param name="callInfo">
		///           Сигнатура аргументов на сайте вызова.
		///         </param>
		// Token: 0x060017E8 RID: 6120 RVA: 0x0004F909 File Offset: 0x0004DB09
		protected GetIndexBinder(CallInfo callInfo)
		{
			ContractUtils.RequiresNotNull(callInfo, "callInfo");
			this.CallInfo = callInfo;
		}

		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип результата операции.
		///       </returns>
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x000374E6 File Offset: 0x000356E6
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>
		///         Получает сигнатуру аргументов на сайте вызова.
		///       </summary>
		/// <returns>
		///         Сигнатура аргументов на сайте вызова.
		///       </returns>
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0004F923 File Offset: 0x0004DB23
		public CallInfo CallInfo { get; }

		/// <summary>
		///         Выполняет привязку динамической операции получения индекса.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции получения индекса.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции получения индекса.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017EB RID: 6123 RVA: 0x0004F92B File Offset: 0x0004DB2B
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindGetIndex(this, args);
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Выполняет привязку динамической операции получения индекса, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции получения индекса.
		///         </param>
		/// <param name="indexes">
		///           Аргументы динамической операции получения индекса.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017ED RID: 6125 RVA: 0x0004F94B File Offset: 0x0004DB4B
		public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
		{
			return this.FallbackGetIndex(target, indexes, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции получения индекса, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции получения индекса.
		///         </param>
		/// <param name="indexes">
		///           Аргументы динамической операции получения индекса.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017EE RID: 6126
		public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
	}
}
