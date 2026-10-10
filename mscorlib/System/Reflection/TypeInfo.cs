using System;
using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Представляет объявления типов для классов, интерфейсов, массивов, значений, перечислений, параметров, определений универсальных типов и открытых или закрытых сконструированных универсальных типов.</summary>
	// Token: 0x020008D0 RID: 2256
	public abstract class TypeInfo : Type, IReflectableType
	{
		/// <summary>Возвращает представление текущего типа объекта <see cref="T:System.Reflection.TypeInfo" />.</summary>
		/// <returns>Ссылка на текущий тип.</returns>
		// Token: 0x06004B29 RID: 19241 RVA: 0x0000270D File Offset: 0x0000090D
		TypeInfo IReflectableType.GetTypeInfo()
		{
			return this;
		}

		/// <summary>Возвращает текущий тип в виде объекта <see cref="T:System.Type" />.</summary>
		/// <returns>Текущий тип.</returns>
		// Token: 0x06004B2A RID: 19242 RVA: 0x0000270D File Offset: 0x0000090D
		public virtual Type AsType()
		{
			return this;
		}

		/// <summary>Возвращает массив параметров универсального типа для текущего экземпляра.</summary>
		/// <returns>Массив, содержащий параметры текущего экземпляра универсального типа или массив <see cref="P:System.Array.Length" /> 0, если текущий экземпляр не имеет параметры универсального типа.</returns>
		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06004B2B RID: 19243 RVA: 0x000F012E File Offset: 0x000EE32E
		public virtual Type[] GenericTypeParameters
		{
			get
			{
				if (!this.IsGenericTypeDefinition)
				{
					return Type.EmptyTypes;
				}
				return this.GetGenericArguments();
			}
		}

		/// <summary>Возвращает объект, представляющий указанное открытое событие, объявленное текущим типом.</summary>
		/// <param name="name">Имя события.</param>
		/// <returns>Объект, представляющий указанное событие, если оно найдено; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B2C RID: 19244 RVA: 0x000F0144 File Offset: 0x000EE344
		public virtual EventInfo GetDeclaredEvent(string name)
		{
			return this.GetEvent(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Возвращает объект, представляющий указанное открытое поле, объявленное текущим типом.</summary>
		/// <param name="name">Имя поля.</param>
		/// <returns>Объект, представляющий указанное поле, если оно найдено; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B2D RID: 19245 RVA: 0x000F014F File Offset: 0x000EE34F
		public virtual FieldInfo GetDeclaredField(string name)
		{
			return this.GetField(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Возвращает объект, представляющий указанный открытый метод, объявленный текущим типом.</summary>
		/// <param name="name">Имя метода.</param>
		/// <returns>Объект, представляющий указанный метод, если такой метод есть; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B2E RID: 19246 RVA: 0x000F015A File Offset: 0x000EE35A
		public virtual MethodInfo GetDeclaredMethod(string name)
		{
			return base.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Возвращает объект, представляющий указанный открытый вложенный тип, объявленный текущим типом.</summary>
		/// <param name="name">Имя вложенного типа.</param>
		/// <returns>Объект, представляющий указанный вложенный тип, если он найдено; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B2F RID: 19247 RVA: 0x000F0165 File Offset: 0x000EE365
		public virtual TypeInfo GetDeclaredNestedType(string name)
		{
			Type nestedType = this.GetNestedType(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (nestedType == null)
			{
				return null;
			}
			return nestedType.GetTypeInfo();
		}

		/// <summary>Возвращает объект, представляющий указанное открытое свойство, объявленное текущим типом.</summary>
		/// <param name="name">Имя свойства.</param>
		/// <returns>Объект, представляющий указанное свойство, если оно найдено; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B30 RID: 19248 RVA: 0x000F017B File Offset: 0x000EE37B
		public virtual PropertyInfo GetDeclaredProperty(string name)
		{
			return base.GetProperty(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Возвращает коллекцию, содержащую все открытые методы, объявленные в текущем типе, которые соответствуют заданному имени.</summary>
		/// <param name="name">Имя метода для поиска.</param>
		/// <returns>Коллекция, содержащая методы, соответствующие <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B31 RID: 19249 RVA: 0x000F0186 File Offset: 0x000EE386
		public virtual IEnumerable<MethodInfo> GetDeclaredMethods(string name)
		{
			foreach (MethodInfo methodInfo in this.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if (methodInfo.Name == name)
				{
					yield return methodInfo;
				}
			}
			MethodInfo[] array = null;
			yield break;
		}

		/// <summary>Возвращает коллекцию конструкторов, объявленных текущим типом.</summary>
		/// <returns>Коллекция конструкторов, объявленных текущим типом.</returns>
		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06004B32 RID: 19250 RVA: 0x000F019D File Offset: 0x000EE39D
		public virtual IEnumerable<ConstructorInfo> DeclaredConstructors
		{
			get
			{
				return this.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		/// <summary>Возвращает коллекцию событий, определенных текущим типом.</summary>
		/// <returns>Коллекция событий, определенных текущим типом.</returns>
		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x000F01A7 File Offset: 0x000EE3A7
		public virtual IEnumerable<EventInfo> DeclaredEvents
		{
			get
			{
				return this.GetEvents(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		/// <summary>Возвращает коллекцию полей, определенных текущим типом.</summary>
		/// <returns>Коллекция полей, определенных текущим типом.</returns>
		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x000F01B1 File Offset: 0x000EE3B1
		public virtual IEnumerable<FieldInfo> DeclaredFields
		{
			get
			{
				return this.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		/// <summary>Возвращает коллекцию членов, определенных текущим типом.</summary>
		/// <returns>Коллекция членов, определенных текущим типом.</returns>
		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x000F01BB File Offset: 0x000EE3BB
		public virtual IEnumerable<MemberInfo> DeclaredMembers
		{
			get
			{
				return this.GetMembers(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		/// <summary>Возвращает коллекцию методов, определенных текущим типом.</summary>
		/// <returns>Коллекция методов, определенных текущим типом.</returns>
		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06004B36 RID: 19254 RVA: 0x000F01C5 File Offset: 0x000EE3C5
		public virtual IEnumerable<MethodInfo> DeclaredMethods
		{
			get
			{
				return this.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		/// <summary>Возвращает коллекцию вложенных типов, определенных текущим типом.</summary>
		/// <returns>Коллекция вложенных типов, определенных текущим типом.</returns>
		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06004B37 RID: 19255 RVA: 0x000F01CF File Offset: 0x000EE3CF
		public virtual IEnumerable<TypeInfo> DeclaredNestedTypes
		{
			get
			{
				foreach (Type type in this.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
				{
					yield return type.GetTypeInfo();
				}
				Type[] array = null;
				yield break;
			}
		}

		/// <summary>Возвращает коллекцию свойств, определенных текущим типом.</summary>
		/// <returns>Коллекция свойств, определенных текущим типом.</returns>
		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x000F01DF File Offset: 0x000EE3DF
		public virtual IEnumerable<PropertyInfo> DeclaredProperties
		{
			get
			{
				return this.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		/// <summary>Возвращает коллекцию интерфейсов, реализованных текущим типом.</summary>
		/// <returns>Коллекция интерфейсов, реализованных текущим типом.</returns>
		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06004B39 RID: 19257 RVA: 0x000F01E9 File Offset: 0x000EE3E9
		public virtual IEnumerable<Type> ImplementedInterfaces
		{
			get
			{
				return this.GetInterfaces();
			}
		}

		/// <summary>Возвращает значение, указывающее, можно ли назначить указанный тип текущему типу.</summary>
		/// <param name="typeInfo">Проверяемый тип.</param>
		/// <returns>Значение <see langword="true" />, если указанный тип может быть присвоен этому типу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B3A RID: 19258 RVA: 0x000F01F4 File Offset: 0x000EE3F4
		public virtual bool IsAssignableFrom(TypeInfo typeInfo)
		{
			if (typeInfo == null)
			{
				return false;
			}
			if (this == typeInfo)
			{
				return true;
			}
			if (typeInfo.IsSubclassOf(this))
			{
				return true;
			}
			if (base.IsInterface)
			{
				return typeInfo.ImplementInterface(this);
			}
			if (this.IsGenericParameter)
			{
				Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
				for (int i = 0; i < genericParameterConstraints.Length; i++)
				{
					if (!genericParameterConstraints[i].IsAssignableFrom(typeInfo))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x04002F57 RID: 12119
		private const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
	}
}
