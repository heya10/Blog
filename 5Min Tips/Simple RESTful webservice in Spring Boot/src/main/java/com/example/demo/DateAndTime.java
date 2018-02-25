package com.example.demo;

import java.time.LocalDate;
import java.time.LocalTime;

class DateAndTime{
	
	LocalDate dateNow;
	LocalTime timeNow;
	
	DateAndTime(){
		dateNow = LocalDate.now();
		timeNow = LocalTime.now();
	}

	public LocalDate getDateNow() {
		return dateNow;
	}

	public void setDateNow(LocalDate dateNow) {
		this.dateNow = dateNow;
	}

	public LocalTime getTimeNow() {
		return timeNow;
	}

	public void setTimeNow(LocalTime timeNow) {
		this.timeNow = timeNow;
	}	
	
}
