using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameSettings : MonoBehaviour 
{
	public bool useCustomControls=true;

	public CustomControls customControls;

	[System.Serializable]
	public class CustomControls
	{
		//mouse
		public KeyCode fire;//fire = Game.instance.settings.controls.fire;
		public KeyCode zoom;//zoom = Game.instance.settings.controls.zoom;
		//movement
		public KeyCode jump;//jump = Game.instance.settings.controls.jump;
		public KeyCode sprint;//sprint = Game.instance.settings.controls.sprint;
		public KeyCode moveForward;//moveForward = Game.instance.settings.controls.moveForward;
		public KeyCode moveBack;//moveBack = Game.instance.settings.controls.moveBack;
		public KeyCode strafeLeft;//strafeLeft = Game.instance.settings.controls.strafeLeft;
		public KeyCode strafeRight;//strafeRight = Game.instance.settings.controls.strafeRight;
		//actions
		public KeyCode crouch;//crouch = Game.instance.settings.controls.crouch;
		public KeyCode reload;//reload = Game.instance.settings.controls.reload;
		public KeyCode fireMode;//fireMode = Game.instance.settings.controls.fireMode;
		public KeyCode holsterWeapon;//holsterWeapon = Game.instance.settings.controls.holsterWeapon;

		public KeyCode use;
		public KeyCode enterBulletTime;
		public KeyCode torch;
		public KeyCode switchView;

		//pause menus
		public KeyCode inventory;
		public KeyCode objectives;
		public KeyCode map;

		//new
		public KeyCode bike;
		public KeyCode customize;
	}

	public int difficulty;
	public CustomControls controls;

	void Awake()
	{
		difficulty = PlayerPrefs.GetInt ("Difficulty");

		if (useCustomControls) 
		{
			if (DoesExist ()) 
			{
				Read ();
			} 
			else 
			{
				Write ();
			}
		}
	}

	public void Write()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath+"/controlsv2.dat");
		bf.Serialize(file,controls);
		file.Close();
	}

	public void Read()
	{
		if(File.Exists(Application.persistentDataPath+"/controlsv2.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath+"/controlsv2.dat",FileMode.Open);
			controls = (CustomControls)bf.Deserialize(file);
			file.Close();
		}
	}

	public bool DoesExist()
	{
		if(File.Exists(Application.persistentDataPath+"/controlsv2.dat"))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
