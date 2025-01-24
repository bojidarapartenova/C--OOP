namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();

                string id = data[1];
                string firstName = data[2];
                string lastName = data[3];

                ISoldier currentSoldier = null;

                if (data[0] == "Private")
                {
                    decimal salary = decimal.Parse(data[4]);
                    currentSoldier = new Private(id, firstName, lastName, salary);
                }

                if (data[0] == "LeutenantGeneral")
                {
                    decimal salary = decimal.Parse(data[4]);
                    ILieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

                    foreach (var privateId in data.Skip(5))
                    {
                        ISoldier privates = soldiers.First(x => x.Id == privateId);
                        general.AddPrivates((IPrivate)privates);
                    }

                    currentSoldier = general;
                }

                if (data[0] == "Engineer")
                {
                    decimal salary = decimal.Parse(data[4]);
                    string corps = data[5];

                    try
                    {
                        IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                        string[] repairsTokens = data.Skip(6).ToArray();

                        for (int i = 0; i < repairsTokens.Length; i += 2)
                        {
                            string partName = repairsTokens[i];
                            int hoursWorked = int.Parse(repairsTokens[i + 1]);
                            IRepair repair = new Repair(partName, hoursWorked);
                            engineer.AddRepair(repair);
                        }

                        currentSoldier = engineer;
                    }
                    catch (Exception e)
                    {
                        continue;
                    }

                }

                if (data[0] == "Commando")
                {
                    decimal salary = decimal.Parse(data[4]);
                    string corps = data[5];
                    try
                    {
                        ICommando commando = new Commando(id, firstName, lastName, salary, corps);
                        string[] missionsTokens = data.Skip(6).ToArray();

                        for (int i = 0; i < missionsTokens.Length; i += 2)
                        {
                            try
                            {
                                string missionCodeName = missionsTokens[i];
                                string missionState = missionsTokens[i + 1];
                                IMission mission = new Mission(missionCodeName, missionState);
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
                }   

                if (data[0] == "Spy")
                {
                    int codeNumber = int.Parse(data[4]);
                    currentSoldier = new Spy(id, firstName, lastName, codeNumber);
                }

                if (currentSoldier is not null)
                {
                    soldiers.Add(currentSoldier);
                }
            }

            Console.WriteLine(string.Join("\n", soldiers));
        }
    }
}