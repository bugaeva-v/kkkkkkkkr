using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000015 RID: 21
	internal class Quads
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00006C18 File Offset: 0x00004E18
		private static bool HasMeshes()
		{
			if (Quads.meshes == null)
			{
				return false;
			}
			foreach (Mesh y in Quads.meshes)
			{
				if (null == y)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006C54 File Offset: 0x00004E54
		public static void Cleanup()
		{
			if (Quads.meshes == null)
			{
				return;
			}
			for (int i = 0; i < Quads.meshes.Length; i++)
			{
				if (null != Quads.meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(Quads.meshes[i]);
					Quads.meshes[i] = null;
				}
			}
			Quads.meshes = null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006CA4 File Offset: 0x00004EA4
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (Quads.HasMeshes() && Quads.currentQuads == totalWidth * totalHeight)
			{
				return Quads.meshes;
			}
			int num = 10833;
			int num2 = totalWidth * totalHeight;
			Quads.currentQuads = num2;
			Quads.meshes = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
			int num3 = 0;
			for (int i = 0; i < num2; i += num)
			{
				int triCount = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
				Quads.meshes[num3] = Quads.GetMesh(triCount, i, totalWidth, totalHeight);
				num3++;
			}
			return Quads.meshes;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00006D34 File Offset: 0x00004F34
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 4];
			Vector2[] array2 = new Vector2[triCount * 4];
			Vector2[] array3 = new Vector2[triCount * 4];
			int[] array4 = new int[triCount * 6];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 4;
				int num2 = i * 6;
				int num3 = triOffset + i;
				float num4 = Mathf.Floor((float)(num3 % totalWidth)) / (float)totalWidth;
				float num5 = Mathf.Floor((float)(num3 / totalWidth)) / (float)totalHeight;
				Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
				array[num] = vector;
				array[num + 1] = vector;
				array[num + 2] = vector;
				array[num + 3] = vector;
				array2[num] = new Vector2(0f, 0f);
				array2[num + 1] = new Vector2(1f, 0f);
				array2[num + 2] = new Vector2(0f, 1f);
				array2[num + 3] = new Vector2(1f, 1f);
				array3[num] = new Vector2(num4, num5);
				array3[num + 1] = new Vector2(num4, num5);
				array3[num + 2] = new Vector2(num4, num5);
				array3[num + 3] = new Vector2(num4, num5);
				array4[num2] = num;
				array4[num2 + 1] = num + 1;
				array4[num2 + 2] = num + 2;
				array4[num2 + 3] = num + 1;
				array4[num2 + 4] = num + 2;
				array4[num2 + 5] = num + 3;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}

		// Token: 0x040000C4 RID: 196
		private static Mesh[] meshes;

		// Token: 0x040000C5 RID: 197
		private static int currentQuads;
	}
}
