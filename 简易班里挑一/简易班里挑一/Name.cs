using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简易班里挑一
{
    /// <summary>
    /// 初始化姓名的类
    /// </summary>
    class Name
    {
        public Name()
        {
        }
        public Name(string Name,int ClassNumber,int ID,string ZhuanYe)
            {
            this.name = Name;
            this.classNumber = ClassNumber;
                this.id = ID;
            this.zhuanYe = ZhuanYe;
            }
        public string name { get; set; }
        public int classNumber{ get;set;}
        public int id { get; set; }
        public string zhuanYe { get; set; }
    }
}
