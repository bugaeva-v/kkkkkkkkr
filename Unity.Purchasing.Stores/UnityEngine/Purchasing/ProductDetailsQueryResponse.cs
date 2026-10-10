using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000020 RID: 32
	internal class ProductDetailsQueryResponse : IProductDetailsQueryResponse
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00003C00 File Offset: 0x00001E00
		protected override void Finalize()
		{
			try
			{
				foreach (ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> valueTuple in this.m_Responses)
				{
					IEnumerable<AndroidJavaObject> item = valueTuple.Item2;
					if (item != null)
					{
						foreach (AndroidJavaObject androidJavaObject in item)
						{
							if (androidJavaObject != null)
							{
								androidJavaObject.Dispose();
							}
						}
					}
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003C9C File Offset: 0x00001E9C
		public void AddResponse(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails)
		{
			this.m_Responses.Add(new ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>(billingResult, (from product in productDetails
			select product).ToList<AndroidJavaObject>()));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003CDC File Offset: 0x00001EDC
		public List<AndroidJavaObject> ProductDetails()
		{
			return (from response in this.m_Responses
			where response.Item1.responseCode == GoogleBillingResponseCode.Ok
			select response).SelectMany((ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> response) => response.Item2).ToList<AndroidJavaObject>();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003D3C File Offset: 0x00001F3C
		public bool IsRecoverable()
		{
			return (from response in this.m_Responses
			select response.Item1).Any(new Func<IGoogleBillingResult, bool>(ProductDetailsQueryResponse.IsRecoverable));
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003D7C File Offset: 0x00001F7C
		public GoogleBillingResponseCode GetRecoverableBillingResponseCode()
		{
			if ((from response in this.m_Responses
			select response.Item1).Any(new Func<IGoogleBillingResult, bool>(ProductDetailsQueryResponse.IsServiceUnavailable)))
			{
				return GoogleBillingResponseCode.ServiceUnavailable;
			}
			if ((from response in this.m_Responses
			select response.Item1).Any(new Func<IGoogleBillingResult, bool>(ProductDetailsQueryResponse.IsDeveloperError)))
			{
				return GoogleBillingResponseCode.DeveloperError;
			}
			return this.m_Responses.FirstOrDefault<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>>().Item1.responseCode;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003E1C File Offset: 0x0000201C
		private static bool IsRecoverable(IGoogleBillingResult billingResult)
		{
			return ProductDetailsQueryResponse.IsServiceUnavailable(billingResult) || ProductDetailsQueryResponse.IsDeveloperError(billingResult);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003E2E File Offset: 0x0000202E
		private static bool IsServiceUnavailable(IGoogleBillingResult billingResult)
		{
			return billingResult.responseCode == GoogleBillingResponseCode.ServiceUnavailable;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003E39 File Offset: 0x00002039
		private static bool IsDeveloperError(IGoogleBillingResult billingResult)
		{
			return billingResult.responseCode == GoogleBillingResponseCode.DeveloperError;
		}

		// Token: 0x04000045 RID: 69
		private readonly ConcurrentBag<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> m_Responses = new ConcurrentBag<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>>();
	}
}
