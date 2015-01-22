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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using HDS_EDIRelay.Models;

namespace HDS_EDIRelay
{
    public partial class frmMain : Form
    {
        private DepotDetails
            objDepotDetails;
        private ToFTP
            objToFTP;
        private ToNetPath
            objToNetPath;
        private ToLocalPath
            objToLocalPath;

        private bool
            _ToFTP_Enabled,
            _ToNetPath_Enabled,
            _ToLocalPath_Enabled;

        int
            _timeremaining;

        //
        // Public Functions

        public frmMain()
        {
            InitializeComponent();
        }

        //
        // Private Functions

        private void Populate_Fields()
        {
            nudTimer.Value = objDepotDetails._Timer;

            if (this.objDepotDetails._Autostart)
                chkAutoStart.Checked = true;
            else
                chkAutoStart.Checked = false;

            if (this.objDepotDetails._ToFTP_Enabled)
                chkA_Enabled.Checked = true;
            else
                chkA_Enabled.Checked = false;

            if (this.objDepotDetails._ToNetPath_Enabled)
                chkB_Enabled.Checked = true;
            else
                chkB_Enabled.Checked = false;

            if (this.objDepotDetails._ToLocalPath_Enabled)
                chkC_Enabled.Checked = true;
            else
                chkC_Enabled.Checked = false;

            /* Depot Details */
            /*****************/
            txtA_Depot_Host.Text = this.objDepotDetails._Depot_FTPHost;
            txtA_Depot_Username.Text = this.objDepotDetails._Depot_Username;
            txtA_Depot_Password.Text = this.objDepotDetails._Depot_Password;
            txtA_Depot_EDIPath.Text = this.objDepotDetails._Depot_EDI_Path;
            txtA_Depot_FileExt.Text = this.objDepotDetails._Depot_Extension;
            txtA_Depot_POPath.Text = this.objDepotDetails._Depot_PO_Path;

            /* ToFTP Details */
            /*****************/
            txtA_Dest_Host.Text = this.objToFTP._Dest_FTPHost;
            txtA_Dest_Username.Text = this.objToFTP._Dest_Username;
            txtA_Dest_Password.Text = this.objToFTP._Dest_Password;
            txtA_Dest_EDIPath.Text = this.objToFTP._Dest_Path;
            txtA_Dest_FileExt.Text = this.objToFTP._Dest_Extension;
            if (this.objToFTP._Dest_PO)
                chkA_Dest_FetchPO.Checked = true;
            else
                chkA_Dest_FetchPO.Checked = false;
            txtA_Dest_POPath.Text = this.objToFTP._Dest_PO_Path;
            if (this.objToFTP._Dest_PO_All_Flag)
                rdoA_Dest_PO_All.Checked = true;
            else
                rdoA_Dest_PO_All.Checked = false;
            if (this.objToFTP._Dest_PO_Depot_Flag)
                rdoA_Dest_PO_DepotName.Checked = true;
            else
                rdoA_Dest_PO_DepotName.Checked = false;
            txtA_Dest_PO_DepotNames.Text = this.objToFTP._Dest_PO_DepotNames;
            
            this.chkA_Dest_FetchPO_CheckedChanged(null, null);

            /* ToNetPath Details */
            /*********************/
            txtB_Dest_Host.Text = this.objToNetPath._Dest_Host;
            txtB_Dest_Username.Text = this.objToNetPath._Dest_Username;
            txtB_Dest_Password.Text = this.objToNetPath._Dest_Password;
            txtB_Dest_ServerName.Text = this.objToNetPath._Dest_ServerName;
            txtB_Dest_EDIPath.Text = this.objToNetPath._Dest_Path;
            txtB_Dest_FileExt.Text = this.objToNetPath._Dest_Extension;
            if (this.objToNetPath._Dest_PO)
                chkB_Dest_FetchPO.Checked = true;
            else
                chkB_Dest_FetchPO.Checked = false;
            txtB_Dest_POPath.Text = this.objToNetPath._Dest_PO_Path;
            if (this.objToNetPath._Dest_PO_All_Flag)
                rdoB_Dest_PO_All.Checked = true;
            else
                rdoB_Dest_PO_All.Checked = false;
            if (this.objToNetPath._Dest_PO_Depot_Flag)
                rdoB_Dest_PO_DepotName.Checked = true;
            else
                rdoB_Dest_PO_DepotName.Checked = false;
            txtB_Dest_PO_DepotNames.Text = this.objToNetPath._Dest_PO_DepotNames;

            this.chkB_Dest_FetchPO_CheckedChanged(null, null);

            /* ToLocalPath Details */
            /***********************/
            txtC_Dest_EDIPath.Text = this.objToLocalPath._Dest_Path;
            txtC_Dest_FileExt.Text = this.objToLocalPath._Dest_Extension;
            if (this.objToLocalPath._Dest_PO)
                chkC_Dest_FetchPO.Checked = true;
            else
                chkC_Dest_FetchPO.Checked = false;
            txtC_Dest_POPath.Text = this.objToLocalPath._Dest_PO_Path;
            if (this.objToLocalPath._Dest_PO_All_Flag)
                rdoC_Dest_PO_All.Checked = true;
            else
                rdoC_Dest_PO_All.Checked = false;
            if (this.objToLocalPath._Dest_PO_Depot_Flag)
                rdoC_Dest_PO_DepotName.Checked = true;
            else
                rdoC_Dest_PO_DepotName.Checked = false;
            txtC_Dest_PO_DepotNames.Text = this.objToLocalPath._Dest_PO_DepotNames;

            this.chkC_Dest_FetchPO_CheckedChanged(null, null);
        }

        private void updateAllObjFields()
        {
            /* Depot Details */
            /*****************/
            this.objDepotDetails.UpdateFields
                (
                    (int)nudTimer.Value,
                    chkAutoStart.Checked,
                    chkA_Enabled.Checked,
                    chkB_Enabled.Checked,
                    chkC_Enabled.Checked,
                    txtA_Depot_Host.Text.Trim(),
                    txtA_Depot_Username.Text,
                    txtA_Depot_Password.Text,
                    txtA_Depot_EDIPath.Text.Trim(),
                    txtA_Depot_POPath.Text.Trim(),
                    txtA_Depot_FileExt.Text.Trim()
                );

            /* ToFTP Details */
            /*****************/
            this.objToFTP.UpdateFields
                (
                    txtA_Dest_Host.Text,
                    txtA_Dest_Username.Text,
                    txtA_Dest_Password.Text,
                    txtA_Dest_EDIPath.Text.Trim(),
                    txtA_Dest_FileExt.Text.Trim(),
                    txtA_Dest_POPath.Text.Trim(),
                    txtA_Dest_PO_DepotNames.Text.Trim(),
                    chkA_Dest_FetchPO.Checked,
                    rdoA_Dest_PO_All.Checked,
                    rdoA_Dest_PO_DepotName.Checked
                );

            /* ToNetPath Details */
            /*********************/
            this.objToNetPath.UpdateFields
                (
                    txtB_Dest_Host.Text,
                    txtB_Dest_Username.Text,
                    txtB_Dest_Password.Text,
                    txtB_Dest_ServerName.Text.Trim(),
                    txtB_Dest_EDIPath.Text.Trim(),
                    txtB_Dest_FileExt.Text.Trim(),
                    txtB_Dest_POPath.Text.Trim(),
                    txtB_Dest_PO_DepotNames.Text.Trim(),
                    chkB_Dest_FetchPO.Checked,
                    rdoB_Dest_PO_All.Checked,
                    rdoB_Dest_PO_DepotName.Checked
                );

            /* ToLocalPath Details */
            /***********************/
            this.objToLocalPath.UpdateFields
                (
                    txtC_Dest_EDIPath.Text.Trim(),
                    txtC_Dest_FileExt.Text.Trim(),
                    txtC_Dest_POPath.Text.Trim(),
                    txtC_Dest_PO_DepotNames.Text.Trim(),
                    chkC_Dest_FetchPO.Checked,
                    rdoC_Dest_PO_All.Checked,
                    rdoC_Dest_PO_DepotName.Checked
                );
        }

        private void parseAllConfig(out bool errstat, out string errmsg)
        {
            errstat = false;
            errmsg = string.Empty;

            try
            {
                // parse depot config
                if (this.objDepotDetails.ParseConfig(out errstat, out errmsg) == false)
                    throw new Exception("Failed to parse Depot Details config file.");

                // parse toftp config
                if (this.objToFTP.ParseConfig(out errstat, out errmsg) == false)
                    throw new Exception("Failed to parse ToFTP config file.");

                // parse tonetpath config
                if (this.objToNetPath.ParseConfig(out errstat, out errmsg) == false)
                    throw new Exception("Failed to parse ToNetPath config file.");

                // parse tolocalpath config
                if (this.objToLocalPath.ParseConfig(out errstat, out errmsg) == false)
                    throw new Exception("Failed to parse ToLocalPath config file.");
            }
            catch (Exception ex)
            {
                errstat = true;
                errmsg = "Error parsing config files: " + ex.Message;
            }

            return;
        }

        private void EnableAllControls(bool bEnable)
        {
            if (bEnable)
            {
                // Depot
                foreach (Control ctrl in gbxDepot.Controls)
                    if (ctrl is TextBox)
                        ctrl.Enabled = true;

                // ToFTP
                foreach (Control ctrl in gbxA.Controls)
                    if (ctrl is TextBox || ctrl is CheckBox || ctrl is RadioButton)
                        ctrl.Enabled = true;

                // ToNetPath
                foreach (Control ctrl in gbxB.Controls)
                    if (ctrl is TextBox || ctrl is CheckBox || ctrl is RadioButton)
                        ctrl.Enabled = true;

                // ToLocalPath
                foreach (Control ctrl in gbxC.Controls)
                    if (ctrl is TextBox || ctrl is CheckBox || ctrl is RadioButton)
                        ctrl.Enabled = true;

                nudTimer.Enabled = true;
                chkA_Enabled.Enabled = true;
                chkB_Enabled.Enabled = true;
                chkC_Enabled.Enabled = true;

                this.chkA_Dest_FetchPO_CheckedChanged(null, null);
                this.chkB_Dest_FetchPO_CheckedChanged(null, null);
                this.chkC_Dest_FetchPO_CheckedChanged(null, null);
            }
            else
            {
                // Depot
                foreach (Control ctrl in gbxDepot.Controls)
                    if (ctrl is TextBox)
                        ctrl.Enabled = false;

                // ToFTP
                foreach (Control ctrl in gbxA.Controls)
                    if (ctrl is TextBox || ctrl is CheckBox || ctrl is RadioButton)
                        ctrl.Enabled = false;

                // ToNetPath
                foreach (Control ctrl in gbxB.Controls)
                    if (ctrl is TextBox || ctrl is CheckBox || ctrl is RadioButton)
                        ctrl.Enabled = false;

                // ToLocalPath
                foreach (Control ctrl in gbxC.Controls)
                    if (ctrl is TextBox || ctrl is CheckBox || ctrl is RadioButton)
                        ctrl.Enabled = false;

                nudTimer.Enabled = false;
                chkA_Enabled.Enabled = false;
                chkB_Enabled.Enabled = false;
                chkC_Enabled.Enabled = false;
            }
        }

        //
        // Widget Handlers

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // ToFTP
                this.objToFTP = new ToFTP(Path.GetDirectoryName(Application.ExecutablePath));
                // DepotDetails
                this.objDepotDetails = new DepotDetails(Path.GetDirectoryName(Application.ExecutablePath));
                // ToNetPath
                this.objToNetPath = new ToNetPath(Path.GetDirectoryName(Application.ExecutablePath));
                // ToLocalPath
                this.objToLocalPath = new ToLocalPath(Path.GetDirectoryName(Application.ExecutablePath));

                btnStart.Enabled = false;

                bool errstat;
                string errmsg;

                // parse all config files
                this.parseAllConfig(out errstat, out errmsg);

                //this._timeremaining = this.objDepotDetails._Timer * 60;
                // force first run
                this._timeremaining = 0;
                this.Populate_Fields();
                btnStart.Enabled = true;

                // switch to enabled tab
                if (this.objDepotDetails._ToFTP_Enabled)
                    tctrlMain.SelectedTab = tpgA_ToFTP;
                if (this.objDepotDetails._ToNetPath_Enabled)
                    tctrlMain.SelectedTab = tpgB_ToNetPath;
                if (this.objDepotDetails._ToLocalPath_Enabled)
                    tctrlMain.SelectedTab = tpgC_ToLocalPath;
            }
            catch (Exception ex)
            {
                UpdateLabel("Init error: " + ex.Message, Color.Red);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            {// Validation Check
                int ichecked = 0;

                ichecked += chkA_Enabled.Checked ? 1 : 0;
                ichecked += chkB_Enabled.Checked ? 1 : 0;
                ichecked += chkC_Enabled.Checked ? 1 : 0;
                
                if (ichecked == 0)
                    UpdateLabel("At least one 'Destination' upload option needs to be enabled", Color.Red);
                if (ichecked > 1)
                    UpdateLabel("Only one 'Destination' upload option can be enabled", Color.Red);

                if (ichecked != 1)
                    return;

                if (string.IsNullOrEmpty(txtA_Depot_Host.Text))
                {
                    UpdateLabel("Depot FTP 'Host' required", Color.Red);
                    return;
                }
                if (string.IsNullOrEmpty(txtA_Depot_Username.Text))
                {
                    UpdateLabel("Depot FTP 'Username' required", Color.Red);
                    return;
                }
                if (string.IsNullOrEmpty(txtA_Depot_Password.Text))
                {
                    UpdateLabel("Depot FTP 'Password' required", Color.Red);
                    return;
                }
                if (string.IsNullOrEmpty(txtA_Depot_EDIPath.Text))
                {
                    UpdateLabel("Depot FTP 'EDI Path (out)' required", Color.Red);
                    return;
                }

                if (nudTimer.Value <= 0)
                {
                    UpdateLabel("Timer number be greater than 0 minutes", Color.Red);
                    return;
                }
            }

            {// save config and reparse
                bool errstat;
                string errmsg;

                // Update all object fields
                this.updateAllObjFields();

                // Write to all config file
                if (this.objDepotDetails.UpdateConfigFile(out errstat, out errmsg) == false)
                    UpdateLabel("Error saving Depot Details config file: " + errmsg, Color.Red);
                if (!errstat && this.objToFTP.UpdateConfigFile(out errstat, out errmsg) == false)
                    UpdateLabel("Error saving ToFTP config file: " + errmsg, Color.Red);
                if (!errstat && this.objToNetPath.UpdateConfigFile(out errstat, out errmsg) == false)
                    UpdateLabel("Error saving ToNetPath config file: " + errmsg, Color.Red);
                if (!errstat && this.objToLocalPath.UpdateConfigFile(out errstat, out errmsg) == false)
                    UpdateLabel("Error saving ToLocalPath config file: " + errmsg, Color.Red);

                if (errstat)
                    return;
            }

            // disable all controls
            this.EnableAllControls(false);

            btnStart.Enabled = false;
            btnStop.Enabled = true;

            tmrFetch.Enabled = true;
            tmrFetch.Interval = 1000;

            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Online";

            // flag enabled option
            this._ToFTP_Enabled = false;
            this._ToNetPath_Enabled = false;
            this._ToLocalPath_Enabled = false;

            if (chkA_Enabled.Checked)
                this._ToFTP_Enabled = true;
            if (chkB_Enabled.Checked)
                this._ToNetPath_Enabled = true;
            if (chkC_Enabled.Checked)
                this._ToLocalPath_Enabled = true;

            tmrFetch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // enable all controls
            this.EnableAllControls(true);

            btnStop.Enabled = false;
            btnStart.Enabled = true;

            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "Offline";

            tmrFetch.Enabled = false;
            tmrFetch.Stop();
        }

        // async label update
        private void UpdateLabel(string text, Color color)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblInformation.Text = text;
                    lblInformation.ForeColor = color;
                });
            }
            else
            {
                lblInformation.Text = text;
            }
        }

        private void tmrFetch_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this._timeremaining > 0)
                {
                    this._timeremaining--;
                    lblTimeRemaining.Text = this._timeremaining + " sec remaining";
                }
                else
                {
                    // prevent execution overlap
                    tmrFetch.Stop();
                    this._timeremaining = this.objDepotDetails._Timer * 60;

                    UpdateLabel("Looking for Depot EDI files ...", Color.Green);

                    bool errstat;
                    string errmsg;
                    int totalsent_edi = 0;
                    int totalsent_po = 0;

                    // TODO - Threading
                    //Thread oThread = new Thread(delegate(object unused) { objDepotDetails.fetchDepot_EDIFiles(out errstat, out errmsg); });
                    //oThread.Start();

                    // EDI fetch
                    if (this.objDepotDetails.FetchDepot_EDIFiles(out errstat, out errmsg))
                    {
                        UpdateLabel("Uploading new Depot EDI files ...", Color.Green);

                        if (this._ToFTP_Enabled)
                            this.objToFTP.UploadDest_EDIFiles(out errstat, out errmsg, out totalsent_edi);
                        else if (this._ToNetPath_Enabled)
                            this.objToNetPath.UploadDest_EDIFiles(out errstat, out errmsg, out totalsent_edi);
                        else if (this._ToLocalPath_Enabled)
                            this.objToLocalPath.UploadDest_EDIFiles(out errstat, out errmsg, out totalsent_edi);
                        else
                             throw new Exception("No valid enable option found (EDI) ?");

                        if (errstat)
                            UpdateLabel("Error uploading EDI files: " + errmsg, Color.Red);
                        else
                            UpdateLabel(totalsent_edi + " EDI files uploaded.", Color.Green);
                    }
                    else
                    {
                        UpdateLabel("Error fetching Depot EDI files. Invalid Host details or no Internet connection: " + errmsg, Color.Red);
                    }

                    // PO fetch
                    if (!errstat && (this.objToFTP._Dest_PO || this.objToNetPath._Dest_PO || this.objToLocalPath._Dest_PO))
                    {
                        UpdateLabel("Looking for Packhouse railing files ...", Color.Green);

                        if (this._ToFTP_Enabled && this.objToFTP._Dest_PO)
                            this.objToFTP.FetchDest_POFiles(out errstat, out errmsg);
                        else if (this._ToNetPath_Enabled && this.objToNetPath._Dest_PO)
                            this.objToNetPath.FetchDest_POFiles(out errstat, out errmsg);
                        else if (this._ToLocalPath_Enabled && this.objToLocalPath._Dest_PO)
                            this.objToLocalPath.FetchDest_POFiles(out errstat, out errmsg);
                        else
                            throw new Exception("No valid enable option found (PO) ?");

                        // upload PO file to Depot
                        if (!errstat)
                        {
                            UpdateLabel("Uploading new Packhouse railing files to Depot ...", Color.Green);

                            this.objDepotDetails.UploadDepot_POFiles(out errstat, out errmsg, out totalsent_po);

                            if (errstat)
                                UpdateLabel("Error uploading PO files: " + errmsg, Color.Red);
                            else
                                UpdateLabel(totalsent_po + " PO files uploaded.", Color.Green);
                        }
                    }

                    if (totalsent_edi > 0 || totalsent_po > 0)
                        lblLastXmit.Text = string.Format("{0} EDI / {1} PO - {2}", totalsent_edi, totalsent_po, DateTime.Now.ToString("dd/MM hh:mm:ss"));

                    if (!errstat)
                        UpdateLabel(string.Format("{0} EDI files received. {1} PO file sent. No errors occured - {2}", 
                            totalsent_edi, totalsent_po, DateTime.Now.ToString("dd/MM hh:mm:ss")),
                            Color.Green);

                    tmrFetch.Start();
                }
            }
            catch (Exception ex)
            {
                // enable all controls
                this.EnableAllControls(true);

                UpdateLabel("System error attempting EDI/PO upload/download function: " + ex.Message, Color.Red);
            }
        }

        private void chkA_Dest_FetchPO_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA_Dest_FetchPO.Checked)
            {
                txtA_Dest_POPath.Enabled = true;
                rdoA_Dest_PO_All.Enabled = true;
                rdoA_Dest_PO_DepotName.Enabled = true;
                txtA_Dest_PO_DepotNames.Enabled = true;
                txtA_Dest_FileExt.Enabled = true;
            }
            else
            {
                txtA_Dest_POPath.Enabled = false;
                rdoA_Dest_PO_All.Enabled = false;
                rdoA_Dest_PO_DepotName.Enabled = false;
                txtA_Dest_PO_DepotNames.Enabled = false;
                txtA_Dest_FileExt.Enabled = false;
            }
        }

        private void chkB_Dest_FetchPO_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_Dest_FetchPO.Checked)
            {
                txtB_Dest_POPath.Enabled = true;
                rdoB_Dest_PO_All.Enabled = true;
                rdoB_Dest_PO_DepotName.Enabled = true;
                txtB_Dest_PO_DepotNames.Enabled = true;
                txtB_Dest_FileExt.Enabled = true;
            }
            else
            {
                txtB_Dest_POPath.Enabled = false;
                rdoB_Dest_PO_All.Enabled = false;
                rdoB_Dest_PO_DepotName.Enabled = false;
                txtB_Dest_PO_DepotNames.Enabled = false;
                txtB_Dest_FileExt.Enabled = false;
            }
        }

        private void chkC_Dest_FetchPO_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC_Dest_FetchPO.Checked)
            {
                txtC_Dest_POPath.Enabled = true;
                rdoC_Dest_PO_All.Enabled = true;
                rdoC_Dest_PO_DepotName.Enabled = true;
                txtC_Dest_PO_DepotNames.Enabled = true;
                txtC_Dest_FileExt.Enabled = true;
            }
            else
            {
                txtC_Dest_POPath.Enabled = false;
                rdoC_Dest_PO_All.Enabled = false;
                rdoC_Dest_PO_DepotName.Enabled = false;
                txtC_Dest_PO_DepotNames.Enabled = false;
                txtC_Dest_FileExt.Enabled = false;
            }
        }


    }
}
