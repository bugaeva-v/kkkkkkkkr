using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Задает идентификатор приложения (в качестве идентификатора GUID) для данной сборки. Этот класс не наследуется.</summary>
	// Token: 0x0200000E RID: 14
	[AttributeUsage(AttributeTargets.Assembly)]
	[ComVisible(false)]
	public sealed class ApplicationIDAttribute : Attribute, IConfigurationAttribute
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.EnterpriseServices.ApplicationIDAttribute" />, задавая идентификатор GUID, представляющий идентификатор приложения для приложения COM+.</summary>
		/// <param name="guid">Идентификатор GUID, связанный с приложением COM+.</param>
		// Token: 0x06000024 RID: 36 RVA: 0x00002137 File Offset: 0x00000337
		public ApplicationIDAttribute(string guid)
		{
			this.guid = new Guid(guid);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020AA File Offset: 0x000002AA
		bool IConfigurationAttribute.AfterSaveChanges(Hashtable info)
		{
			return false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020AA File Offset: 0x000002AA
		bool IConfigurationAttribute.Apply(Hashtable cache)
		{
			return false;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020AD File Offset: 0x000002AD
		bool IConfigurationAttribute.IsValidTarget(string s)
		{
			return s == "Application";
		}

		/// <summary>Возвращает идентификатор GUID приложения COM+.</summary>
		/// <returns>Идентификатор GUID, представляющий приложение COM+.</returns>
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000214B File Offset: 0x0000034B
		public Guid Value
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x04000038 RID: 56
		private Guid guid;
	}
}
