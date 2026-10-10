using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Mono.Security;

namespace System.Security.Policy
{
	/// <summary>Предоставляет зону безопасности сборки кода, используемую в качестве свидетельства для оценки политики. Этот класс не наследуется.</summary>
	// Token: 0x02000427 RID: 1063
	[ComVisible(true)]
	[Serializable]
	public sealed class Zone : EvidenceBase, IIdentityPermissionFactory, IBuiltInEvidence
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.Zone" /> с зоной, являющейся источником сборки кода.</summary>
		/// <param name="zone">Зона, являющаяся источником для связанной сборки кода.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="zone" /> не является допустимым <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B80 RID: 11136 RVA: 0x0009D220 File Offset: 0x0009B420
		public Zone(SecurityZone zone)
		{
			if (!Enum.IsDefined(typeof(SecurityZone), zone))
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid zone {0}."), zone), "zone");
			}
			this.zone = zone;
		}

		/// <summary>Получает зону, являющуюся источником сборки кода.</summary>
		/// <returns>Зона, являющаяся источником сборки кода.</returns>
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x0009D271 File Offset: 0x0009B471
		public SecurityZone SecurityZone
		{
			get
			{
				return this.zone;
			}
		}

		/// <summary>Создает эквивалентную копию объекта свидетельства.</summary>
		/// <returns>Новая, идентичная копия объекта свидетельства.</returns>
		// Token: 0x06002B82 RID: 11138 RVA: 0x0009D279 File Offset: 0x0009B479
		public object Copy()
		{
			return new Zone(this.zone);
		}

		/// <summary>Создает разрешение идентификации, соответствующее текущему экземпляру класса свидетельства <see cref="T:System.Security.Policy.Zone" />.</summary>
		/// <param name="evidence">Набор свидетельств, из которого создается разрешение идентификации.</param>
		/// <returns>Разрешение <see cref="T:System.Security.Permissions.ZoneIdentityPermission" /> для указанного свидетельства <see cref="T:System.Security.Policy.Zone" />.</returns>
		// Token: 0x06002B83 RID: 11139 RVA: 0x0009D286 File Offset: 0x0009B486
		public IPermission CreateIdentityPermission(Evidence evidence)
		{
			return new ZoneIdentityPermission(this.zone);
		}

		/// <summary>Создает новую зону с указанным URL-адресом.</summary>
		/// <param name="url">URL-адрес, используемый для создания зоны.</param>
		/// <returns>Новая зона с указанным URL-адресом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="url" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B84 RID: 11140 RVA: 0x0009D294 File Offset: 0x0009B494
		[MonoTODO("Not user configurable yet")]
		public static Zone CreateFromUrl(string url)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			SecurityZone securityZone = SecurityZone.NoZone;
			if (url.Length == 0)
			{
				return new Zone(securityZone);
			}
			Uri uri = null;
			try
			{
				uri = new Uri(url);
			}
			catch
			{
				return new Zone(securityZone);
			}
			if (securityZone == SecurityZone.NoZone)
			{
				if (uri.IsFile)
				{
					if (File.Exists(uri.LocalPath))
					{
						securityZone = SecurityZone.MyComputer;
					}
					else if (string.Compare("FILE://", 0, url, 0, 7, true, CultureInfo.InvariantCulture) == 0)
					{
						securityZone = SecurityZone.Intranet;
					}
					else
					{
						securityZone = SecurityZone.Internet;
					}
				}
				else if (uri.IsLoopback)
				{
					securityZone = SecurityZone.Intranet;
				}
				else
				{
					securityZone = SecurityZone.Internet;
				}
			}
			return new Zone(securityZone);
		}

		/// <summary>Сравнивает указанный объект и текущий объект свидетельства<see cref="T:System.Security.Policy.Zone" /> на предмет равенства.</summary>
		/// <param name="o">Объект свидетельства <see cref="T:System.Security.Policy.Zone" />, который требуется проверить на эквивалентность текущему объекту.</param>
		/// <returns>Значение <see langword="true" />, если два объекта <see cref="T:System.Security.Policy.Zone" /> равны; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="o" /> не является объектом <see cref="T:System.Security.Policy.Zone" />.</exception>
		// Token: 0x06002B85 RID: 11141 RVA: 0x0009D338 File Offset: 0x0009B538
		public override bool Equals(object o)
		{
			Zone zone = o as Zone;
			return zone != null && zone.zone == this.zone;
		}

		/// <summary>Получает хэш-код текущей зоны.</summary>
		/// <returns>Хэш-код текущей зоны.</returns>
		// Token: 0x06002B86 RID: 11142 RVA: 0x0009D271 File Offset: 0x0009B471
		public override int GetHashCode()
		{
			return (int)this.zone;
		}

		/// <summary>Возвращает строковое представление текущего объекта <see cref="T:System.Security.Policy.Zone" />.</summary>
		/// <returns>Представление текущего объекта <see cref="T:System.Security.Policy.Zone" />.</returns>
		// Token: 0x06002B87 RID: 11143 RVA: 0x0009D360 File Offset: 0x0009B560
		public override string ToString()
		{
			SecurityElement securityElement = new SecurityElement("System.Security.Policy.Zone");
			securityElement.AddAttribute("version", "1");
			securityElement.AddChild(new SecurityElement("Zone", this.zone.ToString()));
			return securityElement.ToString();
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x000221D2 File Offset: 0x000203D2
		int IBuiltInEvidence.GetRequiredSize(bool verbose)
		{
			return 3;
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x0009D3AD File Offset: 0x0009B5AD
		int IBuiltInEvidence.InitFromBuffer(char[] buffer, int position)
		{
			char c = buffer[position++];
			char c2 = buffer[position++];
			return position;
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x0009D3C2 File Offset: 0x0009B5C2
		int IBuiltInEvidence.OutputToBuffer(char[] buffer, int position, bool verbose)
		{
			buffer[position++] = '\u0003';
			buffer[position++] = (char)(this.zone >> 16);
			buffer[position++] = (char)(this.zone & (SecurityZone)65535);
			return position;
		}

		// Token: 0x04001FCA RID: 8138
		private SecurityZone zone;
	}
}
