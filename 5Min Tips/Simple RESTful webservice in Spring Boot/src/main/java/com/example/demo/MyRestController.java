package com.example.demo;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class MyRestController {
	
	@RequestMapping(value="/date-and-time")
	public DateAndTime getDataAndTime() {
		return new DateAndTime();
	}
	
}