using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatAreWeVotingFor.Models
{
    [Serializable]
    public class Candidate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string Party { get; set; }

        public List<Candidate> AllCandidates()
        {
            var candidates = new List<Candidate>();
            for(int i = 0; i < 10; i++)
            {
                candidates.Add(OneCandidate());
            }


            return candidates;
        }

        public Candidate OneCandidate()
        {
            var candidate = new Candidate();
            Random random = new Random();
            candidate.FirstName = random.Next(0, 123456789).ToString();
            candidate.LastName = random.Next(0, 123456789).ToString();
            candidate.State = random.Next(0, 123456789).ToString();
            candidate.Party = random.Next(0, 123456789).ToString();
            return candidate;
        }
    }
}
