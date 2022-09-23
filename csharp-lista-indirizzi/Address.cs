//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV,
//che cambia poco da quanto appena visto nel live-coding in classe,
//e salvare tutti gli indirizzi contenuti al sul interno all’interno
//di una lista di oggetti istanziati a partire dalla classe Indirizzo.

internal class Address
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string PostalCode { get; set; }

    public Address(string name, string surname, string street, string city, string province, string postalCode)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        PostalCode = postalCode;
    }

    public override string? ToString()
    {
        return String.Format("| Nome: {0,15} | Cognome: {1,15} | Via: {2,40} | Citta: {3,15}({4,2}) | Zip: {5}", Name,Surname,Street,City,Province,PostalCode);


    }
}