using System;
using System.ComponentModel;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет данные для метода <see cref="M:System.Drawing.Design.UITypeEditor.PaintValue(System.Object,System.Drawing.Graphics,System.Drawing.Rectangle)" />.</summary>
	// Token: 0x02000125 RID: 293
	public class PaintValueEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.PaintValueEventArgs" /> с помощью указанных значений.</summary>
		/// <param name="context">Контекст, в котором выступает значение.</param>
		/// <param name="value">Значение для рисования.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, которым выполняется рисование.</param>
		/// <param name="bounds">Объект <see cref="T:System.Drawing.Rectangle" />, в котором выполняется рисование.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="graphics" /> — <see langword="null" />.</exception>
		// Token: 0x06000D99 RID: 3481 RVA: 0x0001EFDA File Offset: 0x0001D1DA
		public PaintValueEventArgs(ITypeDescriptorContext context, object value, Graphics graphics, Rectangle bounds)
		{
			this.context = context;
			this.valueToPaint = value;
			this.graphics = graphics;
			if (graphics == null)
			{
				throw new ArgumentNullException("graphics");
			}
			this.bounds = bounds;
		}

		/// <summary>Возвращает прямоугольник, определяющий область, в котором должно выполняться рисование.</summary>
		/// <returns>Прямоугольник, определяющий область, в котором должно выполняться рисование.</returns>
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0001F00D File Offset: 0x0001D20D
		public Rectangle Bounds
		{
			get
			{
				return this.bounds;
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемое для получения дополнительных сведений о контексте изображаемого значения.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, определяющий контекст события.</returns>
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0001F015 File Offset: 0x0001D215
		public ITypeDescriptorContext Context
		{
			get
			{
				return this.context;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Graphics" />, при помощи которого должно выполняться рисование.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Graphics" />, используемый для рисования.</returns>
		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0001F01D File Offset: 0x0001D21D
		public Graphics Graphics
		{
			get
			{
				return this.graphics;
			}
		}

		/// <summary>Возвращает значение для рисования.</summary>
		/// <returns>Объект, определяющий предмет рисования.</returns>
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0001F025 File Offset: 0x0001D225
		public object Value
		{
			get
			{
				return this.valueToPaint;
			}
		}

		// Token: 0x04000A9B RID: 2715
		private readonly ITypeDescriptorContext context;

		// Token: 0x04000A9C RID: 2716
		private readonly object valueToPaint;

		// Token: 0x04000A9D RID: 2717
		private readonly Graphics graphics;

		// Token: 0x04000A9E RID: 2718
		private readonly Rectangle bounds;
	}
}
