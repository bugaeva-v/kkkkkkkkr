using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace System.Drawing
{
	/// <summary>Определяет объект, используемый для рисования прямых линий и кривых. Этот класс не наследуется.</summary>
	// Token: 0x02000085 RID: 133
	public sealed class Pen : MarshalByRefObject, ICloneable, IDisposable
	{
		// Token: 0x06000645 RID: 1605 RVA: 0x00012F0A File Offset: 0x0001110A
		internal Pen(IntPtr p)
		{
			this.nativeObject = p;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Drawing.Pen" /> с заданным объектом <see cref="T:System.Drawing.Brush" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий свойства заполнения объекта <see cref="T:System.Drawing.Pen" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="brush" /> — <see langword="null" />.</exception>
		// Token: 0x06000646 RID: 1606 RVA: 0x00012F20 File Offset: 0x00011120
		public Pen(Brush brush) : this(brush, 1f)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Pen" /> с указанным цветом.</summary>
		/// <param name="color">Структура <see cref="T:System.Drawing.Color" />, показывающая цвет объекта <see cref="T:System.Drawing.Pen" />.</param>
		// Token: 0x06000647 RID: 1607 RVA: 0x00012F2E File Offset: 0x0001112E
		public Pen(Color color) : this(color, 1f)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Drawing.Pen" /> с заданными объектами <see cref="T:System.Drawing.Brush" /> и <see cref="P:System.Drawing.Pen.Width" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий характеристики данного объекта <see cref="T:System.Drawing.Pen" />.</param>
		/// <param name="width">Ширина нового пера <see cref="T:System.Drawing.Pen" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="brush" /> — <see langword="null" />.</exception>
		// Token: 0x06000648 RID: 1608 RVA: 0x00012F3C File Offset: 0x0001113C
		public Pen(Brush brush, float width)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePen2(brush.NativeBrush, width, GraphicsUnit.World, out this.nativeObject));
			this.color = Color.Empty;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Pen" /> с указанными свойствами <see cref="T:System.Drawing.Color" /> и <see cref="P:System.Drawing.Pen.Width" />.</summary>
		/// <param name="color">Структура <see cref="T:System.Drawing.Color" />, показывающая цвет объекта <see cref="T:System.Drawing.Pen" />.</param>
		/// <param name="width">Значение, показывающее ширину объекта <see cref="T:System.Drawing.Pen" />.</param>
		// Token: 0x06000649 RID: 1609 RVA: 0x00012F7C File Offset: 0x0001117C
		public Pen(Color color, float width)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePen1(color.ToArgb(), width, GraphicsUnit.World, out this.nativeObject));
			this.color = color;
		}

		/// <summary>Получает или задает выравнивание объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.Drawing2D.PenAlignment" />, представляющая выравнивание объекта <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Заданное значение отсутствует в перечислении <see cref="T:System.Drawing.Drawing2D.PenAlignment" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.Alignment" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00012FAC File Offset: 0x000111AC
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00012FCC File Offset: 0x000111CC
		[MonoLimitation("Libgdiplus doesn't use this property for rendering")]
		public PenAlignment Alignment
		{
			get
			{
				PenAlignment result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenMode(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (value < PenAlignment.Center || value > PenAlignment.Right)
				{
					throw new InvalidEnumArgumentException("Alignment", (int)value, typeof(PenAlignment));
				}
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenMode(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Drawing.Brush" />, определяющий атрибуты объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Brush" />, определяющий атрибуты объекта <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.Brush" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00013020 File Offset: 0x00011220
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00013048 File Offset: 0x00011248
		public Brush Brush
		{
			get
			{
				IntPtr nativeBrush;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenBrushFill(this.nativeObject, out nativeBrush));
				return new SolidBrush(nativeBrush);
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Brush");
				}
				if (!this.isModifiable)
				{
					throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPenBrushFill(this.nativeObject, value.NativeBrush));
				this.color = Color.Empty;
			}
		}

		/// <summary>Получает или задает цвет объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.Color" />, представляющая цвет объекта <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.Color" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0001309C File Offset: 0x0001129C
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x000130DF File Offset: 0x000112DF
		public Color Color
		{
			get
			{
				if (this.color.Equals(Color.Empty))
				{
					int argb;
					GDIPlus.CheckStatus(GDIPlus.GdipGetPenColor(this.nativeObject, out argb));
					this.color = Color.FromArgb(argb);
				}
				return this.color;
			}
			set
			{
				if (!this.isModifiable)
				{
					throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPenColor(this.nativeObject, value.ToArgb()));
				this.color = value;
			}
		}

		/// <summary>Получает или задает массив значений, определяющий составное перо. Составное перо рисует составную линию, состоящую из параллельных линий и промежутков.</summary>
		/// <returns>Массив действительных чисел, задающий составной массив. Элементы массива должны быть числами от 0 до 1, расположенными в порядке возрастания.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.CompoundArray" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00013118 File Offset: 0x00011318
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00013154 File Offset: 0x00011354
		public float[] CompoundArray
		{
			get
			{
				int num;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenCompoundCount(this.nativeObject, out num));
				float[] array = new float[num];
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenCompoundArray(this.nativeObject, array, num));
				return array;
			}
			set
			{
				if (!this.isModifiable)
				{
					throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
				}
				if (value.Length < 2)
				{
					throw new ArgumentException("Invalid parameter.");
				}
				for (int i = 0; i < value.Length; i++)
				{
					float num = value[i];
					if (num < 0f || num > 1f)
					{
						throw new ArgumentException("Invalid parameter.");
					}
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPenCompoundArray(this.nativeObject, value, value.Length));
			}
		}

		/// <summary>Получает или задает настраиваемое окончание линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />, представляющий окончание линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.CustomEndCap" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x000131CD File Offset: 0x000113CD
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x000131D5 File Offset: 0x000113D5
		public CustomLineCap CustomEndCap
		{
			get
			{
				return this.endCap;
			}
			set
			{
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenCustomEndCap(this.nativeObject, value.nativeCap));
					this.endCap = value;
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает настраиваемое начало линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />, представляющий начало линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.CustomStartCap" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00013211 File Offset: 0x00011411
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00013219 File Offset: 0x00011419
		public CustomLineCap CustomStartCap
		{
			get
			{
				return this.startCap;
			}
			set
			{
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenCustomStartCap(this.nativeObject, value.nativeCap));
					this.startCap = value;
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает стиль окончания пунктиров, ограничивающих пунктирные линии, нарисованные при помощи объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Drawing2D.DashCap" />, представляющих стиль оконечного элемента, используемого в начале и конце штрихов, которые составляют пунктирные линии, рисуемые с помощью пера <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Заданное значение отсутствует в перечислении <see cref="T:System.Drawing.Drawing2D.DashCap" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.DashCap" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00013258 File Offset: 0x00011458
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00013278 File Offset: 0x00011478
		public DashCap DashCap
		{
			get
			{
				DashCap result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenDashCap197819(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (value < DashCap.Flat || value > DashCap.Triangle)
				{
					throw new InvalidEnumArgumentException("DashCap", (int)value, typeof(DashCap));
				}
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenDashCap197819(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает расстояние от начала линии до начала штрихового шаблона.</summary>
		/// <returns>Расстояние от начала линии до начала штрихового шаблона.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.DashOffset" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x000132CC File Offset: 0x000114CC
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x000132EC File Offset: 0x000114EC
		public float DashOffset
		{
			get
			{
				float result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenDashOffset(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenDashOffset(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает массив настраиваемых штрихов и промежутков.</summary>
		/// <returns>Массив действительных чисел, задающий длины сменяющих друг друга штрихов и промежутков, в пунктирных линиях.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.DashPattern" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00013318 File Offset: 0x00011518
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00013378 File Offset: 0x00011578
		public float[] DashPattern
		{
			get
			{
				int num;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenDashCount(this.nativeObject, out num));
				float[] array;
				if (num > 0)
				{
					array = new float[num];
					GDIPlus.CheckStatus(GDIPlus.GdipGetPenDashArray(this.nativeObject, array, num));
				}
				else if (this.DashStyle == DashStyle.Custom)
				{
					array = new float[]
					{
						1f
					};
				}
				else
				{
					array = new float[0];
				}
				return array;
			}
			set
			{
				if (!this.isModifiable)
				{
					throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
				}
				if (value.Length == 0)
				{
					throw new ArgumentException("Invalid parameter.");
				}
				for (int i = 0; i < value.Length; i++)
				{
					if (value[i] <= 0f)
					{
						throw new ArgumentException("Invalid parameter.");
					}
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPenDashArray(this.nativeObject, value, value.Length));
			}
		}

		/// <summary>Получает или задает стиль, используемый для пунктирных линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.Drawing2D.DashStyle" />, представляющее стиль, используемый для пунктирных линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.DashStyle" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000133E8 File Offset: 0x000115E8
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00013408 File Offset: 0x00011608
		public DashStyle DashStyle
		{
			get
			{
				DashStyle result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenDashStyle(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (value < DashStyle.Solid || value > DashStyle.Custom)
				{
					throw new InvalidEnumArgumentException("DashStyle", (int)value, typeof(DashStyle));
				}
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenDashStyle(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает стиль начала линий, рисуемых при помощи объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Drawing2D.LineCap" />, представляющих стиль оконечного элемента, используемого в начале линий, которые рисуются с помощью этого пера <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Заданное значение отсутствует в перечислении <see cref="T:System.Drawing.Drawing2D.LineCap" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.StartCap" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0001345C File Offset: 0x0001165C
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x0001347C File Offset: 0x0001167C
		public LineCap StartCap
		{
			get
			{
				LineCap result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenStartCap(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (value < LineCap.Flat || value > LineCap.Custom)
				{
					throw new InvalidEnumArgumentException("StartCap", (int)value, typeof(LineCap));
				}
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenStartCap(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает стиль окончания линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Drawing2D.LineCap" />, представляющих стиль оконечного элемента, который используется на концах линий, рисуемых с помощью пера <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Заданное значение отсутствует в перечислении <see cref="T:System.Drawing.Drawing2D.LineCap" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.EndCap" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000134D4 File Offset: 0x000116D4
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x000134F4 File Offset: 0x000116F4
		public LineCap EndCap
		{
			get
			{
				LineCap result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenEndCap(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (value < LineCap.Flat || value > LineCap.Custom)
				{
					throw new InvalidEnumArgumentException("EndCap", (int)value, typeof(LineCap));
				}
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenEndCap(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает общий стиль окончаний для двух последовательных линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.Drawing2D.LineJoin" />, представляющее общий стиль окончаний для двух последовательных линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.LineJoin" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001354C File Offset: 0x0001174C
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x0001356C File Offset: 0x0001176C
		public LineJoin LineJoin
		{
			get
			{
				LineJoin result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenLineJoin(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (value < LineJoin.Miter || value > LineJoin.MiterClipped)
				{
					throw new InvalidEnumArgumentException("LineJoin", (int)value, typeof(LineJoin));
				}
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenLineJoin(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает ограничение толщины соединения скошенных углов.</summary>
		/// <returns>Ограничение толщины соединения скошенных углов.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.MiterLimit" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000135C0 File Offset: 0x000117C0
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x000135E0 File Offset: 0x000117E0
		public float MiterLimit
		{
			get
			{
				float result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenMiterLimit(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenMiterLimit(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или задает стиль линий, нарисованных с помощью объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.Drawing2D.PenType" />, задающее стиль линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</returns>
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0001360C File Offset: 0x0001180C
		public PenType PenType
		{
			get
			{
				PenType result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenFillType(this.nativeObject, out result));
				return result;
			}
		}

		/// <summary>Получает или задает копию геометрического преобразования объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Копия матрицы <see cref="T:System.Drawing.Drawing2D.Matrix" />, которая представляет геометрическое преобразование объекта <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.Transform" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001362C File Offset: 0x0001182C
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00013656 File Offset: 0x00011856
		public Matrix Transform
		{
			get
			{
				Matrix matrix = new Matrix();
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenTransform(this.nativeObject, matrix.nativeMatrix));
				return matrix;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Transform");
				}
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenTransform(this.nativeObject, value.nativeMatrix));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		/// <summary>Получает или устанавливает ширину пера <see cref="T:System.Drawing.Pen" />, в единицах объекта <see cref="T:System.Drawing.Graphics" />, используемого для рисования.</summary>
		/// <returns>Ширина значка <see cref="T:System.Drawing.Pen" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.Pen.Width" /> устанавливается для неизменного объекта <see cref="T:System.Drawing.Pen" />, например такого, какие возвращаются классом <see cref="T:System.Drawing.Pens" />.</exception>
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00013694 File Offset: 0x00011894
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x000136B4 File Offset: 0x000118B4
		public float Width
		{
			get
			{
				float result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPenWidth(this.nativeObject, out result));
				return result;
			}
			set
			{
				if (this.isModifiable)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipSetPenWidth(this.nativeObject, value));
					return;
				}
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000136DF File Offset: 0x000118DF
		internal IntPtr NativePen
		{
			get
			{
				return this.nativeObject;
			}
		}

		/// <summary>Создает точную копию данного объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который может быть приведен к объекту <see cref="T:System.Drawing.Pen" />.</returns>
		// Token: 0x0600066C RID: 1644 RVA: 0x000136E8 File Offset: 0x000118E8
		public object Clone()
		{
			IntPtr p;
			GDIPlus.CheckStatus(GDIPlus.GdipClonePen(this.nativeObject, out p));
			return new Pen(p)
			{
				startCap = this.startCap,
				endCap = this.endCap
			};
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Pen" />.</summary>
		// Token: 0x0600066D RID: 1645 RVA: 0x00013725 File Offset: 0x00011925
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00013734 File Offset: 0x00011934
		private void Dispose(bool disposing)
		{
			if (disposing && !this.isModifiable)
			{
				throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
			}
			if (this.nativeObject != IntPtr.Zero)
			{
				Status status = GDIPlus.GdipDeletePen(this.nativeObject);
				this.nativeObject = IntPtr.Zero;
				GDIPlus.CheckStatus(status);
			}
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как объект будет утилизирован в процессе сборки мусора.</summary>
		// Token: 0x0600066F RID: 1647 RVA: 0x0001378C File Offset: 0x0001198C
		~Pen()
		{
			this.Dispose(false);
		}

		/// <summary>Умножает матрицу преобразования объекта <see cref="T:System.Drawing.Pen" /> на заданный объект <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, на который умножается матрица преобразования.</param>
		// Token: 0x06000670 RID: 1648 RVA: 0x000137BC File Offset: 0x000119BC
		public void MultiplyTransform(Matrix matrix)
		{
			this.MultiplyTransform(matrix, MatrixOrder.Prepend);
		}

		/// <summary>Умножает матрицу преобразования объекта <see cref="T:System.Drawing.Pen" /> на заданный объект <see cref="T:System.Drawing.Drawing2D.Matrix" /> в заданном порядке.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, на который умножается матрица преобразования.</param>
		/// <param name="order">Порядок, в котором производится операция умножения.</param>
		// Token: 0x06000671 RID: 1649 RVA: 0x000137C6 File Offset: 0x000119C6
		public void MultiplyTransform(Matrix matrix, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipMultiplyPenTransform(this.nativeObject, matrix.nativeMatrix, order));
		}

		/// <summary>Возвращает матрице геометрического преобразования объекта <see cref="T:System.Drawing.Pen" /> единичное значение.</summary>
		// Token: 0x06000672 RID: 1650 RVA: 0x000137DF File Offset: 0x000119DF
		public void ResetTransform()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipResetPenTransform(this.nativeObject));
		}

		/// <summary>Поворачивает локальное геометрическое преобразование на заданный угол. Этот метод добавляет поворот перед преобразованием.</summary>
		/// <param name="angle">Угол поворота.</param>
		// Token: 0x06000673 RID: 1651 RVA: 0x000137F1 File Offset: 0x000119F1
		public void RotateTransform(float angle)
		{
			this.RotateTransform(angle, MatrixOrder.Prepend);
		}

		/// <summary>Поворачивает локальное геометрическое преобразование на заданный угол в заданном порядке.</summary>
		/// <param name="angle">Угол поворота.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, указывающий, где будет добавляться матрица поворота: в начале или в конце.</param>
		// Token: 0x06000674 RID: 1652 RVA: 0x000137FB File Offset: 0x000119FB
		public void RotateTransform(float angle, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipRotatePenTransform(this.nativeObject, angle, order));
		}

		/// <summary>Выполняет изменение масштаба локального геометрического преобразования при помощи заданных коэффициентов. Этот метод вставляет изменение масштаба перед преобразованием.</summary>
		/// <param name="sx">Коэффициент изменения масштаба по оси Х.</param>
		/// <param name="sy">Коэффициент изменения масштаба по оси Y.</param>
		// Token: 0x06000675 RID: 1653 RVA: 0x0001380F File Offset: 0x00011A0F
		public void ScaleTransform(float sx, float sy)
		{
			this.ScaleTransform(sx, sy, MatrixOrder.Prepend);
		}

		/// <summary>Изменяет масштаб локального геометрического преобразования при помощи заданных коэффициентов в заданном порядке.</summary>
		/// <param name="sx">Коэффициент изменения масштаба по оси Х.</param>
		/// <param name="sy">Коэффициент изменения масштаба по оси Y.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, указывающий, где добавляется матрица масштабирования: в начале или в конце.</param>
		// Token: 0x06000676 RID: 1654 RVA: 0x0001381A File Offset: 0x00011A1A
		public void ScaleTransform(float sx, float sy, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipScalePenTransform(this.nativeObject, sx, sy, order));
		}

		/// <summary>Устанавливает значения, определяющие стиль окончания линий, нарисованных при помощи объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <param name="startCap">Объект <see cref="T:System.Drawing.Drawing2D.LineCap" />, представляющий стиль начала линий, рисуемых при помощи объекта <see cref="T:System.Drawing.Pen" />.</param>
		/// <param name="endCap">Объект <see cref="T:System.Drawing.Drawing2D.LineCap" />, представляющий стиль окончаний линий, рисуемых при помощи объекта <see cref="T:System.Drawing.Pen" />.</param>
		/// <param name="dashCap">Объект <see cref="T:System.Drawing.Drawing2D.LineCap" />, представляющий стиль оконечного элемента, используемого в начале или конце пунктирных линий, рисуемых при помощи этого пера <see cref="T:System.Drawing.Pen" />.</param>
		// Token: 0x06000677 RID: 1655 RVA: 0x0001382F File Offset: 0x00011A2F
		public void SetLineCap(LineCap startCap, LineCap endCap, DashCap dashCap)
		{
			if (this.isModifiable)
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetPenLineCap197819(this.nativeObject, startCap, endCap, dashCap));
				return;
			}
			throw new ArgumentException(Locale.GetText("This Pen object can't be modified."));
		}

		/// <summary>Выполняет перевод локального геометрического преобразования на заданные размеры. Этот метод вставляет перевод перед преобразованием.</summary>
		/// <param name="dx">Значение сдвига по оси X.</param>
		/// <param name="dy">Значение сдвига по оси Y.</param>
		// Token: 0x06000678 RID: 1656 RVA: 0x0001385C File Offset: 0x00011A5C
		public void TranslateTransform(float dx, float dy)
		{
			this.TranslateTransform(dx, dy, MatrixOrder.Prepend);
		}

		/// <summary>Выполняет перевод локального геометрического преобразования на заданные размеры в заданном порядке.</summary>
		/// <param name="dx">Значение сдвига по оси X.</param>
		/// <param name="dy">Значение сдвига по оси Y.</param>
		/// <param name="order">Порядок применения преобразования (в начале или в конце).</param>
		// Token: 0x06000679 RID: 1657 RVA: 0x00013867 File Offset: 0x00011A67
		public void TranslateTransform(float dx, float dy, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipTranslatePenTransform(this.nativeObject, dx, dy, order));
		}

		// Token: 0x040004D4 RID: 1236
		internal IntPtr nativeObject;

		// Token: 0x040004D5 RID: 1237
		internal bool isModifiable = true;

		// Token: 0x040004D6 RID: 1238
		private Color color;

		// Token: 0x040004D7 RID: 1239
		private CustomLineCap startCap;

		// Token: 0x040004D8 RID: 1240
		private CustomLineCap endCap;
	}
}
