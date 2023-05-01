using (StreamReader reader1 = File.OpenText("Friends.txt"))
{
    string s = null;
    while ((s = reader1.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
   
}