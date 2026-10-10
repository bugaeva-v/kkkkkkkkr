using System;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Используется для представления объекта <see cref="T:System.Linq.Expressions.GotoExpression" />.
	///       </summary>
	// Token: 0x0200026A RID: 618
	public sealed class LabelTarget
	{
		// Token: 0x06001203 RID: 4611 RVA: 0x0003AE70 File Offset: 0x00039070
		internal LabelTarget(Type type, string name)
		{
			this.Type = type;
			this.Name = name;
		}

		/// <summary>
		///         Получает имя метки.
		///       </summary>
		/// <returns>
		///         Имя метки.
		///       </returns>
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x0003AE86 File Offset: 0x00039086
		public string Name { get; }

		/// <summary>
		///         Тип значения, которое передается при переходе к метке (или <see cref="T:System.Void" /> Если значение не должно быть передано).
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Объект, представляющий тип значения, которое передается при переходе к метке или <see cref="T:System.Void" /> Если значение не должно быть передано
		///       </returns>
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0003AE8E File Offset: 0x0003908E
		public Type Type { get; }

		/// <summary>
		///         Возвращает строку <see cref="T:System.String" />, которая представляет текущий объект <see cref="T:System.Object" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.String" />, представляющий текущий объект <see cref="T:System.Object" />.
		///       </returns>
		// Token: 0x06001206 RID: 4614 RVA: 0x0003AE96 File Offset: 0x00039096
		public override string ToString()
		{
			if (!string.IsNullOrEmpty(this.Name))
			{
				return this.Name;
			}
			return "UnamedLabel";
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0000235B File Offset: 0x0000055B
		internal LabelTarget()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
