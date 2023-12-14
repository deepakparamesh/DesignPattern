namespace Com.DeepakParamesh
{
    public class Observable
    {
        private List<Observer> observers = new List<Observer>();
        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers(int value)
        {
            foreach(var observer in observers)
            {
                observer.update(value);
            }
        }
    }

    public class DataSource : Observable
    {
        private int value;

        public int getValue()
        {
            return value;
        }

        public void setValue(int value)
        {
            this.value = value;
            notifyObservers(value);
        }
    }

    public interface Observer
    {
        public void update(int value);
    }

    public class SpreadSheet : Observer
    {
        public void update(int value)
        {
            Console.WriteLine("Spreadsheet got notified: " + value);
        }
    }

    public class Chart : Observer
    {
        public void update(int value)
        {
            Console.WriteLine("Chart got notified: " + value);
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Observables
            DataSource newDataSource = new();
            
            // Observers
            SpreadSheet sheet1 = new();
            SpreadSheet sheet2 = new();
            Chart chart1 = new();

            newDataSource.addObserver(sheet1);
            newDataSource.addObserver(sheet2);
            newDataSource.addObserver(chart1);

            newDataSource.setValue(1);
        }
    }
}