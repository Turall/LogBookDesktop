using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogBookDesktop.Model;

namespace LogBookDesktop.ViewModel
{
    //GroupModel ozunde bu grupa adi olan telebelerin listin saxliyir,ve sonra onlari dictionary-de key olaraq,
    // Group,value olaraqda groupa aid olan studentlerin listin saxlayir
    //Teacheride bu classlar elaqelendirmek lazimdi ,ona bax !!
    class GroupModel
    {
        public static List<Student> StdList = new List<Student>();
        public static Dictionary<Group, List<Student>> StdandGroupList = new Dictionary<Group, List<Student>>();

       

        public GroupModel(Student std)
        {
            StdList.Add(std);
        }

        public GroupModel(List<Student> s, Group grp)
        {
            StdandGroupList.Add(grp, s);
        }
    }
}
