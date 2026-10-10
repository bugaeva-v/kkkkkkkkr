using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007D RID: 125
	[NullableContext(1)]
	[Nullable(0)]
	public class ExponentialBackOffRetryPolicy : IRetryPolicy
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00006423 File Offset: 0x00004623
		public ExponentialBackOffRetryPolicy(int baseRetryDelay = 1000, int maxRetryDelay = 30000, float exponentialFactor = 2f)
		{
			ExponentialBackOffRetryPolicy.ValidateArguments(baseRetryDelay, maxRetryDelay, exponentialFactor);
			this.m_BaseRetryDelay = baseRetryDelay;
			this.m_MaxRetryDelay = maxRetryDelay;
			this.m_ExponentialFactor = exponentialFactor;
			this.m_MaxNumberOfRetriesBeforeCeiling = this.CalculateMaxNumberOfRetriesBeforeCeiling(baseRetryDelay, maxRetryDelay, exponentialFactor);
			this.m_Delayer = new AsyncDelayer();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00006462 File Offset: 0x00004662
		private static void ValidateArguments(int baseRetryDelay, int maxRetryDelay, float exponentialFactor)
		{
			if (baseRetryDelay <= 0)
			{
				throw new ArgumentException("Base retry delay must be greater than 0.");
			}
			if (maxRetryDelay <= 0)
			{
				throw new ArgumentException("Maximum retry delay must be greater than 0.");
			}
			if (exponentialFactor <= 0f)
			{
				throw new ArgumentException("The exponential factor must be greater than 0.");
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00006495 File Offset: 0x00004695
		private int CalculateMaxNumberOfRetriesBeforeCeiling(int baseRetryDelay, int maxRetryDelay, float exponentialFactor)
		{
			return (int)Mathf.Log((float)maxRetryDelay / (float)baseRetryDelay, exponentialFactor);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000064A3 File Offset: 0x000046A3
		internal ExponentialBackOffRetryPolicy(IAsyncDelayer delayer, int baseRetryDelay = 1000, int maxRetryDelay = 30000, float exponentialFactor = 2f) : this(baseRetryDelay, maxRetryDelay, exponentialFactor)
		{
			this.m_Delayer = delayer;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000064B8 File Offset: 0x000046B8
		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			ExponentialBackOffRetryPolicy.<ShouldRetry>d__9 <ShouldRetry>d__;
			<ShouldRetry>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<ShouldRetry>d__.<>4__this = this;
			<ShouldRetry>d__.info = info;
			<ShouldRetry>d__.<>1__state = -1;
			<ShouldRetry>d__.<>t__builder.Start<ExponentialBackOffRetryPolicy.<ShouldRetry>d__9>(ref <ShouldRetry>d__);
			return <ShouldRetry>d__.<>t__builder.Task;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00006503 File Offset: 0x00004703
		private int AdjustDelay(int numberOfRetries)
		{
			if (this.HasHitMaxRetryDelay(numberOfRetries))
			{
				return this.m_MaxRetryDelay;
			}
			return (int)((float)this.m_BaseRetryDelay * Mathf.Pow(this.m_ExponentialFactor, (float)numberOfRetries));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000652B File Offset: 0x0000472B
		private bool HasHitMaxRetryDelay(int numberOfRetries)
		{
			return numberOfRetries > this.m_MaxNumberOfRetriesBeforeCeiling && this.m_ExponentialFactor > 1f;
		}

		// Token: 0x040000B0 RID: 176
		private readonly int m_BaseRetryDelay;

		// Token: 0x040000B1 RID: 177
		private readonly int m_MaxRetryDelay;

		// Token: 0x040000B2 RID: 178
		private readonly float m_ExponentialFactor;

		// Token: 0x040000B3 RID: 179
		private readonly int m_MaxNumberOfRetriesBeforeCeiling;

		// Token: 0x040000B4 RID: 180
		private readonly IAsyncDelayer m_Delayer;
	}
}
