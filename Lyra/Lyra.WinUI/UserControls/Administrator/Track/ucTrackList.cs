﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Track
{
    public partial class ucTrackList : UserControl
    {
        private readonly APIService _apiService = new APIService("Track");
        
        public ucTrackList()
        {
            InitializeComponent();
        }

        private async void ucTrackList_Load(object sender, EventArgs e)
        {
            var list = await _apiService.Get<List<Model.Track>>(null);
            dgvTracks.DataSource = list;
        }

        private void btnEditTrack_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvTracks.CurrentRow.Cells["ID"].Value);

            var uc = new ucTrackUpsert(ID);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private async void btnDeleteTrack_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTracks.CurrentRow.Cells["ID"].Value);
            await _apiService.Delete<dynamic>(id);
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            var uc = new ucTrackUpsert();

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        
    }
}