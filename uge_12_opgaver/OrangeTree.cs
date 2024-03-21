

namespace uge_12_opgaver
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age 
        { 
            get { return age; } 
            set 
            {  
                if (value >= 0)
                {
                    age = value;
                } else
                {
                    Console.WriteLine("Age must be a positive number!");
                    age = 0;
                }
                 
            } 
        }
        public int Height { get { return height; } set {  height = value; } }
        public bool TreeAlive { get {  return treeAlive; } set {  treeAlive = value; } }
        public int NumOranges { get {  return numOranges; } }
        public int OrangesEaten { get { return  orangesEaten; } }

        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}

        //public int GetAge()
        //{
        //    return this.age;
        //}

        //public void SetHeight(int height) 
        //{
        //    this.height = height;
        //}

        //public int GetHeight()
        //{
        //    return this.height;
        //}

        //public void SetTreeAlive(bool treeAlive) 
        //{
        //    this.treeAlive = treeAlive;
        //}

        //public bool GetTreeAlive() 
        //{ 
        //    return this.treeAlive;
        //}

        //public int GetNumOranges()
        //{
        //    return this.numOranges;
        //}

        //public int GetOrangesEaten()
        //{
        //    return this.orangesEaten;
        //}

        public void OneYearPasses()
        {
            this.age++;
                       
            if (this.age > 1)
            {
                this.numOranges += 5;
            }
            if (this.age >= 80)
            {
                this.TreeAlive = false;
                this.numOranges = 0;
            } else
            {
                this.height += 2;
            }
        }

        public void EatOrange(int count)
        {
            if (count <= this.numOranges)
            {
                this.numOranges -= count;
                this.orangesEaten += count;
            }
            else
            {
                Console.WriteLine($"There is only {this.numOranges} oranges on the tree! Wait another Year.");
                              
            }

        }

        

        




    }
}
