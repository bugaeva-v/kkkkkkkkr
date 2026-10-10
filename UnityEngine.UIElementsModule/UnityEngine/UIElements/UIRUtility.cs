using System;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x0200026A RID: 618
	internal static class UIRUtility
	{
		// Token: 0x060012C2 RID: 4802 RVA: 0x0004B3E4 File Offset: 0x000495E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef)
		{
			Debug.Assert(maskDepth == stencilRef || maskDepth == stencilRef + 1);
			return maskDepth == stencilRef;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0004B410 File Offset: 0x00049610
		public static Vector4 ToVector4(Rect rc)
		{
			return new Vector4(rc.xMin, rc.yMin, rc.xMax, rc.yMax);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0004B444 File Offset: 0x00049644
		public static bool IsRoundRect(VisualElement ve)
		{
			IResolvedStyle resolvedStyle = ve.resolvedStyle;
			return resolvedStyle.borderTopLeftRadius >= 1E-30f || resolvedStyle.borderTopRightRadius >= 1E-30f || resolvedStyle.borderBottomLeftRadius >= 1E-30f || resolvedStyle.borderBottomRightRadius >= 1E-30f;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0004B498 File Offset: 0x00049698
		public static void Multiply2D(this Quaternion rotation, ref Vector2 point)
		{
			float num = rotation.z * 2f;
			float num2 = 1f - rotation.z * num;
			float num3 = rotation.w * num;
			point = new Vector2(num2 * point.x - num3 * point.y, num3 * point.x + num2 * point.y);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0004B4F8 File Offset: 0x000496F8
		public static bool IsVectorImageBackground(VisualElement ve)
		{
			return ve.computedStyle.backgroundImage.vectorImage != null;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0004B524 File Offset: 0x00049724
		public static bool IsElementSelfHidden(VisualElement ve)
		{
			return ve.resolvedStyle.visibility == Visibility.Hidden;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0004B544 File Offset: 0x00049744
		public static void Destroy(Object obj)
		{
			bool flag = obj == null;
			if (!flag)
			{
				bool isPlaying = Application.isPlaying;
				if (isPlaying)
				{
					Object.Destroy(obj);
				}
				else
				{
					Object.DestroyImmediate(obj);
				}
			}
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0004B578 File Offset: 0x00049778
		public static int GetPrevPow2(int n)
		{
			int num = 0;
			while (n > 1)
			{
				n >>= 1;
				num++;
			}
			return 1 << num;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0004B5A8 File Offset: 0x000497A8
		public static int GetNextPow2(int n)
		{
			int i;
			for (i = 1; i < n; i <<= 1)
			{
			}
			return i;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0004B5CC File Offset: 0x000497CC
		public static int GetNextPow2Exp(int n)
		{
			int i = 1;
			int num = 0;
			while (i < n)
			{
				i <<= 1;
				num++;
			}
			return num;
		}

		// Token: 0x040008BD RID: 2237
		public static readonly string k_DefaultShaderName = Shaders.k_Runtime;

		// Token: 0x040008BE RID: 2238
		public static readonly string k_DefaultWorldSpaceShaderName = Shaders.k_RuntimeWorld;

		// Token: 0x040008BF RID: 2239
		public const float k_Epsilon = 1E-30f;

		// Token: 0x040008C0 RID: 2240
		public const float k_ClearZ = 0.99f;

		// Token: 0x040008C1 RID: 2241
		public const float k_MeshPosZ = 0f;

		// Token: 0x040008C2 RID: 2242
		public const float k_MaskPosZ = 1f;

		// Token: 0x040008C3 RID: 2243
		public const int k_MaxMaskDepth = 7;
	}
}
