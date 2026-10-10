using System;

namespace System.Drawing.Imaging
{
	/// <summary>Инкапсулирует свойство метаданных, включаемое в файл изображения. Не наследуется.</summary>
	// Token: 0x02000114 RID: 276
	public sealed class PropertyItem
	{
		// Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
		internal PropertyItem()
		{
		}

		/// <summary>Получает или задает идентификатор свойства.</summary>
		/// <returns>Целое число, отражающее идентификатор свойства.</returns>
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0001DCDC File Offset: 0x0001BEDC
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
		public int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}

		/// <summary>Получает или задает длину в байтах для свойства <see cref="P:System.Drawing.Imaging.PropertyItem.Value" />.</summary>
		/// <returns>Целое число, представляющее длину в байтах для массива байтов <see cref="P:System.Drawing.Imaging.PropertyItem.Value" />.</returns>
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0001DCED File Offset: 0x0001BEED
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x0001DCF5 File Offset: 0x0001BEF5
		public int Len
		{
			get
			{
				return this._len;
			}
			set
			{
				this._len = value;
			}
		}

		/// <summary>Получает или задает целочисленное значение, определяющее тип данных, которые содержатся в свойстве <see cref="P:System.Drawing.Imaging.PropertyItem.Value" />.</summary>
		/// <returns>Целочисленное значение, определяющее тип данных, которые содержатся в свойстве <see cref="P:System.Drawing.Imaging.PropertyItem.Value" />.</returns>
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0001DCFE File Offset: 0x0001BEFE
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x0001DD06 File Offset: 0x0001BF06
		public short Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}

		/// <summary>Получает или задает значение свойства.</summary>
		/// <returns>Массив байтов, представляющий значение свойства.</returns>
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0001DD0F File Offset: 0x0001BF0F
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x0001DD17 File Offset: 0x0001BF17
		public byte[] Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x04000A37 RID: 2615
		private int _id;

		// Token: 0x04000A38 RID: 2616
		private int _len;

		// Token: 0x04000A39 RID: 2617
		private short _type;

		// Token: 0x04000A3A RID: 2618
		private byte[] _value;
	}
}
