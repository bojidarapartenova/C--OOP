using MilitaryElite.Classes;
using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICollection<ISoldier> soldiers = new List<ISoldier>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();
                string type = data[0];
                string id = data[1];
                string firstName = data[2];
                string lastName = data[3];
                decimal salary;
                string corps;
                int codeNumber;

                ISoldier currentSoldier = null;

                switch (type)
                {
                    case "Private":
                        salary = decimal.Parse(data[4]);
                        currentSoldier = new Private(id, firstName, lastName, salary);
                        break;
                    case "LieutenantGeneral":
                        salary = decimal.Parse(data[4]);
                        ILieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

                        foreach (var privateId in data.Skip(5))
                        {
                            ISoldier privateToAdd = soldiers.First(x => x.Id == privateId);
                            general.AddPrivate((IPrivate)privateToAdd);
                        }

                        currentSoldier = general;
                        break;
                    case "Engineer":
                        salary = decimal.Parse(data[4]);
                        corps = data[5];

                        try
                        {
                            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                            string[] repairs = data.Skip(6).ToArray();

                            for (int i = 0; i < repairs.Length; i+=2)
                            {
                                string partName = repairs[i];
                                int hoursWorked = int.Parse(repairs[i + 1]);

                                IRepair repair = new Repair(partName, hoursWorked);
                                engineer.AddRepair(repair);
                            }

                            currentSoldier = engineer;
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                        break;
                    case "Commando":
                        salary = decimal.Parse(data[4]);
                        corps = data[5];

                        try
                        {
                            ICommando commando = new Commando(id, firstName, lastName, salary, corps);
                            string[] missions = data.Skip(6).ToArray();

                            for (int i = 0; i < missions.Length; i+=2)
                            {
                                try
                                {
                                    string codeName = missions[i];
                                    string state = missions[i + 1];

                                    IMission mission = new Mission(codeName, state);
                                    commando.AddMission(mission);
                                }
                                catch (Exception ex)
                                {
                                    continue;
                                }
                            }

                            currentSoldier = commando;
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                        break;
                    case "Spy":
                        codeNumber = int.Parse(data[4]);
                        currentSoldier = new Spy(id, firstName, lastName, codeNumber);
                        break;
                }

                if (currentSoldier != null)
                {
                    soldiers.Add(currentSoldier);
                }

            }
            Console.WriteLine(string.Join("\n", soldiers));
        }
    }
}