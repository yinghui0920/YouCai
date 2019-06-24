using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoansItemMvc.Models
{
    [DataContract]
    public class YCUserInfoData
    {
        [DataMember]
        /// <summary>
        /// 主键ID
        /// </summary>
        public int U_Id       { get; set; }
        [DataMember]
        /// <summary>
        /// 用户名
        /// </summary>
        public string U_Name	 { get; set; }
        [DataMember]
        /// <summary>
        /// 用户密码
        /// </summary>
        public string U_Password { get; set; }
        [DataMember]
        /// <summary>
        /// 手机号
        /// </summary>
        public string U_Phone { get; set; }
    }
}
