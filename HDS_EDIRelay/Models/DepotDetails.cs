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
using System.IO;
using System.Net.FtpClient;

namespace HDS_EDIRelay.Models
{
    public class DepotDetails
    {
        public string
            _execution_path;

        public int
            _Timer;
        public bool
            _Autostart;

        public bool
            _ToFTP_Enabled,
            _ToNetPath_Enabled,
            _ToLocalPath_Enabled;

        public string
            _Depot_FTPHost,
            _Depot_Username,
            _Depot_Password,
            _Depot_EDI_Path,
            _Depot_PO_Path,
            _Depot_Extension;

        private FtpClient
            _ftpcli;

        public DepotDetails(string execution_path)
        {
            this._execution_path = execution_path;
        }

        public bool ParseConfig(out bool errstat, out string errmsg)
        {
            errstat = false;
            errmsg = string.Empty;

            try
            {
                using (StreamReader srdConfigFile = new StreamReader(Path.Combine(_execution_path, @"Config\Depot\config.ini")))
                {
                    string line;
                    while ((line = srdConfigFile.ReadLine()) != null)
                    {
                        string key = string.Empty;
                        string value = string.Empty;

                        // skip comments
                        if (line != null && line.Length > 0 && line.Substring(0, 1) != "#")
                            if (line.Substring(0, 1) == "[")
                                key = line.Substring(1, line.IndexOf("]") - 1).Trim();

                        if (string.IsNullOrEmpty(key) == false)
                            if (line != null && line.Length > 0 && line.Substring(0, 1) != "#")
                                value = line.Substring(line.IndexOf("=") + 1, (line.IndexOf(";") - line.IndexOf("=")) - 1).Trim();

                        switch (key)
                        {
                            case "Timer":
                                this._Timer = int.Parse(value);
                                break;
                            case "Autostart":
                                if (value == "1")
                                    this._Autostart = true;
                                else
                                    this._Autostart = false;
                                break;

                            case "ToFTP_Enabled":
                                if (value == "1")
                                    this._ToFTP_Enabled = true;
                                else
                                    this._ToFTP_Enabled = false;
                                break;
                            case "ToNetPath_Enabled":
                                if (value == "1")
                                    this._ToNetPath_Enabled = true;
                                else
                                    this._ToNetPath_Enabled = false;
                                break;
                            case "ToLocalPath_Enabled":
                                if (value == "1")
                                    this._ToLocalPath_Enabled = true;
                                else
                                    this._ToLocalPath_Enabled = false;
                                break;

                            case "Depot_FTPHost":
                                this._Depot_FTPHost = value;
                                break;
                            case "Depot_Username":
                                this._Depot_Username = value;
                                break;
                            case "Depot_Password":
                                this._Depot_Password = value;
                                break;
                            case "Depot_EDI_Path":
                                this._Depot_EDI_Path = value;
                                break;
                            case "Depot_PO_Path":
                                this._Depot_PO_Path = value;
                                break;
                            case "Depot_Extension":
                                this._Depot_Extension = value;
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = "Error parsing config file, " + ex.Message;

                return (false);
            }

            return (true);
        }

        public void UpdateFields(int Timer, bool Autostart, bool ToFTP_Enabled, bool ToNetPath_Enabled, bool ToLocalPath_Enabled, string Depot_FTPHost,
            string Depot_Username, string Depot_Password, string Depot_EDI_Path, string Depot_PO_Path, string Depot_Extension)
        {
           this._Timer = Timer;
           this._Autostart = Autostart;
           this._ToFTP_Enabled = ToFTP_Enabled;
           this._ToNetPath_Enabled = ToNetPath_Enabled;
           this._ToLocalPath_Enabled = ToLocalPath_Enabled;
           this._Depot_FTPHost = Depot_FTPHost;
           this._Depot_Username = Depot_Username;
           this._Depot_Password = Depot_Password;
           this._Depot_EDI_Path = Depot_EDI_Path;
           this._Depot_PO_Path = Depot_PO_Path;
           this._Depot_Extension = Depot_Extension;
        }

        public bool UpdateConfigFile(out bool errstat, out string errmsg)
        {
            errstat = false;
            errmsg = string.Empty;

            try
            {
                List<string> lstFinal = new List<string>();

                using (StreamReader srdConfigFile = new StreamReader(Path.Combine(_execution_path, @"Config\Depot\config.ini")))
                {
                    string line;
                    while ((line = srdConfigFile.ReadLine()) != null)
                    {
                        string key = string.Empty;

                        // skip comments
                        if (line != null && line.Length > 0 && line.Substring(0, 1) != "#")
                            if (line.Substring(0, 1) == "[")
                                key = line.Substring(1, line.IndexOf("]") - 1).Trim();

                        switch (key)
                        {
                            case "Timer":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Timer));
                                break;
                            case "Autostart":
                                if (this._Autostart == true)
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "1"));
                                else
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "0"));
                                break;

                            case "ToFTP_Enabled":
                                if (this._ToFTP_Enabled == true)
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "1"));
                                else
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "0"));
                                break;
                            case "ToNetPath_Enabled":
                                if (this._ToNetPath_Enabled == true)
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "1"));
                                else
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "0"));
                                break;
                            case "ToLocalPath_Enabled":
                                if (this._ToLocalPath_Enabled == true)
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "1"));
                                else
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "0"));
                                break;

                            case "Depot_FTPHost":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Depot_FTPHost));
                                break;
                            case "Depot_Username":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Depot_Username));
                                break;
                            case "Depot_Password":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Depot_Password));
                                break;
                            case "Depot_EDI_Path":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Depot_EDI_Path));
                                break;
                            case "Depot_PO_Path":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Depot_PO_Path));
                                break;
                            case "Depot_Extension":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Depot_Extension));
                                break;

                            default:
                                lstFinal.Add(line);
                                break;
                        }
                    }
                }

                using (StreamWriter swrConfigFile = new StreamWriter(Path.Combine(_execution_path, @"Config\Depot\config.ini"), false))
                {
                    foreach (string line in lstFinal)
                    {
                        swrConfigFile.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = ex.Message;

                return (false);
            }

            return (true);
        }

        public bool FetchDepot_EDIFiles(out bool errstat, out string errmsg)
        {
            errstat = false;
            errmsg = string.Empty;

            try
            {
                if (Directory.Exists(Path.Combine(_execution_path, @"Cache\EDI")) == false)
                    throw new Exception("Cache Directory not found for EDI files");

                using (_ftpcli = new FtpClient())
                {
                    _ftpcli.Host = this._Depot_FTPHost;
                    _ftpcli.Credentials = new System.Net.NetworkCredential(this._Depot_Username, this._Depot_Password);
                    _ftpcli.Connect();

                    int iCounter = 0;

                    char[] charSplit = { ',' };
                    string[] arrExt = this._Depot_Extension.Split(charSplit);
                    foreach (FtpListItem item in _ftpcli.GetListing(this._Depot_EDI_Path))
                    {
                        bool bCopyFile = false;

                        // determine copy status
                        if (string.IsNullOrEmpty(this._Depot_Extension))
                            bCopyFile = true;
                        else
                            foreach (string strExt in arrExt)
                                if (string.Equals(strExt, Path.GetExtension(item.Name)))
                                    bCopyFile = true;

                        // good for copy file
                        if (bCopyFile)
                        {
                            using (Stream istream = _ftpcli.OpenRead(item.FullName))
                            {
                                try
                                {
                                    using (FileStream writeStream = new FileStream(Path.Combine(_execution_path, @"Cache\EDI\" + item.Name), FileMode.Create))
                                    {
                                        int Length = 2048;
                                        Byte[] buffer = new Byte[Length];
                                        int bytesRead = istream.Read(buffer, 0, Length);
                                        while (bytesRead > 0)
                                        {
                                            writeStream.Write(buffer, 0, bytesRead);
                                            bytesRead = istream.Read(buffer, 0, Length);
                                        }
                                    }

                                    // delete file
                                    _ftpcli.DeleteFile(item.FullName);
                                }
                                finally
                                {
                                    istream.Close();
                                }
                            }

                            iCounter += 1;
                        }

                    }

                    _ftpcli.Disconnect();
                }
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = ex.Message;

                return (false);
            }

            return (true);
        }

        public void UploadDepot_POFiles(out bool errstat, out string errmsg, out int totalsent)
        {
            errstat = false;
            errmsg = string.Empty;
            totalsent = 0;

            try
            {
                using (_ftpcli = new FtpClient())
                {
                    _ftpcli.Host = this._Depot_FTPHost;
                    _ftpcli.Credentials = new System.Net.NetworkCredential(this._Depot_Username, this._Depot_Password);
                    _ftpcli.Connect();

                    string[] dirs = Directory.GetFiles(Path.Combine(_execution_path, @"Cache\PO"), "*.*");

                    foreach (string file in dirs)
                    {
                        using (var fileStream = File.OpenRead(file))
                        {
                            using (var ftpStream = _ftpcli.OpenWrite(string.Format("{0}/{1}", this._Depot_PO_Path, Path.GetFileName(file))))
                            {
                                var buffer = new byte[8 * 1024];
                                int count;
                                while ((count = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    ftpStream.Write(buffer, 0, count);
                                }
                            }
                        }

                        // delete local file
                        File.Delete(Path.Combine(_execution_path, @"Cache\PO\" + Path.GetFileName(file)));

                        totalsent += 1;
                    }

                }
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = ex.Message;
            }

            return;
        }
    }
}
