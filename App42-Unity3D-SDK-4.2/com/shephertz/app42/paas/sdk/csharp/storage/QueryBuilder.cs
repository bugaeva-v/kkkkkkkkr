using System;
using System.Collections;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x02000087 RID: 135
	public class QueryBuilder : App42Response
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0001F2E4 File Offset: 0x0001D4E4
		public static Query Build(string key, object value, string op)
		{
			Query result = null;
			Util.ThrowExceptionIfNullOrBlank(key, "key");
			Util.ThrowExceptionIfNull(value, "value");
			if (!Operator.EQUALS.ToString().Equals(op) && !Operator.NOT_EQUALS.ToString().Equals(op) && !Operator.GREATER_THAN.ToString().Equals(op) && !Operator.LESS_THAN.ToString().Equals(op) && !Operator.GREATER_THAN_EQUALTO.ToString().Equals(op) && !Operator.LESS_THAN_EQUALTO.ToString().Equals(op) && !Operator.LIKE.ToString().Equals(op) && !Operator.AND.ToString().Equals(op) && !Operator.OR.ToString().Equals(op) && !Operator.INLIST.ToString().Equals(op))
			{
				return null;
			}
			try
			{
				string jsonQuery;
				if (value.GetType().FullName.Equals("System.String"))
				{
					jsonQuery = string.Concat(new object[]
					{
						"{\"key\":\"",
						key,
						"\",\"operator\":\"",
						op,
						"\",\"value\":\"",
						value,
						"\"}"
					});
				}
				else if (value.GetType().IsGenericType && value is IList && op.ToString().Equals("$in"))
				{
					IList list = value as IList;
					JSONArray jsonarray = new JSONArray();
					foreach (object obj in list)
					{
						jsonarray.Add(obj.ToString());
					}
					jsonQuery = string.Concat(new string[]
					{
						"{\"key\":\"",
						key,
						"\",\"operator\":\"",
						op,
						"\",\"value\":",
						jsonarray.ToString(),
						"}"
					});
				}
				else if (value.GetType().FullName.Equals("System.Boolean"))
				{
					if (value.ToString().Equals("True", StringComparison.InvariantCultureIgnoreCase))
					{
						jsonQuery = string.Concat(new string[]
						{
							"{\"key\":\"",
							key,
							"\",\"operator\":\"",
							op,
							"\",\"value\":true}"
						});
					}
					else
					{
						jsonQuery = string.Concat(new string[]
						{
							"{\"key\":\"",
							key,
							"\",\"operator\":\"",
							op,
							"\",\"value\":false}"
						});
					}
				}
				else
				{
					jsonQuery = string.Concat(new object[]
					{
						"{\"key\":\"",
						key,
						"\",\"operator\":\"",
						op,
						"\",\"value\":",
						value,
						"}"
					});
				}
				result = new Query(jsonQuery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001F61C File Offset: 0x0001D81C
		public static Query SetLoggedInUser(string logged)
		{
			Util.ThrowExceptionIfNullOrBlank(logged, "logged");
			Query result = null;
			try
			{
				string jsonQuery = string.Concat(new string[]
				{
					"{\"key\":\"_$owner.owner\",\"operator\":\"",
					Operator.EQUALS,
					"\",\"value\":\"",
					logged,
					"\"}"
				});
				result = new Query(jsonQuery);
			}
			catch (Exception ex)
			{
				throw new App42Exception(ex.ToString());
			}
			return result;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0001F690 File Offset: 0x0001D890
		public static Query SetCreatedOn(string date, string op)
		{
			Util.ThrowExceptionIfNullOrBlank(date, "date");
			Query result = null;
			try
			{
				string jsonQuery = string.Concat(new string[]
				{
					"{\"key\":\"_$createdAt\",\"operator\":\"",
					op,
					"\",\"value\":\"",
					date,
					"\"}"
				});
				result = new Query(jsonQuery);
			}
			catch (Exception ex)
			{
				throw new App42Exception(ex.ToString());
			}
			return result;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0001F700 File Offset: 0x0001D900
		public static Query SetUpdatedOn(string date, string op)
		{
			Util.ThrowExceptionIfNullOrBlank(date, "date");
			Query result = null;
			try
			{
				string jsonQuery = string.Concat(new string[]
				{
					"{\"key\":\"_$updatedAt\",\"operator\":\"",
					op,
					"\",\"value\":\"",
					date,
					"\"}"
				});
				result = new Query(jsonQuery);
			}
			catch (Exception ex)
			{
				throw new App42Exception(ex.ToString());
			}
			return result;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001F770 File Offset: 0x0001D970
		public static Query SetDocumentId(string docid)
		{
			Util.ThrowExceptionIfNullOrBlank(docid, "docid");
			Query result = null;
			try
			{
				string jsonQuery = string.Concat(new string[]
				{
					"{\"key\":\"_id\",\"operator\":\"",
					Operator.EQUALS,
					"\",\"value\":\"",
					docid,
					"\"}"
				});
				result = new Query(jsonQuery);
			}
			catch (Exception ex)
			{
				throw new App42Exception(ex.ToString());
			}
			return result;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		public static Query CompoundOperator(Query q1, string op, Query q2)
		{
			StringBuilder stringBuilder = new StringBuilder("[");
			Query result = null;
			try
			{
				if (!Operator.EQUALS.ToString().Equals(op) && !Operator.NOT_EQUALS.ToString().Equals(op) && !Operator.GREATER_THAN.ToString().Equals(op) && !Operator.LESS_THAN.ToString().Equals(op) && !Operator.GREATER_THAN_EQUALTO.ToString().Equals(op) && !Operator.LESS_THAN_EQUALTO.ToString().Equals(op) && !Operator.LIKE.ToString().Equals(op) && !Operator.AND.ToString().Equals(op) && !Operator.OR.ToString().Equals(op))
				{
					return null;
				}
				if (q1.GetType().GetType().FullName.Equals("System.String"))
				{
					stringBuilder.Append(q1.GetType());
					stringBuilder.Append(",");
				}
				else
				{
					stringBuilder.Append(q1.GetType());
					stringBuilder.Append(",");
				}
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add("compoundOpt", op);
				stringBuilder.Append(jsonobject.ToString());
				stringBuilder.Append(",");
				if (q2.GetType().GetType().FullName.Equals("System.String"))
				{
					stringBuilder.Append(q2.GetType());
				}
				else
				{
					stringBuilder.Append(q2.GetType());
				}
				stringBuilder.Append("]");
				result = new Query(stringBuilder);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0001F9A0 File Offset: 0x0001DBA0
		public static GeoQuery BuildGeoQuery(GeoTag geoTag, string op, double maxDistance)
		{
			GeoQuery result = null;
			try
			{
				JSONNode jsonnode = (JSONObject)JSON.Parse(geoTag.GetJSONObject().ToString());
				StringBuilder stringBuilder = new StringBuilder();
				string value = string.Concat(new object[]
				{
					"{\"lat\":",
					jsonnode["lat"],
					",\"lng\":",
					jsonnode["lng"],
					",\"operator\":\"",
					op,
					"\",\"maxDistance\":",
					maxDistance,
					"}"
				});
				stringBuilder.Append(value);
				result = new GeoQuery(stringBuilder);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}
	}
}
