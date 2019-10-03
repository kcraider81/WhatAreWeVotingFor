using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WhatAreWeVotingFor.Models;

namespace WhatAreWeVotingFor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> GetAllCandidates()
        {
            var candidate = new Candidate();
            return JsonConvert.SerializeObject(candidate.AllCandidates());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetCandidate(int id)
        {
            var candidate = new Candidate();
            return JsonConvert.SerializeObject(candidate.OneCandidate());
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
