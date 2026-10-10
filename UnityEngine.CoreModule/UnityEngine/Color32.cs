using System;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001BF RID: 447
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Explicit)]
	public struct Color32 : IFormattable
	{
		// Token: 0x060013AD RID: 5037 RVA: 0x0001C1C2 File Offset: 0x0001A3C2
		public Color32(byte r, byte g, byte b, byte a)
		{
			this.rgba = 0;
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		public static implicit operator Color32(Color c)
		{
			return new Color32((byte)Mathf.Round(Mathf.Clamp01(c.r) * 255f), (byte)Mathf.Round(Mathf.Clamp01(c.g) * 255f), (byte)Mathf.Round(Mathf.Clamp01(c.b) * 255f), (byte)Mathf.Round(Mathf.Clamp01(c.a) * 255f));
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0001C260 File Offset: 0x0001A460
		public static implicit operator Color(Color32 c)
		{
			return new Color((float)c.r / 255f, (float)c.g / 255f, (float)c.b / 255f, (float)c.a / 255f);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0001C2AC File Offset: 0x0001A4AC
		public static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0001C330 File Offset: 0x0001A530
		public static Color32 LerpUnclamped(Color32 a, Color32 b, float t)
		{
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x17000407 RID: 1031
		public byte this[int index]
		{
			get
			{
				byte result;
				switch (index)
				{
				case 0:
					result = this.r;
					break;
				case 1:
					result = this.g;
					break;
				case 2:
					result = this.b;
					break;
				case 3:
					result = this.a;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Color32 index(" + index.ToString() + ")!");
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.r = value;
					break;
				case 1:
					this.g = value;
					break;
				case 2:
					this.b = value;
					break;
				case 3:
					this.a = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Color32 index(" + index.ToString() + ")!");
				}
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0001C484 File Offset: 0x0001A684
		[VisibleToOtherModules]
		internal bool InternalEquals(Color32 other)
		{
			return this.rgba == other.rgba;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0001C4A4 File Offset: 0x0001A6A4
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0001C4DC File Offset: 0x0001A6DC
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = formatProvider == null;
			if (flag)
			{
				formatProvider = CultureInfo.InvariantCulture.NumberFormat;
			}
			return UnityString.Format("RGBA({0}, {1}, {2}, {3})", new object[]
			{
				this.r.ToString(format, formatProvider),
				this.g.ToString(format, formatProvider),
				this.b.ToString(format, formatProvider),
				this.a.ToString(format, formatProvider)
			});
		}

		// Token: 0x04000740 RID: 1856
		[Ignore(DoesNotContributeToSize = true)]
		[FieldOffset(0)]
		private int rgba;

		// Token: 0x04000741 RID: 1857
		[FieldOffset(0)]
		public byte r;

		// Token: 0x04000742 RID: 1858
		[FieldOffset(1)]
		public byte g;

		// Token: 0x04000743 RID: 1859
		[FieldOffset(2)]
		public byte b;

		// Token: 0x04000744 RID: 1860
		[FieldOffset(3)]
		public byte a;
	}
}
