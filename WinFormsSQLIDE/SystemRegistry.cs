using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsSQLIDE
{
    public static class SystemRegistry
    {
        //KEYS:
        //Server,
        //Database,
        //Table.
        public static string getRegistryKey(string keyName)
        {
            //KEYS:
            //Server,
            //Database,
            //Table.
            string Fullname = "Software\\SQLService_Db" + keyName;
            string valueName = "Name";

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Fullname, true);

            if (registryKey == null)
            {
                //Return !@#<NoKey if there is no registry with name like that
                return "!@#<NoKey";
            }

            string getValue = (string)registryKey.GetValue(valueName);

            registryKey.Close();
            return getValue;
        }

        public static void ModifyRegistry(string key,string value)
        {
            //KEYS:
            //Server,
            //Database,
            //Table.
            //Ścieżka
            string fullPath = "Software\\SQLService_Db" + key;
            //PropertyName
            string valueName = "Name";

            //User, otwórz SubKey
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(fullPath, true);
            {
                //Jeżeli nie istnieje to utwórz nowy
                if (registryKey == null)
                {
                    registryKey = Registry.CurrentUser.CreateSubKey(fullPath);
                }

                //Ustaw wartość klucza na konkretną:
                registryKey.SetValue(valueName, value);
            }
            //Zamknij klucz
            registryKey.Close();
        }

    }

    //IMPORTANT!
    //KEYS:
    //Server,
    //Database,
    //Table.
}
