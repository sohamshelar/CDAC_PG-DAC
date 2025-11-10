package com.Test;

import com.Hashing.MyHashTable;

public class TestMyHashTable {

	public static void main (String[] args)
	{
		MyHashTable ht=new MyHashTable(5);
		ht.insertData(41);
		ht.insertData(48);
		ht.insertData(6);
		ht.insertData(4);
		ht.insertData(8);
		ht.insertData(54);
		ht.insertData(85);
		ht.insertData(79);
		ht.insertData(56);
		ht.insertData(81);
		ht.insertData(94);
		ht.insertData(83);
		ht.displayHashTable();
		ht.searchData(79);
		ht.searchData(1001);
	}

}
