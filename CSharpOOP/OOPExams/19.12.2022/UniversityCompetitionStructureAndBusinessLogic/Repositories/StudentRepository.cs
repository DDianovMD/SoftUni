using System.Collections.Generic;
using System.Linq;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class StudentRepository : IRepository<IStudent>
    {
        private List<IStudent> models;

        public StudentRepository()
        {
            this.models = new List<IStudent>();
        }

        public IReadOnlyCollection<IStudent> Models => this.models.AsReadOnly();

        public void AddModel(IStudent model)
        {
            this.models.Add(model);
        }

        public IStudent FindById(int id)
        {
            return this.models.FirstOrDefault(x => x.Id == id);
        }

        public IStudent FindByName(string name)
        {
            string[] names = name.Split(" ");
            string firstName = names[0];
            string lastName = names[1];

            return this.models.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
