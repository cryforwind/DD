//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace DD
{
	public class Hit
	{
		static int ID_COUNT = 0;
		public int damage {get;set;}
		public int ID {get;private set;}

		public object Attacker {get;set;}

		public Hit(int damage,object attacker){
			this.Attacker = attacker;
			ID = ID_COUNT++;
		}
	}
}
