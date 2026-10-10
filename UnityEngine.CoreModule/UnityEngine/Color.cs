using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001BE RID: 446
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeClass("ColorRGBAf")]
	[NativeHeader("Runtime/Math/Color.h")]
	public struct Color : IEquatable<Color>, IFormattable
	{
		// Token: 0x06001381 RID: 4993 RVA: 0x0001B4A3 File Offset: 0x000196A3
		public Color(float r, float g, float b, float a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0001B4C3 File Offset: 0x000196C3
		public Color(float r, float g, float b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = 1f;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0001B4E8 File Offset: 0x000196E8
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0001B504 File Offset: 0x00019704
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0001B520 File Offset: 0x00019720
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = string.IsNullOrEmpty(format);
			if (flag)
			{
				format = "F3";
			}
			bool flag2 = formatProvider == null;
			if (flag2)
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

		// Token: 0x06001386 RID: 4998 RVA: 0x0001B5A8 File Offset: 0x000197A8
		public override int GetHashCode()
		{
			return this.GetHashCode();
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0001B5D4 File Offset: 0x000197D4
		public override bool Equals(object other)
		{
			bool flag = !(other is Color);
			return !flag && this.Equals((Color)other);
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0001B608 File Offset: 0x00019808
		public bool Equals(Color other)
		{
			return this.r.Equals(other.r) && this.g.Equals(other.g) && this.b.Equals(other.b) && this.a.Equals(other.a);
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0001B668 File Offset: 0x00019868
		public static Color operator +(Color a, Color b)
		{
			return new Color(a.r + b.r, a.g + b.g, a.b + b.b, a.a + b.a);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0001B6B4 File Offset: 0x000198B4
		public static Color operator -(Color a, Color b)
		{
			return new Color(a.r - b.r, a.g - b.g, a.b - b.b, a.a - b.a);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0001B700 File Offset: 0x00019900
		public static Color operator *(Color a, Color b)
		{
			return new Color(a.r * b.r, a.g * b.g, a.b * b.b, a.a * b.a);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0001B74C File Offset: 0x0001994C
		public static Color operator *(Color a, float b)
		{
			return new Color(a.r * b, a.g * b, a.b * b, a.a * b);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0001B784 File Offset: 0x00019984
		public static Color operator *(float b, Color a)
		{
			return new Color(a.r * b, a.g * b, a.b * b, a.a * b);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0001B7BC File Offset: 0x000199BC
		public static Color operator /(Color a, float b)
		{
			return new Color(a.r / b, a.g / b, a.b / b, a.a / b);
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0001B7F4 File Offset: 0x000199F4
		public static bool operator ==(Color lhs, Color rhs)
		{
			return lhs == rhs;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0001B818 File Offset: 0x00019A18
		public static bool operator !=(Color lhs, Color rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0001B834 File Offset: 0x00019A34
		public static Color Lerp(Color a, Color b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0001B8AC File Offset: 0x00019AAC
		public static Color LerpUnclamped(Color a, Color b, float t)
		{
			return new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0001B91C File Offset: 0x00019B1C
		internal Color RGBMultiplied(float multiplier)
		{
			return new Color(this.r * multiplier, this.g * multiplier, this.b * multiplier, this.a);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0001B954 File Offset: 0x00019B54
		internal Color AlphaMultiplied(float multiplier)
		{
			return new Color(this.r, this.g, this.b, this.a * multiplier);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0001B988 File Offset: 0x00019B88
		internal Color RGBMultiplied(Color multiplier)
		{
			return new Color(this.r * multiplier.r, this.g * multiplier.g, this.b * multiplier.b, this.a);
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0001B9CC File Offset: 0x00019BCC
		public static Color red
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(1f, 0f, 0f, 1f);
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		public static Color green
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(0f, 1f, 0f, 1f);
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0001BA24 File Offset: 0x00019C24
		public static Color blue
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(0f, 0f, 1f, 1f);
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x0001BA50 File Offset: 0x00019C50
		public static Color white
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(1f, 1f, 1f, 1f);
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0001BA7C File Offset: 0x00019C7C
		public static Color black
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(0f, 0f, 0f, 1f);
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0001BAA8 File Offset: 0x00019CA8
		public static Color yellow
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(1f, 0.92156863f, 0.015686275f, 1f);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0001BAD4 File Offset: 0x00019CD4
		public static Color cyan
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(0f, 1f, 1f, 1f);
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x0001BB00 File Offset: 0x00019D00
		public static Color magenta
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(1f, 0f, 1f, 1f);
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0001BB2C File Offset: 0x00019D2C
		public static Color gray
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(0.5f, 0.5f, 0.5f, 1f);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x0001BB58 File Offset: 0x00019D58
		public static Color grey
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(0.5f, 0.5f, 0.5f, 1f);
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0001BB84 File Offset: 0x00019D84
		public static Color clear
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Color(0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0001BBB0 File Offset: 0x00019DB0
		public float grayscale
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0.299f * this.r + 0.587f * this.g + 0.114f * this.b;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0001BBE8 File Offset: 0x00019DE8
		public Color linear
		{
			get
			{
				return new Color(Mathf.GammaToLinearSpace(this.r), Mathf.GammaToLinearSpace(this.g), Mathf.GammaToLinearSpace(this.b), this.a);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0001BC28 File Offset: 0x00019E28
		public Color gamma
		{
			get
			{
				return new Color(Mathf.LinearToGammaSpace(this.r), Mathf.LinearToGammaSpace(this.g), Mathf.LinearToGammaSpace(this.b), this.a);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0001BC68 File Offset: 0x00019E68
		public float maxColorComponent
		{
			get
			{
				return Mathf.Max(Mathf.Max(this.r, this.g), this.b);
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0001BC98 File Offset: 0x00019E98
		public static implicit operator Vector4(Color c)
		{
			return new Vector4(c.r, c.g, c.b, c.a);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0001BCC8 File Offset: 0x00019EC8
		public static implicit operator Color(Vector4 v)
		{
			return new Color(v.x, v.y, v.z, v.w);
		}

		// Token: 0x17000406 RID: 1030
		public float this[int index]
		{
			get
			{
				float result;
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
					throw new IndexOutOfRangeException("Invalid Color index(" + index.ToString() + ")!");
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
					throw new IndexOutOfRangeException("Invalid Color index(" + index.ToString() + ")!");
				}
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0001BDD0 File Offset: 0x00019FD0
		public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V)
		{
			bool flag = rgbColor.b > rgbColor.g && rgbColor.b > rgbColor.r;
			if (flag)
			{
				Color.RGBToHSVHelper(4f, rgbColor.b, rgbColor.r, rgbColor.g, out H, out S, out V);
			}
			else
			{
				bool flag2 = rgbColor.g > rgbColor.r;
				if (flag2)
				{
					Color.RGBToHSVHelper(2f, rgbColor.g, rgbColor.b, rgbColor.r, out H, out S, out V);
				}
				else
				{
					Color.RGBToHSVHelper(0f, rgbColor.r, rgbColor.g, rgbColor.b, out H, out S, out V);
				}
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0001BE78 File Offset: 0x0001A078
		private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V)
		{
			V = dominantcolor;
			bool flag = V != 0f;
			if (flag)
			{
				bool flag2 = colorone > colortwo;
				float num;
				if (flag2)
				{
					num = colortwo;
				}
				else
				{
					num = colorone;
				}
				float num2 = V - num;
				bool flag3 = num2 != 0f;
				if (flag3)
				{
					S = num2 / V;
					H = offset + (colorone - colortwo) / num2;
				}
				else
				{
					S = 0f;
					H = offset + (colorone - colortwo);
				}
				H /= 6f;
				bool flag4 = H < 0f;
				if (flag4)
				{
					H += 1f;
				}
			}
			else
			{
				S = 0f;
				H = 0f;
			}
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0001BF2C File Offset: 0x0001A12C
		public static Color HSVToRGB(float H, float S, float V)
		{
			return Color.HSVToRGB(H, S, V, true);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0001BF48 File Offset: 0x0001A148
		public static Color HSVToRGB(float H, float S, float V, bool hdr)
		{
			Color white = Color.white;
			bool flag = S == 0f;
			if (flag)
			{
				white.r = V;
				white.g = V;
				white.b = V;
			}
			else
			{
				bool flag2 = V == 0f;
				if (flag2)
				{
					white.r = 0f;
					white.g = 0f;
					white.b = 0f;
				}
				else
				{
					white.r = 0f;
					white.g = 0f;
					white.b = 0f;
					float num = H * 6f;
					int num2 = (int)Mathf.Floor(num);
					float num3 = num - (float)num2;
					float num4 = V * (1f - S);
					float num5 = V * (1f - S * num3);
					float num6 = V * (1f - S * (1f - num3));
					switch (num2)
					{
					case -1:
						white.r = V;
						white.g = num4;
						white.b = num5;
						break;
					case 0:
						white.r = V;
						white.g = num6;
						white.b = num4;
						break;
					case 1:
						white.r = num5;
						white.g = V;
						white.b = num4;
						break;
					case 2:
						white.r = num4;
						white.g = V;
						white.b = num6;
						break;
					case 3:
						white.r = num4;
						white.g = num5;
						white.b = V;
						break;
					case 4:
						white.r = num6;
						white.g = num4;
						white.b = V;
						break;
					case 5:
						white.r = V;
						white.g = num4;
						white.b = num5;
						break;
					case 6:
						white.r = V;
						white.g = num6;
						white.b = num4;
						break;
					}
					bool flag3 = !hdr;
					if (flag3)
					{
						white.r = Mathf.Clamp(white.r, 0f, 1f);
						white.g = Mathf.Clamp(white.g, 0f, 1f);
						white.b = Mathf.Clamp(white.b, 0f, 1f);
					}
				}
			}
			return white;
		}

		// Token: 0x0400073C RID: 1852
		public float r;

		// Token: 0x0400073D RID: 1853
		public float g;

		// Token: 0x0400073E RID: 1854
		public float b;

		// Token: 0x0400073F RID: 1855
		public float a;
	}
}
