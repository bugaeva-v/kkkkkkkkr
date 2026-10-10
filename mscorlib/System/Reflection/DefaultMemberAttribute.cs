using System;

namespace System.Reflection
{
	/// <summary>Описывает члена типа, являющегося членом по умолчанию, который используется методом <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />.</summary>
	// Token: 0x02000897 RID: 2199
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class DefaultMemberAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.DefaultMemberAttribute" />.</summary>
		/// <param name="memberName">Значение типа <see langword="String" />, содержащее имя вызываемого члена. Это может быть конструктор, метод, свойство или поле. При вызове метода должен быть задан подходящий атрибут вызова. Член по умолчанию для класса может быть задан путем передачи пустой <see langword="String" /> в качестве имени члена.  
		/// Член по умолчанию для типа помечается пользовательским атрибутом <see langword="DefaultMemberAttribute" /> или в COM-объекте обычным путем.</param>
		// Token: 0x06004898 RID: 18584 RVA: 0x000EE24F File Offset: 0x000EC44F
		public DefaultMemberAttribute(string memberName)
		{
			this.MemberName = memberName;
		}

		/// <summary>Возвращает имя из атрибута.</summary>
		/// <returns>Строка, представляющая имя члена.</returns>
		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x000EE25E File Offset: 0x000EC45E
		public string MemberName { get; }
	}
}
