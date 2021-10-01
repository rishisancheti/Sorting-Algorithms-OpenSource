public class SelectionSort {
    public static void selectionSort (int [] myList){

        for (int i = 0; i < myList.length - 1; i++){
            int min = myList[i];
            int indexMin = i;

            for(int j = i + 1; j < myList.length; j++){
                if(min > myList[j]){
                    min = myList[j];
                    indexMin = j;
                }
            }
            if(indexMin != i){
                myList[indexMin] = myList [i];
                myList[i] = min;
            }
        }

    }

    public static void main(String args []){

        int myArray [] = {22, 34, 18, 10, 42, 56, 68, 29, 77, 56};
        SelectionSort.selectionSort(myArray);

        for (int i = 0; i < myArray.length; i++){
            System.out.print(myArray[i] + " ");
        }


    }
}
