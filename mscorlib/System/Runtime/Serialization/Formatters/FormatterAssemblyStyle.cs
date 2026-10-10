using System;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Указывает метод, который будет использоваться во время десериализации для расположения и загрузки сборок.</summary>
	// Token: 0x02000679 RID: 1657
	public enum FormatterAssemblyStyle
	{
		/// <summary>В простом режиме сборка, используемая во время десериализации, не должна точно соответствовать сборке, используемой во время сериализации. В частности, номера версий не должны совпадать, так как метод <see cref="Overload:System.Reflection.Assembly.LoadWithPartialName" /> используется для загрузки сборки.</summary>
		// Token: 0x040027AA RID: 10154
		Simple,
		/// <summary>В полном режиме сборка, используемая во время десериализации, должна точно соответствовать сборке, используемой во время сериализации. Метод <see cref="Overload:System.Reflection.Assembly.Load" /> класса <see cref="T:System.Reflection.Assembly" /> используется для загрузки сборки.</summary>
		// Token: 0x040027AB RID: 10155
		Full
	}
}
