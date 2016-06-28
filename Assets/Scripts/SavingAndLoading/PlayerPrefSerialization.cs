using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class PlayerPrefSerialization {

	public static BinaryFormatter binaryFormatter = new BinaryFormatter();

	//obj needs to be able to be serialized,
	//converting to 1's & 0's
	public static void Save(string saveTag, object obj)
	{
		MemoryStream memoryStream = new MemoryStream();
		//serialize the object
		binaryFormatter.Serialize(memoryStream, obj);
		//binary from serialization gets stored in string temp
		string temp = System.Convert.ToBase64String(memoryStream.ToArray());
		PlayerPrefs.SetString(saveTag, temp);
	}

	public static object Load(string saveTag)
	{
		string temp = PlayerPrefs.GetString(saveTag);
		//check if string is empty
		if(temp == string.Empty)
		{
			return null;
		}
		//preparing memory stream for deserialization
		MemoryStream memoryStream = new MemoryStream(System.Convert.FromBase64String(temp));
		return binaryFormatter.Deserialize(memoryStream);
	}
}
