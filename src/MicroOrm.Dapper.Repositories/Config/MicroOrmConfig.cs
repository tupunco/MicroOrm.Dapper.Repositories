using MicroOrm.Dapper.Repositories.SqlGenerator;

namespace MicroOrm.Dapper.Repositories.Config
{
    /// <summary>
    /// 
    /// </summary>
    public static class MicroOrmConfig
    {
        /// <summary>
        ///     Type Sql provider
        /// </summary>
        public static SqlProvider SqlProvider { get; set; }

        /// <summary>
        ///     Use quotation marks for TableName and ColumnName
        /// </summary>
        public static bool UseQuotationMarks { get; set; }
    }
}
