using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurveyApp.Entities;
using SurveyApp.Helpers;
using SurveyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApp.Controllers
{
    [Route("api/[controller]")]
    public class SurveyController : Controller
    {
        private ApplicationDbContext _context;

        public SurveyController(ApplicationDbContext context)
        {
            this._context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var surveys = await this._context.Surveys.OrderByDescending(x => x.Id).ToListAsync();
            return ResponseHelper.Ok(surveys);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]SurveyModel surveyModel)
        {
            Survey survey = new Survey()
            {
                CompanyName = surveyModel.CompanyName,
                FullName = surveyModel.FullName,
                Email = surveyModel.Email,
                PhoneNumber = surveyModel.PhoneNumber,
                TrackAndTraceModules = surveyModel.TrackAndTraceModules,
                WarehouseModules = surveyModel.WarehouseModules,
                DataAnalytics = surveyModel.DataAnalytics,
            };

            try
            {
                this._context.Add(survey);
                await this._context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return ResponseHelper.BadRequest(ex.Message);
            }
            return ResponseHelper.Ok(survey);
        }
    }
}
