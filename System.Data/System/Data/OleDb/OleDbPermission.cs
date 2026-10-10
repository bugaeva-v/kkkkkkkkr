using System;
using System.ComponentModel;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.OleDb
{
	/// <summary>Позволяет поставщику данных .NET Framework для OLE DB обеспечить пользователю уровень безопасности, достаточный для доступа к источнику данных OLE DB.</summary>
	// Token: 0x0200015A RID: 346
	[Serializable]
	public sealed class OleDbPermission : DBDataPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbPermission" />.</summary>
		// Token: 0x06001291 RID: 4753 RVA: 0x0005AAB6 File Offset: 0x00058CB6
		[Obsolete("OleDbPermission() has been deprecated.  Use the OleDbPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
		public OleDbPermission() : this(PermissionState.None)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbPermission" />.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		// Token: 0x06001292 RID: 4754 RVA: 0x0005AABF File Offset: 0x00058CBF
		public OleDbPermission(PermissionState state) : base(state)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbPermission" />.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <param name="allowBlankPassword">Указывает, разрешается ли пустой пароль.</param>
		// Token: 0x06001293 RID: 4755 RVA: 0x0005AAC8 File Offset: 0x00058CC8
		[Obsolete("OleDbPermission(PermissionState state, Boolean allowBlankPassword) has been deprecated.  Use the OleDbPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
		public OleDbPermission(PermissionState state, bool allowBlankPassword) : this(state)
		{
			base.AllowBlankPassword = allowBlankPassword;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0005AAD8 File Offset: 0x00058CD8
		private OleDbPermission(OleDbPermission permission) : base(permission)
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0005AAE1 File Offset: 0x00058CE1
		internal OleDbPermission(OleDbPermissionAttribute permissionAttribute) : base(permissionAttribute)
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0005AAEA File Offset: 0x00058CEA
		internal OleDbPermission(OleDbConnectionString constr) : base(constr)
		{
			if (constr == null || constr.IsEmpty)
			{
				base.Add(ADP.StrEmpty, ADP.StrEmpty, KeyRestrictionBehavior.AllowOnly);
			}
		}

		/// <summary>Это свойство промаркировано как устаревшее. Установка этого свойства ни на что не повлияет.</summary>
		/// <returns>Это свойство промаркировано как устаревшее. Установка этого свойства ни на что не повлияет.</returns>
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x0005AB10 File Offset: 0x00058D10
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x0005AB60 File Offset: 0x00058D60
		[Obsolete("Provider property has been deprecated.  Use the Add method.  http://go.microsoft.com/fwlink/?linkid=14202")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public string Provider
		{
			get
			{
				string text = this._providers;
				if (text == null)
				{
					string[] providerRestriction = this._providerRestriction;
					if (providerRestriction != null && providerRestriction.Length != 0)
					{
						text = providerRestriction[0];
						for (int i = 1; i < providerRestriction.Length; i++)
						{
							text = text + ";" + providerRestriction[i];
						}
					}
				}
				if (text == null)
				{
					return ADP.StrEmpty;
				}
				return text;
			}
			set
			{
				string[] array = null;
				if (!ADP.IsEmpty(value))
				{
					array = value.Split(new char[]
					{
						';'
					});
					array = DBConnectionString.RemoveDuplicates(array);
				}
				this._providerRestriction = array;
				this._providers = value;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.OleDb.OleDbPermission" /> в качестве <see cref="T:System.Security.IPermission" />.</summary>
		/// <returns>Копия текущего объекта разрешения.</returns>
		// Token: 0x06001299 RID: 4761 RVA: 0x0005AB9E File Offset: 0x00058D9E
		public override IPermission Copy()
		{
			return new OleDbPermission(this);
		}

		// Token: 0x04000BA8 RID: 2984
		private string[] _providerRestriction;

		// Token: 0x04000BA9 RID: 2985
		private string _providers;
	}
}
