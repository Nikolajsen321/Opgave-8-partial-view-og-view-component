namespace Opgave_8_partial_view_og_view_component.Models
{
    public class Person
    {
        private string _navn;
        public string Navn { get { return _navn; } set { _navn = value; } }
        private int _alder;
        public int Alder { get { return _alder; } set { _alder = value; } }

        public Person(string navn, int alder) : this()
        {

            this._navn = navn;
            this._alder = alder;
        }

        public Person()
        {
            this._navn = "Hans";
            this._alder = 0;
        }


        
   
}
}
