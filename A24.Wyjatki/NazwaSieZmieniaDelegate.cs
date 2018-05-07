using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24.Wyjatki
{

    //4. Poniższy delegat w zdarzeniach przyjmuje dwa parametry - object sender oraz klasę którą utworzyliśmy ZmienNazweEventArgs args.  
    //object sender - mogę tu przekazać cokolwiek np wartość liczbową, stringa lub instancję klasy - w tym przypadku bedzie to nasza klasa dzienniczka.
    public delegate void NazwaSieZmieniaDelegate(object sender, ZmienNazweEventArgs args);
}
