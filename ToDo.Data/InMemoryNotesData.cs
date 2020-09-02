using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.Models;

namespace ToDo.Data
{
   public class InMemoryNotesData:INotesData
    {

        List<Note> notes;

        public InMemoryNotesData()
        {
            notes = new List<Note>() {
            new Note{ id = 1, description = "Pasear a roger", Details="Educarlo para que se siente antes de salir", done = false, startDate = DateTime.Now, endDate = DateTime.Now},
            new Note{ id = 1, description = "Cena con ely", Details="Con rosas del amor", done = false, startDate = DateTime.Now, endDate = DateTime.Now},
            new Note{ id = 1, description = "Terminar pagos parciales", Details="Pruebas con Alex", done = false, startDate = DateTime.Now, endDate = DateTime.Now}
            };
        }

        public IEnumerable<Note> GetNotes(string searchString)
        {
            return from n in notes
                   where string.IsNullOrEmpty(searchString) || n.description.ToUpper().Contains(searchString.ToUpper())
                   orderby n.description
                   select n;
        }
    }
}
