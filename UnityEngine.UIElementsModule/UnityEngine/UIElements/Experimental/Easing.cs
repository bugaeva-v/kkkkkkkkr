using System;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x02000386 RID: 902
	public static class Easing
	{
		// Token: 0x06001CCF RID: 7375 RVA: 0x000892B0 File Offset: 0x000874B0
		public static float Step(float t)
		{
			return (float)((t < 0.5f) ? 0 : 1);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000892D0 File Offset: 0x000874D0
		public static float Linear(float t)
		{
			return t;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000892E4 File Offset: 0x000874E4
		public static float InSine(float t)
		{
			return Mathf.Sin(1.5707964f * (t - 1f)) + 1f;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00089310 File Offset: 0x00087510
		public static float OutSine(float t)
		{
			return Mathf.Sin(t * 1.5707964f);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00089330 File Offset: 0x00087530
		public static float InOutSine(float t)
		{
			return (Mathf.Sin(3.1415927f * (t - 0.5f)) + 1f) * 0.5f;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00089360 File Offset: 0x00087560
		public static float InQuad(float t)
		{
			return t * t;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00089378 File Offset: 0x00087578
		public static float OutQuad(float t)
		{
			return t * (2f - t);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00089394 File Offset: 0x00087594
		public static float InOutQuad(float t)
		{
			t *= 2f;
			bool flag = t < 1f;
			float result;
			if (flag)
			{
				result = t * t * 0.5f;
			}
			else
			{
				result = -0.5f * ((t - 1f) * (t - 3f) - 1f);
			}
			return result;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000893E4 File Offset: 0x000875E4
		public static float InCubic(float t)
		{
			return Easing.InPower(t, 3);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00089400 File Offset: 0x00087600
		public static float OutCubic(float t)
		{
			return Easing.OutPower(t, 3);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0008941C File Offset: 0x0008761C
		public static float InOutCubic(float t)
		{
			return Easing.InOutPower(t, 3);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00089438 File Offset: 0x00087638
		public static float InPower(float t, int power)
		{
			return Mathf.Pow(t, (float)power);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00089454 File Offset: 0x00087654
		public static float OutPower(float t, int power)
		{
			int num = (power % 2 == 0) ? -1 : 1;
			return (float)num * (Mathf.Pow(t - 1f, (float)power) + (float)num);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00089488 File Offset: 0x00087688
		public static float InOutPower(float t, int power)
		{
			t *= 2f;
			bool flag = t < 1f;
			float result;
			if (flag)
			{
				result = Easing.InPower(t, power) * 0.5f;
			}
			else
			{
				int num = (power % 2 == 0) ? -1 : 1;
				result = (float)num * 0.5f * (Mathf.Pow(t - 2f, (float)power) + (float)(num * 2));
			}
			return result;
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000894E8 File Offset: 0x000876E8
		public static float InBounce(float t)
		{
			return 1f - Easing.OutBounce(1f - t);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0008950C File Offset: 0x0008770C
		public static float OutBounce(float t)
		{
			bool flag = t < 0.36363637f;
			float result;
			if (flag)
			{
				result = 7.5625f * t * t;
			}
			else
			{
				bool flag2 = t < 0.72727275f;
				if (flag2)
				{
					float num;
					t = (num = t - 0.54545456f);
					result = 7.5625f * num * t + 0.75f;
				}
				else
				{
					bool flag3 = t < 0.90909094f;
					if (flag3)
					{
						float num2;
						t = (num2 = t - 0.8181818f);
						result = 7.5625f * num2 * t + 0.9375f;
					}
					else
					{
						float num3;
						t = (num3 = t - 0.95454544f);
						result = 7.5625f * num3 * t + 0.984375f;
					}
				}
			}
			return result;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x000895AC File Offset: 0x000877AC
		public static float InOutBounce(float t)
		{
			bool flag = t < 0.5f;
			float result;
			if (flag)
			{
				result = Easing.InBounce(t * 2f) * 0.5f;
			}
			else
			{
				result = Easing.OutBounce((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return result;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00089600 File Offset: 0x00087800
		public static float InElastic(float t)
		{
			bool flag = t == 0f;
			float result;
			if (flag)
			{
				result = 0f;
			}
			else
			{
				bool flag2 = t == 1f;
				if (flag2)
				{
					result = 1f;
				}
				else
				{
					float num = 0.3f;
					float num2 = num / 4f;
					float num3 = Mathf.Pow(2f, 10f * (t -= 1f));
					result = -(num3 * Mathf.Sin((t - num2) * 6.2831855f / num));
				}
			}
			return result;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0008967C File Offset: 0x0008787C
		public static float OutElastic(float t)
		{
			bool flag = t == 0f;
			float result;
			if (flag)
			{
				result = 0f;
			}
			else
			{
				bool flag2 = t == 1f;
				if (flag2)
				{
					result = 1f;
				}
				else
				{
					float num = 0.3f;
					float num2 = num / 4f;
					result = Mathf.Pow(2f, -10f * t) * Mathf.Sin((t - num2) * 6.2831855f / num) + 1f;
				}
			}
			return result;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x000896F0 File Offset: 0x000878F0
		public static float InOutElastic(float t)
		{
			bool flag = t < 0.5f;
			float result;
			if (flag)
			{
				result = Easing.InElastic(t * 2f) * 0.5f;
			}
			else
			{
				result = Easing.OutElastic((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return result;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00089744 File Offset: 0x00087944
		public static float InBack(float t)
		{
			float num = 1.70158f;
			return t * t * ((num + 1f) * t - num);
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0008976C File Offset: 0x0008796C
		public static float OutBack(float t)
		{
			return 1f - Easing.InBack(1f - t);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00089790 File Offset: 0x00087990
		public static float InOutBack(float t)
		{
			bool flag = t < 0.5f;
			float result;
			if (flag)
			{
				result = Easing.InBack(t * 2f) * 0.5f;
			}
			else
			{
				result = Easing.OutBack((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return result;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x000897E4 File Offset: 0x000879E4
		public static float InBack(float t, float s)
		{
			return t * t * ((s + 1f) * t - s);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00089808 File Offset: 0x00087A08
		public static float OutBack(float t, float s)
		{
			return 1f - Easing.InBack(1f - t, s);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00089830 File Offset: 0x00087A30
		public static float InOutBack(float t, float s)
		{
			bool flag = t < 0.5f;
			float result;
			if (flag)
			{
				result = Easing.InBack(t * 2f, s) * 0.5f;
			}
			else
			{
				result = Easing.OutBack((t - 0.5f) * 2f, s) * 0.5f + 0.5f;
			}
			return result;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00089888 File Offset: 0x00087A88
		public static float InCirc(float t)
		{
			return -(Mathf.Sqrt(1f - t * t) - 1f);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000898B0 File Offset: 0x00087AB0
		public static float OutCirc(float t)
		{
			t -= 1f;
			return Mathf.Sqrt(1f - t * t);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x000898DC File Offset: 0x00087ADC
		public static float InOutCirc(float t)
		{
			t *= 2f;
			bool flag = t < 1f;
			float result;
			if (flag)
			{
				result = -0.5f * (Mathf.Sqrt(1f - t * t) - 1f);
			}
			else
			{
				t -= 2f;
				result = 0.5f * (Mathf.Sqrt(1f - t * t) + 1f);
			}
			return result;
		}

		// Token: 0x04000EA0 RID: 3744
		private const float HalfPi = 1.5707964f;
	}
}
