using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    
    
}

public class Rettangolo
{
    public int baseRettangolo;
    public int altezzaRettangolo;
    public int calcolaPerimetro
    {
        get { return (baseRettangolo + altezzaRettangolo) + 2; }

    }
    public int calcoloArea
    {
        get { return baseRettangolo * altezzaRettangolo; }
    }
}