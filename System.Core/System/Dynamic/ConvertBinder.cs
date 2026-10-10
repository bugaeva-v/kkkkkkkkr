using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию преобразования в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x020002F9 RID: 761
	public abstract class ConvertBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.ConvertBinder" />.
		///       </summary>
		/// <param name="type">
		///           Целевой тип преобразования.
		///         </param>
		/// <param name="explicit">
		///           Значение true, если преобразование должно быть явным; в противном случае — значение false.
		///         </param>
		// Token: 0x060016EC RID: 5868 RVA: 0x0004CF68 File Offset: 0x0004B168
		protected ConvertBinder(Type type, bool @explicit)
		{
			ContractUtils.RequiresNotNull(type, "type");
			this.Type = type;
			this.Explicit = @explicit;
		}

		/// <summary>
		///         Целевой тип преобразования.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Представляющий тип для преобразования.
		///       </returns>
		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x0004CF89 File Offset: 0x0004B189
		public Type Type { get; }

		/// <summary>
		///         Возвращает значение, указывающее, если преобразование должно быть явным.
		///       </summary>
		/// <returns>
		///         <see langword="True" /> Если существует явное преобразование, в противном случае <see langword="false" />.
		///       </returns>
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0004CF91 File Offset: 0x0004B191
		public bool Explicit { get; }

		/// <summary>
		///         Выполняет привязку динамической операции преобразования, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции преобразования.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016EF RID: 5871 RVA: 0x0004CF99 File Offset: 0x0004B199
		public DynamicMetaObject FallbackConvert(DynamicMetaObject target)
		{
			return this.FallbackConvert(target, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции преобразования, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции преобразования.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016F0 RID: 5872
		public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		/// <summary>
		///         Выполняет привязку динамической операции преобразования.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции преобразования.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции преобразования.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016F1 RID: 5873 RVA: 0x0004CFA3 File Offset: 0x0004B1A3
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.Requires(args == null || args.Length == 0, "args");
			return target.BindConvert(this);
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип результата операции.
		///       </returns>
		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0004CFCC File Offset: 0x0004B1CC
		public sealed override Type ReturnType
		{
			get
			{
				return this.Type;
			}
		}
	}
}
