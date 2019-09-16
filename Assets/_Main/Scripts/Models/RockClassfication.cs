using System.Collections;
using System.Collections.Generic;


public class RockClassfication{

	private string name;
	private string description;

	public RockClassfication(string name, string description){
		this.name = name;
		this.description = description;
	}

	public string GetName(){
		return name;
	}

	public string GetDescription(){
		return description;
	}
}
