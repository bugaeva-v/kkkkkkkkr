using System;
using System.Security;

namespace System.IO.IsolatedStorage
{
	/// <summary>Предоставляет параметры для управления размером квоты изолированного хранилища.</summary>
	// Token: 0x02000B78 RID: 2936
	public class IsolatedStorageSecurityState : SecurityState
	{
		// Token: 0x06006AF4 RID: 27380 RVA: 0x0016E127 File Offset: 0x0016C327
		internal IsolatedStorageSecurityState()
		{
		}

		/// <summary>Получает параметр для управления безопасностью изолированного хранилища.</summary>
		/// <returns>Параметр для увеличения размера квоты изолированного хранилища.</returns>
		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x00022807 File Offset: 0x00020A07
		public IsolatedStorageSecurityOptions Options
		{
			get
			{
				return IsolatedStorageSecurityOptions.IncreaseQuotaForApplication;
			}
		}

		/// <summary>Получает или задает текущий размер квоты изолированного хранилища.</summary>
		/// <returns>Текущий размер квоты в байтах.</returns>
		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06006AF6 RID: 27382 RVA: 0x000479F8 File Offset: 0x00045BF8
		// (set) Token: 0x06006AF7 RID: 27383 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public long Quota
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
			}
		}

		/// <summary>Получает текущий размер использования изолированного хранения.</summary>
		/// <returns>Текущий размер использования в байтах.</returns>
		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06006AF8 RID: 27384 RVA: 0x000479F8 File Offset: 0x00045BF8
		public long UsedSize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Гарантирует, что состояние, которое представлено <see cref="T:System.IO.IsolatedStorage.IsolatedStorageSecurityState" />, доступно на узле.</summary>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Состояние недоступно.</exception>
		// Token: 0x06006AF9 RID: 27385 RVA: 0x000479F8 File Offset: 0x00045BF8
		public override void EnsureState()
		{
			throw new NotImplementedException();
		}
	}
}
