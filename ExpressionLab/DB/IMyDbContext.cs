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

    public interface IMyDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Account> Accounts { get; set; } // Account
        System.Data.Entity.DbSet<Announcement> Announcements { get; set; } // Announcement
        System.Data.Entity.DbSet<AnnouncementAndDeptMapping> AnnouncementAndDeptMappings { get; set; } // AnnouncementAndDeptMapping
        System.Data.Entity.DbSet<AnnouncementAttach> AnnouncementAttaches { get; set; } // AnnouncementAttach
        System.Data.Entity.DbSet<AnnouncementCategory> AnnouncementCategories { get; set; } // AnnouncementCategory
        System.Data.Entity.DbSet<AnnouncementLog> AnnouncementLogs { get; set; } // AnnouncementLog
        System.Data.Entity.DbSet<ApplicationErrorLog> ApplicationErrorLogs { get; set; } // ApplicationErrorLog
        System.Data.Entity.DbSet<Brand> Brands { get; set; } // Brand
        System.Data.Entity.DbSet<BrandAndDeptMapping> BrandAndDeptMappings { get; set; } // BrandAndDeptMapping
        System.Data.Entity.DbSet<Department> Departments { get; set; } // Department
        System.Data.Entity.DbSet<Language> Languages { get; set; } // Language
        System.Data.Entity.DbSet<LanguageInfo> LanguageInfoes { get; set; } // LanguageInfo
        System.Data.Entity.DbSet<RaiseErrorMessage> RaiseErrorMessages { get; set; } // RaiseErrorMessage
        System.Data.Entity.DbSet<Role> Roles { get; set; } // Role
        System.Data.Entity.DbSet<RoleAndAccountMapping> RoleAndAccountMappings { get; set; } // RoleAndAccountMapping
        System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);

        // Stored Procedures
        int UspCleanDatabase();
        // UspCleanDatabaseAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspDeleteBrand(int? brandId, string modifierId);
        // UspDeleteBrandAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspDeleteBrandAndDeptMapping(int? id, string modifierId);
        // UspDeleteBrandAndDeptMappingAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspDeleteRoleAccountMapping(int? id, string modifyId);
        // UspDeleteRoleAccountMappingAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        System.Collections.Generic.List<UspGetAccountInfoByAccountReturnModel> UspGetAccountInfoByAccount(string account);
        System.Collections.Generic.List<UspGetAccountInfoByAccountReturnModel> UspGetAccountInfoByAccount(string account, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAccountInfoByAccountReturnModel>> UspGetAccountInfoByAccountAsync(string account);

        System.Collections.Generic.List<UspGetAllAccountReturnModel> UspGetAllAccount();
        System.Collections.Generic.List<UspGetAllAccountReturnModel> UspGetAllAccount(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAllAccountReturnModel>> UspGetAllAccountAsync();

        System.Collections.Generic.List<UspGetAllDepartmentReturnModel> UspGetAllDepartment();
        System.Collections.Generic.List<UspGetAllDepartmentReturnModel> UspGetAllDepartment(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAllDepartmentReturnModel>> UspGetAllDepartmentAsync();

        System.Collections.Generic.List<UspGetAnnouncementAttachByIdReturnModel> UspGetAnnouncementAttachById(int? id);
        System.Collections.Generic.List<UspGetAnnouncementAttachByIdReturnModel> UspGetAnnouncementAttachById(int? id, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAnnouncementAttachByIdReturnModel>> UspGetAnnouncementAttachByIdAsync(int? id);

        System.Collections.Generic.List<UspGetAnnouncementAttachsByAnnouncementIdReturnModel> UspGetAnnouncementAttachsByAnnouncementId(int? announcementId, byte? attachType);
        System.Collections.Generic.List<UspGetAnnouncementAttachsByAnnouncementIdReturnModel> UspGetAnnouncementAttachsByAnnouncementId(int? announcementId, byte? attachType, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAnnouncementAttachsByAnnouncementIdReturnModel>> UspGetAnnouncementAttachsByAnnouncementIdAsync(int? announcementId, byte? attachType);

        System.Collections.Generic.List<UspGetAnnouncementByIdReturnModel> UspGetAnnouncementById(int? announcementId);
        System.Collections.Generic.List<UspGetAnnouncementByIdReturnModel> UspGetAnnouncementById(int? announcementId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAnnouncementByIdReturnModel>> UspGetAnnouncementByIdAsync(int? announcementId);

        System.Collections.Generic.List<UspGetAnnouncementCategoryByIdReturnModel> UspGetAnnouncementCategoryById(int? id);
        System.Collections.Generic.List<UspGetAnnouncementCategoryByIdReturnModel> UspGetAnnouncementCategoryById(int? id, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAnnouncementCategoryByIdReturnModel>> UspGetAnnouncementCategoryByIdAsync(int? id);

        System.Collections.Generic.List<UspGetAnnouncementCategorysReturnModel> UspGetAnnouncementCategorys(bool? vaild, string account, System.DateTime? sysLocalDate);
        System.Collections.Generic.List<UspGetAnnouncementCategorysReturnModel> UspGetAnnouncementCategorys(bool? vaild, string account, System.DateTime? sysLocalDate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAnnouncementCategorysReturnModel>> UspGetAnnouncementCategorysAsync(bool? vaild, string account, System.DateTime? sysLocalDate);

        System.Collections.Generic.List<UspGetAnnouncementDeptMappingReturnModel> UspGetAnnouncementDeptMapping(int? announcementId);
        System.Collections.Generic.List<UspGetAnnouncementDeptMappingReturnModel> UspGetAnnouncementDeptMapping(int? announcementId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAnnouncementDeptMappingReturnModel>> UspGetAnnouncementDeptMappingAsync(int? announcementId);

        System.Collections.Generic.List<UspGetAnnouncementFrontPagingByCondReturnModel> UspGetAnnouncementFrontPagingByCond(int? currentPage, int? pageSize, string keyword, int? categoryId, System.DateTime? sysLocalDate, string account, int? deptId, int? sortType);
        System.Collections.Generic.List<UspGetAnnouncementFrontPagingByCondReturnModel> UspGetAnnouncementFrontPagingByCond(int? currentPage, int? pageSize, string keyword, int? categoryId, System.DateTime? sysLocalDate, string account, int? deptId, int? sortType, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAnnouncementFrontPagingByCondReturnModel>> UspGetAnnouncementFrontPagingByCondAsync(int? currentPage, int? pageSize, string keyword, int? categoryId, System.DateTime? sysLocalDate, string account, int? deptId, int? sortType);

        System.Collections.Generic.List<UspGetAnnouncementPagingByCondReturnModel> UspGetAnnouncementPagingByCond(int? currentPage, int? pageSize, string title, string creatorName, int? categoryId, System.DateTime? effectiveStartdate, System.DateTime? effectiveEnddate);
        System.Collections.Generic.List<UspGetAnnouncementPagingByCondReturnModel> UspGetAnnouncementPagingByCond(int? currentPage, int? pageSize, string title, string creatorName, int? categoryId, System.DateTime? effectiveStartdate, System.DateTime? effectiveEnddate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetAnnouncementPagingByCondReturnModel>> UspGetAnnouncementPagingByCondAsync(int? currentPage, int? pageSize, string title, string creatorName, int? categoryId, System.DateTime? effectiveStartdate, System.DateTime? effectiveEnddate);

        System.Collections.Generic.List<UspGetBrandByIdReturnModel> UspGetBrandById(int? brandId);
        System.Collections.Generic.List<UspGetBrandByIdReturnModel> UspGetBrandById(int? brandId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetBrandByIdReturnModel>> UspGetBrandByIdAsync(int? brandId);

        System.Collections.Generic.List<UspGetBrandsPagingReturnModel> UspGetBrandsPaging(int? currentPage, int? pageSize);
        System.Collections.Generic.List<UspGetBrandsPagingReturnModel> UspGetBrandsPaging(int? currentPage, int? pageSize, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetBrandsPagingReturnModel>> UspGetBrandsPagingAsync(int? currentPage, int? pageSize);

        System.Collections.Generic.List<UspGetChangeLanguageReturnModel> UspGetChangeLanguage();
        System.Collections.Generic.List<UspGetChangeLanguageReturnModel> UspGetChangeLanguage(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetChangeLanguageReturnModel>> UspGetChangeLanguageAsync();

        System.Collections.Generic.List<UspGetDeptsByBrandReturnModel> UspGetDeptsByBrand(int? brandId);
        System.Collections.Generic.List<UspGetDeptsByBrandReturnModel> UspGetDeptsByBrand(int? brandId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetDeptsByBrandReturnModel>> UspGetDeptsByBrandAsync(int? brandId);

        System.Collections.Generic.List<UspGetFontCategoryReturnModel> UspGetFontCategory(string account, System.DateTime? sysLocalDate);
        System.Collections.Generic.List<UspGetFontCategoryReturnModel> UspGetFontCategory(string account, System.DateTime? sysLocalDate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetFontCategoryReturnModel>> UspGetFontCategoryAsync(string account, System.DateTime? sysLocalDate);

        System.Collections.Generic.List<UspGetHistoryAnnouncementFrontPagingByCondReturnModel> UspGetHistoryAnnouncementFrontPagingByCond(int? currentPage, int? pageSize, string keyword, int? categoryId, int? year, int? month, System.DateTime? sysLocalDate, string account, int? sortType);
        System.Collections.Generic.List<UspGetHistoryAnnouncementFrontPagingByCondReturnModel> UspGetHistoryAnnouncementFrontPagingByCond(int? currentPage, int? pageSize, string keyword, int? categoryId, int? year, int? month, System.DateTime? sysLocalDate, string account, int? sortType, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetHistoryAnnouncementFrontPagingByCondReturnModel>> UspGetHistoryAnnouncementFrontPagingByCondAsync(int? currentPage, int? pageSize, string keyword, int? categoryId, int? year, int? month, System.DateTime? sysLocalDate, string account, int? sortType);

        System.Collections.Generic.List<UspGetLanguageInfoByLanguageKeyReturnModel> UspGetLanguageInfoByLanguageKey(string languageKey);
        System.Collections.Generic.List<UspGetLanguageInfoByLanguageKeyReturnModel> UspGetLanguageInfoByLanguageKey(string languageKey, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetLanguageInfoByLanguageKeyReturnModel>> UspGetLanguageInfoByLanguageKeyAsync(string languageKey);

        System.Collections.Generic.List<UspGetLanguagesReturnModel> UspGetLanguages();
        System.Collections.Generic.List<UspGetLanguagesReturnModel> UspGetLanguages(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetLanguagesReturnModel>> UspGetLanguagesAsync();

        System.Collections.Generic.List<UspGetRoleAndAccountMappingByRoleIdReturnModel> UspGetRoleAndAccountMappingByRoleId(int? roleId);
        System.Collections.Generic.List<UspGetRoleAndAccountMappingByRoleIdReturnModel> UspGetRoleAndAccountMappingByRoleId(int? roleId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetRoleAndAccountMappingByRoleIdReturnModel>> UspGetRoleAndAccountMappingByRoleIdAsync(int? roleId);

        int UspInsertAnnouncement(int? categoryId, string title, string contentSummary, string contentDesc, System.DateTime? effectiveStartdate, System.DateTime? effectiveEnddate, string backgroundImagePath, bool? valid, string creatorId, System.DateTime? createdAt, string creatorName, int? creatorDept, System.Data.DataTable attachs, System.Data.DataTable depts);
        // UspInsertAnnouncementAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspInsertAnnouncementCategory(string categoryName, int? sort, bool? valid, string creatorId, System.DateTime? createdAt);
        // UspInsertAnnouncementCategoryAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspInsertAnnouncementLog(int? announcementId, string account);
        // UspInsertAnnouncementLogAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspInsertApplicationErrorLog(string applicationName, string requestUrl, string requestPath, string message, string stachMessage);
        // UspInsertApplicationErrorLogAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspInsertBrand(string brandName, string creatorId);
        // UspInsertBrandAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspInsertBrandAndDeptMapping(int? brandId, int? deptId, string creatorId);
        // UspInsertBrandAndDeptMappingAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspInsertRoleAndAccountMapping(int? roleId, string account, string reasons, string creatorId);
        // UspInsertRoleAndAccountMappingAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspRaiseError();
        // UspRaiseErrorAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspSyncAccount(string modifierId, System.Data.DataTable account);
        // UspSyncAccountAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspSyncDepartment(string modifierId, System.Data.DataTable dept);
        // UspSyncDepartmentAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateAnnouncement(int? id, int? categoryId, string title, string contentSummary, string contentDesc, System.DateTime? effectiveStartdate, System.DateTime? effectiveEnddate, string backgroundImagePath, string modifierId, System.DateTime? modifiedAt, System.Data.DataTable attachs, System.Data.DataTable depts);
        // UspUpdateAnnouncementAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateAnnouncementAttachValid(int? id, string modifierId, System.DateTime? modifiedAt);
        // UspUpdateAnnouncementAttachValidAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateAnnouncementCategory(int? id, string categoryName, int? sort, bool? valid, string modifierId, System.DateTime? modifiedAt);
        // UspUpdateAnnouncementCategoryAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateAnnouncementCategoryValid(int? id, string modifierId, System.DateTime? modifiedAt);
        // UspUpdateAnnouncementCategoryValidAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateAnnouncementValid(int? id, string modifierId, System.DateTime? modifiedAt);
        // UspUpdateAnnouncementValidAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateBrand(int? brandId, string brandName, string modifierId, string requestUrl);
        // UspUpdateBrandAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateLanguageIsNeedUpdate();
        // UspUpdateLanguageIsNeedUpdateAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

    }

}
// </auto-generated>
