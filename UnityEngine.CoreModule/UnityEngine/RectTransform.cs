using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200025C RID: 604
	[NativeHeader("Runtime/Transform/RectTransform.h")]
	[NativeClass("UI::RectTransform")]
	public sealed class RectTransform : Transform
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06001A0C RID: 6668 RVA: 0x0002A248 File Offset: 0x00028448
		// (remove) Token: 0x06001A0D RID: 6669 RVA: 0x0002A27C File Offset: 0x0002847C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0002A2B0 File Offset: 0x000284B0
		public Rect rect
		{
			get
			{
				Rect result;
				this.get_rect_Injected(out result);
				return result;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0002A2C8 File Offset: 0x000284C8
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x0002A2DE File Offset: 0x000284DE
		public Vector2 anchorMin
		{
			get
			{
				Vector2 result;
				this.get_anchorMin_Injected(out result);
				return result;
			}
			set
			{
				this.set_anchorMin_Injected(ref value);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0002A2E8 File Offset: 0x000284E8
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x0002A2FE File Offset: 0x000284FE
		public Vector2 anchorMax
		{
			get
			{
				Vector2 result;
				this.get_anchorMax_Injected(out result);
				return result;
			}
			set
			{
				this.set_anchorMax_Injected(ref value);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0002A308 File Offset: 0x00028508
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0002A31E File Offset: 0x0002851E
		public Vector2 anchoredPosition
		{
			get
			{
				Vector2 result;
				this.get_anchoredPosition_Injected(out result);
				return result;
			}
			set
			{
				this.set_anchoredPosition_Injected(ref value);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0002A328 File Offset: 0x00028528
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x0002A33E File Offset: 0x0002853E
		public Vector2 sizeDelta
		{
			get
			{
				Vector2 result;
				this.get_sizeDelta_Injected(out result);
				return result;
			}
			set
			{
				this.set_sizeDelta_Injected(ref value);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0002A348 File Offset: 0x00028548
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x0002A35E File Offset: 0x0002855E
		public Vector2 pivot
		{
			get
			{
				Vector2 result;
				this.get_pivot_Injected(out result);
				return result;
			}
			set
			{
				this.set_pivot_Injected(ref value);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x0002A368 File Offset: 0x00028568
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x0002A3A0 File Offset: 0x000285A0
		public Vector3 anchoredPosition3D
		{
			get
			{
				Vector2 anchoredPosition = this.anchoredPosition;
				return new Vector3(anchoredPosition.x, anchoredPosition.y, base.localPosition.z);
			}
			set
			{
				this.anchoredPosition = new Vector2(value.x, value.y);
				Vector3 localPosition = base.localPosition;
				localPosition.z = value.z;
				base.localPosition = localPosition;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0002A3E4 File Offset: 0x000285E4
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x0002A414 File Offset: 0x00028614
		public Vector2 offsetMin
		{
			get
			{
				return this.anchoredPosition - Vector2.Scale(this.sizeDelta, this.pivot);
			}
			set
			{
				Vector2 vector = value - (this.anchoredPosition - Vector2.Scale(this.sizeDelta, this.pivot));
				this.sizeDelta -= vector;
				this.anchoredPosition += Vector2.Scale(vector, Vector2.one - this.pivot);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x0002A480 File Offset: 0x00028680
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x0002A4B8 File Offset: 0x000286B8
		public Vector2 offsetMax
		{
			get
			{
				return this.anchoredPosition + Vector2.Scale(this.sizeDelta, Vector2.one - this.pivot);
			}
			set
			{
				Vector2 vector = value - (this.anchoredPosition + Vector2.Scale(this.sizeDelta, Vector2.one - this.pivot));
				this.sizeDelta += vector;
				this.anchoredPosition += Vector2.Scale(vector, this.pivot);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001A1F RID: 6687
		// (set) Token: 0x06001A20 RID: 6688
		public extern Object drivenByObject { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] internal set; }

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001A21 RID: 6689
		// (set) Token: 0x06001A22 RID: 6690
		internal extern DrivenTransformProperties drivenProperties { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001A23 RID: 6691
		[NativeMethod("UpdateIfTransformDispatchIsDirty")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ForceUpdateRectTransforms();

		// Token: 0x06001A24 RID: 6692 RVA: 0x0002A524 File Offset: 0x00028724
		public void GetLocalCorners(Vector3[] fourCornersArray)
		{
			bool flag = fourCornersArray == null || fourCornersArray.Length < 4;
			if (flag)
			{
				Debug.LogError("Calling GetLocalCorners with an array that is null or has less than 4 elements.");
			}
			else
			{
				Rect rect = this.rect;
				float x = rect.x;
				float y = rect.y;
				float xMax = rect.xMax;
				float yMax = rect.yMax;
				fourCornersArray[0] = new Vector3(x, y, 0f);
				fourCornersArray[1] = new Vector3(x, yMax, 0f);
				fourCornersArray[2] = new Vector3(xMax, yMax, 0f);
				fourCornersArray[3] = new Vector3(xMax, y, 0f);
			}
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0002A5C8 File Offset: 0x000287C8
		public void GetWorldCorners(Vector3[] fourCornersArray)
		{
			bool flag = fourCornersArray == null || fourCornersArray.Length < 4;
			if (flag)
			{
				Debug.LogError("Calling GetWorldCorners with an array that is null or has less than 4 elements.");
			}
			else
			{
				this.GetLocalCorners(fourCornersArray);
				Matrix4x4 localToWorldMatrix = base.transform.localToWorldMatrix;
				for (int i = 0; i < 4; i++)
				{
					fourCornersArray[i] = localToWorldMatrix.MultiplyPoint(fourCornersArray[i]);
				}
			}
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0002A630 File Offset: 0x00028830
		public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size)
		{
			int index = (edge == RectTransform.Edge.Top || edge == RectTransform.Edge.Bottom) ? 1 : 0;
			bool flag = edge == RectTransform.Edge.Top || edge == RectTransform.Edge.Right;
			float value = (float)(flag ? 1 : 0);
			Vector2 vector = this.anchorMin;
			vector[index] = value;
			this.anchorMin = vector;
			vector = this.anchorMax;
			vector[index] = value;
			this.anchorMax = vector;
			Vector2 sizeDelta = this.sizeDelta;
			sizeDelta[index] = size;
			this.sizeDelta = sizeDelta;
			Vector2 anchoredPosition = this.anchoredPosition;
			anchoredPosition[index] = (flag ? (-inset - size * (1f - this.pivot[index])) : (inset + size * this.pivot[index]));
			this.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0002A6FC File Offset: 0x000288FC
		public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
			Vector2 sizeDelta = this.sizeDelta;
			sizeDelta[(int)axis] = size - this.GetParentSize()[(int)axis] * (this.anchorMax[(int)axis] - this.anchorMin[(int)axis]);
			this.sizeDelta = sizeDelta;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0002A755 File Offset: 0x00028955
		[RequiredByNativeCode]
		internal static void SendReapplyDrivenProperties(RectTransform driven)
		{
			RectTransform.ReapplyDrivenProperties reapplyDrivenProperties = RectTransform.reapplyDrivenProperties;
			if (reapplyDrivenProperties != null)
			{
				reapplyDrivenProperties(driven);
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0002A76C File Offset: 0x0002896C
		internal Rect GetRectInParentSpace()
		{
			Rect rect = this.rect;
			Vector2 vector = this.offsetMin + Vector2.Scale(this.pivot, rect.size);
			bool flag = base.transform.parent;
			if (flag)
			{
				RectTransform component = base.transform.parent.GetComponent<RectTransform>();
				bool flag2 = component;
				if (flag2)
				{
					vector += Vector2.Scale(this.anchorMin, component.rect.size);
				}
			}
			rect.x += vector.x;
			rect.y += vector.y;
			return rect;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0002A824 File Offset: 0x00028A24
		private Vector2 GetParentSize()
		{
			RectTransform rectTransform = base.parent as RectTransform;
			bool flag = !rectTransform;
			Vector2 result;
			if (flag)
			{
				result = Vector2.zero;
			}
			else
			{
				result = rectTransform.rect.size;
			}
			return result;
		}

		// Token: 0x06001A2C RID: 6700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_rect_Injected(out Rect ret);

		// Token: 0x06001A2D RID: 6701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_anchorMin_Injected(out Vector2 ret);

		// Token: 0x06001A2E RID: 6702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_anchorMin_Injected(ref Vector2 value);

		// Token: 0x06001A2F RID: 6703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_anchorMax_Injected(out Vector2 ret);

		// Token: 0x06001A30 RID: 6704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_anchorMax_Injected(ref Vector2 value);

		// Token: 0x06001A31 RID: 6705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_anchoredPosition_Injected(out Vector2 ret);

		// Token: 0x06001A32 RID: 6706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_anchoredPosition_Injected(ref Vector2 value);

		// Token: 0x06001A33 RID: 6707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_sizeDelta_Injected(out Vector2 ret);

		// Token: 0x06001A34 RID: 6708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_sizeDelta_Injected(ref Vector2 value);

		// Token: 0x06001A35 RID: 6709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_pivot_Injected(out Vector2 ret);

		// Token: 0x06001A36 RID: 6710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_pivot_Injected(ref Vector2 value);

		// Token: 0x0200025D RID: 605
		public enum Edge
		{
			// Token: 0x040008B3 RID: 2227
			Left,
			// Token: 0x040008B4 RID: 2228
			Right,
			// Token: 0x040008B5 RID: 2229
			Top,
			// Token: 0x040008B6 RID: 2230
			Bottom
		}

		// Token: 0x0200025E RID: 606
		public enum Axis
		{
			// Token: 0x040008B8 RID: 2232
			Horizontal,
			// Token: 0x040008B9 RID: 2233
			Vertical
		}

		// Token: 0x0200025F RID: 607
		// (Invoke) Token: 0x06001A38 RID: 6712
		public delegate void ReapplyDrivenProperties(RectTransform driven);
	}
}
