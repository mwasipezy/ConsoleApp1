// See https://aka.ms/new-console-template for more information
using System.Configuration;
using CustomTags;
class Program
{
    static void Main(string[] args)
    {
            WorldSection? group = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).SectionGroups["worldSection"] as WorldSection;
            foreach (ConfigurationSection section in group.Sections)
            {
                Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("you are accessing ==>"+section.SectionInformation.Name.ToUpper());
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
                if (section.GetType() == typeof(GameEnvironment))
                {
                    GameEnvironment c = (GameEnvironment)section;
                    ObjectElementCollection coll = c.Companies;
               
                    foreach (ObjectElements item in coll)
                    {
                        Console.WriteLine("{0,25} {1,6} {2,6}", item.Name, item.DefencePoints, item.AttackPoints);
                        Console.WriteLine("{0,25} | {1,6}", "Your log file link", ConfigurationManager.AppSettings["logfile"]);
                   
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
                    }
                }
              

            }
            Console.ReadLine();
        
    }
    void CountNofLootedITems()
    {
        string[] somearray = new string[10];
        //Linq query  
        IEnumerable<string> namesOfPeople = from name in somearray
                                            where name.Length <= 16
                                            select name;
        foreach (var name in namesOfPeople)
        {
            //txtDisplay.AppendText(name + "\n");
        }
    }
}
