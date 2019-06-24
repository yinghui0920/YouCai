using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoansItemMvc.Models
{
    [DataContract]
    public class YCUserDetailsData
    {
        [DataMember]
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Ud_Id         { get; set; }
        [DataMember]
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string Ud_Name       { get; set; }
        [DataMember]
        /// <summary>
        /// 性别
        /// </summary>
        public bool Ud_Sex        { get; set; }
        [DataMember]
        /// <summary>
        /// 身份ID
        /// </summary>
        public int Ud_IdentityID { get; set; }
        [DataMember]
        /// <summary>
        /// 贷款类型
        /// </summary>
        public int Ud_Type       { get; set; }
        [DataMember]
        /// <summary>
        /// 贷款金额
        /// </summary>
        public int Ud_Money      { get; set; }
        [DataMember]
        /// <summary>
        /// 分期时间
        /// </summary>
        public int Ud_Time       { get; set; }
        [DataMember]
        /// <summary>
        /// 贷款用途ID
        /// </summary>
        public int Ud_Goal       { get; set; }
        [DataMember]
        /// <summary>
        /// 手机号
        /// </summary>
        public string Ud_Phone      { get; set; }
        [DataMember]
        /// <summary>
        /// 上传身份证图片
        /// </summary>
        public string Ud_IDCardPic  { get; set; }
        [DataMember]
        /// <summary>
        /// 备注说明
        /// </summary>
        public string Ud_Remark     { get; set; }
        [DataMember]
        /// <summary>
        /// 获取当前时间
        /// </summary>
        public DateTime Ud_NowDate    { get; set; }
    }
}
