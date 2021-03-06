// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace ExpressionLab.DB
{

    // ApplicationErrorLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class ApplicationErrorLog
    {

        ///<summary>
        /// 錯誤流水識別碼
        ///</summary>
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// 應用程式名稱
        ///</summary>
        public string ApplicationName { get; set; } // ApplicationName (length: 50)

        ///<summary>
        /// 系統網址
        ///</summary>
        public string RequestUrl { get; set; } // RequestUrl (length: 20)

        ///<summary>
        /// 錯誤來源網址
        ///</summary>
        public string RequestPath { get; set; } // RequestPath (length: 200)

        ///<summary>
        /// 錯誤訊息
        ///</summary>
        public string Message { get; set; } // Message (length: 500)

        ///<summary>
        /// 堆疊錯誤訊息
        ///</summary>
        public string StachMessage { get; set; } // StachMessage (length: 1073741823)

        ///<summary>
        /// 記錄時間點
        ///</summary>
        public System.DateTime LogAt { get; set; } // LogAt
    }

}
// </auto-generated>
