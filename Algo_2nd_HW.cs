using System;

namespace _2020510076_duru_capar_DEU
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Derya", "Elife", "Fatih", "Ali" }; // array of names to be used for high-score table created
            int[] scores = { 120, 115, 110, 105, 100, 95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 45, 40, 35, 30, 25, 20, 15, 10, 5, 0 }; // array of scores to be used for high-score table created
            bool play = true; int i = 0;   // variables assigned         
            string[] array_1 = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            string[] array_2 = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            string[] array_3 = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " }; //  three arrays (A1, A2, and A3) with 15 in size created
            string[] letter = { "D", "E", "U" }; // array of randomly selected letters created

            Console.WriteLine("Please press enter to start the game ^-^");
            Console.ReadLine();
            Console.Clear();




            do // while boolean play is true, the loop runs
            {
                Random random_array = new Random();
                int a = random_array.Next(1, 4);
                Random random_column = new Random();
                int c = random_column.Next(0, 15);
                Random random_letter = new Random();
                int l = random_letter.Next(0, 3);     //random integer a (for choosing arrray), c (for choosing column) and l (for choosing letter) created 

                Console.WriteLine("Player 1: " + "      " + "P1-" + scores[1] + "  P2-" + scores[0]); // game started with player1
                if (a == 1)
                {
                    array_1[c] = letter[l];  // c column at first array is assigned with value of the value at l column at letter array
                    Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                    Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                    Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);
                }
                else if (a == 2)
                {
                    array_2[c] = letter[l]; // c column at second array is assigned with value of the value at l column at letter array
                    Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                    Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                    Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);
                }
                else
                {
                    array_3[c] = letter[l]; // c column at third array is assigned with value of the value at l column at letter array
                    Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                    Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                    Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);
                }
                Console.ReadLine();

                for (int round = 0; round <= 24; round++) // it makes the game run for 24 times
                {

                    Random random_array2 = new Random();
                    int a2 = random_array2.Next(1, 4);
                    Random random_array3 = new Random();
                    int a3 = random_array3.Next(1, 4);

                    Random random_column2 = new Random();
                    int c2 = random_column2.Next(0, 15);
                    Random random_column3 = new Random();
                    int c3 = random_column3.Next(0, 15);

                    Random random_letter2 = new Random();
                    int l2 = random_letter2.Next(0, 3);
                    Random random_letter3 = new Random();
                    int l3 = random_letter3.Next(0, 3);   //random integer a2, a3 (for choosing arrray); c2, c3 (for choosing column) and l2, l3 (for choosing letter) created 


                    Console.WriteLine("Player 2: " + "      " + "P1-" + scores[i + 1] + "  P2- " + scores[i + 1]);
                    if (a2 == 1)
                    {
                        array_1[c2] = letter[l2]; // c2 column at first array is assigned with value of the value at l2 column at letter array
                        Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                        Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                        Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);
                    }
                    else if (a2 == 2)
                    {
                        array_2[c2] = letter[l2]; // c2 column at second array is assigned with value of the value at l2 column at letter array
                        Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                        Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                        Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);
                    }
                    else
                    {
                        array_3[c2] = letter[l2]; // c2 column at third array is assigned with value of the value at l2 column at letter array
                        Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                        Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                        Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);

                    }
                    Console.ReadLine();

                    // player1's turn, value of i variable is increased

                    Console.WriteLine("Player 1: " + "      " + "P1-" + scores[i + 2] + "  P2-" + scores[i + 1]);
                    if (a3 == 1)
                    {
                        array_1[c3] = letter[l3]; // c3 column at first array is assigned with value of the value at l3 column at letter array
                        Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                        Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                        Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);
                    }
                    else if (a3 == 2)
                    {
                        array_2[c3] = letter[l3]; // c3 column at second array is assigned with value of the value at l3 column at letter array
                        Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                        Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                        Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);
                    }
                    else
                    {
                        array_3[c3] = letter[l3]; // c3 column at third array is assigned with value of the value at l3 column at letter array
                        Console.WriteLine("A1 " + array_1[0] + array_1[1] + array_1[2] + array_1[3] + array_1[4] + array_1[5] + array_1[6] + array_1[7] + array_1[8] + array_1[9] + array_1[10] + array_1[11] + array_1[12] + array_1[13] + array_1[14]);
                        Console.WriteLine("A2 " + array_2[0] + array_2[1] + array_2[2] + array_2[3] + array_2[4] + array_2[5] + array_2[6] + array_2[7] + array_2[8] + array_2[9] + array_2[10] + array_2[11] + array_2[12] + array_2[13] + array_2[14]);
                        Console.WriteLine("A3 " + array_3[0] + array_3[1] + array_3[2] + array_3[3] + array_3[4] + array_3[5] + array_3[6] + array_3[7] + array_3[8] + array_3[9] + array_3[10] + array_3[11] + array_3[12] + array_3[13] + array_3[14]);
                    }
                    Console.ReadLine();

                    i++;

                    if ((c3 >= 2 && c3 <= 12)) // Controlled for arrays to stay within bounds
                    {
                        // Winning situations
                        if ((array_1[c3] == letter[0] & array_1[c3 + 1] == letter[1] & array_1[c3 + 2] == letter[2]) || (array_2[c3] == letter[0] & array_2[c3 + 1] == letter[1] && array_2[c3 + 2] == letter[2]) || (array_3[c3] == letter[0] && array_3[c3 + 1] == letter[1] && array_3[c3 + 2] == letter[2]) /* first letter D*/ || (array_1[c3] == letter[1] & array_1[c3 + 1] == letter[2] & array_1[c3 - 1] == letter[0]) || (array_2[c3] == letter[1] & array_2[c3 + 1] == letter[2] && array_2[c3 - 1] == letter[0]) || (array_3[c3] == letter[1] && array_3[c3 + 1] == letter[2] && array_3[c3 - 1] == letter[0])/* first letter E*/ || (array_1[c3] == letter[2] & array_1[c3 - 1] == letter[1] & array_1[c3 - 2] == letter[0]) || (array_2[c3] == letter[2] & array_2[c3 - 1] == letter[1] && array_2[c3 - 2] == letter[0]) || (array_3[c3] == letter[2] && array_3[c3 - 1] == letter[1] && array_3[c3 - 2] == letter[0]) /* first letter U*/)/*DEU*/
                        {
                            Console.WriteLine("Winner is: player1");   //if the winner is player1, player1's score will be on the score table
                            if (scores[i + 1] >= scores[4])
                            {
                                Console.WriteLine("Name" + "       " + "Score");
                                Console.WriteLine("player1" + "      " + scores[i + 1]);
                                Console.WriteLine(names[0] + "       " + scores[4]);
                                Console.WriteLine(names[1] + "       " + scores[5]);
                                Console.WriteLine(names[2] + "       " + scores[6]);
                            }
                            else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                            {
                                Console.WriteLine("Name" + "       " + "Score");
                                Console.WriteLine(names[0] + "       " + scores[4]);
                                Console.WriteLine("player1" + "      " + scores[i + 1]);
                                Console.WriteLine(names[1] + "       " + scores[5]);
                                Console.WriteLine(names[2] + "       " + scores[6]);
                            }
                            else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                            {
                                Console.WriteLine("Name" + "       " + "Score");
                                Console.WriteLine(names[0] + "       " + scores[4]);
                                Console.WriteLine(names[1] + "       " + scores[5]);
                                Console.WriteLine("player1" + "      " + scores[i + 1]);
                                Console.WriteLine(names[2] + "       " + scores[6]);
                            }
                            else if (scores[i + 1] < scores[6])
                            {
                                Console.WriteLine("Name" + "       " + "Score");
                                Console.WriteLine(names[0] + "       " + scores[4]);
                                Console.WriteLine(names[1] + "       " + scores[5]);
                                Console.WriteLine(names[2] + "       " + scores[6]);
                                Console.WriteLine("player1" + "      " + scores[i + 1]);
                            }
                            round = 25;  // to end for loop
                            play = false; // to end while loop
                        }
                        else if ((array_1[c3] == letter[0] && array_1[c3 - 1] == letter[1] && array_1[c3 - 2] == letter[2]) || (array_2[c3] == letter[0] && array_2[c3 - 1] == letter[1] && array_2[c3 - 2] == letter[2]) || (array_3[c3] == letter[0] && array_3[c3 - 1] == letter[1] && array_3[c3 - 2] == letter[2])/* first letter D*/|| (array_1[c3] == letter[1] && array_1[c3 + 1] == letter[0] && array_1[c3 - 1] == letter[2]) || (array_2[c3] == letter[1] && array_2[c3 + 1] == letter[0] && array_2[c3 - 1] == letter[2]) || (array_3[c3] == letter[1] && array_3[c3 + 1] == letter[0] && array_3[c3 - 1] == letter[2])/* first letter E*/ || (array_1[c3] == letter[2] && array_1[c3 + 1] == letter[1] && array_1[c3 + 2] == letter[0]) || (array_2[c3] == letter[2] && array_2[c3 + 1] == letter[1] && array_2[c3 + 2] == letter[0]) || (array_3[c3] == letter[2] && array_3[c3 + 1] == letter[1] && array_3[c3 + 2] == letter[0])/* first letter U*/)/*UED*/
                        {
                            Console.WriteLine("Winner is: player1");   //if the winner is player1, player1's score will be on the score table
                            if (scores[i + 1] >= scores[4])
                            {
                                Console.WriteLine("Name" + "       " + "Score");
                                Console.WriteLine("player1" + "      " + scores[i + 1]);
                                Console.WriteLine(names[0] + "       " + scores[4]);
                                Console.WriteLine(names[1] + "       " + scores[5]);
                                Console.WriteLine(names[2] + "       " + scores[6]);
                            }
                            else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                            {
                                Console.WriteLine("Name" + "       " + "Score");
                                Console.WriteLine(names[0] + "       " + scores[4]);
                                Console.WriteLine("player1" + "      " + scores[i + 1]);
                                Console.WriteLine(names[1] + "       " + scores[5]);
                                Console.WriteLine(names[2] + "       " + scores[6]);
                            }
                            else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                            {
                                Console.WriteLine("Name" + "       " + "Score");
                                Console.WriteLine(names[0] + "       " + scores[4]);
                                Console.WriteLine(names[1] + "       " + scores[5]);
                                Console.WriteLine("player1" + "      " + scores[i + 1]);
                                Console.WriteLine(names[2] + "       " + scores[6]);
                            }
                            else if (scores[i + 1] < scores[6])
                            {
                                Console.WriteLine("Name" + "       " + "Score");
                                Console.WriteLine(names[0] + "       " + scores[4]);
                                Console.WriteLine(names[1] + "       " + scores[5]);
                                Console.WriteLine(names[2] + "       " + scores[6]);
                                Console.WriteLine("player1" + "      " + scores[i + 1]);
                            }
                            round = 25;  // to end for loop
                            play = false; // to end while loop
                        }
                        else if ((array_1[c3] == letter[0] && array_2[c3] == letter[1] && array_3[c3] == letter[2]) || (array_2[c3] == letter[1] && array_1[c3] == letter[0] && array_3[c3] == letter[2]) || (array_3[c3] == letter[2] && array_2[c3] == letter[1] && array_1[c3] == letter[0])  /* DOWNWARDS*/|| (array_1[c3] == letter[2] && array_2[c3] == letter[1] && array_3[c3] == letter[0]) || (array_2[c3] == letter[1] && array_3[c3] == letter[0] && array_1[c3] == letter[2]) || (array_3[c3] == letter[0] && array_2[c3] == letter[1] && array_1[c3] == letter[2])) /* UPWARDS*/)
                        {
                Console.WriteLine("Winner is: player1");   //if the winner is player1, player1's score will be on the score table
                    if (scores[i + 1] >= scores[4])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[6])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                    }
                    round = 25;  // to end for loop
                    play = false; // to end while loop
                }
                        else if ((array_3[c3] == letter[0] && array_2[c3 - 1] == letter[1] && array_1[c3 - 2] == letter[2]) || (array_3[c3 + 1] == letter[0] && array_2[c3] == letter[1] && array_1[c3 - 1] == letter[2]) || (array_3[c3 + 2] == letter[0] && array_2[c3 + 1] == letter[1] && array_1[c3] == letter[2])/*D,E,U UPPER LEFT CROSS*/ || (array_3[c3] == letter[0] && array_2[c3 + 1] == letter[1] && array_1[c3 + 2] == letter[2]) || (array_3[c3 - 1] == letter[0] && array_2[c3] == letter[1] && array_1[c3 + 1] == letter[2]) || (array_3[c3 - 2] == letter[0] && array_2[c3 - 1] == letter[1] && array_1[c3] == letter[2])/* D,E,U UPPER RİGHT CROSS*/)
                {
                    Console.WriteLine("Winner is: player1");   //if the winner is player1, player1's score will be on the score table
                    if (scores[i + 1] >= scores[4])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[6])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                    }
                    round = 25;  // to end for loop
                    play = false; // to end while loop
                }
                else if ((array_1[c3] == letter[0] && array_2[c3 - 1] == letter[1] && array_3[c3 - 2] == letter[2]) || (array_1[c3 + 1] == letter[0] && array_2[c3] == letter[1] && array_3[c3 - 1] == letter[2]) || (array_1[c3 + 2] == letter[0] && array_2[c3 + 1] == letter[1] && array_3[c3] == letter[2])/*D,E,U LOWER LEFT CROSS*/ || (array_1[c3] == letter[0] && array_2[c3 + 1] == letter[1] && array_3[c3 + 2] == letter[2]) || (array_1[c3 - 1] == letter[0] && array_2[c3] == letter[1] && array_3[c3 + 1] == letter[2]) || (array_1[c3 - 2] == letter[0] && array_2[c3 - 1] == letter[1] && array_3[c3] == letter[2])/* D,E,U LOWER RIGHT CROSS*/)
                {
                    Console.WriteLine("Winner is: player1");   //if the winner is player1, player1's score will be on the score table
                    if (scores[i + 1] >= scores[4])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[6])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                    }
                    round = 25;  // to end for loop
                    play = false; // to end while loop
                }
            }

                   else if ((c2 >= 2 && c2 <= 12)) // Controlled for arrays to stay within bounds
            {

                if ((array_1[c2] == letter[0] & array_1[c2 + 1] == letter[1] & array_1[c2 + 2] == letter[2]) || (array_2[c2] == letter[0] & array_2[c2 + 1] == letter[1] && array_2[c2 + 2] == letter[2]) || (array_3[c2] == letter[0] && array_3[c2 + 1] == letter[1] && array_3[c2 + 2] == letter[2]) /* first letter D*/ || (array_1[c2] == letter[1] & array_1[c2 + 1] == letter[2] & array_1[c2 - 1] == letter[0]) || (array_2[c2] == letter[1] & array_2[c2 + 1] == letter[2] && array_2[c2 - 1] == letter[0]) || (array_3[c2] == letter[1] && array_3[c2 + 1] == letter[2] && array_3[c2 - 1] == letter[0])/* first letter E*/ || (array_1[c2] == letter[2] & array_1[c2 - 1] == letter[1] & array_1[c2 - 2] == letter[0]) || (array_2[c2] == letter[2] & array_2[c2 - 1] == letter[1] && array_2[c2 - 2] == letter[0]) || (array_3[c2] == letter[2] && array_3[c2 - 1] == letter[1] && array_3[c2 - 2] == letter[0]) /* first letter U*/)/*DEU*/
                {
                    Console.WriteLine("Winner is: player2");  //if the winner is player2, player1's score will be on the score table
                    if (scores[i + 1] >= scores[4])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[6])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                    }
                    round = 25; // to end for loop
                    play = false; // to end while loop
                }
                else if ((array_1[c2] == letter[0] && array_1[c2 - 1] == letter[1] && array_1[c2 - 2] == letter[2]) || (array_2[c2] == letter[0] && array_2[c2 - 1] == letter[1] && array_2[c2 - 2] == letter[2]) || (array_3[c2] == letter[0] && array_3[c2 - 1] == letter[1] && array_3[c2 - 2] == letter[2])/* first letter D*/|| (array_1[c2] == letter[1] && array_1[c2 + 1] == letter[0] && array_1[c2 - 1] == letter[2]) || (array_2[c2] == letter[1] && array_2[c2 + 1] == letter[0] && array_2[c2 - 1] == letter[2]) || (array_3[c2] == letter[1] && array_3[c2 + 1] == letter[0] && array_3[c2 - 1] == letter[2])/* first letter E*/ || (array_1[c2] == letter[2] && array_1[c2 + 1] == letter[1] && array_1[c2 + 2] == letter[0]) || (array_2[c2] == letter[2] && array_2[c2 + 1] == letter[1] && array_2[c2 + 2] == letter[0]) || (array_3[c2] == letter[2] && array_3[c2 + 1] == letter[1] && array_3[c2 + 2] == letter[0])/* first letter U*/)/*UED*/
                {
                    Console.WriteLine("Winner is: player2");  //if the winner is player2, player1's score will be on the score table
                    if (scores[i + 1] >= scores[4])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[6])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                    }
                    round = 25; // to end for loop
                    play = false; // to end while loop
                }
                else if ((array_1[c2] == letter[0] && array_2[c2] == letter[1] && array_3[c2] == letter[2]) || (array_2[c2] == letter[1] && array_1[c2] == letter[0] && array_3[c2] == letter[2]) || (array_3[c2] == letter[2] && array_2[c2] == letter[1] && array_1[c2] == letter[0])  /* DOWNWARDS*/|| (array_1[c2] == letter[2] && array_2[c2] == letter[1] && array_3[c2] == letter[0]) || (array_2[c2] == letter[1] && array_3[c2] == letter[0] && array_1[c2] == letter[2]) || (array_3[c2] == letter[0] && array_2[c2] == letter[1] && array_1[c2] == letter[2])) /* UPWARDS*/)
                        {
                    Console.WriteLine("Winner is: player2");  //if the winner is player2, player1's score will be on the score table
                    if (scores[i + 1] >= scores[4])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[6])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                    }
                    round = 25; // to end for loop
                    play = false; // to end while loop
                }
                        else if ((array_3[c2] == letter[0] && array_2[c2 - 1] == letter[1] && array_1[c2 - 2] == letter[2]) || (array_3[c2 + 1] == letter[0] && array_2[c2] == letter[1] && array_1[c2 - 1] == letter[2]) || (array_3[c2 + 2] == letter[0] && array_2[c2 + 1] == letter[1] && array_1[c2] == letter[2])/*D,E,U UPPER LEFT CROSS*/ || (array_3[c2] == letter[0] && array_2[c2 + 1] == letter[1] && array_1[c2 + 2] == letter[2]) || (array_3[c2 - 1] == letter[0] && array_2[c2] == letter[1] && array_1[c2 + 1] == letter[2]) || (array_3[c2 - 2] == letter[0] && array_2[c2 - 1] == letter[1] && array_1[c2] == letter[2])/* D,E,U UPPER RİGHT CROSS*/)
                {
                    Console.WriteLine("Winner is: player2");  //if the winner is player2, player1's score will be on the score table
                    if (scores[i + 1] >= scores[4])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[6])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                    }
                    round = 25; // to end for loop
                    play = false; // to end while loop
                }
                else if ((array_1[c2] == letter[0] && array_2[c2 - 1] == letter[1] && array_3[c2 - 2] == letter[2]) || (array_1[c2 + 1] == letter[0] && array_2[c2] == letter[1] && array_3[c2 - 1] == letter[2]) || (array_1[c2 + 2] == letter[0] && array_2[c2 + 1] == letter[1] && array_3[c2] == letter[2])/*D,E,U LOWER LEFT CROSS*/ || (array_1[c2] == letter[0] && array_2[c2 + 1] == letter[1] && array_3[c2 + 2] == letter[2]) || (array_1[c2 - 1] == letter[0] && array_2[c2] == letter[1] && array_3[c2 + 1] == letter[2]) || (array_1[c2 - 2] == letter[0] && array_2[c2 - 1] == letter[1] && array_3[c2] == letter[2])/* D,E,U LOWER RIGHT CROSS*/)
                {
                    Console.WriteLine("Winner is: player2");  //if the winner is player2, player1's score will be on the score table
                    if (scores[i + 1] >= scores[4])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[4] && scores[i + 1] >= scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] >= scores[6] && scores[i + 1] < scores[5])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                    }
                    else if (scores[i + 1] < scores[6])
                    {
                        Console.WriteLine("Name" + "       " + "Score");
                        Console.WriteLine(names[0] + "       " + scores[4]);
                        Console.WriteLine(names[1] + "       " + scores[5]);
                        Console.WriteLine(names[2] + "       " + scores[6]);
                        Console.WriteLine("player1" + "      " + scores[i + 1]);
                    }
                    round = 25; // to end for loop
                    play = false; // to end while loop
                }
            }
            if (scores[i + 1] == scores[24]) // if player1's score is zero,
            {
                Console.WriteLine("Tie");
                Console.WriteLine("      ");
                Console.WriteLine("Name" + "       " + "Score");
                Console.WriteLine(names[0] + "       " + scores[4]);
                Console.WriteLine(names[1] + "       " + scores[5]);
                Console.WriteLine(names[2] + "       " + scores[6]);
                Console.WriteLine(names[3] + "       " + scores[7]);
                round = 25; // to end for loop
                play = false; // to end while loop
            }
        }
    } while (play == true);

            Console.ReadLine();
        }            
    }
}


