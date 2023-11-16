using _31_AJAX.Models;
using Microsoft.AspNetCore.Mvc;

namespace _31_AJAX.Controllers
{
    public class PersonController : Controller
    {
        private static List<Person> persons = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe", Age = 25 },
            new Person { Id = 2, FirstName = "Jane", LastName = "Doe", Age = 30 },
                // ... diğer örnekler
        };

        public IActionResult Index()
        {
            return View(persons);
        }

        [HttpPost]
        public JsonResult AddPerson(Person person)
        {
            // Yeni kişiyi ekleyerek ID'yi oluştur
            person.Id = persons.Count + 1;
            persons.Add(person);
            return Json(person);
        }

        [HttpGet]
        public JsonResult GetPerson(int id)
        {
            // ID'ye göre kişiyi getir
            var person = persons.FirstOrDefault(p => p.Id == id);
            return Json(person);
        }

        [HttpPost]
        public JsonResult UpdatePerson(Person person)
        {
            // ID'ye göre kişiyi güncelle
            var existingPerson = persons.FirstOrDefault(p => p.Id == person.Id);
            if (existingPerson != null)
            {
                existingPerson.FirstName = person.FirstName;
                existingPerson.LastName = person.LastName;
                existingPerson.Age = person.Age;
                return Json(existingPerson);
            }
            else
            {
                return Json(null);
            }
        }

        [HttpPost]
        public JsonResult DeletePerson(int id)
        {
            // ID'ye göre kişiyi sil
            var personToRemove = persons.FirstOrDefault(p => p.Id == id);
            if (personToRemove != null)
            {
                persons.Remove(personToRemove);
                return Json(id);
            }
            else
            {
                return Json(null);
            }
        }
    }

}
