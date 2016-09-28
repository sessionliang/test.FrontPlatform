using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fesoc.Forepart.Test.Controllers.api.v1
{
    public class StaffsController : ApiController
    {
        //Get All, Or with QueryString
        public dynamic Get(int start, int length, string search, string orderCol, string orderDir)
        {
            List<dynamic> array = new List<dynamic>();
            array.Add(new { Name = "test1", Position = "pos1", Office = "off1", Age = 1, StartDate = DateTime.Now.AddHours(1), Salary = "test" });
            array.Add(new { Name = "test2", Position = "pos2", Office = "off2", Age = 2, StartDate = DateTime.Now.AddHours(2), Salary = "test" });
            array.Add(new { Name = "test3", Position = "pos3", Office = "off3", Age = 3, StartDate = DateTime.Now.AddHours(3), Salary = "test" });
            array.Add(new { Name = "test4", Position = "pos4", Office = "off4", Age = 4, StartDate = DateTime.Now.AddHours(4), Salary = "test" });
            array.Add(new { Name = "test5", Position = "pos5", Office = "off5", Age = 5, StartDate = DateTime.Now.AddHours(5), Salary = "test" });
            array.Add(new { Name = "test6", Position = "pos6", Office = "off6", Age = 6, StartDate = DateTime.Now.AddHours(6), Salary = "test" });
            array.Add(new { Name = "test11", Position = "pos11", Office = "off1", Age = 1, StartDate = DateTime.Now.AddHours(1), Salary = "test" });
            array.Add(new { Name = "test21", Position = "pos21", Office = "off2", Age = 2, StartDate = DateTime.Now.AddHours(2), Salary = "test" });
            array.Add(new { Name = "test31", Position = "pos31", Office = "off3", Age = 3, StartDate = DateTime.Now.AddHours(3), Salary = "test" });
            array.Add(new { Name = "test41", Position = "pos41", Office = "off4", Age = 4, StartDate = DateTime.Now.AddHours(4), Salary = "test" });
            array.Add(new { Name = "test51", Position = "pos51", Office = "off5", Age = 5, StartDate = DateTime.Now.AddHours(5), Salary = "test" });
            array.Add(new { Name = "test61", Position = "pos61", Office = "off6", Age = 6, StartDate = DateTime.Now.AddHours(6), Salary = "test" });
            array.Add(new { Name = "test12", Position = "pos12", Office = "off1", Age = 1, StartDate = DateTime.Now.AddHours(1), Salary = "test" });
            array.Add(new { Name = "test22", Position = "pos22", Office = "off2", Age = 2, StartDate = DateTime.Now.AddHours(2), Salary = "test" });
            array.Add(new { Name = "test32", Position = "pos32", Office = "off3", Age = 3, StartDate = DateTime.Now.AddHours(3), Salary = "test" });
            array.Add(new { Name = "test42", Position = "pos42", Office = "off4", Age = 4, StartDate = DateTime.Now.AddHours(4), Salary = "test" });
            array.Add(new { Name = "test52", Position = "pos52", Office = "off5", Age = 5, StartDate = DateTime.Now.AddHours(5), Salary = "test" });
            array.Add(new { Name = "test62", Position = "pos62", Office = "off6", Age = 6, StartDate = DateTime.Now.AddHours(6), Salary = "test" });
            array.Add(new { Name = "test13", Position = "pos13", Office = "off1", Age = 1, StartDate = DateTime.Now.AddHours(1), Salary = "test" });
            array.Add(new { Name = "test23", Position = "pos23", Office = "off2", Age = 2, StartDate = DateTime.Now.AddHours(2), Salary = "test" });
            array.Add(new { Name = "test33", Position = "pos33", Office = "off3", Age = 3, StartDate = DateTime.Now.AddHours(3), Salary = "test" });
            array.Add(new { Name = "test43", Position = "pos43", Office = "off4", Age = 4, StartDate = DateTime.Now.AddHours(4), Salary = "test" });
            array.Add(new { Name = "test53", Position = "pos53", Office = "off5", Age = 5, StartDate = DateTime.Now.AddHours(5), Salary = "test" });
            array.Add(new { Name = "test63", Position = "pos63", Office = "off6", Age = 6, StartDate = DateTime.Now.AddHours(6), Salary = "test" });
            array.Add(new { Name = "test14", Position = "pos14", Office = "off1", Age = 1, StartDate = DateTime.Now.AddHours(1), Salary = "test" });
            array.Add(new { Name = "test24", Position = "pos24", Office = "off2", Age = 2, StartDate = DateTime.Now.AddHours(2), Salary = "test" });
            array.Add(new { Name = "test34", Position = "pos34", Office = "off3", Age = 3, StartDate = DateTime.Now.AddHours(3), Salary = "test" });
            array.Add(new { Name = "test44", Position = "pos44", Office = "off4", Age = 4, StartDate = DateTime.Now.AddHours(4), Salary = "test" });
            array.Add(new { Name = "test54", Position = "pos54", Office = "off5", Age = 5, StartDate = DateTime.Now.AddHours(5), Salary = "test" });
            array.Add(new { Name = "test64", Position = "pos64", Office = "off6", Age = 6, StartDate = DateTime.Now.AddHours(6), Salary = "test" });
            array.Add(new { Name = "test1", Position = "pos1", Office = "off1", Age = 1, StartDate = DateTime.Now.AddHours(1), Salary = "test" });
            array.Add(new { Name = "test2", Position = "pos2", Office = "off2", Age = 2, StartDate = DateTime.Now.AddHours(2), Salary = "test" });
            array.Add(new { Name = "test3", Position = "pos3", Office = "off3", Age = 3, StartDate = DateTime.Now.AddHours(3), Salary = "test" });
            array.Add(new { Name = "test4", Position = "pos4", Office = "off4", Age = 4, StartDate = DateTime.Now.AddHours(4), Salary = "test" });
            array.Add(new { Name = "test5", Position = "pos5", Office = "off5", Age = 5, StartDate = DateTime.Now.AddHours(5), Salary = "test" });
            array.Add(new { Name = "test6", Position = "pos6", Office = "off6", Age = 6, StartDate = DateTime.Now.AddHours(6), Salary = "test" });

            if (!string.IsNullOrEmpty(search))
            {
                array = array.Where(i => i.Name.Contains(search)).ToList();
            }
            if (string.IsNullOrEmpty(orderDir) || orderDir.ToUpper() == "ASC")
            {
                if (!string.IsNullOrEmpty(orderCol))
                {
                    array = array.OrderBy(i => orderCol.ToUpperInvariant()).ToList();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(orderCol))
                {
                    array = array.OrderByDescending(i => orderCol.ToUpperInvariant()).ToList();
                }
            }
            var recordsFiltered = array.Count;
            array = array.Skip(start).Take(length).ToList();
            return new { Data = array, RecordsTotal = 36, RecordsFiltered = recordsFiltered };
        }

        public class SearchValue
        {
            public string Value { get; set; }
            public string Regex { get; set; }
        }
    }
}
