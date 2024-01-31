using System;

namespace StopWatchExample
{
    class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        
        public DateTime StartTime { get { return startTime; } }
        public DateTime EndTime { get { return endTime; } }

        public StopWatch()
        {
            startTime = DateTime.Now;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public long GetElapsedTime()
        {
            TimeSpan elapsed = endTime - startTime;
            return (long)elapsed.TotalMilliseconds;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the StopWatch
            StopWatch stopwatch = new StopWatch();

            // Generate an array of 100,000 random numbers
            int[] numbers = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next();
            }

            // Measure the execution time of selection sort algorithm
            stopwatch.Start();
            SelectionSort(numbers);
            stopwatch.Stop();

            // Output the elapsed time
            Console.WriteLine("Elapsed Time (ms): " + stopwatch.GetElapsedTime());
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
