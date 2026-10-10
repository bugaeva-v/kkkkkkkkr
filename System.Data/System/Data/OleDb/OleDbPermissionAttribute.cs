using System;
using System.ComponentModel;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.OleDb
{
	/// <summary>Связывает операцию безопасности с пользовательским атрибутом безопасности.</summary>
	// Token: 0x0200015B RID: 347
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class OleDbPermissionAttribute : DBDataPermissionAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbPermissionAttribute" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />, представляющих действие, которое может быть выполнено с применением декларативной безопасности.</param>
		// Token: 0x0600129A RID: 4762 RVA: 0x0005ABA6 File Offset: 0x00058DA6
		public OleDbPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Возвращает или задает строку со списком поддерживаемых поставщиков, в качестве разделителя используется запятая.</summary>
		/// <returns>Разделенный запятыми список поставщиков, разрешаемых политикой безопасности.</returns>
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x0005ABB0 File Offset: 0x00058DB0
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x0005ABCE File Offset: 0x00058DCE
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Provider property has been deprecated.  Use the Add method.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public string Provider
		{
			get
			{
				string providers = this._providers;
				if (providers == null)
				{
					return ADP.StrEmpty;
				}
				return providers;
			}
			set
			{
				this._providers = value;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.OleDb.OleDbPermission" />, который настроен в соответствии со свойствами атрибутов.</summary>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbPermission" />.</returns>
		// Token: 0x0600129D RID: 4765 RVA: 0x0005ABD7 File Offset: 0x00058DD7
		public override IPermission CreatePermission()
		{
			return new OleDbPermission(this);
		}

		// Token: 0x04000BAA RID: 2986
		private string _providers;
	}
}
