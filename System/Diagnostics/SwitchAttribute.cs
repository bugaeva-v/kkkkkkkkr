using System;
using System.Collections;
using System.Reflection;

namespace System.Diagnostics
{
	/// <summary>Идентифицирует переключатель, используемый в сборке, классе или члене.</summary>
	// Token: 0x02000225 RID: 549
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public sealed class SwitchAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.SwitchAttribute" />, задающего имя и тип переключателя.</summary>
		/// <param name="switchName">Отображаемое имя переключателя.</param>
		/// <param name="switchType">Тип переключателя.</param>
		// Token: 0x06000FFA RID: 4090 RVA: 0x00046A64 File Offset: 0x00044C64
		public SwitchAttribute(string switchName, Type switchType)
		{
			this.SwitchName = switchName;
			this.SwitchType = switchType;
		}

		/// <summary>Возвращает или задает отображаемое имя переключателя.</summary>
		/// <returns>Отображаемое имя переключателя.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Diagnostics.SwitchAttribute.SwitchName" /> задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В качестве значения свойства <see cref="P:System.Diagnostics.SwitchAttribute.SwitchName" /> задана пустая строка ("").</exception>
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00046A7A File Offset: 0x00044C7A
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00046A84 File Offset: 0x00044C84
		public string SwitchName
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.Length == 0)
				{
					throw new ArgumentException(SR.GetString("Argument {0} cannot be null or zero-length.", new object[]
					{
						"value"
					}), "value");
				}
				this.name = value;
			}
		}

		/// <summary>Возвращает или задает тип переключателя.</summary>
		/// <returns>Тип переключателя.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Diagnostics.SwitchAttribute.SwitchType" /> задается значение <see langword="null" />.</exception>
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00046AD1 File Offset: 0x00044CD1
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x00046AD9 File Offset: 0x00044CD9
		public Type SwitchType
		{
			get
			{
				return this.type;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.type = value;
			}
		}

		/// <summary>Возвращает или задает описание переключателя.</summary>
		/// <returns>Описание переключателя.</returns>
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00046AF6 File Offset: 0x00044CF6
		// (set) Token: 0x06001000 RID: 4096 RVA: 0x00046AFE File Offset: 0x00044CFE
		public string SwitchDescription
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		/// <summary>Возвращает все атрибуты переключателя для указанной сборки.</summary>
		/// <param name="assembly">Сборка для проверки атрибутов переключателей.</param>
		/// <returns>Массив, содержащий все атрибуты переключателя для данной сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assembly" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001001 RID: 4097 RVA: 0x00046B08 File Offset: 0x00044D08
		public static SwitchAttribute[] GetAll(Assembly assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			ArrayList arrayList = new ArrayList();
			object[] customAttributes = assembly.GetCustomAttributes(typeof(SwitchAttribute), false);
			arrayList.AddRange(customAttributes);
			Type[] types = assembly.GetTypes();
			for (int i = 0; i < types.Length; i++)
			{
				SwitchAttribute.GetAllRecursive(types[i], arrayList);
			}
			SwitchAttribute[] array = new SwitchAttribute[arrayList.Count];
			arrayList.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00046B80 File Offset: 0x00044D80
		private static void GetAllRecursive(Type type, ArrayList switchAttribs)
		{
			SwitchAttribute.GetAllRecursive(type, switchAttribs);
			MemberInfo[] members = type.GetMembers(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < members.Length; i++)
			{
				if (!(members[i] is Type))
				{
					SwitchAttribute.GetAllRecursive(members[i], switchAttribs);
				}
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00046BC0 File Offset: 0x00044DC0
		private static void GetAllRecursive(MemberInfo member, ArrayList switchAttribs)
		{
			object[] customAttributes = member.GetCustomAttributes(typeof(SwitchAttribute), false);
			switchAttribs.AddRange(customAttributes);
		}

		// Token: 0x040009C1 RID: 2497
		private Type type;

		// Token: 0x040009C2 RID: 2498
		private string name;

		// Token: 0x040009C3 RID: 2499
		private string description;
	}
}
