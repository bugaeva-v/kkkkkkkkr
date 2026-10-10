using System;

namespace System.Security.Permissions
{
	/// <summary>Определяет допустимое использование значения <see cref="N:System.Reflection" /> и пространства имен <see cref="N:System.Reflection.Emit" />.</summary>
	// Token: 0x0200042E RID: 1070
	[Flags]
	public enum ReflectionPermissionFlag
	{
		/// <summary>Заданы флаги <see langword="TypeInformation" />, <see langword="MemberAccess" /> и <see langword="ReflectionEmit" />. Значение <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.AllFlags" /> не включает флаг <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.RestrictedMemberAccess" />.</summary>
		// Token: 0x04001FEF RID: 8175
		[Obsolete("This permission has been deprecated. Use PermissionState.Unrestricted to get full access.")]
		AllFlags = 7,
		/// <summary>Допустимы операции вызова на все элементы, независимо от набора привилегий. Если этот флаг не установлен, операции вызова допустимы только на видимые элементы.</summary>
		// Token: 0x04001FF0 RID: 8176
		MemberAccess = 2,
		/// <summary>Допускается перечисление типов и элементов. Операции вызова допустимы только на видимые элементы.</summary>
		// Token: 0x04001FF1 RID: 8177
		NoFlags = 0,
		/// <summary>Разрешено генерирование символов отладки. Начиная с .NET Framework 2.0 с пакетом обновления 1 (SP1), этот флаг больше не требуется для генерирования кода.</summary>
		// Token: 0x04001FF2 RID: 8178
		[Obsolete("This permission is no longer used by the CLR.")]
		ReflectionEmit = 4,
		/// <summary>Для кода с неполным доверием предусмотрен ограниченный доступ к элементам. Код с неполным доверием может допускать неоткрытые типы и элементы, но только в том случае, если набор привилегий кода с неполным доверием включает все разрешения в наборе привилегий сборки, содержащей неоткрытые типы и элементы, к которым выполняется обращение. Этот флаг является новым в .NET Framework 2.0 с пакетом обновления 1 (SP1).</summary>
		// Token: 0x04001FF3 RID: 8179
		RestrictedMemberAccess = 8,
		/// <summary>Этот флаг устарел. Чтобы перечислять типы и элементы и исследовать их метаданные, флаги не нужны. Взамен рекомендуется использовать <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.NoFlags" />.</summary>
		// Token: 0x04001FF4 RID: 8180
		[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
		TypeInformation = 1
	}
}
