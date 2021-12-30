using System;
using System.Collections.Generic;
using System.IO;

namespace Data{
	[Serializable]
	//Star Wars BattleFront II troop
	class MyData{
	public String type {get; set;}
	public int level {get; set;}
	public String skin {get; set;}
	public String weapon {get; set;}
	public List<String> cards {get; set;}
	public void PrintValue(){
		Console.WriteLine("your data type is " + type);
		Console.WriteLine("your data level is " + level);
		Console.WriteLine("your data skin is " + skin);
		Console.WriteLine("your data weapon is " + weapon);
		foreach (var card in cards){
			Console.WriteLine(card + " is your card");
		}
	}
	public void WriteValue(string path){
		using (StreamWriter writer = new StreamWriter(path)){
			writer.WriteLine(type);
			writer.WriteLine(level);
			writer.WriteLine(skin);
			writer.WriteLine(weapon);
			foreach (var card in cards){
			writer.WriteLine(card);
			}
			writer.Close();
		}
	}
	public MyData(){}
	}
}
