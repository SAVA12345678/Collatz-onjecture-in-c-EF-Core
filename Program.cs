using System.Runtime.InteropServices.Marshalling;
using EfCore;
using Microsoft.EntityFrameworkCore;
namespace EfCore;

class Program{

    static async Task Main()
    {
        using var db = new AddDb();


        if (!await db.CollatzSys.AnyAsync())
        {
            db.CollatzSys.Add(new CollatzSys {Number = 1, ChainOfNumbers = string.Join(',',CollatzСonjecture(1))}); 
            await db.SaveChangesAsync();
        }
        
        var Da = await db.CollatzSys.OrderByDescending(n => n.Number).FirstOrDefaultAsync();

        if (Da != null)
        {
        
            for (long i = Da.Number + 1; i < Da.Number + 6; i++)

            {
                db.CollatzSys.Add(new CollatzSys {Number = i, ChainOfNumbers = string.Join(',',CollatzСonjecture(i))});
                await db.SaveChangesAsync();
            }
        }

    foreach(CollatzSys i in db.CollatzSys)
        {
            Console.WriteLine($"Число: {i.Number}, Путь: {i.ChainOfNumbers} \n");
        }


        
    }

    public static List<long> CollatzСonjecture(long num)
    {   
        List<long> vars = new List<long>();

        if (num <= 0)
        {

            return vars;
        }

        while (num > 1)
        {
            if (num % 2 == 0)
            {
                num /= 2;
                vars.Add(num);
            }

            else
            {
                num *= 3;
                num += 1;
                vars.Add(num);
            }
        }    
        return vars;
        

    }

    

}
