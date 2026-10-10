using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Указывает флаги доступа для объекта разрешения безопасности.</summary>
	// Token: 0x02000459 RID: 1113
	[Flags]
	[ComVisible(true)]
	[Serializable]
	public enum SecurityPermissionFlag
	{
		/// <summary>Нет доступа безопасности.</summary>
		// Token: 0x04002099 RID: 8345
		NoFlags = 0,
		/// <summary>Возможность утверждения того, что все вызывающие этого кода имеют необходимое разрешение для операции.</summary>
		// Token: 0x0400209A RID: 8346
		Assertion = 1,
		/// <summary>Возможность вызывать неуправляемый код.</summary>
		// Token: 0x0400209B RID: 8347
		UnmanagedCode = 2,
		/// <summary>Возможность пропускать проверку кода в этой сборке. Код, который является непроверяемым, может быть запущен для проверки, если предоставлено это разрешение.</summary>
		// Token: 0x0400209C RID: 8348
		SkipVerification = 4,
		/// <summary>Разрешение на запуск кода. Без этого разрешения управляемый код не может быть выполнен.</summary>
		// Token: 0x0400209D RID: 8349
		Execution = 8,
		/// <summary>Возможность использовать некоторые расширенные операции над потоками.</summary>
		// Token: 0x0400209E RID: 8350
		ControlThread = 16,
		/// <summary>Возможность предоставления свидетельства, включая возможность изменять свидетельство, предоставленное общеязыковой средой выполнения.</summary>
		// Token: 0x0400209F RID: 8351
		ControlEvidence = 32,
		/// <summary>Возможность просматривать и изменять политику.</summary>
		// Token: 0x040020A0 RID: 8352
		ControlPolicy = 64,
		/// <summary>Возможность предоставления служб сериализации. Используется форматтерами сериализации.</summary>
		// Token: 0x040020A1 RID: 8353
		SerializationFormatter = 128,
		/// <summary>Возможность задания политики домена.</summary>
		// Token: 0x040020A2 RID: 8354
		ControlDomainPolicy = 256,
		/// <summary>Возможность управлять объектом участника.</summary>
		// Token: 0x040020A3 RID: 8355
		ControlPrincipal = 512,
		/// <summary>Возможность создания и управления объектом <see cref="T:System.AppDomain" />.</summary>
		// Token: 0x040020A4 RID: 8356
		ControlAppDomain = 1024,
		/// <summary>Разрешение настраивать типы и каналы удаленного взаимодействия.</summary>
		// Token: 0x040020A5 RID: 8357
		RemotingConfiguration = 2048,
		/// <summary>Разрешение на подключение кода в инфраструктуру среды CLR, например добавление удаленных приемников контекста, приемников делегата и динамических приемников.</summary>
		// Token: 0x040020A6 RID: 8358
		Infrastructure = 4096,
		/// <summary>Разрешение на выполнение явного перенаправления привязки в файле конфигурации приложения. Это относится к перенаправлению сборок .NET Framework, которые были объединены, а также других сборок, находящихся вне .NET Framework.</summary>
		// Token: 0x040020A7 RID: 8359
		BindingRedirects = 8192,
		/// <summary>Неограниченное состояние разрешения.</summary>
		// Token: 0x040020A8 RID: 8360
		AllFlags = 16383
	}
}
