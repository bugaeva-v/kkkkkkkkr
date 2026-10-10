using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию вызова в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x0200031D RID: 797
	public abstract class InvokeBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.InvokeBinder" />.
		///       </summary>
		/// <param name="callInfo">
		///           Сигнатура аргументов на сайте вызова.
		///         </param>
		// Token: 0x060017F9 RID: 6137 RVA: 0x0004F9BA File Offset: 0x0004DBBA
		protected InvokeBinder(CallInfo callInfo)
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
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x000374E6 File Offset: 0x000356E6
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
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x0004F9D4 File Offset: 0x0004DBD4
		public CallInfo CallInfo { get; }

		/// <summary>
		///         Выполняет привязку динамической операции вызова, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции вызова.
		///         </param>
		/// <param name="args">
		///           Аргументы динамической операции вызова.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017FC RID: 6140 RVA: 0x0004F9DC File Offset: 0x0004DBDC
		public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return this.FallbackInvoke(target, args, null);
		}

		/// <summary>
		///         Выполняет привязку динамической операции вызова, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции вызова.
		///         </param>
		/// <param name="args">
		///           Аргументы динамической операции вызова.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017FD RID: 6141
		public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		/// <summary>
		///         Выполняет привязку динамической операции вызова.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции вызова.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции вызова.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017FE RID: 6142 RVA: 0x0004F9E7 File Offset: 0x0004DBE7
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindInvoke(this, args);
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}
	}
}
