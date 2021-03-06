﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.Helpers;
using Lyra.Model;
using Lyra.Model.Requests;

namespace Lyra.WinUI.UserControls.Administrator.Artist
{
    public partial class ucArtistList : UserControl
    {
        private readonly APIService _apiService = new APIService("Artist");
        private readonly List<string> _props = new List<string> { "ID", "Name" };
        private int _page { get; set; }
        private int _itemsPerPage { get; set; }
        public ucArtistList()
        {
            _page = 1;
            _itemsPerPage = 10;
            InitializeComponent();
        }

        private async void ucArtistList_Load(object sender, EventArgs e)
        {
            var request = new ArtistSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage
            };
            await LoadList(request);
        }

        private async Task LoadList(ArtistSearchRequest request)
        {
            var list = await _apiService.Get<List<Model.Track>>(request);

            if (list.Count > 0)
            {
                dgvArtists.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvArtists, list, _props);

                _page = request.Page;
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearch.Text)) && request.Page == 1)
            {
                dgvArtists.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvArtists, list, _props);

                _page = 1;
            }

            btnPageNumber.Text = Convert.ToString(_page);
        }

        #region Buttons

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            if(dgvArtists.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ID"].Value);
                PanelHelper.SwapPanels(this.Parent, this, new ucArtistUpsert(ID));
            }
        }

        private async void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            if(dgvArtists.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ID"].Value);
                await _apiService.Delete<dynamic>(ID);
                PanelHelper.SwapPanels(this.Parent, this, new ucArtistList());
            }
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucArtistUpsert());
        }

        

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new ArtistSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadList(request);
        }

        #endregion

        #region Pagination
        private async void btnNext_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new ArtistSearchRequest()
            {
                Page = _page + 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadList(request);
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_page > 1)
            {
                var search = Convert.ToString(txtSearch.Text);

                var request = new ArtistSearchRequest()
                {
                    Page = _page - 1,
                    ItemsPerPage = _itemsPerPage,
                    Name = search
                };

                await LoadList(request);
            }
        }

        #endregion
    }
}
