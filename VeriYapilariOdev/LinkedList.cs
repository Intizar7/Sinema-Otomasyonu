using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev
{
    public class LinkedList : ListADT
    {
        public override void InsertPos(int position, Bilet value)
        {
            Node temp = new Node { Data = value };
            Node current = Head;

       
            if (current != null)
            {
                for (int i = 0; i < position && current.Next != null; i++)
                {
                    current = current.Next;
                }

                temp.Next = current.Next;
                current.Next = temp;
            } else
            {
                Head = temp;
            }

            Size++;
        }

        public override void DeletePos(int position)
        {

            Node current = Head;
            if (Head != null)
            {
                for (int i = 0; i < position; i++)
                {
                    if (current.Next == null)
                        return;

                    current = current.Next;
                }
                current.Next = current.Next.Next;
                Size--;
            }
                        
        }
        public override Node GetElement(int position)
        {
            Node iter = Head;
            for (int i = 1; i <= position; i++)
            {
                iter = iter.Next;
            }
            return iter;
        }
    }
}
