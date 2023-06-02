using UnityEngine;
using UnityEngine.UI;

public class CustomControls : MonoBehaviour 
{
	public bool listening=false;
	private string oldText="";
	private string newText="";
	private Text targetText;

	private string targetKey="";

	public OrganoSphereGameMenuUI menu;
	new public FlashLight light;
	public EnableInventory inventory;

	public Text[] texts;

	public Text invertMouseText;

	public bool mainMenu = false;

	public void SetInvertMouse()
	{
		if (PlayerPrefs.GetInt ("invertMouse") == 0) 
		{
			PlayerPrefs.SetInt ("invertMouse", 1);
			if (!mainMenu) Game.instance.playerScript.FPSWalkerComponent.SmoothMouseLookComponent.inverted = true;
			invertMouseText.text = "INVERT MOUSE : <color=\"#84FF00\">ON</color>";
			return;
		}

		if (PlayerPrefs.GetInt ("invertMouse") == 1) 
		{
			PlayerPrefs.SetInt ("invertMouse", 0);
			if (!mainMenu) Game.instance.playerScript.FPSWalkerComponent.SmoothMouseLookComponent.inverted = false;
			invertMouseText.text = "INVERT MOUSE : <color=\"#84FF00\">OFF</color>";
		}
	}

	public void OnEnable()
	{
		texts [0].text = "FORWARD : " + "<color=\"#84FF00\">" + Game.instance.settings.controls.moveForward.ToString()+"</color>";
		texts [1].text = "BACK : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.moveBack.ToString()+"</color>";
		texts [2].text = "LEFT : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.strafeLeft.ToString()+"</color>";
		texts [3].text = "RIGHT : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.strafeRight.ToString()+"</color>";
		texts [4].text = "JUMP/TAKE ALL : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.jump.ToString()+"</color>";
		texts [5].text = "CROUCH : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.crouch.ToString()+"</color>";
		texts [6].text = "INTERACT/PICKUP : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.use.ToString()+"</color>";
		texts [7].text = "RELOAD : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.reload.ToString()+"</color>";
		texts [8].text = "TORCH : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.torch.ToString()+"</color>";
		texts [9].text = "ADRENALINE/BULLET TIME : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.enterBulletTime.ToString()+"</color>";
		texts [10].text = "SPRINT/RUN : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.sprint.ToString()+"</color>";
		texts [11].text = "INVENTORY : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.inventory.ToString()+"</color>";
		texts [12].text = "SWITCH SCOPE : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.holsterWeapon.ToString()+"</color>";
		texts [13].text = "FIRE WEAPON : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.fire.ToString()+"</color>";
		texts [14].text = "ZOOM/SCOPE : " +  "<color=\"#84FF00\">" + Game.instance.settings.controls.zoom.ToString()+"</color>";
		texts [15].text = "CUSTOMIZE WEAPON : " + "<color=\"#84FF00\">" + Game.instance.settings.controls.customize.ToString() + "</color>";
		texts [16].text = "SPAWN VEHICLE : " + "<color=\"#84FF00\">" + Game.instance.settings.controls.bike.ToString() + "</color>";
	}

	public void EditForward(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "FORWARD : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "fwd";
	}

	public void EditBack(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "BACK : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "back";
	}

	public void EditLeft(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "LEFT : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "left";
	}

	public void EditRight(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "RIGHT : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "right";
	}

	public void EditJump(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "JUMP/TAKE ALL : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "jump";
	}

	public void EditCrouch(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "CROUCH : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "crouch";
	}

	public void EditUse(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "INTERACT/PICKUP : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "use";
	}

	public void EditReload(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "RELOAD : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "reload";
	}

	public void EditTorch(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "TORCH : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "torch";
	}

	public void EditAdrenaline(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "ADRENALINE/BULLET TIME : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "slowmo";
	}

	public void EditSprint(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "SPRINT/RUN : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "sprint";
	}

	public void EditInventory(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "INVENTORY : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "inventory";
	}

	public void EditHolster(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "SWITCH SCOPE : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "holster";
	}

	public void EditFire(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "FIRE WEAPON : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "fire";
	}

	public void EditZoom(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "ZOOM/SCOPE : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "zoom";
	}

	public void EditCustomize(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "CUSTOMIZE WEAPON : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "customize";
	}

	public void EditBike(Text ui)
	{
		oldText = ui.text;
		listening = true;
		newText = "SPAWN VEHICLE : ";
		ui.text = "PRESS NEW KEY";
		targetText = ui;
		targetKey = "bike";
	}

	public void UpdateKey(KeyCode key)
	{
		if (targetKey == "fwd")
			Game.instance.settings.controls.moveForward = key;
			
		if (targetKey == "back")
			Game.instance.settings.controls.moveBack = key;

		if (targetKey == "left")
			Game.instance.settings.controls.strafeLeft = key;

		if (targetKey == "right")
			Game.instance.settings.controls.strafeRight = key;

		if (targetKey == "jump")
			Game.instance.settings.controls.jump = key;

		if (targetKey == "crouch")
			Game.instance.settings.controls.crouch = key;

		if (targetKey == "use")
			Game.instance.settings.controls.use = key;

		if (targetKey == "reload")
			Game.instance.settings.controls.reload = key;

		if (targetKey == "torch")
			Game.instance.settings.controls.torch = key;

		if (targetKey == "slowmo")
			Game.instance.settings.controls.enterBulletTime = key;

		if (targetKey == "sprint")
			Game.instance.settings.controls.sprint = key;

		if (targetKey == "inventory")
			Game.instance.settings.controls.inventory = key;

		if (targetKey == "holster")
			Game.instance.settings.controls.holsterWeapon = key;

		if (targetKey == "fire")
			Game.instance.settings.controls.fire = key;

		if (targetKey == "zoom")
			Game.instance.settings.controls.zoom = key;

		if (targetKey == "customize")
			Game.instance.settings.controls.customize = key;

		if (targetKey == "bike")
			Game.instance.settings.controls.bike = key;

		if (!mainMenu) Game.instance.playerScript.ResetControls ();
		if (!mainMenu) Game.instance.playerScript.FPSWalkerComponent.ResetControls ();

		PickupTrigger[] triggers = FindObjectsOfType<PickupTrigger>();

		foreach (PickupTrigger trigger in triggers) 
		{
			trigger.Start ();
		}

		if (!mainMenu) light.Start ();

		if (!mainMenu) inventory.Start ();

		if (!mainMenu) Game.instance.settings.Write ();
	}

	void Update () 
	{
		if (listening) 
		{
			if (Input.GetKeyDown (KeyCode.Escape)) 
			{
				targetText.text = oldText;
				listening = false;
				return;
			}

			foreach(KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
			{
				if(Input.GetKeyDown(vKey))
				{
					KeyCode key = vKey;

					if (key != KeyCode.Escape) 
					{
						if (targetKey == "back")
							Game.instance.settings.controls.moveBack = key;

						if (targetKey == "left")
							Game.instance.settings.controls.strafeLeft = key;

						if (targetKey == "right")
							Game.instance.settings.controls.strafeRight = key;

						if (targetKey == "jump")
							Game.instance.settings.controls.jump = key;

						if (targetKey == "crouch")
							Game.instance.settings.controls.crouch = key;

						if (targetKey == "use")
							Game.instance.settings.controls.use = key;

						if (targetKey == "reload")
							Game.instance.settings.controls.reload = key;

						if (targetKey == "torch")
							Game.instance.settings.controls.torch = key;

						if (targetKey == "slowmo")
							Game.instance.settings.controls.enterBulletTime = key;

						if (targetKey == "sprint")
							Game.instance.settings.controls.sprint = key;

						if (targetKey == "inventory")
							Game.instance.settings.controls.inventory = key;

						if (targetKey == "holster")
							Game.instance.settings.controls.holsterWeapon = key;

						if (targetKey == "fire")
							Game.instance.settings.controls.fire = key;

						if (targetKey == "zoom")
							Game.instance.settings.controls.zoom = key;

						targetText.text = newText + "<color=\"#84FF00\">" + vKey.ToString () + "</color>";
						UpdateKey (key);
						listening = false;
						return;

					} 
				}
			}
		}
	}
}
