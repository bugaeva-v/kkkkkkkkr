using System;

namespace System.Security.Principal
{
	/// <summary>Задает способ создания участников и объектов удостоверений для домена приложения. Значение по умолчанию — <see langword="UnauthenticatedPrincipal" />.</summary>
	// Token: 0x020004E0 RID: 1248
	public enum PrincipalPolicy
	{
		/// <summary>Для сущности, не прошедшей проверку подлинности, должны быть созданы объекты-участники и объекты идентификации. Для сущности, не прошедшей проверку подлинности, свойство <see cref="P:System.Security.Principal.GenericIdentity.Name" /> имеет значение пустой строки (""), а свойство <see cref="P:System.Security.Principal.GenericIdentity.IsAuthenticated" /> — значение <see langword="false" />.</summary>
		// Token: 0x040022B4 RID: 8884
		UnauthenticatedPrincipal,
		/// <summary>Не должно создаваться ни одного объекта-участника или объекта идентификации.</summary>
		// Token: 0x040022B5 RID: 8885
		NoPrincipal,
		/// <summary>Должны быть созданы объекты-участники и объекты идентификации, отражающие маркер операционной системы, связанный с текущим выполняемым потоком, а связанным группам операционной системы должны быть сопоставлены роли.</summary>
		// Token: 0x040022B6 RID: 8886
		WindowsPrincipal
	}
}
