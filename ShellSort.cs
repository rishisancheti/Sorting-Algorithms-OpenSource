// C# implementation of ShellSort
using System;

class ShellSort
{
	/* An utility function to
	print array of size n*/
	static void printArray(int []arr)
	{
		int n = arr.Length;
		for (int i=0; i<n; ++i)
		Console.Write(arr[i] + " ");
		Console.WriteLine();
	}

	/* function to sort arr using shellSort */
	int sort(int []arr)
	{
		int n = arr.Length;

		// Start with a big gap,
		// then reduce the gap
		for (int gap = n/2; gap > 0; gap /= 2)
		{
			// Do a gapped insertion sort for this gap size.
			// The first gap elements a[0..gap-1] are already
			// in gapped order keep adding one more element
			// until the entire array is gap sorted
			for (int i = gap; i < n; i += 1)
			{
				// add a[i] to the elements that have
				// been gap sorted save a[i] in temp and
				// make a hole at position i
				int temp = arr[i];

				// shift earlier gap-sorted elements up until
				// the correct location for a[i] is found
				int j;
				for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
					arr[j] = arr[j - gap];

				// put temp (the original a[i])
				// in its correct location
				arr[j] = temp;
			}
		}
		return 0;
	}

	// Driver method
	public static void Main()
	{
		int []arr = {12, 34, 54, 2, 3};
		Console.Write("Array before sorting :\n");
		printArray(arr);

		ShellSort ob = new ShellSort();
		ob.sort(arr);

		Console.Write("Array after sorting :\n");
		printArray(arr);
	}

	//shellsort in java
	static void printArray(int arr[])
    {
        int n = arr.length;
        for (int i=0; i<n; ++i)
            System.out.print(arr[i] + " ");
        System.out.println();
    }

    /* function to sort arr using shellSort */
    int sort(int arr[])
    {
        int n = arr.length;

        // Start with a big gap, then reduce the gap
        for (int gap = n/2; gap > 0; gap /= 2)
        {
            // Do a gapped insertion sort for this gap size.
            // The first gap elements a[0..gap-1] are already
            // in gapped order keep adding one more element
            // until the entire array is gap sorted
            for (int i = gap; i < n; i += 1)
            {
                // add a[i] to the elements that have been gap
                // sorted save a[i] in temp and make a hole at
                // position i
                int temp = arr[i];

                // shift earlier gap-sorted elements up until
                // the correct location for a[i] is found
                int j;
                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    arr[j] = arr[j - gap];

                // put temp (the original a[i]) in its correct
                // location
                arr[j] = temp;
            }
        }
        return 0;
    }

    // shellsort in java

		class ShellSort{

    public static void Array(int arr[])
    {
        int n = arr.length;
        for (int i=0; i<n; ++i)
            System.out.print(arr[i] + " ");
        System.out.println();
    }

    /* function to sort arr using shellSort */
    int sort(int arr[])
    {
        int n = arr.length;


        for (int dis = n/2; dis > 0; dis/= 2)
        {

            for (int i = dis; i < n; i += 1)
            {
                int temp = arr[i];

                int j;
                for (j = i; j >= dis && arr[j - dis] > temp; j -= dis)
                    arr[j] = arr[j - dis];

                arr[j] = temp;
            }
        }
        return 0;
    }
    public static void main(String args[])
    {
        int arr[] = {2, 3, 5, 2, 9};
        System.out.println("Array before sorting");
        Array(arr);

        ShellSort ob = new ShellSort();
        ob.sort(arr);

        System.out.println("Array after shell sort");
        Array(arr);
    }
}
