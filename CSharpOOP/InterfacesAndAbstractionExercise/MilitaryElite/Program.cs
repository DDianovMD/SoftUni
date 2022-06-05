using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        static void Main()
        {
            List<ISoldier> military = new List<ISoldier>();

            while (true)
            {
                string[] userInput = Console.ReadLine().Split();

                if (userInput[0] == "End")
                {
                    break;
                }

                if (userInput[0] == "Private")
                {
                    Private currentPrivate = new Private(int.Parse(userInput[1]), userInput[2], userInput[3], decimal.Parse(userInput[4]));
                    military.Add(currentPrivate);
                }
                else if (userInput[0] == "LieutenantGeneral")
                {
                    LieutenantGeneral currentLieutenant = new LieutenantGeneral(int.Parse(userInput[1]), userInput[2], userInput[3], decimal.Parse(userInput[4]));

                    for (int i = 5; i < userInput.Length; i++)
                    {
                        foreach (var soldier in military)
                        {
                            if (int.Parse(userInput[i]) == soldier.ID)
                            {
                                currentLieutenant.Privates.Add((Private)soldier);
                            }
                        }
                    }

                    military.Add(currentLieutenant);
                }
                else if (userInput[0] == "Engineer")
                {
                    if (userInput[5] == "Airforces" || userInput[5] == "Marines")
                    {
                        List<Repair> repairs = new List<Repair>();

                        for (int i = 6; i < userInput.Length; i += 2)
                        {
                            Repair currentRepair = new Repair(userInput[i], int.Parse(userInput[i + 1]));
                            repairs.Add(currentRepair);
                        }

                        Engineer currentEngineer = new Engineer(int.Parse(userInput[1]), userInput[2], userInput[3], decimal.Parse(userInput[4]), userInput[5], repairs);
                        military.Add(currentEngineer);
                        repairs.Clear();
                    }
                }
                else if (userInput[0] == "Commando")
                {
                    if (userInput[5] == "Airforces" || userInput[5] == "Marines")
                    {
                        List<Mission> missionsList = new List<Mission>();

                        for (int i = 6; i < userInput.Length; i += 2)
                        {
                            Mission currentMission = new Mission(userInput[i], userInput[i + 1]);
                            missionsList.Add(currentMission);
                        }

                        Commando currentCommando = new Commando(int.Parse(userInput[1]), userInput[2], userInput[3], decimal.Parse(userInput[4]), userInput[5], missionsList);
                        military.Add(currentCommando);
                        missionsList.Clear();
                    }
                }
                else if (userInput[0] == "Spy")
                {
                    Spy currentSpy = new Spy(int.Parse(userInput[1]), userInput[2], userInput[3], int.Parse(userInput[4]));

                    military.Add(currentSpy);
                }
            }

            foreach (var soldier in military)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
