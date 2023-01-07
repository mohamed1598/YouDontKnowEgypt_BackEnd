﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using YouDontKnowEgypt.Models;

namespace YouDontKnowEgypt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        YouDontKnowEgyptContext db;

        public UploadController(YouDontKnowEgyptContext db)
        {
            this.db = db;
        }

        [HttpPost("{id:int}"), DisableRequestSizeLimit]
        public IActionResult Upload(int id)
        {
            LocationImage locimgs = new LocationImage();
            locimgs.LocationId = id;

            try
            {

                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                    Guid guid = Guid.NewGuid();
                    fileName = guid + fileName;
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    locimgs.ImagePath = fileName;

                    db.LocationImages.Add(locimgs);
                    db.SaveChanges();
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");

            }
        }
        [HttpPost("Hotel/{id:int}"), DisableRequestSizeLimit]
        public IActionResult UploadForHotel(int id)
        {
            HotelsImage hotelImage = new HotelsImage();
            hotelImage.HotelId = id;

            try
            {

                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                    Guid guid = Guid.NewGuid();
                    fileName = guid + fileName;
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    hotelImage.ImagePath = fileName;

                    db.HotelsImages.Add(hotelImage);
                    db.SaveChanges();
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");

            }
        }
    }
}
