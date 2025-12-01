package com.demo.test;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.cfg.Configuration;

import com.demo.beans.MyUser;
import com.demo.beans.Product;

public class TestMyuser {

	public static void main(String[] args) {
		SessionFactory sf=new Configuration().configure().buildSessionFactory();
		Session session=sf.openSession();
		Transaction tr=session.beginTransaction();
		MyUser u1=new MyUser(3,"Rushi","rushi@gmail.com");
		MyUser u2=new MyUser(4,"Aditya","adi@gmail.com");
		Product p1=new Product("lays2",29,85);
		Product p2=new Product("nachos3",28,253);
		session.save(u1);
		session.save(u2);
		session.save(p1);
		session.save(p2);
		tr.commit();
		session.close();
		sf.close();

	}

}

