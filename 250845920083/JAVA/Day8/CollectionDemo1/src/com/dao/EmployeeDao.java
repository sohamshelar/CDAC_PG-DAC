package com.dao;
import java.util.List;

import com.beans.*;
public interface EmployeeDao {

	boolean save(Employee e);

	List<Employee> findAll();

	Employee findById(int eid);

	boolean removeById(int eid);

	List<Employee> findByName(String nm);

}
