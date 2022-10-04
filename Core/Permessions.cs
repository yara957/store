using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorSystem.Core
{
   static class Permessions
    {
        
        public const string _READ_PERMESSION="READ";
        public const string _ADD_PERMESSION="ADD";
        public const string _UPDATE_PERMESSION="UPDATE";
        public const string _REMOVE_PERMESSION="REMOVE";
        public const string _ADMIN_PERMESSION="ADMIN";
        public const string _DFLT_USR_PASS="123";

        public static void refreshCurntUsr() {
            if (Program.CurrentUser == null)
                return;
            SysData.DbCntxt1 db = new SysData.DbCntxt1();
            Program.CurrentUser = db.Users.FirstOrDefault((usr) => usr.user_id == Program.CurrentUser.user_id);
        }

        public static bool canAdd() 
        {
            if (Program.CurrentUser == null)
                return false;
            
            refreshCurntUsr();

            if (string.IsNullOrEmpty(Program.CurrentUser.user_role))
                return false;

            if(Program.CurrentUser.user_role.Contains(_ADD_PERMESSION))
            return true;

            return false;
        }
        public static bool canRemove() {
            if (Program.CurrentUser == null)
                return false;

            refreshCurntUsr();


            if (string.IsNullOrEmpty(Program.CurrentUser.user_role))
                return false;

            if (Program.CurrentUser.user_role.Contains(_REMOVE_PERMESSION))
                return true;

            return false;
        }
        public static bool canRead()
        {if (Program.CurrentUser == null)
                return false;

            refreshCurntUsr();

            if (string.IsNullOrEmpty(Program.CurrentUser.user_role))
                return false;
            if (Program.CurrentUser.user_role.Contains(_ADD_PERMESSION))
                return true;
            return false;
        }

        public static bool canUpdate()
        {
            if (Program.CurrentUser == null)
                return false;

            refreshCurntUsr();

            if (string.IsNullOrEmpty(Program.CurrentUser.user_role))
                return false;

            if (Program.CurrentUser.user_role.Contains(_UPDATE_PERMESSION))
                return true;

            return false;
        }
        public static bool isAdmin()
        {
            if (Program.CurrentUser == null)
                return false;

            refreshCurntUsr();

            if (string.IsNullOrEmpty(Program.CurrentUser.user_role))
                return false;

            if (Program.CurrentUser.user_role.Contains(_ADMIN_PERMESSION))
                return true;

            return false;
        }

    }
}
