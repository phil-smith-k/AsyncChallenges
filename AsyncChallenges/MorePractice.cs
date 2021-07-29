using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncChallenges
{
    /*
        Refactor the following CRUD methods to make them async. Research any 
        syntax or methods you don't recognize. For even more practice with 
        calling async methods, implement a ProgramUI using this Repository 
        to Create, Display, Update and Delete pastries from a menu
    */

    public class PastryRepository
    {
        private readonly List<Pastry> _pastries = new List<Pastry>();

        public bool Create(Pastry pastry)
        {
            if (pastry == null)
            {
                return false;
            }

            _pastries.Add(pastry);
            return true;
        }

        public IEnumerable<Pastry> GetPastries(int skip = 0, int take = 25)
        {
            return _pastries.Skip(skip).Take(take);
        }

        public Pastry GetPastryById(int id)
        {
            return _pastries.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Pastry updatedPastry)
        {
            Pastry existingPastry = this.GetPastryById(updatedPastry.Id);

            if (existingPastry == null)
            {
                return false;
            }

            this.UpdateProperties(existingPastry, updatedPastry);

            return true;
        }

        public bool Delete(int id)
        {
            Pastry existingPastry = this.GetPastryById(id);

            if (existingPastry == null)
            {
                return false;
            }

            _pastries.Remove(existingPastry);

            return true;
        }

        private void UpdateProperties(Pastry existing, Pastry updated)
        {
            existing.Name = updated.Name;
            existing.Ingredients = updated.Ingredients;
            existing.PastryType = updated.PastryType;
        }
    }

    public class Pastry
    {
        public Pastry()
        {

        }

        public Pastry(
            int id, 
            string name, 
            List<string> ingredients, 
            PastryType pastryType)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            PastryType = pastryType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public PastryType PastryType { get; set; }
    }

    public enum PastryType
    {
        Danish,
        Donut,
        Scone,
        Cupcake
    }
}
