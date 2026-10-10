using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Обнаруживает атрибуты локальной переменной и предоставляет доступ к ее метаданным.</summary>
	// Token: 0x020008EF RID: 2287
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public class LocalVariableInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.LocalVariableInfo" />.</summary>
		// Token: 0x06004CAB RID: 19627 RVA: 0x0000259F File Offset: 0x0000079F
		protected LocalVariableInfo()
		{
		}

		/// <summary>Получает значение <see cref="T:System.Boolean" />, определяющее, закреплен ли в памяти объект, на который ссылается локальная переменная.</summary>
		/// <returns>Значение <see langword="true" />, если объект, на который ссылается локальная переменная, закреплен в памяти; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06004CAC RID: 19628 RVA: 0x000F3105 File Offset: 0x000F1305
		public virtual bool IsPinned
		{
			get
			{
				return this.is_pinned;
			}
		}

		/// <summary>Возвращает индекс локальной переменной в основном тексте метода.</summary>
		/// <returns>Целочисленное значение, которое представляет последовательность объявления локальной переменной в основном тексте метода.</returns>
		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06004CAD RID: 19629 RVA: 0x000F310D File Offset: 0x000F130D
		public virtual int LocalIndex
		{
			get
			{
				return (int)this.position;
			}
		}

		/// <summary>Возвращает тип локальной переменной.</summary>
		/// <returns>Тип локальной переменной.</returns>
		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06004CAE RID: 19630 RVA: 0x000F3115 File Offset: 0x000F1315
		public virtual Type LocalType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Возвращает понятную для пользователя строку, описывающую локальную переменную.</summary>
		/// <returns>Строка, отображающая сведения о локальной переменной, включая имя типа, индекс и состояние закрепленности.</returns>
		// Token: 0x06004CAF RID: 19631 RVA: 0x000F3120 File Offset: 0x000F1320
		public override string ToString()
		{
			if (this.is_pinned)
			{
				return string.Format("{0} ({1}) (pinned)", this.type, this.position);
			}
			return string.Format("{0} ({1})", this.type, this.position);
		}

		// Token: 0x04003032 RID: 12338
		internal Type type;

		// Token: 0x04003033 RID: 12339
		internal bool is_pinned;

		// Token: 0x04003034 RID: 12340
		internal ushort position;
	}
}
