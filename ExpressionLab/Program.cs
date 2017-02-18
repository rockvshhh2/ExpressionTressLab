using ExpressionLab.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext db = new MyDbContext();

            var test = db.Accounts
                .Like(d => d.Account_, "gg")
                .OrderByMultiple(new List<OrderByObj> {
                    new OrderByObj { sortCol = nameof(Account.Account_) , sortType = OrderbyType.Asc },
                    new OrderByObj { sortCol = nameof(Account.CreateBy) , sortType = OrderbyType.Desc },
                    new OrderByObj { sortCol = nameof(Account.Dept) , sortType = OrderbyType.Asc }
                }).ToList();
        }
    }

    public static class David
    {
        // 根據查詢內容是否有% 符號來決定Like的方式 , ex : 如果使用者輸入 gg% => DB的where要是 like N'gg%'
        // EndsWith , Contains , StartsWith
        public static IQueryable<T> Like<T>(this IQueryable<T> query, Expression<Func<T, string>> lambda, string param)
        {
            // 解析Lambda的內容
            var body = lambda.Body as MemberExpression;

            if (body == null)
            {
                return query;
            }

            // 產生參數
            ParameterExpression parSource = Expression.Parameter(query.ElementType, "m");
            Expression columnExp = Expression.Property(parSource, body.Member.Name);

            int likeIndex = param.IndexOf('%');

            MethodCallExpression method;

            if (string.IsNullOrEmpty(param))
            {
                return query;
            }

            string final = param.Replace("%", "");

            Expression paramString = Expression.Constant(final, typeof(string));

            if (likeIndex == 0)
            {
                //所產生的Lambda :  d => d.欄位.EndsWith(paramString)
                method = Expression.Call(columnExp, typeof(string).GetMethod("EndsWith", new[] { typeof(string) }), paramString);
            }
            else if (likeIndex == param.Length - 1)
            {
                //所產生的Lambda :  d => d.欄位.StartsWith(paramString)
                method = Expression.Call(columnExp, typeof(string).GetMethod("StartsWith", new[] { typeof(string) }), paramString);
            }
            else
            {
                //所產生的Lambda :  d => d.欄位.Contains(paramString)
                method = Expression.Call(columnExp, typeof(string).GetMethod("Contains", new[] { typeof(string) }), paramString);
            }

            return query.Where(Expression.Lambda<Func<T, bool>>(method, parSource));
        }

        // 根據陣列作相對應的排序
        public static IQueryable<T> OrderByMultiple<T>(this IQueryable<T> query, List<OrderByObj> cols)
        {
            bool isFirst = true;
            foreach (var col in cols)
            {
                ParameterExpression parSource = Expression.Parameter(query.ElementType, "m");
                Expression columnExp = Expression.Property(parSource, col.sortCol);

                // 要使用的 Method
                string orderMethod = "OrderBy";

                // 判斷要 Call 的 Method
                if (isFirst)
                {
                    orderMethod = "OrderBy";
                    if (col.sortType == OrderbyType.Desc)
                    {
                        orderMethod = "OrderByDescending";
                    }
                    isFirst = false;
                }
                else
                {
                    orderMethod = "ThenBy";
                    if (col.sortType == OrderbyType.Desc)
                    {
                        orderMethod = "ThenByDescending";
                    }
                }

                // 產生 Call Method 的節點
                var method = Expression.Call(
                    typeof(Queryable),
                    orderMethod,
                    new Type[] { query.ElementType, columnExp.Type },
                    query.Expression,
                    Expression.Quote(Expression.Lambda(columnExp, parSource))
                    );

                query = query.Provider.CreateQuery<T>(method);
            }

            return query;
        }
    }

    public enum OrderbyType
    {
        Asc,
        Desc
    }

    public class OrderByObj
    {
        public OrderbyType sortType { get; set; }

        public string sortCol { get; set; }
    }
}