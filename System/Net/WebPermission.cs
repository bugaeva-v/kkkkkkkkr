using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text.RegularExpressions;

namespace System.Net
{
	/// <summary>Управляет правами доступа к интернет-ресурсам HTTP.</summary>
	// Token: 0x02000611 RID: 1553
	[Serializable]
	public sealed class WebPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x000A9B24 File Offset: 0x000A7D24
		internal static Regex MatchAllRegex
		{
			get
			{
				if (WebPermission.s_MatchAllRegex == null)
				{
					WebPermission.s_MatchAllRegex = new Regex(".*");
				}
				return WebPermission.s_MatchAllRegex;
			}
		}

		/// <summary>Это свойство возвращает перечисление отдельных разрешений на подключение, хранящихся в данном <see cref="T:System.Net.WebPermission" />. Возможными типами объектов, содержащихся в возвращаемом перечислении, являются <see cref="T:System.String" /> и <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" />, содержащий разрешения на подключения.</returns>
		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x000A9B48 File Offset: 0x000A7D48
		public IEnumerator ConnectList
		{
			get
			{
				if (this.m_UnrestrictedConnect)
				{
					return new Regex[]
					{
						WebPermission.MatchAllRegex
					}.GetEnumerator();
				}
				ArrayList arrayList = new ArrayList(this.m_connectList.Count);
				for (int i = 0; i < this.m_connectList.Count; i++)
				{
					arrayList.Add((this.m_connectList[i] is DelayedRegex) ? ((DelayedRegex)this.m_connectList[i]).AsRegex : ((this.m_connectList[i] is Uri) ? ((Uri)this.m_connectList[i]).GetComponents(UriComponents.HttpRequestUrl, UriFormat.UriEscaped) : this.m_connectList[i]));
				}
				return arrayList.GetEnumerator();
			}
		}

		/// <summary>Это свойство возвращает перечисление отдельных разрешений на доступ, хранящихся в данном объекте <see cref="T:System.Net.WebPermission" />. Возможными типами объектов, содержащихся в возвращаемом перечислении, являются <see cref="T:System.String" /> и <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" />, содержащий разрешения на прием подключений.</returns>
		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x000A9C0C File Offset: 0x000A7E0C
		public IEnumerator AcceptList
		{
			get
			{
				if (this.m_UnrestrictedAccept)
				{
					return new Regex[]
					{
						WebPermission.MatchAllRegex
					}.GetEnumerator();
				}
				ArrayList arrayList = new ArrayList(this.m_acceptList.Count);
				for (int i = 0; i < this.m_acceptList.Count; i++)
				{
					arrayList.Add((this.m_acceptList[i] is DelayedRegex) ? ((DelayedRegex)this.m_acceptList[i]).AsRegex : ((this.m_acceptList[i] is Uri) ? ((Uri)this.m_acceptList[i]).GetComponents(UriComponents.HttpRequestUrl, UriFormat.UriEscaped) : this.m_acceptList[i]));
				}
				return arrayList.GetEnumerator();
			}
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.WebPermission" />, который передает или отклоняет все запросы.</summary>
		/// <param name="state">Значение <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		// Token: 0x0600312B RID: 12587 RVA: 0x000A9CCE File Offset: 0x000A7ECE
		public WebPermission(PermissionState state)
		{
			this.m_noRestriction = (state == PermissionState.Unrestricted);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x000A9CF6 File Offset: 0x000A7EF6
		internal WebPermission(bool unrestricted)
		{
			this.m_noRestriction = unrestricted;
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.WebPermission" />.</summary>
		// Token: 0x0600312D RID: 12589 RVA: 0x000A9D1B File Offset: 0x000A7F1B
		public WebPermission()
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x000A9D39 File Offset: 0x000A7F39
		internal WebPermission(NetworkAccess access)
		{
			this.m_UnrestrictedConnect = ((access & NetworkAccess.Connect) > (NetworkAccess)0);
			this.m_UnrestrictedAccept = ((access & NetworkAccess.Accept) > (NetworkAccess)0);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebPermission" /> с указанными правами доступа для заданного регулярного выражения URI.</summary>
		/// <param name="access">Значение <see cref="T:System.Net.NetworkAccess" />, показывающее тип доступа, предоставляемого заданному универсальному коду ресурса (URI). <see cref="F:System.Net.NetworkAccess.Accept" /> показывает, что приложение наделено правом разрешать подключения к локальному ресурсу из Интернета. <see cref="F:System.Net.NetworkAccess.Connect" /> показывает, что приложению разрешено подключаться к определенным интернет-ресурсам.</param>
		/// <param name="uriRegex">Регулярное выражение, описывающее URI, к которому предоставляется доступ.</param>
		// Token: 0x0600312F RID: 12591 RVA: 0x000A9D74 File Offset: 0x000A7F74
		public WebPermission(NetworkAccess access, Regex uriRegex)
		{
			this.AddPermission(access, uriRegex);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebPermission" /> с указанными правами доступа для заданного URI.</summary>
		/// <param name="access">Значение NetworkAccess показывает тип доступа, предоставляемого заданному универсальному коду ресурса (URI). <see cref="F:System.Net.NetworkAccess.Accept" /> показывает, что приложение наделено правом разрешать подключения к локальному ресурсу из Интернета. <see cref="F:System.Net.NetworkAccess.Connect" /> показывает, что приложению разрешено подключаться к определенным интернет-ресурсам.</param>
		/// <param name="uriString">Строка URI, для которого предоставляются права доступа.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="uriString" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003130 RID: 12592 RVA: 0x000A9D9A File Offset: 0x000A7F9A
		public WebPermission(NetworkAccess access, string uriString)
		{
			this.AddPermission(access, uriString);
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x000A9DC0 File Offset: 0x000A7FC0
		internal WebPermission(NetworkAccess access, Uri uri)
		{
			this.AddPermission(access, uri);
		}

		/// <summary>Добавляет в текущий объект <see cref="T:System.Net.WebPermission" /> заданную строку URI с заданными правами доступа.</summary>
		/// <param name="access">Объект <see cref="T:System.Net.NetworkAccess" />, который указывает права доступа, предоставленные для URI.</param>
		/// <param name="uriString">Строка, описывающая URI, для которого предоставляются права доступа.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="uriString" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003132 RID: 12594 RVA: 0x000A9DE8 File Offset: 0x000A7FE8
		public void AddPermission(NetworkAccess access, string uriString)
		{
			if (uriString == null)
			{
				throw new ArgumentNullException("uriString");
			}
			if (this.m_noRestriction)
			{
				return;
			}
			Uri uri;
			if (Uri.TryCreate(uriString, UriKind.Absolute, out uri))
			{
				this.AddPermission(access, uri);
				return;
			}
			ArrayList arrayList = new ArrayList();
			if ((access & NetworkAccess.Connect) != (NetworkAccess)0 && !this.m_UnrestrictedConnect)
			{
				arrayList.Add(this.m_connectList);
			}
			if ((access & NetworkAccess.Accept) != (NetworkAccess)0 && !this.m_UnrestrictedAccept)
			{
				arrayList.Add(this.m_acceptList);
			}
			foreach (object obj in arrayList)
			{
				ArrayList arrayList2 = (ArrayList)obj;
				bool flag = false;
				foreach (object obj2 in arrayList2)
				{
					string text = obj2 as string;
					if (text != null && string.Compare(text, uriString, StringComparison.OrdinalIgnoreCase) == 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					arrayList2.Add(uriString);
				}
			}
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x000A9F0C File Offset: 0x000A810C
		internal void AddPermission(NetworkAccess access, Uri uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			if (this.m_noRestriction)
			{
				return;
			}
			ArrayList arrayList = new ArrayList();
			if ((access & NetworkAccess.Connect) != (NetworkAccess)0 && !this.m_UnrestrictedConnect)
			{
				arrayList.Add(this.m_connectList);
			}
			if ((access & NetworkAccess.Accept) != (NetworkAccess)0 && !this.m_UnrestrictedAccept)
			{
				arrayList.Add(this.m_acceptList);
			}
			foreach (object obj in arrayList)
			{
				ArrayList arrayList2 = (ArrayList)obj;
				bool flag = false;
				foreach (object obj2 in arrayList2)
				{
					if (obj2 is Uri && uri.Equals(obj2))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					arrayList2.Add(uri);
				}
			}
		}

		/// <summary>Добавляет в текущий объект <see cref="T:System.Net.WebPermission" /> заданный URI с заданными правами доступа.</summary>
		/// <param name="access">Объект NetworkAccess, который указывает права доступа, предоставленные для URI.</param>
		/// <param name="uriRegex">Регулярное выражение, описывающее набор URI, которым предоставлены права доступа.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="uriRegex" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003134 RID: 12596 RVA: 0x000AA01C File Offset: 0x000A821C
		public void AddPermission(NetworkAccess access, Regex uriRegex)
		{
			if (uriRegex == null)
			{
				throw new ArgumentNullException("uriRegex");
			}
			if (this.m_noRestriction)
			{
				return;
			}
			if (uriRegex.ToString() == ".*")
			{
				if (!this.m_UnrestrictedConnect && (access & NetworkAccess.Connect) != (NetworkAccess)0)
				{
					this.m_UnrestrictedConnect = true;
					this.m_connectList.Clear();
				}
				if (!this.m_UnrestrictedAccept && (access & NetworkAccess.Accept) != (NetworkAccess)0)
				{
					this.m_UnrestrictedAccept = true;
					this.m_acceptList.Clear();
				}
				return;
			}
			this.AddAsPattern(access, new DelayedRegex(uriRegex));
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x000AA0A4 File Offset: 0x000A82A4
		internal void AddAsPattern(NetworkAccess access, DelayedRegex uriRegexPattern)
		{
			ArrayList arrayList = new ArrayList();
			if ((access & NetworkAccess.Connect) != (NetworkAccess)0 && !this.m_UnrestrictedConnect)
			{
				arrayList.Add(this.m_connectList);
			}
			if ((access & NetworkAccess.Accept) != (NetworkAccess)0 && !this.m_UnrestrictedAccept)
			{
				arrayList.Add(this.m_acceptList);
			}
			foreach (object obj in arrayList)
			{
				ArrayList arrayList2 = (ArrayList)obj;
				bool flag = false;
				foreach (object obj2 in arrayList2)
				{
					if (obj2 is DelayedRegex && string.Compare(uriRegexPattern.ToString(), obj2.ToString(), StringComparison.OrdinalIgnoreCase) == 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					arrayList2.Add(uriRegexPattern);
				}
			}
		}

		/// <summary>Проверяет полное состояние разрешения для <see cref="T:System.Net.WebPermission" />.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Net.WebPermission" /> был создан с помощью <see cref="F:System.Security.Permissions.PermissionState.Unrestricted" /><see cref="T:System.Security.Permissions.PermissionState" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003136 RID: 12598 RVA: 0x000AA1A4 File Offset: 0x000A83A4
		public bool IsUnrestricted()
		{
			return this.m_noRestriction;
		}

		/// <summary>Создает копию <see cref="T:System.Net.WebPermission" />.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Net.WebPermission" />, имеющий те же значения, что и исходный.</returns>
		// Token: 0x06003137 RID: 12599 RVA: 0x000AA1AC File Offset: 0x000A83AC
		public override IPermission Copy()
		{
			if (this.m_noRestriction)
			{
				return new WebPermission(true);
			}
			return new WebPermission((this.m_UnrestrictedConnect ? NetworkAccess.Connect : ((NetworkAccess)0)) | (this.m_UnrestrictedAccept ? NetworkAccess.Accept : ((NetworkAccess)0)))
			{
				m_acceptList = (ArrayList)this.m_acceptList.Clone(),
				m_connectList = (ArrayList)this.m_connectList.Clone()
			};
		}

		/// <summary>Определяет, является ли текущее <see cref="T:System.Net.WebPermission" /> подмножеством заданного объекта.</summary>
		/// <param name="target">Объект <see cref="T:System.Net.WebPermission" /> для сравнения с текущим объектом <see cref="T:System.Net.WebPermission" />.</param>
		/// <returns>
		///   <see langword="true" />, если текущий экземпляр — подмножество параметра <paramref name="target" />, в противном случае — <see langword="false" />. Если цель равна <see langword="null" />, этот метод возвращает <see langword="true" /> для пустого текущего разрешения, не являющегося неограниченным, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр назначения — не является экземпляром <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий экземпляр содержит право в кодировке Regex и не найдено точно такого же права в экземпляре назначения.</exception>
		// Token: 0x06003138 RID: 12600 RVA: 0x000AA218 File Offset: 0x000A8418
		public override bool IsSubsetOf(IPermission target)
		{
			if (target == null)
			{
				return !this.m_noRestriction && !this.m_UnrestrictedConnect && !this.m_UnrestrictedAccept && this.m_connectList.Count == 0 && this.m_acceptList.Count == 0;
			}
			WebPermission webPermission = target as WebPermission;
			if (webPermission == null)
			{
				throw new ArgumentException(SR.GetString("Cannot cast target permission type."), "target");
			}
			if (webPermission.m_noRestriction)
			{
				return true;
			}
			if (this.m_noRestriction)
			{
				return false;
			}
			if (!webPermission.m_UnrestrictedAccept)
			{
				if (this.m_UnrestrictedAccept)
				{
					return false;
				}
				if (this.m_acceptList.Count != 0)
				{
					if (webPermission.m_acceptList.Count == 0)
					{
						return false;
					}
					foreach (object obj in this.m_acceptList)
					{
						if (obj is DelayedRegex)
						{
							if (!WebPermission.isSpecialSubsetCase(obj.ToString(), webPermission.m_acceptList))
							{
								throw new NotSupportedException(SR.GetString("Cannot subset Regex. Only support if both patterns are identical."));
							}
						}
						else if (!WebPermission.isMatchedURI(obj, webPermission.m_acceptList))
						{
							return false;
						}
					}
				}
			}
			if (!webPermission.m_UnrestrictedConnect)
			{
				if (this.m_UnrestrictedConnect)
				{
					return false;
				}
				if (this.m_connectList.Count != 0)
				{
					if (webPermission.m_connectList.Count == 0)
					{
						return false;
					}
					foreach (object obj2 in this.m_connectList)
					{
						if (obj2 is DelayedRegex)
						{
							if (!WebPermission.isSpecialSubsetCase(obj2.ToString(), webPermission.m_connectList))
							{
								throw new NotSupportedException(SR.GetString("Cannot subset Regex. Only support if both patterns are identical."));
							}
						}
						else if (!WebPermission.isMatchedURI(obj2, webPermission.m_connectList))
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x000AA400 File Offset: 0x000A8600
		private static bool isSpecialSubsetCase(string regexToCheck, ArrayList permList)
		{
			foreach (object obj in permList)
			{
				DelayedRegex delayedRegex = obj as DelayedRegex;
				Uri uri;
				if (delayedRegex != null)
				{
					if (string.Compare(regexToCheck, delayedRegex.ToString(), StringComparison.OrdinalIgnoreCase) == 0)
					{
						return true;
					}
				}
				else if ((uri = (obj as Uri)) != null)
				{
					if (string.Compare(regexToCheck, Regex.Escape(uri.GetComponents(UriComponents.HttpRequestUrl, UriFormat.UriEscaped)), StringComparison.OrdinalIgnoreCase) == 0)
					{
						return true;
					}
				}
				else if (string.Compare(regexToCheck, Regex.Escape(obj.ToString()), StringComparison.OrdinalIgnoreCase) == 0)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Возвращает логическое объединение между двумя экземплярами класса <see cref="T:System.Net.WebPermission" />.</summary>
		/// <param name="target">Разрешение <see cref="T:System.Net.WebPermission" />, используемое в сочетании с текущим <see cref="T:System.Net.WebPermission" />.</param>
		/// <returns>Новое <see cref="T:System.Net.WebPermission" />, представляющее собой объединение текущего экземпляра и параметра <paramref name="target" />. Если значение любого объекта <see langword="WebPermission" /> равно <see cref="F:System.Security.Permissions.PermissionState.Unrestricted" />, этот метод возвращает <see cref="T:System.Net.WebPermission" />, то есть <see cref="F:System.Security.Permissions.PermissionState.Unrestricted" />. Если назначением является <see langword="null" />, данный метод возвращает копию текущего объекта <see cref="T:System.Net.WebPermission" />.</returns>
		/// <exception cref="T:System.ArgumentException">назначение не <see langword="null" /> или имеет тип <see cref="T:System.Net.WebPermission" /></exception>
		// Token: 0x0600313A RID: 12602 RVA: 0x000AA4B4 File Offset: 0x000A86B4
		public override IPermission Union(IPermission target)
		{
			if (target == null)
			{
				return this.Copy();
			}
			WebPermission webPermission = target as WebPermission;
			if (webPermission == null)
			{
				throw new ArgumentException(SR.GetString("Cannot cast target permission type."), "target");
			}
			if (this.m_noRestriction || webPermission.m_noRestriction)
			{
				return new WebPermission(true);
			}
			WebPermission webPermission2 = new WebPermission();
			if (this.m_UnrestrictedConnect || webPermission.m_UnrestrictedConnect)
			{
				webPermission2.m_UnrestrictedConnect = true;
			}
			else
			{
				webPermission2.m_connectList = (ArrayList)webPermission.m_connectList.Clone();
				for (int i = 0; i < this.m_connectList.Count; i++)
				{
					DelayedRegex delayedRegex = this.m_connectList[i] as DelayedRegex;
					if (delayedRegex == null)
					{
						if (this.m_connectList[i] is string)
						{
							webPermission2.AddPermission(NetworkAccess.Connect, (string)this.m_connectList[i]);
						}
						else
						{
							webPermission2.AddPermission(NetworkAccess.Connect, (Uri)this.m_connectList[i]);
						}
					}
					else
					{
						webPermission2.AddAsPattern(NetworkAccess.Connect, delayedRegex);
					}
				}
			}
			if (this.m_UnrestrictedAccept || webPermission.m_UnrestrictedAccept)
			{
				webPermission2.m_UnrestrictedAccept = true;
			}
			else
			{
				webPermission2.m_acceptList = (ArrayList)webPermission.m_acceptList.Clone();
				for (int j = 0; j < this.m_acceptList.Count; j++)
				{
					DelayedRegex delayedRegex2 = this.m_acceptList[j] as DelayedRegex;
					if (delayedRegex2 == null)
					{
						if (this.m_acceptList[j] is string)
						{
							webPermission2.AddPermission(NetworkAccess.Accept, (string)this.m_acceptList[j]);
						}
						else
						{
							webPermission2.AddPermission(NetworkAccess.Accept, (Uri)this.m_acceptList[j]);
						}
					}
					else
					{
						webPermission2.AddAsPattern(NetworkAccess.Accept, delayedRegex2);
					}
				}
			}
			return webPermission2;
		}

		/// <summary>Возвращает логическое пересечение двух экземпляров <see cref="T:System.Net.WebPermission" />.</summary>
		/// <param name="target">
		///   <see cref="T:System.Net.WebPermission" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Новое <see cref="T:System.Net.WebPermission" />, представляющее собой пересечение текущего экземпляра и параметра <paramref name="target" />. Если это пересечение пустое, данный метод возвращает <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не <see langword="null" /> или имеет тип <see cref="T:System.Net.WebPermission" /></exception>
		// Token: 0x0600313B RID: 12603 RVA: 0x000AA680 File Offset: 0x000A8880
		public override IPermission Intersect(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			WebPermission webPermission = target as WebPermission;
			if (webPermission == null)
			{
				throw new ArgumentException(SR.GetString("Cannot cast target permission type."), "target");
			}
			if (this.m_noRestriction)
			{
				return webPermission.Copy();
			}
			if (webPermission.m_noRestriction)
			{
				return this.Copy();
			}
			WebPermission webPermission2 = new WebPermission();
			if (this.m_UnrestrictedConnect && webPermission.m_UnrestrictedConnect)
			{
				webPermission2.m_UnrestrictedConnect = true;
			}
			else if (this.m_UnrestrictedConnect || webPermission.m_UnrestrictedConnect)
			{
				webPermission2.m_connectList = (ArrayList)(this.m_UnrestrictedConnect ? webPermission : this).m_connectList.Clone();
			}
			else
			{
				WebPermission.intersectList(this.m_connectList, webPermission.m_connectList, webPermission2.m_connectList);
			}
			if (this.m_UnrestrictedAccept && webPermission.m_UnrestrictedAccept)
			{
				webPermission2.m_UnrestrictedAccept = true;
			}
			else if (this.m_UnrestrictedAccept || webPermission.m_UnrestrictedAccept)
			{
				webPermission2.m_acceptList = (ArrayList)(this.m_UnrestrictedAccept ? webPermission : this).m_acceptList.Clone();
			}
			else
			{
				WebPermission.intersectList(this.m_acceptList, webPermission.m_acceptList, webPermission2.m_acceptList);
			}
			if (!webPermission2.m_UnrestrictedConnect && !webPermission2.m_UnrestrictedAccept && webPermission2.m_connectList.Count == 0 && webPermission2.m_acceptList.Count == 0)
			{
				return null;
			}
			return webPermission2;
		}

		/// <summary>Восстанавливает <see cref="T:System.Net.WebPermission" /> из XML-представления.</summary>
		/// <param name="securityElement">Кодировка XML, используемая для восстановления <see cref="T:System.Net.WebPermission" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="securityElement" /> равно <see langword="null." /></exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="securityElement" /> — не является элементом разрешения для данного типа.</exception>
		// Token: 0x0600313C RID: 12604 RVA: 0x000AA7C8 File Offset: 0x000A89C8
		public override void FromXml(SecurityElement securityElement)
		{
			if (securityElement == null)
			{
				throw new ArgumentNullException("securityElement");
			}
			if (!securityElement.Tag.Equals("IPermission"))
			{
				throw new ArgumentException(SR.GetString("Specified value does not contain 'IPermission' as its tag."), "securityElement");
			}
			string text = securityElement.Attribute("class");
			if (text == null)
			{
				throw new ArgumentException(SR.GetString("Specified value does not contain a 'class' attribute."), "securityElement");
			}
			if (text.IndexOf(base.GetType().FullName) < 0)
			{
				throw new ArgumentException(SR.GetString("The value class attribute is not valid."), "securityElement");
			}
			string text2 = securityElement.Attribute("Unrestricted");
			this.m_connectList = new ArrayList();
			this.m_acceptList = new ArrayList();
			this.m_UnrestrictedAccept = (this.m_UnrestrictedConnect = false);
			if (text2 != null && string.Compare(text2, "true", StringComparison.OrdinalIgnoreCase) == 0)
			{
				this.m_noRestriction = true;
				return;
			}
			this.m_noRestriction = false;
			SecurityElement securityElement2 = securityElement.SearchForChildByTag("ConnectAccess");
			if (securityElement2 != null)
			{
				foreach (object obj in securityElement2.Children)
				{
					SecurityElement securityElement3 = (SecurityElement)obj;
					if (securityElement3.Tag.Equals("URI"))
					{
						string text3;
						try
						{
							text3 = securityElement3.Attribute("uri");
						}
						catch
						{
							text3 = null;
						}
						if (text3 == null)
						{
							throw new ArgumentException(SR.GetString("The '{0}' element contains one or more invalid values."), "ConnectAccess");
						}
						if (text3 == ".*")
						{
							this.m_UnrestrictedConnect = true;
							this.m_connectList = new ArrayList();
							break;
						}
						this.AddAsPattern(NetworkAccess.Connect, new DelayedRegex(text3));
					}
				}
			}
			securityElement2 = securityElement.SearchForChildByTag("AcceptAccess");
			if (securityElement2 != null)
			{
				foreach (object obj2 in securityElement2.Children)
				{
					SecurityElement securityElement4 = (SecurityElement)obj2;
					if (securityElement4.Tag.Equals("URI"))
					{
						string text3;
						try
						{
							text3 = securityElement4.Attribute("uri");
						}
						catch
						{
							text3 = null;
						}
						if (text3 == null)
						{
							throw new ArgumentException(SR.GetString("The '{0}' element contains one or more invalid values."), "AcceptAccess");
						}
						if (text3 == ".*")
						{
							this.m_UnrestrictedAccept = true;
							this.m_acceptList = new ArrayList();
							break;
						}
						this.AddAsPattern(NetworkAccess.Accept, new DelayedRegex(text3));
					}
				}
			}
		}

		/// <summary>Создает кодировку XML для <see cref="T:System.Net.WebPermission" /> и его текущего состояния.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, который содержит представление в кодировке XML разрешения <see cref="T:System.Net.WebPermission" />, включая сведения о состоянии.</returns>
		// Token: 0x0600313D RID: 12605 RVA: 0x000AAA60 File Offset: 0x000A8C60
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = new SecurityElement("IPermission");
			securityElement.AddAttribute("class", base.GetType().FullName + ", " + base.GetType().Module.Assembly.FullName.Replace('"', '\''));
			securityElement.AddAttribute("version", "1");
			if (!this.IsUnrestricted())
			{
				if (this.m_UnrestrictedConnect || this.m_connectList.Count > 0)
				{
					SecurityElement securityElement2 = new SecurityElement("ConnectAccess");
					if (this.m_UnrestrictedConnect)
					{
						SecurityElement securityElement3 = new SecurityElement("URI");
						securityElement3.AddAttribute("uri", SecurityElement.Escape(".*"));
						securityElement2.AddChild(securityElement3);
					}
					else
					{
						foreach (object obj in this.m_connectList)
						{
							Uri uri = obj as Uri;
							string str;
							if (uri != null)
							{
								str = Regex.Escape(uri.GetComponents(UriComponents.HttpRequestUrl, UriFormat.UriEscaped));
							}
							else
							{
								str = obj.ToString();
							}
							if (obj is string)
							{
								str = Regex.Escape(str);
							}
							SecurityElement securityElement4 = new SecurityElement("URI");
							securityElement4.AddAttribute("uri", SecurityElement.Escape(str));
							securityElement2.AddChild(securityElement4);
						}
					}
					securityElement.AddChild(securityElement2);
				}
				if (this.m_UnrestrictedAccept || this.m_acceptList.Count > 0)
				{
					SecurityElement securityElement5 = new SecurityElement("AcceptAccess");
					if (this.m_UnrestrictedAccept)
					{
						SecurityElement securityElement6 = new SecurityElement("URI");
						securityElement6.AddAttribute("uri", SecurityElement.Escape(".*"));
						securityElement5.AddChild(securityElement6);
					}
					else
					{
						foreach (object obj2 in this.m_acceptList)
						{
							Uri uri2 = obj2 as Uri;
							string str;
							if (uri2 != null)
							{
								str = Regex.Escape(uri2.GetComponents(UriComponents.HttpRequestUrl, UriFormat.UriEscaped));
							}
							else
							{
								str = obj2.ToString();
							}
							if (obj2 is string)
							{
								str = Regex.Escape(str);
							}
							SecurityElement securityElement7 = new SecurityElement("URI");
							securityElement7.AddAttribute("uri", SecurityElement.Escape(str));
							securityElement5.AddChild(securityElement7);
						}
					}
					securityElement.AddChild(securityElement5);
				}
			}
			else
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			return securityElement;
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x000AAD00 File Offset: 0x000A8F00
		private static bool isMatchedURI(object uriToCheck, ArrayList uriPatternList)
		{
			string text = uriToCheck as string;
			foreach (object obj in uriPatternList)
			{
				DelayedRegex delayedRegex = obj as DelayedRegex;
				if (delayedRegex == null)
				{
					if (uriToCheck.GetType() == obj.GetType())
					{
						if (text != null && string.Compare(text, (string)obj, StringComparison.OrdinalIgnoreCase) == 0)
						{
							return true;
						}
						if (text == null && uriToCheck.Equals(obj))
						{
							return true;
						}
					}
				}
				else
				{
					string text2 = (text != null) ? text : ((Uri)uriToCheck).GetComponents(UriComponents.HttpRequestUrl, UriFormat.UriEscaped);
					Match match = delayedRegex.AsRegex.Match(text2);
					if (match != null && match.Index == 0 && match.Length == text2.Length)
					{
						return true;
					}
					if (text == null)
					{
						text2 = ((Uri)uriToCheck).GetComponents(UriComponents.HttpRequestUrl, UriFormat.SafeUnescaped);
						match = delayedRegex.AsRegex.Match(text2);
						if (match != null && match.Index == 0 && match.Length == text2.Length)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x000AAE3C File Offset: 0x000A903C
		private static void intersectList(ArrayList A, ArrayList B, ArrayList result)
		{
			bool[] array = new bool[A.Count];
			bool[] array2 = new bool[B.Count];
			int num = 0;
			foreach (object obj in A)
			{
				int num2 = 0;
				foreach (object obj2 in B)
				{
					if (!array2[num2] && obj.GetType() == obj2.GetType())
					{
						if (obj is Uri)
						{
							if (obj.Equals(obj2))
							{
								result.Add(obj);
								array[num] = (array2[num2] = true);
								break;
							}
						}
						else if (string.Compare(obj.ToString(), obj2.ToString(), StringComparison.OrdinalIgnoreCase) == 0)
						{
							result.Add(obj);
							array[num] = (array2[num2] = true);
							break;
						}
					}
					num2++;
				}
				num++;
			}
			num = 0;
			foreach (object l in A)
			{
				if (!array[num])
				{
					int num2 = 0;
					foreach (object r in B)
					{
						if (!array2[num2])
						{
							bool flag;
							object obj3 = WebPermission.intersectPair(l, r, out flag);
							if (obj3 != null)
							{
								bool flag2 = false;
								foreach (object obj4 in result)
								{
									if (flag == obj4 is Uri && (flag ? obj3.Equals(obj4) : (string.Compare(obj4.ToString(), obj3.ToString(), StringComparison.OrdinalIgnoreCase) == 0)))
									{
										flag2 = true;
										break;
									}
								}
								if (!flag2)
								{
									result.Add(obj3);
								}
							}
						}
						num2++;
					}
				}
				num++;
			}
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000AB0AC File Offset: 0x000A92AC
		private static object intersectPair(object L, object R, out bool isUri)
		{
			isUri = false;
			DelayedRegex delayedRegex = L as DelayedRegex;
			DelayedRegex delayedRegex2 = R as DelayedRegex;
			if (delayedRegex != null && delayedRegex2 != null)
			{
				return new DelayedRegex(string.Concat(new string[]
				{
					"(?=(",
					delayedRegex.ToString(),
					"))(",
					delayedRegex2.ToString(),
					")"
				}));
			}
			if (delayedRegex != null && delayedRegex2 == null)
			{
				isUri = (R is Uri);
				string text = isUri ? ((Uri)R).GetComponents(UriComponents.HttpRequestUrl, UriFormat.UriEscaped) : R.ToString();
				Match match = delayedRegex.AsRegex.Match(text);
				if (match != null && match.Index == 0 && match.Length == text.Length)
				{
					return R;
				}
				return null;
			}
			else if (delayedRegex == null && delayedRegex2 != null)
			{
				isUri = (L is Uri);
				string text2 = isUri ? ((Uri)L).GetComponents(UriComponents.HttpRequestUrl, UriFormat.UriEscaped) : L.ToString();
				Match match2 = delayedRegex2.AsRegex.Match(text2);
				if (match2 != null && match2.Index == 0 && match2.Length == text2.Length)
				{
					return L;
				}
				return null;
			}
			else
			{
				isUri = (L is Uri);
				if (isUri)
				{
					if (!L.Equals(R))
					{
						return null;
					}
					return L;
				}
				else
				{
					if (string.Compare(L.ToString(), R.ToString(), StringComparison.OrdinalIgnoreCase) != 0)
					{
						return null;
					}
					return L;
				}
			}
		}

		// Token: 0x04001C9A RID: 7322
		private bool m_noRestriction;

		// Token: 0x04001C9B RID: 7323
		[OptionalField]
		private bool m_UnrestrictedConnect;

		// Token: 0x04001C9C RID: 7324
		[OptionalField]
		private bool m_UnrestrictedAccept;

		// Token: 0x04001C9D RID: 7325
		private ArrayList m_connectList = new ArrayList();

		// Token: 0x04001C9E RID: 7326
		private ArrayList m_acceptList = new ArrayList();

		// Token: 0x04001C9F RID: 7327
		internal const string MatchAll = ".*";

		// Token: 0x04001CA0 RID: 7328
		private static volatile Regex s_MatchAllRegex;
	}
}
