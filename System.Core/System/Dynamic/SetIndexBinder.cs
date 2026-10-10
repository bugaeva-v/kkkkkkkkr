using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию установки индекса в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x0200031F RID: 799
	public abstract class SetIndexBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.SetIndexBinder" />.
		///       </summary>
		/// <param name="callInfo">
		///           Сигнатура аргументов на сайте вызова.
		///         </param>
		// Token: 0x0600180A RID: 6154 RVA: 0x0004FA7D File Offset: 0x0004DC7D
		protected SetIndexBinder(CallInfo callInfo)
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
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x000374E6 File Offset: 0x000356E6
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
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0004FA97 File Offset: 0x0004DC97
		public CallInfo CallInfo { get; }

		/// <summary>
		///         Выполняет привязку динамической операции задания индекса.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции задания индекса.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции задания индекса.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x0600180D RID: 6157 RVA: 0x0004FAA0 File Offset: 0x0004DCA0
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNull(args, "args");
			ContractUtils.Requires(args.Length >= 2, "args");
			DynamicMetaObject value = args[args.Length - 1];
			DynamicMetaObject[] array = args.RemoveLast<DynamicMetaObject>();
			ContractUtils.RequiresNotNull(value, "args");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(array, "args");
			return target.BindSetIndex(this, array, value);
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Выполняет привязку динамической операции задания индекса, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции задания индекса.
		///         </param>
		/// <param name="indexes">
		///           Аргументы динамической операции задания индекса.
		///         </param>
		/// <param name="value">
		///           Значение, задаваемое для коллекции.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x0600180F RID: 6159 RVA: 0x0004FB04 File Offset: 0x0004DD04
		public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			return this.FallbackSetIndex(target, indexes, value, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции задания индекса, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции задания индекса.
		///         </param>
		/// <param name="indexes">
		///           Аргументы динамической операции задания индекса.
		///         </param>
		/// <param name="value">
		///           Значение, задаваемое для коллекции.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001810 RID: 6160
		public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
	}
}
