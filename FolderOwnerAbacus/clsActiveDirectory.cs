using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;


namespace ActiveDirectory
{
    public class OUBO
    {
        public string Name = string.Empty;
        public DirectoryEntry objDirEntry = null;

    }
    public abstract class clsActiveDirectory
    {
        private static bool CheckSchmea(string schemaClassName, string childName)
        {

            try
            {
                if (schemaClassName == "organizationalUnit")
                    return true;

                if (schemaClassName == "user")
                    return true;

                if (schemaClassName == "container" && childName == "CN=Users")
                    return true;
            }
            catch (Exception E)
            {
                string strEx = E.Message;
            }

            return false;

        }

        private static bool GetSingleUser(DirectoryEntry dirEntry, DataTable dTable_ADUsers)
        {
            try
            {

                //if (String.Compare(dirEntry.SchemaClassName, "User", true) == 0)
                //{
                DataRow dRow_ADUser = dTable_ADUsers.NewRow();
                dRow_ADUser["FullName"] = dirEntry.Name.Substring(3);
                dTable_ADUsers.Rows.Add(dRow_ADUser);

                try
                {
                    dRow_ADUser["UserName"] = dirEntry.Properties["sAMAccountName"].Value.ToString();
                }
                catch (Exception accountException)
                {
                    dRow_ADUser["UserName"] = string.Empty;
                }
                try
                {
                    dRow_ADUser["ADDomainName"] = dirEntry.Parent.Parent.Name.Substring(3).ToString();
                }
                catch (Exception accountException)
                {
                    dRow_ADUser["ADDomainName"] = string.Empty;
                }
                try
                {
                    dRow_ADUser["UserPrincipalName"] = dirEntry.Properties["UserPrincipalName"].Value.ToString();
                }
                catch (Exception accountException)
                {
                    dRow_ADUser["UserPrincipal "] = string.Empty;
                }

                try
                {
                    dRow_ADUser["Telephone"] = dirEntry.Properties["telephoneNumber"].Value.ToString();
                }
                catch (Exception telephoneException)
                {
                    dRow_ADUser["Telephone"] = string.Empty;
                }

                try
                {
                    dRow_ADUser["Home"] = dirEntry.Properties["HomePhone"].Value.ToString();
                }
                catch (Exception homePhoneException)
                {
                    dRow_ADUser["Home"] = string.Empty;
                }

                try
                {
                    dRow_ADUser["Pager"] = dirEntry.Properties["Pager"].Value.ToString();
                }
                catch (Exception pagerException)
                {
                    dRow_ADUser["Pager"] = string.Empty;
                }

                try
                {
                    dRow_ADUser["Mobile"] = dirEntry.Properties["mobile"].Value.ToString();
                }
                catch (Exception mobileException)
                {
                    dRow_ADUser["Mobile"] = string.Empty;
                }

                try
                {
                    dRow_ADUser["Fax"] = dirEntry.Properties["facsimileTelephoneNumber"].Value.ToString();
                }
                catch (Exception faxException)
                {
                    dRow_ADUser["Fax"] = string.Empty;
                }

                try
                {
                    dRow_ADUser["IPPhone"] = dirEntry.Properties["IPPhone"].Value.ToString();
                }
                catch (Exception ipPhoneException)
                {
                    dRow_ADUser["IPPhone"] = string.Empty;
                }

                try
                {
                    dRow_ADUser["Office"] = dirEntry.Properties["physicalDeliveryOfficeName"].Value.ToString();
                }
                catch (Exception officeException)
                {
                    dRow_ADUser["Office"] = string.Empty;
                }

                try
                {
                    dRow_ADUser["Description"] = dirEntry.Properties["Description"].Value.ToString();
                }
                catch (Exception descriptionException)
                {
                    dRow_ADUser["Description"] = string.Empty;
                }

                try
                {
                    dRow_ADUser["Sid"] = getSid(dirEntry);

                }
                catch (Exception descriptionException)
                {
                    dRow_ADUser["Sid"] = string.Empty;
                }



                // }
            }
            catch (Exception E)
            {
                throw E;
            }

            return true;
        }

        public static DataTable GetADUsersContainers(string DomainName, string Username, string Password)
        {
            DataTable dtContainers = new DataTable();
            try
            {
                dtContainers.Columns.Add("ContainerName");
                DirectoryEntry objDEMainNode = null;

                if (Username.Trim() == string.Empty)
                    objDEMainNode = new DirectoryEntry("LDAP://" + System.Environment.UserDomainName);
                else
                    objDEMainNode = new DirectoryEntry("LDAP://" + DomainName, Username, Password);

                foreach (DirectoryEntry deChild in objDEMainNode.Children)
                {
                    try
                    {
                        //if (CheckSchmea(deChild.SchemaClassName, deChild.Name))
                        //{
                            DataRow dRow_ADUser = dtContainers.NewRow();
                            dRow_ADUser["ContainerName"] = deChild.Name;
                            dtContainers.Rows.Add(dRow_ADUser);
                       // }
                    }
                    catch (Exception InnerExp)
                    {
                        string strInnerExp = InnerExp.Message;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return dtContainers;
        }
        public static DataTable GetADUsers(string DomainName, string Username, string Password)
        {
            List<DirectoryEntry> lstUsersDE = new List<DirectoryEntry>();
            DataTable dTable_ADUsers = new DataTable("ADUsers");

            try
            {

                dTable_ADUsers.Columns.Add("FullName");
                dTable_ADUsers.Columns.Add("UserName");
                dTable_ADUsers.Columns.Add("ADDomainName");
                dTable_ADUsers.Columns.Add("UserPrincipalName");
                dTable_ADUsers.Columns.Add("Telephone");
                dTable_ADUsers.Columns.Add("Home");
                dTable_ADUsers.Columns.Add("Mobile");
                dTable_ADUsers.Columns.Add("Pager");
                dTable_ADUsers.Columns.Add("Fax");
                dTable_ADUsers.Columns.Add("IPPhone");
                dTable_ADUsers.Columns.Add("Office");
                dTable_ADUsers.Columns.Add("Description");
                dTable_ADUsers.Columns.Add("Sid");

                // string username = String.Format(@"{0}\{1}", "192.168.0.112", "GhostSoftware\\shahzeb.khan");
                //   System.Security.Principal.WindowsIdentity id = new System.Security.Principal.WindowsIdentity(username);
                //  string sid = id.User.AccountDomainSid.ToString();


                DirectoryEntry objDEMainNode = null;

                if (Username.Trim() == string.Empty)
                    objDEMainNode = new DirectoryEntry("LDAP://" + System.Environment.UserDomainName);
                else
                    objDEMainNode = new DirectoryEntry("LDAP://" + DomainName, Username, Password);

                foreach (DirectoryEntry deChild in objDEMainNode.Children)
                {
                    try
                    {
                        if (CheckSchmea(deChild.SchemaClassName, deChild.Name))
                        {
                            if (deChild.SchemaClassName == "container" && deChild.Name == "CN=Users")
                                lstUsersDE.Add(deChild);
                        }
                    }
                    catch (Exception InnerExp)
                    {
                        string strInnerExp = InnerExp.Message;
                    }
                }

                foreach (DirectoryEntry objDirectoryEntry in lstUsersDE)
                {
                    try
                    {
                        GetUsers(dTable_ADUsers, objDirectoryEntry);
                    }
                    catch (Exception InnerExp)
                    {
                        string strInnerExp = InnerExp.Message;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }

            return dTable_ADUsers;
        }

        public static DataTable GetADUsersByContainer(string DomainName, string Username, string Password, string Container)
        {
            List<DirectoryEntry> lstUsersDE = new List<DirectoryEntry>();
            DataTable dTable_ADUsers = new DataTable("ADUsers");

            try
            {

                dTable_ADUsers.Columns.Add("FullName");
                dTable_ADUsers.Columns.Add("UserName");
                dTable_ADUsers.Columns.Add("ADDomainName");
                dTable_ADUsers.Columns.Add("UserPrincipalName");
                dTable_ADUsers.Columns.Add("Telephone");
                dTable_ADUsers.Columns.Add("Home");
                dTable_ADUsers.Columns.Add("Mobile");
                dTable_ADUsers.Columns.Add("Pager");
                dTable_ADUsers.Columns.Add("Fax");
                dTable_ADUsers.Columns.Add("IPPhone");
                dTable_ADUsers.Columns.Add("Office");
                dTable_ADUsers.Columns.Add("Description");
                dTable_ADUsers.Columns.Add("Sid");

                // string username = String.Format(@"{0}\{1}", "192.168.0.112", "GhostSoftware\\shahzeb.khan");
                //   System.Security.Principal.WindowsIdentity id = new System.Security.Principal.WindowsIdentity(username);
                //  string sid = id.User.AccountDomainSid.ToString();


                DirectoryEntry objDEMainNode = null;

                if (Username.Trim() == string.Empty)
                    objDEMainNode = new DirectoryEntry("LDAP://" + System.Environment.UserDomainName);
                else
                    objDEMainNode = new DirectoryEntry("LDAP://" + DomainName, Username, Password);

                foreach (DirectoryEntry deChild in objDEMainNode.Children)
                {
                    try
                    {
                        if (deChild.Name.Trim().ToLower() == Container.Trim().ToLower())
                            lstUsersDE.Add(deChild);
                    }
                    catch (Exception InnerExp)
                    {
                        string strInnerExp = InnerExp.Message;
                    }
                }

                foreach (DirectoryEntry objDirectoryEntry in lstUsersDE)
                {
                    try
                    {
                        GetUsers(dTable_ADUsers, objDirectoryEntry);
                    }
                    catch (Exception InnerExp)
                    {
                        string strInnerExp = InnerExp.Message;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }

            return dTable_ADUsers;
        }

        private static DataTable GetUsers(DataTable dTable_ADUsers, DirectoryEntry objDirEntry)
        {
            try
            {

                foreach (DirectoryEntry deChild in objDirEntry.Children)
                {
                    if (CheckSchmea(deChild.SchemaClassName, deChild.Name))
                    {
                        try
                        {
                            //if (deChild.SchemaClassName == "user" )
                            GetSingleUser(deChild, dTable_ADUsers);

                        }
                        catch (Exception InnerExp)
                        {
                            string strInnerExp = InnerExp.Message;
                        }
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }

            return dTable_ADUsers;
        }

        public static string ConvertByteToStringSid(Byte[] sidBytes)
        {
            StringBuilder strSid = new StringBuilder();
            strSid.Append("S-");
            try
            {
                // Add SID revision.
                strSid.Append(sidBytes[0].ToString());
                // Next six bytes are SID authority value.
                if (sidBytes[6] != 0 || sidBytes[5] != 0)
                {
                    string strAuth = String.Format
                        ("0x{0:2x}{1:2x}{2:2x}{3:2x}{4:2x}{5:2x}",
                        (Int16)sidBytes[1],
                        (Int16)sidBytes[2],
                        (Int16)sidBytes[3],
                        (Int16)sidBytes[4],
                        (Int16)sidBytes[5],
                        (Int16)sidBytes[6]);
                    strSid.Append("-");
                    strSid.Append(strAuth);
                }
                else
                {
                    Int64 iVal = (Int32)(sidBytes[1]) +
                        (Int32)(sidBytes[2] << 8) +
                        (Int32)(sidBytes[3] << 16) +
                        (Int32)(sidBytes[4] << 24);
                    strSid.Append("-");
                    strSid.Append(iVal.ToString());
                }

                // Get sub authority count...
                int iSubCount = Convert.ToInt32(sidBytes[7]);
                int idxAuth = 0;
                for (int i = 0; i < iSubCount; i++)
                {
                    idxAuth = 8 + i * 4;
                    UInt32 iSubAuth = BitConverter.ToUInt32(sidBytes, idxAuth);
                    strSid.Append("-");
                    strSid.Append(iSubAuth.ToString());
                }
            }
            catch (Exception ex)
            {
                return "";
            }
            return strSid.ToString();
        }

        public static string getSid(DirectoryEntry dirEntry)
        {
            string userSID = "";
            System.DirectoryServices.PropertyCollection coll = dirEntry.Properties;
            object obVal = coll["objectSid"].Value;
            if (null != obVal)
            {
                userSID = ConvertByteToStringSid((Byte[])obVal);
            }
            return userSID;
        }

        public static bool AuthenticateADUser(string DomainName, string Username, string Password, string SID)
        {
            bool IsValidUser = false;
            try
            {
                #region Junk Code
                //DirectoryEntry entry = new DirectoryEntry("LDAP://" + DomainName, Username, Password);
                //foreach (DirectoryEntry deChild in entry.Children)
                //{

                //}
                //DirectorySearcher srch = new DirectorySearcher(entry);
                //srch.Filter = "(objectCategory=Person)";
                //srch.SearchScope = SearchScope.Subtree;

                // //define properties to load
                //srch.PropertiesToLoad.Add("objectSid");
                //srch.PropertiesToLoad.Add("sAMAccountName");

                //// search the directory
                //foreach (System.DirectoryServices.SearchResult result in srch.FindAll())
                //{
                //     //grab the data - if present
                //    if (result.Properties["objectSid"] != null && result.Properties["objectSid"].Count > 0)
                //    {
                //        string sid = getSid(entry);
                //    }

                //    if (result.Properties["sAMAccountName"] != null && result.Properties["sAMAccountName"].Count > 0)
                //    {
                //        string userName = result.Properties["sAMAccountName"][0].ToString();
                //    }
                //}
                #endregion

                DataTable dt = GetSelectedADUsers(DomainName, DomainName + "\\" + Username, Password);
                if (dt.Rows.Count > 0 && SID.Trim() == dt.Rows[0]["SID"].ToString().Trim())
                {
                    IsValidUser = true;
                }
            }
            catch (Exception ex)
            {

                IsValidUser = false;
                throw new Exception("Error authenticating user." + ex.Message);
            }
            return IsValidUser;
        }

        public static DataTable GetSelectedADUsers(string DomainName, string Username, string Password)
        {
            List<DirectoryEntry> lstUsersDE = new List<DirectoryEntry>();
            DataTable dTable_ADUsers = new DataTable("ADUsers");

            try
            {

                dTable_ADUsers.Columns.Add("FullName");
                dTable_ADUsers.Columns.Add("UserName");
                dTable_ADUsers.Columns.Add("ADDomainName");
                dTable_ADUsers.Columns.Add("UserPrincipalName");
                dTable_ADUsers.Columns.Add("Telephone");
                dTable_ADUsers.Columns.Add("Home");
                dTable_ADUsers.Columns.Add("Mobile");
                dTable_ADUsers.Columns.Add("Pager");
                dTable_ADUsers.Columns.Add("Fax");
                dTable_ADUsers.Columns.Add("IPPhone");
                dTable_ADUsers.Columns.Add("Office");
                dTable_ADUsers.Columns.Add("Description");
                dTable_ADUsers.Columns.Add("Sid");

                // string username = String.Format(@"{0}\{1}", "192.168.0.112", "GhostSoftware\\shahzeb.khan");
                //   System.Security.Principal.WindowsIdentity id = new System.Security.Principal.WindowsIdentity(username);
                //  string sid = id.User.AccountDomainSid.ToString();


                DirectoryEntry objDEMainNode = null;

                if (Username.Trim() == string.Empty)
                    objDEMainNode = new DirectoryEntry("LDAP://" + System.Environment.UserDomainName);
                else
                    objDEMainNode = new DirectoryEntry("LDAP://" + DomainName, Username, Password);

                foreach (DirectoryEntry deChild in objDEMainNode.Children)
                {
                    try
                    {
                        if (CheckSchmea(deChild.SchemaClassName, deChild.Name))
                        {
                            if (deChild.SchemaClassName == "container" && deChild.Name == "CN=Users")
                                lstUsersDE.Add(deChild);
                        }
                    }
                    catch (Exception InnerExp)
                    {
                        string strInnerExp = InnerExp.Message;
                    }
                }

                foreach (DirectoryEntry objDirectoryEntry in lstUsersDE)
                {
                    try
                    {
                        GetSelectedUser(dTable_ADUsers, objDirectoryEntry, Username);
                    }
                    catch (Exception InnerExp)
                    {
                        string strInnerExp = InnerExp.Message;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }

            return dTable_ADUsers;
        }
        private static DataTable GetSelectedUser(DataTable dTable_ADUsers, DirectoryEntry objDirEntry, string userName)
        {
            try
            {

                foreach (DirectoryEntry deChild in objDirEntry.Children)
                {
                    if (CheckSchmea(deChild.SchemaClassName, deChild.Name))
                    {
                        try
                        {
                            if (deChild.SchemaClassName == "user")
                            {
                                string uName = userName.Split(new char[] { '\\' }, 2)[1];
                                if (deChild.Properties["sAMAccountName"].Value.ToString() == uName)
                                {
                                    GetSingleUser(deChild, dTable_ADUsers);
                                    break;
                                }
                            }
                        }
                        catch (Exception InnerExp)
                        {
                            string strInnerExp = InnerExp.Message;
                        }
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }

            return dTable_ADUsers;
        }

        public static bool AuthenticateADUserPrincipalContext(string DomainName, string Username, string Password)
        {
            bool res = false;
            try
            {
                PrincipalContext pContex = new PrincipalContext(ContextType.Domain, DomainName);
                res = pContex.ValidateCredentials(Username, Password);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return res;
        }

        public static string IsValidDomainPrincipalContext(string DomainName)
        {
            string res = "ErrorAdDomainName";
            try
            {
                PrincipalContext pContex = new PrincipalContext(ContextType.Domain, DomainName);
                if (pContex.ConnectedServer.Trim() != string.Empty)
                {
                    res = pContex.ConnectedServer.Trim();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("the server could not be contacted"))
                    res = "ErrorAdDomainName:" + ex.Message;
                else
                    res = "Contacted server found :" + ex.Message;
            }
            return res;
        }

        public static DataTable GetAllADUsersPrincipalContext(string DomainName)
        {
            DataTable dtAdUsers = new DataTable();
            try
            {
                PrincipalContext AD = new PrincipalContext(ContextType.Domain, DomainName);
                UserPrincipal u = new UserPrincipal(AD);
                PrincipalSearcher search = new PrincipalSearcher(u);

                dtAdUsers.Columns.Add("FirstName");
                dtAdUsers.Columns.Add("MiddleName");
                dtAdUsers.Columns.Add("LastName");
                dtAdUsers.Columns.Add("FullName");
                dtAdUsers.Columns.Add("UserName");
                dtAdUsers.Columns.Add("Sid");

                foreach (UserPrincipal result in search.FindAll())
                {
                    if (result != null && result.DisplayName != null)
                    {
                        DataRow dRow = dtAdUsers.NewRow();
                        dRow["FirstName"] = result.GivenName;
                        dRow["MiddleName"] = result.MiddleName;
                        dRow["LastName"] = result.Surname;
                        dRow["FullName"] = result.DisplayName;
                        dRow["UserName"] = result.SamAccountName;
                        dRow["Sid"] = result.Sid.Value;
                        dtAdUsers.Rows.Add(dRow);
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return dtAdUsers;
        }
        public static DataTable GetAllADUsersPrincipalContext(string DomainName, string strUsername, string strPassword)
        {
            DataTable dtAdUsers = new DataTable();
            try
            {
                PrincipalContext AD = new PrincipalContext(ContextType.Domain, DomainName, null, strUsername, strPassword);
                UserPrincipal u = new UserPrincipal(AD);
                PrincipalSearcher search = new PrincipalSearcher(u);

                dtAdUsers.Columns.Add("FirstName");
                dtAdUsers.Columns.Add("MiddleName");
                dtAdUsers.Columns.Add("LastName");
                dtAdUsers.Columns.Add("FullName");
                dtAdUsers.Columns.Add("UserName");
                dtAdUsers.Columns.Add("Sid");

                foreach (UserPrincipal result in search.FindAll())
                {
                    if (result != null && result.DisplayName != null)
                    {
                        DataRow dRow = dtAdUsers.NewRow();
                        dRow["FirstName"] = result.GivenName;
                        dRow["MiddleName"] = result.MiddleName;
                        dRow["LastName"] = result.Surname;
                        dRow["FullName"] = result.DisplayName;
                        dRow["UserName"] = result.SamAccountName;
                        dRow["Sid"] = result.Sid.Value;
                        dtAdUsers.Rows.Add(dRow);
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return dtAdUsers;
        }
    }
}
