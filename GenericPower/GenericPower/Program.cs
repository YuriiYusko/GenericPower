using GenericPower.Data;
using GenericPower.Entities;
using GenericPower.Repositories;

//var employyeRepository = new GenericRepository<Employee>();
//employyeRepository.Add(new Employee { FirstName = "Yurii" });
//employyeRepository.Add(new Employee { FirstName = "Mariana" });
//employyeRepository.Add(new Employee { FirstName = "Witalii" })
//employyeRepository.Save();

var sqlRepository = new SQLRepository<Employee>(new MyAppDbContext());
AddEmployee(sqlRepository);
AddManager(sqlRepository);
WriteAll(sqlRepository);

static void AddEmployee(IRepository<Employee> repository)
{
    repository.Add(new Employee { FirstName = "Yurii" });
    repository.Add(new Employee { FirstName = "Mariana" });
    repository.Add(new Employee { FirstName = "Vitalii" });
    repository.Save();
}

static void AddManager(IWriteRepository<Manager> repository)
{
    repository.Add(new Manager { FirstName = "Ivan" });
    repository.Add(new Manager { FirstName = "Ola" });
    repository.Save();
}

static void WriteAll(IReadRepository<IEntity> repository)
{
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine(item);
    }
}