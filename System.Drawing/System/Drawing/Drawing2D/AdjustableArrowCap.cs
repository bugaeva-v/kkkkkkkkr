using System;
using System.Runtime.InteropServices;

namespace System.Drawing.Drawing2D
{
	/// <summary>Представляет настраиваемое завершение отрезка в форме стрелки. Этот класс не наследуется.</summary>
	// Token: 0x02000133 RID: 307
	public sealed class AdjustableArrowCap : CustomLineCap
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x0001FBC9 File Offset: 0x0001DDC9
		internal AdjustableArrowCap(IntPtr nativeCap) : base(nativeCap)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.AdjustableArrowCap" /> с заданной шириной и высотой. Стрелки, созданные с помощью данного конструктора, всегда заполнены.</summary>
		/// <param name="width">Ширина стрелки.</param>
		/// <param name="height">Высота стрелки.</param>
		// Token: 0x06000E02 RID: 3586 RVA: 0x0001FBD2 File Offset: 0x0001DDD2
		public AdjustableArrowCap(float width, float height) : this(width, height, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.AdjustableArrowCap" /> с заданной шириной, высотой и свойством заполнения. Заполнена ли стрелка, зависит от аргумента, переданного параметру <paramref name="isFilled" />.</summary>
		/// <param name="width">Ширина стрелки.</param>
		/// <param name="height">Высота стрелки.</param>
		/// <param name="isFilled">Значение <see langword="true" />, чтобы заполнить наконечник стрелки; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000E03 RID: 3587 RVA: 0x0001FBE0 File Offset: 0x0001DDE0
		public AdjustableArrowCap(float width, float height, bool isFilled)
		{
			IntPtr nativeLineCap;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCreateAdjustableArrowCap(height, width, isFilled, out nativeLineCap));
			base.SetNativeLineCap(nativeLineCap);
		}

		/// <summary>Получает или задает высоту стрелки.</summary>
		/// <returns>Высота стрелки.</returns>
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0001FC0C File Offset: 0x0001DE0C
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x0001FC37 File Offset: 0x0001DE37
		public float Height
		{
			get
			{
				float result;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetAdjustableArrowCapHeight(new HandleRef(this, this.nativeCap), out result));
				return result;
			}
			set
			{
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipSetAdjustableArrowCapHeight(new HandleRef(this, this.nativeCap), value));
			}
		}

		/// <summary>Получает или задает ширину стрелки.</summary>
		/// <returns>Ширина стрелки в единицах.</returns>
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x0001FC58 File Offset: 0x0001DE58
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x0001FC83 File Offset: 0x0001DE83
		public float Width
		{
			get
			{
				float result;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetAdjustableArrowCapWidth(new HandleRef(this, this.nativeCap), out result));
				return result;
			}
			set
			{
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipSetAdjustableArrowCapWidth(new HandleRef(this, this.nativeCap), value));
			}
		}

		/// <summary>Получает или задает число единиц между контуром и заполнением стрелки.</summary>
		/// <returns>Число единиц между контуром стрелки и заполнением стрелки.</returns>
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x0001FCCF File Offset: 0x0001DECF
		public float MiddleInset
		{
			get
			{
				float result;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetAdjustableArrowCapMiddleInset(new HandleRef(this, this.nativeCap), out result));
				return result;
			}
			set
			{
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipSetAdjustableArrowCapMiddleInset(new HandleRef(this, this.nativeCap), value));
			}
		}

		/// <summary>Получает или задает значение, указывающее, заполнена ли стрелка.</summary>
		/// <returns>Это свойство имеет значение <see langword="true" />, если стрелка заполнена; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x0001FD1B File Offset: 0x0001DF1B
		public bool Filled
		{
			get
			{
				bool result;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetAdjustableArrowCapFillState(new HandleRef(this, this.nativeCap), out result));
				return result;
			}
			set
			{
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipSetAdjustableArrowCapFillState(new HandleRef(this, this.nativeCap), value));
			}
		}
	}
}
