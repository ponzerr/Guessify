using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class DataPersistenceManager : MonoBehaviour
{
	[Header("File Storage Config")]
	
	[SerializeField] private string fileName;

	private GameData gameData;

	public GameData data => gameData;
	
    public static DataPersistenceManager instance {get; private set;}


	
	private List<IDataPersistence> dataPersistenceObjects;
	
	private FileDataHandler dataHandler;
	
	private void Awake()
	{
		if (instance != null)
		{
			Debug.LogError("Found more than one Data Persistence Manager in the scene.");
		}
		instance = this;
	}
	
	private void Start()
	{
		Debug.Log(Application.persistentDataPath); 
		this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
		this.dataPersistenceObjects = FindAllDataPersistenceObjects();
		LoadGame();
	}


	public void NewGame()
	{
		this.gameData = new GameData();
	}
	
	public void LoadGame()
	{
		this.gameData = dataHandler.Load();
		
		if (this.gameData == null)
		{
			Debug.Log("No Data was found. Initializing data to defaults.");
			NewGame();
		}
		
		foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects)
		{
			dataPersistenceObj.LoadData(gameData.GetLevel(dataPersistenceObj.index));
		}
		
	}
	
	public void SaveGame()
	{
		dataPersistenceObjects = FindAllDataPersistenceObjects();
		foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects)
		{
			var leveldata = gameData.GetLevel(dataPersistenceObj.index);
			dataPersistenceObj.SaveData(ref leveldata);
			gameData.SetLevel(dataPersistenceObj.index, leveldata);
			Debug.Log("SavingStars");
        }
		
		dataHandler.Save(gameData);
	}
	
	private void OnApplicationQuit()
	{
		SaveGame();
	}
	
	private List<IDataPersistence> FindAllDataPersistenceObjects()
	{
		IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();
		
		return new List<IDataPersistence>(dataPersistenceObjects);
		
	}
}
