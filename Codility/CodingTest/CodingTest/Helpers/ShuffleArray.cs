using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.Helpers
{
    public static class ShuffleArray
    {
        private static Random random = new Random();

        public static List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = random.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }
            return randomList;
        }

        public static void ShuffleList<E>(IList<E> list)
        {
            if (list.Count > 1)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    E tmp = list[i];
                    int randomIndex = random.Next(i + 1);
                    //Swap elements
                    list[i] = list[randomIndex];
                    list[randomIndex] = tmp;
                }
            }
        }

        // https://www.exceptionnotfound.net/understanding-the-fisher-yates-card-shuffling-algorithm/
        public static void FisherYates1()
        {
            // O(n^2)
            Random r = new Random();

            List<char> unshuffledLetters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            List<char> shuffledLetters = new List<char>();

            //Step 1: For each remaining unshuffled letter
            for (int n = unshuffledLetters.Count; n > 0; n--)
            {
                //Step 2: Randomly select one of the remaining unshuffled letters
                int k = r.Next(n);

                //Step 3: Place the selected letter in the shuffled collection
                char temp = unshuffledLetters[k];
                shuffledLetters.Add(temp);

                //Step 4: Remove the selected letter from the unshuffled collection
                unshuffledLetters.RemoveAt(k);
            }
        }

        public static void FisherYates2()
        {
            // O(n)
            Random r = new Random();
            List<char> unshuffledLetters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };

            //Step 1: For each unshuffled item in the collection
            for (int n = unshuffledLetters.Count - 1; n > 0; --n)
            {
                //Step 2: Randomly pick an item which has not been shuffled
                int k = r.Next(n + 1);

                //Step 3: Swap the selected item with the last "unstruck" letter in the collection
                char temp = unshuffledLetters[n];
                unshuffledLetters[n] = unshuffledLetters[k];
                unshuffledLetters[k] = temp;
            }
        }

        public static void ShuffleSort()
        {
            var cards = Enumerable.Range(0, 51);
            var shuffledcards = cards.OrderBy(a => Guid.NewGuid());
        }
    }
}
