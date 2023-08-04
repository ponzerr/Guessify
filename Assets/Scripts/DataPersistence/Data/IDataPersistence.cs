using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence
{
	int index { get; }
	void LoadData(LevelData data);
	
	void SaveData(ref LevelData data);
}
