using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MathAppApi.Models;
using MathAppApi.Services;
using MathAppApi.Data;

namespace MathAppApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LessonsController : ControllerBase
    {

        private readonly LessonService _lessonService;

        public LessonsController(LessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet]
        public IEnumerable<Lesson> GetAll()
        {
            return _lessonService.GetAllLessons();
        }
    }
}
