using (StreamWriter writer = File.CreateText("Friends.txt"))
{
    writer.WriteLine("Вася");
    writer.WriteLine("Маша");
    writer.WriteLine("Ира");
}