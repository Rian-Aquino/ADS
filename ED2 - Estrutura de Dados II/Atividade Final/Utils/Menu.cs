
using System;
using System.Linq;
using System.Collections.Generic;

namespace Projeto_Locação.Utils
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public class Menu
	{
		public List<Option> options {
			get;
			set;
		}
		
		public int index {
			get;
			set;
		}
		
		public string header {
			get;
			set;
		}
		
		public Menu(string header = "Home", List<Option> options = default(List<Option>)) {
			this.options = options;
			this.header = header;
			this.index = 0;
		}
		
	    public void Render()
	    {
	        WriteMenu(options[index]);
	
	        ConsoleKeyInfo keyinfo;
	        do
	        {
	            keyinfo = Console.ReadKey();
	
	            if (keyinfo.Key == ConsoleKey.DownArrow)
	            {
	                if (index + 1 < options.Count)
	                {
	                    index++;
	                    WriteMenu(options[index]);
	                }
	            }
	            if (keyinfo.Key == ConsoleKey.UpArrow)
	            {
	                if (index - 1 >= 0)
	                {
	                    index--;
	                    WriteMenu(options[index]);
	                }
	            }
	            
	            if (keyinfo.Key == ConsoleKey.Enter)
	            {
	            	Console.Clear();
	                options[index].Selected.Invoke();
	                index = 0;
	            }
	        }
	        while (keyinfo.Key != ConsoleKey.Escape);
	
	        Console.ReadKey();
	
	    }
	
	    public void WriteMenu(Option selectedOption)
	    {
	        Console.Clear();
	        
	        Console.WriteLine("\n  " + this.header);
	        Console.WriteLine();
	        
	        Console.WriteLine("  --------------------------");
	        foreach (var option in this.options) {
	        	if (option == selectedOption)
	            {
	        		Console.ForegroundColor = ConsoleColor.Cyan;
	                Console.Write("  > ");
	            }
	            else
	            {
	                Console.Write("   ");
	            }
	
	            Console.WriteLine(option.Name);
	            Console.ResetColor();
	        }
	        Console.WriteLine("  --------------------------");
	
	    }
	}
	
	
	
	public class Option
    {
        public string Name {
    		get;
    		set;
    	}
        public Action Selected {
    		get;
    		set;
    	}

        public Option(string name, Action selected)
        {
            Name = name;
            Selected = selected;
        }
    }
}
