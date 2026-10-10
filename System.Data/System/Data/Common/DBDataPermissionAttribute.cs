using System;
using System.ComponentModel;
using System.Security.Permissions;

namespace System.Data.Common
{
	/// <summary>Связывает операцию безопасности с пользовательским атрибутом безопасности.</summary>
	// Token: 0x020003D1 RID: 977
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public abstract class DBDataPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DBDataPermissionAttribute" />.</summary>
		/// <param name="action">Одно из значений операции безопасности, представляющее операцию, которая может быть выполнена с помощью декларативной безопасности.</param>
		// Token: 0x06002F2C RID: 12076 RVA: 0x000CAB04 File Offset: 0x000C8D04
		protected DBDataPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Возвращает или задает значение, показывающее, допускается ли пустой пароль.</summary>
		/// <returns>Значение <see langword="true" />, если пустой пароль допустим; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000CAB0D File Offset: 0x000C8D0D
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x000CAB15 File Offset: 0x000C8D15
		public bool AllowBlankPassword
		{
			get
			{
				return this._allowBlankPassword;
			}
			set
			{
				this._allowBlankPassword = value;
			}
		}

		/// <summary>Возвращает или задает разрешенную строку подключения.</summary>
		/// <returns>Разрешенная строка подключения.</returns>
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x000CAB20 File Offset: 0x000C8D20
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x000CAB3E File Offset: 0x000C8D3E
		public string ConnectionString
		{
			get
			{
				string connectionString = this._connectionString;
				if (connectionString == null)
				{
					return string.Empty;
				}
				return connectionString;
			}
			set
			{
				this._connectionString = value;
			}
		}

		/// <summary>Определяет, являются ли параметры в списке параметров строк подключения, указанных в свойстве <see cref="P:System.Data.Common.DBDataPermissionAttribute.KeyRestrictions" />, единственными допустимыми параметрами строк подключения.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.KeyRestrictionBehavior" />.</returns>
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000CAB47 File Offset: 0x000C8D47
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x000CAB4F File Offset: 0x000C8D4F
		public KeyRestrictionBehavior KeyRestrictionBehavior
		{
			get
			{
				return this._behavior;
			}
			set
			{
				if (value <= KeyRestrictionBehavior.PreventUsage)
				{
					this._behavior = value;
					return;
				}
				throw ADP.InvalidKeyRestrictionBehavior(value);
			}
		}

		/// <summary>Возвращает или задает параметры строки подключения, которые разрешены или запрещены.</summary>
		/// <returns>Один или несколько параметров строки подключения, которые разрешены или запрещены.</returns>
		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x000CAB64 File Offset: 0x000C8D64
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x000CAB82 File Offset: 0x000C8D82
		public string KeyRestrictions
		{
			get
			{
				string restrictions = this._restrictions;
				if (restrictions == null)
				{
					return ADP.StrEmpty;
				}
				return restrictions;
			}
			set
			{
				this._restrictions = value;
			}
		}

		/// <summary>Определяет, должен ли атрибут выполнять сериализацию строки подключения.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут должен выполнять сериализацию строки подключения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002F35 RID: 12085 RVA: 0x000CAB8B File Offset: 0x000C8D8B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeConnectionString()
		{
			return this._connectionString != null;
		}

		/// <summary>Определяет, должен ли атрибут выполнять сериализацию набора ключевых ограничений.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут должен выполнять сериализацию набора ключевых ограничений; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002F36 RID: 12086 RVA: 0x000CAB96 File Offset: 0x000C8D96
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeKeyRestrictions()
		{
			return this._restrictions != null;
		}

		// Token: 0x04001C6F RID: 7279
		private bool _allowBlankPassword;

		// Token: 0x04001C70 RID: 7280
		private string _connectionString;

		// Token: 0x04001C71 RID: 7281
		private string _restrictions;

		// Token: 0x04001C72 RID: 7282
		private KeyRestrictionBehavior _behavior;
	}
}
