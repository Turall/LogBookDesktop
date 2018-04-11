using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogBookDesktop.Model;

namespace LogBookDesktop.ViewModel
{
    class GroupModelView
    {
        public static List<StudentModel> StdList = new List<StudentModel>();
        public static Dictionary<GroupModel, List<StudentModel>> StdandGroupList = new Dictionary<GroupModel, List<StudentModel>>();
       
       

        public GroupModelView(StudentModel std)
        {
            StdList.Add(std);
        }

        public GroupModelView(List<StudentModel> s, GroupModel grp)
        {
            StdandGroupList.Add(grp, s);
        }
    }
}
