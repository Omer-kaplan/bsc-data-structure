// --------------------------------------------------------------------------------------------------------------------
    // Eden Ezra, Omer Kaplan 208278036
    
    // random a 30 heights between 1-100 and sets to array as buildings(height, index) [ NICE TO HAVE buildings[], results[] ]
    // set a stack of buildings with functions pop, push, isEmpty, top?
    // write a function that gets the array, runs from the last index
    // if last place -> insert to stack else checks the height of current building vs the top() in the stuck
    // if heigher -> set in result[stack.top(building.index)]  = i; stack.pop(); stack.push(buildings[i]);
// --------------------------------------------------------------------------------------------------------------------

using System;
   
class Targil2 {
    public class Building {
        int height;
        int index;
    }
    
    public class Stack {
        Building[] stack = new Building [50];
        int stackTopIndex = 0;
        bool isEmptyBool = true;
        
        push(item){
            if(this.top != 50){
                // insert into array
                // isEmptyBool = false
            }
            else {
                // Throw error of overflow
            }
        }
        pop() {
            if !(isEmpty())
                // Delete item
                // if index == 0 -> isEmptyBool=true;
            else{
                // Error underflow    
            }
        }
        isEmpty() {
            return isEmptyBool;
        }
        top() {
            // use the stackTopIndex
        }
    }
    
    public Building[] initBuildingAraay(Building[] buildings){
	for (int i = 0; i < 30; ++i) // O(n) initialize buildings array
    	{
        // tmpHeight = random 1-100, set buildings[i].height = tmpHeight && 
        // buildings[i].index = i;
    	}
	return buildings;
    }

    public static sortArrays(Building[] buildings, int[] results )
    {
	for (int j = 29; i >= 0; j--) // O(n) foreach building compares to stack building height
        {
        // if j==29 -> stack.push(buildings[j]); && j--;
        // if buildings[j].height < stack.top().height --> stack.push
        // else while !stack.isEmpty && flag { if buildings[j].height >  stack.top().height: 
        // results [stack.top().index] = j && stack.pop && !flag
        }
    }

  static void Main() {
    int[] results = new int [30]; // already initialized to 0,0,...0
    Building[] buildings = new Building [30]; // the main array to check
    
	// initBuildingAraay(buildings);
	// sortArrays(buildings,results);

    // Print array O(n) again
  } // sums 3O(n) == O(n)
}