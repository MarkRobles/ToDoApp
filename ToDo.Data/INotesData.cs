using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Models;

namespace ToDo.Data
{
    public interface INotesData
    {
        IEnumerable<Note> GetNotes(string name);
    }
}
