using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Задает имя приложения COM+, которое будет использоваться для установки компонентов в сборке. Этот класс не наследуется.</summary>
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Assembly)]
	[ComVisible(false)]
	public sealed class ApplicationNameAttribute : Attribute, IConfigurationAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ApplicationNameAttribute" />, задавая имя приложения COM+, используемое для установки компонентов.</summary>
		/// <param name="name">Имя приложения COM+.</param>
		// Token: 0x06000029 RID: 41 RVA: 0x00002153 File Offset: 0x00000353
		public ApplicationNameAttribute(string name)
		{
			this.name = name;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020AA File Offset: 0x000002AA
		bool IConfigurationAttribute.AfterSaveChanges(Hashtable info)
		{
			return false;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		bool IConfigurationAttribute.Apply(Hashtable cache)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020AD File Offset: 0x000002AD
		bool IConfigurationAttribute.IsValidTarget(string s)
		{
			return s == "Application";
		}

		/// <summary>Получает значение, которое указывает имя приложения COM+, содержащего компоненты в сборке.</summary>
		/// <returns>Имя приложения COM+.</returns>
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002162 File Offset: 0x00000362
		public string Value
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x04000039 RID: 57
		private string name;
	}
}
