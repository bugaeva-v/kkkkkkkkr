using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using App42Json;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp.util
{
	// Token: 0x020000CA RID: 202
	public class Util : MonoBehaviour
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x00034B38 File Offset: 0x00032D38
		private static string SortAndConvertTableToString(Dictionary<string, string> dics)
		{
			ICollection<string> keys = dics.Keys;
			List<string> list = new List<string>(keys);
			list.Sort();
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string text in list)
			{
				stringBuilder.Append(text);
				stringBuilder.Append(dics[text]);
			}
			App42Log.Console(stringBuilder.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00034BC4 File Offset: 0x00032DC4
		public static string ComputeHmac(string input, byte[] key)
		{
			HMACSHA1 hmacsha = new HMACSHA1(key);
			byte[] bytes = Encoding.UTF8.GetBytes(input);
			MemoryStream inputStream = new MemoryStream(bytes);
			return Convert.ToBase64String(hmacsha.ComputeHash(inputStream));
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00034C04 File Offset: 0x00032E04
		public static string Sign(string secretKey, Dictionary<string, string> paramsList)
		{
			string input = Util.SortAndConvertTableToString(paramsList);
			string text = Util.ComputeHmac(input, Encoding.UTF8.GetBytes(secretKey));
			string input2 = text;
			return Regex.Replace(input2, "(%[0-9a-f][0-9a-f])", (Match c) => c.Value.ToUpper());
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00034C54 File Offset: 0x00032E54
		public static string GetUTCFormattedTimestamp()
		{
			DateTime dateTime = DateTime.Now.ToUniversalTime();
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond);
			return string.Format("{0:yyyy-MM-dd'T'HH:mm:ss.fff'Z'}", dateTime2);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00034CB8 File Offset: 0x00032EB8
		public static string GetUTCFormattedTimestamp(DateTime dt)
		{
			DateTime dateTime = dt;
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond);
			return string.Format("{0:yyyy-MM-dd'T'HH:mm:ss.fff'Z'}", dateTime2);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00034D10 File Offset: 0x00032F10
		internal static void ThrowExceptionIfNullOrBlank(object param, string paramName)
		{
			if (param == null)
			{
				throw new App42Exception(paramName + " can not be null");
			}
			if (param is string && ((string)param).Trim().Equals(""))
			{
				throw new App42Exception(paramName + " can not be blank");
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00034D64 File Offset: 0x00032F64
		public static string UpperCaseUrlEncode(string s)
		{
			char[] array = s.ToCharArray();
			for (int i = 0; i < array.Length - 2; i++)
			{
				if (array[i] == '%')
				{
					array[i + 1] = char.ToUpper(array[i + 1]);
					array[i + 2] = char.ToUpper(array[i + 2]);
				}
			}
			return new string(array);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00034DB4 File Offset: 0x00032FB4
		public static string extractFileExtension(string fileName)
		{
			return fileName.Substring(fileName.LastIndexOf(".") + 1);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00034DD6 File Offset: 0x00032FD6
		public static void ValidateMax(int max)
		{
			if (max < 1)
			{
				throw new App42Exception("Max must be greater than Zero.");
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00034DE7 File Offset: 0x00032FE7
		public static void ValidateHowMany(int howMany)
		{
			if (howMany > 1000)
			{
				throw new App42Exception("How Many Should be less than 1000");
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00034DFC File Offset: 0x00032FFC
		public static void ThrowExceptionIfEmailNotValid(object obj, string name)
		{
			if (obj == null)
			{
				throw new App42Exception(name + " can not be null");
			}
			string input = obj.ToString();
			string pattern = "^(?!\\.)(\"([^\"\\r\\\\]|\\\\[\"\\r\\\\])*\"|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\\.)\\.)*)(?<!\\.)@[a-z0-9][\\w\\.-]*[a-z0-9]\\.[a-z][a-z\\.]*[a-z]$";
			Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
			if (match.Success)
			{
				return;
			}
			throw new App42Exception(name + " is Not Valid");
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00034E4C File Offset: 0x0003304C
		public static void ThrowExceptionIfNotValidExtension(string fileName, string name)
		{
			if (fileName == null)
			{
				throw new App42Exception(name + " parameter can not be null");
			}
			if (fileName.IndexOf('.') == -1)
			{
				throw new App42Exception(name + " does not contain valid extension.");
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00034E80 File Offset: 0x00033080
		public static void ThrowExceptionIfNotValidImageExtension(string fileName, string name)
		{
			if (fileName == null)
			{
				throw new App42Exception(name + " parameter can not be null ");
			}
			if (fileName.IndexOf('.') == -1)
			{
				throw new App42Exception(name + " does not contain valid extension. ");
			}
			string text = Util.extractFileExtension(fileName);
			if (!text.Equals("jpg") && !text.Equals("jpeg") && !text.Equals("gif") && !text.Equals("png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00034F03 File Offset: 0x00033103
		public static void ThrowExceptionIfNull(object obj, string name)
		{
			if (obj == null)
			{
				throw new App42Exception(name + " parameter can not be null");
			}
			if (obj is IList && ((IList)obj).Count == 0)
			{
				throw new App42Exception(name + " can not be empty");
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00034F40 File Offset: 0x00033140
		public static string GetID()
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			for (int i = 0; i < 16; i++)
			{
				char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString().ToLower();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00034FA3 File Offset: 0x000331A3
		public static void ThrowExceptionIfLongValueIsNegativeOrEqualToZero(long obj, string name)
		{
			if (Convert.ToDouble(obj) < 1.0)
			{
				throw new App42Exception(name + " parameter can not be less than or Equal to Zero");
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00034FC8 File Offset: 0x000331C8
		internal static string ConvertDictionaryToJson(Dictionary<string, object> dict)
		{
			if (dict == null || dict.Count <= 0)
			{
				return "\"\"";
			}
			string result;
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				JsonWriter jsonWriter = new JsonWriter(stringBuilder);
				jsonWriter.WriteObjectStart();
				foreach (KeyValuePair<string, object> keyValuePair in dict)
				{
					jsonWriter.WritePropertyName(keyValuePair.Key);
					if (keyValuePair.Value.GetType().FullName.Equals("System.String"))
					{
						jsonWriter.Write(Convert.ToString(keyValuePair.Value));
					}
					else if (keyValuePair.Value.GetType().FullName.Equals("System.Boolean"))
					{
						jsonWriter.Write(Convert.ToBoolean(keyValuePair.Value));
					}
					else if (keyValuePair.Value.GetType().FullName.Equals("System.Double"))
					{
						jsonWriter.Write(Convert.ToDouble(keyValuePair.Value));
					}
					else if (keyValuePair.Value.GetType().FullName.Equals("System.Int32"))
					{
						jsonWriter.Write(Convert.ToInt32(keyValuePair.Value));
					}
					else if (keyValuePair.Value.GetType().FullName.Equals("System.Int64"))
					{
						jsonWriter.Write(Convert.ToInt64(keyValuePair.Value));
					}
					else if (keyValuePair.Value.GetType().FullName.Equals("System.int"))
					{
						jsonWriter.Write(Convert.ToInt32(keyValuePair.Value));
					}
					else if (keyValuePair.Value.GetType().FullName.Equals("System.Single"))
					{
						jsonWriter.Write((double)Convert.ToSingle(keyValuePair.Value));
					}
					else
					{
						jsonWriter.Write(Convert.ToString(keyValuePair.Value));
					}
				}
				jsonWriter.WriteObjectEnd();
				result = stringBuilder.ToString();
			}
			catch (ArgumentException ex)
			{
				throw new App42Exception(ex.ToString());
			}
			return result;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00035204 File Offset: 0x00033404
		internal static Dictionary<string, object> ConvertJsonToDictionary(string requestParams)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			App42JObject app42JObject = new App42JObject(requestParams);
			ArrayList keys = app42JObject.keys;
			foreach (object obj in keys)
			{
				string text = (string)obj;
				if (app42JObject.GetField(text).ToString().StartsWith("{"))
				{
					dictionary.Add(text, app42JObject.GetField(text).ToString());
				}
				else
				{
					dictionary.Add(text, app42JObject.GetField(text).str);
				}
			}
			return dictionary;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000352B0 File Offset: 0x000334B0
		internal static bool CheckIfJSONString(string message)
		{
			return (message.StartsWith("{") && message.EndsWith("}")) || (message.StartsWith("[") && message.EndsWith("]"));
		}
	}
}
