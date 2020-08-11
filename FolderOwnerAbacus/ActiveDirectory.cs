using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOwnerAbacus
{
	public class ActiveDirectory
	{
		public bool AuthenticateADUser(string DomainName, string Username, string Password, string SID, ref IList<DirectoryEntry> lstFileterdUsers)
		{
			bool IsValidUser = false;
			try
			{
				bool IsAuthenticated = GetActiveDirectoryUsers(DomainName, DomainName + "\\" + Username, Password, ref lstFileterdUsers);
				if (lstFileterdUsers.Count() > 0 && SID.Trim() == GetSID(lstFileterdUsers.FirstOrDefault()).Trim() && IsAuthenticated)
					IsValidUser = true;
			}
			catch (Exception ex)
			{
				IsValidUser = false;
				throw new Exception("Error authenticating user." + ex.Message);
			}
			return IsValidUser;
		}

		public string GetSID(DirectoryEntry dirEntry)
		{
			string userSID = "";
			try
			{
				System.DirectoryServices.PropertyCollection coll = dirEntry.Properties;
				object obVal = coll["objectSid"].Value;
				if (null != obVal)
				{
					userSID = ConvertByteToStringSid((Byte[])obVal);
				}	
			}
			catch (Exception ex)
			{

			}
			return userSID;
		}

		public string ConvertByteToStringSid(Byte[] sidBytes)
		{
			StringBuilder strSid = new StringBuilder();
			strSid.Append("S-");
			try
			{
				strSid.Append(sidBytes[0].ToString());
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

		public bool GetActiveDirectoryUsers(string DomainName, string Username, string Password, ref IList<DirectoryEntry> lstFilteredUsers)
		{
			IList<DirectoryEntry> lstUsersDE = new List<DirectoryEntry>();
			lstFilteredUsers = new List<DirectoryEntry>();
			bool IsAuthenticated = false;
			try
			{
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
							//if (deChild.SchemaClassName == "container" && deChild.Name == "CN=Users")
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
						foreach (DirectoryEntry deChild in objDirectoryEntry.Children)
						{
							if (CheckSchmea(deChild.SchemaClassName, deChild.Name))
							{
								try
								{
									if (deChild.SchemaClassName == "user")
									{
										string uName = Username.Split(new char[] { '\\' }, 2)[1];
										if (deChild.Properties["sAMAccountName"].Value.ToString() == uName)
											IsAuthenticated = true;

										lstFilteredUsers.Add(deChild);
									}
								}
								catch (Exception InnerExp)
								{
									string strInnerExp = InnerExp.Message;
								}
							}
						}
					}
					catch (Exception InnerExp)
					{
						IsAuthenticated = false;
						string strInnerExp = InnerExp.Message;
					}
				}
			}
			catch (Exception E)
			{
				IsAuthenticated = false;
				throw E;
			}

			return IsAuthenticated;
		}
		public bool CheckSchmea(string schemaClassName, string childName)
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
	}
}
