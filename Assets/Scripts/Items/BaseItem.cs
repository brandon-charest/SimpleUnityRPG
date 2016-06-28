﻿using UnityEngine;
using System.Collections;

[System.Serializable] //tells compiler that this class is serializable
public class BaseItem {

	private string itemName;
	private string itemDescription;

	private int itemID;

	public enum ItemTypes
	{
		EQUIPMENT, WEAPON, SCROLL, POSTION, CHEST
	}

	private ItemTypes itemType;

	public string ItemName { get; set; }
	public string ItemDescription { get; set; }
	public int ItemID { get; set; }
	public ItemTypes ItemType { get; set; }
}
