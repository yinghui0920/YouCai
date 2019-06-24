using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoansItemMvc.Models
{
    [DataContract]
   public class YCIdentityTableData
    {
        [DataMember]
        /// <summary>
        /// 主键ID
        /// </summary>
        public int  I_Id   { get; set; }
        [DataMember]
        /// <summary>
        /// 身份证姓名
        /// </summary>
        public string I_Name { get; set; }
    }
}
