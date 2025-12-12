package com.demo.JWTSecurityUsingdatabse.security;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import com.demo.JWTSecurityUsingdatabse.beans.MyUser;
import com.demo.JWTSecurityUsingdatabse.dao.LoginDao;

@Service
public class MyUserDetailsService implements UserDetailsService{
	
	@Autowired
	private LoginDao repo;

	@Override
	public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
		MyUser u=repo.findByUname(username);
		System.out.println("in loadbyusername");
		System.out.println(u);
		if(u == null)
			throw new UsernameNotFoundException("User Not Found");
		
		return org.springframework.security.core.userdetails.User
				.withUsername(u.getUname())
				.password(u.getPassword())
				.roles(u.getRole())
				.build();
		
	}
	
	
	

}
