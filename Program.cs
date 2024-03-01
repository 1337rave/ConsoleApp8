using System;

class Store
{
    // Property for store area
    public double Area { get; private set; }

    // Class constructor
    public Store(double area)
    {
        Area = area;
    }

    // Method to increase store area
    public void IncreaseArea(double value)
    {
        Area += value;
    }

    // Overloaded operator + to increase store area
    public static Store operator +(Store store, double value)
    {
        store.Area += value;
        return store;
    }

    // Overloaded operator - to decrease store area
    public static Store operator -(Store store, double value)
    {
        store.Area -= value;
        return store;
    }

    // Overloaded operator == to check equality of store areas
    public static bool operator ==(Store store1, Store store2)
    {
        return store1.Area == store2.Area;
    }

    // Overloaded operator != to check inequality of store areas
    public static bool operator !=(Store store1, Store store2)
    {
        return store1.Area != store2.Area;
    }

    // Overloaded operator < to compare store areas
    public static bool operator <(Store store1, Store store2)
    {
        return store1.Area < store2.Area;
    }

    // Overloaded operator > to compare store areas
    public static bool operator >(Store store1, Store store2)
    {
        return store1.Area > store2.Area;
    }

    // Overridden Equals method for object comparison
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Store other = (Store)obj;
        return this.Area == other.Area;
    }

    // Overridden GetHashCode method for use with Equals
    public override int GetHashCode()
    {
        return Area.GetHashCode();
    }

    // Main method to demonstrate class usage
    public static void Main(string[] args)
    {
        // Creating two stores with specified areas
        Store store1 = new Store(100);
        Store store2 = new Store(150);

        // Increasing area of the first store by 50 using the + operator
        store1 += 50;

        // Displaying the area of the first store
        Console.WriteLine("Area of the first store: " + store1.Area);

        // Checking equality of store areas
        if (store1 == store2)
        {
            Console.WriteLine("Store areas are equal.");
        }
        else
        {
            Console.WriteLine("Store areas are not equal.");
        }

        // Comparing stores by area
        if (store1 > store2)
        {
            Console.WriteLine("First store has a larger area.");
        }
        else if (store1 < store2)
        {
            Console.WriteLine("Second store has a larger area.");
        }
        else
        {
            Console.WriteLine("Stores have the same area.");
        }
    }
}
