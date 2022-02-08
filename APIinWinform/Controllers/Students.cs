using APIinWinform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace APIinWinform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {

        DataBasecontext _context;


        public Students(DataBasecontext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<JsonResult> GetAsync()
        {
            var employee = await _context.students.ToListAsync();
            return new JsonResult(employee);
        }
        [HttpGet("{Id}")]
        public async Task<JsonResult> GetbyID(int Id)
        {
            var employee = await _context.students.Where(a => a.Id == Id).SingleOrDefaultAsync();
            return new JsonResult(employee);
        }
        [HttpPut]
        public JsonResult Update(student tcs)
        {
            var UpdateDATA = (from p in _context.students where p.Id == tcs.Id select p);
            foreach (var UpdateDATAGet in UpdateDATA)
            {
                UpdateDATAGet.StudentName = tcs.StudentName;
                
                UpdateDATAGet.Dob = tcs.Dob;
                UpdateDATAGet.Email = tcs.Email;
                UpdateDATAGet.Notes = tcs.Notes;



            }
            _context.SaveChanges();
            return new JsonResult("Updated Successfully");

        }
        [HttpDelete("{Id}")]
        public JsonResult Delete(int Id)
        {
            var objdel = _context.students.Find(Id);
            _context.students.Remove(objdel);
            _context.SaveChanges();
            return new JsonResult("Deleted Successfully");
        }
       
    }
}
