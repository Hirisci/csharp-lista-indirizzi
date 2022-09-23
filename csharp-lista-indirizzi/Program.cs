//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV,
//che cambia poco da quanto appena visto nel live-coding in classe,
//e salvare tutti gli indirizzi contenuti al sul interno all’interno
//di una lista di oggetti istanziati a partire dalla classe Indirizzo.

//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.


using System.IO;
List<Address> lists = new();
string path =
    @"..\..\..\addresses.csv";


try
{
	using (StreamReader sr = new StreamReader(path))
	{
		sr.ReadLine();
		while (sr.Peek() >= 0)
		{
			string[] address = sr.ReadLine().Split(',');
			try
			{
				if (address.Length <=6)
				{
					lists.Add(new Address(address[0].Trim(), address[1].Trim(), address[2].Trim(), address[3].Trim(), address[4].Trim(), address[5].Trim()));
				}
			}
            catch (IndexOutOfRangeException e)
            {
				sr.ReadLine();
                
            }
        }
	}
}
catch (FileNotFoundException e)
{

	Console.WriteLine(e.Message);
}
catch (Exception)
{

    throw;
}



foreach (Address address in lists)
{
	Console.WriteLine(address.ToString());
}