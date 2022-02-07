package com.aekmot.demo.models.dao;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.repository.CrudRepository;

import com.aekmot.demo.models.entity.Cliente;

public interface IClienteDao extends JpaRepository<Cliente, Long>{
	
}
