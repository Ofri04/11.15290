using ComputerScienceYA;
using System;

namespace _11._15290
{
    class Program
    {
        static void Main(string[] args)
        {

            Node<int> p = RandomLoadList(1, 10, 5); // task 1\
            Node<int> p2 = RandomLoadList(1, 10, 8); // task 1\

            Node<int> p_clone = CloneList(p);
            Console.WriteLine(p_clone.ToString());

            Console.WriteLine(SumList(p)); //task 4
            Console.WriteLine(LenList(p)); //task 5
            Console.WriteLine(IsInList(p, 3)); //task  6

            DelFromList(p, 2);
            Console.WriteLine(p.ToString());

            DelAllFromList(p, 3);
            Console.WriteLine(p.ToString());

            Console.WriteLine("----------------------------------");

            Console.WriteLine(p.ToString());

            Console.WriteLine(SortList(p).ToString());

            Node<int> p_sorted = SortList(p);

            InserToList(p_sorted, 4); //TARGIL 9

            Console.WriteLine(p_sorted.ToString());


            Console.WriteLine("------TASK 10-----");
            Console.WriteLine(SortList(p).ToString());
            Console.WriteLine(SortList(p2).ToString());


            Console.WriteLine("------TASK 11-----");
            Console.WriteLine(JoinSortedLists(SortList(p), SortList(p2)));


            Console.WriteLine("------TASK 12-----");
            Console.WriteLine(p2.ToString());
            Console.WriteLine(OddList(p2).ToString());

            Console.WriteLine("------TASK 13-----");

            Console.WriteLine(p2.ToString());
            Console.WriteLine("------TASK 13-----");
            Console.WriteLine(NegitiveFirstList(p2).ToString());

            Console.WriteLine("------TASK 14-----");
            Console.WriteLine(p.ToString());
            Console.WriteLine(FlipList(p).ToString());


            Console.WriteLine("------TASK 15-----");
            Console.WriteLine(p.ToString());
            Console.WriteLine(IsPoliList(p).ToString());

            Console.WriteLine("------TASK 16-----");
            Console.WriteLine(p.ToString());
            Console.WriteLine(UniqueValuesList(p).ToString());

            Console.WriteLine("------TASK 17-----");
            Console.WriteLine(p.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(IsListList(p,p2).ToString());

            Console.WriteLine("------TASK 18-----");
            Console.WriteLine(p.ToString());
            Console.WriteLine(MaxListR(p).ToString());

            Console.WriteLine("------TASK 19-----");
            Console.WriteLine(p.ToString());
            Console.WriteLine(SumListR(p).ToString());

            Console.WriteLine("------TASK 20-----");
            Console.WriteLine(p.ToString());
            Console.WriteLine(LenListR(p).ToString());

            Console.ReadLine();
        }
        public static Node<int> RandomLoadList(int f, int t, int n) //task 1 simple
        {
            // הפעולה מקבלת שלושה פרמטרים שלמים ושמה אותם ברשימה לפי טווח המספרים F-T ועושה זאת N פעמים


            Node<int> first = null, last = null;
            int x;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                x = rnd.Next(f, t + 1);
                if (first == null)
                {
                    first = new Node<int>(x);
                    last = first;
                }
                else
                {
                    last.SetNext(new Node<int>(x));
                    last = last.GetNext();
                }
            }
            Console.WriteLine(first.ToString());
            return first;
        }
        public static Node<int> CloneList(Node<int> p)// task 2 simple
        {
            Node<int> first = null, last = null;
            int x;
            while (p != null)
            {
                x = p.GetValue();
                if (first == null)
                {
                    first = new Node<int>(x);
                    last = first;
                }
                else
                {
                    last.SetNext(new Node<int>(x));
                    last = last.GetNext();
                }
                p = p.GetNext();
            }

            return first;
        }
        public static int MaxList(Node<int> p) // task 3 simple
        {
            int max = 0, x;
            while (p != null)
            {
                x = p.GetValue();
                if (x > max)
                    max = x;
                p = p.GetNext();
            }
            return max;
        }
        public static int MinList(Node<int> p) // מעטפת
        {
            int min, x;
            if (p != null)
            {
                min = p.GetValue();

                while (p != null)
                {
                    x = p.GetValue();
                    if (x < min)
                        min = x;
                    p = p.GetNext();
                }
            }
            else
                min = 0;
            return min;
        }
        public static int SumList(Node<int> p) // task 4 simple
        {
            int x, sum = 0;
            while (p != null)
            {
                x = p.GetValue();
                sum += x;
                p = p.GetNext();

            }
            return sum;
        }
        public static int LenList(Node<int> p) // task 5 simple
        {

            int x, len = 0;
            while (p != null)
            {
                x = p.GetValue();
                len++;
                p = p.GetNext();
            }
            return len;
        }
        public static bool IsInList(Node<int> p, int k) // task 6 simple
        {
            // פעולה המקבלת רשימה ומספר ומחזירה האם המספר נמצא ברשימה 

            int x;
            while (p != null)
            {
                x = p.GetValue();
                if (k == x)
                    return true;
                else
                    p = p.GetNext();
            }
            return false;
        }
        public static void DelFromList(Node<int> p, int k) // task 7
        {
            // פעולה המקבלת רשימה ומספר ובודקת האם מספר נמצא ברשימה אם כן היא מוחקת אותו 
            int x;
            if (p != null)
            {
                while (p.GetNext() != null)
                {
                    x = p.GetNext().GetValue();

                    if (x == k)
                    {
                        p.SetNext(p.GetNext().GetNext());
                        break;
                    }

                    p = p.GetNext();
                }
            }

        }
        public static void DelAllFromList(Node<int> p, int k) // task 8
        {
            // פעולה המקבלת רשימה ומספר ובודקת האם מספר מופיע ומוחקת את כל הפעמים שמופיע 
            int x;
            if (p != null)
            {
                while (p.GetNext() != null)
                {
                    x = p.GetNext().GetValue();

                    if (x == k)
                    {
                        p.SetNext(p.GetNext().GetNext());
                    }
                    else
                        p = p.GetNext();
                }
            }

        }
        public static void InserToList(Node<int> p, int k) // task 9
        {
            //מקבלת רשימה ומספר ומכניסה את המספר המתקבל לרשימה
            Node<int> p_new;
            int x;
            if (p != null)
            {
                while (p.GetNext() != null)
                {
                    x = p.GetNext().GetValue();

                    if (k < x)
                    {
                        p_new = new Node<int>(k);
                        p_new.SetNext(p.GetNext());
                        p.SetNext(p_new);
                        break;
                    }

                    p = p.GetNext();
                }
            }


        }
        public static Node<int> SortList(Node<int> p) // task 10
        {
            // מקבלת רשימה ומחזירה את הרשימה בצורה הממויינת שלה
            Node<int> p_temp = new Node<int>(int.MaxValue);
            p_temp.SetNext(CloneList(p));

            Node<int> first = null, last = null;
            int min;

            while (p_temp.GetNext() != null)
            {
                min = MinList(p_temp);

                if (first == null)
                {
                    first = new Node<int>(min);
                    last = first;
                }
                else
                {
                    last.SetNext(new Node<int>(min));
                    last = last.GetNext();
                }

                DelFromList(p_temp, min);



            }
            return first;
        }
        public static Node<int> JoinSortedLists(Node<int> p1, Node<int> p2) //task 11
        {
            // מקבלת שתי רשימות ממיוינות וומחזירה רשימה ממוינת אחת של האיחוד שלהן
            Node<int> first = null, last = null;
            Node<int> p_temp;
            int x;

            while (p1 != null || p2 != null)
            {

                if (p1 == null)
                {
                    p_temp = p2;
                    p2 = p2.GetNext();
                }
                else if (p2 == null)
                {
                    p_temp = p1;
                    p1 = p1.GetNext();
                }

                else
                {
                    if (p1.GetValue() < p2.GetValue())
                    {
                        p_temp = p1;
                        p1 = p1.GetNext();
                    }
                    else
                    {
                        p_temp = p2;
                        p2 = p2.GetNext();
                    }
                }

                x = p_temp.GetValue();
                if (first == null)
                {
                    first = new Node<int>(x);
                    last = first;
                }

                else
                {

                    last.SetNext(new Node<int>(x));
                    last = last.GetNext();
                }


            }

            return first;


        }
        public static Node<int> OddList(Node<int> p)//task 12 
        {
            // הפעולה מקבלת רשימה ומחזזירה רשימה חדשה המכילה רק את המספרים האי זוגיים
            Node<int> first = null, last = null;
            int x;
            while (p != null)
            {
                x = p.GetValue();
                if (x % 2 != 0)
                {
                    if (first == null)
                    {
                        first = new Node<int>(x);
                        last = first;
                    }
                    else
                    {

                        last.SetNext(new Node<int>(x));
                        last = last.GetNext();
                    }
                }
                p = p.GetNext();

            }
            return first;
        }
        public static Node<int> NegitiveFirstList(Node<int> p) // task 13
        {
            // פעולה המקבלת רשימה ומחזירה רשימה חדשה שכל המזספרים השליליים נמצאים בתחילה, והחיוביים אחרי
            Node<int> firstneg = null, lastneg = null;
            Node<int> firstpos = null, lastpos = null;

            int x;
            while (p != null)
            {
                x = p.GetValue();
                if (x < 0)
                {
                    if (firstneg == null)
                    {
                        firstneg = new Node<int>(x);
                        lastneg = firstneg;
                    }
                    else
                    {

                        lastneg.SetNext(new Node<int>(x));
                        lastneg = lastneg.GetNext();
                    }
                }
                else
                {
                    if (firstpos == null)
                    {
                        firstpos = new Node<int>(x);
                        lastpos = firstpos;
                    }
                    else
                    {
                        lastpos.SetNext(new Node<int>(x));
                        lastpos = lastpos.GetNext();
                    }
                }
                p = p.GetNext();
            }
            if (firstneg == null)
                return firstpos;
            else
            {
                lastneg.SetNext(firstpos);
                return firstneg;
            }

        }
        public static Node<int> FlipList(Node<int> p) // task 14
        {
            // פעולה המקבלת רשימה ומחזירה רשימה עם כל האיברים בסדר ההפוך
            Node<int> first = null, last = null;
            int x;
            while (p != null)
            {
                x = p.GetValue();
                if (first == null)
                {
                    first = new Node<int>(x);
                    last = first;
                }
                else
                {
                    first = new Node<int>(x, first);
                }

                p = p.GetNext();
            }

            return first;
        }
        public static bool IsPoliList(Node<int> p) // task 15
        {
            // פעולה המקבלת רשימה ובודקת האם הרשימה היא פולינדרום
            Node<int> p_temp = FlipList(p);
            while (p_temp != null)
            {
                if (p.GetValue() != p_temp.GetValue())
                {
                    return false;
                }
                p = p.GetNext();
                p_temp = p_temp.GetNext();

            }
            return true;
        }
        public static Node<int> UniqueValuesList(Node<int>p) // task 16
        {
            // פעולה המקבלת רשימה ומחזירה רשימה חדשה המכילה את הרשימה המקורית ללא חזרות של מספרים
            Node<int> first = null, last = null;
            int x;

            while (p != null)
            {
                x = p.GetValue();
                
                if(!IsInList(first, x))
                {
                    if (first == null)
                    {
                        first = new Node<int>(x);
                        last = first;
                    }
                    else
                    {
                        last.SetNext(new Node<int>(x));
                        last = last.GetNext();
                    }
                }

                p = p.GetNext();

            }
            return first;
        }
        public static bool IsListList(Node<int>p1,Node<int>p2) // task 17
        {
            // פעולה המקבלת שתי רשימות ומחזירה האם הרשימה הראשונה מוכלת בתוך הרשימה השנייה
            int x1;
            
            while (p1!=null)
            {
                x1 = p1.GetValue();

                if(!IsInList(p2,x1))
                {
                   return false;
                }
                p1 = p1.GetNext();
            }
            return true;
        }
        public static int MaxListR(Node<int>p) // task 18
        {
            // פעולה רקורסיבית המחזירה את הערך הגבוה היותר ברשימה
            if (p != null && p.GetNext() == null)
            {
                return p.GetValue();
            }
            else
            {
                int max = MaxListR(p.GetNext());
                if (p.GetValue() > max)
                {
                    return p.GetValue();
                }
                else
                    return max;
            }

        }
        public static int SumListR(Node<int> p) // task 19
        {
            // פעולה רקורסיבית המחזירה את סכום הערכים ברשימה
            if (p != null && p.GetNext() == null)
            {
                return p.GetValue();
            }
            else
            {
                int sum = SumListR(p.GetNext());
                return p.GetValue() + sum;
            }
        }
        public static int LenListR(Node<int> p) // task 20
        {
            // פעולה רקורסיבית המחזירה את מספר האיברים ברשימה
            if (p == null )
            {
                return 0;
            }
            else
            {
                return LenListR(p.GetNext()) + 1;
            }
        }
    }
}

