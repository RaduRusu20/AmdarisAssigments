using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public abstract class Plane
    {
        protected string planeId;
        protected int totalEnginePower;

        public Plane(string planeId, int totalEnginePower)
        {
            this.planeId = planeId;
            this.totalEnginePower = totalEnginePower;   
        }

        public string PlaneId { get { return planeId; } }

        public int TotalEnginePower { get { return totalEnginePower; } }

        public void fly()
        {
            Console.WriteLine(this.planeId + " fly");
        }

        //overriding method
        public override string ToString()
        {
            return "Plane: " + this.planeId + " , total engine power: " + this.totalEnginePower;
        }
       
    }

    public abstract class FightPlane : Plane
    {
        public object Clone { get; internal set; }

        public FightPlane(string planeId, int totalEnginePower) : base(planeId, totalEnginePower)
        {
        }

        public void launchMissile()
        {
            Console.WriteLine(this.planeId + " - Initiating missile launch procedure - Acquiring target - Launching missile - Breaking away - Missile launch complete");
        }

        public virtual void highSpeedGeometry() { }
        public virtual void normalGeometry() { }  

        //method overloading
        public virtual void refuel() { }
        public virtual void refuel(int x) { }


    }

    public abstract class PassengerPlane : Plane
    {
        protected int maxPassengers;

        public PassengerPlane(string planeId, int totalEnginePower, int maxPassengers) : base(planeId, totalEnginePower)
        {
            this.maxPassengers = maxPassengers;
        }

        //properties (getter + setter)
        public int MaxPassengers { get{return maxPassengers;} set { maxPassengers = value; } }


        public virtual void goSuperSonic() { }
        public virtual void goSubSonic() { }

       
    }

    public class Boeing : PassengerPlane
    {
        public Boeing(string planeId, int totalEnginePower, int maxPassengers) : base(planeId, totalEnginePower, maxPassengers)
        {
        }


    }

    public class Concorde : PassengerPlane
    {
        public Concorde(string planeId, int totalEnginePower, int maxPassengers) : base(planeId, totalEnginePower, maxPassengers)
        {
        }

        public override void goSuperSonic()
        {
            Console.WriteLine(this.planeId + " - Supersonic mode activated");
        }

        public override void goSubSonic()
        {
            Console.WriteLine(this.planeId + "- Supersonic mode deactivated");
        }
    }

    public class Mig: FightPlane
    {
        public Mig(string planeId, int totalEnginePower) : base(planeId, totalEnginePower)
        {

        }

        public override void highSpeedGeometry()
        {
            Console.WriteLine(this.planeId + " - High speed geometry selected");
        }

        public override void normalGeometry()
        {
            Console.WriteLine(this.planeId + " - Normal geometry selected");
        }
    }

    //implement ICloneable
    public class TomCat : FightPlane, ICloneable
    {
        public TomCat(string planeId, int totalEnginePower) : base (planeId, totalEnginePower)
        {
        }

        public object Clone()
        {
            return new TomCat(this.planeId, this.totalEnginePower);
        }

        public override void refuel()
        {
            Console.WriteLine(this.planeId + " - Initiating refueling procedure - Locating refueller - Catching up -Refueling - Refueling complete");
        }

        public override void refuel(int x)
        {
            Console.WriteLine("Refuel with {0} liters.", x);
        }
    }

    //implement Ienumerable + IEnumerator

    public class PlaneEnumerator : IEnumerator
    {
        private PlaneCollection planeCollection;
        private int indx;

        public PlaneEnumerator(PlaneCollection planeCollection)
        {
            this.planeCollection = planeCollection;
            indx = -1;
        }

        public Plane Current =>  planeCollection[indx];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            return ++indx < planeCollection.Count();
        }

        public void Reset()
        {
            indx = -1;
        }
    }

    public class PlaneCollection : IEnumerable<Plane>
    {

        public List<Plane> planeList = new List<Plane>();  

        public void add(Plane p)
        {
            planeList.Add(p);
        }
        public IEnumerator<Plane> GetEnumerator()
        {
            return planeList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Plane this[int indx] => planeList[indx];
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PassengerPlane p = new Boeing("123wq", 2000, 100);
            Console.WriteLine(p.PlaneId);
            Console.WriteLine(p.TotalEnginePower);

            PassengerPlane q = new Concorde("222rt", 2500, 170);
            q.goSubSonic();
            q.goSuperSonic();

            FightPlane f = new Mig("333er", 1000);
            f.launchMissile();  
            f.highSpeedGeometry();
            f.normalGeometry();

            FightPlane h = new TomCat("123qw", 900);
            h.refuel();
            h.refuel(50);
            h.launchMissile();
            h.fly();

            

            PlaneCollection pc = new PlaneCollection();
            pc.add(p);
            pc.add(q);
            pc.add(f);
            pc.add(h);


            var enumerator = pc.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            TomCat tc = new TomCat("111", 890);

            var x = tc.Clone();

            Console.WriteLine(x);

        }
    }
}