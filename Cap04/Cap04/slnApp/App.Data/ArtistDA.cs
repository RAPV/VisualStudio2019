using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    
    public class ArtistDA
    {
        private ChinookModel _context;
        public ArtistDA()
        {
            _context = new ChinookModel();
        }
        public int Count()
        {
            //Select count(*) from Artist
            return _context.Artist.Count();
        }

        public List<Artist> Gets(string filtroByNombre)
        {
            //Aerosmith
            //aero
            //Select * from Artist where Name like '%aero%'
            /*
             Contains: ejemplo= like '%aero%' 
            StartsWith:ejemplo= like 'aero%' 
            EndsWith:ejemplo= like '%aero' 
            == ejemplo: = '%aero%' 
            && = AND
            || =  OR
            */
            return _context.Artist
                .Where(item=>item.Name.Contains(filtroByNombre)               
                )
                .ToList();
        }
    }
}
