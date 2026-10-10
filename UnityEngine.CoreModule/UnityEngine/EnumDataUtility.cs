using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	// Token: 0x02000204 RID: 516
	internal static class EnumDataUtility
	{
		// Token: 0x060016B9 RID: 5817 RVA: 0x00024540 File Offset: 0x00022740
		internal static EnumData GetCachedEnumData(Type enumType, bool excludeObsolete = true, Func<string, string> nicifyName = null)
		{
			EnumData enumData;
			bool flag = excludeObsolete && EnumDataUtility.s_NonObsoleteEnumData.TryGetValue(enumType, out enumData);
			EnumData result;
			if (flag)
			{
				result = enumData;
			}
			else
			{
				bool flag2 = !excludeObsolete && EnumDataUtility.s_EnumData.TryGetValue(enumType, out enumData);
				if (flag2)
				{
					result = enumData;
				}
				else
				{
					enumData = new EnumData
					{
						underlyingType = Enum.GetUnderlyingType(enumType)
					};
					enumData.unsigned = (enumData.underlyingType == typeof(byte) || enumData.underlyingType == typeof(ushort) || enumData.underlyingType == typeof(uint) || enumData.underlyingType == typeof(ulong));
					FieldInfo[] fields = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
					List<FieldInfo> list = new List<FieldInfo>();
					int num = fields.Length;
					for (int i = 0; i < num; i++)
					{
						bool flag3 = EnumDataUtility.CheckObsoleteAddition(fields[i], excludeObsolete);
						if (flag3)
						{
							list.Add(fields[i]);
						}
					}
					bool flag4 = !list.Any<FieldInfo>();
					if (flag4)
					{
						string[] array = new string[]
						{
							""
						};
						Enum[] values = new Enum[0];
						int[] flagValues = new int[1];
						enumData.values = values;
						enumData.flagValues = flagValues;
						enumData.displayNames = array;
						enumData.names = array;
						enumData.tooltip = array;
						enumData.flags = true;
						enumData.serializable = true;
						result = enumData;
					}
					else
					{
						try
						{
							string location = list.First<FieldInfo>().Module.Assembly.Location;
							bool flag5 = !string.IsNullOrEmpty(location);
							if (flag5)
							{
								list = (from f in list
								orderby f.MetadataToken
								select f).ToList<FieldInfo>();
							}
						}
						catch
						{
						}
						enumData.displayNames = (from f in list
						select EnumDataUtility.EnumNameFromEnumField(f, nicifyName)).ToArray<string>();
						bool flag6 = enumData.displayNames.Distinct<string>().Count<string>() != enumData.displayNames.Length;
						if (flag6)
						{
							Debug.LogWarning("Enum " + enumType.Name + " has multiple entries with the same display name, this prevents selection in EnumPopup.");
						}
						enumData.tooltip = (from f in list
						select EnumDataUtility.EnumTooltipFromEnumField(f)).ToArray<string>();
						enumData.values = (from f in list
						select (Enum)f.GetValue(null)).ToArray<Enum>();
						int[] flagValues2;
						if (!enumData.unsigned)
						{
							flagValues2 = (from v in enumData.values
							select (int)Convert.ToInt64(v)).ToArray<int>();
						}
						else
						{
							flagValues2 = (from v in enumData.values
							select (int)Convert.ToUInt64(v)).ToArray<int>();
						}
						enumData.flagValues = flagValues2;
						enumData.names = new string[enumData.values.Length];
						for (int j = 0; j < enumData.values.Length; j++)
						{
							enumData.names[j] = enumData.values[j].ToString();
						}
						bool flag7 = enumData.underlyingType == typeof(ushort);
						if (flag7)
						{
							int k = 0;
							int num2 = enumData.flagValues.Length;
							while (k < num2)
							{
								bool flag8 = (long)enumData.flagValues[k] == 65535L;
								if (flag8)
								{
									enumData.flagValues[k] = -1;
								}
								k++;
							}
						}
						else
						{
							bool flag9 = enumData.underlyingType == typeof(byte);
							if (flag9)
							{
								int l = 0;
								int num3 = enumData.flagValues.Length;
								while (l < num3)
								{
									bool flag10 = (long)enumData.flagValues[l] == 255L;
									if (flag10)
									{
										enumData.flagValues[l] = -1;
									}
									l++;
								}
							}
						}
						enumData.flags = enumType.IsDefined(typeof(FlagsAttribute), false);
						enumData.serializable = (enumData.underlyingType != typeof(long) && enumData.underlyingType != typeof(ulong));
						if (excludeObsolete)
						{
							EnumDataUtility.s_NonObsoleteEnumData[enumType] = enumData;
						}
						else
						{
							EnumDataUtility.s_EnumData[enumType] = enumData;
						}
						result = enumData;
					}
				}
			}
			return result;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000249E0 File Offset: 0x00022BE0
		internal static int EnumFlagsToInt(EnumData enumData, Enum enumValue)
		{
			bool unsigned = enumData.unsigned;
			int result;
			if (unsigned)
			{
				bool flag = enumData.underlyingType == typeof(uint);
				if (flag)
				{
					result = (int)Convert.ToUInt32(enumValue);
				}
				else
				{
					bool flag2 = enumData.underlyingType == typeof(ushort);
					if (flag2)
					{
						ushort num = Convert.ToUInt16(enumValue);
						result = ((num == ushort.MaxValue) ? -1 : ((int)num));
					}
					else
					{
						byte b = Convert.ToByte(enumValue);
						result = ((b == byte.MaxValue) ? -1 : ((int)b));
					}
				}
			}
			else
			{
				result = Convert.ToInt32(enumValue);
			}
			return result;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00024A6C File Offset: 0x00022C6C
		internal static Enum IntToEnumFlags(Type enumType, int value)
		{
			EnumData cachedEnumData = EnumDataUtility.GetCachedEnumData(enumType, true, null);
			bool unsigned = cachedEnumData.unsigned;
			Enum result;
			if (unsigned)
			{
				bool flag = cachedEnumData.underlyingType == typeof(uint);
				if (flag)
				{
					uint num = (uint)value;
					result = (Enum.Parse(enumType, num.ToString()) as Enum);
				}
				else
				{
					bool flag2 = cachedEnumData.underlyingType == typeof(ushort);
					if (flag2)
					{
						result = (Enum.Parse(enumType, ((ushort)value).ToString()) as Enum);
					}
					else
					{
						result = (Enum.Parse(enumType, ((byte)value).ToString()) as Enum);
					}
				}
			}
			else
			{
				result = (Enum.Parse(enumType, value.ToString()) as Enum);
			}
			return result;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00024B24 File Offset: 0x00022D24
		private static bool CheckObsoleteAddition(FieldInfo field, bool excludeObsolete)
		{
			object[] customAttributes = field.GetCustomAttributes(typeof(ObsoleteAttribute), false);
			bool flag = customAttributes.Length != 0;
			return !flag || (!excludeObsolete && !((ObsoleteAttribute)customAttributes.First<object>()).IsError);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00024B74 File Offset: 0x00022D74
		private static string EnumTooltipFromEnumField(FieldInfo field)
		{
			object[] customAttributes = field.GetCustomAttributes(typeof(TooltipAttribute), false);
			bool flag = customAttributes.Length != 0;
			string result;
			if (flag)
			{
				result = ((TooltipAttribute)customAttributes.First<object>()).tooltip;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00024BBC File Offset: 0x00022DBC
		private static string EnumNameFromEnumField(FieldInfo field, Func<string, string> nicifyName)
		{
			EnumDataUtility.<>c__DisplayClass7_0 CS$<>8__locals1;
			CS$<>8__locals1.nicifyName = nicifyName;
			CS$<>8__locals1.field = field;
			object[] customAttributes = CS$<>8__locals1.field.GetCustomAttributes(typeof(InspectorNameAttribute), false);
			bool flag = customAttributes.Length != 0;
			string result;
			if (flag)
			{
				result = ((InspectorNameAttribute)customAttributes.First<object>()).displayName;
			}
			else
			{
				bool flag2 = CS$<>8__locals1.field.IsDefined(typeof(ObsoleteAttribute), false);
				if (flag2)
				{
					result = EnumDataUtility.<EnumNameFromEnumField>g__NicifyName|7_0(ref CS$<>8__locals1) + " (Obsolete)";
				}
				else
				{
					result = EnumDataUtility.<EnumNameFromEnumField>g__NicifyName|7_0(ref CS$<>8__locals1);
				}
			}
			return result;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00024C64 File Offset: 0x00022E64
		[CompilerGenerated]
		internal static string <EnumNameFromEnumField>g__NicifyName|7_0(ref EnumDataUtility.<>c__DisplayClass7_0 A_0)
		{
			return (A_0.nicifyName == null) ? A_0.field.Name : A_0.nicifyName(A_0.field.Name);
		}

		// Token: 0x040007EB RID: 2027
		private static readonly Dictionary<Type, EnumData> s_NonObsoleteEnumData = new Dictionary<Type, EnumData>();

		// Token: 0x040007EC RID: 2028
		private static readonly Dictionary<Type, EnumData> s_EnumData = new Dictionary<Type, EnumData>();
	}
}
