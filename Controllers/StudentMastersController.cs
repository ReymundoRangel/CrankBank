using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrankBank.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrankBank.Controllers
{
    [Produces("application/json")]
    [Route("api/StudentMastersAPI")]
    public class StudentMastersAPI : Controller
    {
        private readonly StudentContext _context;
        public StudentMastersAPI(StudentContext context)
        {
            _context = context;
        }

        // GET: api/StudentMastersAPI/Student  

        [HttpGet]
        [Route("Student")]
        public IEnumerable<StudentMasters> GetStudentMasters()
        {
            IEnumerable<StudentMasters> _retArray = _context.StudentMasters as IEnumerable<StudentMasters>;
            return _retArray;
        }

/*
        // GET: api/StudentMastersAPI/GetAccountSummariesDB  
        [HttpGet]
        [Route("GetAccountSummariesDB")]
        public IEnumerable<AccountSummaries> GetAccountSummariesDB()
        {
            IEnumerable<AccountSummaries> _retArray = _context.AccountSummariesDB as IEnumerable<AccountSummaries>;
            return _retArray;
        }

        // GET: api/StudentMastersAPI/GetAccountSummariesSELECT  
        [HttpGet]
        [Route("GetAccountSummariesSELECT")]
        public IEnumerable<AccountSummaries> GetAccountSummariesSELECT()
        {
            var _results = _context.AccountSummariesDB.FromSql("Select * from AccountSummariesDb")
                .OrderBy(s => s.Balance)
                .ToList();
            return _results;
        }

        // GET: api/StudentMastersAPI/GetAccountSummariesSprocSelect  
        [HttpGet]
        [Route("GetAccountSummariesSprocSelect")]
        public IEnumerable<AccountSummaries> GetAccountSummariesSprocSelect()
        {
            var _results = _context.AccountSummariesDB.FromSql("Execute usp_AccountSummaries_Select ")
                .OrderBy(s => s.Balance)
                .ToList();
            return _results;
        }

        // GET: api/StudentMastersAPI/GetAccountSummariesSprocWithParam  
        [HttpGet]
        [Route("GetAccountSummariesSprocWithParam")]
        public IEnumerable<AccountSummaries> GetAccountSummariesSpocWithParam()
        {
            string _accountId = "712-022-9234";

            var _results = _context.AccountSummariesDB.FromSql("Execute usp_AccountSummaries_WithParam @p0", _accountId)
                .ToList();
            return _results;
        }

        // GET: api/StudentMastersAPI/GetAccountSummariesSprocWithParamUpdate  
        [HttpGet]
        [Route("GetAccountSummariesSprocWithParamUpdate")]
        public IEnumerable<AccountSummaries> GetAccountSummariesSpocWithParamUpdate()
        {
            string _accountId = "712-022-9234";

            var _results = _context.AccountSummariesDB.FromSql("Execute usp_AccountSummaries_WithParamUpdate @p0", _accountId)
                .ToList();
            return _results;
        }

*/

    }
}
