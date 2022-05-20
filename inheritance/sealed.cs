using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class parent
    {
       
         public virtual void play()
        {
            Console.WriteLine("play on ground");
        }
        internal virtual void study()
        {
            Console.WriteLine("study books");
        }
    }

    class child : parent
    {
        public   override void play()
        {
            Console.WriteLine("playing games");
        }
        internal override void study()
        {
            Console.WriteLine("online study");
        }
    }

    class child1 : child
    {
        public override void play()
        {
            Console.WriteLine("playind video games");
        }
        internal override void study()
        {
            Console.WriteLine("ofline study");
        }
    }

            class parent1
            {
                static void Main(string[] args)
                {
                    parent p = new parent();
                    p.play();
                    p.study();
                    child c = new child();
                    c.play();
                    c.study();
                    child1 c1 = new child1();
                    c1.play();
                    c1.study();
                }
            }
        }

    

    

