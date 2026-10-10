using System;

namespace System
{
	/// <summary>Настраиваемое средство синтаксического анализа, основанное на схеме протокола LDAP.</summary>
	// Token: 0x02000163 RID: 355
	public class LdapStyleUriParser : UriParser
	{
		/// <summary>Создает настраиваемое средство синтаксического анализа, основанное на схеме протокола LDAP.</summary>
		// Token: 0x06000990 RID: 2448 RVA: 0x0002A307 File Offset: 0x00028507
		public LdapStyleUriParser() : base(UriParser.LdapUri.Flags)
		{
		}
	}
}
