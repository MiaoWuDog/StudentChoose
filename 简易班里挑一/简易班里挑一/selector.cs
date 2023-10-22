using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace 简易班里挑一
{
    /// <summary>
    /// 随机选择的类
    /// </summary>
    class Selector
    {
        private List<Name> namelist;

        /// <summary>
        /// 构造函数--初始化人员合集数组
        /// </summary>
        public Selector()
            {namelist=new List<Name>();}

       /// <summary>
       /// 读取人员并且输出到数组
       /// </summary>
        public List<Name> Namelist
        {
            get {
                if (namelist.Count!=0)
                {
                    //如果数组已经被读取过了，以免bug，直接返回
                    return namelist;
                }
                //否则文件流
                FileStream fs = new FileStream("name.txt",FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs,Encoding.UTF8);
                string nameInfo = string.Empty;
                //创建临时字符串
                while (true)
                    //死循环
                {
                    nameInfo = sr.ReadLine();
                    //文件流读取一行（一个流所以一行一行读取）
                    if (nameInfo == null)
                    {
                        break;
                        //当读到null的时候说明读完了，break
                    }
                    else
                    {
                        string[] student = nameInfo.Split(',');
                            //将每一行分割开存进一个临时数组里
                        namelist.Add(new Name(student[0], Convert.ToInt32(student[1]), Convert.ToInt32(student[2]),student[3]));
                        //整体添加到一个大数组里
                    }

                }
                fs.Close();
                sr.Close();
                return namelist;
                //关闭流返回namelist

            }
        }
        private Random random = new Random();
        public Name RandomStd()
        {

            int random1 = random.Next(Namelist.Count);
            //随机一个数 返回总数组的角标对应参数
            return namelist[random1];
        }

    }
}
