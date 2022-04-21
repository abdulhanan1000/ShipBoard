1.	string[,] arr2d = new string [10,10];
2.	char[] yaxisMatchingLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
3.	char[] yaxisMatchingNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
4.	char yaxis = '-';
5.	char zaxis = '-';
6.	
7.	static void initializeArr(string[,] arr2d)
8.	{
9.	    for (int i = 0; i < 10; i++)
10.	    {
11.	        for (int j = 0; j < 10; j++)
12.	        {
13.	            arr2d[i, j] = "A";
14.	        }
15.	    }
16.	}
17.	 
18.	for(int i = 0; i < 10; i++)
19.	{
20.	    for(int j = 0; j < 10; j++)
21.	    {
22.	        arr2d[i, j] = "A";
23.	    }
24.	}
25.	 
26.	while (true)
27.	{
28.	    Console.WriteLine("Enter where you want to place a ship");
29.	    string shipPosition = Console.ReadLine();
30.	    for (int i = 0; i < yaxisMatchingLetters.Length; i++)
31.	    {
32.	        if (shipPosition[0] == yaxisMatchingLetters[i])
33.	        {
34.	            yaxis = yaxisMatchingNumbers[i];
35.	        }
36.	    }
37.	 
38.	 
39.	    int xaxis = shipPosition[1];
40.	    for (int i = 0; i < 10; i++)
41.	    {
42.	        for (int j = 0; j < 10; j++)
43.	        {
44.	            if ((yaxis - '0') == i && (xaxis - '0') == j)
45.	            {
46.	                arr2d[i, j] = "X";
47.	            }
48.	        }
49.	    }
50.	    Console.WriteLine("    0   1   2   3   4   5   6   7   8   9");
51.	    Console.WriteLine("  +---+---+---+---+---+---+---+---+---+---+");
52.	    for (int i = 0; i < 10; i++)
53.	    {
54.	        for (int j = 0; j < 10; j++)
55.	        {
56.	            if (j == 0)
57.	            {
58.	                Console.Write(yaxisMatchingLetters[i]);
59.	            }
60.	            if (arr2d[i, j] == "A")
61.	            {
62.	                Console.Write(" |  ");
63.	            }
64.	            else
65.	            {
66.	                Console.Write(" | " + arr2d[i, j]);
67.	 
68.	            }
69.	 
70.	        }
71.	        Console.WriteLine(" |\n  +---+---+---+---+---+---+---+---+---+---+");
72.	    }
73.	 
74.	}
75.	 
