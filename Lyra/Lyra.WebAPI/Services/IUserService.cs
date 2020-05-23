﻿using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IUserService : ICRUDService<Model.User, UserSearchRequest, UserInsertRequest, UserUpdateRequest>
    {
        Task<Model.User> Authenticate(UserAuthenticationRequest request);
        Task<Model.User> SignUp(UserInsertRequest request);
        Task<List<Model.Track>> GetFavouriteTracks(int id);
        Task<List<Model.Album>> GetFavouriteAlbums(int id);
        Task<List<Model.Artist>> GetFavouriteArtists(int id);
        Task<List<Model.UserActivityTrack>> GetActivityTracks(int id);
        Task<List<Model.UserActivityAlbum>> GetActivityAlbums(int id);
        Task<List<Model.UserActivityArtist>> GetActivityArtists(int id);
        Task<List<Model.UserActivityPlaylist>> GetActivityPlaylists(int id);
    }
}
