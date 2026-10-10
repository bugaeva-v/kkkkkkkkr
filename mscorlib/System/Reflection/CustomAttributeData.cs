using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection
{
	/// <summary>Предоставляет доступ к данным настраиваемых атрибутов для сборок, модулей, типов, членов и параметров, загруженных в контекст, предназначенный только для отражения.</summary>
	// Token: 0x020008EC RID: 2284
	[ComVisible(true)]
	[Serializable]
	public class CustomAttributeData
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.CustomAttributeData" />.</summary>
		// Token: 0x06004C8E RID: 19598 RVA: 0x0000259F File Offset: 0x0000079F
		protected CustomAttributeData()
		{
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x000F2BE9 File Offset: 0x000F0DE9
		internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
		{
			this.ctorInfo = ctorInfo;
			this.lazyData = new CustomAttributeData.LazyCAttrData();
			this.lazyData.assembly = assembly;
			this.lazyData.data = data;
			this.lazyData.data_length = data_length;
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x000F2C28 File Offset: 0x000F0E28
		internal CustomAttributeData(ConstructorInfo ctorInfo) : this(ctorInfo, Array.Empty<CustomAttributeTypedArgument>(), Array.Empty<CustomAttributeNamedArgument>())
		{
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x000F2C3B File Offset: 0x000F0E3B
		internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs)
		{
			this.ctorInfo = ctorInfo;
			this.ctorArgs = ctorArgs;
			this.namedArgs = namedArgs;
		}

		// Token: 0x06004C92 RID: 19602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs);

		// Token: 0x06004C93 RID: 19603 RVA: 0x000F2C58 File Offset: 0x000F0E58
		private void ResolveArguments()
		{
			if (this.lazyData == null)
			{
				return;
			}
			object[] array;
			object[] array2;
			CustomAttributeData.ResolveArgumentsInternal(this.ctorInfo, this.lazyData.assembly, this.lazyData.data, this.lazyData.data_length, out array, out array2);
			this.ctorArgs = Array.AsReadOnly<CustomAttributeTypedArgument>((array != null) ? CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>(array) : Array.Empty<CustomAttributeTypedArgument>());
			this.namedArgs = Array.AsReadOnly<CustomAttributeNamedArgument>((array2 != null) ? CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>(array2) : Array.Empty<CustomAttributeNamedArgument>());
			this.lazyData = null;
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.ConstructorInfo" />, представляющий конструктор, предназначенный для инициализации настраиваемого атрибута.</summary>
		/// <returns>Объект, представляющий конструктор, предназначенный для инициализации настраиваемого атрибута, представленного текущим экземпляром класса <see cref="T:System.Reflection.CustomAttributeData" />.</returns>
		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06004C94 RID: 19604 RVA: 0x000F2CDB File Offset: 0x000F0EDB
		[ComVisible(true)]
		public virtual ConstructorInfo Constructor
		{
			get
			{
				return this.ctorInfo;
			}
		}

		/// <summary>Возвращает список позиционных аргументов, заданных для экземпляра атрибута, который представлен объектом <see cref="T:System.Reflection.CustomAttributeData" />.</summary>
		/// <returns>Коллекция структур, представляющих позиционные аргументы, заданные для экземпляра настраиваемого атрибута.</returns>
		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06004C95 RID: 19605 RVA: 0x000F2CE3 File Offset: 0x000F0EE3
		[ComVisible(true)]
		public virtual IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			get
			{
				this.ResolveArguments();
				return this.ctorArgs;
			}
		}

		/// <summary>Возвращает список именованных аргументов, заданных для экземпляра атрибута, представленного объектом <see cref="T:System.Reflection.CustomAttributeData" />.</summary>
		/// <returns>Коллекция структур, представляющих именованные аргументы, заданные для экземпляра настраиваемого атрибута.</returns>
		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x000F2CF1 File Offset: 0x000F0EF1
		public virtual IList<CustomAttributeNamedArgument> NamedArguments
		{
			get
			{
				this.ResolveArguments();
				return this.namedArgs;
			}
		}

		/// <summary>Возвращает список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, примененных к целевой сборке.</summary>
		/// <param name="target">Сборка, данные настраиваемого атрибута которой требуется извлечь.</param>
		/// <returns>Список объектов, представляющих данные об атрибутах, примененных к целевой сборке.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="target" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004C97 RID: 19607 RVA: 0x000F2CFF File Offset: 0x000F0EFF
		public static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
		{
			return MonoCustomAttrs.GetCustomAttributesData(target, false);
		}

		/// <summary>Возвращает список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, примененных к целевому элементу.</summary>
		/// <param name="target">Элемент, данные об атрибутах которого требуется извлечь.</param>
		/// <returns>Список объектов, представляющих данные об атрибутах, примененных к целевому элементу.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="target" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004C98 RID: 19608 RVA: 0x000F2CFF File Offset: 0x000F0EFF
		public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			return MonoCustomAttrs.GetCustomAttributesData(target, false);
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x000F2CFF File Offset: 0x000F0EFF
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
		{
			return MonoCustomAttrs.GetCustomAttributesData(target, false);
		}

		/// <summary>Возвращает список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, примененных к целевому модулю.</summary>
		/// <param name="target">Модуль, данные настраиваемого атрибута которого требуется извлечь.</param>
		/// <returns>Список объектов, представляющих данные об атрибутах, примененных к целевому модулю.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="target" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004C9A RID: 19610 RVA: 0x000F2CFF File Offset: 0x000F0EFF
		public static IList<CustomAttributeData> GetCustomAttributes(Module target)
		{
			return MonoCustomAttrs.GetCustomAttributesData(target, false);
		}

		/// <summary>Возвращает список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, примененных к целевому параметру.</summary>
		/// <param name="target">Параметр, данные об атрибутах которого требуется извлечь.</param>
		/// <returns>Список объектов, представляющих данные об атрибутах, примененных к целевому параметру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="target" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004C9B RID: 19611 RVA: 0x000F2CFF File Offset: 0x000F0EFF
		public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
		{
			return MonoCustomAttrs.GetCustomAttributesData(target, false);
		}

		/// <summary>Получает тип атрибута.</summary>
		/// <returns>Тип атрибута.</returns>
		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06004C9C RID: 19612 RVA: 0x000F2D08 File Offset: 0x000F0F08
		public Type AttributeType
		{
			get
			{
				return this.ctorInfo.DeclaringType;
			}
		}

		/// <summary>Возвращает строковое представление настраиваемого атрибута.</summary>
		/// <returns>Строковое значение, которое представляет настраиваемый атрибут.</returns>
		// Token: 0x06004C9D RID: 19613 RVA: 0x000F2D18 File Offset: 0x000F0F18
		public override string ToString()
		{
			this.ResolveArguments();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("[" + this.ctorInfo.DeclaringType.FullName + "(");
			for (int i = 0; i < this.ctorArgs.Count; i++)
			{
				stringBuilder.Append(this.ctorArgs[i].ToString());
				if (i + 1 < this.ctorArgs.Count)
				{
					stringBuilder.Append(", ");
				}
			}
			if (this.namedArgs.Count > 0)
			{
				stringBuilder.Append(", ");
			}
			for (int j = 0; j < this.namedArgs.Count; j++)
			{
				stringBuilder.Append(this.namedArgs[j].ToString());
				if (j + 1 < this.namedArgs.Count)
				{
					stringBuilder.Append(", ");
				}
			}
			stringBuilder.AppendFormat(")]", Array.Empty<object>());
			return stringBuilder.ToString();
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x000F2E30 File Offset: 0x000F1030
		private static T[] UnboxValues<T>(object[] values)
		{
			T[] array = new T[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				array[i] = (T)((object)values[i]);
			}
			return array;
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004C9F RID: 19615 RVA: 0x000F2E64 File Offset: 0x000F1064
		public override bool Equals(object obj)
		{
			CustomAttributeData customAttributeData = obj as CustomAttributeData;
			if (customAttributeData == null || customAttributeData.ctorInfo != this.ctorInfo || customAttributeData.ctorArgs.Count != this.ctorArgs.Count || customAttributeData.namedArgs.Count != this.namedArgs.Count)
			{
				return false;
			}
			for (int i = 0; i < this.ctorArgs.Count; i++)
			{
				if (this.ctorArgs[i].Equals(customAttributeData.ctorArgs[i]))
				{
					return false;
				}
			}
			for (int j = 0; j < this.namedArgs.Count; j++)
			{
				bool flag = false;
				for (int k = 0; k < customAttributeData.namedArgs.Count; k++)
				{
					if (this.namedArgs[j].Equals(customAttributeData.namedArgs[k]))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Служит хэш-функцией для определенного типа.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Object" />.</returns>
		// Token: 0x06004CA0 RID: 19616 RVA: 0x000F2F74 File Offset: 0x000F1174
		public override int GetHashCode()
		{
			int num = (this.ctorInfo == null) ? 13 : (this.ctorInfo.GetHashCode() << 16);
			if (this.ctorArgs != null)
			{
				for (int i = 0; i < this.ctorArgs.Count; i++)
				{
					num += (num ^ 7 + this.ctorArgs[i].GetHashCode() << i * 4);
				}
			}
			if (this.namedArgs != null)
			{
				for (int j = 0; j < this.namedArgs.Count; j++)
				{
					num += this.namedArgs[j].GetHashCode() << 5;
				}
			}
			return num;
		}

		// Token: 0x04003024 RID: 12324
		private ConstructorInfo ctorInfo;

		// Token: 0x04003025 RID: 12325
		private IList<CustomAttributeTypedArgument> ctorArgs;

		// Token: 0x04003026 RID: 12326
		private IList<CustomAttributeNamedArgument> namedArgs;

		// Token: 0x04003027 RID: 12327
		private CustomAttributeData.LazyCAttrData lazyData;

		// Token: 0x020008ED RID: 2285
		private class LazyCAttrData
		{
			// Token: 0x04003028 RID: 12328
			internal Assembly assembly;

			// Token: 0x04003029 RID: 12329
			internal IntPtr data;

			// Token: 0x0400302A RID: 12330
			internal uint data_length;
		}
	}
}
