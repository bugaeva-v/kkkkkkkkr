using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию удаления индекса в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x020002FB RID: 763
	public abstract class DeleteIndexBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.DeleteIndexBinder" />.
		///       </summary>
		/// <param name="callInfo">
		///           Сигнатура аргументов на сайте вызова.
		///         </param>
		// Token: 0x060016FB RID: 5883 RVA: 0x0004D021 File Offset: 0x0004B221
		protected DeleteIndexBinder(CallInfo callInfo)
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
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x000358FE File Offset: 0x00033AFE
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(void);
			}
		}

		/// <summary>
		///         Получает сигнатуру аргументов на сайте вызова.
		///       </summary>
		/// <returns>
		///         Сигнатура аргументов на сайте вызова.
		///       </returns>
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x0004D03B File Offset: 0x0004B23B
		public CallInfo CallInfo { get; }

		/// <summary>
		///         Выполняет привязку динамической операции удаления индекса.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции удаления индекса.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции удаления индекса.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016FE RID: 5886 RVA: 0x0004D043 File Offset: 0x0004B243
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindDeleteIndex(this, args);
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Выполняет привязку динамической операции удаления индекса, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции удаления индекса.
		///         </param>
		/// <param name="indexes">
		///           Аргументы динамической операции удаления индекса.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001700 RID: 5888 RVA: 0x0004D063 File Offset: 0x0004B263
		public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
		{
			return this.FallbackDeleteIndex(target, indexes, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции удаления индекса, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции удаления индекса.
		///         </param>
		/// <param name="indexes">
		///           Аргументы динамической операции удаления индекса.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001701 RID: 5889
		public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
	}
}
