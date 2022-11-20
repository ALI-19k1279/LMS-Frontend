﻿using LMS.DTOS.Announcements;
using LMS.Models;
using LMS.DTOS.FileDto;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Services.Announcements
{
    public interface IAnnouncementService
    {
        public Task<List<AnnouncementResponse>> getAnnouncementsOfClass(int classId , string token ,string roleType);
        public Task<bool> addAnnouncementsOfClassAsync(string id,string token,AddAnnouncementDTO dto, List<IFormFile> fileToUpload);

    }
}
