using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.EnvironmentPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000435 RID: 1077
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class EnvironmentPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.EnvironmentPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="action" /> не является допустимым значением для <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x06002BAB RID: 11179 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public EnvironmentPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Задает полный доступ к переменным среды, которые заданы строковым значением.</summary>
		/// <returns>Список переменных среды для полного доступа.</returns>
		/// <exception cref="T:System.NotSupportedException">Это свойство не поддерживает метод Get.</exception>
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x0009DCFD File Offset: 0x0009BEFD
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x0009DD09 File Offset: 0x0009BF09
		public string All
		{
			get
			{
				throw new NotSupportedException("All");
			}
			set
			{
				this.read = value;
				this.write = value;
			}
		}

		/// <summary>Получает или задает доступ для чтения переменных среды, которые заданы строковым значением.</summary>
		/// <returns>Список переменных среды для доступа с правом на чтение.</returns>
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x0009DD19 File Offset: 0x0009BF19
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x0009DD21 File Offset: 0x0009BF21
		public string Read
		{
			get
			{
				return this.read;
			}
			set
			{
				this.read = value;
			}
		}

		/// <summary>Получает или задает доступ к записи переменных среды, которые заданы строковым значением.</summary>
		/// <returns>Список переменных среды для доступа с правом на запись.</returns>
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x0009DD2A File Offset: 0x0009BF2A
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x0009DD32 File Offset: 0x0009BF32
		public string Write
		{
			get
			{
				return this.write;
			}
			set
			{
				this.write = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.EnvironmentPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.EnvironmentPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002BB2 RID: 11186 RVA: 0x0009DD3C File Offset: 0x0009BF3C
		public override IPermission CreatePermission()
		{
			EnvironmentPermission environmentPermission;
			if (base.Unrestricted)
			{
				environmentPermission = new EnvironmentPermission(PermissionState.Unrestricted);
			}
			else
			{
				environmentPermission = new EnvironmentPermission(PermissionState.None);
				if (this.read != null)
				{
					environmentPermission.AddPathList(EnvironmentPermissionAccess.Read, this.read);
				}
				if (this.write != null)
				{
					environmentPermission.AddPathList(EnvironmentPermissionAccess.Write, this.write);
				}
			}
			return environmentPermission;
		}

		// Token: 0x0400200D RID: 8205
		private string read;

		// Token: 0x0400200E RID: 8206
		private string write;
	}
}
