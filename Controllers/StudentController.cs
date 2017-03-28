using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrankBank.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrankBank.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        private readonly StudentContext _context;
        public StudentController(StudentContext context)
        {
            _context = context;
        }

        // GET: api/Student/GetStudentMasters  

        [HttpGet]
        [Route("StudentMasters")]
        public IEnumerable<Data.StudentMasters> GetStudentMasters()
        {
            IEnumerable<Data.StudentMasters> _retArray = _context.StudentMasters as IEnumerable<Data.StudentMasters>;
            return _retArray;
        }


        // GET: api/Student/GetAccountSummariesDB  

        [HttpGet]
        [Route("GetAccountSummaries")]
        public IEnumerable<AccountSummaries> GetAccountSummaries()
        {
            IEnumerable<AccountSummaries> _retArray = _context.AccountSummaries as IEnumerable<AccountSummaries>;
            return _retArray;
        }

        // GET: api/Student/GetAccountSummariesSELECT  

        [HttpGet]
        [Route("GetAccountSummariesSELECT")]
        public IEnumerable<AccountSummaries> GetAccountSummariesSELECT()
        {
            var _results = _context.AccountSummaries.FromSql("Select * from AccountSummariesDb")
                .OrderBy(s => s.Balance)
                .ToList();
            return _results;
        }

        // GET: api/Student/GetAccountSummariesSprocSelect  

        [HttpGet]
        [Route("GetAccountSummariesSprocSelect")]
        public IEnumerable<AccountSummaries> GetAccountSummariesSprocSelect()
        {
            var _results = _context.AccountSummaries.FromSql("Execute usp_AccountSummaries_Select ")
                .OrderBy(s => s.Balance)
                .ToList();
            return _results;
        }

        // GET: api/Student/GetAccountSummariesSprocWithParam  

        [HttpGet]
        [Route("GetAccountSummariesSprocWithParam")]
        public IEnumerable<AccountSummaries> GetAccountSummariesSpocWithParam()
        {
            string _accountId = "712-022-9234";

            var _results = _context.AccountSummaries.FromSql("Execute usp_AccountSummaries_WithParam @p0", _accountId)
                .ToList();
            return _results;
        }

        // GET: api/Student/GetAccountSummariesSprocWithParamUpdate  

        [HttpGet]
        [Route("GetAccountSummariesSprocWithParamUpdate")]
        public IEnumerable<AccountSummaries> GetAccountSummariesSpocWithParamUpdate()
        {
            string _accountId = "712-022-9234";

            var _results = _context.AccountSummaries.FromSql("Execute usp_AccountSummaries_WithParamUpdate @p0", _accountId)
                .ToList();
            return _results;
        }

    }
}
