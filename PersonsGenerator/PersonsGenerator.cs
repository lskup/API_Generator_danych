
namespace Generator;

public class PersonsGenerator : IPersonsGenerator
{
    private readonly Random _random;

    public PersonsGenerator(Random random)
    {
        _random = random;
    }

    public List<string> AvailableData
    {
        get
        {
            return new List<string>
            {
               "Jan","Kamil","Bartosz","Michał","Agata","Iwona","Maria","Sylwia","Maciej",
                "Magda","Zofia","Matylda","Celina","Albert","Wojciech","Adam","Robert",
               "Zygmunt","Stefan","Joanna","Hanna","Mateusz","Igor","Agnieszka","Paweł",
               "Maja","Kaja","Maksymilian","Alojzy","Aldona","Kinga","Marzena","Łukasz",
               "Franciszek","Katarzyna","Renata","Marek","Tadeusz","Krzysztof","Rafał",
               "Danuta","Ewelina","Olga","Barbara","Marta","Dominika","Katarzyna","Martyna",
               "Róża","Władysław",

               "Walczak","Mikołajczyk","Gajda","Błaszczyk","Grzelak","Dzidzic",
               "Kubiak","Ratajczak","Wypych","Michalak","Wróbel","Bąk","Nowak",
               "Krupa","Wawrzyniak","Adamczyk","Kowalik","Wrona","Kaźmierczak",
               "Musiał","Wójcik","Mazurek","Sikora","Owczarek","Szczepaniak","Małysz",
               "Rusowicz","Jarosz","Tym","Obajtek","Knypek","Gańko","Jasina","Bończyk",
               "Lem","Prus","Tyrmand","Grechuta","Mickiewicz","Polko","Skrzypek",
               "Furdyna","Mann","Zakalec","Dziwisz","Gajos","Legutko","Knapp","Wróbel",
               "Mróz"

            };
        }
    }

    public List<(string,string)> GeneratePersonsData(int usersAmount)
    {
        List<(string,string)> users = new List<(string,string)>();

        for (int i = 0; i < usersAmount; i++)
        {
            string firstName = AvailableData[_random.Next(50)];
            string lastName = AvailableData[_random.Next(50, 100)];
            users.Add(new(firstName, lastName));
        }

        return users;
    }

}
