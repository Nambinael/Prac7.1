using Newtonsoft.Json;

namespace _123
{
    public class Class1
    {
        public static void MySerialize<T>(T Marmelade)
        {
            File.Create("Mameladki.json");
            string json = JsonConvert.SerializeObject(Marmelade);
            File.WriteAllText("C:\\Users\\wellr\\OneDrive\\Рабочий стол\\Mameladki.json", json);
        }
        public static T MyDeserialize<T>()
        {
            string json = File.ReadAllText("C:\\Users\\wellr\\OneDrive\\Рабочий стол\\Mameladki.json");
            T Marmelade = JsonConvert.DeserializeObject<T>(json);
            return Marmelade;
        }
    }
}