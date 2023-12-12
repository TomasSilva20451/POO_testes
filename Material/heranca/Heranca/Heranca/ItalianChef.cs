using System;
namespace Heranca
{
	class ItalianChef : Chef
	{
		public void MakePasta()
		{
			Console.WriteLine("Make Pastas");
		}

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef mkaes Ribs");
        }
    }
}

