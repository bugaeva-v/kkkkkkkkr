using System;

namespace System.Security.AccessControl
{
	/// <summary>Эти флаги влияют на поведение дескриптора безопасности.</summary>
	// Token: 0x0200051A RID: 1306
	[Flags]
	public enum ControlFlags
	{
		/// <summary>Нет флагов управления.</summary>
		// Token: 0x04002461 RID: 9313
		None = 0,
		/// <summary>Указывает, что владелец <see cref="T:System.Security.Principal.SecurityIdentifier" /> был получен с помощью механизма установки значений по умолчанию. Задается только диспетчером ресурсов; не должен задаваться вызывающими объектами.</summary>
		// Token: 0x04002462 RID: 9314
		OwnerDefaulted = 1,
		/// <summary>Указывает, что группа <see cref="T:System.Security.Principal.SecurityIdentifier" /> была получена с помощью механизма установки значений по умолчанию. Задается только диспетчером ресурсов; не должен задаваться вызывающими объектами.</summary>
		// Token: 0x04002463 RID: 9315
		GroupDefaulted = 2,
		/// <summary>Указывает, что список управления доступом на уровне пользователей не равен <see langword="null" />. Задается диспетчером ресурсов или пользователями.</summary>
		// Token: 0x04002464 RID: 9316
		DiscretionaryAclPresent = 4,
		/// <summary>Указывает, что список управления доступом на уровне пользователей был получен с помощью механизма установки значений по умолчанию. Задается только диспетчером ресурсов.</summary>
		// Token: 0x04002465 RID: 9317
		DiscretionaryAclDefaulted = 8,
		/// <summary>Указывает, что системный список управления доступом не равен <see langword="null" />. Задается диспетчером ресурсов или пользователями.</summary>
		// Token: 0x04002466 RID: 9318
		SystemAclPresent = 16,
		/// <summary>Указывает, что системный список управления доступом был получен с помощью механизма установки значений по умолчанию. Задается только диспетчером ресурсов.</summary>
		// Token: 0x04002467 RID: 9319
		SystemAclDefaulted = 32,
		/// <summary>Не обрабатывается.</summary>
		// Token: 0x04002468 RID: 9320
		DiscretionaryAclUntrusted = 64,
		/// <summary>Не обрабатывается.</summary>
		// Token: 0x04002469 RID: 9321
		ServerSecurity = 128,
		/// <summary>Не обрабатывается.</summary>
		// Token: 0x0400246A RID: 9322
		DiscretionaryAclAutoInheritRequired = 256,
		/// <summary>Не обрабатывается.</summary>
		// Token: 0x0400246B RID: 9323
		SystemAclAutoInheritRequired = 512,
		/// <summary>Указывает, что список управления доступом на уровне пользователей автоматически наследуется у родительского элемента. Задается только диспетчером ресурсов.</summary>
		// Token: 0x0400246C RID: 9324
		DiscretionaryAclAutoInherited = 1024,
		/// <summary>Указывает, что системный список управления доступом автоматически наследуется у родительского элемента. Задается только диспетчером ресурсов.</summary>
		// Token: 0x0400246D RID: 9325
		SystemAclAutoInherited = 2048,
		/// <summary>Указывает, что диспетчер ресурсов не допускает автоматического наследования. Задается диспетчером ресурсов или пользователями.</summary>
		// Token: 0x0400246E RID: 9326
		DiscretionaryAclProtected = 4096,
		/// <summary>Указывает, что диспетчер ресурсов не допускает автоматического наследования. Задается диспетчером ресурсов или пользователями.</summary>
		// Token: 0x0400246F RID: 9327
		SystemAclProtected = 8192,
		/// <summary>Указывает, что содержимое поля Reserved действительно.</summary>
		// Token: 0x04002470 RID: 9328
		RMControlValid = 16384,
		/// <summary>Указывает, что двоичное представление дескриптора безопасности не относительное.  Этот флаг всегда установлен.</summary>
		// Token: 0x04002471 RID: 9329
		SelfRelative = 32768
	}
}
