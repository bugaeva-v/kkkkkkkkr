using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000419 RID: 1049
	public struct StencilState : IEquatable<StencilState>
	{
		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x0003D2E4 File Offset: 0x0003B4E4
		public static StencilState defaultValue
		{
			get
			{
				return new StencilState(true, byte.MaxValue, byte.MaxValue, CompareFunction.Always, StencilOp.Keep, StencilOp.Keep, StencilOp.Keep);
			}
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0003D30C File Offset: 0x0003B50C
		public StencilState(bool enabled = true, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = CompareFunction.Always, StencilOp passOperation = StencilOp.Keep, StencilOp failOperation = StencilOp.Keep, StencilOp zFailOperation = StencilOp.Keep)
		{
			this = new StencilState(enabled, readMask, writeMask, compareFunction, passOperation, failOperation, zFailOperation, compareFunction, passOperation, failOperation, zFailOperation);
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0003D334 File Offset: 0x0003B534
		public StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack)
		{
			this.m_Enabled = Convert.ToByte(enabled);
			this.m_ReadMask = readMask;
			this.m_WriteMask = writeMask;
			this.m_Padding = 0;
			this.m_CompareFunctionFront = (byte)compareFunctionFront;
			this.m_PassOperationFront = (byte)passOperationFront;
			this.m_FailOperationFront = (byte)failOperationFront;
			this.m_ZFailOperationFront = (byte)zFailOperationFront;
			this.m_CompareFunctionBack = (byte)compareFunctionBack;
			this.m_PassOperationBack = (byte)passOperationBack;
			this.m_FailOperationBack = (byte)failOperationBack;
			this.m_ZFailOperationBack = (byte)zFailOperationBack;
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x0003D3AC File Offset: 0x0003B5AC
		// (set) Token: 0x06002427 RID: 9255 RVA: 0x0003D3C9 File Offset: 0x0003B5C9
		public bool enabled
		{
			get
			{
				return Convert.ToBoolean(this.m_Enabled);
			}
			set
			{
				this.m_Enabled = Convert.ToByte(value);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x0003D3D8 File Offset: 0x0003B5D8
		// (set) Token: 0x06002429 RID: 9257 RVA: 0x0003D3F0 File Offset: 0x0003B5F0
		public byte readMask
		{
			get
			{
				return this.m_ReadMask;
			}
			set
			{
				this.m_ReadMask = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600242A RID: 9258 RVA: 0x0003D3FC File Offset: 0x0003B5FC
		// (set) Token: 0x0600242B RID: 9259 RVA: 0x0003D414 File Offset: 0x0003B614
		public byte writeMask
		{
			get
			{
				return this.m_WriteMask;
			}
			set
			{
				this.m_WriteMask = value;
			}
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0003D41E File Offset: 0x0003B61E
		public void SetCompareFunction(CompareFunction value)
		{
			this.compareFunctionFront = value;
			this.compareFunctionBack = value;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0003D431 File Offset: 0x0003B631
		public void SetPassOperation(StencilOp value)
		{
			this.passOperationFront = value;
			this.passOperationBack = value;
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0003D444 File Offset: 0x0003B644
		public void SetFailOperation(StencilOp value)
		{
			this.failOperationFront = value;
			this.failOperationBack = value;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0003D457 File Offset: 0x0003B657
		public void SetZFailOperation(StencilOp value)
		{
			this.zFailOperationFront = value;
			this.zFailOperationBack = value;
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x0003D46C File Offset: 0x0003B66C
		// (set) Token: 0x06002431 RID: 9265 RVA: 0x0003D484 File Offset: 0x0003B684
		public CompareFunction compareFunctionFront
		{
			get
			{
				return (CompareFunction)this.m_CompareFunctionFront;
			}
			set
			{
				this.m_CompareFunctionFront = (byte)value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002432 RID: 9266 RVA: 0x0003D490 File Offset: 0x0003B690
		// (set) Token: 0x06002433 RID: 9267 RVA: 0x0003D4A8 File Offset: 0x0003B6A8
		public StencilOp passOperationFront
		{
			get
			{
				return (StencilOp)this.m_PassOperationFront;
			}
			set
			{
				this.m_PassOperationFront = (byte)value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x0003D4B4 File Offset: 0x0003B6B4
		// (set) Token: 0x06002435 RID: 9269 RVA: 0x0003D4CC File Offset: 0x0003B6CC
		public StencilOp failOperationFront
		{
			get
			{
				return (StencilOp)this.m_FailOperationFront;
			}
			set
			{
				this.m_FailOperationFront = (byte)value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x0003D4D8 File Offset: 0x0003B6D8
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x0003D4F0 File Offset: 0x0003B6F0
		public StencilOp zFailOperationFront
		{
			get
			{
				return (StencilOp)this.m_ZFailOperationFront;
			}
			set
			{
				this.m_ZFailOperationFront = (byte)value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x0003D4FC File Offset: 0x0003B6FC
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x0003D514 File Offset: 0x0003B714
		public CompareFunction compareFunctionBack
		{
			get
			{
				return (CompareFunction)this.m_CompareFunctionBack;
			}
			set
			{
				this.m_CompareFunctionBack = (byte)value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x0003D520 File Offset: 0x0003B720
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x0003D538 File Offset: 0x0003B738
		public StencilOp passOperationBack
		{
			get
			{
				return (StencilOp)this.m_PassOperationBack;
			}
			set
			{
				this.m_PassOperationBack = (byte)value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x0003D544 File Offset: 0x0003B744
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x0003D55C File Offset: 0x0003B75C
		public StencilOp failOperationBack
		{
			get
			{
				return (StencilOp)this.m_FailOperationBack;
			}
			set
			{
				this.m_FailOperationBack = (byte)value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x0003D568 File Offset: 0x0003B768
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x0003D580 File Offset: 0x0003B780
		public StencilOp zFailOperationBack
		{
			get
			{
				return (StencilOp)this.m_ZFailOperationBack;
			}
			set
			{
				this.m_ZFailOperationBack = (byte)value;
			}
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x0003D58C File Offset: 0x0003B78C
		public bool Equals(StencilState other)
		{
			return this.m_Enabled == other.m_Enabled && this.m_ReadMask == other.m_ReadMask && this.m_WriteMask == other.m_WriteMask && this.m_CompareFunctionFront == other.m_CompareFunctionFront && this.m_PassOperationFront == other.m_PassOperationFront && this.m_FailOperationFront == other.m_FailOperationFront && this.m_ZFailOperationFront == other.m_ZFailOperationFront && this.m_CompareFunctionBack == other.m_CompareFunctionBack && this.m_PassOperationBack == other.m_PassOperationBack && this.m_FailOperationBack == other.m_FailOperationBack && this.m_ZFailOperationBack == other.m_ZFailOperationBack;
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0003D644 File Offset: 0x0003B844
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is StencilState && this.Equals((StencilState)obj);
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0003D67C File Offset: 0x0003B87C
		public override int GetHashCode()
		{
			int num = this.m_Enabled.GetHashCode();
			num = (num * 397 ^ this.m_ReadMask.GetHashCode());
			num = (num * 397 ^ this.m_WriteMask.GetHashCode());
			num = (num * 397 ^ this.m_CompareFunctionFront.GetHashCode());
			num = (num * 397 ^ this.m_PassOperationFront.GetHashCode());
			num = (num * 397 ^ this.m_FailOperationFront.GetHashCode());
			num = (num * 397 ^ this.m_ZFailOperationFront.GetHashCode());
			num = (num * 397 ^ this.m_CompareFunctionBack.GetHashCode());
			num = (num * 397 ^ this.m_PassOperationBack.GetHashCode());
			num = (num * 397 ^ this.m_FailOperationBack.GetHashCode());
			return num * 397 ^ this.m_ZFailOperationBack.GetHashCode();
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x0003D764 File Offset: 0x0003B964
		public static bool operator ==(StencilState left, StencilState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0003D780 File Offset: 0x0003B980
		public static bool operator !=(StencilState left, StencilState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000D61 RID: 3425
		private byte m_Enabled;

		// Token: 0x04000D62 RID: 3426
		private byte m_ReadMask;

		// Token: 0x04000D63 RID: 3427
		private byte m_WriteMask;

		// Token: 0x04000D64 RID: 3428
		private byte m_Padding;

		// Token: 0x04000D65 RID: 3429
		private byte m_CompareFunctionFront;

		// Token: 0x04000D66 RID: 3430
		private byte m_PassOperationFront;

		// Token: 0x04000D67 RID: 3431
		private byte m_FailOperationFront;

		// Token: 0x04000D68 RID: 3432
		private byte m_ZFailOperationFront;

		// Token: 0x04000D69 RID: 3433
		private byte m_CompareFunctionBack;

		// Token: 0x04000D6A RID: 3434
		private byte m_PassOperationBack;

		// Token: 0x04000D6B RID: 3435
		private byte m_FailOperationBack;

		// Token: 0x04000D6C RID: 3436
		private byte m_ZFailOperationBack;
	}
}
