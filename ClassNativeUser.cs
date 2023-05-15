using media.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    internal static class ClassNativeUser
    {
        static User nativeUser;
        public static List<int>nativeUsersFriendsId= new List<int>();
        public static List<User> distinctUserList;
        public static List<User> DistinctUserList
        {
            get { return distinctUserList; }
            set
            {
                distinctUserList = value;
            }
        }

        //private static User[] arrayUsersFriend;
        /*        public static User[] ArrayUsersFriend
                {
                    get { return arrayUsersFriend; }
                    set
                    {
                        arrayUsersFriend = nativeUsersFriends.ToArray();
                        if (nativeUsersFriends != null && nativeUsersFriends.Count > 0)
                        {
                            arrayUsersFriend = nativeUsersFriends
                                 .Where(p => p != null)
                                 .GroupBy(p => p.Key)
                                 .Select(g => g.First())
                                 .ToArray();
                        }
                        MessageBox.Show("efweffrrrev "+ arrayUsersFriend.Length.ToString());
                    }
                }*/
        public static User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }
        static ClassNativeUser()
        {
            NativeUser = null;
        }
    }
}
