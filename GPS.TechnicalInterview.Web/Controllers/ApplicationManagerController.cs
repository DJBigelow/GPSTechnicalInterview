﻿using GPS.ApplicationManager.Data.Models;
using GPS.ApplicationManager.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GPS.ApplicationManager.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationManagerController : ControllerBase
    {
        private readonly ILogger<ApplicationManagerController> _logger;

        private readonly ILoanApplicationRepository _loanAppRepository;

        public ApplicationManagerController(ILogger<ApplicationManagerController> logger, ILoanApplicationRepository loanAppRepository)
        {
            _logger = logger;
            _loanAppRepository = loanAppRepository;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult> CreateLoanApplication(LoanApplication loanApplication)
        {
            await _loanAppRepository.CreateLoanApplicationAsync(loanApplication);

            return StatusCode(200);
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<LoanApplication> GetLoanApplicationByNumber(string loanApplicationNumber)
        {
            LoanApplication loanApplication = _loanAppRepository.GetLoanApplicationByApplicationNumber(loanApplicationNumber);

            return loanApplication;        
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<IEnumerable<LoanApplication>> GetLoanApplications() 
        {
            List<LoanApplication> loanApplications = _loanAppRepository.GetLoanApplications().ToList();

            return loanApplications;
        }

        [Route("[action]")]
        [HttpPut]
        public async Task<ActionResult> UpdateLoanApplication(LoanApplication loanApplication)
        {
                await _loanAppRepository.UpdateLoanApplicationAsync(loanApplication);

                return StatusCode(200);
        }

        [Route("[action]")]
        [HttpDelete]
        public async Task<ActionResult> DeleteLoanApplication(string loanApplicationNumber)
        {
            await _loanAppRepository.DeleteLoanApplicationAsync(loanApplicationNumber);

            return StatusCode(200);
        }

    }
}
