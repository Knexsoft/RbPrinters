using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RbPrinters.Api.Contracts.Models.Entity;
using RbPrinters.Api.Contracts.Models.Request;
using RbPrinters.Api.Interfaces.Repositories;

namespace RbPrinters.Api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BranchController : ControllerBase
    {
        #region globle objects
        private readonly IBaseRepository<Branch> _branch;
        #endregion

        public BranchController(IBaseRepository<Branch> branch)
        {
            _branch = branch;
        }

        #region Public Actions
        /// <summary>
        /// Insert new branch
        /// </summary>
        /// <param name="branchRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Insert([FromBody] BranchRequest branchRequest)
        {
            return Ok();
        }

        /// <summary>
        /// Update branch details
        /// </summary>
        /// <param name="branchRequest">All required details</param>
        /// <param name="branchID">branch guid</param>
        /// <returns></returns>
        public IActionResult Update(BranchRequest branchRequest, string branchID)
        {
            return Ok();
        }
        #endregion

        #region Helpers
        #endregion
    }
}