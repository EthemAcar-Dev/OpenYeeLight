/******************************************************************************
 * SunnyUI 开源控件库、工具类库、扩展类库、多页面开发框架。
 * CopyRight (C) 2012-2020 ShenYongHua(沈永华).
 * QQ群：56829229 QQ：17612584 EMail：SunnyUI@qq.com
 *
 * Blog:   https://www.cnblogs.com/yhuse
 * Gitee:  https://gitee.com/yhuse/SunnyUI
 * GitHub: https://github.com/yhuse/SunnyUI
 *
 * SunnyUI.dll can be used for free under the GPL-3.0 license.
 * If you use this code, please keep this note.
 * 如果您使用此代码，请保留此说明。
 ******************************************************************************
 * 文件名称: UIFormHelper.cs
 * 文件说明: 多语言字符串定义
 * 当前版本: V2.2
 * 创建日期: 2020-01-01
 *
 * 2020-04-19: V2.2 增加文件说明
******************************************************************************/

namespace Sunny.UI
{
    public static class UILocalize
    {
        public static string InfoTitle = "Info";
        public static string SuccessTitle = "Success";
        public static string WarningTitle = "Warning";
        public static string ErrorTitle = "Error";
        public static string AskTitle = "Query";
        public static string InputTitle = "Input";
        public static string SelectTitle = "Select";
        public static string CloseAll = "Close all";
        public static string OK = "OK";
        public static string Cancel = "Cancel";
        public static string GridNoData = "[ No data ]";
        public static string GridDataLoading = "Data loading ......";
        public static string GridDataSourceException = "The data source must be DataTable or List";
    }

    public static class UILocalizeHelper
    {
        public static void SetEN()
        {
            UILocalize.InfoTitle = "Info";
            UILocalize.SuccessTitle = "Success";
            UILocalize.WarningTitle = "Warning";
            UILocalize.ErrorTitle = "Error";
            UILocalize.AskTitle = "Query";
            UILocalize.InputTitle = "Input";
            UILocalize.SelectTitle = "Select";
            UILocalize.CloseAll = "Close all";
            UILocalize.OK = "OK";
            UILocalize.Cancel = "Cancel";
            UILocalize.GridNoData = "[ No data ]";
            UILocalize.GridDataLoading = "Data loading ......";
            UILocalize.GridDataSourceException = "The data source must be DataTable or List";
        }
    }
}