using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Acme.IssueManagement.Constants
{
    public class Enums
    {
        public enum BookTypeEnums
        {
            [Description("Không_Xác_Định")]
            Undefined,
            [Description("Cuộc_Phiêu_Lưu")]
            Adventure,
            [Description("Tiểu_Sử")]
            Biography,
            [Description("Viễn_Tưởng")]
            Dystopia,
            [Description("Tưởng_Tượng")]
            Fantastic,
            [Description("Kinh_Dị")]
            Horror,
            [Description("Khoa_Học")]
            Science,
            [Description("Khoa_Học_Viễn_Tưởng")]
            ScienceFiction,
            [Description("Thơ")]
            Poetry
        }
    }
    
}
