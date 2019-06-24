using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoansItemMvc.Models
{
    [DataContract]
    public class YCMyBillData
    {
        [DataMember]
        /// <summary>
        /// 主键ID
        /// </summary>
        public int MB_Id       { get; set; }
        [DataMember]
        /// <summary>
        /// 期数
        /// </summary>
        public string MB_Month    { get; set; }
        [DataMember]
        /// <summary>
        /// 本金
        /// </summary>
        public string MB_Money    { get; set; }
        [DataMember]
        /// <summary>
        /// 利息
        /// </summary>
        public string MB_Interest { get; set; }
        [DataMember]
        /// <summary>
        /// 应还
        /// </summary>
        public string MB_AllMoney { get; set; }
        [DataMember]
        /// <summary>
        /// 最后还款日
        /// </summary>
        public DateTime MB_LastDate { get; set; }
        [DataMember]
        /// <summary>
        /// 还款时间
        /// </summary>
        public DateTime MB_NowDate  { get; set; }
    }
}
