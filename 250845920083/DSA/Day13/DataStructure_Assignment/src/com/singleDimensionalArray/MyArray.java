package com.singleDimensionalArray;

public class MyArray {

	
	public int addArrayDigit(int [] arr)
	{
	int sum=0;
	for(int i =0;i<arr.length;i++)
	{
		
		sum=sum+arr[i];
		System.out.println("Sum of Digits" + sum);
	}
	return sum;
	}
	
	public static int sumOfDigits(int num) 
	{
	        num = Math.abs(num);
	        int sum = 0;
	        while (num > 0) {
	            sum += num % 10;
	            num /= 10;
	        }
	        return sum;
	    }
	
	public int[] PrimeFact(int[] arr) {
	    int[] temp = new int[arr.length];
	    for (int i = 0; i < arr.length; i++) {
	        if (isPrime(arr[i])) {
	            temp[i] = factorial(arr[i]);
	            System.out.println("Prime: " + arr[i] + ", Factorial: " + temp[i]);
	        } else {
	            temp[i] = 0; 
	        }
	    }
	    return temp;
	}

	public boolean isPrime(int num) {
	    if (num <= 1) return false;
	    for (int j = 2; j <= Math.sqrt(num); j++) {
	        if (num % j == 0) return false;
	    }
	    return true;
	}

	public int factorial(int num) {
	    int fact = 1;
	    for (int k = 2; k <= num; k++) {
	        fact *= k;
	    }
	    return fact;
	}

	
	public int MaxPrime(int [] arr)
	{
		int max=Integer.MIN_VALUE;
		for(int i=0;i<arr.length;i++)
		{
			if(arr[i] % 2 != 0)
			{
				if(max<arr[i])
				{
					max=arr[i];
				}
			}
		}
		System.out.println("Max prime number is " + max);
		return max;
	}
//	public void MaxPrime(int [] arr)
//	{
//		int max=Max(arr);
//		System.out.println("Maximum number is "+ max);
//			if(max % 2!=0)
//			{
//				System.out.println(max + " Number is prime");
//			}
//			else
//			{
//				System.out.println(max + " Number is not prime");
//			}
//	}
	
	
}

