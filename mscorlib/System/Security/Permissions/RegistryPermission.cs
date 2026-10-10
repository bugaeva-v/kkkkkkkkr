using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace System.Security.Permissions
{
	/// <summary>Управляет возможностью доступа к переменным реестра. Этот класс не наследуется.</summary>
	// Token: 0x02000453 RID: 1107
	[ComVisible(true)]
	[Serializable]
	public sealed class RegistryPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.RegistryPermission" /> указанным состоянием разрешения: полностью ограниченное или неограниченное.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002CE7 RID: 11495 RVA: 0x000A10B5 File Offset: 0x0009F2B5
		public RegistryPermission(PermissionState state)
		{
			this._state = CodeAccessPermission.CheckPermissionState(state, true);
			this.createList = new ArrayList();
			this.readList = new ArrayList();
			this.writeList = new ArrayList();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.RegistryPermission" /> с заданным доступом к указанным переменным реестра.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</param>
		/// <param name="pathList">Список переменных реестра (разделенных точкой с запятой), к которым предоставляется доступ.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="pathList" /> не является допустимой строкой.</exception>
		// Token: 0x06002CE8 RID: 11496 RVA: 0x000A10EB File Offset: 0x0009F2EB
		public RegistryPermission(RegistryPermissionAccess access, string pathList)
		{
			this._state = PermissionState.None;
			this.createList = new ArrayList();
			this.readList = new ArrayList();
			this.writeList = new ArrayList();
			this.AddPathList(access, pathList);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.RegistryPermission" /> с указанным доступом к указанным переменным реестра и указанными правами доступа к сведениям об элементе управления реестра.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</param>
		/// <param name="control">Поразрядное сочетание значений <see cref="T:System.Security.AccessControl.AccessControlActions" />.</param>
		/// <param name="pathList">Список переменных реестра (разделенных точкой с запятой), к которым предоставляется доступ.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="pathList" /> не является допустимой строкой.</exception>
		// Token: 0x06002CE9 RID: 11497 RVA: 0x000A1124 File Offset: 0x0009F324
		public RegistryPermission(RegistryPermissionAccess access, AccessControlActions control, string pathList)
		{
			if (!Enum.IsDefined(typeof(AccessControlActions), control))
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), control), "AccessControlActions");
			}
			this._state = PermissionState.None;
			this.AddPathList(access, control, pathList);
		}

		/// <summary>Добавляет доступ для заданных переменных реестра к существующему состоянию разрешения.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</param>
		/// <param name="pathList">Список переменных реестра (разделенных точкой с запятой).</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="pathList" /> не является допустимой строкой.</exception>
		// Token: 0x06002CEA RID: 11498 RVA: 0x000A1180 File Offset: 0x0009F380
		public void AddPathList(RegistryPermissionAccess access, string pathList)
		{
			if (pathList == null)
			{
				throw new ArgumentNullException("pathList");
			}
			switch (access)
			{
			case RegistryPermissionAccess.NoAccess:
				return;
			case RegistryPermissionAccess.Read:
				this.AddWithUnionKey(this.readList, pathList);
				return;
			case RegistryPermissionAccess.Write:
				this.AddWithUnionKey(this.writeList, pathList);
				return;
			case RegistryPermissionAccess.Create:
				this.AddWithUnionKey(this.createList, pathList);
				return;
			case RegistryPermissionAccess.AllAccess:
				this.AddWithUnionKey(this.createList, pathList);
				this.AddWithUnionKey(this.readList, pathList);
				this.AddWithUnionKey(this.writeList, pathList);
				return;
			}
			this.ThrowInvalidFlag(access, false);
		}

		/// <summary>Добавляет доступ для указанных переменных реестра в существующее состояние разрешения, задавая уровень доступа разрешения реестра и действия по управлению доступом.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</param>
		/// <param name="control">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlActions" />.</param>
		/// <param name="pathList">Список переменных реестра (разделенных точкой с запятой).</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="pathList" /> не является допустимой строкой.</exception>
		// Token: 0x06002CEB RID: 11499 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("(2.0) Access Control isn't implemented")]
		public void AddPathList(RegistryPermissionAccess access, AccessControlActions control, string pathList)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает пути для всех переменных реестра с заданным <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />, представляющее один тип доступа к переменным среды.</param>
		/// <returns>Список переменных реестра (разделенных точкой с запятой) с указанным <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="access" /> не является допустимым значением <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.  
		/// -или- 
		///  <paramref name="access" /> имеет значение <see cref="F:System.Security.Permissions.RegistryPermissionAccess.AllAccess" />, которое представляет несколько типов доступа к переменным реестра, или <see cref="F:System.Security.Permissions.RegistryPermissionAccess.NoAccess" />, которое не представляет ни один тип доступа к переменным реестра.</exception>
		// Token: 0x06002CEC RID: 11500 RVA: 0x000A1220 File Offset: 0x0009F420
		public string GetPathList(RegistryPermissionAccess access)
		{
			switch (access)
			{
			case RegistryPermissionAccess.NoAccess:
			case RegistryPermissionAccess.AllAccess:
				this.ThrowInvalidFlag(access, true);
				goto IL_61;
			case RegistryPermissionAccess.Read:
				return this.GetPathList(this.readList);
			case RegistryPermissionAccess.Write:
				return this.GetPathList(this.writeList);
			case RegistryPermissionAccess.Create:
				return this.GetPathList(this.createList);
			}
			this.ThrowInvalidFlag(access, false);
			IL_61:
			return null;
		}

		/// <summary>Задает новый доступ для указанных имен переменных реестра в существующее состояние разрешения.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</param>
		/// <param name="pathList">Список переменных реестра (разделенных точкой с запятой).</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="pathList" /> не является допустимой строкой.</exception>
		// Token: 0x06002CED RID: 11501 RVA: 0x000A1290 File Offset: 0x0009F490
		public void SetPathList(RegistryPermissionAccess access, string pathList)
		{
			if (pathList == null)
			{
				throw new ArgumentNullException("pathList");
			}
			switch (access)
			{
			case RegistryPermissionAccess.NoAccess:
				return;
			case RegistryPermissionAccess.Read:
				this.readList.Clear();
				foreach (string value in pathList.Split(';', StringSplitOptions.None))
				{
					this.readList.Add(value);
				}
				return;
			case RegistryPermissionAccess.Write:
				this.writeList.Clear();
				foreach (string value2 in pathList.Split(';', StringSplitOptions.None))
				{
					this.writeList.Add(value2);
				}
				return;
			case RegistryPermissionAccess.Create:
				this.createList.Clear();
				foreach (string value3 in pathList.Split(';', StringSplitOptions.None))
				{
					this.createList.Add(value3);
				}
				return;
			case RegistryPermissionAccess.AllAccess:
				this.createList.Clear();
				this.readList.Clear();
				this.writeList.Clear();
				foreach (string value4 in pathList.Split(';', StringSplitOptions.None))
				{
					this.createList.Add(value4);
					this.readList.Add(value4);
					this.writeList.Add(value4);
				}
				return;
			}
			this.ThrowInvalidFlag(access, false);
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002CEE RID: 11502 RVA: 0x000A13E8 File Offset: 0x0009F5E8
		public override IPermission Copy()
		{
			RegistryPermission registryPermission = new RegistryPermission(this._state);
			string pathList = this.GetPathList(RegistryPermissionAccess.Create);
			if (pathList != null)
			{
				registryPermission.SetPathList(RegistryPermissionAccess.Create, pathList);
			}
			pathList = this.GetPathList(RegistryPermissionAccess.Read);
			if (pathList != null)
			{
				registryPermission.SetPathList(RegistryPermissionAccess.Read, pathList);
			}
			pathList = this.GetPathList(RegistryPermissionAccess.Write);
			if (pathList != null)
			{
				registryPermission.SetPathList(RegistryPermissionAccess.Write, pathList);
			}
			return registryPermission;
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="elem" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="elem" /> не является допустимым элементом разрешения.  
		/// -или- 
		/// Недопустимый номер версии параметра <paramref name="elem" />.</exception>
		// Token: 0x06002CEF RID: 11503 RVA: 0x000A143C File Offset: 0x0009F63C
		public override void FromXml(SecurityElement esd)
		{
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			if (CodeAccessPermission.IsUnrestricted(esd))
			{
				this._state = PermissionState.Unrestricted;
			}
			string text = esd.Attribute("Create");
			if (text != null && text.Length > 0)
			{
				this.SetPathList(RegistryPermissionAccess.Create, text);
			}
			string text2 = esd.Attribute("Read");
			if (text2 != null && text2.Length > 0)
			{
				this.SetPathList(RegistryPermissionAccess.Read, text2);
			}
			string text3 = esd.Attribute("Write");
			if (text3 != null && text3.Length > 0)
			{
				this.SetPathList(RegistryPermissionAccess.Write, text3);
			}
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002CF0 RID: 11504 RVA: 0x000A14D4 File Offset: 0x0009F6D4
		[SecuritySafeCritical]
		public override IPermission Intersect(IPermission target)
		{
			RegistryPermission registryPermission = this.Cast(target);
			if (registryPermission == null)
			{
				return null;
			}
			if (this.IsUnrestricted())
			{
				return registryPermission.Copy();
			}
			if (registryPermission.IsUnrestricted())
			{
				return this.Copy();
			}
			RegistryPermission registryPermission2 = new RegistryPermission(PermissionState.None);
			this.IntersectKeys(this.createList, registryPermission.createList, registryPermission2.createList);
			this.IntersectKeys(this.readList, registryPermission.readList, registryPermission2.readList);
			this.IntersectKeys(this.writeList, registryPermission.writeList, registryPermission2.writeList);
			if (!registryPermission2.IsEmpty())
			{
				return registryPermission2;
			}
			return null;
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002CF1 RID: 11505 RVA: 0x000A1568 File Offset: 0x0009F768
		[SecuritySafeCritical]
		public override bool IsSubsetOf(IPermission target)
		{
			RegistryPermission registryPermission = this.Cast(target);
			if (registryPermission == null)
			{
				return false;
			}
			if (registryPermission.IsEmpty())
			{
				return this.IsEmpty();
			}
			if (this.IsUnrestricted())
			{
				return registryPermission.IsUnrestricted();
			}
			return registryPermission.IsUnrestricted() || (this.KeyIsSubsetOf(this.createList, registryPermission.createList) && this.KeyIsSubsetOf(this.readList, registryPermission.readList) && this.KeyIsSubsetOf(this.writeList, registryPermission.writeList));
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002CF2 RID: 11506 RVA: 0x000A15ED File Offset: 0x0009F7ED
		public bool IsUnrestricted()
		{
			return this._state == PermissionState.Unrestricted;
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002CF3 RID: 11507 RVA: 0x000A15F8 File Offset: 0x0009F7F8
		[SecuritySafeCritical]
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (this._state == PermissionState.Unrestricted)
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			else
			{
				string pathList = this.GetPathList(RegistryPermissionAccess.Create);
				if (pathList != null)
				{
					securityElement.AddAttribute("Create", pathList);
				}
				pathList = this.GetPathList(RegistryPermissionAccess.Read);
				if (pathList != null)
				{
					securityElement.AddAttribute("Read", pathList);
				}
				pathList = this.GetPathList(RegistryPermissionAccess.Write);
				if (pathList != null)
				{
					securityElement.AddAttribute("Write", pathList);
				}
			}
			return securityElement;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="other">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="other" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002CF4 RID: 11508 RVA: 0x000A1670 File Offset: 0x0009F870
		[SecuritySafeCritical]
		public override IPermission Union(IPermission other)
		{
			RegistryPermission registryPermission = this.Cast(other);
			if (registryPermission == null)
			{
				return this.Copy();
			}
			if (this.IsUnrestricted() || registryPermission.IsUnrestricted())
			{
				return new RegistryPermission(PermissionState.Unrestricted);
			}
			if (this.IsEmpty() && registryPermission.IsEmpty())
			{
				return null;
			}
			RegistryPermission registryPermission2 = (RegistryPermission)this.Copy();
			string pathList = registryPermission.GetPathList(RegistryPermissionAccess.Create);
			if (pathList != null)
			{
				registryPermission2.AddPathList(RegistryPermissionAccess.Create, pathList);
			}
			pathList = registryPermission.GetPathList(RegistryPermissionAccess.Read);
			if (pathList != null)
			{
				registryPermission2.AddPathList(RegistryPermissionAccess.Read, pathList);
			}
			pathList = registryPermission.GetPathList(RegistryPermissionAccess.Write);
			if (pathList != null)
			{
				registryPermission2.AddPathList(RegistryPermissionAccess.Write, pathList);
			}
			return registryPermission2;
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
		int IBuiltInPermission.GetTokenIndex()
		{
			return 5;
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x000A16FE File Offset: 0x0009F8FE
		private bool IsEmpty()
		{
			return this._state == PermissionState.None && this.createList.Count == 0 && this.readList.Count == 0 && this.writeList.Count == 0;
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000A1732 File Offset: 0x0009F932
		private RegistryPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			RegistryPermission registryPermission = target as RegistryPermission;
			if (registryPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(RegistryPermission));
			}
			return registryPermission;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x000A1754 File Offset: 0x0009F954
		internal void ThrowInvalidFlag(RegistryPermissionAccess flag, bool context)
		{
			string text;
			if (context)
			{
				text = Locale.GetText("Unknown flag '{0}'.");
			}
			else
			{
				text = Locale.GetText("Invalid flag '{0}' in this context.");
			}
			throw new ArgumentException(string.Format(text, flag), "flag");
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x000A1794 File Offset: 0x0009F994
		private string GetPathList(ArrayList list)
		{
			if (this.IsUnrestricted())
			{
				return string.Empty;
			}
			if (list.Count == 0)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (object obj in list)
			{
				string value = (string)obj;
				stringBuilder.Append(value);
				stringBuilder.Append(";");
			}
			string text = stringBuilder.ToString();
			int length = text.Length;
			if (length > 0)
			{
				return text.Substring(0, length - 1);
			}
			return string.Empty;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000A1840 File Offset: 0x0009FA40
		internal bool KeyIsSubsetOf(IList local, IList target)
		{
			bool flag = false;
			foreach (object obj in local)
			{
				string text = (string)obj;
				foreach (object obj2 in target)
				{
					string value = (string)obj2;
					if (text.StartsWith(value))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000A18EC File Offset: 0x0009FAEC
		internal void AddWithUnionKey(IList list, string pathList)
		{
			foreach (string text in pathList.Split(';', StringSplitOptions.None))
			{
				int count = list.Count;
				if (count == 0)
				{
					list.Add(text);
				}
				else
				{
					for (int j = 0; j < count; j++)
					{
						string text2 = (string)list[j];
						if (text2.StartsWith(text))
						{
							list[j] = text;
						}
						else if (!text.StartsWith(text2))
						{
							list.Add(text);
						}
					}
				}
			}
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x000A1970 File Offset: 0x0009FB70
		internal void IntersectKeys(IList local, IList target, IList result)
		{
			foreach (object obj in local)
			{
				string text = (string)obj;
				foreach (object obj2 in target)
				{
					string text2 = (string)obj2;
					if (text2.Length > text.Length)
					{
						if (text2.StartsWith(text))
						{
							result.Add(text2);
						}
					}
					else if (text.StartsWith(text2))
					{
						result.Add(text);
					}
				}
			}
		}

		// Token: 0x0400207F RID: 8319
		private const int version = 1;

		// Token: 0x04002080 RID: 8320
		private PermissionState _state;

		// Token: 0x04002081 RID: 8321
		private ArrayList createList;

		// Token: 0x04002082 RID: 8322
		private ArrayList readList;

		// Token: 0x04002083 RID: 8323
		private ArrayList writeList;
	}
}
