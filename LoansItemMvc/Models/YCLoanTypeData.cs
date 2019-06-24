using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoansItemMvc.Models
{
    [DataContract]
    public class YCLoanTypeData
    {
        [DataMember]
        /// <summary>
        /// 主键ID
        /// </summary>
        public int  LT_Id      { get; set; }
        [DataMember]
        /// <summary>
        /// 名称
        /// </summary>
        public string  LT_Name    { get; set; }
        [DataMember]
        /// <summary>
        /// 利率
        /// </summary>
        public string  LT_GoalID  { get; set; }
        [DataMember]
        /// <summary>
        /// 特点
        /// </summary>
        public string  LT_Trait   { get; set; }
        [DataMember]
        /// <summary>
        /// 图片
        /// </summary>
        public string  LT_Picture { get; set; }
    }
}
