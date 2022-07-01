using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

//do not call on this class
public class SaveSystem
{
	public void SaveLocation(PlayerMovement playerMovement)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/player.Location";
		FileStream stream = new FileStream(path, FileMode.Create);

		SavePlayerLocation data = new SavePlayerLocation(playerMovement);

		formatter.Serialize(stream, data);
		stream.Close();
	}

	public void SavePickups(PickUpObject pickUp)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/player.Pickupobjects";
		FileStream stream = new FileStream(path, FileMode.Create);

		SaveItems data = new SaveItems(pickUp);

		formatter.Serialize(stream, data);
		stream.Close();
	}

	public void SaveSettings(SettingsMenu settings)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/player.Settings";
		FileStream stream = new FileStream(path, FileMode.Create);

		SaveSettings data = new SaveSettings (settings);

		formatter.Serialize(stream, data);
		stream.Close();
	}

	public PickUpObject LoadLocation()
	{
		string path = Application.persistentDataPath + "/player.Pickupobjects";
		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);

			PickUpObject data = formatter.Deserialize(stream) as PickUpObject;
			stream.Close();

			return data;
		}
		else
		{
			return null;
		}
	}

	public PlayerMovement LoadPickups()
	{
		string path = Application.persistentDataPath + "/player.Location";
		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);

			PlayerMovement data = formatter.Deserialize(stream) as PlayerMovement;
			stream.Close();

			return data;
		}
		else
		{
			return null;
		}
	}

	public SettingsMenu LoadSettings()
	{
		string path = Application.persistentDataPath + "/player.Settings";
		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);

			SettingsMenu data = formatter.Deserialize(stream) as SettingsMenu;
			stream.Close();

			return data;
		}
		else
		{
			return null;
		}
	}
}
