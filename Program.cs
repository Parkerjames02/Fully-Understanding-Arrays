// This line creates an array of integers with a capacity of 10 values.
// It's important to note that the capacity of an array is different from the length.
// Arrays are fixed in size so the capacity of an array is indicative of how many
// values it can hold onto.
int[] intArray = new int[10];

// This line creates an integer value called length and sets it to the value of 0.
// This value will be used when trying to look at the true length of the array rather
// than the capacity. This variable will be indicative of the number of values that
// are being stored in the array.
int length = 0;

// In order to properly test adding or deleting values from an array we should first
// fill the array with some standard values starting with the 1 and ending with 8.
// I will use a for loop to iterate through the array while also storing values in
// each cell of the array that incrementally get larger by 1.

// For Loop Iterator Explanation:

// At the beginning of the for loop an integer called "i" is created and set to the
// value of 0. It's important to note that this integer value called "i" is exclusively
// used by this for loop and won't conflict with other "i" integers that is created and
// used in other for loops. When the for loops completes it's cycle, the "i" integer
// value will be deleted so that it can be created and used again for another.

// Then, after the "i" integer is created and set to 0, it is compared to 8. As long
// as i is less than (<) 8, the for loop will continue. With each iteration of this
// loop, i is increased by 1 so this for loop will loop 8 times.
for (int i = 0; i < 7; i++)
{
    // This line is how the values are set in the array. The "intArray[length]" part
    // just defines where in the array the new value will go. As you can see the
    // "length" variable is being used to select the cell which is why the length
    // is increased by 1 each loop. The value in that sell is then set to the integer
    // "i" plus 1 so that the array doesn't start with 0. 
    intArray[length] = i + 1;
    // This line is responsible for increasing the length variable by 1.
    length++;
}

// Now that we have created the array, a variable to keep track of the length of the
// array, and a for loop that will insert values 1-8 into the array we can test out
// inserting and deleting values from the array.

// How To Insert A Value At The End Of An Array:

// The length variable is set to 8 at this point so "intArray[length]" is referring
// to the 8th cell of the array. That cell is then set to the value of 9 to continue
// the count of numbers that initially stopped at 8.
intArray[length] = 8;
// When adding a value to an array it's really important to update the length variable
// so that it's value is accurate to the actual length of the array. Since we inserted
// the value of 8 at the end of the array the length of the array is now 8.
length++;

// How To Insert A Value At The Start Of An Array:

// This for loop will start at the end of the array (cell 8) and move the value from
// the previous cell to the current cell and goes through the whole array until all
// of the values have shifted by one cell besides the first value. If we are looking
// at an array that goes from left to right then then this for loop is starting at the
// end on the right and shifting each value by 1 cell to the right.
for (int i = 7; i >= 0; i--)
{
    // This line is responsible for looking at the furthest cell of the array that has
    // a value (7) and then looking at the next cell or the first cell without a value
    // (8). The "intArray[i + 1]" is responsible for pointing at the 8th cell because
    // it's "7 + 1". Then, the 8th cell is being set to the value in the 7th cell. Each
    // iteration or loop lowers the value of i by 1 so all of the values are shifted
    // except for the first value of the array.
    intArray[i + 1] = intArray[i];
}

// This is the line that inserts the new value at the beginning of the array. This line
// points to the first cell of the array (0) and sets it to the value 0. 
intArray[0] = 0;

// Just like with all of the other insert methods it's important to make sure that the
// length variable is accurate to the actual length of the array. Since we inserted the
// value of 0 to the beginning of the array the length of the array is now 9.
length++;

// How To Insert A Value Anywhere In An Array:

// This for loop is a lot like the for loop in the previous insert method but with some
// small changes. The variable "i" is set to 8 so the shift in values will start with
// the value that is in cell 8 or, in other words, the last cell in the array to
// actually have a value. This means that cell 9 will now hold the value of 8,
// cell 8 will hold the value of 7, etc. This will happen until the "i" variable is no
// longer more than or equal to 2. This means that the only values that don't get
// shifted are the values in cell 0 and 1. Since we don't need the duplicate value in
// cell 2 we can insert a new value into the array while also keeping all of the other
// values that have been put into the array. This new value will be in cell 2 which is
// in between cell 1 and cell 3.
for (int i = 8; i >= 2; i--)
{
    // This line does the exact same thing as the last one did in the previous for loop.
    // It points to cell 6, sets the value in cell 6 to the value of in cell 5 (5), and
    // does that for all of the cell except for cells 0 and 1.
    intArray[i + 1] = intArray[i];
}

// This line points at cell 2 of the array which holds the duplicate value that we don't
// need. Since cell 2 has the same value as cell 3 (2) then we can replace the value in
// cell 2 to something completely different. This line points at the third cell of the
// array (cell 2) and sets it to 12.
intArray[2] = 12;

// Just like with all of the other insert methods it's important to make sure that the
// length variable is accurate to the actual length of the array. Since we inserted the
// value of 12 into cell 2 of the array the length of the array is now 10.
length++;

// How To Delete The Value At The End Of An Array:

// From my understanding, you can't actually remove a value from an array like you can
// in other programming languages so, instead, we can manipulate the length of the array
// so that only the values that we want to keep track of are kept within the length
// variable. This line takes the length variable (which is equal to 10 currently and
// subtracts it by 1 to make it 9.
length--;

// Now if we use the length value to iterate through the array and print it to the
// console only the first 9 values of the array will be printed. This means that the
// value of cell 9 (8) will be excluded from the print of the whole array.
for (int i = 0; i < length; i++)
{
    // This just prints each value in the array to the console. It starts with the value
    // in the first cell (0) and then moves on to printing the value in the next cell.
    // This loop continues until the variable "i" is equal to 9 or, in other words,
    // not bigger than the length variable which we set to 9.
    Console.WriteLine(intArray[i]);
}

// How To Delete The Value At The Beginning Of An Array:

// This for loop is for shifting all of the values in the array to the left by 1 cell.
// In other words, the value in cell 1 will move to cell 0, the value in cell 2 will
// move to the value in cell 1, etc. Since the length variable is currently set to 9 
// only the first 8 values will get shifted because the variable "i" needs to be bigger
// than the length in order to continue the loop.
for (int i = 1; i < length; i++)
{
    // The first iteration of this loop will point at the first cell of the array (0)
    // and set it to the value of the second cell (1). This loop will inclemently do
    // this until the integer variable "i" is equal to 9, or, in other words, equal to
    // the length variable which is also 9.
    intArray[i - 1] = intArray[i];
}

// This line then shortens the length variable by 1. Since we moved all of the variables
// to the left the first value has been removed but there is a duplicate value in the
// array at cell 8. After the previous for loop cells 7 and 8 will both have the value
// of 7 so we need to shorten the length by 1 so that we can only print the first 8
// values of the array.
length--;

// This for loop is just like the previous for loop that printed the values of the
// array. The only difference is that the length variable is now 8 instead of 9 and the
// first value of the array (0) has been deleted. The values that do get printed start
// at 1 and end with 7.
Console.WriteLine("");
for (int i = 0; i < length; i++)
{
    Console.WriteLine(intArray[i]);
}

// How To Delete A Value Anywhere In An Array:

// Because there is a value of twelve in the second cell (1) I want to remove that value
// and so that the series of numbers are in order counting up in increments of 1. To do
// this this for loop will first point towards the 2nd cell (1) where the value is 12
// and set it to the value of cell 2 (2). This continues until all of the values that
// are in the cells after the 2nd cell have been shifted to the left of the array.
for (int i = 2; i < length; i++)
{
    intArray[i - 1] = intArray[i];
}

// We once again shorten the length variable by 1 because there is another duplicate
// variable at the end.
length--;

// The array is once again printed to show all of the values of the array from 1 to 7.
Console.WriteLine("");
for (int i = 0; i < length; i++)
{
    Console.WriteLine(intArray[i]);
}

// Searching For A Value In An Array With Linear Search:

// Now that we have created an array, inserted values into the array, and deleted
// values lets try using an algorithm to search for a value in the array. Linear
// searches are the easiest search algorithm and very commonly used in real world
// environments. It works by first iterating through the array with a for loop and
// then using an if statement to see if the value that is currently being looked at
// is the value that we are searching for.

// This is a bool function so it has to have the return type of true or false. This
// bool function is called LinearSearch and takes in our intArray and an integer
// variable called key. The key variable represents the value that we are searching
// for in the array.
bool LinearSearch(int[] intArray, int key)
{
    // This for loop iterates through array to the extent of the length variable (7).
    for (int i = 0; i < length; i++)
    {
        // This if statement compares each variable of the array to the key. If the
        // variable that we are searching for or the key is found in the array then
        // true will be returned to the console.
        if (intArray[i] == key)
        {
            return true;
        }
    }
    // This return false condition will only happen if the function iterates
    // through the whole array and never fulfills the condition of one of the
    // values of the array being equal to the key variable or the variable that
    // we are searching for.
    return false;
}

// This line not only calls the function but it also writes the result of the
// function to the console. This is also where we put our array and key value into
// the function as arguments.
Console.WriteLine(LinearSearch(intArray, 5));