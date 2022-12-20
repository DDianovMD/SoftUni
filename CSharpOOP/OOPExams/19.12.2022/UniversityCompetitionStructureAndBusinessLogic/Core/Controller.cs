using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories;

namespace UniversityCompetition.Core
{
    public class Controller : IController
    {
        private SubjectRepository subjects;
        private StudentRepository students;
        private UniversityRepository universities;

        public Controller()
        {
            this.subjects = new SubjectRepository();
            this.students = new StudentRepository();
            this.universities = new UniversityRepository();
        }

        public string AddStudent(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;

            if (students.FindByName(fullName) != null)
            {
                return $"{firstName} {lastName} is already added in the repository.";
            }

            IStudent student = new Student(students.Models.Count + 1, firstName, lastName);

            this.students.AddModel(student);

            return $"Student {firstName} {lastName} is added to the StudentRepository!";
        }

        public string AddSubject(string subjectName, string subjectType)
        {

            if (subjectType != nameof(EconomicalSubject) &&
                subjectType != nameof(HumanitySubject) &&
                subjectType != nameof(TechnicalSubject))
            {
                return $"Subject type {subjectType} is not available in the application!";
            }

            if (this.subjects.FindByName(subjectName) != null)
            {
                return $"{subjectName} is already added in the repository.";
            }

            ISubject subject = null;

            if (subjectType == nameof(EconomicalSubject))
            {
                subject = new EconomicalSubject(this.subjects.Models.Count + 1, subjectName);
            }
            else if (subjectType == nameof(HumanitySubject))
            {
                subject = new HumanitySubject(this.subjects.Models.Count + 1, subjectName);
            }
            else if (subjectType == nameof(TechnicalSubject))
            {
                subject = new TechnicalSubject(this.subjects.Models.Count + 1, subjectName);
            }

            this.subjects.AddModel(subject);

            return $"{subjectType} {subjectName} is created and added to the {this.subjects.GetType().Name}!";
        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if (this.universities.FindByName(universityName) != null)
            {
                return $"{universityName} is already added in the repository.";
            }

            List<int> subjectsIds = new List<int>();

            foreach (string subject in requiredSubjects)
            {
                int currentId = this.subjects.FindByName(subject).Id;
                subjectsIds.Add(currentId);
            }

            IUniversity university = new University(this.universities.Models.Count + 1,
                                                    universityName,
                                                    category,
                                                    capacity,
                                                    subjectsIds);

            subjectsIds.Clear();

            this.universities.AddModel(university);

            return $"{universityName} university is created and added to the {this.universities.GetType().Name}!";
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            string[] names = studentName.Split(" ");

            string firstName = names[0];
            string lastName = names[1];

            IStudent student = this.students.FindByName(studentName);
            IUniversity university = this.universities.FindByName(universityName);

            if (student == null)
            {
                return $"{firstName} {lastName} is not registered in the application!";
            }

            if (university == null)
            {
                return $"{universityName} is not registered in the application!";
            }

            bool hasCoveredAllExams = true;

            IReadOnlyCollection<int> requiredExams = university.RequiredSubjects;

            foreach (int exam in requiredExams)
            {
                if (student.CoveredExams.Contains(exam) == false)
                {
                    hasCoveredAllExams = false;
                    break;
                }
            }

            if (hasCoveredAllExams == false)
            {
                return $"{studentName} has not covered all the required exams for {universityName} university!";
            }

            if (student.University != null && student.University.Name == universityName)
            {
                return $"{student.FirstName} {student.LastName} has already joined {universityName}.";
            }

            student.JoinUniversity(university);

            return $"{student.FirstName} {student.LastName} joined {universityName} university!";
        }

        public string TakeExam(int studentId, int subjectId)
        {
            IStudent student = this.students.FindById(studentId);
            ISubject subject = this.subjects.FindById(subjectId);

            if (student == null)
            {
                return "Invalid student ID!";
            }

            if (subject == null)
            {
                return "Invalid subject ID!";
            }

            if (student.CoveredExams.Contains(subjectId))
            {
                return $"{student.FirstName} {student.LastName} has already covered exam of {subject.Name}.";
            }

            student.CoverExam(subject);

            return $"{student.FirstName} {student.LastName} covered {subject.Name} exam!";
        }

        public string UniversityReport(int universityId)
        {
            IUniversity university = this.universities.FindById(universityId);

            int studentsCount = this.students.Models
                                            .Where(x => x.University != null &&
                                                                        x.University.Name == university.Name)
                                            .Count();

            StringBuilder result = new StringBuilder();

            result.AppendLine($"*** {university.Name} ***");
            result.AppendLine($"Profile: {university.Category}");
            result.AppendLine($"Students admitted: {studentsCount}");
            result.AppendLine($"University vacancy: {university.Capacity - studentsCount}");

            return result.ToString().TrimEnd();
        }
    }
}
