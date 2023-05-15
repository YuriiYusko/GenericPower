using GenericPower.Entities;
using GenericPower.Repositories;

var employyeRepository = new GenericRepository<Employee>();

employyeRepository.Add(new Employee { FirstName = "Yurii" });
employyeRepository.Add(new Employee { FirstName = "Mariana" });
employyeRepository.Add(new Employee { FirstName = "Witalii" });

employyeRepository.Save();  