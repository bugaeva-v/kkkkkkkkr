using System;

namespace System.Net
{
	/// <summary>Указывает протоколы для проверки подлинности.</summary>
	// Token: 0x020005C2 RID: 1474
	[Flags]
	public enum AuthenticationSchemes
	{
		/// <summary>Проверка подлинности не разрешена. Клиент, запрашивающий объект <see cref="T:System.Net.HttpListener" /> с установленным приведенным флагом, всегда будет получать состояние 403 "Запрещено". Используйте этот флаг, если ресурс не должен предоставляться клиенту.</summary>
		// Token: 0x04001A54 RID: 6740
		None = 0,
		/// <summary>Определяет дайджест-проверку подлинности.</summary>
		// Token: 0x04001A55 RID: 6741
		Digest = 1,
		/// <summary>Проводит согласование с клиентом для определения схемы проверки подлинности. Если и клиент, и сервер поддерживают Kerberos, используется именно этот протокол; в противном случае используется NTLM.</summary>
		// Token: 0x04001A56 RID: 6742
		Negotiate = 2,
		/// <summary>Указывает проверку подлинности NTLM.</summary>
		// Token: 0x04001A57 RID: 6743
		Ntlm = 4,
		/// <summary>Определяет обычную проверку подлинности.</summary>
		// Token: 0x04001A58 RID: 6744
		Basic = 8,
		/// <summary>Указывает анонимную проверку подлинности.</summary>
		// Token: 0x04001A59 RID: 6745
		Anonymous = 32768,
		/// <summary>Указывает проверку подлинности Windows.</summary>
		// Token: 0x04001A5A RID: 6746
		IntegratedWindowsAuthentication = 6
	}
}
