/* Name: HDS - Exporter EDI Relay
   Desc: An applicaiton generally used by citrus exporters to relay EDI 
   files between depot, exporter, and pack house systems.*/

/* Copyright (C) 2015 Free Software Foundation, Inc.

   This file is part of 'HDS - Exporter EDI Relay'.

   'HDS - Exporter EDI Relay' is free software: you can redistribute it 
   and/or modify it under the terms of the GNU General Public License 
   as published by the Free Software Foundation, either version 3 of 
   the License, or (at your option) any later version.

   'HDS - Exporter EDI Relay' is distributed in the hope that it will 
   be useful, but WITHOUT ANY WARRANTY; without even the implied warranty 
   of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with 'HDS - Exporter EDI Relay'.  
   If not, see <http://www.gnu.org/licenses/>.
   
   For additional details, please contact the developer 'Kavish Harrilall'
   at kavish@listkh.com
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace HDS_EDIRelay.HDS_Functions
{
    public class HDS_NetworkAuth : IDisposable
    {
        //[DllImport("advapi32.dll", SetLastError = true)]
        //private static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, out IntPtr phToken);

        //[DllImport("kernel32", SetLastError = true)]
        //private static extern bool CloseHandle(IntPtr hObject);

        //private IntPtr userHandle = IntPtr.Zero;
        //private WindowsImpersonationContext impersonationContext;

        //public HDS_NetworkAuth(string user, string domain, string password)
        //{
        //    if (!string.IsNullOrEmpty(user))
        //    {
        //        // Call LogonUser to get a token for the user  
        //        bool loggedOn = LogonUser(user, domain, password,
        //                        9 /*(int)LogonType.LOGON32_LOGON_NEW_CREDENTIALS*/,
        //                        3 /*(int)LogonProvider.LOGON32_PROVIDER_WINNT50*/,
        //        out userHandle);
        //        if (!loggedOn)
        //            throw new Win32Exception(Marshal.GetLastWin32Error());
        //        // Begin impersonating the user  
        //        impersonationContext = WindowsIdentity.Impersonate(userHandle);
        //    }
        //}

        //public void Dispose()
        //{
        //    if (userHandle != IntPtr.Zero)
        //        CloseHandle(userHandle);
        //    if (impersonationContext != null)
        //        impersonationContext.Undo();
        //}

        private WindowsImpersonationContext impersonationContext = null;

        public HDS_NetworkAuth(string userName, string domainName, string password)
		{
			ImpersonateValidUser( userName, domainName, password );
		}

		public void Dispose()
		{
			UndoImpersonation();
		}

		[DllImport("advapi32.dll", SetLastError=true)]
		private static extern int LogonUser(
			string lpszUserName,
			string lpszDomain,
			string lpszPassword,
			int dwLogonType,
			int dwLogonProvider,
			ref IntPtr phToken);
		
		[DllImport("advapi32.dll", CharSet=CharSet.Auto, SetLastError=true)]
		private static extern int DuplicateToken(
			IntPtr hToken,
			int impersonationLevel,
			ref IntPtr hNewToken);

		[DllImport("advapi32.dll", CharSet=CharSet.Auto, SetLastError=true)]
		private static extern bool RevertToSelf();

		[DllImport("kernel32.dll", CharSet=CharSet.Auto)]
		private static extern  bool CloseHandle(
			IntPtr handle);

		private const int LOGON32_LOGON_INTERACTIVE = 2;
		private const int LOGON32_PROVIDER_DEFAULT = 0;

		private void ImpersonateValidUser(string userName, string domain, string password)
		{
			WindowsIdentity tempWindowsIdentity = null;
			IntPtr token = IntPtr.Zero;
			IntPtr tokenDuplicate = IntPtr.Zero;

			try
			{
				if ( RevertToSelf() )
					if ( LogonUser(userName, domain, password, LOGON32_LOGON_INTERACTIVE,LOGON32_PROVIDER_DEFAULT, ref token ) != 0 )
						if ( DuplicateToken( token, 2, ref tokenDuplicate ) != 0 )
						{
							tempWindowsIdentity = new WindowsIdentity( tokenDuplicate );
							impersonationContext = tempWindowsIdentity.Impersonate();
						}
						else
							throw new Win32Exception( Marshal.GetLastWin32Error() );
					else
						throw new Win32Exception( Marshal.GetLastWin32Error() );
				else
					throw new Win32Exception( Marshal.GetLastWin32Error() );
			}
			finally
			{
				if ( token!= IntPtr.Zero )
					CloseHandle( token );
				if ( tokenDuplicate!=IntPtr.Zero )
					CloseHandle( tokenDuplicate );
			}
		}

		private void UndoImpersonation()
		{
			if ( impersonationContext!=null )
				impersonationContext.Undo();
		}
    }
}
