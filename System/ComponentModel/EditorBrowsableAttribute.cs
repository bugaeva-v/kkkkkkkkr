using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, что свойство или метод можно просматривать в редакторе. Этот класс не наследуется.</summary>
	// Token: 0x0200035F RID: 863
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class EditorBrowsableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EditorBrowsableAttribute" />, используя объект <see cref="T:System.ComponentModel.EditorBrowsableState" />.</summary>
		/// <param name="state">Состояние <see cref="T:System.ComponentModel.EditorBrowsableState" />, устанавливаемое равным <see cref="P:System.ComponentModel.EditorBrowsableAttribute.State" />.</param>
		// Token: 0x06001CA8 RID: 7336 RVA: 0x0006797A File Offset: 0x00065B7A
		public EditorBrowsableAttribute(EditorBrowsableState state)
		{
			this.browsableState = state;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EditorBrowsableAttribute" />, используя состояние <see cref="P:System.ComponentModel.EditorBrowsableAttribute.State" />, равное состоянию по умолчанию.</summary>
		// Token: 0x06001CA9 RID: 7337 RVA: 0x00067989 File Offset: 0x00065B89
		public EditorBrowsableAttribute() : this(EditorBrowsableState.Always)
		{
		}

		/// <summary>Возвращает отображаемое состояние свойства или метода.</summary>
		/// <returns>Состояние <see cref="T:System.ComponentModel.EditorBrowsableState" />, являющееся отображаемым состоянием свойства или метода.</returns>
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00067992 File Offset: 0x00065B92
		public EditorBrowsableState State
		{
			get
			{
				return this.browsableState;
			}
		}

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.EditorBrowsableAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CAB RID: 7339 RVA: 0x0006799C File Offset: 0x00065B9C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			EditorBrowsableAttribute editorBrowsableAttribute = obj as EditorBrowsableAttribute;
			return editorBrowsableAttribute != null && editorBrowsableAttribute.browsableState == this.browsableState;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001CAC RID: 7340 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000E8C RID: 3724
		private EditorBrowsableState browsableState;
	}
}
