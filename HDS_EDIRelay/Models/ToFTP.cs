﻿/* Name: HDS - Exporter EDI Relay
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
using System.Net.FtpClient;
using System.IO;
using System.Reflection;

namespace HDS_EDIRelay.Models
{
    public class ToFTP
    {
        public string
            _execution_path;

        public string
            _Dest_FTPHost,
            _Dest_Username,
            _Dest_Password,
            _Dest_Path,
            _Dest_Extension,

            _Dest_PO_Path,
            _Dest_PO_DepotNames;

        public bool
            _Dest_PO,
            _Dest_PO_All_Flag,
            _Dest_PO_Depot_Flag;
        
        private FtpClient
            _ftpcli;

        public ToFTP(string execution_path)
        {
            this._execution_path = execution_path;
        }

        //
        // Config file

        public bool ParseConfig(out bool errstat, out string errmsg)
        {
            errstat = false;
            errmsg = string.Empty;

            try
            {
                using (StreamReader srdConfigFile = new StreamReader(Path.Combine(_execution_path,@"Config\ToFTP\config.ini")))
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
                            case "Dest_FTPHost":
                                this._Dest_FTPHost = value;
                                break;
                            case "Dest_Username":
                                this._Dest_Username = value;
                                break;
                            case "Dest_Password":
                                this._Dest_Password = value;
                                break;
                            case "Dest_Path":
                                this._Dest_Path = value;
                                break;
                            case "Dest_Extension":
                                this._Dest_Extension = value;
                                break;
                            case "Dest_PO":
                                if (value == "1")
                                    this._Dest_PO = true;
                                else
                                    this._Dest_PO = false;
                                break;
                            case "Dest_PO_Path":
                                this._Dest_PO_Path = value;
                                break;

                            case "Dest_PO_All_Flag":
                                if (value == "1")
                                    this._Dest_PO_All_Flag = true;
                                else
                                    this._Dest_PO_All_Flag = false;
                                break;
                            case "Dest_PO_Depot_Flag":
                                if (value == "1")
                                    this._Dest_PO_Depot_Flag = true;
                                else
                                    this._Dest_PO_Depot_Flag = false;
                                break;
                            case "Dest_PO_DepotNames":
                                this._Dest_PO_DepotNames = value;
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

        public void UpdateFields(string Dest_FTPHost, string Dest_Username, string Dest_Password, string Dest_Path, string Dest_Extension, string Dest_PO_Path,
            string Dest_PO_DepotNames, bool Dest_PO, bool Dest_PO_All_Flag, bool Dest_PO_Depot_Flag)
        {
           this._Dest_FTPHost = Dest_FTPHost;
           this._Dest_Username = Dest_Username;
           this._Dest_Password = Dest_Password;
           this._Dest_Path = Dest_Path;
           this._Dest_Extension = Dest_Extension;
           this._Dest_PO_Path = Dest_PO_Path;
           this._Dest_PO_DepotNames = Dest_PO_DepotNames;
           this._Dest_PO = Dest_PO;
           this._Dest_PO_All_Flag = Dest_PO_All_Flag;
           this._Dest_PO_Depot_Flag = Dest_PO_Depot_Flag;
        }

        public bool UpdateConfigFile(out bool errstat, out string errmsg)
        {
            errstat = false;
            errmsg = string.Empty;

            try
            {
                List<string> lstFinal = new List<string>();

                using (StreamReader srdConfigFile = new StreamReader(Path.Combine(_execution_path, @"Config\ToFTP\config.ini")))
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
                            case "Dest_FTPHost":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Dest_FTPHost));
                                break;
                            case "Dest_Username":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Dest_Username));
                                break;
                            case "Dest_Password":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Dest_Password));
                                break;
                            case "Dest_Path":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Dest_Path));
                                break;
                            case "Dest_Extension":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Dest_Extension));
                                break;
                            case "Dest_PO":
                                if (this._Dest_PO == true)
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "1"));
                                else
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "0"));
                                break;
                            case "Dest_PO_Path":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Dest_PO_Path));
                                break;

                            case "Dest_PO_All_Flag":
                                if (this._Dest_PO_All_Flag == true)
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "1"));
                                else
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "0"));
                                break;
                            case "Dest_PO_Depot_Flag":
                                if (this._Dest_PO_Depot_Flag == true)
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "1"));
                                else
                                    lstFinal.Add(String.Format("[{0}]={1};", key, "0"));
                                break;
                            case "Dest_PO_DepotNames":
                                lstFinal.Add(String.Format("[{0}]={1};", key, this._Dest_PO_DepotNames));
                                break;

                            default:
                                lstFinal.Add(line);
                                break;
                        }
                    }
                }

                using (StreamWriter swrConfigFile = new StreamWriter(Path.Combine(_execution_path, "Config/ToFTP/config.ini"), false))
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

        //
        // EDI Files

        public void UploadDest_EDIFiles(out bool errstat, out string errmsg, out int totalsent)
        {
            errstat = false;
            errmsg = string.Empty;
            totalsent = 0;

            try 
            {
                using (_ftpcli = new FtpClient())
                {
                    _ftpcli.Host = this._Dest_FTPHost;
                    _ftpcli.Credentials = new System.Net.NetworkCredential(this._Dest_Username, this._Dest_Password);
                    _ftpcli.Connect();

                    string[] dirs = Directory.GetFiles(Path.Combine(_execution_path, @"Cache\EDI"), "*.*");

                    foreach (string file in dirs)
                    {
                        using (var fileStream = File.OpenRead(file))
                        {
                            using (var ftpStream = _ftpcli.OpenWrite(string.Format("{0}/{1}", this._Dest_Path, Path.GetFileName(file))))
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
                        File.Delete(Path.Combine(_execution_path, @"Cache\EDI\" + Path.GetFileName(file)));

                        totalsent += 1;
                    }
   
                }
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = ex.Message;
            }
        }

        //
        // PO Files

        public bool FetchDest_POFiles(out bool errstat, out string errmsg)
        {
            errstat = false;
            errmsg = string.Empty;

            StringBuilder result = new StringBuilder();

            try
            {
                if (Directory.Exists(Path.Combine(_execution_path, @"Cache\PO")) == false)
                    throw new Exception("PO Directory not found for PO files");

                using (_ftpcli = new FtpClient())
                {
                    _ftpcli.Host = this._Dest_FTPHost;
                    _ftpcli.Credentials = new System.Net.NetworkCredential(this._Dest_Username, this._Dest_Password);
                    _ftpcli.Connect();

                    int iCounter = 0;

                    char[] charSplit = { ',' };
                    string[] arrExt = this._Dest_Extension.Split(charSplit);

                    string datemask = DateTime.Now.ToString("dd_MM_yyyy");

                    // 4 days back
                    DateTime podatebound = DateTime.Today.AddDays(-4);

                    foreach (FtpListItem item in _ftpcli.GetListing(this._Dest_PO_Path, FtpListOption.Modify))
                    {
                        // check if po is already downloaded
                        if (this.checkPO_Marked(out errstat, out errmsg, datemask, Path.GetFileName(item.Name)) == false)
                        {
                            bool bCopyFile = false;

                            // determine copy status
                            if (string.IsNullOrEmpty(this._Dest_Extension))
                                if (item.Modified >= podatebound.Date)
                                    bCopyFile = true;
                            else
                                foreach (string strExt in arrExt)
                                    if (string.Equals(strExt, Path.GetExtension(item.Name)))
                                        if (item.Modified >= podatebound.Date)
                                            bCopyFile = true;

                            // good for copy file
                            if (bCopyFile)
                            {
                                using (Stream istream = _ftpcli.OpenRead(item.FullName))
                                {
                                    try
                                    {
                                        using (FileStream writeStream = new FileStream(Path.Combine(_execution_path, @"Cache\PO\" + item.Name), FileMode.Create))
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

                                        // delete file -- lets not delete the clients PO files
                                        //_ftpcli.DeleteFile(item.FullName);

                                        // after local copy, do depot search
                                        if (this.checkPO_DepotNames(out errstat, out errmsg, Path.Combine(_execution_path, @"Cache\PO\" + item.Name)))
                                            iCounter += 1;
                                    }
                                    finally
                                    {
                                        istream.Close();
                                    }
                                }
                            }

                            // mark po file as downloaded
                            this.markPO_Downloaded(out errstat, out errmsg, datemask, item.Name);
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

        private bool checkPO_Marked(out bool errstat, out string errmsg, string datemask, string filename)
        {
            errstat = false;
            errmsg = string.Empty;

            bool result = false;

            try
            {
                string fqp_pomarkfile = Path.Combine(this._execution_path, @"Marked\PO");
                fqp_pomarkfile = Path.Combine(fqp_pomarkfile, datemask);
                fqp_pomarkfile = Path.Combine(fqp_pomarkfile, filename);

                if (File.Exists(fqp_pomarkfile))
                    result = true;
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = ex.Message;
            }

            return (result);
        }

        private void markPO_Downloaded(out bool errstat, out string errmsg, string datemask, string filename)
        {
            errstat = false;
            errmsg = string.Empty;

            try
            {
                string fqp_datemaskpath = Path.Combine(this._execution_path, @"Marked\PO");
                fqp_datemaskpath = Path.Combine(fqp_datemaskpath, datemask);

                if (Directory.Exists(fqp_datemaskpath) == false)
                    Directory.CreateDirectory(fqp_datemaskpath);

                using (StreamWriter swrFile = File.CreateText(Path.Combine(fqp_datemaskpath, filename)))
                {
                    swrFile.Close();
                }
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = ex.Message;
            }

            return;
        }

        private bool checkPO_DepotNames(out bool errstat, out string errmsg, string fqp_POfile)
        {
            errstat = false;
            errmsg = string.Empty;
            bool result = false;

            char[] charSplit = { ',' };
            string[] arrDepotNames = this._Dest_PO_DepotNames.Split(charSplit);

            try
            {
                if (string.IsNullOrEmpty(this._Dest_PO_DepotNames) == false)
                {
                    using (StreamReader srdrPO = new StreamReader(fqp_POfile))
                    {
                        string poline = string.Empty;
                        bool foundOH = false;
                        bool foundname = false;

                        while (foundOH == false && (poline = srdrPO.ReadLine()) != null)
                        {
                            // found file HEADER
                            if (string.Equals(poline.Trim().Substring(0, 2), "OH", StringComparison.OrdinalIgnoreCase))
                            {
                                foundOH = true;

                                foreach (string depotname in arrDepotNames)
                                    if (string.Equals(depotname, poline.Substring(160, 7).Trim(), StringComparison.OrdinalIgnoreCase))
                                        foundname = true;
                            }
                        }

                        srdrPO.Close();

                        // delete DP Depot mismatch PO files
                        if (foundname == false)
                            File.Delete(fqp_POfile);
                        else
                            result = true;
                    }
                }
                else
                    result = true;
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = ex.Message;
            }

            return (result);
        }
    }

}
