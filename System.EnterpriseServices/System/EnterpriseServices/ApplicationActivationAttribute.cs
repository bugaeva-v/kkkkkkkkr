using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Указывает, выполняются ли компоненты при сборке в процессе создателя или в системном процессе.</summary>
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Assembly)]
	[ComVisible(false)]
	public sealed class ApplicationActivationAttribute : Attribute, IConfigurationAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ApplicationActivationAttribute" />, устанавливая указанное значение <see cref="T:System.EnterpriseServices.ActivationOption" />.</summary>
		/// <param name="opt">Одно из значений <see cref="T:System.EnterpriseServices.ActivationOption" />.</param>
		// Token: 0x0600001B RID: 27 RVA: 0x000020FE File Offset: 0x000002FE
		public ApplicationActivationAttribute(ActivationOption opt)
		{
			this.opt = opt;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		bool IConfigurationAttribute.AfterSaveChanges(Hashtable info)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		bool IConfigurationAttribute.Apply(Hashtable cache)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020AD File Offset: 0x000002AD
		bool IConfigurationAttribute.IsValidTarget(string s)
		{
			return s == "Application";
		}

		/// <summary>Это свойство не поддерживается в текущей версии.</summary>
		/// <returns>Это свойство не поддерживается в текущей версии.</returns>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000210D File Offset: 0x0000030D
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002115 File Offset: 0x00000315
		public string SoapMailbox
		{
			get
			{
				return this.soapMailbox;
			}
			set
			{
				this.soapMailbox = value;
			}
		}

		/// <summary>Получает или задает значение, представляющее собой виртуальную корневую папку приложения COM+ в Интернете.</summary>
		/// <returns>Виртуальная корневая папка приложения COM+ в Интернете.</returns>
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000211E File Offset: 0x0000031E
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002126 File Offset: 0x00000326
		public string SoapVRoot
		{
			get
			{
				return this.soapVRoot;
			}
			set
			{
				this.soapVRoot = value;
			}
		}

		/// <summary>Возвращает указанное значение <see cref="T:System.EnterpriseServices.ActivationOption" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.ActivationOption" />, или <see langword="Library" /> или <see langword="Server" />.</returns>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000212F File Offset: 0x0000032F
		public ActivationOption Value
		{
			get
			{
				return this.opt;
			}
		}

		// Token: 0x04000035 RID: 53
		private ActivationOption opt;

		// Token: 0x04000036 RID: 54
		private string soapMailbox;

		// Token: 0x04000037 RID: 55
		private string soapVRoot;
	}
}
