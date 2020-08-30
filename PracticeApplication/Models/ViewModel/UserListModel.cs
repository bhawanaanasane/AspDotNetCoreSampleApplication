using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApplication.Models.ViewModel
{
    public class UserListModel
    {
        public UserListModel()
        {
            Users = new List<UserModel>();
        }

        public IList<UserModel> Users { get; set; }
    }
}
