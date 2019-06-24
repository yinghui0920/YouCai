using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoansItemMvc.Models
{
    [DataContract]
   public  class YCloansGoalData
    {
        [DataMember]
        /// <summary>
        /// 主键ID
        /// </summary>
        public int IG_Id   { get; set; }
        [DataMember]
        /// <summary>
        /// 用途名称
        /// </summary>
        public string IG_Name { get; set; }
    }
}
