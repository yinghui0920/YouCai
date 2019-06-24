using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoansItemMvc.Models
{
    [DataContract]
    public class YCAdminInfoData
    {
        [DataMember]
        /// <summary>
        /// 主键ID
        /// </summary>
        public int A_Id       { get; set; }
        [DataMember]
        /// <summary>
        /// 用户性
        /// </summary>
        public string A_Name     { get; set; }
        [DataMember]
        /// <summary>
        /// 密码
        /// </summary>
        public string A_Password { get; set; }
        [DataMember]
        /// <summary>
        /// 身份（单选按钮）
        /// </summary>
        public bool A_Identity { get; set; }
    }
}
