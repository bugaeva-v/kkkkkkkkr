using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace System.Data.Common
{
	/// <summary>Позволяет поставщику данных .NET Framework гарантировать, что уровень безопасности пользователя достаточен для доступа к данным.</summary>
	// Token: 0x020003CF RID: 975
	[SecurityPermission(SecurityAction.InheritanceDemand, ControlEvidence = true, ControlPolicy = true)]
	[Serializable]
	public abstract class DBDataPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="DBDataPermission" />.</summary>
		// Token: 0x06002F15 RID: 12053 RVA: 0x000CA22C File Offset: 0x000C842C
		[Obsolete("DBDataPermission() has been deprecated.  Use the DBDataPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
		protected DBDataPermission() : this(PermissionState.None)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="DBDataPermission" /> с указанным значением <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		// Token: 0x06002F16 RID: 12054 RVA: 0x000CA235 File Offset: 0x000C8435
		protected DBDataPermission(PermissionState state)
		{
			this._keyvaluetree = NameValuePermission.Default;
			base..ctor();
			if (state == PermissionState.Unrestricted)
			{
				this._isUnrestricted = true;
				return;
			}
			if (state == PermissionState.None)
			{
				this._isUnrestricted = false;
				return;
			}
			throw ADP.InvalidPermissionState(state);
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="DBDataPermission" /> с указанным значением <see cref="T:System.Security.Permissions.PermissionState" /> и значением, указывающим, разрешается ли использовать пустой пароль.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <param name="allowBlankPassword">Значение <see langword="true" />, если пустой пароль допустим; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06002F17 RID: 12055 RVA: 0x000CA265 File Offset: 0x000C8465
		[Obsolete("DBDataPermission(PermissionState state,Boolean allowBlankPassword) has been deprecated.  Use the DBDataPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
		protected DBDataPermission(PermissionState state, bool allowBlankPassword) : this(state)
		{
			this.AllowBlankPassword = allowBlankPassword;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="DBDataPermission" />, используя существующие объекты <see langword="DBDataPermission" />.</summary>
		/// <param name="permission">Существующий объект <see langword="DBDataPermission" />, использованный для создания нового объекта <see langword="DBDataPermission" />.</param>
		// Token: 0x06002F18 RID: 12056 RVA: 0x000CA275 File Offset: 0x000C8475
		protected DBDataPermission(DBDataPermission permission)
		{
			this._keyvaluetree = NameValuePermission.Default;
			base..ctor();
			if (permission == null)
			{
				throw ADP.ArgumentNull("permissionAttribute");
			}
			this.CopyFrom(permission);
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="DBDataPermission" /> с указанным значением <see langword="DBDataPermissionAttribute" />.</summary>
		/// <param name="permissionAttribute">Действие по обеспечению безопасности, связанное с пользовательским атрибутом безопасности.</param>
		// Token: 0x06002F19 RID: 12057 RVA: 0x000CA2A0 File Offset: 0x000C84A0
		protected DBDataPermission(DBDataPermissionAttribute permissionAttribute)
		{
			this._keyvaluetree = NameValuePermission.Default;
			base..ctor();
			if (permissionAttribute == null)
			{
				throw ADP.ArgumentNull("permissionAttribute");
			}
			this._isUnrestricted = permissionAttribute.Unrestricted;
			if (!this._isUnrestricted)
			{
				this._allowBlankPassword = permissionAttribute.AllowBlankPassword;
				if (permissionAttribute.ShouldSerializeConnectionString() || permissionAttribute.ShouldSerializeKeyRestrictions())
				{
					this.Add(permissionAttribute.ConnectionString, permissionAttribute.KeyRestrictions, permissionAttribute.KeyRestrictionBehavior);
				}
			}
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000CA314 File Offset: 0x000C8514
		internal DBDataPermission(DbConnectionOptions connectionOptions)
		{
			this._keyvaluetree = NameValuePermission.Default;
			base..ctor();
			if (connectionOptions != null)
			{
				this._allowBlankPassword = connectionOptions.HasBlankPassword;
				this.AddPermissionEntry(new DBConnectionString(connectionOptions));
			}
		}

		/// <summary>Получает значение, определяющее, разрешен ли пустой пароль.</summary>
		/// <returns>Значение <see langword="true" />, если пустой пароль разрешен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x000CA342 File Offset: 0x000C8542
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x000CA34A File Offset: 0x000C854A
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

		/// <summary>Добавляет доступ для заданной строки подключения к существующему состоянию объекта <see langword="DBDataPermission" />.</summary>
		/// <param name="connectionString">Разрешенная строка подключения.</param>
		/// <param name="restrictions">Строка, определяющая разрешенные или запрещенные параметры строки подключения.</param>
		/// <param name="behavior">Одно из свойств <see cref="T:System.Data.KeyRestrictionBehavior" />.</param>
		// Token: 0x06002F1D RID: 12061 RVA: 0x000CA354 File Offset: 0x000C8554
		public virtual void Add(string connectionString, string restrictions, KeyRestrictionBehavior behavior)
		{
			DBConnectionString entry = new DBConnectionString(connectionString, restrictions, behavior, null, false);
			this.AddPermissionEntry(entry);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000CA374 File Offset: 0x000C8574
		internal void AddPermissionEntry(DBConnectionString entry)
		{
			if (this._keyvaluetree == null)
			{
				this._keyvaluetree = new NameValuePermission();
			}
			if (this._keyvalues == null)
			{
				this._keyvalues = new ArrayList();
			}
			NameValuePermission.AddEntry(this._keyvaluetree, this._keyvalues, entry);
			this._isUnrestricted = false;
		}

		/// <summary>Удаляет все разрешения, которые были до этого добавлены с помощью метода <see cref="M:System.Data.Common.DBDataPermission.Add(System.String,System.String,System.Data.KeyRestrictionBehavior)" />.</summary>
		// Token: 0x06002F1F RID: 12063 RVA: 0x000CA3C0 File Offset: 0x000C85C0
		protected void Clear()
		{
			this._keyvaluetree = null;
			this._keyvalues = null;
		}

		/// <summary>Создает и возвращает идентичную копию текущего объекта разрешения.</summary>
		/// <returns>Копия текущего объекта разрешения.</returns>
		// Token: 0x06002F20 RID: 12064 RVA: 0x000CA3D0 File Offset: 0x000C85D0
		public override IPermission Copy()
		{
			DBDataPermission dbdataPermission = this.CreateInstance();
			dbdataPermission.CopyFrom(this);
			return dbdataPermission;
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x000CA3E0 File Offset: 0x000C85E0
		private void CopyFrom(DBDataPermission permission)
		{
			this._isUnrestricted = permission.IsUnrestricted();
			if (!this._isUnrestricted)
			{
				this._allowBlankPassword = permission.AllowBlankPassword;
				if (permission._keyvalues != null)
				{
					this._keyvalues = (ArrayList)permission._keyvalues.Clone();
					if (permission._keyvaluetree != null)
					{
						this._keyvaluetree = permission._keyvaluetree.CopyNameValue();
					}
				}
			}
		}

		/// <summary>Создает новый экземпляр класса <see langword="DBDataPermission" />.</summary>
		/// <returns>Новый объект <see langword="DBDataPermission" />.</returns>
		// Token: 0x06002F22 RID: 12066 RVA: 0x000CA444 File Offset: 0x000C8644
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		protected virtual DBDataPermission CreateInstance()
		{
			return Activator.CreateInstance(base.GetType(), BindingFlags.Instance | BindingFlags.Public, null, null, CultureInfo.InvariantCulture, null) as DBDataPermission;
		}

		/// <summary>Возвращает новый объект разрешений, предоставляющий пересечение текущего и заданного объектов разрешений.</summary>
		/// <param name="target">Объект разрешений, пересекающийся с текущим объектом разрешений. Должен относиться к тому же типу, что и текущий объект разрешений.</param>
		/// <returns>Новый объект разрешений, представляющий собой пересечение текущего и заданного объектов разрешений. Этот новый объект разрешений представляет собой ссылку со значением NULL (<see langword="Nothing" /> в Visual Basic), если пересечение пусто.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является ссылкой со значением NULL (<see langword="Nothing" /> в Visual Basic), а также не является экземпляром того же класса, что и текущий объект разрешений.</exception>
		// Token: 0x06002F23 RID: 12067 RVA: 0x000CA460 File Offset: 0x000C8660
		public override IPermission Intersect(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			if (target.GetType() != base.GetType())
			{
				throw ADP.PermissionTypeMismatch();
			}
			if (this.IsUnrestricted())
			{
				return target.Copy();
			}
			DBDataPermission dbdataPermission = (DBDataPermission)target;
			if (dbdataPermission.IsUnrestricted())
			{
				return this.Copy();
			}
			DBDataPermission dbdataPermission2 = (DBDataPermission)dbdataPermission.Copy();
			dbdataPermission2._allowBlankPassword &= this.AllowBlankPassword;
			if (this._keyvalues != null && dbdataPermission2._keyvalues != null)
			{
				dbdataPermission2._keyvalues.Clear();
				dbdataPermission2._keyvaluetree.Intersect(dbdataPermission2._keyvalues, this._keyvaluetree);
			}
			else
			{
				dbdataPermission2._keyvalues = null;
				dbdataPermission2._keyvaluetree = null;
			}
			if (dbdataPermission2.IsEmpty())
			{
				dbdataPermission2 = null;
			}
			return dbdataPermission2;
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x000CA51C File Offset: 0x000C871C
		private bool IsEmpty()
		{
			ArrayList keyvalues = this._keyvalues;
			return !this.IsUnrestricted() && !this.AllowBlankPassword && (keyvalues == null || keyvalues.Count == 0);
		}

		/// <summary>Возвращает значение, указывающее, является ли текущий объект разрешений подмножеством заданного объекта разрешений.</summary>
		/// <param name="target">Объект разрешения, для которого требуется проверить соотношение подмножеств. Этот объект должен относиться к тому же типу, что и текущий объект разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект разрешений является подмножеством заданного объекта разрешений; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> — это объект типа, который отличается от типа текущего объекта разрешений.</exception>
		// Token: 0x06002F25 RID: 12069 RVA: 0x000CA550 File Offset: 0x000C8750
		public override bool IsSubsetOf(IPermission target)
		{
			if (target == null)
			{
				return this.IsEmpty();
			}
			if (target.GetType() != base.GetType())
			{
				throw ADP.PermissionTypeMismatch();
			}
			DBDataPermission dbdataPermission = target as DBDataPermission;
			bool flag = dbdataPermission.IsUnrestricted();
			if (!flag && !this.IsUnrestricted() && (!this.AllowBlankPassword || dbdataPermission.AllowBlankPassword) && (this._keyvalues == null || dbdataPermission._keyvaluetree != null))
			{
				flag = true;
				if (this._keyvalues != null)
				{
					foreach (object obj in this._keyvalues)
					{
						DBConnectionString parsetable = (DBConnectionString)obj;
						if (!dbdataPermission._keyvaluetree.CheckValueForKeyPermit(parsetable))
						{
							flag = false;
							break;
						}
					}
				}
			}
			return flag;
		}

		/// <summary>Возвращает значение, указывающее, должно ли разрешение быть представлено как неограниченное без знания его семантики.</summary>
		/// <returns>
		///   <see langword="true" />, если разрешение может быть представлено как неограниченное.</returns>
		// Token: 0x06002F26 RID: 12070 RVA: 0x000CA620 File Offset: 0x000C8820
		public bool IsUnrestricted()
		{
			return this._isUnrestricted;
		}

		/// <summary>Возвращает новый объект разрешений, представляющий собой объединение текущего и заданного объектов разрешений.</summary>
		/// <param name="target">Объект разрешений для комбинирования с текущим объектом разрешений. Должен относиться к тому же типу, что и текущий объект разрешений.</param>
		/// <returns>Новый объект разрешения, представляющий собой объединение текущего и заданного объектов разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Объект <paramref name="target" /> имеет тип, отличный от типа текущего объекта разрешений.</exception>
		// Token: 0x06002F27 RID: 12071 RVA: 0x000CA628 File Offset: 0x000C8828
		public override IPermission Union(IPermission target)
		{
			if (target == null)
			{
				return this.Copy();
			}
			if (target.GetType() != base.GetType())
			{
				throw ADP.PermissionTypeMismatch();
			}
			if (this.IsUnrestricted())
			{
				return this.Copy();
			}
			DBDataPermission dbdataPermission = (DBDataPermission)target.Copy();
			if (!dbdataPermission.IsUnrestricted())
			{
				dbdataPermission._allowBlankPassword |= this.AllowBlankPassword;
				if (this._keyvalues != null)
				{
					foreach (object obj in this._keyvalues)
					{
						DBConnectionString entry = (DBConnectionString)obj;
						dbdataPermission.AddPermissionEntry(entry);
					}
				}
			}
			if (!dbdataPermission.IsEmpty())
			{
				return dbdataPermission;
			}
			return null;
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x000CA6F0 File Offset: 0x000C88F0
		private string DecodeXmlValue(string value)
		{
			if (value != null && 0 < value.Length)
			{
				value = value.Replace("&quot;", "\"");
				value = value.Replace("&apos;", "'");
				value = value.Replace("&lt;", "<");
				value = value.Replace("&gt;", ">");
				value = value.Replace("&amp;", "&");
			}
			return value;
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x000CA764 File Offset: 0x000C8964
		private string EncodeXmlValue(string value)
		{
			if (value != null && 0 < value.Length)
			{
				value = value.Replace('\0', ' ');
				value = value.Trim();
				value = value.Replace("&", "&amp;");
				value = value.Replace(">", "&gt;");
				value = value.Replace("<", "&lt;");
				value = value.Replace("'", "&apos;");
				value = value.Replace("\"", "&quot;");
			}
			return value;
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="securityElement">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		// Token: 0x06002F2A RID: 12074 RVA: 0x000CA7EC File Offset: 0x000C89EC
		public override void FromXml(SecurityElement securityElement)
		{
			if (securityElement == null)
			{
				throw ADP.ArgumentNull("securityElement");
			}
			string tag = securityElement.Tag;
			if (!tag.Equals("Permission") && !tag.Equals("IPermission"))
			{
				throw ADP.NotAPermissionElement();
			}
			string text = securityElement.Attribute("version");
			if (text != null && !text.Equals("1"))
			{
				throw ADP.InvalidXMLBadVersion();
			}
			string text2 = securityElement.Attribute("Unrestricted");
			this._isUnrestricted = (text2 != null && bool.Parse(text2));
			this.Clear();
			if (!this._isUnrestricted)
			{
				string text3 = securityElement.Attribute("AllowBlankPassword");
				this._allowBlankPassword = (text3 != null && bool.Parse(text3));
				ArrayList children = securityElement.Children;
				if (children == null)
				{
					return;
				}
				using (IEnumerator enumerator = children.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						SecurityElement securityElement2 = (SecurityElement)obj;
						tag = securityElement2.Tag;
						if ("add" == tag || (tag != null && "add" == tag.ToLower(CultureInfo.InvariantCulture)))
						{
							string text4 = securityElement2.Attribute("ConnectionString");
							string text5 = securityElement2.Attribute("KeyRestrictions");
							string text6 = securityElement2.Attribute("KeyRestrictionBehavior");
							KeyRestrictionBehavior behavior = KeyRestrictionBehavior.AllowOnly;
							if (text6 != null)
							{
								behavior = (KeyRestrictionBehavior)Enum.Parse(typeof(KeyRestrictionBehavior), text6, true);
							}
							text4 = this.DecodeXmlValue(text4);
							text5 = this.DecodeXmlValue(text5);
							this.Add(text4, text5, behavior);
						}
					}
					return;
				}
			}
			this._allowBlankPassword = false;
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002F2B RID: 12075 RVA: 0x000CA9A0 File Offset: 0x000C8BA0
		public override SecurityElement ToXml()
		{
			Type type = base.GetType();
			SecurityElement securityElement = new SecurityElement("IPermission");
			securityElement.AddAttribute("class", type.AssemblyQualifiedName.Replace('"', '\''));
			securityElement.AddAttribute("version", "1");
			if (this.IsUnrestricted())
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			else
			{
				securityElement.AddAttribute("AllowBlankPassword", this._allowBlankPassword.ToString(CultureInfo.InvariantCulture));
				if (this._keyvalues != null)
				{
					foreach (object obj in this._keyvalues)
					{
						DBConnectionString dbconnectionString = (DBConnectionString)obj;
						SecurityElement securityElement2 = new SecurityElement("add");
						string text = dbconnectionString.ConnectionString;
						text = this.EncodeXmlValue(text);
						if (!ADP.IsEmpty(text))
						{
							securityElement2.AddAttribute("ConnectionString", text);
						}
						text = dbconnectionString.Restrictions;
						text = this.EncodeXmlValue(text);
						if (text == null)
						{
							text = ADP.StrEmpty;
						}
						securityElement2.AddAttribute("KeyRestrictions", text);
						text = dbconnectionString.Behavior.ToString();
						securityElement2.AddAttribute("KeyRestrictionBehavior", text);
						securityElement.AddChild(securityElement2);
					}
				}
			}
			return securityElement;
		}

		// Token: 0x04001C5F RID: 7263
		private bool _isUnrestricted;

		// Token: 0x04001C60 RID: 7264
		private bool _allowBlankPassword;

		// Token: 0x04001C61 RID: 7265
		private NameValuePermission _keyvaluetree;

		// Token: 0x04001C62 RID: 7266
		private ArrayList _keyvalues;

		// Token: 0x020003D0 RID: 976
		private static class XmlStr
		{
			// Token: 0x04001C63 RID: 7267
			internal const string _class = "class";

			// Token: 0x04001C64 RID: 7268
			internal const string _IPermission = "IPermission";

			// Token: 0x04001C65 RID: 7269
			internal const string _Permission = "Permission";

			// Token: 0x04001C66 RID: 7270
			internal const string _Unrestricted = "Unrestricted";

			// Token: 0x04001C67 RID: 7271
			internal const string _AllowBlankPassword = "AllowBlankPassword";

			// Token: 0x04001C68 RID: 7272
			internal const string _true = "true";

			// Token: 0x04001C69 RID: 7273
			internal const string _Version = "version";

			// Token: 0x04001C6A RID: 7274
			internal const string _VersionNumber = "1";

			// Token: 0x04001C6B RID: 7275
			internal const string _add = "add";

			// Token: 0x04001C6C RID: 7276
			internal const string _ConnectionString = "ConnectionString";

			// Token: 0x04001C6D RID: 7277
			internal const string _KeyRestrictions = "KeyRestrictions";

			// Token: 0x04001C6E RID: 7278
			internal const string _KeyRestrictionBehavior = "KeyRestrictionBehavior";
		}
	}
}
