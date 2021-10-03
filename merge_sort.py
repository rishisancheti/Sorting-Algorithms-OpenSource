#  Python program for implementation of Merge Sort

def mergeSort(arr,l,r):
    if(r>l):
        mid = l+(r-l)//2
        mergeSort(arr,l,mid)
        mergeSort(arr,mid+1,r)
        merge(arr,l,mid,r)

def merge(arr,l,m,r):
    l1 = m+1-l
    l2 = r-m
    arr1 = [0 for i in range(l1)]
    arr2 = [0 for i in range(l2)]
    i = 0
    j = 0

    for f in range(l1):
        arr1[f] = arr[l+f]
    for f in range(l2):
        arr2[f] = arr[m+1+f]

    k = l

    while i < l1 and j < l2:
        if(arr1[i]<arr2[j]):
            arr[k] = arr1[i]
            k += 1
            i += 1
        else:
            arr[k] = arr2[j]
            k += 1
            j += 1

    while(i<l1):
        arr[k] = arr1[i]
        i += 1
        k += 1
    while(j<l2):
        arr[k] = arr2[j]
        j += 1
        k += 1

# Driver code to test above
arr = [64, 34, 25, 12, 22, 11, 90]
 
mergeSort(arr,0,len(arr)-1) # Expected Output: [11, 12, 22, 25, 34, 64, 90]
 
print("Sorted array is:",arr)